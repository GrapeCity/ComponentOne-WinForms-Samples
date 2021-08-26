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
// Copyright (C) 2004 - 2006 ComponentOne LLC
//------------------------------------------------------------------------------------
// Status   Date        By          Comments
// Created	Jun 2004	Bernardo	-
// Modified Jan 2005	Bernardo	Allow placement on group footer sections
// Modified Mar 2005	Bernardo	Added FormatX, FormatY properties to allow 
//									customization of axis label formats.
// Modified Jul 2006	Bernardo	Added ImageType, ShowLegend properties.
//------------------------------------------------------------------------------------
using System;
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

namespace C1.C1Report.CustomFields
{
    using C1.C1Preview;
	using C1.C1Report;
	//using C1.Win.C1Report.Util;
	using C1.Win.C1Chart;

	/// <summary>
	/// The Chart Class inherits from <see cref="Field"/> and uses the 
	/// <see cref="C1Chart"/> control to embed data bound charts in reports.
	/// </summary>
	[ Description("Chart Field") ]
	public class Chart : C1.C1Report.Field 
	{
		//-------------------------------------------------------------------------------------------
		#region ** enums

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
			Column
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
		#endregion

		//-------------------------------------------------------------------------------------------
		#region ** fields

		private C1.Win.C1Chart.C1Chart	_chart;			// internal C1Chart control
		private Image					_image;			// cached chart image (for design-time)
		private ChartTypeEnum			_chartType;		// chart type
		private Color					_dataColor;		// chart color (used when no palette is sepcified)
		private string					_colorNames;	// string of color names (e.g. Red;Green;Blue)
		private string					_dataX;			// label field
		private string					_dataY;			// data field (comma-delimited)
		private bool					_gridLines;		// show gridlines
		private bool					_boxed;			// draw box around chart
		private bool					_use3D;			// use 3D effects
		private bool					_radialLabels;	// radial labels (pie charts only)
		private bool					_showPercent;	// show percentages (pie charts only)
		private string					_recordSource;	// recordsource (override main report)
		private Color[]					_palette;		// color palette
		private double					_xMin, _xMax;	// explicit scale for x axis <<B168>>
		private double					_yMin, _yMax;	// explicit scale for y axis <<B168>>
		private string					_formatX;		// explicit format fox x axis labels <<B178>>
		private string					_formatY;		// explicit format fox y axis labels <<B178>>
		private ImageTypeEnum			_imageType;		// image format to use when creating the chart <<B182>>
        private ShowLegendEnum          _showLegend;    // whether to show the chart legend <<B221>>
        private AggregateEnum           _aggregate;     // how to aggregate the chart data

		#endregion

		//-------------------------------------------------------------------------------------------
		#region ** ctors

		/// <summary>
		/// Initializes a new instance of the <see cref="Chart"/> class.
		/// </summary>
		public Chart() 
		{
			// initialize instance
			ChartControl    = new C1.Win.C1Chart.C1Chart();
			PictureAlign    = PictureAlignEnum.Stretch;
			ChartType       = ChartTypeEnum.Bar;
			DataColor       = Color.Navy;
			GridLines       = false;
			RadialLabels    = false;
			ShowPercentages = true;
			XMin			= -1;
			XMax			= -1;
			YMin			= -1;
			YMax			= -1;
			_formatX		= string.Empty;
			_formatY		= string.Empty;
			_imageType		= ImageTypeEnum.Emf;
		}
        /// <summary>
        /// Overridden to clone the inner C1Chart control in the field so the 
        /// clone doesn't reference the original field's chart.
        /// </summary>
        /// <returns>A deep clone of the <see cref="Chart"/> field.</returns>
        public override object Clone()
        {
            Chart clone = base.Clone() as Chart;
            clone.ChartControl = new C1Chart();
            return clone;
        }

		#endregion

		//-------------------------------------------------------------------------------------------
		#region ** object model

		/// <summary>
		/// Gets or sets the chart type. Available types are Area, Bar, Pie, Scatter, Line and Column.
		/// </summary>
		[ Category("Chart"), DefaultValue(ChartTypeEnum.Bar) ]
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
		[ Category("Chart"), DefaultValue(false) ]
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
		[ Category("Chart"), DefaultValue(true) ]
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
		[ Category("Chart"), DefaultValue(""), Editor(typeof(C1.C1Report.Design.ExpressionEditor), typeof(UITypeEditor)) ]
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
		[ Category("Chart"), DefaultValue(""), Editor(typeof(C1.C1Report.Design.TextFieldEditor), typeof(UITypeEditor)) ]
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
		[ Category("Chart"), DefaultValue(""), Editor(typeof(C1.C1Report.Design.TextFieldEditor), typeof(UITypeEditor)) ]
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
		/// Specifies the color for the chart bars, lines, symbols, or pie slices.
		/// </summary>
		/// <remarks>
		/// If the chart contains more than one series (or pie slices) 
		/// then additional colors are generated automatically by making 
		/// the base color lighter. To control the color of each series in 
		/// a multi-series chart, use the <see cref="Palette"/> property instead.
		/// </remarks>
		[ Category("Chart"), DefaultValue(typeof(Color), "SteelBlue") ]
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
		[ Category("Chart"), DefaultValue("") ]
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
		[ Category("Chart"), DefaultValue(false) ]
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
		[ Category("Chart"), DefaultValue(false) ]
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
		[ Category("Chart"), DefaultValue(false) ]
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
		/// Minimum for X axis.
		/// </summary>
		[ Category("Chart"), DefaultValue(-1.0) ]
		public double XMin // <<B168>>
		{
			get { return _xMin; }
			set 
			{
				_xMin = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Maximum value for X axis.
		/// </summary>
		[ Category("Chart"), DefaultValue(-1.0) ]
		public double XMax // <<B168>>
		{
			get { return _xMax; }
			set 
			{
				_xMax = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Minimum for Y axis.
		/// </summary>
		[ Category("Chart"), DefaultValue(-1.0) ]
		public double YMin // <<B168>>
		{
			get { return _yMin; }
			set 
			{
				_yMin = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Maximum value for Y axis.
		/// </summary>
		[ Category("Chart"), DefaultValue(-1.0) ]
		public double YMax // <<B168>>
		{
			get { return _yMax; }
			set 
			{
				_yMax = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Gets or sets the annotation format for the X axis.
		/// </summary>
		/// <seealso cref="C1.Win.C1Chart.Axis.AnnoFormat"/>
        /// <remarks>
        /// <para>This property controls the format used to display values along the X axis of the chart.</para>
        /// <para>The value is a regular .NET format string that is used to format numeric or <see cref="DateTime"/> 
        /// values. For details on how to specify format strings, see the <see cref="IFormattable"/> interface.</para>
        /// <para>Typical values used for formatting numeric values are "F2" (floating point with two decimals),
        /// "C" (currency), and "#,##0.00" (thousand-separated values with two decimals).</para>
        /// </remarks>
		[ Category("Chart"), DefaultValue("") ]
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
		/// <seealso cref="C1.Win.C1Chart.Axis.AnnoFormat"/>
        /// <remarks>
        /// <para>This property controls the format used to display values along the Y axis of the chart.</para>
        /// <para>The value is a regular .NET format string that is used to format numeric or <see cref="DateTime"/> 
        /// values. For details on how to specify format strings, see the <see cref="IFormattable"/> interface.</para>
        /// <para>Typical values used for formatting numeric values are "F2" (floating point with two decimals),
        /// "C" (currency), and "#,##0.00" (thousand-separated values with two decimals).</para>
        /// </remarks>
		[ Category("Chart"), DefaultValue("") ]
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
		/// Gets a reference to the underlying <see cref="C1Chart"/> control. 
		/// </summary>
		/// <remarks>
		/// You can set properties in the underlying <see cref="C1Chart"/> control using script or code, 
		/// but these properties are not persisted when the report is saved.
		/// </remarks>
		[ Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) ]
        public C1.Win.C1Chart.C1Chart ChartControl
        {
			get { return _chart; }
			set 
			{ 
				_chart = value;
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Gets or sets the type of image to use when exporting the chart to html. 
		/// </summary>
		/// <remarks>Because of GDI+ limitation, this conversion does not support transparency.</remarks>
		[ Category("Chart"), DefaultValue(ImageTypeEnum.Emf) ] // <<B182>>
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
        /// Gets or sets whether the chart should include a legend.
        /// </summary>
        [ Category("Chart"), DefaultValue(ShowLegendEnum.Automatic) ] // <<B221>>
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
        [Category("Chart"), DefaultValue(AggregateEnum.None)]
        public AggregateEnum Aggregate
        {
            get { return _aggregate; }
            set
            {
                _aggregate = value;
                OnPropertyChanged();
            }
        }
		#endregion

		//-------------------------------------------------------------------------------------------
		#region ** overrides

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
					_chart.Font      == (Font)this.Font &&
					_chart.Size      == GetFieldSizePixels())
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
		#endregion

		//-------------------------------------------------------------------------------------------
		#region ** private stuff

		/// <summary>
		/// Marks the owner report as dirty so it will clear the internal 
		/// cache and render again (useful for implementing custom fields).
		/// </summary>
		override public void OnPropertyChanged()
		{
			_image = null;
			base.OnPropertyChanged();
		}
		private Size GetFieldSizePixels(Graphics g)
		{
			// get field size
			Size sz = new Size((int)(Width/1440f*g.DpiX), (int)(Height/1440f*g.DpiY));

			// can't be empty <<B167>>
			if (sz.Width  <= 0) sz.Width = 1;
			if (sz.Height <= 0) sz.Height = 1;

			// return field size
			return sz;
		}
		private Size GetFieldSizePixels()
		{
			using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
				return GetFieldSizePixels(g);
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
			ChartData cd = _chart.ChartGroups.Group0.ChartData;
			cd.SeriesList.Clear();
			_chart.ChartLabels.LabelsCollection.Clear();

			// reset chart
			//_chart.Reset();
			//_chart.BackColor = Color.White; // shouldn't be necessary...
			//_chart.ForeColor = Color.White;
			//_chart.Font = Control.DefaultFont;

			// get useful chart objects 
			ChartGroup group = _chart.ChartGroups.Group0;
			Area area = _chart.ChartArea;

			// apply field properties to chart
			_chart.Size      = GetFieldSizePixels();
			_chart.BackColor = Utils.FromWpfColor(BackColor);
			_chart.ForeColor = Utils.FromWpfColor(ForeColor);
			_chart.Font      = Font;

			// initialize global chart parameters
			group.Use3D = Use3D; // <<IP282>> APRDS000302
			if (Use3D)
			{
				View3D view = _chart.ChartArea.PlotArea.View3D;
				if (view.Depth == 0)
					view.Depth = (_chartType == ChartTypeEnum.Pie) ? 20 : 5;
				if (view.Elevation == 0)
					view.Elevation = 45;
				if (view.Rotation == 0)
					view.Rotation = 45;
			}

			area.PlotArea.Boxed = Boxed;
			_chart.Legend.Visible = false;

			// initialize chart type parameters
			switch (_chartType)
			{
				case ChartTypeEnum.Area:
					group.ChartType = Chart2DTypeEnum.Area;
					area.Inverted = false;
					area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
					//area.AxisX.AnnotationRotation = 45; <<B179>> let the user choose
					break;
				case ChartTypeEnum.Column: // <<B168>>
					group.ChartType = Chart2DTypeEnum.Bar;
					area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
					//area.AxisX.Reversed = true; <<B182>> not reversed
					break;
				case ChartTypeEnum.Bar:
					group.ChartType = Chart2DTypeEnum.Bar;
					area.Inverted = true;
					area.AxisX.Reversed = true; 
					break;
				case ChartTypeEnum.Line: // <<B168>>
				case ChartTypeEnum.Scatter:
					group.ChartType = Chart2DTypeEnum.XYPlot;
					area.Inverted = false;
					area.AxisX.Reversed = false; // <<IP282>> set that explicitly (APRDS000299)
					//area.AxisX.AnnotationRotation = 45; <<B179>> let the user choose
					break;
				case ChartTypeEnum.Pie:
					group.ChartType = Chart2DTypeEnum.Pie;
					break;
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
                Axis ay = _chart.ChartArea.AxisY;
				ay.TickMinor = TickMarksEnum.None;
				ay.GridMajor.Visible = GridLines;
				ay.GridMajor.Thickness = 0;
				// <<IP282>> don't set Min to 0 in order to keep automatic minimum 
				// (VNRPT000415, APRDS000294)
				//		if (ay.Min > 0) ay.Min = 0;  
				if (YMax != -1) ay.Max = YMax; 
				if (YMin != -1) ay.Min = YMin; 
				ApplyLabelFormat(ay, _formatY, dt, 1); // <<B178>>

                // configure X-axis
                Axis ax = _chart.ChartArea.AxisX;
                //ax.Max = dt.Rows.Count - 0.5;
                ax.TickMinor = TickMarksEnum.None;
                if (XMin != -1) ax.Min = XMin;
                if (XMax != -1) ax.Max = XMax;
                ApplyLabelFormat(ax, _formatX, dt, 0); // <<B178>>
			}
			else // build pie charts
			{
				CreatePies(dt);
			}

			// create chart image
			Image img = _chart.GetImage(ImageFormat.Emf);

			// convert format and return image
			return ConvertImageFormat(img);
		}
		private Image ConvertImageFormat(Image img)
		{
			// we only convert to bitmaps
            if (img == null || _imageType == ImageTypeEnum.Emf)
            {
                return img;
            }

			// create bitmap
			Bitmap bmp = new Bitmap(img.Width, img.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				// transparency is not supported (too bad...)
				Color backColor = Utils.FromWpfColor(this.BackColor);
                if (backColor == Color.Transparent)
                {
                    backColor = Utils.FromWpfColor(ParentSection.BackColor);
                }
                if (backColor == Color.Transparent)
                {
                    backColor = Color.White;
                }

				// create the bitmap
				using (SolidBrush br = new SolidBrush(backColor))
				{
					g.FillRectangle(br, 0, 0, bmp.Width, bmp.Height);
					g.DrawImage(img, 0, 0, bmp.Width, bmp.Height);
				}
			}

			// save to stream and load it back
			MemoryStream ms = new MemoryStream();
			switch (_imageType)
			{
				case ImageTypeEnum.Bmp:
					bmp.Save(ms, ImageFormat.Bmp);
                    //bmp.Save(ms, ImageFormat.Png);
					break;
				case ImageTypeEnum.Gif:
					bmp.Save(ms, ImageFormat.Gif);
					break;
				case ImageTypeEnum.Jpeg:
					bmp.Save(ms, ImageFormat.Jpeg);
					break;
				case ImageTypeEnum.Png:
		//			bmp.Save(ms, ImageFormat.Bmp);
					bmp.Save(ms, ImageFormat.Png);
					break;
			}
			return Image.FromStream(ms);
		}
		private void ApplyLabelFormat(Axis ax, string fmt, DataTable dt, int col)
		{
            // get column data type
            Type type = dt.Columns[col].DataType;

            // use labels on string values
            if (type == typeof(string))
            {
                ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
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
                ax.AnnoMethod = AnnotationMethodEnum.Values;
                if (fmt == null || fmt.Length == 0)
                {
                    ax.AnnoFormat = FormatEnum.DateShort;
                }
                else
                {
                    ax.AnnoFormat = FormatEnum.DateManual;
                    ax.AnnoFormatString = fmt;
                }
                return;
            }

            // numeric values
            ax.AnnoMethod = AnnotationMethodEnum.Values;
            if (fmt == null || fmt.Length == 0)
            {
                ax.AnnoFormat = FormatEnum.NumericGeneral; 
            }
            else
            {
                ax.AnnoFormat = FormatEnum.NumericManual;
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
				: new Color[dt.Columns.Count-1];

			
			// build palette using base color and making colors lighter
			_palette = (ChartType == ChartTypeEnum.Pie)
				? new Color[dt.Rows.Count]
				: new Color[dt.Columns.Count-1];
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
            ChartData cd = _chart.ChartGroups.Group0.ChartData;
            ChartDataSeries ds = cd.SeriesList.AddNewSeries();
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
                ds.LineStyle.Pattern = LinePatternEnum.None;
            }
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
        private double GetDouble(object value, ChartData cd)
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
			ChartData cd = _chart.ChartGroups.Group0.ChartData;
			PointF[] pt = new PointF[dt.Columns.Count-1];
			for (int slice = 0; slice < dt.Rows.Count; slice++)
			{
				// create series (slice)
				ChartDataSeries ds = cd.SeriesList.AddNewSeries();

				// set color
				ds.LineStyle.Color = _palette[slice % _palette.Length];

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
					object value = dt.Rows[slice][pie+1];
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
                    _chart.Legend.Visible = !_radialLabels;
                    break;
                case ShowLegendEnum.Always:
                    _chart.Legend.Visible = true;
                    break;
                case ShowLegendEnum.Never:
                    _chart.Legend.Visible = false;
                    break;
            }

			// use radial labels instead of legend
			if (_radialLabels)
			{
				// configure labels
				C1.Win.C1Chart.Style s     = _chart.ChartLabels.DefaultLabelStyle;
				s.Font      = Font;
				s.ForeColor = Utils.FromWpfColor(ForeColor);
				s.BackColor = Color.White;
				s.Opaque    = true;
				s.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

				// attach labels to each slice
				for (int pie = 0; pie < dt.Columns.Count-1; pie++)
				{
					for (int slice = 0; slice < dt.Rows.Count; slice++)
					{
						C1.Win.C1Chart.Label lbl = _chart.ChartLabels.LabelsCollection.AddNewLabel();
						lbl.Text = cd.SeriesList[slice].Label;
						lbl.Compass = LabelCompassEnum.Radial;
						lbl.Offset = 20;
						lbl.Connected = true;
						lbl.Visible = true;
						lbl.AttachMethod = AttachMethodEnum.DataIndex;
						AttachMethodData am = lbl.AttachMethodData;
						am.GroupIndex  = 0;
						am.PointIndex  = pie;
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
			string colNames = (DataY != null)? DataY: "Series1;Series2";
			string[] dataY = colNames.Split(';');
			for (int i = 0; i < dataY.Length; i++)
			{
                dataY[i] = dataY[i].Trim();
			}

			// create chart data table
			// the first column always contains the DataX values
			// the remaining columns contain the chart data
			DataTable dt = new DataTable();
			dt.Columns.Add("X");
			for (int i = 0; i < dataY.Length; i++)
			{
				DataColumn col = dt.Columns.Add();
                col.DataType = typeof(int);
				col.Caption = dataY[i];
			}

			// at design time, create 10 points of random data
			if (designTime)
			{
				Random rnd = new Random(0);
				for (int i = 0; i < 10; i++)
				{
					DataRow newRow = dt.NewRow();
					newRow[0] = i + 1;
					for (int col = 1; col < dt.Columns.Count; col++)
						newRow[col] = rnd.Next(100);
					dt.Rows.Add(newRow);
				}
				return dt;
			}

			// if a custom RecordSource string was provided, use it
			if (RecordSource != null && RecordSource.Length > 0)
			{
				// get custom table
				DataTable dtCustom = new DataTable();
				string conn = ParentReport.DataSource.ConnectionString;
				string sql  = ParentReport.Evaluate(RecordSource).ToString();
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
						newRow[i+1] = dr[dataY[i]];
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
				for (; !rs.BOF(); rs.MovePrevious())
				{
					// break at group start
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

				// <<IP223>> for details see APRDS000262
				// Sometimes current cursor position is not equal to bkmk position;
				// in such cases chart image has no some data which should be there.
				// (It occurs only for group headers and footers)
				if (this.ParentSection.Type != SectionTypeEnum.Detail)
				{
					rs.SetBookmark(bkmk); 
				}

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
						newRow[i+1] = ParentReport.Evaluate(dataY[i]);

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
		private object[] GetGroupValues()
		{
			// get last group
			int lastGroup = ((int)Section - 5) / 2;
			if (lastGroup < 0) lastGroup = -1;
			object[] values = new object[lastGroup+1];

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
            internal static double GetDouble(object value)
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
    }
}
