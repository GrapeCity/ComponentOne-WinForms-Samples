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
    public partial class PieCharts : C1DemoForm
    {
        public PieCharts()
        {
            InitializeComponent();
        }

        private void PieCharts_Load(object sender, EventArgs e)
        {
            categorySales1.ResetBindings(false);

            ChartGroup g = c1Chart1.ChartGroups.Group0;
            View3D v = c1Chart1.ChartArea.PlotArea.View3D;
            Pie p = g.Pie;

            ChartVisualStyles.ApplyVisualStyle(c1Chart1, ChartVisualStyles.ChartStyles.Office2007Silver);
            c1Chart1.ColorGeneration = ColorGeneration.Custom;

            AnnotateSlices(c1Chart1);

            // add demo properties
            AddProperty("InnerRadius", p);
            AddProperty("Start", p);
            AddPropertyHeader("3D Properties");
            AddProperty("Depth", v);
            AddProperty("Elevation", v);
            AddProperty("Use3D", g); 
        }

        //offsets a particular pie slice
        private void ExplodeSlice(C1.Win.C1Chart.C1Chart chart, int series, int offset, bool fromClick)
        {
            if (radImageLabels.Checked)
            {
                ChartGroup g = chart.ChartGroups.Group0;
                ChartDataSeriesCollection seriesList = g.ChartData.SeriesList;

                for (int i = 0; i < seriesList.Count; i++)
                {
                    if (i == series)
                    {
                        if (seriesList[i].Offset == 10 && fromClick)
                        {
                            seriesList[i].Offset = 0;
                            RemoveSliceImage(chart, i);
                        }
                        else
                        {
                            seriesList[i].Offset = offset;
                            AnnotateSlicewithImage(chart, i);
                        }
                        return;
                    }
                }
            }
        }

        //adds image
        private void AnnotatePie(C1.Win.C1Chart.C1Chart chart)
        {
            Style s = chart.ChartLabels.DefaultLabelStyle;
            s.Opaque = false;
            s.Border.BorderStyle = BorderStyleEnum.None;

            C1.Win.C1Chart.Label label = chart.ChartLabels.LabelsCollection.AddNewLabel();
            label.Text = chart.ChartGroups[0].ChartData.SeriesList[0].X[0].ToString();
            label.Compass = LabelCompassEnum.South;
            label.Visible = true;
            label.AttachMethod = AttachMethodEnum.Coordinate;

            PlotArea plot = chart.ChartArea.PlotArea;
            label.AttachMethodData.X = plot.Location.X;
            label.AttachMethodData.Y = plot.Location.Y + (plot.Size.Width / 2);
        }

        private void AnnotateSlices(C1.Win.C1Chart.C1Chart chart)
        {
            Style s = chart.ChartLabels.DefaultLabelStyle;
            s.BackColor = SystemColors.Info;
            s.Opaque = true;
            s.Border.BorderStyle = BorderStyleEnum.Solid;

            ChartDataSeriesCollection series = chart.ChartGroups[0].ChartData.SeriesList;

            chart.ChartLabels.LabelsCollection.Clear();
            // Attach labels to each slice
            for (int i = 0; i < series.Count; i++)
            {
                C1.Win.C1Chart.Label label = chart.ChartLabels.LabelsCollection.AddNewLabel();
                label.Text = String.Format("{0:C0}", series[i].Y[0]);
                label.Compass = LabelCompassEnum.Radial;
                label.Offset = 20;
                label.Connected = true;
                label.Visible = true;
                label.AttachMethod = AttachMethodEnum.DataIndex;
                AttachMethodData am = label.AttachMethodData;
                am.GroupIndex = 0;
                am.SeriesIndex = i;
                am.PointIndex = 0;

                series[i].Offset = 0;
            }
        }

        private void ConfigureChart(bool threed, bool doughnut)
        {
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.Use3D = threed;
            g.Pie.InnerRadius = doughnut ? 30 : 0;
        }

        public void ImageLabels()
        {
            ConfigureChart(true, false);

            c1Chart1.ChartLabels.LabelsCollection.Clear(); ;

            ExplodeSlice(c1Chart1, 0, 10, false);
            ExplodeSlice(c1Chart1, 3, 10, false);

        }

        public void AnnotateSlicewithImage(C1.Win.C1Chart.C1Chart chart, int seriesIndex)
        {
            ChartDataSeriesCollection series = chart.ChartGroups[0].ChartData.SeriesList;
            LabelsCollection labels = c1Chart1.ChartLabels.LabelsCollection;
            C1.Win.C1Chart.Label label;
            label = labels.AddNewLabel();
            label.Image = imageList1.Images[seriesIndex];
            label.Style.BackColor = Color.Transparent;
            label.Style.Border.BorderStyle = BorderStyleEnum.None;
            label.Style.GradientStyle = GradientStyleEnum.None;
            label.Style.ImageAlignment = AlignImageEnum.Top;
            label.Size = label.Image.Size + new Size(0, 20);
            label.Compass = LabelCompassEnum.Radial;
            label.Offset = 30;
            label.Connected = false;
            label.Visible = true;
            label.AttachMethod = AttachMethodEnum.DataIndex;
            label.Text = String.Format("{0:C0}", series[seriesIndex].Y[0]);

            AttachMethodData am = label.AttachMethodData;
            am.GroupIndex = 0;
            am.SeriesIndex = seriesIndex;
            am.PointIndex = 0;

        }

        public void RemoveSliceImage(C1.Win.C1Chart.C1Chart chart, int seriesIndex)
        {
            LabelsCollection labels = c1Chart1.ChartLabels.LabelsCollection;

            for (int i = 0; i < labels.Count; i++)
            {
                if (labels[i].AttachMethodData.SeriesIndex == seriesIndex)
                {
                    labels.RemoveAt(i);
                }
            }

        }

        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radDefault.Checked)
            {
                AnnotateSlices(c1Chart1);
                ConfigureChart(false, false);
            }
            else
            {
                ImageLabels();
            }
        }

        private void c1Chart1_MouseClick(object sender, MouseEventArgs e)
        {
            int series = 0;
            int distance = 0;
            c1Chart1.ChartGroups.Group0.CoordToSeriesIndex(e.X, e.Y, PlotElementEnum.Series, ref series, ref distance);
            ExplodeSlice(c1Chart1, series, 10, true);
        }
    }
}
