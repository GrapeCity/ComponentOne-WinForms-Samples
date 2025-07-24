using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            labelWaiting.Visible = true;
            labelWaiting.BringToFront();
            labelWaiting.Refresh();

            await Task.Run(() =>
            {
                try
                {
                    string connectionString = @"Data Source=http://ssrs.componentone.com/OLAP/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional";
                    string cubeName = "Adventure Works";

                    // Cross-thread safe invocation for UI work
                    this.Invoke((MethodInvoker)(() =>
                    {
                        c1FlexPivotPage1.FlexPivotPanel.ConnectCube(cubeName, connectionString);

                        var fp = c1FlexPivotPage1.PivotEngine;
                        fp.BeginUpdate();
                        fp.ColumnFields.Add("Date.Fiscal Year");
                        fp.RowFields.Add("Category");
                        fp.ValueFields.Add("Internet Revenue Trend");
                        fp.ValueFields.Add("Internet Revenue Status");
                        fp.EndUpdate();
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)(() => MessageBox.Show(ex.Message)));
                }
            });

            // Hide loading UI
            labelWaiting.Visible = false;
            progressBar1.Visible = false;
        }
    }
}
