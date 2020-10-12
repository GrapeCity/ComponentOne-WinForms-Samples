using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.C1Schedule;
using C1.Win.C1Schedule;
using RibbonControls;
using C1.Win.C1Schedule.Forms;

namespace TestSchedule
{
	public partial class AppointmentForm : C1RibbonForm
	{
		#region ** fields
		private C1Schedule _scheduler;
		// temporary appointment used for editing
		private Appointment _appEdited;

		private TimeSpan _defaultStart;
		private TimeSpan _defaultDuration;

		// save all Location values which have been used in application
		// you can remove this field if you use C1Schedule build 184 or later
		public static List<string> Locations = new List<string>();
		
		// keep ZoomFactor for the appointment body rich text box
		public static float ZoomFactor = 1.0f;
		#endregion

		#region ** initialization
		/// <summary>
		/// Initializes a new instance of the <see cref="AppointmentForm"/> form.
		/// </summary>
		/// <param name="scheduler">Reference to the owning <see cref="C1Schedule"/> control.</param>
		/// <param name="appointment">The <see cref="Appointment"/> object for editing.</param>
		public AppointmentForm(C1Schedule scheduler, Appointment appointment)
		{
			_scheduler = scheduler;
			Appointment = appointment;
			// work with appointment copy, so that don't change initial appointment
			// until end-user saves the changes
			_appEdited = appointment.Copy();
			_appEdited.BeginEdit();
			_defaultStart = appointment.AllDayEvent ? _scheduler.CalendarInfo.StartDayTime : appointment.Start.TimeOfDay;
			_defaultDuration = appointment.AllDayEvent ? _scheduler.CalendarInfo.TimeScale : appointment.Duration;

			InitializeComponent();
			Initialize();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
            SetCurrentZoom();
        }

		private void AppointmentForm_Shown(object sender, EventArgs e)
		{
			if (_scheduler != null && !DesignMode && (string)_appEdited.Tag == "Create recurrence")
			{
				_appEdited.Tag = null;
				// if form is opened with C1Schedule context menu "Create Recurring Appointment" or "Create Recurring Event",
				// then open Recurrence dialog immediately
				_btnRecurrence_Click(this, null);
			}
		}

		private void Initialize()
		{
			// initialize controls in the ribbon
			c1Ribbon1.BeginUpdate();
			_cmbStatus.DataBindings.Clear();
			_cmbLabel.DataBindings.Clear();
			_cmbOwner.DataBindings.Clear();
			_txtSubject.DataBindings.Clear();
			_txtBody.DataBindings.Clear();
			_cmbLocation.DataBindings.Clear();
			_chkAllDay.DataBindings.Clear();
			_dpStartDate.DataBindings.Clear();
			_dpStartTime.DataBindings.Clear();
			_dpEndTime.DataBindings.Clear();
			_dpEndDate.DataBindings.Clear();
			_dpEndTime.DataBindings.Clear();
			_dpEndDate.MinDate = DateTimePicker.MinimumDateTime;
			_dpEndTime.MinDate = DateTimePicker.MinimumDateTime;

			_togglePrivate.Pressed = _appEdited.Private;
			switch (_appEdited.Importance)
			{
				case ImportanceEnum.High:
					_toggleHighImportance.Pressed = true;
					break;
				case ImportanceEnum.Low:
					_toggleLowImportance.Pressed = true;
					break;
			}

			_cmbStatus.DataSource = _scheduler.DataStorage.StatusStorage.Statuses;
			_cmbStatus.DisplayMember = "Text";
			Binding status = new Binding("SelectedItem", _appEdited, "BusyStatus", true, DataSourceUpdateMode.OnPropertyChanged);
			_cmbStatus.DataBindings.Add(status);
			status.BindingComplete += delegate
			{
				_cmbStatus.SelectedValueChanged -= new EventHandler(_cmbStatus_SelectedValueChanged);
				_appEdited.BusyStatus = (Status)_cmbStatus.SelectedItem;
				_cmbStatus.SelectedValueChanged += new EventHandler(_cmbStatus_SelectedValueChanged);
			};

			_cmbLabel.DataSource = _scheduler.DataStorage.LabelStorage.Labels;
			_cmbLabel.DisplayMember = "Text";
			Binding label = new Binding("SelectedItem", _appEdited, "Label", true, DataSourceUpdateMode.OnPropertyChanged);
			_cmbLabel.DataBindings.Add(label);
			label.BindingComplete += delegate
			{
				_cmbLabel.SelectedValueChanged -= new EventHandler(_cmbLabel_SelectedValueChanged);
				_appEdited.Label = (C1.C1Schedule.Label)_cmbLabel.SelectedItem;
				_cmbLabel.SelectedValueChanged += new EventHandler(_cmbLabel_SelectedValueChanged);
			};

			FillReminders();
            InitZoom();
            c1Ribbon1.EndUpdate();

			// initialize other controls
			// bind controls to appointment properties
            _cmbOwner.SelectedIndexChanged -= new EventHandler(_cmbOwner_SelectedIndexChanged);
            _cmbOwner.DataSource = _scheduler.DataStorage.OwnerStorage.Contacts;
			_cmbOwner.DataBindings.Add(new Binding("SelectedItem", _appEdited, "Owner", true, DataSourceUpdateMode.OnPropertyChanged));
			_cmbOwner.SelectedIndexChanged += new EventHandler(_cmbOwner_SelectedIndexChanged);

            _txtSubject.DataBindings.Add(new Binding("Text", _appEdited, "Subject", false, DataSourceUpdateMode.OnPropertyChanged));
            _txtBody.DataBindings.Add(new Binding("Text", _appEdited, "Body", true, DataSourceUpdateMode.OnPropertyChanged));
			
			// bind _cmbLocations to the available locations
			_cmbLocation.DataSource = Locations;
			// you can remove the previous line of code and uncomment the next line
			// if you use C1Schedule build 184 or later
			// _cmbLocation.DataSource = _scheduler.Locations; 

			_cmbLocation.DataBindings.Add(new Binding("Text", _appEdited, "Location"));

			if (_appEdited.RecurrenceState != RecurrenceStateEnum.Master)
			{
				// Note: don't set DateTime related bindings for master appointments

				Binding allDay = new Binding("Checked", _appEdited, "AllDayEvent", true, DataSourceUpdateMode.OnPropertyChanged);
				_chkAllDay.DataBindings.Add(allDay);
				allDay.BindingComplete += delegate
				{
					// update window title and DateTime controls
					MakeTitle();
					bool needUpdate = false;
					if (_appEdited.AllDayEvent)
					{
						needUpdate = _dpStartTime.Visible;
						_dpStartTime.Visible = _dpEndTime.Visible = false;
					}
					else
					{
						needUpdate = !_dpStartTime.Visible;
						_dpStartTime.Visible = _dpEndTime.Visible = true;
						if (_appEdited.Start.TimeOfDay == TimeSpan.Zero && _appEdited.Duration.TotalDays >= 1)
						{
							needUpdate = true;
							// initialize times to some default values
							_appEdited.Start = _appEdited.Start.Add(_defaultStart);
							_appEdited.Duration = _defaultDuration;
						}
					}
					if (needUpdate)
					{
						UpdateAppointmentEndControls();
					}
				};
				Binding start = new Binding("Value", _appEdited, "Start", true, DataSourceUpdateMode.OnPropertyChanged);
				_dpStartDate.DataBindings.Add(start);
				start = new Binding("Value", _appEdited, "Start", true, DataSourceUpdateMode.OnPropertyChanged);
				_dpStartTime.DataBindings.Add(start);
				start.BindingComplete += delegate
				{
					UpdateAppointmentEndControls();
				};
				_dpEndTime.DataBindings.Add(new Binding("Value", _dpEndDate, "Value", false, DataSourceUpdateMode.OnPropertyChanged));
			}

			foreach (Category cat in _scheduler.DataStorage.CategoryStorage.Categories)
			{
				int index = _lstCategories.Items.Add(cat);
				_lstCategories.SetItemChecked(index, _appEdited.Categories.Contains(cat));
			}
			foreach (Resource res in _scheduler.DataStorage.ResourceStorage.Resources)
			{
				int index = _lstResources.Items.Add(res);
				_lstResources.SetItemChecked(index, _appEdited.Resources.Contains(res));
			}
			foreach (Contact cnt in _scheduler.DataStorage.ContactStorage.Contacts)
			{
				int index = _lstClients.Items.Add(cnt);
				_lstClients.SetItemChecked(index, _appEdited.Links.Contains(cnt));
			}

			_btnPreview.Enabled = _scheduler.PrintInfo.IsPreviewEnabled;
			_btnPrint.Enabled = _scheduler.PrintInfo.IsPrintingEnabled;

            SetCurrentZoom();
			MakeTitle();
			UpdateRecurrenceControls();
			UpdateAppointmentEndControls();
        }
		#endregion

		#region ** public interface
		/// <summary>
		/// The <see cref="C1.C1Schedule.Appointment"/> object which is currently edited with the form.
		/// </summary>
		public Appointment Appointment
		{
			get;
			private set;
		}
		#endregion

		#region ** Actions
		private void _rbSaveClose_Click(object sender, EventArgs e)
		{
			// copy all changes to the initial appointment and close the form
			SaveAppointment();
			Close();
		}
		private void _rbDelete_Click(object sender, EventArgs e)
		{
			Appointment.Delete();
			Close();
		}
		protected override void OnClosing(CancelEventArgs e)
		{
			_cmbStatus.SelectedValueChanged -= new EventHandler(_cmbStatus_SelectedValueChanged);
			_cmbLabel.SelectedValueChanged -= new EventHandler(_cmbLabel_SelectedValueChanged);
			_cmbReminder.SelectedIndexChanged -= new EventHandler(_cmbReminder_SelectedIndexChanged);
			if (_saved)
			{
				DialogResult = DialogResult.OK;
			}
			base.OnClosing(e);
		}
		bool _saving = false;
		private void _btnSaveAs_Click(object sender, EventArgs e)
		{
			try
			{
				if (_saving)
				{
					return;
				}
				_saving = true;
				SaveAppointment();

				_scheduler.Export(Appointment,
					C1.Win.C1Schedule.Localization.Strings.AppointmentFormStrings.Item("SaveAppointment", _scheduler.CalendarInfo.CultureInfo));
			}
			finally
			{
				_saving = false;
			}
		}
		private void _btnPrint_Click(object sender, EventArgs e)
		{
			SaveAppointment();
			_scheduler.PrintInfo.Print(Appointment);
		}
		private void _btnPreview_Click(object sender, EventArgs e)
		{
			SaveAppointment();
			_scheduler.PrintInfo.Preview(Appointment);
		}
		bool _saved = false;
		private void SaveAppointment()
		{
            // save all changes into initial appointment
			Appointment.BeginEdit();
			Appointment.CopyFrom(_appEdited, false);
			Appointment.EndEdit();
            if (!_scheduler.DataStorage.AppointmentStorage.Appointments.Contains(Appointment))
            {
                _scheduler.DataStorage.AppointmentStorage.Appointments.Add(Appointment);
            }
            _saved = true;
		}
		#endregion

		#region ** misc event handlers
		private void AppointmentForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			if (e.KeyChar == 13 && !_txtBody.Focused)
			{
				SendKeys.Send("{TAB}");
			}
			else if (e.KeyChar == 27)
			{
				Close();
			}
		}
		private void _txtBody_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		#endregion

		#region ** recurrence handling
		private void UpdateRecurrenceControls()
		{
			switch (_appEdited.RecurrenceState)
			{
				case RecurrenceStateEnum.Master:
					_pnPattern.Visible = true;
					_lblPattern.Text = _appEdited.GetRecurrencePattern().GetDescription(_scheduler.CalendarInfo);
					_pnTime.Visible = false;
					_btnRecurrence.Pressed = true;
					break;
				default:
					_pnPattern.Visible = false;
					_pnTime.Visible = true;
					_btnRecurrence.Pressed = false;
					break;
			}
		}
		#endregion

		#region ** form title handling
		private void MakeTitle()
		{
			Text = _scheduler.GroupItems[_appEdited.Owner].DisplayName + ": ";
			// update dialog title according to the appointment properties
			if (!string.IsNullOrEmpty(_txtSubject.Text))
			{
				Text += _txtSubject.Text;
			}
			else
			{
				Text += "Untitled";
			}
			if (_appEdited.AllDayEvent)
			{
				Text += " - " + "Event";
			}
			else
			{
				Text += " - " + "Appointment";
			}
		}
		private void _txtSubject_TextChanged(object sender, EventArgs e)
		{
			MakeTitle();
		}
		#endregion

		#region ** Assignments
		private void _cmbOwner_SelectedIndexChanged(object sender, EventArgs e)
		{
			_appEdited.Owner = (Contact)_cmbOwner.SelectedItem;
			MakeTitle();
		}
		private void _lstCategories_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			Category cat = (Category)_lstCategories.Items[e.Index];
			if (e.NewValue == CheckState.Checked)
			{
				int index = e.Index;
				if (!_scheduler.Settings.AllowCategoriesMultiSelection)
				{
					for (int i = 0; i < _lstCategories.Items.Count; i++)
					{
						if (i != index)
						{
							_lstCategories.SetItemChecked(i, false);
						}
					}
				}
				if (!_appEdited.Categories.Contains(cat))
				{
					_appEdited.Categories.Add(cat);
				}
			}
			else
			{
				_appEdited.Categories.Remove(cat);
			}
		}
		private void _lstResources_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			Resource res = (Resource)_lstResources.Items[e.Index];
			if (e.NewValue == CheckState.Checked)
			{
				int index = e.Index;
				if (!_scheduler.Settings.AllowResourcesMultiSelection)
				{
					for (int i = 0; i < _lstResources.Items.Count; i++)
					{
						if (i != index)
						{
							_lstResources.SetItemChecked(i, false);
						}
					}
				}
				if (!_appEdited.Resources.Contains(res))
				{
					_appEdited.Resources.Add(res);
				}
			}
			else
			{
				_appEdited.Resources.Remove(res);
			}
		}
		private void _lstClients_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			Contact cnt = (Contact)_lstClients.Items[e.Index];
			if (e.NewValue == CheckState.Checked)
			{
				int index = e.Index;
				if (!_scheduler.Settings.AllowContactsMultiSelection)
				{
					for (int i = 0; i < _lstClients.Items.Count; i++)
					{
						if (i != index)
						{
							_lstClients.SetItemChecked(i, false);
						}
					}
				}
				if (!_appEdited.Links.Contains(cnt))
				{
					_appEdited.Links.Add(cnt);
				}
			}
			else
			{
				_appEdited.Links.Remove(cnt);
			}
		}
		#endregion

		#region ** DateTime properties handling
		private void UpdateAppointmentEndControls()
		{
			DateTime end = _appEdited.End;
			_dpEndDate.MinDate = _dpEndTime.MinDate = _appEdited.Start;
			if (_appEdited.AllDayEvent)
			{
				end = end.AddDays(-1);
			}
			_dpEndTime.Value = _dpEndDate.Value = end; 
		}
		private void _dpEndDate_ValueChanged(object sender, EventArgs e)
		{
			DateTime end = _dpEndDate.Value;
			if (_appEdited.AllDayEvent)
			{
				end = end.AddDays(1);
			}
			_appEdited.End = end;
			UpdateAppointmentEndControls();
		}
		#endregion

		#region ** Tags
		private void _cmbLabel_SelectedValueChanged(object sender, EventArgs e)
		{
			_appEdited.Label = (C1.C1Schedule.Label)_cmbLabel.SelectedItem;
		}
		private void _togglePrivate_Click(object sender, EventArgs e)
		{
			_appEdited.Private = _togglePrivate.Pressed;
		}
		private void _toggleHighImportance_Click(object sender, EventArgs e)
		{
			if (_toggleHighImportance.Pressed)
			{
				_toggleLowImportance.Pressed = false;
				_appEdited.Importance = ImportanceEnum.High;
			}
			else if (_toggleLowImportance.Pressed == false)
			{
				_appEdited.Importance = ImportanceEnum.Normal;
			}
		}
		private void _toggleLowImportance_Click(object sender, EventArgs e)
		{
			if (_toggleLowImportance.Pressed)
			{
				_toggleHighImportance.Pressed = false;
				_appEdited.Importance = ImportanceEnum.Low;
			}
			else if (_toggleHighImportance.Pressed == false)
			{
				_appEdited.Importance = ImportanceEnum.Normal;
			}
		}
		#endregion

		#region ** Options
		private void _btnRecurrence_Click(object sender, EventArgs e)
		{
			bool isNew = _appEdited.RecurrenceState == RecurrenceStateEnum.NotRecurring;
			RecurrencePattern pattern = _appEdited.GetRecurrencePattern();
			if (pattern.ParentAppointment != _appEdited)
			{
				// if current appointment is occurrence,
				// then switch to the master appointment
				Appointment.CancelEdit();
				Appointment = pattern.ParentAppointment;
				_appEdited = pattern.ParentAppointment.Copy();
				_appEdited.BeginEdit();
				pattern = _appEdited.GetRecurrencePattern();
				this.Initialize();
			}
			RecurrenceForm form = new RecurrenceForm(_scheduler, pattern, isNew);
			form.ShowDialog(this);
			if (form.DialogResult == DialogResult.OK)
			{
				// update master appointment properties from pattern
                _appEdited.Duration = pattern.Duration;
                _appEdited.Start = pattern.StartTime;
			}
			else if (isNew)
			{
				// clear pattern back
				_appEdited.ClearRecurrencePattern();
			}
			// initialize again
			Initialize();
		}

		private void _cmb_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			ComboBox cmb = sender as ComboBox;
			if (cmb != null)
			{
				BaseObject bo = cmb.Items[e.Index] as BaseObject;

				e.DrawBackground();

				using (Pen pen = new Pen(Color.Black, 1))
				{
					e.Graphics.DrawRectangle(pen, e.Bounds.X + 2, e.Bounds.Y + 2,
											e.Bounds.Height - 4, e.Bounds.Height - 4);
				}
				e.Graphics.FillRectangle(bo.Brush.Brush, e.Bounds.X + 3, e.Bounds.Y + 3, e.Bounds.Height - 5, e.Bounds.Height - 5);

				// draw the current item text based on the current Font
				using (Brush brush = new SolidBrush(e.ForeColor))
				{
					e.Graphics.DrawString(bo.ToString(), e.Font, brush, e.Bounds.X + e.Bounds.Height, e.Bounds.Y);
				}
				// if the ListBox has focus, draw a focus rectangle around the selected item
				e.DrawFocusRectangle();
			}
		}

		private void _cmbStatus_SelectedValueChanged(object sender, EventArgs e)
		{
			_appEdited.BusyStatus = (Status)_cmbStatus.SelectedItem;
		}

		private void FillReminders()
		{
            _cmbReminder.SelectedIndexChanged -= new EventHandler(_cmbReminder_SelectedIndexChanged);
            _cmbReminder.Items.Clear();
			AddReminderItem("None", null);
			AddReminderItem("0 minutes", TimeSpan.Zero);
			AddReminderItem("5 minutes", TimeSpan.FromMinutes(5));
			AddReminderItem("10 minutes", TimeSpan.FromMinutes(10));
			AddReminderItem("15 minutes", TimeSpan.FromMinutes(15));
			AddReminderItem("30 minutes", TimeSpan.FromMinutes(30));
			AddReminderItem("1 hour", TimeSpan.FromHours(1));
			AddReminderItem("2 hours", TimeSpan.FromHours(2));
			AddReminderItem("3 hours", TimeSpan.FromHours(3));
			AddReminderItem("4 hours", TimeSpan.FromHours(4));
			AddReminderItem("5 hours", TimeSpan.FromHours(5));
			AddReminderItem("6 hours", TimeSpan.FromHours(6));
			AddReminderItem("7 hours", TimeSpan.FromHours(7));
			AddReminderItem("8 hours", TimeSpan.FromHours(8));
			AddReminderItem("9 hours", TimeSpan.FromHours(9));
			AddReminderItem("10 hours", TimeSpan.FromHours(10));
			AddReminderItem("11 hours", TimeSpan.FromHours(11));
			AddReminderItem("12 hours", TimeSpan.FromHours(12));
			AddReminderItem("18 hours", TimeSpan.FromHours(18));
			AddReminderItem("1 day", TimeSpan.FromDays(1));
			AddReminderItem("2 days", TimeSpan.FromDays(2));
			AddReminderItem("3 days", TimeSpan.FromDays(3));
			AddReminderItem("4 days", TimeSpan.FromDays(4));
			AddReminderItem("1 week", TimeSpan.FromDays(7));
			AddReminderItem("2 weeks", TimeSpan.FromDays(14));
			_cmbReminder.SelectedIndex = 0;
			if (_appEdited.ReminderSet)
			{
				for (int i = 1; i < _cmbReminder.Items.Count; i++)
				{
					if ((TimeSpan)_cmbReminder.Items[i].Tag == _appEdited.ReminderTimeBeforeStart)
					{
						_cmbReminder.SelectedIndex = i;
						break;
					}
				}
			}
			_cmbReminder.SelectedIndexChanged += new EventHandler(_cmbReminder_SelectedIndexChanged);
		}
		private void AddReminderItem(string text, object tag)
		{
			RibbonButton btn = new RibbonButton(text);
			btn.Tag = tag;
			_cmbReminder.Items.Add(btn);
		}
		void _cmbReminder_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_cmbReminder.SelectedIndex == 0)
			{
				_appEdited.ReminderSet = false;
			}
			else
			{
				_appEdited.ReminderSet = true;
				_appEdited.ReminderTimeBeforeStart = (TimeSpan)_cmbReminder.SelectedItem.Tag;
			}
		}
		#endregion

		#region ** Zoom
		private void InitZoom()
		{
            _galleryZoom.Items.Clear();
            for (int i = 75; i <= 150; i += 25)
			{
				_galleryZoom.Items.Add(i.ToString() + " %");
			}
			_galleryZoom.Items.Add("200 %");
			_galleryZoom.Items.Add("400 %");
        }
        private void SetCurrentZoom()
        {
            if (this.Created)
            {
                // initialize zoom here, at earlier initialization it might be lost for empty RichTextBox
                string currentZoom = ((int)(ZoomFactor * 100)).ToString();
                foreach (RibbonGalleryItem item in _galleryZoom.Items)
                {
                    if (item.Text.StartsWith(currentZoom))
                    {
                        _galleryZoom.SelectedIndex = _galleryZoom.Items.IndexOf(item);
                        break;
                    }
                }
            }
        }
		private void _txtBody_Enter(object sender, EventArgs e)
		{
			_galleryZoom.Enabled = true;
		}
		private void _galleryZoom_SelectedIndexChanged(object sender, EventArgs e)
		{
			int factor = int.Parse(_galleryZoom.SelectedItem.Text.Substring(0, _galleryZoom.SelectedItem.Text.Length - 2));
			ZoomFactor = _txtBody.ZoomFactor = (float)factor / 100;
		}
		#endregion
	}
}
