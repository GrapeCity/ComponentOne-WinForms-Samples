using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using C1.FlexMap;
using VectorItem = C1.Win.Map.VectorItem;
using VectorPolygon = C1.Win.Map.VectorPolygon;
using VectorPolyline = C1.Win.Map.VectorPolyline;

namespace MapSample.Layers
{
    public delegate void ProcessVectorItem(VectorItem vector, IGeoGeometryRecordData data);

    internal class MapReader
    {
        public static C1.Win.Map.VectorLayer LoadShpFile(string shpFile, string dbfFile, ProcessVectorItem processVector)
        {
            using(var shpStream = OpenFile(shpFile))
            using (var dbfStream = OpenFile(dbfFile))
            {
                var records = ShapeReader.Read(shpStream, dbfStream);
                var items = records.Select(record =>
                {
                    var vector = CreateVector(record);
                    if (vector != null && processVector != null)
                    {
                        processVector(vector, record.Data);
                    }
                    return vector;
                });

                var layer = new C1.Win.Map.VectorLayer();
                foreach (var item in items)
                {
                    layer.Items.Add(item);
                }

                return layer;
            }
        }

        public static Stream OpenFile(string file)
        {
            if (!File.Exists(file)) return null;
            try
            {
                return File.OpenRead(file);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static C1.Win.Map.VectorLayer LoadKmlFile(string filePath, ProcessVectorItem processVector)
        {
            using (var kmlStream = OpenFile(filePath))
            {
                var records = KmlReader.Read(kmlStream);
                var items = records.Select(record =>
                {
                    var vector = CreateVector(record);
                    if (vector != null && processVector != null)
                    {
                        processVector(vector, record.Data);
                    }
                    return vector;
                });

                var layer = new C1.Win.Map.VectorLayer();
                foreach (var item in items)
                {
                    layer.Items.Add(item);
                }

                return layer;
            }
        }

        private static VectorItem CreateVector(GeoGeometryRecord record)
        {
            VectorItem vector;

            switch (record.Geometry.Type)
            {
                case GeoGeometryType.Point:
                case GeoGeometryType.MultiPoint:
                    vector = new C1.Win.Map.VectorPlacemark();
                    break;
                case GeoGeometryType.Polygon:
                case GeoGeometryType.MultiPolygon:
                    vector = new VectorPolygon();
                    break;
                case GeoGeometryType.LineString:
                case GeoGeometryType.MultiLineString:
                    vector = new VectorPolyline();
                    break;
                default:
                    return null;
            }

            vector.GeometryData = WkCoder.ToBase64String(record.Geometry, WkCoder.WkbByteOrder.LittleEndian);
            return vector;
        }

        public static Color GetKmlStyleColor(string s)
        {
            if (string.IsNullOrEmpty(s)) return Color.Empty;

            UInt32 argb;
            if (!UInt32.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out argb))
                return Color.Empty;

            // aabbggrr
            var a = (byte)((argb & -16777216) >> 0x18);
            var b = (byte)((argb & 0xff0000) >> 0x10);
            var g = (byte)((argb & 0xff00) >> 8);
            var r = (byte)(argb & 0xff);
            return Color.FromArgb(a, r, g, b);
        }
    }
}
