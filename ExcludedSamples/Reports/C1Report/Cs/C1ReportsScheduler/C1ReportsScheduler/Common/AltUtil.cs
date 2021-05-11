using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Text;

namespace C1ReportsScheduler
{
    /// <summary>
    /// Contains utility methods that act differently depending on whether they are in the UI app or in the service.
    /// </summary>
    public static class AltUtil
    {
#if SERVICE
        private static bool _logTasks = C1ReportsSchedulerService.Defaults.LogTasks;
        private static bool _logActions = C1ReportsSchedulerService.Defaults.LogActions;
        private static bool _logProgramOutput = C1ReportsSchedulerService.Defaults.LogProgramOutput;

        public static bool LogTasks
        {
            get { return _logTasks; }
            set { _logTasks = value; }
        }

        public static bool LogActions
        {
            get { return _logActions; }
            set { _logActions = value; }
        }

        public static bool LogProgramOutput
        {
            get { return _logProgramOutput; }
            set { _logProgramOutput = value; }
        }
#else
        public static bool LogTasks
        {
            get { return false; }
            set { }
        }

        public static bool LogActions
        {
            get { return false; }
            set { }
        }

        public static bool LogProgramOutput
        {
            get { return false; }
            set { }
        }
#endif

        public static void ShowError(string message)
        {
#if SERVICE
            C1ReportsSchedulerService.Logger.Log("ERROR", message);
#else
            WinUtil.ShowError(message);
#endif
        }

        public static void ShowWarning(string message)
        {
#if SERVICE
            C1ReportsSchedulerService.Logger.Log("WARNING", message);
#else
            WinUtil.ShowWarning(message);
#endif
        }

        /// <summary>
        /// Logs a purely informative verbose message.
        /// In UI context, does NOT show a modal dialog (currently does nothing at all).
        /// </summary>
        /// <param name="message"></param>
        public static void LogMessage(string message)
        {
#if SERVICE
            C1ReportsSchedulerService.Logger.Log("MESSAGE", message);
#else
            // todo: log?
#endif
        }
    }
}
