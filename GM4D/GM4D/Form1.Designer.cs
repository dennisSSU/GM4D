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
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHostIP = new System.Windows.Forms.Label();
            this.lblHostSubnetMask = new System.Windows.Forms.Label();
            this.tbHostSubnetMask = new System.Windows.Forms.TextBox();
            this.lblHostIPInfo = new System.Windows.Forms.Label();
            this.lblHostSubnetMaskInfo = new System.Windows.Forms.Label();
            this.tbHostIP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIPRangeStartInfo = new System.Windows.Forms.Label();
            this.lblIPRangeEnd = new System.Windows.Forms.Label();
            this.lblIPRangeEndInfo = new System.Windows.Forms.Label();
            this.tbIPRangeStart = new System.Windows.Forms.TextBox();
            this.tbIPRangeEnd = new System.Windows.Forms.TextBox();
            this.lblIPRangeStart = new System.Windows.Forms.Label();
            this.tbSubnetMask = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblSubnetMaskInfo = new System.Windows.Forms.Label();
            this.lblGatewayInfo = new System.Windows.Forms.Label();
            this.panelStaticLeases = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClients = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOverviewIP = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIP1 = new System.Windows.Forms.Label();
            this.labelIP2 = new System.Windows.Forms.Label();
            this.labelIP3 = new System.Windows.Forms.Label();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelOverview.SuspendLayout();
            this.panelOverviewIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.AutoScrollMinSize = new System.Drawing.Size(115, 200);
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMenu.Controls.Add(this.btnOverview);
            this.panelMenu.Controls.Add(this.btnBasicSettings);
            this.panelMenu.Controls.Add(this.btnStaticLeases);
            this.panelMenu.Controls.Add(this.btnClients);
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panelMenu.Size = new System.Drawing.Size(140, 617);
            this.panelMenu.TabIndex = 1;
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
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.AutoScroll = true;
            this.panelSettings.BackColor = System.Drawing.Color.Green;
            this.panelSettings.Controls.Add(this.tableLayoutPanel2);
            this.panelSettings.Controls.Add(this.tableLayoutPanel1);
            this.panelSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSettings.Location = new System.Drawing.Point(143, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(729, 617);
            this.panelSettings.TabIndex = 3;
            this.panelSettings.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblHostIP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHostSubnetMask, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbHostSubnetMask, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHostIPInfo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHostSubnetMaskInfo, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbHostIP, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 67);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblHostIP
            // 
            this.lblHostIP.AutoSize = true;
            this.lblHostIP.Location = new System.Drawing.Point(3, 0);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(60, 20);
            this.lblHostIP.TabIndex = 0;
            this.lblHostIP.Text = "Host IP";
            // 
            // lblHostSubnetMask
            // 
            this.lblHostSubnetMask.AutoSize = true;
            this.lblHostSubnetMask.Location = new System.Drawing.Point(3, 32);
            this.lblHostSubnetMask.Name = "lblHostSubnetMask";
            this.lblHostSubnetMask.Size = new System.Drawing.Size(138, 20);
            this.lblHostSubnetMask.TabIndex = 1;
            this.lblHostSubnetMask.Text = "Host Subnet Mask";
            // 
            // tbHostSubnetMask
            // 
            this.tbHostSubnetMask.Location = new System.Drawing.Point(147, 35);
            this.tbHostSubnetMask.Name = "tbHostSubnetMask";
            this.tbHostSubnetMask.Size = new System.Drawing.Size(100, 26);
            this.tbHostSubnetMask.TabIndex = 3;
            // 
            // lblHostIPInfo
            // 
            this.lblHostIPInfo.AutoSize = true;
            this.lblHostIPInfo.Location = new System.Drawing.Point(253, 0);
            this.lblHostIPInfo.Name = "lblHostIPInfo";
            this.lblHostIPInfo.Size = new System.Drawing.Size(84, 20);
            this.lblHostIPInfo.TabIndex = 4;
            this.lblHostIPInfo.Text = "HostIPInfo";
            // 
            // lblHostSubnetMaskInfo
            // 
            this.lblHostSubnetMaskInfo.AutoSize = true;
            this.lblHostSubnetMaskInfo.Location = new System.Drawing.Point(253, 32);
            this.lblHostSubnetMaskInfo.Name = "lblHostSubnetMaskInfo";
            this.lblHostSubnetMaskInfo.Size = new System.Drawing.Size(158, 20);
            this.lblHostSubnetMaskInfo.TabIndex = 5;
            this.lblHostSubnetMaskInfo.Text = "HostSubnetMaskInfo";
            // 
            // tbHostIP
            // 
            this.tbHostIP.Location = new System.Drawing.Point(147, 3);
            this.tbHostIP.Name = "tbHostIP";
            this.tbHostIP.Size = new System.Drawing.Size(100, 26);
            this.tbHostIP.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblIPRangeStartInfo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIPRangeEnd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIPRangeEndInfo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIPRangeStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbIPRangeEnd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIPRangeStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSubnetMask, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbGateway, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSubnetMask, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGateway, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSubnetMaskInfo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGatewayInfo, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIPRangeStartInfo
            // 
            this.lblIPRangeStartInfo.AutoSize = true;
            this.lblIPRangeStartInfo.Location = new System.Drawing.Point(363, 0);
            this.lblIPRangeStartInfo.Name = "lblIPRangeStartInfo";
            this.lblIPRangeStartInfo.Size = new System.Drawing.Size(130, 20);
            this.lblIPRangeStartInfo.TabIndex = 1;
            this.lblIPRangeStartInfo.Text = "IPRangeStartInfo";
            // 
            // lblIPRangeEnd
            // 
            this.lblIPRangeEnd.AutoSize = true;
            this.lblIPRangeEnd.Location = new System.Drawing.Point(3, 32);
            this.lblIPRangeEnd.Name = "lblIPRangeEnd";
            this.lblIPRangeEnd.Size = new System.Drawing.Size(102, 20);
            this.lblIPRangeEnd.TabIndex = 2;
            this.lblIPRangeEnd.Text = "IP Range End";
            // 
            // lblIPRangeEndInfo
            // 
            this.lblIPRangeEndInfo.AutoSize = true;
            this.lblIPRangeEndInfo.Location = new System.Drawing.Point(363, 32);
            this.lblIPRangeEndInfo.Name = "lblIPRangeEndInfo";
            this.lblIPRangeEndInfo.Size = new System.Drawing.Size(122, 20);
            this.lblIPRangeEndInfo.TabIndex = 3;
            this.lblIPRangeEndInfo.Text = "IPRangeEndInfo";
            // 
            // tbIPRangeStart
            // 
            this.tbIPRangeStart.Location = new System.Drawing.Point(203, 3);
            this.tbIPRangeStart.Name = "tbIPRangeStart";
            this.tbIPRangeStart.Size = new System.Drawing.Size(100, 26);
            this.tbIPRangeStart.TabIndex = 4;
            this.tbIPRangeStart.Validating += new System.ComponentModel.CancelEventHandler(this.tbIPRangeStart_Validating);
            // 
            // tbIPRangeEnd
            // 
            this.tbIPRangeEnd.Location = new System.Drawing.Point(203, 35);
            this.tbIPRangeEnd.Name = "tbIPRangeEnd";
            this.tbIPRangeEnd.Size = new System.Drawing.Size(100, 26);
            this.tbIPRangeEnd.TabIndex = 5;
            // 
            // lblIPRangeStart
            // 
            this.lblIPRangeStart.AutoSize = true;
            this.lblIPRangeStart.Location = new System.Drawing.Point(3, 0);
            this.lblIPRangeStart.Name = "lblIPRangeStart";
            this.lblIPRangeStart.Size = new System.Drawing.Size(110, 20);
            this.lblIPRangeStart.TabIndex = 0;
            this.lblIPRangeStart.Text = "IP Range Start";
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.Location = new System.Drawing.Point(203, 67);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.Size = new System.Drawing.Size(100, 26);
            this.tbSubnetMask.TabIndex = 6;
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(203, 99);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(100, 26);
            this.tbGateway.TabIndex = 7;
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(3, 64);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(100, 20);
            this.lblSubnetMask.TabIndex = 8;
            this.lblSubnetMask.Text = "Subnet Mask";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(3, 96);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(71, 20);
            this.lblGateway.TabIndex = 9;
            this.lblGateway.Text = "Gateway";
            // 
            // lblSubnetMaskInfo
            // 
            this.lblSubnetMaskInfo.AutoSize = true;
            this.lblSubnetMaskInfo.Location = new System.Drawing.Point(363, 64);
            this.lblSubnetMaskInfo.Name = "lblSubnetMaskInfo";
            this.lblSubnetMaskInfo.Size = new System.Drawing.Size(124, 20);
            this.lblSubnetMaskInfo.TabIndex = 10;
            this.lblSubnetMaskInfo.Text = "SubnetMaskInfo";
            // 
            // lblGatewayInfo
            // 
            this.lblGatewayInfo.AutoSize = true;
            this.lblGatewayInfo.Location = new System.Drawing.Point(363, 96);
            this.lblGatewayInfo.Name = "lblGatewayInfo";
            this.lblGatewayInfo.Size = new System.Drawing.Size(99, 20);
            this.lblGatewayInfo.TabIndex = 11;
            this.lblGatewayInfo.Text = "GatewayInfo";
            // 
            // panelStaticLeases
            // 
            this.panelStaticLeases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStaticLeases.AutoScroll = true;
            this.panelStaticLeases.BackColor = System.Drawing.Color.Blue;
            this.panelStaticLeases.Location = new System.Drawing.Point(143, 0);
            this.panelStaticLeases.Margin = new System.Windows.Forms.Padding(0);
            this.panelStaticLeases.Name = "panelStaticLeases";
            this.panelStaticLeases.Size = new System.Drawing.Size(729, 617);
            this.panelStaticLeases.TabIndex = 4;
            this.panelStaticLeases.Visible = false;
            // 
            // panelClients
            // 
            this.panelClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClients.AutoScroll = true;
            this.panelClients.BackColor = System.Drawing.Color.Red;
            this.panelClients.Location = new System.Drawing.Point(143, 0);
            this.panelClients.Margin = new System.Windows.Forms.Padding(0);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(729, 617);
            this.panelClients.TabIndex = 5;
            this.panelClients.Visible = false;
            // 
            // panelOverview
            // 
            this.panelOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOverview.AutoScroll = true;
            this.panelOverview.BackColor = System.Drawing.Color.Yellow;
            this.panelOverview.Controls.Add(this.panelOverviewIP);
            this.panelOverview.Location = new System.Drawing.Point(143, 0);
            this.panelOverview.Margin = new System.Windows.Forms.Padding(0);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(729, 617);
            this.panelOverview.TabIndex = 2;
            this.panelOverview.Visible = false;
            // 
            // panelOverviewIP
            // 
            this.panelOverviewIP.Controls.Add(this.labelIP1);
            this.panelOverviewIP.Controls.Add(this.labelIP2);
            this.panelOverviewIP.Controls.Add(this.labelIP3);
            this.panelOverviewIP.Location = new System.Drawing.Point(3, 3);
            this.panelOverviewIP.Name = "panelOverviewIP";
            this.panelOverviewIP.Padding = new System.Windows.Forms.Padding(5);
            this.panelOverviewIP.Size = new System.Drawing.Size(658, 57);
            this.panelOverviewIP.TabIndex = 0;
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
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(GM4D.Settings);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 617);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelStaticLeases);
            this.Controls.Add(this.panelClients);
            this.Controls.Add(this.panelOverview);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 208);
            this.Name = "MainWindow";
            this.Text = "GM4D - Graphical Manager for DHCP";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelOverview.ResumeLayout(false);
            this.panelOverviewIP.ResumeLayout(false);
            this.panelOverviewIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel panelSettings;
        private System.Windows.Forms.FlowLayoutPanel panelStaticLeases;
        private System.Windows.Forms.FlowLayoutPanel panelClients;
        private System.Windows.Forms.FlowLayoutPanel panelOverview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.FlowLayoutPanel panelOverviewIP;
        private System.Windows.Forms.Label labelIP1;
        private System.Windows.Forms.Label labelIP2;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.Label labelIP3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIPRangeStartInfo;
        private System.Windows.Forms.Label lblIPRangeEnd;
        private System.Windows.Forms.Label lblIPRangeEndInfo;
        private System.Windows.Forms.TextBox tbIPRangeStart;
        private System.Windows.Forms.TextBox tbIPRangeEnd;
        private System.Windows.Forms.Label lblIPRangeStart;
        private System.Windows.Forms.TextBox tbSubnetMask;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblSubnetMaskInfo;
        private System.Windows.Forms.Label lblGatewayInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHostIP;
        private System.Windows.Forms.Label lblHostSubnetMask;
        private System.Windows.Forms.TextBox tbHostSubnetMask;
        private System.Windows.Forms.Label lblHostIPInfo;
        private System.Windows.Forms.Label lblHostSubnetMaskInfo;
        private System.Windows.Forms.TextBox tbHostIP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

