using System.Drawing;
using C1.FlexMap;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapEarthQuakes : MapUserControl
    {
        public MapEarthQuakes()
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
            var layer = MapReader.LoadKmlFile("Resources\\2.5_day_depth.kml", (vector, data) =>
            {
                var placemark = vector as C1.Win.Map.VectorPlacemark;
                if (placemark == null) return;

                var name = data["name"] as string;
                placemark.Tag = name;
                placemark.Marker.Caption = name;
                placemark.Marker.Shape = MarkerShape.Custom;
                placemark.Marker.CustomShape=new EarthquakeShape();
                placemark.Marker.LabelPosition = LabelPosition.Right;
                placemark.Marker.Size = new SizeF(10, 6);
                placemark.LabelStyle.BackColor = Color.FromArgb(0x70, Color.White);
                placemark.LabelWidth = 150;
            });

            layer.Style.Stroke.Color = Color.FromArgb(0x90, 0xff, 0x00, 0x00);
            layer.Style.Stroke.Width = 2;
            layer.LabelVisibility = LabelVisibility.AutoHide;

            c1Map1.Layers.Add(layer);
        }
    }

    class EarthquakeShape : CustomShape
    {
        public override void Draw(Graphics g, RectangleF bounds, Style style)
        {
            using (var pen = new Pen(style.Stroke.Color, style.Stroke.Width))
            {
                var rect = new RectangleF(bounds.X, bounds.Y, bounds.Width - 4, bounds.Height);
                g.DrawEllipse(pen, rect);
                var x1 = rect.Right;
                var x2 = bounds.Right;
                var y = rect.Top + rect.Height/2;

                pen.Color = Color.LightGray;
                g.DrawLine(pen, x1, y, x2, y);
            }
        }
    }
}
