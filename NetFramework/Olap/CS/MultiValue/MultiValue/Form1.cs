using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiValue
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

            // initialize view
            var def = Properties.Settings.Default.ViewDefinition;
            if (string.IsNullOrEmpty(def))
            {
                var olap = this.c1OlapPage1.OlapEngine;
                olap.RowFields.Add("ProductName");
                olap.ColumnFields.Add("Country");
                olap.ValueFields.MaxItems = 5;
                olap.ValueFields.Add("ExtendedPrice", "Freight");
            }
            else
            {
                this.c1OlapPage1.ViewDefinition = def;
            }
        }

        // save view when closing
        protected override void OnClosing(CancelEventArgs e)
        {
            var def = this.c1OlapPage1.ViewDefinition;
            Properties.Settings.Default.ViewDefinition = def;
            Properties.Settings.Default.Save();

            base.OnClosing(e);
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
