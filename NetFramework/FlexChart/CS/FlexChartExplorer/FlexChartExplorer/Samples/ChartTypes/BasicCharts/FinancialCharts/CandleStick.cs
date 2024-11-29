using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class CandleStick : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public CandleStick()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = FinancialDataSource.GetQuotes(90);
            var minPrice = data.Min((q) => q.Low);
            var maxPrice = data.Max((q) => q.High);
            var orderedVolume = data.OrderBy((q) => q.Volume);

            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            this.flexChart1.ToolTip.Content = "High:{High:C2}\nLow:{Low:C2}\nOpen:{Open:C2}\nClose:{Close:C2}\nVolume:{Volume}";
            var _sPrice = new Series
            {
                Name = "Price",
                Binding = "High,Low,Open,Close",
                ChartType = ChartType.Candlestick,
            };
            var _sVolume = new Series
            {
                Name = "Volume",
                Binding = "Volume",
                AxisY = new Axis { Position = Position.Right, Format = "#,##0,,M", Max = 2.5 * orderedVolume.Last().Volume - orderedVolume.First().Volume },
            };
            this.flexChart1.AxisY.Min = 2 * minPrice - maxPrice;
            this.flexChart1.AxisX.Format = "MMMM dd";
            this.flexChart1.Series.Add(_sPrice);
            this.flexChart1.Series.Add(_sVolume);
            this.flexChart1.DataSource = data;
            this.flexChart1.AxisX.AxisLine = false;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
        }

    }
}
