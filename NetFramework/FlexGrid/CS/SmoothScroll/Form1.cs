using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmoothScroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // designer initialization
            InitializeComponent();

            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);
            _smoothFlex.DataSource = dt;
            _smoothFlex.AutoSizeCols();
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
