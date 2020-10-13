using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.FlexMap;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapKml : MapUserControl
    {
        private readonly Countries _countries = new Countries();

        public MapKml()
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
            // read text data from resources
            foreach (var s in File.ReadAllLines("Resources\\gdp-ppp.txt"))
            {
                var ss = s.Split(new[] {'\t'}, StringSplitOptions.RemoveEmptyEntries);

                _countries.Add(new Country
                {
                    Name = ss[1].Trim(),
                    Value = double.Parse(ss[2], CultureInfo.InvariantCulture)
                });
            }

            // create palette
            var cvals = new ColorValues
            {
                new ColorValue {Color = Color.FromArgb(255, 241, 244, 255), Value = 0},
                new ColorValue {Color = Color.FromArgb(255, 241, 244, 255), Value = 5000},
                new ColorValue {Color = Color.FromArgb(255, 224, 224, 246), Value = 10000},
                new ColorValue {Color = Color.FromArgb(255, 203, 205, 255), Value = 20000},
                new ColorValue {Color = Color.FromArgb(255, 179, 182, 230), Value = 50000},
                new ColorValue {Color = Color.FromArgb(255, 156, 160, 240), Value = 100000},
                new ColorValue {Color = Color.FromArgb(255, 127, 132, 243), Value = 200000},
                new ColorValue {Color = Color.FromArgb(255, 89, 97, 230), Value = 500000},
                new ColorValue {Color = Color.FromArgb(255, 56, 64, 217), Value = 1000000},
                new ColorValue {Color = Color.FromArgb(255, 19, 26, 148), Value = 2000000},
                new ColorValue {Color = Color.FromArgb(255, 0, 3, 74), Value = 1.001*_countries.GetMax()}
            };
            _countries.Converter = cvals;

            // read world map from resources
            var layerWorld = MapReader.LoadKmlFile("Resources\\WorldMap.kmz", (vector, data) =>
            {
                var name = data["name"] as string;
                vector.Tag = name;

                var country = _countries[name];
                if (country != null) vector.Style.BackColor = country.Fill;

                var placemark = vector as C1.Win.Map.VectorPlacemark;
                if (placemark != null)
                {
                    placemark.Marker.Caption = name;
                    placemark.Lod = new LOD(0, 0, 2, 20);
                }
            });

            layerWorld.LabelVisibility = LabelVisibility.AutoHide;
            layerWorld.LabelStyle.ForeColor = Color.FromArgb(0x97, 0x35, 0x35);
            c1Map1.Layers.Add(layerWorld);

            // reserve space for legend
            c1Map1.Viewport.Margin = new Padding(0, 0, 100, 0);

            InitKmlLegend();
        }

        private void InitKmlLegend()
        {
            var cvals = (ColorValues)_countries.Converter;
            int cnt = cvals.Count;
            const float sz = 20;

            var legend = new C1.Win.Map.MapLegend
            {
                Alignment = ContentAlignment.MiddleRight,
                Layout = MapLegendLayout.Column
            };
            c1Map1.Legends.Add(legend);

            for (int i = 0; i < cnt - 1; i++)
            {
                ColorValue cv = cvals[i];

                var item = new C1.Win.Map.MapLegendItem {Kind = MapLegendItemKind.Rectangle};
                item.Style.BackColor = cv.Color;
                item.Style.BackColor2 = cvals[i + 1].Color;
                item.Style.GradientStyle = GradientStyle.Vertical;
                item.Style.Stroke.Color = Color.LightGray;
                item.Style.Stroke.Width = 1;
                item.Style.Alignment = ContentAlignment.MiddleLeft;
                item.Size = new SizeF(sz, sz);
                item.Label = cv.Value.ToString(CultureInfo.InvariantCulture);

                legend.Items.Add(item);
            }
        }
    }
}
