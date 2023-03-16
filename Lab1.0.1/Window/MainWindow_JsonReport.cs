using Newtonsoft.Json;
using PC_info.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_info.Models;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {

        private Report.Hardware GetHardwareFromView()
        {
            cpuMutex.WaitOne();
            Report.Hardware.CPU cpu = new Report.Hardware.CPU()
            {
                Name = CPUnamelbl.Text.Trim(),
                NumberOfCores = Int32.Parse(CPUnumberOfCoreslbl.Text.Split(' ')[3]),
                LoadPercentage = Double.Parse(CPUpercentage.Text.Remove(CPUpercentage.Text.Length - 1, 1))
            };
            cpuMutex.ReleaseMutex();

            ramMutex.WaitOne();
            Report.Hardware.RAM ram = new Report.Hardware.RAM()
            {
                TotalAmountGB = Double.Parse(RAMsizelbl.Text.Remove(RAMsizelbl.Text.Length - 2, 2).Split(' ')[2]),
                LoadPercentage = Double.Parse(RAMpercentage.Text.Remove(RAMpercentage.Text.Length - 1, 1))
            };
            ramMutex.ReleaseMutex();

            List<Report.Hardware.DISK> disks = new List<Report.Hardware.DISK>();
            foreach (DataGridViewRow row in DISKgrid.Rows)
            {
                disks.Add(new Report.Hardware.DISK()
                {
                    Name = row.Cells[0].Value.ToString(),
                    Size = row.Cells[1].Value.ToString(),
                });
            }

            return new Report.Hardware()
            {
                CPU_ = cpu,
                RAM_ = ram,
                DISKs_ = disks
            };
        }

        private Report.Antivirus GetAntivirusFromView()
        {
            string[] antivirusStrings = AntivirusInfoLbl.Text.Split('\n');
            Report.Antivirus antivirus = new Report.Antivirus()
            {
                IsInstalled = antivirusStrings.Length == 3,
                Name = antivirusStrings.Length == 3 ? antivirusStrings[0].Split('(', ')')[1] : null,
                State = antivirusStrings.Length == 3 ? antivirusStrings[1].Remove(0, 7) : null,
                GUID = antivirusStrings.Length == 3 ? antivirusStrings[2].Remove(0, 6) : null
            };

            return antivirus;
        }

        private async Task<Report.OS> GetAntivirusFromViewAsync()
        {
            string[] osStrings = OSInfoLbl.Text.Split('\n');
            Report.OS os = new Report.OS()
            {
                Name = osStrings[0].Remove(0, 6),
                Version = osStrings[1].Remove(0, 9),
                Status = osStrings[2].Remove(0, 8),
            };

            await updatesSemaphore.WaitAsync();
            List<Report.OS.Update> updates = new List<Report.OS.Update>();
            foreach (DataGridViewRow row in OSupdatesGrid.Rows)
                updates.Add(new Report.OS.Update()
                {
                    Title = row.Cells[0].Value.ToString(),
                    IsInstalled = Boolean.Parse(row.Cells[1].Value.ToString()),
                    isDownloaded = Boolean.Parse(row.Cells[2].Value.ToString()),
                });
            updatesSemaphore.Release();

            os.SoftwareUpdates = updates;

            return os;
        }


        private Report.Firewall GetFirewallFromView()
        {
            string[] firewallStrings = FirewallInfoLbl.Text.Split('\n');
            Report.Firewall firewall = new Report.Firewall()
            {
                ProfileType = firewallStrings[0].Remove(0, 14),
                IsEnabled = Boolean.Parse(firewallStrings[1].Remove(0, 18))
            };

            List<Report.Firewall.Port> ports = new List<Report.Firewall.Port>();
            foreach (DataGridViewRow row in FirewallPortsGrid.Rows)
                ports.Add(new Report.Firewall.Port()
                {
                    PortNumber = row.Cells[0].Value.ToString(),
                    IpVersion = row.Cells[1].Value.ToString()
                });

            List<Report.Firewall.Application> apps = new List<Report.Firewall.Application>();
            foreach (DataGridViewRow row in FirewallAppsGrid.Rows)
                apps.Add(new Report.Firewall.Application()
                {
                    Name = row.Cells[0].Value.ToString(),
                    IpVersion = row.Cells[1].Value.ToString()
                });

            firewall.GloballyOpenPorts = ports;
            firewall.AuthorizedApplications = apps;

            return firewall;
        }

        private async void JsonReportBttn_ClickAsync(object sender, EventArgs e)
        { 
            tabControl.Focus();
            try
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "json files (*.json)|*.json";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFileDialog1.OpenFile())
                    {
                        if (stream != null)
                        {
                            using (StreamWriter writer = new StreamWriter(stream))
                            {
                                Report report = new Report();

                                report.Hardware_ = GetHardwareFromView();
                                report.Antivirus_ = GetAntivirusFromView();
                                report.OS_ = await GetAntivirusFromViewAsync();
                                report.Firewall_ = GetFirewallFromView();

                                string serializedReport = JsonConvert.SerializeObject(report, Formatting.Indented);

                                await writer.WriteAsync(serializedReport);

                                MetroFramework.MetroMessageBox.Show(this, "", "Report is saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
