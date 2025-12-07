using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace Box
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.GroupBox grpInputs;
		private System.Windows.Forms.Label lblPointCount;
		private System.Windows.Forms.TextBox txtPointCount;
		private System.Windows.Forms.Button buttonGenerate;
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
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.grpInputs = new System.Windows.Forms.GroupBox();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.txtPointCount = new System.Windows.Forms.TextBox();
			this.lblPointCount = new System.Windows.Forms.Label();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.grpInputs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
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
			// menuHelp
			// 
			this.menuHelp.Index = 1;
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
			// grpInputs
			// 
			this.grpInputs.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.buttonGenerate,
																					this.txtPointCount,
																					this.lblPointCount});
			this.grpInputs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpInputs.Name = "grpInputs";
			this.grpInputs.Size = new System.Drawing.Size(328, 48);
			this.grpInputs.TabIndex = 0;
			this.grpInputs.TabStop = false;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(208, 16);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(104, 24);
			this.buttonGenerate.TabIndex = 2;
			this.buttonGenerate.Text = "Regenerate Data";
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// txtPointCount
			// 
			this.txtPointCount.Location = new System.Drawing.Point(128, 16);
			this.txtPointCount.Name = "txtPointCount";
			this.txtPointCount.Size = new System.Drawing.Size(32, 20);
			this.txtPointCount.TabIndex = 1;
			this.txtPointCount.Text = "5";
			this.txtPointCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPointCount_KeyPress);
			// 
			// lblPointCount
			// 
			this.lblPointCount.Location = new System.Drawing.Point(8, 18);
			this.lblPointCount.Name = "lblPointCount";
			this.lblPointCount.Size = new System.Drawing.Size(120, 16);
			this.lblPointCount.TabIndex = 0;
			this.lblPointCount.Text = "Number of data points:";
			// 
			// c1Chart1
			// 
			this.c1Chart1.Location = new System.Drawing.Point(8, 56);
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
				"1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default" +
				"</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Name><ParentNa" +
				"me>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>AxisX" +
				"</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Cont" +
				"rol,1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData></Name" +
				"dStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rot" +
				"ation=Rotate270;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Align" +
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
				"gnVert=Top;</StyleData></NamedStyle></StyleCollection><Footer Compass=\"South\"><T" +
				"ext /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartAre" +
				"a /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(488, 312);
			this.c1Chart1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 381);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.grpInputs});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Box and Whisker Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpInputs.ResumeLayout(false);
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

		private void txtPointCount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// only allow numbers to be entered.
			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
				return;

			e.Handled = true;		
		}

		private void buttonGenerate_Click(object sender, System.EventArgs e)
		{
			this.GenerateSomeData();
			this.LoadChartData();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// center the form
			this.CenterToParent();

			// setup the chart.
			c1Chart1.Top = grpInputs.Bottom + 1;
			c1Chart1.Left = 0;
			c1Chart1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height-c1Chart1.Top);
			c1Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  //!!VBPassThru

			c1Chart1.Style.BackColor = Color.LightGray;
			c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.Groove;
			c1Chart1.Style.Border.Thickness = 2;

			// setup the area
			Area area = c1Chart1.ChartArea;
			area.Style.BackColor = Color.Wheat;
			area.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel;
			area.Style.Border.Thickness = 4;
			area.PlotArea.BackColor = Color.BlanchedAlmond;
			area.PlotArea.Boxed = true;
			area.Inverted = true;

			// setup the header
			Title hdr = c1Chart1.Header;
			hdr.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel;
			hdr.Style.Border.Thickness = 4;
			hdr.Text = "Box-and-Whisker Plot";
			hdr.Style.Font = new Font("Arial", 14);

			// setup the groups
			c1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.Candle;
			c1Chart1.ChartGroups[1].ChartType = Chart2DTypeEnum.XYPlot;

			// fix the bounds of the Y and Y2 axes, always 0 to 100
			area.AxisY.Min = 0f;
			area.AxisY.Max = 100f;
			area.AxisY2.Min = 0f;
			area.AxisY2.Max = 100f;
			area.AxisY2.Visible = false;

			GenerateSomeData();
			LoadChartData();
		}


		// use an array of arrays so each sub array can be sorted
		//   float [5 values per point] [# of points] ChartValues  (reduced data)
		float [][] ChartValues = null;

		private int NumberOfPoints()
		{
			try { return int.Parse(txtPointCount.Text);}
			catch { return 0; }
		}

		private void GenerateSomeData()
		{
			int i=0, n=0;

			// use an array of arrays so each sub array can be sorted
			//   float [# of points] [15 values per point] DataSets     (raw data)
			const int valuesPerPoint = 15;
			float [][] DataSets = null;

			int nPoints = NumberOfPoints();
			if(nPoints == 0)
				return;

			// build the outer array.
			DataSets = (float[][])Array.CreateInstance(typeof(float[]), nPoints);

			// fill each element of the outer array with an inner array,
			// each with 15 elements containing random float data.  Sort each
			// inner array.
			for(n=0; n < nPoints; n++)
			{
				// for each element of the outer array
				Random r = new Random(DateTime.Now.Millisecond - n);

				float[] inner = (float[])Array.CreateInstance(typeof(float), valuesPerPoint);
				for(i=0; i < valuesPerPoint; i++)
					inner[i] = (float)(100.0 * r.NextDouble());

				Array.Sort(inner);
				DataSets[n] = inner;
			}


			// now create the reduced data, which includes high, low, median and
			// upper and lower quartiles for each inner array (data point).
			ChartValues = (float[][])Array.CreateInstance(typeof(float[]), 5);
			for(i=0; i < 5; i++)
				ChartValues[i] = (float[])Array.CreateInstance(typeof(float),nPoints);

			// fill all the array elements.  note that the inner arrays contain
			// lows, highs, median, lower quartile and upper quartile, respectively.
			// This allows each array to be copied into the chart at once.
			for(n=0; n < nPoints; n++)
			{
				ChartValues[0][n] = DataSets[n][0];					// lowest values
				ChartValues[1][n] = DataSets[n][valuesPerPoint-1];	// highest values
				ChartValues[2][n] = DataSets[n][8];					// median values
				ChartValues[3][n] = DataSets[n][4];					// lower quartiles
				ChartValues[4][n] = DataSets[n][12];				// upper quartiles
			}
		}

		private void LoadChartData()
		{
			int n=0;
			int nPoints = NumberOfPoints();

			// the first chart group will handle the "candle" part of Box and Whisker
			ChartGroup grp0 = c1Chart1.ChartGroups[0];
			grp0.ChartData.SeriesList.Clear();

			// the second group will handle the remaining elements of the Box and Whisker
			ChartGroup grp1 = c1Chart1.ChartGroups[1];
			grp1.ChartData.SeriesList.Clear();

			if(nPoints == 0)
				return;

			// all the x values are the same, and for convenience simply
			// indicate the number of the data points.
			int [] xvals = (int[])Array.CreateInstance(typeof(int), nPoints);
			for(n=0; n < nPoints; n++)
				xvals[n] = n+1;

			ChartDataSeries cds = grp0.ChartData.SeriesList.AddNewSeries();
			cds.X.CopyDataIn(xvals);
			cds.Y.CopyDataIn(ChartValues[1]);		// high values
			cds.Y1.CopyDataIn(ChartValues[0]);		// low values
			cds.Y2.CopyDataIn(ChartValues[3]);		// open values	(lower quartile)
			cds.Y3.CopyDataIn(ChartValues[4]);		// close values are high, making candle hollow
			cds.SymbolStyle.Size = 16;
			cds.LineStyle.Color = Color.Purple;
			cds.LineStyle.Thickness = 2;

			// now plot the Low, High and Median values in the
			// second chart group.  Use consistent symbols and color, no lines.
			cds = grp1.ChartData.SeriesList.AddNewSeries();
			cds.X.CopyDataIn(xvals);
			cds.Y.CopyDataIn(ChartValues[0]);
			cds.LineStyle.Pattern = LinePatternEnum.None;
			cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine;
			cds.SymbolStyle.Size = 16;
			cds.SymbolStyle.Color = Color.Purple;

			cds = grp1.ChartData.SeriesList.AddNewSeries();
			cds.X.CopyDataIn(xvals);
			cds.Y.CopyDataIn(ChartValues[1]);
			cds.LineStyle.Pattern = LinePatternEnum.None;
			cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine;
			cds.SymbolStyle.Size = 16;
			cds.SymbolStyle.Color = Color.Purple;

			cds = grp1.ChartData.SeriesList.AddNewSeries();
			cds.X.CopyDataIn(xvals);
			cds.Y.CopyDataIn(ChartValues[2]);
			cds.LineStyle.Pattern = LinePatternEnum.None;
			cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine;
			cds.SymbolStyle.Size = 16;
			cds.SymbolStyle.Color = Color.Purple;
		}
	}
}
