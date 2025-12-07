using System;
using System.Windows.Forms;

using C1.Win.Schedule;

namespace C1CommandBasedApp
{
    /// <summary>
    /// Allow change view options of C1Schedule.
    /// </summary>
    public class C1ScheduleOptions
    {
        private C1Schedule _schedule;

        public C1ScheduleOptions(
            C1Schedule schedule)
        {
            _schedule = schedule;
        }

        public C1Schedule Schedule
        {
            get { return _schedule; }
        }

        public ScheduleViewEnum ViewType
        {
            get { return _schedule.ViewType; }
            set { _schedule.ViewType = value; }
        }

        public bool EnableGrouping
        {
            get { return !string.IsNullOrEmpty(_schedule.GroupBy); }
            set { _schedule.GroupBy = value ? "Category" : string.Empty; }
        }

        public bool Office2003WeekView
        {
            get { return _schedule.WeekViewStyle == WeekViewStyleEnum.Office2003; }
            set { _schedule.WeekViewStyle = value ? WeekViewStyleEnum.Office2003 : WeekViewStyleEnum.Office2007; }
        }
    }
}
