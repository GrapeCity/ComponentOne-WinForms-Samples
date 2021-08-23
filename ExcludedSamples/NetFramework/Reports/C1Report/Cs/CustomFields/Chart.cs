//------------------------------------------------------------------------------------
// C1\Win\C1Report\CustomFields\Chart.cs
//
// Custom C1Report field: Chart
//
// This class inherits from C1Report.Field and uses the C1Chart control
// to embed databound charts in reports.
//
// Object Model:
//
// public ChartTypeEnum ChartType
//	Gets or sets the chart type. Available types are Bar, Area, Scatter, and Pie.
// 
// public string RecordSource (optional)
//  Gets or sets a Sql statement to use and retrieve data for the chart. 
//  If provided, data is retrieved using the parent report's ConnectionString.
//  If omitted, data is retrieved directly from the parent report. In this case,
//  the data is automatically filtered according to the current grouping scope
//  (e.g. a chart in a 'Category' group header would contain data only for the 
//  current category).
//  
// public string DataX
//	Gets or sets a string containing one field with the chart labels. Labels are
//  displayed along the X axis or along with pie slices. 
//	For example: DataX = "ProductName"
//
// public string DataY
//	Gets or sets a string containing one or more fields with the data to plot on
//  the chart. For example, DataY = "UnitPrice;UnitsInStock"
//
// public string DataYLabels
//  Gets or sets a string containing text labels to use for DataY.
//  If null or empty, field names specified by DataY are used.
//
// public bool RadialLabels
//	Adds radial labels to pie charts (instead of a legend, Pie charts only).
//
// public bool ShowPercentages
//	Adds percentage labels to pie chart labels (Pie charts only).
//
// public bool GridLines
//	Adds gridlines to charts (except Pie charts).
//
// public bool Boxed
//	Draws a box around the plot area.
//
// public bool Use3D
//	Applies 3D effects to the charts.
//
// public Color DataColor
//	Specifies the color for the chart bars, lines, symbols, or pie slices.
//	If the chart contains more than one series (or pie slices) then additional
//	colors are generated automatically by making the base color lighter.
//  This property has no effect if the Palette property is used.
//
// public string Palette
//	Specifies a collection of colors to be used for each series (or pie slices).
//  The collection is specified as a string with color names. For example:
//  Palette = "Red;Green;Blue".
//
// public C1.Win.C1Chart.C1Chart ChartControl
//  Provides access to the underlying C1Chart control and its object model.
//
// public ImageTypeEnum ImageType
//  Gets or sets the type of image to use when exporting the chart to html. 
//
// public ShowLegendEnum ShowLegend
//  Gets or sets whether the chart should include a legend.
//
// Copyright (C) ComponentOne LLC
//------------------------------------------------------------------------------------
// Status   Date        By          Comments
// Created	Jun 2004	Bernardo	-
// Modified Jan 2005	Bernardo	Allow placement on group footer sections
// Modified Mar 2005	Bernardo	Added FormatX, FormatY properties to allow 
//									customization of axis label formats.
// Modified Jul 2006	Bernardo	Added ImageType, ShowLegend properties.
//
// Modified Aug 2010    Dima        Added the ability to use C1Chart dynamically
//                                  without a static reference to the chart assembly
//                                  (see DYNAMIC_ASMS). (C#4.0/VS2010 and later.)
// Modified Aug 2010    Dima        Added DataYLabels.
// Modified Jan 2012    Dima        Added:
//                                  LabelCompass (default none) - breaking for radial charts, must be explicitly set to Radial
//                                  LabelOffset (default 20)
//                                  LabelConnected (default false) - breaking for radial charts
//                                  LabelAutoArrangeMethod (default decimation)
//                                  LabelAutoArrangeOptions
//                                  OutlineColor
//                                  PieStartAngle (default 0)
//                                  PieClockwise (default false)
//                                  PieInnerRadius (default 0)
//                                  View3dDepth (default 10) - breaking, was 20 for pie charts, 5 for others
//                                  View3dElevation (default 45)
//                                  View3dRotation (default 45)
//                                  View3dShading (default none)
//------------------------------------------------------------------------------------
#if WPF
#define DYNAMIC_ASMS // undefine this and add a reference to C1.Win.C1Chart.4 assembly to use static reference
#endif

using System;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using C1.C1Preview;
using C1.C1Report;
#if !DYNAMIC_ASMS
using C1.Win.C1Chart;
#endif

namespace C1.C1Report.CustomFields
{

#if DYNAMIC_ASMS
    /// <summary>
    /// The Chart Class inherits from <see cref="Field"/> and uses the 
    /// <c>C1Chart</c> control to embed data bound charts in reports.
    /// </summary>
#else
    /// <summary>
    /// The Chart Class inherits from <see cref="Field"/> and uses the 
    /// <see cref="C1Chart"/> control to embed data bound charts in reports.
    /// </summary>
#endif
#if GRAPECITY
    [Description("グラフ")]
#else
    [Description("Chart")]
#endif
    public class Chart : C1.C1Report.Field
    {
        #region Enums
        /// <summary>
        /// Specifies the type of chart to display.
        /// </summary>
        public enum ChartTypeEnum
        {
            /// <summary>
            /// A chart that draws each series as a bar in a cluster.
            /// </summary>
            Bar,
            /// <summary>
            /// A chart that draws each series as connected points of data, 
            /// filled below the points.
            /// </summary>
            Area,
            /// <summary>
            /// A chart that uses two values to represent each data point.
            /// </summary>
            Scatter,
            /// <summary>
            /// A chart that draws each series as a slice in a pie.
            /// </summary>
            Pie,
            /// <summary>
            /// A chart that represents data as data points connected with line.
            /// </summary>
            Line,
            /// <summary>
            /// A chart that draws each series as a vertical bar in a cluster.
            /// </summary>
            Column,
			/// <summary>
			/// A chart that draws each series as a form of a XY Plot chart.
			/// </summary>
			Step,
			/// <summary>
			/// A chart that takes a collection of raw data values and plots the frequency distribution.
			/// </summary>
			Histogram,
			/// <summary>
			/// A chart that draws each series as a radar line.
			/// </summary>
			Radar,
			/// <summary>
			/// A chart that draws each series as (theta,r), 
			/// where theta is amount of rotation from the origin and r is the distance from the origin.
			/// </summary>
			Polar,
        }

        /// <summary>
        /// Specifies the type of image to generate.
        /// </summary>
        public enum ImageTypeEnum
        {
            /// <summary>
            /// Enhanced Windows metafile image format (EMF).
            /// </summary>
            Emf,
            /// <summary>
            /// W3C Portable Network Graphics (PNG) image format.
            /// </summary>
            Png,
            /// <summary>
            /// Graphics Interchange Format (GIF) image format.
            /// </summary>
            Gif,
            /// <summary>
            /// Joint Photographic Experts Group (JPEG) image format.
            /// </summary>
            Jpeg,
            /// <summary>
            /// Bitmap image format (BMP).
            /// </summary>
            Bmp
        }

        /// <summary>
        /// Specifies whether a legend should be displayed.
        /// </summary>
        public enum ShowLegendEnum
        {
            /// <summary>
            /// Show legend if there are two or more series.
            /// </summary>
            Automatic,
            /// <summary>
            /// Always show legend.
            /// </summary>
            Always,
            /// <summary>
            /// Never show legend.
            /// </summary>
            Never
        }

        /// <summary>
        /// Specifies how data should be aggregated for charting.
        /// </summary>
        public enum AggregateEnum
        {
            /// <summary>
            /// Raw values (no aggregation).
            /// </summary>
            None,
            /// <summary>
            /// Sum all values for each point.
            /// </summary>
            Sum,
            /// <summary>
            /// Number of values for each point.
            /// </summary>
            Count,
            /// <summary>
            /// Average all values for each point.
            /// </summary>
            Average,
            /// <summary>
            /// Get the minimum value for each point.
            /// </summary>
            Minimum,
            /// <summary>
            /// Get the maximum value for each point.
            /// </summary>
            Maximum,
            /// <summary>
            /// Gets the variance of the values for each point (sample).
            /// </summary>
            Variance,
            /// <summary>
            /// Gets the variance of the values for each point (population).
            /// </summary>
            VariancePop,
            /// <summary>
            /// Gets the standard deviation of the values for each point (sample).
            /// </summary>
            StandardDeviation,
            /// <summary>
            /// Gets the standard deviation of the values for each point (population).
            /// </summary>
            StandardDeviationPop,
        }

        /// <summary>
        /// Specifies data label location relative to the data point.
        /// </summary>
        public enum LabelCompassEnum
        {
            /// <summary>
            /// Label is not shown.
            /// </summary>
            None,
            /// <summary>
            /// Label is to the north of the data point.
            /// </summary>
            North,
            /// <summary>
            /// Label is to the north east of the data point.
            /// </summary>
            NorthEast,
            /// <summary>
            /// Label is to the east of the data point.
            /// </summary>
            East,
            /// <summary>
            /// Label is to the south east of the data point.
            /// </summary>
            SouthEast,
            /// <summary>
            /// Label is to the south of the data point.
            /// </summary>
            South,
            /// <summary>
            /// Label is to the south west of the data point.
            /// </summary>
            SouthWest,
            /// <summary>
            /// Label is to the west of the data point.
            /// </summary>
            West,
            /// <summary>
            /// Label is to the north west of the data point.
            /// </summary>
            NorthWest,
            /// <summary>
            /// In a pie chart, label is directly away from the center of the chart.
            /// </summary>
            Radial,
            /// <summary>
            /// Label is perpendicularly away from the plot line.
            /// </summary>
            Orthogonal,
            /// <summary>
            /// Automatic label arrangement.
            /// </summary>
            Auto,
            /// <summary>
            /// Label is perpendicular away from the plot line, with text oriented along that line.
            /// </summary>
            RadialText,
        }

        /// <summary>
        /// Specifies the type of shading used when rendering 3D charts.
        /// </summary>
        public enum ShadingEnum
        {
            /// <summary>
            /// No special 3D color is applied.
            /// </summary>
            None,
            /// <summary>
            /// 3D color is lighter than front color.
            /// </summary>
            ColorLight,
            /// <summary>
            /// 3D color is darker than front color.
            /// </summary>
            ColorDark,
        }

        /// <summary>
        /// Flags controlling which label positions are allowed when labels are arranged automatically.
        /// </summary>
        [Flags]
        public enum AutoLabelArrangementOptions
        {
            /// <summary>
            /// //     Allows any label position.
            Default = 0,
            /// <summary>
            /// Allows top label position.
            /// </summary>
            Top = 1,
            /// <summary>
            /// Allows left label position.
            /// </summary>
            Left = 2,
            /// <summary>
            /// Allows bottom label position.
            /// </summary>
            Bottom = 4,
            /// <summary>
            /// Allows right label position.
            /// </summary>
            Right = 8,
            /// <summary>
            /// Allows top right label position.
            /// </summary>
            TopRight = 16,
            /// <summary>
            /// Allows bottom right label position.
            /// </summary>
            BottomRight = 32,
            /// <summary>
            /// Allows bottom left label position.
            /// </summary>
            BottomLeft = 64,
            /// <summary>
            /// Allows top left label position.
            /// </summary>
            TopLeft = 128,
            /// <summary>
            /// Labels should not cover data points.
            /// </summary>
            UseDataPoints = 256,
        }

        /// <summary>
        /// Specifies the label auto arrangement method.
        /// </summary>
        public enum AutoLabelArrangementMethodEnum
        {
            /// <summary>
            /// Remove labels which cannot be placed without overlapping.
            /// </summary>
            Decimation,
            /// <summary>
            /// Try to position all labels avoiding overlapping.
            /// </summary>
            FindingOptimum,
        }
        #endregion

        #region Private data
#if DYNAMIC_ASMS
        private dynamic _chart;
#else
        private C1.Win.C1Chart.C1Chart _chart;
#endif
        private Image _image;			// cached chart image (for design-time)
        private ChartTypeEnum _chartType;		// chart type
        private Color _dataColor;		// chart color (used when no palette is sepcified)
        private string _colorNames;	    // string of color names (e.g. Red;Green;Blue)
        private string _dataX;			// label field
        private string _dataY;			// data field (comma-delimited)
        private string _dataYLabels;    // data lables (semicolon-delimited)
        private bool _gridLines;		// show gridlines
        private bool _boxed;			// draw box around chart
        private bool _use3D;			// use 3D effects
        private bool _radialLabels;	    // radial labels (pie charts only)
        private bool _showPercent;	    // show percentages (pie charts only)
        private string _recordSource;	// recordsource (override main report)
        private Color[] _palette;		// color palette
        private double _xMin, _xMax;	// explicit scale for x axis <<B168>>
        private double _yMin, _yMax;	// explicit scale for y axis <<B168>>
        private string _formatX;		// explicit format fox x axis labels <<B178>>
        private string _formatY;		// explicit format fox y axis labels <<B178>>
        private ImageTypeEnum _imageType;		// image format to use when creating the chart <<B182>>
        private ShowLegendEnum _showLegend;    // whether to show the chart legend <<B221>>
        private AggregateEnum _aggregate;     // how to aggregate the chart data
        // labels:
        private LabelCompassEnum _labelCompass = LabelCompassEnum.None;
        private int _labelOffset = 20;
        private bool _labelConnected = false;
        private AutoLabelArrangementMethodEnum _labelAutoArrangeMethod = AutoLabelArrangementMethodEnum.Decimation;
        private AutoLabelArrangementOptions _labelAutoArrangeOptions = AutoLabelArrangementOptions.Default;
        // outlines (stroking):
        private bool _showOutline = true;
        private Color _outlineColor = Color.Empty;
        // pie:
        private int _pieStartAngle = 0;
        private bool _pieClockwise = false;
        private int _pieInnerRadius = 0;
        // 3d:
        private int _view3dDepth = 10;
        private int _view3dElevation = 45;
        private int _view3dRotation = 45;
        private ShadingEnum _view3dShading = ShadingEnum.ColorDark;
        // misc:
        private int _seriesOffset = 0;
		// options:
		private RadarOptions _radar = new RadarOptions();
	    private PolarOptions _polar = new PolarOptions();
	    private HistogramOptions _histogram = new HistogramOptions();
        #endregion

        #region ctors
        /// <summary>
        /// Initializes a new instance of the <b>C1Chart</b> class.
        /// </summary>
        public Chart()
        {
            // initialize instance
#if DYNAMIC_ASMS
            ChartControl = DynLoader.CreateC1Chart();
#else
            ChartControl = new C1.Win.C1Chart.C1Chart();
#endif

#if WPF
	        BackColor = System.Windows.Media.Colors.Transparent;
#else
            BackColor = Color.White;
#endif
            PictureAlign = PictureAlignEnum.Stretch;
            ChartType = ChartTypeEnum.Bar;
            DataColor = Color.Navy;
            GridLines = false;
            RadialLabels = false;
            ShowPercentages = true;
            XMin = -1;
            XMax = -1;
            YMin = -1;
            YMax = -1;
            _formatX = string.Empty;
            _formatY = string.Empty;
            _imageType = ImageTypeEnum.Emf;

	        _radar.Owner = this;
	        _polar.Owner = this;
	        _histogram.Owner = this;
        }

        /// <summary>
        /// Overridden to clone the inner C1Chart control in the field so the 
        /// clone doesn't reference the original field's chart.
        /// </summary>
        /// <returns>A deep clone of the <see cref="Chart"/> field.</returns>
        public override object Clone()
        {
            Chart clone = base.Clone() as Chart;
#if DYNAMIC_ASMS
            clone.ChartControl = DynLoader.CreateC1Chart();
#else
            clone.ChartControl = new C1.Win.C1Chart.C1Chart();
#endif

			// Clone the options for specific chart. Cannot set the options property directly,
			// for now the origin and clone has the same options object, set the options of clone 
			// will reset the owner of the riginal options to null.
	        clone._radar = Radar.Clone(clone) as RadarOptions;
	        clone._polar = Polar.Clone(clone) as PolarOptions;
	        clone._histogram = Histogram.Clone(clone) as HistogramOptions;

            return clone;
        }
        #endregion

        #region Public object model

	    /// <summary>
	    /// Gets or sets options for Radar chart.
	    /// </summary>
	    [Category("Chart")]
		[Description("Gets or sets options for Radar chart.")]
	    public RadarOptions Radar
	    {
		    get { return _radar; }
		    set
		    {
			    if (_radar != null) _radar.Owner = null;
			    _radar = value;
			    if (_radar != null) _radar.Owner = this;
			    OnPropertyChanged();
		    }
	    }

		/// <summary>
		/// Gets or sets options for Polar chart.
		/// </summary>
		[Category("Chart")]
		[Description("Gets or sets options for Polar chart.")]
		public PolarOptions Polar
		{
			get { return _polar; }
			set
			{
				if (_polar != null) _polar.Owner = null;
				_polar = value;
				if (_polar != null) _polar.Owner = this;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets options for Histogram chart.
		/// </summary>
		[Category("Chart")]
		[Description("Gets or sets options for Histogram chart.")]
		public HistogramOptions Histogram
		{
			get { return _histogram; }
			set
			{
				if (_histogram != null) _histogram.Owner = null;
				_histogram = value;
				if (_histogram != null) _histogram.Owner = this;
				OnPropertyChanged();
			}
		}

        /// <summary>
        /// Gets or sets the chart type. Available types are Area, Bar, Pie, Scatter, Line and Column.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(ChartTypeEnum.Bar)]
        [Description("Specifies the chart type (bar, pie and so on).")]
        public ChartTypeEnum ChartType
        {
            get { return _chartType; }
            set
            {
                _chartType = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This property only applies to Pie charts. 
        /// It causes the field to add radial labels attached to the pie slices 
        /// instead of a legend.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("For Pie charts, adds radial labels to the pie slices instead of a legend.")]
        public bool RadialLabels
        {
            get { return _radialLabels; }
            set
            {
                _radialLabels = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This property only applies to Pie charts. 
        /// It causes the field to add percentage labels to the pie slices.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(true)]
        [Description("For Pie charts, adds percentage labels to the pie slices.")]
        public bool ShowPercentages
        {
            get { return _showPercent; }
            set
            {
                _showPercent = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a Sql statement to use and retrieve data for the chart.
        /// </summary>
        /// <remarks>
        /// If provided, data is retrieved using the parent report's ConnectionString. 
        /// If omitted, data is retrieved directly from the parent report. 
        /// In this latter case, the data is automatically filtered according 
        /// to the current grouping scope (e.g. a chart in a 'Category' 
        /// group header would contain data only for the current category).
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
#if CLR40
        [Editor("C1.C1Report.Design.ExpressionEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
#else
        [Editor(typeof(C1.C1Report.Design.ExpressionEditor), typeof(UITypeEditor))]
#endif
        [Description("Sql statement used to retrieve data for the chart.")]
        public string RecordSource
        {
            get { return _recordSource; }
            set
            {
                _recordSource = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a string containing one field with the chart labels.
        /// </summary>
        /// <remarks>
        /// Labels are displayed along the X axis or along with pie slices. For example:
        /// <example>chartField.DataX = "ProductName"</example>
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
#if CLR40
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
#else
        [Editor(typeof(C1.C1Report.Design.TextFieldEditor), typeof(UITypeEditor))]
#endif
        [Description("The name of a field used to display chart labels along the X axis (or along with pie slices).")]
        public string DataX
        {
            get { return _dataX; }
            set
            {
                _dataX = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Gets or sets a string containing one or more fields with the data to plot on the chart.
        /// </summary>
        /// <remarks>
        /// If multiple fields are provided, they must be separated with semicolons. For example:
        /// <example>chartField.DataY = "UnitPrice;UnitsInStock"</example>
        /// You can also use regular VBScript expressions instead of simple field names. 
        /// For example, to plot sales and sales taxes as two separate series, you could use:
        /// <example>chartField.DataY = "Sales;Sales * 0.085"</example>
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
#if CLR40
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
#else
        [Editor(typeof(C1.C1Report.Design.TextFieldEditor), typeof(UITypeEditor)) ]
#endif
        [Description("Names of fields used to plot chart data. Separate multiple names with semicolons, e.g. \"UnitPrice;UnitsInStock\".")]
        public string DataY
        {
            get { return _dataY; }
            set
            {
                _dataY = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a string containing text labels to use for <see cref="DataY"/>.
        /// <para>
        /// If null or empty, field names specified by <see cref="DataY"/> are used.
        /// </para>
        /// <para>
        /// If multiple labels are provided, they must be separated with semicolons. For example:
        /// <example>chartField.DataYLabels = "Unit Price;Units In Stock"</example>
        /// </para>
        /// </summary>
        [Category("Chart")]
        [DefaultValue("")]
#if CLR40
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
#else
        [Editor(typeof(C1.C1Report.Design.TextFieldEditor), typeof(UITypeEditor))]
#endif
        [Description("Text labels to use for DataY instead of field names. Separate multiple strings with semicolons, e.g. \"Unit price;Units in stock\".")]
        public string DataYLabels
        {
            get { return _dataYLabels; }
            set
            {
                _dataYLabels = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Specifies the color for the chart bars, lines, symbols, or pie slices.
        /// </summary>
        /// <remarks>
        /// If the chart contains more than one series (or pie slices) 
        /// then additional colors are generated automatically by making 
        /// the base color lighter. To control the color of each series in 
        /// a multi-series chart, use the <see cref="Palette"/> property instead.
        /// </remarks>
        [Category("Chart")]
        [DefaultValue(typeof(Color), "SteelBlue")]
        [Description("Base color for chart figures. Additional colors are generated by lightening this color (use Palette to override that).")]
        public Color DataColor
        {
            get { return _dataColor; }
            set
            {
                _dataColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Specifies a collection of colors to be used for each series (or pie slices).
        /// </summary>
        /// <remarks>
        /// The collection is specified as a string containing a list of color names, 
        /// delimited by semicolons. For example:
        /// <example>chartField.Palette = "Red;Green;Blue"</example>
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
        [Description("Semicolon-delimited list of colors used for multiple series (or pie slices). Overrides DataColor.")]
        public string Palette
        {
            get { return _colorNames; }
            set
            {
                _colorNames = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Adds gridlines to charts. This property does not apply to Pie charts.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("Indicates whether to draw gridlines (does not apply to pie charts).")]
        public bool GridLines
        {
            get { return _gridLines; }
            set
            {
                _gridLines = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Draws a box around the plot area.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("Indicates whether to draw a box around the plot area.")]
        public bool Boxed
        {
            get { return _boxed; }
            set
            {
                _boxed = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Applies 3D effects to the charts.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("Indicates whether to use 3D effects when drawing the chart.")]
        public bool Use3D
        {
            get { return _use3D; }
            set
            {
                _use3D = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the minimum value for the X axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(-1.0)]
        [Description("Minimum value for the X axis.")]
        public double XMin // <<B168>>
        {
            get { return _xMin; }
            set
            {
                if (value > _xMax)
                    throw new ArgumentOutOfRangeException("value", value, "Max must not be less than min.");

                _xMin = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the maximum value for the X axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(-1.0)]
        [Description("Maximum value for the X axis.")]
        public double XMax // <<B168>>
        {
            get { return _xMax; }
            set
            {
                if (value < _xMin)
                    throw new ArgumentOutOfRangeException("value", value, "Max must not be less than min.");

                _xMax = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the minimum value for the Y axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(-1.0)]
        [Description("Minimum value for the Y axis.")]
        public double YMin // <<B168>>
        {
            get { return _yMin; }
            set
            {
                if (value > _yMax)
                    throw new ArgumentOutOfRangeException("value", value, "Max must not be less than min.");

                _yMin = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the maximum value for the Y axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(-1.0)]
        [Description("Maximum value for the Y axis.")]
        public double YMax // <<B168>>
        {
            get { return _yMax; }
            set
            {
                if (value < _yMin)
                    throw new ArgumentOutOfRangeException("value", value, "Max must not be less than min.");

                _yMax = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the annotation format for the X axis.
        /// </summary>
        /// <remarks>
        /// <para>This property controls the format used to display values along the X axis of the chart.</para>
        /// <para>The value is a regular .NET format string that is used to format numeric or <see cref="DateTime"/> 
        /// values. For details on how to specify format strings, see the <see cref="IFormattable"/> interface.</para>
        /// <para>Typical values used for formatting numeric values are "F2" (floating point with two decimals),
        /// "C" (currency), and "#,##0.00" (thousand-separated values with two decimals).</para>
        /// See also <b>C1.Win.C1Chart.Axis.AnnoFormat</b>.
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
        [Description("A .NET format string used to display values along the X axis of the chart.")]
        public string FormatX // <<B178>>
        {
            get { return _formatX; }
            set
            {
                _formatX = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the annotation format for the Y axis. 
        /// </summary>
        /// <remarks>
        /// <para>This property controls the format used to display values along the Y axis of the chart.</para>
        /// <para>The value is a regular .NET format string that is used to format numeric or <see cref="DateTime"/> 
        /// values. For details on how to specify format strings, see the <see cref="IFormattable"/> interface.</para>
        /// <para>Typical values used for formatting numeric values are "F2" (floating point with two decimals),
        /// "C" (currency), and "#,##0.00" (thousand-separated values with two decimals).</para>
        /// See also <b>C1.Win.C1Chart.Axis.AnnoFormat</b>.
        /// </remarks>
        [Category("Chart")]
        [DefaultValue("")]
        [Description("A .NET format string used to display values along the Y axis of the chart.")]
        public string FormatY // <<B178>>
        {
            get { return _formatY; }
            set
            {
                _formatY = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the location of labels relative to data points. If set to Auto,
        /// several AutoLabel* properties provide additional options.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(LabelCompassEnum.None)]
        [Description("Location of labels relative to data points. If Auto, AutlLabel* properties provide additional options.")]
        public LabelCompassEnum LabelCompass
        {
            get { return _labelCompass; }
            set
            {
                _labelCompass = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the distance between a label and its associated data point (maximum distance when auto arranging labels).
        /// </summary>
        [Category("Chart")]
        [DefaultValue(20)]
        [Description("Distance between a label and its associated data point (maximum distance when auto arranging labels).")]
        public int LabelOffset
        {
            get { return _labelOffset; }
            set
            {
                _labelOffset = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a connecting line is drawn from a label to its associated data point.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("Indicates whether a connecting line is drawn from a label to its associated data point.")]
        public bool LabelConnected
        {
            get { return _labelConnected; }
            set
            {
                _labelConnected = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets method used to auto arrange labels (used only if LabelCompass is Auto).
        /// </summary>
        [Category("Chart")]
        [DefaultValue(AutoLabelArrangementMethodEnum.Decimation)]
        [Description("Method used to auto arrange labels (applicable only if LabelCompass is Auto).")]
        public AutoLabelArrangementMethodEnum LabelAutoArrangeMethod
        {
            get { return _labelAutoArrangeMethod; }
            set
            {
                _labelAutoArrangeMethod = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets flags controlling which locations are allowed when auto arranging labels (applicable only if LabelCompass is Auto).
        /// </summary>
        [Category("Chart")]
        [DefaultValue(AutoLabelArrangementOptions.Default)]
        [Description("Flags controlling which locations are allowed when auto arranging labels (applicable only if LabelCompass is Auto).")]
#if CLR40
        [Editor("C1.C1Preview.Design.FlagsEnumEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
#else
        [Editor(typeof(C1.C1Preview.Design.FlagsEnumEditor), typeof(UITypeEditor))]
#endif
        public AutoLabelArrangementOptions LabelAutoArrangeOptions
        {
            get { return _labelAutoArrangeOptions; }
            set
            {
                _labelAutoArrangeOptions = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the data series offset for appropriate charts.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(0)]
        [Description("Specifies the data series offset for appropriate charts.")]
        public int SeriesOffset
        {
            get { return _seriesOffset; }
            set
            {
                _seriesOffset = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether chart figures should be outlined.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(true)]
        [Description("Indicates whether chart figures should be outlined. Use OutlineColor to adjust the color.")]
        public bool ShowOutline
        {
            get { return _showOutline; }
            set
            {
                _showOutline = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the color used to draw outlines.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(typeof(Color), "Empty")]
        [Description("Color used to draw outlines (if ShowOutline is true). Clear to use the default.")]
        public Color OutlineColor
        {
            get { return _outlineColor; }
            set
            {
                _outlineColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For Pie charts, gets or sets the starting angle of the first slice (in degrees, counter-clockwise from the X axis).
        /// </summary>
        [Category("Chart")]
        [DefaultValue(0)]
        [Description("For Pie charts, specifies the starting angle of the first slice (in degrees, counter-clockwise from the X axis).")]
        public int PieStartAngle
        {
            get { return _pieStartAngle; }
            set
            {
                _pieStartAngle = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For Pie charts, gets or sets a value indicating whether series are drawn clockwise or counter-clockwise.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(false)]
        [Description("For Pie charts, indicates whether series are drawn clockwise or counter-clockwise.")]
        public bool PieClockwise
        {
            get { return _pieClockwise; }
            set
            {
                _pieClockwise = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For Pie charts, gets or sets the inner radius of the pie, in percent relative to the outer radius.
        /// Values greater than 0 turn a pie chart into a doughnut.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(0)]
        [Description("For Pie charts, specifies the inner radius of the pie, in percent relative to the outer radius. Values greater than 0 create a doughnut chart.")]
        public int PieInnerRadius
        {
            get { return _pieInnerRadius; }
            set
            {
                _pieInnerRadius = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For 3D charts (Use3D is true), gets or sets the apparent chart depth as a percentage of chart width.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(10)]
        [Description("For 3D charts (Use3D is true), the apparent chart depth as a percentage of chart width.")]
        public int View3dDepth
        {
            get { return _view3dDepth; }
            set
            {
                _view3dDepth = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For 3D charts (Use3D is true), gets or sets the apparent degree of inclination of the eye-point above the X-axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(45)]
        [Description("For 3D charts (Use3D is true), the apparent degree of inclination of the eye-point above the X-axis.")]
        public int View3dElevation
        {
            get { return _view3dElevation; }
            set
            {
                _view3dElevation = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For 3D charts (Use3D is true), gets or sets the apparent degree of rotation of the eye-point to the right of the Y-axis.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(45)]
        [Description("For 3D charts (Use3D is true), the apparent degree of rotation of the eye-point to the right of the Y-axis.")]
        public int View3dRotation
        {
            get { return _view3dRotation; }
            set
            {
                _view3dRotation = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// For 3D charts (Use3D is true), gets or sets the type of shading applied to 3D areas of the chart.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(ShadingEnum.ColorDark)]
        [Description("For 3D charts (Use3D is true), the type of shading applied to 3D areas of the chart.")]
        public ShadingEnum View3dShading
        {
            get { return _view3dShading; }
            set
            {
                _view3dShading = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the type of image generated by the chart.
        /// </summary>
        /// <remarks>Because of GDI+ limitation, this conversion does not support transparency.</remarks>
        [Category("Chart")]
        [DefaultValue(ImageTypeEnum.Emf)] // <<B182>>
        [Description("The type of image generated by the chart.")]
        public ImageTypeEnum ImageType
        {
            get { return _imageType; }
            set
            {
                _imageType = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the chart should include a legend.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(ShowLegendEnum.Automatic)] // <<B221>>
        [Description("Indicates whether the chart should include a legend.")]
        public ShowLegendEnum ShowLegend
        {
            get { return _showLegend; }
            set
            {
                _showLegend = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets how values should be aggregated on the chart.
        /// </summary>
        [Category("Chart")]
        [DefaultValue(AggregateEnum.None)]
        [Description("Controls how values should be aggregated on the chart.")]
        public AggregateEnum Aggregate
        {
            get { return _aggregate; }
            set
            {
                _aggregate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets a reference to the underlying <c>C1Chart</c> control. 
        /// </summary>
        /// <remarks>
        /// You can set properties in the underlying <c>C1Chart</c> control using script or code, 
        /// but these properties are not persisted when the report is saved.
        /// </remarks>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#if DYNAMIC_ASMS
        public dynamic ChartControl
#else
        public C1.Win.C1Chart.C1Chart ChartControl
#endif
        {
            get { return _chart; }
            set
            {
                _chart = value;
                OnPropertyChanged();
            }
        }
        #endregion

		#region Serialization

		private bool ShouldSerializeRadar()
		{
			return _radar != null && !_radar.IsDefault;
		}

		private bool ShouldSerializePolar()
		{
			return _polar != null && !_polar.IsDefault;
		}

		private bool ShouldSerializeHistogram()
		{
			return _histogram != null && !_histogram.IsDefault;
		}

		#endregion Serialization

		#region Overrides

		protected override void Save(XmlWriter properties)
	    {
		    base.Save(properties);

			if (ShouldSerializeRadar()) RadarOptions.Serializer.Serialize(properties, _radar);
			if (ShouldSerializePolar()) PolarOptions.Serializer.Serialize(properties, _polar);
			if (ShouldSerializeHistogram()) HistogramOptions.Serializer.Serialize(properties, _histogram);
	    }

	    protected override void Load(XmlNodeList properties)
	    {
		    base.Load(properties);
			
			RadarOptions radar = LoadOptions(properties, RadarOptions.XmlName, RadarOptions.Serializer) as RadarOptions;
		    if (radar != null) Radar = radar;

			PolarOptions polar = LoadOptions(properties, PolarOptions.XmlName, PolarOptions.Serializer) as PolarOptions;
			if (polar != null) Polar = polar;

			HistogramOptions histogram = LoadOptions(properties, HistogramOptions.XmlName, HistogramOptions.Serializer) as HistogramOptions;
			if (histogram != null) Histogram = histogram;
	    }

	    private object LoadOptions(XmlNodeList properties, string xmlName, XmlSerializer serializer)
	    {
			foreach (XmlNode node in properties)
				if (node.Name == xmlName)
				{
					XmlNodeReader reader = new XmlNodeReader(node);
					return serializer.Deserialize(reader);
				}
			return null;
	    }

	    /// <summary>
        /// Selects the text or image that will be rendered by the field.
        /// </summary>
        /// <param name="value">Field text.</param>
        /// <param name="img">Chart image.</param>
        /// <param name="designTime">Whether we in design time or runtime.</param>
        override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
        {
            // if we have a cached image at design time and no properties
            // have changed, then use the cached image
            if (designTime && _image != null)
            {
                // check whether any relevant field properties have changed
                if (_chart.BackColor == C1.C1Preview.Utils.FromWpfColor(this.BackColor) &&
                    _chart.ForeColor == C1.C1Preview.Utils.FromWpfColor(this.ForeColor) &&
                    _chart.Font == (Font)this.Font &&
                    _chart.Size == GetFieldSizePixels())
                {
                    img = _image;
                    return;
                }
            }

            // return new chart image
            try
            {
                img = BuildChart(designTime);
            }
            catch (Exception x)
            {
                Debug.WriteLine(x.Message);
            }

            // cache new image at design time
            if (designTime)
                _image = img;
        }

        /// <summary>
        /// Marks the owner report as dirty so it will clear the internal 
        /// cache and render again (useful for implementing custom fields).
        /// </summary>
        override public void OnPropertyChanged()
        {
            _image = null;
            base.OnPropertyChanged();
        }
        #endregion

        #region Private stuff
        private Size GetFieldSizePixels(Graphics g)
        {
            // get field size
            Size sz = new Size((int)(Width / 1440f * g.DpiX), (int)(Height / 1440f * g.DpiY));

            // can't be empty <<B167>>
            if (sz.Width <= 0) sz.Width = 1;
            if (sz.Height <= 0) sz.Height = 1;

            // return field size
            return sz;
        }

        private Size GetFieldSizePixels()
        {
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                return GetFieldSizePixels(g);
        }

        /// <summary>
        /// Gets the backcolor for the Chart.
        /// </summary>
        /// <returns>
        /// The backcolor for the Chart.
        /// </returns>
        /// <remarks>
        /// On saving Metafile to Bitmap, the text gets blurred if the backcolor is Transparent.
        /// So using the White as the backcolor. And WPF does not support Metafile.
        /// </remarks>
        private Color GetChartBackColor()
        {
            var backColor = Utils.FromWpfColor(BackColor);

#if !WPF
            if (ImageType == ImageTypeEnum.Emf)
                return backColor;
#endif

            if (backColor == Color.Transparent)
            {
                backColor = Utils.FromWpfColor(ParentSection.BackColor);
            }

            if (backColor == Color.Transparent)
            {
                backColor = Color.White;
            }

            return backColor;
        }

        private Image BuildChart(bool designTime)
        {
            // get chart data, return empty image if no data is available
            DataTable dt = GetChartData(designTime);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            // build color palette
            BuildPalette(dt);

            // <<B179>> do not reset the chart, reset just the SeriesList.
            // this way we can keep the settings made by the report definition 
            // script through the ChartControl property
#if DYNAMIC_ASMS
            dynamic cd = _chart.ChartGroups.Group0.ChartData;
#else
            ChartData cd = _chart.ChartGroups.Group0.ChartData;
#endif
            cd.SeriesList.Clear();
            _chart.ChartLabels.LabelsCollection.Clear();

            // reset chart
            //_chart.Reset();
            //_chart.BackColor = Color.White; // shouldn't be necessary...
            //_chart.ForeColor = Color.White;
            //_chart.Font = Control.DefaultFont;

            // get useful chart objects 
#if DYNAMIC_ASMS
            dynamic group = _chart.ChartGroups.Group0;
            dynamic area = _chart.ChartArea;
#else
            ChartGroup group = _chart.ChartGroups.Group0;
            Area area = _chart.ChartArea;
#endif
            // outlines (stroke):
            group.ShowOutline = ShowOutline;
            group.OutlineColor = OutlineColor;

            // apply field properties to chart
            _chart.Size = GetFieldSizePixels();
            _chart.BackColor = GetChartBackColor();
            _chart.ForeColor = Utils.FromWpfColor(ForeColor);
            _chart.Font = Font;

            // initialize global chart parameters
            group.Use3D = Use3D; // <<IP282>> APRDS000302
            if (Use3D)
            {
#if DYNAMIC_ASMS
                dynamic view = _chart.ChartArea.PlotArea.View3D;
                view.Shading = DynLoader.GetC1ChartEnumValue(string.Format("ShadingEnum.{0}", View3dShading));
#else
                View3D view = _chart.ChartArea.PlotArea.View3D;
                view.Shading = (Win.C1Chart.ShadingEnum)Enum.Parse(typeof(Win.C1Chart.ShadingEnum), View3dShading.ToString());
#endif
                view.Depth = View3dDepth;
                view.Elevation = View3dElevation;
                view.Rotation = View3dRotation;
            }

            area.PlotArea.Boxed = Boxed;
            _chart.Legend.Visible = false;

            // initialize chart type parameters
            switch (_chartType)
            {
                case ChartTypeEnum.Area:
#if DYNAMIC_ASMS
                    group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Area");
#else
                    group.ChartType = Chart2DTypeEnum.Area;
#endif
                    area.Inverted = false;
                    area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
                    //area.AxisX.AnnotationRotation = 45; <<B179>> let the user choose
                    break;
                case ChartTypeEnum.Column: // <<B168>>
#if DYNAMIC_ASMS
                    group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Bar");
#else
                    group.ChartType = Chart2DTypeEnum.Bar;
#endif
                    area.Inverted = false;
                    area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
                    //area.AxisX.Reversed = true; <<B182>> not reversed
                    break;
                case ChartTypeEnum.Bar:
#if DYNAMIC_ASMS
                    group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Bar");
#else
                    group.ChartType = Chart2DTypeEnum.Bar;
#endif
                    area.Inverted = true;
                    area.AxisX.Reversed = true;
                    break;
                case ChartTypeEnum.Line: // <<B168>>
                case ChartTypeEnum.Scatter:
#if DYNAMIC_ASMS
                    group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.XYPlot");
#else
                    group.ChartType = Chart2DTypeEnum.XYPlot;
#endif
                    area.Inverted = false;
                    area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
                    //area.AxisX.AnnotationRotation = 45; <<B179>> let the user choose
                    break;
				case ChartTypeEnum.Step:
#if DYNAMIC_ASMS
					group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Step");
#else
                    group.ChartType = Chart2DTypeEnum.Step;
#endif
					area.Inverted = false;
                    area.AxisX.Reversed = false;
		            break;
				case ChartTypeEnum.Radar:
#if DYNAMIC_ASMS
					group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Radar");
#else
                    group.ChartType = Chart2DTypeEnum.Radar;
#endif
					area.Inverted = false;
                    area.AxisX.Reversed = false;
					ApplyRadarOptions();
		            break;
				case ChartTypeEnum.Polar:
#if DYNAMIC_ASMS
					group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Polar");
#else
                    group.ChartType = Chart2DTypeEnum.Polar;
#endif
					area.Inverted = false;
                    area.AxisX.Reversed = false;
		            ApplyPolarOptions();
					break;
				case ChartTypeEnum.Histogram:
#if DYNAMIC_ASMS
					group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Histogram");
#else
                    group.ChartType = Chart2DTypeEnum.Histogram;
#endif
					area.Inverted = false;
                    area.AxisX.Reversed = false;
		            ApplyHistogramOptions();
					break;
                case ChartTypeEnum.Pie:
#if DYNAMIC_ASMS
                    group.ChartType = DynLoader.GetC1ChartEnumValue("Chart2DTypeEnum.Pie");
#else
                    group.ChartType = Chart2DTypeEnum.Pie;
#endif
                    break;
            }

            // auto label arrangement options:
            if (LabelCompass == LabelCompassEnum.Auto)
            {
#if DYNAMIC_ASMS
                _chart.ChartLabels.AutoArrangement.Method =
                    DynLoader.GetC1ChartEnumValue(string.Format("AutoLabelArrangementMethodEnum.{0}", LabelAutoArrangeMethod));
                _chart.ChartLabels.AutoArrangement.Options =
                    Enum.ToObject(_chart.ChartLabels.AutoArrangement.Options.GetType(), (int)LabelAutoArrangeOptions);
#else
                _chart.ChartLabels.AutoArrangement.Method =
                    (Win.C1Chart.AutoLabelArrangementMethodEnum)Enum.Parse(typeof(Win.C1Chart.AutoLabelArrangementMethodEnum), LabelAutoArrangeMethod.ToString());
                _chart.ChartLabels.AutoArrangement.Options =
                    (Win.C1Chart.AutoLabelArrangementOptions)(int)LabelAutoArrangeOptions;
#endif
                _chart.ChartLabels.AutoArrangement.Offset = LabelOffset;
                //_chart.ChartLabels.AutoArrangement.MaxIterations ?
            }

            // build regular (all non-pie) charts
            if (ChartType != ChartTypeEnum.Pie)
            {
                // show legends if we have more than one series
                switch (_showLegend)
                {
                    case ShowLegendEnum.Automatic:
                        _chart.Legend.Visible = dt.Columns.Count > 2;
                        break;
                    case ShowLegendEnum.Always:
                        _chart.Legend.Visible = true;
                        break;
                    case ShowLegendEnum.Never:
                        _chart.Legend.Visible = false;
                        break;
                }

                // add series data
                for (int col = 1; col < dt.Columns.Count; col++)
                {
                    AddRegularSeries(dt, col);
                }

                // configure Y-axis (same for all series)
#if DYNAMIC_ASMS
                dynamic ay = _chart.ChartArea.AxisY;
                ay.TickMinor = DynLoader.GetC1ChartEnumValue("TickMarksEnum.None");
#else
                Axis ay = _chart.ChartArea.AxisY;
                ay.TickMinor = TickMarksEnum.None;
#endif
                ay.GridMajor.Visible = GridLines;
                ay.GridMajor.Thickness = 0;
                // <<IP282>> don't set Min to 0 in order to keep automatic minimum 
                // (VNRPT000415, APRDS000294)
                //		if (ay.Min > 0) ay.Min = 0;  
                if (YMax != -1)
                    ay.Max = YMax;
                else
                    ay.AutoMax = true;
                if (YMin != -1)
                    ay.Min = YMin;
                else
                    ay.AutoMin = true;
                ApplyLabelFormat(ay, _formatY, dt, 1); // <<B178>>

                // configure X-axis
#if DYNAMIC_ASMS
                dynamic ax = _chart.ChartArea.AxisX;
                ax.TickMinor = DynLoader.GetC1ChartEnumValue("TickMarksEnum.None");
#else
                Axis ax = _chart.ChartArea.AxisX;
                ax.TickMinor = TickMarksEnum.None;
#endif
                if (XMin != -1)
                    ax.Min = XMin;
                else
                    ax.AutoMin = true;
                if (XMax != -1)
                    ax.Max = XMax;
                else
                    ax.AutoMax = true;
                ApplyLabelFormat(ax, _formatX, dt, 0); // <<B178>>
            }
            else // build pie charts
            {
                CreatePies(dt);
            }

            // create chart image
            Image img = _chart.GetMetafile(_chart.Size, ParentReport.EmfType);

            // convert format and return image
            return ConvertImageFormat(img);
        }

        private void ApplyRadarOptions()
	    {
#if DYNAMIC_ASMS
			dynamic group = _chart.ChartGroups.Group0;
			dynamic radar = group.Radar;
#else
            ChartGroup group = _chart.ChartGroups.Group0;
			Radar radar = group.Radar;
#endif

			radar.Degrees = _radar.Degrees;
			radar.Start = _radar.Start;
			radar.FlatGridLines = _radar.FlatGridLines;
			radar.Filled = _radar.Filled;
		}

	    private void ApplyPolarOptions()
	    {
#if DYNAMIC_ASMS
			dynamic group = _chart.ChartGroups.Group0;
			dynamic polar = group.Polar;
#else
            ChartGroup group = _chart.ChartGroups.Group0;
			Polar polar = group.Polar;
#endif

			polar.Degrees = _polar.Degrees;
			polar.Start = _polar.Start;
			polar.PiRatioAnnotations = _polar.PiRatioAnnotations;
		}

	    private void ApplyHistogramOptions()
	    {
#if DYNAMIC_ASMS
			dynamic group = _chart.ChartGroups.Group0;
		    dynamic histogram = group.Histogram;
		    dynamic curve = histogram.NormalDisplay;
		    dynamic lineStyle = curve.LineStyle;
		    dynamic fillStyle = curve.FillStyle;
#else
            ChartGroup group = _chart.ChartGroups.Group0;
			C1.Win.C1Chart.Histogram histogram = group.Histogram;
			C1.Win.C1Chart.NormalCurve curve = histogram.NormalDisplay;
			C1.Win.C1Chart.ChartLineStyle lineStyle = curve.LineStyle;
			C1.Win.C1Chart.FillStyle fillStyle = curve.FillStyle;
#endif

		    histogram.Normalized = _histogram.Normalized;
		    histogram.NormalizationInterval = _histogram.NormalizationInterval;

		    NormalCurve curveOptions = _histogram.NormalDisplay;
		    curve.ForegroundDisplay = curveOptions.ForegroundDisplay;
		    curve.UseAntiAlias = curveOptions.UseAntiAlias;
		    curve.Visible = curveOptions.Visible;

		    LineStyle lineStyleOptions = curveOptions.LineStyle;
#if DYNAMIC_ASMS
			lineStyle.Pattern = DynLoader.GetC1ChartEnumValue(string.Format("LinePatternEnum.{0}", lineStyleOptions.Pattern));
#else
            lineStyle.Pattern = (C1.Win.C1Chart.LinePatternEnum)Enum.Parse(typeof(C1.Win.C1Chart.LinePatternEnum), lineStyleOptions.Pattern.ToString());
#endif
		    lineStyle.Color = lineStyleOptions.Color.IsEmpty ? Color.Black : lineStyleOptions.Color;
		    lineStyle.Thickness = lineStyleOptions.Thickness;
		    lineStyle.MiterLimit = lineStyleOptions.MiterLimit;
		    lineStyle.LineJoin = lineStyleOptions.LineJoin;

		    FillStyle fillStyleOptions = curveOptions.FillStyle;
#if DYNAMIC_ASMS
			fillStyle.FillType = DynLoader.GetC1ChartEnumValue(string.Format("FillTypeEnum.{0}", fillStyleOptions.FillType));
			fillStyle.GradientStyle = DynLoader.GetC1ChartEnumValue(string.Format("GradientStyleEnum.{0}", fillStyleOptions.GradientStyle));
			fillStyle.HatchStyle = DynLoader.GetC1ChartEnumValue(string.Format("HatchStyleEnum.{0}", fillStyleOptions.HatchStyle));
#else
            fillStyle.FillType = (C1.Win.C1Chart.FillTypeEnum)Enum.Parse(typeof(C1.Win.C1Chart.FillTypeEnum), fillStyleOptions.FillType.ToString());
			fillStyle.GradientStyle = (C1.Win.C1Chart.GradientStyleEnum)Enum.Parse(typeof(C1.Win.C1Chart.GradientStyleEnum), fillStyleOptions.GradientStyle.ToString());
			fillStyle.HatchStyle = (C1.Win.C1Chart.HatchStyleEnum)Enum.Parse(typeof(C1.Win.C1Chart.HatchStyleEnum), fillStyleOptions.HatchStyle.ToString());
#endif
		    fillStyle.Alpha = fillStyleOptions.Alpha;
		    fillStyle.Color1 = fillStyleOptions.Color1.IsEmpty ? Color.White : fillStyleOptions.Color1;
		    fillStyle.Color2 = fillStyleOptions.Color2;
		    fillStyle.OutlineColor = fillStyleOptions.OutlineColor;
		    fillStyle.OutlineThickness = fillStyleOptions.OutlineThickness;
		    fillStyle.Image = fillStyleOptions.Image == null ? null : fillStyleOptions.Image.Clone() as Image;
	    }

#if DYNAMIC_ASMS
		private void ApplyChartHistogramOptions(dynamic series)
#else
	    private void ApplyChartHistogramOptions(ChartDataSeries series)
#endif
	    {
#if DYNAMIC_ASMS
			dynamic histogram = series.Histogram;
#else
			C1.Win.C1Chart.ChartHistogram histogram= series.Histogram;
#endif

#if DYNAMIC_ASMS
			histogram.DisplayType  = DynLoader.GetC1ChartEnumValue(string.Format("DisplayTypeEnum.{0}", _histogram.DisplayType ));
			histogram.IntervalCreationMethod = DynLoader.GetC1ChartEnumValue(string.Format("IntervalMethodEnum.{0}", _histogram.IntervalCreationMethod));
#else
            histogram.DisplayType  = (C1.Win.C1Chart.DisplayTypeEnum)Enum.Parse(typeof(C1.Win.C1Chart.DisplayTypeEnum), _histogram.DisplayType .ToString());
			histogram.IntervalCreationMethod = (C1.Win.C1Chart.IntervalMethodEnum)Enum.Parse(typeof(C1.Win.C1Chart.IntervalMethodEnum), _histogram.IntervalCreationMethod.ToString());
#endif

			histogram.IntervalNumber = _histogram.IntervalNumber;
			histogram.IntervalStart = _histogram.IntervalStart;
			histogram.IntervalWidth = _histogram.IntervalWidth;
	    }

	    private Image ConvertImageFormat(Image img)
        {
            // we only convert to bitmaps
            if (img == null || _imageType == ImageTypeEnum.Emf)
            {
                return img;
            }

            // save to stream and load it back
            MemoryStream ms = new MemoryStream();
            switch (_imageType)
            {
                case ImageTypeEnum.Bmp:
                    img.Save(ms, ImageFormat.Bmp);
                    break;
                case ImageTypeEnum.Gif:
                    img.Save(ms, ImageFormat.Gif);
                    break;
                case ImageTypeEnum.Jpeg:
                    img.Save(ms, ImageFormat.Jpeg);
                    break;
                case ImageTypeEnum.Png:
                    img.Save(ms, ImageFormat.Png);
                    break;
                default:
                    img.Save(ms, ImageFormat.Bmp);
                    break;
            }
            return Image.FromStream(ms);
        }

#if DYNAMIC_ASMS
        private void ApplyLabelFormat(dynamic ax, string fmt, DataTable dt, int col)
#else
        private void ApplyLabelFormat(Axis ax, string fmt, DataTable dt, int col)
#endif
        {
            // get column data type
            Type type = dt.Columns[col].DataType;

            // use labels on string values
            if (type == typeof(string))
            {
#if DYNAMIC_ASMS
                ax.AnnoMethod = DynLoader.GetC1ChartEnumValue("AnnotationMethodEnum.ValueLabels");
#else
                ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
#endif
                ax.ValueLabels.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ax.ValueLabels.Add(i, dt.Rows[i][col].ToString());
                }
                return;
            }

            // handle DateTime values
            if (type == typeof(DateTime))
            {
#if DYNAMIC_ASMS
                ax.AnnoMethod = DynLoader.GetC1ChartEnumValue("AnnotationMethodEnum.Values");
#else
                ax.AnnoMethod = AnnotationMethodEnum.Values;
#endif
                if (fmt == null || fmt.Length == 0)
                {
#if DYNAMIC_ASMS
                    ax.AnnoFormat = DynLoader.GetC1ChartEnumValue("FormatEnum.DateShort");
#else
                    ax.AnnoFormat = FormatEnum.DateShort;
#endif
                }
                else
                {
#if DYNAMIC_ASMS
                    ax.AnnoFormat = DynLoader.GetC1ChartEnumValue("FormatEnum.DateManual");
#else
                    ax.AnnoFormat = FormatEnum.DateManual;
#endif
                    ax.AnnoFormatString = fmt;
                }
                return;
            }

            // numeric values
#if DYNAMIC_ASMS
            ax.AnnoMethod = DynLoader.GetC1ChartEnumValue("AnnotationMethodEnum.Values");
#else
            ax.AnnoMethod = AnnotationMethodEnum.Values;
#endif
            if (fmt == null || fmt.Length == 0)
            {
#if DYNAMIC_ASMS
                ax.AnnoFormat = DynLoader.GetC1ChartEnumValue("FormatEnum.NumericGeneral");
#else
                ax.AnnoFormat = FormatEnum.NumericGeneral;
#endif
            }
            else
            {
#if DYNAMIC_ASMS
                ax.AnnoFormat = DynLoader.GetC1ChartEnumValue("FormatEnum.NumericManual");
#else
                ax.AnnoFormat = FormatEnum.NumericManual;
#endif
                ax.AnnoFormatString = fmt;
            }
        }

        private void BuildPalette(DataTable dt)
        {
            // honor user-supplied palette, if any
            if (Palette != null && Palette.Length > 0)
            {
                string[] colorNames = Palette.Split(';');
                _palette = new Color[colorNames.Length];
                for (int i = 0; i < _palette.Length; i++)
                {
                    _palette[i] = Color.FromName(colorNames[i]);
                }
                return;
            }

            // build palette using base color and alpha
            _palette = (ChartType == ChartTypeEnum.Pie)
                ? new Color[dt.Rows.Count]
                : new Color[dt.Columns.Count - 1];


            // build palette using base color and making colors lighter
            _palette = (ChartType == ChartTypeEnum.Pie)
                ? new Color[dt.Rows.Count]
                : new Color[dt.Columns.Count - 1];
            for (int i = 0; i < _palette.Length; i++)
            {
                float f = i / (float)_palette.Length;
                int r = (int)(255f * f + (1 - f) * DataColor.R);
                int g = (int)(255f * f + (1 - f) * DataColor.G);
                int b = (int)(255f * f + (1 - f) * DataColor.B);
                _palette[i] = Color.FromArgb(r, g, b);
            }
        }

        private void AddRegularSeries(DataTable dt, int columnIndex)
        {
            // add a new series
#if DYNAMIC_ASMS
            dynamic cd = _chart.ChartGroups.Group0.ChartData;
            dynamic ds = cd.SeriesList.AddNewSeries();
#else
            ChartData cd = _chart.ChartGroups.Group0.ChartData;
            ChartDataSeries ds = cd.SeriesList.AddNewSeries();
#endif

	        if (ChartType == ChartTypeEnum.Histogram)
	        {
		        ApplyChartHistogramOptions(ds);
	        }

            // add data labels:
            if (LabelCompass != LabelCompassEnum.None)
            {
                ds.DataLabel.Visible = true;
                ds.DataLabel.Offset = LabelOffset;
                ds.DataLabel.Connected = LabelConnected;
                ds.DataLabel.Text = "{#YVAL}";
#if DYNAMIC_ASMS
                ds.DataLabel.Compass = DynLoader.GetC1ChartEnumValue(string.Format("LabelCompassEnum.{0}", LabelCompass));
#else
                ds.DataLabel.Compass = (Win.C1Chart.LabelCompassEnum)Enum.Parse(typeof(Win.C1Chart.LabelCompassEnum), LabelCompass.ToString());
#endif
            }

            string caption = dt.Columns[columnIndex].Caption;
            if (caption.StartsWith("[") && caption.EndsWith("]"))
            {
                caption = caption.Substring(1, caption.Length - 2);
            }
            ds.Label = caption;

            // add series data
            double[] x = new double[dt.Rows.Count];
            double[] y = new double[dt.Rows.Count];
            bool hasXValues = IsNumericType(dt.Columns[0].DataType);
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = hasXValues ? GetDouble(dt.Rows[i][0], cd) : i;
                y[i] = GetDouble(dt.Rows[i][columnIndex], cd);
            }
            ds.X.CopyDataIn(x);
            ds.Y.CopyDataIn(y);

            // set color
            Color color = _palette[(columnIndex - 1) % _palette.Length];

            // configure series style
            ds.SymbolStyle.Color = color;
            ds.LineStyle.Color = color;

            // no lines in scatter charts
            if (ChartType == ChartTypeEnum.Scatter)
            {
#if DYNAMIC_ASMS
                ds.LineStyle.Pattern = DynLoader.GetC1ChartEnumValue("LinePatternEnum.None");
#else
                ds.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
#endif
            }

            // series offset
            ds.Offset = SeriesOffset;
        }

        private bool IsNumericType(Type t)
        {
            switch (Type.GetTypeCode(t))
            {
                case TypeCode.Byte:
                case TypeCode.DateTime:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
            }
            return false;
        }

#if DYNAMIC_ASMS
        private double GetDouble(object value, dynamic cd)
#else
        private double GetDouble(object value, ChartData cd)
#endif
        {
            if (value == null || value == DBNull.Value)
                return cd.Hole;

            if (value is double)
                return (double)value;

            if (value is DateTime)
                return ((DateTime)value).ToOADate();

            return (double)Convert.ChangeType(value, typeof(double));
        }

        private void CreatePies(DataTable dt)
        {
            // compute total value to calculate percentages
            float total = 0;
            if (dt.Columns.Count == 2 && ShowPercentages)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    object value = dr[1];
                    if (value != DBNull.Value && value != null) // <<B187>>
                    {
                        total += (float)Convert.ChangeType(value, typeof(float));
                    }
                }
            }

            // add one series per data point
#if DYNAMIC_ASMS
            dynamic cd = _chart.ChartGroups.Group0.ChartData;
#else
            ChartData cd = _chart.ChartGroups.Group0.ChartData;
#endif
            // pie properties:
            _chart.ChartGroups.Group0.Pie.Start = PieStartAngle;
            _chart.ChartGroups.Group0.Pie.Clockwise = PieClockwise;
            _chart.ChartGroups.Group0.Pie.InnerRadius = PieInnerRadius;

            PointF[] pt = new PointF[dt.Columns.Count - 1];
            for (int slice = 0; slice < dt.Rows.Count; slice++)
            {
                // create series (slice)
#if DYNAMIC_ASMS
                dynamic ds = cd.SeriesList.AddNewSeries();
#else
                ChartDataSeries ds = cd.SeriesList.AddNewSeries();
#endif
                // set color
                ds.LineStyle.Color = _palette[slice % _palette.Length];

                // series offset
                ds.Offset = SeriesOffset;

                // set label
                if (total > 0)
                {
                    object value = dt.Rows[slice][1];
                    if (value != DBNull.Value && value != null) // <<B187>>
                    {
                        // calculate percentage
                        float pct = (float)Convert.ChangeType(value, typeof(float)) / total;

                        // format percentage
                        string fmt = (_formatY != null && _formatY.Length > 0) ? _formatY : "p0";

                        // create label
                        ds.Label = string.Format("{0} ({1})", dt.Rows[slice][0], pct.ToString(fmt));
                    }
                }
                else
                {
                    object value = dt.Rows[slice][0];
                    ds.Label = (value != DBNull.Value && value != null) // <<B187>>
                        ? value.ToString()
                        : string.Empty;
                }

                // set value
                for (int pie = 0; pie < pt.Length; pie++)
                {
                    object value = dt.Rows[slice][pie + 1];
                    pt[pie].Y = (value == null || value == DBNull.Value || value == null) // <<B187>>
                        ? (float)cd.Hole
                        : (float)Convert.ChangeType(value, typeof(float));
                }
                ds.PointData.CopyDataIn(pt);
            }

            // show legend by default
            switch (_showLegend)
            {
                case ShowLegendEnum.Automatic:
                    _chart.Legend.Visible = !RadialLabels;
                    break;
                case ShowLegendEnum.Always:
                    _chart.Legend.Visible = true;
                    break;
                case ShowLegendEnum.Never:
                    _chart.Legend.Visible = false;
                    break;
            }

            // use radial labels instead of legend
            if (RadialLabels)
            {
                // configure labels
#if DYNAMIC_ASMS
                dynamic s = _chart.ChartLabels.DefaultLabelStyle;
#else
                C1.Win.C1Chart.Style s = _chart.ChartLabels.DefaultLabelStyle;
#endif
                s.Font = Font;
                s.ForeColor = Utils.FromWpfColor(ForeColor);
                s.BackColor = Color.White;
                s.Opaque = true;
#if DYNAMIC_ASMS
                s.Border.BorderStyle = DynLoader.GetC1ChartEnumValue("BorderStyleEnum.Solid");
#else
                s.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
#endif

                // attach labels to each slice
                for (int pie = 0; pie < dt.Columns.Count - 1; pie++)
                {
                    for (int slice = 0; slice < dt.Rows.Count; slice++)
                    {
#if DYNAMIC_ASMS
                        dynamic lbl = _chart.ChartLabels.LabelsCollection.AddNewLabel();
#else
                        C1.Win.C1Chart.Label lbl = _chart.ChartLabels.LabelsCollection.AddNewLabel();
#endif
                        lbl.Text = cd.SeriesList[slice].Label;

                        if (LabelCompass != LabelCompassEnum.None)
                        {
                            lbl.Visible = true;
                            lbl.Connected = LabelConnected;
                            lbl.Offset = LabelOffset;
#if DYNAMIC_ASMS
                            lbl.Compass = DynLoader.GetC1ChartEnumValue(string.Format("LabelCompassEnum.{0}", LabelCompass));
#else
                            lbl.Compass = (Win.C1Chart.LabelCompassEnum)Enum.Parse(typeof(Win.C1Chart.LabelCompassEnum), LabelCompass.ToString());
#endif
                        }
                        else
                            lbl.Visible = false;

#if DYNAMIC_ASMS
                        lbl.AttachMethod = DynLoader.GetC1ChartEnumValue("AttachMethodEnum.DataIndex");
                        dynamic am = lbl.AttachMethodData;
#else
                        lbl.AttachMethod = AttachMethodEnum.DataIndex;
                        AttachMethodData am = lbl.AttachMethodData;
#endif
                        am.GroupIndex = 0;
                        am.PointIndex = pie;
                        am.SeriesIndex = slice;
                    }
                }
            }
        }

        private DataTable GetChartData(bool designTime)
        {
            // get data as usual
            DataTable dt = GetChartDataInternal(designTime);

            // calculate aggregates if that was requested
            if (!designTime && _aggregate != AggregateEnum.None)
            {
                Dictionary<object, Tally[]> summary = new Dictionary<object, Tally[]>();
                foreach (DataRow dr in dt.Rows)
                {
                    // get key value
                    object key = dr[0];

                    // get/create tallies for this key
                    Tally[] tally;
                    if (!summary.TryGetValue(key, out tally))
                    {
                        tally = new Tally[dt.Columns.Count];
                        summary[key] = tally;
                    }

                    // tally values in this row
                    for (int col = 1; col < dt.Columns.Count; col++)
                    {
                        if (tally[col] == null)
                        {
                            tally[col] = new Tally();
                        }
                        tally[col].AddValue(dr[col]);
                    }
                }

                // populate table with tallies
                dt.Rows.Clear();
                foreach (object key in summary.Keys)
                {
                    Tally[] tally = summary[key];
                    DataRow dr = dt.NewRow();
                    dr[0] = key;
                    for (int col = 1; col < dt.Columns.Count; col++)
                    {
                        dr[col] = tally[col].GetAggregate(_aggregate);
                    }
                    dt.Rows.Add(dr);
                }
            }

            // return table
            return dt;
        }

        private DataTable GetChartDataInternal(bool designTime)
        {
            // get names/expressions for each data column
            string colNames = (DataY != null) ? DataY : "Series1;Series2";
            string[] dataY = colNames.Split(';');
            for (int i = 0; i < dataY.Length; i++)
            {
                dataY[i] = dataY[i].Trim();
            }

            string[] colLabels = string.IsNullOrEmpty(DataYLabels) ? null : DataYLabels.Split(';');

            // create chart data table
            // the first column always contains the DataX values
            // the remaining columns contain the chart data
            DataTable dt = new DataTable();
            dt.Columns.Add("X");
            for (int i = 0; i < dataY.Length; i++)
            {
                DataColumn col = dt.Columns.Add();
                col.DataType = typeof(int);
                col.Caption = (colLabels != null && colLabels.Length > i) ? colLabels[i] : dataY[i];
            }

            if (designTime)
            {
                FillDesignTimeData(dt);
                return dt;
            }

            // if a custom RecordSource string was provided, use it
            if (RecordSource != null && RecordSource.Length > 0)
            {
                // get custom table
                DataTable dtCustom = new DataTable();
                string conn = ParentReport.DataSource.ConnectionString;
                string sql = ParentReport.Evaluate(RecordSource).ToString();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn); // <<B176>>
                da.Fill(dtCustom);

                // set column data types <<B211>>
                dt.Columns[0].DataType = dtCustom.Columns[DataX].DataType;
                for (int i = 0; i < dataY.Length; i++)
                {
                    dt.Columns[i + 1].DataType = dtCustom.Columns[dataY[i]].DataType;
                }

                // build chart table
                foreach (DataRow dr in dtCustom.Rows)
                {
                    DataRow newRow = dt.NewRow();
                    newRow[0] = dr[DataX];
                    for (int i = 0; i < dataY.Length; i++)
                        newRow[i + 1] = dr[dataY[i]];
                    dt.Rows.Add(newRow);
                }
                return dt;
            }

            // build table using parent recordsource
            IC1ReportRecordset rs = ParentReport.DataSource.Recordset as IC1ReportRecordset;
            if (rs != null)
            {
                // get current group values <<B168>>
                object[] gStart = GetGroupValues();

                // move up to the top of the current group <<B171>>
                // (the field could be in a detail or group footer section)
                int bkmk = rs.GetBookmark();
                while (!rs.BOF())
                {
                    rs.MovePrevious();
                    object[] gNow = GetGroupValues();
                    if (IsGroupBreak(gStart, gNow))
                    {
                        rs.MoveNext();
                        break;
                    }
                }

                // set column data types <<B213>>
                object x = ParentReport.Evaluate(DataX);
                if (x != null)
                {
                    dt.Columns[0].DataType = x.GetType();
                }
                for (int i = 0; i < dataY.Length; i++)
                {
                    x = ParentReport.Evaluate(dataY[i]);
                    if (x != null)
                    {
                        dt.Columns[i + 1].DataType = x.GetType();
                    }
                }

                // 14.01.2011 Alexander Manuzin:
                // I don't understand why but following commented code
                // causes 14140 TFS bug
                // I think this code is not needed because we select
                // position at top of group for groupfooter in the above code.
                //
                // <<IP223>> for details see APRDS000262
                // Sometimes current cursor position is not equal to bkmk position;
                // in such cases chart image has no some data which should be there.
                // (It occurs only for group headers and footers)
                /*if (this.ParentSection.Type != SectionTypeEnum.Detail)
                {
                    rs.SetBookmark(bkmk);
                }*/

                // populate the table
                //int bkmk = rs.GetBookmark();
                for (; !rs.EOF(); rs.MoveNext())
                {
                    // break at group end
                    object[] gNow = GetGroupValues();
                    if (IsGroupBreak(gStart, gNow))
                    {
                        break;
                    }

                    // add this row
                    DataRow newRow = dt.NewRow();
                    newRow[0] = ParentReport.Evaluate(DataX);
                    for (int i = 0; i < dataY.Length; i++)
                    {
                        newRow[i + 1] = ParentReport.Evaluate(dataY[i]);

                        // honor DoEvents setting
                        if (i % 100 == 0 && ParentReport != null && ParentReport.DoEvents)
                            Application.DoEvents();
                    }
                    dt.Rows.Add(newRow);
                }

                // restore bookmark
                rs.SetBookmark(bkmk);

                // return data
                return dt;
            }

            // can't get data
            return null;
        }

        private void FillDesignTimeData(DataTable dt)
        {
            if(ChartType== ChartTypeEnum.Histogram)
                FillDesignTimeHistogramData(dt);
            else
                FillDesignTimeRegularData(dt);
        }

        private void FillDesignTimeRegularData(DataTable dt)
        {
            var xDegrees360 = false;
            if (ChartType == ChartTypeEnum.Polar)
            {
                dt.Columns[0].DataType = typeof(int);
                xDegrees360 = Polar.Degrees;
            }

            var pointsCount = (ChartType == ChartTypeEnum.Polar || ChartType == ChartTypeEnum.Radar) ? 5 : 10;
            Random rnd = new Random(0);
            for (int i = 0; i < pointsCount; i++)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = xDegrees360 ? rnd.Next(72) + i * 72 : i + 1;
                for (int col = 1; col < dt.Columns.Count; col++)
                    newRow[col] = rnd.Next(100);
                dt.Rows.Add(newRow);
            }
        }

        private void FillDesignTimeHistogramData(DataTable dt)
        {
            dt.Columns[0].DataType = typeof(int);

            var semiAuto = _histogram.IntervalCreationMethod == IntervalCreationMethodEnum.SemiAutomatic;
            var intervalRange = (int)(_histogram.IntervalStart + _histogram.IntervalWidth * _histogram.IntervalNumber);
            var xData = _histogram.IntervalCreationMethod == IntervalCreationMethodEnum.XDataBoundaries;

            const int pointsCount = 10;
            var rnd = new Random(0);
            for (int i = 0; i < pointsCount; i++)
            {
                var newRow = dt.NewRow();
                newRow[0] = xData ? (i + 1)*10 : i + 1;
                for (int col = 1; col < dt.Columns.Count; col++)
                    newRow[col] = semiAuto?_histogram.IntervalStart + rnd.Next(intervalRange): rnd.Next(100);
                dt.Rows.Add(newRow);
            }
        }

        private object[] GetGroupValues()
        {
            // get last group
            int lastGroup = ((int)Section - 5) / 2;
            if (lastGroup < 0) lastGroup = -1;
            object[] values = new object[lastGroup + 1];

            // calculate values
            for (int i = 0; i < values.Length; i++)
            {
                string expr = ParentReport.Groups[i].GroupBy;
                values[i] = ParentReport.Evaluate(expr);
            }

            // return result
            return values;
        }

        private bool IsGroupBreak(object[] gv1, object[] gv2)
        {
            Debug.Assert(gv1.Length == gv2.Length);
            for (int i = 0; i < gv1.Length; i++)
            {
                if (!object.Equals(gv1[i], gv2[i]))
                    return true;
            }
            return false;
        }
        #endregion

        #region Nested class
        /// <summary>
        /// Class used to calculate aggregate values.
        /// </summary>
        class Tally
        {
            double _cnt, _sum, _sum2, _max, _min;

            public void AddValue(object obj)
            {
                double value = GetDouble(obj);
                if (!double.IsNaN(value))
                {
                    _cnt++;
                    _sum += value;
                    _sum2 += value * value;
                    if (_cnt == 1 || value > _max)
                    {
                        _max = value;
                    }
                    if (_cnt == 1 || value < _min)
                    {
                        _min = value;
                    }
                }
            }

            public double GetAggregate(AggregateEnum total)
            {
                switch (total)
                {
                    case AggregateEnum.Average:
                        return _cnt > 0 ? _sum / _cnt : 0;
                    case AggregateEnum.Maximum:
                        return _max;
                    case AggregateEnum.Minimum:
                        return _min;
                    case AggregateEnum.Sum:
                        return _sum;
                    case AggregateEnum.Count:
                        return _cnt;
                    case AggregateEnum.VariancePop:
                        if (_cnt > 1)
                        {
                            double avg = _sum / _cnt;
                            return _sum2 / _cnt - avg * avg;
                        }
                        return 0;

                    case AggregateEnum.Variance:
                        return _cnt > 1 ? GetAggregate(AggregateEnum.VariancePop) * _cnt / (_cnt - 1) : 0;

                    case AggregateEnum.StandardDeviation:
                        return Math.Sqrt(GetAggregate(AggregateEnum.Variance));

                    case AggregateEnum.StandardDeviationPop:
                        return Math.Sqrt(GetAggregate(AggregateEnum.VariancePop));
                }
                throw new Exception("invalid aggregate");
            }

            private static double GetDouble(object value)
            {
                // null means zero
                if (value == null || value == DBNull.Value)
                {
                    return double.NaN;
                }

                // parse others
                try
                {
                    return (double)Convert.ChangeType(value, typeof(double));
                }
                catch
                {
                    return double.NaN;
                }
            }
        }
        #endregion

		#region Options

		#region Options Base
		/// <summary>
		/// Represents that the instance of this class is owned by Chart.
		/// </summary>
		public abstract class ChartOwnedItem
		{
			private Chart _chart;

			/// <summary>
			/// Gets or sets the chart object as owner.
			/// </summary>
			[XmlIgnore]
			[Browsable(false)]
			public Chart Owner
			{
				get { return _chart; }
				set
				{
					_chart = value;
					OnOwnerChanged();
				}
			}

			/// <summary>
			/// Indicated whether the instance has default values.
			/// </summary>
			internal abstract bool IsDefault { get; }

			/// <summary>
			/// Create a duplicate instance of this object.
			/// </summary>
			/// <param name="owner">The owner of the new object.</param>
			/// <returns>A new object which is a copy of this object.</returns>
			public abstract object Clone(Chart owner);

			/// <summary>
			/// Notify the owner that some property changed.
			/// </summary>
			protected void OnPropertyChanged()
			{
				if (_chart != null) _chart.OnPropertyChanged();
			}

			/// <summary>
			/// Notify the owner of this object is changed.
			/// </summary>
			protected virtual void OnOwnerChanged()
			{
				// do nothing for base. 
				// on overriding, change the owner of some fields if necessary.
			}
		}

		/// <summary>
		/// Represents the common options for Radar and Polar chart.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public abstract class CircularOptions : ChartOwnedItem
		{
			private bool _degrees = true;
			private double _start;

			/// <summary>
			/// Gets or sets the starting angle of Radar and Polar chart.
			/// </summary>
			/// <remarks>
			/// The angle is measured in degrees if the Degrees property is true, radians otherwise.
			/// The angle is measured in the counter-clockwise direction from the 12 o'clock position.
			/// </remarks>
			[DefaultValue(0d)]
			[Description("Gets or sets the starting angle of Radar and Polar chart.")]
			public double Start
			{
				get { return _start; }
				set
				{
					if (_start != value)
					{
						_start = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets whether the Start value reflects angles in degrees (true) or radians (false) for Radar and Polar chart.
			/// </summary>
			[DefaultValue(true)]
			[Description("Gets or sets whether the Start value reflects angles in degrees (true) or radians (false) for Radar and Polar chart.")]
			public bool Degrees
			{
				get { return _degrees; }
				set
				{
					if (_degrees != value)
					{
						_degrees = value;
						OnPropertyChanged();
					}
				}
			}

			internal override bool IsDefault
			{
				get
				{
					return _degrees 
						&& _start == 0;
				}
			}
		}

		#endregion Options Base

		#region RadarOptions

		/// <summary>
		/// Represents the options for Radar chart.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class RadarOptions : CircularOptions
		{
			private bool _filled;
			private bool _flatGridLines;

			internal const string XmlName = "Radar";
			internal static XmlSerializer Serializer = new XmlSerializer(typeof(RadarOptions), new XmlRootAttribute(XmlName));

			/// <summary>
			/// Gets or sets whether Radar chart should be filled.
			/// </summary>
			[DefaultValue(false)]
			[Description("Gets or sets whether Radar chart should be filled.")]
			public bool Filled
			{
				get { return _filled; }
				set
				{
					if (_filled != value)
					{
						_filled = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets whether Radar chart should use flat Y coordinate gridlines. By default, Y coordinate gridlines are circular.
			/// </summary>
			[DefaultValue(false)]
			[Description("Gets or sets whether Radar chart should use flat Y coordinate gridlines.")]
			public bool FlatGridLines
			{
				get { return _flatGridLines; }
				set
				{
					if (_flatGridLines != value)
					{
						_flatGridLines = value;
						OnPropertyChanged();
					}
				}
			}

			internal override bool IsDefault
			{
				get
				{
					return base.IsDefault
					       && !_filled 
						   && !_flatGridLines;
				}
			}

			public override object Clone(Chart owner)
			{
				RadarOptions radar = new RadarOptions();
				radar.Degrees = Degrees;
				radar.Start = Start;
				radar._filled = _filled;
				radar._flatGridLines = _flatGridLines;
				radar.Owner = owner;
				return radar;
			}
		}

		#endregion RadarOptions

		#region Polar Options

		/// <summary>
		/// Represents the options for Polar chart.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class PolarOptions : CircularOptions
		{
			private bool _piRatio = true;

			internal const string XmlName = "Polar";
			internal static XmlSerializer Serializer = new XmlSerializer(typeof(PolarOptions), new XmlRootAttribute(XmlName));

			/// <summary>
			/// Gets or sets whether polar chart measured in radians should be annotated with Pi rations.
			/// </summary>
			[DefaultValue(true)]
			[Description("Gets or sets whether polar chart measured in radians should be annotated with Pi rations.")]
			public bool PiRatioAnnotations 
			{
				get { return _piRatio; }
				set
				{
					if (_piRatio != value)
					{
						_piRatio = value;
						OnPropertyChanged();
					}
				}
			}

			internal override bool IsDefault
			{
				get
				{
					return base.IsDefault
					       && _piRatio;
				}
			}

			public override object Clone(Chart owner)
			{
				PolarOptions polar = new PolarOptions();
				polar.Degrees = Degrees;
				polar.Start = Start;
				polar._piRatio = _piRatio;
				polar.Owner = owner;
				return polar;
			}
		}

		#endregion Polar Options

		#region Histogram Options

		/// <summary>
		/// Represents the options for Histogram chart.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class HistogramOptions : ChartOwnedItem
	    {
			internal const string XmlName = "Histogram";
			internal static XmlSerializer Serializer = new XmlSerializer(typeof(HistogramOptions), new XmlRootAttribute(XmlName));

			private bool _normalized;
			private double _normalizationInterval = -1;
			private NormalCurve _normalCurve = new NormalCurve();

			private IntervalCreationMethodEnum _intervalCreationMethod = IntervalCreationMethodEnum.Automatic;
			private DisplayTypeEnum _displayType = DisplayTypeEnum.Histogram;
			private int _intervalNumber = 7;
			private double _intervalStart;
			private double _intervalWidth = 1;

			/// <summary>
			/// Gets or sets whether each histogram series interval is normalized.
			/// </summary>
			/// <remarks>
			/// When histograms with non-uniform intervals are generated, each interval
			/// is typically normalized such that each interval height represents the
			/// same frequency per unit width.  This preserves the most appropriate
			/// histogram shape.
			/// </remarks>
			[DefaultValue(false)]
			[Description("Gets or sets whether each histogram series interval is normalized.")]
			public bool Normalized
			{
				get { return _normalized; }
				set
				{
					if (_normalized != value)
					{
						_normalized = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the normalization interval width.
			/// </summary>
			/// <remarks>
			/// When histograms with non-uniform intervals are generated, each interval
			/// is typically normalized such that each interval height represents the
			/// same frequency per unit width.  This preserves the most appropriate
			/// histogram shape.  The normalization interval width is the width to which
			/// all other intervals are normalized.  Intervals with the same width as the
			/// normalization width, will have a height which directly indicates its value.
			/// </remarks>
			[DefaultValue(-1.0)]
			[Description("Gets or sets the normalization interval width.")]
			public double NormalizationInterval
			{
				get { return _normalizationInterval; }
				set
				{
					if (_normalizationInterval != value)
					{
						_normalizationInterval = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets an object describing a Gaussian normal curve display.
			/// </summary>
			/// <remarks>
			/// Histograms and frequency graphs are used to show the distribution of
			/// data values.  Very often, the data distributions are compared to normal
			/// distributions.  The properties of the NormalCurve object control the
			/// appearance of a built in display of a Normal (Gaussian) curve for
			/// comparison.  The normal curve is unrelated to the data.
			/// </remarks>
			[Description("Gets or sets an object describing a Gaussian normal curve display.")]
			public NormalCurve NormalDisplay
			{
				get { return _normalCurve; }
				set
				{
					if (_normalCurve != null) _normalCurve.Owner = null;
					_normalCurve = value;
					if (_normalCurve != null) _normalCurve.Owner = Owner;
					OnPropertyChanged();
				}
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether NormalDisplay property should be serialized.
			/// </summary>
			/// <returns>true if the NormalDiplay property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeNormalDisplay()
			{
				return _normalCurve!= null && !_normalCurve.IsDefault;
			}

			/// <summary>
			/// Gets or sets the method used to display the frequency data.
			/// </summary>
			/// <remarks>
			/// Frequency data can be displayed in a different manner on a per series
			/// basis, making it possible to mix display types in a single chart group.
			/// </remarks>
			[DefaultValue(DisplayTypeEnum.Histogram)]
			[Description("Gets or sets the method used to display the frequency data.")]
			public DisplayTypeEnum DisplayType
			{
				get { return _displayType; }
				set
				{
					if (_displayType != value)
					{
						_displayType = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the method used to specify the histogram intervals.
			/// </summary>
			/// <remarks>
			/// Interval boundaries can be established in a variety of ways.
			/// <para>When the Automatic method is used, the chart calculates
			/// the upper and lower limits of the intervals using the maximum and minimum
			/// data values, and restricting the intervals to lie within 3 standard deviations
			/// of the data mean.  The number of intervals is optional.  Interval boundaries
			/// are calculated uniformly.</para>
			/// <para>When the SemiAutomatic method is used, the upper and lower limits
			/// of the intervals are specified together with the number of intervals.
			/// Interval boundaries are calculated uniformly.</para>
			/// <para>When the XDataBoundaries method is used, the X values of the data
			/// data series are used to explicitly set each interval boundary.  The X values
			/// are sorted and duplicate values are eliminated.  Each ascending value of the
			/// result is used determine the next interval boundary.  Thus, the first and second
			/// resulting X values define the first interval and each successive X value specifies
			/// the end of the next interval.  Note that specification of N intervals requires
			/// N+1 unique X values.
			/// </para>
			/// </remarks>
			[DefaultValue(IntervalCreationMethodEnum.Automatic)]
			[Description("Gets or sets the method used to specify the histogram intervals.")]
			public IntervalCreationMethodEnum IntervalCreationMethod
			{
				get { return this._intervalCreationMethod; }
				set
				{
					if (_intervalCreationMethod != value)
					{
						_intervalCreationMethod = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the number of intervals in the histogram.
			/// </summary>
			/// <remarks>
			/// The IntervalNumber property applies only to histograms created with
			/// Automatic and SemiAutomatic methods.  When the XDataBoundaries method
			/// is used, the number of intervals is defined as 1 less than the number
			/// of unique X values specified.
			/// </remarks>
			[DefaultValue(7)]
			[Description("Gets or sets the number of intervals in the histogram.")]
			public int IntervalNumber
			{
				get { return _intervalNumber; }
				set
				{
					if (_intervalNumber != value)
					{
						_intervalNumber = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the numeric value of the beginning of the first interval.
			/// </summary>
			/// <remarks>Applies only to the SemiAutomatic creation method.</remarks>
			[Description("Gets or sets the numeric value of the beginning of the first interval.")]
			[DefaultValue(0d)]
			public double IntervalStart
			{
				get { return _intervalStart; }
				set
				{
					if (_intervalStart != value)
					{
						_intervalStart = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the numeric value of the width of the each interval.
			/// </summary>
			/// <remarks>Applies only to the SemiAutomatic creation method.</remarks>
			[Description("Gets or sets the numeric value of the width of the each interval.")]
			[DefaultValue(1d)]
			public double IntervalWidth
			{
				get { return _intervalWidth; }
				set
				{
					if (_intervalWidth != value)
					{
						_intervalWidth = value;
						OnPropertyChanged();
					}
				}
			}

			protected override void OnOwnerChanged()
			{
				base.OnOwnerChanged();
				if (_normalCurve != null) _normalCurve.Owner = Owner;
			}

			internal override bool IsDefault
			{
				get
				{
					return !ShouldSerializeNormalDisplay()
					       && !_normalized
					       && _normalizationInterval == -1

					       && _intervalCreationMethod == IntervalCreationMethodEnum.Automatic
					       && _displayType == DisplayTypeEnum.Histogram
					       && _intervalNumber == 7
					       && _intervalStart == 0d
					       && _intervalWidth == 1d;
				}
			}

			public override object Clone(Chart owner)
			{
				HistogramOptions histogram = new HistogramOptions();
				histogram._normalized = _normalized;
				histogram._normalizationInterval = _normalizationInterval;
				if (_normalCurve != null) histogram._normalCurve = _normalCurve.Clone(owner) as NormalCurve;

				histogram._intervalCreationMethod = _intervalCreationMethod;
				histogram._displayType = _displayType;
				histogram._intervalNumber = _intervalNumber;
				histogram._intervalStart = _intervalStart;
				histogram._intervalWidth = _intervalWidth;

				histogram.Owner = owner;
				return histogram;
			}
	    }

		/// <summary>
		/// Represents the appearance of the  normal curve for the Histogram chart.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class NormalCurve : ChartOwnedItem
		{
			private bool _visible;
			private LineStyle _lineStyle = new LineStyle();
			private FillStyle _fillStyle = new FillStyle();
			private bool _foreground;
			private bool _useAntiAlias = true;

			/// <summary>
			/// Gets or sets whether the Normal (Gaussian) curve is displayed on top of the chart data display.
			/// </summary>
			/// <remarks>
			/// By default, the Normal (Gaussian) curve is displayed behind all charted data.  Setting
			/// the ForegroundDisplay property to true specifies that the Normal curve should be drawn
			/// on top of the charted data.
			/// </remarks>
			[Description("Gets or sets whether the Normal (Gaussian) curve is displayed on top of the chart data display.")]
			[DefaultValue(false)]
			public bool ForegroundDisplay
			{
				get { return _foreground; }
				set
				{
					if (_foreground != value)
					{
						_foreground = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the LineStyle object for the Normal curve.
			/// </summary>
			/// <remarks>
			/// The LineStyle property controls the appearance of the actual line drawn
			/// representing the Normal curve.  The FillStyle property controls the
			/// appearance of the area under the Normal curve.
			/// </remarks>
			[Description("Gets or sets the LineStyle object for the Normal curve.")]
			public LineStyle LineStyle
			{
				get { return _lineStyle; }
				set
				{
					if (_lineStyle != null) _lineStyle.Owner = null;
					_lineStyle = value;
					if (_lineStyle != null) _lineStyle.Owner = Owner;
					OnPropertyChanged();
				}
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether LineStyle property should be serialized.
			/// </summary>
			/// <returns>true if the LineStyle property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeLineStyle()
			{
				return _lineStyle != null && !_lineStyle.IsDefault;
			}

			/// <summary>
			/// Gets or sets the FillStyle object for the Normal curve.
			/// </summary>
			/// <remarks>
			/// The FillStyle property controls the appearance of the area under the Normal
			/// curve.  The LineStyle property controls the appearance of the actual line
			/// drawn representing the Normal curve.
			/// </remarks>
			[Description("Gets or sets the FillStyle object for the Normal curve.")]
			public FillStyle FillStyle
			{
				get { return _fillStyle; }
				set
				{
					if (_fillStyle != null) _fillStyle.Owner = null;
					_fillStyle = value;
					if (_fillStyle != null) _fillStyle.Owner = Owner;
					OnPropertyChanged();
				}
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether FillStyle property should be serialized.
			/// </summary>
			/// <returns>true if the FillStyle property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeFillStyle()
			{
				return _fillStyle != null
				       && !_fillStyle.IsDefault;
			}

			/// <summary>
			/// Gets or sets whether the Normal curve is drawn using anti-aliasing.
			/// </summary>
			/// <remarks>
			/// By default, the normal curve is drawn using anti-aliasing methods.  Setting
			/// the UseAntiAlias property to false overrides this behavior.
			/// </remarks>
			[Description("Gets or sets whether the Normal curve is drawn using anti-aliasing.")]
			[DefaultValue(true)]
			public bool UseAntiAlias
			{
				get { return _useAntiAlias; }
				set
				{
					if (_useAntiAlias != value)
					{
						_useAntiAlias = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets whether the Normal curve is drawn.
			/// </summary>
			[Description("Gets or sets whether the Normal curve is drawn.")]
			[DefaultValue(false)]
			public bool Visible
			{
				get { return _visible; }
				set
				{
					if (_visible != value)
					{
						_visible = value;
						OnPropertyChanged();
					}
				}
			}

			protected override void OnOwnerChanged()
			{
				base.OnOwnerChanged();
				if (_lineStyle != null) _lineStyle.Owner = Owner;
				if (_fillStyle != null) _fillStyle.Owner = Owner;
			}

			internal override bool IsDefault
			{
				get
				{
					return !ShouldSerializeFillStyle()
					       && !ShouldSerializeLineStyle()
					       && !_foreground
					       && !_visible
					       && _useAntiAlias;
				}
			}

			public override object Clone(Chart owner)
			{
				NormalCurve curve = new NormalCurve();
				if(_lineStyle!=null)
					curve._lineStyle = _lineStyle.Clone(owner) as LineStyle;
				if (_fillStyle != null)
					curve._fillStyle = _fillStyle.Clone(owner) as FillStyle;
				curve._foreground = _foreground;
				curve._useAntiAlias = _useAntiAlias;
				curve._visible = _visible;
				curve.Owner = owner;
				return curve;
			}
		}

		/// <summary>
		/// Represents the fill style for chart elements.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class FillStyle : ChartOwnedItem
		{
			private Color _color1 = Color.Empty;
			private Color _color2 = Color.White;
			private Color _outlineColor = Color.Empty;
			private int _outlineThickness = 1;
			private FillTypeEnum _fillType = FillTypeEnum.SolidColor;
			private GradientStyleEnum _gradientStyle = GradientStyleEnum.Horizontal;
			private HatchStyleEnum _hatchStyle = HatchStyleEnum.Horizontal;
			private Image _image;
			private byte _alpha = 255;

			/// <summary>
			/// Gets or sets the fill color.
			/// </summary>
			[Description("Gets or sets the fill color.")]
			[DefaultValue(typeof(Color), "Empty")]
			[XmlIgnore]
			public Color Color1
			{
				get
				{
					return _color1;
				}
				set
				{
					if (_color1 != value)
					{
						_color1 = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// For internal XML serialization used. Gets or sets the argb value for Color1 property.
			/// </summary>
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[XmlElement("Color1")]
			public int Color1Xml
			{
				get { return _color1.ToArgb(); }
				set { _color1 = Color.FromArgb(value); }
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether Color1 property should be serialized.
			/// </summary>
			/// <returns>true if the Color1 property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeColor1Xml()
			{
				return _color1 != Color.Empty;
			}

			/// <summary>
			/// Gets or sets the second fill color.
			/// </summary>
			[Description("Gets or sets the second fill color.")]
			[DefaultValue(typeof(Color), "White")]
			[XmlIgnore]
			public Color Color2
			{
				get { return _color2; }
				set
				{
					if (_color2 != value)
					{
						_color2 = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// For internal XML serialization used. Gets or sets the argb value for Color2 property.
			/// </summary>
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[XmlElement("Color2")]
			public int Color2Xml
			{
				get { return _color2.ToArgb(); }
				set { _color2 = Color.FromArgb(value); }
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether Color2 property should be serialized.
			/// </summary>
			/// <returns>true if the Color2 property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeColor2Xml()
			{
				return _color2 != Color.White;
			}

			/// <summary>
			/// Gets or sets the color filled region outlines.
			/// </summary>
			[Description("Gets or sets the color filled region outlines.")]
			[DefaultValue(typeof(Color), "Empty")]
			[XmlIgnore]
			public Color OutlineColor
			{
				get { return _outlineColor; }
				set
				{
					if (_outlineColor != value)
					{
						_outlineColor = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// For internal XML serialization used. Gets or sets the argb value for OutlineColor property.
			/// </summary>
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[XmlElement("OutlineColor")]
			public int OutlineColorXml
			{
				get { return _outlineColor.ToArgb(); }
				set { _outlineColor = Color.FromArgb(value); }
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether OutlineColor property should be serialized.
			/// </summary>
			/// <returns>true if the OutlineColor property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeOutlineColorXml()
			{
				return _outlineColor != Color.Empty;
			}

			/// <summary>
			/// Gets or sets the thickness of filled region outlines.
			/// </summary>
			[Description("Gets or sets the thickness of filled region outlines.")]
			[DefaultValue(1)]
			public int OutlineThickness
			{
				get { return _outlineThickness; }
				set
				{
					if (_outlineThickness != value)
					{
						_outlineThickness = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the fill type.
			/// </summary>
			[Description("Gets or sets the fill type.")]
			[DefaultValue(FillTypeEnum.SolidColor)]
			public FillTypeEnum FillType
			{
				get { return _fillType; }
				set
				{
					if (_fillType != value)
					{
						_fillType = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the fill gradient style.
			/// </summary>
			[Description("Gets or sets the fill gradient style.")]
			[DefaultValue(GradientStyleEnum.Horizontal)]
			public GradientStyleEnum GradientStyle
			{
				get { return _gradientStyle; }
				set
				{
					if (_gradientStyle != value)
					{
						_gradientStyle = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the fill hatch style.
			/// </summary>
			[Description("Gets or sets the fill hatch style.")]
			[DefaultValue(HatchStyleEnum.Horizontal)]
			public HatchStyleEnum HatchStyle
			{
				get { return _hatchStyle; }
				set
				{
					if (_hatchStyle != value)
					{
						_hatchStyle = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the fill image.
			/// </summary>
			[Description("Gets or sets the fill image.")]
			[DefaultValue(null)]
			[XmlIgnore]
			public Image Image
			{
				get { return _image; }
				set
				{
					if (_image != value)
					{
						_image = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// For internal XML serialization used. Gets or sets the btyes array for Image property.
			/// </summary>
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[XmlElement("Image")]
			public byte[] ImageXml
			{
				get
				{
					if (_image == null) return null;
					return GraphicsUtils.SaveImageToMemory(_image, _image.RawFormat, true);
				}
				set
				{
					_image = GraphicsUtils.LoadImageFromMemory(value);
				}
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether Image property should be serialized.
			/// </summary>
			/// <returns>true if the Image property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeImageXml()
			{
				return _image != null;
			}

			/// <summary>
			/// Gets or sets the fill alpha value (transparency).
			/// </summary>
			[Description("Gets or sets the fill alpha value (transparency).")]
			[DefaultValue((byte)255)]
			public byte Alpha
			{
				get { return _alpha; }
				set
				{
					if (_alpha != value)
					{
						_alpha = value;
						OnPropertyChanged();
					}
				}
			}

			internal override bool IsDefault
			{
				get
				{
					return _alpha == 255
					       && _color1 == Color.Empty
					       && _color2 == Color.White
					       && _fillType == FillTypeEnum.SolidColor
					       && _gradientStyle == GradientStyleEnum.Horizontal
					       && _outlineColor == Color.Empty
					       && _outlineThickness == 1
					       && _hatchStyle == HatchStyleEnum.Horizontal
					       && _image == null;
				}
			}

			public override object Clone(Chart owner)
			{
				FillStyle style = new FillStyle();
				style._alpha = _alpha;
				style._color1 = _color1;
				style._color2 = _color2;
				style._fillType = _fillType;
				style._gradientStyle = _gradientStyle;
				style._outlineColor = _outlineColor;
				style._outlineThickness = _outlineThickness;
				style._hatchStyle = _hatchStyle;
				if (_image != null)
					style._image = _image.Clone() as Image;
				style.Owner = owner;
				return style;
			}
		}

		/// <summary>
		/// Represents the style of chart lines.
		/// </summary>
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class LineStyle : ChartOwnedItem
		{
			private int _thickness = 1;
			private Color _color = Color.Empty;
			private LinePatternEnum _pattern = LinePatternEnum.Solid;
			private float _miterLimit = 10f;
			private LineJoin _lineJoin = LineJoin.Miter;

			/// <summary>
			/// Gets or sets the thickness of the line in pixels. The valid range is from 0 to 1000.
			/// </summary>
			[Description("Gets or sets the thickness of the line in pixels.")]
			[DefaultValue(1)]
			public int Thickness
			{
				get { return _thickness; }
				set
				{
					if (_thickness==value || (value < 0 || value > 1000)) return;

					_thickness = value; 
					OnPropertyChanged();
				}
			}

			/// <summary>
			/// Gets or sets the color of the line.
			/// </summary>
			[Description("Gets or sets the color of the line.")]
			[DefaultValue(typeof(Color), "Empty")]
			[XmlIgnore]
			public Color Color
			{
				get { return _color; }
				set
				{
					if (_color != value)
					{
						_color = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// For internal XML serialization used. Gets or sets the argb value for Color property.
			/// </summary>
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[XmlElement("Color")]
			public int ColorXml
			{
				get
				{
					return _color.ToArgb();
				}
				set
				{
					_color = Color.FromArgb(value);
				}
			}

			/// <summary>
			/// For internal XML serialization used. Indicates whether Color property should be serialized.
			/// </summary>
			/// <returns>true if the Color property should be serialized; otherwise, false.</returns>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool ShouldSerializeColorXml()
			{
				return _color != Color.Empty;
			}

			/// <summary>
			/// Gets or sets the pattern of the line.
			/// </summary>
			[Description("Gets or sets the pattern of the line.")]
			[DefaultValue(LinePatternEnum.Solid)]
			public LinePatternEnum Pattern
			{
				get { return _pattern; }
				set
				{
					if (_pattern != value)
					{
						_pattern = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the joining style of the drawn line segments.
			/// </summary>
			/// <remarks>
			/// For further details, see the discussion of the LineJoin property and LineJoin
			/// enumeration for the System.Drawing.Pen instance.  The default value is appropriate
			/// for most situations.  Lower MiterLimit values or LineJoin.Round might be appropriate
			/// for thick lines.
			/// </remarks>
			[Description("Gets or sets the joining style of the drawn line segments.")]
			[DefaultValue(LineJoin.Miter)]
			public LineJoin LineJoin
			{
				get { return _lineJoin; }
				set
				{
					if (_lineJoin != value)
					{
						_lineJoin = value;
						OnPropertyChanged();
					}
				}
			}

			/// <summary>
			/// Gets or sets the miter limit of the joints of the drawn line.
			/// </summary>
			/// <remarks>
			/// For further details, see the discussion of the MiterLimit property for
			/// the System.Drawing.Pen instance.  The default value is appropriate for most
			/// situations.  Lower values might be appropriate for thick lines.
			/// </remarks>
			[Description("Gets or sets the miter limit of the joints of the drawn line.")]
			[DefaultValue(10f)]
			public float MiterLimit
			{
				get { return _miterLimit; }
				set
				{
					if (_miterLimit != value)
					{
						_miterLimit = value;
						OnPropertyChanged();
					}
				}
			}

			internal override bool IsDefault
			{
				get
				{
					return _thickness == 1
					       && _color == Color.Empty
					       && _pattern == LinePatternEnum.Solid
					       && _miterLimit == 10f
					       && _lineJoin == LineJoin.Miter;
				}
			}

			public override object Clone(Chart owner)
			{
				LineStyle style = new LineStyle();
				style._thickness = _thickness;
				style._color = _color;
				style._pattern = _pattern;
				style._miterLimit = _miterLimit;
				style._lineJoin = _lineJoin;
				style.Owner = owner;
				return style;
			}
		}

		/// <summary>
		/// Defines the method of interval creation.
		/// </summary>
		public enum IntervalCreationMethodEnum
		{
			/// <summary>
			/// Interval boundaries and width are calculated based on the data statistics.
			/// The number of intervals is an optional input.
			/// </summary>
			Automatic,
			/// <summary>
			/// Starting interval, interval width, and the number of intervals specify interval boundaries. 
			/// </summary>
			SemiAutomatic,
			/// <summary>
			/// The X data inputs will be used for interval boundaries.
			/// </summary>
			XDataBoundaries,
		}

		/// <summary>
		/// Defines the type of how to display the intervals.
		/// </summary>
		public enum DisplayTypeEnum
		{
			/// <summary>
			/// Displays the intervals and counts as a histogram.
			/// </summary>
			Histogram,
			/// <summary>
			/// Displays the intervals and counts as a frequency graph.
			/// </summary>
			FrequencyGraph,
			/// <summary>
			/// Displays the intervals and counts as a stepped frequency graph.
			/// </summary>
			SteppedFrequencyGraph,
		}

		/// <summary>
		/// Specifies how data shapes are filled.
		/// </summary>
		public enum FillTypeEnum
		{
			/// <summary>
			/// Solid color is used for filling using Color1.
			/// </summary>
			SolidColor,

			/// <summary>
			/// A two color gradient is used to fill using Color1 and Color2 with a pattern enumerated by the <see cref="GradientStyleEnum"/>./>.
			/// </summary>
			Gradient,

			/// <summary>
			/// A two color hatch pattern is used to fill using Color1 and Color2 with a pattern enumerated by the <see cref="HatchStyleEnum"/>./>.
			/// </summary>
			Hatch,

			/// <summary>
			/// A texture is created by tiling the specified Image of the FillStyle.
			/// </summary>
			Texture
		}

		/// <summary>
		/// Defines the style of the gradient.
		/// </summary>
		public enum GradientStyleEnum
		{
			/// <summary>
			/// No gradient filling.
			/// </summary>
			None,
			/// <summary>
			/// From left (Color1) to right (Color2).
			/// </summary>
			Horizontal,
			/// <summary>
			/// From center (Color1) to left and right (Color2).
			/// </summary>
			HorizontalCenter,
			/// <summary>
			/// From top (Color1) to bottom (Color2).
			/// </summary>
			Vertical,
			/// <summary>
			/// From center (Color1) to top and bottom (Color2).
			/// </summary>
			VerticalCenter,
			/// <summary>
			/// From left-bottom (Color1) to right-top (Color2).
			/// </summary>
			Diagonal,
			/// <summary>
			/// From center (Color1) to  left-bottom and right-top (Color2).
			/// </summary>
			DiagonalCenter,
			/// <summary>
			/// From left-top (Color1) to right-bottom (Color2).
			/// </summary>
			DiagonalBack,
			/// <summary>
			/// From center (Color1) to left-top and right-bottom (Color2).
			/// </summary>
			DiagonalBackCenter,
			/// <summary>
			/// From center (Color1) to corners (Color2) in radial direction.
			/// </summary>
			Radial,
			/// <summary>
			/// From center (Color1) to corners (Color2).
			/// </summary>
			FromCenter,
		}

		/// <summary>
		/// Defines the style of Hatch.
		/// </summary>
		public enum HatchStyleEnum
		{
			/// <summary>
			/// No pattern.
			/// </summary>
			None,
			/// <summary>
			/// A pattern of horizontal lines.
			/// </summary>
			Horizontal,
			/// <summary>
			/// A pattern of vertical lines.
			/// </summary>
			Vertical,
			/// <summary>
			/// A pattern of lines on a diagonal from upper left to lower right.
			/// </summary>
			ForwardDiagonal,
			/// <summary>
			/// A pattern of lines on a diagonal from upper right to lower left.
			/// </summary>
			BackwardDiagonal,
			/// <summary>
			/// Specifies horizontal and vertical lines that cross.
			/// </summary>
			Cross,
			/// <summary>
			/// Specifies forward diagonal and backward diagonal lines that cross. The lines are antialiased.
			/// </summary>
			DiagonalCross,
			/// <summary>
			/// Specifies a 5-percent hatch. The ratio of foreground color to background color is 5:100.
			/// </summary>
			Percent05,
			/// <summary>
			/// Specifies a 10-percent hatch. The ratio of foreground color to background color is 10:100.
			/// </summary>
			Percent10,
			/// <summary>
			/// Specifies a 20-percent hatch. The ratio of foreground color to background color is 20:100.
			/// </summary>
			Percent20,
			/// <summary>
			/// Specifies a 25-percent hatch. The ratio of foreground color to background color is 25:100.
			/// </summary>
			Percent25,
			/// <summary>
			/// Specifies a 30-percent hatch. The ratio of foreground color to background color is 30:100.
			/// </summary>
			Percent30,
			/// <summary>
			/// Specifies a 40-percent hatch. The ratio of foreground color to background color is 40:100.
			/// </summary>
			Percent40,
			/// <summary>
			/// Specifies a 50-percent hatch. The ratio of foreground color to background color is 50:100.
			/// </summary>
			Percent50,
			/// <summary>
			/// Specifies a 60-percent hatch. The ratio of foreground color to background color is 60:100.
			/// </summary>
			Percent60,
			/// <summary>
			/// Specifies a 70-percent hatch. The ratio of foreground color to background color is 70:100.
			/// </summary>
			Percent70,
			/// <summary>
			/// Specifies a 75-percent hatch. The ratio of foreground color to background color is 75:100.
			/// </summary>
			Percent75,
			/// <summary>
			/// Specifies a 80-percent hatch. The ratio of foreground color to background color is 80:100.
			/// </summary>
			Percent80,
			/// <summary>
			/// Specifies a 90-percent hatch. The ratio of foreground color to background color is 90:100.
			/// </summary>
			Percent90,
			/// <summary>
			/// Specifies diagonal lines that slant to the left from top points to bottom points and
			/// are spaced 50 percent closer together than ForwardDiagonal, but they are not antialiased.
			/// </summary>
			LightDownwardDiagonal,
			/// <summary>
			/// Specifies diagonal lines that slant to the left from top points to bottom points and
			/// are spaced 50 percent closer together than BackwardDiagonal, but they are not antialiased.
			/// </summary>
			LightUpwardDiagonal,
			/// <summary>
			/// Specifies diagonal lines that slant to the right from top points to bottom points,
			/// are spaced 50 percent closer together than, and are twice the width of ForwardDiagonal.
			/// This hatch pattern is not antialiased.
			/// </summary>
			DarkDownwardDiagonal,
			/// <summary>
			/// Specifies diagonal lines that slant to the left from top points to bottom points,
			/// are spaced 50 percent closer together than BackwardDiagonal, and are twice its width,
			/// but the lines are not antialiased.
			/// </summary>
			DarkUpwardDiagonal,
			/// <summary>
			/// Specifies diagonal lines that slant to the right from top points to bottom points,
			/// have the same spacing as hatch style ForwardDiagonal, and are triple its width, but are not antialiased.
			/// </summary>
			WideDownwardDiagonal,
			/// <summary>
			/// Specifies diagonal lines that slant to the left from top points to bottom points,
			/// have the same spacing as hatch style BackwardDiagonal, and are triple its width, but are not antialiased.
			/// </summary>
			WideUpwardDiagonal,
			/// <summary>
			/// Specifies vertical lines that are spaced 50 percent closer together than Vertical.
			/// </summary>
			LightVertical,
			/// <summary>
			/// Specifies horizontal lines that are spaced 50 percent closer together than Horizontal.
			/// </summary>
			LightHorizontal,
			/// <summary>
			/// Specifies vertical lines that are spaced 75 percent closer together
			/// than hatch style Vertical (or 25 percent closer together than LightVertical).
			/// </summary>
			NarrowVertical,
			/// <summary>
			/// Specifies horizontal lines that are spaced 75 percent closer together
			/// than hatch style Horizontal (or 25 percent closer together than LightHorizontal).
			/// </summary>
			NarrowHorizontal,
			/// <summary>
			/// Specifies vertical lines that are spaced 50 percent closer together than Vertical and are twice its width.
			/// </summary>
			DarkVertical,
			/// <summary>
			/// Specifies horizontal lines that are spaced 50 percent closer together than Horizontal and are twice its width.
			/// </summary>
			DarkHorizontal,
			/// <summary>
			/// Specifies dashed diagonal lines that slant to the right from top points to bottom points.
			/// </summary>
			DashedDownwardDiagonal,
			/// <summary>
			/// Specifies dashed diagonal lines that slant to the left from top points to bottom points.
			/// </summary>
			DashedUpwardDiagonal,
			/// <summary>
			/// Specifies dashed horizontal lines.
			/// </summary>
			DashedHorizontal,
			/// <summary>
			/// Specifies dashed vertical lines.
			/// </summary>
			DashedVertical,
			/// <summary>
			/// Specifies a hatch that has the appearance of confetti.
			/// </summary>
			SmallConfetti,
			/// <summary>
			/// Specifies a hatch that has the appearance of confetti,
			/// and is composed of larger pieces than SmallConfetti.
			/// </summary>
			LargeConfetti,
			/// <summary>
			/// Specifies horizontal lines that are composed of zigzags.
			/// </summary>
			ZigZag,
			/// <summary>
			/// Specifies horizontal lines that are composed of tildes.
			/// </summary>
			Wave,
			/// <summary>
			/// Specifies a hatch that has the appearance of layered bricks that
			/// slant to the left from top points to bottom points.
			/// </summary>
			DiagonalBrick,
			/// <summary>
			/// Specifies a hatch that has the appearance of horizontally layered bricks.
			/// </summary>
			HorizontalBrick,
			/// <summary>
			/// Specifies a hatch that has the appearance of a woven material.
			/// </summary>
			Weave,
			/// <summary>
			/// Specifies a hatch that has the appearance of a plaid material.
			/// </summary>
			Plaid,
			/// <summary>
			/// Specifies a hatch that has the appearance of divots.
			/// </summary>
			Divot,
			/// <summary>
			/// Specifies horizontal and vertical lines, each of which is composed of dots that cross.
			/// </summary>
			DottedGrid,
			/// <summary>
			/// Specifies forward diagonal and backward diagonal lines, each of which is composed of dots, that cross.
			/// </summary>
			DottedDiamond,
			/// <summary>
			/// Specifies a hatch that has the appearance of diagonally-layered shingles that slant
			/// to the right from top points to bottom points.
			/// </summary>
			Shingle,
			/// <summary>
			/// Specifies a hatch that has the appearance of a trellis.
			/// </summary>
			Trellis,
			/// <summary>
			/// Specifies a hatch that has the appearance of spheres laid adjacent to one another.
			/// </summary>
			Sphere,
			/// <summary>
			/// Specifies horizontal and vertical lines that cross and are spaced 50 percent
			/// closer together than hatch style Cross.
			/// </summary>
			SmallGrid,
			/// <summary>
			/// Specifies a hatch that has the appearance of a checkerboard.
			/// </summary>
			SmallCheckerBoard,
			/// <summary>
			/// Specifies a hatch that has the appearance of a checkerboard with
			/// squares that are twice the size of SmallCheckerBoard.
			/// </summary>
			LargeCheckerBoard,
			/// <summary>
			/// Specifies forward diagonal and backward diagonal lines that cross but are not antialiased.
			/// </summary>
			OutlinedDiamond,
			/// <summary>
			/// Specifies a hatch that has the appearance of a checkerboard placed diagonally.
			/// </summary>
			SolidDiamond,
		}

		/// <summary>
		/// Represents the patterns of the line.
		/// </summary>
		public enum LinePatternEnum
		{
			/// <summary>
			/// A solid line.
			/// </summary>
			Solid = DashStyle.Solid,
			/// <summary>
			/// A dashed line.
			/// </summary>
			Dash = DashStyle.Dash,
			/// <summary>
			/// A dotted line.
			/// </summary>
			Dot = DashStyle.Dot,
			/// <summary>
			/// A line with alternating dashes and dots.
			/// </summary>
			DashDot = DashStyle.DashDot,
			/// <summary>
			/// A line with series consisting of a dash followed by two dots.
			/// </summary>
			DashDotDot = DashStyle.DashDotDot,
			/// <summary>
			/// No line is drawn.
			/// </summary>
			None
		}

		#endregion Histogram Options

		#endregion Options
	}
}
