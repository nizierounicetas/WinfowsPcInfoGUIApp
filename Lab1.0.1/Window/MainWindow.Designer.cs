namespace PC_info
{
    partial class PCinfoForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCinfoForm));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.hardwareTab = new MetroFramework.Controls.MetroTabPage();
            this.DISKrefreshBttn = new MetroFramework.Controls.MetroButton();
            this.DISKgrid = new MetroFramework.Controls.MetroGrid();
            this.DISKlbl = new MetroFramework.Controls.MetroLabel();
            this.RAMsizelbl = new MetroFramework.Controls.MetroLabel();
            this.RAMpercentage = new MetroFramework.Controls.MetroLabel();
            this.RAMpb = new MetroFramework.Controls.MetroProgressBar();
            this.RAMlbl = new MetroFramework.Controls.MetroLabel();
            this.CPUnumberOfCoreslbl = new MetroFramework.Controls.MetroLabel();
            this.CPUnamelbl = new MetroFramework.Controls.MetroLabel();
            this.CPUpercentage = new MetroFramework.Controls.MetroLabel();
            this.CPUpb = new MetroFramework.Controls.MetroProgressBar();
            this.CPUlbl = new MetroFramework.Controls.MetroLabel();
            this.antivirusTab = new MetroFramework.Controls.MetroTabPage();
            this.AntivirusRefreshBttn = new MetroFramework.Controls.MetroButton();
            this.AntivirusInfoLbl = new MetroFramework.Controls.MetroLabel();
            this.firewallTab = new MetroFramework.Controls.MetroTabPage();
            this.FirewallInfoRefreshBttn = new MetroFramework.Controls.MetroButton();
            this.FirewallRefreshAppsBttn = new MetroFramework.Controls.MetroButton();
            this.FirewallPortsRefreshBttn = new MetroFramework.Controls.MetroButton();
            this.FirewallAppsLbl = new MetroFramework.Controls.MetroLabel();
            this.FirewallAppsGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirewallOpenPortsLbl = new MetroFramework.Controls.MetroLabel();
            this.FirewallPortsGrid = new MetroFramework.Controls.MetroGrid();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirewallInfoLbl = new MetroFramework.Controls.MetroLabel();
            this.OStab = new MetroFramework.Controls.MetroTabPage();
            this.OSInfoUpdateBttn = new MetroFramework.Controls.MetroButton();
            this.OSrefreshBttn = new MetroFramework.Controls.MetroButton();
            this.SoftwareUpdatesLbl = new MetroFramework.Controls.MetroLabel();
            this.OSupdatesGrid = new MetroFramework.Controls.MetroGrid();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downloaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.OSInfoLbl = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CPUcounter = new System.Diagnostics.PerformanceCounter();
            this.RAMcounter = new System.Diagnostics.PerformanceCounter();
            this.JsonReportBttn = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.hardwareTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DISKgrid)).BeginInit();
            this.antivirusTab.SuspendLayout();
            this.firewallTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirewallAppsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirewallPortsGrid)).BeginInit();
            this.OStab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OSupdatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUcounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMcounter)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.hardwareTab);
            this.tabControl.Controls.Add(this.antivirusTab);
            this.tabControl.Controls.Add(this.firewallTab);
            this.tabControl.Controls.Add(this.OStab);
            this.tabControl.Location = new System.Drawing.Point(1, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(875, 429);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // hardwareTab
            // 
            this.hardwareTab.Controls.Add(this.DISKrefreshBttn);
            this.hardwareTab.Controls.Add(this.DISKgrid);
            this.hardwareTab.Controls.Add(this.DISKlbl);
            this.hardwareTab.Controls.Add(this.RAMsizelbl);
            this.hardwareTab.Controls.Add(this.RAMpercentage);
            this.hardwareTab.Controls.Add(this.RAMpb);
            this.hardwareTab.Controls.Add(this.RAMlbl);
            this.hardwareTab.Controls.Add(this.CPUnumberOfCoreslbl);
            this.hardwareTab.Controls.Add(this.CPUnamelbl);
            this.hardwareTab.Controls.Add(this.CPUpercentage);
            this.hardwareTab.Controls.Add(this.CPUpb);
            this.hardwareTab.Controls.Add(this.CPUlbl);
            this.hardwareTab.HorizontalScrollbarBarColor = true;
            this.hardwareTab.HorizontalScrollbarHighlightOnWheel = false;
            this.hardwareTab.HorizontalScrollbarSize = 10;
            this.hardwareTab.Location = new System.Drawing.Point(4, 38);
            this.hardwareTab.Name = "hardwareTab";
            this.hardwareTab.Size = new System.Drawing.Size(867, 387);
            this.hardwareTab.Style = MetroFramework.MetroColorStyle.Yellow;
            this.hardwareTab.TabIndex = 0;
            this.hardwareTab.Text = "Hardware";
            this.hardwareTab.VerticalScrollbarBarColor = true;
            this.hardwareTab.VerticalScrollbarHighlightOnWheel = false;
            this.hardwareTab.VerticalScrollbarSize = 10;
            // 
            // DISKrefreshBttn
            // 
            this.DISKrefreshBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DISKrefreshBttn.Location = new System.Drawing.Point(77, 195);
            this.DISKrefreshBttn.Name = "DISKrefreshBttn";
            this.DISKrefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.DISKrefreshBttn.TabIndex = 19;
            this.DISKrefreshBttn.Text = "Refresh";
            this.DISKrefreshBttn.UseSelectable = true;
            this.DISKrefreshBttn.Click += new System.EventHandler(this.DISKrefreshBttn_Click);
            // 
            // DISKgrid
            // 
            this.DISKgrid.AllowUserToAddRows = false;
            this.DISKgrid.AllowUserToDeleteRows = false;
            this.DISKgrid.AllowUserToResizeColumns = false;
            this.DISKgrid.AllowUserToResizeRows = false;
            this.DISKgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DISKgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DISKgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DISKgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DISKgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DISKgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DISKgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DISKgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DISKgrid.EnableHeadersVisualStyles = false;
            this.DISKgrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DISKgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DISKgrid.Location = new System.Drawing.Point(18, 228);
            this.DISKgrid.Name = "DISKgrid";
            this.DISKgrid.ReadOnly = true;
            this.DISKgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DISKgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DISKgrid.RowHeadersWidth = 48;
            this.DISKgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DISKgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DISKgrid.Size = new System.Drawing.Size(357, 150);
            this.DISKgrid.TabIndex = 18;
            // 
            // DISKlbl
            // 
            this.DISKlbl.AutoSize = true;
            this.DISKlbl.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.DISKlbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DISKlbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DISKlbl.ForeColor = System.Drawing.Color.Black;
            this.DISKlbl.Location = new System.Drawing.Point(18, 193);
            this.DISKlbl.Name = "DISKlbl";
            this.DISKlbl.Size = new System.Drawing.Size(53, 25);
            this.DISKlbl.TabIndex = 12;
            this.DISKlbl.Text = "DISK";
            // 
            // RAMsizelbl
            // 
            this.RAMsizelbl.AutoSize = true;
            this.RAMsizelbl.Location = new System.Drawing.Point(431, 70);
            this.RAMsizelbl.Name = "RAMsizelbl";
            this.RAMsizelbl.Size = new System.Drawing.Size(94, 19);
            this.RAMsizelbl.TabIndex = 11;
            this.RAMsizelbl.Text = "Total Amount: ";
            // 
            // RAMpercentage
            // 
            this.RAMpercentage.AutoSize = true;
            this.RAMpercentage.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.RAMpercentage.ForeColor = System.Drawing.Color.Black;
            this.RAMpercentage.Location = new System.Drawing.Point(687, 101);
            this.RAMpercentage.Name = "RAMpercentage";
            this.RAMpercentage.Size = new System.Drawing.Size(44, 19);
            this.RAMpercentage.TabIndex = 9;
            this.RAMpercentage.Text = "0.00%";
            // 
            // RAMpb
            // 
            this.RAMpb.Location = new System.Drawing.Point(431, 101);
            this.RAMpb.Name = "RAMpb";
            this.RAMpb.Size = new System.Drawing.Size(250, 23);
            this.RAMpb.TabIndex = 8;
            // 
            // RAMlbl
            // 
            this.RAMlbl.AutoSize = true;
            this.RAMlbl.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.RAMlbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RAMlbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RAMlbl.ForeColor = System.Drawing.Color.Black;
            this.RAMlbl.Location = new System.Drawing.Point(431, 38);
            this.RAMlbl.Name = "RAMlbl";
            this.RAMlbl.Size = new System.Drawing.Size(54, 25);
            this.RAMlbl.TabIndex = 7;
            this.RAMlbl.Text = "RAM";
            // 
            // CPUnumberOfCoreslbl
            // 
            this.CPUnumberOfCoreslbl.AutoSize = true;
            this.CPUnumberOfCoreslbl.Location = new System.Drawing.Point(17, 101);
            this.CPUnumberOfCoreslbl.Name = "CPUnumberOfCoreslbl";
            this.CPUnumberOfCoreslbl.Size = new System.Drawing.Size(162, 19);
            this.CPUnumberOfCoreslbl.TabIndex = 6;
            this.CPUnumberOfCoreslbl.Text = "Number of cores(logical): ";
            // 
            // CPUnamelbl
            // 
            this.CPUnamelbl.AutoSize = true;
            this.CPUnamelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUnamelbl.Location = new System.Drawing.Point(17, 70);
            this.CPUnamelbl.Name = "CPUnamelbl";
            this.CPUnamelbl.Size = new System.Drawing.Size(66, 19);
            this.CPUnamelbl.TabIndex = 5;
            this.CPUnamelbl.Text = "Processor";
            // 
            // CPUpercentage
            // 
            this.CPUpercentage.AutoSize = true;
            this.CPUpercentage.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.CPUpercentage.ForeColor = System.Drawing.Color.Black;
            this.CPUpercentage.Location = new System.Drawing.Point(273, 135);
            this.CPUpercentage.Name = "CPUpercentage";
            this.CPUpercentage.Size = new System.Drawing.Size(44, 19);
            this.CPUpercentage.TabIndex = 4;
            this.CPUpercentage.Text = "0.00%";
            // 
            // CPUpb
            // 
            this.CPUpb.Location = new System.Drawing.Point(17, 135);
            this.CPUpb.Name = "CPUpb";
            this.CPUpb.Size = new System.Drawing.Size(250, 23);
            this.CPUpb.TabIndex = 3;
            // 
            // CPUlbl
            // 
            this.CPUlbl.AutoSize = true;
            this.CPUlbl.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.CPUlbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CPUlbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CPUlbl.ForeColor = System.Drawing.Color.Black;
            this.CPUlbl.Location = new System.Drawing.Point(18, 38);
            this.CPUlbl.Name = "CPUlbl";
            this.CPUlbl.Size = new System.Drawing.Size(47, 25);
            this.CPUlbl.TabIndex = 2;
            this.CPUlbl.Text = "CPU";
            // 
            // antivirusTab
            // 
            this.antivirusTab.Controls.Add(this.AntivirusRefreshBttn);
            this.antivirusTab.Controls.Add(this.AntivirusInfoLbl);
            this.antivirusTab.HorizontalScrollbarBarColor = true;
            this.antivirusTab.HorizontalScrollbarHighlightOnWheel = false;
            this.antivirusTab.HorizontalScrollbarSize = 10;
            this.antivirusTab.Location = new System.Drawing.Point(4, 38);
            this.antivirusTab.Name = "antivirusTab";
            this.antivirusTab.Size = new System.Drawing.Size(867, 387);
            this.antivirusTab.TabIndex = 1;
            this.antivirusTab.Text = "Antivirus";
            this.antivirusTab.VerticalScrollbarBarColor = true;
            this.antivirusTab.VerticalScrollbarHighlightOnWheel = false;
            this.antivirusTab.VerticalScrollbarSize = 10;
            // 
            // AntivirusRefreshBttn
            // 
            this.AntivirusRefreshBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AntivirusRefreshBttn.Location = new System.Drawing.Point(473, 40);
            this.AntivirusRefreshBttn.Name = "AntivirusRefreshBttn";
            this.AntivirusRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.AntivirusRefreshBttn.TabIndex = 6;
            this.AntivirusRefreshBttn.Text = "Refresh";
            this.AntivirusRefreshBttn.UseSelectable = true;
            this.AntivirusRefreshBttn.Click += new System.EventHandler(this.AntivirusRefreshBttn_Click);
            // 
            // AntivirusInfoLbl
            // 
            this.AntivirusInfoLbl.AutoSize = true;
            this.AntivirusInfoLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AntivirusInfoLbl.Location = new System.Drawing.Point(18, 38);
            this.AntivirusInfoLbl.Name = "AntivirusInfoLbl";
            this.AntivirusInfoLbl.Size = new System.Drawing.Size(153, 25);
            this.AntivirusInfoLbl.TabIndex = 2;
            this.AntivirusInfoLbl.Text = "Antivirus installed: ";
            // 
            // firewallTab
            // 
            this.firewallTab.Controls.Add(this.FirewallInfoRefreshBttn);
            this.firewallTab.Controls.Add(this.FirewallRefreshAppsBttn);
            this.firewallTab.Controls.Add(this.FirewallPortsRefreshBttn);
            this.firewallTab.Controls.Add(this.FirewallAppsLbl);
            this.firewallTab.Controls.Add(this.FirewallAppsGrid);
            this.firewallTab.Controls.Add(this.FirewallOpenPortsLbl);
            this.firewallTab.Controls.Add(this.FirewallPortsGrid);
            this.firewallTab.Controls.Add(this.FirewallInfoLbl);
            this.firewallTab.HorizontalScrollbarBarColor = true;
            this.firewallTab.HorizontalScrollbarHighlightOnWheel = false;
            this.firewallTab.HorizontalScrollbarSize = 10;
            this.firewallTab.Location = new System.Drawing.Point(4, 38);
            this.firewallTab.Name = "firewallTab";
            this.firewallTab.Size = new System.Drawing.Size(867, 387);
            this.firewallTab.TabIndex = 3;
            this.firewallTab.Text = "Firewall";
            this.firewallTab.VerticalScrollbarBarColor = true;
            this.firewallTab.VerticalScrollbarHighlightOnWheel = false;
            this.firewallTab.VerticalScrollbarSize = 10;
            // 
            // FirewallInfoRefreshBttn
            // 
            this.FirewallInfoRefreshBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FirewallInfoRefreshBttn.Location = new System.Drawing.Point(18, 104);
            this.FirewallInfoRefreshBttn.Name = "FirewallInfoRefreshBttn";
            this.FirewallInfoRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.FirewallInfoRefreshBttn.TabIndex = 25;
            this.FirewallInfoRefreshBttn.Text = "Refresh";
            this.FirewallInfoRefreshBttn.UseSelectable = true;
            this.FirewallInfoRefreshBttn.Click += new System.EventHandler(this.FirewallInfoRefreshBttn_Click);
            // 
            // FirewallRefreshAppsBttn
            // 
            this.FirewallRefreshAppsBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FirewallRefreshAppsBttn.Location = new System.Drawing.Point(616, 186);
            this.FirewallRefreshAppsBttn.Name = "FirewallRefreshAppsBttn";
            this.FirewallRefreshAppsBttn.Size = new System.Drawing.Size(75, 23);
            this.FirewallRefreshAppsBttn.TabIndex = 24;
            this.FirewallRefreshAppsBttn.Text = "Refresh";
            this.FirewallRefreshAppsBttn.UseSelectable = true;
            this.FirewallRefreshAppsBttn.Click += new System.EventHandler(this.FirewallRefreshAppsBttn_Click);
            // 
            // FirewallPortsRefreshBttn
            // 
            this.FirewallPortsRefreshBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FirewallPortsRefreshBttn.Location = new System.Drawing.Point(204, 186);
            this.FirewallPortsRefreshBttn.Name = "FirewallPortsRefreshBttn";
            this.FirewallPortsRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.FirewallPortsRefreshBttn.TabIndex = 23;
            this.FirewallPortsRefreshBttn.Text = "Refresh";
            this.FirewallPortsRefreshBttn.UseSelectable = true;
            this.FirewallPortsRefreshBttn.Click += new System.EventHandler(this.FirewallPortsRefreshBttn_Click);
            // 
            // FirewallAppsLbl
            // 
            this.FirewallAppsLbl.AutoSize = true;
            this.FirewallAppsLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FirewallAppsLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FirewallAppsLbl.Location = new System.Drawing.Point(395, 184);
            this.FirewallAppsLbl.Name = "FirewallAppsLbl";
            this.FirewallAppsLbl.Size = new System.Drawing.Size(215, 25);
            this.FirewallAppsLbl.TabIndex = 22;
            this.FirewallAppsLbl.Text = "Authorized applications";
            // 
            // FirewallAppsGrid
            // 
            this.FirewallAppsGrid.AllowUserToAddRows = false;
            this.FirewallAppsGrid.AllowUserToDeleteRows = false;
            this.FirewallAppsGrid.AllowUserToResizeColumns = false;
            this.FirewallAppsGrid.AllowUserToResizeRows = false;
            this.FirewallAppsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FirewallAppsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirewallAppsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FirewallAppsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirewallAppsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FirewallAppsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirewallAppsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirewallAppsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.FirewallAppsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FirewallAppsGrid.EnableHeadersVisualStyles = false;
            this.FirewallAppsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirewallAppsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FirewallAppsGrid.Location = new System.Drawing.Point(395, 220);
            this.FirewallAppsGrid.Name = "FirewallAppsGrid";
            this.FirewallAppsGrid.ReadOnly = true;
            this.FirewallAppsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirewallAppsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FirewallAppsGrid.RowHeadersWidth = 48;
            this.FirewallAppsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FirewallAppsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FirewallAppsGrid.Size = new System.Drawing.Size(476, 150);
            this.FirewallAppsGrid.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IP version";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FirewallOpenPortsLbl
            // 
            this.FirewallOpenPortsLbl.AutoSize = true;
            this.FirewallOpenPortsLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FirewallOpenPortsLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FirewallOpenPortsLbl.Location = new System.Drawing.Point(18, 184);
            this.FirewallOpenPortsLbl.Name = "FirewallOpenPortsLbl";
            this.FirewallOpenPortsLbl.Size = new System.Drawing.Size(180, 25);
            this.FirewallOpenPortsLbl.TabIndex = 20;
            this.FirewallOpenPortsLbl.Text = "Globally open ports";
            // 
            // FirewallPortsGrid
            // 
            this.FirewallPortsGrid.AllowUserToAddRows = false;
            this.FirewallPortsGrid.AllowUserToDeleteRows = false;
            this.FirewallPortsGrid.AllowUserToResizeColumns = false;
            this.FirewallPortsGrid.AllowUserToResizeRows = false;
            this.FirewallPortsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FirewallPortsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirewallPortsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FirewallPortsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirewallPortsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FirewallPortsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirewallPortsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.IpVersion});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirewallPortsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.FirewallPortsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FirewallPortsGrid.EnableHeadersVisualStyles = false;
            this.FirewallPortsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirewallPortsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FirewallPortsGrid.Location = new System.Drawing.Point(18, 220);
            this.FirewallPortsGrid.Name = "FirewallPortsGrid";
            this.FirewallPortsGrid.ReadOnly = true;
            this.FirewallPortsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirewallPortsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FirewallPortsGrid.RowHeadersWidth = 48;
            this.FirewallPortsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FirewallPortsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FirewallPortsGrid.Size = new System.Drawing.Size(371, 150);
            this.FirewallPortsGrid.TabIndex = 19;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 120;
            // 
            // IpVersion
            // 
            this.IpVersion.HeaderText = "IP version";
            this.IpVersion.Name = "IpVersion";
            this.IpVersion.ReadOnly = true;
            this.IpVersion.Width = 200;
            // 
            // FirewallInfoLbl
            // 
            this.FirewallInfoLbl.AutoSize = true;
            this.FirewallInfoLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FirewallInfoLbl.Location = new System.Drawing.Point(18, 38);
            this.FirewallInfoLbl.Name = "FirewallInfoLbl";
            this.FirewallInfoLbl.Size = new System.Drawing.Size(102, 25);
            this.FirewallInfoLbl.TabIndex = 2;
            this.FirewallInfoLbl.Text = "Firewall info";
            // 
            // OStab
            // 
            this.OStab.Controls.Add(this.OSInfoUpdateBttn);
            this.OStab.Controls.Add(this.OSrefreshBttn);
            this.OStab.Controls.Add(this.SoftwareUpdatesLbl);
            this.OStab.Controls.Add(this.OSupdatesGrid);
            this.OStab.Controls.Add(this.metroGrid1);
            this.OStab.Controls.Add(this.OSInfoLbl);
            this.OStab.HorizontalScrollbarBarColor = true;
            this.OStab.HorizontalScrollbarHighlightOnWheel = false;
            this.OStab.HorizontalScrollbarSize = 10;
            this.OStab.Location = new System.Drawing.Point(4, 38);
            this.OStab.Name = "OStab";
            this.OStab.Size = new System.Drawing.Size(867, 387);
            this.OStab.TabIndex = 2;
            this.OStab.Text = "OS";
            this.OStab.VerticalScrollbarBarColor = true;
            this.OStab.VerticalScrollbarHighlightOnWheel = false;
            this.OStab.VerticalScrollbarSize = 10;
            // 
            // OSInfoUpdateBttn
            // 
            this.OSInfoUpdateBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OSInfoUpdateBttn.Location = new System.Drawing.Point(19, 118);
            this.OSInfoUpdateBttn.Name = "OSInfoUpdateBttn";
            this.OSInfoUpdateBttn.Size = new System.Drawing.Size(75, 23);
            this.OSInfoUpdateBttn.TabIndex = 7;
            this.OSInfoUpdateBttn.Text = "Refresh";
            this.OSInfoUpdateBttn.UseSelectable = true;
            this.OSInfoUpdateBttn.Click += new System.EventHandler(this.OSInfoUpdateBttn_Click);
            // 
            // OSrefreshBttn
            // 
            this.OSrefreshBttn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OSrefreshBttn.Location = new System.Drawing.Point(187, 185);
            this.OSrefreshBttn.Name = "OSrefreshBttn";
            this.OSrefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.OSrefreshBttn.TabIndex = 6;
            this.OSrefreshBttn.Text = "Refresh";
            this.OSrefreshBttn.UseSelectable = true;
            this.OSrefreshBttn.Click += new System.EventHandler(this.OSrefreshBttn_ClickAsync);
            // 
            // SoftwareUpdatesLbl
            // 
            this.SoftwareUpdatesLbl.AutoSize = true;
            this.SoftwareUpdatesLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SoftwareUpdatesLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SoftwareUpdatesLbl.Location = new System.Drawing.Point(19, 184);
            this.SoftwareUpdatesLbl.Name = "SoftwareUpdatesLbl";
            this.SoftwareUpdatesLbl.Size = new System.Drawing.Size(161, 25);
            this.SoftwareUpdatesLbl.TabIndex = 5;
            this.SoftwareUpdatesLbl.Text = "Software updates";
            // 
            // OSupdatesGrid
            // 
            this.OSupdatesGrid.AllowUserToAddRows = false;
            this.OSupdatesGrid.AllowUserToDeleteRows = false;
            this.OSupdatesGrid.AllowUserToResizeColumns = false;
            this.OSupdatesGrid.AllowUserToResizeRows = false;
            this.OSupdatesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OSupdatesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OSupdatesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OSupdatesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OSupdatesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.OSupdatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OSupdatesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Installed,
            this.Downloaded});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OSupdatesGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.OSupdatesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OSupdatesGrid.EnableHeadersVisualStyles = false;
            this.OSupdatesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OSupdatesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OSupdatesGrid.Location = new System.Drawing.Point(18, 220);
            this.OSupdatesGrid.Name = "OSupdatesGrid";
            this.OSupdatesGrid.ReadOnly = true;
            this.OSupdatesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OSupdatesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.OSupdatesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OSupdatesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OSupdatesGrid.Size = new System.Drawing.Size(593, 150);
            this.OSupdatesGrid.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 350;
            // 
            // Installed
            // 
            this.Installed.HeaderText = "Installed";
            this.Installed.Name = "Installed";
            this.Installed.ReadOnly = true;
            this.Installed.Width = 80;
            // 
            // Downloaded
            // 
            this.Downloaded.HeaderText = "Downloaded";
            this.Downloaded.Name = "Downloaded";
            this.Downloaded.ReadOnly = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-154, 171);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 3;
            // 
            // OSInfoLbl
            // 
            this.OSInfoLbl.AutoSize = true;
            this.OSInfoLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OSInfoLbl.Location = new System.Drawing.Point(18, 38);
            this.OSInfoLbl.Name = "OSInfoLbl";
            this.OSInfoLbl.Size = new System.Drawing.Size(69, 25);
            this.OSInfoLbl.TabIndex = 2;
            this.OSInfoLbl.Text = "OS Info";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CPUcounter
            // 
            this.CPUcounter.CategoryName = "Processor";
            this.CPUcounter.CounterName = "% Processor time";
            this.CPUcounter.InstanceName = "_Total";
            // 
            // RAMcounter
            // 
            this.RAMcounter.CategoryName = "Memory";
            this.RAMcounter.CounterName = "% Committed Bytes IN Use";
            // 
            // JsonReportBttn
            // 
            this.JsonReportBttn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.JsonReportBttn.Location = new System.Drawing.Point(698, 34);
            this.JsonReportBttn.Name = "JsonReportBttn";
            this.JsonReportBttn.Size = new System.Drawing.Size(178, 23);
            this.JsonReportBttn.TabIndex = 1;
            this.JsonReportBttn.Text = "Save JSON report";
            this.JsonReportBttn.UseSelectable = true;
            this.JsonReportBttn.Click += new System.EventHandler(this.JsonReportBttn_ClickAsync);
            // 
            // PCinfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(899, 494);
            this.Controls.Add(this.JsonReportBttn);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCinfoForm";
            this.Resizable = false;
            this.Text = "PC info";
            this.Load += new System.EventHandler(this.PCinfo_Load);
            this.tabControl.ResumeLayout(false);
            this.hardwareTab.ResumeLayout(false);
            this.hardwareTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DISKgrid)).EndInit();
            this.antivirusTab.ResumeLayout(false);
            this.antivirusTab.PerformLayout();
            this.firewallTab.ResumeLayout(false);
            this.firewallTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirewallAppsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirewallPortsGrid)).EndInit();
            this.OStab.ResumeLayout(false);
            this.OStab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OSupdatesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUcounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMcounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter CPUcounter;
        private MetroFramework.Controls.MetroTabPage antivirusTab;
        private System.Diagnostics.PerformanceCounter RAMcounter;
        private MetroFramework.Controls.MetroTabPage hardwareTab;
        private MetroFramework.Controls.MetroButton DISKrefreshBttn;
        private MetroFramework.Controls.MetroGrid DISKgrid;
        private MetroFramework.Controls.MetroLabel DISKlbl;
        private MetroFramework.Controls.MetroLabel RAMsizelbl;
        private MetroFramework.Controls.MetroLabel RAMpercentage;
        private MetroFramework.Controls.MetroProgressBar RAMpb;
        private MetroFramework.Controls.MetroLabel RAMlbl;
        private MetroFramework.Controls.MetroLabel CPUnumberOfCoreslbl;
        private MetroFramework.Controls.MetroLabel CPUnamelbl;
        private MetroFramework.Controls.MetroLabel CPUpercentage;
        private MetroFramework.Controls.MetroProgressBar CPUpb;
        private MetroFramework.Controls.MetroLabel CPUlbl;
        private MetroFramework.Controls.MetroTabPage OStab;
        private MetroFramework.Controls.MetroLabel AntivirusInfoLbl;
        private MetroFramework.Controls.MetroButton AntivirusRefreshBttn;
        private MetroFramework.Controls.MetroLabel OSInfoLbl;
        private MetroFramework.Controls.MetroGrid OSupdatesGrid;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel SoftwareUpdatesLbl;
        private MetroFramework.Controls.MetroButton OSrefreshBttn;
        private MetroFramework.Controls.MetroButton OSInfoUpdateBttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downloaded;
        private MetroFramework.Controls.MetroTabPage firewallTab;
        private MetroFramework.Controls.MetroLabel FirewallInfoLbl;
        private MetroFramework.Controls.MetroGrid FirewallPortsGrid;
        private MetroFramework.Controls.MetroLabel FirewallOpenPortsLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpVersion;
        private MetroFramework.Controls.MetroLabel FirewallAppsLbl;
        private MetroFramework.Controls.MetroGrid FirewallAppsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroButton FirewallPortsRefreshBttn;
        private MetroFramework.Controls.MetroButton FirewallRefreshAppsBttn;
        private MetroFramework.Controls.MetroButton FirewallInfoRefreshBttn;
        private MetroFramework.Controls.MetroButton JsonReportBttn;
    }
}

