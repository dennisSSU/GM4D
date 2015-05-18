using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
/* 
 * Filename: Controller.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: main controller, initializes the application
 */
namespace GM4D
{
    /// <summary>
    ///  main controller, initializes the application
    /// </summary>
    class Controller
    {
        /// <summary>
        /// main application window
        /// </summary>
        private MainWindow mainWindow;
        /// <summary>
        /// loading indicator
        /// </summary>
        private LoadingWindow loadingWindow;
        /// <summary>
        /// data storage object
        /// </summary>
        private Settings settings;
        /// <summary>
        /// controller for IO operations
        /// </summary>
        private IOController ioController;
        /// <summary>
        /// backgroundworker user for getting host information during application start
        /// </summary>
        private BackgroundWorker bw;
        /// <summary>
        /// creates a new controller instance
        /// </summary>
        public Controller()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(init);
            this.bw.WorkerReportsProgress = true;
            this.settings = new Settings();
            this.ioController = new IOController(this.settings);
            this.mainWindow = new MainWindow(this.settings, this.ioController);
            this.loadingWindow = new LoadingWindow();
        }
        /// <summary>
        /// function to start the application
        /// starts the backgroundworker with the init function and show the loading window
        /// when the loading windows is closed the main window is shown
        /// </summary>
        public void Run()
        {
            bw.ProgressChanged += loadingWindow.OnProgressChange;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
            System.Windows.Forms.Application.Run(loadingWindow);
            mainWindow.Shown += mainWindow_Shown;
            System.Windows.Forms.Application.Run(mainWindow);
        }
        /// <summary>
        /// this function is called when the BackgroundWorker completes the init function. It closes the loading window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.loadingWindow.Close();
            this.loadingWindow.Dispose();
            bw.ProgressChanged -= loadingWindow.OnProgressChange;
            bw.RunWorkerCompleted -= bw_RunWorkerCompleted;
        }
        /// <summary>
        /// Run all neccassary functions to gather information at the start of the application and reports progress.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void init(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(1);
            try
            {
                // initialize a bash instance in the IOController
                this.ioController.InitShell();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "InitShell " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(20);
            try
            {
                if (!ioController.GetGksudoInstallStatus())
                {
                    // check if gksu is installed
                    IOController.Log(this, "gksu not installed ", IOController.Flag.error);
                }
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetGksudoInstallStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(30);
            try
            {
                // get information about the host computer
                this.ioController.GetHostInfo();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetHostInfo " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(40);
            try
            {
                // get status of isc-dhcp-server installation
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetDHCPServerInstallStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(50);
            try
            {
                // get running status of isc-dhcp-server
                this.ioController.GetDHCPServerStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetDHCPServerStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(60);
            try
            {
                // get the inface selected in the /etc/default/isc-dhcp-server file
                this.ioController.GetSelectedInterfaceFromEtcDefault();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetSelectedInterfaceFromEtcDeafult " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(70);
            try
            {
                if (settings.IsDHCPServerRunning)
                {
                    // load the setting from the /etc/dhcp/dhcpd/conf file if dhcp server is running
                    this.ioController.LoadSettingsFile("/etc/dhcp/dhcpd.conf");
                }
            }
            catch (Exception exc)
            {
                IOController.Log(this, "LoadSettingsFile " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(80);
            try
            {
                // create the filewatcher to track changes in the /var/lib/dhcp/dhcpd. leases file
                this.ioController.InitiateDhcpdLeasesFileWatcher();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "InitiateDhcpdLeasesFileWatcher " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(90);
            try
            {
                if (settings.IsDHCPServerRunning)
                {
                    // read in existing leases if dhcp server is running
                    this.ioController.ReadDhcpdLeasesFile("/var/lib/dhcp/dhcpd.leases");
                }
            }
            catch (Exception exc)
            {
                IOController.Log(this, "ReadDhcpdLeasesFile " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(100);
            System.Threading.Thread.Sleep(800);
        }
        /// <summary>
        /// is called when the main window is shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWindow_Shown(object sender, EventArgs e)
        {
            // do stuff after the main window is visible
        }
    }
}
