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
using System.Globalization;

namespace FlexChartExplorer.Samples
{
    public partial class SeriesBinding : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public SeriesBinding()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = FinancialDataSource.GetQuotes(new DateTime(2017,1,1));
            var monthlyData = data.GroupBy(x => x.Date.Month).SelectMany(grp => grp.Select(val => new
            {
                Date = new DateTime(val.Date.Year, grp.Key, 15),
                Value = grp.Average(x => x.Volume),
            })).Distinct().ToList();

            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "Stock Exchange Analysis";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "Date";
            this.flexChart1.Binding = "Volume";
            var ser1 = new Series { Name = "Daily" };
            var ser2 = new Series
            {
                Name = "Monthly (Avg)",
                Binding = "Value",
                ChartType = ChartType.LineSymbols,
                DataSource = monthlyData,
            };
            this.flexChart1.Series.Add(ser1);
            this.flexChart1.Series.Add(ser2);

            this.flexChart1.ToolTip.Content = "{y:n0}";
            this.flexChart1.AxisX.TimeUnit = TimeUnits.Month;
            this.flexChart1.AxisX.MajorUnit = 1;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
