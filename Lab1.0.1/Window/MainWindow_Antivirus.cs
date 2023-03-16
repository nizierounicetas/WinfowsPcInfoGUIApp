using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {
        private void InitAntivirusInfo()
        {
            ManagementObjectCollection instances = new ManagementObjectSearcher(@"root\SecurityCenter2", "SELECT * FROM AntiVirusProduct").Get();

            AntivirusInfoLbl.Text = $"Antivirus installed: {instances.Count > 0}";
            foreach (ManagementObject instance in instances)
            {
                AntivirusInfoLbl.Text += $" ({instance["displayName"]})";

                int state = Convert.ToInt32(instance["productState"]);
                string stateString;
                antivirusStates.TryGetValue(state, out stateString);
                AntivirusInfoLbl.Text += $"\nState: {state}";

                if (stateString != null)
                    AntivirusInfoLbl.Text += $" ({stateString})";

                AntivirusInfoLbl.Text += $"\nGUID: {instance["instanceGuid"]}";
            }

        }

        private void AntivirusRefreshBttn_Click(object sender, EventArgs e)
        {
            AntivirusInfoLbl.Focus();

            try
            {
                InitAntivirusInfo();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
