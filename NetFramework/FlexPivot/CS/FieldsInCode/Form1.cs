using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterInCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get data
            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind to FlexPivot page
            this.c1FlexPivotPage1.DataSource = dt;

            // build view
            var fp = this.c1FlexPivotPage1.FlexPivotEngine;
            fp.ValueFields.Add("ExtendedPrice");
            fp.RowFields.Add("OrderDate", "ProductName");

            // format order date and extended price
            var field = fp.Fields["OrderDate"];
            field.Format = "yyyy";
            field = fp.Fields["ExtendedPrice"];
            field.Format = "c";

            // show average price (instead of sum)
            field = fp.Fields["ExtendedPrice"];
            field.Subtotal = C1.FlexPivot.Subtotal.Average;

            // apply value filter to show only a few products
            C1.FlexPivot.C1FlexPivotFilter filter = fp.Fields["ProductName"].Filter;
            filter.Clear();
            filter.ShowValues = "Chai,Chang,Geitost,Ikura".Split(',');

            // apply range filter to show only some dates
            filter = fp.Fields["OrderDate"].Filter;
            filter.Clear();
            filter.Condition1.Operator = C1.FlexPivot.ConditionOperator.GreaterThanOrEqualTo;
            filter.Condition1.Parameter = new DateTime(2014, 1, 1);
            filter.Condition2.Operator = C1.FlexPivot.ConditionOperator.LessThanOrEqualTo;
            filter.Condition2.Parameter = new DateTime(2014, 12, 31);
            filter.AndConditions = true;
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
