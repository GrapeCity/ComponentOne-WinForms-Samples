using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapExplorer.Samples
{
    using MapExplorer.Samples.Layers;
    using SourceMaps = C1.FlexMap;
    using C1.Win.Map;
    using C1.FlexMap;

    public partial class RouteControl : UserControl
    {
        #region fields

        private MapUserControl _mapControl;
        private C1.Win.Map.VectorLayer _cityLayer;
        private C1.Win.Map.VectorLayer _routeLayer;

        #endregion

        #region ctor & dctor
        public RouteControl()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// Create pair from point of place and point of label
        /// </summary>
        /// <param name="sourceCity"></param>
        /// <returns></returns>
        private KeyValuePair<C1.Win.Map.VectorPlacemark, C1.Win.Map.VectorPlacemark> CreateTarget(City sourceCity)
        {
            // Create target point
            var place = new C1.Win.Map.VectorPlacemark
            {
                Tag = sourceCity.Title,
                Geometry = new GeoPoint(sourceCity.longitude, sourceCity.latitude),
                Marker = { Shape = MarkerShape.Custom }
            };

            var shape = new MarkerImageShape();
            shape.Image = MapExplorer.Properties.Resources.Target;
            place.Marker.Size = new SizeF(20, 20);
            place.Marker.CustomShape = shape;

            // Create target point
            var label = new C1.Win.Map.VectorPlacemark
            {
                Geometry = new GeoPoint(sourceCity.longitude - 0.1F, sourceCity.latitude + 0.16F),
            };
            label.Marker.Caption = sourceCity.Title;
            label.Marker.LabelAngle = -90F;
            label.LabelStyle.ForeColor = Color.Yellow;

            return 
                new KeyValuePair<C1.Win.Map.VectorPlacemark, C1.Win.Map.VectorPlacemark>(place, label);
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
                new City(){ latitude = 34.87F, longitude = 137.06F, Title = "Nishio" },      //Japan
                new City(){ latitude  = 34.87F, longitude = 138.3F, Title = "Yaizu" },       //Japan
                new City(){ latitude  = 34.97F, longitude = 136.64F, Title = "Yokkaichi" },  //Japan
                new City(){ latitude  = 34.82F, longitude = 137.39F, Title = "Toyokawa" },   //Japan
                new City(){ latitude  = 35.6F, longitude = 139.7F, Title = "Tokyo" }         //Japan
            };

            // Create points for each city
            cities.ForEach(x =>
            {
                var point = CreateTarget(x);
                _cityLayer.Items.Add(point.Key);
                _cityLayer.Items.Add(point.Value);
            });

            // Create route from Toyokawa to Tokyo
            var list = cities.OrderByDescending(x => x.longitude).ToList();
            for(int index = 1; index <= list.Count() - 1; index++)
            {
                var last = list[index - 1];
                var current = list[index];

                var route = CreateRoute(last, current);
                _routeLayer.Items.Add(route);
            }

            // Zoom in items
            var items = _cityLayer.Items.Cast<C1.Win.Map.VectorItem>().ToArray();
            _mapControl.Map.ZoomToItems(items);
        }

        #region events

        private void RouteControl_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                // Init map
                _mapControl = new MapUserControl(new OpenStreetTileSource());
                _mapControl.Map.Viewport.Zoom = 2.5;
                _mapControl.Dock = DockStyle.Fill;

                this.Controls.Add(_mapControl);

                // Create layers
                _cityLayer = new C1.Win.Map.VectorLayer();
                _cityLayer.LabelVisibility = LabelVisibility.Visible;
                _mapControl.Map.Layers.Add(_cityLayer);

                _routeLayer = new C1.Win.Map.VectorLayer();
                _routeLayer.Style.Stroke.Width = 2;
                _routeLayer.Style.Stroke.Color = Color.Red;
                _routeLayer.Opacity = 0.6;

                _mapControl.Map.Layers.Add(_routeLayer);

                // Create routes
                CreateRoutes();
            }
        }

        #endregion
    }

    /// <summary>
    /// Description of city
    /// </summary>
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
