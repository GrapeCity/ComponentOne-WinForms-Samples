using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;

namespace C1ReportsScheduler
{
    public class ScheduleClient : ScheduleBase
    {
        #region construction/destruction
        public ScheduleClient(TaskClient owner)
            : base(owner)
        {
        }

        internal void FromProxyXml(string xml)
        {
            FromProxy((ScheduleProxy)Util.FromXml(xml, typeof(ScheduleProxy)));
        }

        private void FromProxy(ScheduleProxy proxy)
        {
            this._enabled = proxy.Enabled;
            this._paused = proxy.Paused;
            this._frequency = proxy.Frequency;
            this._startDateTime = proxy.StartTime;
            this._recurEveryDays = proxy.RecurEveryDays;
            this._recurEveryWeeks = proxy.RecurEveryWeeks;
            this._repeatUnit = proxy.RepeatUnit;
            this._repeatFrequency = proxy.RepeatFrequency;
            this._repeat = proxy.Repeat;
            this._daysOfWeek = proxy.DaysOfWeek;
            this._months = proxy.Months;
            this._days = proxy.Days;
            this._lastRunTime = this.LastRunTime;
        }

        internal void CallPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
        }

        private void SetProperty(string propertyName, string propertyValue)
        {
            ((TaskListClient)_owner.Owner).SetScheduleProperty(_owner, propertyName, propertyValue);
        }

        public override void Exit()
        {
        }
        #endregion construction/destruction

        #region public stored properties
        [DefaultValue(false)]
        public override bool Enabled
        {
            set
            {
                SetProperty("Enabled", value.ToString());
            }
        }

        [DefaultValue(false)]
        public override bool Paused
        {
            set
            {
                SetProperty("Paused", value.ToString());
            }
        }

        [DefaultValue(ScheduleFrequency.Once)]
        public override ScheduleFrequency Frequency
        {
            set
            {
                SetProperty("Frequency", value.ToString());
            }
        }

        public override DateTime StartTime
        {
            set
            {
                SetProperty("StartTime", value.ToString());
            }
        }

        [DefaultValue(1)]
        public override int RecurEveryDays
        {
            set
            {
                SetProperty("RecurEveryDays", value.ToString());
            }
        }

        [DefaultValue(1)]
        public override int RecurEveryWeeks
        {
            set
            {
                SetProperty("RecurEveryWeeks", value.ToString());
            }
        }

        [DefaultValue(ScheduleRepeatUnit.Seconds)]
        public override ScheduleRepeatUnit RepeatUnit
        {
            set
            {
                SetProperty("RepeatUnit", value.ToString());
            }
        }

        [DefaultValue(1)]
        public override int RepeatFrequency
        {
            set
            {
                SetProperty("RepeatFrequency", value.ToString()); 
            }
        }

        [DefaultValue(false)]
        public override bool Repeat
        {
            set
            {
                SetProperty("Repeat", value.ToString()); 
            }
        }

        #region days of week
        protected override void _setDayOfWeek(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_"));
            string dayName = caller.Name.Substring(4);
            SetProperty(dayName, on.ToString()); 
        }
        #endregion days of week

        #region months
        protected override void _setMonth(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_"));
            string monthName = caller.Name.Substring(4);
            SetProperty(monthName, on.ToString()); 
        }
        #endregion months

        #region days
        protected override void _setDay(MethodBase caller, bool on)
        {
            System.Diagnostics.Debug.Assert(caller.Name.StartsWith("set_Day"));
            string daystr = caller.Name.Substring(4);
            SetProperty(daystr, on.ToString()); 
        }
        #endregion days
        #endregion public stored properties
    }
}
