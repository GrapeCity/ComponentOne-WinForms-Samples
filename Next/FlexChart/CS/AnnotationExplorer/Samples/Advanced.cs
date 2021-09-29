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
using C1.Win.Chart.Interaction;

namespace AnnotationExplorer.Samples
{
    public partial class Advanced : UserControl
    {
        AxisScrollbar axisScrollbar;
        List<DataItem> dataList = new List<DataItem>();
        AnnotationLayer annotationLayer;
        C1.Win.Chart.Annotation.Rectangle infoAnnotation;

        public Advanced()
        {
            InitializeComponent();

            InitializeControls();

            SetupChart();

            SetupAnnotations();
        }

        private void SetupAnnotations()
        {
            annotationLayer = new AnnotationLayer(flexChart1);
            var greenRect = new C1.Win.Chart.Annotation.Rectangle("", 10580, 1285)
            {
                Location = new PointF((float)dataList[20].Date.ToOADate(), 100),
                Attachment = AnnotationAttachment.DataCoordinate,
                Position = AnnotationPosition.Right,
            };
            greenRect.ContentStyle.StrokeColor = Color.Black;
            greenRect.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            greenRect.Style.FillColor = Color.FromArgb(25, Color.Green);
            greenRect.Style.StrokeColor = Color.Transparent;
            greenRect.Style.StrokeWidth = 1;
            annotationLayer.Annotations.Add(greenRect);

            foreach (var data in dataList)
            {
                if (data.Volume >= 9)
                {
                    var dSquare = new C1.Win.Chart.Annotation.Square("D", 20)
                    {
                        SeriesIndex = 1,
                        PointIndex = dataList.IndexOf(data),
                        Attachment = AnnotationAttachment.DataIndex,
                        TooltipText = "Dividend"
                    };
                    dSquare.ContentStyle.StrokeColor = Color.White;
                    dSquare.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    dSquare.Style.FillColor = Color.FromArgb(150, Color.Blue);
                    dSquare.Style.StrokeColor = Color.Transparent;
                    dSquare.Style.StrokeWidth = 1;
                    annotationLayer.Annotations.Add(dSquare);
                }
                if (data.Date.Day % 10 == 0)
                {
                    var eSquare = new C1.Win.Chart.Annotation.Square("E", 20)
                    {

                        SeriesIndex = 0,
                        PointIndex = dataList.IndexOf(data),
                        Attachment = AnnotationAttachment.DataIndex,
                        TooltipText = "Close"
                    };
                    eSquare.ContentStyle.StrokeColor = Color.Black;
                    eSquare.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    eSquare.Style.FillColor = Color.FromArgb(150, Color.Aqua);
                    eSquare.Style.StrokeColor = Color.Black;
                    eSquare.Style.StrokeWidth = 1;
                    annotationLayer.Annotations.Add(eSquare);
                }
            }

            var lineRising = new C1.Win.Chart.Annotation.Line("Rising wedge")
            {

                Start = new Point((int)dataList[10].Date.ToOADate(), 20),
                End = new Point((int)dataList[40].Date.ToOADate(), 100),
                Attachment = AnnotationAttachment.DataCoordinate,
            };
            lineRising.ContentStyle.StrokeColor = Color.Black;
            lineRising.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lineRising.Style.StrokeColor = Color.Aqua;
            lineRising.Style.StrokeWidth = 1;
            annotationLayer.Annotations.Add(lineRising);
            var lineEmpty = new C1.Win.Chart.Annotation.Line("")
            {

                Start = new Point((int)dataList[20].Date.ToOADate(), 0),
                End = new Point((int)dataList[50].Date.ToOADate(), 80),
                Attachment = AnnotationAttachment.DataCoordinate,
            };
            lineEmpty.ContentStyle.StrokeColor = Color.Black;
            lineEmpty.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lineEmpty.Style.StrokeColor = Color.Aqua;
            lineEmpty.Style.StrokeWidth = 1;
            annotationLayer.Annotations.Add(lineEmpty);

            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(AnnotationExplorer.Properties.Resources.flag)
            {
                SeriesIndex = 0,
                PointIndex = 20,
                Attachment = AnnotationAttachment.DataIndex,
                Position = AnnotationPosition.Top
            });
            var txtFB = new C1.Win.Chart.Annotation.Text("Facebook inc to acquire LifeRail.")
            {
                SeriesIndex = 0,
                PointIndex = 20,
                Attachment = AnnotationAttachment.DataIndex,
                Position = AnnotationPosition.Left,
            };
            txtFB.Style.StrokeColor = Color.Black;
            txtFB.Style.Font = new Font(FontFamily.GenericSansSerif, 12);
            annotationLayer.Annotations.Add(txtFB);

            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(AnnotationExplorer.Properties.Resources.flag)
            {
                SeriesIndex = 0,
                PointIndex = 70,
                Attachment = AnnotationAttachment.DataIndex,
                Position = AnnotationPosition.Top,
            });
            var txtAli = new C1.Win.Chart.Annotation.Text("Alibaba Group Holding Ltd")
                        {
                            SeriesIndex = 0,
                            PointIndex = 70,
                            Attachment = AnnotationAttachment.DataIndex,
                            Position = AnnotationPosition.Left,
                        };
            txtAli.Style.StrokeColor = Color.Black;
            txtAli.Style.Font = new Font(FontFamily.GenericSansSerif, 12);
            annotationLayer.Annotations.Add(txtAli);

            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(AnnotationExplorer.Properties.Resources.arrowDOWN)
            {
                SeriesIndex = 0,
                PointIndex = 30,
                Attachment = AnnotationAttachment.DataIndex,
                TooltipText = "Bid: $73.59"
            });
            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(AnnotationExplorer.Properties.Resources.arrowUP)
            {
                SeriesIndex = 0,
                PointIndex = 50,
                Attachment = AnnotationAttachment.DataIndex,
                TooltipText = "Bid: $73.59"
            });

            infoAnnotation = new C1.Win.Chart.Annotation.Rectangle("", 120, 100)
            {
                Location = new PointF(130, 60),
                Attachment = AnnotationAttachment.Absolute,
            };
            infoAnnotation.ContentStyle.StrokeColor = Color.Brown;
            infoAnnotation.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            infoAnnotation.Style.FillColor = Color.FromArgb(200, Color.SandyBrown);
            infoAnnotation.Style.StrokeColor = Color.Chocolate;
            infoAnnotation.Style.StrokeWidth = 1;

        }

        void SetupChart()
        {
            var rnt = new Random();
            var current = new DateTime(DateTime.Now.Year, 1, 1);

            for (int j = 10, k = 30; k <= 110; j += 20, k += 20)
                for (int i = 1; i < 20; i++)
                {
                    current = current.AddDays(1);
                    var item = new DataItem()
                    {
                        Date = current,
                        Close = rnt.Next(j, k) + Math.Round(rnt.NextDouble(), 2),
                        Volume = rnt.Next(0, 10)
                    };
                    item.Hight = item.Close + Math.Round(rnt.NextDouble(), 2);
                    item.Low = item.Close - Math.Round(rnt.NextDouble(), 2);
                    item.Open = rnt.Next(100) % 2 == 0 ? item.Close - rnt.Next(2) - Math.Round(rnt.NextDouble(), 2) : item.Close + rnt.Next(2) + Math.Round(rnt.NextDouble(), 2);

                    dataList.Add(item);
                }

            flexChart1.BeginUpdate();
            flexChart1.AxisY.Min = 0;
            flexChart1.AxisY.Max = 110;

            flexChart1.Series.Clear();

            flexChart1.ChartType = C1.Chart.ChartType.Line;

            var close = new Series()
            {
                Name = "Close",
                DataSource = dataList,
                Binding = "Close",
                BindingX = "Date",
                ChartType = ChartType.Line
            };
            var volume = new Series()
            {
                Name = "Volume",
                DataSource = dataList,
                Binding = "Volume",
                BindingX = "Date",
                ChartType = ChartType.Bar
            };

            flexChart1.Series.Add(close);
            flexChart1.Series.Add(volume);

            flexChart1.EndUpdate();
        }

        private void flexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if (axisScrollbar == null)
            {
                axisScrollbar = new AxisScrollbar(flexChart1.AxisX);
                axisScrollbar.ValueChanged += XRangeSelector_ValueChanged;
            }
        }
        void XRangeSelector_ValueChanged(object sender, EventArgs e)
        {
            flexChart1.AxisX.Min = axisScrollbar.LowerValue;
            flexChart1.AxisX.Max = axisScrollbar.UpperValue;
        }

        private void flexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flexChart1.PlotRect.Contains(e.Location))
            {
                var ht = flexChart1.HitTest(e.Location, MeasureOption.X, 0);
                if (ht == null) return;

                var low = dataList[ht.PointIndex].Low;
                var hight = dataList[ht.PointIndex].Hight;
                var open = dataList[ht.PointIndex].Open;
                var close = dataList[ht.PointIndex].Close;
                var volume = dataList[ht.PointIndex].Volume;

                infoAnnotation.Content = string.Format(
                    "Low={0}\r\nHight={1}\r\nOpen={2}\r\nClose={3}\r\nVolume={4}", low, hight, open, close, volume
                    );

                if (!annotationLayer.Annotations.Contains(infoAnnotation))
                {
                    annotationLayer.Annotations.Add(infoAnnotation);
                }
                flexChart1.Refresh();
            }
            else
            {
                annotationLayer.Annotations.Remove(infoAnnotation);
            }
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("advanced", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("advanced", "description").MakeRtf();
            baseSample1.pScroll.Controls.Remove(baseSample1.pControls);
            flexChart1 = baseSample1.flexChart1;
            flexChart1.Rendered += flexChart1_Rendered;
            flexChart1.MouseMove += flexChart1_MouseMove;
        }
        public class DataItem
        {
            public double Hight { get; set; }
            public double Low { get; set; }
            public double Open { get; set; }
            public double Close { get; set; }
            public int Volume { get; set; }

            public DateTime Date { get; set; }
        }
    }

}
