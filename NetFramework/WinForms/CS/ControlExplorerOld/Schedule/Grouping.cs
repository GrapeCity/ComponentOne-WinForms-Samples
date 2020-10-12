using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.C1Schedule;

namespace ControlExplorer.Schedule
{
    public partial class Grouping : C1DemoForm
    {
        public Grouping()
        {
            InitializeComponent();
            
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            if (e.Command == c1Command_Day)
            {
                //switch to day view
                c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
                c1Command_Month.Checked = false;
                c1Command_Week.Checked = false;
                c1Command_Day.Checked = true;
                c1Command_FullWeek.Checked = false;
                c1Command_TimeLine.Checked = false;
            }
            else if (e.Command == c1Command_Week)
            {
                //switch to work week view
                c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
                c1Command_Month.Checked = false;
                c1Command_Week.Checked = true;
                c1Command_Day.Checked = false;
                c1Command_FullWeek.Checked = false;
                c1Command_TimeLine.Checked = false;
            }
            else if (e.Command == c1Command_FullWeek)
            {
                //switch to full week view
                c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView;
                c1Command_Month.Checked = false;
                c1Command_Week.Checked = false;
                c1Command_Day.Checked = false;
                c1Command_FullWeek.Checked = true;
                c1Command_TimeLine.Checked = false;
            }
            else if (e.Command == c1Command_Month)
            {
                //switch to month view
                c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
                c1Command_Month.Checked = true;
                c1Command_Week.Checked = false;
                c1Command_Day.Checked = false;
                c1Command_FullWeek.Checked = false;
                c1Command_TimeLine.Checked = false;
            }
            else if (e.Command == c1Command_TimeLine)
            {
                //switch to month view
                c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.TimeLineView;
                c1Command_Month.Checked = false;
                c1Command_Week.Checked = false;
                c1Command_Day.Checked = false;
                c1Command_FullWeek.Checked = false;
                c1Command_TimeLine.Checked = true;
            }
            else if (e.Command == c1Command_GroupNone)
            {
                //turn off grouping
                c1Schedule1.GroupBy = "";
                c1Command_GroupNone.Checked = true;
                c1Command_GroupContact.Checked = false;
                c1Command_GroupCategory.Checked = false;
                c1Command_GroupResource.Checked = false;
            }
            else if (e.Command == c1Command_GroupCategory)
            {
                //group by category
                c1Schedule1.GroupBy = "Category";
                c1Command_GroupNone.Checked = false;
                c1Command_GroupContact.Checked = false;
                c1Command_GroupCategory.Checked = true;
                c1Command_GroupResource.Checked = false;
            }
            else if (e.Command == c1Command_GroupContact)
            {
                //group by contact
                c1Schedule1.GroupBy = "Contact";
                c1Command_GroupNone.Checked = false;
                c1Command_GroupContact.Checked = true;
                c1Command_GroupCategory.Checked = false;
                c1Command_GroupResource.Checked = false;
            }
            else if (e.Command == c1Command_GroupResource)
            {
                //group by resource
                c1Schedule1.GroupBy = "Resource";
                c1Command_GroupNone.Checked = false;
                c1Command_GroupContact.Checked = false;
                c1Command_GroupCategory.Checked = false;
                c1Command_GroupResource.Checked = true;
            }
        }

        Random rnd = new Random();
        string[] subjects = new string[] { "Design Meeting", "Lunch with VP", "Conference call", "Business Proposal", "Working from home", "SharePoint Webcast", "Marketing meeting", "Sales meeting", "Case study", "Financial Planning", "Brainstorming session", "Peer-2-Peer review", "Sandusky Event Planning", "Yearly goals review" };
        string[] locations = new string[] { "Sandusky office", "Pittsburgh office", "San Diego office", "Conference room", "Office" };
        int[] durations = new int[] { 60, 60, 90, 120 };

        void CreateSampleData(int nAppts)
        {
            CreateContacts();
            CreateResources();
            for (int i = 0; i < nAppts; i++)
            {
                Appointment ap = new Appointment();
                ap.Subject = subjects[rnd.Next(0, subjects.Length - 1)];
                ap.Location = locations[rnd.Next(0, locations.Length - 1)];
                ap.Start = DateTime.Now.AddDays(rnd.Next(-3, 3)).AddHours(rnd.Next(-4, 4));
                ap.End = ap.Start.AddMinutes(durations[rnd.Next(0, durations.Length - 1)]);
                c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(ap);
                ap.Label = c1Schedule1.DataStorage.LabelStorage.Labels[rnd.Next(0, c1Schedule1.DataStorage.LabelStorage.Labels.Count - 1)];
                ap.Resources.Add((Resource)c1Schedule1.DataStorage.ResourceStorage.Resources[rnd.Next(0, c1Schedule1.DataStorage.ResourceStorage.Resources.Count - 1)]);
                ap.Categories.Add((Category)c1Schedule1.DataStorage.CategoryStorage.Categories[rnd.Next(0, c1Schedule1.DataStorage.CategoryStorage.Categories.Count - 1)]);
                ap.Links.Add((Contact)c1Schedule1.DataStorage.ContactStorage.Contacts[rnd.Next(0, c1Schedule1.DataStorage.ContactStorage.Contacts.Count - 1)]);
            }
        }

        void CreateContacts()
        {
            c1Schedule1.DataStorage.ContactStorage.Contacts.Add(new Contact() { Text = "Matthew Longworthy" });
            c1Schedule1.DataStorage.ContactStorage.Contacts.Add(new Contact() { Text = "Althea Seamons"});
            c1Schedule1.DataStorage.ContactStorage.Contacts.Add(new Contact() { Text = "Charlene Hart"});
            c1Schedule1.DataStorage.ContactStorage.Contacts.Add(new Contact() { Text = "Jessie Wantz"});
            c1Schedule1.DataStorage.ContactStorage.Contacts.Add(new Contact() { Text = "Amie McCardle" });
        }

        void CreateResources()
        {
            c1Schedule1.DataStorage.ResourceStorage.Resources.Add(new Resource() { Text = "Room 1" });
            c1Schedule1.DataStorage.ResourceStorage.Resources.Add(new Resource() { Text = "Room 2"});
            c1Schedule1.DataStorage.ResourceStorage.Resources.Add(new Resource() { Text = "Room 3" });

        }

        private void Grouping_Load(object sender, EventArgs e)
        {
            CreateSampleData(40);
            c1Schedule1.GroupBy = "Contact";
            c1Schedule1.Settings.FirstVisibleTime = DateTime.Now.TimeOfDay.Subtract(new TimeSpan(4, 0, 0));

            // add demo properties
            AddProperty("GroupPageSize", c1Schedule1);
            AddProperty("ShowEmptyGroupItem", c1Schedule1);
        }

    }
}
