using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Schedule;
using C1.C1Schedule;

namespace ControlExplorer.Schedule
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void _DayView_Click(object sender, EventArgs e)
        {
            // Switch to the DayView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.DayView;
        }

        private void _workWeek_Click(object sender, EventArgs e)
        {
            // Switch to the WorkWeekView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView;
        }

        private void _week_Click(object sender, EventArgs e)
        {
            // Switch to the WeekView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.WeekView;
        }

        private void _month_Click(object sender, EventArgs e)
        {
            // Switch to the MonthView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.MonthView;
        }

        private void _timeline_Click(object sender, EventArgs e)
        {
            // Switch to the TimeLineView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
        }

        private void _today_Click(object sender, EventArgs e)
        {
            // Go to today date.
            this.c1Schedule1.GoToDate(DateTime.Today);
        }

        private void _print_Click(object sender, EventArgs e)
        {
            c1Schedule1.PrintInfo.Preview();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            this.c1Schedule1.DataStorage.Import(AppDomain.CurrentDomain.BaseDirectory + "Schedule\\C1Schedule.xml", FileFormatEnum.XML);

            // Add demo properties
            AddPropertyHeader("C1Calendar Properties");
            AddProperty("CalendarDimensions", c1Calendar1);
            AddProperty("ShowWeekNumbers", c1Calendar1);
            
            AddPropertyHeader("C1Schedule Properties");
            AddProperty("SetReminder", c1Schedule1.Settings);
            AddProperty("TimeInterval", c1Schedule1.CalendarInfo);
            AddProperty("WeekStart", c1Schedule1.CalendarInfo);
            AddProperty("WeekViewStyle", c1Schedule1);
        }
    }
}
