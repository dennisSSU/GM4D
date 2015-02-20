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
            this.hostIP_lbl = new System.Windows.Forms.Label();
            this.hostSubnetMask_lbl = new System.Windows.Forms.Label();
            this.hostSubnetMask_tb = new System.Windows.Forms.TextBox();
            this.hostIP_lblInfo = new System.Windows.Forms.Label();
            this.hostSubnetMask_lblInfo = new System.Windows.Forms.Label();
            this.hostIP_tb = new System.Windows.Forms.TextBox();
            this.settings_panelInput = new System.Windows.Forms.TableLayoutPanel();
            this.ipRangeEnde_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.ipRangeEnd_input = new IPAddressControlLib.IPAddressControl();
            this.ipRangeStart_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeEnd_lbl = new System.Windows.Forms.Label();
            this.ipRangeEnd_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeStart_lbl = new System.Windows.Forms.Label();
            this.subnetMask_lbl = new System.Windows.Forms.Label();
            this.gateway_lbl = new System.Windows.Forms.Label();
            this.subnetMask_Info = new System.Windows.Forms.Label();
            this.gateway_lblInfo = new System.Windows.Forms.Label();
            this.primaryDNS_lbl = new System.Windows.Forms.Label();
            this.secondaryDNS_lbl = new System.Windows.Forms.Label();
            this.primaryDNS_lblInfo = new System.Windows.Forms.Label();
            this.secondaryDNS_lblInfo = new System.Windows.Forms.Label();
            this.subnet_lbl = new System.Windows.Forms.Label();
            this.subnet_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeStart_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.ipRangeStart_input = new IPAddressControlLib.IPAddressControl();
            this.subnet_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.subnet_input = new IPAddressControlLib.IPAddressControl();
            this.subnetMask_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.subnetMask_input = new IPAddressControlLib.IPAddressControl();
            this.gateway_inputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gateway_input = new IPAddressControlLib.IPAddressControl();
            this.primaryDNS_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.primaryDNS_input = new IPAddressControlLib.IPAddressControl();
            this.secondaryDNS_panelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.secondaryDNS_input = new IPAddressControlLib.IPAddressControl();
            this.staticLeases_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.clients_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.validationStatus_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.validationStatus_ok = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuBottom_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBottom_btnLoad = new System.Windows.Forms.Button();
            this.menuBottom_btnApply = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusRequired = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuBottom_backUpConfig = new System.Windows.Forms.Button();
            this.menu_panelMain.SuspendLayout();
            this.settings_panelMain.SuspendLayout();
            this.settings_panelInfo.SuspendLayout();
            this.settings_panelInput.SuspendLayout();
            this.ipRangeEnde_panelInput.SuspendLayout();
            this.ipRangeStart_panelInput.SuspendLayout();
            this.subnet_panelInput.SuspendLayout();
            this.subnetMask_panelInput.SuspendLayout();
            this.gateway_inputPanel.SuspendLayout();
            this.primaryDNS_panelInput.SuspendLayout();
            this.secondaryDNS_panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_ok)).BeginInit();
            this.menuBottom_panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_btnOverview
            // 
            this.menu_btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnOverview.FlatAppearance.BorderSize = 0;
            this.menu_btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menu_btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnOverview.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.menu_btnOverview.Location = new System.Drawing.Point(8, 8);
            this.menu_btnOverview.Name = "menu_btnOverview";
            this.menu_btnOverview.Size = new System.Drawing.Size(100, 105);
            this.menu_btnOverview.TabIndex = 1;
            this.menu_btnOverview.Text = "Overview";
            this.menu_btnOverview.UseVisualStyleBackColor = false;
            this.menu_btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // menu_btnBasicSettings
            // 
            this.menu_btnBasicSettings.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnBasicSettings.FlatAppearance.BorderSize = 0;
            this.menu_btnBasicSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnBasicSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menu_btnBasicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnBasicSettings.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnBasicSettings.Location = new System.Drawing.Point(8, 119);
            this.menu_btnBasicSettings.Name = "menu_btnBasicSettings";
            this.menu_btnBasicSettings.Size = new System.Drawing.Size(100, 105);
            this.menu_btnBasicSettings.TabIndex = 2;
            this.menu_btnBasicSettings.Text = "Address Range";
            this.menu_btnBasicSettings.UseVisualStyleBackColor = false;
            this.menu_btnBasicSettings.Click += new System.EventHandler(this.btnBasicSettings_Click);
            // 
            // menu_btnStaticLeases
            // 
            this.menu_btnStaticLeases.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnStaticLeases.FlatAppearance.BorderSize = 0;
            this.menu_btnStaticLeases.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnStaticLeases.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menu_btnStaticLeases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnStaticLeases.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnStaticLeases.Location = new System.Drawing.Point(8, 230);
            this.menu_btnStaticLeases.Name = "menu_btnStaticLeases";
            this.menu_btnStaticLeases.Size = new System.Drawing.Size(100, 105);
            this.menu_btnStaticLeases.TabIndex = 3;
            this.menu_btnStaticLeases.Text = "Static Leases";
            this.menu_btnStaticLeases.UseVisualStyleBackColor = false;
            this.menu_btnStaticLeases.Click += new System.EventHandler(this.btnStaticLeases_Click);
            // 
            // menu_btnClients
            // 
            this.menu_btnClients.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnClients.FlatAppearance.BorderSize = 0;
            this.menu_btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menu_btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnClients.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnClients.Location = new System.Drawing.Point(8, 341);
            this.menu_btnClients.Name = "menu_btnClients";
            this.menu_btnClients.Size = new System.Drawing.Size(100, 105);
            this.menu_btnClients.TabIndex = 4;
            this.menu_btnClients.Text = "Clients";
            this.menu_btnClients.UseVisualStyleBackColor = false;
            this.menu_btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // menu_panelMain
            // 
            this.menu_panelMain.AutoScroll = true;
            this.menu_panelMain.AutoScrollMinSize = new System.Drawing.Size(115, 200);
            this.menu_panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_panelMain.Controls.Add(this.menu_btnOverview);
            this.menu_panelMain.Controls.Add(this.menu_btnBasicSettings);
            this.menu_panelMain.Controls.Add(this.menu_btnStaticLeases);
            this.menu_panelMain.Controls.Add(this.menu_btnClients);
            this.menu_panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panelMain.Location = new System.Drawing.Point(0, 0);
            this.menu_panelMain.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menu_panelMain.Name = "menu_panelMain";
            this.menu_panelMain.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.menu_panelMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_panelMain.Size = new System.Drawing.Size(140, 617);
            this.menu_panelMain.TabIndex = 1;
            // 
            // menuBottom_btnSave
            // 
            this.menuBottom_btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnSave.BackColor = System.Drawing.Color.Transparent;
            this.menuBottom_btnSave.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBottom_btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuBottom_btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnSave.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBottom_btnSave.Location = new System.Drawing.Point(3, 3);
            this.menuBottom_btnSave.Name = "menuBottom_btnSave";
            this.menuBottom_btnSave.Size = new System.Drawing.Size(100, 50);
            this.menuBottom_btnSave.TabIndex = 5;
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
            this.settings_panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.settings_panelMain.Controls.Add(this.settings_panelInfo);
            this.settings_panelMain.Controls.Add(this.settings_panelInput);
            this.settings_panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.settings_panelMain.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.settings_panelMain.Location = new System.Drawing.Point(140, 0);
            this.settings_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.settings_panelMain.Name = "settings_panelMain";
            this.settings_panelMain.Size = new System.Drawing.Size(732, 547);
            this.settings_panelMain.TabIndex = 3;
            this.settings_panelMain.Visible = false;
            // 
            // settings_panelInfo
            // 
            this.settings_panelInfo.ColumnCount = 3;
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInfo.Controls.Add(this.hostIP_lbl, 0, 0);
            this.settings_panelInfo.Controls.Add(this.hostSubnetMask_lbl, 0, 1);
            this.settings_panelInfo.Controls.Add(this.hostSubnetMask_tb, 1, 1);
            this.settings_panelInfo.Controls.Add(this.hostIP_lblInfo, 2, 0);
            this.settings_panelInfo.Controls.Add(this.hostSubnetMask_lblInfo, 2, 1);
            this.settings_panelInfo.Controls.Add(this.hostIP_tb, 1, 0);
            this.settings_panelInfo.Location = new System.Drawing.Point(3, 3);
            this.settings_panelInfo.Name = "settings_panelInfo";
            this.settings_panelInfo.RowCount = 2;
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInfo.Size = new System.Drawing.Size(717, 67);
            this.settings_panelInfo.TabIndex = 1;
            // 
            // hostIP_lbl
            // 
            this.hostIP_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lbl.AutoSize = true;
            this.hostIP_lbl.Location = new System.Drawing.Point(3, 6);
            this.hostIP_lbl.Name = "hostIP_lbl";
            this.hostIP_lbl.Size = new System.Drawing.Size(60, 20);
            this.hostIP_lbl.TabIndex = 0;
            this.hostIP_lbl.Text = "Host IP";
            // 
            // hostSubnetMask_lbl
            // 
            this.hostSubnetMask_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostSubnetMask_lbl.AutoSize = true;
            this.hostSubnetMask_lbl.Location = new System.Drawing.Point(3, 39);
            this.hostSubnetMask_lbl.Name = "hostSubnetMask_lbl";
            this.hostSubnetMask_lbl.Size = new System.Drawing.Size(138, 20);
            this.hostSubnetMask_lbl.TabIndex = 1;
            this.hostSubnetMask_lbl.Text = "Host Subnet Mask";
            // 
            // hostSubnetMask_tb
            // 
            this.hostSubnetMask_tb.Location = new System.Drawing.Point(153, 35);
            this.hostSubnetMask_tb.Name = "hostSubnetMask_tb";
            this.hostSubnetMask_tb.ReadOnly = true;
            this.hostSubnetMask_tb.Size = new System.Drawing.Size(144, 26);
            this.hostSubnetMask_tb.TabIndex = 0;
            this.hostSubnetMask_tb.TabStop = false;
            // 
            // hostIP_lblInfo
            // 
            this.hostIP_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lblInfo.AutoSize = true;
            this.hostIP_lblInfo.Location = new System.Drawing.Point(303, 6);
            this.hostIP_lblInfo.Name = "hostIP_lblInfo";
            this.hostIP_lblInfo.Size = new System.Drawing.Size(84, 20);
            this.hostIP_lblInfo.TabIndex = 4;
            this.hostIP_lblInfo.Text = "HostIPInfo";
            // 
            // hostSubnetMask_lblInfo
            // 
            this.hostSubnetMask_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostSubnetMask_lblInfo.AutoSize = true;
            this.hostSubnetMask_lblInfo.Location = new System.Drawing.Point(303, 39);
            this.hostSubnetMask_lblInfo.Name = "hostSubnetMask_lblInfo";
            this.hostSubnetMask_lblInfo.Size = new System.Drawing.Size(158, 20);
            this.hostSubnetMask_lblInfo.TabIndex = 5;
            this.hostSubnetMask_lblInfo.Text = "HostSubnetMaskInfo";
            // 
            // hostIP_tb
            // 
            this.hostIP_tb.Location = new System.Drawing.Point(153, 3);
            this.hostIP_tb.Name = "hostIP_tb";
            this.hostIP_tb.ReadOnly = true;
            this.hostIP_tb.Size = new System.Drawing.Size(144, 26);
            this.hostIP_tb.TabIndex = 0;
            this.hostIP_tb.TabStop = false;
            // 
            // settings_panelInput
            // 
            this.settings_panelInput.ColumnCount = 4;
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInput.Controls.Add(this.ipRangeEnde_panelInput, 1, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lblInfo, 3, 0);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lbl, 0, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lblInfo, 3, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lbl, 0, 0);
            this.settings_panelInput.Controls.Add(this.subnetMask_lbl, 0, 3);
            this.settings_panelInput.Controls.Add(this.gateway_lbl, 0, 4);
            this.settings_panelInput.Controls.Add(this.subnetMask_Info, 3, 3);
            this.settings_panelInput.Controls.Add(this.gateway_lblInfo, 3, 4);
            this.settings_panelInput.Controls.Add(this.primaryDNS_lbl, 0, 5);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_lbl, 0, 6);
            this.settings_panelInput.Controls.Add(this.primaryDNS_lblInfo, 3, 5);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_lblInfo, 3, 6);
            this.settings_panelInput.Controls.Add(this.subnet_lbl, 0, 2);
            this.settings_panelInput.Controls.Add(this.subnet_lblInfo, 3, 2);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_panelInput, 1, 0);
            this.settings_panelInput.Controls.Add(this.subnet_panelInput, 1, 2);
            this.settings_panelInput.Controls.Add(this.subnetMask_panelInput, 1, 3);
            this.settings_panelInput.Controls.Add(this.gateway_inputPanel, 1, 4);
            this.settings_panelInput.Controls.Add(this.primaryDNS_panelInput, 1, 5);
            this.settings_panelInput.Controls.Add(this.secondaryDNS_panelInput, 1, 6);
            this.settings_panelInput.Location = new System.Drawing.Point(3, 76);
            this.settings_panelInput.Name = "settings_panelInput";
            this.settings_panelInput.RowCount = 8;
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
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
            // ipRangeEnde_panelInput
            // 
            this.ipRangeEnde_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnde_panelInput.Controls.Add(this.ipRangeEnd_input);
            this.statusRequired.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.ipRangeEnde_panelInput, 1);
            this.ipRangeEnde_panelInput.Location = new System.Drawing.Point(150, 30);
            this.ipRangeEnde_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.ipRangeEnde_panelInput.Name = "ipRangeEnde_panelInput";
            this.ipRangeEnde_panelInput.Size = new System.Drawing.Size(180, 30);
            this.ipRangeEnde_panelInput.TabIndex = 0;
            // 
            // ipRangeEnd_input
            // 
            this.ipRangeEnd_input.AllowInternalTab = false;
            this.ipRangeEnd_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_input.AutoHeight = true;
            this.ipRangeEnd_input.BackColor = System.Drawing.SystemColors.Window;
            this.ipRangeEnd_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipRangeEnd_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeEnd_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipRangeEnd_input.Location = new System.Drawing.Point(3, 3);
            this.ipRangeEnd_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.ipRangeEnd_input.Name = "ipRangeEnd_input";
            this.ipRangeEnd_input.ReadOnly = false;
            this.ipRangeEnd_input.Size = new System.Drawing.Size(144, 22);
            this.ipRangeEnd_input.TabIndex = 2;
            this.ipRangeEnd_input.Text = "...";
            this.ipRangeEnd_input.Validated += new System.EventHandler(this.settings_validateIpRangeEndInput);
            // 
            // ipRangeStart_lblInfo
            // 
            this.ipRangeStart_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_lblInfo.AutoSize = true;
            this.ipRangeStart_lblInfo.Location = new System.Drawing.Point(353, 5);
            this.ipRangeStart_lblInfo.Name = "ipRangeStart_lblInfo";
            this.ipRangeStart_lblInfo.Size = new System.Drawing.Size(130, 20);
            this.ipRangeStart_lblInfo.TabIndex = 1;
            this.ipRangeStart_lblInfo.Text = "IPRangeStartInfo";
            // 
            // ipRangeEnd_lbl
            // 
            this.ipRangeEnd_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_lbl.AutoSize = true;
            this.ipRangeEnd_lbl.Location = new System.Drawing.Point(3, 35);
            this.ipRangeEnd_lbl.Name = "ipRangeEnd_lbl";
            this.ipRangeEnd_lbl.Size = new System.Drawing.Size(102, 20);
            this.ipRangeEnd_lbl.TabIndex = 2;
            this.ipRangeEnd_lbl.Text = "IP Range End";
            // 
            // ipRangeEnd_lblInfo
            // 
            this.ipRangeEnd_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_lblInfo.AutoSize = true;
            this.ipRangeEnd_lblInfo.Location = new System.Drawing.Point(353, 35);
            this.ipRangeEnd_lblInfo.Name = "ipRangeEnd_lblInfo";
            this.ipRangeEnd_lblInfo.Size = new System.Drawing.Size(122, 20);
            this.ipRangeEnd_lblInfo.TabIndex = 3;
            this.ipRangeEnd_lblInfo.Text = "IPRangeEndInfo";
            // 
            // ipRangeStart_lbl
            // 
            this.ipRangeStart_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_lbl.AutoSize = true;
            this.ipRangeStart_lbl.Location = new System.Drawing.Point(3, 5);
            this.ipRangeStart_lbl.Name = "ipRangeStart_lbl";
            this.ipRangeStart_lbl.Size = new System.Drawing.Size(110, 20);
            this.ipRangeStart_lbl.TabIndex = 0;
            this.ipRangeStart_lbl.Text = "IP Range Start";
            // 
            // subnetMask_lbl
            // 
            this.subnetMask_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_lbl.AutoSize = true;
            this.subnetMask_lbl.Location = new System.Drawing.Point(3, 95);
            this.subnetMask_lbl.Name = "subnetMask_lbl";
            this.subnetMask_lbl.Size = new System.Drawing.Size(100, 20);
            this.subnetMask_lbl.TabIndex = 8;
            this.subnetMask_lbl.Text = "Subnet Mask";
            // 
            // gateway_lbl
            // 
            this.gateway_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_lbl.AutoSize = true;
            this.gateway_lbl.Location = new System.Drawing.Point(3, 125);
            this.gateway_lbl.Name = "gateway_lbl";
            this.gateway_lbl.Size = new System.Drawing.Size(71, 20);
            this.gateway_lbl.TabIndex = 9;
            this.gateway_lbl.Text = "Gateway";
            // 
            // subnetMask_Info
            // 
            this.subnetMask_Info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_Info.AutoSize = true;
            this.subnetMask_Info.Location = new System.Drawing.Point(353, 95);
            this.subnetMask_Info.Name = "subnetMask_Info";
            this.subnetMask_Info.Size = new System.Drawing.Size(124, 20);
            this.subnetMask_Info.TabIndex = 10;
            this.subnetMask_Info.Text = "SubnetMaskInfo";
            // 
            // gateway_lblInfo
            // 
            this.gateway_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_lblInfo.AutoSize = true;
            this.gateway_lblInfo.Location = new System.Drawing.Point(353, 125);
            this.gateway_lblInfo.Name = "gateway_lblInfo";
            this.gateway_lblInfo.Size = new System.Drawing.Size(99, 20);
            this.gateway_lblInfo.TabIndex = 11;
            this.gateway_lblInfo.Text = "GatewayInfo";
            // 
            // primaryDNS_lbl
            // 
            this.primaryDNS_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_lbl.AutoSize = true;
            this.primaryDNS_lbl.Location = new System.Drawing.Point(3, 155);
            this.primaryDNS_lbl.Name = "primaryDNS_lbl";
            this.primaryDNS_lbl.Size = new System.Drawing.Size(97, 20);
            this.primaryDNS_lbl.TabIndex = 12;
            this.primaryDNS_lbl.Text = "Primary DNS";
            // 
            // secondaryDNS_lbl
            // 
            this.secondaryDNS_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_lbl.AutoSize = true;
            this.secondaryDNS_lbl.Location = new System.Drawing.Point(3, 185);
            this.secondaryDNS_lbl.Name = "secondaryDNS_lbl";
            this.secondaryDNS_lbl.Size = new System.Drawing.Size(119, 20);
            this.secondaryDNS_lbl.TabIndex = 13;
            this.secondaryDNS_lbl.Text = "Secondary DNS";
            // 
            // primaryDNS_lblInfo
            // 
            this.primaryDNS_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_lblInfo.AutoSize = true;
            this.primaryDNS_lblInfo.Location = new System.Drawing.Point(353, 155);
            this.primaryDNS_lblInfo.Name = "primaryDNS_lblInfo";
            this.primaryDNS_lblInfo.Size = new System.Drawing.Size(121, 20);
            this.primaryDNS_lblInfo.TabIndex = 14;
            this.primaryDNS_lblInfo.Text = "PrimaryDNSInfo";
            // 
            // secondaryDNS_lblInfo
            // 
            this.secondaryDNS_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_lblInfo.AutoSize = true;
            this.secondaryDNS_lblInfo.Location = new System.Drawing.Point(353, 185);
            this.secondaryDNS_lblInfo.Name = "secondaryDNS_lblInfo";
            this.secondaryDNS_lblInfo.Size = new System.Drawing.Size(143, 20);
            this.secondaryDNS_lblInfo.TabIndex = 15;
            this.secondaryDNS_lblInfo.Text = "SecondaryDNSInfo";
            // 
            // subnet_lbl
            // 
            this.subnet_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_lbl.AutoSize = true;
            this.subnet_lbl.Location = new System.Drawing.Point(3, 65);
            this.subnet_lbl.Name = "subnet_lbl";
            this.subnet_lbl.Size = new System.Drawing.Size(78, 20);
            this.subnet_lbl.TabIndex = 16;
            this.subnet_lbl.Text = "Subnet ID";
            // 
            // subnet_lblInfo
            // 
            this.subnet_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_lblInfo.AutoSize = true;
            this.subnet_lblInfo.Location = new System.Drawing.Point(353, 65);
            this.subnet_lblInfo.Name = "subnet_lblInfo";
            this.subnet_lblInfo.Size = new System.Drawing.Size(88, 20);
            this.subnet_lblInfo.TabIndex = 17;
            this.subnet_lblInfo.Text = "SubnetInfo";
            // 
            // ipRangeStart_panelInput
            // 
            this.ipRangeStart_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_panelInput.Controls.Add(this.ipRangeStart_input);
            this.statusRequired.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.ipRangeStart_panelInput, 1);
            this.ipRangeStart_panelInput.Location = new System.Drawing.Point(150, 0);
            this.ipRangeStart_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.ipRangeStart_panelInput.Name = "ipRangeStart_panelInput";
            this.ipRangeStart_panelInput.Size = new System.Drawing.Size(180, 30);
            this.ipRangeStart_panelInput.TabIndex = 0;
            // 
            // ipRangeStart_input
            // 
            this.ipRangeStart_input.AllowInternalTab = false;
            this.ipRangeStart_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_input.AutoHeight = true;
            this.ipRangeStart_input.BackColor = System.Drawing.SystemColors.Window;
            this.ipRangeStart_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipRangeStart_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeStart_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipRangeStart_input.Location = new System.Drawing.Point(3, 3);
            this.ipRangeStart_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.ipRangeStart_input.Name = "ipRangeStart_input";
            this.ipRangeStart_input.ReadOnly = false;
            this.ipRangeStart_input.Size = new System.Drawing.Size(144, 22);
            this.ipRangeStart_input.TabIndex = 1;
            this.ipRangeStart_input.Text = "...";
            this.ipRangeStart_input.Validated += new System.EventHandler(this.settings_validateIpInput);
            // 
            // subnet_panelInput
            // 
            this.subnet_panelInput.Controls.Add(this.subnet_input);
            this.subnet_panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusRequired.SetIconPadding(this.subnet_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.subnet_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.subnet_panelInput, 1);
            this.subnet_panelInput.Location = new System.Drawing.Point(150, 60);
            this.subnet_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.subnet_panelInput.Name = "subnet_panelInput";
            this.subnet_panelInput.Size = new System.Drawing.Size(180, 30);
            this.subnet_panelInput.TabIndex = 0;
            // 
            // subnet_input
            // 
            this.subnet_input.AllowInternalTab = false;
            this.subnet_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnet_input.AutoHeight = true;
            this.subnet_input.BackColor = System.Drawing.SystemColors.Window;
            this.subnet_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subnet_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnet_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnet_input.Location = new System.Drawing.Point(3, 3);
            this.subnet_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.subnet_input.Name = "subnet_input";
            this.subnet_input.ReadOnly = false;
            this.subnet_input.Size = new System.Drawing.Size(144, 22);
            this.subnet_input.TabIndex = 3;
            this.subnet_input.Text = "...";
            this.subnet_input.Validated += new System.EventHandler(this.settings_validateSubnetInput);
            // 
            // subnetMask_panelInput
            // 
            this.subnetMask_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_panelInput.Controls.Add(this.subnetMask_input);
            this.statusRequired.SetIconPadding(this.subnetMask_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.subnetMask_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.subnetMask_panelInput, 1);
            this.subnetMask_panelInput.Location = new System.Drawing.Point(150, 90);
            this.subnetMask_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.subnetMask_panelInput.Name = "subnetMask_panelInput";
            this.subnetMask_panelInput.Size = new System.Drawing.Size(180, 30);
            this.subnetMask_panelInput.TabIndex = 0;
            // 
            // subnetMask_input
            // 
            this.subnetMask_input.AllowInternalTab = false;
            this.subnetMask_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_input.AutoHeight = true;
            this.subnetMask_input.BackColor = System.Drawing.SystemColors.Window;
            this.subnetMask_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subnetMask_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnetMask_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetMask_input.Location = new System.Drawing.Point(3, 3);
            this.subnetMask_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.subnetMask_input.Name = "subnetMask_input";
            this.subnetMask_input.ReadOnly = false;
            this.subnetMask_input.Size = new System.Drawing.Size(144, 22);
            this.subnetMask_input.TabIndex = 4;
            this.subnetMask_input.Text = "...";
            this.subnetMask_input.Validated += new System.EventHandler(this.settings_validateSubnetMaskInput);
            // 
            // gateway_inputPanel
            // 
            this.gateway_inputPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_inputPanel.Controls.Add(this.gateway_input);
            this.statusRequired.SetIconPadding(this.gateway_inputPanel, 1);
            this.validationStatus_error.SetIconPadding(this.gateway_inputPanel, 1);
            this.validationStatus_ok.SetIconPadding(this.gateway_inputPanel, 1);
            this.gateway_inputPanel.Location = new System.Drawing.Point(150, 120);
            this.gateway_inputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gateway_inputPanel.Name = "gateway_inputPanel";
            this.gateway_inputPanel.Size = new System.Drawing.Size(180, 30);
            this.gateway_inputPanel.TabIndex = 0;
            // 
            // gateway_input
            // 
            this.gateway_input.AllowInternalTab = false;
            this.gateway_input.AutoHeight = true;
            this.gateway_input.BackColor = System.Drawing.SystemColors.Window;
            this.gateway_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gateway_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gateway_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gateway_input.Location = new System.Drawing.Point(3, 3);
            this.gateway_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.gateway_input.Name = "gateway_input";
            this.gateway_input.ReadOnly = false;
            this.gateway_input.Size = new System.Drawing.Size(144, 22);
            this.gateway_input.TabIndex = 5;
            this.gateway_input.Text = "...";
            this.gateway_input.Validated += new System.EventHandler(this.settings_validateGatewayInput);
            // 
            // primaryDNS_panelInput
            // 
            this.primaryDNS_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_panelInput.Controls.Add(this.primaryDNS_input);
            this.statusRequired.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.primaryDNS_panelInput, 1);
            this.primaryDNS_panelInput.Location = new System.Drawing.Point(150, 150);
            this.primaryDNS_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.primaryDNS_panelInput.Name = "primaryDNS_panelInput";
            this.primaryDNS_panelInput.Size = new System.Drawing.Size(180, 30);
            this.primaryDNS_panelInput.TabIndex = 0;
            // 
            // primaryDNS_input
            // 
            this.primaryDNS_input.AllowInternalTab = false;
            this.primaryDNS_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryDNS_input.AutoHeight = true;
            this.primaryDNS_input.BackColor = System.Drawing.SystemColors.Window;
            this.primaryDNS_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.primaryDNS_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.primaryDNS_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryDNS_input.Location = new System.Drawing.Point(3, 3);
            this.primaryDNS_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.primaryDNS_input.Name = "primaryDNS_input";
            this.primaryDNS_input.ReadOnly = false;
            this.primaryDNS_input.Size = new System.Drawing.Size(144, 22);
            this.primaryDNS_input.TabIndex = 6;
            this.primaryDNS_input.Text = "...";
            this.primaryDNS_input.Validated += new System.EventHandler(this.settings_validatePrimaryDNSInput);
            // 
            // secondaryDNS_panelInput
            // 
            this.secondaryDNS_panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_panelInput.Controls.Add(this.secondaryDNS_input);
            this.statusRequired.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.validationStatus_error.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.validationStatus_ok.SetIconPadding(this.secondaryDNS_panelInput, 1);
            this.secondaryDNS_panelInput.Location = new System.Drawing.Point(150, 180);
            this.secondaryDNS_panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.secondaryDNS_panelInput.Name = "secondaryDNS_panelInput";
            this.secondaryDNS_panelInput.Size = new System.Drawing.Size(180, 30);
            this.secondaryDNS_panelInput.TabIndex = 0;
            // 
            // secondaryDNS_input
            // 
            this.secondaryDNS_input.AllowInternalTab = false;
            this.secondaryDNS_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryDNS_input.AutoHeight = true;
            this.secondaryDNS_input.BackColor = System.Drawing.SystemColors.Window;
            this.secondaryDNS_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondaryDNS_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondaryDNS_input.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryDNS_input.Location = new System.Drawing.Point(3, 3);
            this.secondaryDNS_input.MinimumSize = new System.Drawing.Size(99, 22);
            this.secondaryDNS_input.Name = "secondaryDNS_input";
            this.secondaryDNS_input.ReadOnly = false;
            this.secondaryDNS_input.Size = new System.Drawing.Size(144, 22);
            this.secondaryDNS_input.TabIndex = 7;
            this.secondaryDNS_input.Text = "...";
            this.secondaryDNS_input.Validated += new System.EventHandler(this.settings_validateSecondaryDNSInput);
            // 
            // staticLeases_panelMain
            // 
            this.staticLeases_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticLeases_panelMain.AutoScroll = true;
            this.staticLeases_panelMain.BackColor = System.Drawing.Color.Blue;
            this.staticLeases_panelMain.Location = new System.Drawing.Point(140, 0);
            this.staticLeases_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.staticLeases_panelMain.Name = "staticLeases_panelMain";
            this.staticLeases_panelMain.Size = new System.Drawing.Size(732, 547);
            this.staticLeases_panelMain.TabIndex = 4;
            this.staticLeases_panelMain.Visible = false;
            // 
            // clients_panelMain
            // 
            this.clients_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clients_panelMain.AutoScroll = true;
            this.clients_panelMain.BackColor = System.Drawing.Color.Red;
            this.clients_panelMain.Location = new System.Drawing.Point(140, 0);
            this.clients_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.clients_panelMain.Name = "clients_panelMain";
            this.clients_panelMain.Size = new System.Drawing.Size(732, 547);
            this.clients_panelMain.TabIndex = 5;
            this.clients_panelMain.Visible = false;
            // 
            // overview_panelMain
            // 
            this.overview_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_panelMain.AutoScroll = true;
            this.overview_panelMain.BackColor = System.Drawing.Color.Yellow;
            this.overview_panelMain.Location = new System.Drawing.Point(140, 0);
            this.overview_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.overview_panelMain.Name = "overview_panelMain";
            this.overview_panelMain.Size = new System.Drawing.Size(732, 547);
            this.overview_panelMain.TabIndex = 2;
            this.overview_panelMain.Visible = false;
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
            this.menuBottom_panelMain.AutoScroll = true;
            this.menuBottom_panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnSave);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnLoad);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_btnApply);
            this.menuBottom_panelMain.Controls.Add(this.menuBottom_backUpConfig);
            this.menuBottom_panelMain.Location = new System.Drawing.Point(140, 547);
            this.menuBottom_panelMain.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.menuBottom_panelMain.Name = "menuBottom_panelMain";
            this.menuBottom_panelMain.Size = new System.Drawing.Size(732, 74);
            this.menuBottom_panelMain.TabIndex = 6;
            // 
            // menuBottom_btnLoad
            // 
            this.menuBottom_btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.menuBottom_btnLoad.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBottom_btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuBottom_btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnLoad.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBottom_btnLoad.Location = new System.Drawing.Point(109, 3);
            this.menuBottom_btnLoad.Name = "menuBottom_btnLoad";
            this.menuBottom_btnLoad.Size = new System.Drawing.Size(100, 50);
            this.menuBottom_btnLoad.TabIndex = 6;
            this.menuBottom_btnLoad.Text = "Load Config";
            this.menuBottom_btnLoad.UseVisualStyleBackColor = false;
            // 
            // menuBottom_btnApply
            // 
            this.menuBottom_btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_btnApply.BackColor = System.Drawing.Color.Transparent;
            this.menuBottom_btnApply.FlatAppearance.BorderSize = 0;
            this.menuBottom_btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBottom_btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuBottom_btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_btnApply.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBottom_btnApply.Location = new System.Drawing.Point(215, 3);
            this.menuBottom_btnApply.Name = "menuBottom_btnApply";
            this.menuBottom_btnApply.Size = new System.Drawing.Size(100, 50);
            this.menuBottom_btnApply.TabIndex = 7;
            this.menuBottom_btnApply.Text = "Apply to DHCP Server";
            this.menuBottom_btnApply.UseVisualStyleBackColor = false;
            this.menuBottom_btnApply.Click += new System.EventHandler(this.menuBottom_btnApply_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "gm4d";
            this.saveFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "gm4d";
            this.openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // statusRequired
            // 
            this.statusRequired.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.statusRequired.ContainerControl = this;
            // 
            // menuBottom_backUpConfig
            // 
            this.menuBottom_backUpConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBottom_backUpConfig.BackColor = System.Drawing.Color.Transparent;
            this.menuBottom_backUpConfig.FlatAppearance.BorderSize = 0;
            this.menuBottom_backUpConfig.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBottom_backUpConfig.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuBottom_backUpConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBottom_backUpConfig.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBottom_backUpConfig.Location = new System.Drawing.Point(321, 3);
            this.menuBottom_backUpConfig.Name = "menuBottom_backUpConfig";
            this.menuBottom_backUpConfig.Size = new System.Drawing.Size(100, 50);
            this.menuBottom_backUpConfig.TabIndex = 8;
            this.menuBottom_backUpConfig.Text = "Backup Current Setting";
            this.menuBottom_backUpConfig.UseVisualStyleBackColor = false;
            this.menuBottom_backUpConfig.Click += new System.EventHandler(this.menuBottom_backUpConfig_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 617);
            this.Controls.Add(this.menuBottom_panelMain);
            this.Controls.Add(this.menu_panelMain);
            this.Controls.Add(this.settings_panelMain);
            this.Controls.Add(this.staticLeases_panelMain);
            this.Controls.Add(this.clients_panelMain);
            this.Controls.Add(this.overview_panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 208);
            this.Name = "MainWindow";
            this.Text = "GM4D - Graphical Manager for DHCP";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menu_panelMain.ResumeLayout(false);
            this.settings_panelMain.ResumeLayout(false);
            this.settings_panelInfo.ResumeLayout(false);
            this.settings_panelInfo.PerformLayout();
            this.settings_panelInput.ResumeLayout(false);
            this.settings_panelInput.PerformLayout();
            this.ipRangeEnde_panelInput.ResumeLayout(false);
            this.ipRangeStart_panelInput.ResumeLayout(false);
            this.subnet_panelInput.ResumeLayout(false);
            this.subnetMask_panelInput.ResumeLayout(false);
            this.gateway_inputPanel.ResumeLayout(false);
            this.primaryDNS_panelInput.ResumeLayout(false);
            this.secondaryDNS_panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationStatus_ok)).EndInit();
            this.menuBottom_panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusRequired)).EndInit();
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
        private System.Windows.Forms.Label subnetMask_Info;
        private System.Windows.Forms.Label gateway_lblInfo;
        private System.Windows.Forms.TableLayoutPanel settings_panelInfo;
        private System.Windows.Forms.Label hostIP_lbl;
        private System.Windows.Forms.Label hostSubnetMask_lbl;
        private System.Windows.Forms.TextBox hostSubnetMask_tb;
        private System.Windows.Forms.Label hostIP_lblInfo;
        private System.Windows.Forms.Label hostSubnetMask_lblInfo;
        private System.Windows.Forms.TextBox hostIP_tb;
        private IPAddressControlLib.IPAddressControl ipRangeEnd_input;
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
        private IPAddressControlLib.IPAddressControl subnet_input;
        private System.Windows.Forms.ErrorProvider statusRequired;
        private System.Windows.Forms.FlowLayoutPanel ipRangeStart_panelInput;
        private System.Windows.Forms.FlowLayoutPanel ipRangeEnde_panelInput;
        private System.Windows.Forms.FlowLayoutPanel subnet_panelInput;
        private System.Windows.Forms.FlowLayoutPanel subnetMask_panelInput;
        private System.Windows.Forms.FlowLayoutPanel gateway_inputPanel;
        private System.Windows.Forms.FlowLayoutPanel primaryDNS_panelInput;
        private System.Windows.Forms.FlowLayoutPanel secondaryDNS_panelInput;
        private System.Windows.Forms.Button menuBottom_backUpConfig;
    }
}

