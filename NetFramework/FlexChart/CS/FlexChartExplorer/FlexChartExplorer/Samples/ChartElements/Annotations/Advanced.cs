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
using C1.Win.Chart.Interaction;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Advanced : FlexChartBaseSample
    {
        private List<Quote> _stockData;
        private Font _contentFont = new Font("Segoe UI", 10, FontStyle.Bold);
        private Font _textFont = new Font("Segoe UI", 12);
        private C1.Win.Chart.Annotation.Rectangle _infoAnnotation;
        private AnnotationLayer annotationLayer;
        private C1.Win.Chart.Interaction.AxisScrollbar axisScrollbar;
        private FlexChart flexChart1;

        public Advanced()
        {
            InitializeComponent();
            SetupAnnotations();
        }
        private void SetupAnnotations()
        {
            annotationLayer = new AnnotationLayer(this.flexChart1);
            var lowestClose = _stockData.Min(y => y.Close);
            var highestClose = _stockData.Max(y => y.Close);
            //Two lines to show rising wedges
            var risingLine = new Line("Rising Wedges")
            {
                Start = new Point((int)_stockData[0].Date.ToOADate()+5, (int)lowestClose + 40),
                End = new Point((int)_stockData[0].Date.ToOADate()+65, (int)highestClose),
                Attachment = AnnotationAttachment.DataCoordinate,
            };
            risingLine.ContentStyle.StrokeColor = Color.Black;
            risingLine.ContentStyle.Font = _contentFont;
            risingLine.Style.StrokeColor = Color.Aqua;
            risingLine.Style.StrokeWidth = 1;

            var emptyLine = new Line()
            {
                Start = new Point((int)_stockData[0].Date.ToOADate() + 5, (int)lowestClose),
                End = new Point((int)_stockData[0].Date.ToOADate() + 65, (int)highestClose -40),
                Attachment = AnnotationAttachment.DataCoordinate,
            };
            emptyLine.Style.StrokeColor = Color.Aqua;
            emptyLine.Style.StrokeWidth = 1;

            annotationLayer.Annotations.Add(risingLine);
            annotationLayer.Annotations.Add(emptyLine);
            
            foreach(var stock in _stockData)
            {
                if (stock.Volume >= 180)
                {
                    var dSquare = new Square("D", 20)
                    {
                        SeriesIndex = 1,
                        PointIndex = _stockData.IndexOf(stock),
                        Attachment = AnnotationAttachment.DataIndex,
                        TooltipText = "Dividend"
                    };
                    dSquare.ContentStyle.StrokeColor = Color.White;
                    dSquare.ContentStyle.Font = _contentFont;
                    dSquare.Style.FillColor = Color.FromArgb(150, Color.Blue);
                    dSquare.Style.StrokeColor = Color.Transparent;
                    dSquare.Style.StrokeWidth = 1;
                    annotationLayer.Annotations.Add(dSquare);
                }
                if (stock.Date.Day % 10 == 0)
                {
                    var eSquare = new Square("E", 20)
                    {

                        SeriesIndex = 0,
                        PointIndex = _stockData.IndexOf(stock),
                        Attachment = AnnotationAttachment.DataIndex,
                        TooltipText = "Close"
                    };
                    eSquare.ContentStyle.StrokeColor = Color.Black;
                    eSquare.ContentStyle.Font = _contentFont;
                    eSquare.Style.FillColor = Color.FromArgb(150, Color.Aqua);
                    eSquare.Style.StrokeColor = Color.Black;
                    eSquare.Style.StrokeWidth = 1;
                    annotationLayer.Annotations.Add(eSquare);
                }
            }
            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(Properties.Resources.flag)
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = 25,
                Position = AnnotationPosition.Top,
            });
            var textJustD = new Text("Justdial Ltd")
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = 25,
                Position = AnnotationPosition.Left,
            };
            textJustD.Style.Font = _textFont;
            textJustD.Style.StrokeColor = Color.Black;
            annotationLayer.Annotations.Add(textJustD);
            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(Properties.Resources.flag)
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = 75,
                Position = AnnotationPosition.Top,
            });
            var textAli = new Text("Alibaba Group Holding Ltd")
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = 75,
                Position = AnnotationPosition.Left,
            };
            textAli.Style.Font = _textFont;
            textAli.Style.StrokeColor = Color.Black;
            annotationLayer.Annotations.Add(textAli);
            //Image annotations to show bid
            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(Properties.Resources.arrowDOWN)
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex=0,
                PointIndex = 30,
                TooltipText = "Bid : $75.3",
            });
            annotationLayer.Annotations.Add(new C1.Win.Chart.Annotation.Image(Properties.Resources.arrowUP)
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = 60,
                TooltipText = "Bid : $75.3",
            });
            //rectangle annotation to show HLOC values
            _infoAnnotation = new C1.Win.Chart.Annotation.Rectangle("", 100, 100)
            {
                Attachment = AnnotationAttachment.Absolute,
                Location = new PointF(100, 110),
            };
            _infoAnnotation.ContentStyle.StrokeColor = Color.Brown;
            _infoAnnotation.ContentStyle.Font = _contentFont;
            _infoAnnotation.Style.StrokeColor = Color.Chocolate;
            _infoAnnotation.Style.StrokeWidth = 1;
            _infoAnnotation.Style.FillColor = Color.FromArgb(200, Color.SandyBrown);
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            var close = new Series
            {
                Name = "Close", Binding = "Close",
                ChartType = ChartType.Line,
            };
            var Volume = new Series
            {
                Name = "Volume",
                Binding = "Volume",
                AxisY = new Axis { Max=800, Position= Position.Right}
            };
            this.flexChart1.Series.Add(close);
            this.flexChart1.Series.Add(Volume);
            this.flexChart1.AxisY.Min = 0;
            this.flexChart1.AxisY.Max = 175;
            this.flexChart1.DataSource = _stockData= FinancialDataSource.GetFinancialData();
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
            this.flexChart1.Rendered += FlexChart1_Rendered;
            this.flexChart1.AxisX.AxisLine = false;
        }

        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if (axisScrollbar == null)
            {
                axisScrollbar = new C1.Win.Chart.Interaction.AxisScrollbar(flexChart1.AxisX);
                axisScrollbar.ValueChanged += (s, ev)=>
                {
                    flexChart1.AxisX.Min = axisScrollbar.LowerValue;
                    flexChart1.AxisX.Max = axisScrollbar.UpperValue;
                };
            }
        }
        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flexChart1.PlotRect.Contains(e.Location))
            {
                var hitInfo = flexChart1.HitTest(e.Location, MeasureOption.X, 0);
                var data = _stockData[hitInfo.PointIndex];
                _infoAnnotation.Content = string.Format("High = {0} \nLow = {1} \nOpen={2} \nClose={3} \nVolume={4}", data.High, data.Low, data.Open, data.Close, data.Volume);
                if (!annotationLayer.Annotations.Contains(_infoAnnotation))
                {
                    annotationLayer.Annotations.Add(_infoAnnotation);
                }
            }
            else
            {
                annotationLayer.Annotations.Remove(_infoAnnotation);
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
