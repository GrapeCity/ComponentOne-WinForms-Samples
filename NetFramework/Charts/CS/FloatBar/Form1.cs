using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Float
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.CheckBox chkESeries3;
		private System.Windows.Forms.CheckBox chkESeries1;
		private System.Windows.Forms.CheckBox chkESeries2;
		private System.Windows.Forms.CheckBox chkESeries0;
		private System.Windows.Forms.CheckBox chkHSeries3;
		private System.Windows.Forms.CheckBox chkHSeries1;
		private System.Windows.Forms.CheckBox chkHSeries2;
		private System.Windows.Forms.CheckBox chkHSeries0;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblElevation;
		private System.Windows.Forms.Label lblRotation;
		private System.Windows.Forms.NumericUpDown udRotation;
		private System.Windows.Forms.Label lblDepth;
		private System.Windows.Forms.NumericUpDown udElevation;
		private System.Windows.Forms.NumericUpDown udDepth;
		private System.Windows.Forms.CheckBox chk3DOn;
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

		void setupChart()
		{
			// setup chart style
			c1Chart1.Style.BackColor = Color.LightBlue;
			c1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet;
			c1Chart1.Style.Border.Thickness = 1;

			// setup header
			c1Chart1.Header.Style.BackColor = Color.LightYellow;
			c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			c1Chart1.Header.Style.Border.Thickness = 1;
			c1Chart1.Header.Style.Font = new Font( "Arial", 10);
			c1Chart1.Header.Text = "Use the Check Boxes to the Left to Hide or Exclude a Series";

			// setup chart area
			c1Chart1.ChartArea.Style.BackColor = Color.PaleGreen;
			c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			c1Chart1.ChartArea.Style.Border.Thickness = 4;

			// setup legend
			//c1Chart1.ChartArea.Style.BackColor = Color.PaleGreen;
			c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Groove;
			c1Chart1.Legend.Style.Border.Thickness = 2;
			c1Chart1.Legend.Style.Border.Color = Color.LightBlue;
			c1Chart1.Legend.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center;
			c1Chart1.Legend.Style.Font = new Font( "Tahoma", 10);
			c1Chart1.Legend.Text = "Series";
			c1Chart1.Legend.Visible = true;

			// setup axes
			c1Chart1.ChartArea.AxisY.Min = 0;
			c1Chart1.ChartArea.AxisY.Max = 100;

			c1Chart1.ChartArea.AxisX.GridMajor.Color = Color.Black;
			c1Chart1.ChartArea.AxisY.GridMajor.Color = Color.Black;

			c1Chart1.ChartArea.AxisX.GridMajor.Visible = true;
			c1Chart1.ChartArea.AxisY.GridMajor.Visible = true;

			// setup chart type
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;
			c1Chart1.ChartGroups[0].Stacked  = true;

			// setup series appearence
			c1Chart1.ChartGroups[0].ChartData[0].LineStyle.Color = Color.Red;
			c1Chart1.ChartGroups[0].ChartData[1].LineStyle.Color = Color.Tan;
			c1Chart1.ChartGroups[0].ChartData[2].LineStyle.Color = Color.Green;
			c1Chart1.ChartGroups[0].ChartData[3].LineStyle.Color = Color.MediumTurquoise;

			// setup default 3D view angles
			c1Chart1.ChartArea.PlotArea.View3D.Elevation = 45;
			c1Chart1.ChartArea.PlotArea.View3D.Rotation = 45;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblDepth = new System.Windows.Forms.Label();
			this.udDepth = new System.Windows.Forms.NumericUpDown();
			this.lblRotation = new System.Windows.Forms.Label();
			this.udRotation = new System.Windows.Forms.NumericUpDown();
			this.lblElevation = new System.Windows.Forms.Label();
			this.udElevation = new System.Windows.Forms.NumericUpDown();
			this.chk3DOn = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkESeries3 = new System.Windows.Forms.CheckBox();
			this.chkESeries1 = new System.Windows.Forms.CheckBox();
			this.chkESeries2 = new System.Windows.Forms.CheckBox();
			this.chkESeries0 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkHSeries3 = new System.Windows.Forms.CheckBox();
			this.chkHSeries1 = new System.Windows.Forms.CheckBox();
			this.chkHSeries2 = new System.Windows.Forms.CheckBox();
			this.chkHSeries0 = new System.Windows.Forms.CheckBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.panel3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udRotation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udElevation)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.c1Chart1,
																				 this.panel3});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(592, 403);
			this.panel2.TabIndex = 4;
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.Color.LightBlue;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(104, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Control,1;<" +
				"/StyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.defaul" +
				"t</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentNa" +
				"me>Control</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle" +
				"><NamedStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData />" +
				"</NamedStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</Parent" +
				"Name><StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</P" +
				"arentName><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;Bac" +
				"kColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><Named" +
				"Style><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate2" +
				"70;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;Align" +
				"Vert=Center;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><" +
				"ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><Name" +
				"dStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData>Bor" +
				"der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><" +
				"Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleData>" +
				"Border=None,Control,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" +
				"><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Contr" +
				"ol,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" +
				"e /><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNam" +
				"e><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor" +
				"=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.de" +
				"fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" +
				"gnVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Ch" +
				"artGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSe" +
				"riesCollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenr" +
				"od\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>seri" +
				"es 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTy" +
				"pes>Single;Single;Single;Single;Single</DataTypes></DataSeriesSerializer><DataSe" +
				"riesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGray\" Pattern=\"Solid\" /><Symb" +
				"olStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel>" +
				"<X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;S" +
				"ingle;Single;Single</DataTypes></DataSeriesSerializer><DataSeriesSerializer><Lin" +
				"eStyle Thickness=\"1\" Color=\"DarkGreen\" Pattern=\"Solid\" /><SymbolStyle Color=\"Cor" +
				"nsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16" +
				";17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Single;Single;Single</Da" +
				"taTypes></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Co" +
				"lor=\"DarkKhaki\" Pattern=\"Solid\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /" +
				"><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><" +
				"Y2 /><Y3 /><DataTypes>Single;Single;Single;Single;Single</DataTypes></DataSeries" +
				"Serializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>F" +
				"alse</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>" +
				"ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent" +
				"=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMet" +
				"hod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnn" +
				"otations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Sh" +
				"owOutline>True</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=\"3.402" +
				"8234663852886E+38\" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlo" +
				"t</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=" +
				"50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" +
				"e=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,Mi" +
				"nimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><" +
				"Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline></" +
				"ChartGroup></ChartGroupsCollection><Header Compass=\"North\"><Text /></Header><Foo" +
				"ter Compass=\"South\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Tex" +
				"t /></Legend><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0" +
				".5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" C" +
				"ompass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGra" +
				"y\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" " +
				"Pattern=\"Dash\" /></Axis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoM" +
				"ajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"W" +
				"est\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern" +
				"=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"D" +
				"ash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\"" +
				" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text " +
				"/><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><" +
				"GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Ax" +
				"is></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(488, 403);
			this.c1Chart1.TabIndex = 6;
			// 
			// panel3
			// 
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.groupBox3,
																				 this.groupBox2,
																				 this.groupBox1});
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(104, 403);
			this.panel3.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.lblDepth,
																					this.udDepth,
																					this.lblRotation,
																					this.udRotation,
																					this.lblElevation,
																					this.udElevation,
																					this.chk3DOn});
			this.groupBox3.Location = new System.Drawing.Point(0, 256);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(104, 144);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "3D View";
			// 
			// lblDepth
			// 
			this.lblDepth.Location = new System.Drawing.Point(8, 40);
			this.lblDepth.Name = "lblDepth";
			this.lblDepth.Size = new System.Drawing.Size(40, 16);
			this.lblDepth.TabIndex = 6;
			this.lblDepth.Text = "Depth";
			// 
			// udDepth
			// 
			this.udDepth.Enabled = false;
			this.udDepth.Location = new System.Drawing.Point(48, 40);
			this.udDepth.Name = "udDepth";
			this.udDepth.Size = new System.Drawing.Size(40, 20);
			this.udDepth.TabIndex = 5;
			this.udDepth.ValueChanged += new System.EventHandler(this.udDepth_ValueChanged);
			// 
			// lblRotation
			// 
			this.lblRotation.Location = new System.Drawing.Point(8, 104);
			this.lblRotation.Name = "lblRotation";
			this.lblRotation.Size = new System.Drawing.Size(32, 16);
			this.lblRotation.TabIndex = 4;
			this.lblRotation.Text = "Rot.";
			// 
			// udRotation
			// 
			this.udRotation.Enabled = false;
			this.udRotation.Location = new System.Drawing.Point(48, 104);
			this.udRotation.Name = "udRotation";
			this.udRotation.Size = new System.Drawing.Size(40, 20);
			this.udRotation.TabIndex = 3;
			this.udRotation.ValueChanged += new System.EventHandler(this.udRotation_ValueChanged);
			// 
			// lblElevation
			// 
			this.lblElevation.Location = new System.Drawing.Point(8, 72);
			this.lblElevation.Name = "lblElevation";
			this.lblElevation.Size = new System.Drawing.Size(40, 16);
			this.lblElevation.TabIndex = 2;
			this.lblElevation.Text = "Elev.";
			// 
			// udElevation
			// 
			this.udElevation.Enabled = false;
			this.udElevation.Location = new System.Drawing.Point(48, 72);
			this.udElevation.Name = "udElevation";
			this.udElevation.Size = new System.Drawing.Size(40, 20);
			this.udElevation.TabIndex = 1;
			this.udElevation.ValueChanged += new System.EventHandler(this.udElevation_ValueChanged);
			// 
			// chk3DOn
			// 
			this.chk3DOn.Location = new System.Drawing.Point(16, 16);
			this.chk3DOn.Name = "chk3DOn";
			this.chk3DOn.Size = new System.Drawing.Size(40, 16);
			this.chk3DOn.TabIndex = 0;
			this.chk3DOn.Text = "On";
			this.chk3DOn.CheckedChanged += new System.EventHandler(this.chk3DOn_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.chkESeries3,
																					this.chkESeries1,
																					this.chkESeries2,
																					this.chkESeries0});
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(104, 128);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Exclude";
			// 
			// chkESeries3
			// 
			this.chkESeries3.Location = new System.Drawing.Point(16, 96);
			this.chkESeries3.Name = "chkESeries3";
			this.chkESeries3.Size = new System.Drawing.Size(80, 24);
			this.chkESeries3.TabIndex = 7;
			this.chkESeries3.Text = "Series 3";
			this.chkESeries3.CheckedChanged += new System.EventHandler(this.chkESeries3_CheckedChanged);
			// 
			// chkESeries1
			// 
			this.chkESeries1.Location = new System.Drawing.Point(16, 48);
			this.chkESeries1.Name = "chkESeries1";
			this.chkESeries1.Size = new System.Drawing.Size(80, 24);
			this.chkESeries1.TabIndex = 6;
			this.chkESeries1.Text = "Series 1";
			this.chkESeries1.CheckedChanged += new System.EventHandler(this.chkESeries1_CheckedChanged);
			// 
			// chkESeries2
			// 
			this.chkESeries2.Location = new System.Drawing.Point(16, 72);
			this.chkESeries2.Name = "chkESeries2";
			this.chkESeries2.Size = new System.Drawing.Size(80, 24);
			this.chkESeries2.TabIndex = 5;
			this.chkESeries2.Text = "Series 2";
			this.chkESeries2.CheckedChanged += new System.EventHandler(this.chkESeries2_CheckedChanged);
			// 
			// chkESeries0
			// 
			this.chkESeries0.Location = new System.Drawing.Point(16, 24);
			this.chkESeries0.Name = "chkESeries0";
			this.chkESeries0.Size = new System.Drawing.Size(80, 24);
			this.chkESeries0.TabIndex = 4;
			this.chkESeries0.Text = "Series 0";
			this.chkESeries0.CheckedChanged += new System.EventHandler(this.chkESeries0_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.chkHSeries3,
																					this.chkHSeries1,
																					this.chkHSeries2,
																					this.chkHSeries0});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(104, 128);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hide";
			// 
			// chkHSeries3
			// 
			this.chkHSeries3.Location = new System.Drawing.Point(16, 96);
			this.chkHSeries3.Name = "chkHSeries3";
			this.chkHSeries3.Size = new System.Drawing.Size(80, 24);
			this.chkHSeries3.TabIndex = 7;
			this.chkHSeries3.Text = "Series 3";
			this.chkHSeries3.CheckedChanged += new System.EventHandler(this.chkHSeries3_CheckedChanged);
			// 
			// chkHSeries1
			// 
			this.chkHSeries1.Location = new System.Drawing.Point(16, 48);
			this.chkHSeries1.Name = "chkHSeries1";
			this.chkHSeries1.Size = new System.Drawing.Size(80, 24);
			this.chkHSeries1.TabIndex = 6;
			this.chkHSeries1.Text = "Series 1";
			this.chkHSeries1.CheckedChanged += new System.EventHandler(this.chkHSeries1_CheckedChanged);
			// 
			// chkHSeries2
			// 
			this.chkHSeries2.Location = new System.Drawing.Point(16, 72);
			this.chkHSeries2.Name = "chkHSeries2";
			this.chkHSeries2.Size = new System.Drawing.Size(80, 24);
			this.chkHSeries2.TabIndex = 5;
			this.chkHSeries2.Text = "Series 2";
			this.chkHSeries2.CheckedChanged += new System.EventHandler(this.chkHSeries2_CheckedChanged);
			// 
			// chkHSeries0
			// 
			this.chkHSeries0.Location = new System.Drawing.Point(16, 24);
			this.chkHSeries0.Name = "chkHSeries0";
			this.chkHSeries0.Size = new System.Drawing.Size(80, 24);
			this.chkHSeries0.TabIndex = 4;
			this.chkHSeries0.Text = "Series 0";
			this.chkHSeries0.CheckedChanged += new System.EventHandler(this.chkHSeries0_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel2});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Floating Stacked Bars Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udRotation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udElevation)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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
			setupChart();

			udDepth.Minimum = 1;
			udDepth.Value = 20;

			udElevation.Value = 45;
			udElevation.Minimum = -45;
			udElevation.Maximum = 45;

			udRotation.Value = 45;
			udRotation.Minimum = -45;
			udRotation.Maximum = 45;
		}

		private void chkHSeries0_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkHSeries0.Checked)
			{
				if(chkESeries0.Checked) chkESeries0.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[0].Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[0].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkHSeries1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkHSeries1.Checked)
			{
				if(chkESeries1.Checked) chkESeries1.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[1].Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[1].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkHSeries2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkHSeries2.Checked)
			{
				if(chkESeries2.Checked) chkESeries2.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[2].Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[2].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkHSeries3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkHSeries3.Checked)
			{
				if(chkESeries3.Checked) chkESeries3.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[3].Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[3].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkESeries0_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkESeries0.Checked)
			{
				if(chkHSeries0.Checked) chkHSeries0.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[0].Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[0].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkESeries1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkESeries1.Checked)
			{
				if(chkHSeries1.Checked) chkHSeries1.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[1].Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[1].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkESeries2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkESeries2.Checked)
			{
				if(chkHSeries2.Checked) chkHSeries2.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[2].Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[2].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void chkESeries3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkESeries3.Checked)
			{
				if(chkHSeries3.Checked) chkHSeries3.Checked = false;
				c1Chart1.ChartGroups[0].ChartData.SeriesList[3].Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude;
			}
			else
				c1Chart1.ChartGroups[0].ChartData.SeriesList[3].Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void chk3DOn_CheckedChanged(object sender, System.EventArgs e)
		{
			if( chk3DOn.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
				udDepth.Enabled = true;
				udElevation.Enabled = true;
				udRotation.Enabled = true;
			}
			else
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = 0;
				udDepth.Enabled = false;
				udElevation.Enabled = false;
				udRotation.Enabled = false;
			}
		}

		private void udDepth_ValueChanged(object sender, System.EventArgs e)
		{
			if( chk3DOn.Checked)
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
		}

		private void udElevation_ValueChanged(object sender, System.EventArgs e)
		{
			if( chk3DOn.Checked)
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = (int)udElevation.Value;
		}

		private void udRotation_ValueChanged(object sender, System.EventArgs e)
		{
			if( chk3DOn.Checked)
				c1Chart1.ChartArea.PlotArea.View3D.Rotation = (int)udRotation.Value;
		}
	}
}
