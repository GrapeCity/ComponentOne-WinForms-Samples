using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public partial class C1TrueDBGridSample : UserControl
    {
        public C1TrueDBGridSample()
        {
            InitializeComponent();
            this.c1TrueDBGrid1.DataSource = GetData();
        }


        private static DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("CustomerID", typeof(string)));
            table.Columns.Add(new DataColumn("CompanyName", typeof(string)));
            table.Columns.Add(new DataColumn("ContactName", typeof(string)));
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            return table;
        }
    }
}
