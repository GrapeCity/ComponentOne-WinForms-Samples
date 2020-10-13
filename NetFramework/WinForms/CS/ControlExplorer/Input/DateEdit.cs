using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public DateEdit()
        {
            InitializeComponent();
            AddPropertyHeader("DateEdit settings");
            AddProperty("AllowSpinLoop", c1DateEdit1);
            AddProperty("RetainTimeOnDateChange", c1DateEdit1);
            AddPropertyHeader("Calendar settings");
            AddProperty("Width", c1DateEdit1.Calendar.CalendarDimensions, "CalendarDimensions.Width");
            AddProperty("Height", c1DateEdit1.Calendar.CalendarDimensions, "CalendarDimensions.Height");
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
            // DayNameLength is styled property and can be changed during theme change 
            c1DateEdit1.Calendar.DayNameLength = _dayNameLength;
        }
    }
}
