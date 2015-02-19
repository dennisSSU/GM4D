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
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnBasicSettings = new System.Windows.Forms.Button();
            this.btnStaticLeases = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.menu_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.ipRangeStart_tb = new System.Windows.Forms.TextBox();
            this.ipRangeEnd_tb = new System.Windows.Forms.TextBox();
            this.ipRangeStart_lbl = new System.Windows.Forms.Label();
            this.subnetMask_tb = new System.Windows.Forms.TextBox();
            this.gateway_tb = new System.Windows.Forms.TextBox();
            this.subnetMask_lbl = new System.Windows.Forms.Label();
            this.gateway_lbl = new System.Windows.Forms.Label();
            this.subnetMask_Info = new System.Windows.Forms.Label();
            this.gateway_lblInfo = new System.Windows.Forms.Label();
            this.staticLeases_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.clients_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_panelIP = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIP1 = new System.Windows.Forms.Label();
            this.labelIP2 = new System.Windows.Forms.Label();
            this.labelIP3 = new System.Windows.Forms.Label();
            this.ipRangeStart_validationStatus_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ipRangeStart_validationStatus_ok = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu_panelMain.SuspendLayout();
            this.settings_panelMain.SuspendLayout();
            this.settings_panelInfo.SuspendLayout();
            this.settings_panelInput.SuspendLayout();
            this.overview_panelMain.SuspendLayout();
            this.overview_panelIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipRangeStart_validationStatus_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRangeStart_validationStatus_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.btnOverview.Location = new System.Drawing.Point(8, 8);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(100, 105);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnBasicSettings
            // 
            this.btnBasicSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnBasicSettings.FlatAppearance.BorderSize = 0;
            this.btnBasicSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBasicSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnBasicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicSettings.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicSettings.Location = new System.Drawing.Point(8, 119);
            this.btnBasicSettings.Name = "btnBasicSettings";
            this.btnBasicSettings.Size = new System.Drawing.Size(100, 105);
            this.btnBasicSettings.TabIndex = 2;
            this.btnBasicSettings.Text = "Address Range";
            this.btnBasicSettings.UseVisualStyleBackColor = false;
            this.btnBasicSettings.Click += new System.EventHandler(this.btnBasicSettings_Click);
            // 
            // btnStaticLeases
            // 
            this.btnStaticLeases.BackColor = System.Drawing.Color.Transparent;
            this.btnStaticLeases.FlatAppearance.BorderSize = 0;
            this.btnStaticLeases.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStaticLeases.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnStaticLeases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaticLeases.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaticLeases.Location = new System.Drawing.Point(8, 230);
            this.btnStaticLeases.Name = "btnStaticLeases";
            this.btnStaticLeases.Size = new System.Drawing.Size(100, 105);
            this.btnStaticLeases.TabIndex = 3;
            this.btnStaticLeases.Text = "Static Leases";
            this.btnStaticLeases.UseVisualStyleBackColor = false;
            this.btnStaticLeases.Click += new System.EventHandler(this.btnStaticLeases_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(8, 341);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(100, 105);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // menu_panelMain
            // 
            this.menu_panelMain.AutoScroll = true;
            this.menu_panelMain.AutoScrollMinSize = new System.Drawing.Size(115, 200);
            this.menu_panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_panelMain.Controls.Add(this.btnOverview);
            this.menu_panelMain.Controls.Add(this.btnBasicSettings);
            this.menu_panelMain.Controls.Add(this.btnStaticLeases);
            this.menu_panelMain.Controls.Add(this.btnClients);
            this.menu_panelMain.Controls.Add(this.btnSave);
            this.menu_panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panelMain.Location = new System.Drawing.Point(0, 0);
            this.menu_panelMain.Name = "menu_panelMain";
            this.menu_panelMain.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.menu_panelMain.Size = new System.Drawing.Size(140, 617);
            this.menu_panelMain.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(8, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 105);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // settings_panelMain
            // 
            this.settings_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_panelMain.AutoScroll = true;
            this.settings_panelMain.BackColor = System.Drawing.Color.Green;
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
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.settings_panelInfo.Size = new System.Drawing.Size(726, 67);
            this.settings_panelInfo.TabIndex = 1;
            // 
            // hostIP_lbl
            // 
            this.hostIP_lbl.AutoSize = true;
            this.hostIP_lbl.Location = new System.Drawing.Point(3, 0);
            this.hostIP_lbl.Name = "hostIP_lbl";
            this.hostIP_lbl.Size = new System.Drawing.Size(60, 20);
            this.hostIP_lbl.TabIndex = 0;
            this.hostIP_lbl.Text = "Host IP";
            // 
            // hostSubnetMask_lbl
            // 
            this.hostSubnetMask_lbl.AutoSize = true;
            this.hostSubnetMask_lbl.Location = new System.Drawing.Point(3, 32);
            this.hostSubnetMask_lbl.Name = "hostSubnetMask_lbl";
            this.hostSubnetMask_lbl.Size = new System.Drawing.Size(138, 20);
            this.hostSubnetMask_lbl.TabIndex = 1;
            this.hostSubnetMask_lbl.Text = "Host Subnet Mask";
            // 
            // hostSubnetMask_tb
            // 
            this.hostSubnetMask_tb.Location = new System.Drawing.Point(147, 35);
            this.hostSubnetMask_tb.Name = "hostSubnetMask_tb";
            this.hostSubnetMask_tb.Size = new System.Drawing.Size(100, 26);
            this.hostSubnetMask_tb.TabIndex = 3;
            // 
            // hostIP_lblInfo
            // 
            this.hostIP_lblInfo.AutoSize = true;
            this.hostIP_lblInfo.Location = new System.Drawing.Point(253, 0);
            this.hostIP_lblInfo.Name = "hostIP_lblInfo";
            this.hostIP_lblInfo.Size = new System.Drawing.Size(84, 20);
            this.hostIP_lblInfo.TabIndex = 4;
            this.hostIP_lblInfo.Text = "HostIPInfo";
            // 
            // hostSubnetMask_lblInfo
            // 
            this.hostSubnetMask_lblInfo.AutoSize = true;
            this.hostSubnetMask_lblInfo.Location = new System.Drawing.Point(253, 32);
            this.hostSubnetMask_lblInfo.Name = "hostSubnetMask_lblInfo";
            this.hostSubnetMask_lblInfo.Size = new System.Drawing.Size(158, 20);
            this.hostSubnetMask_lblInfo.TabIndex = 5;
            this.hostSubnetMask_lblInfo.Text = "HostSubnetMaskInfo";
            // 
            // hostIP_tb
            // 
            this.hostIP_tb.Location = new System.Drawing.Point(147, 3);
            this.hostIP_tb.Name = "hostIP_tb";
            this.hostIP_tb.Size = new System.Drawing.Size(100, 26);
            this.hostIP_tb.TabIndex = 2;
            // 
            // settings_panelInput
            // 
            this.settings_panelInput.ColumnCount = 4;
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settings_panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lblInfo, 3, 0);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lbl, 0, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_lblInfo, 3, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_tb, 1, 0);
            this.settings_panelInput.Controls.Add(this.ipRangeEnd_tb, 1, 1);
            this.settings_panelInput.Controls.Add(this.ipRangeStart_lbl, 0, 0);
            this.settings_panelInput.Controls.Add(this.subnetMask_tb, 1, 2);
            this.settings_panelInput.Controls.Add(this.gateway_tb, 1, 3);
            this.settings_panelInput.Controls.Add(this.subnetMask_lbl, 0, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lbl, 0, 3);
            this.settings_panelInput.Controls.Add(this.subnetMask_Info, 3, 2);
            this.settings_panelInput.Controls.Add(this.gateway_lblInfo, 3, 3);
            this.settings_panelInput.Location = new System.Drawing.Point(3, 76);
            this.settings_panelInput.Name = "settings_panelInput";
            this.settings_panelInput.RowCount = 5;
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settings_panelInput.Size = new System.Drawing.Size(726, 150);
            this.settings_panelInput.TabIndex = 0;
            // 
            // ipRangeStart_lblInfo
            // 
            this.ipRangeStart_lblInfo.AutoSize = true;
            this.ipRangeStart_lblInfo.Location = new System.Drawing.Point(299, 0);
            this.ipRangeStart_lblInfo.Name = "ipRangeStart_lblInfo";
            this.ipRangeStart_lblInfo.Size = new System.Drawing.Size(130, 20);
            this.ipRangeStart_lblInfo.TabIndex = 1;
            this.ipRangeStart_lblInfo.Text = "IPRangeStartInfo";
            // 
            // ipRangeEnd_lbl
            // 
            this.ipRangeEnd_lbl.AutoSize = true;
            this.ipRangeEnd_lbl.Location = new System.Drawing.Point(3, 32);
            this.ipRangeEnd_lbl.Name = "ipRangeEnd_lbl";
            this.ipRangeEnd_lbl.Size = new System.Drawing.Size(102, 20);
            this.ipRangeEnd_lbl.TabIndex = 2;
            this.ipRangeEnd_lbl.Text = "IP Range End";
            // 
            // ipRangeEnd_lblInfo
            // 
            this.ipRangeEnd_lblInfo.AutoSize = true;
            this.ipRangeEnd_lblInfo.Location = new System.Drawing.Point(299, 32);
            this.ipRangeEnd_lblInfo.Name = "ipRangeEnd_lblInfo";
            this.ipRangeEnd_lblInfo.Size = new System.Drawing.Size(122, 20);
            this.ipRangeEnd_lblInfo.TabIndex = 3;
            this.ipRangeEnd_lblInfo.Text = "IPRangeEndInfo";
            // 
            // ipRangeStart_tb
            // 
            this.ipRangeStart_tb.Location = new System.Drawing.Point(153, 3);
            this.ipRangeStart_tb.Name = "ipRangeStart_tb";
            this.ipRangeStart_tb.Size = new System.Drawing.Size(100, 26);
            this.ipRangeStart_tb.TabIndex = 4;
            this.ipRangeStart_tb.Validating += new System.ComponentModel.CancelEventHandler(this.IpRangeStart_tb_Validating);
            this.ipRangeStart_tb.Validated += new System.EventHandler(this.IpRangeStart_tb_Validated);
            // 
            // ipRangeEnd_tb
            // 
            this.ipRangeEnd_tb.Location = new System.Drawing.Point(153, 35);
            this.ipRangeEnd_tb.Name = "ipRangeEnd_tb";
            this.ipRangeEnd_tb.Size = new System.Drawing.Size(100, 26);
            this.ipRangeEnd_tb.TabIndex = 5;
            // 
            // ipRangeStart_lbl
            // 
            this.ipRangeStart_lbl.AutoSize = true;
            this.ipRangeStart_lbl.Location = new System.Drawing.Point(3, 0);
            this.ipRangeStart_lbl.Name = "ipRangeStart_lbl";
            this.ipRangeStart_lbl.Size = new System.Drawing.Size(110, 20);
            this.ipRangeStart_lbl.TabIndex = 0;
            this.ipRangeStart_lbl.Text = "IP Range Start";
            // 
            // subnetMask_tb
            // 
            this.subnetMask_tb.Location = new System.Drawing.Point(153, 67);
            this.subnetMask_tb.Name = "subnetMask_tb";
            this.subnetMask_tb.Size = new System.Drawing.Size(100, 26);
            this.subnetMask_tb.TabIndex = 6;
            // 
            // gateway_tb
            // 
            this.gateway_tb.Location = new System.Drawing.Point(153, 99);
            this.gateway_tb.Name = "gateway_tb";
            this.gateway_tb.Size = new System.Drawing.Size(100, 26);
            this.gateway_tb.TabIndex = 7;
            // 
            // subnetMask_lbl
            // 
            this.subnetMask_lbl.AutoSize = true;
            this.subnetMask_lbl.Location = new System.Drawing.Point(3, 64);
            this.subnetMask_lbl.Name = "subnetMask_lbl";
            this.subnetMask_lbl.Size = new System.Drawing.Size(100, 20);
            this.subnetMask_lbl.TabIndex = 8;
            this.subnetMask_lbl.Text = "Subnet Mask";
            // 
            // gateway_lbl
            // 
            this.gateway_lbl.AutoSize = true;
            this.gateway_lbl.Location = new System.Drawing.Point(3, 96);
            this.gateway_lbl.Name = "gateway_lbl";
            this.gateway_lbl.Size = new System.Drawing.Size(71, 20);
            this.gateway_lbl.TabIndex = 9;
            this.gateway_lbl.Text = "Gateway";
            // 
            // subnetMask_Info
            // 
            this.subnetMask_Info.AutoSize = true;
            this.subnetMask_Info.Location = new System.Drawing.Point(299, 64);
            this.subnetMask_Info.Name = "subnetMask_Info";
            this.subnetMask_Info.Size = new System.Drawing.Size(124, 20);
            this.subnetMask_Info.TabIndex = 10;
            this.subnetMask_Info.Text = "SubnetMaskInfo";
            // 
            // gateway_lblInfo
            // 
            this.gateway_lblInfo.AutoSize = true;
            this.gateway_lblInfo.Location = new System.Drawing.Point(299, 96);
            this.gateway_lblInfo.Name = "gateway_lblInfo";
            this.gateway_lblInfo.Size = new System.Drawing.Size(99, 20);
            this.gateway_lblInfo.TabIndex = 11;
            this.gateway_lblInfo.Text = "GatewayInfo";
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
            this.overview_panelMain.Controls.Add(this.overview_panelIP);
            this.overview_panelMain.Location = new System.Drawing.Point(143, 0);
            this.overview_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.overview_panelMain.Name = "overview_panelMain";
            this.overview_panelMain.Size = new System.Drawing.Size(729, 617);
            this.overview_panelMain.TabIndex = 2;
            this.overview_panelMain.Visible = false;
            // 
            // overview_panelIP
            // 
            this.overview_panelIP.Controls.Add(this.labelIP1);
            this.overview_panelIP.Controls.Add(this.labelIP2);
            this.overview_panelIP.Controls.Add(this.labelIP3);
            this.overview_panelIP.Location = new System.Drawing.Point(3, 3);
            this.overview_panelIP.Name = "overview_panelIP";
            this.overview_panelIP.Padding = new System.Windows.Forms.Padding(5);
            this.overview_panelIP.Size = new System.Drawing.Size(658, 57);
            this.overview_panelIP.TabIndex = 0;
            // 
            // labelIP1
            // 
            this.labelIP1.AutoSize = true;
            this.labelIP1.Location = new System.Drawing.Point(8, 5);
            this.labelIP1.Name = "labelIP1";
            this.labelIP1.Size = new System.Drawing.Size(84, 20);
            this.labelIP1.TabIndex = 0;
            this.labelIP1.Text = "IP Address";
            // 
            // labelIP2
            // 
            this.labelIP2.AutoSize = true;
            this.labelIP2.Location = new System.Drawing.Point(98, 5);
            this.labelIP2.Name = "labelIP2";
            this.labelIP2.Size = new System.Drawing.Size(47, 20);
            this.labelIP2.TabIndex = 1;
            this.labelIP2.Text = "static";
            // 
            // labelIP3
            // 
            this.labelIP3.AutoSize = true;
            this.labelIP3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "HostIP", true));
            this.labelIP3.Location = new System.Drawing.Point(151, 5);
            this.labelIP3.Name = "labelIP3";
            this.labelIP3.Size = new System.Drawing.Size(52, 20);
            this.labelIP3.TabIndex = 2;
            this.labelIP3.Text = "label1";
            // 
            // ipRangeStart_validationStatus_error
            // 
            this.ipRangeStart_validationStatus_error.ContainerControl = this;
            this.ipRangeStart_validationStatus_error.Icon = ((System.Drawing.Icon)(resources.GetObject("ipRangeStart_validationStatus_error.Icon")));
            // 
            // ipRangeStart_validationStatus_ok
            // 
            this.ipRangeStart_validationStatus_ok.ContainerControl = this;
            this.ipRangeStart_validationStatus_ok.Icon = ((System.Drawing.Icon)(resources.GetObject("ipRangeStart_validationStatus_ok.Icon")));
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(GM4D.Settings);
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
            this.overview_panelMain.ResumeLayout(false);
            this.overview_panelIP.ResumeLayout(false);
            this.overview_panelIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipRangeStart_validationStatus_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRangeStart_validationStatus_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void tbIPRangeStart_Validating(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnBasicSettings;
        private System.Windows.Forms.Button btnStaticLeases;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.FlowLayoutPanel menu_panelMain;
        private System.Windows.Forms.FlowLayoutPanel settings_panelMain;
        private System.Windows.Forms.FlowLayoutPanel staticLeases_panelMain;
        private System.Windows.Forms.FlowLayoutPanel clients_panelMain;
        private System.Windows.Forms.FlowLayoutPanel overview_panelMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.FlowLayoutPanel overview_panelIP;
        private System.Windows.Forms.Label labelIP1;
        private System.Windows.Forms.Label labelIP2;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.Label labelIP3;
        private System.Windows.Forms.TableLayoutPanel settings_panelInput;
        private System.Windows.Forms.Label ipRangeStart_lblInfo;
        private System.Windows.Forms.Label ipRangeEnd_lbl;
        private System.Windows.Forms.Label ipRangeEnd_lblInfo;
        private System.Windows.Forms.TextBox ipRangeStart_tb;
        private System.Windows.Forms.TextBox ipRangeEnd_tb;
        private System.Windows.Forms.Label ipRangeStart_lbl;
        private System.Windows.Forms.TextBox subnetMask_tb;
        private System.Windows.Forms.TextBox gateway_tb;
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
        private System.Windows.Forms.ErrorProvider ipRangeStart_validationStatus_error;
        private System.Windows.Forms.ErrorProvider ipRangeStart_validationStatus_ok;
    }
}

