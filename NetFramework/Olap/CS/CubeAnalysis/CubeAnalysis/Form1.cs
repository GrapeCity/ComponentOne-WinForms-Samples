using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CubeAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // prepare to build view 
            string connectionString = @"Data Source=http://c1db1.componentone.com/olap/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional-EE";

            string cubeName = "Adventure Works";
            try
            {
                c1OlapPage1.OlapPanel.ConnectCube(cubeName, connectionString);

                // show some data.
                var olap = c1OlapPage1.OlapEngine;
                olap.BeginUpdate();
                olap.ColumnFields.Add("Color");
                olap.RowFields.Add("Category");
                olap.ValueFields.Add("Order Count");
                olap.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            c1OlapPage1.OlapEngine.Updated += (s1, e) =>
            {
                progressBar1.Visible = false;
            };

            c1OlapPage1.OlapEngine.UpdateProgressChanged += (s1, e) =>
            {
                progressBar1.Visible = true;
                progressBar1.Value = (int)e.ProgressPercentage;
            };
        }
    }
}
