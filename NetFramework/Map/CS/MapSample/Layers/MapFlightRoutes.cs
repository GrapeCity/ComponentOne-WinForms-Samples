using System;
using System.Drawing;
using C1.FlexMap;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapFlightRoutes : MapUserControl
    {
        private C1.Win.Map.VectorLayer _layerCities;
        private C1.Win.Map.VectorLayer _layerRoutesBern;
        private C1.Win.Map.VectorLayer _layerRoutesKiev;
        private Image _fromTargetImage;
        private Image _toTargetImage;

        public MapFlightRoutes()
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
            c1Map1.Viewport.Zoom = 1;
            _fromTargetImage = Image.FromFile("Resources\\fromTarget.png");
            _toTargetImage = Image.FromFile("Resources\\toTarget.png");

            _layerCities = new C1.Win.Map.VectorLayer();
            _layerCities.Items.Add(CreateCity("Bern", 7.4481, 46.9480, true));
            _layerCities.Items.Add(CreateCity("Kiev", 30.5367, 50.4422, true));
            _layerCities.Items.Add(CreateCity("Beijing", 116.3, 39.9, false));
            _layerCities.Items.Add(CreateCity("Tokyo", 139.7, 35.6, false));
            _layerCities.Items.Add(CreateCity("London", -0.1262, 51.5002, false));
            _layerCities.Items.Add(CreateCity("Vilnius", 25.2799, 54.6896, false));
            _layerCities.Items.Add(CreateCity("Brussels", 4.3676, 50.8371, false));
            _layerCities.Items.Add(CreateCity("Prague", 14.4205, 50.0878, false));
            _layerCities.Items.Add(CreateCity("Athens", 23.7166, 37.9792, false));
            _layerCities.Items.Add(CreateCity("Dublin", -6.2675, 53.3441, false));
            _layerCities.Items.Add(CreateCity("Oslo", 10.7387, 59.9138, false));
            _layerCities.Items.Add(CreateCity("Lisbon", -9.1355, 38.7072, false));
            _layerCities.Items.Add(CreateCity("Moscow", 37.6176, 55.7558, false));
            _layerCities.Items.Add(CreateCity("Belgrade", 20.4781, 44.8048, false));
            _layerCities.Items.Add(CreateCity("Bratislava", 17.1547, 48.2116, false));
            _layerCities.Items.Add(CreateCity("Ljubljana", 14.5060, 46.0514, false));
            _layerCities.Items.Add(CreateCity("Madrid", -3.7033, 40.4167, false));
            _layerCities.Items.Add(CreateCity("Stockholm", 18.0645, 59.3328, false));
            _layerCities.Items.Add(CreateCity("Paris", 2.3510, 48.8567, false));

            _layerRoutesBern = new C1.Win.Map.VectorLayer();
            _layerRoutesBern.Style.Stroke.Width = 1;
            _layerRoutesBern.Style.Stroke.Color = Color.Red;
            _layerRoutesBern.Opacity = 0.6;
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 4.3676, 50.8371));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 10.7387, 59.9138));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, -3.7033, 40.4167));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 14.4205, 50.0878));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 17.1547, 48.2116));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 20.4781, 44.8048));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 37.6176, 55.7558));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, 23.7166, 37.9792));
            _layerRoutesBern.Items.Add(CreateRoute(7.4481, 46.9480, -6.2675, 53.3441));

            _layerRoutesKiev = new C1.Win.Map.VectorLayer();
            _layerRoutesKiev.Style.Stroke.Width = 1;
            _layerRoutesKiev.Style.Stroke.Color = Color.Red;
            _layerRoutesKiev.Opacity = 0.6;
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 18.0645, 59.3328));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, -3.7033, 40.4167));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 14.5060, 46.0514));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 17.1547, 48.2116));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 20.4781, 44.8048));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 37.6176, 55.7558));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, -9.1355, 38.7072));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 25.2799, 54.6896));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 139.7, 35.6));
            _layerRoutesKiev.Items.Add(CreateRoute(30.5367, 50.4422, 116.3, 39.9));

            c1Map1.Layers.Add(_layerCities);
            c1Map1.Layers.Add(_layerRoutesKiev);
            c1Map1.Layers.Add(_layerRoutesBern);

            UpdateLayers();
        }

        private C1.Win.Map.VectorPlacemark CreateCity(string title, double lon, double lat, bool fromTarget)
        {
            var placemark = new C1.Win.Map.VectorPlacemark
            {
                Tag = title,
                Geometry = new GeoPoint(lon, lat),
                Marker = {Shape = MarkerShape.Custom}
            };
            var shape = new MarkerImageShape();
            if (fromTarget)
            {
                shape.Image = _fromTargetImage;
                placemark.Marker.Size = new SizeF(30, 30);
            }
            else
            {
                shape.Image = _toTargetImage;
                placemark.Marker.Size = new SizeF(20, 20);
            }
            placemark.Marker.CustomShape = shape;

            return placemark;
        }

        private C1.Win.Map.VectorPolyline CreateRoute(double lon1, double lat1, double lon2, double lat2)
        {
            var line = new C1.Win.Map.VectorPolyline
            {
                Geometry = new GeoLineString(new[]
                {
                    new GeoPoint(lon1, lat1),
                    new GeoPoint(lon2, lat2)
                })
            };
            return line;
        }

        private void UpdateLayers()
        {
            if (radRoutesBern.Checked)
            {
                _layerRoutesBern.Visible = true;
                _layerRoutesKiev.Visible = false;
                c1Map1.Viewport.Zoom = 2.5;
                c1Map1.Viewport.Center = new C1.Win.Interop.Point(7.4481, 46.9480);
            }
            else
            {
                _layerRoutesBern.Visible = false;
                _layerRoutesKiev.Visible = true;
                c1Map1.Viewport.Zoom = 2.5;
                c1Map1.Viewport.Center = new C1.Win.Interop.Point(10.5367, 50.4422);
            }
        }

        private void radRoutes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLayers();
        }
    }
}
