using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.MenusToolbars
{
    public partial class C1OutBar : C1DemoForm
    {
        public C1OutBar()
        {
            InitializeComponent();  
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            //update GroupBox to show selected command
            groupBox1.Text = e.Command.Text;
        }

        private void C1OutBar_Load(object sender, EventArgs e)
        {
            //fill schedule
            c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(new C1.C1Schedule.Appointment(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0), new TimeSpan(2, 0, 0), "Meeting with Craig"));
            
            //add demo properties
            AddProperty("Animate", c1OutBar1);
            AddProperty("PageTitleHeight", c1OutBar1);
            AddProperty("ShowScrollButtons", c1OutBar1);
        }
    }
}
