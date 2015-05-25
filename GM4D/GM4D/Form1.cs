using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
/* 
 * Filename: Form1.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: contains GUI controller and GUI related code
 */
namespace GM4D
{
    partial class MainWindow : Form
    {
        // main region for settings for the whole GUI
        #region Main
        //################################################################################################# Main
        /// <summary>
        /// data storage object
        /// </summary>
        private Settings settings;
        /// <summary>
        /// backgroundworker for asynchronous tasks
        /// </summary>
        private BackgroundWorker bw;
        /// <summary>
        /// controller for IO operations
        /// </summary>
        private IOController ioController;
        #region colours
        // colours that will be set to controls on application start
        /// <summary>
        /// background colour for inactive (default) buttons
        /// </summary>
        private Color buttonColorBgInactive = SystemColors.Control;
        /// <summary>
        /// background colour for active (after click) buttons
        /// </summary>
        private Color buttonColorBgActive = System.Drawing.ColorTranslator.FromHtml("#E36C43");
        /// <summary>
        /// background colour for buttons on mouse over
        /// </summary>
        private Color buttonColorMouseOver = System.Drawing.ColorTranslator.FromHtml("#E05A2B");
        /// <summary>
        /// background colour for buttons on mouse down
        /// </summary>
        private Color buttonColorMouseDown = System.Drawing.ColorTranslator.FromHtml("#DD4814");
        /// <summary>
        /// background colour for the menu panels
        /// </summary>
        private Color menuColorBg = SystemColors.Control;
        /// <summary>
        /// background colour for all panels
        /// </summary>
        private Color panelColorBg = System.Drawing.ColorTranslator.FromHtml("#AEA79F");
        /// <summary>
        /// background colour for the list views
        /// </summary>
        private Color listViewColorBg = System.Drawing.ColorTranslator.FromHtml("#F6F6F5");
        #endregion colours
        /// <summary>
        /// contructor, registers event handlers
        /// </summary>
        /// <param name="_settings">Settings (data storage) object</param>
        /// <param name="_ioCOntroller">IOController object</param>
        public MainWindow(Settings _settings, IOController _ioCOntroller)
        {
            InitializeComponent();
            this.settings = _settings;
            this.ioController = _ioCOntroller;
            this.settings.DhcpdLeasesChangedEvt += this.OnSettingsDhcpdLeasesChange;
            this.settings.StaticLeasesChangedEvt += this.StaticLeases_ListView_update;
            this.settings.IsDHCPServerInstalledChangedEvt += OnIsDHCPServerInstalledChange;
            this.settings.IsDHCPServerRunningChangedEvt += OnIsDHCPServerRunningChange;
            this.ioController.SettingsFileLoadedEvt += this.OnSettingsFileLoaded;
            this.ioController.UserIsSUChanged += this.OnUserIsSUChanged;
            this.ioController.OsIsUnixChanged += this.OnOsIsUnixChanged;
        }
        /// <summary>
        /// function to show a warning message if OS is not a Unix environment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOsIsUnixChanged(object sender, EventArgs e)
        {
            if (!this.ioController.OsIsUnix)
            {
                MessageBox.Show("The current environment is not a Unix environment. Not all functions will be working.", "No Unix environment");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnUserIsSUChanged(object sender, EventArgs e)
        {
            if (!this.ioController.UserIsSU)
            {
                MessageBox.Show("Some features require root privilleges. It is recommended to run the application with sudo privilleges e.g. 'gksudo mono GM4D.exe'. Otherwise each single command will prompt for SU passward.", "No root privilleges");
            }
        }
        /// <summary>
        /// funtion called automatically after the MainWindow has loaded
        /// registers event handlers and extends the listviews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MainWindow_Load(object sender, EventArgs e)
        {
            // set required icon to inputs
            this.statusRequired.SetError(this.ipRangeStart_input, "this field is required");
            this.statusRequired.SetError(this.subnet_input, "this field is required");
            this.statusRequired.SetError(this.ipRangeEnd_input, "this field is required");
            this.statusRequired.SetError(this.subnetMask_input, "this field is required");
            // set source of databindings source
            this.settingsBindingSource.DataSource = settings;
            // extend listview staticleases with buttons
            ListViewExtender lve = new ListViewExtender(staticLeases_listview);
            ListViewButtonColumn lvbcEdit = new ListViewButtonColumn(4);
            lvbcEdit.Click += ListViewEditClick;
            lvbcEdit.FixedWidth = true;
            lve.AddColumn(lvbcEdit);
            ListViewButtonColumn lvbcDelete = new ListViewButtonColumn(5);
            lvbcDelete.Click += ListViewDeleteClick;
            lvbcDelete.FixedWidth = true;
            lve.AddColumn(lvbcDelete);
            // extend listview clients with buttons
            ListViewExtender clients_lve = new ListViewExtender(clients_dhcpdLeases_listView);
            ListViewButtonColumn clients_lvbc_addStatic = new ListViewButtonColumn(5);
            clients_lvbc_addStatic.Click += ClientsListviewAddStaticClick;
            clients_lvbc_addStatic.FixedWidth = true;
            clients_lve.AddColumn(clients_lvbc_addStatic);
            // extend listview switch nic with buttons
            ListViewExtender switchNic_lve = new ListViewExtender(selectNic_listview);
            ListViewButtonColumn switchNic_lvbc_select = new ListViewButtonColumn(5);
            switchNic_lvbc_select.Click += switchNicSelectClick;
            switchNic_lvbc_select.FixedWidth = true;
            switchNic_lve.AddColumn(switchNic_lvbc_select);
            updateColors();
            this.MaximizeBox = false;
            switchView(views.about);
        }
        /// <summary>
        /// runs throuh all child controls and calls setColors
        /// </summary>
        private void updateColors()
        {
            foreach (Control c in this.Controls)
            {
                setColors(c);
            }
        }
        /// <summary>
        /// runs through the control and all children to set the colours specified in colour region
        /// </summary>
        /// <param name="ctrl">control to run through</param>
        private void setColors(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).BackColor = this.buttonColorBgInactive;
                    ((Button)c).FlatAppearance.MouseDownBackColor = this.buttonColorMouseDown;
                    ((Button)c).FlatAppearance.MouseOverBackColor = this.buttonColorMouseOver;
                }
                else if (c is Panel)
                {
                    if (c.Name.Contains("main") || c.Name.Contains("Main"))
                    {
                        ((Panel)c).BackColor = panelColorBg;
                    }
                }
                else if (c is FlowLayoutPanel){
                    ((FlowLayoutPanel)c).BackColor = panelColorBg;
                }
                else if (c is ListView)
                {
                    ((ListView)c).BackColor = this.listViewColorBg;
                }
                if (c.HasChildren)
                {
                    setColors(c);
                }
            }
            this.menu_panelMain.BackColor = this.menuColorBg;
            this.menuBottom_panelMain.BackColor = this.menuColorBg;
        }
        #endregion Main
        // region for the main menu panel on the left
        #region MenuPanel
        //################################################################################################# MenuPanel
        /// <summary>
        /// enum containing all possible views
        /// </summary>
        private enum views {none, overview, changenic, sethostip, settings, staticLeases, clients, about};
        /// <summary>
        /// switches the view
        /// makes the view passed in the parameter visible and hides all others
        /// </summary>
        /// <param name="view">views enum to chenge to</param>
        private void switchView(views view)
        {
            IOController.Log(this, "switchView: " + view.ToString(), IOController.Flag.debug);
            // hide panels and set button colours to inactive
            this.overview_panelMain.Visible = false;
            this.menu_btnOverview.BackColor = this.buttonColorBgInactive;
            this.settings_panelMain.Visible = false;
            this.menu_btnBasicSettings.BackColor = this.buttonColorBgInactive;
            this.staticLeases_panelMain.Visible = false;
            this.menu_btnStaticLeases.BackColor = this.buttonColorBgInactive;
            this.clients_panelMain.Visible = false;
            this.menu_btnClients.BackColor = this.buttonColorBgInactive;
            this.changeNic_panelMain.Visible = false;
            this.setHostIp_panelMain.Visible = false;
            this.copyright_panel.Visible = false;
            IOController.Log(this, "switchView: all panels invisible", IOController.Flag.debug);
            // show panel of selected view
            switch (view)
            {
                case views.overview: 
                    this.overview_panelMain.Visible = true;
                    this.menu_btnOverview.BackColor = this.buttonColorBgActive;
                    overviewRefresh();
                    break;
                case views.changenic:
                    this.changeNic_panelMain.Visible = true;
                    break;
                case views.sethostip:
                    this.setHostIp_panelMain.Visible = true;
                    break;
                case views.settings:
                    this.settings_panelMain.Visible = true;
                    this.menu_btnBasicSettings.BackColor = this.buttonColorBgActive;
                    settingsTriggerValidation();
                    break;
                case views.staticLeases: 
                    this.staticLeases_panelMain.Visible = true;
                    staticLeasesTriggerValidation();
                    this.menu_btnStaticLeases.BackColor = this.buttonColorBgActive;
                    break;
                case views.clients: 
                    this.clients_panelMain.Visible = true;
                    this.menu_btnClients.BackColor = this.buttonColorBgActive;
                    break;
                default: 
                    this.copyright_panel.Visible = true;
                    break;
            }
        }
        /// <summary>
        /// first menue button click, switches to overview view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverview_Click(object sender, EventArgs e)
        {
            switchView(views.overview);
        }
        /// <summary>
        /// second menue button click, switches to settings view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            switchView(views.settings);
        }
        /// <summary>
        /// third menue button click, switches to staticleases view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStaticLeases_Click(object sender, EventArgs e)
        {
            switchView(views.staticLeases);
        }
        /// <summary>
        /// fourth menue button click, switch to clients view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            switchView(views.clients);
        }
        /// <summary>
        /// switches to about view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            switchView(views.about);
        }
        #endregion MenuPanel
        // region for the overview panel
        #region OverviewPanel
        //################################################################################################# OverviewPanel
        /// <summary>
        /// refresh the labels and values from settings object (needed because the data binding does not always in Linux/Mono)
        /// </summary>
        private void overviewRefresh()
        {
            this.overview_hostNic_status_lbl.Text = this.settings.OverviewSelectedInterfaceName;
            this.overview_hostNic_status_lbl.Refresh();
            this.overview_hostip_info_ip_lbl.Text = this.settings.HostIP;
            this.overview_hostip_info_ip_lbl.Refresh();
            this.overview_hostip_info_subnetMask_lbl.Text = this.settings.HostSubnetMask;
            this.overview_hostip_info_subnetMask_lbl.Refresh();
        }
        /// <summary>
        /// input validation for host ip address input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_validateIpInput(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.settings.NewHostIP = ipAddress.ToString();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// input validation for host subnet mask input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_validateSubnetMaskInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// switches view to set host ip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_hostip_btn_Click(object sender, EventArgs e)
        {
            if (ioController.OsIsUnix)
            {
                try
                {
                    switchView(views.sethostip);
                    ((Button)sender).Enabled = false;
                    if (this.settings.HostIpIsSet && this.settings.HostSubnetMaskIsSet)
                    {
                        this.overview_setHostIp_ip_ipinput.Text = this.settings.HostIP;
                        this.overview_setHostIp_ip_ipinput.Focus();
                        this.overview_setHostIp_subnetmask_ipinput.Text = this.settings.HostSubnetMask;
                        this.overview_setHostIp_subnetmask_ipinput.Focus();
                        this.overview_setHostIp_ip_ipinput.Focus();
                    }
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                }
            }
            else
            {
                MessageBox.Show("This feature is only supported in an Unix environment.", "Not an Unix environment!");
            }
        }
        /// <summary>
        /// sets the new host ip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_setHostIp_set_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // trigger validation
                this.overview_setHostIp_ip_ipinput.Focus();
                this.overview_setHostIp_subnetmask_ipinput.Focus();
                this.overview_panelMain.Focus();
                // set new host ip
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
                    switchView(views.overview);
                    this.validationStatus_error.SetError(this.overview_setHostIp_ip_ipinput, "");
                    this.validationStatus_ok.SetError(this.overview_setHostIp_ip_ipinput, "");
                    this.validationStatus_error.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
                    this.validationStatus_ok.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
                }
                else
                {
                    MessageBox.Show("Please enter valid IP address and subnetmask before saving");
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// cancels setting the new host ip and switches view back to overview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_setHostIp_cancel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.overview_hostip_btn.Enabled = true;
                switchView(views.overview);
                this.settings.NewHostIP = "";
                this.settings.NewHostIpIsSet = false;
                this.settings.NewHostSubnetMask = "";
                this.settings.NewHostSubnetMaskIsSet = false;
                this.overview_setHostIp_ip_ipinput.Clear();
                this.overview_setHostIp_subnetmask_ipinput.Clear();
                this.validationStatus_error.SetError(this.overview_setHostIp_ip_ipinput, "");
                this.validationStatus_ok.SetError(this.overview_setHostIp_ip_ipinput, "");
                this.validationStatus_error.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
                this.validationStatus_ok.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// sets available interfaces to list view and switches view to select nic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_hostNic_btn_Click(object sender, EventArgs e)
        {
            this.selectNic_listview.Items.Clear();
            for (int i = 0; i < this.settings.Interfaces.Count;i++ )
            {
                HostNIC nic = (HostNIC)this.settings.Interfaces[i];
                if (nic.Ipv4Enabled)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(nic.Id);
                    item.SubItems.Add(nic.Name);
                    item.SubItems.Add(nic.MacAddress);
                    item.SubItems.Add(nic.IPAddress);
                    item.SubItems.Add("select");
                    this.selectNic_listview.Items.Add(item);
                }
            }
            switchView(views.changenic);
            this.selectNic_listview.Refresh();
        }
        /// <summary>
        /// switches to the interface clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchNicSelectClick(object sender, ListViewColumnMouseEventArgs e)
        {
            int i = int.Parse(e.Item.Text);
            if (ioController.OsIsUnix)
            {
                try
                {
                    this.settings.SelectInterface(i);
                    switchView(views.overview);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This interface can not be used for the DHCP server. Make sure IPv4 is enabled and IP is set.", "Failed to select interface");
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                }
            }
            else
            {
                this.settings.SelectInterface(i);
                switchView(views.overview);
            }
        }
        /// <summary>
        /// installes the isc-dhcp-server package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_dhcpServer_btn_Click(object sender, EventArgs e)
        {
            if (ioController.OsIsUnix)
            {
                try
                {
                    this.ioController.InstallDHCPServer();
                    this.ioController.GetDHCPServerInstallStatus();
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                    MessageBox.Show("Failed to install DHCP server");
                }
            }
            else
            {
                MessageBox.Show("This feature is only supported in an Unix environment.", "Not an Unix environment!");
            }
        }
        /// <summary>
        /// starts or stops the dhcp server service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_dhcpDeamon_btn_Click(object sender, EventArgs e)
        {
            if (ioController.OsIsUnix)
            {
                try
                {
                    if (this.settings.IsDHCPServerRunning)
                    {
                        try
                        {
                            this.ioController.StopDHCPServer();
                        }
                        catch (Exception exc)
                        {
                            IOController.Log(this, exc.Message, IOController.Flag.error);
                            MessageBox.Show("StopDHCPServer failed");
                        }
                    }
                    else
                    {
                        try
                        {
                            this.ioController.StartDHCPServer();
                        }
                        catch (Exception exc)
                        {
                            IOController.Log(this, exc.Message, IOController.Flag.error);
                            MessageBox.Show(exc.Message, "StartDHCPServer failed");
                        }
                    }
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                }
            }
            else
            {
                MessageBox.Show("This feature is only supported in an Unix environment.", "Not an Unix environment!");
            }
        }
        /// <summary>
        /// eventhandler, calls function to change the install button for dhcp server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIsDHCPServerInstalledChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.overview_dhcpServer_btn.InvokeRequired)
            {
                changeDhcpServerInstallButtonCallback cb = new changeDhcpServerInstallButtonCallback(changeDhcpServerInstallButton);
                this.Invoke(cb);
            }
            else
            {
                changeDhcpServerInstallButton();
            }
        }
        private delegate void changeDhcpServerInstallButtonCallback();
        /// <summary>
        /// changes the install button for dhcp server - use OnIsDHCPServerInstalledChange to call threadsafe
        /// </summary>
        private void changeDhcpServerInstallButton()
        {
            try
            {
                if (this.settings.IsDHCPServerInstalled)
                {
                    this.overview_dhcpServer_btn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// eventhalndler, calls function to cahnge start/stop button for dhcp server service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIsDHCPServerRunningChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.overview_dhcpDeamon_btn.InvokeRequired)
            {
                changeDhcpServerRunningButtonCallback cb = new changeDhcpServerRunningButtonCallback(changeDhcpServerRunningButton);
                this.Invoke(cb);
            }
            else
            {
                changeDhcpServerRunningButton();
            }
        }
        private delegate void changeDhcpServerRunningButtonCallback();
        /// <summary>
        /// changes the button to start or stop dhcp server service, fo rthreadsafe call use OnIsDHCPServerRunningChange
        /// </summary>
        private void changeDhcpServerRunningButton()
        {
            try
            {
                if (this.settings.IsDHCPServerRunning)
                {
                    this.overview_dhcpDeamon_btn.Text = "stop";
                    this.overview_dhcpDeamon_status_lbl.Text = "running";
                }
                else
                {
                    this.overview_dhcpDeamon_btn.Text = "start";
                    this.overview_dhcpDeamon_status_lbl.Text = "stopped";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        #endregion OverviewPanel
        // region for the settings panel
        #region SettingsPanel
        //################################################################################################# SettingsPanel
        /// <summary>
        /// This function validates the input of the IPAddressControl for the startng address of the IP range
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateIpRangeStartInput(object sender, EventArgs e)
        {
            this.settings.IpRangeStartIsValid = false;
            try
            {
                // disblae required icon
                this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                System.Net.IPAddress ipAddress;
                // check if input is valid ip address
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    // check if IP is ist ssame subnet as host IP
                    if (settings.HostNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                    {
                        if (settings.SubnetMaskIsSet && settings.IpRangeEndIsSet)
                        {
                            // check if IP range end is in same subnet
                            if (settings.DHCPNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.IpRangeEnd, settings.SubnetMask))
                            {
                                // set OK icon
                                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                                this.ipRangeStart_lblInfo.Text = "";
                                this.settings.IpRangeStartIsValid = true;
                                this.settings.IpRangeStart = ipAddress.ToString();
                                // calculate&set netmask
                                calculateSubnetId();
                            }
                            else
                            {
                                // set Error
                                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                                this.ipRangeStart_lblInfo.Text = "start and end address not in the same subnet";
                            }
                        }
                        else
                        {
                            // set OK icon
                            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                            this.ipRangeStart_lblInfo.Text = "";
                            this.settings.IpRangeStartIsValid = true;
                            this.settings.IpRangeStart = ipAddress.ToString();
                            calculateSubnetId();
                        }
                    }
                    else
                    {
                        // set Error
                        validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                        validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                        this.ipRangeStart_lblInfo.Text = "address is not in the same subnet as host ip";
                    }
                }
                else
                {
                    // set Error
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.ipRangeStart_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for IP range end
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateIpRangeEndInput(object sender, EventArgs e)
        {
            this.settings.IpRangeEndIsValid = false;
            try
            {
                this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    if (settings.HostNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                    {
                        if (settings.SubnetMaskIsSet && settings.IpRangeStartIsSet)
                        {
                            if (settings.DHCPNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.IpRangeStart, settings.SubnetMask))
                            {
                                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                                this.ipRangeEnd_lblInfo.Text = "";
                                this.settings.IpRangeEndIsValid = true;
                                this.settings.IpRangeEnd = ipAddress.ToString();
                                calculateSubnetId();
                            }
                            else
                            {
                                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                                this.ipRangeEnd_lblInfo.Text = "start and end address not in the same subnet";
                            }
                        }
                        else
                        {
                            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                            this.ipRangeEnd_lblInfo.Text = "";
                            this.settings.IpRangeEndIsValid = true;
                            this.settings.IpRangeEnd = ipAddress.ToString();
                        }
                    }
                    else
                    {
                        validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                        validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                        this.ipRangeEnd_lblInfo.Text = "address is not in the same subnet as host ip";
                    }
                    
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.ipRangeEnd_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for subnet address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateSubnetInput(object sender, EventArgs e)
        {
            this.settings.SubnetIsValid = false;
            try
            {
                this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.subnet_lblInfo.Text = "";
                    this.settings.SubnetIsValid = true;
                    this.settings.Subnet = ipAddress.ToString();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.subnet_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// calculates subnet address from IP address and subnet mask
        /// </summary>
        private void calculateSubnetId()
        {
            // automatically calculate and set subnet id
            if (this.settings.IpRangeStartIsSet && this.settings.SubnetMaskIsSet)
            {
                try
                {
                    this.settings.DHCPNetCalcTool.calculate(this.settings.IpRangeStart, this.settings.SubnetMask);
                    this.settings.Subnet = this.settings.DHCPNetCalcTool.NetworkId;
                    this.subnet_input.Text = this.settings.Subnet;
                    this.settings_validateSubnetInput(this.subnet_input, new EventArgs());
                }
                catch
                {
                    IOController.Log(this,"subnet calculation failed",IOController.Flag.error);
                }
            }
        }
        /// <summary>
        /// validates input for subnet mask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateSubnetMaskInput(object sender, EventArgs e)
        {
            this.settings.SubnetMaskIsValid = false;
            try
            {
                this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                System.Net.IPAddress ipAddress;
                // check if ip address is valid
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    if (settings.IpRangeStartIsSet && settings.IpRangeEndIsSet)
                    {
                        if (settings.DHCPNetCalcTool.CheckSameSubnet(settings.IpRangeEnd, settings.IpRangeStart, ipAddress.ToString()))
                        {
                            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                            this.subnetMask_lblInfo.Text = "";
                            this.settings.SubnetMaskIsValid = true;
                            this.settings.SubnetMask = ipAddress.ToString();
                            settings_validateIpRangeEndInput(ipRangeEnd_input, new EventArgs());
                            settings_validateIpRangeStartInput(ipRangeStart_input, new EventArgs());
                            calculateSubnetId();
                        }
                        else
                        {
                            validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                            this.subnetMask_lblInfo.Text = "start and/or end do not match subnet";
                        }
                    }
                    else
                    {
                        this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                        this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                        this.subnetMask_lblInfo.Text = "";
                        this.settings.SubnetMask = ipAddress.ToString();
                    }
                    
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.subnetMask_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for gateway address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateGatewayInput(object sender, EventArgs e)
        {
            this.settings.GatewayIsValid = false;
            try
            {
                if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
                {
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.gateway_lblInfo.Text = "";
                    return;
                }
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.gateway_lblInfo.Text = "";
                    this.settings.GatewayIsValid = true;
                    this.settings.Gateway = ipAddress.ToString();
                }
                else
                {
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.gateway_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for primary DNS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validatePrimaryDNSInput(object sender, EventArgs e)
        {
            this.settings.PrimaryDNSIsValid = false;
            try
            {
                if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
                {
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.primaryDNS_lblInfo.Text = "";
                    return;
                }
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.primaryDNS_lblInfo.Text = "";
                    this.settings.PrimaryDNSIsValid = true;
                    this.settings.PrimaryDNS = ipAddress.ToString();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.primaryDNS_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for secondary DNS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateSecondaryDNSInput(object sender, EventArgs e)
        {
            this.settings.SecondaryDNSIsValid = false;
            try
            {
                if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
                {
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.secondaryDNS_lblInfo.Text = "";
                    return;
                }
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.secondaryDNS_lblInfo.Text = "";
                    this.settings.SecondaryDNSIsValid = true;
                    this.settings.SecondaryDNS = ipAddress.ToString();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.secondaryDNS_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for default lease time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateDefaultLeaseInput(object sender, EventArgs e)
        {
            try
            {
                if (((NumericUpDown)sender).Value > 0)
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid Lease Time");
                    this.settings.DefaultLeaseTime = Convert.ToInt32(((NumericUpDown)sender).Value);
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// validates input for max lease time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_validateMaxLeaseInput(object sender, EventArgs e)
        {
            try
            {
                if (((NumericUpDown)sender).Value > 0)
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid Lease Time");
                    this.settings.DefaultLeaseTime = Convert.ToInt32(((NumericUpDown)sender).Value);
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// called when settings file is loaded, calls function to refresh GUI elements (because data binding does not work always in Linux/Mono)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        public void OnSettingsFileLoaded(object sender, EventArgs ea)
        {
            IOController.Log(this, "OnSettingsFileLoaded called, calling refreshSettings...", IOController.Flag.debug);
            if (this.settings_panelMain.InvokeRequired)
            {
                refreshSettingsCallback rc = new refreshSettingsCallback(refreshSettings);
                this.Invoke(rc);
            }
            else
            {
                refreshSettings();    
            }
        }
        private delegate void refreshSettingsCallback();
        /// <summary>
        /// refresh GUI elements of settings panel
        /// </summary>
        private void refreshSettings()
        {
            
            IOController.Log(this, "refreshSettings called, refreshSettings...", IOController.Flag.debug);
            try
            {
                this.ipRangeStart_input.Text = this.settings.IpRangeStart;
                this.ipRangeStart_input.Refresh();
                this.ipRangeEnd_input.Text = this.settings.IpRangeEnd;
                this.ipRangeEnd_input.Refresh();
                this.subnetMask_input.Text = this.settings.SubnetMask;
                this.subnetMask_input.Refresh();
                this.gateway_input.Text = this.settings.Gateway;
                this.gateway_input.Refresh();
                this.primaryDNS_input.Text = this.settings.PrimaryDNS;
                this.primaryDNS_input.Refresh();
                this.secondaryDNS_input.Text = this.settings.SecondaryDNS;
                this.secondaryDNS_input.Refresh();
                this.subnet_input.Text = this.settings.Subnet;
                this.subnet_input.Refresh();
                this.defaultLease_input.Value = Convert.ToDecimal(this.settings.DefaultLeaseTime);
                this.defaultLease_input.Refresh();
                this.maxLease_input.Value = Convert.ToDecimal(this.settings.MaxLeaseTime);
                this.maxLease_input.Refresh();
                IOController.Log(this, "refreshSettings finished, calling settingsTriggerValidation...", IOController.Flag.debug);
                settingsTriggerValidation();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
             
        }
        /// <summary>
        /// trigger validation for settings panel inputs
        /// </summary>
        private void settingsTriggerValidation()
        {
            IOController.Log(this, "settingsTriggerValidation called, triggering...", IOController.Flag.debug);
            // Control.Validate() is not implemented yet in Mono
            /*
            this.ipRangeStart_input.Validate();
            this.ipRangeEnd_input.Validate();
            this.subnetMask_input.Validate();
            this.gateway_input.Validate();
            this.primaryDNS_input.Validate();
            this.secondaryDNS_input.Validate();
            this.subnet_input.Validate();
            this.defaultLease_input.Validate();
            this.maxLease_input.Validate();
            this.ipRangeStart_input.Validate();
             * */
            // workaround by setting focus
            this.ipRangeStart_input.Focus();
            this.ipRangeEnd_input.Focus();
            this.subnetMask_input.Focus();
            this.gateway_input.Focus();
            this.primaryDNS_input.Focus();
            this.secondaryDNS_input.Focus();
            this.subnet_input.Focus();
            this.defaultLease_input.Focus();
            this.maxLease_input.Focus();
            this.ipRangeStart_input.Focus();
            IOController.Log(this, "settingsTriggerValidation validation triggered. ", IOController.Flag.debug);
            //refreshing hostinfo
            this.hostIP_tb.Text = this.settings.HostIP;
            this.hostIP_tb.Refresh();
            this.hostSubnetMask_tb.Text = this.settings.HostSubnetMask;
            this.hostSubnetMask_tb.Refresh();
            this.hostGateway_tb.Text = this.settings.HostGateway;
            this.hostGateway_tb.Refresh();
            IOController.Log(this, "settingsTriggerValidation Hostinfo refreshed.", IOController.Flag.debug);
        }
        #endregion SettingsPanel
        // region for the menu panel on the bottom
        #region MenuBottomPanel
        //################################################################################################# MenuBottomPanel
        /// <summary>
        /// shows save file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while saving file. See log for details.");
            }
        }
        /// <summary>
        /// saves settings file using backgroundworker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                bw = new BackgroundWorker();
                bw.DoWork += delegate { ioController.SaveSettingsFile(((SaveFileDialog)sender).FileName); System.Console.WriteLine("bg delegate"); };
                bw.WorkerReportsProgress = false;
                bw.RunWorkerCompleted += (bgsender, bge) =>
                {
                    if (bge.Error == null)
                    {
                        if (this.feedback_panel.InvokeRequired)
                        {
                            this.feedback_panel.Invoke((MethodInvoker)delegate
                            {
                                GiveUserFeedback("file saved", Color.Green);
                            });
                        }
                        else
                        {
                            GiveUserFeedback("file saved", Color.Green);
                        }
                    }
                    else
                    {
                        IOController.Log(this, bge.Error.Message, IOController.Flag.error);
                        MessageBox.Show("Error while saving file. See log for details.");
                    }
                    bw.Dispose();
                };
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while saving file. See log for details.");
            }
        }
        /// <summary>
        /// shows load file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBottom_btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while loading file. See log for details.");
            }
        }
        /// <summary>
        /// loads selected file using background worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                bw = new BackgroundWorker();
                bw.DoWork += delegate { ioController.LoadSettingsFile(((OpenFileDialog)sender).FileName); };
                bw.WorkerReportsProgress = false;
                bw.RunWorkerCompleted += (bgsender, bge) =>
                {
                    if (bge.Error == null)
                    {
                        if (this.feedback_panel.InvokeRequired)
                        {
                            this.feedback_panel.Invoke((MethodInvoker)delegate
                            {
                                GiveUserFeedback("file loaded", Color.Green);
                            });
                        }
                        else
                        {
                            GiveUserFeedback("file loaded", Color.Green);
                        }
                    }
                    else
                    {
                        IOController.Log(this, bge.Error.Message, IOController.Flag.error);
                        MessageBox.Show("Error while loading file. See log for details.");
                    }
                    bw.Dispose();
                };
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while opening file. See log for details.");
            }
        }
        /// <summary>
        /// applies settings to dhcpd.conf and restarts service (if running)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBottom_btnApply_Click(object sender, EventArgs e)
        {
            if (ioController.OsIsUnix)
            {
                if (this.settingsAreValid())
                {
                    IOController.Log(this, "settingsAreValid true", IOController.Flag.debug);
                    try
                    {
                        bw = new BackgroundWorker();
                        bw.DoWork += delegate
                        {
                            try
                            {
                                ioController.ApplySettingsToDHCPServer();
                            }
                            catch (Exception ex)
                            {
                                IOController.Log(this, ex.Message, IOController.Flag.error);
                                MessageBox.Show(ex.Message, "Settings could not be applied.");
                            }
                        };
                        bw.WorkerReportsProgress = false;
                        bw.RunWorkerCompleted += (bgsender, bge) =>
                        {
                            if (bge.Error == null)
                            {
                                if (this.feedback_panel.InvokeRequired)
                                {
                                    this.feedback_panel.Invoke((MethodInvoker)delegate
                                    {
                                        GiveUserFeedback("settings applied", Color.Green);
                                    });
                                }
                                else
                                {
                                    GiveUserFeedback("settings applied", Color.Green);
                                }
                            }
                            else
                            {
                                IOController.Log(this, bge.Error.Message, IOController.Flag.error);
                                MessageBox.Show("Error applying settings. See log for details.");
                            }
                            bw.Dispose();
                        };
                        bw.RunWorkerAsync();
                    }
                    catch (System.Exception ex)
                    {
                        IOController.Log(this, ex.Message, IOController.Flag.error);
                        MessageBox.Show("Exception while applying settings. See log for details.");
                    }
                }//end if (this.settingsAreValid())
                else
                {
                    IOController.Log(this, "settingsAreValid false", IOController.Flag.debug);
                    GiveUserFeedback("Please make sure all settings are valid before applying!", Color.Red);
                }
            }
            else
            {
                MessageBox.Show("This feature requires a Linux environment.");
            }
        }
        /// <summary>
        /// load settings from dhcpd.conf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBottom_loadFromDhcp_Click(object sender, EventArgs e)
        {
            if (ioController.OsIsUnix)
            {
                try
                {
                    bw = new BackgroundWorker();
                    bw.DoWork += delegate { this.ioController.LoadSettingsFile("/etc/dhcp/dhcpd.conf"); };
                    bw.WorkerReportsProgress = false;
                    bw.RunWorkerCompleted += (bgsender, bge) =>
                    {
                        if (bge.Error == null)
                        {
                            if (this.feedback_panel.InvokeRequired)
                            {
                                this.feedback_panel.Invoke((MethodInvoker)delegate
                                {
                                    GiveUserFeedback("settings loaded", Color.Green);
                                });
                            }
                            else
                            {
                                GiveUserFeedback("settings loaded", Color.Green);
                            }
                        }
                        else
                        {
                            IOController.Log(this, bge.Error.Message, IOController.Flag.error);
                            MessageBox.Show("Error while loading file. See log for details.");
                        }
                        bw.Dispose();
                    };
                    bw.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                    MessageBox.Show("The file /etc/dhcp/dhcpd.conf could not be loaded. See log for details.");
                }
            }
            else
            {
                MessageBox.Show("This feature requires a Linux environment.");
            }
        }
        /// <summary>
        /// user feedback if asynchronous operation was succussful
        /// </summary>
        /// <param name="text">text to display</param>
        /// <param name="colour">color for background</param>
        public void GiveUserFeedback(string text, Color colour)
        {
            feedback_panel.BackColor = colour;
            feedback_panel.Visible = true;
            feedback_panel.BringToFront();
            feedback_lbl.Text = text;
            feedback_lbl.Refresh();
            feedback_panel.Refresh();
            Timer t = new Timer();
            t.Interval = 1800;
            t.Tick += (object sender, EventArgs e) =>
            {
                feedback_panel.Visible = false;
                t.Stop();
            };
            t.Start();
        }
        /// <summary>
        /// checks if settings are valid
        /// </summary>
        /// <returns>true if all settings are valid, false if one setting is invalid</returns>
        private bool settingsAreValid()
        {
            // trigger validation
            settingsTriggerValidation();
            IOController.Log(this, "checking if settings are valid", IOController.Flag.debug);
            // check if setings are valid
            if (!this.settings.IpRangeStartIsValid)
            {
                return false;
            }
            if (!this.settings.IpRangeEndIsValid)
            {
                return false;
            }
            if (!this.settings.SubnetIsValid)
            {
                return false;
            }
            if (!this.settings.SubnetMaskIsValid)
            {
                return false;
            }
            if (this.settings.GatewayIsSet)
            {
                if (!this.settings.GatewayIsValid)
                {
                    return false;
                }
            }
            if (this.settings.PrimaryDNSIsSet)
            {
                if (!this.settings.PrimaryDNSIsValid)
                {
                    return false;
                }
            }
            if (this.settings.SecondaryDNSIsSet)
            {
                if (!this.settings.SecondaryDNSIsValid)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion MenuBottomPanel
        // region for the static leases panel
        #region StaticLeases
        //################################################################################################# StaticLeases
        /// <summary>
        /// calls function to update static leases listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StaticLeases_ListView_update(object sender, PropertyChangedEventArgs e)
        {
            if (this.staticLeases_listview.InvokeRequired)
            {
                updateStaticLeasesListViewCallback uc = new updateStaticLeasesListViewCallback(updateStaticLeasesListView);
                this.Invoke(uc);
            }
            else
            {
                updateStaticLeasesListView();
            }
        }
        private delegate void updateStaticLeasesListViewCallback();
        /// <summary>
        /// updates static leases listview, use StaticLeases_ListView_update for threadsafe call
        /// </summary>
        private void updateStaticLeasesListView()
        {
            try
            {
                IOController.Log(this, "updateStaticLeasesListView", IOController.Flag.debug);
                this.staticLeases_listview.Items.Clear();
                foreach (KeyValuePair<string, StaticLease> entry in this.settings.GetStaticLeases())
                {
                    StaticLease staticLease = entry.Value;
                    ListViewItem lvi = this.staticLeases_listview.Items.Add("" + staticLease.ID);
                    lvi.SubItems.Add(staticLease.DeviceName);
                    lvi.SubItems.Add(staticLease.MACAddress);
                    lvi.SubItems.Add(staticLease.IPAddress);
                    lvi.SubItems.Add("edit");
                    lvi.SubItems.Add("delete");
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, "updateStaticLeasesListView FAILED: " + ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// calls staticLeasesListViewAdd threadsafe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staticLeases_input_btn_add_Click(object sender, EventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewAddCallback cb = new staticLeasesListViewAddCallback(staticLeasesListViewAdd);
                this.Invoke(cb);
            }
            else
            {
                staticLeasesListViewAdd();
            }
        }
        private delegate void staticLeasesListViewAddCallback();
        /// <summary>
        /// adds static lease (StaticLease object) to the list view
        /// </summary>
        private void staticLeasesListViewAdd()
        {
            this.staticLeasesTriggerValidation();
            if (staticLeasesMacInputIsValid && staticLeasesIpInputIsValid)
            {
                try
                {
                    IOController.Log(this, "staticLeasesListViewAdd called", IOController.Flag.debug);
                    StaticLease staticLease = new StaticLease();
                    staticLease.IPAddress = staticLeases_input_tb_ip.Text;
                    staticLease.MACAddress = staticLeases_input_tb_mac.Text;
                    staticLease.DeviceName = staticLeases_input_tb_name.Text;
                    staticLease.ID = (this.settings.GetStaticLeases().Count + 1).ToString();
                    this.settings.AddStaticLease(staticLease);
                    staticLeases_input_tb_name.Clear();
                    staticLeases_input_tb_mac.Clear();
                    staticLeases_input_tb_ip.Clear();
                    this.staticLeases_input_lbl.BackColor = Color.Transparent;
                    this.staticLeases_input_lbl.Text = "Add a new static lease:";
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                }
            }
            else
            {
                this.staticLeases_input_lbl.BackColor = Color.OrangeRed;
                this.staticLeases_input_lbl.Text = "Invalid Input! Please make sure to enter a valid MAC and IP address!";
            }
        }
        /// <summary>
        /// id (text of first field - MAC address) of list view item
        /// </summary>
        private string listviewitemid;
        /// <summary>
        /// zero based index of list view item
        /// </summary>
        private int listviewindex;
        /// <summary>
        /// true if editing (or false if adding new)
        /// </summary>
        private bool staticLeaseEditing = false;
        /// <summary>
        /// calls function to edit item threadsafe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewEditClick(object sender, ListViewColumnMouseEventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewEditCallback cb = new staticLeasesListViewEditCallback(staticLeasesListViewEdit);
                this.Invoke(cb, e);
            }
            else
            {
                staticLeasesListViewEdit(e);
            }
            
        }
        private delegate void staticLeasesListViewEditCallback(ListViewColumnMouseEventArgs e);
        /// <summary>
        /// edit a listview item, loads values into text fields and changes buttons
        /// </summary>
        /// <param name="e"></param>
        private void staticLeasesListViewEdit(ListViewColumnMouseEventArgs e)
        {
            try
            {
                staticLeaseEditing = true;
                listviewitemid = e.Item.Text;
                listviewindex = e.Item.Index;
                staticLeases_input_tb_name.Text = e.Item.SubItems[1].Text;
                staticLeases_input_tb_mac.Text = e.Item.SubItems[2].Text;
                System.Net.IPAddress ip;
                if (System.Net.IPAddress.TryParse(e.Item.SubItems[3].Text, out ip))
                {
                    staticLeases_input_tb_ip.IPAddress = ip;
                }
                this.staticLeases_listview.Items.RemoveAt(e.Item.Index);
                this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_add_Click;
                this.staticLeases_input_btn_add.Click += staticLeases_input_btn_saveEdit_Click;
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// calls function to save changes threadsafe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staticLeases_input_btn_saveEdit_Click(object sender, EventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewSaveEditCallback cb = new staticLeasesListViewSaveEditCallback(staticLeasesListViewSaveEdit);
                this.Invoke(cb);
            }
            else
            {
                staticLeasesListViewSaveEdit();
            }
        }
        private delegate void staticLeasesListViewSaveEditCallback();
        /// <summary>
        /// saves changes to an edited item
        /// </summary>
        private void staticLeasesListViewSaveEdit()
        {
            staticLeasesTriggerValidation();
            if (staticLeasesMacInputIsValid && staticLeasesIpInputIsValid)
            {
                try
                {
                    StaticLease staticLease = new StaticLease();
                    staticLease.IPAddress = staticLeases_input_tb_ip.Text;
                    staticLease.MACAddress = staticLeases_input_tb_mac.Text;
                    staticLease.DeviceName = staticLeases_input_tb_name.Text;
                    staticLease.ID = listviewitemid;
                    this.settings.AddStaticLease(staticLease);
                    staticLeases_input_tb_name.Clear();
                    staticLeases_input_tb_mac.Clear();
                    staticLeases_input_tb_ip.Clear();
                    this.staticLeases_input_btn_add.Click += staticLeases_input_btn_add_Click;
                    this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_saveEdit_Click;
                    listviewitemid = null;
                    staticLeaseEditing = false;
                    this.staticLeases_input_lbl.BackColor = Color.Transparent;
                    this.staticLeases_input_lbl.Text = "Add a new static lease:";
                }
                catch (Exception ex)
                {
                    IOController.Log(this, ex.Message, IOController.Flag.error);
                }
            }
            else
            {
                this.staticLeases_input_lbl.BackColor = Color.OrangeRed;
                this.staticLeases_input_lbl.Text = "Invalid Input! Please make sure to enter a valid MAC and IP address!";
            }
        }
        /// <summary>
        /// calls function to delete item threadsafe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewDeleteClick(object sender, ListViewColumnMouseEventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewDeleteCallback cb = new staticLeasesListViewDeleteCallback(staticLeasesListViewDelete);
                this.Invoke(cb, e);
            }
            else
            {
                staticLeasesListViewDelete(e);
            }
        }
        private delegate void staticLeasesListViewDeleteCallback(ListViewColumnMouseEventArgs e);
        /// <summary>
        /// removes the listview item and corresponding static lease from settings 
        /// </summary>
        /// <param name="e"></param>
        private void staticLeasesListViewDelete(ListViewColumnMouseEventArgs e)
        {
            try
            {
                IOController.Log(this, "ListViewDeleteClick Item.Index: " + e.Item.Index, IOController.Flag.debug);
                this.settings.RemoveStaticLease(e.Item.SubItems[2].Text);
                if (staticLeaseEditing)
                {
                    staticLeases_input_tb_name.Clear();
                    staticLeases_input_tb_mac.Clear();
                    staticLeases_input_tb_ip.Clear();
                    this.staticLeases_input_btn_add.Click += staticLeases_input_btn_add_Click;
                    this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_saveEdit_Click;
                    listviewitemid = null;
                    staticLeaseEditing = false;
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private bool staticLeasesIpInputIsValid;
        /// <summary>
        /// validation for static lease ip address input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staticLeases_validateIpInput(object sender, EventArgs e)
        {
            staticLeasesIpInputIsValid = false;
            try
            {
                System.Net.IPAddress ipAddress;
                if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.staticLeases_input_lbl.BackColor = Color.Transparent;
                    this.staticLeases_input_lbl.Text = "Add a new static lease:";
                    ((IPAddressControlLib.IPAddressControl)sender).Parent.BackColor = Color.White;
                }
                else
                {
                    if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                    {
                        if (this.settings.DHCPNetCalcTool.CheckSameSubnet(ipAddress.ToString(), this.settings.IpRangeStart, this.settings.SubnetMask))
                        {
                            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                            staticLeasesIpInputIsValid = true;
                            ((IPAddressControlLib.IPAddressControl)sender).Parent.BackColor = Color.White;
                        }
                        else
                        {
                            validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                            validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "IP address is not in DHCP subnet");
                            staticLeasesIpInputIsValid = false;
                            ((IPAddressControlLib.IPAddressControl)sender).Parent.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                        validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                        staticLeasesIpInputIsValid = false;
                        ((IPAddressControlLib.IPAddressControl)sender).Parent.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private bool staticLeasesMacInputIsValid;
        /// <summary>
        /// validation for static lease mac address input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staticLeases_validateMacInput(object sender, EventArgs e)
        {
            staticLeasesMacInputIsValid = false;
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    this.validationStatus_error.SetError((TextBox)sender, "");
                    this.validationStatus_ok.SetError((TextBox)sender, "");
                    this.staticLeases_input_lbl.BackColor = Color.Transparent;
                    this.staticLeases_input_lbl.Text = "Add a new static lease:";
                    ((TextBox)sender).Parent.BackColor = Color.White;
                }
                else
                {
                    string input = ((TextBox)sender).Text;
                    input = input.ToUpper();
                    input = input.Replace(':', '-');
                    System.Net.NetworkInformation.PhysicalAddress macAddress = null;
                    IOController.Log(this, "start", IOController.Flag.debug);
                    try
                    {
                        macAddress = System.Net.NetworkInformation.PhysicalAddress.Parse(input);
                        IOController.Log(this, "parsemac " + macAddress.ToString(), IOController.Flag.debug);
                    }
                    catch (FormatException ex)
                    {
                        IOController.Log(this, "parsemac failed " + ex.Message, IOController.Flag.error);
                        macAddress = null;
                    }
                    if (macAddress != null)
                    {
                        this.validationStatus_error.SetError((TextBox)sender, "");
                        this.validationStatus_ok.SetError((TextBox)sender, "valid MAC address");
                        staticLeasesMacInputIsValid = true;
                        ((TextBox)sender).Parent.BackColor = Color.White;
                    }
                    else
                    {
                        ((TextBox)sender).Parent.BackColor = Color.Red;
                        validationStatus_ok.SetError((TextBox)sender, "");
                        validationStatus_error.SetError((TextBox)sender, "please enter valid MAC address");
                        staticLeasesMacInputIsValid = false;
                    }
                }
            }
            catch (Exception ex)
            {
                validationStatus_ok.SetError((TextBox)sender, "");
                validationStatus_error.SetError((TextBox)sender, "please enter valid MAC address");
                staticLeasesMacInputIsValid = false;
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// triggers validation of static lease inputs
        /// </summary>
        private void staticLeasesTriggerValidation()
        {
            this.staticLeases_input_tb_ip.Focus();
            this.staticLeases_input_tb_mac.Focus();
            this.staticLeases_input_tb_name.Focus();
        }
        #endregion StaticLeases
        // region for the client leases panel
        #region DhcpdLeases
        //################################################################################################# DhcpdLeases
        /// <summary>
        /// calls function to update list view threadsafe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSettingsDhcpdLeasesChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.clients_dhcpdLeases_listView.InvokeRequired)
            {
                updateDhcpdLeasesListViewCallback uc = new updateDhcpdLeasesListViewCallback(updateDhcpdLeasesListView);
                this.Invoke(uc);
            }
            else
            {
                updateDhcpdLeasesListView();
            }
        }
        private delegate void updateDhcpdLeasesListViewCallback();
        /// <summary>
        /// updates the list view for client leases
        /// </summary>
        private void updateDhcpdLeasesListView()
        {
            IOController.Log(this, "called", IOController.Flag.debug);
            try
            {
                clients_dhcpdLeases_listView.Items.Clear();
                foreach (KeyValuePair<string, DhcpdLease> entry in this.settings.DhcpdLeases)
                {
                    DhcpdLease dhcpdLease = entry.Value;
                    if (dhcpdLease.LeaseState == "active")
                    {
                        ListViewItem item = new ListViewItem(dhcpdLease.MACAddress);
                        item.SubItems.Add(dhcpdLease.DeviceName);
                        item.SubItems.Add(dhcpdLease.IPAddress);
                        item.SubItems.Add(dhcpdLease.LeaseStart);
                        item.SubItems.Add(dhcpdLease.LeaseEnd);
                        item.SubItems.Add("add static lease");
                        clients_dhcpdLeases_listView.Items.Add(item);
                    }
                }
                clients_dhcpdLeases_listView.Refresh();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// transfers the data of the lease to static lease view and changes view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClientsListviewAddStaticClick(object sender, ListViewColumnMouseEventArgs e)
        {
            try
            {
                DhcpdLease dhcpLease = this.settings.DhcpdLeases[e.Item.Text];
                this.staticLeases_input_tb_ip.Text = dhcpLease.IPAddress;
                this.staticLeases_input_tb_mac.Text = dhcpLease.MACAddress;
                this.staticLeases_input_tb_name.Text = dhcpLease.DeviceName;
                switchView(views.staticLeases);
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        #endregion DhcpdLeases
    }
}
