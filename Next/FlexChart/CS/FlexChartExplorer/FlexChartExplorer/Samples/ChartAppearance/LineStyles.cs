using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart;
using C1.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class LineStyles : FlexChartBaseSample
    {
        private float _previousX, _previousY;
        private int _sequentialInc, _sequentialDec;
        private FlexChart flexChart1;

        public LineStyles()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;

            this.flexChart1.DataSource = DataService.GetLineStylePoints();
            this.flexChart1.BindingX = "X";
            var series = new Series() { Binding="Y"};
            // Use this to avoid the default render of the lines.
            series.Style.StrokeColor = Color.Transparent;
            series.SymbolRendered += Series_SymbolRendered;
            this.flexChart1.Series.Add(series);
        }

        private void Series_SymbolRendered(object sender, RenderSymbolEventArgs e)
        {
            if (e.Index > 0)
            {
                Color lineColor;
                if(e.Point.Y == _previousY)
                {
                    lineColor = Color.Yellow;
                    e.Engine.SetStrokePattern(new double[] { 2, 1 });
                }
                else if(e.Point.Y < _previousY)
                {
                    lineColor = Color.FromArgb(Math.Min(100 + 50 * _sequentialInc, 255), 0, 255, 0);
                    _sequentialInc++;
                    _sequentialDec = 0;
                    e.Engine.SetStrokePattern(null);
                }
                else
                {
                    lineColor = Color.FromArgb(Math.Min(100 + 50 * _sequentialDec, 255), 255, 0, 0);
                    _sequentialDec++;
                    _sequentialInc = 0;
                    e.Engine.SetStrokePattern(null);
                }
                e.Engine.SetStroke(new SolidBrush(lineColor));
                e.Engine.SetStrokeThickness(3);
                e.Engine.DrawLine(_previousX, _previousY, e.Point.X, e.Point.Y);
            }
            _previousX = e.Point.X;
            _previousY = e.Point.Y;
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
        }
    }
}
