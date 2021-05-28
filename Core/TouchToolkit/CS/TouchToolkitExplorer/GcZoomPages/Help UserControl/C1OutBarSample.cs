using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public partial class C1OutBarSample : UserControl
    {
        public C1OutBarSample()
        {
            InitializeComponent();
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            groupBox1.Text = e.Command.Text;
        }

        private void C1OutBar_Load(object sender, EventArgs e)
        {
            c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(new C1.C1Schedule.Appointment(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0), new TimeSpan(2, 0, 0), "Meeting with Craig"));
        }
    }
}
