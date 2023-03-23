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
            string connectionString = @"Data Source=http://ssrs.componentone.com/OLAP/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional";
            string cubeName = "Adventure Works";
            try
            {
                c1FlexPivotPage1.FlexPivotPanel.ConnectCube(cubeName, connectionString);

                // show some data.
                var fp = c1FlexPivotPage1.PivotEngine;
                fp.BeginUpdate();
                fp.ColumnFields.Add("Date.Fiscal Year");
                fp.RowFields.Add("Category");
                fp.ValueFields.Add("Internet Revenue Trend");
                fp.ValueFields.Add("Internet Revenue Status");
                fp.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            c1FlexPivotPage1.PivotEngine.Updated += (s1, e) =>
            {
                progressBar1.Visible = false;
            };

            c1FlexPivotPage1.PivotEngine.UpdateProgressChanged += (s1, e) =>
            {
                progressBar1.Visible = true;
                progressBar1.Value = (int)e.ProgressPercentage;
            };
        }
    }
}
