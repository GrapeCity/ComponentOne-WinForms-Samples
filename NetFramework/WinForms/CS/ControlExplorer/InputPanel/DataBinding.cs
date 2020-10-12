using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.InputPanel
{
    public partial class DataBinding : C1DemoForm
    {
        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Employees' table.
            this.employeesTableAdapter.Fill(this.c1DemoDataSet.Employees);
        }

        private void cbReportsTo_Format(object sender, ListControlConvertEventArgs e)
        {
            PropertyDescriptor pd = TypeDescriptor.GetProperties(e.ListItem)["FirstName"];
            if (pd != null)
            {
                object firstName = pd.GetValue(e.ListItem);
                if (firstName is string && e.Value is string)
                {
                    e.Value = (string)firstName + " " + (string)e.Value;
                }
            }
        }
    }
}
