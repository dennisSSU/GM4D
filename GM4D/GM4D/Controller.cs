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
    class Controller
    {
        private MainWindow mainWindow;
        private Settings settings;
        private IOController ioController;
        private BackgroundWorker bw;
        private LoadingWindow loadingWindow;

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
                this.ioController.GetHostInfo();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetHostInfo " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(40);
            try
            {
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetDHCPServerInstallStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(50);
            try
            {
                this.ioController.GetDHCPServerStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetDHCPServerStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(60);
            try
            {
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
                this.ioController.InitiateDhcpdLeasesFileWatcher();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "InitiateDhcpdLeasesFileWatcher " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(90);
            try
            {
                this.ioController.ReadDhcpdLeasesFile("/var/lib/dhcp/dhcpd.leases");
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
            
        }
    }
}
