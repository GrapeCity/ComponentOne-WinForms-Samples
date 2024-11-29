using System;
using System.Drawing;
using C1.FlexMap;
using C1.Win.Map;
using VectorLayer = C1.Win.Map.VectorLayer;
using VectorPlacemark = C1.Win.Map.VectorPlacemark;
using VectorPolyline = C1.Win.Map.VectorPolyline;

namespace MapSample.Layers
{
    public partial class MapGrid : MapUserControl
    {
        public MapGrid()
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
            c1Map1.Viewport.Zoom = 3;
            var layer = new VectorLayer { LabelVisibility = LabelVisibility.Visible, Track = false };
            c1Map1.Layers.Add(layer);

            layer.LabelStyle.ForeColor = Color.DarkGray;
            layer.Style.Stroke.Color = Color.DarkGray;
            layer.Style.Stroke.Style = DashStyle.Dash;
            layer.Style.Stroke.Width = 1;

            for (int lon = -180; lon <= 180; lon += 30)
            {
                var pl = new VectorPolyline
                {
                    Geometry = new GeoLineString(new[] { new GeoPoint(lon, -85), new GeoPoint(lon, 85) })
                };
                layer.Items.Add(pl);

                var lbl = Math.Abs(lon) + "°";
                if (lon > 0) lbl += "E";
                else if (lon < 0) lbl += "W";

                var pm = new VectorPlacemark
                {
                    Geometry = new GeoPoint(lon, 0),
                    Marker = {Caption = lbl, LabelPosition = LabelPosition.Top}
                };
                layer.Items.Add(pm);
            }

            for (int lat = -80; lat <= 80; lat += 20)
            {
                var pl = new VectorPolyline
                {
                    Geometry = new GeoLineString(new[] { new GeoPoint(-180, lat), new GeoPoint(180, lat) })
                };
                layer.Items.Add(pl);

                var lbl = Math.Abs(lat) + "°";
                if (lat > 0) lbl += "N";
                else if (lat < 0) lbl += "S";

                var pm = new VectorPlacemark
                {
                    Geometry = new GeoPoint(0, lat),
                    Marker = {Caption = lbl, LabelPosition = LabelPosition.Right}
                };
                layer.Items.Add(pm);
            }
        }
    }
}
