using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace Radar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.MenuItem menuOptions;
		private System.Windows.Forms.MenuItem menuOptionsFilled;
		private System.Windows.Forms.MenuItem menuOptionsStacked;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileExit;
		private C1.Win.C1Chart.C1Chart c1Chart1;
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuOptions = new System.Windows.Forms.MenuItem();
			this.menuOptionsFilled = new System.Windows.Forms.MenuItem();
			this.menuOptionsStacked = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuOptions,
																					  this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFileExit});
			this.menuFile.Text = "File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuOptions
			// 
			this.menuOptions.Index = 1;
			this.menuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuOptionsFilled,
																						this.menuOptionsStacked});
			this.menuOptions.Text = "Options";
			// 
			// menuOptionsFilled
			// 
			this.menuOptionsFilled.Index = 0;
			this.menuOptionsFilled.Text = "Filled";
			this.menuOptionsFilled.Click += new System.EventHandler(this.menuOptionsFilled_Click);
			// 
			// menuOptionsStacked
			// 
			this.menuOptionsStacked.Index = 1;
			this.menuOptionsStacked.Text = "Stacked";
			this.menuOptionsStacked.Click += new System.EventHandler(this.menuOptionsStacked_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 2;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuHelpAbout});
			this.menuHelp.Text = "Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// c1Chart1
			// 
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Axes><Axis Max=\"5\" Min=\"1\" UnitM" +
				"ajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMi" +
				"n=\"True\" _onTop=\"0\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Co" +
				"lor=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color" +
				"=\"LightGray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"2" +
				"\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" " +
				"_onTop=\"0\" Compass=\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"Light" +
				"Gray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGra" +
				"y\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor" +
				"=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" " +
				"Compass=\"East\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patte" +
				"rn=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=" +
				"\"Dash\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text /></Header><ChartGr" +
				"oupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</" +
				"Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</Stacked><H" +
				"iLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Sho" +
				"wOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>EncodingMethod=Diamete" +
				"r,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer Defaul" +
				"tSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y>20;22;19;24;25</Y><Li" +
				"neStyle Thickness=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><SymbolStyle Shape" +
				"=\"Box\" Color=\"Coral\" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sing" +
				"le;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSerie" +
				"sSerializer><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=\"1\" C" +
				"olor=\"DarkGray\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue" +
				"\" /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Si" +
				"ngle</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSe" +
				"riesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=\"1\" Color=\"DarkGreen\" P" +
				"attern=\"Solid\" /><SymbolStyle Shape=\"Tri\" Color=\"Cornsilk\" /><SeriesLabel>series" +
				" 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" +
				"X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesSerializer><Y>16;19" +
				";15;22;18</Y><LineStyle Thickness=\"1\" Color=\"DarkKhaki\" Pattern=\"Solid\" /><Symbo" +
				"lStyle Shape=\"Diamond\" Color=\"Crimson\" /><SeriesLabel>series 3</SeriesLabel><Dat" +
				"aTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /" +
				"><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><ShowOutli" +
				"ne>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Pie>OtherOffset" +
				"=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=" +
				"True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>Fal" +
				"se</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Show" +
				"Close=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Encoding" +
				"Method=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name><DataSer" +
				"ializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" +
				"Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><StyleC" +
				"ollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName><StyleDa" +
				"ta>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Legend</Name" +
				"><ParentName>Legend.default</ParentName><StyleData /></NamedStyle><NamedStyle><N" +
				"ame>Footer</Name><ParentName>Control</ParentName><StyleData>Border=None,Control," +
				"1;</StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</Pare" +
				"ntName><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;Back" +
				"Color=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Ar" +
				"ea</Name><ParentName>Area.default</ParentName><StyleData /></NamedStyle><NamedSt" +
				"yle><Name>Control</Name><ParentName>Control.default</ParentName><StyleData /></N" +
				"amedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>" +
				"Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;Al" +
				"ignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentNam" +
				"e>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignHorz" +
				"=Near;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyl" +
				"e><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentNam" +
				"e><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>C" +
				"ontrol</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</Sty" +
				"leData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentNam" +
				"e>Control</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</Parent" +
				"Name><StyleData>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name" +
				">Control.default</Name><ParentName /><StyleData>ForeColor=ControlText;Border=Non" +
				"e,Control,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>Area.de" +
				"fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" +
				"gnVert=Top;</StyleData></NamedStyle></StyleCollection><Footer Compass=\"South\"><T" +
				"ext /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartAre" +
				"a /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(512, 312);
			this.c1Chart1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Radar Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
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

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuOptionsFilled_Click(object sender, System.EventArgs e)
		{
			// turn filling on and off
			MenuItem mi = (MenuItem)sender;
			mi.Checked = !mi.Checked;
			c1Chart1.ChartGroups[0].Radar.Filled = mi.Checked;
		}

		private void menuOptionsStacked_Click(object sender, System.EventArgs e)
		{
			// turn stacking on and off
			MenuItem mi = (MenuItem)sender;
			mi.Checked = !mi.Checked;
			c1Chart1.ChartGroups[0].Stacked = mi.Checked;
			if(mi.Checked)
				c1Chart1.ChartArea.AxisY.Min = 0;
			else
				c1Chart1.ChartArea.AxisY.AutoMin = true;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// center the form.
			this.CenterToParent();

			// setup the chart to fill the form, then set the appearance.
			c1Chart1.Dock = DockStyle.Fill;
			
			// set the chart itself
			c1Chart1.Style.BackColor = Color.LightBlue;
			c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel;
			c1Chart1.Style.Border.Thickness = 4;

			// set up the area
			Area area = c1Chart1.ChartArea;
			area.Style.BackColor = Color.LightYellow;
			area.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel;
			area.Style.Border.Thickness = 4;

			// set up the plot area
			PlotArea parea = area.PlotArea;
			parea.BackColor = Color.AntiqueWhite;

			// set up the header
			Title hdr = c1Chart1.Header;
			hdr.Text = "Radar Chart for System Adaptability";
			hdr.Style.Font = new Font("Arial Black", 14);
			hdr.Style.Border.BorderStyle = BorderStyleEnum.Raised;
			hdr.Style.Border.Color = Color.PaleTurquoise;

			// set up the Legend
			Legend leg = c1Chart1.Legend;
			leg.Style.Font = new Font("Arial Narrow", 9);
			leg.Style.BackColor = Color.AntiqueWhite;
			leg.Style.Border.BorderStyle = BorderStyleEnum.Raised;
			leg.Visible = true;

			// set up axes
			Axis ax = area.AxisX;
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			ax.Font = new Font("Arial", 10);
			ax.Reversed = true;
			ax.Thickness = 0;
			ax.GridMajor.Color = Color.Black;
			ax.GridMajor.Pattern = LinePatternEnum.Dot;
			ax.GridMajor.Visible = true;

			// set the chart type to radar and add the data
			ChartGroup grp = c1Chart1.ChartGroups[0];
			grp.ChartType = Chart2DTypeEnum.Radar;

			// set the axis information.  Not that the compass
			// information is limited by the chart type, so it is
			// necessary to set the chart type first.
			Axis ay = area.AxisY;
			ay.GridMajor.Color = Color.Black;
			ay.GridMajor.Pattern = LinePatternEnum.Dot;
			ay.GridMajor.Visible = true;
			ay.Compass = CompassEnum.North;

			ChartDataSeriesCollection series = grp.ChartData.SeriesList;
			series.Clear();

			// there will be 3 new series, all with the same 7 x values:
			int [] x = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			float [] y0 = new float[] { 2.8f, 3.5f, 3.3f, 2f, 4f, 3f, 2.9f };
			float [] y1 = new float[] { 3.2f, 3.3f, 3.5f, 2.4f, 3.8f, 3.4f, 4.2f };
			float [] y2 = new float[] { 3.6f, 5f, 3.3f, 5f, 3.6f, 4.3f, 3.8f };

			// series 0
			ChartDataSeries s = series.AddNewSeries();
			s.X.CopyDataIn(x);
			s.Y.CopyDataIn(y0);
			s.LineStyle.Color = Color.Orange;
			s.Label = "New Transport";

			// series 1
			s = series.AddNewSeries();
			s.X.CopyDataIn(x);
			s.Y.CopyDataIn(y1);
			s.LineStyle.Color = Color.Blue;
			s.Label = "OTIS";

			// series 2
			s = series.AddNewSeries();
			s.X.CopyDataIn(x);
			s.Y.CopyDataIn(y2);
			s.LineStyle.Color = Color.Green;
			s.Label = "Mobile Walk";

			// add in the value labels for the x axis.
			ValueLabelsCollection vlabs = ax.ValueLabels;
			vlabs.Add(x[0], "Introduce");
			vlabs.Add(x[1], "Response");
			vlabs.Add(x[2], "Travel Time");
			vlabs.Add(x[3], "Get On/Off");
			vlabs.Add(x[4], "Comfort");
			vlabs.Add(x[5], "Social");
			vlabs.Add(x[6], "Operate");
		}
	}
}
