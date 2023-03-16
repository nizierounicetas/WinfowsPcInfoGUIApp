using PC_info.Customed_Elements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {
        private void timer_Tick(object sender, EventArgs e)
        {
            cpuMutex.WaitOne();
            float cpuLoad = CPUcounter.NextValue();
            CPUpb.Value = (int)cpuLoad;
            CPUpercentage.Text = String.Format("{0:0.00}%", cpuLoad);
            cpuMutex.ReleaseMutex();

            ramMutex.WaitOne();
            float ramLoad = RAMcounter.NextValue();
            RAMpb.Value = (int)ramLoad;
            RAMpercentage.Text = String.Format("{0:0.00}%", ramLoad);
            ramMutex.ReleaseMutex();
        }

        private void InitCPUInfo()
        {
            ManagementObjectCollection instances = new ManagementObjectSearcher("select * from Win32_Processor").Get();

            foreach (ManagementObject instance in instances)
            {
                CPUnamelbl.Text = instance["Name"].ToString();
                CPUnumberOfCoreslbl.Text = String.Format($"Number of cores: {instance["NumberOfCores"]}");
            }
        }

        private void InitRAMInfo()
        {
            ManagementObjectCollection instances = new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get();

            foreach (ManagementObject instance in instances)
            {
                RAMsizelbl.Text = String.Format($"Total Amount: {Convert.ToDouble(instance["TotalPhysicalMemory"]) / BITS_IN_GB:0.00} GB");
            }
        }

        private void InitDISKInfo()
        {

            DISKgrid.Columns.Add("nameClmn", "Name");
            DISKgrid.Columns[0].Width = 120;

            DataGridViewDiskSizeGBProgressColumn sizeColumn = new DataGridViewDiskSizeGBProgressColumn();
            sizeColumn.HeaderText = "Size";
            sizeColumn.Width = 180;

            DISKgrid.Columns.Add(sizeColumn);

            DISKInfoRefresh();
        }


        private void DISKrefreshBttn_Click(object sender, EventArgs e)
        {
            DISKlbl.Focus();
            try
            {
                DISKInfoRefresh();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DISKInfoRefresh()
        {
            DISKgrid.Rows.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                DISKgrid.Rows.Add(d.Name + d.VolumeLabel, new SizeGB(Convert.ToDouble(d.TotalSize) / BITS_IN_GB, d.AvailableFreeSpace / BITS_IN_GB));
            }
        }
    }

}
