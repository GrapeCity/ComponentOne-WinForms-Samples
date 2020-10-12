using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace ControlExplorer.Schedule
{
	using C1.C1Schedule;
	using C1.Win.C1Schedule;

	/// <summary>
	/// The <see cref="ExcerciseForm"/> represents the dialog form for editing
	/// <see cref="Appointment"/> objects.
	/// It differ from the built-in AppointmentForms and display an Appointment
	/// in terms of Fitness Center domain.
	/// </summary>
	public partial class ExcerciseForm : Form
	{
        //------------------------------------------------------------------------------------------
        #region ** fields
		// reference to the owning C1Schedule component.
		private C1Schedule _schedule;
		// Appointment object
        private Appointment _appointment;
		#endregion

        //------------------------------------------------------------------------------------------
        #region ** ctor

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcerciseForm"/> form
		/// for editing of the specified <see cref="Appointment"/> object.
		/// </summary>
		/// <param name="schedule">The owning <see cref="C1Schedule"/> component.</param>
		/// <param name="appointment">The <see cref="Appointment"/> object.</param>
		public ExcerciseForm(C1Schedule schedule, Appointment appointment)
		{
			// initialize private fields
			_schedule = schedule;
			_appointment = appointment;

			// call BeginEdit in order to not refresh UI at changing properties of Appointment
			_appointment.BeginEdit();

			Font = SystemInformation.MenuFont;
			InitializeComponent();

			// initialize form controls
			Initialize();
		}

		// initialize form controls
		private void Initialize()
		{
			// cmbLabel shows group(student) level
			cmbLabel.DataSource = _schedule.DataStorage.LabelStorage.Labels;
			cmbLabel.DisplayMember = "Text";
			// draw colored levels
			cmbLabel.DrawItem += new DrawItemEventHandler(cmbLabel_DrawItem);
			cmbLabel.DrawMode = DrawMode.OwnerDrawFixed;

			// cmbLocation shows available locations
			cmbLocation.DataSource = _schedule.DataStorage.ResourceStorage.Resources;
			cmbLocation.DisplayMember = "Text";

            // cmbInstructor shows instructors
			cmbInstructor.DataSource = _schedule.DataStorage.ContactStorage.Contacts;
			cmbInstructor.DisplayMember = "Text";

            // cmbCategory shows exercise categories
			cmbCategory.DataSource = _schedule.DataStorage.CategoryStorage.Categories;
			cmbCategory.DisplayMember = "Text";

			// init date and time controls
			dpStart.Value = _appointment.Start.Date;
			dpEnd.Value = _appointment.End.Date;
			tpStart.MinDate = _appointment.Start.Date;
			tpStart.Value =
				tpEnd.MinDate = _appointment.Start;
			tpEnd.Value = _appointment.End;
			dpEnd.MinDate = _appointment.Start;

			// init selected control values
			if (_appointment.Label!= null )
			{
				cmbLabel.SelectedItem = _appointment.Label;
			}
			cmbLocation.SelectedIndex = cmbLocation.FindStringExact(_appointment.Location);
			if (cmbLocation.SelectedIndex == -1)
			{
				cmbLocation.SelectedIndex = 0;
			}

			cmbExcercise.SelectedIndex = cmbExcercise.FindStringExact(_appointment.Subject);
			if (cmbExcercise.SelectedIndex == -1)
			{
				cmbExcercise.SelectedIndex = 0;
			}
			
			if (_appointment.Links.Count > 0)
			{
				cmbInstructor.SelectedIndex = cmbInstructor.FindStringExact(_appointment.Links[0].ToString());
			}
			if (_appointment.Categories.Count > 0)
			{
				cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_appointment.Categories[0].ToString());
			}

			txtBody.Text = _appointment.Body;
		}

		// set Appointment properties according to the selected control values
		private void SetAppointment()
		{
			try
			{
                // set exercise name
				_appointment.Subject = cmbExcercise.SelectedItem.ToString();
                // set exercise description
				_appointment.Body = txtBody.Text;

                // set exercise level
				if (cmbLabel.SelectedIndex >= 0)
				{
					if (!((C1.C1Schedule.Label)cmbLabel.SelectedItem).Equals(_appointment.Label))
					{
						_appointment.Label = (C1.C1Schedule.Label)cmbLabel.SelectedItem;
					}
				}

                // set exercise instructor
				_appointment.Links.Clear();
				_appointment.Links.Add((Contact)cmbInstructor.SelectedItem);

                // set exercise category
				_appointment.Categories.Clear();
				_appointment.Categories.Add((Category)cmbCategory.SelectedItem);

                // set exercise start time
				_appointment.Start = dpStart.Value.Date.Add(tpStart.Value.TimeOfDay);
                // set exercise end time
				DateTime end = dpEnd.Value.Date.Add(tpEnd.Value.TimeOfDay);
				_appointment.End = (_appointment.Start >= end) ? _appointment.Start.AddMinutes(1) : end;

                // set exercise location
				_appointment.Location = cmbLocation.SelectedItem.ToString();

				// we don't use reminders at all
				_appointment.ReminderSet = false;
			}
			finally
			{
				// always call EndEdit to apply changes and refresh UI
				_appointment.EndEdit();
			}
		}
		#endregion

        //------------------------------------------------------------------------------------------
        #region ** object model

		/// <summary>
		/// Gets the <see cref="Appointment"/> object.
		/// </summary>
		public Appointment Appointment
		{
			get
			{
				return _appointment;
			}
		}
		#endregion

        //------------------------------------------------------------------------------------------
        #region ** event handlers
		void cmbLabel_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			Brush brush;
			if ((e.State & DrawItemState.Focus) == 0)
			{
				brush = Brushes.Black;
			}
			else
			{
				brush = Brushes.White;
			}
			// Define the default color of the brush as black.
			Brush myBrush = new SolidBrush(_schedule.DataStorage.LabelStorage.Labels[e.Index].Color);

			e.Graphics.DrawRectangle(new Pen(Color.Black, 1), e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4);
			e.Graphics.FillRectangle(myBrush, e.Bounds.X + 3, e.Bounds.Y + 3, e.Bounds.Height - 5, e.Bounds.Height - 5);
			// Draw the current item text based on the current Font and the custom brush settings.
			e.Graphics.DrawString(cmbLabel.Items[e.Index].ToString(), e.Font, brush, e.Bounds.X + e.Bounds.Height, e.Bounds.Y);
			// If the ListBox has focus, draw a focus rectangle around the selected item.
			e.DrawFocusRectangle();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// validate DateTime values selected in controls
			if (!CheckTimes())
			{
				// if validation fails, return
				return;
			}
			// apply changes
			SetAppointment();
			DialogResult = DialogResult.OK;
			// close form
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            // remove exercise (this will remove an Appointment object from control)
			_appointment.Delete();
			// close form
			Close();
		}

        // change minimum allowed values of other controls according to the new value of start date.
		private void dpStart_ValueChanged(object sender, EventArgs e)
		{
			tpStart.MinDate = dpStart.Value.Date;
			DateTime start = dpStart.Value.Date.Add(tpStart.Value.TimeOfDay);
			DateTime end = dpEnd.Value.Date.Add(tpEnd.Value.TimeOfDay);
			if (end < start)
			{
				end = start.Add(_schedule.CalendarInfo.TimeScale);
				dpEnd.Value = tpEnd.Value = end;
			}
			tpEnd.MinDate = dpEnd.MinDate = start;
		}

		// Validate times and show error message if necessary.
		private bool CheckTimes()
		{
			DateTime start = dpStart.Value.Date.Add(tpStart.Value.TimeOfDay);
			DateTime end = dpEnd.Value.Date.Add(tpEnd.Value.TimeOfDay);
			if (end < start)
			{
				MessageBox.Show("The end date you entered occurs before the start date.",
					Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}
		#endregion

	}
}