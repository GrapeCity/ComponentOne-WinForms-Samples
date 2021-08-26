using System.Diagnostics;

namespace C1ReportsSchedulerService
{
    public static class Logger
    {
        static public void Log(string source, string message)
        {
            // EventLog.WriteEntry("", "", EventLogEntryType.Warning);
            EventLog.WriteEntry(Constants.EventLogSourceName, string.Format("{0}: {1}", source, message));
        }
    }
}
