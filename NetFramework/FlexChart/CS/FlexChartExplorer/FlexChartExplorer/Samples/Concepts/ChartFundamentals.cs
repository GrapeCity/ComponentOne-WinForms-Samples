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
using BaseExplorer;
using C1.Win.Chart.Annotation;
using C1.Chart.Annotation;

namespace FlexChartExplorer.Samples
{
    public partial class ChartFundamentals : FlexChartBaseSample
    {
        private TrackBar _trackBar;
        private ButtonEx _btnTimer;
        private int pointCount = 15;
        private Timer _timer;
        private FlexChart _flexChart;
        private List<ChartElement> _displayOrder = new List<ChartElement>
        {
            ChartElement.None,
            ChartElement.ChartArea,
            ChartElement.Header,
            ChartElement.Footer,
            ChartElement.PlotArea,
            ChartElement.AxisX,
            ChartElement.AxisY,
            ChartElement.Legend,
            ChartElement.Series,
            ChartElement.SeriesSymbol,
            ChartElement.DataLabel,
        };

        public ChartFundamentals()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        protected override void SetupChart()
        {
            var ds = DataService.CreateDataPoints(x => x, y => y * Math.Log(y), pointCount);
            this._flexChart.DataSource = ds;
            this._flexChart.ChartType = ChartType.LineSymbols;
            this._flexChart.BindingX = "X";
            this._flexChart.Binding = "Y";
            this._flexChart.Options.BubbleMinSize = 10;
            this._flexChart.Options.BubbleMaxSize = 70;

            var ser1 = new Series
            {
                Name = "Series-1",
                Binding = "Y,Y",
                ChartType = ChartType.Bubble
            };
            ser1.DataLabel = new DataLabel
            {
                Content = "Series Symbols",
                Position = LabelPosition.None
            };

            var ser2 = new Series
            {
                Name = "Series-2",
                DataSource = DataService.CreateDataPoints(x => x, y => y * Math.Sin(y), pointCount),
            };
            ser2.DataLabel = new DataLabel
            {
                ConnectingLine = true,
                Content = "{y:0.00}",
                Border = true,
                Position = LabelPosition.None
            };
            this._flexChart.Series.Add(ser1);
            this._flexChart.Series.Add(ser2);

            //Legend
            this._flexChart.Legend.Title = "Chart Legend";
            this._flexChart.Legend.Position = Position.None;
            this._flexChart.Legend.TitleStyle.Font = StyleInfo.LegendTitleFont;

            //Axis
            this._flexChart.AxisX.Title = "X-Axis Title";
            this._flexChart.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this._flexChart.AxisX.Style.StrokeWidth = 2;
            this._flexChart.AxisX.DataSource = GetAxisLabels();
            this._flexChart.AxisX.Binding = "Value,Name";

            this._flexChart.AxisY.AxisLine = true;
            this._flexChart.AxisY.Title = "Y-Axis Title";
            this._flexChart.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this._flexChart.AxisY.Style.StrokeWidth = 2;

            //Plot Area
            this._flexChart.PlotStyle.StrokeDashPattern = new float[] { 3, 1 };
            this._flexChart.PlotStyle.StrokeWidth = 2;

            //Chart Titles
            this._flexChart.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this._flexChart.Footer.Style.Font = StyleInfo.ChartHeaderFont;

            //Background
            this._flexChart.BackColor = Color.LightYellow;

            this._flexChart.LabelRendering += OnLabelRendering;
            this._flexChart.Rendered += OnChartRendered;
        }

        protected override void InitializeControls()
        {
            _flexChart = new FlexChart();
            this.Chart = _flexChart;

            _trackBar = new TrackBar()
            {
                Minimum = 0,
                Maximum = _displayOrder.Count - 1,
                Value = _displayOrder.Count-1,
                Width = 150
            };
            _trackBar.Scroll += OnTrackScrolled;

            _timer = new Timer()
            {
                Interval = 1000
            };
            _timer.Tick += OnTick;

            _btnTimer = new ButtonEx("Stop");
            _btnTimer.Click += (s, e) =>
            {
                if (_timer.Enabled)
                {
                    _timer.Stop();
                    _btnTimer.Text = "Start";
                }
                else
                {
                    _timer.Start();
                    _btnTimer.Text = "Stop";
                }
            };
            this.pnlControls.Controls.Add(_trackBar);
            this.pnlControls.Controls.Add(_btnTimer);
        }

        #region Event Handlers

        private void OnLoad(object sender, EventArgs e)
        {
            foreach(ChartElement ele in Enum.GetValues(typeof(ChartElement)))
            {
                if (ele != ChartElement.None)
                    ShowElement(ele);
            }
            _timer.Start();
        }
        private void OnLabelRendering(object sender, RenderDataLabelEventArgs e)
        {
            var si = _flexChart.Series.IndexOf(e.Series);
            if (si == 0 && e.Index != pointCount - 2)
                e.Cancel = true;
            else if (si == 2 && e.Index % 2 == 1)
                e.Cancel = true;
            else if (si == 1 && e.Index == 6)
            {
                e.Text = "Data Labels";
                e.Engine.SetStroke(Brushes.DarkBlue);
            }
        }

        private void OnChartRendered(object sender, RenderEventArgs e)
        {
            e.Graphics.DrawString("Chart Area", StyleInfo.AxisTitleFont, Brushes.SandyBrown, new PointF(2, 2));
            e.Graphics.DrawRectangle(new Pen(Brushes.SandyBrown, 2), new System.Drawing.Rectangle(2, 2, _flexChart.Width - 4, _flexChart.Height - 4));
            if (_flexChart.AxisX.AxisLine)
                e.Graphics.DrawString("X-Axis Line", StyleInfo.AxisTitleFont, Brushes.DimGray, new PointF(_flexChart.PlotRect.Width / 2, _flexChart.PlotRect.Bottom - 20));
            if (_flexChart.AxisY.AxisLine)
                e.Graphics.DrawString("Y-Axis Line", StyleInfo.AxisTitleFont, Brushes.DimGray, new PointF(_flexChart.PlotRect.Left, _flexChart.PlotRect.Height / 2));
            if (_flexChart.PlotStyle.FillColor != Color.Transparent)
                e.Graphics.DrawString("The Plot Area", StyleInfo.AxisTitleFont, Brushes.DarkGreen, new PointF(_flexChart.PlotRect.Width / 2, _flexChart.PlotRect.Top));
        }
        private void OnTick(object sender, EventArgs e)
        {
            if (_trackBar.Value == _trackBar.Maximum)
                _trackBar.Value = 0;
            else
                _trackBar.Value++;
            ShowElement(_displayOrder[_trackBar.Value]);
        }

  
        private void OnTrackScrolled(object sender, EventArgs e)
        {
            bool isTimerEnabled = _timer.Enabled;
            _timer.Stop();
            var currentValue = _trackBar.Value;
            _trackBar.Value = _trackBar.Maximum;
            for (int i = 0; i <= currentValue; i++)
            {
                OnTick(sender, e);
            }
            if (isTimerEnabled)
                _timer.Start();
        }

        #endregion
        /// <summary>
        /// Handle visibility of FlexChart elements if TrackBar scrolled by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowElement(ChartElement ele)
        {
            switch (ele)
            {
                case ChartElement.ChartArea: _flexChart.Visible = true;
                    break;
                case ChartElement.PlotArea:
                    _flexChart.PlotStyle.FillColor = Color.FromArgb(100, Color.LightGreen);
                    _flexChart.PlotStyle.StrokeColor = Color.DarkGreen;
                    break;
                case ChartElement.Header:
                    _flexChart.Header.Content = "FlexChart Header";
                    break;
                case ChartElement.Footer:
                    _flexChart.Footer.Content = "FlexChart Footer";
                    break;
                case ChartElement.AxisX:
                    _flexChart.AxisX.AxisLine = true;
                    _flexChart.AxisX.Labels = true;
                    _flexChart.AxisX.Title = "X-Axis Title";
                    break;
                case ChartElement.AxisY:
                    _flexChart.AxisY.AxisLine = true;
                    _flexChart.AxisY.Labels = true;
                    _flexChart.AxisY.Title = "Y-Axis Title";
                    break;
                case ChartElement.Legend:
                    _flexChart.Legend.Position = Position.Right;
                    break;
                case ChartElement.Series:
                    _flexChart.Series[0].Visibility = SeriesVisibility.Visible;
                    _flexChart.Series[0].DataLabel.Position = LabelPosition.None;
                    _flexChart.Series[1].Visibility = SeriesVisibility.Visible;
                    _flexChart.Series[1].DataLabel.Position = LabelPosition.None;
                    break;
                case ChartElement.SeriesSymbol:
                    _flexChart.Series[0].DataLabel.Position = LabelPosition.Center;
                    break;
                case ChartElement.DataLabel:
                    _flexChart.Series[1].DataLabel.Position = LabelPosition.Top;
                    break;
                case ChartElement.None:
                default:
                    _flexChart.Visible = false;
                    _flexChart.Header.Content = string.Empty;
                    _flexChart.Footer.Content = string.Empty;
                    _flexChart.PlotStyle.FillColor = Color.Transparent;
                    _flexChart.PlotStyle.StrokeColor = Color.Transparent;
                    _flexChart.AxisX.AxisLine = false;
                    _flexChart.AxisX.Labels = false;
                    _flexChart.AxisX.Title = string.Empty;
                    _flexChart.AxisY.AxisLine = false;
                    _flexChart.AxisY.Labels = false;
                    _flexChart.AxisY.Title = string.Empty;
                    _flexChart.Series[0].Visibility = SeriesVisibility.Hidden;
                    _flexChart.Series[1].Visibility = SeriesVisibility.Hidden;
                    _flexChart.Legend.Position = Position.None;
                    break;
            }
        }

        private List<CategoricalPoint> GetAxisLabels()
        {
            var labels = new List<CategoricalPoint>();
            for (int i = 1; i <= 15; i += 5)
            {
                labels.Add(new CategoricalPoint() { Name = "Axis Label", Value = i });
            }
            return labels;
        }
    }
}
