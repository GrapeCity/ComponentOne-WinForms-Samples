using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;
using System.Diagnostics;

namespace HistogramSpace
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radHistogram;
		private System.Windows.Forms.RadioButton radFreq;
		private System.Windows.Forms.RadioButton radStepFreq;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.CheckBox chkShowNormal;
		private System.Windows.Forms.TextBox txtDistanceStats;
		private System.Windows.Forms.CheckBox chkHideData;
		private System.Windows.Forms.CheckBox chkHideLabels;
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radStepFreq = new System.Windows.Forms.RadioButton();
			this.radFreq = new System.Windows.Forms.RadioButton();
			this.radHistogram = new System.Windows.Forms.RadioButton();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.chkShowNormal = new System.Windows.Forms.CheckBox();
			this.txtDistanceStats = new System.Windows.Forms.TextBox();
			this.chkHideData = new System.Windows.Forms.CheckBox();
			this.chkHideLabels = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Location = new System.Drawing.Point(176, 5);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;AlignV" +
				"ert=Top;\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><NamedStyl" +
				"e Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;Ali" +
				"gnVert=Center;\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"Bord" +
				"er=None,Transparent,1;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleDa" +
				"ta=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.d" +
				"efault\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle Name=\"" +
				"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"La" +
				"belStyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent" +
				",1;BackColor=Transparent;\" /><NamedStyle Name=\"PlotArea\" ParentName=\"Area\" Style" +
				"Data=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Control.default\" ParentNam" +
				"e=\"\" StyleData=\"ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" +
				"l;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Border=N" +
				"one,Transparent,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"AxisY\" ParentNa" +
				"me=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><Nam" +
				"edStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Cen" +
				"ter;AlignVert=Bottom;\" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" +
				"me=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeriesS" +
				"erializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"B" +
				"ox\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" +
				"Style Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><Seri" +
				"esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" +
				"gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" +
				"le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" +
				"\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2<" +
				"/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" +
				"e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " +
				"/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><S" +
				"ymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel>" +
				"<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" +
				"le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" +
				"sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" +
				"illStyle Color1=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup><ChartG" +
				"roup Name=\"Group2\"><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" +
				"=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" +
				"n><Header Compass=\"North\" /><Footer Compass=\"South\" /><Legend Compass=\"East\" Vis" +
				"ible=\"False\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"S" +
				"outh\"><GridMajor /><GridMinor /></Axis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" Unit" +
				"Minor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compas" +
				"s=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Comp" +
				"ass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(448, 443);
			this.c1Chart1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radStepFreq,
																					this.radFreq,
																					this.radHistogram});
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 72);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// radStepFreq
			// 
			this.radStepFreq.Location = new System.Drawing.Point(8, 48);
			this.radStepFreq.Name = "radStepFreq";
			this.radStepFreq.Size = new System.Drawing.Size(128, 16);
			this.radStepFreq.TabIndex = 2;
			this.radStepFreq.Text = "Stepped Frequency";
			this.radStepFreq.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
			// 
			// radFreq
			// 
			this.radFreq.Location = new System.Drawing.Point(8, 32);
			this.radFreq.Name = "radFreq";
			this.radFreq.Size = new System.Drawing.Size(96, 16);
			this.radFreq.TabIndex = 1;
			this.radFreq.Text = "Frequency";
			this.radFreq.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
			// 
			// radHistogram
			// 
			this.radHistogram.Checked = true;
			this.radHistogram.Location = new System.Drawing.Point(8, 16);
			this.radHistogram.Name = "radHistogram";
			this.radHistogram.Size = new System.Drawing.Size(96, 16);
			this.radHistogram.TabIndex = 0;
			this.radHistogram.TabStop = true;
			this.radHistogram.Text = "Histogram";
			this.radHistogram.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(8, 232);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(160, 216);
			this.txtDescription.TabIndex = 2;
			this.txtDescription.Text = "";
			// 
			// chkShowNormal
			// 
			this.chkShowNormal.Location = new System.Drawing.Point(16, 80);
			this.chkShowNormal.Name = "chkShowNormal";
			this.chkShowNormal.Size = new System.Drawing.Size(128, 16);
			this.chkShowNormal.TabIndex = 3;
			this.chkShowNormal.Text = "Show Normal Curve";
			this.chkShowNormal.CheckedChanged += new System.EventHandler(this.chkShowNormal_CheckedChanged);
			// 
			// txtDistanceStats
			// 
			this.txtDistanceStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDistanceStats.Location = new System.Drawing.Point(8, 152);
			this.txtDistanceStats.Multiline = true;
			this.txtDistanceStats.Name = "txtDistanceStats";
			this.txtDistanceStats.ReadOnly = true;
			this.txtDistanceStats.Size = new System.Drawing.Size(160, 72);
			this.txtDistanceStats.TabIndex = 4;
			this.txtDistanceStats.Text = "Distance Statistics";
			// 
			// chkHideData
			// 
			this.chkHideData.Location = new System.Drawing.Point(16, 104);
			this.chkHideData.Name = "chkHideData";
			this.chkHideData.Size = new System.Drawing.Size(128, 16);
			this.chkHideData.TabIndex = 5;
			this.chkHideData.Text = "Hide Raw Data";
			this.chkHideData.CheckedChanged += new System.EventHandler(this.chkHideData_CheckedChanged);
			// 
			// chkHideLabels
			// 
			this.chkHideLabels.Location = new System.Drawing.Point(16, 128);
			this.chkHideLabels.Name = "chkHideLabels";
			this.chkHideLabels.Size = new System.Drawing.Size(128, 16);
			this.chkHideLabels.TabIndex = 6;
			this.chkHideLabels.Text = "Hide Data Labels";
			this.chkHideLabels.CheckedChanged += new System.EventHandler(this.chkHideLabels_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.chkHideLabels,
																		  this.chkHideData,
																		  this.txtDistanceStats,
																		  this.txtDescription,
																		  this.groupBox1,
																		  this.c1Chart1,
																		  this.chkShowNormal});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
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

		private PointF [] GenerateScatterData(int NumberOfPoints, float xscale, float yscale)
		{
			Random rnd = new Random();
			PointF [] result = (PointF[])Array.CreateInstance(typeof(PointF), NumberOfPoints);
			for(int i=0; i < NumberOfPoints; i++)
			{
				float x = (float)(xscale * rnd.NextDouble());
				float y = (float)(yscale * rnd.NextDouble());
				result[i] = new PointF(x, y);
			}
			return result;
		}

		private double AddChartAxisMarker(Axis ax)
		{
			// Set the annotation method to Mixed so both automatic
			// Values annotation AND ValueLabels can be used concurrently.
			ax.AnnoMethod = AnnotationMethodEnum.Mixed;

			// Set the GridMajor line pattern to solid.  This will be
			// used for the ValueLabel Gridline draw.
			ax.GridMajor.Pattern = LinePatternEnum.Solid;
			ax.OnTop = true;

			// A convenient value for the axes units.
			ax.UnitMajor = 10;

			// Create the ValueLabel.  Use an arrow, and make it big
			// and red so it cannot be missed.
			ValueLabel vl = ax.ValueLabels.AddNewLabel();
			vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker;
			vl.GridLine = true;
			vl.Moveable = true;
			vl.MarkerSize = 20;
			vl.Color = Color.Red;

			// Put it in the middle of the axis.  For this to work
			// the chart must have been drawn so the axis is properly
			// scaled.  A prior GetImage() will do this.
			vl.NumericValue = (ax.Max - ax.Min) / 2;

			// Set the event so the data can be recalculated
			// each time the marker is moved.
			vl.ValueChanged += new EventHandler(MarkerMoved);	//!!VBSubst AddHandler vl.ValueChanged, AddressOf MarkerMoved

			// return the numeric location.
			return vl.NumericValue;
		}

		private void MarkerMoved(object sender, EventArgs e)
		{
			SetHistogramData();
		}

		private void ChartSetup()
		{
			// Reset the chart, position it, and appropriately anchor
			c1Chart1.Reset();
			c1Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;	//!!VBPassThru

			// Setup the Chart appearance
			Style sty = c1Chart1.Style;
			sty.BackColor = Color.FromKnownColor(KnownColor.Window);

			// The Chart border
			Border b = sty.Border;
			b.BorderStyle = BorderStyleEnum.Solid;
			b.Rounding.All = 10;
			b.Thickness = 3;
			b.Color = Color.Black;
			
			// Turn on tooltips
			c1Chart1.ToolTip.Enabled = true;

			// Generate scatter data and populate the chart.
			PointF [] scatter = GenerateScatterData(100, 100f, 75f);

			// Plot the data in the first ChartGroup.  For scatter data, turn off the lines.
			ChartDataSeries cds = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			cds.LineStyle.Pattern = LinePatternEnum.None;
			cds.PointData.CopyDataIn(scatter);
			cds.TooltipText = "({#XVAL:0.00},{#YVAL:0.00})";

			// Force the chart to scale the axes right now.
			c1Chart1.GetImage();

			// Automatically label each of the points by its PointIndex.
			cds.DataLabel.Compass = LabelCompassEnum.Auto;
			cds.DataLabel.Offset = 4;
			cds.DataLabel.Connected = true;
			cds.DataLabel.Text = "{#IPOINT}";
			cds.DataLabel.Visible = true;

			// Provide Header for description
			Title t = c1Chart1.Header;
			t.Style.Font = new Font("Tahoma", 14);
			t.Text = "Histogram/Frequency Data Measuring Distance from Crosshairs to Scatter data.";
			
			// Provide Footer for instructions
			t = c1Chart1.Footer;
			Font f = new Font("Tahoma", 12);
			t.AppendRtfText("Drag the ", f);
			t.AppendRtfText("Red", Color.Red, f);
			t.AppendRtfText(" arrows to move the crosshairs", Color.Black, f, HorizontalAlignment.Center);

			// Switch over the axes to mixed label mode and add some centered
			// markers to form a target.
			Area carea = c1Chart1.ChartArea;
			double xMarker = AddChartAxisMarker(carea.AxisX);
			double yMarker = AddChartAxisMarker(carea.AxisY);

			// Set the Axis Titles.
			carea.AxisX.Text = "Scatter data X values / Distances from crosshair";
			carea.AxisY.Text = "Scatter data Y values";
			carea.AxisY2.Text = "Count of data at distance from crosshair";

		}

		private void SetupHistogram()
		{
			// Create a Histogram in the second chart group using the scatter data
			// and the distance from the marker intersection as data for the histogram.
			ChartGroup cg = c1Chart1.ChartGroups[1];

			// Start by adding a Normal (Gaussian) distribution curve.  This is available
			// as a convenient reference to compare the histogram shape.
			NormalCurve nc = cg.Histogram.NormalDisplay;
			nc.FillStyle.Alpha = 64;
			nc.FillStyle.Color1 = Color.Yellow;
			nc.Visible = chkShowNormal.Checked;

			cg.ChartType = Chart2DTypeEnum.Histogram;
			
			ChartDataSeries cds = cg.ChartData.SeriesList.AddNewSeries();
			cds.FitType = FitTypeEnum.Spline;
			cds.FillStyle.Alpha = 64;
			cds.FillStyle.Color1 = Color.Blue;

			cds.Histogram.IntervalCreationMethod = IntervalMethodEnum.SemiAutomatic;
			cds.Histogram.DisplayType = DisplayTypeEnum.Histogram;
			cds.Histogram.IntervalStart = 0;
			cds.Histogram.IntervalWidth = 10;
			cds.Histogram.IntervalNumber = 10;

			C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
			lab.AttachMethod = AttachMethodEnum.DataCoordinate;
			lab.AttachMethodData.X = 100;
			lab.AttachMethodData.Y = 0;
			lab.AttachMethodData.GroupIndex = 0;
			lab.Offset = 50;
			lab.Name = "overflow";
			lab.Text = "";
			lab.Compass = LabelCompassEnum.South;
			lab.Visible = true;
		}

		private void SetHistogramData()
		{
			Area carea = c1Chart1.ChartArea;
			if(carea.AxisX.ValueLabels[0] != null)
			{
				// get the Target Coordinates
				double xtarget = carea.AxisX.ValueLabels[0].NumericValue;
				double ytarget = carea.AxisY.ValueLabels[0].NumericValue;

				// get the data point coordinates from the chart.
				ChartDataSeries cds = c1Chart1.ChartGroups[0].ChartData.SeriesList[0];
				PointF[] cdata = (PointF[])cds.PointData.CopyDataOut();

				// find the distance from each scatter point to the target point.
				int n = cdata.Length;
				double[] distances = (double[])Array.CreateInstance(typeof(double), n);
				for(int i=0; i < n; i++)
				{
					double dx = cdata[i].X - xtarget;
					double dy = cdata[i].Y - ytarget;
					distances[i] = Math.Sqrt(dx*dx + dy*dy);
				}

				// add the data to the Histogram chart series in ChartGroup(1).
				cds = c1Chart1.ChartGroups[1].ChartData.SeriesList[0];
				cds.Y.CopyDataIn(distances);

				// report the statistics of the distance data.
				txtDistanceStats.Text = "Distance Statistics:\r\n" +
					"  Mean: " + cds.Y.Statistics.Mean.ToString("0.000") + "\r\n" +
					"  Median: " + cds.Y.Statistics.Median.ToString("0.000") + "\r\n" +
					"  StdDev: " + cds.Y.Statistics.StdDev.ToString("0.000");

				// set the overflow label.
				int overflow = (int)cds.Histogram.AboveIntervalCount;
				string msg = "";
				if(overflow > 0)
				{
					msg = "Number > " + carea.AxisX.Max.ToString() + " = " + overflow.ToString();
				}
				c1Chart1.ChartLabels["overflow"].Text = msg;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			txtDescription.Text = "Shown, is a combination chart with scatter data in ";
			txtDescription.Text += "Group0 and a Histogram in Group1.\r\n\r\n";
			txtDescription.Text += "The histogram shows the distribution of the distance (in data coordinates) ";
			txtDescription.Text += "from each of the scatter data points to the marker intersection (crosshairs).\r\n\r\n";
			txtDescription.Text += "The optional Normal Curve is unrelated to the data, and is provided ";
			txtDescription.Text += "for comparison of the histogram to the normal (Gaussian) distribution.  ";
			txtDescription.Text += "The curve always fills the PlotArea.";
			
			// Setup the Chart with markers and Scatter data in the first ChartGroup.
			// Setup a Histogram in the second ChartGroup, but do not add the data.
			ChartSetup();

			// Create a Histogram in the second chart group using the scatter data
			// and the distance from the marker intersection as data for the histogram.
			SetupHistogram();
			
			// now set the actual histogram data based on the marker values.
			SetHistogramData();
		}

		private void RadioCheckedChanged(object sender, System.EventArgs e)
		{
			if(c1Chart1.ChartGroups[1].ChartData.SeriesList.Count < 1)
				return;
			
			RadioButton rb = (RadioButton)sender;
			ChartHistogram ch = c1Chart1.ChartGroups[1].ChartData.SeriesList[0].Histogram;
			
			if(rb.Checked)
			{
				switch(rb.Text)
				{
					case "Histogram":
						ch.DisplayType = DisplayTypeEnum.Histogram;
						break;

					case "Frequency":
						ch.DisplayType = DisplayTypeEnum.FrequencyGraph;
						break;

					case "Stepped Frequency":
						ch.DisplayType = DisplayTypeEnum.SteppedFrequencyGraph;
						break;
				}
			}
		}

		private void chkShowNormal_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[1].Histogram.NormalDisplay.Visible = chkShowNormal.Checked;
		}

		private void chkHideData_CheckedChanged(object sender, System.EventArgs e)
		{
			SeriesDisplayEnum sde;
			if(chkHideData.Checked)
				sde = SeriesDisplayEnum.Hide;
			else
				sde = SeriesDisplayEnum.Show;

			c1Chart1.ChartGroups[0].ChartData.SeriesList[0].Display = sde;
		}

		private void chkHideLabels_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[0].ChartData.SeriesList[0].DataLabel.Visible = !chkHideLabels.Checked;			
		}
	}
}
