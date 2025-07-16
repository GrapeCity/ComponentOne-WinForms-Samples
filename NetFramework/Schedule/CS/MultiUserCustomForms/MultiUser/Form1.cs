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
using System.IO;
using System.Drawing.Imaging;

namespace MultiUser
{
	public partial class Form1 : Form
	{
		#region ** Initialization
		private bool _initialized = false;

		public Form1()
		{
			InitializeComponent();
			// suspend C1Schedule updates while loading data
			c1Schedule1.BeginUpdate();
			// TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.c1NWindDataSet1.Customers_Multi);
			// TODO: This line of code loads data into the 'nwindDataSet.Statuses' table. You can move, or remove it, as needed.
            this.statusesTableAdapter.Fill(this.c1NWindDataSet1.Statuses);
			// TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1NWindDataSet1.Products_Schedule);
			// TODO: This line of code loads data into the 'nwindDataSet.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter.Fill(this.c1NWindDataSet1.Labels);
			// TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.c1NWindDataSet1.Employees);
			// TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.c1NWindDataSet1.Categories);
			// TODO: This line of code loads data into the 'nwindDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.c1NWindDataSet1.Appointments_Multi);

			// set correct MenuCaption for contacts (Customers)
			foreach (Contact cnt in c1Schedule1.DataStorage.ContactStorage.Contacts)
			{
                MultiUser.C1NWindDataSet.Customers_MultiRow row = this.c1NWindDataSet1.Customers_Multi.FindByCustomerId((Guid)cnt.Key[0]);
				if (row != null)
				{
					cnt.MenuCaption = row["CompanyName"].ToString() + " (" + row["ContactName"].ToString() + ")";
				}
			}

			// set correct MenuCaption for owners (Employees)
			foreach (Contact cnt in c1Schedule1.DataStorage.OwnerStorage.Contacts)
			{
                MultiUser.C1NWindDataSet.EmployeesRow row = this.c1NWindDataSet1.Employees.FindByEmployeeID((int)cnt.Key[0]);
				if (row != null)
				{
					cnt.MenuCaption = row["FirstName"].ToString() + " " + row["LastName"].ToString();
				}
				lstCalendarOwners.Items.Add(cnt);
			}
			for (int i = 0; i < lstCalendarOwners.Items.Count; i++)
			{
				// check all items
				lstCalendarOwners.SetItemChecked(i, true);
			}
			// resume C1Schedule updates
			c1Schedule1.EndUpdate();

			// preview C1Schedule context menu actions
			c1Schedule1.ContextMenuStrip.MouseClick += new MouseEventHandler(ContextMenuStrip_MouseClick);

            _initialized = true;
		}
		#endregion

		#region ** Exit
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// On form closing update data adapters in order to save data to the database.
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            this.c1NWindDataSet1.EnforceConstraints = false;
			// TODO: This line of code saves data from the 'nwindDataSet.Statuses' table. You can move, or remove it, as needed.
			// this.statusesTableAdapter.Update(this.nwindDataSet.Statuses);
			// TODO: This line of code saves data from the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Update(this.c1NWindDataSet1.Products_Schedule);
			// TODO: This line of code saves data from the 'nwindDataSet.Labels' table. You can move, or remove it, as needed.
			// this.labelsTableAdapter.Update(this.nwindDataSet.Labels);
			// TODO: This line of code saves data from the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
			// this.employeesTableAdapter.Update(this.nwindDataSet.Employees);
			// TODO: This line of code saves data from the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			// this.categoriesTableAdapter.Update(this.nwindDataSet.Categories);
			// TODO: This line of code saves data from the 'nwindDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Update(this.c1NWindDataSet1.Appointments_Multi);
            this.c1NWindDataSet1.EnforceConstraints = true;
		}
		#endregion

		#region ** Navigation
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
			// Switch to the MonthView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
		}

		private void _today_Click(object sender, EventArgs e)
		{
			// Go to today date.
			this.c1Schedule1.GoToDate(DateTime.Today);
		}
		#endregion

		#region ** Show/Hide calendars
		private void lstCalendarOwners_ItemCheck(object sender, ItemCheckEventArgs e)
		{
            if (!_initialized)
            {
                return;
            }

			// update ScheduleGroupItem.IsChecked property
			Contact cnt = lstCalendarOwners.Items[e.Index] as Contact;
			c1Schedule1.GroupItems[cnt].IsChecked = e.NewValue == CheckState.Checked;
		}
		#endregion

		#region ** Format group headers
		void c1Schedule1_BeforeGroupHeaderFormat(object sender, C1.Win.Schedule.BeforeGroupHeaderFormatEventArgs e)
		{
			Contact owner = e.Group.Owner as Contact;
			if (owner != null)
			{
				MultiUser.C1NWindDataSet.EmployeesRow row = this.c1NWindDataSet1.Employees.FindByEmployeeID((int)owner.Key[0]);
				if (row != null)
				{
					string imageName = "photo" + row.EmployeeID + ".bmp";
					if (!File.Exists(imageName))
					{
						// resize and cache image into the working directory
						using (MemoryStream ms = new MemoryStream(row.Photo, 78, row.Photo.Length - 78))
						{
							Bitmap bmp = Image.FromStream(ms, true) as Bitmap;
							Bitmap bmp1 = ResizeImage(bmp, 82, 94);
							bmp1.Save(imageName, System.Drawing.Imaging.ImageFormat.Bmp);
						}
                    }
                    // use image from file
                    // note, C1Schedule only accepts images from internet (http://..), 
                    // application resources (res://..) and local file system (file:///...).
                    e.Html = row.FirstName + " " + row.LastName + "&nbsp;<br><img STYLE='padding-top:1mm' src=file:///" + imageName + "/>";
                }
                if (e.Style.Hot != null)
                {
                    // Hot style is applied to the group header when ScheduleGroupItem is selected.
                    e.Style.Hot.BackColor2 = e.Style.Hot.BorderColor = Color.DarkSlateGray;
                    e.Style.Hot.ForeColor = Color.WhiteSmoke;
                }
            }
            // uncomment the next line to use rectangular group headers
            // e.TriangleTab = false;
		}
		/// <summary>        
		/// Resize the image to the specified width and height.        
		/// </summary>        
		/// <param name="image">The image to resize.</param>        
		/// <param name="width">The width to resize to.</param>        
		/// <param name="height">The height to resize to.</param>        
		/// <returns>The resized image.</returns>        
		public static System.Drawing.Bitmap ResizeImage(System.Drawing.Image image, int width, int height)        
		{            
			//a holder for the result            
			Bitmap result = new Bitmap(width, height);            
			//use a graphics object to draw the resized image into the bitmap            
			using (Graphics graphics = Graphics.FromImage(result))            
			{                
				//set the resize quality modes to high quality                
				graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;                
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;                
				graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;                
				//draw the image into the target bitmap                
				graphics.DrawImage(image, 0, 0, result.Width, result.Height);            
			}            
			//return the resulting bitmap            
			return result;
		}
		#endregion

		#region ** Show custom forms
        private bool _createRecurrenceFlag = false;
        private void ContextMenuStrip_MouseClick(object sender, MouseEventArgs e)
		{
            _createRecurrenceFlag = false;
            ToolStripItem item = c1Schedule1.ContextMenuStrip.GetItemAt(e.Location);
            if (item != null)
            {
                // use this flag to open recurrence form automatically for the new recurring apps
                if (item.Owner.Tag == null)
                {
                    switch (item.Name)
                    {
                        case "NewRecurringAppointment":
                        case "NewRecurringEvent":
                            // create recurrence
                            _createRecurrenceFlag = true;
                            break;
                    }
                }
            }
		}

		private void c1Schedule1_BeforeAppointmentCreate(object sender, CancelAppointmentEventArgs e)
		{
            // set default status and label
            e.Appointment.BusyStatus = c1Schedule1.DataStorage.StatusStorage.Statuses[new Guid("{E6569EEF-845E-41FE-8772-C7A252D467F9}")]; // unknown status
            e.Appointment.Label = c1Schedule1.DataStorage.LabelStorage.Labels[new Guid("{D3F876F9-881B-478C-8594-4941B92D6424}")]; // none
		}

		private void c1Schedule1_BeforeAppointmentShow(object sender, CancelAppointmentEventArgs e)
		{
			// Don't show built-in form
			e.Cancel = true;
			Appointment appointment = e.Appointment;
            foreach (Form f in Application.OpenForms)
            {
                if (f is AppointmentForm && ((AppointmentForm)f).Appointment == appointment)
                {
                    // if form is already opened, just bring it to front
                    f.BringToFront();
                    return;
                }
            }
            if (appointment.RecurrenceState == RecurrenceStateEnum.Exception ||
				appointment.RecurrenceState == RecurrenceStateEnum.Occurrence)
			{
				// show Series dialog
				SeriesDialog dial = new SeriesDialog(appointment.Subject);
				if (dial.ShowDialog() == DialogResult.OK)
				{
					if (dial.Series)
					{
						// if customer selected Series, switch to the master appointment
						appointment = appointment.ParentRecurrence;
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f is AppointmentForm && ((AppointmentForm)f).Appointment == appointment)
                            {
                                // if form is already opened, just bring it to front
                                f.BringToFront();
                                return;
                            }
                        }
                    }
				}
				else
				{
					// do nothing
					return;
				}
			}
			// Create AppointmentForm for selected Appointment
            if (_createRecurrenceFlag)
            {
                _createRecurrenceFlag = false;
                appointment.Tag = "Create recurrence";
            }
			AppointmentForm form = new AppointmentForm(c1Schedule1, appointment);
			form.Show(this);
        }

		// update list of available locations
		// you can remove the next methods if you use C1Schedule build 184 or later
		private void c1Schedule1_AppointmentAdded(object sender, AppointmentEventArgs e)
		{
			UpdateAvailableLocation(e.Appointment.Location);
		}

		private void c1Schedule1_AppointmentChanged(object sender, AppointmentEventArgs e)
		{
			UpdateAvailableLocation(e.Appointment.Location);
		}

		private void UpdateAvailableLocation(string location)
		{
			if (!string.IsNullOrEmpty(location) && !AppointmentForm.Locations.Contains(location))
			{
				lock (AppointmentForm.Locations)
				{
					AppointmentForm.Locations.Add(location);
				}
			}
		}
		#endregion
	}
}