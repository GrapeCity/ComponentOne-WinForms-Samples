using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Schedule;
using C1.Schedule;
using System.Globalization;
using System.Threading;

namespace FullBound
{
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

		// On form loading fill data adapters in order to load data from the database.
		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Statuses' table. You can move, or remove it, as needed.
            this.statusesTableAdapter1.Fill(this.c1NWindDataSet1.Statuses);
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Products_Schedule' table. You can move, or remove it, as needed.
            this.products_ScheduleTableAdapter.Fill(this.c1NWindDataSet1.Products_Schedule);
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter1.Fill(this.c1NWindDataSet1.Labels);
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Appointees' table. You can move, or remove it, as needed.
            this.appointeesTableAdapter.Fill(this.c1NWindDataSet1.Appointees);
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Fill(this.c1NWindDataSet1.Categories);
            // TODO: This line of code loads data into the 'c1NWindDataSet1.Appointments_Full' table. You can move, or remove it, as needed.
            this.appointments_FullTableAdapter.Fill(this.c1NWindDataSet1.Appointments_Full);
		}

		// On form closing update data adapters in order to save data to the database.
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            this.c1NWindDataSet1.EnforceConstraints = false;
			// TODO: This line of code saves data from the 'nwindDataSet.Statuses' table. You can move, or remove it, as needed.
			this.statusesTableAdapter1.Update(this.c1NWindDataSet1.Statuses);
			// TODO: This line of code saves data from the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.products_ScheduleTableAdapter.Update(this.c1NWindDataSet1.Products_Schedule);
			// TODO: This line of code saves data from the 'nwindDataSet.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter1.Update(this.c1NWindDataSet1.Labels);
			// TODO: This line of code saves data from the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.appointeesTableAdapter.Update(this.c1NWindDataSet1.Appointees);
			// TODO: This line of code saves data from the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Update(this.c1NWindDataSet1.Categories);
			// TODO: This line of code saves data from the 'nwindDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointments_FullTableAdapter.Update(this.c1NWindDataSet1.Appointments_Full);
            this.c1NWindDataSet1.EnforceConstraints = true;
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

		private void _today_Click(object sender, EventArgs e)
		{
			// Go to today date.
			this.c1Schedule1.GoToDate(DateTime.Today);
		}

		private void _timeLine_Click(object sender, EventArgs e)
		{
			// Switch to the TimeLineView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
		}

		private void c1Schedule1_BeforeAppointmentShow(object sender, CancelAppointmentEventArgs e)
		{
			if (e.Appointment.BusyStatus == null)
			{
				e.Appointment.BusyStatus = c1Schedule1.DataStorage.StatusStorage.Statuses[2];
			}
		}

		private void c1Schedule1_AppointmentAdded(object sender, AppointmentEventArgs e)
		{
			if (e.Appointment.BusyStatus == null)
			{
				e.Appointment.BusyStatus = c1Schedule1.DataStorage.StatusStorage.Statuses[2];
			}
		}
	}
}