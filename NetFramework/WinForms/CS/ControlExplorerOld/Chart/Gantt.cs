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
    public partial class Gantt : C1DemoForm
    {
        public Gantt()
        {
            InitializeComponent();
        }

        //adds a new series to the Gantt chart accepting a task name,
        //an array of starting times and an array of ending times.
        private void AddGanttSeriesData(ChartDataSeriesCollection cdsc,
            string taskName, DateTime[] startTimes, DateTime[] endTimes)
        {
            ChartDataSeries cds = cdsc.AddNewSeries();
            cds.Label = taskName;
            cds.Y.CopyDataIn(startTimes);
            cds.Y1.CopyDataIn(endTimes);
        }

        //add chart labels with beginning and ending dates for each data point
        //in the Gantt chart.  Labels are placed inside on the western edge.
        private void AddGanttTaskLabels(C1Chart chart, ChartDataSeriesCollection cdsc)
        {
            ChartLabels cl = chart.ChartLabels;
            cl.DefaultLabelStyle.BackColor = Color.Transparent;
            cl.DefaultLabelStyle.GradientStyle = GradientStyleEnum.None;
            cl.DefaultLabelStyle.ForeColor = Color.Sienna;
            cl.DefaultLabelStyle.HorizontalAlignment = AlignHorzEnum.Far;

            C1.Win.C1Chart.LabelsCollection clc = cl.LabelsCollection;
            clc.Clear();

            int slen = cdsc.Count;
            for (int s = 0; s < cdsc.Count; s++)
            {
                ChartDataSeries cds = cdsc[s];
                for (int p = 0; p < cds.Length; p++)
                {
                    C1.Win.C1Chart.Label lab = clc.AddNewLabel();
                    DateTime start = (DateTime)cds.Y[p];
                    DateTime end = (DateTime)cds.Y1[p];
                    lab.Text = start.ToString("MMM dd") + " - " + end.ToString("MMM dd");
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

        private void LoadData()
        {
            //clear the existing data and add new Series data.
            ChartGroup cg = c1Chart1.ChartGroups.Group0;
            ChartDataSeriesCollection cdsc = cg.ChartData.SeriesList;
            cdsc.Clear();

            //create a new series for each "row" of the Gantt chart.
            //TASK ONE
            AddGanttSeriesData(cdsc, "Idea Generation",
                new DateTime[] { new DateTime(2009, 01, 01) },
                new DateTime[] { new DateTime(2009, 01, 25) });

            //TASK TWO
            AddGanttSeriesData(cdsc, "Concept Development",
                new DateTime[] { new DateTime(2009, 01, 10) },
                new DateTime[] { new DateTime(2009, 02, 14) });

            //TASK THREE
            AddGanttSeriesData(cdsc, "Business Analysis",
                new DateTime[] { new DateTime(2009, 01, 21) },
                new DateTime[] { new DateTime(2009, 02, 28) });

            //TASK FOUR
            AddGanttSeriesData(cdsc, "Market Analysis",
                new DateTime[] { new DateTime(2009, 01, 21), new DateTime(2009, 02, 20) },
                new DateTime[] { new DateTime(2009, 02, 12), new DateTime(2009, 03, 15) });

            //TASK FIVE
            AddGanttSeriesData(cdsc, "Implementation",
                new DateTime[] { new DateTime(2009, 02, 10) },
                new DateTime[] { new DateTime(2009, 04, 15) });

            //TASK SIX
            AddGanttSeriesData(cdsc, "Testing & Bug Fixes",
                new DateTime[] { new DateTime(2009, 02, 15), new DateTime(2009, 03, 20) },
                new DateTime[] { new DateTime(2009, 03, 15), new DateTime(2009, 04, 10) });


            //TASK SEVEN
            AddGanttSeriesData(cdsc, "Commercialize",
                new DateTime[] { new DateTime(2009, 04, 5) },
                new DateTime[] { new DateTime(2009, 05, 05) });

            //add task labels.
            AddGanttTaskLabels(c1Chart1, cdsc);
        }

        private void Gantt_Load(object sender, EventArgs e)
        {
            LoadData();

            //add demo properties
            AddProperty("Compass", c1Chart1.ChartArea.AxisY);
            AddProperty("Use3D", c1Chart1.ChartGroups.Group0);
        }
    }
}
