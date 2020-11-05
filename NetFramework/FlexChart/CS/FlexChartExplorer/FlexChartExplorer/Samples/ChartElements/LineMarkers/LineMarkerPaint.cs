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
using C1.Win.Chart.Interaction;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class LineMarkerPaint : FlexChartBaseSample
    {
        private LineMarker _lineMarker;
        Font _dataFont = new Font("Segoe UI", 9, FontStyle.Bold);
        Image[] _images = new Image[]
        {
            Properties.Resources.JP_Flag,
            Properties.Resources.CH_Flag,
            Properties.Resources.IN_Flag,
        };
        private FlexChart flexChart1;

        public LineMarkerPaint()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Population : Birth Rate";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetLineMarkerCustomData();
            this.flexChart1.BindingX = "Date";
            this.flexChart1.ChartType = ChartType.Line;

            var japan = new Series() { Name = "Japan", Binding = "Japan" };
            japan.Style.StrokeColor = Color.FromArgb(255, 178, 251, 88);
            var china = new Series() { Name = "China", Binding = "China" };
            china.Style.StrokeColor = Color.FromArgb(255, 251, 178, 88);
            var india = new Series() { Name = "India", Binding = "India" };
            india.Style.StrokeColor = Color.FromArgb(255, 136, 189, 230);
            this.flexChart1.Series.Add(japan);
            this.flexChart1.Series.Add(china);
            this.flexChart1.Series.Add(india);

            this.flexChart1.Rendered += FlexChart1_Rendered;            
        }
        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if (_lineMarker == null)
            {
                _lineMarker = new LineMarker(this.flexChart1) { LineWidth = 2, HorizontalPosition = 0.5, VerticalPosition = 0.5};
                _lineMarker.Paint += _lineMarker_Paint;
            }
        }

        private void _lineMarker_Paint(object sender, PaintEventArgs e)
        {
            var chartPoint = new Point(_lineMarker.X, _lineMarker.Y);
            var hitInfo = this.flexChart1.HitTest(chartPoint);
            if (double.IsNaN(hitInfo.Distance) || hitInfo.PointIndex < 0)
                return;
            //Render info rectangle
            var infoRect = new Rectangle(chartPoint.X + 10, chartPoint.Y + 10, 150, 75);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), infoRect);
            var startPoint = new Point(chartPoint.X + 20, chartPoint.Y + 20);

            //Render content of the rectangle
            int i = 0;
            foreach(Series series in flexChart1.Series)
            {
                var yValues = series.GetValues(0);
                var text = string.Format("{0}-{1}", series.Name, yValues[hitInfo.PointIndex]);
                var textPoint = new Point(startPoint.X+ _images[i].Width + 10, startPoint.Y);
                e.Graphics.DrawImage(_images[i], startPoint);
                e.Graphics.DrawString(text, _dataFont, series.Style.Stroke, textPoint);
                startPoint.Y += 20;
                i++;
            }
            //y-Rectangle
            var yRect = new Rectangle((int)flexChart1.PlotRect.Left-50, _lineMarker.Y-15, 50, 30);
            e.Graphics.FillRectangle(Brushes.DarkBlue,yRect);
            e.Graphics.DrawString(hitInfo.Format("{y}"), _dataFont, Brushes.White, yRect.X+5, yRect.Y+2);
            //x-rectangle
            var xRect = new Rectangle(_lineMarker.X - 60, (int)(flexChart1.PlotRect.Top + flexChart1.PlotRect.Height), 120, 25);
            e.Graphics.FillRectangle(Brushes.DarkBlue, xRect);
            e.Graphics.DrawString(hitInfo.Format("{x:dd-MM-yyyy}"),_dataFont , Brushes.White, xRect.X+5, xRect.Y+2);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
