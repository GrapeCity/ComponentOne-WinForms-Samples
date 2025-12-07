using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace FExplorer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.CheckBox cbAA;
		private System.Windows.Forms.StatusBar statusBar1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnAnimate;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem miFile;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miHelp;
		private System.Windows.Forms.MenuItem miAbout;
		private System.ComponentModel.IContainer components;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnAnimate = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.cbAA = new System.Windows.Forms.CheckBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.miHelp = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							this.tabPage1,
																																							this.tabPage2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(200, 453);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.btnAnimate,
																																					 this.listView1,
																																					 this.treeView1});
			this.tabPage1.DockPadding.Bottom = 34;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(192, 427);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Functions";
			// 
			// btnAnimate
			// 
			this.btnAnimate.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.btnAnimate.Location = new System.Drawing.Point(46, 400);
			this.btnAnimate.Name = "btnAnimate";
			this.btnAnimate.Size = new System.Drawing.Size(101, 23);
			this.btnAnimate.TabIndex = 2;
			this.btnAnimate.Text = "Start Animation";
			this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 168);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(192, 225);
			this.listView1.TabIndex = 1;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.treeView1.HideSelection = false;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(192, 168);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.cbAA});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(192, 427);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Plot Options";
			// 
			// cbAA
			// 
			this.cbAA.Location = new System.Drawing.Point(8, 8);
			this.cbAA.Name = "cbAA";
			this.cbAA.Size = new System.Drawing.Size(120, 24);
			this.cbAA.TabIndex = 0;
			this.cbAA.Text = "Use anti-aliasing";
			this.cbAA.CheckedChanged += new System.EventHandler(this.cbAA_CheckedChanged);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(200, 431);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(432, 22);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "Ready";
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Interaction.Enabled = true;
			this.c1Chart1.Location = new System.Drawing.Point(200, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\"><StyleData>Border=Solid,ControlText,1;BackColor=Wh" +
				"iteSmoke;</StyleData></NamedStyle><NamedStyle Name=\"Legend\" ParentName=\"Legend.d" +
				"efault\"><StyleData /></NamedStyle><NamedStyle Name=\"Footer\" ParentName=\"Control\"" +
				"><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=\"Area\"" +
				" ParentName=\"Area.default\"><StyleData /></NamedStyle><NamedStyle Name=\"Control\" " +
				"ParentName=\"Control.default\"><StyleData>Border=Solid,Black,1;</StyleData></Named" +
				"Style><NamedStyle Name=\"AxisX\" ParentName=\"Area\"><StyleData>Rotation=Rotate0;Bor" +
				"der=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;Align" +
				"Vert=Bottom;</StyleData></NamedStyle><NamedStyle Name=\"AxisY\" ParentName=\"Area\">" +
				"<StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor" +
				"=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle " +
				"Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\"><StyleData /></N" +
				"amedStyle><NamedStyle Name=\"Legend.default\" ParentName=\"Control\"><StyleData>Bord" +
				"er=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle Na" +
				"me=\"LabelStyleDefault.default\" ParentName=\"Control\"><StyleData>Border=None,Black" +
				",1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle Name=\"Header\" Pare" +
				"ntName=\"Control\"><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedS" +
				"tyle Name=\"Control.default\" ParentName=\"\"><StyleData>ForeColor=ControlText;Borde" +
				"r=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle Name=\"Axis" +
				"Y2\" ParentName=\"Area\"><StyleData>Rotation=Rotate90;Border=None,Transparent,1;Ali" +
				"gnHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><Name" +
				"dStyle Name=\"Area.default\" ParentName=\"Control\"><StyleData>Border=None,Black,1;A" +
				"lignVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><" +
				"ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><Data" +
				"SeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><Symbo" +
				"lStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4" +
				";5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Dou" +
				"ble;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer" +
				"><DataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"Cornflo" +
				"werBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;1" +
				"2;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</D" +
				"ataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesS" +
				"erializer><LineStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tr" +
				"i\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y1" +
				" /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" +
				"lds>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineSt" +
				"yle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLa" +
				"bel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><Y2 /><Y3 /" +
				"><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Data" +
				"Fields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><Na" +
				"me>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherO" +
				"ffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFa" +
				"lling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</Hi" +
				"LoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Pol" +
				"ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" +
				"d=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></C" +
				"hartGroup><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Grou" +
				"p2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0" +
				",Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=T" +
				"rue,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData>" +
				"<Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degr" +
				"ees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False" +
				",Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGro" +
				"up></ChartGroupsCollection><Header Compass=\"North\" Visible=\"False\"><Text /></Hea" +
				"der><Footer Compass=\"South\" Visible=\"False\"><Text /></Footer><Legend Compass=\"Ea" +
				"st\" Visible=\"False\"><Text /></Legend><ChartArea><Margin Top=\"0\" Left=\"0\" Bottom=" +
				"\"0\" Right=\"0\" /></ChartArea><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\"" +
				" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"" +
				"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><A" +
				"xis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"T" +
				"rue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor " +
				"AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" " +
				"Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onT" +
				"op=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" Patt" +
				"ern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></Ax" +
				"is></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(432, 431);
			this.c1Chart1.TabIndex = 3;
			this.c1Chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Chart1_Paint);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.miFile,
																																							this.miHelp});
			// 
			// miFile
			// 
			this.miFile.Index = 0;
			this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miExit});
			this.miFile.Text = "&File";
			// 
			// miExit
			// 
			this.miExit.Index = 0;
			this.miExit.Text = "E&xit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// miHelp
			// 
			this.miHelp.Index = 1;
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
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.statusBar1,
																																	this.tabControl1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Function Explorer Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
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

		// colors
		Color[] clrs = new Color[] { Color.Red, Color.Green, Color.Blue,
																 Color.DarkRed, Color.DarkGreen, Color.DarkBlue};

		// trigonometric
		string[] trigNames = new string[] { "sin(x)", "cos(x)", "tg(x)", "ctg(x)", "sec(x)", "cosec(x)"};
		string[] trigCodes = new string[] { "Math.Sin(x)", "Math.Cos(x)", "Math.Tan(x)", "1/Math.Tan(x)", "1/Math.Sin(x)", "1/Math.Cos(x)"};

		// hyperbolic
		string[] hbNames = new string[] { "sinh(x)", "cosh(x)", "tgh(x)", "ctgh(x)"};
		string[] hbCodes = new string[] { "Math.Sinh(x)", "Math.Cosh(x)", "Math.Tanh(x)", "1/Math.Tanh(x)"};

		// rational
		string[] ratNames = new string[] { "1/x", "1/(x*x-3)", "1/(x+2)+1/(x-2)"};
		string[] ratCodes = new string[] { "1/x", "1/(x*x-3)", "1/(x+2)+1/(x-2)"};

		// exponent
		string[] expNames = new string[] { "sin(x)*exp(0.01*x*x)", "exp(0.01*x*x)", "-exp(0.01*x*x)"};
		string[] expCodes = new string[] { "Math.Sin(5*x)*Math.Exp(0.01*x*x)", "Math.Exp(0.01*x*x)", "-Math.Exp(0.01*x*x)"};

		// lissajour
		string[] lsNames = new string[] { "x = sin(t) y= cos(t)",
																			"x = sin(2t) y= cos(t)",
																			"x = sin(t) y= cos(3t)",
																			"x = sin(3t) y= cos(4t)"};
		string[] lsCodesX = new string[] { "Math.Sin(t)", "Math.Sin(2*t)", "Math.Sin(t)", "Math.Sin(3*t)"};
		string[] lsCodesY = new string[] { "Math.Cos(t)", "Math.Cos(t)", "Math.Cos(3*t)", "Math.Cos(4*t)"};

		// spiral
		string[] spNames = new string[] { "x = t*sin(t) y= cos(t)",
																			"x = sin(t) y= t*cos(t)",
																			"x = t*sin(t) y= t*cos(t)"};
		string[] spCodesX = new string[] { "t*Math.Sin(t)", "Math.Sin(t)", "t*Math.Sin(t)"};
		string[] spCodesY = new string[] { "Math.Cos(t)", "t*Math.Cos(t)", "t*Math.Cos(t)"};

		// roses
		string[] rsNames = new string[] { "x=sin(2*t)*sin(t) y=sin(2*t)*cos(t)",
																			"x=sin(5*t/3)*sin(t) y=sin(5*t/3)*cos(t)",
																			"x=sin(t/2)*sin(t) y=sin(t/2)*cos(t)"};
		string[] rsCodesX = new string[] { "Math.Sin(2*t)*Math.Sin(t)", "Math.Sin(5*t/3)*Math.Sin(t)", "Math.Sin(t/2)*Math.Sin(t)"};
		string[] rsCodesY = new string[] { "Math.Sin(2*t)*Math.Cos(t)", "Math.Sin(5*t/3)*Math.Cos(t)", "Math.Sin(t/2)*Math.Cos(t)"};

		// wheel
		string[] whNames = new string[] { "x=t-1.25*sin(t) y=1-1.25*cos(t)-2",
																			"x=t-0.75*sin(t) y=1-0.75*cos(t)",
																			"x=t-sin(t) y=1-cos(t)+2"};
		string[] whCodesX = new string[] { "t-1.25*Math.Sin(t)", "t-0.75*Math.Sin(t)", "t-Math.Sin(t)"};
		string[] whCodesY = new string[] { "1-1.25*Math.Cos(t)-2", "1-0.75*Math.Cos(t)", "1-Math.Cos(t)+2"};

		// create node and YFunction group
		TreeNode AddGroup( TreeNode node, string name, string[] fnames, string[] fcodes,
			double xmin, double xmax, double ymin, double ymax, int npoints)
		{
			TreeNode gn = new TreeNode( name);

			FunctionBase[] fs = new FunctionBase[fnames.Length];//!!VBSubst Dim fs(fnames.Length-1) As FunctionBase

			for( int i=0; i<fs.Length; i++)
			{
				YFunction f = new YFunction();
				f.Label = fnames[i];
				f.LineStyle.Color = clrs[i];
				f.LineStyle.Thickness = 2;
				if ( npoints>0)
					f.PlotNumPoints = npoints;

				fs[i] = f;
			}

			FunctionsGroup fg = new FunctionsGroup( fs, fcodes, xmin, xmax, ymin, ymax);

			gn.Tag = fg;
			node.Nodes.Add( gn);

			return gn;
		}

		// create node and ParametricFunction group
		TreeNode AddGroup( TreeNode node, string name, string[] fnames, string[] fcodesx, string[] fcodesy,
			double tmin, double tmax)
		{
			TreeNode gn = new TreeNode( name);

			FunctionBase[] fs = new FunctionBase[fnames.Length];//!!VBSubst Dim fs(fnames.Length-1) As FunctionBase

			for( int i=0; i<fs.Length; i++)
			{
				ParametricFunction f = new ParametricFunction();
				f.Label = fnames[i];
				f.LineStyle.Color = clrs[i];
				f.LineStyle.Thickness = 2;
				f.MinT = tmin;
				f.MaxT = tmax;
				fs[i] = f;
			}

			FunctionsGroup fg = new FunctionsGroup( fs, fcodesx, fcodesy);

			gn.Tag = fg;
			node.Nodes.Add( gn);

			return gn;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// show grid
      c1Chart1.ChartArea.AxisX.GridMajor.Visible = true;
			c1Chart1.ChartArea.AxisY.GridMajor.Visible = true;

			// clear default series data
			c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();

			// YFunction's
			TreeNode tn = new TreeNode("Explicit y=f(x)");

			treeView1.Nodes.Add( tn);

			TreeNode sn = AddGroup( tn, "Trigonometric", trigNames, trigCodes, -10, 10, -5, 5, 0);
			AddGroup( tn, "Hyperbolic", hbNames, hbCodes, -5, 5, -5, 5, 0);
			AddGroup( tn, "Rational", ratNames, ratCodes, -4, 4, -4, 4, 0);
			AddGroup( tn, "Exponent", expNames, expCodes, -20, 20, -55, 55, 400);

			// ParametricFunction's
			tn = new TreeNode("Parametric x=f1(t) y=f2(t)");
			treeView1.Nodes.Add( tn);
			
			AddGroup( tn, "Lissajous", lsNames, lsCodesX, lsCodesY, 0, 2*Math.PI);
			AddGroup( tn, "Spiral", spNames, spCodesX, spCodesY, 0, 20);
			AddGroup( tn, "Rose", rsNames, rsCodesX, rsCodesY, 0, 4*Math.PI);
			AddGroup( tn, "Wheel", whNames, whCodesX, whCodesY, 0, 6*Math.PI);


			// expand all and select sn
			treeView1.ExpandAll();
			treeView1.SelectedNode = sn;
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			AnimateStop();
			btnAnimate.Enabled = false;

			TreeNode sn = treeView1.SelectedNode;

			// if group of functions are associated with this node
			if( sn!=null && sn.Tag !=null)
			{
				FunctionsCollection fc = c1Chart1.ChartGroups[0].ChartData.FunctionsList;

				// clear previous functions and listview
				fc.Clear();
				listView1.Items.Clear();

				FunctionsGroup fg = (FunctionsGroup)sn.Tag;
				fg.Load(statusBar1);

				// fill listview
				for( int i=0; i<fg.FunctionList.Length; i++)
				{
					FunctionBase f = fg.FunctionList[i];
					ListViewItem lvi = new ListViewItem(f.Label);
					lvi.Checked = true;
					lvi.ForeColor = f.LineStyle.Color;
					lvi.Tag = f;
					listView1.Items.Add( lvi);
					fc.Add( f);
				}

				fg.ApplyOptions( c1Chart1);
			}
		}

		private void listView1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			AnimateStop();
			// hide or show corresponding function

			ListViewItem lvi = listView1.Items[ e.Index];

			if( lvi.Tag!=null && lvi.Tag is FunctionBase)
			{
				FunctionBase f = (FunctionBase)lvi.Tag;

				f.Visible = (e.NewValue == CheckState.Checked);
			}
		}

		private void cbAA_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.UseAntiAliasedGraphics = cbAA.Checked;
		}

		FunctionBase f_anim = null;
		double par_anim = 0;
		double par_anim_step = 0;
		double par_anim_max = 0;
		double par_anim_min = 0;

		private void AnimateStart()
		{
			if( listView1.SelectedItems[0].Tag is FunctionBase)
			{
				f_anim = (FunctionBase)listView1.SelectedItems[0].Tag;

				if(	f_anim is YFunction)
				{
					YFunction yf = (YFunction)f_anim;
					
					par_anim_max = yf.MaxX;
					par_anim_min = yf.MinX;
				} 
				else if(f_anim is ParametricFunction)
				{
					ParametricFunction pf = (ParametricFunction)f_anim;
					
					par_anim_max = pf.MaxT;
					par_anim_min = pf.MinT;
				}

				par_anim = par_anim_min;
				par_anim_step = (par_anim_max - par_anim_min) / 200;

				timer1.Start();
				RedrawChart();

				btnAnimate.Text = "Stop animation";
			}
		}

		private void AnimateStop()
		{
			if(f_anim!=null)
			{
				f_anim = null;
				timer1.Stop();
				RedrawChart();
				curPosition = Point.Empty;
				statusBar1.Text = "Ready";
				btnAnimate.Text = "Start animation";
			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			par_anim += par_anim_step;

			if( par_anim > par_anim_max)
			{
				par_anim = par_anim_max;
				par_anim_step = -par_anim_step;
			}
			else if( par_anim < par_anim_min)
			{
				par_anim = par_anim_min;
				par_anim_step = -par_anim_step;
			}

			if( f_anim!=null)
			{
				double xd = 0, yd = 0;
				int x = 0, y = 0;

				if(	f_anim is YFunction)
				{
					YFunction yf = (YFunction)f_anim;

					xd = par_anim;
					yd = yf.GetY( xd);

					statusBar1.Text = string.Format(" x={0:g4}", xd);
				} 
				else if(f_anim is ParametricFunction)
				{
					ParametricFunction pf = (ParametricFunction)f_anim;

					xd = pf.GetX( par_anim);
					yd = pf.GetY( par_anim);

					statusBar1.Text = string.Format(" t={0:g4}", par_anim);
				}

				Axis xa = c1Chart1.ChartArea.AxisX;
				Axis ya = c1Chart1.ChartArea.AxisY;

				if( xd>= xa.Min && xd<= xa.Max && yd>= ya.Min && yd<= ya.Max &&
					c1Chart1.ChartGroups[0].DataCoordToCoord( xd, yd, ref x, ref y))
				{
					RedrawChart();
					curPosition.X = x; curPosition.Y = y;
					RedrawChart();
				}
				else
				{
					RedrawChart();
					curPosition = Point.Empty;
				}
			}
		}

		private void RedrawChart()
		{
			if( !curPosition.IsEmpty)
			{
				Point pt = c1Chart1.PointToScreen( curPosition);
				ControlPaint.DrawReversibleLine( new Point( pt.X-10, pt.Y), new Point( pt.X+10, pt.Y), c1Chart1.ChartArea.PlotArea.BackColor);
				ControlPaint.DrawReversibleLine( new Point( pt.X, pt.Y-10), new Point( pt.X, pt.Y+10), c1Chart1.ChartArea.PlotArea.BackColor);
			}
		}

		Point curPosition = Point.Empty;

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			AnimateStop();

			if( listView1.SelectedItems!=null && listView1.SelectedItems.Count==1)
				btnAnimate.Enabled = true;
			else
				btnAnimate.Enabled = false;
		}

		private void btnAnimate_Click(object sender, System.EventArgs e)
		{
			if( f_anim == null)
				AnimateStart();
			else
				AnimateStop();
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void c1Chart1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			curPosition = Point.Empty;
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// store for function and additional options
	class FunctionsGroup
	{
		private double _xmin, _xmax, _ymin, _ymax;
		private FunctionBase[] _flist;

		private bool _limits = false;

		private bool _loaded = false;

		string[] _xcodes, _ycodes;

		public FunctionsGroup( FunctionBase[] flist, string[] ycodes, double xmin, double xmax, double ymin, double ymax)
		{
			_flist = flist;
			_xmin = xmin;
			_xmax = xmax;
			_ymin = ymin;
			_ymax = ymax;
			_limits = true;
			_ycodes = ycodes;
		}

		public FunctionsGroup( FunctionBase[] flist, string[] xcodes, string[] ycodes)
		{
			_flist = flist;
			_xcodes = xcodes;
			_ycodes = ycodes;
		}

		public void ApplyOptions( C1Chart chart)
		{
			if( _limits)
			{
				chart.ChartArea.AxisX.SetMinMax( _xmin, _xmax);
				chart.ChartArea.AxisY.SetMinMax( _ymin, _ymax);
			}
			else
			{
				chart.ChartArea.AxisX.AutoMax = true;
				chart.ChartArea.AxisX.AutoMin = true;
				chart.ChartArea.AxisY.AutoMax = true;
				chart.ChartArea.AxisY.AutoMin = true;
			}
		}

		public void Load( StatusBar sb)
		{
			if( !_loaded)
			{
				string txt = sb.Text;
				sb.Text = "Please wait. Loading functions...";

				// setup function code
				// can be long operation because code will be compiled in memory
				for( int i=0; i<_flist.Length; i++)
				{
					if( _flist[i] is YFunction)
					{
						YFunction yf = (YFunction)_flist[i];
						yf.CodeText = _ycodes[i];
					}
					else if( _flist[i] is ParametricFunction)
					{
						ParametricFunction pf = (ParametricFunction)_flist[i];
						pf.CodeTextX = _xcodes[i];
						pf.CodeTextY = _ycodes[i];
					}
				}

				sb.Text = txt;

				_loaded = true;
			}
		}

		public FunctionBase[] FunctionList
		{
			get{ return _flist;}
		}
	}
}
