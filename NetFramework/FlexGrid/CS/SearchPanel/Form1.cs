using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SearchPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataSource();
            SetupGrid();
        }

        private void BindDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("First Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Birthdate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Salary", typeof(double)));

            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 1, "John", "Smith", new DateTime(1964, 04, 19), 1000 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 2, "Jane", "Smith", new DateTime(1973, 12, 23), 500 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 3, "John Jr", "Anderson", new DateTime(1995, 10, 11), 300 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 4, "Aaron", "Acker", new DateTime(1951, 3, 27), 5500 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 5, "Britney", "Fox", new DateTime(2000, 1, 1), 3000 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 6, "Eliza", "Dooley", new DateTime(1961, 9, 2), 1200 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 7, "Cindy", "Chen", new DateTime(1986, 12, 1), 300 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 8, "Bruce", "Andrews", new DateTime(1957, 1, 31), 200 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 9, "Melanie", "Garrett", new DateTime(1925, 5, 24), 2995 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 10, "Lucy", "Hill", new DateTime(1996, 2, 29), 1549 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 11, "Craig", "Parker", new DateTime(1988, 5, 27), 166.37 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 12, "Emily", "Parker", new DateTime(1964, 7, 26), 2016 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 13, "Michael", "Osborne", new DateTime(1969, 4, 11), 10000 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 14, "Winston", "Stone", new DateTime(1992, 6, 13), 1285 };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 15, "Avril", "Marlow", new DateTime(1993, 10, 21), 700 };

            dt.Rows.Add(dr);

            c1FlexGrid1.DataSource = dt;
        }

        private void SetupGrid()
        {
            c1FlexGrid1.Cols["Salary"].Format = "c2";
        }
    }
}
