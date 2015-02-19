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
            this.menu_btnSave = new System.Windows.Forms.Button();
            this.settings_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.settings_panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.hostIP_lbl = new System.Windows.Forms.Label();
            this.hostSubnetMask_lbl = new System.Windows.Forms.Label();
            this.hostSubnetMask_tb = new System.Windows.Forms.TextBox();
            this.hostIP_lblInfo = new System.Windows.Forms.Label();
            this.hostSubnetMask_lblInfo = new System.Windows.Forms.Label();
            this.hostIP_tb = new System.Windows.Forms.TextBox();
            this.settings_panelInput = new System.Windows.Forms.TableLayoutPanel();
            this.ipRangeStart_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeEnd_lbl = new System.Windows.Forms.Label();
            this.ipRangeEnd_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeStart_lbl = new System.Windows.Forms.Label();
            this.subnetMask_lbl = new System.Windows.Forms.Label();
            this.gateway_lbl = new System.Windows.Forms.Label();
            this.subnetMask_Info = new System.Windows.Forms.Label();
            this.gateway_lblInfo = new System.Windows.Forms.Label();
            this.ipRangeEnd_input = new IPAddressControlLib.IPAddressControl();
            this.ipRangeStart_input = new IPAddressControlLib.IPAddressControl();
            this.subnetMask_input = new IPAddressControlLib.IPAddressControl();
            this.gateway_input = new IPAddressControlLib.IPAddressControl();
            this.staticLeases_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.clients_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.ipRange_validationStatus_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ipRange_validationStatus_ok = new System.Windows.Forms.ErrorProvider(this.components);
            this.menu_panelMain.SuspendLayout();
            this.settings_panelMain.SuspendLayout();
            this.settings_panelInfo.SuspendLayout();
            this.settings_panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipRange_validationStatus_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRange_validationStatus_ok)).BeginInit();
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
            this.menu_panelMain.Controls.Add(this.menu_btnSave);
            this.menu_panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panelMain.Location = new System.Drawing.Point(0, 0);
            this.menu_panelMain.Name = "menu_panelMain";
            this.menu_panelMain.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.menu_panelMain.Size = new System.Drawing.Size(140, 617);
            this.menu_panelMain.TabIndex = 1;
            // 
            // menu_btnSave
            // 
            this.menu_btnSave.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnSave.FlatAppearance.BorderSize = 0;
            this.menu_btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menu_btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnSave.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnSave.Location = new System.Drawing.Point(8, 452);
            this.menu_btnSave.Name = "menu_btnSave";
            this.menu_btnSave.Size = new System.Drawing.Size(100, 105);
            this.menu_btnSave.TabIndex = 5;
            this.menu_btnSave.Text = "Save";
            this.menu_btnSave.UseVisualStyleBackColor = false;
            this.menu_btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.settings_panelMain.Location = new System.Drawing.Point(143, 0);
            this.settings_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.settings_panelMain.Name = "settings_panelMain";
            this.settings_panelMain.Size = new System.Drawing.Size(729, 617);
            this.settings_panelMain.TabIndex = 3;
            this.settings_panelMain.Visible = false;
            // 
            // settings_panelInfo
            // 
            this.settings_panelInfo.ColumnCount = 3;
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
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
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInfo.Size = new System.Drawing.Size(726, 67);
            this.settings_panelInfo.TabIndex = 1;
            // 
            // hostIP_lbl
            // 
            this.hostIP_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lbl.AutoSize = true;
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
            this.hostSubnetMask_lbl.Location = new System.Drawing.Point(3, 38);
            this.hostSubnetMask_lbl.Name = "hostSubnetMask_lbl";
            this.hostSubnetMask_lbl.Size = new System.Drawing.Size(138, 20);
            this.hostSubnetMask_lbl.TabIndex = 1;
            this.hostSubnetMask_lbl.Text = "Host Subnet Mask";
            // 
            // hostSubnetMask_tb
            // 
            this.hostSubnetMask_tb.Location = new System.Drawing.Point(153, 33);
            this.hostSubnetMask_tb.Name = "hostSubnetMask_tb";
            this.hostSubnetMask_tb.Size = new System.Drawing.Size(100, 26);
            this.hostSubnetMask_tb.TabIndex = 0;
            this.hostSubnetMask_tb.TabStop = false;
            // 
            // hostIP_lblInfo
            // 
            this.hostIP_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostIP_lblInfo.AutoSize = true;
            this.hostIP_lblInfo.Location = new System.Drawing.Point(288, 5);
            this.hostIP_lblInfo.Name = "hostIP_lblInfo";
            this.hostIP_lblInfo.Size = new System.Drawing.Size(84, 20);
            this.hostIP_lblInfo.TabIndex = 4;
            this.hostIP_lblInfo.Text = "HostIPInfo";
            // 
            // hostSubnetMask_lblInfo
            // 
            this.hostSubnetMask_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hostSubnetMask_lblInfo.AutoSize = true;
            this.hostSubnetMask_lblInfo.Location = new System.Drawing.Point(288, 38);
            this.hostSubnetMask_lblInfo.Name = "hostSubnetMask_lblInfo";
            this.hostSubnetMask_lblInfo.Size = new System.Drawing.Size(158, 20);
            this.hostSubnetMask_lblInfo.TabIndex = 5;
            this.hostSubnetMask_lblInfo.Text = "HostSubnetMaskInfo";
            // 
            // hostIP_tb
            // 
            this.hostIP_tb.Location = new System.Drawing.Point(153, 3);
            this.hostIP_tb.Name = "hostIP_tb";
            this.hostIP_tb.Size = new System.Drawing.Size(100, 26);
            this.hostIP_tb.TabIndex = 0;
            this.hostIP_tb.TabStop = false;
            // 
            // settings_panelInput
            // 
            this.settings_panelInput.ColumnCount = 3;
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lblInfo, 2, 0);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lbl, 0, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lblInfo, 2, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lbl, 0, 0);
            this.settings_panelInput.Controls.Add(this.subnetMask_lbl, 0, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lbl, 0, 3);
            this.settings_panelInput.Controls.Add(this.subnetMask_Info, 2, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lblInfo, 2, 3);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_input, 1, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_input, 1, 0);
            this.settings_panelInput.Controls.Add(this.subnetMask_input, 1, 2);
            this.settings_panelInput.Controls.Add(this.gateway_input, 1, 3);
            this.settings_panelInput.Location = new System.Drawing.Point(3, 76);
            this.settings_panelInput.Name = "settings_panelInput";
            this.settings_panelInput.RowCount = 5;
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settings_panelInput.Size = new System.Drawing.Size(726, 150);
            this.settings_panelInput.TabIndex = 0;
            // 
            // ipRangeStart_lblInfo
            // 
            this.ipRangeStart_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_lblInfo.AutoSize = true;
            this.ipRangeStart_lblInfo.Location = new System.Drawing.Point(303, 5);
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
            this.ipRangeEnd_lblInfo.Location = new System.Drawing.Point(303, 35);
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
            this.gateway_lbl.Location = new System.Drawing.Point(3, 95);
            this.gateway_lbl.Name = "gateway_lbl";
            this.gateway_lbl.Size = new System.Drawing.Size(71, 20);
            this.gateway_lbl.TabIndex = 9;
            this.gateway_lbl.Text = "Gateway";
            // 
            // subnetMask_Info
            // 
            this.subnetMask_Info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_Info.AutoSize = true;
            this.subnetMask_Info.Location = new System.Drawing.Point(303, 65);
            this.subnetMask_Info.Name = "subnetMask_Info";
            this.subnetMask_Info.Size = new System.Drawing.Size(124, 20);
            this.subnetMask_Info.TabIndex = 10;
            this.subnetMask_Info.Text = "SubnetMaskInfo";
            // 
            // gateway_lblInfo
            // 
            this.gateway_lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_lblInfo.AutoSize = true;
            this.gateway_lblInfo.Location = new System.Drawing.Point(303, 95);
            this.gateway_lblInfo.Name = "gateway_lblInfo";
            this.gateway_lblInfo.Size = new System.Drawing.Size(99, 20);
            this.gateway_lblInfo.TabIndex = 11;
            this.gateway_lblInfo.Text = "GatewayInfo";
            // 
            // ipRangeEnd_input
            // 
            this.ipRangeEnd_input.AllowInternalTab = false;
            this.ipRangeEnd_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeEnd_input.AutoHeight = true;
            this.ipRangeEnd_input.BackColor = System.Drawing.SystemColors.Window;
            this.ipRangeEnd_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipRangeEnd_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeEnd_input.Location = new System.Drawing.Point(153, 33);
            this.ipRangeEnd_input.MinimumSize = new System.Drawing.Size(123, 26);
            this.ipRangeEnd_input.Name = "ipRangeEnd_input";
            this.ipRangeEnd_input.ReadOnly = false;
            this.ipRangeEnd_input.Size = new System.Drawing.Size(123, 26);
            this.ipRangeEnd_input.TabIndex = 2;
            this.ipRangeEnd_input.Text = "...";
            this.ipRangeEnd_input.Validated += new System.EventHandler(this.settings_validateIpInput);
            // 
            // ipRangeStart_input
            // 
            this.ipRangeStart_input.AllowInternalTab = false;
            this.ipRangeStart_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipRangeStart_input.AutoHeight = true;
            this.ipRangeStart_input.BackColor = System.Drawing.SystemColors.Window;
            this.ipRangeStart_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipRangeStart_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipRangeStart_input.Location = new System.Drawing.Point(153, 3);
            this.ipRangeStart_input.MinimumSize = new System.Drawing.Size(123, 26);
            this.ipRangeStart_input.Name = "ipRangeStart_input";
            this.ipRangeStart_input.ReadOnly = false;
            this.ipRangeStart_input.Size = new System.Drawing.Size(123, 26);
            this.ipRangeStart_input.TabIndex = 1;
            this.ipRangeStart_input.Text = "...";
            this.ipRangeStart_input.Validated += new System.EventHandler(this.settings_validateIpInput);
            // 
            // subnetMask_input
            // 
            this.subnetMask_input.AllowInternalTab = false;
            this.subnetMask_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subnetMask_input.AutoHeight = true;
            this.subnetMask_input.BackColor = System.Drawing.SystemColors.Window;
            this.subnetMask_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subnetMask_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnetMask_input.Location = new System.Drawing.Point(153, 63);
            this.subnetMask_input.MinimumSize = new System.Drawing.Size(123, 26);
            this.subnetMask_input.Name = "subnetMask_input";
            this.subnetMask_input.ReadOnly = false;
            this.subnetMask_input.Size = new System.Drawing.Size(123, 26);
            this.subnetMask_input.TabIndex = 3;
            this.subnetMask_input.Text = "...";
            // 
            // gateway_input
            // 
            this.gateway_input.AllowInternalTab = false;
            this.gateway_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gateway_input.AutoHeight = true;
            this.gateway_input.BackColor = System.Drawing.SystemColors.Window;
            this.gateway_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gateway_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gateway_input.Location = new System.Drawing.Point(153, 93);
            this.gateway_input.MinimumSize = new System.Drawing.Size(123, 26);
            this.gateway_input.Name = "gateway_input";
            this.gateway_input.ReadOnly = false;
            this.gateway_input.Size = new System.Drawing.Size(123, 26);
            this.gateway_input.TabIndex = 5;
            this.gateway_input.Text = "...";
            // 
            // staticLeases_panelMain
            // 
            this.staticLeases_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticLeases_panelMain.AutoScroll = true;
            this.staticLeases_panelMain.BackColor = System.Drawing.Color.Blue;
            this.staticLeases_panelMain.Location = new System.Drawing.Point(143, 0);
            this.staticLeases_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.staticLeases_panelMain.Name = "staticLeases_panelMain";
            this.staticLeases_panelMain.Size = new System.Drawing.Size(729, 617);
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
            this.clients_panelMain.Location = new System.Drawing.Point(143, 0);
            this.clients_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.clients_panelMain.Name = "clients_panelMain";
            this.clients_panelMain.Size = new System.Drawing.Size(729, 617);
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
            this.overview_panelMain.Location = new System.Drawing.Point(143, 0);
            this.overview_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.overview_panelMain.Name = "overview_panelMain";
            this.overview_panelMain.Size = new System.Drawing.Size(729, 617);
            this.overview_panelMain.TabIndex = 2;
            this.overview_panelMain.Visible = false;
            // 
            // ipRange_validationStatus_error
            // 
            this.ipRange_validationStatus_error.ContainerControl = this;
            this.ipRange_validationStatus_error.Icon = ((System.Drawing.Icon)(resources.GetObject("ipRange_validationStatus_error.Icon")));
            // 
            // ipRange_validationStatus_ok
            // 
            this.ipRange_validationStatus_ok.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ipRange_validationStatus_ok.ContainerControl = this;
            this.ipRange_validationStatus_ok.Icon = ((System.Drawing.Icon)(resources.GetObject("ipRange_validationStatus_ok.Icon")));
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 617);
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
            ((System.ComponentModel.ISupportInitialize)(this.ipRange_validationStatus_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRange_validationStatus_ok)).EndInit();
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
        private System.Windows.Forms.Button menu_btnSave;
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
        private System.Windows.Forms.ErrorProvider ipRange_validationStatus_error;
        private System.Windows.Forms.ErrorProvider ipRange_validationStatus_ok;
    }
}

