using C1.C1Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.Schedule
{
    public partial class TableView : C1DemoForm
    {
        public TableView()
        {
            InitializeComponent();
            this.c1Schedule1.DataStorage.Import(AppDomain.CurrentDomain.BaseDirectory + "Schedule\\C1Schedule.xml", FileFormatEnum.XML);
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            btnActiveView.Checked = false;
            btnCalendarView.Checked = false;
            this.panel1.Visible = false;
            this.c1TableView1.Active = false;
            this.c1TableView1.Visible = true;
        }

        private void btnCalendarView_Click(object sender, EventArgs e)
        {
            btnActiveView.Checked = false;
            btnTableView.Checked = false;
            this.panel1.Visible = true;
            this.c1TableView1.Visible = false;
        }

        private void btnActiveView_Click(object sender, EventArgs e)
        {
            btnTableView.Checked = false;
            btnCalendarView.Checked = false;
            this.panel1.Visible = false;
            this.c1TableView1.Active = true;
            this.c1TableView1.Visible = true;
        }
    }
}
