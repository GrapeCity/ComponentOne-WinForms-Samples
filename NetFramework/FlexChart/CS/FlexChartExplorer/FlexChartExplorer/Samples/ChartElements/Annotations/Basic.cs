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
    public partial class Basic : FlexChartBaseSample
    {
        private C1.Win.Chart.Annotation.Shape _circle, _ellipse, _poly;
        private C1.Win.Chart.Annotation.Line _line;
        private C1.Win.Chart.Annotation.Image _img;
        private C1.Win.Chart.Annotation.Text _text;
        private C1.Win.Chart.Annotation.AnnotationLayer _annotationLayer;
        private List<InvestmentEquity> _data;
        private FlexChart flexChart1;

        public Basic()
        {
            InitializeComponent();
            SetupAnnotations();
        }
        private void SetupAnnotations()
        {
            _annotationLayer = new C1.Win.Chart.Annotation.AnnotationLayer(this.flexChart1);
            var orderedByAmount = _data.OrderBy(x => x.Amount).ToList();
            var orderedByReturn = _data.OrderBy(x => x.Return).ToList();
            //line annotation
            _line = new C1.Win.Chart.Annotation.Line("Range Of Investment Amount")
            {
                Attachment = AnnotationAttachment.DataCoordinate,
                Start = new PointF(orderedByAmount[0].Age, (float)orderedByAmount[0].Amount),
                End = new PointF(orderedByAmount[_data.Count - 1].Age, (float)orderedByAmount[_data.Count - 1].Amount),
                TooltipText = "This is Line Annotation\nAttachment : DataCoordinate",
            };
            _line.TooltipText = string.Concat(_line.TooltipText, string.Format("\nStart=({0}, {1:0}), End=({2}, {3:0})", _line.Start.X, _line.Start.Y*100, _line.End.X,_line.End.Y*100));
            _line.Style.StrokeColor = Color.SandyBrown;
            _line.Style.StrokeWidth = 3;
            _line.ContentStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            _line.ContentStyle.StrokeColor = Color.SandyBrown;
            //Circle annotation
            _circle = new C1.Win.Chart.Annotation.Circle()
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = _data.IndexOf(orderedByAmount[0]),
                Content = "Min Amount -\n" + orderedByAmount[0].Amount.ToString("c0"),
                Radius = 40,
                TooltipText = "This is Circle Annotation\nAttachment : DataIndex\nRadius : 40",
            };
            _circle.TooltipText = string.Concat(_circle.TooltipText, "\nSeries Index= 0, Point Index= " + _circle.PointIndex);
            _circle.Style.FillColor = Color.FromArgb(200, Color.OrangeRed);
            _circle.Style.StrokeColor = Color.Red;
            _circle.ContentStyle.StrokeColor = Color.White;
            //Ellipse annotation
            _ellipse = new C1.Win.Chart.Annotation.Ellipse()
            {
                Attachment = AnnotationAttachment.DataIndex,
                SeriesIndex = 0,
                PointIndex = _data.IndexOf(orderedByAmount[_data.Count - 1]),
                Content = "Max Amount -\n" + orderedByAmount[_data.Count - 1].Amount.ToString("c0"),
                Width = 100,Height=50,
                TooltipText = "This is Ellipse Annotation\nAttachment : DataIndex\n Height : 50, Width=100",
            };
            _ellipse.TooltipText = string.Concat(_ellipse.TooltipText, "\nSeries Index= 0, Point Index= " + _ellipse.PointIndex);
            _ellipse.Style.FillColor = Color.FromArgb(200, Color.Green);
            _ellipse.Style.StrokeColor = Color.Green;
            _ellipse.ContentStyle.StrokeColor = Color.White;
            //Rectangle annotations
            for(int i=1; i<_data.Count-1; i+=5)
            {
                if(_data[i].Amount!= orderedByAmount[0].Amount && _data[i].Amount!=orderedByAmount[_data.Count-1].Amount)
                {
                    var _rect = new C1.Win.Chart.Annotation.Rectangle(_data[i].Amount.ToString("c0"), 70, 21)
                    {
                        Attachment = AnnotationAttachment.DataIndex,
                        SeriesIndex = 0,
                        PointIndex = i,
                        TooltipText = "This is Rectangle Annotation\nAttachment : DataIndex\nWidth=70, Height=21",
                    };
                    _rect.TooltipText = string.Concat(_rect.TooltipText, "\nSeries Index= 0, Point Index= " + _rect.PointIndex);
                    _rect.Style.FillColor = Color.FromArgb(200, Color.LightBlue);
                    _rect.Style.StrokeColor = Color.LightBlue;
                    _annotationLayer.Annotations.Add(_rect);
                }
            }
            //Polygon annotation
            _poly = new C1.Win.Chart.Annotation.Polygon("Chart Shows Investment \nAmount,Invested By Various\nInvestors For Different Periods.")
            {
                Attachment = AnnotationAttachment.Absolute,
                Points =
                {
                    new PointF(140, 30),
                    new PointF(220, 20),
                    new PointF(300, 30),
                    new PointF(300, 100),
                    new PointF(140, 100),
                },
                ContentCenter = new PointF(220, 60),
                TooltipText = "This is Polygon Annotation\nAttachment : Absolute\nPoints : [(140,30),(220,20),(300,30),(300,100),(140,100)]",
            };
            _poly.Style.FillColor = Color.FromArgb(60, Color.CornflowerBlue);
            _poly.Style.StrokeColor = Color.DodgerBlue;
            _poly.ContentStyle.StrokeColor = Color.DodgerBlue;
            _poly.ContentStyle.Font = new Font("Segoe UI", 8);
            //Image Annotation
            _img = new C1.Win.Chart.Annotation.Image()
            {
                Attachment = AnnotationAttachment.Relative,
                SourceImage = Properties.Resources.C1,
                Width = 80,
                Height = 80,
                Location = new PointF(1, 0.11f),
                TooltipText = "This is Image Annotation\nAttachment : Relative\nLocation : {x:0.96, y:0.1}\nWidth=100, Height=100",
            };
            //Text Annotation
            _text = new C1.Win.Chart.Annotation.Text("Equity Investment Analysis")
            {
                Attachment = AnnotationAttachment.Relative,
                Location = new PointF(0.5f, 0.05f),
                TooltipText = "This is Text Annotation\nAttachment : Relative\nLocation : {x:0.45, y:0.1}",
            };
            _text.Style.Font = StyleInfo.ChartHeaderFont;
            _text.Style.StrokeColor = Color.Black;
            
            //Add Annotations to Annotation-layer
            _annotationLayer.Annotations.Add(_line);
            _annotationLayer.Annotations.Add(_circle);
            _annotationLayer.Annotations.Add(_ellipse);
            _annotationLayer.Annotations.Add(_poly);
            _annotationLayer.Annotations.Add(_img);
            _annotationLayer.Annotations.Add(_text);
        }
        protected override void SetupChart()
        {
            _data = FinancialDataSource.GetInvestmentData();
            
            this.flexChart1.Binding = "Amount";
            this.flexChart1.BindingX = "Age";
            this.flexChart1.DataSource = _data;

            this.flexChart1.AxisY.Format = "c0";
            this.flexChart1.AxisY.Max = 1200000;
            this.flexChart1.AxisY.Min = 0;
            this.flexChart1.AxisY.Title = "Investment Amount";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisX.Min = 0;
            this.flexChart1.AxisX.Title = "Age Of Investment(Years)";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Series.Add(new Series());
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
