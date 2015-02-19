using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    public partial class MainWindow : Form
    {
        private Settings settings;
        public MainWindow(Settings _settings)
        {
            InitializeComponent();
            this.settings = _settings;
        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.overview_panelMain.Visible = true;
            this.settings_panelMain.Visible = false;
            this.staticLeases_panelMain.Visible = false;
            this.clients_panelMain.Visible = false;            
        }

        private void btnBasicSettings_Click(object sender, EventArgs e)
        {
            this.overview_panelMain.Visible = false;
            this.settings_panelMain.Visible = true;
            this.staticLeases_panelMain.Visible = false;
            this.clients_panelMain.Visible = false;
        }

        private void btnStaticLeases_Click(object sender, EventArgs e)
        {
            this.overview_panelMain.Visible = false;
            this.settings_panelMain.Visible = false;
            this.staticLeases_panelMain.Visible = true;
            this.clients_panelMain.Visible = false;
        }
        
        private void btnClients_Click(object sender, EventArgs e)
        {
            this.overview_panelMain.Visible = false;
            this.settings_panelMain.Visible = false;
            this.staticLeases_panelMain.Visible = false;
            this.clients_panelMain.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void settings_validateIpInput(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.ipRange_validationStatus_error.Clear();
                this.ipRange_validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
            }
            else
            {
                ipRange_validationStatus_ok.Clear();
                ipRange_validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
            
        }
        
    }
}
