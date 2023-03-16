using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace PC_info
{
    public partial class PCinfoForm : MetroFramework.Forms.MetroForm
    {
        private readonly long BITS_IN_GB = 1_073_741_824;
        private readonly Mutex cpuMutex = new();
        private readonly Mutex ramMutex = new();
        private readonly SemaphoreSlim updatesSemaphore = new SemaphoreSlim(1, 1);
        private readonly Dictionary<int, string> antivirusStates = new Dictionary<int, string>{
            {262144, "disabled and up to date" },
            {266240, "enabled and up to date" },
            {266256, "firewall enabled"},
            {262160, "firewall disabled"},
            {393472, "disabled and up to date"},
            {397584, "enabled and out of date"},
            {397568, "enabled and up to date"},
            {397312, "enabled and up to date" },
            {393216, "disabled and up to date"}
        };


        public PCinfoForm()
        {
            InitializeComponent();
        }

        private void PCinfo_Load(object sender, EventArgs e)
        {
            timer.Start();

            try
            {
                InitCPUInfo();
                InitRAMInfo();
                InitDISKInfo();

                InitAntivirusInfo();

                InitOSInfo();
                InitUpdatesInfo();

                InitFirewallInfo();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            cpuMutex.Close();
            ramMutex.Close();
            updatesSemaphore.Dispose();
        }
    }
}
