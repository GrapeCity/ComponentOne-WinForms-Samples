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

namespace FlexChartExplorer.Samples
{
    public partial class HLOC : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public HLOC()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = FinancialDataSource.GetQuotes(180);
            var minPrice = data.Min((q) => q.Low);
            var maxPrice = data.Max((q) => q.High);
            var orderedVolume = data.OrderBy((q) => q.Volume);

            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisX.AxisLine = false;

            this.flexChart1.BindingX = "Date";
            this.flexChart1.ToolTip.Content = "High:{High}\nLow:{Low}\nOpen:{Open}\nClose:{Close}\nVolume:{Volume} K";
            var _sPrice = new Series
            {
                Name = "Price",
                Binding = "High,Low,Open,Close",
                ChartType = ChartType.HighLowOpenClose,
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
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}