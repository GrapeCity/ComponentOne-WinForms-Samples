using C1.CalendarView;
using C1.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.CalendarView
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
            AddPropertyHeader("Layout");
            AddProperty("MonthTitlePosition", c1CalendarView1);
            AddProperty("DayTitlePosition", c1CalendarView1);
            AddProperty("ShowWeekNumbers", c1CalendarView1);
            AddProperty("VerticalOrientationLayout", c1CalendarView1);
            AddProperty("HorizontalAlignment", c1CalendarView1.Theme.Common);
            AddProperty("VerticalAlignment", c1CalendarView1.Theme.Common);
            AddProperty("CalendarDimensions", c1CalendarView1);
            AddProperty("MaxSelectionCount", c1CalendarView1);

            c1CalendarView1.BeginUpdate();

            var selectedDates = new DateTime[2] { DateTime.Now, DateTime.Now.AddDays(1) };
            var boldedDates = new DateTime[3] { DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3) };
            var disabledDays = new DateTime[2] { DateTime.Now.AddDays(3), DateTime.Now.AddDays(4) };
            c1CalendarView1.MaxSelectionCount = 14;
            c1CalendarView1.SelectedDates = selectedDates;
            c1CalendarView1.BoldedDates = boldedDates;
            c1CalendarView1.DisabledDates = disabledDays;

            c1CalendarView1.EndUpdate();
        }        
    }
}
