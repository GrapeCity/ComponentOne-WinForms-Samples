using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;
using System.ServiceModel;
using Microsoft.Win32;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {
        private string _wcfEndpointAddress = string.Empty;
        //private EndpointAddress _wcfEpAddress = null;
        //private C1ReportsSchedulerWcfClient _wcfClient = null;

        // "http://localhost:8002/C1ReportsSchedulerService/ReportsSchedulerWcf/ReportsSchedulerWcfService"
        public string WcfEndpointAddress
        {
            get { return _wcfEndpointAddress; }
            set
            {
                _wcfEndpointAddress = value;
            }
        }

        private void WcfConnect(ProgressDialog prg)
        {
            // set up callback to track tasks loading progress:
            var progressCbk = new ProgressCallback(delegate(int from, int to, int current)
                {
                    prg.SetProgress(20 + (current * 80) / (to - from), string.Format("Loading task {0} of {1}...", current + 1, to - from));
                });

            prg.SetProgress(10, "Connecting to service...");
            WcfDisconnect();

            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(C1ReportsSchedulerService.Constants.RegKey_Root))
                {
                    string baseAddr = key.GetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointBaseAddress) as string;
                    string relAddr = key.GetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointRelAddress) as string;
                    // todo: check how base and rel addresses are combined:
#if wcf_http
                    WcfEndpointAddress = string.Format("{0}/{1}", baseAddr, relAddr);
#else
                    WcfEndpointAddress = string.Format("{0}/{1}", baseAddr, relAddr);
#endif
                }
                LoadTasks(new TaskListHolderClient(this, WcfEndpointAddress, progressCbk));
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(string.Format("Could not get service endpoint address from registry: {0}", ex.Message));
            }
        }

        private void WcfDisconnect()
        {
            TaskListHolderClient tasksHolder = _tasksHolder as TaskListHolderClient;
            if (tasksHolder != null)
            {
                tasksHolder.WcfDisconnect();
            }
        }

        private bool CanConnectToService(bool showErrors)
        {
            bool serviceInstalled;
            return CanConnectToService(showErrors, out serviceInstalled);
        }

        private bool CanConnectToService(bool showErrors, out bool serviceInstalled)
        {
            serviceInstalled = false;
            using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
            {
                try
                {
                    if (sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.Paused)
                    {
                        serviceInstalled = true;
                        return true;
                    }
                    else
                    {
                        if (showErrors)
                            WinUtil.ShowError(string.Format("Cannot connect to service {0}: it is not running.", C1ReportsSchedulerService.Constants.Name));
                        serviceInstalled = true;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    if (showErrors)
                        WinUtil.ShowError(string.Format("Could not access service {0}: {1}", C1ReportsSchedulerService.Constants.Name, ex.Message));
                    return false;
                }
                finally
                {
                    sc.Close();
                }
            }
        }

        private void ConnectToService(ProgressDialog prg)
        {
            System.Diagnostics.Debug.Assert(CanConnectToService(false));
            try
            {
                WcfConnect(prg);
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(string.Format("Cannot connect to service {0}: {1}.", C1ReportsSchedulerService.Constants.Name, ex.Message));
            }
        }

        private void ServiceStart(ProgressDialog progress, bool unconditionalTransfer)
        {
            using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
            {
                try
                {
                    progress.SetProgress(5, "Checking service status...");
                    sc.WaitForStatus(ServiceControllerStatus.Stopped, c_timeout);
                    ServiceControllerStatus status = sc.Status;
                    if (status != ServiceControllerStatus.Stopped)
                    {
                        WinUtil.ShowError("Service is running or paused!");
                        return;
                    }
                    string currentTaskListFile = null;
                    bool transfer = unconditionalTransfer;
                    if (!transfer && _tasksHolder.Tasks.Count > 0)
                        transfer = WinUtil.AskQuestion("Transfer current task list to service?", false);

                    if (transfer)
                    {
                        progress.SetProgress(10, "Stopping running schedules...");
                        _tasksHolder.StopSchedules();

                        progress.SetProgress(20, "Preparing current task list for transfer...");
                        currentTaskListFile = Path.GetTempFileName();
                        _tasksHolder.Save(currentTaskListFile);
                    }
                    this.Clear();

                    progress.SetProgress(30, string.Format("Starting {0} service...", C1ReportsSchedulerService.Constants.Name));

                    if (string.IsNullOrEmpty(currentTaskListFile))
                        sc.Start();
                    else
                        sc.Start(new string[] { currentTaskListFile });

                    WaitForStatus(sc, ServiceControllerStatus.Running, progress);

                    sc.ExecuteCommand((int)C1ReportsSchedulerService.CustomCommands.ResetC1rsconfFileToRegistry);
                    progress.SetProgress(90, "Connecting to service...");
                    ConnectToService(progress);

                    progress.SetProgress(90, "Service successfully started.");

                    if (!string.IsNullOrEmpty(currentTaskListFile))
                        File.Delete(currentTaskListFile);
                }
                catch (Exception ex)
                {
                    WinUtil.ShowError(string.Format("Error: {0}", ex.Message));
                }
                finally
                {
                    sc.Close();
                }
            }
        }

        private void WaitForStatus(ServiceController sc, ServiceControllerStatus desiredStatus, ProgressDialog prg)
        {
            DateTime basta = DateTime.Now + c_timeout;
            const int delta = 1;
            while (sc.Status != desiredStatus && DateTime.Now < basta)
            {
                prg.Complete = Math.Min(90, prg.Complete + delta); // never get to 100%
                Application.DoEvents();
                System.Threading.Thread.Sleep(250);
                sc.Refresh();
            }
            if (sc.Status != desiredStatus)
                throw new System.ServiceProcess.TimeoutException();
        }

        private void ServiceCall(ServiceControllerStatus desiredStatus, string actionName)
        {
            using (ProgressDialog prg = new ProgressDialog())
                ServiceCall(desiredStatus, actionName, prg);
        }

        private void ServiceCall(ServiceControllerStatus desiredStatus, string actionName, ProgressDialog prg)
        {
            prg.SetProgress(10, string.Format("{0} {1} service...", actionName, C1ReportsSchedulerService.Constants.Name));
            using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
            {
                try
                {
                    if (sc.Status == desiredStatus)
                        return;
                    switch (desiredStatus)
                    {
                        case ServiceControllerStatus.Paused:
                            sc.Pause();
                            break;
                        case ServiceControllerStatus.Running:
                            if (sc.Status == ServiceControllerStatus.Paused)
                                sc.Continue();
                            else
                                sc.Start();
                            break;
                        case ServiceControllerStatus.Stopped:
                            sc.Stop();
                            break;
                        default:
                            System.Diagnostics.Debug.Assert(false);
                            break;
                    }
                    WaitForStatus(sc, desiredStatus, prg);
                }
                catch (Exception ex)
                {
                    WinUtil.ShowError(string.Format("Error: {0}", ex.Message));
                }
                finally
                {
                    sc.Close();
                }
            }
        }
    }
}
