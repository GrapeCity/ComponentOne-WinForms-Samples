using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Schedule;
using C1.C1Schedule;


namespace ControlExplorer.Schedule
{
    public partial class DragDrop : C1DemoForm
    {

        public DragDrop()
        {
            InitializeComponent();
        }

        private void DragDrop_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.AddItem("\tCreate planning document");
            c1FlexGrid1.AddItem("\tSales meeting");
            c1FlexGrid1.AddItem("\tFinish presentation");
            c1FlexGrid1.AddItem("\tStart ACM Training");
            c1FlexGrid1.AddItem("\tMeeting with product team");
            c1FlexGrid1.AddItem("\tAll-hands meeting");
            c1FlexGrid1.AddItem("\tBudget meeting");
            c1FlexGrid1.AddItem("\tAdvanced testing and debugging");
            c1FlexGrid1.AllowAddNew = true;

            Appointment ap1 = c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add();
            ap1.Location = "Small Meeting Room";
            ap1.Body = "Be there or be square";
            ap1.Subject = "Conference Call";
            ap1.Start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            ap1.End = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
            ap1.Label = c1Schedule1.DataStorage.LabelStorage.Labels[11];
        }

        private void c1Schedule1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(C1.C1Schedule.Appointment)))
            {
                Appointment app;
                app = (Appointment)e.Data.GetData(typeof(C1.C1Schedule.Appointment));
                //Data automatically gets set to appointment's Body text
                //Assign data to Subject text if empty
                if (string.IsNullOrEmpty(app.Subject))
                {
                    app.Subject = app.Body;
                }
            }
        }

        private void c1Schedule_MouseDown(object sender, MouseEventArgs e)
        {
            c1Calendar1.Schedule = (C1Schedule)sender;
        }

        private void c1Schedule1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            c1Calendar1.Schedule = c1Schedule2;
        }

        private void c1Schedule2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            c1Calendar1.Schedule = c1Schedule1;
        }
    }
}
