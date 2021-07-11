using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text;
using System.Drawing.Design;
using System.Globalization;
using C1.C1Report.CustomFields.Maps;

namespace C1.C1Report.CustomFields
{
    public partial class Map
    {
        #region Nested types
        /// <summary>
        /// Abstract base class for map's spatial data rows.
        /// </summary>
        private abstract class SpatialDataRowBase
        {
            /// <summary>
            /// Initializes a new instance of SpatialDataRowBase.
            /// </summary>
            public SpatialDataRowBase()
            {
                Count = 1;
            }
            /// <summary>
            /// Gets or sets the count of this location's instances.
            /// </summary>
            public int Count { get; set; }
            /// <summary>
            /// Iterates through all points associated with the current row.
            /// </summary>
            /// <param name="action">The action to perform for each point.</param>
            public abstract void ForAllPoints(Action<double, double> action);
            /// <summary>
            /// Writes the content of the current row into a binary stream.
            /// May be used to compare instances of data rows.
            /// </summary>
            /// <param name="w">The binary stream to write to.</param>
            public virtual void Dump(BinaryWriter w)
            {
                w.Write(Count);
            }
        }

        /// <summary>
        /// Data row representing a single spatial location (point).
        /// </summary>
        private class PointsDataRow : SpatialDataRowBase
        {
            /// <summary>
            /// Gets or sets the longitude of the point.
            /// </summary>
            public double Longitude { get; set; }
            /// <summary>
            /// Gets or sets the latitude of the point.
            /// </summary>
            public double Latitude { get; set; }
            /// <summary>
            /// Gets or sets the caption associated with the point.
            /// </summary>
            public string Caption { get; set; }
            /// <summary>
            /// Gets or sets the font used to draw the caption.
            /// </summary>
            public Font Font { get; set; }
            /// <summary>
            /// Gets or sets the text color used to draw the caption.
            /// </summary>
            public Color TextColor { get; set; }
            /// <summary>
            /// Gets or sets the size of the marker, in 96 dpi pixels.
            /// </summary>
            public double MarkerSize { get; set; }
            /// <summary>
            /// Gets or sets the fill color of the marker.
            /// </summary>
            public Color MarkerFill { get; set; }
            /// <summary>
            /// Gets or sets the stroke color of the marker.
            /// </summary>
            public Color MarkerStroke { get; set; }
            /// <summary>
            /// Gets or sets the shape of the marker.
            /// </summary>
            public MarkerShape MarkerShape { get; set; }
            /// <summary>
            /// Overridden. Invokes the specified action for the current row.
            /// </summary>
            /// <param name="action">The action to perform for each point.</param>
            public override void ForAllPoints(Action<double, double> action)
            {
                action(Longitude, Latitude);
            }
            /// <summary>
            /// Writes the content of the current row into a binary stream.
            /// May be used to compare instances of data rows.
            /// </summary>
            /// <param name="w">The binary stream to write to.</param>
            public override void Dump(BinaryWriter w)
            {
                base.Dump(w);
                w.Write(Longitude);
                w.Write(Latitude);
                w.Write(Caption ?? string.Empty);
                // font is not variable between rows now, so we skip it
                // write font... todo if font becomes variable
                // ditto ForeColor
                w.Write(MarkerSize);
                w.Write(MarkerFill.ToArgb());
                w.Write(MarkerStroke.ToArgb());
                w.Write((int)MarkerShape);
            }
        }

        /// <summary>
        /// Data row representing a pair of spatial location connected by a line.
        /// </summary>
        private class LinesDataRow : SpatialDataRowBase
        {
            /// <summary>
            /// Gets or sets the longitude of the first end point of the line.
            /// </summary>
            public double Longitude0 { get; set; }
            /// <summary>
            /// Gets or sets the latitude of the first end point of the line.
            /// </summary>
            public double Latitude0 { get; set; }
            /// <summary>
            /// Gets or sets the longitude of the second end point of the line.
            /// </summary>
            public double Longitude1 { get; set; }
            /// <summary>
            /// Gets or sets the latitude of the second end point of the line.
            /// </summary>
            public double Latitude1 { get; set; }
            /// <summary>
            /// Gets or sets the caption associated with the line.
            /// </summary>
            public string Caption { get; set; }
            /// <summary>
            /// Gets or sets the color of the stroke used to draw the line.
            /// </summary>
            public Color LineStroke { get; set; }
            /// <summary>
            /// Gets or sets the dash style of the line.
            /// </summary>
            public DashStyle DashStyle { get; set; }
            /// <summary>
            /// Gets or sets the thickness of the line, in 96 dpi pixels.
            /// </summary>
            public double LineThickness { get; set; }
            /// <summary>
            /// Overridden. Invokes the specified action for the first and second end points of the line.
            /// </summary>
            /// <param name="action">The action to perform for each point.</param>
            public override void ForAllPoints(Action<double, double> action)
            {
                action(Longitude0, Latitude0);
                action(Longitude1, Latitude1);
            }
            /// <summary>
            /// Writes the content of the current row into a binary stream.
            /// May be used to compare instances of data rows.
            /// </summary>
            /// <param name="w">The binary stream to write to.</param>
            public override void Dump(BinaryWriter w)
            {
                base.Dump(w);
                w.Write(Longitude0);
                w.Write(Latitude0);
                w.Write(Longitude1);
                w.Write(Latitude1);
                w.Write(Caption ?? string.Empty);
                w.Write(LineStroke.ToArgb());
                w.Write((int)DashStyle);
                w.Write(LineThickness);
            }
        }

        /// <summary>
        /// A collection of spatial data rows used to build a map.
        /// </summary>
        private class SpatialDataTable : List<SpatialDataRowBase>
        {
            /// <summary>
            /// Gets the row type. Allowed types are <see cref="PointsDataRow"/> and <see cref="LinesDataRow"/>.
            /// </summary>
            public Type RowType { get; private set; }
            /// <summary>
            /// Gets the unique key of the map layer associated with the current table.
            /// </summary>
            public string LayerKey { get; private set; }
            /// <summary>
            /// Initializes a new instance of the SpatialDataTable class.
            /// </summary>
            /// <param name="rowType">The type of data rows (see <see cref="RowType"/>).</param>
            /// <param name="layerKey">The key of the map layer associated with this table.</param>
            public SpatialDataTable(Type rowType, string layerKey)
            {
                System.Diagnostics.Debug.Assert(typeof(SpatialDataRowBase).IsAssignableFrom(rowType));
                RowType = rowType;
                LayerKey = layerKey;
            }
            /// <summary>
            /// Creates a new data row (of <see cref="RowType"/> type).
            /// </summary>
            /// <returns>The new row instance.</returns>
            public SpatialDataRowBase NewRow()
            {
                return (SpatialDataRowBase)Activator.CreateInstance(RowType);
            }
            /// <summary>
            /// Writes the content of the current table into a binary stream.
            /// May be used to compare instances of data tables.
            /// </summary>
            /// <param name="w">The binary stream to write to.</param>
            public void Dump(BinaryWriter w)
            {
                this.ForEach((row) => row.Dump(w));
            }
        }

        /// <summary>
        /// Design time editor for the geocache file name.
        /// </summary>
        public class GeoCacheFileEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.Modal;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.CheckFileExists = false;
                    ofd.CheckPathExists = true;
                    ofd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                        return ofd.FileName;
                }
                return value;
            }
        }
        #endregion

        #region Infrastructure
        internal void ReportError(int cookie, string message)
        {
            if (!_reportedErrors.Contains(cookie))
            {
                MessageBox.Show(message, "Map Custom Field ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _reportedErrors.Add(cookie);
            }
        }

        internal void ResetReportedError(int cookie)
        {
            _reportedErrors.RemoveAll((c) => c == cookie);
        }

        internal bool IsLoading
        {
            get { return _loading; }
        }

        /// <summary>
        /// Enumerates all Map fields in the report,
        /// starting with the current map if <paramref name="includeSelf"/> is true.
        /// </summary>
        /// <param name="includeSelf">Whether to include the current map as the first element.</param>
        /// <returns>The sequence of all maps in the report.</returns>
        internal IEnumerable<Map> FindAllMaps(bool includeSelf)
        {
            if (includeSelf)
                yield return this;

            if (ParentReport != null)
            {
                foreach (Field f in ParentReport.Fields)
                    if (f is Map && f != this)
                        yield return (Map)f;
            }
        }

        internal static string GetFullPath(string path)
        {
            try
            {
                if (!Path.IsPathRooted(path))
                    path = Path.Combine(C1.C1Report.Util.PictureHolder.GetDefaultPath(), path);
                return path;
            }
            catch
            {
                return path;
            }
        }

        internal void SetKml(KmlLayer kmlLayer, Stream kmlStream, string layerKey)
        {
            AddingKmlItemDelegate addingItemProc = null;
            if (_runtime)
            {
                // TODO: maybe allow non-custom (i.e. report's main) data source here too?
                var layerData = string.IsNullOrEmpty(kmlLayer.ItemFilterExpr) ?
                    null :
                    MakeCustomData(kmlLayer.RecordSource);

                try
                {
                    addingItemProc = delegate(ref string itemName, out Color? stroke, out Color? fill, out bool trackCoords)
                    {
                        stroke = null;
                        fill = null;
                        trackCoords = false;

                        DataRowReportScriptContext context = null;
                        if (layerData != null)
                        {
                            try
                            {
                                // quote item name with ' doubling single quotes if any:
                                var filter = s_kmlItemNameRegex.Replace(kmlLayer.ItemFilterExpr,
                                    string.Format(CultureInfo.InvariantCulture, "'{0}'", itemName.Replace("'", "''")));
                                DataRow[] res = layerData.Select(filter);
                                if (res.Length > 0)
                                    context = new DataRowReportScriptContext(res[0]);
                                else // provide empty (dbnull) context values so that expressions still evaluate to something reasonable:
                                    context = new DataRowReportScriptContext(layerData.NewRow(), layerData.Columns);
                            }
                            catch
                            {
                                // eat select errors
                            }
                        }
                        if (context == null)
                            context = new DataRowReportScriptContext(null, null);
                        context.AddConstant(KmlLayer.varItemName, itemName);
                        bool itemVisible = Maps.Util.GetBool(ParentReport.Evaluate(kmlLayer.ItemVisibleExpr, context), true);
                        if (itemVisible)
                        {
                            var itemStyle = EvalStyleExpr<KmlItemStyle>(kmlLayer.ItemStyleExpr, KmlItemStyles, ExternalKmlItemStyle, kmlLayer.ItemStyle, context);
                            stroke = Maps.Util.IsColorEmpty(itemStyle.StrokeColor) ? (Color?)null : itemStyle.StrokeColor;
                            fill = Maps.Util.IsColorEmpty(itemStyle.FillColor) ? (Color?)null : itemStyle.FillColor;
                            itemName = string.IsNullOrEmpty(itemStyle.ItemNameExpr) ? itemName : Maps.Util.GetString(ParentReport.Evaluate(itemStyle.ItemNameExpr, context));
                            trackCoords = Maps.Util.GetBool(ParentReport.Evaluate(kmlLayer.ItemTrackExpr, context), true);
                        }
                        return itemVisible;
                    };
                }
                finally
                {
                    if (layerData != null)
                        layerData.Dispose();
                }
            }

            InitMapper();
            _c1mapper.UpdateKmlLayer(layerKey, kmlStream, addingItemProc);
        }

        internal void RemoveKmlLayer(string name)
        {
            InitMapper();
            _c1mapper.UpdateKmlLayer(name, null, null);
        }
        #endregion

        #region Privates
        private void InitMapper()
        {
            if (_c1mapper == null)
            {
                _c1mapper = new C1Mapper(this);
                Size s = GetFieldSizePixels();
                _c1mapper.Width = s.Width;
                _c1mapper.Height = s.Height;
            }
        }

        private void TermMapper()
        {
            if (_c1mapper != null)
            {
                _c1mapper = null;
            }
        }

        private void InitGeocoder(bool force)
        {
            if (_geocoder == null || force)
            {
                var path = _geoCachePath;
                if (!string.IsNullOrEmpty(path) && !Path.IsPathRooted(path))
                    path = Path.Combine(Application.StartupPath, path);
                _geocoder = new GeocoderGoogle(path, true);
            }
        }

        private void DisposeImage()
        {
            if (_image != null)
            {
                _image.Dispose();
                _image = null;
            }
        }

        private Image GetImage(bool designTime)
        {
            // If we have a cached image, AND neither our relevant properties
            // nor data (at runtime only) has changed - reuse the image:
            if (designTime)
            {
                bool same =
                    _image != null && // all property setters set cached image to null
                    GetFieldSizePixels() == new Size((int)_c1mapper.Width, (int)_c1mapper.Height);
                if (same)
                    return _image;
            }

            // get spatial and associated analytical data:
            List<SpatialDataTable> datas = GetMapDatas(designTime);

            // make and if design time, cache, image:
            InitMapper();
            DisposeImage();
            var image = BuildMap(datas, designTime);
            if (designTime)
                _image = image;

            // done:
            return image;
        }

        private Size GetFieldSizePixels()
        {
            // get field size
            Size sz = new Size((int)(Width / TwipsIn * ScreenDpiX), (int)(Height / TwipsIn * ScreenDpiY));

            // can't be empty <<B167>>
            if (sz.Width <= 0) sz.Width = 1;
            if (sz.Height <= 0) sz.Height = 1;

            // return field size
            return sz;
        }

        private List<KmlLayer> GetCalculatedKmlLayers()
        {
            var ret = new List<KmlLayer>();
            foreach (KmlLayer layer in Layers.FindAll((l) => l is KmlLayer && ((KmlLayer)l).Calculated))
                ret.Add(layer);
            return ret;
        }

        private Image BuildMap(List<SpatialDataTable> datas, bool designTime)
        {
            if (designTime)
            {
                foreach (KmlLayer layer in Layers.FindAll((l) => l is KmlLayer))
                    layer.RemoveFromOwner();
            }
            else
            {
                var calcLayers = GetCalculatedKmlLayers();
                calcLayers.ForEach((l) => l.RemoveFromOwner());
            }

            _c1mapper.ClearMarks();
            _c1mapper.ResetBoundingPoints();

            _c1mapper.Width = (this.Width * ScreenDpiX) / TwipsIn;
            _c1mapper.Height = (this.Height * ScreenDpiY) / TwipsIn;

            // 1st pass: add KML layers, retrieve coordinates from other layers for auto-zoom/center:
            foreach (LayerBase layer in Layers.FindAll((l) => l.Visible && (l is KmlLayer || l.Track)))
            {
                if (layer is KmlLayer)
                    ((KmlLayer)layer).SetKmlOnOwner();
                else // layer.Track
                {
                    SpatialDataTable dt = datas.Find((t) => t.LayerKey == layer.Key);
                    dt.ForEach((row) => row.ForAllPoints((lon, lat) => _c1mapper.AddBoundingPoint(lon, lat)));
                }
            }

            // now we can auto zoom/center as all relevant spatial data has been given to the mapper:
            _c1mapper.DoCenterAndZoom();

            // 2nd pass: add points/lines layers:
            foreach (LayerBase layer in Layers.FindAll((l) => l.Visible && !(l is KmlLayer)))
            {
                // considering that no of layers should not be large, this is ok:
                SpatialDataTable dt = datas.Find((t) => t.LayerKey == layer.Key);
                if (dt.RowType == typeof(PointsDataRow))
                {
                    var l = (PointsLayer)layer;
                    // clustering:
                    var clusterDist = l.ClusterDistance;
                    var maxClusterSize = 0;
                    if (clusterDist > 0)
                    {
                        for (int i = 0; i < dt.Count; ++i)
                        {
                            var r = (PointsDataRow)dt[i];
                            for (int j = dt.Count - 1; j > i; --j)
                            {
                                var r2 = (PointsDataRow)dt[j];
                                if (_c1mapper.DistancePix(r.Longitude, r.Latitude, r2.Longitude, r2.Latitude) < clusterDist)
                                {
                                    maxClusterSize = Math.Max(maxClusterSize, ++r.Count);
                                    dt.RemoveAt(j);
                                }
                            }
                        }
                    }
                    // spread styles among clusters:
                    var styleCount = l.ClusterStyles != null ? l.ClusterStyles.Count : 0;
                    var q = l.ClusterDistribution == ScaleType.Linear ? ((styleCount - 1f) / (maxClusterSize - 2f)) : 1f;
                    // add clustered points to the map:
                    dt.ForEach((row) =>
                        {
                            PointsDataRow r = (PointsDataRow)row;
                            if (r.Count > 1)
                            {
                                r.Caption = r.Count.ToString(CultureInfo.InvariantCulture);
                                if (styleCount > 0)
                                {
                                    // we have a style to apply:
                                    int idx;
                                    if (l.ClusterDistribution == ScaleType.Linear)
                                        idx = (int)Math.Round((r.Count - 2) * q);
                                    else
                                    {
                                        var t = Math.Log(r.Count - 1, maxClusterSize - 1);
                                        if (double.IsNaN(t))
                                            t = 0;
                                        idx = (int)Math.Round(t * (styleCount - 1d));
                                    }
                                    var s = l.ClusterStyles[idx];
                                    r.Font = s.Font;
                                    r.TextColor = s.TextColor;
                                    r.MarkerShape = s.Shape;
                                    // todo: eval expr here, allow to use Count?
                                    r.MarkerSize = Maps.Util.GetDouble(s.SizeExpr, MarkerStyle.c_SizeValue);
                                    r.MarkerStroke = s.StrokeColor;
                                    r.MarkerFill = s.FillColor;
                                }
                            }
                            _c1mapper.DrawPoint(layer.Key, r.Longitude, r.Latitude, r.Caption, r.Font, r.TextColor, r.MarkerShape, r.MarkerSize, r.MarkerStroke, r.MarkerFill);
                        }
                    );
                }
                else if (dt.RowType == typeof(LinesDataRow))
                {
                    // add lines to the map:
                    dt.ForEach((row) =>
                        {
                            LinesDataRow r = (LinesDataRow)row;
                            _c1mapper.DrawLine(layer.Key, r.Longitude0, r.Latitude0, r.Longitude1, r.Latitude1, r.LineStroke, r.DashStyle, r.LineThickness);
                        }
                    );
                }
            }

            // done:
            return _c1mapper.GetImage(TargetDpi, TargetDpi);
        }

        private DataTable MakeCustomData(string recordSource)
        {
            if (string.IsNullOrEmpty(recordSource))
                return null;

            DataTable dtCustom = new DataTable();
            string conn = ParentReport.DataSource.ConnectionString;
            string sql = ParentReport.Evaluate(recordSource).ToString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn); // <<B176>>
            da.Fill(dtCustom);
            return dtCustom;
        }

        private MarkerStyle ExternalMarkerStyle(string styleName)
        {
            foreach (Map map in FindAllMaps(false))
            {
                var style = map.MarkerStyles[styleName];
                if (style != null)
                    return style;
            }
            return null;
        }

        private LineStyle ExternalLineStyle(string styleName)
        {
            foreach (Map map in FindAllMaps(false))
            {
                var style = map.LineStyles[styleName];
                if (style != null)
                    return style;
            }
            return null;
        }

        private KmlItemStyle ExternalKmlItemStyle(string styleName)
        {
            foreach (Map map in FindAllMaps(false))
            {
                var style = map.KmlItemStyles[styleName];
                if (style != null)
                    return style;
            }
            return null;
        }

        private TStyle EvalStyleExpr<TStyle>(
            string styleExpr,
            MapOwnedCollectionBase<TStyle> styles,
            Func<string, TStyle> externalStyleGetter,
            TStyle defaultStyle,
            IReportScriptContext sc)
            where TStyle : MapStyleBase
        {
            TStyle style = null;
            int intIdx;
            var strIdx = Maps.Util.GetIndex(ParentReport.Evaluate(styleExpr, sc), out intIdx);
            if (!string.IsNullOrEmpty(strIdx))
            {
                style = styles[strIdx];
                if (style == null && externalStyleGetter != null)
                    style = externalStyleGetter(strIdx);
            }
            if (style == null && intIdx >= 0 && intIdx < styles.Count)
                style = styles[intIdx];
            if (style == null)
                style = defaultStyle;
            return style;
        }

        private void AddPointsRow(PointsLayer layer, SpatialDataTable pointsTable, IReportScriptContext sc)
        {
            bool markVisible = Maps.Util.GetBool(ParentReport.Evaluate(layer.MarkerVisibleExpr, sc), true);
            if (markVisible)
            {
                bool pointsOk;
                var loc = GetLocations(layer, sc, out pointsOk)[0];
                // If we got a location, add it (tbd: report misses?):
                if (pointsOk)
                {
                    var row = (PointsDataRow)pointsTable.NewRow();
                    // evaluate marker style
                    var markerStyle = EvalStyleExpr<MarkerStyle>(layer.MarkerStyleExpr, MarkerStyles, ExternalMarkerStyle, layer.MarkerStyle, sc);
                    row.Latitude = loc.Latitude;
                    row.Longitude = loc.Longitude;
                    row.Caption = Maps.Util.GetString(ParentReport.Evaluate(markerStyle.CaptionExpr, sc));
                    row.MarkerSize = Maps.Util.GetDouble(ParentReport.Evaluate(markerStyle.SizeExpr, sc), MarkerStyle.c_SizeValue);
                    row.MarkerStroke = markerStyle.StrokeColor;
                    row.MarkerFill = markerStyle.FillColor;
                    row.MarkerShape = markerStyle.Shape;
                    row.Font = markerStyle.Font;
                    row.TextColor = markerStyle.TextColor;
                    pointsTable.Add(row);
                }
            }
        }

        /// <summary>
        /// Adds data from a RecordSource specified for a points layer to a "points" data table.
        /// </summary>
        /// <param name="layer">The points layer being processed.</param>
        /// <param name="pointsTable">The points data table being built.</param>
        private void AddCustomDataToPointsTable(PointsLayer layer, SpatialDataTable pointsTable)
        {
            using (var dtCustom = MakeCustomData(layer.RecordSource))
                foreach (IReportScriptContext sc in DataTableReportScriptContext.Foreach(dtCustom))
                    AddPointsRow(layer, pointsTable, sc);
        }

        private void AddReportDataToPointsTable(PointsLayer layer, SpatialDataTable pointsTable)
        {
            foreach (IReportScriptContext sc in ForeachReportDataRow())
                AddPointsRow(layer, pointsTable, sc);
        }

        private void AddLinesRow(LinesLayer layer, SpatialDataTable linesTable, IReportScriptContext sc)
        {
            bool pointsOk;
            var locs = GetLocations(layer, sc, out pointsOk);
            if (pointsOk)
            {
                var row = (LinesDataRow)linesTable.NewRow();
                var lineStyle = EvalStyleExpr<LineStyle>(layer.LineStyleExpr, LineStyles, ExternalLineStyle, layer.LineStyle, sc);
                row.Longitude0 = locs[0].Longitude;
                row.Latitude0 = locs[0].Latitude;
                row.Longitude1 = locs[1].Longitude;
                row.Latitude1 = locs[1].Latitude;
                row.LineStroke = lineStyle.StrokeColor;
                row.DashStyle = lineStyle.DashStyle;
                row.LineThickness = Maps.Util.GetDouble(ParentReport.Evaluate(lineStyle.ThicknessExpr, sc), LineStyle.c_LineThickness);
                linesTable.Add(row);
            }
        }

        private void AddCustomDataToLinesTable(LinesLayer layer, SpatialDataTable linesTable)
        {
            using (var dtCustom = MakeCustomData(layer.RecordSource))
                foreach (IReportScriptContext sc in DataTableReportScriptContext.Foreach(dtCustom))
                    AddLinesRow(layer, linesTable, sc);
        }

        private void AddReportDataToLinesTable(LinesLayer layer, SpatialDataTable linesTable)
        {
            foreach (IReportScriptContext sc in ForeachReportDataRow())
                AddLinesRow(layer, linesTable, sc);
        }

        /// <summary>
        /// Gets the data table where each row describes a point that is to be plotted on the map.
        /// The columns of the table are as follows:
        /// <list type="bullet">
        /// 
        /// <item><term>Latitude</term><description>Numeric latitude value.</description></item>
        /// <item><term>Longitude</term><description>Numeric longitude value.</description></item>
        /// <item><term>Caption</term><description>Point caption text.</description></item>
        /// 
        /// </list>
        /// </summary>
        /// <param name="designTime"></param>
        /// <returns></returns>
        private List<SpatialDataTable> GetMapDatas(bool designTime)
        {
            List<SpatialDataTable> tables = new List<SpatialDataTable>();

            foreach (LayerBase l in Layers.FindAll((ll) => ll.Visible))
            {
                if (l is PointsLayer)
                {
                    var dtPoints = new SpatialDataTable(typeof(PointsDataRow), l.Key);
                    if (designTime)
                        AddSampleDataToPointsTable((PointsLayer)l, dtPoints);
                    else if (!string.IsNullOrEmpty(l.RecordSource))
                        AddCustomDataToPointsTable((PointsLayer)l, dtPoints);
                    else
                        AddReportDataToPointsTable((PointsLayer)l, dtPoints);
                    tables.Add(dtPoints);
                }
                else if (l is LinesLayer)
                {
                    var dtLines = new SpatialDataTable(typeof(LinesDataRow), l.Key);
                    if (designTime)
                        AddSampleDataToLinesTable((LinesLayer)l, dtLines);
                    else if (!string.IsNullOrEmpty(l.RecordSource))
                        AddCustomDataToLinesTable((LinesLayer)l, dtLines);
                    else
                        AddReportDataToLinesTable((LinesLayer)l, dtLines);
                    tables.Add(dtLines);
                }
                else if (l is KmlLayer)
                {
                    // nothing to do
                }
                else
                    System.Diagnostics.Debug.Assert(false, "unknown layer type");
            }
            return tables;
        }

        private void AddSampleDataToPointsTable(PointsLayer layer, SpatialDataTable dt)
        {
            int npoints = 15 / Layers.CountAll((l) => l.Visible && l is PointsLayer);
            var rnd = new Random(Layers.IndexOf(layer)); // this ensures same data for same layer but different points for different layers
            for (int i = 0; i < npoints; ++i)
            {
                PointsDataRow row = (PointsDataRow)dt.NewRow();
                var markerStyle = layer.MarkerStyle;
                row.Latitude = rnd.Next(SampleLatMin, SampleLatMax);
                row.Longitude = rnd.Next(SampleLonMin, SampleLonMax);
                row.Caption = string.Format(CultureInfo.InvariantCulture, "{0} {1}", layer.Caption, i);
                row.MarkerSize = MarkerStyle.c_SizeValue;
                row.MarkerStroke = markerStyle.StrokeColor;
                row.MarkerFill = markerStyle.FillColor;
                row.MarkerShape = markerStyle.Shape;
                row.Font = markerStyle.Font;
                row.TextColor = markerStyle.TextColor;
                dt.Add(row);
            }
        }

        private void AddSampleDataToLinesTable(LinesLayer layer, SpatialDataTable dt)
        {
            int nplines = 15 / Layers.CountAll((l) => l.Visible && l is LinesLayer);
            var rnd = new Random(Layers.IndexOf(layer)); // this ensures same data for same layer but different points for different layers
            for (int i = 0; i < nplines; ++i)
            {
                LinesDataRow row = (LinesDataRow)dt.NewRow();
                var lineStyle = layer.LineStyle;
                row.Latitude0 = rnd.Next(SampleLatMin, SampleLatMax);
                row.Longitude0 = rnd.Next(SampleLonMin, SampleLonMax);
                row.Latitude1 = rnd.Next(SampleLatMin, SampleLatMax);
                row.Longitude1 = rnd.Next(SampleLonMin, SampleLonMax);
                row.LineStroke = lineStyle.StrokeColor;
                row.DashStyle = lineStyle.DashStyle;
                dt.Add(row);
            }
        }

        /// <summary>
        /// Gets the geographical location of a point based on spatial data or location expression.
        /// If a data row is provided (not null), data (location expressions or spatial data) 
        /// is assumed to be actual fields in that row, and is NOT evaluated.
        /// If the data row is null, data is evaluated against the ParentReport, so may
        /// constitute expressions.
        /// </summary>
        /// <param name="layer">The map layer for which location is retrieved.</param>
        /// <param name="source">The data row (of the layer's custom data source) or null.</param>
        /// <param name="allOk">OUT: true if all points have numeric coordinates, false if at least one is a NaN.</param>
        /// <returns>Location, in geographical coordinates (X is longitude, Y is latitude).</returns>
        private List<LonLat<double>> GetLocations(LayerBase layer, IReportScriptContext context, out bool allOk)
        {
            allOk = true;
            Func<LonLat<string>, List<string>, LonLat<double>> getLoc = (lonlat, locExpr) =>
                {
                    if (locExpr != null)
                    {
                        // Make address string:
                        var sb = new StringBuilder();
                        for (int i = 0; i < locExpr.Count; ++i)
                        {
                            string s = ParentReport.Evaluate(locExpr[i], context) as string;
                            if (!string.IsNullOrEmpty(s))
                            {
                                sb.Append(s);
                                if (i < locExpr.Count - 1)
                                    sb.Append(", ");
                            }
                        }
                        return _geocoder.GetLocation(sb.ToString());
                    }
                    else
                    {
                        return new LonLat<double>(
                            Maps.Util.GetDouble(ParentReport.Evaluate(lonlat.Longitude, context)),
                            Maps.Util.GetDouble(ParentReport.Evaluate(lonlat.Latitude, context)));
                    }
                };

            var locExprs = layer.PointsLocationExpressions;
            var lonlats = layer.PointsLocations;
            var points = new List<LonLat<double>>(lonlats.Count);
            for (int i = 0; i < lonlats.Count; ++i)
            {
                LonLat<double> pt = getLoc(lonlats[i], locExprs[i]);
                points.Add(pt);
                if (allOk && (double.IsNaN(pt.Longitude) || double.IsNaN(pt.Latitude)))
                    allOk = false;
            }
            return points;
        }

        private IEnumerable<IReportScriptContext> ForeachReportDataRow()
        {
            // build table using parent recordsource
            IC1ReportRecordset rs = ParentReport.DataSource.Recordset as IC1ReportRecordset;
            if (rs != null)
            {
                // get current group values <<B168>>
                object[] gStart = GetGroupValues();

                // move up to the top of the current group <<B171>>
                // (the field could be in a detail or group footer section)
                int bkmk = rs.GetBookmark();
                for (; !rs.BOF(); rs.MovePrevious())
                {
                    // break at group start
                    object[] gNow = GetGroupValues();
                    if (IsGroupBreak(gStart, gNow))
                    {
                        rs.MoveNext();
                        break;
                    }
                }

                // loop through data:
                for (; !rs.EOF(); rs.MoveNext())
                {
                    // break at group end
                    object[] gNow = GetGroupValues();
                    if (IsGroupBreak(gStart, gNow))
                        break;

                    yield return null;
                }

                // restore bookmark
                rs.SetBookmark(bkmk);
            }
        }

        private object[] GetGroupValues()
        {
            // get last group
            int lastGroup = ((int)Section - 5) / 2;
            if (lastGroup < 0) lastGroup = -1;
            object[] values = new object[lastGroup + 1];

            // calculate values
            for (int i = 0; i < values.Length; i++)
            {
                string expr = ParentReport.Groups[i].GroupBy;
                values[i] = ParentReport.Evaluate(expr);
            }

            // return result
            return values;
        }

        private bool IsGroupBreak(object[] gv1, object[] gv2)
        {
            Debug.Assert(gv1.Length == gv2.Length);
            for (int i = 0; i < gv1.Length; i++)
            {
                if (!object.Equals(gv1[i], gv2[i]))
                    return true;
            }
            return false;
        }
        #endregion
    }
}
