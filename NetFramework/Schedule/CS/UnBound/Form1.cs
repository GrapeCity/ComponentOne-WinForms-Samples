using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestSchedule
{
	using C1.Win.C1Schedule;
	using C1.C1Schedule;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// On loading the form, load previously saved data.
		private void Form1_Load(object sender, EventArgs e)
		{
			// If file with data exists,
			if (File.Exists("C1Schedule.xml"))
			{
	            // load data from the file.
				this.c1Schedule1.DataStorage.Import("C1Schedule.xml", FileFormatEnum.XML);
			}
		}

		// On closing the form, save all data to the file.
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
	        // Save all data to the file.
			this.c1Schedule1.DataStorage.Export("C1Schedule.xml", FileFormatEnum.XML);
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