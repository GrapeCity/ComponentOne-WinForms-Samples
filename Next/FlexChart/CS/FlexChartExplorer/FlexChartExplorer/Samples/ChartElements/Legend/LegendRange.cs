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
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class LegendRange : FlexChartBaseSample
    {
        private static readonly Color[] GradientRedColors =
        {
                Color.FromArgb(254, 224, 232),
                Color.FromArgb(252, 173, 193),
                Color.FromArgb(251, 121, 154),
                Color.FromArgb(249, 70, 115),
                Color.FromArgb(247, 19, 77),
                Color.FromArgb(205, 7, 57),
                Color.FromArgb(154, 5, 43),
                Color.FromArgb(103, 3, 29)
        };
        private FlexChart flexChart1;

        public LegendRange()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "US : Highest Temperature recorded";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.DataSource = DataService.GetUSStatesTemperature();

            this.flexChart1.BindingX = "Name";
            this.flexChart1.ChartType = ChartType.Scatter;
            var ser = new SeriesWithPointLegendItems { Binding = "Value"};
            ser.SymbolRendering += Ser_SymbolRendering;
            this.flexChart1.Series.Add(ser);

            this.flexChart1.ToolTip.Content = "{x}\r\n{y}";
            this.flexChart1.AxisY.Format = "0 °F";
            this.flexChart1.Legend.Position = Position.Right;
            this.flexChart1.Legend.Title = "Temperature Ranges";            
        }

        private void Ser_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            int idx = (int)(((CategoricalPoint)e.Item).Value - 95) / 5;
            e.Engine.SetFill(new SolidBrush(GradientRedColors[idx]));
            e.Engine.SetStroke(new SolidBrush(GradientRedColors[idx]));
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
        public class SeriesWithPointLegendItems : Series, ISeries
        {
            /// <summary>
            /// Gets the name of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            string ISeries.GetLegendItemName(int index)
            {
                int low = 95 + 5 * index;
                return low + " to " + (low + 5);
            }

            /// <summary>
            /// Gets the style of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            _Style ISeries.GetLegendItemStyle(int index)
            {
                return new _Style { Fill = new SolidBrush(GradientRedColors[index]) };
            }

            /// <summary>
            /// Get the number of series items in the legend.
            /// </summary>
            int ISeries.GetLegendItemLength() { return 8; }
        }
    }
}
