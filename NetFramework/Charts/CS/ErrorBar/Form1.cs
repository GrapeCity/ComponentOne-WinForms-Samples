using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace error_bars_demo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
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
			//setup the chart style
			c1Chart1.Style.BackColor = Color.LightBlue;

			//setup the chart header
			c1Chart1.Header.Text="These are Error Bars";
			c1Chart1.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			c1Chart1.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			c1Chart1.ChartArea.Style.BackColor = Color.LightYellow;
			c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			c1Chart1.ChartArea.Style.Border.Thickness = 4;

			//chart types for the two groups
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose;
			c1Chart1.ChartGroups[0].HiLoData.FullWidth = true;

			c1Chart1.ChartGroups[1].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;   	

			//setup axes
			c1Chart1.ChartArea.AxisX.ForeColor = Color.Red;
			c1Chart1.ChartArea.AxisX.Min = 0;
			c1Chart1.ChartArea.AxisX.Max = 6;

			c1Chart1.ChartArea.AxisY.ForeColor = Color.Blue;
			c1Chart1.ChartArea.AxisY.Max = 25;
			c1Chart1.ChartArea.AxisY.Min = 0;

			c1Chart1.ChartArea.AxisY2.ForeColor = Color.Blue;
			c1Chart1.ChartArea.AxisY2.Min = 0;
			c1Chart1.ChartArea.AxisY2.Max = 25;
		}

		void setupData()
		{
			double[] x = new double[] { 1, 2, 3, 4, 5};
			double[] y = new double[] { 14,17,15,18,20};
			double[] ymax = new double[]{20,22,19,24,25};
			double[] ymin = new double[] {8,12,10,12,15};
			int len = y.Length;

			// setup group0 data
			c1Chart1.ChartGroups[0].ChartData[0].X.CopyDataIn(  x);
			c1Chart1.ChartGroups[0].ChartData[0].Y.CopyDataIn( ymin);
			c1Chart1.ChartGroups[0].ChartData[0].Y1.CopyDataIn( ymax);
			c1Chart1.ChartGroups[0].ChartData[0].Y2.CopyDataIn( ymin);
			c1Chart1.ChartGroups[0].ChartData[0].Y3.CopyDataIn( ymax);

			// setup group1 data
			C1.Win.C1Chart.ChartDataSeries ds1 = new C1.Win.C1Chart.ChartDataSeries();
			
			// setup appearance
			ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
			ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Box;
			ds1.SymbolStyle.Color = Color.Black;

			//copy the data into dataseries									
			ds1.X.CopyDataIn( x);
			ds1.Y.CopyDataIn( y);
			
			//add the data series
			c1Chart1.ChartGroups[1].ChartData.SeriesList.Add( ds1);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Par" +
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
			this.c1Chart1.Size = new System.Drawing.Size(592, 403);
			this.c1Chart1.TabIndex = 0;
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
																																	this.c1Chart1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Error Bar Demo";
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			setupChart();
			setupData();
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
