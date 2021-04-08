using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexPivotExplorer.Samples
{
    public partial class CubeAnalysis : UserControl
    {
        public CubeAnalysis()
        {
            InitializeComponent();
        }

        private void ShowFlexPivot(bool mode)
        {
            c1FlexPivotPage1.Visible = mode;
            lbWaiting.Visible = !mode;

            Refresh();
        }

        private void CubeAnalysis_Load(object sender, EventArgs e)
        {

            // prepare to build view 
            string connectionString = @"Data Source=http://ssrs.componentone.com/OLAP/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional";
            string cubeName = "Adventure Works";
            try
            {
                // show waiting
                ShowFlexPivot(false);

                // load data
                c1FlexPivotPage1.FlexPivotPanel.ConnectCube(cubeName, connectionString);

                // show flex pivot
                ShowFlexPivot(true);

                // show some data.
                var fp = c1FlexPivotPage1.FlexPivotEngine;
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

            c1FlexPivotPage1.FlexPivotEngine.Updated += (s1, e) =>
            {
                progressBar1.Visible = false;
            };

            c1FlexPivotPage1.FlexPivotEngine.UpdateProgressChanged += (s1, e) =>
            {
                progressBar1.Visible = true;
                progressBar1.Value = (int)e.ProgressPercentage;
            };
        }
    }
}
