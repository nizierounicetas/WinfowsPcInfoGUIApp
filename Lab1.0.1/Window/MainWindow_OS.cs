using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUApiLib;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {
        private void InitOSInfo()
        {

            ManagementObjectCollection instances = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get();
            foreach (ManagementObject instance in instances)
            {
                OSInfoLbl.Text = $""""
                    Name: {instance["Caption"]} {instance["OSArchitecture"]}
                    Version: {instance["Version"]}
                    Status: {instance["Status"]}
                    """";
            }
        }

        private void InitUpdatesInfo()
        {
            UpdateSession uSession = new UpdateSession();
            IUpdateSearcher uSearcher = uSession.CreateUpdateSearcher();
            uSearcher.Online = false;

            ISearchResult sResult = uSearcher.Search("Type='Software'");
            foreach (IUpdate update in sResult.Updates)
            {
                OSupdatesGrid.Rows.Add(update.Title, update.IsInstalled, update.IsDownloaded);
            }
        }

        private async void OSrefreshBttn_ClickAsync(object sender, EventArgs e)
        {
            SoftwareUpdatesLbl.Focus();

            OSupdatesGrid.Rows.Clear();
            try
            {
                await updatesSemaphore.WaitAsync();
                OSupdatesGrid.Enabled = false;
                await Task.Run(InitUpdatesInfo);
                OSupdatesGrid.Enabled = true;
                updatesSemaphore.Release();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void OSInfoUpdateBttn_Click(object sender, EventArgs e)
        {
            OSInfoLbl.Focus();
            try
            {
                InitOSInfo();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
