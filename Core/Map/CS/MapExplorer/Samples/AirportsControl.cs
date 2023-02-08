using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapExplorer.Samples
{
    using C1.Win.Map;
    using MapExplorer.Samples.Layers;
    //using C1.FlexMap;
    using System.IO;

    public partial class AirportsControl : UserControl
    {
        #region fields

        private MapUserControl _mapControl;
        private VectorLayer _layerLand;
        private VectorLayer _layerAirports;

        #endregion

        #region ctor & dctor
        public AirportsControl()
        {
            InitializeComponent();
        }

        #endregion


        #region events

        private void AirportsControl_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                // Init map
                _mapControl = new MapUserControl();
                _mapControl.Dock = DockStyle.Fill;
                _mapControl.BackColor = Color.FromArgb(138, 180, 248);
                _mapControl.ToolTip = new ToolTip();

                var cb = new CheckBox() { Text = "Show Labels", Dock = DockStyle.Top };
                cb.CheckedChanged += (sender, args) => _layerAirports.LabelVisibility = cb.Checked ?
                    C1.FlexMap.LabelVisibility.AutoHide : C1.FlexMap.LabelVisibility.Hidden;

                this.Controls.Add(cb);
                this.Controls.Add(_mapControl);

                _layerLand = ReadGeoJsonFromResource("land.geojson", Color.FromArgb(187,226,198), Color.Transparent);
                _layerAirports = ReadGeoJsonFromResource("airports.geojson", Color.LightGray, Color.Gray);


                _mapControl.Map.BeginUpdate();
                _mapControl.Map.Layers.Add(_layerLand);
                _mapControl.Map.Layers.Add(_layerAirports);
                _mapControl.Map.EndUpdate();

                _mapControl.Map.ZoomToItems(_layerAirports.Items);
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
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MapExplorer.Resources." + name);

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
