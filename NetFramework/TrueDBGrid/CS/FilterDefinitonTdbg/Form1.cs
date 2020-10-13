using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterDefinitionTdbg._2010
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
                OleDbConnection conn = customersTableAdapter.Connection;
                OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder(conn.ConnectionString);
                csb.DataSource = dbPath;
                conn.ConnectionString = csb.ToString();
            }
            #endregion

            this.customersTableAdapter.Fill(this.c1NWindDataSet.Customers);

        }

        void SaveCustomFilter()
        {
            System.IO.File.WriteAllText("custom.xml", this.c1TrueDBGrid1.Splits[0].FilterDefinition);
        }

        void ReadFilter(string name)
        {
            c1TrueDBGrid1.Splits[0].FilterDefinition = System.IO.File.ReadAllText(name + ".xml");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomFilter();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ReadFilter("empty");
        }

        private void btnUS_Click(object sender, EventArgs e)
        {
            ReadFilter("usa");
        }

        private void btnEU_Click(object sender, EventArgs e)
        {
            ReadFilter("eu");
        }

        private void btnNonUSOwners_Click(object sender, EventArgs e)
        {
            ReadFilter("nonusowners");
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            ReadFilter("custom");
        }
    }
}
