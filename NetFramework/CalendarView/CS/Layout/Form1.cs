using C1.CalendarView;
using C1.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Layout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTheme.Items.AddRange(C1.Win.C1Themes.C1ThemeController.GetThemes());
        }

        private void cmbDayTitlePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1CalendarView1.DayTitlePosition = (Position)Enum.Parse(typeof(Position), cmbDayTitlePosition.Text);
        }

        private void cmbMonthTitlePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1CalendarView1.MonthTitlePosition = (Position)Enum.Parse(typeof(Position), cmbMonthTitlePosition.Text);
        }

        private void cbVerticalOrientationLayout_CheckedChanged(object sender, EventArgs e)
        {
            c1CalendarView1.VerticalOrientationLayout = cbVerticalOrientationLayout.Checked;
        }

        private void cmbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c1CalendarView1.VerticalOrientationLayout)
                c1CalendarView1.Theme.Common.VerticalAlignment = (Alignment)Enum.Parse(typeof(Alignment), cmbAlignment.Text);
            else
                c1CalendarView1.Theme.Common.HorizontalAlignment = (Alignment)Enum.Parse(typeof(Alignment), cmbAlignment.Text);
        }

        private void cbShowWeekNumbers_CheckedChanged(object sender, EventArgs e)
        {
            c1CalendarView1.ShowWeekNumbers = cbShowWeekNumbers.Checked;
        }

        private void numCalendarDimensions_ValueChanged(object sender, EventArgs e)
        {
            c1CalendarView1.CalendarDimensions = (int)numCalendarDimensions.Value;
        }

        private void numMaxSelectionCount_ValueChanged(object sender, EventArgs e)
        {
            c1CalendarView1.MaxSelectionCount = (int)numMaxSelectionCount.Value;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.Text;
            if (clpDayForeColor.Color != Color.Transparent)
                c1CalendarView1.Theme.Day.Ordinary.ForeColor = clpDayForeColor.Color;
            if (clpWeekendForeColor.Color != Color.Transparent)
                c1CalendarView1.Theme.Day.Weekend.ForeColor = clpWeekendForeColor.Color;
            if (clpTodayForeColor.Color != Color.Transparent)
                c1CalendarView1.Theme.Day.Today.ForeColor = clpTodayForeColor.Color;
            if (clpTodayBorderColor.Color != Color.Transparent)
                c1CalendarView1.Theme.Day.Today.BorderColor = clpTodayBorderColor.Color;
        }

        private void clpDayForeColor_ColorChanged(object sender, EventArgs e)
        {
            c1CalendarView1.Theme.Day.Ordinary.ForeColor = clpDayForeColor.Color;
        }

        private void clpWeekendForeColor_ColorChanged(object sender, EventArgs e)
        {
            c1CalendarView1.Theme.Day.Weekend.ForeColor = clpWeekendForeColor.Color;
        }

        private void clpTodayForeColor_ColorChanged(object sender, EventArgs e)
        {
            c1CalendarView1.Theme.Day.Today.ForeColor = clpTodayForeColor.Color;
        }

        private void clpTodayBorderColor_ColorChanged(object sender, EventArgs e)
        {
            c1CalendarView1.Theme.Day.Today.BorderColor = clpTodayBorderColor.Color;
        }
    }
}
