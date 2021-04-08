using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Map
{
    using C1.Win.Map;
    using C1.FlexMap;

    public partial class Routes : C1DemoForm
    {
        private C1Map _map;
        private MapUserControl _mapControl;
        private C1.Win.Map.VectorLayer _cityLayer;
        private C1.Win.Map.VectorLayer _routeLayer;
        private ComponentResourceManager _resources = new ComponentResourceManager(typeof(MapUserControl));

        public Routes()
        {
            InitializeComponent();
        }

        // Create pair from point of place and point of label.
        private KeyValuePair<C1.Win.Map.VectorPlacemark, C1.Win.Map.VectorPlacemark> CreateTarget(City sourceCity)
        {
            // Create target point.
            var place = new C1.Win.Map.VectorPlacemark
            {
                Tag = sourceCity.Title,
                Geometry = new GeoPoint(sourceCity.longitude, sourceCity.latitude),
                Marker = { Shape = MarkerShape.Custom }
            };

            var shape = new MarkerImageShape();            
            shape.Image = (Image)_resources.GetObject("Target");
            place.Marker.Size = new SizeF(20, 20);
            place.Marker.CustomShape = shape;

            // Create target point.
            var label = new C1.Win.Map.VectorPlacemark
            {
                Geometry = new GeoPoint(sourceCity.longitude - 0.1F, sourceCity.latitude + 0.16F),
            };
            label.Marker.Caption = sourceCity.Title;
            label.Marker.LabelAngle = -90F;
            label.LabelStyle.ForeColor = Color.Yellow;

            return new KeyValuePair<C1.Win.Map.VectorPlacemark, C1.Win.Map.VectorPlacemark>(place, label);
        }

        private C1.Win.Map.VectorPolyline CreateRoute(City startCity, City stopCity)
        {
            var line = new C1.Win.Map.VectorPolyline
            {
                Geometry = new GeoLineString(new[]
                {
                    new GeoPoint(startCity.longitude, startCity.latitude),
                    new GeoPoint(stopCity.longitude, stopCity.latitude)
                })
            };
            return line;
        }

        private void CreateRoutes()
        {
            var cities = new List<City>()
            {
                new City(){ latitude = 34.87F, longitude = 137.06F, Title = "Nishio" },
                new City(){ latitude  = 34.87F, longitude = 138.3F, Title = "Yaizu" },
                new City(){ latitude  = 34.97F, longitude = 136.64F, Title = "Yokkaichi" },
                new City(){ latitude  = 34.82F, longitude = 137.39F, Title = "Toyokawa" },
                new City(){ latitude  = 35.6F, longitude = 139.7F, Title = "Tokyo" }
            };

            // Create points for each city.
            cities.ForEach(x =>
            {
                var point = CreateTarget(x);
                _cityLayer.Items.Add(point.Key);
                _cityLayer.Items.Add(point.Value);
            });

            // Create route from Toyokawa to Tokyo.
            var list = cities.OrderByDescending(x => x.longitude).ToList();
            for(int index = 1; index <= list.Count() - 1; index++)
            {
                var last = list[index - 1];
                var current = list[index];

                var route = CreateRoute(last, current);
                _routeLayer.Items.Add(route);
            }

            // Zoom in items.
            var items = _cityLayer.Items.Cast<C1.Win.Map.VectorItem>().ToArray();
            _map.ZoomToItems(items);
        }

        private void RouteControl_Load(object sender, EventArgs e)
        {
            // Init map.
            _mapControl = new MapUserControl(new VirtualEarthHybridSource())
            {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(_mapControl);

            _map = _mapControl.Map;
            _map.Viewport.Zoom = 1;

            // Create layers.
            _cityLayer = new C1.Win.Map.VectorLayer();
            _cityLayer.LabelVisibility = LabelVisibility.Visible;
            _map.Layers.Add(_cityLayer);

            _routeLayer = new C1.Win.Map.VectorLayer();
            _routeLayer.Style.Stroke.Width = 2;
            _routeLayer.Style.Stroke.Color = Color.Red;
            _routeLayer.Opacity = 0.6;

            _map.Layers.Add(_routeLayer);

            // Create routes.
            CreateRoutes();
        }
    }

    // Description of city
    public class City
    {
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Title}, {latitude}X{longitude}";
        }
    }
}
