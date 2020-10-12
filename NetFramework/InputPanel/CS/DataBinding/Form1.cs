using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Switch to C1NWind.mdb database

            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                "\\ComponentOne Samples\\Common\\C1NWind.mdb";
            if (File.Exists(dbPath))
            {
                OleDbConnection conn = employeesTableAdapter.Connection;
                OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder(conn.ConnectionString);
                csb.DataSource = dbPath;
                conn.ConnectionString = csb.ToString();
            }

            #endregion

            employeesTableAdapter.Fill(nWINDDataSet.Employees);
        }

        private void inputDataNavigator1_SaveData(object sender, EventArgs e)
        {
            employeesTableAdapter.Update(nWINDDataSet.Employees);
        }

        private void inputDataNavigator1_ReloadData(object sender, EventArgs e)
        {
            employeesTableAdapter.Fill(nWINDDataSet.Employees);
        }

        private void inputComboBox1_Format(object sender, ListControlConvertEventArgs e)
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