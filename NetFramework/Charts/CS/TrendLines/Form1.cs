using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Data;
using System.Text;

using C1.Win.C1Chart;

namespace TrendLines
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnNewData;
		private System.Windows.Forms.NumericUpDown udOrder;
		private System.Windows.Forms.ComboBox cbTrendType;
		private System.Windows.Forms.ComboBox cbDataType;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem miFile;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miView;
		private System.Windows.Forms.MenuItem miStat;
		private System.Windows.Forms.MenuItem miFormula;
		private System.Windows.Forms.MenuItem miEdit;
		private System.Windows.Forms.MenuItem miCopy;
		private System.Windows.Forms.MenuItem miLegend;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.MenuItem miHelp;
		private System.Windows.Forms.MenuItem miAbout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblErrorData;
		private System.Windows.Forms.Label lblErrorTrend;
		private System.Windows.Forms.CheckBox cbTLCursor;
		private System.Windows.Forms.MenuItem miPaste;
		private System.Windows.Forms.MenuItem miCopyStat;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.CheckBox cbUseYIntercept;
		private System.Windows.Forms.NumericUpDown udYIntercept;
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
			this.btnNewData = new System.Windows.Forms.Button();
			this.udOrder = new System.Windows.Forms.NumericUpDown();
			this.cbTrendType = new System.Windows.Forms.ComboBox();
			this.cbDataType = new System.Windows.Forms.ComboBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.miEdit = new System.Windows.Forms.MenuItem();
			this.miCopy = new System.Windows.Forms.MenuItem();
			this.miCopyStat = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.miPaste = new System.Windows.Forms.MenuItem();
			this.miView = new System.Windows.Forms.MenuItem();
			this.miStat = new System.Windows.Forms.MenuItem();
			this.miFormula = new System.Windows.Forms.MenuItem();
			this.miLegend = new System.Windows.Forms.MenuItem();
			this.miHelp = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.udYIntercept = new System.Windows.Forms.NumericUpDown();
			this.cbUseYIntercept = new System.Windows.Forms.CheckBox();
			this.cbTLCursor = new System.Windows.Forms.CheckBox();
			this.lblErrorTrend = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblErrorData = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.udOrder)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udYIntercept)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNewData
			// 
			this.btnNewData.Location = new System.Drawing.Point(8, 88);
			this.btnNewData.Name = "btnNewData";
			this.btnNewData.Size = new System.Drawing.Size(144, 20);
			this.btnNewData.TabIndex = 1;
			this.btnNewData.Text = "Generate new data";
			this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
			// 
			// udOrder
			// 
			this.udOrder.Location = new System.Drawing.Point(112, 80);
			this.udOrder.Maximum = new System.Decimal(new int[] {
																														5,
																														0,
																														0,
																														0});
			this.udOrder.Minimum = new System.Decimal(new int[] {
																														2,
																														0,
																														0,
																														0});
			this.udOrder.Name = "udOrder";
			this.udOrder.Size = new System.Drawing.Size(40, 20);
			this.udOrder.TabIndex = 3;
			this.udOrder.Value = new System.Decimal(new int[] {
																													2,
																													0,
																													0,
																													0});
			this.udOrder.ValueChanged += new System.EventHandler(this.udOrder_ValueChanged);
			// 
			// cbTrendType
			// 
			this.cbTrendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTrendType.Location = new System.Drawing.Point(8, 48);
			this.cbTrendType.Name = "cbTrendType";
			this.cbTrendType.Size = new System.Drawing.Size(144, 21);
			this.cbTrendType.TabIndex = 4;
			this.cbTrendType.SelectedIndexChanged += new System.EventHandler(this.cbTrendType_SelectedIndexChanged);
			// 
			// cbDataType
			// 
			this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataType.Location = new System.Drawing.Point(8, 48);
			this.cbDataType.Name = "cbDataType";
			this.cbDataType.Size = new System.Drawing.Size(144, 21);
			this.cbDataType.TabIndex = 5;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.miFile,
																																							this.miEdit,
																																							this.miView,
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
			// miEdit
			// 
			this.miEdit.Index = 1;
			this.miEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miCopy,
																																					 this.miCopyStat,
																																					 this.menuItem1,
																																					 this.miPaste});
			this.miEdit.Text = "&Edit";
			// 
			// miCopy
			// 
			this.miCopy.Index = 0;
			this.miCopy.Text = "Copy";
			this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
			// 
			// miCopyStat
			// 
			this.miCopyStat.Index = 1;
			this.miCopyStat.Text = "Copy Statistics";
			this.miCopyStat.Click += new System.EventHandler(this.miCopyStat_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// miPaste
			// 
			this.miPaste.Index = 3;
			this.miPaste.Text = "Paste";
			this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
			// 
			// miView
			// 
			this.miView.Index = 2;
			this.miView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miStat,
																																					 this.miFormula,
																																					 this.miLegend});
			this.miView.Text = "&View";
			// 
			// miStat
			// 
			this.miStat.Index = 0;
			this.miStat.Text = "&Statistics";
			this.miStat.Click += new System.EventHandler(this.miStat_Click);
			// 
			// miFormula
			// 
			this.miFormula.Index = 1;
			this.miFormula.Text = "Fo&rmula";
			this.miFormula.Click += new System.EventHandler(this.miFormula_Click);
			// 
			// miLegend
			// 
			this.miLegend.Index = 2;
			this.miLegend.Text = "Legend";
			this.miLegend.Click += new System.EventHandler(this.miLegend_Click);
			// 
			// miHelp
			// 
			this.miHelp.Index = 3;
			this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.miAbout});
			this.miHelp.Text = "&Help";
			// 
			// miAbout
			// 
			this.miAbout.Index = 0;
			this.miAbout.Text = "About";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							this.tabPage1,
																																							this.tabPage2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(168, 433);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.udYIntercept,
																																					 this.cbUseYIntercept,
																																					 this.cbTLCursor,
																																					 this.lblErrorTrend,
																																					 this.lblNumber,
																																					 this.label1,
																																					 this.cbTrendType,
																																					 this.udOrder});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(160, 407);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Trend line";
			// 
			// udYIntercept
			// 
			this.udYIntercept.DecimalPlaces = 1;
			this.udYIntercept.Location = new System.Drawing.Point(104, 112);
			this.udYIntercept.Name = "udYIntercept";
			this.udYIntercept.Size = new System.Drawing.Size(48, 20);
			this.udYIntercept.TabIndex = 11;
			this.udYIntercept.Visible = false;
			this.udYIntercept.ValueChanged += new System.EventHandler(this.udYIntercept_ValueChanged);
			// 
			// cbUseYIntercept
			// 
			this.cbUseYIntercept.Location = new System.Drawing.Point(8, 112);
			this.cbUseYIntercept.Name = "cbUseYIntercept";
			this.cbUseYIntercept.Size = new System.Drawing.Size(96, 24);
			this.cbUseYIntercept.TabIndex = 10;
			this.cbUseYIntercept.Text = "UseYIntercept";
			this.cbUseYIntercept.CheckedChanged += new System.EventHandler(this.cbUseYIntercept_CheckedChanged);
			// 
			// cbTLCursor
			// 
			this.cbTLCursor.Location = new System.Drawing.Point(8, 144);
			this.cbTLCursor.Name = "cbTLCursor";
			this.cbTLCursor.Size = new System.Drawing.Size(144, 24);
			this.cbTLCursor.TabIndex = 9;
			this.cbTLCursor.Text = "Trend line cursor";
			this.cbTLCursor.CheckedChanged += new System.EventHandler(this.cbTLCursor_CheckedChanged);
			// 
			// lblErrorTrend
			// 
			this.lblErrorTrend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblErrorTrend.ForeColor = System.Drawing.Color.Red;
			this.lblErrorTrend.Location = new System.Drawing.Point(8, 248);
			this.lblErrorTrend.Name = "lblErrorTrend";
			this.lblErrorTrend.Size = new System.Drawing.Size(144, 32);
			this.lblErrorTrend.TabIndex = 8;
			this.lblErrorTrend.Text = "This data does not fit to the selected trend type.";
			this.lblErrorTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumber
			// 
			this.lblNumber.Location = new System.Drawing.Point(8, 80);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(96, 20);
			this.lblNumber.TabIndex = 6;
			this.lblNumber.Text = "Number of terms:";
			this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Trend line type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.lblErrorData,
																																					 this.label2,
																																					 this.cbDataType,
																																					 this.btnNewData});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(160, 407);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Data";
			// 
			// lblErrorData
			// 
			this.lblErrorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblErrorData.ForeColor = System.Drawing.Color.Red;
			this.lblErrorData.Location = new System.Drawing.Point(8, 128);
			this.lblErrorData.Name = "lblErrorData";
			this.lblErrorData.Size = new System.Drawing.Size(144, 32);
			this.lblErrorData.TabIndex = 7;
			this.lblErrorData.Text = "This data does not fit to the selected trend type.";
			this.lblErrorData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Data distribution:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.DockPadding.Left = 150;
			this.c1Chart1.Location = new System.Drawing.Point(168, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\"><StyleData>Border=Solid,ControlText,1;BackColor=Wh" +
				"ite;</StyleData></NamedStyle><NamedStyle Name=\"Legend\" ParentName=\"Legend.defaul" +
				"t\"><StyleData>Border=Solid,Black,1;BackColor=192, 224, 224, 224;Rounding=5 5 5 5" +
				";</StyleData></NamedStyle><NamedStyle Name=\"Footer\" ParentName=\"Control\"><StyleD" +
				"ata>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=\"Area\" ParentN" +
				"ame=\"Area.default\"><StyleData /></NamedStyle><NamedStyle Name=\"Control\" ParentNa" +
				"me=\"Control.default\"><StyleData>Border=Solid,Transparent,1;BackColor=Gainsboro;<" +
				"/StyleData></NamedStyle><NamedStyle Name=\"AxisX\" ParentName=\"Area\"><StyleData>Ro" +
				"tation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;" +
				"Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=\"AxisY\" " +
				"ParentName=\"Area\"><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignH" +
				"orz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></Named" +
				"Style><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default" +
				"\"><StyleData /></NamedStyle><NamedStyle Name=\"Legend.default\" ParentName=\"Contro" +
				"l\"><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedSt" +
				"yle><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Control\"><StyleData" +
				">Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle " +
				"Name=\"Header\" ParentName=\"Control\"><StyleData>Border=None,Black,1;</StyleData></" +
				"NamedStyle><NamedStyle Name=\"Control.default\" ParentName=\"\"><StyleData>ForeColor" +
				"=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><Nam" +
				"edStyle Name=\"AxisY2\" ParentName=\"Area\"><StyleData>Rotation=Rotate90;Border=None" +
				",Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData>" +
				"</NamedStyle><NamedStyle Name=\"Area.default\" ParentName=\"Control\"><StyleData>Bor" +
				"der=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollection><Chart" +
				"GroupsCollection><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" Defau" +
				"ltSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkG" +
				"oldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</Seri" +
				"esLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single" +
				";Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></Da" +
				"taSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolSt" +
				"yle Color=\"CornflowerBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1" +
				";2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Doubl" +
				"e;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSeria" +
				"lizer><DataSeriesSerializer><LineStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"C" +
				"ornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;" +
				"16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</" +
				"DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeries" +
				"Serializer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Di" +
				"amond\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y" +
				"><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><Dat" +
				"aFields>;;;;</DataFields><Tag /></DataSeriesSerializer></DataSeriesCollection></" +
				"DataSerializer><Name>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</Cha" +
				"rtType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Ba" +
				"r><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True" +
				",ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumS" +
				"ize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>" +
				"Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>Tru" +
				"e</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=\"3.4028234663852886" +
				"E+38\" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType>" +
				"<Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLo" +
				"Data>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOp" +
				"en=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</" +
				"Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees" +
				"=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Show" +
				"Outline></ChartGroup></ChartGroupsCollection><Header Compass=\"North\" Visible=\"Fa" +
				"lse\"><Text /></Header><Footer Compass=\"South\" Visible=\"False\"><Text /></Footer><" +
				"Legend Compass=\"North\" LocationDefault=\"80, 80\" Visible=\"False\"><Text /></Legend" +
				"><ChartArea><Margin Top=\"0\" Left=\"0\" Bottom=\"0\" Right=\"0\" /></ChartArea><Axes><A" +
				"xis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"Tr" +
				"ue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor " +
				"Visible=\"True\" Spacing=\"1\" AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><" +
				"GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"" +
				"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" Auto" +
				"Max=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor Visible=\"" +
				"True\" Spacing=\"1\" AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor" +
				" AutoSpace=\"True\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0" +
				"\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" A" +
				"utoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Colo" +
				"r=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Color=\"LightGray\" Pat" +
				"tern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(464, 433);
			this.c1Chart1.TabIndex = 7;
			this.c1Chart1.LayoutLabels += new System.EventHandler(this.c1Chart1_LayoutLabels);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			this.c1Chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Chart1_Paint);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 433);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.tabControl1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart.Net 2D - Trend Lines Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.udOrder)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udYIntercept)).EndInit();
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

		Random rnd = new Random();
		int np = 100;
		double[] k;

		enum DataType
		{
			Poly2,
			Poly3,
			Poly4,
			Expo,
			Log,
			Pow,
			Fourier2,
			Fourier3,
			Fourier4,
			Random
		}

		DataType dtLastGenerated = DataType.Poly2;

		// generates normally distributed random numbers
		double[] RandNormal( int n)
		{
			if ( n%2 ==1)
				n++;

			double[] rn = new double[n]; //!!VBSubst Dim rn(n-1) As Double

			for( int i=0; i<n/2; i++)
			{
				do
				{
					double u = 2*rnd.NextDouble() - 1;
					double v = 2*rnd.NextDouble() - 1;

					double s = u*u + v*v;

					if( s < 1)
					{
						s = Math.Sqrt( -2 * Math.Log( s) / s);
						rn[2*i] = u * s;
						rn[2*i+1] = v * s;
						break;
					}
				}while(true);
			}

			return rn;
		}

		// create pseudo-random data
		private void GenerateNewData(DataType dt)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;
			ChartDataSeries ds;

			if( cd.SeriesList.Count!=1)
			{
				// create and setup data series
				cd.SeriesList.Clear();
				ds = cd.SeriesList.AddNewSeries();
				ds.LineStyle.Pattern = LinePatternEnum.None;
				ds.SymbolStyle.Color = Color.LightBlue;
				ds.SymbolStyle.OutlineColor = Color.DarkBlue;
				ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			}
			else
				ds = cd[0];

			double[] x = new double[np]; //!!VBSubst Dim x(np-1) As Double
			double[] y = new double[np]; //!!VBSubst Dim y(np-1) As Double

			int nk = 2;

			if( dt == DataType.Poly3 || dt == DataType.Fourier3)
				nk = 3;

			if( dt == DataType.Poly4 || dt == DataType.Fourier4)
				nk = 4;

			k = new Double[nk];//!!VBSubst k = New Double(nk - 1) {}

			int i;

			for( i=0; i<k.Length; i++)
			{
				k[i] = 2*rnd.NextDouble() - 1;

				if( dt == DataType.Fourier2 || dt == DataType.Fourier3 || dt == DataType.Fourier4 
					|| dt == DataType.Log)
					k[i] *= 10;
			}

			double[] rns = RandNormal( np);

			double xconst = 5;
			
			if( dt == DataType.Fourier2 || dt == DataType.Fourier3 || dt == DataType.Fourier4)
				xconst = 50;

			if( dt == DataType.Log)
				k[1] = Math.Abs(k[1]);
			else if( dt == DataType.Pow || dt == DataType.Expo)
			{
				if( k[0]<0)
					k[1] = -Math.Abs(k[1]);
				else
					k[1] = Math.Abs(k[1]);
			}
		
			for( i=0; i<np; i++)
			{
				x[i] = xconst*rnd.NextDouble();

				switch( dt)
				{
					case DataType.Poly2:
					case DataType.Poly3:
					case DataType.Poly4:
						y[i] = 0;
						for( int j=0; j<k.Length; j++)
							y[i] += k[j]*Math.Pow( x[i], j);
						break;

					case DataType.Log:
						y[i] = k[0]*Math.Log( k[1] * x[i]);
						break;

					case DataType.Pow:
						y[i] = k[0]*Math.Pow( x[i], k[1]);
						break;

					case DataType.Expo:
						y[i] = k[0]*Math.Exp( x[i]* k[1]);
						break;

					case DataType.Fourier2:
						y[i] = k[0] + Math.Cos( x[i]) * k[1];
						break;

					case DataType.Fourier3:
						y[i] = k[0] + Math.Cos( x[i]) * k[1] + Math.Sin( x[i])* k[2];
						break;

					case DataType.Fourier4:
						y[i] = k[0] + Math.Cos( x[i]) * k[1] + Math.Sin( x[i])* k[2] + Math.Cos( 2*x[i]) * k[3];
						break;

					default:
						break;
				}

				y[i] += rns[i] / 10; // add some random noise
			}

			dtLastGenerated = dt;

			// put data into chart
			ds.X.CopyDataIn( x);
			ds.Y.CopyDataIn( y);

			// init trend line
			if( cd.TrendsList.Count==0)
			{
				TrendLine tl = cd.TrendsList.AddNewTrendLine();
				tl.SeriesIndex = 0;
				tl.LineStyle.Color = Color.RoyalBlue;
				tl.LineStyle.Thickness = 3;
				tl.NumTerms = (int) udOrder.Value;
				tl.ForecastBackward = 1;
				tl.ForecastForward = 1;
			}

			// reset axes limits
			c1Chart1.ChartArea.AxisX.AutoMax = true;
			c1Chart1.ChartArea.AxisX.AutoMin = true;
			c1Chart1.ChartArea.AxisY.AutoMax = true;
			c1Chart1.ChartArea.AxisY.AutoMin = true;

			// update labels
			UpdateStatisticsLabel();
			UpdateFormulaLabel();
		}

		private string GetFormula( DataType dt, double[] k)
		{
			string fmt = "G2";

			string s = "";
			switch( dt)
			{
				case DataType.Poly2:
				case DataType.Poly3:
				case DataType.Poly4:
					s = k[0].ToString(fmt);
					for( int i=1; i< k.Length; i++)
						s += string.Format("+{0}x^{1}", k[i].ToString(fmt), i);
					break;

				case DataType.Expo:
					s = string.Format("{0} * exp({1}*x)", k[0].ToString(fmt), k[1].ToString(fmt));
					break;

				case DataType.Log:
					s = string.Format("{0} * ln({1}*x)", k[0].ToString(fmt), k[1].ToString(fmt));
					break;

				case DataType.Pow:
					s = string.Format("{0} * pow( x, {1})", k[0].ToString(fmt), k[1].ToString(fmt));
					break;

				case DataType.Fourier2:
				case DataType.Fourier3:
				case DataType.Fourier4:
					s = string.Format( "{0} + {1}*cos(x)", k[0].ToString(fmt), k[1].ToString(fmt));

					if( k.Length >2)
						s += string.Format( " + {0}*sin(x)",  k[2].ToString(fmt));

					if( k.Length >3)
						s += string.Format( " + {0}*cos(2*x)", k[3].ToString(fmt));

					if( k.Length >4)
						s += string.Format( " + {0}*sin(2*x)", k[4].ToString(fmt));

					break;

				default:
					break;
			}

			return s;
		}

		private string GetFormula( TrendLineTypeEnum tlt, double[] k)
		{
			string s = "";
			switch( tlt)
			{
				case TrendLineTypeEnum.Polynom:
					return GetFormula( DataType.Poly2, k);

				case TrendLineTypeEnum.Exponent:
					return GetFormula( DataType.Expo, k);

				case TrendLineTypeEnum.Logarithmic:
					return GetFormula( DataType.Log, k);

				case TrendLineTypeEnum.Power:
					return GetFormula( DataType.Pow, k);

				case TrendLineTypeEnum.Fourier:
					return GetFormula( DataType.Fourier2, k);

				default:
					break;
			}

			return s;
		}

		private void UpdateFormulaLabel()
		{
			C1.Win.C1Chart.Label lbl;

			if( c1Chart1.ChartLabels.LabelsCollection.Count<2)
			{
				// create formula label
				lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lbl.AttachMethod = AttachMethodEnum.Coordinate;
				lbl.AttachMethodData.X = c1Chart1.ChartArea.PlotArea.Location.X + c1Chart1.ChartArea.PlotArea.Size.Width / 2;
				lbl.AttachMethodData.Y = c1Chart1.ChartArea.PlotArea.Location.Y + 20;
				lbl.Style.BackColor = Color.FromArgb( 192, Color.LightBlue);
				lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
				lbl.Style.Border.Color = Color.DarkBlue;
				lbl.Style.Border.Rounding.All = 15;
				lbl.Style.VerticalAlignment = AlignVertEnum.Center;
				lbl.Compass = LabelCompassEnum.North;
			}
			else
				lbl = c1Chart1.ChartLabels[1];

			TrendLine tl = null;

			if( c1Chart1.ChartGroups[0].ChartData.TrendsList.Count>0)
				tl = c1Chart1.ChartGroups[0].ChartData.TrendsList[0];
			else
				return;

			RegressionStatistics rs = tl.RegressionStatistics;

			if( rs==null || rs.Coeffs==null || !miFormula.Checked)
			{
				lbl.Visible = false;
				return;
			}

			TrendLineTypeEnum tlt = (TrendLineTypeEnum)cbTrendType.SelectedItem;

			string s_regr = GetFormula( tlt, rs.Coeffs);
			string s_exact = GetFormula( dtLastGenerated, k);

			if( s_regr.Length>0 && s_exact.Length>0)
			{
				lbl.Visible = true;
				lbl.Text = string.Format( "Data formula: {0}\n\nRegression formula: {1}", s_exact, s_regr);
			}
			else if( s_regr.Length>0)
			{
				lbl.Visible = true;
				lbl.Text = string.Format( "Regression formula: {1}", s_exact, s_regr);
			}
			else
				lbl.Visible = false;
		}

		private void UpdateStatisticsLabel()
		{
			C1.Win.C1Chart.Label lbl;

			if( c1Chart1.ChartLabels.LabelsCollection.Count<1)
			{
				// create statistics label
				lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lbl.AttachMethod = AttachMethodEnum.Coordinate;
				lbl.Style.BackColor = Color.FromArgb( 192, Color.MistyRose);
				lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
				lbl.Style.Border.Color = Color.IndianRed;
				lbl.Style.Border.Rounding.All = 15;
				lbl.Compass = LabelCompassEnum.West;
				lbl.Style.VerticalAlignment = C1.Win.C1Chart.AlignVertEnum.Center;
				lbl.Style.Font = new Font("Lucida Console", 8);
			}
			else
				lbl = c1Chart1.ChartLabels[0];

			TrendLine tl = null;

			if( c1Chart1.ChartGroups[0].ChartData.TrendsList.Count>0)
				tl = c1Chart1.ChartGroups[0].ChartData.TrendsList[0];
			else
				return;

			RegressionStatistics rs = tl.RegressionStatistics;

			bool isRegression = (tl.TrendLineType == TrendLineTypeEnum.Exponent) ||
				(tl.TrendLineType == TrendLineTypeEnum.Fourier) ||
				(tl.TrendLineType == TrendLineTypeEnum.Logarithmic) ||
				(tl.TrendLineType == TrendLineTypeEnum.Polynom) || 
				(tl.TrendLineType == TrendLineTypeEnum.Power);
	
			if( (rs == null) && isRegression)
			{
				lblErrorData.Visible = true;
				lblErrorTrend.Visible = true;
			}
			else
			{
				lblErrorData.Visible = false;
				lblErrorTrend.Visible = false;
			}

			if( rs!=null && miStat.Checked)
			{
				lbl.Text = CreateStatisticsString( rs, "g4", false);
					//string.Format(
					//"Statistics\n----------\nRSQ\t= {0:g4}\nSEY\t= {1:g4}\nF\t= {2:g4}\nDF\t= {3:g4}\nSSR\t= {4:g4}\nSSE\t= {5:g4}",
					//rs.Rsq, rs.Sey, rs.F, rs.DF, rs.Ssr, rs.Sse);
				lbl.Visible = true;
			}
			else
				lbl.Visible = false;
		}

		string CreateStatisticsString( RegressionStatistics rs, string fmt, bool coeffs)
		{
			string s = "Statistics\n----------\n";

			if( coeffs)
			{
				double[] k = rs.Coeffs;

				for( int i=0; i<k.Length; i++)
					s += string.Format( "k[{0}]\t= {1}\n", i, k[i].ToString(fmt));
			}

			s += string.Format(
				"RSQ\t= {0}\nSEY\t= {1}\nF\t= {2}\nDF\t= {3}\nSSR\t= {4}\nSSE\t= {5}",
				rs.Rsq.ToString(fmt), rs.Sey.ToString(fmt), rs.F.ToString(fmt),
				rs.DF.ToString(fmt), rs.Ssr.ToString(fmt), rs.Sse.ToString(fmt));

			return s;
		}

		private void CopyDataToClipboard( ChartDataSeries ds)
		{
			double[] x = (double[])ds.X.CopyDataOut( typeof(double));
			double[] y = (double[])ds.Y.CopyDataOut( typeof(double));

			int len = x.Length;

			string[] ss = new string[len];//!!VBSubst Dim ss(len-1) As Double

			StringBuilder sb = new StringBuilder();

			for( int i=0; i<len; i++)
				sb.AppendFormat("{0}\t{1}\n", x[i], y[i]);

			Clipboard.SetDataObject( sb.ToString(), false);
		}

		private void PasteDataFromClipboard( ChartDataSeries ds)
		{
			try
			{
				IDataObject obj = Clipboard.GetDataObject();

				string s = (string) obj.GetData( typeof(string));

				string[] ss = s.Split();

				int i, np = 0;

				ArrayList al = new ArrayList();

				for( i=0; i<ss.Length; i++)
				{
					if( ss[i].Length>0)
						al.Add( ss[i]);
				}

				np = al.Count / 2;

				if( np<2)
				{
					MessageBox.Show( "No available data in clipboard");
					return;
				}

				double[] x = new double[np];//!!VBSubst Dim x(np-1) As Double
				double[] y = new double[np];//!!VBSubst Dim y(np-1) As Double

				for( i=0; i<np; i++)
				{
					double res = 0;

					if( ParseDouble( (string)al[2*i+1], out res))
						x[i] = res;
					else
						throw new FormatException();

					if( ParseDouble( (string)al[2*i], out res))
						y[i] = res;
					else
						throw new FormatException();
				}

				ds.X.CopyDataIn( x);
				ds.Y.CopyDataIn( y);

				dtLastGenerated = DataType.Random;

				UpdateStatisticsLabel();
				UpdateFormulaLabel();
			}
			catch
			{
				MessageBox.Show( "No available data in clipboard");
			}
		}

		private bool ParseDouble( string s, out double result)
		{
			if( !double.TryParse( s, NumberStyles.Number, CultureInfo.CurrentCulture, out result))
				return double.TryParse( s, NumberStyles.Number, CultureInfo.InvariantCulture, out result);
		  return true;
		}

		private void btnNewData_Click(object sender, System.EventArgs e)
		{
			GenerateNewData((DataType)cbDataType.SelectedItem);
		}

		private void udOrder_ValueChanged(object sender, System.EventArgs e)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;

			if( cd.TrendsList.Count>0)
			{
				TrendLine tl = cd.TrendsList[0];

				if( tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
					tl.Period = (int) udOrder.Value;
				else
					tl.NumTerms= (int) udOrder.Value;

				UpdateStatisticsLabel();
				UpdateFormulaLabel();
			}
		}

		private void InitComboFromEnum( ComboBox cb, Type entype)
		{
			Array arr = Enum.GetValues( entype);
			for( int i=0; i<arr.Length; i++)
				cb.Items.Add( arr.GetValue(i));

			cb.SelectedItem = arr.GetValue(0);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			c1Chart1.Legend.Orientation = LegendOrientationEnum.Vertical;

			InitComboFromEnum( cbTrendType, typeof(TrendLineTypeEnum));
			InitComboFromEnum( cbDataType, typeof(DataType));
			c1Chart1.UseAntiAliasedGraphics = true;

			GenerateNewData((DataType)cbDataType.SelectedItem);

			udYIntercept.Minimum = -10;
			udYIntercept.Maximum = 10;
		}

		private void cbTrendType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;

			if( cd.TrendsList.Count>0)
			{
				TrendLine tl = cd.TrendsList[0];
				tl.TrendLineType = (TrendLineTypeEnum) cbTrendType.SelectedItem;
				if( tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
					udOrder.Maximum = np;
				else 
					udOrder.Maximum = 5;

				bool isNumber = tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage ||
					tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Polynom ||
					tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Fourier;

				lblNumber.Visible = isNumber;
				udOrder.Visible = isNumber;

				bool isPoly = (tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Polynom);

				cbUseYIntercept.Visible = isPoly;
				udYIntercept.Visible = isPoly;

				if( tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
					lblNumber.Text = "Period:";
				else
					lblNumber.Text = "Number of terms:";

				UpdateStatisticsLabel();
				UpdateFormulaLabel();
			}
		}

		private void c1Chart1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if( hasPoint)
			{
				Pen pen = new Pen( Color.Red,2);
				e.Graphics.DrawEllipse( pen, tlp0.X - 5, tlp0.Y - 5, 11, 11);
				pen.Dispose();
			}
		}

		bool hasPoint = false;
		Point tlp0;

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Point mpt = new Point( e.X, e.Y);

			PlotArea pa = c1Chart1.ChartArea.PlotArea;

			Rectangle rect = new Rectangle( pa.Location, pa.Size);

			if( rect.Contains( mpt) && this.cbTLCursor.Checked)
			{
				ChartGroup cg = c1Chart1.ChartGroups[0];
				if( cg.ChartData.TrendsList.Count>0)
				{
					TrendLine tl = cg.ChartData.TrendsList[0];

					double x = 0, y = 0;
					int ix = 0, iy = 0;

					if( tl.RegressionStatistics!=null)
					{
						if( cg.CoordToDataCoord( mpt.X, mpt.Y, ref x, ref y))
						{
							y = tl.GetY( x);

							if( cg.DataCoordToCoord( x, y, ref ix, ref iy) && rect.Contains( ix, iy))
							{
								Point tlp = new Point( ix, iy);

								hasPoint = true;

								Rectangle invRect = new Rectangle( tlp.X-8, tlp.Y-8, 16,16);

								if( !tlp0.IsEmpty)
									invRect = Rectangle.Union( invRect, new Rectangle( tlp0.X-8, tlp0.Y-8, 16,16));

								c1Chart1.Invalidate( invRect);

								tlp0 = tlp;

								return;
							}
						}
					}
				}
			}
			hasPoint = false;
		}

		private void c1Chart1_LayoutLabels(object sender, System.EventArgs e)
		{
			Point p = c1Chart1.ChartArea.PlotArea.Location;

			if( c1Chart1.Legend.Visible)
				c1Chart1.Legend.Location = new Point( p.X + 20, p.Y + 20);

			if( c1Chart1.ChartLabels.LabelsCollection.Count>0)
			{
				C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels[0];

				p.X += c1Chart1.ChartArea.PlotArea.Size.Width - 10;
				p.Y += c1Chart1.ChartArea.PlotArea.Size.Height/2;

				lbl.AttachMethodData.X = p.X;
				lbl.AttachMethodData.Y = p.Y;
			}

			if( c1Chart1.ChartLabels.LabelsCollection.Count>1)
			{
				C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels[1];

				p = c1Chart1.ChartArea.PlotArea.Location;

				p.X += c1Chart1.ChartArea.PlotArea.Size.Width /2;
				p.Y += c1Chart1.ChartArea.PlotArea.Size.Height - 10;

				lbl.AttachMethodData.X = p.X;
				lbl.AttachMethodData.Y = p.Y;
			}
		}

		// menu handlers
		private void miStat_Click(object sender, System.EventArgs e)
		{
			miStat.Checked = !miStat.Checked;
			UpdateStatisticsLabel();
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miCopy_Click(object sender, System.EventArgs e)
		{
			CopyDataToClipboard( c1Chart1.ChartGroups[0].ChartData[0]);
		}

		private void miLegend_Click(object sender, System.EventArgs e)
		{
			miLegend.Checked = !miLegend.Checked;
			c1Chart1.Legend.Visible = miLegend.Checked;
		}

		private void miFormula_Click(object sender, System.EventArgs e)
		{
			miFormula.Checked = !miFormula.Checked;
			UpdateFormulaLabel();
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void cbTLCursor_CheckedChanged(object sender, System.EventArgs e)
		{
			if( !cbTLCursor.Checked)
				c1Chart1.Invalidate();
		}

		private void miPaste_Click(object sender, System.EventArgs e)
		{
			PasteDataFromClipboard( c1Chart1.ChartGroups[0].ChartData[0]);
		}

		private void miCopyStat_Click(object sender, System.EventArgs e)
		{
			ChartGroup cg = c1Chart1.ChartGroups[0];
			if( cg.ChartData.TrendsList.Count>0)
			{
				TrendLine tl = cg.ChartData.TrendsList[0];

				RegressionStatistics rs = tl.RegressionStatistics;

				if( rs!=null)
					Clipboard.SetDataObject( CreateStatisticsString(rs,"e", true), false);
			}
		}

		private void cbUseYIntercept_CheckedChanged(object sender, System.EventArgs e)
		{
			ChartGroup cg = c1Chart1.ChartGroups[0];
			if( cg.ChartData.TrendsList.Count>0)
			{
				TrendLine tl = cg.ChartData.TrendsList[0];
				tl.RegressionOptions.UseYIntercept = cbUseYIntercept.Checked;

				UpdateStatisticsLabel();
				UpdateFormulaLabel();
			}

			udYIntercept.Visible = cbUseYIntercept.Checked;
		}

		private void udYIntercept_ValueChanged(object sender, System.EventArgs e)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;

			if( cd.TrendsList.Count>0)
			{
				TrendLine tl = cd.TrendsList[0];

				tl.RegressionOptions.YIntercept = (double)udYIntercept.Value;

				UpdateStatisticsLabel();
				UpdateFormulaLabel();
			}
		}
	}
}
