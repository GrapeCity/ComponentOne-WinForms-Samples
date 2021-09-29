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

namespace WeatherChart
{
    public partial class Form1 : Form
    {
        RangeSelector XRangeSelector;
        public Form1()
        {
            InitializeComponent();
            SetupCharts();
        }

        public void SetupRangeSelector()
        {
            if (XRangeSelector != null) return;

            // add X-RangeSelector
            XRangeSelector = new RangeSelector(chartRangeSelector);
            XRangeSelector.ValueChanged += XRangeSelector_ValueChanged;
            XRangeSelector.UpperValue = XRangeSelector.LowerValue + 180;
        }

        void XRangeSelector_ValueChanged(object sender, EventArgs e)
        {
            chartTemperature.AxisX.Min = XRangeSelector.LowerValue;
            chartTemperature.AxisX.Max = XRangeSelector.UpperValue;

            chartPressure.AxisX.Min = XRangeSelector.LowerValue;
            chartPressure.AxisX.Max = XRangeSelector.UpperValue;

            chartPrecipitation.AxisX.Min = XRangeSelector.LowerValue;
            chartPrecipitation.AxisX.Max = XRangeSelector.UpperValue;
        }

        void SetupCharts()
        {
            var rnd = new Random();
            var pointsCount = rnd.Next(1, 30);

            var temperaturePoints = new List<DataItem>();
            for (DateTime date = new DateTime(2016, 1, 1); date.Year == 2016; date = date.AddDays(1))
            {
                var newItem = new DataItem();
                newItem.Date = date;
                if (date.Month <= 8)
                    newItem.MaxTemp = rnd.Next(3 * date.Month, 4 * date.Month);
                else
                    newItem.MaxTemp = rnd.Next((13 - date.Month - 2) * date.Month, (13 - date.Month) * date.Month);
                newItem.MinTemp = newItem.MaxTemp - rnd.Next(6, 8);
                newItem.MeanTemp = (newItem.MaxTemp + newItem.MinTemp) / 2;
                newItem.MeanPressure = rnd.Next(980, 1050);
                newItem.Presipitation = rnd.Next(5) == 1 ? rnd.Next(0, 20) : 0;
                temperaturePoints.Add(newItem);
            }

            //Setup Temperature FlexChart
            chartTemperature.BeginUpdate();
            chartTemperature.ChartType = C1.Chart.ChartType.Line;
            chartTemperature.Series.Clear();

            chartTemperature.BindingX = "Date";
            chartTemperature.Series.Add(new Series() { Name = "MeanTemp", Binding = "MeanTemp" });
            chartTemperature.Series.Add(new Series() { Name = "MaxTemp", Binding = "MaxTemp" });
            chartTemperature.Series.Add(new Series() { Name = "MinTemp", Binding = "MinTemp" });
            chartTemperature.DataSource = temperaturePoints.ToArray();

            chartTemperature.EndUpdate();

            //Setup Pressure FlexChart
            chartPressure.BeginUpdate();
            chartPressure.ChartType = C1.Chart.ChartType.Area;
            chartPressure.Series.Clear();

            chartPressure.BindingX = "Date";
            chartPressure.Series.Add(new Series() { Name = "Pressure", Binding = "MeanPressure" });
            chartPressure.DataSource = temperaturePoints.ToArray();
            chartPressure.AxisY.Min = 950;
            chartPressure.EndUpdate();

            //Setup Precipitation FlexChart
            chartPrecipitation.BeginUpdate();
            chartPrecipitation.ChartType = C1.Chart.ChartType.Column;
            chartPrecipitation.Series.Clear();

            chartPrecipitation.BindingX = "Date";
            chartPrecipitation.Series.Add(new Series() { Name = "Precipitation", Binding = "Presipitation" });
            chartPrecipitation.DataSource = temperaturePoints.ToArray();

            chartPrecipitation.EndUpdate();

            //Setup RangeSelector FlexChart
            
            chartRangeSelector.BeginUpdate();
            chartRangeSelector.ChartType = C1.Chart.ChartType.Line;
            chartRangeSelector.Series.Clear();

            chartRangeSelector.BindingX = "Date";
            chartRangeSelector.Series.Add(new Series() { Name = "MeanTemp", Binding = "MeanTemp" });
            chartRangeSelector.DataSource = temperaturePoints.ToArray();

            chartRangeSelector.EndUpdate();
        }

        class DataItem
        {
            public int MaxTemp { get; set; }
            public int MinTemp { get; set; }
            public int MeanTemp { get; set; }
            public int MeanPressure { get; set; }
            public int Presipitation { get; set; }
            public DateTime Date { get; set; }
        }

        private void chartRangeSelector_Rendered(object sender, RenderEventArgs e)
        {
            SetupRangeSelector();
            //chartTemperature_Rendered(sender, e);
        }

        private void chartTemperature_Rendered(object sender, RenderEventArgs e)
        {
            return;
            var flexChart = (sender as FlexChart);
            if (flexChart == null) return;

            using (var pen = new Pen(new SolidBrush(Color.LightGray)))
            {
                var rect = new Rectangle(
                    (int)flexChart.PlotRect.X,
                    (int)flexChart.PlotRect.Y,
                    (int)flexChart.PlotRect.Width,
                    (int)flexChart.PlotRect.Height
                    );
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
