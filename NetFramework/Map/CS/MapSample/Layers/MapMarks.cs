using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using C1.FlexMap;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapMarks : MapUserControl
    {
        private C1.Win.Map.VectorLayer _layer;
        private readonly Random _rnd = new Random();
        private C1.Win.Map.VectorItem _currentMark;
        private Point _offset;
        private int _index = 1;

        public MapMarks()
        {
            InitializeComponent();
        }

        protected override C1Map Map
        {
            get { return c1Map1; }
        }

        protected override void InitMap()
        {
            base.InitMap();
            c1Map1.TileLayer.TileSource = new OpenStreetTileSource();
            c1Map1.Viewport.Zoom = 2.5;
            _layer = new C1.Win.Map.VectorLayer();
            c1Map1.Layers.Add(_layer);

            c1Map1.MouseUp += c1Map1_MouseUp;
            c1Map1.MouseDown += c1Map1_MouseDown;
            c1Map1.MouseMove += c1Map1_MouseMove;

            for (var i = 0; i < 10; i++)
            {
                AddMark(-80 + _rnd.Next(160), -80 + _rnd.Next(160));
            }
        }

        private void AddMark(double lon, double lat)
        {
            var mark = new C1.Win.Map.VectorPlacemark();
            _layer.Items.Add(mark);

            mark.Geometry = new GeoPoint(lon, lat);
            mark.Marker.Size = new SizeF(20, 27.32f);
            mark.Marker.Shape = MarkerShape.Custom;
            mark.Marker.CustomShape = new MarkShape(_index++);
            mark.Style.Stroke.Color = Color.DarkGray;
            mark.Style.Stroke.Width = 1;
            mark.Style.BackColor = GetRandomColor(128, 192);
        }

        void c1Map1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _currentMark = null;
            var info = c1Map1.HitTest(e.Location);

            if (info == null || info.Type != HitTestType.VectorItem) return;

            if (ModifierKeys == Keys.Shift)
            {
                _currentMark = info.Vector;

                var geometry = (GeoPoint)_currentMark.Geometry;
                var location = c1Map1.GeographicToScreen(new C1.Win.Interop.Point(geometry.X, geometry.Y));
                _offset = new Point(e.Location.X - (int)location.X, e.Location.Y - (int)location.Y);
            }
            else if (ModifierKeys == Keys.Alt)
            {
                _layer.Items.Remove(info.Vector);
            }
        }

        void c1Map1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _currentMark = null;

            if (ModifierKeys == Keys.Control)
            {
                var p1 = c1Map1.GeographicToScreen(new C1.Win.Interop.Point(-180, 90));
                var p2 = c1Map1.GeographicToScreen(new C1.Win.Interop.Point(180, -90));
                var location = e.Location;
                if (location.X >= p1.X && location.X <= p2.X && location.Y >= p1.Y && location.Y <= p2.Y)
                {
                    var point = c1Map1.ScreenToGeographic(location);
                    AddMark(point.X, point.Y);
                }
            }
        }

        void c1Map1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (_currentMark != null && ModifierKeys == Keys.Shift)
            {
                var pt = e.Location;
                pt.X -= _offset.X;
                pt.Y -= _offset.Y;
                var location = c1Map1.ScreenToGeographic(pt);
                if (location.X < -180) location.X = -180;
                if (location.X > 180) location.X = 180;
                if (location.Y < -90) location.Y = -90;
                if (location.Y > 90) location.Y = 90;
                _currentMark.Geometry = new GeoPoint(location.X, location.Y);
            }
        }

        private Color GetRandomColor(byte min, byte a)
        {
            return Color.FromArgb(a, (byte)(min + _rnd.Next(255 - min)),
              (byte)(min + _rnd.Next(255 - min)), (byte)(min + _rnd.Next(255 - min)));
        }
    }

    internal class MarkShape : CustomShape
    {
        private readonly int _index;

        public MarkShape(int index)
        {
            _index = index;
        }

        public override RectangleF GetDrawingBounds(Graphics g, RectangleF bounds, Style style)
        {
            bounds.Y -= bounds.Height/2;
            return bounds;
        }

        public override bool IsVisible(Graphics g, RectangleF bounds, PointF point, Style style)
        {
            using (var path = CreateBaloon(bounds))
                return path.IsVisible(point);
        }

        public override void Draw(Graphics g, RectangleF bounds, Style style)
        {
            using (var path = CreateBaloon(bounds))
            {
                using (var brush = new SolidBrush(style.BackColor))
                    g.FillPath(brush, path);

                using (var pen = new Pen(style.Stroke.Color, style.Stroke.Width))
                    g.DrawPath(pen, path);

                var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
                using(var brush = new SolidBrush(style.ForeColor))
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(_index.ToString(CultureInfo.InstalledUICulture),
                        style.Font, brush, rect, sf);
                }
            }
        }

        private GraphicsPath CreateBaloon(RectangleF bounds)
        {
            var path = new GraphicsPath();
            var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
            path.AddArc(rect, 120, 300);
            rect = new RectangleF(bounds.Right - 10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, -120, -60);
            rect = new RectangleF(bounds.Left-10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, 0, -60);

            return path;
        }
    }
}
