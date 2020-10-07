using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart;
using C1.Win.Chart.Annotation;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Callouts : FlexChartBaseSample
    {
        private IRenderEngine _renderEngine;
        private List<UnitsCost> _data;
        private FlexChart flexChart1;

        public Callouts()
        {
            InitializeComponent();
        }
        private void SetupAnnotations()
        {
            var annotationLayer = new AnnotationLayer(this.flexChart1);
            var orderedCost = _data.OrderBy(x => x.Cost).ToList();
            //Arrow Callouts
            var arrowCallout1 = new Polygon("Minimum Cost")
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = _data.IndexOf(orderedCost[0]),
            };
            arrowCallout1.Style.FillColor = Color.FromArgb(200, Color.Green);
            arrowCallout1.Style.StrokeColor = Color.Green;
            arrowCallout1.ContentStyle.StrokeColor = Color.White;
            foreach(PointF point in GetArrowCalloutPoints(arrowCallout1, orderedCost[0]))
            {
                arrowCallout1.Points.Add(point);
            }
            var arrowCallout2 = new Polygon("Maximum Cost")
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = _data.IndexOf(orderedCost[_data.Count-1]),
            };

            arrowCallout2.Style.FillColor = Color.FromArgb(200, Color.Red);
            arrowCallout2.Style.StrokeColor = Color.Red;
            arrowCallout2.ContentStyle.StrokeColor = Color.White;
            foreach (PointF point in GetArrowCalloutPoints(arrowCallout2, orderedCost[_data.Count-1]))
            {
                arrowCallout2.Points.Add(point);
            }

            var lineCallout = new Polygon("Highest Profit")
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = _data.IndexOf(orderedCost[0]),
                ContentCenter = new PointF(30,-60),
                Points = { new PointF(0, 0), new PointF(30, -40), new PointF(-30, -40), new PointF(-30, -80), new PointF(90, -80), new PointF(90, -40), new PointF(30, -40) }
            };
            lineCallout.Style.FillColor = Color.FromArgb(200, Color.Blue);
            lineCallout.Style.StrokeColor = Color.Blue;
            lineCallout.ContentStyle.StrokeColor = Color.White;

            annotationLayer.Annotations.Add(arrowCallout1);
            annotationLayer.Annotations.Add(arrowCallout2);
            annotationLayer.Annotations.Add(lineCallout);
        }
        private List<PointF> GetArrowCalloutPoints(Polygon callout, UnitsCost dataCord)
        {
            var textSize = _renderEngine.MeasureString(callout.Content);
            var yMax = this.flexChart1.AxisY.ActualMax;
            var xMax = this.flexChart1.AxisX.ActualMax;
            var yMin = this.flexChart1.AxisY.ActualMin;
            var xMin = this.flexChart1.AxisX.ActualMin;
            var points = new List<PointF>();
            var halfX = (float)textSize.Width / 2;
            var halfY = (float)textSize.Height / 2;
            if ((yMax - dataCord.Cost) > (dataCord.Cost - yMin))
            {
                //Above the point
                if ((xMax - dataCord.Units) > (dataCord.Units - xMin))
                {
                    //Above and Right to the Point
                    points.Add(new PointF(0, 0));
                    points.Add(new PointF(5,-5));
                    points.Add(new PointF(7,-5+2));
                    points.Add(new PointF(7+halfX-8, -7-10));
                    points.Add(new PointF(7,-7-10));
                    points.Add(new PointF(7,-7-10-halfY*2));
                    points.Add(new PointF(7+halfX*2, -7-10-halfY*2));
                    points.Add(new PointF(7+halfX*2, -7-10));
                    points.Add(new PointF(7+halfX+4, -7-10));
                    points.Add(new PointF(8,-5+3));
                    points.Add(new PointF(10,0));
                    callout.ContentCenter = new PointF(7+halfX, -17-halfY);
                }
                else
                {
                    //Above and Left to the point
                    points.Add(new PointF(0, 0));
                    points.Add(new PointF(-5, -5));
                    points.Add(new PointF(-7, -5 + 2));
                    points.Add(new PointF(-7 - halfX + 8, -7 - 10));
                    points.Add(new PointF(-7, -7 - 10));
                    points.Add(new PointF(-7, -7 - 10 - halfY * 2));
                    points.Add(new PointF(-7 - halfX * 2, -7 - 10 - halfY * 2));
                    points.Add(new PointF(-7 - halfX * 2, -7 - 10));
                    points.Add(new PointF(-7 - halfX - 4, -7 - 10));
                    points.Add(new PointF(-8, -5 + 3));
                    points.Add(new PointF(-10, 0));
                    callout.ContentCenter = new PointF(-7 - halfX, -17 - halfY);
                }
            }
            else
            {
                //Below the point
                if ((xMax - dataCord.Units) > (dataCord.Units - xMin))
                {
                    //Below and Right to the Point
                    points.Add(new PointF(0, 0));
                    points.Add(new PointF(5, +5));
                    points.Add(new PointF(7, +5 - 2));
                    points.Add(new PointF(7 + halfX - 8, +7 + 10));
                    points.Add(new PointF(7, +7 + 10));
                    points.Add(new PointF(7, +7 + 10 + halfY * 2));
                    points.Add(new PointF(7 + halfX * 2, +7 + 10 + halfY * 2));
                    points.Add(new PointF(7 + halfX * 2, +7 + 10));
                    points.Add(new PointF(7 + halfX + 4, +7 + 10));
                    points.Add(new PointF(8, +5 - 3));
                    points.Add(new PointF(10, 0));
                    callout.ContentCenter = new PointF(7 + halfX, +17 + halfY);
                }
                else
                {
                    //Below and Left to the point
                    points.Add(new PointF(0, 0));
                    points.Add(new PointF(-5, +5));
                    points.Add(new PointF(-7, +5 - 2));
                    points.Add(new PointF(-7 - halfX + 8, +7 + 10));
                    points.Add(new PointF(-7, +7 + 10));
                    points.Add(new PointF(-7, +7 + 10 + halfY * 2));
                    points.Add(new PointF(-7 - halfX * 2, +7 + 10 + halfY * 2));
                    points.Add(new PointF(-7 - halfX * 2, +7 + 10));
                    points.Add(new PointF(-7 - halfX - 4, +7 + 10));
                    points.Add(new PointF(-8, +5 - 3));
                    points.Add(new PointF(-10, 0));
                    callout.ContentCenter = new PointF(-7 - halfX, +17 + halfY);
                }
            }
            return points;
        }
        protected override void SetupChart()
        {
            _data = DataService.GetUnitCostData();
            this.flexChart1.Header.Content = "Relationship between Production and Cost";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.Binding = "Cost";
            this.flexChart1.BindingX = "Units";
            this.flexChart1.DataSource = _data;
            this.flexChart1.ChartType = ChartType.LineSymbols;
            this.flexChart1.Series.Add(new Series() { Name="Cost"});

            this.flexChart1.AxisX.Title = "Quantity";
            this.flexChart1.AxisY.Title = "Per Unit Cost";
            this.flexChart1.AxisY.TitleStyle.Font = this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.Rendering += (s, e) =>
            {
                if (_renderEngine == null)
                {
                    _renderEngine = e.Engine;
                    SetupAnnotations();
                }
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
