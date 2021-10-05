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
    public partial class RangeSelector : FlexChartBaseSample
    {
        private C1.Win.Chart.Interaction.RangeSelector _rsXRangeSelector;
        private FlexChart _fcChartRangeSelector;
        private FlexChart flexChart1;

        public RangeSelector()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = FinancialDataSource.GetQuotes();
            var minPrice = data.Min((q) => q.Low);
            var maxPrice = data.Max((q) => q.High);
            var orderedVolume = data.OrderBy((q) => q.Volume);

            //Setup Main Chart
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "Date";
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
                AxisY = new Axis { Position = Position.Right, Format = "#,##0,,M", Max = 2*orderedVolume.Last().Volume-orderedVolume.First().Volume},
            };
            this.flexChart1.AxisY.Min = 2 * minPrice - maxPrice;
            this.flexChart1.Series.Add(_sPrice);
            this.flexChart1.Series.Add(_sVolume);
            this.flexChart1.Legend.Position = Position.Top;
            this.flexChart1.ToolTip.Content = "High:{High}\nLow:{Low}\nOpen:{Open}\nClose:{Close}\nVolume:{Volume}";
            
            //Setup Range Selector Chart
            _fcChartRangeSelector.ChartType = ChartType.Line;
            _fcChartRangeSelector.DataSource = this.flexChart1.DataSource;
            _fcChartRangeSelector.BindingX = "Date";
            _fcChartRangeSelector.Series.Add(new Series { Binding = "High" });
            _fcChartRangeSelector.Rendered += (s,e)=>
            {
                SetupRangeSelector();
            };
        }
        private void SetupRangeSelector()
        {
            if (_rsXRangeSelector != null)
                return;
            _rsXRangeSelector = new C1.Win.Chart.Interaction.RangeSelector(_fcChartRangeSelector);
            _rsXRangeSelector.ValueChanged += (s, e) =>
            {
                flexChart1.AxisX.Min = _rsXRangeSelector.LowerValue;
                flexChart1.AxisX.Max = _rsXRangeSelector.UpperValue;
            };
            _rsXRangeSelector.LowerValue = _rsXRangeSelector.UpperValue - 90;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _fcChartRangeSelector = new FlexChart() {Dock= DockStyle.Bottom, Height = 100};
            this.Controls.Add(_fcChartRangeSelector);
        }

        public override Image GetImage(int width = 200, int height = 200)
        {
            var combinedImg = new Bitmap(_fcChartRangeSelector.Width, (flexChart1.Height + _fcChartRangeSelector.Height));

            var bmpMainChart = base.GetImage();

            var bmpRangeSelChart = new Bitmap(_fcChartRangeSelector.Width, _fcChartRangeSelector.Height);
            _fcChartRangeSelector.DrawToBitmap(bmpRangeSelChart, _fcChartRangeSelector.DisplayRectangle);

            Graphics g = Graphics.FromImage(combinedImg);
            g.DrawImage(bmpMainChart, 0, 0);
            g.DrawImage(bmpRangeSelChart, 0, flexChart1.Height);
            return combinedImg;
        }
    }
}
