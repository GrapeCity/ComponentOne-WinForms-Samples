using System;
using System.Collections.Generic;
using C1.Win.Chart;
using C1.Win.Chart.Interaction;

namespace ControlExplorer.FlexChart
{
    public partial class AxisScrollbarDemo : C1DemoForm
    {
        AxisScrollbar _horizontalAxisScrollbar;
        AxisScrollbar _verticalAxisScrollbar;

        public AxisScrollbarDemo()
        {
            InitializeComponent();
            SetupChart();
            SetupRangeSelector();
            AddProperty("ScrollButtonsVisible", _verticalAxisScrollbar, "Show Vertical Scroll Buttons");
            AddProperty("ScrollButtonsVisible", _horizontalAxisScrollbar, "Show Horizontal Scroll Buttons");
        }

        public void SetupRangeSelector()
        {
            if (_horizontalAxisScrollbar != null || _verticalAxisScrollbar != null) return;

            // add horizontal AxixScrollbar
            _horizontalAxisScrollbar = new AxisScrollbar(flexChart1.AxisX);
            _horizontalAxisScrollbar.Height = 20;

            // add vertical AxixScrollbar
            _verticalAxisScrollbar = new AxisScrollbar(flexChart1.AxisY);
            _verticalAxisScrollbar.Width = 20;
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
    }
}
