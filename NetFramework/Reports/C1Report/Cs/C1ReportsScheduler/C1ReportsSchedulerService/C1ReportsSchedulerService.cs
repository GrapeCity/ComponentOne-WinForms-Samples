using System;
using System.IO;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Description;
using Microsoft.Win32;
using C1ReportsScheduler;

namespace C1ReportsSchedulerService
{
    public partial class C1ReportsSchedulerService : ServiceBase
    {
        private TaskListHolderServer _tasks = new TaskListHolderServer();
        private SERVICE_STATUS _serviceStatus;
        private ServiceHost _serviceHost = null;
        private string _c1rsconfPath = null;

        #region Win32
        [StructLayout(LayoutKind.Sequential)]
        public struct SERVICE_STATUS
        {
            public uint serviceType;
            public uint currentState;
            public uint controlsAccepted;
            public uint win32ExitCode;
            public uint serviceSpecificExitCode;
            public uint checkPoint;
            public uint waitHint;
        }

        public class SERVICE_STATE
        {
            public const uint
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007;
        }

        [DllImport("ADVAPI32.DLL", EntryPoint = "SetServiceStatus")]
        private static extern bool SetServiceStatus(
                        IntPtr hServiceStatus,
                        ref SERVICE_STATUS lpServiceStatus
                        );

        #endregion Win32

        public C1ReportsSchedulerService()
        {
            CanStop = true;
            CanPauseAndContinue = true;
            CanHandleSessionChangeEvent = true;
            CanShutdown = true;
            ServiceName = Constants.Name;
            Log("C1ReportsSchedulerService", "Service instance created.");
        }

        private void StartWcf()
        {
            System.Diagnostics.Debug.Assert(_serviceHost == null);
            Log("StartWcf", "Starting WCF service...");
            try
            {
                string wcfEndpointBaseAddress = null;
                string wcfEndpointRelAddress = null;
                bool wcfEnableMex = false;
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(Constants.RegKey_Root))
                {
                    wcfEndpointBaseAddress = key.GetValue(Constants.RegKey_WcfEndpointBaseAddress) as string;
                    wcfEndpointRelAddress = key.GetValue(Constants.RegKey_WcfEndpointRelAddress) as string;
                    wcfEnableMex = (int)key.GetValue(Constants.RegKey_EnableMex) != 0;
                }

                Uri baseAddress = new Uri(wcfEndpointBaseAddress);

                _serviceHost = new ServiceHost(new ReportsSchedulerWcf(), baseAddress);

                // Add a service endpoint:
                Log("StartWcf", string.Format("Adding service endpoint, base addr {0}, rel addr {1}", wcfEndpointBaseAddress, wcfEndpointRelAddress));

#if wcf_http
                _serviceHost.AddServiceEndpoint(typeof(IC1ReportsSchedulerWcf), new WSDualHttpBinding(), wcfEndpointRelAddress);

                if (wcfEnableMex)
                {
                    // enable metadata exchange:
                    Log("StartWcf", "Enabling metadata exchange...");
                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    _serviceHost.Description.Behaviors.Add(smb);
                }
#else
                _serviceHost.AddServiceEndpoint(typeof(IC1ReportsSchedulerWcf), new NetTcpBinding(), wcfEndpointRelAddress);

                if (wcfEnableMex)
                {
                    // enable metadata exchange:
                    Log("StartWcf", "Enabling metadata exchange...");
                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    _serviceHost.Description.Behaviors.Add(smb);
                    _serviceHost.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexTcpBinding(),
                        Constants.WcfEndpointMexAddress);
                }
#endif

                if (ReportsSchedulerWcf.Singleton != null)
                    ReportsSchedulerWcf.Singleton.Tasks = _tasks;

                // Step 5 of the hosting procedure: Start (and then stop) the service.
                Log("StartWcf", "Opening service...");
                _serviceHost.Open();
                Log("StartWcf", "WCF service started.");
            }
            catch (Exception ex)
            {
                Log("StartWcf", string.Format("ERROR: {0}", ex.Message));
                _serviceHost = null;
            }
        }

        private void StopWcf()
        {
            System.Diagnostics.Debug.Assert(_serviceHost != null);
            try
            {
                // Close the ServiceHostBase to shutdown the service.
                Log("StopWcf", "Stopping WCF service...");
                _serviceHost.Close();
                _serviceHost = null;
                Log("StopWcf", "WCF service stopped.");
            }
            catch (Exception ex)
            {
                Log("StopWcf", string.Format("ERROR: {0}", ex.Message));
                _serviceHost = null;
            }
        }

        // Start the service.
        protected override void OnStart(string[] args)
        {
            Log("OnStart", "Starting...");

            if (ReportsSchedulerWcf.Singleton != null)
                ReportsSchedulerWcf.Singleton.Paused = false;

            // set service status to start pending:
            IntPtr handle = this.ServiceHandle;
            _serviceStatus.currentState = SERVICE_STATE.SERVICE_START_PENDING;
            SetServiceStatus(handle, ref _serviceStatus);

            // Get values for arguments passed in from the Services control panel or
            // by the ServiceController class Start(string[]) method.
            Log("OnStart", string.Format("Invoked with {0} command line arguments.", args.Length));
            for (int i = 0; i < args.Length; ++i)
                Log("OnStart", string.Format("Command line argument {0}: \"{1}\"", i, args[i]));

            // Get arguments from the ImagePath string value for the service's registry 
            // key (HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\C1Reports_Scheduler).
            string[] imagePathArgs = Environment.GetCommandLineArgs();
            Log("OnStart", string.Format("Invoked with {0} ImagePath arguments.", imagePathArgs.Length));
            for (int i = 0; i < imagePathArgs.Length; ++i)
                Log("OnStart", string.Format("ImagePath argument {0}: \"{1}\"", i, imagePathArgs[i]));

            // Get log flags from registry:
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(Constants.RegKey_Root))
                {
                    AltUtil.LogTasks = (int)key.GetValue(Constants.RegKey_LogTasks) != 0;
                    AltUtil.LogActions = (int)key.GetValue(Constants.RegKey_LogActions) != 0;
                    AltUtil.LogProgramOutput = (int)key.GetValue(Constants.RegKey_LogProgramOutput) != 0;
                }
            }
            catch (Exception ex)
            {
                Log("OnStart", string.Format("ERROR: Could not get log values from registry: {0}", ex.Message));
            }
            Log("OnStart", string.Format("Logging scheduled tasks is {0}.", AltUtil.LogTasks ? "ON" : "OFF"));
            Log("OnStart", string.Format("Logging scheduled tasks' actions is {0}.", AltUtil.LogActions ? "ON" : "OFF"));
            Log("OnStart", string.Format("Logging scheduled \"external program\" type tasks' program output is {0}.", AltUtil.LogProgramOutput ? "ON" : "OFF"));

            // reset .c1rsconf path:
            _c1rsconfPath = null;

            // get .c1rsconf file path from registry:
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(Constants.RegKey_Root))
                _c1rsconfPath = key.GetValue(Constants.RegKey_C1rsconfFilePath) as string;

            // check whether .c1rsconf file was specified in ImagePath,
            // ImagePath overrides registry value:
            if (imagePathArgs.Length >= 2)
                _c1rsconfPath = imagePathArgs[1];

            // check whether .c1rsconf file was specified on command line,
            // command line overrides all:
            if (args.Length >= 1)
                _c1rsconfPath = args[0];

            // if c1rsconf file exists, load tasks from it:
            if (File.Exists(_c1rsconfPath))
            {
                // loading may take time... try to calc it?
                this.RequestAdditionalTime(4000);

                try
                {
                    Log("OnStart", string.Format("Loading task list from: {0}", _c1rsconfPath));
                    _tasks = (TaskListHolderServer)TaskListHolder.Load(_c1rsconfPath);
                }
                catch (Exception ex)
                {
                    Log("OnStart", string.Format("Error loading task list: {0}", ex.Message));
                    _tasks = new TaskListHolderServer();
                }
            }

            // log loaded tasks:
            foreach (C1ReportsScheduler.TaskBase task in _tasks.Tasks)
            {
                // in service, ignore Paused prop - tasks are paused together when service is paused,
                // resumed accordingly
                task.Schedule.Paused = false;
                Log("TASK", string.Format("STARTED: Kind={0}, Name={1}, File={2}.", task.ReportKind, task.ReportName, task.FileName));
            }

            StartWcf();

            // set service status to running:
            _serviceStatus.currentState = SERVICE_STATE.SERVICE_RUNNING;
            SetServiceStatus(handle, ref _serviceStatus);

            Log("OnStart", "Started.");
        }

        // Stop this service.
        protected override void OnStop()
        {
            Log("OnStop", "Stopping...");

            this.RequestAdditionalTime(4000);

            StopWcf();

            // gracefully shut down all schedules:
            foreach (TaskBase t in _tasks.Tasks)
                t.Schedule.Exit();

            // save task list to _c1rsconfPath:
            if (!string.IsNullOrEmpty(_c1rsconfPath))
            {
                try
                {
                    Log("OnStop", string.Format("Saving task list to {0}...", _c1rsconfPath));
                    _tasks.Save(_c1rsconfPath);
                    Log("OnStop", string.Format("Task list saved to {0}.", _c1rsconfPath));
                }
                catch (Exception ex)
                {
                    Log("OnStop", string.Format("Could not save task list to {0}, error: {1}", _c1rsconfPath, ex.Message));
                }
            }

            Log("OnStop", "Stopped.");

            // Indicate a successful exit.
            this.ExitCode = 0;
        }

        // Pause the service.
        protected override void OnPause()
        {
            Log("OnPause", "Pausing all tasks...");

            if (ReportsSchedulerWcf.Singleton != null)
                ReportsSchedulerWcf.Singleton.Paused = true;

            foreach (TaskBase t in _tasks.Tasks)
                if (t.Schedule.Enabled)
                    t.Schedule.Paused = true;

            Log("OnPause", "Paused.");
        }

        // Resume a paused service.
        protected override void OnContinue()
        {
            Log("OnContinue", "Resuming all tasks...");

            if (ReportsSchedulerWcf.Singleton != null)
                ReportsSchedulerWcf.Singleton.Paused = false;

            foreach (TaskBase t in _tasks.Tasks)
                if (t.Schedule.Enabled)
                    t.Schedule.Paused = false;

            Log("OnContinue", "Resumed.");
        }

        protected override void OnShutdown()
        {
            Log("OnShutdown", "");
        }

        protected override void OnCustomCommand(int command)
        {
            Log("OnCustomCommand", "Custom command received: " + command.ToString());

            switch (command)
            {
                case (int)CustomCommands.ResetC1rsconfFileToRegistry:
                    // get .c1rsconf file path from registry:
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(Constants.RegKey_Root))
                        _c1rsconfPath = key.GetValue(Constants.RegKey_C1rsconfFilePath) as string;
                    Log("OnCustomCommand", string.Format("Reset C1rsconfPath to {0}", _c1rsconfPath));
                    break;
                default:
                    Log("OnCustomCommand", "UNKNOWN COMMAND");
                    break;
            }
        }

        static internal void Log(string source, string message)
        {
            Logger.Log(source, message);
        }
    }
}
