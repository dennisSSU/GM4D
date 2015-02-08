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
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnBasicSettings = new System.Windows.Forms.Button();
            this.btnStaticLeases = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.panelStaticLeases = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClients = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
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
            this.btnOverview.Size = new System.Drawing.Size(100, 100);
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
            this.btnBasicSettings.Location = new System.Drawing.Point(8, 114);
            this.btnBasicSettings.Name = "btnBasicSettings";
            this.btnBasicSettings.Size = new System.Drawing.Size(100, 100);
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
            this.btnStaticLeases.Location = new System.Drawing.Point(8, 220);
            this.btnStaticLeases.Name = "btnStaticLeases";
            this.btnStaticLeases.Size = new System.Drawing.Size(100, 100);
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
            this.btnClients.Location = new System.Drawing.Point(8, 326);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(100, 100);
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
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panelMenu.Size = new System.Drawing.Size(140, 586);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.AutoScroll = true;
            this.panelSettings.BackColor = System.Drawing.Color.Green;
            this.panelSettings.Location = new System.Drawing.Point(143, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(729, 586);
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
            this.panelStaticLeases.Size = new System.Drawing.Size(729, 586);
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
            this.panelClients.Size = new System.Drawing.Size(729, 586);
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
            this.panelOverview.Location = new System.Drawing.Point(143, 0);
            this.panelOverview.Margin = new System.Windows.Forms.Padding(0);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(729, 586);
            this.panelOverview.TabIndex = 2;
            this.panelOverview.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 586);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelOverview);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelStaticLeases);
            this.Controls.Add(this.panelClients);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainWindow";
            this.Text = "GM4D - Graphical Manager for DHCP";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnBasicSettings;
        private System.Windows.Forms.Button btnStaticLeases;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel panelSettings;
        private System.Windows.Forms.FlowLayoutPanel panelStaticLeases;
        private System.Windows.Forms.FlowLayoutPanel panelClients;
        private System.Windows.Forms.FlowLayoutPanel panelOverview;
    }
}

