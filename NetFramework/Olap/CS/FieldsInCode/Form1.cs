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

            // bind to olap page
            this.c1OlapPage1.DataSource = dt;

            // build view
            var olap = this.c1OlapPage1.OlapEngine;
            olap.ValueFields.Add("ExtendedPrice");
            olap.RowFields.Add("OrderDate", "ProductName");

            // format order date and extended price
            var field = olap.Fields["OrderDate"];
            field.Format = "yyyy";
            field = olap.Fields["ExtendedPrice"];
            field.Format = "c";

            // show average price (instead of sum)
            field = olap.Fields["ExtendedPrice"];
            field.Subtotal = C1.Olap.Subtotal.Average;

            // apply value filter to show only a few products
            C1.Olap.C1OlapFilter filter = olap.Fields["ProductName"].Filter;
            filter.Clear();
            filter.ShowValues = "Chai,Chang,Geitost,Ikura".Split(',');

            // apply range filter to show only some dates
            filter = olap.Fields["OrderDate"].Filter;
            filter.Clear();
            filter.Condition1.Operator = C1.Olap.ConditionOperator.GreaterThanOrEqualTo;
            filter.Condition1.Parameter = new DateTime(1996, 1, 1);
            filter.Condition2.Operator = C1.Olap.ConditionOperator.LessThanOrEqualTo;
            filter.Condition2.Parameter = new DateTime(1996, 12, 31);
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
