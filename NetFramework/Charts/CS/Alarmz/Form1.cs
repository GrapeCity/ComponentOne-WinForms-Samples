using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace Alarmz
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Location = new System.Drawing.Point(16, 16);
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
			this.c1Chart1.Size = new System.Drawing.Size(552, 288);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.Resize += new System.EventHandler(this.c1Chart1_Resize);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1});
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Alarm Zone Chart Demo";
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
			// Size the form to fit any screen
			this.ClientSize = new Size(600, 400);

			// Center the form
			this.CenterToParent();

			// Fill the form client area with the chart
			c1Chart1.Dock = DockStyle.Fill;

			// Get the data arrays and data.
			int[] StudentScores = this.GetStudentPointTotals();
			int[] StudentNumbers = (int[])Array.CreateInstance(typeof(int), StudentScores.Length);
			int nStudents = StudentScores.Length;
			int i;
			for(i=0; i < nStudents; i++)
				StudentNumbers[i] = i;

			// Get the statistics
			double mean = FindMean(StudentScores);
			double stddev = FindStdDev(StudentScores, mean);

			// Set up the header
			c1Chart1.Header.Text = "Student Scores and Grades";
			c1Chart1.Header.Style.Font = new Font("Tahoma",18,FontStyle.Bold);

			// Set the background color
			c1Chart1.Style.BackColor = Color.FromArgb(128,192,150);

			// Clear the existing data
			c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();

			// Add the data
			ChartData data = c1Chart1.ChartGroups[0].ChartData;
			ChartDataSeriesCollection series = data.SeriesList;

			//plot the student scores
			ChartDataSeries StuSeries = series.AddNewSeries();
			StuSeries.Label = "raw scores";
			StuSeries.LineStyle.Pattern = LinePatternEnum.None;
			StuSeries.LineStyle.Color = c1Chart1.Style.BackColor;
			StuSeries.SymbolStyle.Shape = SymbolShapeEnum.Star;
			StuSeries.SymbolStyle.Color = Color.DarkRed;
			StuSeries.X.CopyDataIn(StudentNumbers);
			StuSeries.Y.CopyDataIn(StudentScores);
			StuSeries = null;

			// mean + 2 s
			LinePatternEnum [] LinePatterns = new LinePatternEnum[]
				{
					LinePatternEnum.Dash, LinePatternEnum.DashDot,
					LinePatternEnum.Solid,
					LinePatternEnum.DashDotDot, LinePatternEnum.Dot
				};
			for(i=2; i >= -2 ; i--)
			{
				ChartDataSeries StatSeries = series.AddNewSeries();
				double [] xd = new double [] { 0, nStudents };
				double [] yd = new double [] { mean + i * stddev, mean + i * stddev};

				StatSeries.X.CopyDataIn(xd);
				StatSeries.Y.CopyDataIn(yd);
				StatSeries.SymbolStyle.Shape = SymbolShapeEnum.None;
				StatSeries.LineStyle.Pattern = LinePatterns[i+2];
				StatSeries.LineStyle.Color = Color.Black;
				StatSeries.LineStyle.Thickness = 1;

				if(i > 0)
					StatSeries.Label = "m+" + i.ToString() + "s";
				else if(i < 0)
					StatSeries.Label = "m" + i.ToString() + "s";
				else
				{
					StatSeries.Label = "mean";
					StatSeries.LineStyle.Thickness = 2;
					StatSeries.LineStyle.Pattern = LinePatternEnum.Solid;
				}
			}			

			// box the plot area
			c1Chart1.ChartArea.PlotArea.Boxed = true;

			// Show the legend
			c1Chart1.Legend.Visible = true;

			// Set the Axis titles
			c1Chart1.ChartArea.AxisX.Text = "Student Number";
			c1Chart1.ChartArea.AxisY.Text = "Student Accumulated Points";

			// sort the student scores so they can be analyzed		
			Array.Sort(StudentScores);

			// Define each of the letter grades
			string [] GradeLetter = new String[] { "A", "B", "C", "D", "F" };

			// Get the bounds of each letter grade
			// At most 95% of the students will not get an A
			// At most 75% of the students will not get a B or higher
			// At most 25% of the students will not get a C or higher
			// At most 5% of the students will not get a D or higher
			int [] GradeBounds = new int[]
			{
				StudentScores[GetBoundingIndex(StudentScores, 0.95)],
				StudentScores[GetBoundingIndex(StudentScores, 0.75)],
				StudentScores[GetBoundingIndex(StudentScores, 0.25)],
				StudentScores[GetBoundingIndex(StudentScores, 0.05)]
			};

			// get the color codes for each grade
			Color [] GradeColor = new Color[]
			{
				Color.FromArgb(128, 128, 225), Color.FromArgb(128, 255, 128),
				Color.FromArgb(255, 228, 128), Color.FromArgb(55, 228, 228),
				Color.FromArgb(255, 192, 192)
			};

			// Add the chart labels.  They will be positioned later
			ChartLabels labels = c1Chart1.ChartLabels;
			labels.DefaultLabelStyle.BackColor = c1Chart1.Style.BackColor;
			labels.DefaultLabelStyle.Font = new Font("Courier New", 16, FontStyle.Bold);

			C1.Win.C1Chart.Label lab = null;
			for(i=0; i < 5; i++)
			{
				lab = labels.LabelsCollection.AddNewLabel();
				lab.Text = GradeLetter[i];
				lab.Style.BackColor = GradeColor[i];
				lab.AttachMethod = AttachMethodEnum.Coordinate;
				lab.Visible = true;
			}

			// Below are calculations and settings that depend upon auto
			// positioning of the chart.  The auto positions are only
			// calculated during rendering of the chart.  Force the
			// chart to be rendered so the chart element positions are
			// calculated.

			// Force calculation of chart element positions
			c1Chart1.GetImage();

			// Add and show the alarm zones
			AlarmZonesCollection zones = c1Chart1.ChartArea.PlotArea.AlarmZones;
			for(i=0; i < 5; i++)
			{
				AlarmZone zone = zones.AddNewZone();

				zone.Name = GradeLetter[i];
				zone.BackColor = GradeColor[i];

				if(i==0)
					zone.UpperExtent = c1Chart1.ChartArea.AxisY.Max;
				else
					zone.UpperExtent = zones[i-1].LowerExtent;

				if(i==4)
					zone.LowerExtent = c1Chart1.ChartArea.AxisY.Min;
				else
					zone.LowerExtent = GradeBounds[i];

				zone.Visible = true;
			}

			PositionLegends();
		}
		private void PositionLegends()
		{
			// reposition the legend and labels
			C1.Win.C1Chart.ChartLabels labels = c1Chart1.ChartLabels;
			if(labels == null || labels.LabelsCollection.Count < 5)
				return;

			c1Chart1.GetImage();

			PlotArea plota = c1Chart1.ChartArea.PlotArea;
			Legend leg = c1Chart1.Legend;

			// get left alignment with the legend, and
			// center about the plot area centerline
			Point labP = leg.Location;
			labP.Y = plota.Location.Y + plota.Size.Height/2;

			// get the height of the labels and legend
			int labHeight = labels[0].Size.Height;
			int h = labHeight * 5 + leg.Size.Height;
			labP.Y -= h / 2;
	
			for(int i=0; i < 5; i++)
			{
				C1.Win.C1Chart.Label lab = labels[i];
				lab.AttachMethodData.X = labP.X;
				lab.AttachMethodData.Y = labP.Y;
				labP.Y += labHeight;
			}

			leg.LocationDefault = new Point(-1,labP.Y);
		}

		private int[] GetStudentPointTotals()
		{
			//populates the array with ficticious student scores for the demo
			const int nStudents = 300;
			const int nMaxPoints = 1600;

			int [] scores = (int[])Array.CreateInstance(typeof(int), nStudents);
			System.Random rnd = new System.Random();
			for(int i = 0; i < nStudents; i++)
				scores[i] = nMaxPoints/2 + rnd.Next(nMaxPoints/2);
			return scores;
		}

		private double FindMean(int[] arr)
		{
			//calculates the mean of an all inclusive group of integers
			double sum = 0;
			for(int i = 0; i < arr.Length; i++)
				sum = sum + arr[i];
			return sum / arr.Length;
		}

		private double FindStdDev(int[] arr, double mean)
		{
			//calculates the standard deviation of an all inclusive group of integers
			double sum = 0;
			double temp = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				temp = arr[i] - mean;
				sum = sum + temp * temp;
			}
			return Math.Sqrt(sum / arr.Length);
		}

		private int GetBoundingIndex(int [] scores, double frac)
		{
			// Assumes scores are sorted, then obtains the
			// index of the first scores() element below
			// the specified percentile fraction
			int n = scores.Length;
			int i = (int)(n * frac);

			while(i > scores[0] && scores[i] == scores[i+1])
				i--;

			return i;
		}

		private void c1Chart1_Resize(object sender, System.EventArgs e)
		{
			this.PositionLegends();
		}
	}
}
