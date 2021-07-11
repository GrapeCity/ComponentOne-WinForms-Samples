using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C1ReportsScheduler
{
    public delegate void ProgressCallback(int from, int to, int current);

    public enum TaskListStore
    {
        AppConfigFile,
        XmlFile,
    }

    public enum ReportKind
    {
        XmlReport,
        C1dDocument,
        ImportedReport,
        Program,
    }

    public enum ActionKind
    {
        Export,
        Print,
        Run,
    }

    public enum CheckedStatus
    {
        Unknown,
        Invalid,
        CheckedOk,
        Working,
    }

    public enum TaskState
    {
        Ready,
        Busy,
        Scheduled,
        Paused,
    }

    public enum ScheduleFrequency
    {
        Once,
        Daily,
        Weekly,
        Monthly,
    }

    public enum ScheduleRepeatUnit
    {
        Seconds,
        Minutes,
        Hours,
    }
}
