using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Scatter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// series and point index
		int si = 0, pi =0, dist=0;

		// mouse pointer over point of first data series
		bool onPoint = false;

		C1.Win.C1Chart.ChartDataSeries ds1, ds2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuOptionsShowLabels;
		private System.Windows.Forms.MenuItem menuFileExit;

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
			c1Chart1.Style.BackColor = Color.PaleTurquoise;


			// setup header
			c1Chart1.Header.Style.BackColor = Color.Tan;
			c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			c1Chart1.Header.Style.Border.Thickness = 3;
			c1Chart1.Header.Style.Font = new Font( "Lucida console", 10, FontStyle.Bold);
			c1Chart1.Header.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center;

			c1Chart1.Footer.Visible = false;

			// setup legend
			c1Chart1.Legend.Style.BackColor = Color.PowderBlue;
			c1Chart1.Legend.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center;
			c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised;			
			c1Chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South;
			c1Chart1.Legend.Visible = true;
			
			// setup chart area
			c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet;
			c1Chart1.ChartArea.Style.Border.Thickness = 2;
			c1Chart1.ChartArea.Style.BackColor = Color.PowderBlue;

			c1Chart1.ChartArea.PlotArea.Boxed = true;
		}

		void setupData()
		{
			c1Chart1.Header.Text = "Connect the Dots!";

			int npoints = 50;

			// clear all data
			c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();

			// fisrt series
			ds1 = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			float[] x = (float[])Array.CreateInstance( typeof(float), npoints);
			float[] y = (float[])Array.CreateInstance( typeof(float), npoints);
			Random rnd = new Random();

			for( int i=0; i<npoints; i++)
			{
				x[i] = rnd.Next(100);
				y[i] = rnd.Next(100);
			}

			ds1.X.CopyDataIn( x);
			ds1.Y.CopyDataIn( y);

			ds1.SymbolStyle.Color = Color.Red;
			ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			ds1.SymbolStyle.Size = 6;
			ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
			ds1.Label = string.Format( "Red series - {0} points", ds1.Length);

			// second series
			ds2 = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			ds2.SymbolStyle.Color = Color.Blue;
			ds2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			ds2.SymbolStyle.Size = 6;
			ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ds2.LineStyle.Color = Color.Navy;

			ds2.Label = string.Format( "Blue series - {0} points", ds2.Length);
		}

		void showLabels( bool show)
		{
			for( int i=0; i<c1Chart1.ChartLabels.LabelsCollection.Count; i++)
				c1Chart1.ChartLabels[ i].Visible = show;
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
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuOptionsShowLabels = new System.Windows.Forms.MenuItem();
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
			this.c1Chart1.Size = new System.Drawing.Size(592, 395);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.Click += new System.EventHandler(this.c1Chart1_Click);
			this.c1Chart1.DoubleClick += new System.EventHandler(this.c1Chart1_DoubleClick);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem3,
																																							this.menuItem2});
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
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuHelpAbout});
			this.menuItem2.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuOptionsShowLabels});
			this.menuItem3.Text = "&Options";
			// 
			// menuOptionsShowLabels
			// 
			this.menuOptionsShowLabels.Index = 0;
			this.menuOptionsShowLabels.Text = "ShowLabels";
			this.menuOptionsShowLabels.Click += new System.EventHandler(this.menuOptionsShowLabels_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 395);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - Scatter Demo";
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

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( c1Chart1.ChartGroups[0].CoordToDataIndex( e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist)
				&& dist<=6 && si == 0)
			{
				Cursor = Cursors.Cross;
				c1Chart1.Legend.Text = String.Format( "(X = {0}, Y = {1})", ds1.X[pi], ds1.Y[pi] );
				onPoint = true;
			}
			else
			{
				Cursor = Cursors.Default;
				c1Chart1.Legend.Text = "No point selected";
				onPoint = false;
			}
		}

		private void c1Chart1_Click(object sender, System.EventArgs e)
		{
			if( onPoint)
			{
				// add point to the second series
				int len = ds2.PointData.Length;
				ds2.PointData.Length = len + 1;
				ds2.PointData[ len] = ds1.PointData[ pi];

				ds2.Label = string.Format( "Blue series - {0} points", ds2.Length);

				C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lbl.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.DataIndex;
				lbl.AttachMethodData.GroupIndex = 0;
				lbl.AttachMethodData.SeriesIndex = 1;
				lbl.AttachMethodData.PointIndex = len;
				lbl.Text = string.Format( "{0}", len+1);
				lbl.Visible = menuOptionsShowLabels.Checked;

				// remove point from the first series
				if( pi != ds1.Length-1)
					ds1.PointData[ pi] = ds1.PointData[ ds1.Length-1];
				ds1.PointData.Length -= 1;
				ds1.Label = string.Format( "Red series - {0} points", ds1.Length);
				if(ds1.Length == 0)
					c1Chart1.Header.Text = "Game Over!\nDouble click on the chart to restart";
			}
		}

		private void c1Chart1_DoubleClick(object sender, System.EventArgs e)
		{
			if(ds1.Length == 0)
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

		private void menuOptionsShowLabels_Click(object sender, System.EventArgs e)
		{
			menuOptionsShowLabels.Checked = !menuOptionsShowLabels.Checked;
			showLabels( menuOptionsShowLabels.Checked);
		}
	}
}
