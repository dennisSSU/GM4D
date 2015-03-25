using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    partial class MainWindow : Form
    {
        #region Main
        private Settings settings;
        private IOController ioController;
        public MainWindow(Settings _settings, IOController _ioCOntroller)
        {
            InitializeComponent();
            this.settings = _settings;
            this.ioController = _ioCOntroller;
        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            this.statusRequired.SetError(this.ipRangeStart_input, "this field is required");
            this.statusRequired.SetError(this.ipRangeEnd_input, "this field is required");
            this.statusRequired.SetError(this.subnet_input, "this field is required");
            this.statusRequired.SetError(this.subnetMask_input, "this field is required");
            //set source of databindings source
            this.settingsBindingSource.DataSource = settings;
        }

        public void MainWindow_Shown(object sender, EventArgs e)
        {
            
        }
        #endregion Main

        #region MenuPanel
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
        #endregion MenuPanel

        #region OverviewPanel
        private void overview_validateIpInput(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                if (settings.NetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.settings.NewHostIP = ipAddress.ToString();
                }
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }

        private void overview_validateSubnetMaskInput(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid subnet mask");
                this.settings.NewHostSubnetMask = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid subnet mask");
            }
        }

        private void overview_hostip_btn_Click(object sender, EventArgs e)
        {
            this.overview_setHostIp_panel.Visible = true;
            ((Button)sender).Enabled = false;
            if (this.settings.HostIpIsSet && this.settings.HostSubnetMaskIsSet)
            {
                this.overview_setHostIp_ip_ipinput.Text = this.settings.HostIP;
                this.overview_setHostIp_subnetmask_ipinput.Text = this.settings.HostSubnetMask;
            }
        }

        private void overview_setHostIp_set_btn_Click(object sender, EventArgs e)
        {
            this.overview_setHostIp_ip_ipinput.Focus();
            this.overview_setHostIp_subnetmask_ipinput.Focus();
            this.overview_panelMain.Focus();
            if (this.settings.NewHostIpIsSet && this.settings.NewHostSubnetMaskIsSet)
            {
                try
                {
                    this.ioController.SetNewHostIp();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("This is only supported on a Unix machine.", exc.Message);
                }
                this.overview_hostip_btn.Enabled = true;
                this.overview_setHostIp_panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter valid IP address and subnetmask before saving");
            }
        }

        private void overview_hostip_info_subnetMask_lbl_Click(object sender, EventArgs e)
        {

        }

        private void overview_dhcpServer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ioController.InstallDHCPServer();
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Failed to install DHCP server");
            }
        }

        private void overview_setHostIp_cancel_btn_Click(object sender, EventArgs e)
        {
            this.overview_hostip_btn.Enabled = true;
            this.overview_setHostIp_panel.Visible = false;
        }
        #endregion OverviewPanel

        #region SettingsPanel
        private void settings_validateIpInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender,"");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                if (settings.NetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                {
                    setValidationOk(sender,"valid IP address");
                    this.settings.IpRangeStart = ipAddress.ToString();
                }
            }
            else
            {
                setValidationError(sender,"please enter valid IP address");
            }
        }

        private void settings_validateIpRangeEndInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.IpRangeEnd = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }
        private void settings_validateSubnetInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.Subnet = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }
        private void settings_validateSubnetMaskInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.SubnetMask = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }
        private void settings_validateGatewayInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.Gateway = ipAddress.ToString();
            }
            else
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }
        private void settings_validatePrimaryDNSInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.PrimaryDNS = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }

        private void settings_validateSecondaryDNSInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.SecondaryDNS = ipAddress.ToString();
            }
            else
            {
                setValidationError(sender,"please enter valid IP address");
            }
        }

        #endregion SettingsPanel

        #region MenuBottomPanel
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ioController.SaveSettingsFile(((SaveFileDialog)sender).FileName);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ioController.LoadSettingsFile(((OpenFileDialog)sender).FileName);
        }

        private void menuBottom_btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                ioController.ApplySettingsToDHCPServer();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("This feature requires a Unix environment!");
            }
            
        }
        private void menuBottom_backUpConfig_Click(object sender, EventArgs e)
        {
            
        }
        #endregion MenuBottomPanel

        #region Validation
        private void setValidationError (object sender, string message)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, message);
        }
        private void setValidationOk(object sender, string message)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, message);
        }
        #endregion Validation

       

        public void ShowMessageBox(String text, String title)
        {
            MessageBox.Show(text, title);
        }

        private void overview_dhcpDeamon_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ioController.StartDHCPServer();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "StartDHCPServer failed");
            }
        }
    }
}
