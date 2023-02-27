using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Schedule;
using C1.C1Schedule;
using System.Globalization;
using System.Threading;
using C1.Win.C1Schedule.UI;

namespace C1ScheduleDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // fill combo for selecting group page size
            cmbGroupPageSize.Items.Add(1);
            cmbGroupPageSize.Items.Add(2);
            cmbGroupPageSize.Items.Add(3);
            cmbGroupPageSize.Items.Add(4);
            cmbGroupPageSize.Items.Add(5);
            cmbGroupPageSize.SelectedIndex = 1;

            // fill available visual styles combo
            foreach (VisualStyle style in Enum.GetValues(typeof(VisualStyle)))
            {
                if (style != VisualStyle.Custom)
                {
                    cmbVisualStyle.Items.Add(style);
                }
            }
            cmbVisualStyle.SelectedItem = VisualStyle.Office2010Blue;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // On form closing update data adapters in order to save data to the database.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.appointeesTableAdapter1.Fill(c1NWindDataSet1.Appointees);
            this.appointmentsTableAdapter1.Fill(c1NWindDataSet1.Appointments);
            // set correct MenuCaption for contacts
            foreach (Contact cnt in c1Schedule1.DataStorage.ContactStorage.Contacts)
            {
                C1ScheduleDemo.C1NwindDataSet.AppointeesRow row = this.c1NWindDataSet1.Appointees.FindByEmployeeID((int)cnt.Key[0]);
                if (row != null)
                {
                    cnt.MenuCaption = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                }
            }
        }

        // On form loading fill data adapters in order to load data from the database.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i = this.appointeesTableAdapter1.Update(c1NWindDataSet1.Appointees);
            int i1 = this.appointmentsTableAdapter1.Update(c1NWindDataSet1.Appointments);
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

        private void _timeLine_Click(object sender, EventArgs e)
        {
            // Switch to the TimeLineView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
        }

        private void _today_Click(object sender, EventArgs e)
        {
            // Go to today date.
            this.c1Schedule1.GoToDate(DateTime.Today);
        }

        private void showEmptyGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1Schedule1.ShowEmptyGroupItem = showEmptyGroupToolStripMenuItem.CheckState == CheckState.Checked;
        }

        private void cmbGroupPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update group page size
            this.c1Schedule1.GroupPageSize = (int)cmbGroupPageSize.SelectedItem;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove C1Schedule grouping
            this.c1Schedule1.GroupBy = "";
            contactToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment contacts
            this.c1Schedule1.GroupBy = "Contact";
            noneToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment categories
            this.c1Schedule1.GroupBy = "Category";
            noneToolStripMenuItem.Checked = false;
            contactToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void resourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment resources
            this.c1Schedule1.GroupBy = "Resource";
            noneToolStripMenuItem.Checked = false;
            contactToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
        }

        private void cmbVisualStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change visual style for both C1Calendar and C1Schedule controls
            c1Calendar1.VisualStyle = c1Schedule1.VisualStyle = (VisualStyle)cmbVisualStyle.SelectedItem;
            c1Calendar1.Refresh();
        }
    }
}