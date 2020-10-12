using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace LogPlots
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.BackColor = Color.LightBlue;
			
			c1Chart1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Populate the Logarithmic Base combo box.	 Note that the base value
			// is the base of the log used for both axes.  It can be any double value
			// greater than zero.  "e" is interpreted as the "natural" algorithm.
			string [] strItems = new string[] { "e", "2", "3", "5", "7.5", "10", "16" };
			comboBoxLogBase.Items.AddRange(strItems);
			comboBoxLogBase.SelectedIndex = comboBoxLogBase.FindStringExact("10");

			// Populate the chart with some Power Series values as these
			// readily show logarithmic behavior.
			const int pointCount = 10;
			int[] baseValues = new int[] { 2, 4, 5, 10};

			ChartDataSeriesCollection cdsc = c1Chart1.ChartGroups.Group0.ChartData.SeriesList;
			cdsc.RemoveAll();

			for(int bi=0; bi < baseValues.Length; bi++)
			{
				int baseValue = baseValues[bi];

				// create the Power Series data array
				PointF[] points = new PointF[pointCount];
				for (int i = 1; i < pointCount; i++)
				{
					points[i].X = i;
					points[i].Y = (float)Math.Pow(baseValue, i);
				}

				// Create and add a new ChartDataSeries and copy in the data array.
				ChartDataSeries cds = cdsc.AddNewSeries();
				cds.PointData.CopyDataIn(points);
				cds.Label = "y = Math.Pow(" + baseValue.ToString() + ",x)";

				// Create a Chart Label to indicate the equation used to generate the data
				// and attach it to the series appropriately.
				C1.Win.C1Chart.ChartLabels clabs = c1Chart1.ChartLabels;
				clabs.AutoArrangement.Method = AutoLabelArrangementMethodEnum.FindingOptimum;

				C1.Win.C1Chart.Label lab = clabs.LabelsCollection.AddNewLabel();
				lab.Text = cds.Label;
				lab.AttachMethod = AttachMethodEnum.DataIndex;
				lab.AttachMethodData.GroupIndex = 0;
				lab.AttachMethodData.PointIndex = pointCount / 2 + bi;
				lab.AttachMethodData.SeriesIndex = bi;
				lab.Connected = true;
				lab.Compass = LabelCompassEnum.Auto;
				lab.Style.Border.BorderStyle = BorderStyleEnum.Solid;
				lab.Visible = true;
			}

			// set the initial Logarithmic base values for the X and Y axes.
			Area area = c1Chart1.ChartArea;
			area.AxisX.LogarithmicBase = 10;
			area.AxisX.Thickness = 1;
			area.AxisY.LogarithmicBase = 10;
			area.AxisY.Thickness = 1;

			// call the check box handler to set axes values appropriate for
			// log or non-log axes.
			checkLOG_CheckedChanged(checkXLOG, null);
			checkLOG_CheckedChanged(checkYLOG, null);

			// Add some cosmetic attributes
			Style style = c1Chart1.Style;
			style.BackColor = Color.DarkRed;
			style.BackColor2 = Color.OrangeRed;
			style.GradientStyle = GradientStyleEnum.DiagonalCenter;
			style.Border.Rounding.All = 20;

			style = c1Chart1.ChartArea.Style;
			style.BackColor = Color.White;
			style.GradientStyle = GradientStyleEnum.None;
		}

		private void checkLOG_CheckedChanged(object sender, EventArgs e)
		{
			// determine which checkbox is firing this event handler
			// and operate on the appropriate chart axis.
			bool useYAxis = sender.Equals(checkYLOG);

			Axis ax = useYAxis ? c1Chart1.ChartArea.AxisY : c1Chart1.ChartArea.AxisX;
			ax.IsLogarithmic = ((CheckBox)sender).Checked;

			// Because the Y axis values may be extreme, use special formatting
			// typical of Log axes in chart.
			if (useYAxis)
			{
				if (ax.IsLogarithmic)
				{
					ax.AnnoFormat = FormatEnum.NumericManual;
					if(ax.LogarithmicBase <= 0)
						ax.AnnoFormatString = ""; //"e**{0}" default for manual, no text
					else
						ax.AnnoFormatString = ax.LogarithmicBase.ToString() + "**{0}";
				}
				else
				{
					ax.AnnoFormat = FormatEnum.NumericGeneral;
				}
			}
		}

		private void comboBoxLogBase_SelectedIndexChanged(object sender, EventArgs e)
		{
			string slogbase = comboBoxLogBase.SelectedItem as string;
			double logbase = 0;

			if (slogbase == "e")
				logbase = 0;
			else
				logbase = double.Parse(slogbase);
			
			Area area = c1Chart1.ChartArea;
			area.AxisX.LogarithmicBase = logbase;
			area.AxisY.LogarithmicBase = logbase;

			// update the formats using the new log base
			checkLOG_CheckedChanged(checkXLOG, null);
			checkLOG_CheckedChanged(checkYLOG, null);
		}
	}
}