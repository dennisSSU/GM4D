namespace GM4D
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menu_btnOverview = new System.Windows.Forms.Button();
            this.menu_btnBasicSettings = new System.Windows.Forms.Button();
            this.menu_btnStaticLeases = new System.Windows.Forms.Button();
            this.menu_btnClients = new System.Windows.Forms.Button();
            this.menu_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBottom_btnSave = new System.Windows.Forms.Button();
            this.settings_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.settings_panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hostGateway_tb = new System.Windows.Forms.TextBox();
            this.hostGateway_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hostSubnetMask_tb = new System.Windows.Forms.TextBox();
            this.hostIP_lbl = new System.Windows.Forms.Label();
            this.hostSubnetMask_lbl = new System.Windows.Forms.Label();
            this.hostIP_lblInfo = new System.Windows.Forms.Label();
            this.hostSubnetMask_lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hostIP_tb = new System.Windows.Forms.TextBox();
            this.settings_panelInput = new System.Windows.Forms.TableLayoutPanel();
            this.maxLease_lblInfo = new System.Windows.Forms.Label();
            this.maxLease_pnl = new System.Windows.Forms.Panel();
            this.maxLease_input = new System.Windows.Forms.NumericUpDown();
            this.maxLease_lbl = new System.Windows.Forms.Label();
            this.defaultLease_lblInfo = new System.Windows.Forms.Label();
            this.defaultLease_lbl = new System.Windows.Forms.Label();
            this.ipRangeStart_lblInfo = new System.Windows.Forms.Label();
            this.subnetMask_lbl = new System.Windows.Forms.Label();
            this.gateway_lbl = new System.Windows.Forms.Label();
            this.subnetMask_lblInfo = new System.Windows.Forms.Label();
            this.gateway_lblInfo = new System.Windows.Forms.Label();
            this.primaryDNS_lbl = new System.Windows.Forms.Label();
            this.secondaryDNS_lbl = new System.Windows.Forms.Label();
            this.primaryDNS_lblInfo = new System.Windows.Forms.Label();
            this.secondaryDNS_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeStart_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.ipRangeStart_input = new IPAddressControlLib.IPAddressControl();
            this.subnet_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.ipRangeEnd_input = new IPAddressControlLib.IPAddressControl();
            this.subnetMask_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.subnetMask_input = new IPAddressControlLib.IPAddressControl();
            this.gateway_inputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gateway_input = new IPAddressControlLib.IPAddressControl();
            this.primaryDNS_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.primaryDNS_input = new IPAddressControlLib.IPAddressControl();
            this.secondaryDNS_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.secondaryDNS_input = new IPAddressControlLib.IPAddressControl();
            this.ipRangeEnde_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.subnet_input = new IPAddressControlLib.IPAddressControl();
            this.ipRangeEnd_lbl = new System.Windows.Forms.Label();
            this.subnet_lbl = new System.Windows.Forms.Label();
            this.ipRangeEnd_lblInfo = new System.Windows.Forms.Label();
            this.subnet_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeStart_lbl = new System.Windows.Forms.Label();
            this.defaultLease_pnl = new System.Windows.Forms.Panel();
            this.defaultLease_input = new System.Windows.Forms.NumericUpDown();
            this.staticLeases_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.staticLeases_listview = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMACaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIPaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnedit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columndelete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staticLeases_input_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staticLeases_input_lbl_name = new System.Windows.Forms.Label();
            this.staticLeases_input_lbl_mac = new System.Windows.Forms.Label();
            this.staticLeases_input_lbl_ip = new System.Windows.Forms.Label();
            this.staticLeases_input_btn_add = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.staticLeases_input_tb_name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.staticLeases_input_tb_mac = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.staticLeases_input_tb_ip = new IPAddressControlLib.IPAddressControl();
            this.clients_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.clients_dhcpdLeases_listView = new System.Windows.Forms.ListView();
            this.columnClientsMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientsIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientsLeaseStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientsLeaseEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientsAddToStatic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.overview_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_tablepanel = new System.Windows.Forms.TableLayoutPanel();
            this.overview_hostip_status_lbl = new System.Windows.Forms.Label();
            this.overview_hostip_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.overview_hostip_subnetMask_info_lbl = new System.Windows.Forms.Label();
            this.overview_hostip_info_lbl = new System.Windows.Forms.Label();
            this.overview_hostip_info_subnetMask_lbl = new System.Windows.Forms.Label();
            this.overview_hostip_info_ip_lbl = new System.Windows.Forms.Label();
            this.overview_header_lbl_c1 = new System.Windows.Forms.Label();
            this.overview_header_lbl_c2 = new System.Windows.Forms.Label();
            this.overview_header_lbl_c3 = new System.Windows.Forms.Label();
            this.overview_header_lbl_c4 = new System.Windows.Forms.Label();
            this.overview_dhcpDeamon_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpDeamon_status_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpDeamon_info_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpDeamon_btn = new System.Windows.Forms.Button();
            this.overview_dhcpServer_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpServer_status_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpServer_info_lbl = new System.Windows.Forms.Label();
            this.overview_dhcpServer_btn = new System.Windows.Forms.Button();
            this.overview_hostip_lbl = new System.Windows.Forms.Label();
            this.overview_hostNic_lbl = new System.Windows.Forms.Label();
            this.overview_hostNic_status_lbl = new System.Windows.Forms.Label();
            this.overview_hostNic_info_lbl = new System.Windows.Forms.Label();
            this.overview_hostNic_btn = new System.Windows.Forms.Button();
            this.overview_setHostIp_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_setHostIp_lbl = new System.Windows.Forms.Label();
            this.overview_setHostIp_tablepanel = new System.Windows.Forms.TableLayoutPanel();
            this.overview_setHostIp_ip_lbl = new System.Windows.Forms.Label();
            this.overview_setHostIp_ip_lbl_info = new System.Windows.Forms.Label();
            this.overview_setHostIp_subnetmask_lbl = new System.Windows.Forms.Label();
            this.overview_setHostIp_subnetmask_lbl_info = new System.Windows.Forms.Label();
            this.overview_setHostIp_ip_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_setHostIp_ip_ipinput = new IPAddressControlLib.IPAddressControl();
            this.overview_setHostIp_subnetmask_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_setHostIp_subnetmask_ipinput = new IPAddressControlLib.IPAddressControl();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_setHostIp_set_btn = new System.Windows.Forms.Button();
            this.overview_setHostIp_cancel_btn = new System.Windows.Forms.Button();
            this.validationStatus_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.validationStatus_ok = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuBottom_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBottom_btnLoad = new System.Windows.Forms.Button();
            this.menuBottom_btnApply = new System.Windows.Forms.Button();
            this.menuBottom_LoadFromDhcp = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusRequired = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeNic_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.selectNic_listview = new System.Windows.Forms.ListView();
            this.changeNicColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeNicColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeNicColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeNicColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeNicColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeNicColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.setHostIp_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.copyright_panel = new System.Windows.Forms.Panel();
            this.copyright_header = new System.Windows.Forms.Label();
            this.copyright_subheader = new System.Windows.Forms.Label();
            this.copyright_sign = new System.Windows.Forms.Label();
            this.copyright_description = new System.Windows.Forms.Label();
            this.copyright_license = new System.Windows.Forms.RichTextBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menu_panelMain.SuspendLayout();
            this.settings_panelMain.SuspendLayout();
            this.settings_panelInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.settings_panelInput.SuspendLayout();
            this.maxLease_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLease_input)).BeginInit();
            this.ipRangeStart_panelInput.SuspendLayout();
            this.subnet_panelInput.SuspendLayout();
            this.subnetMask_panelInput.SuspendLayout();
            this.gateway_inputPanel.SuspendLayout();
            this.primaryDNS_panelInput.SuspendLayout();
            this.secondaryDNS_panelInput.SuspendLayout();
            this.ipRangeEnde_panelInput.SuspendLayout();
            this.defaultLease_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultLease_input)).BeginInit();
            this.staticLeases_panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.clients_panelMain.SuspendLayout();
            this.overview_panelMain.SuspendLayout();
            this.overview_tablepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.overview_setHostIp_panel.SuspendLayout();
            this.overview_setHostIp_tablepanel.SuspendLayout();
            this.overview_setHostIp_ip_panel.SuspendLayout();
            this.overview_setHostIp_subnetmask_panel.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_ok)).BeginInit();
            this.menuBottom_panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusRequired)).BeginInit();
            this.changeNic_panelMain.SuspendLayout();
            this.setHostIp_panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.copyright_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_btnOverview
            // 
            this.menu_btnOverview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_btnOverview.FlatAppearance.BorderSize = 0;
            this.menu_btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnOverview.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menu_btnOverview.Location = new System.Drawing.Point(0, 0);
            this.menu_btnOverview.Margin = new System.Windows.Forms.Padding(0);
            this.menu_btnOverview.Name = "menu_btnOverview";
            this.menu_btnOverview.Size = new System.Drawing.Size(100, 100);
            this.menu_btnOverview.TabIndex = 1;
            this.menu_btnOverview.TabStop = false;
            this.menu_btnOverview.Text = "Overview";
            this.menu_btnOverview.UseVisualStyleBackColor = false;
            this.menu_btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // menu_btnBasicSettings
            // 
            this.menu_btnBasicSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_btnBasicSettings.FlatAppearance.BorderSize = 0;
            this.menu_btnBasicSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnBasicSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnBasicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnBasicSettings.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menu_btnBasicSettings.Location = new System.Drawing.Point(0, 100);
            this.menu_btnBasicSettings.Margin = new System.Windows.Forms.Padding(0);
            this.menu_btnBasicSettings.Name = "menu_btnBasicSettings";
            this.menu_btnBasicSettings.Size = new System.Drawing.Size(100, 100);
            this.menu_btnBasicSettings.TabIndex = 2;
            this.menu_btnBasicSettings.TabStop = false;
            this.menu_btnBasicSettings.Text = "DHCP Settings";
            this.menu_btnBasicSettings.UseVisualStyleBackColor = false;
            this.menu_btnBasicSettings.Click += new System.EventHandler(this.btnBasicSettings_Click);
            // 
            // menu_btnStaticLeases
            // 
            this.menu_btnStaticLeases.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_btnStaticLeases.FlatAppearance.BorderSize = 0;
            this.menu_btnStaticLeases.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnStaticLeases.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnStaticLeases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnStaticLeases.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menu_btnStaticLeases.Location = new System.Drawing.Point(0, 200);
            this.menu_btnStaticLeases.Margin = new System.Windows.Forms.Padding(0);
            this.menu_btnStaticLeases.Name = "menu_btnStaticLeases";
            this.menu_btnStaticLeases.Size = new System.Drawing.Size(100, 100);
            this.menu_btnStaticLeases.TabIndex = 3;
            this.menu_btnStaticLeases.TabStop = false;
            this.menu_btnStaticLeases.Text = "Static Leases";
            this.menu_btnStaticLeases.UseVisualStyleBackColor = false;
            this.menu_btnStaticLeases.Click += new System.EventHandler(this.btnStaticLeases_Click);
            // 
            // menu_btnClients
            // 
            this.menu_btnClients.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_btnClients.FlatAppearance.BorderSize = 0;
            this.menu_btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnClients.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menu_btnClients.Location = new System.Drawing.Point(0, 300);
            this.menu_btnClients.Margin = new System.Windows.Forms.Padding(0);
            this.menu_btnClients.Name = "menu_btnClients";
            this.menu_btnClients.Size = new System.Drawing.Size(100, 100);
            this.menu_btnClients.TabIndex = 4;
            this.menu_btnClients.TabStop = false;
            this.menu_btnClients.Text = "Conected Clients";
            this.menu_btnClients.UseVisualStyleBackColor = false;
            this.menu_btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // menu_panelMain
            // 
            this.menu_panelMain.AutoScroll = true;
            this.menu_panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_panelMain.Controls.Add(this.menu_btnOverview);
            this.menu_panelMain.Controls.Add(this.menu_btnBasicSettings);
            this.menu_panelMain.Controls.Add(this.menu_btnStaticLeases);
            this.menu_panelMain.Controls.Add(this.menu_btnClients);
            this.menu_panelMain.Controls.Add(this.button1);
            this.menu_panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menu_panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_panelMain.Location = new System.Drawing.Point(0, 0);
            this.menu_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.menu_panelMain.Name = "menu_panelMain";
            this.menu_panelMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_panelMain.Size = new System.Drawing.Size(100, 611);
            this.menu_panelMain.TabIndex = 1;
            // 
            // menuBottom_btnSave
            // 
            this.menuBottom_btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_btnSave.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnSave.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menuBottom_btnSave.Location = new System.Drawing.Point(0, 0);
            this.menuBottom_btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.menuBottom_btnSave.Name = "menuBottom_btnSave";
            this.menuBottom_btnSave.Size = new System.Drawing.Size(100, 60);
            this.menuBottom_btnSave.TabIndex = 5;
            this.menuBottom_btnSave.TabStop = false;
            this.menuBottom_btnSave.Text = "Save Config";
            this.menuBottom_btnSave.UseVisualStyleBackColor = false;
            this.menuBottom_btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // settings_panelMain
            // 
            this.settings_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_panelMain.AutoScroll = true;
            this.settings_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.settings_panelMain.Controls.Add(this.settings_panelInfo);
            this.settings_panelMain.Controls.Add(this.settings_panelInput);
            this.settings_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.settings_panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settings_panelMain.Location = new System.Drawing.Point(100, 0);
            this.settings_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.settings_panelMain.Name = "settings_panelMain";
            this.settings_panelMain.Size = new System.Drawing.Size(772, 551);
            this.settings_panelMain.TabIndex = 3;
            this.settings_panelMain.Visible = false;
            // 
            // settings_panelInfo
            // 
            this.settings_panelInfo.ColumnCount = 3;
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInfo.Controls.Add(this.label1, 2, 2);
            this.settings_panelInfo.Controls.Add(this.panel4, 1, 2);
            this.settings_panelInfo.Controls.Add(this.hostGateway_lbl, 0, 2);
            this.settings_panelInfo.Controls.Add(this.panel3, 1, 1);
            this.settings_panelInfo.Controls.Add(this.hostIP_lbl, 0, 0);
            this.settings_panelInfo.Controls.Add(this.hostSubnetMask_lbl, 0, 1);
            this.settings_panelInfo.Controls.Add(this.hostIP_lblInfo, 2, 0);
            this.settings_panelInfo.Controls.Add(this.hostSubnetMask_lblInfo, 2, 1);
            this.settings_panelInfo.Controls.Add(this.panel2, 1, 0);
            this.settings_panelInfo.Location = new System.Drawing.Point(3, 3);
            this.settings_panelInfo.Name = "settings_panelInfo";
            this.settings_panelInfo.RowCount = 4;
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.Size = new System.Drawing.Size(717, 94);
            this.settings_panelInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.label1.Location = new System.Drawing.Point(333, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Standard gateway of host";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.hostGateway_tb);
            this.panel4.Location = new System.Drawing.Point(150, 60);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 30);
            this.panel4.TabIndex = 9;
            // 
            // hostGateway_tb
            // 
            this.hostGateway_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hostGateway_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostGateway_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "HostGateway", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostGateway_tb.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostGateway_tb.Location = new System.Drawing.Point(0, 0);
            this.hostGateway_tb.Margin = new System.Windows.Forms.Padding(2);
            this.hostGateway_tb.Multiline = true;
            this.hostGateway_tb.Name = "hostGateway_tb";
            this.hostGateway_tb.ReadOnly = true;
            this.hostGateway_tb.Size = new System.Drawing.Size(150, 30);
            this.hostGateway_tb.TabIndex = 0;
            this.hostGateway_tb.TabStop = false;
            // 
            // hostGateway_lbl
            // 
            this.hostGateway_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostGateway_lbl.AutoSize = true;
            this.hostGateway_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostGateway_lbl.Location = new System.Drawing.Point(3, 65);
            this.hostGateway_lbl.Name = "hostGateway_lbl";
            this.hostGateway_lbl.Size = new System.Drawing.Size(109, 20);
            this.hostGateway_lbl.TabIndex = 8;
            this.hostGateway_lbl.Text = "Host Gateway";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.hostSubnetMask_tb);
            this.panel3.Location = new System.Drawing.Point(150, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 30);
            this.panel3.TabIndex = 7;
            // 
            // hostSubnetMask_tb
            // 
            this.hostSubnetMask_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hostSubnetMask_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostSubnetMask_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "HostSubnetMask", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostSubnetMask_tb.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostSubnetMask_tb.Location = new System.Drawing.Point(0, 0);
            this.hostSubnetMask_tb.Margin = new System.Windows.Forms.Padding(2);
            this.hostSubnetMask_tb.Multiline = true;
            this.hostSubnetMask_tb.Name = "hostSubnetMask_tb";
            this.hostSubnetMask_tb.ReadOnly = true;
            this.hostSubnetMask_tb.Size = new System.Drawing.Size(150, 26);
            this.hostSubnetMask_tb.TabIndex = 0;
            this.hostSubnetMask_tb.TabStop = false;
            // 
            // hostIP_lbl
            // 
            this.hostIP_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lbl.AutoSize = true;
            this.hostIP_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostIP_lbl.Location = new System.Drawing.Point(3, 5);
            this.hostIP_lbl.Name = "hostIP_lbl";
            this.hostIP_lbl.Size = new System.Drawing.Size(60, 20);
            this.hostIP_lbl.TabIndex = 0;
            this.hostIP_lbl.Text = "Host IP";
            // 
            // hostSubnetMask_lbl
            // 
            this.hostSubnetMask_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostSubnetMask_lbl.AutoSize = true;
            this.hostSubnetMask_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostSubnetMask_lbl.Location = new System.Drawing.Point(3, 35);
            this.hostSubnetMask_lbl.Name = "hostSubnetMask_lbl";
            this.hostSubnetMask_lbl.Size = new System.Drawing.Size(138, 20);
            this.hostSubnetMask_lbl.TabIndex = 1;
            this.hostSubnetMask_lbl.Text = "Host Subnet Mask";
            // 
            // hostIP_lblInfo
            // 
            this.hostIP_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lblInfo.AutoSize = true;
            this.hostIP_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostIP_lblInfo.Location = new System.Drawing.Point(333, 5);
            this.hostIP_lblInfo.Name = "hostIP_lblInfo";
            this.hostIP_lblInfo.Size = new System.Drawing.Size(137, 20);
            this.hostIP_lblInfo.TabIndex = 4;
            this.hostIP_lblInfo.Text = "IP address of host";
            // 
            // hostSubnetMask_lblInfo
            // 
            this.hostSubnetMask_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostSubnetMask_lblInfo.AutoSize = true;
            this.hostSubnetMask_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostSubnetMask_lblInfo.Location = new System.Drawing.Point(333, 35);
            this.hostSubnetMask_lblInfo.Name = "hostSubnetMask_lblInfo";
            this.hostSubnetMask_lblInfo.Size = new System.Drawing.Size(156, 20);
            this.hostSubnetMask_lblInfo.TabIndex = 5;
            this.hostSubnetMask_lblInfo.Text = "Subnet mask of host";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.hostIP_tb);
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 30);
            this.panel2.TabIndex = 6;
            // 
            // hostIP_tb
            // 
            this.hostIP_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hostIP_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostIP_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "HostIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostIP_tb.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.hostIP_tb.Location = new System.Drawing.Point(0, 0);
            this.hostIP_tb.Margin = new System.Windows.Forms.Padding(2);
            this.hostIP_tb.Multiline = true;
            this.hostIP_tb.Name = "hostIP_tb";
            this.hostIP_tb.ReadOnly = true;
            this.hostIP_tb.Size = new System.Drawing.Size(150, 26);
            this.hostIP_tb.TabIndex = 0;
            this.hostIP_tb.TabStop = false;
            // 
            // settings_panelInput
            // 
            this.settings_panelInput.ColumnCount = 3;
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInput.Controls.Add(this.maxLease_lblInfo, 2, 8);
            this.settings_panelInput.Controls.Add(this.maxLease_pnl, 1, 8);
            this.settings_panelInput.Controls.Add(this.maxLease_lbl, 0, 8);
            this.settings_panelInput.Controls.Add(this.defaultLease_lblInfo, 2, 7);
            this.settings_panelInput.Controls.Add(this.defaultLease_lbl, 0, 7);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lblInfo, 2, 0);
            this.settings_panelInput.Controls.Add(this.subnetMask_lbl, 0, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lbl, 0, 3);
            this.settings_panelInput.Controls.Add(this.subnetMask_lblInfo, 2, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lblInfo, 2, 3);
            this.settings_panelInput.Controls.Add(this.primaryDNS_lbl, 0, 4);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_lbl, 0, 5);
            this.settings_panelInput.Controls.Add(this.primaryDNS_lblInfo, 2, 4);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_lblInfo, 2, 5);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_panelInput, 1, 0);
            this.settings_panelInput.Controls.Add(this.subnet_panelInput, 1, 1);
            this.settings_panelInput.Controls.Add(this.subnetMask_panelInput, 1, 2);
            this.settings_panelInput.Controls.Add(this.gateway_inputPanel, 1, 3);
            this.settings_panelInput.Controls.Add(this.primaryDNS_panelInput, 1, 4);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_panelInput, 1, 5);
            this.settings_panelInput.Controls.Add(this.ipRangeEnde_panelInput, 1, 6);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lbl, 0, 1);
            this.settings_panelInput.Controls.Add(this.subnet_lbl, 0, 6);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lblInfo, 2, 1);
            this.settings_panelInput.Controls.Add(this.subnet_lblInfo, 2, 6);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lbl, 0, 0);
            this.settings_panelInput.Controls.Add(this.defaultLease_pnl, 1, 7);
            this.settings_panelInput.Location = new System.Drawing.Point(3, 103);
            this.settings_panelInput.Name = "settings_panelInput";
            this.settings_panelInput.RowCount = 10;
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.Size = new System.Drawing.Size(717, 394);
            this.settings_panelInput.TabIndex = 0;
            // 
            // maxLease_lblInfo
            // 
            this.maxLease_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxLease_lblInfo.AutoSize = true;
            this.maxLease_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.maxLease_lblInfo.Location = new System.Drawing.Point(333, 245);
            this.maxLease_lblInfo.Name = "maxLease_lblInfo";
            this.maxLease_lblInfo.Size = new System.Drawing.Size(222, 20);
            this.maxLease_lblInfo.TabIndex = 23;
            this.maxLease_lblInfo.Text = "Maximal time for DHCP leases";
            // 
            // maxLease_pnl
            // 
            this.maxLease_pnl.Controls.Add(this.maxLease_input);
            this.maxLease_pnl.Location = new System.Drawing.Point(150, 240);
            this.maxLease_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.maxLease_pnl.Name = "maxLease_pnl";
            this.maxLease_pnl.Size = new System.Drawing.Size(180, 30);
            this.maxLease_pnl.TabIndex = 22;
            // 
            // maxLease_input
            // 
            this.maxLease_input.BackColor = System.Drawing.Color.White;
            this.maxLease_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxLease_input.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsBindingSource, "MaxLeaseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxLease_input.Location = new System.Drawing.Point(2, 4);
            this.maxLease_input.Margin = new System.Windows.Forms.Padding(2);
            this.maxLease_input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxLease_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxLease_input.Name = "maxLease_input";
            this.maxLease_input.Size = new System.Drawing.Size(150, 22);
            this.maxLease_input.TabIndex = 21;
            this.maxLease_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxLease_lbl
            // 
            this.maxLease_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxLease_lbl.AutoSize = true;
            this.maxLease_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.maxLease_lbl.Location = new System.Drawing.Point(3, 245);
            this.maxLease_lbl.Name = "maxLease_lbl";
            this.maxLease_lbl.Size = new System.Drawing.Size(114, 20);
            this.maxLease_lbl.TabIndex = 21;
            this.maxLease_lbl.Text = "Max Leasetime";
            // 
            // defaultLease_lblInfo
            // 
            this.defaultLease_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.defaultLease_lblInfo.AutoSize = true;
            this.defaultLease_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.defaultLease_lblInfo.Location = new System.Drawing.Point(333, 215);
            this.defaultLease_lblInfo.Name = "defaultLease_lblInfo";
            this.defaultLease_lblInfo.Size = new System.Drawing.Size(218, 20);
            this.defaultLease_lblInfo.TabIndex = 20;
            this.defaultLease_lblInfo.Text = "Default time for DHCP leases";
            // 
            // defaultLease_lbl
            // 
            this.defaultLease_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.defaultLease_lbl.AutoSize = true;
            this.defaultLease_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.defaultLease_lbl.Location = new System.Drawing.Point(3, 215);
            this.defaultLease_lbl.Name = "defaultLease_lbl";
            this.defaultLease_lbl.Size = new System.Drawing.Size(138, 20);
            this.defaultLease_lbl.TabIndex = 18;
            this.defaultLease_lbl.Text = "Default Leasetime";
            // 
            // ipRangeStart_lblInfo
            // 
            this.ipRangeStart_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_lblInfo.AutoSize = true;
            this.ipRangeStart_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ipRangeStart_lblInfo.Location = new System.Drawing.Point(333, 5);
            this.ipRangeStart_lblInfo.Name = "ipRangeStart_lblInfo";
            this.ipRangeStart_lblInfo.Size = new System.Drawing.Size(271, 20);
            this.ipRangeStart_lblInfo.TabIndex = 1;
            this.ipRangeStart_lblInfo.Text = "First IP address of DHCP client range";
            // 
            // subnetMask_lbl
            // 
            this.subnetMask_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_lbl.AutoSize = true;
            this.subnetMask_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.subnetMask_lbl.Location = new System.Drawing.Point(3, 65);
            this.subnetMask_lbl.Name = "subnetMask_lbl";
            this.subnetMask_lbl.Size = new System.Drawing.Size(100, 20);
            this.subnetMask_lbl.TabIndex = 8;
            this.subnetMask_lbl.Text = "Subnet Mask";
            // 
            // gateway_lbl
            // 
            this.gateway_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_lbl.AutoSize = true;
            this.gateway_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.gateway_lbl.Location = new System.Drawing.Point(3, 95);
            this.gateway_lbl.Name = "gateway_lbl";
            this.gateway_lbl.Size = new System.Drawing.Size(71, 20);
            this.gateway_lbl.TabIndex = 9;
            this.gateway_lbl.Text = "Gateway";
            // 
            // subnetMask_lblInfo
            // 
            this.subnetMask_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_lblInfo.AutoSize = true;
            this.subnetMask_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.subnetMask_lblInfo.Location = new System.Drawing.Point(333, 65);
            this.subnetMask_lblInfo.Name = "subnetMask_lblInfo";
            this.subnetMask_lblInfo.Size = new System.Drawing.Size(209, 20);
            this.subnetMask_lblInfo.TabIndex = 10;
            this.subnetMask_lblInfo.Text = "Subnet mak of DCHP  range";
            // 
            // gateway_lblInfo
            // 
            this.gateway_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_lblInfo.AutoSize = true;
            this.gateway_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.gateway_lblInfo.Location = new System.Drawing.Point(333, 95);
            this.gateway_lblInfo.Name = "gateway_lblInfo";
            this.gateway_lblInfo.Size = new System.Drawing.Size(267, 20);
            this.gateway_lblInfo.TabIndex = 11;
            this.gateway_lblInfo.Text = "Gateway for DHCP clients (optional)";
            // 
            // primaryDNS_lbl
            // 
            this.primaryDNS_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_lbl.AutoSize = true;
            this.primaryDNS_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.primaryDNS_lbl.Location = new System.Drawing.Point(3, 125);
            this.primaryDNS_lbl.Name = "primaryDNS_lbl";
            this.primaryDNS_lbl.Size = new System.Drawing.Size(97, 20);
            this.primaryDNS_lbl.TabIndex = 12;
            this.primaryDNS_lbl.Text = "Primary DNS";
            // 
            // secondaryDNS_lbl
            // 
            this.secondaryDNS_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_lbl.AutoSize = true;
            this.secondaryDNS_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.secondaryDNS_lbl.Location = new System.Drawing.Point(3, 155);
            this.secondaryDNS_lbl.Name = "secondaryDNS_lbl";
            this.secondaryDNS_lbl.Size = new System.Drawing.Size(119, 20);
            this.secondaryDNS_lbl.TabIndex = 13;
            this.secondaryDNS_lbl.Text = "Secondary DNS";
            // 
            // primaryDNS_lblInfo
            // 
            this.primaryDNS_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_lblInfo.AutoSize = true;
            this.primaryDNS_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.primaryDNS_lblInfo.Location = new System.Drawing.Point(333, 125);
            this.primaryDNS_lblInfo.Name = "primaryDNS_lblInfo";
            this.primaryDNS_lblInfo.Size = new System.Drawing.Size(145, 20);
            this.primaryDNS_lblInfo.TabIndex = 14;
            this.primaryDNS_lblInfo.Text = "Primary DNS server";
            // 
            // secondaryDNS_lblInfo
            // 
            this.secondaryDNS_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_lblInfo.AutoSize = true;
            this.secondaryDNS_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.secondaryDNS_lblInfo.Location = new System.Drawing.Point(333, 155);
            this.secondaryDNS_lblInfo.Name = "secondaryDNS_lblInfo";
            this.secondaryDNS_lblInfo.Size = new System.Drawing.Size(145, 20);
            this.secondaryDNS_lblInfo.TabIndex = 15;
            this.secondaryDNS_lblInfo.Text = "Primary DNS server";
            // 
            // ipRangeStart_panelInput
            // 
            this.ipRangeStart_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.ipRangeStart_panelInput.Controls.Add(this.ipRangeStart_input);
            this.statusRequired.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.ipRangeStart_panelInput.Location = new System.Drawing.Point(150, 0);
            this.ipRangeStart_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.ipRangeStart_panelInput.Name = "ipRangeStart_panelInput";
            this.ipRangeStart_panelInput.Size = new System.Drawing.Size(180, 30);
            this.ipRangeStart_panelInput.TabIndex = 0;
            // 
            // ipRangeStart_input
            // 
            this.ipRangeStart_input.AllowInternalTab = true;
            this.ipRangeStart_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_input.AutoHeight = false;
            this.ipRangeStart_input.BackColor = System.Drawing.Color.White;
            this.ipRangeStart_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipRangeStart_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeStart_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "IpRangeStart", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ipRangeStart_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipRangeStart_input.Location = new System.Drawing.Point(2, 2);
            this.ipRangeStart_input.Margin = new System.Windows.Forms.Padding(2);
            this.ipRangeStart_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.ipRangeStart_input.Name = "ipRangeStart_input";
            this.ipRangeStart_input.ReadOnly = false;
            this.ipRangeStart_input.Size = new System.Drawing.Size(150, 26);
            this.ipRangeStart_input.TabIndex = 1;
            this.ipRangeStart_input.Text = "...";
            this.ipRangeStart_input.Validated += new System.EventHandler(this.settings_validateIpInput);
            // 
            // subnet_panelInput
            // 
            this.subnet_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.subnet_panelInput.Controls.Add(this.ipRangeEnd_input);
            this.subnet_panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subnet_panelInput.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.subnet_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.subnet_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.subnet_panelInput, 1);
            this.subnet_panelInput.Location = new System.Drawing.Point(150, 30);
            this.subnet_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.subnet_panelInput.Name = "subnet_panelInput";
            this.subnet_panelInput.Size = new System.Drawing.Size(180, 30);
            this.subnet_panelInput.TabIndex = 0;
            // 
            // ipRangeEnd_input
            // 
            this.ipRangeEnd_input.AllowInternalTab = true;
            this.ipRangeEnd_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_input.AutoHeight = false;
            this.ipRangeEnd_input.BackColor = System.Drawing.Color.White;
            this.ipRangeEnd_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipRangeEnd_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeEnd_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "IpRangeEnd", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ipRangeEnd_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipRangeEnd_input.Location = new System.Drawing.Point(2, 2);
            this.ipRangeEnd_input.Margin = new System.Windows.Forms.Padding(2);
            this.ipRangeEnd_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.ipRangeEnd_input.Name = "ipRangeEnd_input";
            this.ipRangeEnd_input.ReadOnly = false;
            this.ipRangeEnd_input.Size = new System.Drawing.Size(150, 26);
            this.ipRangeEnd_input.TabIndex = 5;
            this.ipRangeEnd_input.Text = "...";
            this.ipRangeEnd_input.Validated += new System.EventHandler(this.settings_validateIpRangeEndInput);
            // 
            // subnetMask_panelInput
            // 
            this.subnetMask_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.subnetMask_panelInput.Controls.Add(this.subnetMask_input);
            this.subnetMask_panelInput.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.subnetMask_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.subnetMask_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.subnetMask_panelInput, 1);
            this.subnetMask_panelInput.Location = new System.Drawing.Point(150, 60);
            this.subnetMask_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.subnetMask_panelInput.Name = "subnetMask_panelInput";
            this.subnetMask_panelInput.Size = new System.Drawing.Size(180, 30);
            this.subnetMask_panelInput.TabIndex = 0;
            // 
            // subnetMask_input
            // 
            this.subnetMask_input.AllowInternalTab = true;
            this.subnetMask_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_input.AutoHeight = false;
            this.subnetMask_input.BackColor = System.Drawing.Color.White;
            this.subnetMask_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subnetMask_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnetMask_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "SubnetMask", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.subnetMask_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetMask_input.Location = new System.Drawing.Point(2, 2);
            this.subnetMask_input.Margin = new System.Windows.Forms.Padding(2);
            this.subnetMask_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.subnetMask_input.Name = "subnetMask_input";
            this.subnetMask_input.ReadOnly = false;
            this.subnetMask_input.Size = new System.Drawing.Size(150, 26);
            this.subnetMask_input.TabIndex = 7;
            this.subnetMask_input.Text = "...";
            this.subnetMask_input.Validated += new System.EventHandler(this.settings_validateSubnetMaskInput);
            // 
            // gateway_inputPanel
            // 
            this.gateway_inputPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_inputPanel.BackColor = System.Drawing.Color.Transparent;
            this.gateway_inputPanel.Controls.Add(this.gateway_input);
            this.gateway_inputPanel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.gateway_inputPanel, 1);
            this.validationStatus_ok.SetIconPadding(this.gateway_inputPanel, 1);
            this.validationStatus_error.SetIconPadding(this.gateway_inputPanel, 1);
            this.gateway_inputPanel.Location = new System.Drawing.Point(150, 90);
            this.gateway_inputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gateway_inputPanel.Name = "gateway_inputPanel";
            this.gateway_inputPanel.Size = new System.Drawing.Size(180, 30);
            this.gateway_inputPanel.TabIndex = 0;
            // 
            // gateway_input
            // 
            this.gateway_input.AllowInternalTab = true;
            this.gateway_input.AutoHeight = false;
            this.gateway_input.BackColor = System.Drawing.Color.White;
            this.gateway_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gateway_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gateway_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Gateway", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.gateway_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gateway_input.Location = new System.Drawing.Point(2, 2);
            this.gateway_input.Margin = new System.Windows.Forms.Padding(2);
            this.gateway_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.gateway_input.Name = "gateway_input";
            this.gateway_input.ReadOnly = false;
            this.gateway_input.Size = new System.Drawing.Size(150, 26);
            this.gateway_input.TabIndex = 6;
            this.gateway_input.Text = "...";
            this.gateway_input.Validated += new System.EventHandler(this.settings_validateGatewayInput);
            // 
            // primaryDNS_panelInput
            // 
            this.primaryDNS_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.primaryDNS_panelInput.Controls.Add(this.primaryDNS_input);
            this.primaryDNS_panelInput.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.primaryDNS_panelInput.Location = new System.Drawing.Point(150, 120);
            this.primaryDNS_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.primaryDNS_panelInput.Name = "primaryDNS_panelInput";
            this.primaryDNS_panelInput.Size = new System.Drawing.Size(180, 30);
            this.primaryDNS_panelInput.TabIndex = 0;
            // 
            // primaryDNS_input
            // 
            this.primaryDNS_input.AllowInternalTab = true;
            this.primaryDNS_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_input.AutoHeight = false;
            this.primaryDNS_input.BackColor = System.Drawing.Color.White;
            this.primaryDNS_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.primaryDNS_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.primaryDNS_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "PrimaryDNS", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.primaryDNS_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryDNS_input.Location = new System.Drawing.Point(2, 2);
            this.primaryDNS_input.Margin = new System.Windows.Forms.Padding(2);
            this.primaryDNS_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.primaryDNS_input.Name = "primaryDNS_input";
            this.primaryDNS_input.ReadOnly = false;
            this.primaryDNS_input.Size = new System.Drawing.Size(150, 26);
            this.primaryDNS_input.TabIndex = 4;
            this.primaryDNS_input.Text = "...";
            this.primaryDNS_input.Validated += new System.EventHandler(this.settings_validatePrimaryDNSInput);
            // 
            // secondaryDNS_panelInput
            // 
            this.secondaryDNS_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.secondaryDNS_panelInput.Controls.Add(this.secondaryDNS_input);
            this.secondaryDNS_panelInput.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.secondaryDNS_panelInput.Location = new System.Drawing.Point(150, 150);
            this.secondaryDNS_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.secondaryDNS_panelInput.Name = "secondaryDNS_panelInput";
            this.secondaryDNS_panelInput.Size = new System.Drawing.Size(180, 30);
            this.secondaryDNS_panelInput.TabIndex = 0;
            // 
            // secondaryDNS_input
            // 
            this.secondaryDNS_input.AllowInternalTab = true;
            this.secondaryDNS_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_input.AutoHeight = false;
            this.secondaryDNS_input.BackColor = System.Drawing.Color.White;
            this.secondaryDNS_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryDNS_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondaryDNS_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "SecondaryDNS", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.secondaryDNS_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryDNS_input.Location = new System.Drawing.Point(2, 2);
            this.secondaryDNS_input.Margin = new System.Windows.Forms.Padding(2);
            this.secondaryDNS_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.secondaryDNS_input.Name = "secondaryDNS_input";
            this.secondaryDNS_input.ReadOnly = false;
            this.secondaryDNS_input.Size = new System.Drawing.Size(150, 26);
            this.secondaryDNS_input.TabIndex = 2;
            this.secondaryDNS_input.Text = "...";
            this.secondaryDNS_input.Validated += new System.EventHandler(this.settings_validateSecondaryDNSInput);
            // 
            // ipRangeEnde_panelInput
            // 
            this.ipRangeEnde_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnde_panelInput.BackColor = System.Drawing.Color.Transparent;
            this.ipRangeEnde_panelInput.Controls.Add(this.subnet_input);
            this.ipRangeEnde_panelInput.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.statusRequired.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.ipRangeEnde_panelInput.Location = new System.Drawing.Point(150, 180);
            this.ipRangeEnde_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.ipRangeEnde_panelInput.Name = "ipRangeEnde_panelInput";
            this.ipRangeEnde_panelInput.Size = new System.Drawing.Size(180, 30);
            this.ipRangeEnde_panelInput.TabIndex = 0;
            // 
            // subnet_input
            // 
            this.subnet_input.AllowInternalTab = true;
            this.subnet_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_input.AutoHeight = false;
            this.subnet_input.BackColor = System.Drawing.Color.White;
            this.subnet_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subnet_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnet_input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Subnet", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.subnet_input.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnet_input.Location = new System.Drawing.Point(2, 2);
            this.subnet_input.Margin = new System.Windows.Forms.Padding(2);
            this.subnet_input.MinimumSize = new System.Drawing.Size(93, 19);
            this.subnet_input.Name = "subnet_input";
            this.subnet_input.ReadOnly = false;
            this.subnet_input.Size = new System.Drawing.Size(150, 26);
            this.subnet_input.TabIndex = 3;
            this.subnet_input.Text = "...";
            this.subnet_input.Validated += new System.EventHandler(this.settings_validateSubnetInput);
            // 
            // ipRangeEnd_lbl
            // 
            this.ipRangeEnd_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_lbl.AutoSize = true;
            this.ipRangeEnd_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ipRangeEnd_lbl.Location = new System.Drawing.Point(3, 35);
            this.ipRangeEnd_lbl.Name = "ipRangeEnd_lbl";
            this.ipRangeEnd_lbl.Size = new System.Drawing.Size(102, 20);
            this.ipRangeEnd_lbl.TabIndex = 2;
            this.ipRangeEnd_lbl.Text = "IP Range End";
            // 
            // subnet_lbl
            // 
            this.subnet_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_lbl.AutoSize = true;
            this.subnet_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.subnet_lbl.Location = new System.Drawing.Point(3, 185);
            this.subnet_lbl.Name = "subnet_lbl";
            this.subnet_lbl.Size = new System.Drawing.Size(78, 20);
            this.subnet_lbl.TabIndex = 16;
            this.subnet_lbl.Text = "Subnet ID";
            // 
            // ipRangeEnd_lblInfo
            // 
            this.ipRangeEnd_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_lblInfo.AutoSize = true;
            this.ipRangeEnd_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ipRangeEnd_lblInfo.Location = new System.Drawing.Point(333, 35);
            this.ipRangeEnd_lblInfo.Name = "ipRangeEnd_lblInfo";
            this.ipRangeEnd_lblInfo.Size = new System.Drawing.Size(269, 20);
            this.ipRangeEnd_lblInfo.TabIndex = 3;
            this.ipRangeEnd_lblInfo.Text = "Last IP address of DHCP client range";
            // 
            // subnet_lblInfo
            // 
            this.subnet_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_lblInfo.AutoSize = true;
            this.subnet_lblInfo.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.subnet_lblInfo.Location = new System.Drawing.Point(333, 185);
            this.subnet_lblInfo.Name = "subnet_lblInfo";
            this.subnet_lblInfo.Size = new System.Drawing.Size(78, 20);
            this.subnet_lblInfo.TabIndex = 17;
            this.subnet_lblInfo.Text = "Subnet ID";
            // 
            // ipRangeStart_lbl
            // 
            this.ipRangeStart_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_lbl.AutoSize = true;
            this.ipRangeStart_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ipRangeStart_lbl.Location = new System.Drawing.Point(3, 5);
            this.ipRangeStart_lbl.Name = "ipRangeStart_lbl";
            this.ipRangeStart_lbl.Size = new System.Drawing.Size(110, 20);
            this.ipRangeStart_lbl.TabIndex = 0;
            this.ipRangeStart_lbl.Text = "IP Range Start";
            // 
            // defaultLease_pnl
            // 
            this.defaultLease_pnl.Controls.Add(this.defaultLease_input);
            this.defaultLease_pnl.Location = new System.Drawing.Point(150, 210);
            this.defaultLease_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.defaultLease_pnl.Name = "defaultLease_pnl";
            this.defaultLease_pnl.Size = new System.Drawing.Size(180, 30);
            this.defaultLease_pnl.TabIndex = 0;
            // 
            // defaultLease_input
            // 
            this.defaultLease_input.BackColor = System.Drawing.Color.White;
            this.defaultLease_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defaultLease_input.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsBindingSource, "DefaultLeaseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.defaultLease_input.Location = new System.Drawing.Point(2, 4);
            this.defaultLease_input.Margin = new System.Windows.Forms.Padding(2);
            this.defaultLease_input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.defaultLease_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.defaultLease_input.Name = "defaultLease_input";
            this.defaultLease_input.Size = new System.Drawing.Size(150, 22);
            this.defaultLease_input.TabIndex = 21;
            this.defaultLease_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // staticLeases_panelMain
            // 
            this.staticLeases_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticLeases_panelMain.AutoScroll = true;
            this.staticLeases_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.staticLeases_panelMain.Controls.Add(this.staticLeases_listview);
            this.staticLeases_panelMain.Controls.Add(this.staticLeases_input_lbl);
            this.staticLeases_panelMain.Controls.Add(this.tableLayoutPanel1);
            this.staticLeases_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.staticLeases_panelMain.Location = new System.Drawing.Point(100, -1);
            this.staticLeases_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.staticLeases_panelMain.Name = "staticLeases_panelMain";
            this.staticLeases_panelMain.Size = new System.Drawing.Size(772, 551);
            this.staticLeases_panelMain.TabIndex = 4;
            this.staticLeases_panelMain.Visible = false;
            // 
            // staticLeases_listview
            // 
            this.staticLeases_listview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.staticLeases_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticLeases_listview.CausesValidation = false;
            this.staticLeases_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnDeviceName,
            this.columnMACaddress,
            this.columnIPaddress,
            this.columnedit,
            this.columndelete});
            this.staticLeases_listview.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_listview.FullRowSelect = true;
            this.staticLeases_listview.Location = new System.Drawing.Point(0, 0);
            this.staticLeases_listview.Margin = new System.Windows.Forms.Padding(0);
            this.staticLeases_listview.MultiSelect = false;
            this.staticLeases_listview.Name = "staticLeases_listview";
            this.staticLeases_listview.Size = new System.Drawing.Size(772, 444);
            this.staticLeases_listview.TabIndex = 0;
            this.staticLeases_listview.TabStop = false;
            this.staticLeases_listview.UseCompatibleStateImageBehavior = false;
            this.staticLeases_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 36;
            // 
            // columnDeviceName
            // 
            this.columnDeviceName.Text = "Name";
            this.columnDeviceName.Width = 114;
            // 
            // columnMACaddress
            // 
            this.columnMACaddress.Text = "MAC address";
            this.columnMACaddress.Width = 180;
            // 
            // columnIPaddress
            // 
            this.columnIPaddress.Text = "IP address";
            this.columnIPaddress.Width = 171;
            // 
            // columnedit
            // 
            this.columnedit.Text = "";
            // 
            // columndelete
            // 
            this.columndelete.Text = "";
            // 
            // staticLeases_input_lbl
            // 
            this.staticLeases_input_lbl.AutoSize = true;
            this.staticLeases_input_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_input_lbl.Location = new System.Drawing.Point(3, 444);
            this.staticLeases_input_lbl.Name = "staticLeases_input_lbl";
            this.staticLeases_input_lbl.Size = new System.Drawing.Size(153, 20);
            this.staticLeases_input_lbl.TabIndex = 0;
            this.staticLeases_input_lbl.Text = "add new static lease";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.staticLeases_input_lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.staticLeases_input_lbl_mac, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.staticLeases_input_lbl_ip, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.staticLeases_input_btn_add, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 464);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 67);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // staticLeases_input_lbl_name
            // 
            this.staticLeases_input_lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_lbl_name.AutoSize = true;
            this.staticLeases_input_lbl_name.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_input_lbl_name.Location = new System.Drawing.Point(3, 3);
            this.staticLeases_input_lbl_name.Name = "staticLeases_input_lbl_name";
            this.staticLeases_input_lbl_name.Size = new System.Drawing.Size(50, 20);
            this.staticLeases_input_lbl_name.TabIndex = 0;
            this.staticLeases_input_lbl_name.Text = "Name";
            // 
            // staticLeases_input_lbl_mac
            // 
            this.staticLeases_input_lbl_mac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_lbl_mac.AutoSize = true;
            this.staticLeases_input_lbl_mac.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_input_lbl_mac.Location = new System.Drawing.Point(183, 3);
            this.staticLeases_input_lbl_mac.Name = "staticLeases_input_lbl_mac";
            this.staticLeases_input_lbl_mac.Size = new System.Drawing.Size(103, 20);
            this.staticLeases_input_lbl_mac.TabIndex = 1;
            this.staticLeases_input_lbl_mac.Text = "MAC address";
            // 
            // staticLeases_input_lbl_ip
            // 
            this.staticLeases_input_lbl_ip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_lbl_ip.AutoSize = true;
            this.staticLeases_input_lbl_ip.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_input_lbl_ip.Location = new System.Drawing.Point(368, 3);
            this.staticLeases_input_lbl_ip.Name = "staticLeases_input_lbl_ip";
            this.staticLeases_input_lbl_ip.Size = new System.Drawing.Size(81, 20);
            this.staticLeases_input_lbl_ip.TabIndex = 2;
            this.staticLeases_input_lbl_ip.Text = "IP address";
            // 
            // staticLeases_input_btn_add
            // 
            this.staticLeases_input_btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_btn_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.staticLeases_input_btn_add.FlatAppearance.BorderSize = 0;
            this.staticLeases_input_btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.staticLeases_input_btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.staticLeases_input_btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLeases_input_btn_add.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.staticLeases_input_btn_add.Location = new System.Drawing.Point(558, 30);
            this.staticLeases_input_btn_add.Name = "staticLeases_input_btn_add";
            this.staticLeases_input_btn_add.Size = new System.Drawing.Size(100, 34);
            this.staticLeases_input_btn_add.TabIndex = 4;
            this.staticLeases_input_btn_add.Text = "save";
            this.staticLeases_input_btn_add.UseVisualStyleBackColor = false;
            this.staticLeases_input_btn_add.Click += new System.EventHandler(this.staticLeases_input_btn_add_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.staticLeases_input_tb_name);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(176, 36);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // staticLeases_input_tb_name
            // 
            this.staticLeases_input_tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticLeases_input_tb_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.staticLeases_input_tb_name.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLeases_input_tb_name.Location = new System.Drawing.Point(8, 8);
            this.staticLeases_input_tb_name.Margin = new System.Windows.Forms.Padding(8);
            this.staticLeases_input_tb_name.MaxLength = 20;
            this.staticLeases_input_tb_name.Name = "staticLeases_input_tb_name";
            this.staticLeases_input_tb_name.Size = new System.Drawing.Size(150, 19);
            this.staticLeases_input_tb_name.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.staticLeases_input_tb_mac);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(182, 29);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(181, 36);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // staticLeases_input_tb_mac
            // 
            this.staticLeases_input_tb_mac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_tb_mac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticLeases_input_tb_mac.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLeases_input_tb_mac.Location = new System.Drawing.Point(5, 8);
            this.staticLeases_input_tb_mac.Margin = new System.Windows.Forms.Padding(5, 8, 8, 8);
            this.staticLeases_input_tb_mac.Name = "staticLeases_input_tb_mac";
            this.staticLeases_input_tb_mac.Size = new System.Drawing.Size(150, 19);
            this.staticLeases_input_tb_mac.TabIndex = 2;
            this.staticLeases_input_tb_mac.Validated += new System.EventHandler(this.staticLeases_validateMacInput);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.staticLeases_input_tb_ip);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(367, 29);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(186, 36);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // staticLeases_input_tb_ip
            // 
            this.staticLeases_input_tb_ip.AllowInternalTab = true;
            this.staticLeases_input_tb_ip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staticLeases_input_tb_ip.AutoHeight = false;
            this.staticLeases_input_tb_ip.BackColor = System.Drawing.SystemColors.Window;
            this.staticLeases_input_tb_ip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticLeases_input_tb_ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staticLeases_input_tb_ip.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLeases_input_tb_ip.Location = new System.Drawing.Point(5, 5);
            this.staticLeases_input_tb_ip.Margin = new System.Windows.Forms.Padding(5);
            this.staticLeases_input_tb_ip.MinimumSize = new System.Drawing.Size(93, 19);
            this.staticLeases_input_tb_ip.Name = "staticLeases_input_tb_ip";
            this.staticLeases_input_tb_ip.ReadOnly = false;
            this.staticLeases_input_tb_ip.Size = new System.Drawing.Size(150, 26);
            this.staticLeases_input_tb_ip.TabIndex = 3;
            this.staticLeases_input_tb_ip.Text = "...";
            this.staticLeases_input_tb_ip.Validated += new System.EventHandler(this.staticLeases_validateIpInput);
            // 
            // clients_panelMain
            // 
            this.clients_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clients_panelMain.AutoScroll = true;
            this.clients_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clients_panelMain.Controls.Add(this.clients_dhcpdLeases_listView);
            this.clients_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.clients_panelMain.Location = new System.Drawing.Point(100, 0);
            this.clients_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.clients_panelMain.Name = "clients_panelMain";
            this.clients_panelMain.Size = new System.Drawing.Size(772, 551);
            this.clients_panelMain.TabIndex = 5;
            this.clients_panelMain.Visible = false;
            // 
            // clients_dhcpdLeases_listView
            // 
            this.clients_dhcpdLeases_listView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clients_dhcpdLeases_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clients_dhcpdLeases_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnClientsMAC,
            this.columnClientsName,
            this.columnClientsIP,
            this.columnClientsLeaseStart,
            this.columnClientsLeaseEnd,
            this.columnClientsAddToStatic});
            this.clients_dhcpdLeases_listView.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.clients_dhcpdLeases_listView.FullRowSelect = true;
            this.clients_dhcpdLeases_listView.Location = new System.Drawing.Point(0, 0);
            this.clients_dhcpdLeases_listView.Margin = new System.Windows.Forms.Padding(0);
            this.clients_dhcpdLeases_listView.MultiSelect = false;
            this.clients_dhcpdLeases_listView.Name = "clients_dhcpdLeases_listView";
            this.clients_dhcpdLeases_listView.Size = new System.Drawing.Size(763, 557);
            this.clients_dhcpdLeases_listView.TabIndex = 0;
            this.clients_dhcpdLeases_listView.UseCompatibleStateImageBehavior = false;
            this.clients_dhcpdLeases_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnClientsMAC
            // 
            this.columnClientsMAC.Text = "MAC Address";
            this.columnClientsMAC.Width = 138;
            // 
            // columnClientsName
            // 
            this.columnClientsName.Text = "Host Name";
            this.columnClientsName.Width = 134;
            // 
            // columnClientsIP
            // 
            this.columnClientsIP.Text = "Assigned IP";
            this.columnClientsIP.Width = 150;
            // 
            // columnClientsLeaseStart
            // 
            this.columnClientsLeaseStart.Text = "Lease Start";
            this.columnClientsLeaseStart.Width = 118;
            // 
            // columnClientsLeaseEnd
            // 
            this.columnClientsLeaseEnd.Text = "Lease End";
            this.columnClientsLeaseEnd.Width = 125;
            // 
            // columnClientsAddToStatic
            // 
            this.columnClientsAddToStatic.Text = "Add Static";
            this.columnClientsAddToStatic.Width = 96;
            // 
            // overview_panelMain
            // 
            this.overview_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_panelMain.AutoScroll = true;
            this.overview_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.overview_panelMain.Controls.Add(this.overview_tablepanel);
            this.overview_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.overview_panelMain.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_panelMain.Location = new System.Drawing.Point(100, 0);
            this.overview_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.overview_panelMain.Name = "overview_panelMain";
            this.overview_panelMain.Size = new System.Drawing.Size(772, 551);
            this.overview_panelMain.TabIndex = 2;
            this.overview_panelMain.Visible = false;
            // 
            // overview_tablepanel
            // 
            this.overview_tablepanel.ColumnCount = 4;
            this.overview_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.overview_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.overview_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.overview_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.overview_tablepanel.Controls.Add(this.overview_hostip_status_lbl, 1, 1);
            this.overview_tablepanel.Controls.Add(this.overview_hostip_btn, 3, 1);
            this.overview_tablepanel.Controls.Add(this.panel1, 2, 1);
            this.overview_tablepanel.Controls.Add(this.overview_header_lbl_c1, 0, 0);
            this.overview_tablepanel.Controls.Add(this.overview_header_lbl_c2, 1, 0);
            this.overview_tablepanel.Controls.Add(this.overview_header_lbl_c3, 2, 0);
            this.overview_tablepanel.Controls.Add(this.overview_header_lbl_c4, 3, 0);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpDeamon_lbl, 0, 4);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpDeamon_status_lbl, 1, 4);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpDeamon_info_lbl, 2, 4);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpDeamon_btn, 3, 4);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpServer_lbl, 0, 3);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpServer_status_lbl, 1, 3);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpServer_info_lbl, 2, 3);
            this.overview_tablepanel.Controls.Add(this.overview_dhcpServer_btn, 3, 3);
            this.overview_tablepanel.Controls.Add(this.overview_hostip_lbl, 0, 1);
            this.overview_tablepanel.Controls.Add(this.overview_hostNic_lbl, 0, 2);
            this.overview_tablepanel.Controls.Add(this.overview_hostNic_status_lbl, 1, 2);
            this.overview_tablepanel.Controls.Add(this.overview_hostNic_info_lbl, 2, 2);
            this.overview_tablepanel.Controls.Add(this.overview_hostNic_btn, 3, 2);
            this.overview_tablepanel.Location = new System.Drawing.Point(3, 3);
            this.overview_tablepanel.Name = "overview_tablepanel";
            this.overview_tablepanel.RowCount = 6;
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.overview_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.overview_tablepanel.Size = new System.Drawing.Size(656, 291);
            this.overview_tablepanel.TabIndex = 0;
            // 
            // overview_hostip_status_lbl
            // 
            this.overview_hostip_status_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostip_status_lbl.AutoSize = true;
            this.overview_hostip_status_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "OverviewDhcpStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.overview_hostip_status_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_status_lbl.Location = new System.Drawing.Point(103, 42);
            this.overview_hostip_status_lbl.Name = "overview_hostip_status_lbl";
            this.overview_hostip_status_lbl.Size = new System.Drawing.Size(52, 20);
            this.overview_hostip_status_lbl.TabIndex = 1;
            this.overview_hostip_status_lbl.Text = "status";
            // 
            // overview_hostip_btn
            // 
            this.overview_hostip_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostip_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_hostip_btn.FlatAppearance.BorderSize = 0;
            this.overview_hostip_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_hostip_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_hostip_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_hostip_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_btn.Location = new System.Drawing.Point(549, 32);
            this.overview_hostip_btn.Name = "overview_hostip_btn";
            this.overview_hostip_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_hostip_btn.TabIndex = 9;
            this.overview_hostip_btn.Text = "setIP";
            this.overview_hostip_btn.UseVisualStyleBackColor = false;
            this.overview_hostip_btn.Click += new System.EventHandler(this.overview_hostip_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.overview_hostip_subnetMask_info_lbl);
            this.panel1.Controls.Add(this.overview_hostip_info_lbl);
            this.panel1.Controls.Add(this.overview_hostip_info_subnetMask_lbl);
            this.panel1.Controls.Add(this.overview_hostip_info_ip_lbl);
            this.panel1.Location = new System.Drawing.Point(223, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 49);
            this.panel1.TabIndex = 12;
            // 
            // overview_hostip_subnetMask_info_lbl
            // 
            this.overview_hostip_subnetMask_info_lbl.AutoSize = true;
            this.overview_hostip_subnetMask_info_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_subnetMask_info_lbl.Location = new System.Drawing.Point(3, 26);
            this.overview_hostip_subnetMask_info_lbl.Name = "overview_hostip_subnetMask_info_lbl";
            this.overview_hostip_subnetMask_info_lbl.Size = new System.Drawing.Size(104, 20);
            this.overview_hostip_subnetMask_info_lbl.TabIndex = 5;
            this.overview_hostip_subnetMask_info_lbl.Text = "Subnet mask:";
            // 
            // overview_hostip_info_lbl
            // 
            this.overview_hostip_info_lbl.AutoSize = true;
            this.overview_hostip_info_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_info_lbl.Location = new System.Drawing.Point(3, 3);
            this.overview_hostip_info_lbl.Name = "overview_hostip_info_lbl";
            this.overview_hostip_info_lbl.Size = new System.Drawing.Size(88, 20);
            this.overview_hostip_info_lbl.TabIndex = 4;
            this.overview_hostip_info_lbl.Text = "IP Address:";
            // 
            // overview_hostip_info_subnetMask_lbl
            // 
            this.overview_hostip_info_subnetMask_lbl.AutoSize = true;
            this.overview_hostip_info_subnetMask_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "HostSubnetMask", true));
            this.overview_hostip_info_subnetMask_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_info_subnetMask_lbl.Location = new System.Drawing.Point(116, 26);
            this.overview_hostip_info_subnetMask_lbl.Name = "overview_hostip_info_subnetMask_lbl";
            this.overview_hostip_info_subnetMask_lbl.Size = new System.Drawing.Size(94, 20);
            this.overview_hostip_info_subnetMask_lbl.TabIndex = 3;
            this.overview_hostip_info_subnetMask_lbl.Text = "subnetMask";
            // 
            // overview_hostip_info_ip_lbl
            // 
            this.overview_hostip_info_ip_lbl.AutoSize = true;
            this.overview_hostip_info_ip_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "HostIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.overview_hostip_info_ip_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_info_ip_lbl.Location = new System.Drawing.Point(116, 3);
            this.overview_hostip_info_ip_lbl.Name = "overview_hostip_info_ip_lbl";
            this.overview_hostip_info_ip_lbl.Size = new System.Drawing.Size(21, 20);
            this.overview_hostip_info_ip_lbl.TabIndex = 2;
            this.overview_hostip_info_ip_lbl.Text = "ip";
            // 
            // overview_header_lbl_c1
            // 
            this.overview_header_lbl_c1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_header_lbl_c1.AutoSize = true;
            this.overview_header_lbl_c1.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_header_lbl_c1.Location = new System.Drawing.Point(3, 2);
            this.overview_header_lbl_c1.Name = "overview_header_lbl_c1";
            this.overview_header_lbl_c1.Size = new System.Drawing.Size(72, 20);
            this.overview_header_lbl_c1.TabIndex = 13;
            this.overview_header_lbl_c1.Text = "Property";
            // 
            // overview_header_lbl_c2
            // 
            this.overview_header_lbl_c2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_header_lbl_c2.AutoSize = true;
            this.overview_header_lbl_c2.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_header_lbl_c2.Location = new System.Drawing.Point(103, 2);
            this.overview_header_lbl_c2.Name = "overview_header_lbl_c2";
            this.overview_header_lbl_c2.Size = new System.Drawing.Size(54, 20);
            this.overview_header_lbl_c2.TabIndex = 14;
            this.overview_header_lbl_c2.Text = "Status";
            // 
            // overview_header_lbl_c3
            // 
            this.overview_header_lbl_c3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_header_lbl_c3.AutoSize = true;
            this.overview_header_lbl_c3.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_header_lbl_c3.Location = new System.Drawing.Point(223, 2);
            this.overview_header_lbl_c3.Name = "overview_header_lbl_c3";
            this.overview_header_lbl_c3.Size = new System.Drawing.Size(37, 20);
            this.overview_header_lbl_c3.TabIndex = 15;
            this.overview_header_lbl_c3.Text = "Info";
            // 
            // overview_header_lbl_c4
            // 
            this.overview_header_lbl_c4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_header_lbl_c4.AutoSize = true;
            this.overview_header_lbl_c4.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_header_lbl_c4.Location = new System.Drawing.Point(549, 2);
            this.overview_header_lbl_c4.Name = "overview_header_lbl_c4";
            this.overview_header_lbl_c4.Size = new System.Drawing.Size(56, 20);
            this.overview_header_lbl_c4.TabIndex = 16;
            this.overview_header_lbl_c4.Text = "Action";
            // 
            // overview_dhcpDeamon_lbl
            // 
            this.overview_dhcpDeamon_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpDeamon_lbl.AutoSize = true;
            this.overview_dhcpDeamon_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpDeamon_lbl.Location = new System.Drawing.Point(3, 197);
            this.overview_dhcpDeamon_lbl.Name = "overview_dhcpDeamon_lbl";
            this.overview_dhcpDeamon_lbl.Size = new System.Drawing.Size(69, 40);
            this.overview_dhcpDeamon_lbl.TabIndex = 6;
            this.overview_dhcpDeamon_lbl.Text = "DHCP Deamon";
            // 
            // overview_dhcpDeamon_status_lbl
            // 
            this.overview_dhcpDeamon_status_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpDeamon_status_lbl.AutoSize = true;
            this.overview_dhcpDeamon_status_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "OverviewDhcpServerStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "no status"));
            this.overview_dhcpDeamon_status_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpDeamon_status_lbl.Location = new System.Drawing.Point(103, 207);
            this.overview_dhcpDeamon_status_lbl.Name = "overview_dhcpDeamon_status_lbl";
            this.overview_dhcpDeamon_status_lbl.Size = new System.Drawing.Size(52, 20);
            this.overview_dhcpDeamon_status_lbl.TabIndex = 7;
            this.overview_dhcpDeamon_status_lbl.Text = "status";
            // 
            // overview_dhcpDeamon_info_lbl
            // 
            this.overview_dhcpDeamon_info_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpDeamon_info_lbl.AutoSize = true;
            this.overview_dhcpDeamon_info_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpDeamon_info_lbl.Location = new System.Drawing.Point(223, 207);
            this.overview_dhcpDeamon_info_lbl.Name = "overview_dhcpDeamon_info_lbl";
            this.overview_dhcpDeamon_info_lbl.Size = new System.Drawing.Size(248, 20);
            this.overview_dhcpDeamon_info_lbl.TabIndex = 8;
            this.overview_dhcpDeamon_info_lbl.Text = "Status if DHCP deamon is running";
            // 
            // overview_dhcpDeamon_btn
            // 
            this.overview_dhcpDeamon_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpDeamon_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_dhcpDeamon_btn.FlatAppearance.BorderSize = 0;
            this.overview_dhcpDeamon_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_dhcpDeamon_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_dhcpDeamon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_dhcpDeamon_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpDeamon_btn.Location = new System.Drawing.Point(549, 197);
            this.overview_dhcpDeamon_btn.Name = "overview_dhcpDeamon_btn";
            this.overview_dhcpDeamon_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_dhcpDeamon_btn.TabIndex = 11;
            this.overview_dhcpDeamon_btn.Text = "start/stop";
            this.overview_dhcpDeamon_btn.UseVisualStyleBackColor = false;
            this.overview_dhcpDeamon_btn.Click += new System.EventHandler(this.overview_dhcpDeamon_btn_Click);
            // 
            // overview_dhcpServer_lbl
            // 
            this.overview_dhcpServer_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpServer_lbl.AutoSize = true;
            this.overview_dhcpServer_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpServer_lbl.Location = new System.Drawing.Point(3, 142);
            this.overview_dhcpServer_lbl.Name = "overview_dhcpServer_lbl";
            this.overview_dhcpServer_lbl.Size = new System.Drawing.Size(56, 40);
            this.overview_dhcpServer_lbl.TabIndex = 3;
            this.overview_dhcpServer_lbl.Text = "DHCP Server";
            // 
            // overview_dhcpServer_status_lbl
            // 
            this.overview_dhcpServer_status_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpServer_status_lbl.AutoSize = true;
            this.overview_dhcpServer_status_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "OverviewDhcpServerInstallStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "not installed"));
            this.overview_dhcpServer_status_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpServer_status_lbl.Location = new System.Drawing.Point(103, 152);
            this.overview_dhcpServer_status_lbl.Name = "overview_dhcpServer_status_lbl";
            this.overview_dhcpServer_status_lbl.Size = new System.Drawing.Size(52, 20);
            this.overview_dhcpServer_status_lbl.TabIndex = 4;
            this.overview_dhcpServer_status_lbl.Text = "status";
            // 
            // overview_dhcpServer_info_lbl
            // 
            this.overview_dhcpServer_info_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpServer_info_lbl.AutoSize = true;
            this.overview_dhcpServer_info_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpServer_info_lbl.Location = new System.Drawing.Point(223, 152);
            this.overview_dhcpServer_info_lbl.Name = "overview_dhcpServer_info_lbl";
            this.overview_dhcpServer_info_lbl.Size = new System.Drawing.Size(315, 20);
            this.overview_dhcpServer_info_lbl.TabIndex = 5;
            this.overview_dhcpServer_info_lbl.Text = "Status if DHCP server is installed on system";
            // 
            // overview_dhcpServer_btn
            // 
            this.overview_dhcpServer_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_dhcpServer_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_dhcpServer_btn.FlatAppearance.BorderSize = 0;
            this.overview_dhcpServer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_dhcpServer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_dhcpServer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_dhcpServer_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_dhcpServer_btn.Location = new System.Drawing.Point(549, 142);
            this.overview_dhcpServer_btn.Name = "overview_dhcpServer_btn";
            this.overview_dhcpServer_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_dhcpServer_btn.TabIndex = 10;
            this.overview_dhcpServer_btn.Text = "install";
            this.overview_dhcpServer_btn.UseVisualStyleBackColor = false;
            this.overview_dhcpServer_btn.Click += new System.EventHandler(this.overview_dhcpServer_btn_Click);
            // 
            // overview_hostip_lbl
            // 
            this.overview_hostip_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostip_lbl.AutoSize = true;
            this.overview_hostip_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostip_lbl.Location = new System.Drawing.Point(3, 42);
            this.overview_hostip_lbl.Name = "overview_hostip_lbl";
            this.overview_hostip_lbl.Size = new System.Drawing.Size(60, 20);
            this.overview_hostip_lbl.TabIndex = 0;
            this.overview_hostip_lbl.Text = "Host IP";
            // 
            // overview_hostNic_lbl
            // 
            this.overview_hostNic_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostNic_lbl.AutoSize = true;
            this.overview_hostNic_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostNic_lbl.Location = new System.Drawing.Point(3, 87);
            this.overview_hostNic_lbl.Name = "overview_hostNic_lbl";
            this.overview_hostNic_lbl.Size = new System.Drawing.Size(76, 40);
            this.overview_hostNic_lbl.TabIndex = 17;
            this.overview_hostNic_lbl.Text = "Selected Interface";
            // 
            // overview_hostNic_status_lbl
            // 
            this.overview_hostNic_status_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostNic_status_lbl.AutoSize = true;
            this.overview_hostNic_status_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "OverviewSelectedInterfaceName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.overview_hostNic_status_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostNic_status_lbl.Location = new System.Drawing.Point(103, 97);
            this.overview_hostNic_status_lbl.Name = "overview_hostNic_status_lbl";
            this.overview_hostNic_status_lbl.Size = new System.Drawing.Size(70, 20);
            this.overview_hostNic_status_lbl.TabIndex = 18;
            this.overview_hostNic_status_lbl.Text = "nicName";
            // 
            // overview_hostNic_info_lbl
            // 
            this.overview_hostNic_info_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostNic_info_lbl.AutoSize = true;
            this.overview_hostNic_info_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostNic_info_lbl.Location = new System.Drawing.Point(223, 87);
            this.overview_hostNic_info_lbl.Name = "overview_hostNic_info_lbl";
            this.overview_hostNic_info_lbl.Size = new System.Drawing.Size(295, 40);
            this.overview_hostNic_info_lbl.TabIndex = 19;
            this.overview_hostNic_info_lbl.Text = "Currently selected interface. To change inface click changeNIC.";
            // 
            // overview_hostNic_btn
            // 
            this.overview_hostNic_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_hostNic_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_hostNic_btn.FlatAppearance.BorderSize = 0;
            this.overview_hostNic_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_hostNic_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_hostNic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_hostNic_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_hostNic_btn.Location = new System.Drawing.Point(549, 87);
            this.overview_hostNic_btn.Name = "overview_hostNic_btn";
            this.overview_hostNic_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_hostNic_btn.TabIndex = 20;
            this.overview_hostNic_btn.Text = "changeNIC";
            this.overview_hostNic_btn.UseVisualStyleBackColor = false;
            this.overview_hostNic_btn.Click += new System.EventHandler(this.overview_hostNic_btn_Click);
            // 
            // overview_setHostIp_panel
            // 
            this.overview_setHostIp_panel.Controls.Add(this.overview_setHostIp_lbl);
            this.overview_setHostIp_panel.Controls.Add(this.overview_setHostIp_tablepanel);
            this.overview_setHostIp_panel.Controls.Add(this.flowLayoutPanel5);
            this.overview_setHostIp_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.overview_setHostIp_panel.Location = new System.Drawing.Point(3, 3);
            this.overview_setHostIp_panel.Name = "overview_setHostIp_panel";
            this.overview_setHostIp_panel.Padding = new System.Windows.Forms.Padding(5);
            this.overview_setHostIp_panel.Size = new System.Drawing.Size(671, 220);
            this.overview_setHostIp_panel.TabIndex = 2;
            // 
            // overview_setHostIp_lbl
            // 
            this.overview_setHostIp_lbl.AutoSize = true;
            this.overview_setHostIp_lbl.Location = new System.Drawing.Point(8, 5);
            this.overview_setHostIp_lbl.Name = "overview_setHostIp_lbl";
            this.overview_setHostIp_lbl.Size = new System.Drawing.Size(142, 20);
            this.overview_setHostIp_lbl.TabIndex = 2;
            this.overview_setHostIp_lbl.Text = "Set Host IP adress:";
            // 
            // overview_setHostIp_tablepanel
            // 
            this.overview_setHostIp_tablepanel.ColumnCount = 3;
            this.overview_setHostIp_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.overview_setHostIp_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.overview_setHostIp_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_ip_lbl, 0, 0);
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_ip_lbl_info, 2, 0);
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_subnetmask_lbl, 0, 1);
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_subnetmask_lbl_info, 2, 1);
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_ip_panel, 1, 0);
            this.overview_setHostIp_tablepanel.Controls.Add(this.overview_setHostIp_subnetmask_panel, 1, 1);
            this.overview_setHostIp_tablepanel.Location = new System.Drawing.Point(8, 28);
            this.overview_setHostIp_tablepanel.Name = "overview_setHostIp_tablepanel";
            this.overview_setHostIp_tablepanel.RowCount = 2;
            this.overview_setHostIp_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.overview_setHostIp_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.overview_setHostIp_tablepanel.Size = new System.Drawing.Size(648, 100);
            this.overview_setHostIp_tablepanel.TabIndex = 1;
            // 
            // overview_setHostIp_ip_lbl
            // 
            this.overview_setHostIp_ip_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_ip_lbl.AutoSize = true;
            this.overview_setHostIp_ip_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_ip_lbl.Location = new System.Drawing.Point(3, 15);
            this.overview_setHostIp_ip_lbl.Name = "overview_setHostIp_ip_lbl";
            this.overview_setHostIp_ip_lbl.Size = new System.Drawing.Size(81, 20);
            this.overview_setHostIp_ip_lbl.TabIndex = 0;
            this.overview_setHostIp_ip_lbl.Text = "IP address";
            // 
            // overview_setHostIp_ip_lbl_info
            // 
            this.overview_setHostIp_ip_lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_ip_lbl_info.AutoSize = true;
            this.overview_setHostIp_ip_lbl_info.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_ip_lbl_info.Location = new System.Drawing.Point(323, 15);
            this.overview_setHostIp_ip_lbl_info.Name = "overview_setHostIp_ip_lbl_info";
            this.overview_setHostIp_ip_lbl_info.Size = new System.Drawing.Size(265, 20);
            this.overview_setHostIp_ip_lbl_info.TabIndex = 1;
            this.overview_setHostIp_ip_lbl_info.Text = "Please enter IP address for the host";
            // 
            // overview_setHostIp_subnetmask_lbl
            // 
            this.overview_setHostIp_subnetmask_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_subnetmask_lbl.AutoSize = true;
            this.overview_setHostIp_subnetmask_lbl.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_subnetmask_lbl.Location = new System.Drawing.Point(3, 65);
            this.overview_setHostIp_subnetmask_lbl.Name = "overview_setHostIp_subnetmask_lbl";
            this.overview_setHostIp_subnetmask_lbl.Size = new System.Drawing.Size(100, 20);
            this.overview_setHostIp_subnetmask_lbl.TabIndex = 2;
            this.overview_setHostIp_subnetmask_lbl.Text = "Subnet mask";
            // 
            // overview_setHostIp_subnetmask_lbl_info
            // 
            this.overview_setHostIp_subnetmask_lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_subnetmask_lbl_info.AutoSize = true;
            this.overview_setHostIp_subnetmask_lbl_info.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_subnetmask_lbl_info.Location = new System.Drawing.Point(323, 65);
            this.overview_setHostIp_subnetmask_lbl_info.Name = "overview_setHostIp_subnetmask_lbl_info";
            this.overview_setHostIp_subnetmask_lbl_info.Size = new System.Drawing.Size(294, 20);
            this.overview_setHostIp_subnetmask_lbl_info.TabIndex = 3;
            this.overview_setHostIp_subnetmask_lbl_info.Text = "Please enter a subnet mask for the host";
            // 
            // overview_setHostIp_ip_panel
            // 
            this.overview_setHostIp_ip_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_ip_panel.Controls.Add(this.overview_setHostIp_ip_ipinput);
            this.overview_setHostIp_ip_panel.Location = new System.Drawing.Point(123, 3);
            this.overview_setHostIp_ip_panel.Name = "overview_setHostIp_ip_panel";
            this.overview_setHostIp_ip_panel.Padding = new System.Windows.Forms.Padding(6);
            this.overview_setHostIp_ip_panel.Size = new System.Drawing.Size(194, 44);
            this.overview_setHostIp_ip_panel.TabIndex = 4;
            // 
            // overview_setHostIp_ip_ipinput
            // 
            this.overview_setHostIp_ip_ipinput.AllowInternalTab = false;
            this.overview_setHostIp_ip_ipinput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_ip_ipinput.AutoHeight = false;
            this.overview_setHostIp_ip_ipinput.BackColor = System.Drawing.SystemColors.Window;
            this.overview_setHostIp_ip_ipinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overview_setHostIp_ip_ipinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overview_setHostIp_ip_ipinput.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_setHostIp_ip_ipinput.Location = new System.Drawing.Point(9, 9);
            this.overview_setHostIp_ip_ipinput.MinimumSize = new System.Drawing.Size(93, 19);
            this.overview_setHostIp_ip_ipinput.Name = "overview_setHostIp_ip_ipinput";
            this.overview_setHostIp_ip_ipinput.ReadOnly = false;
            this.overview_setHostIp_ip_ipinput.Size = new System.Drawing.Size(150, 22);
            this.overview_setHostIp_ip_ipinput.TabIndex = 1;
            this.overview_setHostIp_ip_ipinput.Text = "...";
            this.overview_setHostIp_ip_ipinput.Validated += new System.EventHandler(this.overview_validateIpInput);
            // 
            // overview_setHostIp_subnetmask_panel
            // 
            this.overview_setHostIp_subnetmask_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_subnetmask_panel.Controls.Add(this.overview_setHostIp_subnetmask_ipinput);
            this.overview_setHostIp_subnetmask_panel.Location = new System.Drawing.Point(123, 53);
            this.overview_setHostIp_subnetmask_panel.Name = "overview_setHostIp_subnetmask_panel";
            this.overview_setHostIp_subnetmask_panel.Padding = new System.Windows.Forms.Padding(6);
            this.overview_setHostIp_subnetmask_panel.Size = new System.Drawing.Size(194, 44);
            this.overview_setHostIp_subnetmask_panel.TabIndex = 5;
            // 
            // overview_setHostIp_subnetmask_ipinput
            // 
            this.overview_setHostIp_subnetmask_ipinput.AllowInternalTab = false;
            this.overview_setHostIp_subnetmask_ipinput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_subnetmask_ipinput.AutoHeight = false;
            this.overview_setHostIp_subnetmask_ipinput.BackColor = System.Drawing.SystemColors.Window;
            this.overview_setHostIp_subnetmask_ipinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overview_setHostIp_subnetmask_ipinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overview_setHostIp_subnetmask_ipinput.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_setHostIp_subnetmask_ipinput.Location = new System.Drawing.Point(9, 9);
            this.overview_setHostIp_subnetmask_ipinput.MinimumSize = new System.Drawing.Size(93, 19);
            this.overview_setHostIp_subnetmask_ipinput.Name = "overview_setHostIp_subnetmask_ipinput";
            this.overview_setHostIp_subnetmask_ipinput.ReadOnly = false;
            this.overview_setHostIp_subnetmask_ipinput.Size = new System.Drawing.Size(150, 23);
            this.overview_setHostIp_subnetmask_ipinput.TabIndex = 2;
            this.overview_setHostIp_subnetmask_ipinput.Text = "...";
            this.overview_setHostIp_subnetmask_ipinput.Validated += new System.EventHandler(this.overview_validateSubnetMaskInput);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.overview_setHostIp_set_btn);
            this.flowLayoutPanel5.Controls.Add(this.overview_setHostIp_cancel_btn);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 134);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(236, 51);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // overview_setHostIp_set_btn
            // 
            this.overview_setHostIp_set_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_set_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_setHostIp_set_btn.FlatAppearance.BorderSize = 0;
            this.overview_setHostIp_set_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.overview_setHostIp_set_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_setHostIp_set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_setHostIp_set_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_set_btn.Location = new System.Drawing.Point(3, 3);
            this.overview_setHostIp_set_btn.Name = "overview_setHostIp_set_btn";
            this.overview_setHostIp_set_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_setHostIp_set_btn.TabIndex = 3;
            this.overview_setHostIp_set_btn.Text = "save";
            this.overview_setHostIp_set_btn.UseVisualStyleBackColor = false;
            this.overview_setHostIp_set_btn.Click += new System.EventHandler(this.overview_setHostIp_set_btn_Click);
            // 
            // overview_setHostIp_cancel_btn
            // 
            this.overview_setHostIp_cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overview_setHostIp_cancel_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.overview_setHostIp_cancel_btn.FlatAppearance.BorderSize = 0;
            this.overview_setHostIp_cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.overview_setHostIp_cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.overview_setHostIp_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_setHostIp_cancel_btn.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.overview_setHostIp_cancel_btn.Location = new System.Drawing.Point(109, 3);
            this.overview_setHostIp_cancel_btn.Name = "overview_setHostIp_cancel_btn";
            this.overview_setHostIp_cancel_btn.Size = new System.Drawing.Size(100, 40);
            this.overview_setHostIp_cancel_btn.TabIndex = 4;
            this.overview_setHostIp_cancel_btn.Text = "cancel";
            this.overview_setHostIp_cancel_btn.UseVisualStyleBackColor = false;
            this.overview_setHostIp_cancel_btn.Click += new System.EventHandler(this.overview_setHostIp_cancel_btn_Click);
            // 
            // validationStatus_error
            // 
            this.validationStatus_error.ContainerControl = this;
            this.validationStatus_error.Icon = ((System.Drawing.Icon)(resources.GetObject("validationStatus_error.Icon")));
            // 
            // validationStatus_ok
            // 
            this.validationStatus_ok.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validationStatus_ok.ContainerControl = this;
            this.validationStatus_ok.Icon = ((System.Drawing.Icon)(resources.GetObject("validationStatus_ok.Icon")));
            // 
            // menuBottom_panelMain
            // 
            this.menuBottom_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBottom_panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnSave);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnLoad);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnApply);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_LoadFromDhcp);
            this.menuBottom_panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuBottom_panelMain.Location = new System.Drawing.Point(100, 551);
            this.menuBottom_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.menuBottom_panelMain.Name = "menuBottom_panelMain";
            this.menuBottom_panelMain.Size = new System.Drawing.Size(772, 60);
            this.menuBottom_panelMain.TabIndex = 6;
            // 
            // menuBottom_btnLoad
            // 
            this.menuBottom_btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_btnLoad.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnLoad.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menuBottom_btnLoad.Location = new System.Drawing.Point(100, 0);
            this.menuBottom_btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.menuBottom_btnLoad.Name = "menuBottom_btnLoad";
            this.menuBottom_btnLoad.Size = new System.Drawing.Size(100, 60);
            this.menuBottom_btnLoad.TabIndex = 6;
            this.menuBottom_btnLoad.TabStop = false;
            this.menuBottom_btnLoad.Text = "Load Config";
            this.menuBottom_btnLoad.UseVisualStyleBackColor = false;
            this.menuBottom_btnLoad.Click += new System.EventHandler(this.menuBottom_btnLoad_Click);
            // 
            // menuBottom_btnApply
            // 
            this.menuBottom_btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnApply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_btnApply.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnApply.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menuBottom_btnApply.Location = new System.Drawing.Point(200, 0);
            this.menuBottom_btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.menuBottom_btnApply.Name = "menuBottom_btnApply";
            this.menuBottom_btnApply.Size = new System.Drawing.Size(100, 60);
            this.menuBottom_btnApply.TabIndex = 7;
            this.menuBottom_btnApply.TabStop = false;
            this.menuBottom_btnApply.Text = "Apply to DHCP Server";
            this.menuBottom_btnApply.UseVisualStyleBackColor = false;
            this.menuBottom_btnApply.Click += new System.EventHandler(this.menuBottom_btnApply_Click);
            // 
            // menuBottom_LoadFromDhcp
            // 
            this.menuBottom_LoadFromDhcp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_LoadFromDhcp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_LoadFromDhcp.FlatAppearance.BorderSize = 0;
            this.menuBottom_LoadFromDhcp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_LoadFromDhcp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuBottom_LoadFromDhcp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_LoadFromDhcp.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menuBottom_LoadFromDhcp.Location = new System.Drawing.Point(300, 0);
            this.menuBottom_LoadFromDhcp.Margin = new System.Windows.Forms.Padding(0);
            this.menuBottom_LoadFromDhcp.Name = "menuBottom_LoadFromDhcp";
            this.menuBottom_LoadFromDhcp.Size = new System.Drawing.Size(100, 60);
            this.menuBottom_LoadFromDhcp.TabIndex = 8;
            this.menuBottom_LoadFromDhcp.TabStop = false;
            this.menuBottom_LoadFromDhcp.Text = "Load from DHCP";
            this.menuBottom_LoadFromDhcp.UseVisualStyleBackColor = false;
            this.menuBottom_LoadFromDhcp.Click += new System.EventHandler(this.menuBottom_loadFromDhcp_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "gm4d";
            this.saveFileDialog.Filter = "GM4D configuration files|*.gm4d|All files|*.*";
            this.saveFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "gm4d";
            this.openFileDialog.Filter = "GM4D configuration files|*.gm4d|All files|*.*";
            this.openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // statusRequired
            // 
            this.statusRequired.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.statusRequired.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // changeNic_panelMain
            // 
            this.changeNic_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeNic_panelMain.AutoScroll = true;
            this.changeNic_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.changeNic_panelMain.Controls.Add(this.selectNic_listview);
            this.changeNic_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.changeNic_panelMain.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.changeNic_panelMain.Location = new System.Drawing.Point(100, 0);
            this.changeNic_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.changeNic_panelMain.Name = "changeNic_panelMain";
            this.changeNic_panelMain.Size = new System.Drawing.Size(772, 551);
            this.changeNic_panelMain.TabIndex = 7;
            this.changeNic_panelMain.Visible = false;
            // 
            // selectNic_listview
            // 
            this.selectNic_listview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.selectNic_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectNic_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.changeNicColumnHeader0,
            this.changeNicColumnHeader1,
            this.changeNicColumnHeader2,
            this.changeNicColumnHeader3,
            this.changeNicColumnHeader4,
            this.changeNicColumnHeader5});
            this.selectNic_listview.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.selectNic_listview.FullRowSelect = true;
            this.selectNic_listview.Location = new System.Drawing.Point(0, 0);
            this.selectNic_listview.Margin = new System.Windows.Forms.Padding(0);
            this.selectNic_listview.MultiSelect = false;
            this.selectNic_listview.Name = "selectNic_listview";
            this.selectNic_listview.Size = new System.Drawing.Size(763, 557);
            this.selectNic_listview.TabIndex = 0;
            this.selectNic_listview.UseCompatibleStateImageBehavior = false;
            this.selectNic_listview.View = System.Windows.Forms.View.Details;
            // 
            // changeNicColumnHeader0
            // 
            this.changeNicColumnHeader0.Text = "#";
            this.changeNicColumnHeader0.Width = 25;
            // 
            // changeNicColumnHeader1
            // 
            this.changeNicColumnHeader1.Text = "ID";
            this.changeNicColumnHeader1.Width = 82;
            // 
            // changeNicColumnHeader2
            // 
            this.changeNicColumnHeader2.Text = "Name";
            this.changeNicColumnHeader2.Width = 252;
            // 
            // changeNicColumnHeader3
            // 
            this.changeNicColumnHeader3.Text = "MAC Address";
            this.changeNicColumnHeader3.Width = 158;
            // 
            // changeNicColumnHeader4
            // 
            this.changeNicColumnHeader4.Text = "IP Address";
            this.changeNicColumnHeader4.Width = 147;
            // 
            // changeNicColumnHeader5
            // 
            this.changeNicColumnHeader5.Text = "Select";
            this.changeNicColumnHeader5.Width = 96;
            // 
            // setHostIp_panelMain
            // 
            this.setHostIp_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setHostIp_panelMain.AutoScroll = true;
            this.setHostIp_panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.setHostIp_panelMain.Controls.Add(this.overview_setHostIp_panel);
            this.setHostIp_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.setHostIp_panelMain.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.setHostIp_panelMain.Location = new System.Drawing.Point(100, 0);
            this.setHostIp_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.setHostIp_panelMain.Name = "setHostIp_panelMain";
            this.setHostIp_panelMain.Size = new System.Drawing.Size(772, 551);
            this.setHostIp_panelMain.TabIndex = 8;
            this.setHostIp_panelMain.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // copyright_panel
            // 
            this.copyright_panel.BackColor = System.Drawing.SystemColors.Control;
            this.copyright_panel.Controls.Add(this.copyright_license);
            this.copyright_panel.Controls.Add(this.copyright_description);
            this.copyright_panel.Controls.Add(this.copyright_sign);
            this.copyright_panel.Controls.Add(this.copyright_subheader);
            this.copyright_panel.Controls.Add(this.copyright_header);
            this.copyright_panel.Location = new System.Drawing.Point(159, 71);
            this.copyright_panel.Name = "copyright_panel";
            this.copyright_panel.Size = new System.Drawing.Size(649, 415);
            this.copyright_panel.TabIndex = 9;
            // 
            // copyright_header
            // 
            this.copyright_header.AutoSize = true;
            this.copyright_header.Font = new System.Drawing.Font("Ubuntu", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_header.Location = new System.Drawing.Point(203, 22);
            this.copyright_header.Name = "copyright_header";
            this.copyright_header.Size = new System.Drawing.Size(219, 79);
            this.copyright_header.TabIndex = 0;
            this.copyright_header.Text = "GM4D";
            // 
            // copyright_subheader
            // 
            this.copyright_subheader.AutoSize = true;
            this.copyright_subheader.Font = new System.Drawing.Font("Ubuntu", 16F);
            this.copyright_subheader.Location = new System.Drawing.Point(136, 102);
            this.copyright_subheader.Name = "copyright_subheader";
            this.copyright_subheader.Size = new System.Drawing.Size(343, 26);
            this.copyright_subheader.TabIndex = 1;
            this.copyright_subheader.Text = "A GUI tool for the isc-dhcp-server";
            // 
            // copyright_sign
            // 
            this.copyright_sign.AutoSize = true;
            this.copyright_sign.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.copyright_sign.Location = new System.Drawing.Point(476, 392);
            this.copyright_sign.Name = "copyright_sign";
            this.copyright_sign.Size = new System.Drawing.Size(170, 20);
            this.copyright_sign.TabIndex = 2;
            this.copyright_sign.Text = "© 2015 Dennis Stodko";
            // 
            // copyright_description
            // 
            this.copyright_description.AutoSize = true;
            this.copyright_description.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.copyright_description.Location = new System.Drawing.Point(3, 140);
            this.copyright_description.Name = "copyright_description";
            this.copyright_description.Size = new System.Drawing.Size(650, 18);
            this.copyright_description.TabIndex = 3;
            this.copyright_description.Text = "This software is part of the assignment for the BSc(Hons) degree of the Southampt" +
    "on Solent University";
            // 
            // copyright_license
            // 
            this.copyright_license.BackColor = System.Drawing.Color.White;
            this.copyright_license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyright_license.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.copyright_license.Location = new System.Drawing.Point(22, 162);
            this.copyright_license.Name = "copyright_license";
            this.copyright_license.ReadOnly = true;
            this.copyright_license.Size = new System.Drawing.Size(601, 230);
            this.copyright_license.TabIndex = 4;
            this.copyright_license.Text = resources.GetString("copyright_license.Text");
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(GM4D.Settings);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.button1.Location = new System.Drawing.Point(0, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 611);
            this.Controls.Add(this.menuBottom_panelMain);
            this.Controls.Add(this.menu_panelMain);
            this.Controls.Add(this.overview_panelMain);
            this.Controls.Add(this.settings_panelMain);
            this.Controls.Add(this.staticLeases_panelMain);
            this.Controls.Add(this.changeNic_panelMain);
            this.Controls.Add(this.clients_panelMain);
            this.Controls.Add(this.setHostIp_panelMain);
            this.Controls.Add(this.copyright_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(880, 650);
            this.Name = "MainWindow";
            this.Text = "GM4D - Graphical Manager for DHCP";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menu_panelMain.ResumeLayout(false);
            this.settings_panelMain.ResumeLayout(false);
            this.settings_panelInfo.ResumeLayout(false);
            this.settings_panelInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.settings_panelInput.ResumeLayout(false);
            this.settings_panelInput.PerformLayout();
            this.maxLease_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxLease_input)).EndInit();
            this.ipRangeStart_panelInput.ResumeLayout(false);
            this.subnet_panelInput.ResumeLayout(false);
            this.subnetMask_panelInput.ResumeLayout(false);
            this.gateway_inputPanel.ResumeLayout(false);
            this.primaryDNS_panelInput.ResumeLayout(false);
            this.secondaryDNS_panelInput.ResumeLayout(false);
            this.ipRangeEnde_panelInput.ResumeLayout(false);
            this.defaultLease_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultLease_input)).EndInit();
            this.staticLeases_panelMain.ResumeLayout(false);
            this.staticLeases_panelMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.clients_panelMain.ResumeLayout(false);
            this.overview_panelMain.ResumeLayout(false);
            this.overview_tablepanel.ResumeLayout(false);
            this.overview_tablepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.overview_setHostIp_panel.ResumeLayout(false);
            this.overview_setHostIp_panel.PerformLayout();
            this.overview_setHostIp_tablepanel.ResumeLayout(false);
            this.overview_setHostIp_tablepanel.PerformLayout();
            this.overview_setHostIp_ip_panel.ResumeLayout(false);
            this.overview_setHostIp_subnetmask_panel.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_ok)).EndInit();
            this.menuBottom_panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusRequired)).EndInit();
            this.changeNic_panelMain.ResumeLayout(false);
            this.setHostIp_panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.copyright_panel.ResumeLayout(false);
            this.copyright_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_btnBasicSettings;
        private System.Windows.Forms.Button menu_btnStaticLeases;
        private System.Windows.Forms.Button menu_btnClients;
        private System.Windows.Forms.FlowLayoutPanel menu_panelMain;
        private System.Windows.Forms.FlowLayoutPanel settings_panelMain;
        private System.Windows.Forms.FlowLayoutPanel staticLeases_panelMain;
        private System.Windows.Forms.FlowLayoutPanel clients_panelMain;
        private System.Windows.Forms.FlowLayoutPanel overview_panelMain;
        private System.Windows.Forms.Button menuBottom_btnSave;
        private System.Windows.Forms.Button menu_btnOverview;
        private System.Windows.Forms.TableLayoutPanel settings_panelInput;
        private System.Windows.Forms.Label ipRangeStart_lblInfo;
        private System.Windows.Forms.Label ipRangeEnd_lbl;
        private System.Windows.Forms.Label ipRangeEnd_lblInfo;
        private System.Windows.Forms.Label ipRangeStart_lbl;
        private System.Windows.Forms.Label subnetMask_lbl;
        private System.Windows.Forms.Label gateway_lbl;
        private System.Windows.Forms.Label subnetMask_lblInfo;
        private System.Windows.Forms.Label gateway_lblInfo;
        private System.Windows.Forms.TableLayoutPanel settings_panelInfo;
        private System.Windows.Forms.Label hostIP_lbl;
        private System.Windows.Forms.Label hostSubnetMask_lbl;
        private System.Windows.Forms.TextBox hostSubnetMask_tb;
        private System.Windows.Forms.Label hostIP_lblInfo;
        private System.Windows.Forms.Label hostSubnetMask_lblInfo;
        private System.Windows.Forms.TextBox hostIP_tb;
        private IPAddressControlLib.IPAddressControl subnet_input;
        private IPAddressControlLib.IPAddressControl ipRangeStart_input;
        private IPAddressControlLib.IPAddressControl subnetMask_input;
        private IPAddressControlLib.IPAddressControl gateway_input;
        private System.Windows.Forms.ErrorProvider validationStatus_error;
        private System.Windows.Forms.ErrorProvider validationStatus_ok;
        private System.Windows.Forms.Label primaryDNS_lbl;
        private System.Windows.Forms.Label secondaryDNS_lbl;
        private System.Windows.Forms.Label primaryDNS_lblInfo;
        private System.Windows.Forms.Label secondaryDNS_lblInfo;
        private IPAddressControlLib.IPAddressControl primaryDNS_input;
        private IPAddressControlLib.IPAddressControl secondaryDNS_input;
        private System.Windows.Forms.FlowLayoutPanel menuBottom_panelMain;
        private System.Windows.Forms.Button menuBottom_btnLoad;
        private System.Windows.Forms.Button menuBottom_btnApply;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label subnet_lbl;
        private System.Windows.Forms.Label subnet_lblInfo;
        private IPAddressControlLib.IPAddressControl ipRangeEnd_input;
        private System.Windows.Forms.ErrorProvider statusRequired;
        private System.Windows.Forms.FlowLayoutPanel ipRangeStart_panelInput;
        private System.Windows.Forms.FlowLayoutPanel ipRangeEnde_panelInput;
        private System.Windows.Forms.FlowLayoutPanel subnet_panelInput;
        private System.Windows.Forms.FlowLayoutPanel subnetMask_panelInput;
        private System.Windows.Forms.FlowLayoutPanel gateway_inputPanel;
        private System.Windows.Forms.FlowLayoutPanel primaryDNS_panelInput;
        private System.Windows.Forms.FlowLayoutPanel secondaryDNS_panelInput;
        private System.Windows.Forms.Button menuBottom_LoadFromDhcp;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.ListView staticLeases_listview;
        private System.Windows.Forms.Label staticLeases_input_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label staticLeases_input_lbl_name;
        private System.Windows.Forms.Label staticLeases_input_lbl_mac;
        private System.Windows.Forms.Label staticLeases_input_lbl_ip;
        private System.Windows.Forms.Button staticLeases_input_btn_add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox staticLeases_input_tb_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox staticLeases_input_tb_mac;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel overview_tablepanel;
        private System.Windows.Forms.Label overview_hostip_lbl;
        private System.Windows.Forms.Label overview_hostip_status_lbl;
        private System.Windows.Forms.Label overview_hostip_info_ip_lbl;
        private System.Windows.Forms.Label overview_dhcpServer_lbl;
        private System.Windows.Forms.Label overview_dhcpServer_status_lbl;
        private System.Windows.Forms.Label overview_dhcpServer_info_lbl;
        private System.Windows.Forms.Label overview_dhcpDeamon_lbl;
        private System.Windows.Forms.Label overview_dhcpDeamon_status_lbl;
        private System.Windows.Forms.Label overview_dhcpDeamon_info_lbl;
        private System.Windows.Forms.Button overview_hostip_btn;
        private System.Windows.Forms.Button overview_dhcpServer_btn;
        private System.Windows.Forms.Button overview_dhcpDeamon_btn;
        private System.Windows.Forms.FlowLayoutPanel overview_setHostIp_panel;
        private System.Windows.Forms.Label overview_setHostIp_lbl;
        private System.Windows.Forms.TableLayoutPanel overview_setHostIp_tablepanel;
        private System.Windows.Forms.Label overview_setHostIp_ip_lbl;
        private System.Windows.Forms.Label overview_setHostIp_ip_lbl_info;
        private System.Windows.Forms.Label overview_setHostIp_subnetmask_lbl;
        private System.Windows.Forms.Label overview_setHostIp_subnetmask_lbl_info;
        private System.Windows.Forms.FlowLayoutPanel overview_setHostIp_ip_panel;
        private System.Windows.Forms.FlowLayoutPanel overview_setHostIp_subnetmask_panel;
        private System.Windows.Forms.Button overview_setHostIp_set_btn;
        private System.Windows.Forms.Label overview_hostip_info_subnetMask_lbl;
        private IPAddressControlLib.IPAddressControl overview_setHostIp_ip_ipinput;
        private IPAddressControlLib.IPAddressControl overview_setHostIp_subnetmask_ipinput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label overview_hostip_subnetMask_info_lbl;
        private System.Windows.Forms.Label overview_hostip_info_lbl;
        private System.Windows.Forms.Label overview_header_lbl_c1;
        private System.Windows.Forms.Label overview_header_lbl_c2;
        private System.Windows.Forms.Label overview_header_lbl_c3;
        private System.Windows.Forms.Label overview_header_lbl_c4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button overview_setHostIp_cancel_btn;
        private System.Windows.Forms.ColumnHeader columnDeviceName;
        private System.Windows.Forms.ColumnHeader columnMACaddress;
        private System.Windows.Forms.ColumnHeader columnIPaddress;
        private System.Windows.Forms.ColumnHeader columnedit;
        private IPAddressControlLib.IPAddressControl staticLeases_input_tb_ip;
        private System.Windows.Forms.ColumnHeader columndelete;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ListView clients_dhcpdLeases_listView;
        private System.Windows.Forms.ColumnHeader columnClientsName;
        private System.Windows.Forms.ColumnHeader columnClientsIP;
        private System.Windows.Forms.ColumnHeader columnClientsMAC;
        private System.Windows.Forms.ColumnHeader columnClientsLeaseStart;
        private System.Windows.Forms.ColumnHeader columnClientsLeaseEnd;
        private System.Windows.Forms.ColumnHeader columnClientsAddToStatic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox hostGateway_tb;
        private System.Windows.Forms.Label hostGateway_lbl;
        private System.Windows.Forms.Label defaultLease_lblInfo;
        private System.Windows.Forms.Label defaultLease_lbl;
        private System.Windows.Forms.NumericUpDown defaultLease_input;
        private System.Windows.Forms.Panel defaultLease_pnl;
        private System.Windows.Forms.Label maxLease_lblInfo;
        private System.Windows.Forms.Panel maxLease_pnl;
        private System.Windows.Forms.NumericUpDown maxLease_input;
        private System.Windows.Forms.Label maxLease_lbl;
        private System.Windows.Forms.Label overview_hostNic_lbl;
        private System.Windows.Forms.Label overview_hostNic_status_lbl;
        private System.Windows.Forms.Label overview_hostNic_info_lbl;
        private System.Windows.Forms.Button overview_hostNic_btn;
        private System.Windows.Forms.FlowLayoutPanel changeNic_panelMain;
        private System.Windows.Forms.ListView selectNic_listview;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader1;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader2;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader3;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader4;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader5;
        private System.Windows.Forms.ColumnHeader changeNicColumnHeader0;
        private System.Windows.Forms.FlowLayoutPanel setHostIp_panelMain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel copyright_panel;
        private System.Windows.Forms.Label copyright_header;
        private System.Windows.Forms.RichTextBox copyright_license;
        private System.Windows.Forms.Label copyright_description;
        private System.Windows.Forms.Label copyright_sign;
        private System.Windows.Forms.Label copyright_subheader;
        private System.Windows.Forms.Button button1;
    }
}

