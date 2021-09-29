using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;
using System.Collections.ObjectModel;

namespace FlexChart101.Samples
{
    public partial class Dynamic : UserControl
    {
        const int NUMBER_OF_POINTS = 20;

        Timer _timer = new Timer();
        ObservableCollection<DataItem> data = new ObservableCollection<DataItem>();
        Random rnd = new Random();
        int _counter = 1;

        public Dynamic()
        {
            InitializeComponent();
            InitializeControls();

            _timer.Tick += timer_Tick;
            _timer.Interval = 1000;

            SetupChart();

            //Timer
            _timer.Start();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();

            // Add 3 data series
            var s1 = new Series();
            s1.Binding = s1.Name = "Trucks";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Binding = s2.Name = "Ships";
            flexChart1.Series.Add(s2);

            var s3 = new Series();
            s3.Binding = s3.Name = "Planes";
            flexChart1.Series.Add(s3);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Day";
            flexChart1.DataSource = data;
            flexChart1.ChartType = C1.Chart.ChartType.Area;
            flexChart1.Stacking = C1.Chart.Stacking.Stacked;

            flexChart1.EndUpdate();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            if (data.Count > NUMBER_OF_POINTS)
                data.RemoveAt(0);
            data.Add(new DataItem() 
            { 
                Day = _counter, 
                Trucks = rnd.Next(100),
                Ships = rnd.Next(100)/2,
                Planes = rnd.Next(100)/4
            });
            _counter++;
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            var chb = (sender as CheckBox);
            if (chb == null) return;
            var serie = flexChart1.Series.FirstOrDefault(x => x.Name == chb.Text);
            if (serie == null) return;
            else serie.Visibility = chb.Checked 
                    ? C1.Chart.SeriesVisibility.Visible 
                    : C1.Chart.SeriesVisibility.Legend;
        }

        private void InitializeControls()
        {
            #region Init controls

            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("dynamic", "title");
            baseSample1.pDescription.Height = 140;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("dynamic", "description").MakeRtf();

            baseSample1.tbCode.Text = @"//use ObservableCollection for dynamics charts
flexChart1.DataSource = new ObservableCollection<DataItem>();";

            flexChart1 = baseSample1.flexChart1;

            btnSlow = new Button() { Left = 40, Width = 80, Text = "Slow", FlatStyle = FlatStyle.Flat, ForeColor = Color.DimGray };
            btnSlow.Click += btnSlow_Click;

            btnMedium = new Button() { Left = btnSlow.Right + 10, Width = 80, Text = "Medium", FlatStyle = FlatStyle.Flat, ForeColor = Color.DimGray };
            btnMedium.Click += btnMedium_Click;

            btnFast = new Button() { Left = btnMedium.Right + 10, Width = 80, Text = "Fast", FlatStyle = FlatStyle.Flat, ForeColor = Color.DimGray };
            btnFast.Click += btnFast_Click;

            btnStop = new Button() { Left = btnFast.Right + 10, Width = 80, Text = "Stop", FlatStyle = FlatStyle.Flat, ForeColor = Color.DimGray };
            btnStop.Click += btnStop_Click;

            baseSample1.pControls.Controls.Add(btnSlow);
            baseSample1.pControls.Controls.Add(btnMedium);
            baseSample1.pControls.Controls.Add(btnFast);
            baseSample1.pControls.Controls.Add(btnStop);
            #endregion
        }

        void btnSlow_Click(object sender, EventArgs e)
        {
            _timer.Interval = 1000;
        }
        void btnMedium_Click(object sender, EventArgs e)
        {
            _timer.Interval = 500;
        }
        void btnFast_Click(object sender, EventArgs e)
        {
            _timer.Interval = 100;
        }
        void btnStop_Click(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
                btnStop.Text = "Start";
            }
            else
            {
                _timer.Start();
                btnStop.Text = "Stop";
            }
        }
        class DataItem
        {
            public int Day { get; set; }
            public int Trucks { get; set; }
            public int Ships { get; set; }
            public int Planes { get; set; }
        }
    }
}
