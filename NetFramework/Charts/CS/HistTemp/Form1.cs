using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace HistTemp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtStatistics;
		private C1.Win.C1Chart.C1Chart chartRawData;
		private C1.Win.C1Chart.C1Chart chartHistogram;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chartRawData = new C1.Win.C1Chart.C1Chart();
			this.txtStatistics = new System.Windows.Forms.TextBox();
			this.chartHistogram = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartRawData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
			this.SuspendLayout();
			// 
			// txtStatistics
			// 
			this.txtStatistics.BackColor = System.Drawing.Color.White;
			this.txtStatistics.Multiline = true;
			this.txtStatistics.Name = "txtStatistics";
			this.txtStatistics.ReadOnly = true;
			this.txtStatistics.Size = new System.Drawing.Size(160, 160);
			this.txtStatistics.TabIndex = 1;
			this.txtStatistics.Text = "";
			// 
			// chartRawData
			// 
			this.chartRawData.DataSource = null;
			this.chartRawData.Location = new System.Drawing.Point(168, 0);
			this.chartRawData.Name = "chartRawData";
			this.chartRawData.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;AlignV" +
				"ert=Top;\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><NamedStyl" +
				"e Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;Ali" +
				"gnVert=Center;\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"Bord" +
				"er=None,Transparent,1;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleDa" +
				"ta=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.d" +
				"efault\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle Name=\"" +
				"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"La" +
				"belStyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent" +
				",1;BackColor=Transparent;\" /><NamedStyle Name=\"PlotArea\" ParentName=\"Area\" Style" +
				"Data=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Control.default\" ParentNam" +
				"e=\"\" StyleData=\"ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" +
				"l;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Border=N" +
				"one,Transparent,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"AxisY\" ParentNa" +
				"me=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><Nam" +
				"edStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Cen" +
				"ter;AlignVert=Bottom;\" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" +
				"me=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeriesS" +
				"erializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"B" +
				"ox\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" +
				"Style Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><Seri" +
				"esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" +
				"gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" +
				"le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" +
				"\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2<" +
				"/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" +
				"e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " +
				"/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><S" +
				"ymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel>" +
				"<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" +
				"le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" +
				"sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" +
				"illStyle Color1=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup><ChartG" +
				"roup Name=\"Group2\"><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" +
				"=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" +
				"n><Header Compass=\"North\" /><Footer Compass=\"South\" /><Legend Compass=\"East\" Vis" +
				"ible=\"False\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"S" +
				"outh\"><GridMajor /><GridMinor /></Axis><Axis Max=\"25\" Min=\"5\" UnitMajor=\"5\" Unit" +
				"Minor=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Comp" +
				"ass=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" " +
				"UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Co" +
				"mpass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.chartRawData.Size = new System.Drawing.Size(336, 208);
			this.chartRawData.TabIndex = 0;
			// 
			// chartHistogram
			// 
			this.chartHistogram.DataSource = null;
			this.chartHistogram.Location = new System.Drawing.Point(168, 232);
			this.chartHistogram.Name = "chartHistogram";
			this.chartHistogram.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;AlignV" +
				"ert=Top;\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><NamedStyl" +
				"e Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;Ali" +
				"gnVert=Center;\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"Bord" +
				"er=None,Transparent,1;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleDa" +
				"ta=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.d" +
				"efault\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle Name=\"" +
				"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"La" +
				"belStyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent" +
				",1;BackColor=Transparent;\" /><NamedStyle Name=\"PlotArea\" ParentName=\"Area\" Style" +
				"Data=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Control.default\" ParentNam" +
				"e=\"\" StyleData=\"ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" +
				"l;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Border=N" +
				"one,Transparent,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"AxisY\" ParentNa" +
				"me=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><Nam" +
				"edStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Cen" +
				"ter;AlignVert=Bottom;\" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" +
				"me=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeriesS" +
				"erializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"B" +
				"ox\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" +
				"Style Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><Seri" +
				"esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" +
				"gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" +
				"le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" +
				"\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2<" +
				"/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" +
				"e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " +
				"/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><S" +
				"ymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel>" +
				"<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" +
				"le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" +
				"sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" +
				"illStyle Color1=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup><ChartG" +
				"roup Name=\"Group2\"><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" +
				"=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" +
				"n><Header Compass=\"North\" /><Footer Compass=\"South\" /><Legend Compass=\"East\" Vis" +
				"ible=\"False\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"S" +
				"outh\"><GridMajor /><GridMinor /></Axis><Axis Max=\"25\" Min=\"5\" UnitMajor=\"5\" Unit" +
				"Minor=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Comp" +
				"ass=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" " +
				"UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Co" +
				"mpass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.chartHistogram.Size = new System.Drawing.Size(344, 192);
			this.chartHistogram.TabIndex = 2;
			this.chartHistogram.DoubleClick += new System.EventHandler(this.chartHistogram_DoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.chartHistogram,
																		  this.txtStatistics,
																		  this.chartRawData});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartRawData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		public enum SeasonEnum
		{ 
			Years,
			Winter,
			Spring,
			Summer,
			Fall
		}

		public double [] KansasCityTempData(SeasonEnum season)
		{
			// returns year or Average Mean Temperature for the seasons from
			// 1889 to 2004 for the specified Season in Kansas City, Mo., USA
			//
			// http://www.crh.noaa.gov/eax/climo/winyear.htm
			double [] Winter = new double[]
			{
					37.0,34.0,33.9,25.2,30.9,29.0,33.3,33.5,31.8,26.1,
					30.2,32.6,27.7,29.8,29.2,25.1,34.0,33.4,35.0,34.6,
					27.0,33.6,26.8,31.8,33.9,30.1,30.8,32.1,24.6,36.0,
					29.7,37.9,33.0,34.8,33.0,30.9,34.2,34.1,32.9,27.3,
					32.8,38.4,39.0,34.9,36.1,33.3,24.6,31.0,33.6,34.8,
					28.2,33.8,34.6,32.4,34.0,31.1,33.2,33.8,31.1,31.3,
					34.3,32.0,34.5,36.1,36.6,33.7,31.3,33.6,33.0,30.8,
					33.3,33.6,28.8,28.1,32.8,32.0,35.2,34.1,32.0,30.0,
					31.8,32.7,32.4,29.4,29.5,30.0,34.6,26.2,22.0,21.5,
					29.8,31.9,25.0,33.7,25.4,26.5,29.2,34.3,29.9,32.2,
					31.6,30.2,37.2,29.1,29.9,33.4,29.4,29.1,36.0,34.3,
					36.0,26.1,36.2,31.4,31.4,33.7,
			};

			// http://www.crh.noaa.gov/eax/climo/spryear.htm
			double [] Spring = new double[]
			{
				54.7,52.9,50.5,49.9,51.8,56.7,55.7,56.4,53.8,54.3,
				52.1,55.1,53.3,56.1,55.2,52.0,56.9,52.8,53.0,56.0,
				52.7,58.0,56.4,52.0,54.1,55.1,53.0,54.6,51.7,56.5,
				54.2,52.2,57.9,55.9,52.2,51.1,56.2,54.2,55.6,55.6,
				55.5,55.6,52.2,53.7,54.9,56.8,54.4,58.1,53.7,57.9,
				56.7,53.4,56.7,56.5,52.9,53.1,55.6,59.4,51.1,55.6,
				55.6,52.7,52.2,53.3,53.8,54.6,58.1,56.2,54.7,53.8,
				57.2,51.3,51.5,56.5,58.6,56.4,54.7,55.6,55.9,56.0,
				53.3,57.2,55.9,57.2,53.7,56.2,52.1,53.7,58.9,51.7,
				52.4,52.4,55.5,53.0,49.7,48.9,57.0,56.9,58.2,55.6,
				54.6,52.9,57.2,54.2,51.2,54.8,52.3,51.6,51.3,54.8,
				53.5,56.5,55.5,52.9,54.7,57.3,
			};

			// http://www.crh.noaa.gov/eax/climo/sumyear.htm
			double [] Summer = new double[]
			{
				74.0,77.1,72.5,75.5,74.5,76.7,74.2,75.8,76.9,76.8,
				76.7,77.1,81.9,74.8,74.2,73.5,76.2,75.5,75.8,74.4,
				77.3,75.3,79.4,75.7,80.9,79.1,71.6,77.7,75.5,80.8,
				77.9,74.7,78.4,77.6,76.9,75.1,77.6,76.9,73.0,74.7,
				76.5,78.9,79.1,79.1,79.6,84.9,79.6,84.4,80.4,79.9,
				79.3,77.5,78.2,77.5,79.7,77.4,75.4,78.2,79.6,77.9,
				78.3,72.8,75.1,80.4,81.3,82.6,79.3,80.0,79.9,76.8,
				79.1,77.5,75.0,77.3,80.0,77.4,76.6,77.2,74.8,78.3,
				76.9,79.3,78.0,77.1,76.1,74.9,78.3,76.0,76.2,76.8,
				74.6,80.3,75.0,74.5,78.7,76.5,72.7,76.1,77.5,80.2,
				74.8,76.6,78.1,71.6,76.2,75.7,76.6,74.6,75.1,76.1,
				76.3,76.6,76.7,78.7,77.8,72.7,
			};

			// http://www.crh.noaa.gov/eax/climo/falyear.htm
			double [] Fall = new double[]
			{
				53.2,55.3,55.8,56.5,57.1,56.9,55.8,53.4,61.6,55.0,
				61.0,59.0,58.5,58.0,55.5,59.6,57.7,56.9,56.7,57.9,
				59.3,58.0,55.9,58.2,58.4,60.2,60.6,57.3,55.5,57.0,
				56.7,58.2,59.4,60.1,56.6,58.5,55.4,55.3,59.8,57.6,
				55.1,58.7,63.5,55.0,60.3,59.0,55.9,57.7,56.3,61.4,
				60.9,58.8,59.7,57.9,54.9,59.5,57.8,59.4,60.6,58.7,
				58.3,57.9,54.4,57.3,61.6,61.5,57.9,61.5,55.5,61.0,
				55.1,60.6,56.3,58.3,65.4,58.9,59.5,59.2,57.0,56.8,
				57.8,58.2,61.2,54.7,57.6,54.1,56.1,51.9,55.6,58.1,
				55.7,56.0,56.4,55.0,57.5,55.6,53.4,55.5,55.4,55.8,
				54.5,59.7,54.4,53.9,51.9,57.1,54.1,52.7,55.9,59.6,
				58.2,55.7,57.6,55.0,55.0,58.2,
			};

			double [] seasonData = null;
			switch(season)
			{
				case SeasonEnum.Years:
				{
					// returns an array of the years for which temperature
					// data are available.
					int i=0, j=0;
					seasonData = (double[])Array.CreateInstance(typeof(double), 2004 - 1889 + 1);
					for(i=1889; i <= 2004; i++)
					{
						seasonData[j] = i;
						j++;
					}
				}
					break;
				case SeasonEnum.Winter:
					// returns Winter Average Mean Temperatures
					seasonData = Winter;
					break;
				case SeasonEnum.Spring:
					// returns Spring Average Mean Temperatures
					seasonData = Spring;
					break;
				case SeasonEnum.Summer:
					// returns Summer Average Mean Temperatures
					seasonData = Summer;
					break;
				case SeasonEnum.Fall:
					seasonData = Fall;
					// returns Fall Average Mean Temperatures
					break;
			}
			return seasonData;
		}

		private void SetupRawTempChart(C1Chart chart)
		{
			// show the average mean temperature data and resize
			// the chart with the form.
			chart.Reset();
			chart.Width = this.ClientSize.Width - chart.Left;
			chart.Height = this.ClientSize.Height / 2;
			
			// setup the chart appearance
			chart.Style.BackColor = Color.White;
			chart.Style.Border.BorderStyle = BorderStyleEnum.Inset;
			chart.Style.Border.Thickness = 2;
			chart.Style.Border.Color = Color.Black;

			// setup the axis limits and titles
			Axis ax = chart.ChartArea.AxisX;
			ax.Min = 1880;
			ax.Max = 2020;

			ax = chart.ChartArea.AxisY;
			ax.Text = "Temperature F";
			ax.Min = 0;
			ax.Max = 100;

			ax = chart.ChartArea.AxisY2;
			ax.Text = "Temperature C";
			ax.Min = (0.0 - 32.0) * 5.0 / 9.0;
			ax.Max = (100.0 - 32.0) * 5.0 / 9.0;

			// Legend and header
			chart.Legend.Visible = true;
			chart.Header.Text = "Yearly Average Kansas City Mean Temperatures by Season";
			chart.Header.Style.Font = new Font("Arial Narrow", 12, FontStyle.Bold);

			// get and add the data
			double [] years = KansasCityTempData(SeasonEnum.Years);
			ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;

			// use a thicker line for the plots so the lines are very visible.
			const int lineThickness = 2;

			// Winter
			ChartDataSeries cds = cdsc.AddNewSeries();
			cds.X.CopyDataIn(years);
			cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Winter));
			cds.SymbolStyle.Shape = SymbolShapeEnum.None;
			cds.Label = "Winter";
			cds.LineStyle.Color = Color.Blue;
			cds.LineStyle.Thickness = lineThickness;

			// Spring
			cds = cdsc.AddNewSeries();
			cds.X.CopyDataIn(years);
			cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Spring));
			cds.SymbolStyle.Shape = SymbolShapeEnum.None;
			cds.Label = "Spring";
			cds.LineStyle.Color = Color.Green;
			cds.LineStyle.Thickness = lineThickness;

			// Summer
			cds = cdsc.AddNewSeries();
			cds.X.CopyDataIn(years);
			cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Summer));
			cds.SymbolStyle.Shape = SymbolShapeEnum.None;
			cds.Label = "Summer";
			cds.LineStyle.Color = Color.Red;
			cds.LineStyle.Thickness = lineThickness;

			// Fall
			cds = cdsc.AddNewSeries();
			cds.X.CopyDataIn(years);
			cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Fall));
			cds.SymbolStyle.Shape = SymbolShapeEnum.None;
			cds.Label = "Fall";
			cds.LineStyle.Color = Color.Brown;
			cds.LineStyle.Thickness = lineThickness;

			// add a series to Group1 so the Y2 axis is shown.  At the same time
			// hide the series in the legend, since it is a dummy series.
			chart.ChartGroups[1].ChartData.SeriesList.AddNewSeries().LegendEntry = false;
		}

		private void SetupHistogramChart(C1Chart chartRaw, C1Chart chartHisto)
		{
			chartHisto.Reset();
			chartHisto.Left = 0;
			Form1_Resize(null, null);

			// Setup the Histogram chart appearance
			chartHisto.Style.BackColor = Color.AliceBlue;
			chartHisto.Style.Border.BorderStyle = BorderStyleEnum.Solid;
			chartHisto.Style.Border.Thickness = 2;
			chartHisto.Style.Border.Color = Color.Black;
			chartHisto.Legend.Visible = true;

			// Create a histogram type chart using a bar chart type rather an actual
			// histogram type.  Histograms reflect single series of data well, but do
			// not show multiple series as well as a bar chart.
			//
			// Use the chart static method to generate histogram data from the raw data.
			ChartGroup cgHisto = chartHisto.ChartGroups[0];
			ChartDataSeriesCollection cdscHisto = cgHisto.ChartData.SeriesList;
			cgHisto.ChartType = Chart2DTypeEnum.Bar;

			// obtain the data from chartRaw.
			ChartData cdRaw = chartRaw.ChartGroups[0].ChartData;
			ChartDataSeriesCollection cdscRaw = cdRaw.SeriesList;
			double dataMax=0, dataMin = 0;

			// determine the extremes from the series means
			foreach(ChartDataSeries cdsRaw0 in cdscRaw)
			{
				double mean = cdsRaw0.Y.Statistics.Mean;
				double mn = cdsRaw0.MinY - mean;
				double mx = cdsRaw0.MaxY - mean;

				if(dataMax < mx) dataMax = mx;
				if(dataMin > mn) dataMin = mn;
			}

			dataMax = Math.Ceiling(dataMax);
			dataMin = Math.Floor(dataMin);

			// Assume that the interval width is one degree.
			int intervalCount = (int)(dataMax - dataMin) + 1;

			foreach(ChartDataSeries cdsRaw in cdscRaw)
			{
				double [] rawData = (double[])cdsRaw.Y.CopyDataOut(typeof(double));

				// determine the difference of each point from the mean.
				double mean = cdsRaw.Y.Statistics.Mean;

				double [] differencesFromMean = (double[])rawData.Clone();
				for(int d=0; d < differencesFromMean.Length; d++)
					differencesFromMean[d] -= mean;

				double [] xbounds = null;
				double [] ycounts = null;
				double [] bis = null;

				// generate histogram data of the difference from the means.  Start
				// using a half-width less than the dataMin.  This will provide
				// intervals that center on each integral temperature difference.
				C1Chart.GenerateHistogramData(differencesFromMean, dataMin-0.5, 1.0,
					intervalCount, -1.0, ref xbounds, ref ycounts, ref bis);

				// add a series of histogramdata
				ChartDataSeries cdsHisto = cdscHisto.AddNewSeries();
				cdsHisto.Label = cdsRaw.Label;
				cdsHisto.LineStyle.Color = Color.FromArgb(128,cdsRaw.LineStyle.Color);

				bis = (double[])Array.CreateInstance(typeof(double), intervalCount);
				for(int p=0; p < intervalCount; p++)
					bis[p] = (xbounds[p] + xbounds[p+1]) / 2;

				cdsHisto.X.CopyDataIn(bis);
				cdsHisto.Y.CopyDataIn(ycounts);
			}

			// Add description and instructions to the header, footer and axes.
			chartHisto.Header.Text = "Bar Chart Histogram of Differences from Seasonal Mean Kansas City Temperatures";
			chartHisto.Header.Style.Font = chartRaw.Header.Style.Font;
			chartHisto.Footer.Text = "Double-Click to Toggle Bar Stacking";
			chartHisto.ChartArea.AxisX.Text = "Difference From Mean Seasonal Mean Temperature (F)";
			chartHisto.ChartArea.AxisY.Text = "Count of Seasonal Mean Temperatures";
		}

		private void SetupStatisticsInfo(C1Chart chart)
		{
			// obtain the temperature statistics from the chart series, and report
			// them through the textbox.
			TextBox tb = txtStatistics;
			ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
			foreach(ChartDataSeries cds in cdsc)
			{
				double mean = cds.Y.Statistics.Mean;
				double meanC = (mean - 32) * 5.0 / 9.0;

				double sd = cds.Y.Statistics.StdDev;
				double sdC = sd * 5.0 / 9.0;

				tb.Text += cds.Label + "\r\n";
				tb.Text += "   Mean:   " + mean.ToString("0.0") + "F (" + meanC.ToString("0.0") + "C)\r\n";
				tb.Text += "   StdDev: " + sd.ToString("0.00") + "F (" + sdC.ToString("0.00") + "C)\r\n\r\n";
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			SetupRawTempChart(chartRawData);
			SetupHistogramChart(chartRawData, chartHistogram);
			SetupStatisticsInfo(chartRawData);
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			// resize the charts with each form resize.
			C1Chart chart = chartRawData;

			int w = this.ClientSize.Width - chart.Left;
			int h = chart.Height;
			if(w < 100) w = 100;	
			chart.Width = w;
			txtStatistics.Height = h;

			chart = chartHistogram;
			chart.Width = this.ClientSize.Width;

			chart.Top = h;
			h = this.ClientSize.Height - h;
			if(h < 100) h = 100;
			chart.Height = h;

		}

		private void chartHistogram_DoubleClick(object sender, System.EventArgs e)
		{
			// toggle the stacking property, and adjust the bar chart clusterwidth
			// to fill each cluster when stacked, but separated when non-stacked.
			ChartGroup cg = chartHistogram.ChartGroups[0];
			if(cg.Stacked)
			{
				cg.Stacked = false;
				cg.Bar.ClusterWidth = 50;
			}
			else
			{
				cg.Stacked = true;
				cg.Bar.ClusterWidth = 100;
			}
		}
	}
}
