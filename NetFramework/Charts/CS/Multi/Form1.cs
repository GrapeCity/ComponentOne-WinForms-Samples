using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Multi
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private C1.Win.C1Chart.C1Chart chartBar;
		private C1.Win.C1Chart.C1Chart chartXY;
		private C1.Win.C1Chart.C1Chart chartPie;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ToolBarButton tbbPrint;
		private System.Windows.Forms.ImageList ilToolbar;
		private System.Windows.Forms.ToolBarButton tbbPreview;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog;
		private System.Windows.Forms.ToolBarButton tbbPageSetup;
		private System.Windows.Forms.MenuItem menuFilePageSetup;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuFilePrintPreview;
		private System.Windows.Forms.MenuItem menuFilePrint;

		// initialize random generator
		Random rnd = new Random();
		// history storage for bar chart
		float ha = 0, hb = 0, hc = 0, hd = 0;
		// counter for XY chart
		int count = 0, shift = 0;
		int npoints = 10;
		private System.Windows.Forms.MenuItem menuFileStart;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ToolBarButton tbbStart;
		private System.Windows.Forms.MenuItem menuFileStop;
		int nblocks = 50;

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

		void positionCharts()
		{
			Rectangle rc = ClientRectangle;
			rc.Y += toolBar1.Height;
			rc.Height -= toolBar1.Height;
			
			chartPie.Location = new Point( rc.Left, rc.Top);			
			chartPie.Size = new Size( rc.Width / 2, rc.Height / 2);

			chartBar.Location = new Point( rc.Left + rc.Width / 2, rc.Top);
			chartBar.Size = new Size( rc.Width / 2, rc.Height / 2);

			chartXY.Location = new Point( rc.Left, rc.Top + rc.Height / 2);
			chartXY.Size = new Size( rc.Width, rc.Height / 2);
		}

		// printing handler 
		private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev) 
		{
			int marg = 10;
			int x = ev.MarginBounds.Left;
			int y  = ev.MarginBounds.Top;
			int w = ev.MarginBounds.Width;
			int h = ev.MarginBounds.Height;
			chartPie.Draw( ev.Graphics, new Rectangle( x, y, w/2-marg, h/2-marg));
			chartBar.Draw( ev.Graphics, new Rectangle( x+w/2+marg, y, w/2-marg, h/2-marg));
			chartXY.Draw( ev.Graphics, new Rectangle( x, y+h/2+marg, w, h/2-marg));
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.chartBar = new C1.Win.C1Chart.C1Chart();
			this.chartXY = new C1.Win.C1Chart.C1Chart();
			this.chartPie = new C1.Win.C1Chart.C1Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tbbPrint = new System.Windows.Forms.ToolBarButton();
			this.tbbPreview = new System.Windows.Forms.ToolBarButton();
			this.tbbPageSetup = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbStart = new System.Windows.Forms.ToolBarButton();
			this.ilToolbar = new System.Windows.Forms.ImageList(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileStart = new System.Windows.Forms.MenuItem();
			this.menuFileStop = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuFilePageSetup = new System.Windows.Forms.MenuItem();
			this.menuFilePrintPreview = new System.Windows.Forms.MenuItem();
			this.menuFilePrint = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
			((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartXY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
			this.SuspendLayout();
			// 
			// chartBar
			// 
			this.chartBar.BackColor = System.Drawing.Color.LightBlue;
			this.chartBar.Location = new System.Drawing.Point(296, 24);
			this.chartBar.Name = "chartBar";
			this.chartBar.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Silver;" +
				"</StyleData><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.def" +
				"ault</ParentName><StyleData>Border=Raised,LightBlue,1;AlignHorz=Center;BackColor" +
				"=Azure;</StyleData><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Contr" +
				"ol</ParentName><StyleData>Border=None,LightBlue,1;</StyleData><Name>Footer</Name" +
				"></NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Nam" +
				"e>Area</Name></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><S" +
				"tyleData>Border=Raised,LightBlue,1;BackColor=LightBlue;</StyleData><Name>Control" +
				"</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotation" +
				"=Rotate270;Border=None,LightBlue,1;AlignHorz=Near;BackColor=Transparent;AlignVer" +
				"t=Center;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><ParentName>Area" +
				"</ParentName><StyleData>Rotation=Rotate0;Border=None,LightBlue,1;AlignHorz=Cente" +
				"r;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>AxisY</Name></NamedSt" +
				"yle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleData /><" +
				"Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control</Paren" +
				"tName><StyleData>Border=None,LightBlue,1;Wrap=False;AlignVert=Top;</StyleData><N" +
				"ame>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</ParentNam" +
				"e><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>Label" +
				"StyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" +
				"ame><StyleData>Border=None,LightBlue,1;Font=Microsoft Sans Serif, 12pt, style=Bo" +
				"ld, Underline;</StyleData><Name>Header</Name></NamedStyle><NamedStyle><ParentNam" +
				"e /><StyleData>ForeColor=ControlText;Border=None,LightBlue,1;BackColor=Control;<" +
				"/StyleData><Name>Control.default</Name></NamedStyle><NamedStyle><ParentName>Area" +
				"</ParentName><StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Cen" +
				"ter;BackColor=Transparent;AlignVert=Top;</StyleData><Name>AxisY2</Name></NamedSt" +
				"yle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,LightBlue" +
				",1;AlignVert=Top;</StyleData><Name>Area.default</Name></NamedStyle></StyleCollec" +
				"tion><Axes><Axis Max=\"2.5\" Min=\"0.5\" UnitMajor=\"0.5\" UnitMinor=\"0.25\" AutoMajor=" +
				"\"True\" AutoMinor=\"True\" AutoMax=\"False\" AutoMin=\"False\" AnnoMethod=\"ValueLabels\"" +
				" _onTop=\"0\" Compass=\"West\"><ValueLabels><ValueLabel Value=\"1\" Text=\"Current\" /><" +
				"ValueLabel Value=\"2\" Text=\"History\" /></ValueLabels><GridMajor AutoSpace=\"True\" " +
				"Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thi" +
				"ckness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=" +
				"\"0\" UnitMajor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"Fals" +
				"e\" AutoMin=\"False\" _onTop=\"0\" Compass=\"South\"><GridMajor Spacing=\"10\" AutoSpace=" +
				"\"True\" Visible=\"True\" Thickness=\"1\" Color=\"Black\" Pattern=\"Dash\" /><GridMinor Sp" +
				"acing=\"5\" AutoSpace=\"True\" Visible=\"True\" Thickness=\"1\" Color=\"Black\" Pattern=\"D" +
				"ash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajo" +
				"r=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"Nort" +
				"h\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" />" +
				"<GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Te" +
				"xt /></Axis></Axes><Header Compass=\"North\"><Text>Vehicle Comparison</Text></Head" +
				"er><Footer Compass=\"South\"><Text /></Footer><Legend Compass=\"East\" Visible=\"True" +
				"\"><Text /></Legend><ChartArea Inverted=\"True\" /><ChartGroupsCollection><ChartGro" +
				"up><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Po" +
				"lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" +
				"ed=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Char" +
				"tType>Bar</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,Max" +
				"imumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=Tru" +
				"e,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Default" +
				"Set=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22</Y><" +
				"LineStyle Thickness=\"1\" Color=\"Orange\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Box" +
				"\" Color=\"Coral\" /><SeriesLabel>Cars</SeriesLabel><DataTypes>Single;Single;Single" +
				";Single;Single</DataTypes><Y1 /><X>1;2</X></DataSeriesSerializer><DataSeriesSeri" +
				"alizer><Y3 /><Y2 /><Y>8;12</Y><LineStyle Thickness=\"1\" Color=\"Violet\" Pattern=\"S" +
				"olid\" /><SymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue\" /><SeriesLabel>Trucks</S" +
				"eriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2" +
				"</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>10;10</Y><LineSt" +
				"yle Thickness=\"1\" Color=\"Aquamarine\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Inver" +
				"tedTri\" Color=\"Cyan\" /><SeriesLabel>Buses</SeriesLabel><DataTypes>Single;Single;" +
				"Single;Single;Single</DataTypes><Y1 /><X>1;2</X></DataSeriesSerializer><DataSeri" +
				"esSerializer><Y3 /><Y2 /><Y>15;15</Y><LineStyle Thickness=\"1\" Color=\"LightGray\" " +
				"Pattern=\"Solid\" /><SymbolStyle Shape=\"Star\" Color=\"DarkBlue\" /><SeriesLabel>Plan" +
				"es</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" +
				"X>1;2</X></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartG" +
				"roup><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</S" +
				"howOutline><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Deg" +
				"rees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Grou" +
				"p2</Name><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMe" +
				"thod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,Fi" +
				"llTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataS" +
				"erializer /></ChartGroup></ChartGroupsCollection></Chart2DPropBag>";
			this.chartBar.Size = new System.Drawing.Size(296, 192);
			this.chartBar.TabIndex = 1;
			// 
			// chartXY
			// 
			this.chartXY.BackColor = System.Drawing.Color.PaleGreen;
			this.chartXY.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chartXY.Location = new System.Drawing.Point(0, 216);
			this.chartXY.Name = "chartXY";
			this.chartXY.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>ForeColor=Blue;Border=Solid,Blue,1;</StyleDa" +
				"ta><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</Par" +
				"entName><StyleData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Con" +
				"trol</ParentName><StyleData>Border=None,PaleGreen,1;</StyleData><Name>Footer</Na" +
				"me></NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData>Fore" +
				"Color=Blue;</StyleData><Name>Area</Name></NamedStyle><NamedStyle><ParentName>Con" +
				"trol.default</ParentName><StyleData>ForeColor=ControlText;Border=Raised,PaleGree" +
				"n,1;BackColor=PaleGreen;</StyleData><Name>Control</Name></NamedStyle><NamedStyle" +
				"><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,PaleGreen," +
				"1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>Axis" +
				"X</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotatio" +
				"n=Rotate270;Border=None,PaleGreen,1;AlignHorz=Near;BackColor=Transparent;AlignVe" +
				"rt=Center;</StyleData><Name>AxisY</Name></NamedStyle><NamedStyle><ParentName>Lab" +
				"elStyleDefault.default</ParentName><StyleData /><Name>LabelStyleDefault</Name></" +
				"NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Pa" +
				"leGreen,1;Wrap=False;AlignVert=Top;</StyleData><Name>Legend.default</Name></Name" +
				"dStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Contro" +
				"l,1;BackColor=Transparent;</StyleData><Name>LabelStyleDefault.default</Name></Na" +
				"medStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Pale" +
				"Green,1;Font=Microsoft Sans Serif, 12pt, style=Bold, Underline;</StyleData><Name" +
				">Header</Name></NamedStyle><NamedStyle><ParentName /><StyleData>ForeColor=Contro" +
				"lText;Border=None,PaleGreen,1;BackColor=Control;</StyleData><Name>Control.defaul" +
				"t</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotatio" +
				"n=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVe" +
				"rt=Center;</StyleData><Name>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Co" +
				"ntrol</ParentName><StyleData>Border=None,PaleGreen,1;AlignVert=Top;</StyleData><" +
				"Name>Area.default</Name></NamedStyle></StyleCollection><Axes><Axis Max=\"5\" Min=\"" +
				"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"Fals" +
				"e\" Thickness=\"1\" AutoMin=\"False\" _onTop=\"0\" Compass=\"South\"><GridMajor Spacing=\"" +
				"1\" AutoSpace=\"True\" Visible=\"True\" Thickness=\"1\" Color=\"Blue\" Pattern=\"Dot\" /><G" +
				"ridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Text" +
				" /></Axis><Axis Max=\"12\" Min=\"-12\" UnitMajor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\"" +
				" AutoMinor=\"False\" AutoMax=\"False\" Thickness=\"1\" AutoMin=\"False\" _onTop=\"0\" Comp" +
				"ass=\"West\"><GridMajor Spacing=\"10\" AutoSpace=\"False\" Visible=\"True\" Thickness=\"1" +
				"\" Color=\"Blue\" Pattern=\"Solid\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color" +
				"=\"LightGray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\"" +
				" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _" +
				"onTop=\"0\" Compass=\"East\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightG" +
				"ray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray" +
				"\" Pattern=\"Dash\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text>Noise Lev" +
				"el</Text></Header><Footer Compass=\"South\"><Text /></Footer><Legend Compass=\"East" +
				"\" Visible=\"False\"><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGro" +
				"up><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Po" +
				"lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" +
				"ed=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Char" +
				"tType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter," +
				"MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=" +
				"True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Defa" +
				"ultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;1" +
				"9;24;25</Y><LineStyle Thickness=\"1\" Color=\"Black\" Pattern=\"Solid\" /><SymbolStyle" +
				" Shape=\"None\" Color=\"Coral\" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Sing" +
				"le;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSeri" +
				"alizer></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Clu" +
				"sterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees" +
				"=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,St" +
				"art=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlo" +
				"t</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize" +
				"=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWi" +
				"dth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup>" +
				"</ChartGroupsCollection></Chart2DPropBag>";
			this.chartXY.Size = new System.Drawing.Size(592, 184);
			this.chartXY.TabIndex = 2;
			// 
			// chartPie
			// 
			this.chartPie.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.chartPie.Location = new System.Drawing.Point(0, 24);
			this.chartPie.Name = "chartPie";
			this.chartPie.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>Border=None,PaleGoldenrod,1;</StyleData><Nam" +
				"e>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName" +
				"><StyleData>Border=Raised,PaleGoldenrod,1;AlignHorz=Center;BackColor=LightYellow" +
				";</StyleData><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</Pa" +
				"rentName><StyleData>Border=None,PaleGoldenrod,1;</StyleData><Name>Footer</Name><" +
				"/NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>" +
				"Area</Name></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><Sty" +
				"leData>Border=Raised,PaleGoldenrod,1;BackColor=PaleGoldenrod;</StyleData><Name>C" +
				"ontrol</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData" +
				">Border=None,PaleGoldenrod,1;BackColor=Transparent;</StyleData><Name>LabelStyleD" +
				"efault.default</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><Styl" +
				"eData>Rotation=Rotate270;Border=None,Control,1;AlignHorz=Near;BackColor=Transpar" +
				"ent;AlignVert=Center;</StyleData><Name>AxisY</Name></NamedStyle><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Control,1;Align" +
				"Horz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>AxisX</Name" +
				"></NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><Sty" +
				"leData /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Cont" +
				"rol</ParentName><StyleData>Border=None,PaleGoldenrod,1;Wrap=False;AlignVert=Top;" +
				"</StyleData><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Cont" +
				"rol</ParentName><StyleData>Border=None,PaleGoldenrod,1;Font=Microsoft Sans Serif" +
				", 12pt, style=Bold, Underline;</StyleData><Name>Header</Name></NamedStyle><Named" +
				"Style><ParentName /><StyleData>ForeColor=ControlText;Border=None,PaleGoldenrod,1" +
				";BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><NamedSt" +
				"yle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Transp" +
				"arent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Name>A" +
				"xisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>" +
				"Border=None,PaleGoldenrod,1;AlignVert=Top;</StyleData><Name>Area.default</Name><" +
				"/NamedStyle></StyleCollection><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMino" +
				"r=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"" +
				"0\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" P" +
				"attern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patt" +
				"ern=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"5\" UnitMinor=\"2.5\"" +
				" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Comp" +
				"ass=\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"" +
				"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Das" +
				"h\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=" +
				"\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\">" +
				"<GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Gr" +
				"idMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Text " +
				"/></Axis></Axes><Header Compass=\"North\"><Text>Vehicle Comparison</Text></Header>" +
				"<Footer Compass=\"South\"><Text>Current</Text></Footer><Legend Compass=\"East\" Visi" +
				"ble=\"True\"><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar" +
				">ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Deg" +
				"rees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fals" +
				"e,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>P" +
				"ie</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSiz" +
				"e=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullW" +
				"idth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=\"Tr" +
				"ue\"><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20</Y><LineStyle " +
				"Thickness=\"1\" Color=\"Red\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Box\" Color=\"Cora" +
				"l\" /><SeriesLabel>Cars</SeriesLabel><DataTypes>Single;Single;Single;Single;Singl" +
				"e</DataTypes><Y1 /><X>1</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y" +
				"2 /><Y>8</Y><LineStyle Thickness=\"1\" Color=\"Tan\" Pattern=\"Solid\" /><SymbolStyle " +
				"Shape=\"Dot\" Color=\"CornflowerBlue\" /><SeriesLabel>Trucks</SeriesLabel><DataTypes" +
				">Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1</X></DataSeriesSeriali" +
				"zer><DataSeriesSerializer><Y3 /><Y2 /><Y>10</Y><LineStyle Thickness=\"1\" Color=\"L" +
				"ightGreen\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Tri\" Color=\"Cornsilk\" /><Series" +
				"Label>Buses</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataType" +
				"s><Y1 /><X>1</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>16</" +
				"Y><LineStyle Thickness=\"1\" Color=\"MediumTurquoise\" Pattern=\"Solid\" /><SymbolStyl" +
				"e Shape=\"Diamond\" Color=\"Crimson\" /><SeriesLabel>Planes</SeriesLabel><DataTypes>" +
				"Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1</X></DataSeriesSerializ" +
				"er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" +
				"Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" +
				"e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" +
				"0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" +
				"hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," +
				"MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" +
				"False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" +
				"artGroupsCollection></Chart2DPropBag>";
			this.chartPie.Size = new System.Drawing.Size(296, 192);
			this.chartPie.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																																								this.tbbPrint,
																																								this.tbbPreview,
																																								this.tbbPageSetup,
																																								this.toolBarButton1,
																																								this.tbbStart});
			this.toolBar1.Divider = false;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.ilToolbar;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(592, 24);
			this.toolBar1.TabIndex = 8;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbbPrint
			// 
			this.tbbPrint.ImageIndex = 0;
			this.tbbPrint.Text = "Print";
			this.tbbPrint.ToolTipText = "Print";
			// 
			// tbbPreview
			// 
			this.tbbPreview.ImageIndex = 1;
			this.tbbPreview.Text = "Print Preview";
			this.tbbPreview.ToolTipText = "Print Preview";
			// 
			// tbbPageSetup
			// 
			this.tbbPageSetup.ImageIndex = 4;
			this.tbbPageSetup.Text = "Page Setup";
			this.tbbPageSetup.ToolTipText = "Page Setup";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbStart
			// 
			this.tbbStart.ImageIndex = 2;
			this.tbbStart.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbStart.Text = "Start";
			this.tbbStart.ToolTipText = "Start";
			// 
			// ilToolbar
			// 
			this.ilToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilToolbar.ImageSize = new System.Drawing.Size(16, 16);
			this.ilToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilToolbar.ImageStream")));
			this.ilToolbar.TransparentColor = System.Drawing.Color.Transparent;
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
																																							this.menuFileStart,
																																							this.menuFileStop,
																																							this.menuItem5,
																																							this.menuFilePageSetup,
																																							this.menuFilePrintPreview,
																																							this.menuFilePrint,
																																							this.menuItem4,
																																							this.menuFileExit});
			this.menuItem1.Text = "&File";
			// 
			// menuFileStart
			// 
			this.menuFileStart.Index = 0;
			this.menuFileStart.Text = "&Start";
			this.menuFileStart.Click += new System.EventHandler(this.menuFileStart_Click);
			// 
			// menuFileStop
			// 
			this.menuFileStop.Index = 1;
			this.menuFileStop.Text = "Sto&p";
			this.menuFileStop.Click += new System.EventHandler(this.menuFileStop_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// menuFilePageSetup
			// 
			this.menuFilePageSetup.Index = 3;
			this.menuFilePageSetup.Text = "Page Set&up ...";
			this.menuFilePageSetup.Click += new System.EventHandler(this.menuFilePageSetup_Click);
			// 
			// menuFilePrintPreview
			// 
			this.menuFilePrintPreview.Index = 4;
			this.menuFilePrintPreview.Text = "Print Pre&view";
			this.menuFilePrintPreview.Click += new System.EventHandler(this.menuFilePrintPreview_Click);
			// 
			// menuFilePrint
			// 
			this.menuFilePrint.Index = 5;
			this.menuFilePrint.Text = "&Print ...";
			this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 6;
			this.menuItem4.Text = "-";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 7;
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
			// printDocument
			// 
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
			// 
			// printPreviewDialog
			// 
			this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog.Document = this.printDocument;
			this.printPreviewDialog.Enabled = true;
			this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
			this.printPreviewDialog.Location = new System.Drawing.Point(526, 17);
			this.printPreviewDialog.MaximumSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.Name = "printPreviewDialog";
			this.printPreviewDialog.Opacity = 1;
			this.printPreviewDialog.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog.Visible = false;
			// 
			// printDialog
			// 
			this.printDialog.Document = this.printDocument;
			// 
			// pageSetupDialog
			// 
			this.pageSetupDialog.Document = this.printDocument;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.toolBar1,
																																	this.chartPie,
																																	this.chartXY,
																																	this.chartBar});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Multiple Charts Demo";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartXY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// clear data
			chartXY.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length = 0;
			// adjust axis
			chartXY.ChartArea.AxisX.Min = 0;
			chartXY.ChartArea.AxisX.Max = nblocks*npoints;

			positionCharts();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			int a, b, c, d;

			a = rnd.Next(1, 25);
			b = rnd.Next(1, 20);
			c = rnd.Next(1, 15);
			d = rnd.Next(1, 10);
    
			ha += a;
			hb += b;
			hc +=  c;
			hd += d;

			// for the bar graph
			float[] y0 = new float[] { a, ha * 0.025f};
			float[] y1 = new float[] { b, hb * 0.025f};
			float[] y2 = new float[] { c, hc * 0.025f};
			float[] y3 = new float[] { d, hd * 0.025f};

			chartBar.ChartGroups.Group0.ChartData.SeriesList[0].Y.CopyDataIn( y0);
			chartBar.ChartGroups.Group0.ChartData.SeriesList[1].Y.CopyDataIn( y1);
			chartBar.ChartGroups.Group0.ChartData.SeriesList[2].Y.CopyDataIn( y2);
			chartBar.ChartGroups.Group0.ChartData.SeriesList[3].Y.CopyDataIn( y3);
		
			// for the Pie Chart
			chartPie.ChartGroups.Group0.ChartData.SeriesList[0].Y[0] = a;
			chartPie.ChartGroups.Group0.ChartData.SeriesList[1].Y[0] = b;
			chartPie.ChartGroups.Group0.ChartData.SeriesList[2].Y[0] = c;
			chartPie.ChartGroups.Group0.ChartData.SeriesList[3].Y[0] = d;
			
			// for XY chart

			// adding n points

			if( count >= nblocks)
			{
				// adjust counters 
				shift += count*npoints;
				count = 0;
				// clear data
				chartXY.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length = 0;
				// adjust axes
				chartXY.ChartArea.AxisX.Max = shift + nblocks*npoints;
				chartXY.ChartArea.AxisX.Min = shift;
			}

			int len = chartXY.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length;
			chartXY.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length = len + npoints ;
			for( int i=0; i<npoints; i++)
			{
				float r = (float) rnd.NextDouble();
				float y = (float) ( 10 * r * Math.Sin( 0.1*i ) * Math.Sin( 0.6*rnd.NextDouble()*i));
				chartXY.ChartGroups.Group0.ChartData.SeriesList[0].PointData[len+i] = new PointF( shift+len+i, y);
			}
			count++;
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch( toolBar1.Buttons.IndexOf( e.Button))
			{
				case 0:
					printDialog.ShowDialog();
					break;
				case 1:
					printPreviewDialog.ShowDialog();
					break;
				case 2:
					pageSetupDialog.ShowDialog();
					break;
				case 4:
					timer1.Enabled = !timer1.Enabled;
					break;
				default:
					break;
			}
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFilePageSetup_Click(object sender, System.EventArgs e)
		{
			pageSetupDialog.ShowDialog();		
		}

		private void menuFilePrintPreview_Click(object sender, System.EventArgs e)
		{
			printPreviewDialog.ShowDialog();
		}

		private void menuFilePrint_Click(object sender, System.EventArgs e)
		{
			printDialog.ShowDialog();
		}

		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			positionCharts();
		}

		private void menuFileStart_Click(object sender, System.EventArgs e)
		{
			if( !timer1.Enabled)
			{
				timer1.Enabled = true;
				tbbStart.Pushed = true;
			}
		}

		private void menuFileStop_Click(object sender, System.EventArgs e)
		{
			if( timer1.Enabled)
			{
				timer1.Enabled = false;
				tbbStart.Pushed = false;
			}
		}
	}
}
