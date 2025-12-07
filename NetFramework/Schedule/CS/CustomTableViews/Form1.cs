using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Schedule;
using C1.Win.Schedule.UI;
using C1.Schedule;
using System.Globalization;
using System.Threading;
using C1.Win.Ribbon;
using C1.Win.Themes;

namespace TableViews
{
    public partial class Form1 : C1RibbonForm
    {
        private const string USHolidaysFile = "US32Holidays.ics";
        private const string USHolidaysDownloadUri = "https://ics.calendarlabs.com/76/ef4c45ee/US_Holidays.ics";

        //----------------------------------------
        #region ** Initializing
        public Form1()
        {
            InitializeComponent();
            c1Schedule1.Settings.FirstVisibleTime = TimeSpan.FromHours(8);
            var themes = C1ThemeController.GetThemes();
            foreach (var theme in themes)
            {
                themeCombo.Items.Add(theme);
            }
            themeCombo.SelectedIndex = themeCombo.Items.IndexOf("Office365White");
            agendaViewType.SelectedIndex = 1;
        }

        // On form loading fill data adapters in order to load data from the database.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.appointeesTableAdapter1.Fill(c1NWindDataSet1.Appointees);
            this.appointmentsTableAdapter1.Fill(c1NWindDataSet1.Appointments);
            // set correct MenuCaption for contacts
            foreach (Contact cnt in c1Schedule1.DataStorage.ContactStorage.Contacts)
            {
                TableViews.C1NwindDataSet.AppointeesRow row = this.c1NWindDataSet1.Appointees.FindByEmployeeID((int)cnt.Key[0]);
                if (row != null)
                {
                    cnt.MenuCaption = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                }
            }
            // add US holidays from public calendar
            // use cached file if it already exists in working folder and not old
            if (!System.IO.File.Exists(USHolidaysFile) || DateTime.Today.Subtract(System.IO.File.GetCreationTime(USHolidaysFile)).TotalDays > 90)
            {
                // get newer version
                System.Net.WebClient webClient = new System.Net.WebClient();
                webClient.DownloadFile(USHolidaysDownloadUri, USHolidaysFile);
            }
            c1Schedule1.DataStorage.Import(USHolidaysFile, FileFormatEnum.iCal);

            this.workweekButton.Pressed = true;
        }

        // On form closing update data adapters in order to save data to the database.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
    //        int i = this.appointeesTableAdapter1.Update(c1NWindDataSet1.Appointees);
    //        int i1 = this.appointmentsTableAdapter1.Update(c1NWindDataSet1.Appointments);
        }
        #endregion

        //----------------------------------------
        #region ** Switching Views
        private void next7Button_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Show next 7 days.
            List<DateTime> days = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                days.Add(DateTime.Today.AddDays(i));
            }
            this.c1Schedule1.ShowDates(days.ToArray(), c1Schedule1.ViewType == ScheduleViewEnum.TimeLineView ? ScheduleViewEnum.TimeLineView : ScheduleViewEnum.DayView);
            this.dayButton.Pressed = true;
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Go to today date.
            this.c1Schedule1.GoToDate(DateTime.Today);
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Switch to the DayView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.DayView;
        }

        private void workweekButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Switch to the WorkWeekView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView;
        }

        private void weekButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Switch to the WeekView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.WeekView;
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Switch to the MonthView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.MonthView;
        }

        private void timelineButton_Click(object sender, EventArgs e)
        {
            HideTableView();
            // Switch to the TimeLineView.
            this.c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            // Show TableView
            ShowTableView(false);
        }
        private void activeButton_Click(object sender, EventArgs e)
        {
            // Show fitered Table View (active appointment only)
            ShowTableView(true);
        }

        private void HideTableView()
        {
            this.splitContainer1.Visible = true;
            this.tableView1.Visible = false;
            // update toggle buttons state
            listButton.Pressed = activeButton.Pressed = false;
        }

        private void ShowTableView(bool active)
        {
            this.splitContainer1.Visible = false;
            this.tableView1.Active = active;
            this.tableView1.Visible = true;
            // update toggle buttons state
            dayButton.Pressed = workweekButton.Pressed = weekButton.Pressed = monthButton.Pressed = timelineButton.Pressed = false;
        }
        #endregion

        //----------------------------------------
        #region ** Settings
        // change application theme
        private void themeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1.Win.Themes.C1ThemeController.ApplicationTheme = themeCombo.SelectedItem.Text;
        }

        // show/hide agenda
        private void agendaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !agendaCheckBox.Checked;
        }

        // change AgendaView.ViewType
        private void agendaViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (agendaViewType.SelectedIndex == 0)
            {
                this.agendaView1.ViewType = AgendaViewType.Today;
            }
            else if (agendaViewType.SelectedIndex == 1)
            {
                this.agendaView1.ViewType = AgendaViewType.Week;
            }
            else
            {
                this.agendaView1.ViewType = AgendaViewType.DateRange;
            }
        }
        #endregion

        //----------------------------------------
        #region ** Show/Hide contextual tab for Appointment editing
        // Only show contextual Appointment tab if some appointment is selected in the active view.
        private void c1Schedule1_SelectedAppointmentsChanged(object sender, SelectedAppointmentsChangedEventArgs e)
        {
            UpdateAppointmentTab();
        }
        private void tableView1_SelectedAppointmentsChanged(object sender, EventArgs e)
        {
            UpdateAppointmentTab();
        }
        private void agendaView1_SelectedAppointmentsChanged(object sender, EventArgs e)
        {
            UpdateAppointmentTab();
        }
        private void UpdateAppointmentTab()
        {
            Appointment app = null;
            if (tableView1.Visible && tableView1.Focused && tableView1.SelectedAppointments.Count > 0)
            {
                app = tableView1.SelectedAppointments[0];
            }
            else if (agendaView1.Focused)
            {
                if (agendaView1.SelectedAppointments.Count > 0)
                {
                    app = agendaView1.SelectedAppointments[0];
                }
            }
            else if (c1Schedule1.SelectedAppointments.Count > 0)
            {
                app = c1Schedule1.SelectedAppointments[0];
            }
            appointmentTab.Visible = contextualGroup.Visible = app != null;
            appointmentTab.Tag = app;
            if (app != null)
            {
                appointmentTab.Selected = true;
            }
        }
        #endregion

        //----------------------------------------
        #region ** Working with Appointments
        // create new appointment
        private void newAppButton_Click(object sender, EventArgs e)
        {
            this.c1Schedule1.CreateAppointment();
        }
        // open appointment for editing
        private void openAppButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if ( app != null)
            {
                c1Schedule1.EditAppointment(app);
            }
        }
        // delete appointment
        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if (app != null)
            {
                c1Schedule1.RemoveAppointment(app);
            }
        }
        // edit recurrence
        private void recButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if ( app != null)
            {
                c1Schedule1.EditRecurrence(app);
            }
        }
        // high importance
        private void highImportanceButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if (app != null)
            {
                app.Importance = highImportanceButton.Pressed ? ImportanceEnum.High : ImportanceEnum.Normal;
            }
        }
        // low importance
        private void lowImportanceButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if (app != null)
            {
                app.Importance = lowImportanceButton.Pressed ? ImportanceEnum.Low : ImportanceEnum.Normal;
            }
        }
        // private
        private void privateButton_Click(object sender, EventArgs e)
        {
            Appointment app = appointmentTab.Tag as Appointment;
            if (app != null)
            {
                app.Private = privateButton.Pressed;
            }
        }
        #endregion
    }
}