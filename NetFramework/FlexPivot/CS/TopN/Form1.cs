using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.FlexPivot;
using C1.Win.FlexPivot;

namespace TopN
{
    public partial class Form1 : Form
    {
        C1FlexPivotEngine _engine;

        public Form1()
        {
            InitializeComponent();
            // get data
            var da = new OleDbDataAdapter("select * from [Sales By Category]", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind to data source
            var panel = new C1FlexPivotPanel();
            panel.DataSource = dt;
            c1FlexPivotGrid1.DataSource = panel;

            // initialize view
            _engine = panel.FlexPivotEngine;
            _engine.RowFields.Add("ProductName");
            _engine.ColumnFields.Add("CategoryName");
            _engine.ValueFields.Add("ProductSales");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var filter = _engine.RowFields["ProductName"].Filter;
            if (sender == radioButton1)
                filter.TopN = 0;
            else
            {
                filter.TopN = 3;
                if (sender == radioButton2)
                    filter.TopNRule = TopNRule.TopN;
                else
                    filter.TopNRule = TopNRule.BottomN;
            }
        }

        // get connection string to sample database
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

    }
}
