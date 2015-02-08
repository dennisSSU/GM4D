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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.panelOverview.Visible = true;
            this.panelSettings.Visible = false;
            this.panelStaticLeases.Visible = false;
            this.panelClients.Visible = false;            
        }

        private void btnBasicSettings_Click(object sender, EventArgs e)
        {
            this.panelOverview.Visible = false;
            this.panelSettings.Visible = true;
            this.panelStaticLeases.Visible = false;
            this.panelClients.Visible = false;
        }

        private void btnStaticLeases_Click(object sender, EventArgs e)
        {
            this.panelOverview.Visible = false;
            this.panelSettings.Visible = false;
            this.panelStaticLeases.Visible = true;
            this.panelClients.Visible = false;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.panelOverview.Visible = false;
            this.panelSettings.Visible = false;
            this.panelStaticLeases.Visible = false;
            this.panelClients.Visible = true;
        }

        
    }
}
