using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace TrendAndError
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.StatusBar statusBar1;
		private C1.Win.C1Chart.C1Chart trendChart;
		private System.Windows.Forms.MenuItem miView;
		private System.Windows.Forms.MenuItem miError;
		private System.Windows.Forms.MenuItem miErrScatter;
		private System.Windows.Forms.MenuItem miErrBar;
		private System.Windows.Forms.MenuItem miTrend;
		private System.Windows.Forms.MenuItem miTrend2;
		private System.Windows.Forms.MenuItem miTrend3;
		private System.Windows.Forms.MenuItem miTrend4;
		private System.Windows.Forms.MenuItem miTrend5;
		private System.Windows.Forms.MenuItem miTrend6;
		private System.Windows.Forms.MenuItem miNewData;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miHelp;
		private System.Windows.Forms.MenuItem miAbout;
		private System.Windows.Forms.MenuItem miFile;
		private C1.Win.C1Chart.C1Chart errChart;

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miNewData = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.miView = new System.Windows.Forms.MenuItem();
			this.miError = new System.Windows.Forms.MenuItem();
			this.miErrBar = new System.Windows.Forms.MenuItem();
			this.miErrScatter = new System.Windows.Forms.MenuItem();
			this.miTrend = new System.Windows.Forms.MenuItem();
			this.miTrend2 = new System.Windows.Forms.MenuItem();
			this.miTrend3 = new System.Windows.Forms.MenuItem();
			this.miTrend4 = new System.Windows.Forms.MenuItem();
			this.miTrend5 = new System.Windows.Forms.MenuItem();
			this.miTrend6 = new System.Windows.Forms.MenuItem();
			this.miHelp = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.errChart = new C1.Win.C1Chart.C1Chart();
			this.trendChart = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.errChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trendChart)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.miFile,
																																							this.miView,
																																							this.miHelp});
			// 
			// miFile
			// 
			this.miFile.Index = 0;
			this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miNewData,
																																					 this.menuItem5,
																																					 this.miExit});
			this.miFile.Text = "&File";
			// 
			// miNewData
			// 
			this.miNewData.Index = 0;
			this.miNewData.Text = "&New data";
			this.miNewData.Click += new System.EventHandler(this.miNewData_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// miExit
			// 
			this.miExit.Index = 2;
			this.miExit.Text = "E&xit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// miView
			// 
			this.miView.Index = 1;
			this.miView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miError,
																																					 this.miTrend});
			this.miView.Text = "&View";
			// 
			// miError
			// 
			this.miError.Index = 0;
			this.miError.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						this.miErrBar,
																																						this.miErrScatter});
			this.miError.Text = "Errors";
			// 
			// miErrBar
			// 
			this.miErrBar.Index = 0;
			this.miErrBar.RadioCheck = true;
			this.miErrBar.Text = "Bar";
			this.miErrBar.Click += new System.EventHandler(this.miErrBar_Click);
			// 
			// miErrScatter
			// 
			this.miErrScatter.Checked = true;
			this.miErrScatter.Index = 1;
			this.miErrScatter.RadioCheck = true;
			this.miErrScatter.Text = "Scatter";
			this.miErrScatter.Click += new System.EventHandler(this.miErrBar_Click);
			// 
			// miTrend
			// 
			this.miTrend.Index = 1;
			this.miTrend.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						this.miTrend2,
																																						this.miTrend3,
																																						this.miTrend4,
																																						this.miTrend5,
																																						this.miTrend6});
			this.miTrend.Text = "Trend";
			// 
			// miTrend2
			// 
			this.miTrend2.Checked = true;
			this.miTrend2.Index = 0;
			this.miTrend2.RadioCheck = true;
			this.miTrend2.Text = "Linear";
			this.miTrend2.Click += new System.EventHandler(this.miTrend2_Click);
			// 
			// miTrend3
			// 
			this.miTrend3.Index = 1;
			this.miTrend3.RadioCheck = true;
			this.miTrend3.Text = "Quadratic";
			this.miTrend3.Click += new System.EventHandler(this.miTrend2_Click);
			// 
			// miTrend4
			// 
			this.miTrend4.Index = 2;
			this.miTrend4.RadioCheck = true;
			this.miTrend4.Text = "Cubic";
			this.miTrend4.Click += new System.EventHandler(this.miTrend2_Click);
			// 
			// miTrend5
			// 
			this.miTrend5.Index = 3;
			this.miTrend5.RadioCheck = true;
			this.miTrend5.Text = "4-order";
			this.miTrend5.Click += new System.EventHandler(this.miTrend2_Click);
			// 
			// miTrend6
			// 
			this.miTrend6.Index = 4;
			this.miTrend6.RadioCheck = true;
			this.miTrend6.Text = "5-order";
			this.miTrend6.Click += new System.EventHandler(this.miTrend2_Click);
			// 
			// miHelp
			// 
			this.miHelp.Index = 2;
			this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miAbout});
			this.miHelp.Text = "&Help";
			// 
			// miAbout
			// 
			this.miAbout.Index = 0;
			this.miAbout.Text = "&About";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 411);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(632, 22);
			this.statusBar1.TabIndex = 0;
			this.statusBar1.Text = "Drag points on the top chart";
			// 
			// errChart
			// 
			this.errChart.DataSource = null;
			this.errChart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.errChart.Location = new System.Drawing.Point(0, 243);
			this.errChart.Name = "errChart";
			this.errChart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\"><StyleData>Border=Solid,ControlText,1;BackColor=Wh" +
				"ite;</StyleData></NamedStyle><NamedStyle Name=\"Legend\" ParentName=\"Legend.defaul" +
				"t\"><StyleData /></NamedStyle><NamedStyle Name=\"Footer\" ParentName=\"Control\"><Sty" +
				"leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=\"Area\" Pare" +
				"ntName=\"Area.default\"><StyleData /></NamedStyle><NamedStyle Name=\"Control\" Paren" +
				"tName=\"Control.default\"><StyleData>Border=Solid,Transparent,1;BackColor=Control;" +
				"</StyleData></NamedStyle><NamedStyle Name=\"AxisX\" ParentName=\"Area\"><StyleData>R" +
				"otation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent" +
				";Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=\"AxisY\"" +
				" ParentName=\"Area\"><StyleData>Rotation=Rotate270;Border=None,Transparent,1;Align" +
				"Horz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></Name" +
				"dStyle><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.defaul" +
				"t\"><StyleData /></NamedStyle><NamedStyle Name=\"Legend.default\" ParentName=\"Contr" +
				"ol\"><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedS" +
				"tyle><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Control\"><StyleDat" +
				"a>Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" +
				" Name=\"Header\" ParentName=\"Control\"><StyleData>Border=None,Black,1;</StyleData><" +
				"/NamedStyle><NamedStyle Name=\"Control.default\" ParentName=\"\"><StyleData>ForeColo" +
				"r=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><Na" +
				"medStyle Name=\"AxisY2\" ParentName=\"Area\"><StyleData>Rotation=Rotate90;Border=Non" +
				"e,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData" +
				"></NamedStyle><NamedStyle Name=\"Area.default\" ParentName=\"Control\"><StyleData>Bo" +
				"rder=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollection><Char" +
				"tGroupsCollection><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" Defa" +
				"ultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"Dark" +
				"Goldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</Ser" +
				"iesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Singl" +
				"e;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></D" +
				"ataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolS" +
				"tyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>" +
				"1;2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Doub" +
				"le;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSeri" +
				"alizer><DataSeriesSerializer><LineStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"" +
				"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10" +
				";16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double<" +
				"/DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSerie" +
				"sSerializer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"D" +
				"iamond\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</" +
				"Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><Da" +
				"taFields>;;;;</DataFields><Tag /></DataSeriesSerializer></DataSeriesCollection><" +
				"/DataSerializer><Name>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</Ch" +
				"artType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</B" +
				"ar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=Tru" +
				"e,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,Minimum" +
				"Size=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar" +
				">Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>Tr" +
				"ue</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=\"3.402823466385288" +
				"6E+38\" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType" +
				"><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiL" +
				"oData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowO" +
				"pen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5<" +
				"/Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degree" +
				"s=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Sho" +
				"wOutline></ChartGroup></ChartGroupsCollection><Header Compass=\"North\" Visible=\"F" +
				"alse\"><Text /></Header><Footer Compass=\"South\" Visible=\"False\"><Text /></Footer>" +
				"<Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartArea LocationDefau" +
				"lt=\"5, -1\"><Margin Left=\"1\" Right=\"1\" /></ChartArea><Axes><Axis Max=\"5\" Min=\"1\" " +
				"UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" A" +
				"utoMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Col" +
				"or=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pa" +
				"ttern=\"Dash\" /></Axis><Axis Max=\"25\" Min=\"5\" UnitMajor=\"5\" UnitMinor=\"2.5\" AutoM" +
				"ajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"W" +
				"est\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><Gri" +
				"dMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" " +
				"Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"T" +
				"rue\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True" +
				"\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGra" +
				"y\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.errChart.Size = new System.Drawing.Size(632, 168);
			this.errChart.TabIndex = 2;
			// 
			// trendChart
			// 
			this.trendChart.DataSource = null;
			this.trendChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trendChart.Name = "trendChart";
			this.trendChart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\"><StyleData>Border=Solid,ControlText,1;BackColor=Wh" +
				"ite;</StyleData></NamedStyle><NamedStyle Name=\"Legend\" ParentName=\"Legend.defaul" +
				"t\"><StyleData /></NamedStyle><NamedStyle Name=\"Footer\" ParentName=\"Control\"><Sty" +
				"leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=\"Area\" Pare" +
				"ntName=\"Area.default\"><StyleData /></NamedStyle><NamedStyle Name=\"Control\" Paren" +
				"tName=\"Control.default\"><StyleData>Border=Solid,Transparent,1;</StyleData></Name" +
				"dStyle><NamedStyle Name=\"AxisX\" ParentName=\"Area\"><StyleData>Rotation=Rotate0;Bo" +
				"rder=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;Alig" +
				"nVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=\"AxisY\" ParentName=\"Area\"" +
				"><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColo" +
				"r=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle" +
				" Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\"><StyleData /></" +
				"NamedStyle><NamedStyle Name=\"Legend.default\" ParentName=\"Control\"><StyleData>Bor" +
				"der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle N" +
				"ame=\"LabelStyleDefault.default\" ParentName=\"Control\"><StyleData>Border=None,Blac" +
				"k,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle Name=\"Header\" Par" +
				"entName=\"Control\"><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Named" +
				"Style Name=\"Control.default\" ParentName=\"\"><StyleData>ForeColor=ControlText;Bord" +
				"er=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle Name=\"Axi" +
				"sY2\" ParentName=\"Area\"><StyleData>Rotation=Rotate90;Border=None,Transparent,1;Al" +
				"ignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><Nam" +
				"edStyle Name=\"Area.default\" ParentName=\"Control\"><StyleData>Border=None,Black,1;" +
				"AlignVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection>" +
				"<ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><Dat" +
				"aSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><Symb" +
				"olStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;" +
				"4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Do" +
				"uble;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerialize" +
				"r><DataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"Cornfl" +
				"owerBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;" +
				"12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</" +
				"DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeries" +
				"Serializer><LineStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"T" +
				"ri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y" +
				"1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFi" +
				"elds>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineS" +
				"tyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesL" +
				"abel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><Y2 /><Y3 " +
				"/><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Dat" +
				"aFields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><N" +
				"ame>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>Other" +
				"Offset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillF" +
				"alling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</H" +
				"iLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Po" +
				"lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" +
				"ed=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></" +
				"ChartGroup><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Gro" +
				"up2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=" +
				"0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=" +
				"True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData" +
				"><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Deg" +
				"rees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fals" +
				"e,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGr" +
				"oup></ChartGroupsCollection><Header Compass=\"North\" Visible=\"False\"><Text /></He" +
				"ader><Footer Compass=\"South\" Visible=\"False\"><Text /></Footer><Legend Compass=\"E" +
				"ast\" Visible=\"False\"><Text /></Legend><ChartArea LocationDefault=\"5, -1\"><Margin" +
				" Left=\"1\" Right=\"1\" /></ChartArea><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" Unit" +
				"Minor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onT" +
				"op=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" Pat" +
				"tern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></A" +
				"xis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMino" +
				"r=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMa" +
				"jor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"Tr" +
				"ue\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0" +
				"\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" " +
				"_onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" " +
				"Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" />" +
				"</Axis></Axes></Chart2DPropBag>";
			this.trendChart.Size = new System.Drawing.Size(632, 243);
			this.trendChart.TabIndex = 3;
			this.trendChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseUp);
			this.trendChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			this.trendChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 433);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.trendChart,
																																	this.errChart,
																																	this.statusBar1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Trend&Error  Demo";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trendChart)).EndInit();
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

		Random rnd = new Random();
		int np = 15;

		private void GenerateData()
		{
			ChartData cd = trendChart.ChartGroups[0].ChartData;

			ChartDataSeries ds;

			if( cd.SeriesList.Count!=1)
			{
				cd.SeriesList.Clear();
				ds = cd.SeriesList.AddNewSeries();

				ds.LineStyle.Pattern = LinePatternEnum.None;
				ds.SymbolStyle.Shape = SymbolShapeEnum.Dot;

				ds.SymbolStyle.Color = Color.LightCoral;

				ds.SymbolStyle.OutlineColor = Color.DarkRed;
				ds.SymbolStyle.OutlineWidth = 1;
				ds.SymbolStyle.Size = 12;
			}
			else
				ds = cd[0];

			double[] x = new double[np];//!!VBSubst Dim x(np-1) As Double
			double[] y = new double[np];//!!VBSubst Dim y(np-1) As Double

			for( int i=0; i<np; i++)
			{
				x[i] = i;
				y[i] = rnd.NextDouble() * 100;
			}

			ds.X.CopyDataIn(x);
			ds.Y.CopyDataIn(y);
		}

		void CalculateErrors()
		{
			ChartData cd = trendChart.ChartGroups[0].ChartData;

			TrendLine tl;
			
			if(cd.TrendsList.Count==0)
			{
				tl = cd.TrendsList.AddNewTrendLine();
				tl.LineStyle.Color = Color.DarkGreen;
				tl.LineStyle.Thickness = 3;
				tl.ForecastBackward = 1;
				tl.ForecastForward = 1;
			}
			else
				tl = cd.TrendsList[0];

			double[] x = (double[])cd[0].X.CopyDataOut();
			double[] y = (double[])cd[0].Y.CopyDataOut();

			cd = errChart.ChartGroups[0].ChartData;
			ChartDataSeries ds;

			if( cd.SeriesList.Count>1)
			{
				cd.SeriesList.Clear();
				ds = cd.SeriesList.AddNewSeries();
				ds.LineStyle.Pattern = LinePatternEnum.None;

				ds.SymbolStyle.Shape = SymbolShapeEnum.DiagCross;
				ds.SymbolStyle.Color = Color.ForestGreen;
				ds.SymbolStyle.Size = 12;

				ds.LineStyle.Color = Color.ForestGreen;
			}
			else
				ds = cd[0];

			for( int i=0; i<np; i++)
			{
				y[i] -= tl.GetY( x[i]);
				x[i] = i+1;
			}

			ds.X.CopyDataIn(x);
			ds.Y.CopyDataIn(y);

			if(cd.TrendsList.Count==0)
			{
				tl = cd.TrendsList.AddNewTrendLine();
				tl.TrendLineType = TrendLineTypeEnum.Maximum;
				tl.LineStyle.Color = Color.FromArgb( 128, Color.Red);
				tl.LineStyle.Thickness = 3;
				tl.ForecastBackward = 1;
				tl.ForecastForward = 1;

				tl = cd.TrendsList.AddNewTrendLine();
				tl.TrendLineType = TrendLineTypeEnum.Minimum;
				tl.LineStyle.Color = Color.FromArgb( 128, Color.Blue);
				tl.LineStyle.Thickness = 3;
				tl.ForecastBackward = 1;
				tl.ForecastForward = 1;
			}

			double ymax = Math.Max( Math.Abs(ds.MaxY), Math.Abs(ds.MinY)) + 5;
			errChart.ChartArea.AxisY.SetMinMax( -ymax, ymax);
		}

		void CreatePointStyles()
		{
			ChartData cd = errChart.ChartGroups[0].ChartData;

			PointStyle ps = cd.PointStylesList.AddNewPointStyle();
			ps.Selection = PointStyleSelectionEnum.DataMaxY;
			ps.LineStyle.Color = Color.Red;
			ps.SymbolStyle.Color = Color.Red;
			ps.SymbolStyle.Shape = SymbolShapeEnum.DiagCross;
			ps.SymbolStyle.Size = 15;

			ps = cd.PointStylesList.AddNewPointStyle();
			ps.Selection = PointStyleSelectionEnum.DataMinY;
			ps.LineStyle.Color = Color.Blue;
			ps.SymbolStyle.Color = Color.Blue;
			ps.SymbolStyle.Shape = SymbolShapeEnum.DiagCross;
			ps.SymbolStyle.Size = 15;
		}

		bool moving = false;
		int move_si = -1;
		int move_pi = -1;
		Point move_pt;
		Point prev = Point.Empty;

		private void c1Chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int si = -1, pi = -1, dist = -1;
			if( trendChart.ChartGroups[0].CoordToDataIndex( e.X, e.Y,
				C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist))
			{
				if( dist <= 6)
				{
					trendChart.Cursor = Cursors.Hand;
					moving = true;
					move_si = si;
					move_pi = pi;
					move_pt = new Point( e.X, e.Y);
				}
			}
		}

		private void c1Chart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( moving)
			{
				double x = 0, y = 0;
				if( trendChart.ChartGroups[0].CoordToDataCoord( e.X, e.Y, ref x, ref y))
				{
					if( y>100)
						y = 100;
					else if( y<0)
						y = 0;

					trendChart.ChartGroups[0].ChartData[move_si].X[move_pi] = x;
					trendChart.ChartGroups[0].ChartData[move_si].Y[move_pi] = y;
					CalculateErrors();
				}

				trendChart.Cursor = Cursors.Default;
				moving = false;

				if( !prev.IsEmpty)
				{
					Point pt1 = trendChart.PointToScreen( move_pt);
					ControlPaint.DrawReversibleLine( pt1, prev, trendChart.ChartArea.PlotArea.BackColor);
					prev = Point.Empty;
				}
			}
		}

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( moving)
			{
				Point pt1 = trendChart.PointToScreen( move_pt);

				if( !prev.IsEmpty)
					ControlPaint.DrawReversibleLine( pt1, prev, trendChart.ChartArea.PlotArea.BackColor);

				Point pt2 = trendChart.PointToScreen( new Point( e.X, e.Y));
				ControlPaint.DrawReversibleLine( pt1, pt2, trendChart.ChartArea.PlotArea.BackColor);
				prev = pt2;
			}
			else
			{
				int si = -1, pi = -1, dist = -1;
				if( trendChart.ChartGroups[0].CoordToDataIndex( e.X, e.Y,
					C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist))
				{
					if( dist <= 6)
						trendChart.Cursor = Cursors.SizeAll;
					else
						trendChart.Cursor = Cursors.Arrow;
				}
				else
					trendChart.Cursor = Cursors.Arrow;
			}
		}

		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			trendChart.ChartArea.Size = new Size( ClientSize.Width-10, -1);
			errChart.ChartArea.Size = new Size( ClientSize.Width-10, -1);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			trendChart.Header.Text = "Random data with polynomial trend line";
			trendChart.Header.Visible = true;

			trendChart.ChartArea.AxisY.GridMajor.Visible = true;
			trendChart.ChartArea.AxisX.GridMajor.Visible = true;

			errChart.ChartArea.AxisX.GridMajor.Visible = true;
			errChart.ChartArea.AxisY.GridMajor.Visible = true;

			errChart.Header.Text = "Estimate Error";
			errChart.Header.Visible = true;

			errChart.ChartArea.AxisX.Text = "Sample Number";

			GenerateData();
			CalculateErrors();
			CreatePointStyles();
		}

		private void CheckGroup( MenuItem[] mis, object sender)
		{
			foreach( MenuItem mi in mis)
			{
				if( mi.Equals( sender))
					mi.Checked = true;
				else
					mi.Checked = false;
			}
		}

		private void miErrBar_Click(object sender, System.EventArgs e)
		{
			CheckGroup( new MenuItem[]{ miErrBar, miErrScatter}, sender);

			if( miErrBar.Equals(sender))
				errChart.ChartGroups[0].ChartType = Chart2DTypeEnum.Bar;
			else if( miErrScatter.Equals(sender))
				errChart.ChartGroups[0].ChartType = Chart2DTypeEnum.XYPlot;

			CalculateErrors();
		}

		private void miTrend2_Click(object sender, System.EventArgs e)
		{
			CheckGroup( new MenuItem[]{ miTrend2, miTrend3, miTrend4, miTrend5, miTrend6}, sender);
			ChartData cd = trendChart.ChartGroups[0].ChartData;
			TrendLine tl = cd.TrendsList[0];

			if( miTrend2.Equals(sender))
				tl.RegressionOptions.NumTerms = 2;
			else if( miTrend3.Equals(sender))
				tl.RegressionOptions.NumTerms = 3;
			else if( miTrend4.Equals(sender))
				tl.RegressionOptions.NumTerms = 4;
			else if( miTrend5.Equals(sender))
				tl.RegressionOptions.NumTerms = 5;
			else if( miTrend6.Equals(sender))
				tl.RegressionOptions.NumTerms = 6;

			CalculateErrors();
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miNewData_Click(object sender, System.EventArgs e)
		{
			GenerateData();
			CalculateErrors();
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
