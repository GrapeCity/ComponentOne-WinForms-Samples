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
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Zoom : FlexChartBaseSample
    {
        private ButtonEx _bResetZoom;
        private Point _start, _last;
        private bool _IsMouseDown;
        private FlexChart flexChart1;

        public Zoom()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.LineSymbols;
            this.flexChart1.BindingX = "X";
            var fun1 = new Series
            {
                Binding = "Y",
                DataSource = DataService.CreateDataPoints(x => 2 * Math.Sin(0.16 * x), y => 2 * Math.Cos(0.12 * y), 160),
                Name = "Function-1",
            };
            var fun2 = new Series
            {
                Binding = "Y",
                DataSource = DataService.CreateDataPoints(x => Math.Sin(0.1 * x), y => Math.Cos(0.15 * y), 160),
                Name = "Function-2",
            };
            this.flexChart1.Series.Add(fun1);
            this.flexChart1.Series.Add(fun2);
            this.flexChart1.ToolTip.Content = string.Empty;

            this.flexChart1.MouseDown += FlexChart1_MouseDown;
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
            this.flexChart1.MouseUp += FlexChart1_MouseUp;

            flexChart1.Rendered += (s, e) =>
            {
                if (!_start.IsEmpty && !_last.IsEmpty)
                {
                    // draw selection
                    var p1 = _start;
                    var p2 = _last;
                    e.Engine.SetFill(null);
                    e.Engine.SetStroke(Brushes.Red);
                    e.Engine.SetStrokeThickness(1);
                    e.Engine.SetStrokePattern(new double[] { 3, 3 });
                    e.Engine.DrawRect(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                }
            };
        }

        private void FlexChart1_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop Zooming
            _IsMouseDown = false;
            if (!_last.IsEmpty)
            {
                var start = flexChart1.PointToData(_start);
                var last = flexChart1.PointToData(_last);
                //Update axes with new limits
                flexChart1.AxisX.Min = Math.Min(start.X, last.X);
                flexChart1.AxisX.Max = Math.Max(start.X, last.X);
                flexChart1.AxisY.Min = Math.Min(start.Y, last.Y);
                flexChart1.AxisY.Max = Math.Max(start.Y, last.Y);
            }
            // Clean up
            _start = _last = Point.Empty;
        }

        private void FlexChart1_MouseDown(object sender, MouseEventArgs e)
        {
            //Start Zooming
            _IsMouseDown = true;
            _start = e.Location;
            _last = Point.Empty;
        }

        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            //When zooming, update selection range
            if (_IsMouseDown)
            {
                var ptCurrent = e.Location;
                var left = (int) flexChart1.PlotRect.Left;
                var right = (int)flexChart1.PlotRect.Right;
                var top = (int)flexChart1.PlotRect.Top;
                var bot = (int)flexChart1.PlotRect.Bottom;
                ptCurrent.X = ptCurrent.X < left ? left : ptCurrent.X > right ? right : ptCurrent.X;
                ptCurrent.Y = ptCurrent.Y < top ? top : ptCurrent.Y > bot ? bot : ptCurrent.Y;
                _last = ptCurrent;
                flexChart1.Refresh();
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _bResetZoom = new ButtonEx("Reset Zoom");
            _bResetZoom.Click += (s, e) =>
            {
                flexChart1.AxisX.Min = flexChart1.AxisX.Max = double.NaN;
                flexChart1.AxisY.Min = flexChart1.AxisY.Max = double.NaN;
            };

            this.pnlControls.Controls.Add(_bResetZoom);
        }
    }
}
