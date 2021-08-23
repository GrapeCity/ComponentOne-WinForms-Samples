using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C1ReportsSchedulerService
{
    public static class Constants
    {
        /// <summary>
        /// The C1Reports scheduler service name.
        /// </summary>
        public const string Name = "C1Reports_Scheduler";
        /// <summary>
        /// The C1Reports scheduler service description.
        /// </summary>
        public const string Description =
            "Provides the ability to generate C1Report and C1PrintDocument objects on schedule. " +
            "Generated documents can be exported to any of the supported formats or printed. " +
            "The list of scheduled reports and documents can be configured using the C1ReportsScheduler frontend application. " +
            "The same application can be used to edit that list while the service is running or paused.";
        /// <summary>
        /// Gets the service registry key root.
        /// All RegKey_* values should be saved under that root.
        /// </summary>
        public const string RegKey_Root = @"System\CurrentControlSet\Services\" + Name;
        /// <summary>
        /// WcfEndpointBaseAddress registry key name.
        /// </summary>
        public const string RegKey_WcfEndpointBaseAddress = "WcfEndpointBaseAddress";
        /// <summary>
        /// WcfEndpointRelAddress registry key name.
        /// </summary>
        public const string RegKey_WcfEndpointRelAddress = "WcfEndpointRelAddress";
        /// <summary>
        /// Configuration file path key name.
        /// </summary>
        public const string RegKey_C1rsconfFilePath = "C1rsconfFilePath";
        /// <summary>
        /// Key name of flag indicating whether to log scheduled tasks.
        /// </summary>
        public const string RegKey_LogTasks = "LogTasks";
        /// <summary>
        /// Key name of flag indicating whether to log scheduled tasks' actions.
        /// </summary>
        public const string RegKey_LogActions = "LogActions";
        /// <summary>
        /// Key name of flag indicating whether to log scheduled "external program" type tasks' program output.
        /// </summary>
        public const string RegKey_LogProgramOutput = "LogProgramOutput";
        /// <summary>
        /// Key name of flag indicating whether to enable service metadata publishing.
        /// </summary>
        public const string RegKey_EnableMex = "EnableMex";
        /// <summary>
        /// Event log source name (should be created by the installation).
        /// </summary>
        public const string EventLogSourceName = Name;
        /// <summary>
        /// Event log name (can be Application, System or custom name).
        /// </summary>
        public const string EventLogName = "Application";
        /// <summary>
        /// Metadata exchange address (used for net.tcp binding only).
        /// </summary>
        public const string WcfEndpointMexAddress = "C1ReportsSchedulerServiceMex";
    }

    // todo: think of good defaults
    public static class Defaults
    {
#if wcf_http
        public const string WcfEndpointBaseAddress = "http://localhost:8012/ComponentOneLLC";
#else
        public const string WcfEndpointBaseAddress = "net.tcp://localhost:8012/ComponentOneLLC";
#endif
        public const string WcfEndpointRelAddress = "C1ReportsSchedulerService";
        public const string C1rsconfFileName = "ServiceTaskList";
        public const string C1rsconfFileExt = ".c1rsconf";
        public const bool LogTasks = false;
        public const bool LogActions = false;
        public const bool LogProgramOutput = true;
        public const bool EnableMex = false;
    }

    // Custom commands for the C1ReportsSchedulerService.
    // (allowed values are 128..256)
    public enum CustomCommands
    {
        /// <summary>
        /// Resets the .c1rsconf file name to whatever is stored in C1rsconfFilePath
        /// registry entry (allows to start service with a temp config file name).
        /// </summary>
        ResetC1rsconfFileToRegistry = 128,
    }
}
