using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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

        public void Run()
        {
            bw.ProgressChanged += loadingWindow.OnProgressChange;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
            System.Windows.Forms.Application.Run(loadingWindow);
            mainWindow.Shown += mainWindow_Shown;
            System.Windows.Forms.Application.Run(mainWindow);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.loadingWindow.Close();
            this.loadingWindow.Dispose();
            bw.ProgressChanged -= loadingWindow.OnProgressChange;
            bw.RunWorkerCompleted -= bw_RunWorkerCompleted;
        }

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
                IOController.Log(this, "InitShell " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(50);
            if (settings.Interfaces.Count > 0) settings.selectInterface(0);
            try
            {
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "InitShell " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(60);
            try
            {
                this.ioController.GetDHCPServerStatus();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "GetDHCPServerStatus " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(70);
            try
            {
                this.ioController.InitiateDhcpdLeasesFileWatcher();
            }
            catch (Exception exc)
            {
                IOController.Log(this, "InitiateDhcpdLeasesFileWatcher " + exc.Message, IOController.Flag.error);
            }
            worker.ReportProgress(80);
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
        private void mainWindow_Shown(object sender, EventArgs e)
        {
            if (settings.IsDHCPServerRunning)
            {
                bw = new BackgroundWorker();
                bw.DoWork += bw_loadDHCPDconf;
                bw.RunWorkerCompleted += bw_loadDHCPDconfCompleted;
                bw.WorkerReportsProgress = false;
                bw.RunWorkerAsync();
            }
        }

        private void bw_loadDHCPDconfCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw.DoWork -= bw_loadDHCPDconf;
            bw.RunWorkerCompleted -= bw_loadDHCPDconfCompleted;
        }

        void bw_loadDHCPDconf(object sender, DoWorkEventArgs e)
        {
            this.ioController.LoadSettingsFile("/etc/dhcp/dhcpd.conf");
        }



    }
}
