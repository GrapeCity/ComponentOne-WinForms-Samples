using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.C1Report;

namespace SimpleFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a list of 'myobject' to use as a report datasource
            List<myobject> mylist = new List<myobject>();
            mylist.Add(new myobject("Aaron", "674 Alcatraz", true));
            mylist.Add(new myobject("Joe", "123 Main", true));
            mylist.Add(new myobject("Mary", "456 Main", false));
            mylist.Add(new myobject("Dwayne", "789 Main", true));
            mylist.Add(new myobject("Debbie", "444 High", true));
            mylist.Add(new myobject("Paul", "555 High", false));

            // create custom data source
            CustomDataSource<myobject> mydatasource = new CustomDataSource<myobject>(mylist);

            // assign custom data source to report
            this.c1Report1.DataSource.Recordset = mydatasource;

            // create a simple report definition
            Rectangle rc = new Rectangle(0, 0, 1500, 250);
            Section detail = c1Report1.Sections.Detail;
            detail.Visible = true;
            detail.Height = 300;

            FieldCollection fields = detail.Fields;
            Field f = fields.Add("fname", "name", rc);
            f.Calculated = true;
            rc.Offset(rc.Width, 0);
            f = fields.Add("faddress", "address", rc);
            f.Calculated = true;
            rc.Offset(rc.Width, 0);
            f = fields.Add("factive", "active", rc);
            f.Calculated = true;
            f.CheckBox = CheckBoxEnum.CheckBox;

            // add a group in order to apply sorting
            Group g = c1Report1.Groups.Add("group1", "name", SortEnum.Ascending);
        }

        // show report in a PrintPreviewDialog
        private void ShowReport()
        {
            using (C1.Win.C1Preview.C1PrintPreviewDialog dlg = new C1.Win.C1Preview.C1PrintPreviewDialog())
            {
                dlg.Document = this.c1Report1;
                dlg.PreviewPane.ZoomFactor = 1;
                dlg.ShowDialog();
            }
        }

        // show any errors
        private void c1Report1_ReportError(object sender, ReportEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Handled = true;
        }

        // show report with no filter
        private void button1_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = string.Empty;
            ShowReport();
        }

        // show report with different filters
        private void button2_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = "active = true";
            ShowReport();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = "active = false";
            ShowReport();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = "name > \"E\"";
            ShowReport();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = "name < \"E\"";
            ShowReport();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.c1Report1.DataSource.Filter = this.textBox1.Text;
            ShowReport();
        }
    }

    // simple class with objects used in the report
    public class myobject
    {
        string _name, _address;
        bool _active;
        public myobject(string name, string address, bool active)
        {
            _name = name;
            _address = address;
            _active = active;
        }
        public string Name
        {
            get { return _name; }
        }
        public string Address
        {
            get { return _address; }
        }
        public bool Active
        {
            get { return _active; }
        }
    }
}