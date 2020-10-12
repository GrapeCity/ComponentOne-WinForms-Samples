using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Bubbles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart chart;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
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

		void setupChart()
		{
			// setup chart style
			chart.Style.BackColor = Color.Firebrick;
			chart.Style.ForeColor = Color.Navy;

			// setup header
			chart.Header.Style.BackColor = Color.Tan;
			chart.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			chart.Header.Style.Border.Thickness = 5;
			chart.Header.Style.Font = new Font( "Arial", 10, FontStyle.Italic);
			chart.Header.Location = new Point( 10, 20);
			chart.Header.Text = "Average length of stay for patients\n" + 
			"with the same type of illness\n" + 
			"at three different hospitals";

			// setup footer
			chart.Footer.Style.BackColor = Color.Tan;
			chart.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			chart.Footer.Style.Border.Thickness = 5;
			chart.Footer.Style.Font = new Font( "Arial", 10);
			chart.Footer.Text = "Nowhere"; 
			chart.Footer.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center;

			// setup label
			C1.Win.C1Chart.Label lbl = chart.ChartLabels.LabelsCollection.AddNewLabel();
			lbl.Style.BackColor = Color.Tan;
			lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			lbl.Style.Border.Thickness = 5;
			lbl.Style.ForeColor = Color.DarkViolet;
			lbl.Style.Font = new Font( "Arial", 10);
			lbl.Text = "Move the mouse over a Bubble\n to see length of stay in days";
			lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.SouthEast;
			lbl.AttachMethodData.X = 250;
			lbl.AttachMethodData.Y = 20;
			lbl.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center;
			lbl.Visible = true;

			// setup chart area
			chart.ChartArea.Style.BackColor = Color.Tan;
			chart.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			chart.ChartArea.Style.Border.Thickness = 5;

			// setup axis X
			C1.Win.C1Chart.ValueLabel  vlbl = chart.ChartArea.AxisX.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 1;
			vlbl.Text = "General";

			vlbl = chart.ChartArea.AxisX.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 2;
			vlbl.Text = "Western";

			vlbl = chart.ChartArea.AxisX.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 3;
			vlbl.Text = "Eastern";

			chart.ChartArea.AxisX.Min = 0.5f;
			chart.ChartArea.AxisX.Max = 3.5f;

			chart.ChartArea.AxisX.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels;

			// setup axis Y
			vlbl = chart.ChartArea.AxisY.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 1;
			vlbl.Text = "Men";

			vlbl = chart.ChartArea.AxisY.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 2;
			vlbl.Text = "Women";

			chart.ChartArea.AxisY.Min = 0;
			chart.ChartArea.AxisY.Max = 3;

			chart.ChartArea.AxisY.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels;

			chart.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bubble;
		}

		void setupData()
		{
			// Clear the existing data
			chart.ChartGroups[0].ChartData.SeriesList.Clear();

			// Add the data

			// first series
			C1.Win.C1Chart.ChartDataSeries series1 = chart.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

			float[] x = new float[] { 1, 2, 3};
			float[] y = new float[] { 1, 1, 1};
			float[] y1 = new float[] { 33.16667f,10,25.33333f};
			
			series1.X.CopyDataIn( x);
			series1.Y.CopyDataIn( y);
			series1.Y1.CopyDataIn( y1);

			series1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			series1.SymbolStyle.Color = Color.IndianRed;
			series1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;

			// second series
			C1.Win.C1Chart.ChartDataSeries series2 = chart.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

			y = new float[] { 2, 2, 2};
			y1 = new float[] { 30.5f, 5.833333f, 13.16667f};
			
			series2.X.CopyDataIn( x);
			series2.Y.CopyDataIn( y);
			series2.Y1.CopyDataIn( y1);

			series2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			series2.SymbolStyle.Color = Color.LightSeaGreen;
			series2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chart = new C1.Win.C1Chart.C1Chart();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			this.chart.BackColor = System.Drawing.Color.Firebrick;
			this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
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
				"Axis></Axes><Header Compass=\"North\"><Text /></Header><Footer Compass=\"South\"><Te" +
				"xt /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartArea" +
				" /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar" +
				"><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotations=True,Star" +
				"t=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,St" +
				"art=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stacked>False</Stack" +
				"ed><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoDat" +
				"a>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=" +
				"True</HiLoData><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeri" +
				"esSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickness=\"1\" Color=\"Da" +
				"rkGoldenrod\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Box\" Color=\"Coral\" /><SeriesL" +
				"abel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTy" +
				"pes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2" +
				" /><Y>8;12;10;12;15</Y><LineStyle Thickness=\"1\" Color=\"DarkGray\" Pattern=\"Solid\"" +
				" /><SymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue\" /><SeriesLabel>series 1</Seri" +
				"esLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;" +
				"4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>10;16;17;15;2" +
				"3</Y><LineStyle Thickness=\"1\" Color=\"DarkGreen\" Pattern=\"Solid\" /><SymbolStyle S" +
				"hape=\"Tri\" Color=\"Cornsilk\" /><SeriesLabel>series 2</SeriesLabel><DataTypes>Sing" +
				"le;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSeri" +
				"alizer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><LineStyle Thickne" +
				"ss=\"1\" Color=\"DarkKhaki\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Diamond\" Color=\"C" +
				"rimson\" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;Single;Single;Sin" +
				"gle;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer></DataSeriesC" +
				"ollection></DataSerializer></ChartGroup><ChartGroup><Bar>ClusterOverlap=0,Cluste" +
				"rWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotat" +
				"ions=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>Ot" +
				"herOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</ChartType><Stacke" +
				"d>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" +
				"ubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=" +
				"True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></ChartGroupsCollect" +
				"ion></Chart2DPropBag>";
			this.chart.Size = new System.Drawing.Size(592, 403);
			this.chart.TabIndex = 6;
			this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
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
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.chart});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Bubble Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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

		private void chart_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int row=0, col=0, dist=0;
			if( chart.ChartGroups[0].CoordToDataIndex( e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref row, ref col, ref dist))
			{
				if (dist <=10)
					chart.Footer.Text = String.Format( "({0},{1}) = {2}", row, col,this.chart.ChartGroups[0].ChartData.SeriesList[row].Y1[col]  );
				else
					chart.Footer.Text = "Nowhere";
			}
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			setupChart();
			setupData();
		}
	}
}
