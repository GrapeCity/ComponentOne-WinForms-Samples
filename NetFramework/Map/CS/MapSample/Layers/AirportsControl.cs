using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MapSample.Layers
{
    using C1.Win.C1Input;
    using C1.Win.Map;

    public partial class AirportsControl : MapUserControl
    {
        #region fields

        private C1Map c1Map;
        private VectorLayer _layerLand;
        private VectorLayer _layerAirports;

        #endregion

        #region ctor & dctor
        public AirportsControl()
        {
            InitializeComponent();
        }

        #endregion


        protected override C1Map Map => c1Map;

        protected override void InitMap()
        {
            c1Map = new C1Map() { Dock = DockStyle.Fill, BackColor = Color.FromArgb(138, 180, 248) };
            c1Map.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            c1Map.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            c1Map.PanTool.MarkerStyle.BackColor = System.Drawing.Color.FromArgb(131, 176, 202);
            c1Map.PanTool.PanStyle.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            c1Map.PanTool.PanStyle.Stroke.Color = System.Drawing.Color.FromArgb(168, 168, 168);
            c1Map.PanTool.PanStyle.Stroke.Width = 1F;
            c1Map.ZoomTool.ButtonStyle.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            c1Map.ZoomTool.ButtonStyle.Border.Color = System.Drawing.Color.FromArgb(168, 168, 168);
            c1Map.ZoomTool.ButtonStyle.Border.Width = 1;
            c1Map.ZoomTool.ButtonStyle.Border.RoundRadius.All = 3;
            c1Map.ZoomTool.Margin = new System.Windows.Forms.Padding(20, 70, 0, 0);
            c1Map.ZoomTool.ThumbStyle.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            c1Map.ZoomTool.ThumbStyle.Border.Color = System.Drawing.Color.FromArgb(138, 176, 198);
            c1Map.ZoomTool.ThumbStyle.Border.Width = 1;
            c1Map.ZoomTool.ThumbStyle.Border.RoundRadius.All = 3;
            c1Map.ZoomTool.TrackStyle.BackColor = System.Drawing.Color.FromArgb(203, 203, 203);
            c1Map.ZoomTool.TrackStyle.Border.Color = System.Drawing.Color.FromArgb(168, 168, 168);
            c1Map.ZoomTool.TrackStyle.Border.Width = 1;
            c1Map.ZoomTool.TrackStyle.Border.RoundRadius.All = 3;

            this.Controls.Add(c1Map);

            base.InitMap();

            var cb = new C1CheckBox() { Text = "Show Labels", Font = new Font("Segoe UI", 12 , FontStyle.Regular), Dock = DockStyle.Top, Padding = new Padding(10, 0, 0, 0), Margin = new Padding(15, 0, 0, 0) };
            cb.CheckedChanged += (send, args) => _layerAirports.LabelVisibility = cb.Checked ?
                C1.FlexMap.LabelVisibility.AutoHide : C1.FlexMap.LabelVisibility.Hidden;

            this.Controls.Add(cb);

            _layerLand = ReadGeoJsonFromResource("land.geojson", Color.FromArgb(187, 226, 198), Color.Transparent);
            _layerAirports = ReadGeoJsonFromResource("airports.geojson", Color.LightGray, Color.Gray);


            Map.BeginUpdate();
            Map.Layers.Add(_layerLand);
            Map.Layers.Add(_layerAirports);
            Map.EndUpdate();

            Map.ZoomToItems(_layerAirports.Items);
        }

        #region events

        private void AirportsControl_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                var cb = new C1CheckBox() { Text = "Show Labels", Margin = new Padding(0, 0, 20, 0) };
                cb.CheckedChanged += (send, args) => _layerAirports.LabelVisibility = cb.Checked ?
                    C1.FlexMap.LabelVisibility.AutoHide : C1.FlexMap.LabelVisibility.Hidden;

                this.Controls.Add(cb);

                _layerLand = ReadGeoJsonFromResource("land.geojson", Color.FromArgb(187,226,198), Color.Transparent);
                _layerAirports = ReadGeoJsonFromResource("airports.geojson", Color.LightGray, Color.Gray);


                Map.BeginUpdate();
                Map.Layers.Add(_layerLand);
                Map.Layers.Add(_layerAirports);
                Map.EndUpdate();

                Map.ZoomToItems(_layerAirports.Items);
            }
        }

        private static VectorItem CreateVector(C1.FlexMap.GeoGeometryRecord record)
        {
            VectorItem vector = null;

            switch (record.Geometry?.Type)
            {
                case C1.FlexMap.GeoGeometryType.Point:
                case C1.FlexMap.GeoGeometryType.MultiPoint:
                    VectorPlacemark p = new VectorPlacemark();
                    p.Marker.Shape = C1.FlexMap.MarkerShape.Circle;
                    p.Marker.Size = new SizeF(6, 6);
                    p.Marker.LabelPosition = C1.FlexMap.LabelPosition.Top;
                    p.Tag = p.Marker.Caption = record.Data["name_en"]?.ToString();
                    vector = p;
                    break;
                case C1.FlexMap.GeoGeometryType.Polygon:
                case C1.FlexMap.GeoGeometryType.MultiPolygon:
                    vector = new VectorPolygon();
                    break;
                case C1.FlexMap.GeoGeometryType.LineString:
                case C1.FlexMap.GeoGeometryType.MultiLineString:
                    vector = new VectorPolyline();
                    break;
                default:
                    return null;
            }

            vector.Geometry = record.Geometry;
            return vector;
        }

        VectorLayer ReadGeoJsonFromResource(string name, Color fill, Color stroke)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MapSample.Resources." + name);

            var records = C1.FlexMap.GeoJsonReader.Read(stream);
            var items = records.Select(record => CreateVector(record));

            var vl = new VectorLayer();
            foreach (var item in items)
            {
                if (item != null)
                {
                    item.Style.BackColor = fill;
                    item.Style.Stroke.Color = stroke;
                    vl.Items.Add(item);
                }
            }
            vl.LabelVisibility = C1.FlexMap.LabelVisibility.Hidden;
            return vl;
        }

        #endregion
    }
}
