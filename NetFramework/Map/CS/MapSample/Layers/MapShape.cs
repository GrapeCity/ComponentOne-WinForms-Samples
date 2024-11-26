using System;
using System.Drawing;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapShape : MapUserControl
    {
        public MapShape()
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
            cmbCountry.SelectedIndex = 0;
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1Map1.Layers.Clear();

            switch (cmbCountry.SelectedIndex)
            {
                case 0:
                    var layerUsa = MapReader.LoadShpFile("Resources\\states.shp", "Resources\\states.dbf",
                        (vector, data) =>
                        {
                            vector.Tag = data["STATE_NAME"];
                        });
                    layerUsa.Style.BackColor = Color.Purple;
                    layerUsa.Style.Stroke.Color = Color.LightGray;
                    c1Map1.Layers.Add(layerUsa);

                    c1Map1.Viewport.Center = new C1.Win.Interop.Point(-115, 50);
                    c1Map1.Viewport.MinZoom = 2;
                    c1Map1.Viewport.Zoom = 4;
                    break;
                case 1:
                    var layerJapan = MapReader.LoadShpFile("Resources\\jp_toku_kuni_pgn.shp", "Resources\\jp_toku_kuni_pgn.dbf",
                        (vector, data) =>
                        {
                            vector.Tag = data["NAME_UTF"];
                        });
                    layerJapan.Style.BackColor = Color.Brown;
                    layerJapan.Style.Stroke.Color = Color.LightGray;
                    c1Map1.Layers.Add(layerJapan);

                    c1Map1.Viewport.Center = new C1.Win.Interop.Point(135, 37);
                    c1Map1.Viewport.MinZoom = 4;
                    c1Map1.Viewport.Zoom = 5.5;
                    break;
            }
        }

    }
}
