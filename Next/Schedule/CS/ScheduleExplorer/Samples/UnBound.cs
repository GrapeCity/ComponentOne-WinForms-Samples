using C1.Schedule;
using C1.Win.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleExplorer.Samples
{
    public partial class UnBound : UserControl
    {
        public UnBound()
        {
            InitializeComponent();
        }

        private void C1ScheduleDemo_Load(object sender, EventArgs e)
        {
            // If file with data exists,
            if (File.Exists("C1Schedule.xml"))
            {
                // load data from the file.
                this.c1Schedule1.DataStorage.Import("C1Schedule.xml", FileFormatEnum.XML);
            }
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

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment contacts
            this.c1Schedule1.GroupBy = "Contact";
            categoryToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment categories
            this.c1Schedule1.GroupBy = "Category";
            contactToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void resourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment resources
            this.c1Schedule1.GroupBy = "Resource";
            contactToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
        }

        // Export data to the file.
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1Schedule1.Export(null, "Export Data to File");
        }

        // Import data from the file.
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1Schedule1.Import("Import Data");
        }
    }
}
