using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ControlExplorer.FlexGrid
{
    public partial class Performance : C1DemoForm
    {
        int count = 20000;
        List<MyItem> list = new List<MyItem>();
        BackgroundWorker worker = new BackgroundWorker();

        public Performance()
        {
            InitializeComponent();

            // set AutoResize to false for fastest load time
            c1FlexGrid1.AutoResize = false;

            // set background worker
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.WorkerReportsProgress = true;

            numericUpDown1.Maximum = int.MaxValue;
        }

        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            c1Command2.Enabled = false;

            // clear FlexGrid
            c1FlexGrid1.DataSource = null;
            c1FlexGrid1.Rows.Count = 1;
            c1FlexGrid1.Cols.Count = 1;

            count = (int)txtCount.Value;            
            progressBar.Maximum = count;

            // run background worker
            worker.RunWorkerAsync();  
        }

        #region Background worker

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();
            var list = new List<MyItem>(count);

            try
            {
                for (int i = 0; i < count; i++)
                {
                    // report progress periodically
                    if (i % 1000 == 0)
                    {
                        worker.ReportProgress(0, i);
                    }

                    MyItem m = new MyItem();
                    m.MyId = i;
                    m.MyName = "Row" + i.ToString();
                    m.MyBoolean = i % 2 == 0 ? true : false;
                    m.MyDate = DateTime.Now.Add(new TimeSpan(i, i, i));
                    m.MyValue1 = (double)rnd.Next(int.MaxValue);
                    m.MyValue2 = (double)rnd.Next(int.MaxValue);
                    m.MyValue3 = (double)rnd.Next(int.MaxValue);
                    m.MyValue4 = (double)rnd.Next(int.MaxValue);
                    m.MyValue5 = (double)rnd.Next(int.MaxValue);
                    m.MyValue6 = (double)rnd.Next(int.MaxValue);
                    list.Add(m);
                }
                worker.ReportProgress(0, count);
            }
            catch (OutOfMemoryException)
            {
                // system does not have enough memory to create the data source
                list.Clear();
            }
            e.Result = list;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var items = (IList)e.Result;
            if (items.Count == 0)
            {
                MessageBox.Show("Out of memory. Try a lower number of items.");
            }
            else
            {
                try
                {
                    // load flexgrid with redraw = false for best performance
                    c1FlexGrid1.Redraw = false;
                    c1FlexGrid1.DataSource = items;
                    c1FlexGrid1.Redraw = true;

                    // custom editors
                    c1FlexGrid1.Cols["MyDate"].Editor = dateTimePicker1;
                    c1FlexGrid1.Cols["MyValue1"].Editor = numericUpDown1;
                    c1FlexGrid1.Cols["MyValue2"].Editor = numericUpDown1;
                    c1FlexGrid1.Cols["MyValue3"].Editor = numericUpDown1;
                    c1FlexGrid1.Cols["MyValue4"].Editor = numericUpDown1;
                    c1FlexGrid1.Cols["MyValue5"].Editor = numericUpDown1;
                    c1FlexGrid1.Cols["MyValue6"].Editor = numericUpDown1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Out of memory. Try a lower number of items.");
                }
            }
            c1Command2.Enabled = true;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.UserState;
            lblStatus.Text = string.Format("{0} / {1} rows", ((int)e.UserState).ToString(), count.ToString());
        }

        #endregion

        private void Performance_Load(object sender, EventArgs e)
        {

        }
    }

    public class MyItem
    {
        public int MyId { get; set; }
        public string MyName { get; set; }
        public bool? MyBoolean { get; set; }
        public DateTime? MyDate { get; set; }
        public double? MyValue1 { get; set; }
        public double? MyValue2 { get; set; }
        public double? MyValue3 { get; set; }
        public double? MyValue4 { get; set; }
        public double? MyValue5 { get; set; }
        public double? MyValue6 { get; set; }
    }
}
