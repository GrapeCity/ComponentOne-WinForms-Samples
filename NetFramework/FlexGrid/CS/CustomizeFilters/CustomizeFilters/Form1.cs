using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace CustomizeFilters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // bind grid to some data
            var dt = new DataTable();
            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            da.Fill(dt);
            _flex.DataSource = dt;

            // enable filtering
            _flex.AllowFiltering = true;

            // initialize "ShipRegion" column filter to show only two values: "AK" and "CA"
            var col = _flex.Cols["ShipRegion"];
            col.AllowFiltering = AllowFiltering.ByValue;
            var vf = col.Filter as ValueFilter;
            vf.ShowValues = new object[] { "AK", "CA" };

            // initialize "UnitPrice" column filter to show only values greater than $30
            col = _flex.Cols["UnitPrice"];
            col.AllowFiltering = AllowFiltering.ByCondition;
            var cf = col.Filter as ConditionFilter;
            cf.Condition1.Operator = ConditionOperator.GreaterThan;
            cf.Condition1.Parameter = 30;

            // apply both column filters to the data
            _flex.ApplyFilters();
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
