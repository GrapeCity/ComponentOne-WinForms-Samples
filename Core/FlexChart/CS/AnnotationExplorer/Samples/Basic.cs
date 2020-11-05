using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;
using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;

namespace AnnotationExplorer.Samples
{
    public partial class Basic : UserControl
    {
        AnnotationLayer annotationLayer;
        public Basic()
        {
            InitializeComponent();

            InitializeControls();

            SetupChart();

            SetupAnnotations();
        }

        private void SetupAnnotations()
        {
            annotationLayer = new AnnotationLayer(flexChart1);

            var txtRelative = new C1.Win.Chart.Annotation.Text("Relative")
            {
                Location = new PointF(0.55f, 0.15f),
                Attachment = AnnotationAttachment.Relative,
                TooltipText = "This is a content annotation\r\nLocation: { x:0.55, y:0.15 }\r\nAttachment: Relative"
            };
            txtRelative.Style.StrokeColor = Color.Black;
            txtRelative.Style.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 15);
            annotationLayer.Annotations.Add(txtRelative);

            var ellipseRelative = new Ellipse("Relative", 120, 80)
            {
                Location = new PointF(0.4f, 0.45f),
                Attachment = AnnotationAttachment.Relative,
                TooltipText = "This is a ellipse annotation\r\nLocation: { x:0.4, y:0.45 }\r\nAttachment: Relative"
            };
            ellipseRelative.ContentStyle.StrokeColor = Color.Black;
            ellipseRelative.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            ellipseRelative.Style.FillColor = Color.FromArgb(200, Color.Goldenrod);
            ellipseRelative.Style.StrokeColor = Color.DarkGoldenrod;
            ellipseRelative.Style.StrokeWidth = 2;
            annotationLayer.Annotations.Add(ellipseRelative);

            var circle = new Circle("DataIndex", 50)
            {
                SeriesIndex = 0,
                PointIndex = 27,
                Attachment = AnnotationAttachment.DataIndex,
                TooltipText = "This is a circle annotation\r\nRadius: 50\r\nPointIndex: 27\r\nAttachment: DataIndex"
            };
            circle.ContentStyle.StrokeColor = Color.Black;
            circle.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            circle.Style.FillColor = Color.FromArgb(200, Color.LightSeaGreen);
            circle.Style.StrokeColor = Color.DarkCyan;
            circle.Style.StrokeWidth = 2;
            annotationLayer.Annotations.Add(circle);

            var rectangle = new C1.Win.Chart.Annotation.Rectangle("DataCoordinate", 130, 100)
            {
                Location = new PointF(37, 30),
                Attachment = AnnotationAttachment.DataCoordinate,
                TooltipText = "This is a rectangle annotation\r\nLocation: { x:37, y:30 }\r\nAttachment: DataCoordinate"
            };
            rectangle.ContentStyle.StrokeColor = Color.Black;
            rectangle.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            rectangle.Style.FillColor = Color.FromArgb(200, Color.SlateBlue);
            rectangle.Style.StrokeColor = Color.DarkSlateBlue;
            rectangle.Style.StrokeWidth = 2;
            annotationLayer.Annotations.Add(rectangle);

            var square = new C1.Win.Chart.Annotation.Square("DataIndex", 80)
            {

                SeriesIndex = 0,
                PointIndex = 45,
                Attachment = AnnotationAttachment.DataIndex,
                TooltipText = "This is a square annotation\r\nLength: 80\r\nPointIndex: 45\r\nAttachment: DataIndex"
            };
            square.ContentStyle.StrokeColor = Color.Black;
            square.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            square.Style.FillColor = Color.FromArgb(200, Color.SandyBrown);
            square.Style.StrokeColor = Color.Chocolate;
            square.Style.StrokeWidth = 2;

            annotationLayer.Annotations.Add(square);

            var polygon = new C1.Win.Chart.Annotation.Polygon("Absolute")
            {
                Attachment = AnnotationAttachment.Absolute,
                Points = 
                { 
                    new PointF(200, 25), 
                    new PointF(150, 70), 
                    new PointF(175, 115), 
                    new PointF(225, 115), 
                    new PointF(250, 70) 
                },
                TooltipText = "This is a points annotation\r\nPoints: [(200, 25),(150, 70),(175, 115),(225, 115),(250, 70)]\r\nAttachment: Absolute"
            };
            polygon.ContentStyle.StrokeColor = Color.Black;
            polygon.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            polygon.Style.FillColor = Color.FromArgb(200, Color.Red);
            polygon.Style.StrokeColor = Color.DarkTurquoise;
            polygon.Style.StrokeWidth = 3;
            annotationLayer.Annotations.Add(polygon);

            var line = new C1.Win.Chart.Annotation.Line("Absolute", new Point(50, 200), new Point(300, 350))
            {
                Attachment = AnnotationAttachment.Absolute,
                TooltipText = "This is a line annotation\r\nPoints: [(50, 200),(300, 350)]\r\nAttachment: Absolute"

            };
            line.ContentStyle.StrokeColor = Color.Black;
            line.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            line.Style.StrokeWidth = 4;
            line.Style.StrokeColor = Color.DarkTurquoise;
            annotationLayer.Annotations.Add(line);

            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image()
            {
                SourceImage = AnnotationExplorer.Properties.Resources.Image,
                Location = new PointF(22, 30),
                Attachment = AnnotationAttachment.DataCoordinate,
                TooltipText = "This is a image annotation\r\nLocation: { x:22, y:30 }\r\nAttachment: DataCoordinate"
            });
        }

        void SetupChart()
        {
            List<DataItem> dataList = new List<DataItem>();
            var rnt = new Random();

            for (int i = 1; i < 51; i++)
            {
                dataList.Add(new DataItem() { X = i, Y = rnt.Next(10, 80) });
            }

            flexChart1.BeginUpdate();
            flexChart1.AxisY.Min = 0;
            flexChart1.AxisY.Max = 100;

            flexChart1.Series.Clear();

            flexChart1.ChartType = C1.Chart.ChartType.Line;

            var serie = new Series()
            {
                Name = "Base dataList",
                DataSource = dataList,
                Binding = "Y",
                BindingX = "X",
            };


            flexChart1.Series.Add(serie);

            flexChart1.EndUpdate();
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("basic", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("basic", "description").MakeRtf();
            baseSample1.pScroll.Controls.Remove(baseSample1.pControls);
            flexChart1 = baseSample1.flexChart1;
        }
        public class DataItem
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}
