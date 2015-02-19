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
            this.panelStaticLeases = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClients = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOverviewIP = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIP1 = new System.Windows.Forms.Label();
            this.labelIP2 = new System.Windows.Forms.Label();
            this.labelIP3 = new System.Windows.Forms.Label();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelOverview.SuspendLayout();
            this.panelOverviewIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panelSettings.Controls.Add(this.tableLayoutPanel1);
            this.panelSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSettings.Location = new System.Drawing.Point(143, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(729, 617);
            this.panelSettings.TabIndex = 3;
            this.panelSettings.Visible = false;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
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
            this.panelOverview.ResumeLayout(false);
            this.panelOverviewIP.ResumeLayout(false);
            this.panelOverviewIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

