using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Function2D
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnEdit;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListBox lbFList;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PropertyGrid pgSeries;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.RadioButton rbXY;
		private System.Windows.Forms.RadioButton rbPolar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.PropertyGrid pgOptions;

		Engine engine = new Engine();

		public Form1()
		{
			InitializeComponent();
		}

		void addNewFunction( string text, float xmin, float xmax, int npts)
		{
			C1.Win.C1Chart.ChartDataSeries s = new C1.Win.C1Chart.ChartDataSeries();
			c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(s);
			PointF[] pts = engine.Run( text, xmin, xmax, npts);
			s.PointData.CopyDataIn( pts);
			s.Label = text;

			int i = lbFList.Items.Add( text);

			lbFList.SelectedIndex = i;
		}

		void setXYChart()
		{
			Cursor.Current = Cursors.WaitCursor;

			c1Chart1.Header.Text = "X - Y chart";
			c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();
			lbFList.Items.Clear();
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

			float pi = (float) Math.PI;
			addNewFunction( "Math.Sin(x)", -pi, pi, 20);
			addNewFunction( "Math.Cos(x)", -pi, pi, 20);
			addNewFunction( "Math.Sin(5*x)*Math.Exp(-Math.Abs(x))", -pi, pi, 50);
			lbFList.SelectedIndex = 0;

			pgOptions.Visible = false;
			Cursor.Current = Cursors.Default;
		}

		void setPolarChart()
		{
			Cursor.Current = Cursors.WaitCursor;

			c1Chart1.Header.Text = "Polar chart";
			c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();
			lbFList.Items.Clear();
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Polar;

			addNewFunction( "3*Math.Cos(2*x*Math.PI/180)", 0, 360, 50);
			addNewFunction( "1-2*Math.Cos(x*Math.PI/180)", 0, 360, 50);
			addNewFunction( "2*Math.Cos((3*x)*Math.PI/180)", 0, 180, 50);
			lbFList.SelectedIndex = 0;

			pgOptions.Visible = true;
			Cursor.Current = Cursors.Default;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pgOptions = new System.Windows.Forms.PropertyGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbPolar = new System.Windows.Forms.RadioButton();
			this.rbXY = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.pgSeries = new System.Windows.Forms.PropertyGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.lbFList = new System.Windows.Forms.ListBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1Chart1.Location = new System.Drawing.Point(200, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
				"entName>Area</ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Gainsbo" +
				"ro;</StyleData><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend." +
				"default</ParentName><StyleData>Border=Solid,Black,1;</StyleData><Name>Legend</Na" +
				"me></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=No" +
				"ne,Control,1;</StyleData><Name>Footer</Name></NamedStyle><NamedStyle><ParentName" +
				">Area.default</ParentName><StyleData /><Name>Area</Name></NamedStyle><NamedStyle" +
				"><ParentName>Control.default</ParentName><StyleData>Border=Solid,ControlText,1;<" +
				"/StyleData><Name>Control</Name></NamedStyle><NamedStyle><ParentName>Area</Parent" +
				"Name><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColo" +
				"r=Transparent;AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><Named" +
				"Style><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Con" +
				"trol,1;AlignHorz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>A" +
				"xisY</Name></NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</Paren" +
				"tName><StyleData /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><Paren" +
				"tName>Control</ParentName><StyleData>Border=None,Control,1;Wrap=False;AlignVert=" +
				"Top;</StyleData><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>" +
				"Control</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</Sty" +
				"leData><Name>LabelStyleDefault.default</Name></NamedStyle><NamedStyle><ParentNam" +
				"e>Control</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Header<" +
				"/Name></NamedStyle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Bo" +
				"rder=None,Control,1;BackColor=Control;</StyleData><Name>Control.default</Name></" +
				"NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90" +
				";Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;" +
				"</StyleData><Name>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</Par" +
				"entName><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.de" +
				"fault</Name></NamedStyle></StyleCollection><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor" +
				"=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"T" +
				"rue\" _onTop=\"0\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=" +
				"\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"Li" +
				"ghtGray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"19\" UnitMajor=\"1\" U" +
				"nitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _" +
				"onTop=\"0\" Compass=\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightG" +
				"ray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray" +
				"\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=" +
				"\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" C" +
				"ompass=\"East\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patter" +
				"n=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"" +
				"Dash\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text /></Header><Footer C" +
				"ompass=\"South\" Visible=\"False\"><Text /></Footer><Legend Compass=\"East\" Visible=\"" +
				"False\"><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar>Clu" +
				"sterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees" +
				"=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,St" +
				"art=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>XYPlo" +
				"t</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize" +
				"=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWi" +
				"dth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=\"Tru" +
				"e\"><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y>" +
				"<LineStyle Thickness=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><SymbolStyle Sh" +
				"ape=\"Box\" Color=\"Coral\" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;S" +
				"ingle;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializ" +
				"er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" +
				"Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" +
				"e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" +
				"0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" +
				"hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," +
				"MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" +
				"False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" +
				"artGroupsCollection></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(392, 403);
			this.c1Chart1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.pgOptions,
																																				 this.groupBox1,
																																				 this.rbPolar,
																																				 this.rbXY,
																																				 this.label2,
																																				 this.pgSeries,
																																				 this.label1,
																																				 this.btnRemove,
																																				 this.btnEdit,
																																				 this.btnNew,
																																				 this.lbFList});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 403);
			this.panel1.TabIndex = 1;
			// 
			// pgOptions
			// 
			this.pgOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pgOptions.CommandsVisibleIfAvailable = true;
			this.pgOptions.HelpVisible = false;
			this.pgOptions.LargeButtons = false;
			this.pgOptions.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pgOptions.Location = new System.Drawing.Point(8, 336);
			this.pgOptions.Name = "pgOptions";
			this.pgOptions.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pgOptions.Size = new System.Drawing.Size(184, 56);
			this.pgOptions.TabIndex = 11;
			this.pgOptions.Text = "propertyGrid1";
			this.pgOptions.ToolbarVisible = false;
			this.pgOptions.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pgOptions.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 4);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// rbPolar
			// 
			this.rbPolar.Location = new System.Drawing.Point(96, 8);
			this.rbPolar.Name = "rbPolar";
			this.rbPolar.Size = new System.Drawing.Size(72, 16);
			this.rbPolar.TabIndex = 9;
			this.rbPolar.Text = "Polar";
			// 
			// rbXY
			// 
			this.rbXY.Checked = true;
			this.rbXY.Location = new System.Drawing.Point(16, 8);
			this.rbXY.Name = "rbXY";
			this.rbXY.Size = new System.Drawing.Size(72, 16);
			this.rbXY.TabIndex = 8;
			this.rbXY.TabStop = true;
			this.rbXY.Text = "X - Y";
			this.rbXY.CheckedChanged += new System.EventHandler(this.rbXY_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Data Series:";
			// 
			// pgSeries
			// 
			this.pgSeries.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.pgSeries.CommandsVisibleIfAvailable = true;
			this.pgSeries.HelpVisible = false;
			this.pgSeries.LargeButtons = false;
			this.pgSeries.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pgSeries.Location = new System.Drawing.Point(8, 168);
			this.pgSeries.Name = "pgSeries";
			this.pgSeries.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pgSeries.Size = new System.Drawing.Size(184, 160);
			this.pgSeries.TabIndex = 6;
			this.pgSeries.Text = "propertyGrid1";
			this.pgSeries.ToolbarVisible = false;
			this.pgSeries.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pgSeries.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Functions:";
			// 
			// btnRemove
			// 
			this.btnRemove.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnRemove.Image")));
			this.btnRemove.Location = new System.Drawing.Point(168, 120);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(24, 23);
			this.btnRemove.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnRemove, "Remove function");
			this.btnRemove.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(168, 84);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(24, 23);
			this.btnEdit.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnEdit, "Edit function");
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnNew
			// 
			this.btnNew.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnNew.Image")));
			this.btnNew.Location = new System.Drawing.Point(168, 48);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(24, 23);
			this.btnNew.TabIndex = 1;
			this.toolTip1.SetToolTip(this.btnNew, "New function");
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// lbFList
			// 
			this.lbFList.Location = new System.Drawing.Point(8, 48);
			this.lbFList.Name = "lbFList";
			this.lbFList.Size = new System.Drawing.Size(152, 95);
			this.lbFList.TabIndex = 0;
			this.lbFList.SelectedIndexChanged += new System.EventHandler(this.lbFList_SelectedIndexChanged);
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
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.panel1,
																																	this.c1Chart1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Function Plotting Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.panel1.ResumeLayout(false);
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

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			FuncForm ff = new FuncForm( engine);
			if( ff.ShowDialog(this) == DialogResult.OK)
				addNewFunction( ff.Code, ff.MinX, ff.MaxX, ff.NPts);
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			int index = lbFList.SelectedIndex;
			if( index>=0)
			{
				C1.Win.C1Chart.ChartDataSeries s = c1Chart1.ChartGroups.Group0.ChartData.SeriesList[index];
				FuncForm ff = new FuncForm( engine);
				ff.Code = lbFList.SelectedItem.ToString();
				ff.MinX = (float)s.MinX;
				ff.MaxX = (float)s.MaxX;
				ff.NPts = s.Length;
				if( ff.ShowDialog(this) == DialogResult.OK)
				{
					PointF[] pts = engine.Run( ff.Code, ff.MinX, ff.MaxX, ff.NPts);
					s.PointData.CopyDataIn( pts);
					s.Label = ff.Code;

					lbFList.Items[ index] = ff.Code;
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int index = lbFList.SelectedIndex;
			if( index>=0)
			{
				if( MessageBox.Show( this, "Delete function?", "Confirmation", MessageBoxButtons.YesNo,
					MessageBoxIcon.Exclamation)==DialogResult.Yes)
				{
					c1Chart1.ChartGroups.Group0.ChartData.SeriesList.RemoveAt( index);
					lbFList.Items.RemoveAt( index);

					c1Chart1.Invalidate();
				}
			}		
		}

		private void lbFList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int index = lbFList.SelectedIndex;
			if( index>=0)
			{
				pgSeries.SelectedObject = c1Chart1.ChartGroups.Group0.ChartData.SeriesList[index];
				btnEdit.Enabled = true;
				btnRemove.Enabled = true;
			}
			else
			{
				pgSeries.SelectedObject = null;
				btnEdit.Enabled = false;
				btnRemove.Enabled = false;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			c1Chart1.Header.Style.Font = new Font( "Arial", 12, FontStyle.Underline);

			pgOptions.SelectedObject = c1Chart1.ChartGroups[0].Polar;
			setXYChart();
		}

		private void rbXY_CheckedChanged(object sender, System.EventArgs e)
		{
			if( rbXY.Checked)
				setXYChart();
			else
				setPolarChart();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
