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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void IpRangeStart_tb_Validating(object sender, CancelEventArgs e)
        {
            if (ipRangeStart_tb.Text.Length <= 5)
            {
                this.ipRangeStart_validationStatus_error.SetError(ipRangeStart_tb, "please enter valid IP address!");
                this.ipRangeStart_validationStatus_ok.SetError(ipRangeStart_tb, "");
                e.Cancel = true;
            }
        }

        private void IpRangeStart_tb_Validated(object sender, EventArgs e)
        {
            this.ipRangeStart_validationStatus_error.SetError(ipRangeStart_tb, "");
            this.ipRangeStart_validationStatus_ok.SetError(ipRangeStart_tb, "valid IP addres");
        }

        
    }
}
