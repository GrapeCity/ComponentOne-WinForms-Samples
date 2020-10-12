using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    public partial class AlarmZones : C1DemoForm
    {
        Random rnd = new Random();
        int np = 100;
        double[] k;

        //define each of the zones
        string[] ZoneText = new String[] { "Toxic", "Unhealthy", "Healthy", "More Healthy", "Healthiest" };

        //get the color codes for each zone
        Color[] ZoneColor = new Color[]
			{
				Color.FromArgb(222, 34, 0), Color.FromArgb(251, 153, 4),
				Color.FromArgb(244, 201, 11), Color.FromArgb(51, 199, 1),
				Color.FromArgb(96, 149, 255)
			};

        //setup array of patterns
        HatchStyle[] patterns = new HatchStyle[]
            {
                HatchStyle.DiagonalBrick, HatchStyle.DottedGrid, HatchStyle.BackwardDiagonal, HatchStyle.ZigZag, HatchStyle.Wave
            };

        public AlarmZones()
        {
            InitializeComponent();
        }

        private void AlarmZones_Load(object sender, EventArgs e)
        {
            LoadData();
            SetUpChart();
            LoadZones();  
        }

        //generate random normal data
        private void LoadData()
        {
            ChartData cd = c1Chart1.ChartGroups[0].ChartData;
            ChartDataSeries ds;

            if (cd.SeriesList.Count != 1)
            {
                //create and setup data series
                cd.SeriesList.Clear();
                ds = cd.SeriesList.AddNewSeries();
                ds.LineStyle.Pattern = LinePatternEnum.None;
                ds.SymbolStyle.Color = Color.DarkBlue;
                ds.SymbolStyle.Shape = SymbolShapeEnum.Star;
                ds.SymbolStyle.Size = 5;
            }
            else
                ds = cd[0];

            double[] x = new double[np];
            double[] y = new double[np];

            int nk = 2;

            k = new Double[nk];

            int i;

            for (i = 0; i < k.Length; i++)
            {
                k[i] = 2 * rnd.NextDouble() - 1;

            }

            double[] rns = RandNormal(np);

            double xconst = 5;

            if (k[0] < 0)
                k[1] = -Math.Abs(k[1]);
            else
                k[1] = Math.Abs(k[1]);

            for (i = 0; i < np; i++)
            {
                x[i] = xconst * rnd.NextDouble();
                        y[i] = k[0] * Math.Exp(x[i] * k[1]);

                y[i] += rns[i] / 10; // add some random noise
            }

            // put data into chart
            ds.X.CopyDataIn(x);
            ds.Y.CopyDataIn(y);

            // reset axes limits
            c1Chart1.ChartArea.AxisX.AutoMax = true;
            c1Chart1.ChartArea.AxisX.AutoMin = true;
            c1Chart1.ChartArea.AxisY.AutoMax = true;
            c1Chart1.ChartArea.AxisY.AutoMin = true;
        }

        // generates normally distributed random numbers
        double[] RandNormal(int n)
        {
            if (n % 2 == 1)
                n++;

            double[] rn = new double[n]; //!!VBSubst Dim rn(n-1) As Double

            for (int i = 0; i < n / 2; i++)
            {
                do
                {
                    double u = 2 * rnd.NextDouble() - 1;
                    double v = 2 * rnd.NextDouble() - 1;

                    double s = u * u + v * v;

                    if (s < 1)
                    {
                        s = Math.Sqrt(-2 * Math.Log(s) / s);
                        rn[2 * i] = u * s;
                        rn[2 * i + 1] = v * s;
                        break;
                    }
                } while (true);
            }

            return rn;
        }

        //set up chart labels
        private void SetUpChart()
        {
            double[] values = (double[])c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Y.CopyDataOut();
            Array.Sort(values);

            //add the chart labels, they will be positioned later
            ChartLabels labels = c1Chart1.ChartLabels;
            labels.DefaultLabelStyle.BackColor = c1Chart1.Style.BackColor;
            labels.DefaultLabelStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            C1.Win.C1Chart.Label lab = null;
            for (int i = 0; i < 5; i++)
            {
                lab = labels.LabelsCollection.AddNewLabel();
                lab.Text = ZoneText[i];
                lab.Size = new Size(100, 22);
                lab.Style.BackColor = ZoneColor[i];
                lab.AttachMethod = AttachMethodEnum.Coordinate;
                lab.Visible = true;
            }
            PositionLegends();
        }

        //set up Alarm Zones
        private void LoadZones()
        {
            c1Chart1.ChartArea.AxisX.GridMajor.Visible = false;
            c1Chart1.ChartArea.AxisY.GridMajor.Visible = false;
            c1Chart1.ChartArea.AxisX.GridMinor.Visible = false;
            c1Chart1.ChartArea.AxisY.GridMinor.Visible = false;

            double[] values = (double [])c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Y.CopyDataOut();
            Array.Sort(values);        

            //get the bounds of each zone
            double[] ZoneBounds = new double[]
			{
				values[GetBoundingIndex(values, 0.95)],
				values[GetBoundingIndex(values, 0.75)],
				values[GetBoundingIndex(values, 0.25)],
				values[GetBoundingIndex(values, 0.05)]
			};          

            //add and show the alarm zones
            AlarmZonesCollection zones = c1Chart1.ChartArea.PlotArea.AlarmZones;
            zones.Clear();
            for (int i = 0; i < 5; i++)
            {
                AlarmZone zone = zones.AddNewZone();

                zone.Name = ZoneText[i];
                zone.BackColor = ZoneColor[i];
                zone.PatternStyle = patterns[i];
                zone.PatternVisible = chkPatterns.Checked;
                if (i == 0)
                    zone.UpperExtent = c1Chart1.ChartArea.AxisY.Max;
                else
                    zone.UpperExtent = zones[i - 1].LowerExtent;

                if (i == 4)
                    zone.LowerExtent = c1Chart1.ChartArea.AxisY.Min;
                else
                    zone.LowerExtent = ZoneBounds[i];

                zone.Visible = true;
            }

        }

        //set up Alarm Zone shapes
        private void LoadShapes()
        {
            c1Chart1.ChartArea.AxisX.GridMajor.Visible = true;
            c1Chart1.ChartArea.AxisY.GridMajor.Visible = true;
            c1Chart1.ChartArea.AxisX.GridMinor.Visible = true;
            c1Chart1.ChartArea.AxisY.GridMinor.Visible = true;

            double[] values = (double[])c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Y.CopyDataOut();
            Array.Sort(values);


            //create the alarm zones.
            AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;
            azs.Clear();

            //add the rectangle
            AlarmZone az = azs.AddNewZone();
            az.Name = "Rectangle";
            az.BackColor = ZoneColor[2];
            az.Shape = AlarmZoneShapeEnum.Rectangle;
            az.PatternStyle = patterns[2];
            az.PatternVisible = chkPatterns.Checked;
            az.UpperExtent = values[GetBoundingIndex(values, 0.65)];
            az.LowerExtent = values[GetBoundingIndex(values, 0.45)];
            az.FarExtent = 3;
            az.NearExtent = 2;
            az.Visible = true;

            //add the ellipse
            az = azs.AddNewZone();
            az.BackColor = ZoneColor[0];
            az.Shape = AlarmZoneShapeEnum.Ellipse;
            az.PatternStyle = patterns[0];
            az.PatternVisible = chkPatterns.Checked;
            az.Name = "Ellipse";
            az.UpperExtent = values[GetBoundingIndex(values, .95)];
            az.LowerExtent = values[GetBoundingIndex(values, 0.75)];
            az.FarExtent = 5;
            az.NearExtent = 4;
            az.Visible = true;

            //add a polygon defined by coordinates.  Coordinates
            //are obtained using the GetPoints method defined above.
            PointF[] pfs = GetPoints(3, 201, 1, 5, 1, 7.5);
            az = azs.AddNewZone();
            az.BackColor = ZoneColor[4];
            az.Shape = AlarmZoneShapeEnum.Polygon;
            az.PatternStyle = patterns[4];
            az.PatternVisible = chkPatterns.Checked;
            az.Name = "Polygon";
            az.UpperExtent = values[GetBoundingIndex(values, 0.4)];
            az.LowerExtent = values[GetBoundingIndex(values, 0.1)];
            az.FarExtent = 2.75;
            az.NearExtent = 0.5;
            pfs = GetPoints(1, 15, az.NearExtent, az.FarExtent,
                az.LowerExtent, az.UpperExtent);
            az.PolygonData.PointData.CopyDataIn(pfs);
            az.Visible = true;

        }

        private int GetBoundingIndex(double[] values, double frac)
        {
            //assumes values are sorted, then obtains the
            //index of the first scores() element below
            //the specified percentile fraction
            int n = values.Length;
            int i = (int)(n * frac);

            while (i > (int)values[0] && values[i] == values[i + 1])
                i--;

            return i;
        }

        //getPoints is used just to generate sine curves for fictional data
        PointF[] GetPoints(int funcType, int nElements, double xstart, double xend, double ylow, double yhigh)
        {
            PointF[] pts = (PointF[])Array.CreateInstance(typeof(PointF), nElements);

            switch (funcType)
            {
                case 1:
                    {
                        //x and y values form a sine curve for 1.5 cycles
                        for (int i = 0; i < nElements; i++)
                        {
                            double xd = xstart + i * (xend - xstart) / (nElements - 1);
                            double yd = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI;
                            double yh = (yhigh - ylow) * 0.5;
                            pts[i].X = (float)xd;
                            pts[i].Y = (float)(Math.Sin(yd) * yh + ylow + yh);
                        }
                    }
                    break;

                case 3:
                    //x and y values form a sine curve for 1.5 cycles with random aspects
                    Random rnd = new Random();
                    for (int i = 0; i < nElements; i++)
                    {
                        double xd = xstart + i * (xend - xstart) / (nElements - 1);
                        double yd = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI;
                        double yh = (yhigh - ylow) * 0.5;
                        pts[i].X = (float)xd;
                        pts[i].Y = (float)(Math.Sin(yd) * yh + ylow + yh) + (float)(0.5 * yh * rnd.NextDouble());
                    }
                    break;
            }

            return pts;
        }

        private void PositionLegends()
        {
            //reposition the legend and labels
            C1.Win.C1Chart.ChartLabels labels = c1Chart1.ChartLabels;
            if (labels == null || labels.LabelsCollection.Count < 5)
                return;

            c1Chart1.Update();

            PlotArea plota = c1Chart1.ChartArea.PlotArea;
            Legend leg = c1Chart1.Legend;

            //get left alignment with the legend, and
            //center about the plot area centerline
            Point labP = leg.Location;
            labP.Y = plota.Location.Y + plota.Size.Height / 2;

            //get the height of the labels and legend
            int labHeight = labels[0].Size.Height;
            int h = labHeight * 5 + leg.Size.Height;
            labP.Y -= h / 2;

            for (int i = 0; i < 5; i++)
            {
                C1.Win.C1Chart.Label lab = labels[i];
                lab.AttachMethodData.X = labP.X;
                lab.AttachMethodData.Y = labP.Y;
                labP.Y += labHeight;
            }

            leg.LocationDefault = new Point(-1, labP.Y);
        }

        private int GetBoundingIndex(int[] scores, double frac)
        {
            //assumes scores are sorted, then obtains the
            //index of the first scores() element below
            //the specified percentile fraction
            int n = scores.Length;
            int i = (int)(n * frac);

            while (i > scores[0] && scores[i] == scores[i + 1])
                i--;

            return i;
        }

        private void c1Chart1_Resize(object sender, EventArgs e)
        {
            this.PositionLegends();
            if (radZones.Checked)
            {
                if (c1Chart1.ChartArea.PlotArea.AlarmZones.Count > 0)
                    c1Chart1.ChartArea.PlotArea.AlarmZones[0].UpperExtent = c1Chart1.ChartArea.AxisY.Max;
                if (c1Chart1.ChartArea.PlotArea.AlarmZones.Count > 4)
                    c1Chart1.ChartArea.PlotArea.AlarmZones[4].LowerExtent = c1Chart1.ChartArea.AxisY.Min;
            }
        }

        private void chkPatterns_CheckedChanged(object sender, EventArgs e)
        {
            foreach (AlarmZone az in c1Chart1.ChartArea.PlotArea.AlarmZones)
            {
                az.PatternVisible = chkPatterns.Checked;
            }
        }

        private void radZones_CheckedChanged(object sender, EventArgs e)
        {
            if (radZones.Checked)
                LoadZones();
            else
                LoadShapes();
        }

        private void btnRegData_Click(object sender, EventArgs e)
        {
            LoadData();
            c1Chart1.GetImage();
            if (radZones.Checked)
                LoadZones();
            else
                LoadShapes();
        }
    }
}
