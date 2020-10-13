using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    public partial class Histogram : C1DemoForm
    {
        public Histogram()
        {
            InitializeComponent();       
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            //setup the Chart with markers and Scatter data in the first ChartGroup.
            //setup a Histogram in the second ChartGroup, but do not add the data.
            ChartSetup();

            //create a Histogram in the second chart group using the scatter data
            //and the distance from the marker intersection as data for the histogram.
            SetupHistogram();

            //now set the actual histogram data based on the marker values.
            SetHistogramData();

            //turn on visual effects
            c1Chart1.VisualEffects["Default"].Enabled = true;
            c1Chart1.VisualEffects["Header"].Enabled = true;

            //add demo properties
            AddPropertyHeader("Scatter Series");
            AddProperty("Display", c1Chart1.ChartGroups[0].ChartData.SeriesList[0]);
            AddProperty("Visible", c1Chart1.ChartGroups[0].ChartData.SeriesList[0].DataLabel, "DataLabel.Visible");
            AddPropertyHeader("Histogram Series");
            AddProperty("DisplayType", c1Chart1.ChartGroups[1].ChartData.SeriesList[0].Histogram);
            AddProperty("Visible", c1Chart1.ChartGroups[1].Histogram.NormalDisplay, "NormalDisplay.Visible");
        }

        private void ChartSetup()
        {
            //reset the chart
            c1Chart1.Reset();
            
            //set the Chart appearance
            Style sty = c1Chart1.Style;
            Border b = sty.Border;
            b.BorderStyle = BorderStyleEnum.None;

            //plot area
            c1Chart1.ChartArea.PlotArea.BackColor = Color.White;
            c1Chart1.ChartArea.AxisX.Thickness = 1;
            c1Chart1.ChartArea.AxisY.Thickness = 1;
            c1Chart1.ChartArea.AxisY2.Thickness = 1;

            //turn on tooltips
            c1Chart1.ToolTip.Enabled = true;

            //generate scatter data and populate the chart.
            PointF[] scatter = GenerateScatterData(100, 100f, 75f);

            //plot the data in the first ChartGroup.  For scatter data, turn off the lines.
            ChartDataSeries cds = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
            cds.LineStyle.Pattern = LinePatternEnum.None;
            cds.SymbolStyle.Size = 2;
            cds.PointData.CopyDataIn(scatter);
            cds.TooltipText = "({#XVAL:0.00},{#YVAL:0.00})";

            //force the chart to scale the axes right now.
            c1Chart1.GetImage();

            //automatically label each of the points by its PointIndex.
            cds.DataLabel.Compass = LabelCompassEnum.Auto;
            cds.DataLabel.Offset = 5;
            cds.DataLabel.Connected = true;
            cds.DataLabel.Text = "{#IPOINT}";
            cds.DataLabel.Visible = true;

            //provide Header for description
            Title t = c1Chart1.Header;
            t.Style.Font = new Font("Tahoma", 14);
            t.Text = "Histogram/Frequency Data Measuring Distance from Crosshairs to Scatter data.";

            //provide Footer for instructions
            t = c1Chart1.Footer;
            Font f = new Font("Tahoma", 12);
            t.AppendRtfText("Drag the ", f);
            t.AppendRtfText("Arrows", Color.FromArgb(255, 82, 24), f);
            t.AppendRtfText(" to move the crosshairs", Color.Black, f, HorizontalAlignment.Center);

            //switch over the axes to mixed label mode and add some centered
            //markers to form a target.
            Area carea = c1Chart1.ChartArea;
            double xMarker = AddChartAxisMarker(carea.AxisX);
            double yMarker = AddChartAxisMarker(carea.AxisY);

            //set the Axis Titles.
            carea.AxisX.Text = "Scatter data X values / Distances from crosshair";
            carea.AxisY.Text = "Scatter data Y values";
            carea.AxisY2.Text = "Count of data at distance from crosshair";
        }

        private void SetupHistogram()
        {
            //create a Histogram in the second chart group using the scatter data
            //and the distance from the marker intersection as data for the histogram.
            ChartGroup cg = c1Chart1.ChartGroups[1];

            //start by adding a Normal (Gaussian) distribution curve.  This is available
            //as a convenient reference to compare the histogram shape.
            NormalCurve nc = cg.Histogram.NormalDisplay;
            nc.FillStyle.Alpha = 64;
            nc.FillStyle.Color1 = Color.Yellow;
            nc.Visible = c1Chart1.ChartGroups[1].Histogram.NormalDisplay.Visible;

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
            if (carea.AxisX.ValueLabels[0] != null)
            {
                //get the Target Coordinates
                double xtarget = carea.AxisX.ValueLabels[0].NumericValue;
                double ytarget = carea.AxisY.ValueLabels[0].NumericValue;

                //get the data point coordinates from the chart.
                ChartDataSeries cds = c1Chart1.ChartGroups[0].ChartData.SeriesList[0];
                PointF[] cdata = (PointF[])cds.PointData.CopyDataOut();

                //find the distance from each scatter point to the target point.
                int n = cdata.Length;
                double[] distances = (double[])Array.CreateInstance(typeof(double), n);
                for (int i = 0; i < n; i++)
                {
                    double dx = cdata[i].X - xtarget;
                    double dy = cdata[i].Y - ytarget;
                    distances[i] = Math.Sqrt(dx * dx + dy * dy);
                }

                //add the data to the Histogram chart series in ChartGroup(1).
                cds = c1Chart1.ChartGroups[1].ChartData.SeriesList[0];
                cds.Y.CopyDataIn(distances);

                //report the statistics of the distance data.
                lblStats.Text = "Distance Statistics: " +
                    "  Mean: " + cds.Y.Statistics.Mean.ToString("0.000") +
                    "  Median: " + cds.Y.Statistics.Median.ToString("0.000") +
                    "  StdDev: " + cds.Y.Statistics.StdDev.ToString("0.000");

                //set the overflow label.
                int overflow = (int)cds.Histogram.AboveIntervalCount;
                string msg = "";
                if (overflow > 0)
                {
                    msg = "Number > " + carea.AxisX.Max.ToString() + " = " + overflow.ToString();
                }
                c1Chart1.ChartLabels["overflow"].Text = msg;
            }
        }

        private PointF[] GenerateScatterData(int NumberOfPoints, float xscale, float yscale)
        {
            Random rnd = new Random();
            PointF[] result = (PointF[])Array.CreateInstance(typeof(PointF), NumberOfPoints);
            for (int i = 0; i < NumberOfPoints; i++)
            {
                float x = (float)(xscale * rnd.NextDouble());
                float y = (float)(yscale * rnd.NextDouble());
                result[i] = new PointF(x, y);
            }
            return result;
        }

        private double AddChartAxisMarker(Axis ax)
        {
            //set the annotation method to Mixed so both automatic
            //values annotation AND ValueLabels can be used concurrently.
            ax.AnnoMethod = AnnotationMethodEnum.Mixed;

            //set the GridMajor line pattern to solid. This will be
            //used for the ValueLabel Gridline draw.
            ax.GridMajor.Pattern = LinePatternEnum.Solid;
            ax.OnTop = true;

            //a convenient value for the axes units.
            ax.UnitMajor = 10;

            //create the ValueLabel.  Use an arrow, and make it big
            //and red so it cannot be missed.
            ValueLabel vl = ax.ValueLabels.AddNewLabel();
            vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker;
            vl.GridLine = true;
            vl.Moveable = true;
            vl.MarkerSize = 20;
            vl.Color = Color.FromArgb(255, 82, 24);

            //put it in the middle of the axis.  For this to work
            //the chart must have been drawn so the axis is properly
            //scaled.  A prior GetImage() will do this.
            vl.NumericValue = 50;

            //set the event so the data can be recalculated
            //each time the marker is moved.
            vl.ValueChanged += new EventHandler(MarkerMoved);

            //return the numeric location.
            return vl.NumericValue;
        }

        private void MarkerMoved(object sender, EventArgs e)
        {
            SetHistogramData();
        }

    }
}
