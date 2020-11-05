using C1.Win.Chart;
using C1.Win.Chart.Interaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxisScrollbarDemo
{
    public partial class Form1 : Form
    {
        AxisScrollbar _horizontalAxisScrollbar;
        AxisScrollbar _verticalAxisScrollbar;
        public Form1()
        {
            InitializeComponent();
            SetupChart();
        }

        public void SetupRangeSelector()
        {
            if (_horizontalAxisScrollbar != null || _verticalAxisScrollbar != null) return;

            // add horizontal AxixScrollbar
            _horizontalAxisScrollbar = new AxisScrollbar(flexChart1.AxisX);
            _horizontalAxisScrollbar.Height = 24;

            // add vartical AxixScrollbar
            _verticalAxisScrollbar = new AxisScrollbar(flexChart1.AxisY);
            _verticalAxisScrollbar.ScrollButtonsVisible = false;
        }
       
        void SetupChart()
        {
            var rnd = new Random();
            var pointsCount = rnd.Next(1, 30);

            var pointsList = new List<DataItem>();
            for (DateTime date = new DateTime(DateTime.Now.Year - 3, 1, 1); date.Year < DateTime.Now.Year; date = date.AddDays(1))
            {
                pointsList.Add(new DataItem()
                {
                    Date = date,
                    Series1 = rnd.Next(100)
                });
            }

            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();
            flexChart1.ChartType = C1.Chart.ChartType.Line;
            flexChart1.BindingX = "Date";
            flexChart1.Series.Add(new Series() { Name = "Series1", Binding = "Series1" });
            flexChart1.DataSource = pointsList.ToArray();

            flexChart1.EndUpdate();
        }

        class DataItem
        {
            public int Series1 { get; set; }
            public DateTime Date { get; set; }
        }

        private void flexChart1_Rendered(object sender, RenderEventArgs e)
        {
            SetupRangeSelector();
        }
    }
}
