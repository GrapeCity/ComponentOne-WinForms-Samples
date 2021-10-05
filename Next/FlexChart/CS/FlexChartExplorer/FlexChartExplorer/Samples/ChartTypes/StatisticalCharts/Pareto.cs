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
    public partial class Pareto : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Pareto()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Factors Influencing Purchase Decisions";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisY.Title = "No. of Customers";
            this.flexChart1.AxisY.AxisLine = true;
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisX.Title = "Factors";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.ChartType = ChartType.RangedHistogram;
            var histogram = new C1.Win.Chart.RangedHistogram()
            {
                Binding = "Value",
                BindingX="Name",
                Name = "Count",
                SortDescending = true,
                DataSource = DataService.GetPurchaseFactorsData(),
                DataLabel = new DataLabel { Content="{y:N0}", Position= LabelPosition.Top},
            };
            this.flexChart1.Series.Add(histogram);
            //calculate data for Pareto line
            var histoYs = histogram.GetValues(0);
            var sum = histoYs.Sum();
            var paretoData = new List<PointF>();
            double cumulativeSum = 0;
            for(int i=0;i<histoYs.Length;i++)
            {
                cumulativeSum += histoYs[i];
                paretoData.Add(new PointF
                {
                    X = i,
                    Y = (float)(cumulativeSum / sum),
                });
            }
            var paretoLine = new Series
            {
                Name = "Cumulative %",
                ChartType = ChartType.LineSymbols,
                DataSource = paretoData,
                Binding = "Y",
                BindingX = "X",
                AxisY = new Axis
                {
                    Position= Position.Right,
                    Min=0,
                    Max=1,
                    Format = "P0",
                    Title = "Cumulative Percentage",
                },
                DataLabel = new DataLabel { Content = "{y:P2}", Position = LabelPosition.Top },
            };
            paretoLine.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            paretoLine.Style.StrokeWidth = paretoLine.SymbolStyle.StrokeWidth = 3;
            paretoLine.Style.StrokeColor = paretoLine.SymbolStyle.FillColor = Color.FromArgb(255, 192, 80, 77);
            this.flexChart1.Series.Add(paretoLine);
            this.flexChart1.MouseMove += OnMouseMove;
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var ht = flexChart1.HitTest(e.Location);
            if (ht == null || ht.Series == null)
                return;
            flexChart1.ToolTip.Content = ht.Series.Name == "Cumulative %" ? "{y:P2}" : "{y}";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
