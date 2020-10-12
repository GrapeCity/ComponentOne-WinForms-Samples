using C1.Win.Sparkline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Sparkline
{
    public partial class Overview : C1DemoForm
    {
        SparklineCommonProperties _sparklineCommonProperties;

        private class SparklineCommonProperties
        {
            private C1Sparkline _lineSparkline;
            private C1Sparkline _columnSparkline;
            private C1Sparkline _winLossSparkline;

            public SparklineCommonProperties(C1Sparkline lineSparkline, C1Sparkline columnSparkline, C1Sparkline winLossSparkline)
            {
                _lineSparkline = lineSparkline;
                _columnSparkline = columnSparkline;
                _winLossSparkline = winLossSparkline;
            }

            /// <summary>
            /// Gets or sets the color of the axis.
            /// </summary>
            public Color AxisColor
            {
                get
                {
                    return _lineSparkline.Styles.AxisColor;
                }
                set
                {
                    _lineSparkline.Styles.AxisColor = value;
                    _columnSparkline.Styles.AxisColor = value;
                    _winLossSparkline.Styles.AxisColor = value;
                }
            }

            /// <summary>
            /// Gets or sets the corresponding data.
            /// </summary>
            public object Data
            {
                get
                {
                    return _lineSparkline.Data;
                }
                set
                {
                    _lineSparkline.Data = value;
                    _columnSparkline.Data = value;
                    _winLossSparkline.Data = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that indicates whether the horizontal axis is displayed.
            /// </summary>
            public bool DisplayXAxis
            {
                get
                {
                    return _lineSparkline.DisplayXAxis;
                }
                set
                {
                    _lineSparkline.DisplayXAxis = value;
                    _columnSparkline.DisplayXAxis = value;
                    _winLossSparkline.DisplayXAxis = value;
                }
            }

            /// <summary>
            /// Gets or sets the color of the first data point.
            /// </summary>
            public Color FirstMarkerColor
            {
                get
                {
                    return _lineSparkline.Styles.FirstMarkerColor;
                }
                set
                {
                    _lineSparkline.Styles.FirstMarkerColor = value;
                    _columnSparkline.Styles.FirstMarkerColor = value;
                    _winLossSparkline.Styles.FirstMarkerColor = value;
                }
            }

            /// <summary>
            /// Gets or sets the color of the highest data point.
            /// </summary>
            public Color HighMarkerColor
            {
                get
                {
                    return _lineSparkline.Styles.HighMarkerColor;
                }
                set
                {
                    _lineSparkline.Styles.HighMarkerColor = value;
                    _columnSparkline.Styles.HighMarkerColor = value;
                    _winLossSparkline.Styles.HighMarkerColor = value;
                }
            }

            /// <summary>
            /// Gets or sets the color of the last data point.
            /// </summary>
            public Color LastMarkerColor
            {
                get
                {
                    return _lineSparkline.Styles.LastMarkerColor;
                }
                set
                {
                    _lineSparkline.Styles.LastMarkerColor = value;
                    _columnSparkline.Styles.LastMarkerColor = value;
                    _winLossSparkline.Styles.LastMarkerColor = value;
                }
            }

            /// <summary>
            /// Gets or sets the color of the lowest data point.
            /// </summary>
            public Color LowMarkerColor
            {
                get
                {
                    return _lineSparkline.Styles.LowMarkerColor;
                }
                set
                {
                    _lineSparkline.Styles.LowMarkerColor = value;
                    _columnSparkline.Styles.LowMarkerColor = value;
                    _winLossSparkline.Styles.LowMarkerColor = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies the color of the data markers.
            /// </summary>
            public Color MarkersColor
            {
                get
                {
                    return _lineSparkline.Styles.MarkersColor;
                }
                set
                {
                    _lineSparkline.Styles.MarkersColor = value;
                    _columnSparkline.Styles.MarkersColor = value;
                    _winLossSparkline.Styles.MarkersColor = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies the color of the negative data points.
            /// </summary>
            public Color NegativeColor
            {
                get
                {
                    return _lineSparkline.Styles.NegativeColor;
                }
                set
                {
                    _lineSparkline.Styles.NegativeColor = value;
                    _columnSparkline.Styles.NegativeColor = value;
                    _winLossSparkline.Styles.NegativeColor = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies the color sparkline.
            /// </summary>
            public Color SeriesColor
            {
                get
                {
                    return _lineSparkline.Styles.SeriesColor;
                }
                set
                {
                    _lineSparkline.Styles.SeriesColor = value;
                    _columnSparkline.Styles.SeriesColor = value;
                    _winLossSparkline.Styles.SeriesColor = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that indicates whether the first data point is formatted differently.
            /// </summary>
            public bool ShowFirst
            {
                get
                {
                    return _lineSparkline.ShowFirst;
                }
                set
                {
                    _lineSparkline.ShowFirst = value;
                    _columnSparkline.ShowFirst = value;
                    _winLossSparkline.ShowFirst = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies whether the data points with the highest value are formatted differently.
            /// </summary>
            public bool ShowHigh
            {
                get
                {
                    return _lineSparkline.ShowHigh;
                }
                set
                {
                    _lineSparkline.ShowHigh = value;
                    _columnSparkline.ShowHigh = value;
                    _winLossSparkline.ShowHigh = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that indicates whether the last data point is formatted differently.
            /// </summary>
            public bool ShowLast
            {
                get
                {
                    return _lineSparkline.ShowLast;
                }
                set
                {
                    _lineSparkline.ShowLast = value;
                    _columnSparkline.ShowLast = value;
                    _winLossSparkline.ShowLast = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies whether the data points with the lowest value are formatted differently.
            /// </summary>
            public bool ShowLow
            {
                get
                {
                    return _lineSparkline.ShowLow;
                }
                set
                {
                    _lineSparkline.ShowLow = value;
                    _columnSparkline.ShowLow = value;
                    _winLossSparkline.ShowLow = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies whether data markers are displayed.
            /// </summary>
            public bool ShowMarkers
            {
                get
                {
                    return _lineSparkline.ShowMarkers;
                }
                set
                {
                    _lineSparkline.ShowMarkers = value;
                    _columnSparkline.ShowMarkers = value;
                    _winLossSparkline.ShowMarkers = value;
                }
            }

            /// <summary>
            /// Gets or sets a value that specifies whether the negative data points are formatted differently.
            /// </summary>
            public bool ShowNegative
            {
                get
                {
                    return _lineSparkline.ShowNegative;
                }
                set
                {
                    _lineSparkline.ShowNegative = value;
                    _columnSparkline.ShowNegative = value;
                    _winLossSparkline.ShowNegative = value;
                }
            }
        }

        public Overview()
        {
            PinProperties = true;

            InitializeComponent();

            _sparklineCommonProperties = new SparklineCommonProperties(lineSparkline, columnSparkline, winLossSparkline);

            AddProperty("SeriesColor", _sparklineCommonProperties);
            AddProperty("DisplayXAxis", _sparklineCommonProperties);
            AddProperty("AxisColor", _sparklineCommonProperties);
            AddProperty("ShowMarkers", _sparklineCommonProperties);
            AddProperty("MarkersColor", _sparklineCommonProperties);
            AddProperty("ShowFirst", _sparklineCommonProperties);
            AddProperty("FirstMarkerColor", _sparklineCommonProperties);
            AddProperty("ShowLast", _sparklineCommonProperties);
            AddProperty("LastMarkerColor", _sparklineCommonProperties);
            AddProperty("ShowHigh", _sparklineCommonProperties);
            AddProperty("HighMarkerColor", _sparklineCommonProperties);
            AddProperty("ShowLow", _sparklineCommonProperties);
            AddProperty("LowMarkerColor", _sparklineCommonProperties);
            AddProperty("ShowNegative", _sparklineCommonProperties);
            AddProperty("NegativeColor", _sparklineCommonProperties);
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            _sparklineCommonProperties.Data = new List<double>() { 1.0, -2.0, -1.0, 6.0, 8.0, -4.0, 3.0, 4.0 };
            _sparklineCommonProperties.ShowFirst = true;
            _sparklineCommonProperties.ShowHigh = true;
            _sparklineCommonProperties.ShowNegative = true;
        }
    }
}
