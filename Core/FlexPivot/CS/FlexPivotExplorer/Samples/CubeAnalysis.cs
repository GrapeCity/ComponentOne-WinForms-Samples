using System;
using System.Windows.Forms;

namespace FlexPivotExplorer.Samples
{
    public partial class CubeAnalysis : UserControl
    {
        private Timer _hideLabelTimer;

        public CubeAnalysis()
        {
            InitializeComponent();
        }

        private void HideLabelWaiting(bool mode)
        {
            if (!mode)
            {
                lbWaiting.Visible = false;
            }
            else
            {
                _hideLabelTimer = new Timer();
                _hideLabelTimer.Interval = 5000;
                _hideLabelTimer.Tick += (s, e) =>
                {
                    lbWaiting.Visible = false;
                    _hideLabelTimer.Stop();
                    _hideLabelTimer.Dispose();
                };

                _hideLabelTimer.Start();
            }
        }

        private void CubeAnalysis_Load(object sender, EventArgs e)
        {
            // prepare to build view 
            string connectionString = @"Data Source=http://ssrs.componentone.com/OLAP/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional";
            string cubeName = "Adventure Works";
            try
            {
                // load data
                c1FlexPivotPage1.FlexPivotPanel.ConnectCube(cubeName, connectionString);

                HideLabelWaiting(true);

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
