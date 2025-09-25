using System;

namespace ControlExplorer.Input
{
    public partial class DateEdit : C1DemoForm
    {
        private int _dayNameLength = -1;
        public int DayNameLength
        {
            get
            {
                return _dayNameLength > -1 ? _dayNameLength : c1DateEdit1.Calendar.DayNameLength;
            }
            set
            {
                _dayNameLength = value;
                c1DateEdit1.Calendar.DayNameLength = value;
            }
        }

        public int CalendarMonthRows
        {
            get => c1DateEdit1.Calendar.CalendarDimensions.Width;
            set
            {
                var dims = c1DateEdit1.Calendar.CalendarDimensions;
                dims.Width = value;
                c1DateEdit1.Calendar.CalendarDimensions = dims;
            }
        }

        public int CalendarMonthColumns
        {
            get => c1DateEdit1.Calendar.CalendarDimensions.Height;
            set
            {
                var dims = c1DateEdit1.Calendar.CalendarDimensions;
                dims.Height = value;
                c1DateEdit1.Calendar.CalendarDimensions = dims;
            }
        }

        public DateEdit()
        {
            InitializeComponent();
            AddPropertyHeader("DateEdit settings");
            AddProperty("AllowSpinLoop", c1DateEdit1);
            AddProperty("RetainTimeOnDateChange", c1DateEdit1);
            AddPropertyHeader("Calendar settings");
            AddProperty("CalendarMonthRows", this);
            AddProperty("CalendarMonthColumns", this);
            AddProperty("CalendarWeekRule", c1DateEdit1.Calendar);
            AddProperty("CaptionFormat", c1DateEdit1.Calendar);
            AddProperty("DayNameLength", this);
            AddProperty("ShowToday", c1DateEdit1.Calendar);
            AddProperty("ShowTodayButton", c1DateEdit1.Calendar);
            AddProperty("ShowClearButton", c1DateEdit1.Calendar);
            AddProperty("ShowTodayCircle", c1DateEdit1.Calendar);

            var boldedDates = new DateTime[3] { DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3) };
            var disabledDays = new DateTime[2] { DateTime.Now.AddDays(3), DateTime.Now.AddDays(4) };
            c1DateEdit1.Calendar.BoldedDates = boldedDates;
            c1DateEdit1.Calendar.DisabledDates = disabledDays;
        }

        /// <summary>
        /// Called when theme was applied.
        /// </summary>
        protected override void OnThemeApplied()
        {
            base.OnThemeApplied();
            // Only override the DayNameLength if a valid value (> -1) has been set.
            if (_dayNameLength > -1)
            {
                c1DateEdit1.Calendar.DayNameLength = _dayNameLength;
            }
        }
    }
}
