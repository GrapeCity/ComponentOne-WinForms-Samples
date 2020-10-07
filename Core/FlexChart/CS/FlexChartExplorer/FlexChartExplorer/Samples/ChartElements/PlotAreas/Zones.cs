using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Zones : FlexChartBaseSample
    {
        Color[] _zones_colors = new Color[]
        {
            Color.FromArgb(64, 255,192,192),
            Color.FromArgb(128, 55,228,228),
            Color.FromArgb(128, 255,228,128),
            Color.FromArgb(128, 128,255,128),
            Color.FromArgb(128, 128,128,225)
        };
        double[] _zones;
        private FlexChart flexChart1;

        public Zones()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = DataService.GetStudentScores();
            var mean = FindMean(data);
            var sd = FindSD(data, mean);

            this.flexChart1.Header.Content = "Distribution of students by Grade";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "Number";
            this.flexChart1.ChartType = ChartType.Scatter;

            //raw score series
            var rawScore = new Series
            {
                Name = "Raw Score",
                Binding = "Score",
            };
            this.flexChart1.Series.Add(rawScore);
            
            //Statistics series
            for (int i = -2; i <= 2; i++)
            {
                var yVal = (int)(mean + i * sd);
                var points = new Point[]
                {
                    new Point(0, yVal),
                    new Point(data.Count, yVal),
                };
                var statSeries = new Series
                {
                    ChartType = ChartType.Line,
                    DataSource = points,
                    Binding = "Y",
                    BindingX = "X"
                };
                statSeries.Style.Stroke = new SolidBrush(Color.FromArgb(20, 20, 20));
                statSeries.Style.StrokeWidth = 2;
                if (Math.Abs(i) == 1)
                    statSeries.Style.StrokeDashPattern = new float[] { 5, 1 };
                else if (Math.Abs(i) == 2)
                    statSeries.Style.StrokeDashPattern = new float[] { 2, 2 };

                if (i > 0)
                    statSeries.Name = "M+" + i + "S";
                else if (i < 0)
                    statSeries.Name = "M" + i + "S";
                else
                    statSeries.Name = "Mean (M)";
                this.flexChart1.Series.Add(statSeries);
            }
            //Add zones to legend
            for (int i = 0; i < 5; i++)
            {
                var series = new Series();
                series.ChartType = ChartType.Area;
                series.Style.Fill = new SolidBrush(_zones_colors[4 - i]);
                series.Style.Stroke = new SolidBrush(Color.Transparent);
                series.Name = "Grade-" + "ABCDE"[i];
                this.flexChart1.Series.Add(series);
            }
            var scores = data.Select(x => x.Score).OrderByDescending(x => x).ToArray();
            _zones = new double[]
            {
                scores[(int)(data.Count*0.95)],
                scores[(int)(data.Count*0.75)],
                scores[(int)(data.Count*0.25)],
                scores[(int)(data.Count*0.05)],
            };

            this.flexChart1.AxisX.Title = "Student Roll Number";
            this.flexChart1.AxisY.Title = "Marks Secured";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Legend.Position = Position.Right;
            this.flexChart1.Rendering += FlexChart1_Rendering;
        }

        private void FlexChart1_Rendering(object sender, RenderEventArgs e)
        {
            var chart = sender as FlexChart;
            var engine = e.Engine;
            for(int i = 0; i < 5; i++)
            {
                var minY = i == 0 ? flexChart1.AxisY.ActualMin : _zones[i - 1];
                var maxY = i == 4 ? flexChart1.AxisY.ActualMax : _zones[i];
                DrawAlarmZone(chart, engine, flexChart1.AxisX.ActualMin, minY, flexChart1.AxisX.ActualMax, maxY, _zones_colors[i]);
            }
        }
        void DrawAlarmZone(FlexChart chart, IRenderEngine engine, double xmin, double ymin, double xmax, double ymax, Color fill)
        {
            var pt1 = chart.DataToPoint(new PointF((float)xmin, (float)ymin));
            var pt2 = chart.DataToPoint(new PointF((float)xmax, (float)ymax));
            engine.SetFill(new SolidBrush(fill));
            engine.SetStroke(new SolidBrush(Color.Transparent));
            engine.DrawRect(Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y), Math.Abs(pt2.X - pt1.X), Math.Abs(pt2.Y - pt1.Y));
        }
        private double FindMean(List<Student> list)
        {
            double sum = 0;
            foreach (Student s in list)
                sum += s.Score;
            return sum / list.Count;
        }
        private double FindSD(List<Student> list, double mean)
        {
            double sum = 0;
            foreach(Student s in list)
            {
                var di = s.Score - mean;
                sum += di * di;
            }
            return Math.Sqrt(sum / list.Count);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
