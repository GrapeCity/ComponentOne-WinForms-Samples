using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart;
using C1.Win.Chart.Annotation;

using ARectangle = C1.Win.Chart.Annotation.Rectangle;
using ALine = C1.Win.Chart.Annotation.Line;
using APolygon = C1.Win.Chart.Annotation.Polygon;
using AEllipse = C1.Win.Chart.Annotation.Ellipse;
using AText = C1.Win.Chart.Annotation.Text;

namespace DrawingTools
{
    interface IPropertyList
    {
        List<string> PropertyNames { get; }
    }

    interface IDrawing : IPropertyList
    {
        DrawingType DrawingType { get; }
        IAnnotationBase Annotation { get; }
        void MoveStart(double dx, double dy);
        void Move(double dx, double dy);
        void Update(double x1, double y1, double x2, double y2);
        void DrawSelection(IRenderEngine engine);
        double Distance(double x, double y);
        void Remove();
    }

    abstract class DrawingBase : IDrawing
    {
        protected IAnnotationBase _annotation;
        protected DrawingLayer _layer;

        public DrawingBase(DrawingLayer layer)
        {
            _layer = layer;
        }

        public IAnnotationBase Annotation
        {
            get { return _annotation; }
        }

        public abstract DrawingType DrawingType { get; }

        public virtual void MoveStart(double dx, double dy)
        {
        }

        public virtual void Move(double dx, double dy)
        {
        }

        public virtual void Update(double x1, double y1, double x2, double y2)
        {
        }

        public virtual void DrawSelection(IRenderEngine engine)
        {
            var rect = Bounds;
            engine.SetStroke(Brushes.Black);
            engine.SetStrokeThickness(1);
            engine.SetStrokePattern(null);
            engine.SetFill(null);
            engine.DrawRect(rect.Left - 1, rect.Top - 1, rect.Width + 2, rect.Height + 2);
            engine.SetFill(Brushes.White);
            var r = 4;
            engine.DrawEllipse(rect.Left, rect.Top, r, r);
            engine.DrawEllipse(rect.Left, rect.Bottom, r, r);
            engine.DrawEllipse(rect.Right, rect.Top, r, r);
            engine.DrawEllipse(rect.Right, rect.Bottom, r, r);
        }

        protected double Distance(double x1, double y1, double x2, double y2)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public virtual double Distance(double x, double y)
        {
            return Annotation.Distance(x, y);
        }

        protected virtual _Rect Bounds
        {
            get { return Annotation.Bounds; }
        }

        public virtual List<string> PropertyNames
        {
            get { return null; }
        }

        public virtual void Remove()
        {
            if (Annotation != null)
                _layer.Annotations.Remove(Annotation);
        }

        public override string ToString()
        {
            return DrawingType.ToString();
        }
    }

    class LineDrawing : DrawingBase
    {
        Element _movingEl = Element.Line;

        enum Element
        {
            Line,
            Start,
            End
        }

        public LineDrawing(DrawingLayer layer, PointF start, PointF end) : base(layer)
        {
            _annotation = CreateAnnotation(start, end);
        }

        public override DrawingType DrawingType
        {
            get { return DrawingType.Line; }
        }

        public override void MoveStart(double x, double y)
        {
            var chart = _layer.Chart;
            var line = Annotation as ALine;
            var start = chart.DataToPoint(line.Start);
            var end = chart.DataToPoint(line.End);

            if (Distance(x, y, start.X, start.Y) <= 5)
                _movingEl = Element.Start;
            else if (Distance(x, y, end.X, end.Y) <= 5)
                _movingEl = Element.End;
            else
                _movingEl = Element.Line;
        }

        public override void Move(double dx, double dy)
        {
            var chart = _layer.Chart;
            var line = Annotation as ALine;
            var start = chart.DataToPoint(line.Start);
            var end = chart.DataToPoint(line.End);

            if (_movingEl == Element.Start)
            {
                start.X += (float)dx;
                start.Y += (float)dy;
            }
            else if (_movingEl == Element.End)
            {
                end.X += (float)dx;
                end.Y += (float)dy;
            }
            else
            {
                start.X += (float)dx;
                start.Y += (float)dy;
                end.X += (float)dx;
                end.Y += (float)dy;
            }

            line.Start = chart.PointToData(start);
            line.End = chart.PointToData(end);
        }

        public override void Update(double x1, double y1, double x2, double y2)
        {
            var line = (ALine)Annotation;
            var start = new PointF((float)x1, (float)y1);
            var end = new PointF((float)x2, (float)y2);
            start = _layer.Chart.PointToData(start);
            end = _layer.Chart.PointToData(end);
            line.Start = start;
            line.End = end;
            line.Style.StrokeColor = Color.DarkGray;
        }

        public override void DrawSelection(IRenderEngine engine)
        {
            var rect = Annotation.Bounds;
            engine.SetStroke(Brushes.Black);
            engine.SetStrokeThickness(1);
            engine.SetStrokePattern(null);
            engine.SetFill(null);
            engine.DrawRect(rect.Left, rect.Top, rect.Width, rect.Height);
            engine.SetFill(Brushes.White);
            var r = 4;
            var chart = _layer.Chart;
            var line = Annotation as ALine;
            var start = chart.DataToPoint(line.Start);
            var end = chart.DataToPoint(line.End);
            engine.DrawEllipse(start.X, start.Y, r, r);
            engine.DrawEllipse(end.X, end.Y, r, r);
        }

        IAnnotationBase CreateAnnotation(PointF start, PointF end)
        {
            var ann = new ALine();
            ann.Attachment = AnnotationAttachment.DataCoordinate;
            start = _layer.Chart.PointToData(start);
            end = _layer.Chart.PointToData(end);
            ann.Start = new PointF(start.X, start.Y);
            ann.End = new PointF(end.X, end.Y);
            return ann;
        }

        public Color Stroke
        {
            get { return ((ALine)Annotation).Style.StrokeColor; }
            set { ((ALine)Annotation).Style.StrokeColor = value; }
        }

        public override List<string> PropertyNames
        {
            get { return new List<string>() { "Stroke" }; }
        }
    }

    class RectangleDrawing : DrawingBase
    {
        Element _movingEl = Element.Rect;

        enum Element
        {
            Rect,
            LeftTop,
            RightTop,
            RightBottom,
            LeftBottom
        }

        public RectangleDrawing(DrawingLayer layer, PointF start, PointF end) : base(layer)
        {
            _annotation = CreateAnnotation(start, end);
        }

        public override DrawingType DrawingType
        {
            get { return DrawingType.Rectangle; }
        }

        public override void MoveStart(double x, double y)
        {
            var pl = (APolygon)Annotation;
            _movingEl = Element.Rect;
            for (int i = 0; i < pl.Points.Count; i++)
            {
                var p = _layer.Convert(new _Point(pl.Points[i].X, pl.Points[i].Y));
                if (Distance(x, y, p.X, p.Y) <= 5)
                    _movingEl = (Element)(i + 1);
            }
        }

        public override void Move(double dx, double dy)
        {
            var pl = (APolygon)Annotation;
            switch (_movingEl)
            {
                case Element.Rect:
                    {
                        for (int i = 0; i < pl.Points.Count; i++)
                        {
                            var p = _layer.Convert(new _Point(pl.Points[i].X, pl.Points[i].Y));
                            p.X += dx; p.Y += dy;
                            p = _layer.ConvertBack(p);
                            pl.Points[i] = new PointF((float)p.X, (float)p.Y);
                        }
                        break;
                    }
                case Element.LeftTop:
                    {
                        var p = _layer.Convert(new _Point(pl.Points[0].X, pl.Points[0].Y));
                        p.X += dx; p.Y += dy;
                        p = _layer.ConvertBack(p);
                        pl.Points[0] = new PointF((float)p.X, (float)p.Y);

                        pl.Points[1] = new PointF(pl.Points[1].X, pl.Points[0].Y);
                        pl.Points[3] = new PointF(pl.Points[0].X, pl.Points[3].Y);
                        break;
                    }
                case Element.RightTop:
                    {
                        var p = _layer.Convert(new _Point(pl.Points[1].X, pl.Points[1].Y));
                        p.X += dx; p.Y += dy;
                        p = _layer.ConvertBack(p);
                        pl.Points[1] = new PointF((float)p.X, (float)p.Y);

                        pl.Points[0] = new PointF(pl.Points[0].X, pl.Points[1].Y);
                        pl.Points[2] = new PointF(pl.Points[1].X, pl.Points[2].Y);
                        break;

                    }
                case Element.RightBottom:
                    {
                        var p = _layer.Convert(new _Point(pl.Points[2].X, pl.Points[2].Y));
                        p.X += dx; p.Y += dy;
                        p = _layer.ConvertBack(p);
                        pl.Points[2] = new PointF((float)p.X, (float)p.Y);

                        pl.Points[1] = new PointF(pl.Points[2].X, pl.Points[1].Y);
                        pl.Points[3] = new PointF(pl.Points[3].X, pl.Points[2].Y);
                        break;

                    }
                case Element.LeftBottom:
                    {
                        var p = _layer.Convert(new _Point(pl.Points[3].X, pl.Points[3].Y));
                        p.X += dx; p.Y += dy;
                        p = _layer.ConvertBack(p);
                        pl.Points[3] = new PointF((float)p.X, (float)p.Y);

                        pl.Points[0] = new PointF(pl.Points[3].X, pl.Points[0].Y);
                        pl.Points[2] = new PointF(pl.Points[2].X, pl.Points[3].Y);
                        break;

                    }
            }
        }

        public override void Update(double x1, double y1, double x2, double y2)
        {
            var p = (APolygon)Annotation;
            var r = new _Rect(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            var start = new PointF((float)r.Left, (float)r.Top);
            var end = new PointF((float)r.Right, (float)r.Bottom);
            start = _layer.Chart.PointToData(start);
            end = _layer.Chart.PointToData(end);
            p.Points[0] = start;
            p.Points[1] = new PointF(end.X, start.Y);
            p.Points[2] = end;
            p.Points[3] = new PointF(start.X, end.Y);
            p.Style.StrokeColor = Color.DarkGray;
            p.Style.FillColor = Color.FromArgb(64, Color.DarkGray);
        }


        AnnotationBase CreateAnnotation(PointF start, PointF end)
        {
            var ann = new APolygon("");
            ann.Attachment = AnnotationAttachment.DataCoordinate;
            for (var i = 0; i < 4; i++)
                ann.Points.Add(new PointF());
            _annotation = ann;
            Update(start.X, start.Y, end.X, end.Y);

            return ann;
        }

        public Color Stroke
        {
            get { return ((APolygon)Annotation).Style.StrokeColor; }
            set { ((APolygon)Annotation).Style.StrokeColor = value; }
        }

        [Options("40a9a9a9,40ff0000,4000ff00,400000ff")]
        public Color Fill
        {
            get { return ((APolygon)Annotation).Style.FillColor; }
            set { ((APolygon)Annotation).Style.FillColor = value; }
        }

        public override List<string> PropertyNames
        {
            get { return new List<string>() { "Stroke", "Fill" }; }
        }
    }

    class MarkerDrawing : DrawingBase
    {
        public MarkerDrawing(DrawingLayer layer, PointF start) : base(layer)
        {
            _annotation = CreateAnnotation(start);
            UpdateSize();
        }

        public override DrawingType DrawingType
        {
            get { return DrawingType.Marker; }
        }

        public override void Move(double dx, double dy)
        {
            var pt = _layer.Convert(Annotation.Location);
            pt.X += dx; pt.Y += dy;
            Annotation.Location = _layer.ConvertBack(pt);
        }

        AnnotationBase CreateAnnotation(PointF start)
        {
            var ann = new ARectangle();
            ann.Position = AnnotationPosition.Center;
            ann.Attachment = AnnotationAttachment.DataCoordinate;

            var chart = _layer.Chart;
            ann.Location = chart.PointToData(start);
            ann.Style.FillColor = Color.Transparent;
            ann.Style.StrokeColor = Color.Transparent;
            ann.Style.StrokeWidth = 0f;

            ann.Content = "☀";
            ann.ContentStyle.StrokeColor = Color.DarkGray;
            ann.ContentStyle.Font = new Font("Segoe UI Symbol", 20);

            return ann;
        }

        void UpdateSize()
        {
            var a = (ARectangle)Annotation;
            var sz = _layer.Chart.CreateGraphics().MeasureString(a.Content, a.ContentStyle.Font);
            a.Width = sz.Width;
            a.Height = sz.Height;
        }

        [Options("☀,☹,☺,☠")]
        public string Marker
        {
            get { return ((ARectangle)Annotation).Content; }
            set { ((ARectangle)Annotation).Content = value; UpdateSize(); }
        }

        [Options("16,20,24,32,40")]
        public int Size
        {
            get { return (int)((ARectangle)Annotation).ContentStyle.Font.Size; }
            set
            {
                ((ARectangle)Annotation).ContentStyle.Font = new Font("Segoe UI Symbol", value); ;
                UpdateSize();
            }
        }

        public Color Stroke
        {
            get { return ((ARectangle)Annotation).ContentStyle.StrokeColor; }
            set { ((ARectangle)Annotation).ContentStyle.StrokeColor = value; }
        }

        public override List<string> PropertyNames
        {
            get { return new List<string>() { "Marker", "Size", "Stroke" }; }
        }
    }

    class TextDrawing : DrawingBase
    {
        public TextDrawing(DrawingLayer layer, PointF start) : base(layer)
        {
            _annotation = CreateAnnotation(start);
            UpdateSize();
        }

        public override DrawingType DrawingType
        {
            get { return DrawingType.Text; }
        }

        AnnotationBase CreateAnnotation(PointF start)
        {
            var ann = new ARectangle();
            ann.Position = AnnotationPosition.Center;
            ann.Attachment = AnnotationAttachment.DataCoordinate;

            var chart = _layer.Chart;
            ann.Location = chart.PointToData(start);

            ann.Style.FillColor = Color.Transparent;
            ann.Style.StrokeColor = Color.Transparent;
            ann.Style.StrokeWidth = 0f;

            ann.Content = "Text";
            ann.ContentStyle.StrokeColor = Color.DarkGray;
            ann.ContentStyle.Font = new Font("Segoe UI Symbol", 20);

            return ann;
        }

        void UpdateSize()
        {
            var a = (ARectangle)Annotation;
            var sz = _layer.Chart.CreateGraphics().MeasureString(a.Content, a.ContentStyle.Font);
            a.Width = sz.Width;
            a.Height = sz.Height;
        }

        public override void Move(double dx, double dy)
        {
            var pt = _layer.Convert(Annotation.Location);
            pt.X += dx; pt.Y += dy;
            Annotation.Location = _layer.ConvertBack(pt);
        }

        public string Text
        {
            get{ return ((ARectangle)Annotation).Content; }
            set{ ((ARectangle)Annotation).Content = value; }
        }

        [Options("16,20,24,32,40")]
        public int Size
        {
            get { return (int)((ARectangle)Annotation).ContentStyle.Font.Size; }
            set { ((ARectangle)Annotation).ContentStyle.Font = new Font("Segoe UI Symbol", value); ; UpdateSize(); }
        }

        public Color Stroke
        {
            get { return ((ARectangle)Annotation).ContentStyle.StrokeColor; }
            set { ((ARectangle)Annotation).ContentStyle.StrokeColor = value; }
        }

        public override List<string> PropertyNames
        {
            get { return new List<string>() { "Text", "Size", "Stroke" }; }
        }
    }

    class EllipseDrawing : DrawingBase
    {
        public EllipseDrawing(DrawingLayer layer, PointF start, PointF end) : base(layer)
        {
            _annotation = CreateAnnotation(start, end);
        }

        public override DrawingType DrawingType
        {
            get { return DrawingType.Ellipse; }
        }

        AnnotationBase CreateAnnotation(PointF start, PointF end)
        {
            var ann = new AEllipse();
            ann.Position = AnnotationPosition.Center;
            ann.Attachment = AnnotationAttachment.DataCoordinate;
            ann.Location = _layer.Chart.PointToData(start);
            _annotation = ann;
            Update(start.X, start.Y, end.X, end.Y);
            ann.Style.StrokeColor = Color.DarkGray;
            ann.Style.FillColor = Color.FromArgb(64, Color.DarkGray);
            return ann;
        }

        public override void Update(double x1, double y1, double x2, double y2)
        {
            var e = (AEllipse)Annotation;
            var r = new _Rect(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            var start = new PointF((float)r.Left, (float)r.Top);
            var end = new PointF((float)r.Right, (float)r.Bottom);
            start = _layer.Chart.PointToData(start);
            end = _layer.Chart.PointToData(end);
            e.Width = 2 * r.Width;
            e.Height = 2 * r.Height;
        }

        protected override _Rect Bounds
        {
            get
            {
                var e = (AEllipse)Annotation;
                var pt = _layer.Convert(new _Point(e.Location.X, e.Location.Y));
                return new _Rect(pt.X - 0.5 * e.Width, pt.Y - 0.5 * e.Height, e.Width, e.Height);
            }
        }

        public override double Distance(double x, double y)
        {
            if (IsInside(x, y))
                return 0;

            var e = (AEllipse)Annotation;
            var c = _layer.Convert(new _Point(e.Location.X, e.Location.Y));
            var a = Math.Atan2(x - c.X, y - c.Y);
            var p = new _Point(c.X + 0.5 * e.Width * Math.Cos(a), c.Y + 0.5 * e.Height * Math.Sin(a));
            return Distance(x, y, p.X, p.Y);
        }

        public override void Move(double dx, double dy)
        {
            var pt = _layer.Convert(Annotation.Location);
            pt.X += dx; pt.Y += dy;
            Annotation.Location = _layer.ConvertBack(pt);
        }

        public Color Stroke
        {
            get{ return ((AEllipse)Annotation).Style.StrokeColor; }
            set{ ((AEllipse)Annotation).Style.StrokeColor = value; }
        }

        [Options("40a9a9a9,40ff0000,4000ff00,400000ff")]
        public Color Fill
        {
            get { return ((AEllipse)Annotation).Style.FillColor; }
            set { ((AEllipse)Annotation).Style.FillColor = value; }
        }

        public override List<string> PropertyNames
        {
            get { return new List<string>() { "Stroke", "Fill" }; }
        }

        bool IsInside(double x, double y)
        {
            var e = (AEllipse)Annotation;
            var c = _layer.Convert(new _Point(e.Location.X, e.Location.Y));

            var dx = x - c.X;
            var dy = y - c.Y;
            var rx = 0.5 * e.Width;
            var ry = 0.5 * e.Height;

            return (dx * dx) / (rx * rx) + (dy * dy) / (ry * ry) <= 1;
        }
    }

    class MovingAverageDrawing : IDrawing
    {
        DrawingLayer _layer;
        C1.Win.Chart.Finance.MovingAverage _ma;

        public MovingAverageDrawing(DrawingLayer layer)
        {
            _layer = layer;
            _ma = new C1.Win.Chart.Finance.MovingAverage() { Binding = "Close", BindingX = "Date", Period = 7 };
            _layer.Chart.Series.Add(_ma);
        }

        public IAnnotationBase Annotation
        {
            get { return null; }
        }

        public DrawingType DrawingType
        {
            get { return DrawingType.MovingAverage; }
        }

        public double Distance(double x, double y)
        {
            var chart = _layer.Chart;
            var hti = chart.HitTest(new Point( (int)x, (int)y), MeasureOption.XY, chart.Series.IndexOf(_ma));
            //throw new NotImplementedException();
            return hti.Distance;
        }

        public void DrawSelection(IRenderEngine engine)
        {
            //throw new NotImplementedException();
        }

        public void Move(double dx, double dy)
        {
        }

        public void MoveStart(double dx, double dy)
        {
        }

        public void Update(double x1, double y1, double x2, double y2)
        {
        }

        public void Remove()
        {
           _layer.Chart.Series.Remove(_ma);
        }

        public Color Color
        {
            get { return _ma.Style.StrokeColor; }
            set { _ma.Style.StrokeColor = value; }
        }

        [Options("7,14,28,56")]
        public int Period
        {
            get { return _ma.Period; }
            set { _ma.Period = value; }
        }

        public List<string> PropertyNames
        {
            get { return new List<string>() { "Period", "Color" }; }
        }

        public override string ToString()
        {
            return "Moving Average";
        }
    }

    class FibonacciDrawing : IDrawing
    {
        enum Element
        {
            All,
            Start,
            End
        }

        DrawingLayer _layer;
        C1.Win.Chart.Finance.Fibonacci _ser;
        _Point _start;
        _Point _end;
        Element _movingEl = Element.All;

        public FibonacciDrawing(DrawingLayer layer, PointF start, PointF end)
        {
            _layer = layer;
            _ser= new C1.Win.Chart.Finance.Fibonacci();
            _ser.Style.StrokeWidth = 1;
            _ser.Style.StrokeColor = Color.Green;
            Update(start.X, start.Y, end.X, end.Y);
            _layer.Chart.Series.Add(_ser);
        }

        public IAnnotationBase Annotation
        {
            get { return null; }
        }

        public DrawingType DrawingType
        {
            get { return DrawingType.Fibonacci; }
        }

        public double Distance(double x, double y)
        {
            var r = Bounds;

            if (r.Contains(x, y))
                return 0;

            var start = _layer.Convert(_start);
            var end = _layer.Convert(_end);

            return Math.Min( MathUtils.Distance(start.X, start.Y, x, y), MathUtils.Distance(end.X, end.Y, x, y));
        }

        public void DrawSelection(IRenderEngine engine)
        {
            var rect = Bounds;
            engine.SetStroke(Brushes.Black);
            engine.SetStrokeThickness(1);
            engine.SetStrokePattern(null);
            engine.SetFill(null);
            engine.DrawRect(rect.Left - 1, rect.Top - 1, rect.Width + 2, rect.Height + 2);
            engine.SetFill(Brushes.White);
            var r = 4;

            var start = _layer.Convert(_start);
            var end = _layer.Convert(_end);
            engine.DrawEllipse(start.X, start.Y, r, r);
            engine.DrawEllipse(end.X, end.Y, r, r);
        }

        public void Move(double dx, double dy)
        {
            var start = _layer.Convert(_start);
            var end = _layer.Convert(_end);

            if (_movingEl == Element.Start)
            {
                start.X += dx; start.Y += dy;
            }
            else if (_movingEl == Element.End)
            {
                end.X += dx; end.Y += dy;
            }
            else
            {
                start.X += dx; start.Y += dy;
                end.X += dx; end.Y += dy;
            }
            Update(start.X, start.Y, end.X, end.Y);
        }

        public void MoveStart(double x, double y)
        {
            var start = _layer.Convert(_start);
            var end = _layer.Convert(_end);

            if (MathUtils.Distance(x, y, start.X, start.Y) <= 10)
                _movingEl = Element.Start;
            else if (MathUtils.Distance(x, y, end.X, end.Y) <= 10)
                _movingEl = Element.End;
            else
                _movingEl = Element.All;
        }

        public void Update(double x1, double y1, double x2, double y2)
        {
            _start = new _Point(x1, y1);
            _end = new _Point(x2, y2);

            var start = _layer.ConvertBack(_start);
            var end = _layer.ConvertBack(_end);
            _ser.Low = Math.Min(start.Y, end.Y);
            _ser.High = Math.Max(start.Y, end.Y);
            _ser.MinX = (double)Math.Min(start.X, end.X);
            _ser.MaxX = (double)Math.Max(start.X, end.X);
            _ser.Uptrend = start.Y <= end.Y;

            _start = start;
            _end = end;
        }

        public void Remove()
        {
            _layer.Chart.Series.Remove(_ser);
        }

        public Color Color
        {
            get { return _ser.Style.StrokeColor; }
            set { _ser.Style.StrokeColor = value; }
        }

        public List<string> PropertyNames
        {
            get { return new List<string>() { "Color" }; }
        }

        public override string ToString()
        {
            return "Fibonacci";
        }

        double MinX
        {
            get { return _ser.MinX == null ? _layer.Chart.AxisX.ActualMin : (_ser.MinX is DateTime ? ((DateTime)_ser.MinX).ToOADate() : (double)_ser.MinX); }
        }

        double MaxX
        {
            get { return _ser.MaxX == null ? _layer.Chart.AxisX.ActualMax : (_ser.MaxX is DateTime ? ((DateTime)_ser.MaxX).ToOADate() : (double)_ser.MaxX); }
        }

        _Rect Bounds
        {
            get
            {
                var st = new _Point(MinX, _ser.Low);
                var end = new _Point(MaxX, _ser.High);
                st = _layer.Convert(st);
                end = _layer.Convert(end);
                return new _Rect( Math.Min(st.X, end.X), Math.Min(st.Y, end.Y), Math.Abs(end.X - st.X), Math.Abs(end.Y - st.Y));
            }
        }
    }

    class MathUtils
    {
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
