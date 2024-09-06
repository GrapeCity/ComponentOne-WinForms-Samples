using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class CombinationCharts : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public CombinationCharts()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.DataSource = DataService.GetTemperatureData(new[] { "Tokyo" }, false, 30, true).First().Data;
            this.flexChart1.Header.Content = "Weather Report : Temperature vs Precipitation";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";

            var series1 = new Series() { Name = "Temperature(°F)", Binding = "HighTemp" };
            var series2 = new Series() { Name = "Precipitation(mm)", Binding = "Precipitation", ChartType= ChartType.LineSymbols };

            this.flexChart1.Series.Add(series1);
            this.flexChart1.Series.Add(series2);
            this.flexChart1.ToolTip.Content = "Temperature = {HighTemp}°C\nPrecipitation = {Precipitation}mm";
            this.flexChart1.AxisX.AxisLine = false;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
