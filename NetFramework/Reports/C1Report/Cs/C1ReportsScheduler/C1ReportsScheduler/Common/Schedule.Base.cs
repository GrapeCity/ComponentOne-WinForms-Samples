using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace C1ReportsScheduler
{
    [XmlInclude(typeof(ScheduleServer))]
    public class ScheduleBase : INotifyPropertyChanged
    {
        // public only because of XmlSerializer:
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ScheduleProxy
        {
            public bool Enabled;
            public bool Paused;
            public ScheduleFrequency Frequency;
            public DateTime StartTime;
            public int RecurEveryDays;
            public int RecurEveryWeeks;
            public ScheduleRepeatUnit RepeatUnit;
            public int RepeatFrequency;
            public bool Repeat;
            public List<DayOfWeek> DaysOfWeek;
            public List<int> Months;
            public List<int> Days;
            public DateTime NextDueTime;
            public DateTime LastRunTime;
        }

        #region fields
        private readonly object _syncRoot = new object();
        protected TaskBase _owner = null;
        protected bool _enabled = false;
        protected bool _paused = false;
        protected DateTime _lastRunTime = DateTime.MinValue;

        protected ScheduleFrequency _frequency = ScheduleFrequency.Once;
        protected DateTime _startDateTime = DateTime.Now;
        /// <summary>
        /// For weekly freq, contains days of week to run the task.
        /// </summary>
        protected List<DayOfWeek> _daysOfWeek = new List<DayOfWeek>(7);
        /// <summary>
        /// For monthly freq, contains 1-based month numbers (1 for Jan etc).
        /// </summary>
        protected List<int> _months = new List<int>(12);
        protected List<int> _days = new List<int>(); // "32" means "last day"
        protected int _recurEveryDays = 1; // used for daily freq
        protected int _recurEveryWeeks = 1; // used for weekly freq
        protected ScheduleRepeatUnit _repeatUnit = ScheduleRepeatUnit.Seconds;
        protected int _repeatFrequency = 1;
        protected bool _repeat = false;
        #endregion fields

        #region constants
        private static readonly List<string> c_monthNames = new List<string>(
            new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        );
        // TimeSpan of -1 millisecond disables Timer:
        protected static readonly TimeSpan c_TimeSpanNever = new TimeSpan(0, 0, 0, 0, -1);
        internal static readonly DateTime c_DateTimeNever = DateTime.MaxValue;
        private const int c_LastDay = 32;
        #endregion

        #region construction/destruction
        /// <summary>
        /// This ctor is for XML serialization only.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal ScheduleBase()
        {
        }

        public ScheduleBase(TaskBase owner)
        {
            SetOwner(owner);
        }

        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        /// <summary>
        /// MUST be called after de-serializing (i.e. after parameterless ctor was used).
        /// </summary>
        /// <param name="owner"></param>
        internal virtual void SetOwner(TaskBase owner)
        {
            System.Diagnostics.Debug.Assert(owner != null && _owner == null);
            _owner = owner;
        }

        /// <summary>
        /// Should be called prior to app exiting. Stops/disposes timer without
        /// setting any properties on itself or setting owner task's state.
        /// Schedule becomes unusable after this call.
        /// </summary>
        public virtual void Exit()
        {
            throw new Util.MustOverrideException();
        }
        #endregion construction/destruction

        #region private methods and properties
        private long RepeatTicks
        {
            get
            {
                if (!Repeat)
                    return 0;
                switch (RepeatUnit)
                {
                    case ScheduleRepeatUnit.Seconds:
                        return TimeSpan.TicksPerSecond * RepeatFrequency;
                    case ScheduleRepeatUnit.Minutes:
                        return TimeSpan.TicksPerMinute * RepeatFrequency;
                    case ScheduleRepeatUnit.Hours:
                        return TimeSpan.TicksPerHour * RepeatFrequency;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        return 0;
                }
            }
        }
        #endregion private methods and properties

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        /*
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        */

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler;
            lock (SyncRoot)
                handler = PropertyChanged;

            if (handler != null)
            {
                ISynchronizeInvoke invoker = null;
                lock (SyncRoot)
                {
                    if (_owner != null)
                        invoker = _owner.Invoker;
                }
                if (invoker != null && invoker.InvokeRequired)
                    invoker.BeginInvoke(handler, new object[] { this, new PropertyChangedEventArgs(propertyName) });
                else
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region public stored properties
        [DefaultValue(false)]
        public virtual bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [DefaultValue(false)]
        public virtual bool Paused
        {
            get { return _paused; }
            set { _paused = value; }
        }

        [DefaultValue(ScheduleFrequency.Once)]
        public virtual ScheduleFrequency Frequency
        {
            get { return _frequency; }
            set
            {
                if (value != _frequency)
                {
                    lock (SyncRoot)
                        _frequency = value;
                    OnPropertyChanged("Frequency");
                }
            }
        }

        public virtual DateTime StartTime
        {
            get { return _startDateTime; }
            set
            {
                if (value != _startDateTime)
                {
                    lock (SyncRoot)
                        _startDateTime = value;
                    OnPropertyChanged("StartTime");
                }
            }
        }

        [DefaultValue(1)]
        public virtual int RecurEveryDays
        {
            get { return _recurEveryDays; }
            set
            {
                if (value != _recurEveryDays)
                {
                    if (value < 1)
                        throw new ArgumentOutOfRangeException("RecurEveryDays", value, "Value must be greater than zero.");
                    lock (SyncRoot)
                        _recurEveryDays = value;
                    OnPropertyChanged("RecurEveryDays");
                }
            }
        }

        [DefaultValue(1)]
        public virtual int RecurEveryWeeks
        {
            get { return _recurEveryWeeks; }
            set
            {
                if (value != _recurEveryWeeks)
                {
                    if (value < 1)
                        throw new ArgumentOutOfRangeException("RecurEveryWeeks", value, "Value must be greater than zero.");
                    lock (SyncRoot)
                        _recurEveryWeeks = value;
                    OnPropertyChanged("RecurEveryWeeks");
                }
            }
        }

        [DefaultValue(ScheduleRepeatUnit.Seconds)]
        public virtual ScheduleRepeatUnit RepeatUnit
        {
            get { return _repeatUnit; }
            set
            {
                if (value != _repeatUnit)
                {
                    lock (SyncRoot)
                        _repeatUnit = value;
                    OnPropertyChanged("RepeatUnit");
                }
            }
        }

        [DefaultValue(1)]
        public virtual int RepeatFrequency
        {
            get { return _repeatFrequency; }
            set
            {
                if (value != _repeatFrequency)
                {
                    if (value < 1)
                        throw new ArgumentOutOfRangeException("RepeatFrequency", value, "Value must be greater than zero.");
                    lock (SyncRoot)
                        _repeatFrequency = value;
                    OnPropertyChanged("RepeatFrequency");
                }
            }
        }

        [DefaultValue(false)]
        public virtual bool Repeat
        {
            get { return _repeat; }
            set
            {
                if (value != _repeat)
                {
                    lock (SyncRoot)
                        _repeat = value;
                    OnPropertyChanged("Repeat");
                }
            }
        }

        #region days of week
        [DefaultValue(false)]
        public bool Sunday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Sunday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Monday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Monday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Tuesday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Tuesday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Wednesday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Wednesday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Thursday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Thursday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Friday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Friday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Saturday
        {
            get { return _daysOfWeek.Contains(DayOfWeek.Saturday); }
            set { _setDayOfWeek(MethodBase.GetCurrentMethod(), value); }
        }

        protected virtual void _setDayOfWeek(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_"));
            string dayName = caller.Name.Substring(4);
            DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayName);
            bool changed;
            lock (SyncRoot)
            {
                changed = _daysOfWeek.Contains(dayOfWeek) != on;
                if (changed)
                {
                    if (on)
                        _daysOfWeek.Add(dayOfWeek);
                    else
                        _daysOfWeek.Remove(dayOfWeek);
                }
            }
            if (changed)
                OnPropertyChanged(dayName);
        }
        #endregion days of week

        #region months
        [DefaultValue(false)]
        public bool January
        {
            get { return _months.Contains(1); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool February
        {
            get { return _months.Contains(2); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool March
        {
            get { return _months.Contains(3); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool April
        {
            get { return _months.Contains(4); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool May
        {
            get { return _months.Contains(5); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool June
        {
            get { return _months.Contains(6); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool July
        {
            get { return _months.Contains(7); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool August
        {
            get { return _months.Contains(8); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool September
        {
            get { return _months.Contains(9); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool October
        {
            get { return _months.Contains(10); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool November
        {
            get { return _months.Contains(11); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool December
        {
            get { return _months.Contains(12); }
            set { _setMonth(MethodBase.GetCurrentMethod(), value); }
        }

        protected virtual void _setMonth(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_"));
            string monthName = caller.Name.Substring(4);
            int month = c_monthNames.IndexOf(monthName) + 1;
            bool changed;
            lock (SyncRoot)
            {
                changed = _months.Contains(month) != on;
                if (changed)
                {
                    if (on)
                        _months.Add(month);
                    else
                        _months.Remove(month);
                }
            }
            if (changed)
                OnPropertyChanged(monthName);
        }
        #endregion months

        #region days
        [DefaultValue(false)]
        public bool Day1
        {
            get { return _days.Contains(1); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day2
        {
            get { return _days.Contains(2); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day3
        {
            get { return _days.Contains(3); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day4
        {
            get { return _days.Contains(4); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day5
        {
            get { return _days.Contains(5); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day6
        {
            get { return _days.Contains(6); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day7
        {
            get { return _days.Contains(7); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day8
        {
            get { return _days.Contains(8); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day9
        {
            get { return _days.Contains(9); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day10
        {
            get { return _days.Contains(10); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day11
        {
            get { return _days.Contains(11); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day12
        {
            get { return _days.Contains(12); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day13
        {
            get { return _days.Contains(13); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day14
        {
            get { return _days.Contains(14); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day15
        {
            get { return _days.Contains(15); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day16
        {
            get { return _days.Contains(16); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day17
        {
            get { return _days.Contains(17); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day18
        {
            get { return _days.Contains(18); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day19
        {
            get { return _days.Contains(19); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day20
        {
            get { return _days.Contains(20); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day21
        {
            get { return _days.Contains(21); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day22
        {
            get { return _days.Contains(22); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day23
        {
            get { return _days.Contains(23); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day24
        {
            get { return _days.Contains(24); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day25
        {
            get { return _days.Contains(25); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day26
        {
            get { return _days.Contains(26); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day27
        {
            get { return _days.Contains(27); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day28
        {
            get { return _days.Contains(28); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day29
        {
            get { return _days.Contains(29); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day30
        {
            get { return _days.Contains(30); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool Day31
        {
            get { return _days.Contains(31); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        [DefaultValue(false)]
        public bool DayLast
        {
            get { return _days.Contains(c_LastDay); }
            set { _setDay(MethodBase.GetCurrentMethod(), value); }
        }

        protected virtual void _setDay(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_Day"));
            string daystr = caller.Name.Substring(7);
            int day;
            if (daystr == "Last")
                day = c_LastDay;
            else
                day = int.Parse(daystr);
            bool changed;
            lock (SyncRoot)
            {
                changed = _days.Contains(day) != on;
                if (changed)
                {
                    if (on)
                        _days.Add(day);
                    else
                        _days.Remove(day);
                }
            }
            if (changed)
                OnPropertyChanged(caller.Name.Substring(4));
        }
        #endregion days
        #endregion public stored properties

        #region public non-stored properties
        /// <summary>
        /// Gets the <c>DateTime</c> when the next run will be due.
        /// If the next run will never be due, gets <c>DateTime.MaxValue</c>.
        /// In some cases may return a value that is a bit in the past already.
        /// </summary>
        public DateTime NextDueTime
        {
            get
            {
                DateTime now = DateTime.Now; // use same now for consistency
                long ticksSinceStart = now.Ticks - StartTime.Ticks;
                long divTicks;
                long repeatsSinceStart;
                switch (Frequency)
                {
                    case ScheduleFrequency.Once:
                        if (ticksSinceStart <= 0)
                            return StartTime;
                        if (!Repeat)
                            return c_DateTimeNever;
                        repeatsSinceStart = Math.DivRem(ticksSinceStart, RepeatTicks, out divTicks);
                        if (divTicks > 0)
                            ++repeatsSinceStart;
                        return new DateTime(StartTime.Ticks + RepeatTicks * repeatsSinceStart);
                    case ScheduleFrequency.Daily:
                        if (ticksSinceStart <= 0)
                            return StartTime;
                        repeatsSinceStart = Math.DivRem(ticksSinceStart, TimeSpan.TicksPerDay * RecurEveryDays, out divTicks);
                        if (divTicks > 0)
                            ++repeatsSinceStart;
                        return new DateTime(StartTime.Ticks + TimeSpan.TicksPerDay * RecurEveryDays * repeatsSinceStart);
                    case ScheduleFrequency.Weekly:
                        if (_daysOfWeek.Count == 0)
                            return c_DateTimeNever;
                        // number of periods (week*RecurEveryWeeks) since task started (0 for tasks that haven't started yet):
                        long periodsSinceStart;
                        if (ticksSinceStart <= 0)
                            periodsSinceStart = 0;
                        else
                            periodsSinceStart = ticksSinceStart / (TimeSpan.TicksPerDay * 7 * RecurEveryWeeks);
                        // start of current period:
                        long currPeriodStart = StartTime.Ticks + TimeSpan.TicksPerDay * 7 * RecurEveryWeeks * periodsSinceStart;
                        // loop thru 7 days from start of current period, loooking for a matching day.
                        // if a match is already in the past, add the period to it and save in case it is the only one.
                        DateTime td = new DateTime(currPeriodStart);
                        DateTime nextPeriod = c_DateTimeNever;
                        for (int i = 0; i < 7; ++i)
                        {
                            if (_daysOfWeek.Contains(td.DayOfWeek))
                            {
                                // combine matched date and start time:
                                DateTime ret = new DateTime(td.Year, td.Month, td.Day, StartTime.Hour, StartTime.Minute, StartTime.Second);
                                // if the result is in the future, we're done:
                                if (ret.Ticks >= now.Ticks)
                                    return ret;
                                // otherwise, add period and use if no match in the current period is found:
                                if (nextPeriod == c_DateTimeNever)
                                    nextPeriod = ret.AddDays(7 * RecurEveryWeeks);
                            }
                            td = td.AddDays(1);
                        }
                        return nextPeriod;
                    case ScheduleFrequency.Monthly:
                        if (_months.Count == 0 || _days.Count == 0)
                            return c_DateTimeNever;
                        // avoid extra calls to _days.Contains:
                        bool onLastDay = _days.Contains(c_LastDay);
                        // earliest possible start time:
                        DateTime startDate = now.Ticks > StartTime.Ticks ? now : StartTime;
                        // loop for a year + 1 month from earliest start date, looking for a match
                        // (the extra month accounts for passed part of the current month):
                        for (int i = 0; i < 13; ++i)
                        {
                            DateTime testMonth = new DateTime(startDate.Year, startDate.Month, i == 0 ? startDate.Day : 1,
                                StartTime.Hour, StartTime.Minute, StartTime.Second);
                            testMonth = testMonth.AddMonths(i);
                            if (_months.Contains(testMonth.Month))
                            {
                                for (DateTime testDate = testMonth; testDate.Month == testMonth.Month; testDate = testDate.AddDays(1))
                                {
                                    if (testDate.Ticks >= startDate.Ticks)
                                    {
                                        int testDay = testDate.Day;
                                        if (_days.Contains(testDay))
                                            return testDate;
                                        if (onLastDay && testDay >= 28 && testDate.AddDays(1).Month != testDate.Month)
                                            return testDate;
                                    }
                                }
                            }
                        }
                        return c_DateTimeNever;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        return c_DateTimeNever;
                }
            }
        }

        public bool FrequencyOnce
        {
            get { return Frequency == ScheduleFrequency.Once; }
        }

        public bool FrequencyDaily
        {
            get { return Frequency == ScheduleFrequency.Daily; }
        }

        public bool FrequencyWeekly
        {
            get { return Frequency == ScheduleFrequency.Weekly; }
        }

        public bool FrequencyMonthly
        {
            get { return Frequency == ScheduleFrequency.Monthly; }
        }

        [XmlIgnore]
        public virtual DateTime LastRunTime
        {
            get { return _lastRunTime; }
            protected set { throw new Util.MustOverrideException(); }
        }
        #endregion public properties
    }
}
