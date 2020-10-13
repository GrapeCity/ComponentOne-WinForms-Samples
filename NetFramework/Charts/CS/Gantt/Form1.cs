using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace Gantt
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.Size = new System.Drawing.Size(600, 400);
			this.c1Chart1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1});
			this.Name = "Form1";
			this.Text = "Gantt Sample";
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

		// Adds a new series to the Gantt chart accepting a task name,
		// an array of starting times and an array of ending times.
		private void AddGanttSeriesData(ChartDataSeriesCollection cdsc,
			string taskName, DateTime[] startTimes, DateTime[] endTimes)
		{
			ChartDataSeries cds = cdsc.AddNewSeries();
			cds.Label = taskName;
			cds.Y.CopyDataIn(startTimes);
			cds.Y1.CopyDataIn(endTimes);
		}

		// Add Chart Labels with beginning and ending dates for each data point
		// in the Gantt chart.  Labels are placed inside on the western edge.
		private void AddGanttTaskLabels(C1Chart chart, ChartDataSeriesCollection cdsc)
		{
			ChartLabels cl = chart.ChartLabels;
			cl.DefaultLabelStyle.BackColor = Color.Transparent;
			cl.DefaultLabelStyle.GradientStyle = GradientStyleEnum.None;
			cl.DefaultLabelStyle.ForeColor = Color.Azure;
			cl.DefaultLabelStyle.HorizontalAlignment = AlignHorzEnum.Far;

			C1.Win.C1Chart.LabelsCollection clc = cl.LabelsCollection;
			clc.Clear();

			int slen = cdsc.Count;
			for(int s = 0; s < cdsc.Count; s++)
			{
				ChartDataSeries cds = cdsc[s];
				for(int p=0; p < cds.Length; p++)
				{
					C1.Win.C1Chart.Label lab = clc.AddNewLabel();
					DateTime start = (DateTime)cds.Y[p];
					DateTime end = (DateTime)cds.Y1[p];
					lab.Text = start.ToString("ddMMM") + "-" + end.ToString("ddMMM");
					lab.AttachMethod = AttachMethodEnum.DataIndex;
					lab.AttachMethodData.GroupIndex = 0;
					lab.AttachMethodData.SeriesIndex = s;
					lab.AttachMethodData.PointIndex = p;
					lab.Compass = LabelCompassEnum.West;
					lab.Offset = 0;
					lab.Visible = true;
				}
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// simplify the chart reference.
			C1Chart chart = c1Chart1;

			// Adjust the chart element styles
			//   Chart style.
			chart.Style.BackColor = Color.Navy;
			chart.Style.BackColor2 = Color.Azure;
			chart.Style.GradientStyle = GradientStyleEnum.FromCenter;

			//   Chart Area style
			Area area = chart.ChartArea;
			area.Style.BackColor = Color.Transparent;
			area.Style.GradientStyle = GradientStyleEnum.None;
			area.Inverted = true;	// X axis is vertical

			//   Plot Area style
			area.PlotArea.BackColor = Color.Azure;
			area.PlotArea.Boxed = true;

			//   Set up the style and format of the Horizontal (Y) axis.
			Axis ax = area.AxisY;
			ax.AnnoFormat = FormatEnum.DateManual;
			ax.AnnoFormatString = "MMM-dd";
			ax.AnnotationRotation = -30;
			ax.Min = new DateTime(2004,1,1).ToOADate();
			ax.Max = new DateTime(2004,4,30).ToOADate();
			ax.Origin = ax.Min;
			ax.Font = new Font("ArialBlack", 10, FontStyle.Bold);
			ax.UnitMajor = 14;
			ax.TickMinor = TickMarksEnum.None;
			ax.GridMajor.Pattern = LinePatternEnum.Dash;
			ax.GridMajor.Color = Color.LightGray;
			ax.GridMajor.Visible = true;

			//   Set up the style and format of the Vertical (X) axis.
			ax = area.AxisX;
			ax.TickMinor = TickMarksEnum.None;
			ax.Reversed = true;		// top to bottom
			ax.UnitMajor = 1;
			ax.GridMinor.Pattern = LinePatternEnum.Dash;
			ax.GridMinor.Color = Color.LightGray;
			ax.GridMinor.Visible = true;
			ax.GridMajor.Pattern = LinePatternEnum.Solid;
			ax.GridMajor.Color = area.PlotArea.BackColor;
			ax.GridMajor.Visible = true;
			ax.Font = new Font("ArialBlack", 16, FontStyle.Bold);

			//   Specify the chart type as Gantt in the ChartGroup
			ChartGroup cg = chart.ChartGroups.Group0;
			cg.ChartType = Chart2DTypeEnum.Gantt;
			cg.Gantt.Width = 40 ;

			//   Clear the existing data and add new Series data.
			ChartDataSeriesCollection cdsc = cg.ChartData.SeriesList;
			cdsc.Clear();

			// create a new series for each "row" of the Gantt chart.
			// TASK ONE
			AddGanttSeriesData(cdsc, "Task One",
				new DateTime[]{new DateTime(2004,01,01)},
				new DateTime[]{new DateTime(2004,03,09)});

			// TASK TWO
			AddGanttSeriesData(cdsc, "Task Two",
				new DateTime[]{new DateTime(2004,01,23)},
				new DateTime[]{new DateTime(2004,02,14)});

			// TASK THREE
			AddGanttSeriesData(cdsc, "Task Three",
				new DateTime[]{new DateTime(2004,01,21)},
				new DateTime[]{new DateTime(2004,02,24)});

			// TASK FOUR
			AddGanttSeriesData(cdsc, "Task Four",
				new DateTime[]{new DateTime(2004,01,22), new DateTime(2004,02,28)},
				new DateTime[]{new DateTime(2004,02,12), new DateTime(2004,03,24)});

			// TASK FIVE
			AddGanttSeriesData(cdsc, "Task Five",
				new DateTime[]{new DateTime(2004,02,13), new DateTime(2004,03,08)},
				new DateTime[]{new DateTime(2004,03,05), new DateTime(2004,03,31)});

			// TASK SIX
			AddGanttSeriesData(cdsc, "Task Six",
				new DateTime[]{new DateTime(2004,03,15)},
				new DateTime[]{new DateTime(2004,04,20)});

			// TASK SEVEN
			AddGanttSeriesData(cdsc, "Task Seven",
				new DateTime[]{new DateTime(2004,04,06)},
				new DateTime[]{new DateTime(2004,04,30)});

			// Add task labels.
			AddGanttTaskLabels(chart, cdsc);
		}
	}
}
