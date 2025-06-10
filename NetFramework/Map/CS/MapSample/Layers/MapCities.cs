using System.Drawing;
using System.Data;
using System.Linq;
using C1.FlexMap;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapCities : MapUserControl
    {
        public MapCities()
        {
            InitializeComponent();
        }

        protected override C1Map Map
        {
            get { return c1Map1; }
        }

        protected override void InitMap()
        {
            c1Map1.TileLayer.TileSource = new OpenStreetTileSource();
            base.InitMap();

            c1Map1.Viewport.Zoom = 2.5;

            var layer = new C1.Win.Map.VectorLayer {LabelVisibility = LabelVisibility.AutoHide};
            layer.LabelStyle.ForeColor = Color.FromArgb(0xC0, 0x50, 0x4d);
            layer.Style.BackColor = Color.FromArgb(0x80, Color.Gold);
            layer.Style.Stroke.Color = Color.FromArgb(0x80, Color.White);
            layer.Style.Stroke.Width = 1;
            c1Map1.Layers.Add(layer);

            using (var stream = MapReader.OpenFile("Resources\\Cities100K.txt"))
            {
                var cities = City.Read(stream);
                var top500 = cities.OrderByDescending(city => city.Population).Take(500);

                foreach (var city in top500)
                {
                    var mark = new C1.Win.Map.VectorPlacemark
                    {
                        Geometry = new GeoPoint(city.Location.X, city.Location.Y),
                        Lod = GetLod(city),
                        Tag = city.Name + ":\r\n" + city.Population,
                        Marker =
                        {
                            Size = GetSize(city),
                            Shape = MarkerShape.Circle,
                            Caption = city.Name,
                            LabelPosition = LabelPosition.Right
                        }
                    };

                    layer.Items.Add(mark);
                }
            }
        }

        private SizeF GetSize(City city)
        {
            var population = city.Population;

            int radius;
            if (population >= 2000000)
                radius = 6;
            else if (population >= 1000000)
                radius = 5;
            else if (population >= 7500000)
                radius = 4;
            else if (population >= 500000)
                radius = 3;
            else if (population >= 250000)
                radius = 2;
            else
                radius = 1;

            return new SizeF(radius*2, radius*2);
        }

        private LOD GetLod(City city)
        {
            var population = city.Population;

            if (population >= 2000000)
                return new LOD(0, 0, 0, 20);

            if (population >= 1000000)
                return new LOD(0, 0, 1, 20);

            if (population >= 7500000)
                return new LOD(0, 0, 2, 20);

            if (population >= 500000)
                return new LOD(0, 0, 3, 20);

            if (population >= 250000)
                return new LOD(0, 0, 4, 20);

            return new LOD(0, 0, 5, 20);
        }
    }
}
