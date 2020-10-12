using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackgroundLoader
{
    public partial class Form1 : Form
    {
        DataTable _dt = new DataTable();
        List<DataRow> _newRows = new List<DataRow>();

        public Form1()
        {
            InitializeComponent();

            // create empty table
            for (int i = 0; i < 20; i++)
            {
                _dt.Columns.Add(string.Format("col{0}", i), typeof(string));
            }

            // bind the grid to the empty table
            _flex.DataSource = _dt;

            // go load the data
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // create 500,000 rows
            for (int i = 0; i < 500000; i++)
            {
                var row = _dt.NewRow();
                for (int j = 0; j < _dt.Columns.Count; j++)
                {
                    row[j] = string.Format("{0}", i + j);
                }
                _newRows.Add(row);

                // inform progress at every 50 rows
                if ((i+1) % 50 == 0)
                {
                    backgroundWorker1.ReportProgress(0);

                    // simulate lengthy operation
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // add new rows to data table
            _dt.BeginLoadData();
            for (int i = 0; i < _newRows.Count; i++)
            {
                _dt.Rows.Add(_newRows[i]);
            }
            _dt.EndLoadData();

            // done with this batch
            _newRows.Clear();

            // update UI
            _lblStatus.Text = string.Format("{0} Rows loaded...", _dt.Rows.Count);
            Application.DoEvents();
        }
    }
}
