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
using System.Collections;

namespace TestSchedule
{
	public partial class Form1 : Form
	{
		// collection of levels
		LevelCollection _levels;
		// collection of categories
		ExerciseCategories _categories;
		// array of locations
		ArrayList _locations;

		public Form1()
		{
			// create level and category collections
			_levels = new LevelCollection();
			_categories = new ExerciseCategories();

			// fill array of locations
			_locations = new ArrayList();
			_locations.Add(new Location(0, "LA Spin"));
			_locations.Add(new Location(1, "Studio 1"));
			_locations.Add(new Location(2, "Studio 2"));
			_locations.Add(new Location(3, "Pool"));
			_locations.Add(new Location(4, "Sauna"));
			_locations.Add(new Location(5, "Studio 3"));

			InitializeComponent();
			// Set mappings for LabelStorage (map Level to C1.C1Schedule.Label object properties)
			this.c1Schedule1.DataStorage.LabelStorage.Mappings.TextMapping.MappingName = "LevelName";
			this.c1Schedule1.DataStorage.LabelStorage.Mappings.CaptionMapping.MappingName = "Description";
			this.c1Schedule1.DataStorage.LabelStorage.Mappings.ColorMapping.MappingName = "ColorString";
			this.c1Schedule1.DataStorage.LabelStorage.Mappings.IdMapping.MappingName = "Id";
			// Set LabelStorage DataSource
			this.c1Schedule1.DataStorage.LabelStorage.DataSource = _levels.Values;

			// Set mappings for CategoryStorage (map ExerciseCategory to C1.C1Schedule.Category object properties)
			this.c1Schedule1.DataStorage.CategoryStorage.Mappings.TextMapping.MappingName = "Name";
			this.c1Schedule1.DataStorage.CategoryStorage.Mappings.IndexMapping.MappingName = "Id";
			// Set CategoryStorage DataSource
			this.c1Schedule1.DataStorage.CategoryStorage.DataSource = _categories;

			// Set mappings for ResourceStorage (map Location to C1.C1Schedule.Resource object properties)
			this.c1Schedule1.DataStorage.ResourceStorage.Mappings.TextMapping.MappingName = "Name";
			this.c1Schedule1.DataStorage.ResourceStorage.Mappings.IndexMapping.MappingName = "Id";
			// Set ResourceStorage DataSource
			this.c1Schedule1.DataStorage.ResourceStorage.DataSource = _locations;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Retrieve time table and instructors data from the database
		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'fitnessClubDataSet.TimeTable' table. You can move, or remove it, as needed.
			this.timeTableTableAdapter.Fill(this.fitnessClubDataSet.TimeTable);
			// TODO: This line of code loads data into the 'fitnessClubDataSet.Instructors' table. You can move, or remove it, as needed.
			this.instructorsTableAdapter.Fill(this.fitnessClubDataSet.Instructors);
		}

		// Save time table data to the database
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.timeTableTableAdapter.Update(this.fitnessClubDataSet.TimeTable);
		}

		// Go to the current date
		private void _today_Click(object sender, EventArgs e)
		{
			// Go to today date.
			this.c1Schedule1.GoToDate(DateTime.Today);

		}

		// Prevent switching to other views
		private void c1Schedule1_BeforeViewChange(object sender, BeforeViewChangeEventArgs e)
		{
			// never switch to other views
			e.ViewType = ScheduleViewEnum.WeekView;
		}

        private void c1Schedule1_BeforeAppointmentCreate(object sender, CancelAppointmentEventArgs e)
		{
            // set default exercise duration (45 minutes)
            e.Appointment.Duration = TimeSpan.FromMinutes(45);
        }

		// Replace built-in AppointmentForm with the ExerciseForm
		private void c1Schedule1_BeforeAppointmentShow(object sender, CancelAppointmentEventArgs e)
		{
			// Don't show built-in form
			e.Cancel = true;
            foreach (Form f in Application.OpenForms)
            {
                // activate form if it is already opened
                if (f is ExerciseForm && ((ExerciseForm)f).Appointment == e.Appointment)
                {
                    f.BringToFront();
                    return;
                }
            }
            // Create ExerciseForm for selected Appointment
			ExerciseForm form = new ExerciseForm(c1Schedule1, e.Appointment);
			// Show form
			form.Show();
        }

		// Copy timetable information from currently selected day to another one
		private void copyDayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create CopyForm
			CopyForm f = new CopyForm();
			f._message.Text = "Select a day for copy to (choose one)";
			f.Text = "Select Day";

			// If user have selected a new day
			if (f.ShowDialog() == DialogResult.OK)
			{
				DateTime originalDate = c1Schedule1.CurrentDate.Date;

				DateTime newDate = f.Date.Date;

				if (newDate == originalDate)
				{
					// don't copy if user selected the same day
					return;
				}

				// A days number to add to the Appointment.Start value 
				int days = ((TimeSpan)(newDate - originalDate)).Days;

				// Get all current day Appointments
				AppointmentList list = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(
					originalDate, originalDate.AddDays(1));

				// For each current day Appointment, create a new one for the selected day
				foreach (Appointment app in list)
				{
					// Create new Appointment
					Appointment newApp = new Appointment();
					// Copy properties from the existent one
					newApp.CopyFrom(app, false);
					// Change start time
					newApp.Start = newApp.Start.AddDays(days);
					// Add new Appointment to AppointmentStorage
					c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(newApp);
				}
			}
		}

		// Copy timetable information from currently selected week to another one
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create CopyForm.
			CopyForm f = new CopyForm();
			// If user have selected a new week
			if (f.ShowDialog() == DialogResult.OK)
			{
				DateTime weekStart = c1Schedule1.SelectedDates[0];

				DateTime newWeekStart = f.Date.Date;
				while (newWeekStart.DayOfWeek != c1Schedule1.CalendarInfo.WeekStart)
				{
					newWeekStart = newWeekStart.AddDays(-1);
				}

				if (newWeekStart == weekStart)
				{
					// don't copy if user selected the same week
					return;
				}

				// A days number to add to the Appointment.Start value 
				int days = ((TimeSpan)(newWeekStart - weekStart)).Days;

				// Get all current week Appointments
				AppointmentList list = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(
					weekStart, weekStart.AddDays(7));

				// For each current week Appointment, create a new one for the selected week
				foreach (Appointment app in list)
				{
					// Create new Appointment
					Appointment newApp = new Appointment();
					// Copy properties from the existent one
					newApp.CopyFrom(app, false);
					// Change start time
					newApp.Start = newApp.Start.AddDays(days);
					// Add new Appointment to AppointmentStorage
					c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(newApp);
				}
			}
		}

		// Clear current week timetable
		private void clearWeekToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Get week start
			DateTime weekStart = c1Schedule1.SelectedDates[0];

			// Get all current week Appointments
			AppointmentList list = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(
				weekStart, weekStart.AddDays(7));

			// Remove appointments
			foreach (Appointment app in list)
			{
				app.Delete();
			}
		}
	}
}