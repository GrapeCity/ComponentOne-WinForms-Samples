using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using C1ReportsSchedulerService;

namespace C1ReportsScheduler
{
    public class ScheduleServer : ScheduleBase
    {
        #region fields
        /// <summary>
        /// Timer is used as follows:
        /// DueTime is set to when the schedule is due to run next time,
        /// or to max valid timer due value. Period is set to infinite.
        /// When the timer callback fires, it resets the timer to the next due time.
        /// </summary>
        private Timer _timer = null;
        /// <summary>
        /// Skip is set to true if the next due time is futher in the future than
        /// the max timer due time value (2^32-2), to skip execution.
        /// </summary>
        private bool _skip = false;
        #endregion fields

        #region construction/destruction
        /// <summary>
        /// This ctor is for XML serialization only.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ScheduleServer()
        {
        }

        public ScheduleServer(TaskBase owner)
            : base(owner)
        {
        }

        internal ScheduleServer(ScheduleBase source)
        {
            lock (SyncRoot)
                Util.CopyNonXmlIgnoreProperties(this, source, typeof(ScheduleBase));
        }

        internal static ScheduleServer FromBase(ScheduleBase source)
        {
            return new ScheduleServer(source);
        }

        internal static ScheduleBase ToBase(ScheduleBase source)
        {
            ScheduleBase ret = new ScheduleBase();
            Util.CopyNonXmlIgnoreProperties(ret, source, typeof(ScheduleBase));
            return ret;
        }

        /// <summary>
        /// MUST be called after de-serializing (i.e. after parameterless ctor was used).
        /// </summary>
        /// <param name="owner"></param>
        internal override void SetOwner(TaskBase owner)
        {
            System.Diagnostics.Debug.Assert(_timer == null);
            base.SetOwner(owner);
            _timer = new Timer(new TimerCallback(TimerCbk));
            if (Enabled)
                Start(); // will account for paused as well
        }

        /// <summary>
        /// Should be called prior to app exiting. Stops/disposes timer without
        /// setting any properties on itself or setting owner task's state.
        /// Schedule becomes unusable after this call.
        /// </summary>
        public override void Exit()
        {
            lock (SyncRoot)
            {
                if (_timer != null)
                {
                    _timer.Change(Timeout.Infinite, Timeout.Infinite);
                    _timer.Dispose();
                    _timer = null;
                }
            }
        }

        internal string ToProxyXml()
        {
            lock (SyncRoot)
                return Util.ToXml(ToProxy(), typeof(ScheduleProxy));
        }

        private ScheduleProxy ToProxy()
        {
            ScheduleProxy proxy = new ScheduleProxy();
            proxy.Enabled = this.Enabled;
            proxy.Paused = this.Paused;
            proxy.Frequency = this.Frequency;
            proxy.StartTime = this.StartTime;
            proxy.RecurEveryDays = this.RecurEveryDays;
            proxy.RecurEveryWeeks = this.RecurEveryWeeks;
            proxy.RepeatUnit = this.RepeatUnit;
            proxy.RepeatFrequency = this.RepeatFrequency;
            proxy.Repeat = this.Repeat;
            proxy.DaysOfWeek = this._daysOfWeek;
            proxy.Months = this._months;
            proxy.Days = this._days;
            proxy.NextDueTime = this.NextDueTime;
            proxy.LastRunTime = this.LastRunTime;
            return proxy;
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != "NextDueTime")
                base.OnPropertyChanged("NextDueTime");

            if (_owner == null)
                return;

            TaskListServer tasks = _owner.Owner as TaskListServer;
            if (tasks == null)
                return;

            IC1ReportsSchedulerWcfCallback callback = tasks.WcfCallback;
            if (callback != null)
            {
                try
                {
                    string xml = ToProxyXml();
                    callback.SchedulePropertyChanged(_owner.Id, xml, propertyName);
                    callback.SchedulePropertyChanged(_owner.Id, xml, "NextDueTime");
                }
                catch (Exception ex)
                {
                    IC1ReportsSchedulerWcf wcfService = tasks.WcfService;
                    if (wcfService != null)
                        wcfService.Disconnect(ex.Message);
                }
            }
        }
        #endregion construction/destruction

        #region private methods and properties
        private void Start()
        {
            System.Diagnostics.Debug.Assert(Enabled);
            lock (SyncRoot)
            {
                if (_owner == null)
                    return; // deserializing... will get called again from SetOwner().

                _owner.State = Paused ? TaskState.Paused : TaskState.Scheduled;
                RenewTimer();
            }
        }

        private void Stop()
        {
            System.Diagnostics.Debug.Assert(_timer != null);
            lock (SyncRoot)
            {
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                if (_owner.State != TaskState.Busy)
                    _owner.State = TaskState.Ready;
            }
        }

        private void Pause()
        {
            System.Diagnostics.Debug.Assert(Enabled && Paused);
            lock (SyncRoot)
            {
                if (_owner != null)
                    _owner.State = TaskState.Paused;
            }
        }

        private void Resume()
        {
            System.Diagnostics.Debug.Assert(Enabled && !Paused);
            lock (SyncRoot)
            {
                _owner.State = TaskState.Scheduled;
            }
        }

        private void TimerCbk(object state)
        {
            if (_timer == null)
                return; // schedule has been exited

            TaskBase owner = _owner;

            if (owner.Owner == null || !owner.Owner.Contains(owner))
            {
                RenewTimer();
                return;
            }

            switch (owner.State)
            {
                case TaskState.Ready:
                    System.Diagnostics.Debug.Assert(false);
                    break;
                case TaskState.Busy:
                    try
                    {
                        owner.Message = "Could not run task on schedule: task is already running.";
                    }
                    catch (Exception ex)
                    {
                        AltUtil.ShowError(ex.Message);
                    }
                    RenewTimer();
                    break;
                case TaskState.Scheduled:
                    if (!_skip)
                    {
                        LastRunTime = DateTime.Now;
                        try
                        {
                            owner.ScheduledRun(this);
                        }
                        catch (Exception ex)
                        {
                            AltUtil.ShowError(ex.Message);
                        }
                    }
                    RenewTimer();
                    break;
                case TaskState.Paused:
                    RenewTimer();
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
        }

        private void RenewTimer()
        {
            lock (SyncRoot)
            {
                if (!_enabled || _timer == null)
                    return;

                DateTime now = DateTime.Now;
                DateTime dueTime = this.NextDueTime;
                if (dueTime == c_DateTimeNever)
                {
                    _timer.Change(Timeout.Infinite, Timeout.Infinite);
                    if (_owner != null)
                        _owner.Message = "Specified schedule will never execute.";
                }
                else
                {
                    // Timer's dueTime cannot be more than 4294967294 (2^32-2) ms away.
                    // In fact, there are also glitches if 4294967294 is specified (callback fires
                    // more than once initially), hence we are being conservative and use max int:
                    const long maxDueTimeMs = int.MaxValue; // 4294967294;
                    long nextDueTimeMs = (long)Math.Round(dueTime.Subtract(now).TotalMilliseconds);
                    _skip = nextDueTimeMs > maxDueTimeMs;
                    long dueTimeMs = _skip ? maxDueTimeMs : nextDueTimeMs;
                    _timer.Change(dueTimeMs, Timeout.Infinite);
                }
            }
        }

        [XmlIgnore]
        public override DateTime LastRunTime
        {
            // get { return _lastRunTime; }
            protected set
            {
                if (value != _lastRunTime)
                {
                    _lastRunTime = value;
                    OnPropertyChanged("LastRunTime");
                }
            }
        }
        #endregion private methods and properties

        #region public properties
        [DefaultValue(false)]
        public override bool Enabled
        {
            get { return _enabled; }
            set
            {
                bool wasPaused = false;
                lock (SyncRoot)
                {
                    if (value == _enabled)
                        return;
                    _enabled = value;
                    if (_paused)
                    {
                        _paused = false;
                        wasPaused = true;
                    }
                    LastRunTime = c_DateTimeNever;
                    if (_enabled)
                        Start();
                    else
                        Stop();
                }
                OnPropertyChanged("Enabled");
                if (wasPaused)
                    OnPropertyChanged("Paused");
            }
        }

        [DefaultValue(false)]
        public override bool Paused
        {
            get { return _paused; }
            set
            {
                lock (SyncRoot)
                {
                    if (value == _paused)
                        return;
                    if (_owner != null && !Enabled)
                        throw new ArgumentOutOfRangeException("Paused", value, "Can only pause an enabled task.");

                    _paused = value;
                    if (_paused)
                        Pause();
                    else
                        Resume();
                }
                OnPropertyChanged("Paused");
            }
        }
        #endregion
    }
}
