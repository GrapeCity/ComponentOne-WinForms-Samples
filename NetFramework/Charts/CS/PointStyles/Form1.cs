using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace PointStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.ComboBox cbChartType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown udPointIndex;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown udSeriesIndex;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem miFile;
		private System.Windows.Forms.MenuItem miNewData;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miHelp;
		private System.Windows.Forms.MenuItem miAbout;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.udSeriesIndex = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.udPointIndex = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbChartType = new System.Windows.Forms.ComboBox();
			this.cbMethod = new System.Windows.Forms.ComboBox();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miNewData = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.miHelp = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udSeriesIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udPointIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.label4,
																																				 this.udSeriesIndex,
																																				 this.label3,
																																				 this.udPointIndex,
																																				 this.label2,
																																				 this.label1,
																																				 this.cbChartType,
																																				 this.cbMethod});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 425);
			this.panel1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Series index";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udSeriesIndex
			// 
			this.udSeriesIndex.Location = new System.Drawing.Point(96, 152);
			this.udSeriesIndex.Maximum = new System.Decimal(new int[] {
																																	1,
																																	0,
																																	0,
																																	0});
			this.udSeriesIndex.Name = "udSeriesIndex";
			this.udSeriesIndex.Size = new System.Drawing.Size(40, 20);
			this.udSeriesIndex.TabIndex = 6;
			this.udSeriesIndex.ValueChanged += new System.EventHandler(this.udSeriesIndex_ValueChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Point index";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udPointIndex
			// 
			this.udPointIndex.Location = new System.Drawing.Point(96, 184);
			this.udPointIndex.Name = "udPointIndex";
			this.udPointIndex.Size = new System.Drawing.Size(40, 20);
			this.udPointIndex.TabIndex = 4;
			this.udPointIndex.ValueChanged += new System.EventHandler(this.udPointIndex_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Point style selection";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chart type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbChartType
			// 
			this.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbChartType.Items.AddRange(new object[] {
																										 "XYPlot",
																										 "Bar"});
			this.cbChartType.Location = new System.Drawing.Point(16, 48);
			this.cbChartType.Name = "cbChartType";
			this.cbChartType.Size = new System.Drawing.Size(121, 21);
			this.cbChartType.TabIndex = 1;
			this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);
			// 
			// cbMethod
			// 
			this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMethod.Location = new System.Drawing.Point(16, 112);
			this.cbMethod.Name = "cbMethod";
			this.cbMethod.Size = new System.Drawing.Size(121, 21);
			this.cbMethod.TabIndex = 0;
			this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(160, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\"><StyleData>Border=Solid,ControlText,1;BackColor=Wh" +
				"ite;</StyleData></NamedStyle><NamedStyle Name=\"Legend\" ParentName=\"Legend.defaul" +
				"t\"><StyleData /></NamedStyle><NamedStyle Name=\"Footer\" ParentName=\"Control\"><Sty" +
				"leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=\"Area\" Pare" +
				"ntName=\"Area.default\"><StyleData /></NamedStyle><NamedStyle Name=\"Control\" Paren" +
				"tName=\"Control.default\"><StyleData>Border=Inset,Transparent,1;</StyleData></Name" +
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
				"ader><Footer Compass=\"South\"><Text /></Footer><Legend Compass=\"East\" Visible=\"Fa" +
				"lse\"><Text /></Legend><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" Uni" +
				"tMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _on" +
				"Top=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\" Pa" +
				"ttern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></" +
				"Axis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMin" +
				"or=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridM" +
				"ajor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"T" +
				"rue\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"" +
				"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\"" +
				" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Color=\"LightGray\"" +
				" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /" +
				"></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(472, 425);
			this.c1Chart1.TabIndex = 2;
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
																																					 this.miNewData,
																																					 this.menuItem3,
																																					 this.miExit});
			this.miFile.Text = "&File";
			// 
			// miNewData
			// 
			this.miNewData.Index = 0;
			this.miNewData.Text = "&New data";
			this.miNewData.Click += new System.EventHandler(this.miNewData_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// miExit
			// 
			this.miExit.Index = 2;
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
			this.ClientSize = new System.Drawing.Size(632, 425);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.panel1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - PointStyles Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udSeriesIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udPointIndex)).EndInit();
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

		Random rnd = new Random();
		int np = 10;

		private void GenerateData()
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;

			if( cd.SeriesList.Count!=2)
			{
				cd.SeriesList.Clear();
				ChartDataSeries ds1 = cd.SeriesList.AddNewSeries();
				ds1.SymbolStyle.Shape = SymbolShapeEnum.Box;
				ds1.SymbolStyle.Size = 10;
				ds1.SymbolStyle.OutlineColor = Color.Black;
				ds1.SymbolStyle.Color = Color.LightBlue;
				ds1.LineStyle.Color = Color.Plum;

				ChartDataSeries ds2 = cd.SeriesList.AddNewSeries();
				ds2.SymbolStyle.Shape = SymbolShapeEnum.Dot;
				ds2.SymbolStyle.Size = 10;
				ds2.SymbolStyle.OutlineColor = Color.Black;
				ds2.SymbolStyle.Color = Color.LightPink;
				ds2.LineStyle.Color = Color.PaleGreen;
			}

			double[] x = new double[np];//!!VBSubst Dim x(np-1) As Double
			double[] y = new double[np];//!!VBSubst Dim y(np-1) As Double

			foreach( ChartDataSeries ds in cd.SeriesList)
			{
				for( int i=0; i<np; i++)
				{
					x[i] = i;
					y[i] = rnd.NextDouble() * 20 - 10;
				}

				ds.X.CopyDataIn(x);
				ds.Y.CopyDataIn(y);
			}
		}

		private void InitComboFromEnum( ComboBox cb, Type entype)
		{
			Array arr = Enum.GetValues( entype);
			for( int i=0; i<arr.Length; i++)
				cb.Items.Add( arr.GetValue(i));

			cb.SelectedItem = arr.GetValue(0);
		}

		private void InitStyle()
		{
			C1.Win.C1Chart.PointStyle ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList[0];
			ps.LineStyle.Color = Color.Red;
			ps.SymbolStyle.Color = Color.LightYellow;
			ps.SymbolStyle.Size = 15;
			ps.SymbolStyle.OutlineColor = Color.Red;
			ps.SymbolStyle.OutlineWidth = 2;
			ps.SymbolStyle.Shape = SymbolShapeEnum.Diamond;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// show grid
			c1Chart1.ChartArea.AxisX.GridMajor.Visible = true;
			c1Chart1.ChartArea.AxisY.GridMajor.Visible = true;

			C1.Win.C1Chart.PointStyle ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
			InitStyle();

			ps.Select += new C1.Win.C1Chart.PointStyleSelectEventHandler(PointStyle_Select);

			GenerateData();
			InitComboFromEnum( cbMethod, typeof(PointStyleSelectionEnum));
			cbChartType.SelectedIndex = 0;

			udPointIndex.Maximum = np-1;
		}

		void PointStyle_Select( object sender, C1.Win.C1Chart.PointStyleSelectEventArgs e)
		{
			double val = Convert.ToDouble(c1Chart1.ChartGroups[0].ChartData[e.SeriesIndex].Y[e.PointIndex]);
			double maxy = c1Chart1.ChartGroups[0].ChartData.MaxY;
			double miny = c1Chart1.ChartGroups[0].ChartData.MinY;
			ChartDataSeries ds = c1Chart1.ChartGroups[0].ChartData[e.SeriesIndex];

			C1.Win.C1Chart.PointStyle ps = (C1.Win.C1Chart.PointStyle)sender;

			if( val>0)
			{
				//Color clr = Color.FromArgb( (int)(255 * ( 1 - (maxy -val) / maxy)), Color.Red);
				Color clr = Color.FromArgb( (int)(255 * ( 1 - (maxy -val) / maxy)), ds.LineStyle.Color);
				ps.LineStyle.Color = clr;
				ps.SymbolStyle.Color = clr;

				ps.SymbolStyle.OutlineColor = Color.Red;
			}
			else
			{
				val = Math.Abs(val);
				miny = Math.Abs( miny);
				//Color clr = Color.FromArgb( (int)(255 * ( 1 - (miny -val) / miny)), Color.Blue);
				Color clr = Color.FromArgb( (int)(255 * ( 1 - (miny -val) / miny)), ds.LineStyle.Color);
				ps.LineStyle.Color = clr;
				ps.SymbolStyle.Color = clr;
				ps.SymbolStyle.OutlineColor = Color.Blue;
			}

			e.Selected = true;
		}

		private void c1Chart1_DoubleClick(object sender, System.EventArgs e)
		{
			c1Chart1.ShowProperties();
		}

		private void cbMethod_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			C1.Win.C1Chart.PointStyle ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList[0];

			ps.Selection = (PointStyleSelectionEnum)cbMethod.SelectedItem;
			InitStyle();

			if( ps.Selection == PointStyleSelectionEnum.Index)
				udPointIndex.Enabled = true;
			else
				udPointIndex.Enabled = false;

			if( ps.Selection == PointStyleSelectionEnum.Index ||
					ps.Selection == PointStyleSelectionEnum.SeriesMaxX ||
					ps.Selection == PointStyleSelectionEnum.SeriesMaxY ||
					ps.Selection == PointStyleSelectionEnum.SeriesMinX ||
					ps.Selection == PointStyleSelectionEnum.SeriesMinY)
				udSeriesIndex.Enabled = true;
			else
				udSeriesIndex.Enabled = false;
		}

		private void cbChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(cbChartType.SelectedIndex)
			{
				case 0:
					c1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.XYPlot;
					break;
				case 1:
					c1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.Bar;
					break;
			}
		}

		private void udPointIndex_ValueChanged(object sender, System.EventArgs e)
		{
			C1.Win.C1Chart.PointStyle ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList[0];
			ps.PointIndex = (int)udPointIndex.Value;
		}

		private void udSeriesIndex_ValueChanged(object sender, System.EventArgs e)
		{
			C1.Win.C1Chart.PointStyle ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList[0];
			ps.SeriesIndex = (int)udSeriesIndex.Value;
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miNewData_Click(object sender, System.EventArgs e)
		{
			GenerateData();		
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
