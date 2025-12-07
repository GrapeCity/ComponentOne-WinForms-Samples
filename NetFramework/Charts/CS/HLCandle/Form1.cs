using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;


namespace HLCandle
{
	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton optComplexCandle;
		private System.Windows.Forms.RadioButton optCandle;
		private System.Windows.Forms.RadioButton optHiLoOpenClose;
		private System.Windows.Forms.RadioButton optHiLo;
		private System.Windows.Forms.CheckBox chkOpenVisible;
		private System.Windows.Forms.CheckBox chkCloseVisible;
		private System.Windows.Forms.GroupBox frTickLength;
		private System.Windows.Forms.GroupBox frCandleWidth;
		private System.Windows.Forms.GroupBox frChartTypes;
		private C1.Win.C1Chart.C1Chart chart;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.NumericUpDown udTickLen;
		private System.Windows.Forms.NumericUpDown udCandleWidth;
		private System.Windows.Forms.GroupBox frWidth;
		private System.Windows.Forms.NumericUpDown udWidth;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;

		/// <summary>
		
		/// Required designer variable.
		

		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.chart = new C1.Win.C1Chart.C1Chart();
			this.frChartTypes = new System.Windows.Forms.GroupBox();
			this.optComplexCandle = new System.Windows.Forms.RadioButton();
			this.optCandle = new System.Windows.Forms.RadioButton();
			this.optHiLoOpenClose = new System.Windows.Forms.RadioButton();
			this.optHiLo = new System.Windows.Forms.RadioButton();
			this.chkOpenVisible = new System.Windows.Forms.CheckBox();
			this.chkCloseVisible = new System.Windows.Forms.CheckBox();
			this.frTickLength = new System.Windows.Forms.GroupBox();
			this.udTickLen = new System.Windows.Forms.NumericUpDown();
			this.frCandleWidth = new System.Windows.Forms.GroupBox();
			this.udCandleWidth = new System.Windows.Forms.NumericUpDown();
			this.frWidth = new System.Windows.Forms.GroupBox();
			this.udWidth = new System.Windows.Forms.NumericUpDown();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.frChartTypes.SuspendLayout();
			this.frTickLength.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udTickLen)).BeginInit();
			this.frCandleWidth.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udCandleWidth)).BeginInit();
			this.frWidth.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			this.chart.Name = "chart";
			this.chart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plot" +
				"Area</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Styl" +
				"eData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" +
				"ame><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyle" +
				"><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name>" +
				"</NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><N" +
				"ame>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleDa" +
				"ta>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent" +
				";AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Parent" +
				"Name>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignH" +
				"orz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name></" +
				"NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleD" +
				"ata /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control" +
				"</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData" +
				"><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" +
				"Name><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>La" +
				"belStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Pare" +
				"ntName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedSt" +
				"yle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Contr" +
				"ol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Nam" +
				"edStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Tr" +
				"ansparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Na" +
				"me>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleD" +
				"ata>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></N" +
				"amedStyle></StyleCollection><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\"" +
				" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pat" +
				"tern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patter" +
				"n=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" Aut" +
				"oMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=" +
				"\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash" +
				"\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /" +
				"><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"Tru" +
				"e\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Gri" +
				"dMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMi" +
				"nor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Text /></" +
				"Axis></Axes><Header Compass=\"North\"><Text /></Header><Footer Compass=\"South\" Vis" +
				"ible=\"False\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></L" +
				"egend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,Clus" +
				"terWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnot" +
				"ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>" +
				"OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stac" +
				"ked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5<" +
				"/Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" +
				"e=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=\"True\"><DataSeriesColl" +
				"ection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickne" +
				"ss=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Box\" Color=\"C" +
				"oral\" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Singl" +
				"e;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSeri" +
				"alizer><Y3 /><Y2 /><Y>8;12;10;12;15</Y><LineStyle Thickness=\"1\" Color=\"DarkGray\"" +
				" Pattern=\"Solid\" /><SymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue\" /><SeriesLabe" +
				"l>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes" +
				"><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 />" +
				"<Y>10;16;17;15;23</Y><LineStyle Thickness=\"1\" Color=\"DarkGreen\" Pattern=\"Solid\" " +
				"/><SymbolStyle Shape=\"Tri\" Color=\"Cornsilk\" /><SeriesLabel>series 2</SeriesLabel" +
				"><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X>" +
				"</DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><L" +
				"ineStyle Thickness=\"1\" Color=\"DarkKhaki\" Pattern=\"Solid\" /><SymbolStyle Shape=\"D" +
				"iamond\" Color=\"Crimson\" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;S" +
				"ingle;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializ" +
				"er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" +
				"Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" +
				"e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" +
				"0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" +
				"hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," +
				"MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" +
				"False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" +
				"artGroupsCollection></Chart2DPropBag>";
			this.chart.Size = new System.Drawing.Size(552, 288);
			this.chart.TabIndex = 0;
			// 
			// frChartTypes
			// 
			this.frChartTypes.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							 this.optComplexCandle,
																																							 this.optCandle,
																																							 this.optHiLoOpenClose,
																																							 this.optHiLo});
			this.frChartTypes.Location = new System.Drawing.Point(8, 288);
			this.frChartTypes.Name = "frChartTypes";
			this.frChartTypes.Size = new System.Drawing.Size(536, 48);
			this.frChartTypes.TabIndex = 1;
			this.frChartTypes.TabStop = false;
			this.frChartTypes.Text = "Chart Types";
			// 
			// optComplexCandle
			// 
			this.optComplexCandle.Location = new System.Drawing.Point(416, 16);
			this.optComplexCandle.Name = "optComplexCandle";
			this.optComplexCandle.Size = new System.Drawing.Size(112, 24);
			this.optComplexCandle.TabIndex = 3;
			this.optComplexCandle.Text = "Complex Candle";
			this.optComplexCandle.Click += new System.EventHandler(this.optComplexCandle_Click);
			// 
			// optCandle
			// 
			this.optCandle.Location = new System.Drawing.Point(304, 16);
			this.optCandle.Name = "optCandle";
			this.optCandle.TabIndex = 2;
			this.optCandle.Text = "Candle";
			this.optCandle.Click += new System.EventHandler(this.optCandle_Click);
			// 
			// optHiLoOpenClose
			// 
			this.optHiLoOpenClose.Location = new System.Drawing.Point(136, 16);
			this.optHiLoOpenClose.Name = "optHiLoOpenClose";
			this.optHiLoOpenClose.Size = new System.Drawing.Size(152, 24);
			this.optHiLoOpenClose.TabIndex = 1;
			this.optHiLoOpenClose.Text = "Hi-Low-Open-Close";
			this.optHiLoOpenClose.Click += new System.EventHandler(this.optHiLoOpenClose_Click);
			// 
			// optHiLo
			// 
			this.optHiLo.Location = new System.Drawing.Point(32, 16);
			this.optHiLo.Name = "optHiLo";
			this.optHiLo.TabIndex = 0;
			this.optHiLo.Text = "Hi-Low";
			this.optHiLo.Click += new System.EventHandler(this.optHiLo_Click);
			// 
			// chkOpenVisible
			// 
			this.chkOpenVisible.Location = new System.Drawing.Point(24, 352);
			this.chkOpenVisible.Name = "chkOpenVisible";
			this.chkOpenVisible.Size = new System.Drawing.Size(112, 16);
			this.chkOpenVisible.TabIndex = 2;
			this.chkOpenVisible.Text = "Open Tick Visible?";
			this.chkOpenVisible.Click += new System.EventHandler(this.chkOpenVisible_Click);
			// 
			// chkCloseVisible
			// 
			this.chkCloseVisible.Location = new System.Drawing.Point(24, 376);
			this.chkCloseVisible.Name = "chkCloseVisible";
			this.chkCloseVisible.Size = new System.Drawing.Size(128, 16);
			this.chkCloseVisible.TabIndex = 3;
			this.chkCloseVisible.Text = "Close Tick Visible?";
			this.chkCloseVisible.Click += new System.EventHandler(this.chkCloseVisible_Click);
			// 
			// frTickLength
			// 
			this.frTickLength.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							 this.udTickLen});
			this.frTickLength.Location = new System.Drawing.Point(304, 344);
			this.frTickLength.Name = "frTickLength";
			this.frTickLength.Size = new System.Drawing.Size(96, 48);
			this.frTickLength.TabIndex = 4;
			this.frTickLength.TabStop = false;
			this.frTickLength.Text = "Tick Length";
			// 
			// udTickLen
			// 
			this.udTickLen.Location = new System.Drawing.Point(16, 16);
			this.udTickLen.Maximum = new System.Decimal(new int[] {
																															50,
																															0,
																															0,
																															0});
			this.udTickLen.Minimum = new System.Decimal(new int[] {
																															1,
																															0,
																															0,
																															0});
			this.udTickLen.Name = "udTickLen";
			this.udTickLen.Size = new System.Drawing.Size(64, 20);
			this.udTickLen.TabIndex = 0;
			this.udTickLen.Value = new System.Decimal(new int[] {
																														1,
																														0,
																														0,
																														0});
			this.udTickLen.ValueChanged += new System.EventHandler(this.udTickLen_ValueChanged);
			// 
			// frCandleWidth
			// 
			this.frCandleWidth.Controls.AddRange(new System.Windows.Forms.Control[] {
																																								this.udCandleWidth});
			this.frCandleWidth.Location = new System.Drawing.Point(448, 344);
			this.frCandleWidth.Name = "frCandleWidth";
			this.frCandleWidth.Size = new System.Drawing.Size(96, 48);
			this.frCandleWidth.TabIndex = 5;
			this.frCandleWidth.TabStop = false;
			this.frCandleWidth.Text = "Candle Width";
			// 
			// udCandleWidth
			// 
			this.udCandleWidth.Location = new System.Drawing.Point(16, 16);
			this.udCandleWidth.Maximum = new System.Decimal(new int[] {
																																	50,
																																	0,
																																	0,
																																	0});
			this.udCandleWidth.Minimum = new System.Decimal(new int[] {
																																	1,
																																	0,
																																	0,
																																	0});
			this.udCandleWidth.Name = "udCandleWidth";
			this.udCandleWidth.Size = new System.Drawing.Size(64, 20);
			this.udCandleWidth.TabIndex = 1;
			this.udCandleWidth.Value = new System.Decimal(new int[] {
																																1,
																																0,
																																0,
																																0});
			this.udCandleWidth.ValueChanged += new System.EventHandler(this.udCandleWidth_ValueChanged);
			// 
			// frWidth
			// 
			this.frWidth.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					this.udWidth});
			this.frWidth.Location = new System.Drawing.Point(160, 344);
			this.frWidth.Name = "frWidth";
			this.frWidth.Size = new System.Drawing.Size(96, 48);
			this.frWidth.TabIndex = 6;
			this.frWidth.TabStop = false;
			this.frWidth.Text = "Line Thickness";
			// 
			// udWidth
			// 
			this.udWidth.Location = new System.Drawing.Point(16, 16);
			this.udWidth.Maximum = new System.Decimal(new int[] {
																														50,
																														0,
																														0,
																														0});
			this.udWidth.Minimum = new System.Decimal(new int[] {
																														1,
																														0,
																														0,
																														0});
			this.udWidth.Name = "udWidth";
			this.udWidth.Size = new System.Drawing.Size(64, 20);
			this.udWidth.TabIndex = 1;
			this.udWidth.Value = new System.Decimal(new int[] {
																													1,
																													0,
																													0,
																													0});
			this.udWidth.ValueChanged += new System.EventHandler(this.udWidth_ValueChanged);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuFileExit});
			this.menuItem1.Text = "&File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuHelpAbout});
			this.menuItem3.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(550, 401);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.frWidth,
																																	this.frTickLength,
																																	this.chkCloseVisible,
																																	this.chkOpenVisible,
																																	this.frChartTypes,
																																	this.chart,
																																	this.frCandleWidth});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D -  HiLoOpenClose & Candle Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.frChartTypes.ResumeLayout(false);
			this.frTickLength.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udTickLen)).EndInit();
			this.frCandleWidth.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udCandleWidth)).EndInit();
			this.frWidth.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
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

		void setupChart()
		{
			// setup the chart
			chart.Style.BackColor = Color.LightGray;
      chart.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised ;
	
			// setup the chart area
			chart.ChartArea.Style.BackColor = Color.Silver;
			chart.ChartArea.Style.Border.BorderStyle= C1.Win.C1Chart.BorderStyleEnum.Raised;

			// setup the header
			chart.Header.Style.ForeColor = Color.Yellow;
			chart.Header.Style.BackColor = Color.Silver;
			chart.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised;
			chart.Header.Style.Font = new Font( "Arial", 14, FontStyle.Underline);

			// setup the legend
			chart.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Inset;
			chart.Legend.Style.BackColor = Color.LightGray;
			chart.Legend.Compass = C1.Win.C1Chart.CompassEnum.South;
			chart.Legend.Style.Font = new Font( "Arial", 9, FontStyle.Bold);
			chart.Legend.Visible = true;

			// setup axes
			chart.ChartArea.Style.ForeColor = Color.White;
			chart.ChartArea.AxisX.Min = 0.5f;
			chart.ChartArea.AxisX.Max = 5.5f;
			chart.ChartArea.AxisY.Min = 5f;
			chart.ChartArea.AxisY.Max = 25f;
		}

		void setupData()
		{
			// remove all previous data and add one new data series
			chart.ChartGroups[0].ChartData.SeriesList.Clear();
			chart.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

			double[] x = new double[] { 1, 2, 3, 4, 5};
			double[] y_hi = new double[]{8,12,10,12,15};
			double[] y_low = new double[] {20,22,19,24,25};
			double[] y_open = new double[] { 10,16,17,15,23};
			double[] y_close = new double[] { 16,19,15,22,18};

			chart.ChartGroups[0].ChartData[0].X.CopyDataIn(  x);
			chart.ChartGroups[0].ChartData[0].Y.CopyDataIn( y_hi);
			chart.ChartGroups[0].ChartData[0].Y1.CopyDataIn( y_low);
			chart.ChartGroups[0].ChartData[0].Y2.CopyDataIn( y_open);
			chart.ChartGroups[0].ChartData[0].Y3.CopyDataIn( y_close);

			chart.ChartGroups[0].ChartData[0].Label = "Series 1";
		}

		void setHiLoChart()
		{
			chart.ChartGroups[0].ChartType=C1.Win.C1Chart.Chart2DTypeEnum.HiLo ;

			chart.Header.Text="Hi Lo Chart";

			chart.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Color= System.Drawing.Color.Blue;
			
			chkOpenVisible.Enabled=false;
			chkCloseVisible.Enabled=false;
			frTickLength.Enabled=false;
			frCandleWidth.Enabled=false;
		}

		void setHiLoOpenCloseChart()
		{
			chart.ChartGroups[0].ChartType=C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose ;

			chart.Header.Text="Hi Lo OpenClose Chart";

			chart.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Color = System.Drawing.Color.Green ;
			chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Size = (int) udTickLen.Value ;

			chkOpenVisible.Enabled=true;
			chkCloseVisible.Enabled=true;
			frTickLength.Enabled=true;	
			frCandleWidth.Enabled=false;
		}

		void setCandleChart()
		{
			chart.ChartGroups[0].ChartType= C1.Win.C1Chart.Chart2DTypeEnum.Candle ;

			chart.ChartGroups[0].HiLoData.FillTransparent = true;
			chart.Header.Text="Candle Chart";	
			
			chart.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Color= System.Drawing.Color.Red;
			chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Size = (int)udCandleWidth.Value;

			chkOpenVisible.Enabled=false;
			chkCloseVisible.Enabled=false;
			frTickLength.Enabled=false;
			frCandleWidth.Enabled=true;
		}

		void setComplexCandleChart()
		{
			chart.ChartGroups[0].ChartType= C1.Win.C1Chart.Chart2DTypeEnum.Candle ;
			chart.ChartGroups[0].HiLoData.FillTransparent=false;
			chart.ChartGroups[0].HiLoData.FillFalling=true;

			chart.Header.Text="Complex Candle Chart";	
			
			chart.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Color= System.Drawing.Color.Red;
			chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Size = (int) udCandleWidth.Value;
			chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Color=System.Drawing.Color.Yellow;
			
			chkOpenVisible.Enabled=false;
			chkCloseVisible.Enabled=false;
			frTickLength.Enabled=false;
			frCandleWidth.Enabled=true;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			chkCloseVisible.Checked=true;
			chkOpenVisible.Checked=true;

			setupChart();
			setupData();

			setHiLoChart();
			optHiLo.Checked=true;

			udWidth.Value = 2;
			udTickLen.Value = 7;
			udCandleWidth.Value = 7;
		}		
	
		private void optCandle_Click(object sender, System.EventArgs e)
		{
			setCandleChart();
		}

		private void optHiLo_Click(object sender, System.EventArgs e)
		{
			setHiLoChart();
		}

		private void optHiLoOpenClose_Click(object sender, System.EventArgs e)
		{
			setHiLoOpenCloseChart();
		}

		private void optComplexCandle_Click(object sender, System.EventArgs e)
		{
			setComplexCandleChart();
		}

		private void chkOpenVisible_Click(object sender, System.EventArgs e)
		{
			chart.ChartGroups[0].HiLoData.ShowOpen = chkOpenVisible.Checked  ;
		}

		private void chkCloseVisible_Click(object sender, System.EventArgs e)
		{
			chart.ChartGroups[0].HiLoData.ShowClose = chkCloseVisible.Checked ;
		}

		private void udTickLen_ValueChanged(object sender, System.EventArgs e)
		{
			if( chart.ChartGroups[0].ChartData.SeriesList.Count!=0)
				chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Size = (int)udTickLen.Value;		
		}

		private void udCandleWidth_ValueChanged(object sender, System.EventArgs e)
		{
			if( chart.ChartGroups[0].ChartData.SeriesList.Count!=0)
				chart.ChartGroups[0].ChartData.SeriesList[0].SymbolStyle.Size = (int)udCandleWidth.Value;		
		}

		private void udWidth_ValueChanged(object sender, System.EventArgs e)
		{
			if( chart.ChartGroups[0].ChartData.SeriesList.Count!=0)
				chart.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Thickness = (int)udWidth.Value;
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
