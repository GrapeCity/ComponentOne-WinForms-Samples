using System;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart;
using C1.Win.Chart.Annotation;

namespace DrawingTools
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, String propertyName = null)
        {
            if (object.Equals(storage, value))
                return false;
            storage = value;
            if(PropertyChanged!=null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }

    class Options : BindableBase
    {
        DrawingType drawingType = DrawingType.None;

        public DrawingType DrawingType
        {
            get { return drawingType; }
            set { SetProperty<DrawingType>(ref drawingType, value, "DrawingType"); }
        }

        public bool HasSelection
        {
            get; set;
        }

        public bool HasDrawings
        {
            get; set;
        }
    }

    enum DrawingType
    {
        None,
        Marker,
        Line,
        Rectangle,
        Ellipse,
        Text,
        MovingAverage,
        Fibonacci
    }

    class DrawingLayer : AnnotationLayer
    {
        FlexChart _chart;
        Point _start;
        Point _last;
        Point _end;
        bool _moving;
        bool _adding;
        bool _confirm = true;

        IDrawing _selection, _new;

        Options options = new Options();

        string _status;

        DrawingToolbar _toolbar;

        ObservableCollection<IDrawing> _drawings = new ObservableCollection<IDrawing>();

        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    if(StatusChanged!=null)
                        StatusChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler StatusChanged;

        public Options Options
        {
            get { return options; }
        }

        public FlexChart Chart
        {
            get { return _chart; }
        }

        IDrawing Selection
        {
            get { return _selection; }
            set
            {
                if (_selection != value)
                {
                    _selection = value;
                    options.HasSelection = _selection != null;
                    _toolbar.Selection = _selection;
                }
            }
        }

        public DrawingLayer(FlexChart chart) : base(chart)
        {
            _chart = chart;
            AttachHandlers();

            _toolbar = new DrawingToolbar(chart, options);
            _toolbar.Remove += (s, e) => RemoveSelection();
            _toolbar.Clear += (s, e) => ClearDrawings();
            _toolbar.Add += (s, e) =>
            {
                Selection = null;
                _adding = true;
                chart.Cursor = Cursors.Cross;
                Status = string.Format("Draw {0}", options.DrawingType);
            };

             _drawings.CollectionChanged += (s, e) => options.HasDrawings = _drawings.Count > 0;
        }

        void AddDrawing(IDrawing drawing)
        {
            _drawings.Add(drawing);
            if(drawing.Annotation!=null)
               Annotations.Add(drawing.Annotation);
        }

        void ClearDrawings()
        {
            if(!_confirm || MessageBox.Show("Remove all drawings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Selection = null;
                foreach (var d in _drawings)
                    d.Remove();
                _drawings.Clear();
                options.DrawingType = DrawingType.None;
            }
        }

        void RemoveSelection()
        {
            if (Selection != null)
            {
                if (!_confirm || MessageBox.Show(_chart, "Remove selected drawing?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var sel = Selection;
                    Selection = null;
                    _drawings.Remove(sel);
                    sel.Remove();
                    options.DrawingType = DrawingType.None;
                }
            }
        }

        void AttachHandlers()
        {
            _chart.MouseDown += MouseDown;
            _chart.MouseMove += MouseMove;
            _chart.MouseUp += MouseUp;
            _chart.Rendered += Rendered;
        }

        private void Rendered(object sender, RenderEventArgs e)
        {
            if(Selection!=null)
                Selection.DrawSelection(e.Engine);
        }

        void MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_moving)
            {
                _end = e.Location;

                if (Selection != null)
                    Selection.Move(_end.X - _last.X, _end.Y - _last.Y);
                else if (_new != null)
                    _new.Update(_start.X, _start.Y, _end.X, _end.Y);
                _last = _end;
            }
        }

        void MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _last = _start = _end = e.Location;
            _moving = true;

            if (_adding)
            {
                _adding = false;
                _new = CreateAnnotation(new PointF(_start.X, _start.Y), new PointF(_end.X, _end.Y));
                if (_new != null)
                    AddDrawing(_new);
            }
            else
            {
                Selection = HitTest(e.X, e.Y);
                if (Selection != null)
                    Selection.MoveStart(e.X, e.Y);
            }
        }

        void MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _end = e.Location;
            _moving = false;

            if (_new != null)
            {
                if (Math.Abs(_end.X - _start.X) <= 1 && Math.Abs(_end.Y - _start.Y) <= 1)
                {
                    _end.X = _start.X + 100;
                    _end.Y = _start.Y + 100;
                }

                _new.Update(_start.X, _start.Y, _end.X, _end.Y);
                Selection = _new;
                _new = null;

                _chart.Cursor = Cursors.Default;
                Status = "Select or add drawing";
            }

            _chart.Refresh();

            options.DrawingType = DrawingType.None;
            if (Selection != null)
                options.DrawingType = Selection.DrawingType;
        }

        IDrawing CreateAnnotation(PointF start, PointF end)
        {
            IDrawing drawiing = null;

            switch (options.DrawingType)
            {
                case DrawingType.Marker:
                    drawiing = new MarkerDrawing(this, start);
                    break;
                case DrawingType.Line:
                    drawiing = new LineDrawing(this, start, end);
                    break;
                case DrawingType.Rectangle:
                    drawiing = new RectangleDrawing(this, start, end);
                    break;
                case DrawingType.Text:
                    drawiing = new TextDrawing(this, start);
                    break;
                case DrawingType.Ellipse:
                    drawiing = new EllipseDrawing(this, start, end);
                    break;
                case DrawingType.MovingAverage:
                    drawiing = new MovingAverageDrawing(this);
                    break;
                case DrawingType.Fibonacci:
                    drawiing = new FibonacciDrawing(this, start, end);
                    break;
            }

            return drawiing;
        }

        public _Point Convert(_Point pt)
        {
            return new _Point(_chart.AxisX.Convert(pt.X), _chart.AxisY.Convert(pt.Y));
        }

        public _Point ConvertBack(_Point pt)
        {
            return new _Point(_chart.AxisX.ConvertBack(pt.X), _chart.AxisY.ConvertBack(pt.Y));
        }

        IDrawing HitTest(double x, double y)
        {
            IDrawing d = null;
            foreach (var item in _drawings)
            {
                if (item.Distance(x, y) <= 10)
                {
                    d = item;
                    break;
                }
            }
            return d;
        }
    }
}
