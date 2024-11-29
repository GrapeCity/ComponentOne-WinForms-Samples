using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using C1.FlexMap;
using C1.Win.Map;
using System.Xml.Serialization;
using VectorItem = C1.Win.Map.VectorItem;
using VectorLayer = C1.Win.Map.VectorLayer;

namespace MapSample.Layers
{
    public partial class MapFactories : MapUserControl
    {
        private DataBase _factories;

        public MapFactories()
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
            c1Map1.Viewport.Zoom = 2.5;
            using (var stream = MapReader.OpenFile("Resources\\database.xml"))
            {
                var serializer = new XmlSerializer(typeof (DataBase));
                _factories = (DataBase) serializer.Deserialize(stream);
            }

            var layerFactory = new VectorLayer();
            var factoryShape = new MarkerImageShape {Image = Image.FromFile("Resources\\factory.png")};
            var factoryMarker = new Marker
            {
                Size = new SizeF(60, 60),
                Shape = MarkerShape.Custom,
                CustomShape = factoryShape
            };
            foreach (var factory in _factories.Factories)
            {
                var item = new C1.Win.Map.VectorPlacemark
                {
                    Geometry = new GeoPoint(factory.Longitude, factory.Latitude),
                    Marker = factoryMarker,
                    Tag = factory.Name
                };
                layerFactory.Items.Add(item);
            }
            c1Map1.Layers.Add(layerFactory);

            var layerOffice = new VectorLayer();
            foreach (var office in _factories.Offices)
            {
                var item = new C1.Win.Map.VectorPlacemark
                {
                    Geometry = new GeoPoint(office.Longitude, office.Latitude),
                    Tag = office.Name
                };
                var officeMarker = new Marker
                {
                    Size = new SizeF(60, 60),
                    Shape = MarkerShape.Custom,
                    CustomShape = new OfficeShape(office)
                };
                item.Marker = officeMarker;

                item.Style.Font = new Font("Arial", 9f);

                layerOffice.Items.Add(item);
            }
            c1Map1.Layers.Add(layerOffice);

            var layerStore = new VirtualLayer();
            layerStore.Slices.Add(new MapSlice(0, 1, 1));
            var storeSlices = (int)Math.Pow(2, LocalStoreSource.MinStoreZoom);
            layerStore.Slices.Add(new MapSlice(LocalStoreSource.MinStoreZoom, storeSlices, storeSlices));
            layerStore.ItemsSource = new LocalStoreSource(_factories);
            c1Map1.Layers.Add(layerStore);
        }
    }

    public class LocalStoreSource : IMapVirtualSource
    {
        public const double MinStoreZoom = 10.5d;

        private readonly DataBase _dataBase;
        private readonly Marker _marker;

        public LocalStoreSource(DataBase localDataBase)
        {
            _dataBase = localDataBase;

            var marker = new Marker {Size = new SizeF(60, 60), Shape = MarkerShape.Custom};
            var shape = new MarkerImageShape {Image = Image.FromFile("Resources\\store.png")};
            marker.CustomShape = shape;
            _marker = marker;
        }

        public IEnumerable<VectorItem> Request(double minZoom, double maxZoom, C1.Win.Interop.Point lowerLeft, C1.Win.Interop.Point upperRight)
        {
            if (minZoom < MinStoreZoom)
                return null;

            return (from store in _dataBase.Stores
                where store.Latitude > lowerLeft.Y
                      && store.Longitude > lowerLeft.X
                      && store.Latitude <= upperRight.Y
                      && store.Longitude <= upperRight.X
                select new C1.Win.Map.VectorPlacemark
                {
                    Geometry = new GeoPoint(store.Longitude, store.Latitude),
                    Marker = _marker
                }).Cast<VectorItem>().ToList();
        }
    }

    public class OfficeShape : CustomShape
    {
        private readonly Image _image = Image.FromFile("Resources\\office.png");
        private readonly Office _office;

        public OfficeShape(Office office)
        {
            _office = office;
        }

        public override void Draw(Graphics g, RectangleF bounds, Style style)
        {
            g.DrawImage(_image, bounds);

            var rect = new RectangleF(bounds.Right - 24, bounds.Top - 12, 24, 24);
            using (var brush = new SolidBrush(Color.FromArgb(0xaa, Color.Black)))
                g.FillEllipse(brush, rect);
            using (var pen = new Pen(Color.Green))
                g.DrawEllipse(pen, rect);

            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                using (var brush = new SolidBrush(Color.White))
                    g.DrawString(_office.Stores.ToString(CultureInfo.InvariantCulture), style.Font, brush, rect, sf);
            }
        }
    }
}
