using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C1.Chart;
using C1.Win.Chart;

#pragma warning disable CS1591  

namespace C1.Win.Chart.Designer.UI
{
    public enum SimpleChartType
    {
        Column,
        Bar,
        Line,
        Scatter,
        LineSymbols,
        Area,
        Spline,
        SplineSymbols,
        SplineArea,
        Bubble,
        Step = ChartType.Step,
        StepSymbols = ChartType.StepSymbols,
        StepArea = ChartType.StepArea,
        //Pie = 101
    }

    public enum YAxis
    {
        Y,
        Y2
    }

    public class FlexChartBaseProperties
    {
        FlexChartBase baseChart;

        internal FlexChartBaseProperties(FlexChartBase baseChart)
        {
            this.baseChart = baseChart;
        }

        [Category("Appearance")]
        public Color BackColor
        {
            get { return baseChart.BackColor; }
            set { baseChart.BackColor = value; }
        }

        public void ResetBackColor()
        {
            baseChart.ResetBackColor();
        }

        [Category("Appearance")]
        public Color ForeColor
        {
            get { return baseChart.ForeColor; }
            set { baseChart.ForeColor = value; }
        }

        public void ResetForeColor()
        {
            baseChart.ResetForeColor();
        }

        [Category("Appearance")]
        public Color PlotColor
        {
            get { return baseChart.PlotStyle.FillColor; }
            set { baseChart.PlotStyle.FillColor = value; }
        }

        [Category("Appearance")]
        [DefaultValue(Palette.Standard)]
        public Palette Palette
        {
            get { return baseChart.Palette; }
            set { baseChart.Palette = value; }
        }

        [Category("Appearance")]
        public Font Font
        {
            get { return baseChart.Font; }
            set { baseChart.Font = value; }
        }

        public void ResetFont()
        {
            baseChart.ResetFont();
        }

        //public DataLabel DataLabel
        //{
        //    get
        //    {
        //        var fc = chart.ActiveChart as FlexChart;
        //        return fc != null ? fc.DataLabel : null;
        //    }
        //}

        public override string ToString()
        {
            return "Chart";
        }
    }

    public class FlexChartProperties : FlexChartBaseProperties
    {
        FlexChart chart;

        internal FlexChartProperties(FlexChart chart) : base(chart)
        {
            this.chart = chart;
        }

        [DefaultValue(SimpleChartType.Column)]
        public SimpleChartType ChartType
        {
            get { return (SimpleChartType)chart.ChartType; }
            set { chart.ChartType = (ChartType)value; }
        }

        [DefaultValue(Stacking.None)]
        public Stacking Stacking
        {
            get{ return chart.Stacking; }
            set{ chart.Stacking = value; }
        }

        /*public Position Legend
        {
            get { return chart.ActiveChart.Legend.Position; }
            set { chart.ActiveChart.Legend.Position = value; }
        }

        public string Header
        {
            get { return chart.ActiveChart.Header.Content; }
            set { chart.ActiveChart.Header.Content = value; }
        }

        public string Footer
        {
            get { return chart.ActiveChart.Footer.Content; }
            set { chart.ActiveChart.Footer.Content = value; }
        }*/

    }

    public class SeriesProperties
    {
        Series series;

        public SeriesProperties(Series series)
        {
            this.series = series;
        }

        [DefaultValue(null)]
        public string Name
        {
            get { return series.Name; }
            set { series.Name = value; }
        }

        [DefaultValue(null)]
        public ChartType? ChartType
        {
            get { return series.ChartType; }
            set { series.ChartType = value; }
        }

        [Category("Appearance")]
        public Color Color
        {
            get{ return GetColor(series.Style.FillColor); }
            set { series.Style.FillColor = series.Style.StrokeColor = value; }
        }

        public void ResetColor()
        {
            series.Style.Fill = series.Style.Stroke = null;
        }

        //public Color Stroke
        //{
        //    get { return GetColor(series.Style.StrokeColor); }
        //    set { series.Style.StrokeColor = value; }
        //}

        [Category("Appearance")]
        [DefaultValue(2)]
        public int StrokeWidth
        {
            get { return (int)series.Style.StrokeWidth; }
            set { series.Style.StrokeWidth = value; }
        }

        [Category("Appearance")]
        [DefaultValue(10)]
        public int SymbolSize
        {
            get { return series.SymbolSize; }
            set { series.SymbolSize = value; }
        }

        [DefaultValue(YAxis.Y)]
        public YAxis YAxis
        {
            get
            {
                return series.AxisY == null ? YAxis.Y : YAxis.Y2;
            }
            set
            {
                if (value == YAxis.Y)
                    series.AxisY = null;
                else
                {
                    var chart = ((ISeries)series).Chart;
                    var axes = chart.GetAxes();
                    IAxis ay2 = null;

                    foreach (var ax in axes)
                    {
                        if (ax.AxisType == AxisType.Y && ax != chart.AxisY)
                        {
                            ay2 = ax;
                            break;
                        }
                    }

                    series.AxisY = ay2!=null ? (Axis)ay2 : new Axis() { Position = Position.Right, AxisLine = false };
                }
            }
        }

        public override string ToString()
        {
            return "Data Series: " + (string.IsNullOrEmpty(series.Name) ? (string.IsNullOrEmpty(series.Binding) ? Chart.Binding : series.Binding) : series.Name);
        }

        FlexChart Chart
        {
            get { return ((ISeries)series).Chart as FlexChart; }
        }

        Color GetColor(Color clr)
        {
            if (clr.IsEmpty)
            {
                var chart = ((ISeries)series).Chart;
                clr = Color.FromArgb((int)(chart.GetColor(chart.Series.IndexOf(series))));
            }

            return clr;
        }
    }

    public class TitleProperties
    {
        ChartTitle title;
        FlexChartBase chart;
        bool header;

        public TitleProperties(ChartTitle title, FlexChartBase chart, bool header)
        {
            this.title = title;
            this.chart = chart;
            this.header = header;
        }

        [DefaultValue(null)]
        public string Content
        {
            get { return title.Content; }
            set { title.Content = value; }
        }

        [Category("Appearance")]
        public Color Color
        {
            get
            {
                var clr = title.Style.StrokeColor;
                if (clr.IsEmpty)
                    clr = chart.ForeColor;
                return clr;
            }
            set { title.Style.StrokeColor = value; }
        }

        public void ResetColor()
        {
            title.Style.Stroke = null;
        }

        [Category("Appearance")]
        [DefaultValue(null)]
        public Font Font
        {
            get { return title.Style.Font; }
            set { title.Style.Font = value; }
        }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Border
        {
            get { return title.Border; }
            set { title.Border = value; }
        }

        [Category("Appearance")]
        public Color BorderFill
        {
            get { return title.BorderStyle.FillColor; }
            set { title.BorderStyle.FillColor = value; }
        }

        [Category("Appearance")]
        public Color BorderStroke
        {
            get { return title.BorderStyle.StrokeColor; }
            set { title.BorderStyle.StrokeColor = value; }
        }

        public override string ToString()
        {
            return header? "Header" : "Footer";
        }
    }

    public class DataLabelBaseProperties
    {
        DataLabelBase dataLabelBase;
        FlexChartBase chart;

        internal DataLabelBaseProperties(DataLabelBase dataLabelBase, FlexChartBase chart)
        {
            this.dataLabelBase = dataLabelBase;
            this.chart = chart;
        }

        [Category("Appearance")]
        public Color Color
        {
            get
            {
                var clr = dataLabelBase.Style.StrokeColor;
                if (clr.IsEmpty)
                    clr = chart.ForeColor;
                return clr;
            }
            set { dataLabelBase.Style.StrokeColor = value; }
        }

        public void ResetColor()
        {
            dataLabelBase.Style.Stroke = null;
        }

        [Category("Appearance")]
        [DefaultValue(null)]
        public Font Font
        {
            get { return dataLabelBase.Style.Font; }
            set { dataLabelBase.Style.Font = value; }
        }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ConnectingLine
        {
            get { return dataLabelBase.ConnectingLine; }
            set { dataLabelBase.ConnectingLine = value; }
        }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Border
        {
            get { return dataLabelBase.Border; }
            set { dataLabelBase.Border = value; }
        }

        [Category("Appearance")]
        public Color BorderFill
        {
            get { return dataLabelBase.BorderStyle.FillColor; }
            set { dataLabelBase.BorderStyle.FillColor = value; }
        }

        [Category("Appearance")]
        public Color BorderStroke
        {
            get { return dataLabelBase.BorderStyle.StrokeColor; }
            set { dataLabelBase.BorderStyle.StrokeColor = value; }
        }

        public override string ToString()
        {
            return "Data Label";
        }
    }

    public class DataLabelProperties : DataLabelBaseProperties
    {
        DataLabel dataLabel;

        internal DataLabelProperties(DataLabel dataLabel, FlexChartBase chart) : base(dataLabel, chart)
        {
            this.dataLabel = dataLabel;
        }

        [TypeConverter(typeof(ContentConverter))]
        [DefaultValue(null)]
        public string Content
        {
            get { return dataLabel.Content; }
            set { dataLabel.Content = value; }
        }

        [DefaultValue(LabelPosition.None)]
        public LabelPosition Position
        {
            get { return dataLabel.Position; }
            set { dataLabel.Position = value; }
        }
    }

    public class PieDataLabelProperties : DataLabelBaseProperties
    {
        PieDataLabel dataLabel;

        internal PieDataLabelProperties(PieDataLabel dataLabel, FlexChartBase chart) : base(dataLabel, chart)
        {
            this.dataLabel = dataLabel;
        }

        [TypeConverter(typeof(ContentConverter))]
        [DefaultValue(null)]
        public string Content
        {
            get { return dataLabel.Content; }
            set { dataLabel.Content = value; }
        }

        [DefaultValue(LabelPosition.None)]
        public PieLabelPosition Position
        {
            get { return dataLabel.Position; }
            set { dataLabel.Position = value; }
        }
    }

    public class AxisProperties
    {
        Axis axis;

        public AxisProperties(Axis axis)
        {
            this.axis = axis;
        }

        [DefaultValue(null)]
        public string Title
        {
            get { return axis.Title; }
            set { axis.Title = value; }
        }

        [DefaultValue(true)]
        public bool Labels
        {
            get { return axis.Labels; }
            set { axis.Labels = value; }
        }

        [DefaultValue(0)]
        public double LabelAngle
        {
            get { return axis.LabelAngle; }
            set { axis.LabelAngle = value; }
        }

        [DefaultValue(null)]
        public string Format
        {
            get { return axis.Format; }
            set { axis.Format = value; }
        }

        [DefaultValue(double.NaN)]
        public double Min
        {
            get { return axis.Min; }
            set { axis.Min = value; }
        }

        [DefaultValue(double.NaN)]
        public double Max
        {
            get { return axis.Max; }
            set { axis.Max = value; }
        }

        [DefaultValue(false)]
        public bool MajorGrid
        {
            get { return axis.MajorGrid; }
            set { axis.MajorGrid = value; }
        }

        [DefaultValue(TickMark.None)]
        public TickMark MajorTicks
        {
            get { return axis.MajorTickMarks; }
            set { axis.MajorTickMarks = value; }
        }

        [DefaultValue(false)]
        public bool Logarithmic
        {
            get { return axis.LogBase == 10; }
            set { axis.LogBase = value? 10 : double.NaN; }
        }

        [DefaultValue(false)]
        public bool Reversed
        {
            get { return axis.Reversed; }
            set { axis.Reversed = value; }
        }

        public override string ToString()
        {
            return axis.AxisType == AxisType.X ? "X-Axis" : "Y-Axis";
        }

        [Category("Appearance")]
        public Color Color
        {
            get
            {
                var clr = axis.Style.StrokeColor;
                if (clr.IsEmpty)
                    clr = ((FlexChartBase)axis.Chart).ForeColor;
                return clr;
            }
            set { axis.Style.StrokeColor = value; }
        }

        public void ResetColor()
        {
            axis.Style.Stroke = null;
        }

        [Category("Appearance")]
        [DefaultValue(null)]
        public Font Font
        {
            get { return axis.Style.Font; }
            set { axis.Style.Font = value; }
        }
    }

    public class LegendProperties
    {
        Legend legend;
        FlexChartBase chart;

        public LegendProperties(Legend legend, FlexChartBase chart)
        {
            this.legend = legend;
            this.chart = chart;
        }

        [DefaultValue(null)]
        public string Title
        {
            get { return legend.Title; }
            set { legend.Title = value; }
        }

        [DefaultValue(Position.Right)]
        public Position Position
        {
            get { return legend.Position; }
            set { legend.Position = value; }
        }

        [DefaultValue(Orientation.Auto)]
        public Orientation Orientation
        {
            get { return legend.Orientation; }
            set { legend.Orientation = value; }
        }

        [DefaultValue(false)]
        public bool Reversed
        {
            get { return legend.Reversed; }
            set { legend.Reversed = value; }
        }

        [Category("Appearance")]
        public Color ForeColor
        {
            get
            {
                var clr = legend.Style.StrokeColor;
                if (clr.IsEmpty)
                    clr = chart.ForeColor;
                return clr;
            }
            set { legend.Style.StrokeColor = value; }
        }

        public void ResetForeColor()
        {
            legend.Style.Stroke = null;
        }

        [Category("Appearance")]
        [DefaultValue(null)]
        public Font Font
        {
            get { return legend.Style.Font; }
            set { legend.Style.Font = value; }
        }

        public override string ToString()
        {
            return "Legend";
        }
    }

    public class FlexPieProperties : FlexChartBaseProperties
    {
        FlexPie pie;

        internal FlexPieProperties(FlexPie pie) : base(pie)
        {
            this.pie = pie;
        }

        public double InnerRadius
        {
            get { return pie.InnerRadius; }
            set { pie.InnerRadius = value; }
        }

        public double StartAngle
        {
            get { return pie.StartAngle; }
            set { pie.StartAngle = value; }
    }

        public double Offet
        {
            get { return pie.Offset; }
            set { pie.Offset = value; }
}

        public override string ToString()
        {
            return "Pie Options";
        }
    }
}