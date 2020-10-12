using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.FlexMap;
using C1.Win.Map;
using VectorLayer = C1.Win.Map.VectorLayer;
using VectorPlacemark = C1.Win.Map.VectorPlacemark;
using VectorPolyline = C1.Win.Map.VectorPolyline;

namespace MapSample.Layers
{
    public partial class MapProjections : MapUserControl
    {
        public MapProjections()
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
            c1Map1.Viewport.Zoom = 1;
            cmbProjection.SelectedIndex = 0;
            
            CreateWorldMap();
            CreateGrids();
        }

        private void CreateWorldMap()
        {
            var layerWorld = MapReader.LoadKmlFile("Resources\\WorldMap.kmz", (vector, data) =>
            {
                var name = data["name"] as string;
                vector.Tag = name;
                vector.Style.BackColor = MapReader.GetKmlStyleColor(data[KmlReader.StyleFillColor] as string);

                var placemark = vector as VectorPlacemark;
                if (placemark != null)
                {
                    placemark.Marker.Caption = name;
                    placemark.Lod = new LOD(0, 0, 2, 20);
                }
            });

            layerWorld.LabelVisibility = LabelVisibility.AutoHide;
            layerWorld.LabelStyle.ForeColor = Color.FromArgb(0x97, 0x35, 0x35);
            c1Map1.Layers.Add(layerWorld);
        }

        private void CreateGrids()
        {
            var layer = new VectorLayer { LabelVisibility = LabelVisibility.Visible, Track = false };
            c1Map1.Layers.Add(layer);

            layer.LabelStyle.ForeColor = Color.DarkGray;
            layer.Style.Stroke.Color = Color.DarkGray;
            layer.Style.Stroke.Style = DashStyle.Dash;
            layer.Style.Stroke.Width = 1;

            for (int lon = -180; lon <= 180; lon += 30)
            {
                var points = new List<GeoPoint>();
                for (int lat = -85; lat <= 85; lat++)
                {
                    points.Add(new GeoPoint(lon, lat));
                }
                var pl = new VectorPolyline
                {
                    Geometry = new GeoLineString(points)
                };
                layer.Items.Add(pl);

                var lbl = Math.Abs(lon) + "°";
                if (lon > 0) lbl += "E";
                else if (lon < 0) lbl += "W";

                var pm = new VectorPlacemark
                {
                    Geometry = new GeoPoint(lon, 0),
                    Marker = { Caption = lbl, LabelPosition = LabelPosition.Top }
                };
                layer.Items.Add(pm);
            }

            for (int lat = -80; lat <= 80; lat += 20)
            {
                var points = new List<GeoPoint>();
                for (int lon = -180; lon <= 180; lon++)
                {
                    points.Add(new GeoPoint(lon, lat));
                }
                var pl = new VectorPolyline
                {
                    Geometry = new GeoLineString(points)
                };
                layer.Items.Add(pl);

                var lbl = Math.Abs(lat) + "°";
                if (lat > 0) lbl += "N";
                else if (lat < 0) lbl += "S";

                var pm = new VectorPlacemark
                {
                    Geometry = new GeoPoint(0, lat),
                    Marker = { Caption = lbl, LabelPosition = LabelPosition.Right }
                };
                layer.Items.Add(pm);
            }
        }

        private void cmbProjection_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cs = Map.CoordinateSystem as GeographicCoordinateSystem;
            if (cs == null) return;

            switch (cmbProjection.SelectedIndex)
            {
                case 0:
                    cs.Projection = new MercatorProjection();
                    break;
                case 1:
                    cs.Projection = new GallPetersProjection();
                    break;
                case 2:
                    cs.Projection = new SinusoidalProjection();
                    break;
                case 3:
                    cs.Projection = new BonneProjection(0, 30);
                    break;
            }

            c1Map1.Invalidate();
        }
    }
}
