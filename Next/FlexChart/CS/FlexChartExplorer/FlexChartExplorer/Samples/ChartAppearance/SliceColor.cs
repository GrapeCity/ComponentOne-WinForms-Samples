using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class SliceColor : FlexChartBaseSample
    {
        private List<CategoricalPoint> _dataSource;
        private CategoricalPoint[] orderedData;

        public SliceColor()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var flexPie = this.Chart as FlexPie;
            flexPie.Header.Content = "Market share of automobile organizations";
            flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;

            flexPie.Binding = "Value";
            flexPie.BindingName = "Name";
            flexPie.InnerRadius = 0.7;
            flexPie.SliceRendering += _flexPie_SliceRendering;

            flexPie.Legend.Position = Position.None;
            flexPie.DataLabel.Content = "{name} - {p:0.00}%";
            flexPie.DataLabel.Position = PieLabelPosition.Inside;

            flexPie.ToolTip.Content = "Units Sold : {value:n0}";

            _dataSource = SalesDataSource.GetCarSales();
            orderedData =  _dataSource.OrderBy(item => item.Value).ToArray();
            flexPie.DataSource = _dataSource;
        }

        private void _flexPie_SliceRendering(object sender, RenderSliceEventArgs e)
        {
            int sliceOrderedIndex = Array.IndexOf(orderedData, _dataSource[e.Index]) + 1;
            Color sliceColor = ColorFrom(Color.White,Color.LightSeaGreen,sliceOrderedIndex,orderedData.Length);
            e.Engine.SetFill(sliceColor.ToArgb());
            e.Engine.SetStroke(ControlPaint.Dark(sliceColor));
        }
        private Color ColorFrom(Color start, Color end, int index, int max)
        {
            var r = start.R + (index * (end.R - start.R)) / max;
            var g = start.G + (index * (end.G - start.G)) / max;
            var b = start.B + (index * (end.B - start.B)) / max;
            Color c = Color.FromArgb(r, g, b);
            return c;
        }
        protected override void InitializeControls()
        {
            this.Chart = new FlexPie { Dock = DockStyle.Fill };
        }
    }
}
