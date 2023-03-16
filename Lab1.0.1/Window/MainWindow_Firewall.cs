using Microsoft.TeamFoundation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {
        private void InitFirewallInfo()
        {
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr manager = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);

            FirewallInfoLbl.Text = $""""
                Profile type: {manager.CurrentProfileType}
                Firewall enabled: {manager.LocalPolicy.CurrentProfile.FirewallEnabled}
                """";

            foreach (INetFwOpenPort port in manager.LocalPolicy.CurrentProfile.GloballyOpenPorts)
                FirewallPortsGrid.Rows.Add($"{port.Port} ({port.Name})", port.IpVersion);

            foreach (INetFwAuthorizedApplication app in manager.LocalPolicy.CurrentProfile.AuthorizedApplications)
                FirewallAppsGrid.Rows.Add(app.Name, app.IpVersion);
        }

        private void FirewallPortsRefreshBttn_Click(object sender, EventArgs e)
        {
            FirewallOpenPortsLbl.Focus();
            FirewallPortsGrid.Rows.Clear();

            try
            {
                Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
                INetFwMgr manager = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);

                foreach (INetFwOpenPort port in manager.LocalPolicy.CurrentProfile.GloballyOpenPorts)
                    FirewallPortsGrid.Rows.Add($"{port.Port} ({port.Name})", port.IpVersion);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FirewallRefreshAppsBttn_Click(object sender, EventArgs e)
        {
            FirewallAppsLbl.Focus();
            FirewallAppsGrid.Rows.Clear();

            try
            {
                Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
                INetFwMgr manager = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);

                foreach (INetFwAuthorizedApplication app in manager.LocalPolicy.CurrentProfile.AuthorizedApplications)
                    FirewallAppsGrid.Rows.Add(app.Name, app.IpVersion);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FirewallInfoRefreshBttn_Click(object sender, EventArgs e)
        {
            FirewallInfoLbl.Focus();
            try
            {
                Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
                INetFwMgr manager = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);

                FirewallInfoLbl.Text = $""""
                Profile type: {manager.CurrentProfileType}
                Firewall enabled: {manager.LocalPolicy.CurrentProfile.FirewallEnabled}
                """";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
