using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using FlexChartExplorer.Data;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class SplineSymbols : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public SplineSymbols()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = DataService.GetTemperatureData(new string[] { "Tokyo"}, false, 30, true);

            this.flexChart1.ChartType = ChartType.SplineSymbols;
            this.flexChart1.Header.Content = "Daily Temperature";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            foreach(var item in data)
            {
                var series = new Series
                {
                    Name = item.Name,
                    Binding = "HighTemp",
                    DataSource = item.Data,
                };
                this.flexChart1.Series.Add(series);
            }
            this.flexChart1.AxisY.Title = "Temperature (°F)";
            this.flexChart1.AxisY.Style.Font = StyleInfo.AxisTitleFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
