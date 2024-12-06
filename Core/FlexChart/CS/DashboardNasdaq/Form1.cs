using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DashboardNasdaq.Data;

using C1.Chart;
using C1.Win.Chart;
using System.IO;
using C1.Win.Chart.Interaction;
using DashboardNasdaq.Utils;

namespace DashboardNasdaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FlexPie chartProfit, chartQuarter;

        FlexChart chartSelection;
        FlexChart chartAll;

        FlexChart chartBubble;

        FlexChart chartDays;
        FlexChart chartFluctuation;

        FlexChart monthsChart;

        RangeSelector rangeSelector;

        DataService dataService = new DataService();
        Data.DataView dataView;

        int ncols = 5;

        // colors
        Color backColor = Color.FromArgb(248, 248, 248);
        Color foreColor = Color.FromArgb(32, 32, 32);
        Color selectionColor = Color.FromArgb(0, 68, 27);

        // palettes
        Color[] palette1 = new Color[] { Color.FromArgb(186, 228, 179), Color.FromArgb(49, 163, 84) };
        //Color[] palette2 = new Color[] { Color.FromArgb(215, 25, 28), Color.FromArgb(255, 255, 191), Color.FromArgb(26, 150, 65) };
        Color[] palette2 = new Color[] { Color.FromArgb(244, 109, 67), Color.FromArgb(255, 255, 191), Color.FromArgb(102, 189, 99) };
        Color[] palette3 = new Color[] { Color.FromArgb(161, 217, 155) };

        // fonts
        Font tooltipFont = new Font("Segoe UI", 10);
        Color tooltipBackColor = Color.FromArgb(0, 90, 50);

        Control parent = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            ParentChanged += Form1_ParentChanged;

            tableLayoutPanel1.BackColor = Color.FromArgb(240, 240, 240);

            var quotes = dataService.GetQuotes();
            dataView = new Data.DataView(quotes);

            chartProfit = CreateProfitChart();
            tableLayoutPanel1.Controls.Add(chartProfit, 0, 1);

            //-- 
            chartQuarter = CreateQuarterChart();
            tableLayoutPanel1.Controls.Add(chartQuarter, 1, 1);

            //--
            chartSelection = CreateSelectionChart();
            tableLayoutPanel1.SetColumnSpan(chartSelection, ncols);
            tableLayoutPanel1.Controls.Add(chartSelection, 0, 2);

            // total data (lower chart)
            chartBubble = CreateBubbleChart();
            tableLayoutPanel1.SetColumnSpan(chartBubble, ncols);
            tableLayoutPanel1.Controls.Add(chartBubble, 0, 0);

            // ---
            monthsChart = CreateMonthsChart();
            tableLayoutPanel1.Controls.Add(monthsChart, 2, 1);

            // ---
            chartDays = CreateDaysChart();
            tableLayoutPanel1.Controls.Add(chartDays, 3, 1);

            // ---
            chartFluctuation = CreateFluctationChart();
            tableLayoutPanel1.Controls.Add(chartFluctuation, 4, 1);

            var mquotes = dataView.GetMonthlyQuotes();
            chartAll = CreateOverviewChart(mquotes);
            tableLayoutPanel1.SetColumnSpan(chartAll, ncols);
            tableLayoutPanel1.Controls.Add(chartAll, 0, 3);

            AddResetButton(chartBubble, chartProfit, chartQuarter, chartDays, monthsChart);
            ApplyStyle(chartAll, chartBubble, chartSelection, chartProfit, chartQuarter, chartFluctuation, chartDays, monthsChart);
        }

        private void Form1_ParentChanged(object sender, EventArgs e)
        {
            if(parent!=null)
                parent.ClientSizeChanged -= Parent_ClientSizeChanged;
            
            if (Parent != null)
            {
                Size = Parent.ClientSize;
                parent = Parent;
                parent.ClientSizeChanged += Parent_ClientSizeChanged;
            }
        }

        private void Parent_ClientSizeChanged(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;
        }

        void UpdateSelection(double min, double max, bool resetYear = false)
        {
            if (resetYear)
                chartBubble.SelectedIndex = -1;

            // update filters
            dataView.SetMinMax(min, max);
            dataView.Profit = chartProfit.SelectedIndex >= 0 ? (bool?)(chartProfit.SelectedIndex == 1) : null;
            dataView.Quarter = chartQuarter.SelectedIndex + 1;
            dataView.Day = chartDays.SelectedIndex >= 0 ? (DayOfWeek?)(chartDays.SelectedIndex + 1) : null;
            dataView.Month = monthsChart.SelectedIndex + 1;

            var yearQuotes = chartBubble.DataSource as List<YearQuote>;
            dataView.Year = chartBubble.SelectedIndex >= 0 && yearQuotes != null && chartBubble.SelectedIndex < yearQuotes.Count ?
                yearQuotes[chartBubble.SelectedIndex].Year : 0;

            foreach (var chart in new FlexChartBase[] { chartBubble, chartProfit, chartQuarter, chartSelection, chartFluctuation, chartDays, monthsChart })
                chart.BeginUpdate();

            chartSelection.DataSource = GetSelection(min, max);
            chartBubble.DataSource = dataView.GetYearQuotes();
            chartProfit.DataSource = dataView.GetOutcomes();
            chartQuarter.DataSource = dataView.GetQuarterVolume();
            chartFluctuation.DataSource = dataView.GetFluctuations();
            chartDays.DataSource = dataView.GetDaysOfWeekData();
            monthsChart.DataSource = dataView.GetMonthsVolume();

            foreach (var chart in new FlexChartBase[] { chartBubble, chartProfit, chartQuarter, chartSelection, chartFluctuation, chartDays, monthsChart })
                chart.EndUpdate();
        }

        List<Quote> GetSelection(double min, double max)
        {
            var quotes = dataView.GetMonthlyQuotes();
            var list = new List<Quote>();
            for (var i = 0; i < quotes.Count; i++)
            {
                if (quotes[i].Date.ToOADate() > max)
                    break;
                if (quotes[i].Date.ToOADate() >= min)
                    list.Add(quotes[i]);
            }
            return list;
        }

        FlexChart CreateBubbleChart()
        {
            var chart = new FlexChart()
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                ChartType = ChartType.Bubble,
                BindingX = "Delta",
                Binding = "DeltaPct,DeltaPctAbs",
                SelectionMode = ChartSelectionMode.Point
            };
            chart.AxisX.AxisLine = false;
            chart.AxisX.MajorGrid = true;
            chart.AxisX.Title = "Index Gain";
            chart.AxisY.Title = "Index Gain, %";
            chart.AxisY.Format = "0%";
            chart.DataLabel.Style.Font = new Font("Segoe UI", 7);
            chart.ToolTip.Content = "Year: {Year}\nIndex Gain: {Delta:n1} {DeltaPct:p0}";
            chart.Header.Content = "Yearly Performance";
            chart.Options.BubbleMinSize = 30;
            chart.Options.BubbleMaxSize = 60;
            var ser = new Series() { SymbolSize = 30 };
            ser.SymbolRendering += (s1, e1) =>
            {
                var alpha = e1.Index == chart.SelectedIndex ? 255 : (chart.SelectedIndex >= 0 ? 96 : 192);
                var item = (YearQuote)e1.Item;
                var clr = (item.DeltaPct >= 0) ?
                    ColorUtils.InterpolateRgb(palette2[1], palette2[2], (float)(item.DeltaPct / dataView.MaxDeltaPct)) :
                    ColorUtils.InterpolateRgb(palette2[1], palette2[0], (float)(item.DeltaPct / dataView.MinDeltaPct));
                clr = Color.FromArgb(alpha, clr);

                e1.Engine.SetFill(clr.ToArgb());
                if (e1.Index != chart.SelectedIndex)
                    e1.Engine.SetStroke(null);
            };
            ser.SymbolRendered += (s, e) =>
            {
                if (chart.SelectedIndex == -1 || chart.SelectedIndex == e.Index)
                {
                    var item = (YearQuote)e.Item;
                    e.Engine.SetFill(chart.ForeColor.ToArgb());
                    e.Engine.SetFont(chart.DataLabel.Style.Font);
                    var lbl = item.Year.ToString();
                    var sz = e.Engine.MeasureString(lbl);
                    e.Engine.DrawString(lbl, new _Point(e.Point.X - 0.5 * sz.Width, e.Point.Y - 0.5 * sz.Height));
                }
            };
            chart.Series.Add(ser);
            chart.AnimationSettings = AnimationSettings.All;

            return chart;
        }

        FlexChart CreateFluctationChart()
        {
            var chart = new FlexChart()
            {
                Dock = DockStyle.Fill,
                ChartType = ChartType.Column,
                BindingX = "Percent",
                Binding = "Days"
            };
            chart.AxisX.Format = @"0\%";
            chart.AxisX.AxisLine = false;
            chart.Header.Content = "Fluctuation";
            chart.ToolTip.Content = "{value} days";
            chart.Series.Add(new Series());

            chart.AnimationSettings = AnimationSettings.All;

            chart.CustomPalette = new List<Brush> { new SolidBrush(palette3[0]) };

            return chart;
        }

        FlexChart CreateDaysChart()
        {
            var chart = new FlexChart()
            {
                Dock = DockStyle.Fill,
                ChartType = ChartType.Bar,
                BindingX = "Outcome",
                Binding = "Days"
            };
            chart.AxisX.AxisLine = false;
            chart.AxisY.MajorGrid = false;
            chart.AxisY.Reversed = true;
            chart.Header.Content = "Days Of Week";
            chart.ToolTip.Content = "{value} days";
            chart.Series.Add(new Series());
            chart.Series[0].SymbolRendering += (s, e) =>
            {
                var items = (List<DaysOutcome>)chart.DataSource;
                float min = items.Min((i) => i.Days);
                float max = items.Max((i) => i.Days);
                var item = (DaysOutcome)e.Item;
                float pct = max == min ? 0 : (item.Days - min) / (max - min);
                var clr = ColorUtils.Interpolate(palette1[0], palette1[1], pct);
                if (e.Index != chart.SelectedIndex)
                    e.Engine.SetStroke(null);
                e.Engine.SetFill(clr.ToArgb());
            };

            chart.AnimationSettings = AnimationSettings.All;
            chart.SelectionMode = ChartSelectionMode.Point;

            return chart;
        }

        FlexChart CreateMonthsChart()
        {
            var chart = new FlexChart()
            {
                Dock = DockStyle.Fill,
                ChartType = ChartType.Column,
                BindingX = "Quarter",
                Binding = "Volume"
            };
            chart.AxisX.AxisLine = false;
            chart.AxisX.MajorTickMarks = TickMark.None;
            chart.AxisX.LabelAngle = 90;
            chart.AxisY.MajorGrid = false;
            chart.AxisY.Labels = false;
            chart.Header.Content = "Monthly Volume";
            chart.Series.Add(new Series());
            chart.Series[0].SymbolRendering += (s, e) =>
            {
                var items = (List<QuarterVolume>)chart.DataSource;
                var min = items.Min((i) => i.Volume);
                var max = items.Max((i) => i.Volume);
                float pct = max == min ? 0 : (float)((items[e.Index].Volume - min) / (max - min));
                var clr = ColorUtils.Interpolate(palette1[0], palette1[1], pct);

                if (e.Index != chart.SelectedIndex)
                    e.Engine.SetStroke(null);
                e.Engine.SetFill(clr.ToArgb());
            };

            chart.AnimationSettings = AnimationSettings.All;
            chart.SelectionMode = ChartSelectionMode.Point;

            return chart;
        }

        FlexChart CreateSelectionChart()
        {
            var chart = new FlexChart()
            {
                Dock = DockStyle.Fill,
                ChartType = ChartType.Area,
                BindingX = "Date",
                Binding = "Close",
            };
            chart.Header.Content = "Monthly Index / Volume";
            chart.Series.Add(new Series());
            chart.Series[0].Style.FillColor = palette1[0];
            chart.Series[0].Style.StrokeColor = palette1[1];
            chart.Series[0].Style.StrokeWidth = 1;
            chart.ToolTip.Content = "{value:n0}";
            chart.PlotMargin = new Padding(60, 0, 0, 0);

            return chart;
        }

        FlexChart CreateOverviewChart(List<Quote> quotes)
        {
            var chart = new FlexChart()
            {
                Dock = DockStyle.Fill,
                ChartType = ChartType.Column,
                BindingX = "Date",
                Binding = "Volume",
                PlotMargin = new Padding(60, 0, 0, 0),
                DataSource = quotes
            };
            chart.Series.Add(new Series());
            chart.Series[0].Style.StrokeWidth = 1;
            chart.AxisX.Max = quotes[quotes.Count - 1].Date.ToOADate();
            chart.AxisX.Min = quotes[0].Date.ToOADate();
            chart.AxisY.Labels = false;
            chart.AxisY.MajorGrid = false;
            chart.Options.ClusterSize = new ElementSize() { SizeType = ElementSizeType.Absolute, Value = 1 };
            chart.CustomPalette = new List<Brush> { new SolidBrush(palette3[0]) };
            chart.ToolTip.Content = null;

            rangeSelector = new RangeSelector(chart);
            rangeSelector.Styles.BarStyle.SelectedAreaColor = Color.FromArgb(56, selectionColor);
            rangeSelector.LowerValueChanged += (s, a) => UpdateSelection(rangeSelector.LowerValue, rangeSelector.UpperValue, true);
            rangeSelector.UpperValueChanged += (s, a) => UpdateSelection(rangeSelector.LowerValue, rangeSelector.UpperValue, true);

            UpdateSelection(rangeSelector.LowerValue, rangeSelector.UpperValue);

            return chart;
        }

        FlexPie CreateProfitChart()
        {
            //--
            var pie = new FlexPie()
            {
                BindingName = "Outcome",
                Binding = "Days",
                StartAngle = 90,
                Dock = DockStyle.Fill,
                SelectionMode = ChartSelectionMode.Point,
                AnimationSettings = AnimationSettings.All
            };
            pie.Header.Content = "Days By Gain/Loss";
            pie.Legend.Position = Position.None;
            pie.DataLabel.Position = PieLabelPosition.Center;
            pie.DataLabel.Content = "{name} {Percent:n0}%";
            pie.ToolTip.Content = "{value} days";
            pie.CustomPalette = new List<Brush> { new SolidBrush( Color.FromArgb(192, palette2[0])),
                new SolidBrush( Color.FromArgb(192, palette2[2])) };

            return pie;
        }

        FlexPie CreateQuarterChart()
        {
            var pie = new FlexPie()
            {
                BindingName = "Quarter",
                Binding = "Volume",
                StartAngle = 90,
                Dock = DockStyle.Fill,
                InnerRadius = 0.4,
                SelectionMode = ChartSelectionMode.Point,
                AnimationSettings = AnimationSettings.All
            };
            pie.Header.Content = "Quarters";
            pie.Legend.Position = Position.None;
            pie.DataLabel.Position = PieLabelPosition.Inside;
            pie.DataLabel.Content = "{name}";
            pie.ToolTip.Content = "{name} : {Percent:n0}%";

            pie.SliceRendering += (s, e) =>
            {
                var items = (List<QuarterVolume>)pie.DataSource;
                var min = items.Min((i) => i.Volume);
                var max = items.Max((i) => i.Volume);

                float pct = max == min ? 0 : (float)((items[e.Index].Volume - min) / (max - min));
                var clr = ColorUtils.Interpolate(palette1[0], palette1[1], pct);

                if (e.Index != pie.SelectedIndex)
                    e.Engine.SetStroke(null);
                e.Engine.SetFill(clr.ToArgb());
            };

            return pie;
        }

        void AddResetButton(params FlexChartBase[] charts)
        {
            foreach (var chart in charts)
            {
                var btn = new Button()
                {
                    Text = "Reset",
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = true,
                    Visible = false,
                    //Font = font
                };
                btn.FlatAppearance.BorderColor = Color.LightGray;
                btn.Click += (s, e) => chart.SelectedIndex = -1;
                chart.SizeChanged += (s, e) => btn.Location = new Point(chart.Size.Width - btn.Width - 4, chart.ClientRectangle.Y + 4);
                chart.Controls.Add(btn);
                chart.SelectionChanged += (s, e) => btn.Visible = chart.SelectedIndex >= 0;
            }
        }

        void ApplyStyle(params FlexChartBase[] charts)
        {
            foreach (var chart in charts)
            {
                chart.Font = new Font("Segoe UI", 8);
                chart.BackColor = backColor;
                chart.ForeColor = foreColor;
                chart.Margin = new Padding(2);

                chart.Header.HorizontalAlignment = HorizontalAlignment.Left;
                chart.Header.Style.Font = new Font("Segoe UI", 12);

                chart.Palette = Palette.Custom;

                chart.SelectionStyle.StrokeColor = selectionColor;
                chart.SelectionStyle.StrokeWidth = 4;

                chart.SelectionChanged += (s, e) => UpdateSelection(rangeSelector.LowerValue, rangeSelector.UpperValue);

                chart.ToolTip.OwnerDraw = true;
                chart.ToolTip.AutoPopDelay = 2000;
                chart.ToolTip.Popup += (s, e) =>
                {
                    var tt = chart.ToolTip.GetToolTip(chart);
                    e.ToolTipSize = TextRenderer.MeasureText(tt, tooltipFont);
                };

                chart.ToolTip.Draw += (s, e) =>
                {
                    var g = e.Graphics;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    using (var b = new SolidBrush(tooltipBackColor))
                    {
                        g.FillRectangle(b, e.Bounds);

                        using (var tb = new SolidBrush(backColor))
                        {
                            g.DrawString(e.ToolTipText, tooltipFont, tb, new PointF(e.Bounds.X + 2, e.Bounds.Y));
                        }
                    }
                };
            }
        }
    }
}
