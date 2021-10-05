using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;

namespace AnnotationExplorer.Samples
{
    public partial class Callouts : UserControl
    {
        AnnotationLayer annotationLayer;
        IRenderEngine _engine;

        public Callouts()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        private void SetupAnnotations()
        {
            annotationLayer = new AnnotationLayer(flexChart1);

            var arrowCallout = new Polygon("Low")
            {
                Attachment = AnnotationAttachment.DataIndex,
                PointIndex = 1,
                ContentCenter = new PointF(25, -50)
            };
            List<PointF> points = GetPointsForArrowCallout(arrowCallout.ContentCenter.Value.X, arrowCallout.ContentCenter.Value.Y, "Low");
            foreach (PointF p in points)
            {
                arrowCallout.Points.Add(p);
            }
            arrowCallout.ContentStyle.StrokeColor = Color.Black;
            arrowCallout.Style.FillColor = Color.FromArgb(200, Color.Green);
            arrowCallout.Style.StrokeColor = Color.Green;

            var lineCallout = new Polygon("High")
            {
                Attachment = AnnotationAttachment.DataIndex,
                PointIndex = 4,
                ContentCenter = new Point(-50, 75),
                Points =  { new Point(0, 0), new Point(-50, 50), new Point(-100, 50), new Point(-100, 100), new Point(0, 100), new Point(0, 50), new Point(-50, 50) }
            };
            lineCallout.ContentStyle.StrokeColor = Color.Black;
            lineCallout.Style.FillColor = Color.FromArgb(200, Color.Red);
            lineCallout.Style.StrokeColor = Color.Red;

            annotationLayer.Annotations.Add(arrowCallout);
            annotationLayer.Annotations.Add(lineCallout);
        }

        void SetupChart()
        {
            List<DataItem> dataList = new List<DataItem>();
            dataList.Add(new DataItem() { X = 1, Y = 30 });
            dataList.Add(new DataItem() { X = 2, Y = 20 });
            dataList.Add(new DataItem() { X = 3, Y = 30 });
            dataList.Add(new DataItem() { X = 4, Y = 65 });
            dataList.Add(new DataItem() { X = 5, Y = 70 });
            dataList.Add(new DataItem() { X = 6, Y = 60 });

            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();

            flexChart1.ChartType = C1.Chart.ChartType.LineSymbols;

            var series = new Series()
            {
                Name = "Trend",
                DataSource = dataList,
                Binding = "Y",
                BindingX = "X",
            };
            
            flexChart1.Series.Add(series);
            flexChart1.Rendered += FlexChart1_Rendered;
            flexChart1.EndUpdate();
        }

        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if(_engine == null)
            { 
                _engine = e.Engine;
                SetupAnnotations();
                flexChart1.Invalidate();
            }
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("callouts", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("callouts", "description").MakeRtf();
            baseSample1.pScroll.Controls.Remove(baseSample1.pControls);
            flexChart1 = baseSample1.flexChart1;
        }


        /// <summary>
        /// This is used to automatically generate the collection of endpoints of an arrow callout. 
        /// </summary>
        /// <param name="centerX">The center x of the content rectangle.</param>
        /// <param name="centerY">The center y of the content rectangle.</param>
        /// <param name="content">The content of this callout. Will automatically adjust the content rectangle according to this.</param>
        /// <returns>The endpoints of an arrow callout.</returns>
        private List<PointF> GetPointsForArrowCallout(float centerX, float centerY, string content)
        {
            _Size size = _engine.MeasureString(content);
            return GetPointsForArrowCallout(centerX, centerY, (float)size.Width + 10, (float)size.Height + 10);
        }

        /// <summary>
        /// This is used to automatically generate the collection of endpoints of an arrow callout. 
        /// </summary>
        /// <param name="centerX">The center x of the content rectangle.</param>
        /// <param name="centerY">The center y of the content rectangle.</param>
        /// <param name="rectWidth">The width of the content rectangle.</param>
        /// <param name="rectHeight">The height of the content rectangle.</param>
        /// <returns>The endpoints of an arrow callout.</returns>
        private List<PointF> GetPointsForArrowCallout(float centerX, float centerY, float rectWidth, float rectHeight)
        {
            var points = new List<PointF>();

            float rectLeft = centerX - rectWidth / 2;
            float rectRight = centerX + rectWidth / 2;
            float rectTop = centerY - rectHeight / 2;
            float rectBottom = centerY + rectHeight / 2;

            float angle = (float)(Math.Atan2(-centerY, centerX));
            float angleOffset1 = 0.4f;
            float angleOffset2 = 0.04f;
            float arrowHeight = 0.4f * rectHeight;
            float hypotenuse = (float)(arrowHeight / Math.Cos(angleOffset1));
            float subHypotenuse = (float)(arrowHeight / Math.Cos(angleOffset2));

            bool isNearBottom = Math.Abs(rectTop) > Math.Abs(rectBottom);
            float nearHorizontalEdge = isNearBottom ? rectBottom : rectTop;
            bool isNearRight = Math.Abs(rectLeft) > Math.Abs(rectRight);
            float nearVerticalEdge = isNearRight ? rectRight : rectLeft;
            bool isHorizontalCrossed = Math.Abs(nearHorizontalEdge) > Math.Abs(nearVerticalEdge);
            float nearEdge = isHorizontalCrossed ? nearHorizontalEdge : nearVerticalEdge;

            int factor = nearEdge > 0 ? -1 : 1;
            float crossedPointOffsetToCenter = isHorizontalCrossed ?
                (float)(rectHeight / (2 * Math.Tan(angle)) * factor) : (float)(rectWidth * Math.Tan(angle) * factor / 2);

            // Arrow points
            points.Add(new PointF(0, 0));
            points.Add(new PointF((float)(Math.Cos(angle + angleOffset1) * hypotenuse), (float)(-Math.Sin(angle + angleOffset1) * hypotenuse)));
            points.Add(new PointF((float)(Math.Cos(angle + angleOffset2) * subHypotenuse), (float)(-Math.Sin(angle + angleOffset2) * subHypotenuse)));

            // Rectangle points
            if (isHorizontalCrossed)
            {
                points.Add(new PointF((float)(-nearEdge / Math.Tan(angle + angleOffset2)), (float)nearEdge));
                if (isNearBottom)
                {
                    points.Add(new PointF(rectLeft, rectBottom));
                    points.Add(new PointF(rectLeft, rectTop));
                    points.Add(new PointF(rectRight, rectTop));
                    points.Add(new PointF(rectRight, rectBottom));
                }
                else
                {
                    points.Add(new PointF(rectRight, rectTop));
                    points.Add(new PointF(rectRight, rectBottom));
                    points.Add(new PointF(rectLeft, rectBottom));
                    points.Add(new PointF(rectLeft, rectTop));
                }
                points.Add(new PointF((float)(-nearEdge / Math.Tan(angle - angleOffset2)), nearEdge));
            }
            else
            {
                points.Add(new PointF(nearEdge, (float)(-nearEdge * Math.Tan(angle + angleOffset2))));
                if (isNearRight)
                {
                    points.Add(new PointF(rectRight, rectBottom));
                    points.Add(new PointF(rectLeft, rectBottom));
                    points.Add(new PointF(rectLeft, rectTop));
                    points.Add(new PointF(rectRight, rectTop));
                }
                else
                {
                    points.Add(new PointF(rectLeft, rectTop));
                    points.Add(new PointF(rectRight, rectTop));
                    points.Add(new PointF(rectRight, rectBottom));
                    points.Add(new PointF(rectLeft, rectBottom));
                }
                points.Add(new PointF(nearEdge, (float)(-nearEdge * Math.Tan(angle - angleOffset2))));
            }

            // Arrow points
            points.Add(new PointF((float)(Math.Cos(angle - angleOffset2) * subHypotenuse), (float)(-Math.Sin(angle - angleOffset2) * subHypotenuse)));
            points.Add(new PointF((float)(Math.Cos(angle - angleOffset1) * hypotenuse), (float)(-Math.Sin(angle - angleOffset1) * hypotenuse)));
            return points;
        }

        public class DataItem
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}
