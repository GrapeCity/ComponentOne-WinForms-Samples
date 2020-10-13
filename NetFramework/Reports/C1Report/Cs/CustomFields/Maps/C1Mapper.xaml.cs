#define DYN // AMIC

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Threading;
#if !DYN
using C1.WPF.Maps;
#endif
using C1.C1Preview;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Provides functionality that allows to use the C1.WPF.Maps.C1Maps control
    /// to generate maps in reports.
    /// </summary>
    /// <remarks>
    /// TODO:
    /// - allow to specify keys for tile sources that require it (CloudMadeMapsSource);
    /// - ?
    /// </remarks>
#if WPF
    [Microsoft.Windows.Design.ToolboxBrowsable(false)]
#endif
    public partial class C1Mapper : UserControl
    {
        #region private data
        private IMapperOwner _owner;
        private bool _doingEvents = false; // prevent recursion
        //
#if !DYN
        private C1.WPF.Maps.C1Maps _c1maps;
#else
        private dynamic _c1maps;
#endif
        // hack: we assume that all's ok but when time comes, we wait a bit
        // so that TilesLoadProgress has a chance to run, if it runs at all:
        private int _tilesRemaining = 0;
        //
        private List<MapsLayerBase> _layers = new List<MapsLayerBase>();
        // client-set bounds for auto-zoom (united with KML bounds by the mapper):
        private Rect _boundingRect = Rect.Empty;
        #endregion

        #region nested types
        /// <summary>
        /// C1Maps limits/constants:
        /// </summary>
        private static class Limits
        {
#if !DYN
            public static double MinLat = C1.WPF.Maps.C1Maps.MinLat;
            public static double MaxLat = C1.WPF.Maps.C1Maps.MaxLat;
            public static double MinLong = C1.WPF.Maps.C1Maps.MinLong;
            public static double MaxLong = C1.WPF.Maps.C1Maps.MaxLong;
            public static double MinZoom = C1.WPF.Maps.C1Maps.MinZoom;
            public static double MaxZoom = C1.WPF.Maps.C1Maps.MaxZoom;
#else
            public static double MinLat = (double)DynLoader.GetC1MapsStaticFieldValue("MinLatValue");
            public static double MaxLat = (double)DynLoader.GetC1MapsStaticFieldValue("MaxLatValue");
            public static double MinLong = (double)DynLoader.GetC1MapsStaticFieldValue("MinLongValue");
            public static double MaxLong = (double)DynLoader.GetC1MapsStaticFieldValue("MaxLongValue");
            public static double MinZoom = (double)DynLoader.GetC1MapsStaticFieldValue("MinZoomValue");
            public static double MaxZoom = (double)DynLoader.GetC1MapsStaticFieldValue("MaxZoomValue");
#endif
            public static int MercatorMapWidth = 512; // from C1Maps.ViewportWidth
        }

        private abstract class MapsLayerBase
        {
            public MapsLayerBase(LayerBase owner)
            {
                MapLayer = owner;
            }
            public LayerBase MapLayer { get; private set; }

#if !DYN
            public abstract IMapLayer Layer { get; }
#else
            public abstract dynamic Layer { get; }
#endif
            public abstract IEnumerable<Point> GeoPoints { get; }
            public virtual void ClearMarks() { }
            public abstract void UpdateLayerProperties();
        }

        private abstract class VectorLayer : MapsLayerBase
        {
#if !DYN
            protected C1.WPF.Maps.C1VectorLayer _vectorLayer;
#else
            protected dynamic _vectorLayer;
#endif

            public VectorLayer(LayerBase owner)
                : base(owner)
            {
#if !DYN
                _vectorLayer = new C1.WPF.Maps.C1VectorLayer();
#else
                _vectorLayer = DynLoader.CreateC1MapsInstance("C1.WPF.Maps.C1VectorLayer");
#endif
                _vectorLayer.Name = MapLayer.Key;
                // AutoHide may yield unexpected results:
#if !DYN
                _vectorLayer.LabelVisibility = WPF.Maps.LabelVisibility.Visible;
#else
                _vectorLayer.LabelVisibility = DynLoader.GetC1MapsEnumValue("C1.WPF.Maps.LabelVisibility.Visible");
#endif
            }
#if !DYN
            public override IMapLayer Layer
#else
            public override dynamic Layer
#endif
            {
                get { return _vectorLayer; }
            }
            public override void UpdateLayerProperties()
            {
                _vectorLayer.Opacity = MapLayer.Opacity;
            }
        }

        private class PointsMapsLayer : VectorLayer
        {
#if !DYN
            private ObservableCollection<C1.WPF.Maps.C1VectorPlacemark> _marks;
#else
            private dynamic _marks;
#endif

            public PointsMapsLayer(LayerBase owner)
                : base(owner)
            {
#if !DYN
                _marks = new ObservableCollection<WPF.Maps.C1VectorPlacemark>();
#else
                var genericCollType = typeof(ObservableCollection<>);
                var specMarksCollType = genericCollType.MakeGenericType(DynLoader.GetC1MapsType("C1.WPF.Maps.C1VectorPlacemark"));
                _marks = Activator.CreateInstance(specMarksCollType);
#endif
                _vectorLayer.ItemsSource = _marks;
            }
#if !DYN
            public void AddMark(C1.WPF.Maps.C1VectorPlacemark mark)
#else
            public void AddMark(dynamic mark)
#endif
            {
                _marks.Add(mark);
            }
            public override IEnumerable<Point> GeoPoints
            {
                get
                {
                    foreach (dynamic mark in _marks)
                        yield return mark.GeoPoint;
                }
            }
            public override void ClearMarks()
            {
                _marks.Clear();
            }
        }

        private class LinesMapsLayer : VectorLayer
        {
#if !DYN
            private ObservableCollection<C1.WPF.Maps.C1VectorPolyline> _lines;
#else
            private dynamic _lines;
#endif

            public LinesMapsLayer(LayerBase owner)
                : base(owner)
            {
#if !DYN
                _lines = new ObservableCollection<WPF.Maps.C1VectorPolyline>();
#else
                var genericCollType = typeof(ObservableCollection<>);
                var specLinesCollType = genericCollType.MakeGenericType(DynLoader.GetC1MapsType("C1.WPF.Maps.C1VectorPolyline"));
                _lines = Activator.CreateInstance(specLinesCollType);
#endif
                _vectorLayer.ItemsSource = _lines;
            }
#if !DYN
            public void AddLine(C1.WPF.Maps.C1VectorPolyline line)
#else
            public void AddLine(dynamic line)
#endif
            {
                _lines.Add(line);
            }
            public override IEnumerable<Point> GeoPoints
            {
                get
                {
                    foreach (dynamic line in _lines)
                        foreach (Point p in line.Points)
                            yield return p;
                }
            }
            public override void ClearMarks()
            {
                _lines.Clear();
            }
        }

        private class KmlMapsLayer : VectorLayer
        {
            private Rect _bounds = Rect.Empty;
            public KmlMapsLayer(LayerBase owner)
                : base(owner)
            {
            }
            public override IEnumerable<Point> GeoPoints
            {
                get
                {
                    return new Point[]
                    {
                        _bounds.TopLeft,
                        _bounds.TopRight,
                        _bounds.BottomRight,
                        _bounds.BottomLeft
                    };
                }
            }
            /// <summary>
            /// Adds a layer created from the specified KML stream.
            /// </summary>
            /// <param name="kml">The source KML stream.</param>
            /// <param name="name">The new layer name (must be a valid alphanumeric name).</param>
            /// <param name="addingItemProc">The callback to invoke for each KML item as it is being loaded.</param>
            public void Update(Stream kml, AddingKmlItemDelegate addingItemProc)
            {
                _vectorLayer.Children.Clear();
                if (kml != null)
                    C1Mapper.LoadKML(_vectorLayer, kml, addingItemProc, out _bounds);
            }
        }
        #endregion

        #region construction
        public C1Mapper()
            : this(null)
        {
            // do not use this ctor.
        }

        public C1Mapper(IMapperOwner owner)
        {
            InitializeComponent();

#if !DYN
            _c1maps = new C1.WPF.Maps.C1Maps();
#else
            _c1maps = DynLoader.CreateC1MapsInstance("C1.WPF.Maps.C1Maps");
#endif
            //
            this._grid.Children.Add(_c1maps);

            _owner = owner;
            _owner.LayersChanged += new EventHandler(Map_LayersChanged);
            _owner.Layers.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Layers_CollectionChanged);

            this.Background = Util.BrushFromGdiColor(Utils.FromWpfColor(_owner.BackColor));

            // hide/show standard tools as required:
            this.LayoutUpdated += (ss, ee) => HideShowTools();
            // TBD: add a property to automatically move scale so as not to obscure data

            _c1maps.FadeInTiles = false;
#if !DYN
            _c1maps.TilesLoadProgress += new EventHandler<TilesLoadProgressEventArgs>(_c1maps_TilesLoadProgress);
#else
            var handlerType = typeof(EventHandler<>).MakeGenericType(DynLoader.GetC1MapsType("TilesLoadProgressEventArgs"));
            var handlerMethod = typeof(C1Mapper).GetMethod("_c1maps_TilesLoadProgress", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var handler = Delegate.CreateDelegate(handlerType, this, handlerMethod);
            _c1maps.TilesLoadProgress += handler;
#endif
            //
            ResetLayers();
        }

        private void ResetLayers()
        {
            _layers.Clear();
            _c1maps.Layers.Clear();
            foreach (LayerBase l in _owner.Layers.FindAllReverse((ll) => ll.Visible))
            {
                MapsLayerBase layer;
                if (l is PointsLayer)
                    layer = new PointsMapsLayer(l);
                else if (l is LinesLayer)
                    layer = new LinesMapsLayer(l);
                else if (l is KmlLayer)
                    layer = new KmlMapsLayer(l);
                else
                {
                    System.Diagnostics.Debug.Assert(false, "unknown map layer type");
                    layer = null;
                }
                _layers.Add(layer);
                _c1maps.Layers.Add(layer.Layer);
            }
        }

        void Map_LayersChanged(object sender, EventArgs e)
        {
            _owner.Layers.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Layers_CollectionChanged);
            ResetLayers();
        }

        void Layers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // TODO: this is too drastic. Analyze e.Action and only update layers rather than recreating all:
            ResetLayers();
        }
        #endregion

        #region private
#if !DYN
        private void _c1maps_TilesLoadProgress(object sender, TilesLoadProgressEventArgs e)
        {
            _tilesRemaining = e.TilesRemaining;
        }
#else
        private void _c1maps_TilesLoadProgress(object sender, dynamic e)
        {
            _tilesRemaining = e.TilesRemaining;
        }
#endif

        /// <summary>
        /// Sets visibility of the standard C1Maps tools (scale, pan & zoom) based on owner's settings.
        /// </summary>
        public void HideShowTools()
        {
            if (_owner == null)
                return;

            // find C1MapToolsLayer named "Tools" in C1Map's template
#if !DYN
            var toolsLayer = _c1maps.Template.FindName("Tools", _c1maps) as C1MapToolsLayer;
#else
            dynamic toolsLayer = _c1maps.Template.FindName("Tools", _c1maps);
#endif
            if (toolsLayer != null)
            {
                Color toolsColor = Color.FromArgb(_owner.ToolsColor.A, _owner.ToolsColor.R, _owner.ToolsColor.G, _owner.ToolsColor.B);
                if (!(toolsLayer.Background is SolidColorBrush) || !((SolidColorBrush)toolsLayer.Background).Color.Equals(toolsColor))
                    toolsLayer.Background = new SolidColorBrush(toolsColor);

                Func<string, FrameworkElement> find = (s) => toolsLayer.Template.FindName(s, toolsLayer) as FrameworkElement;

                var fePan = find("Pan");
                if (fePan != null)
                    fePan.Visibility = _owner.ShowPanTool ? Visibility.Visible : Visibility.Hidden;

                var feZoom = find("Zoom");
                if (feZoom != null)
                    feZoom.Visibility = _owner.ShowZoomTool ? Visibility.Visible : Visibility.Hidden;

                var feScale = find("ScalesBackground");
                if (feScale != null)
                    feScale.Visibility = _owner.ShowScale ? Visibility.Visible : Visibility.Hidden;
            }
        }

        /// <summary>
        /// Refreshes the tile source if needed, based on owner setting.
        /// </summary>
        private void RefreshTileSource()
        {
            if (_owner == null)
                return;

            Action<string> setSource = (typeName) =>
                {
                    if (_c1maps.Source == null || _c1maps.Source.GetType().FullName == typeName)
                        _c1maps.Source = DynLoader.CreateC1MapsInstance(typeName);
                };

            switch (_owner.TileSource)
            {
                case TileSource.None:
                    if (_c1maps.Source != null)
                        _c1maps.Source = null;
                    break;
                case TileSource.VirtualEarthAerial:
                    setSource("C1.WPF.Maps.VirtualEarthAerialSource");
                    break;
                case TileSource.VirtualEarthHybrid:
                    setSource("C1.WPF.Maps.VirtualEarthHybridSource");
                    break;
                case TileSource.VirtualEarthRoad:
                    setSource("C1.WPF.Maps.VirtualEarthRoadSource");
                    break;
#if not_yet
                case MapTileSource.OpenStreet:
                    if (!(_c1maps.Source is C1.C1Report.CustomFields.OpenStreetMapsSource))
                        _c1maps.Source = new C1.C1Report.CustomFields.OpenStreetMapsSource();
                    break;
                case MapTileSource.CloudMade:
                    if (!(_c1maps.Source is C1.C1Report.CustomFields.CloudMadeMapsSource))
                        _c1maps.Source = new C1.C1Report.CustomFields.CloudMadeMapsSource("tbd: allow to specify key");
                    break;
#endif
                default:
                    System.Diagnostics.Debug.Assert(false, "unknown MapTileSource");
                    break;
            }
        }

        /// <summary>
        /// Ensures a longitude value is valid.
        /// </summary>
        /// <param name="longitude">The value to validate.</param>
        /// <returns>Value within MinLong/MaxLong limits.</returns>
        private double ValidateLongitude(double longitude)
        {
            return Math.Min(Limits.MaxLong, Math.Max(Limits.MinLong, longitude));
        }

        /// <summary>
        /// Ensures a latitude value is valid.
        /// </summary>
        /// <param name="longitude">The value to validate.</param>
        /// <returns>Value within MinLat/MaxLat limits.</returns>
        private double ValidateLatitude(double latitude)
        {
            return Math.Min(Limits.MaxLat, Math.Max(Limits.MinLat, latitude));
        }

        /// <summary>
        /// WPF DoEvents method.
        /// </summary>
        private void DoEvents()
        {
            bool doingEvents = _doingEvents;
            _doingEvents = true;
            try
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(delegate { }), DispatcherPriority.Background);
            }
            catch
            {
                // todo - report errors?
            }
            finally
            {
                _doingEvents = doingEvents;
            }
        }

        /// <summary>
        /// Makes a System.Drawing.Image (bitmap) with the specified resolution representing the map.
        /// </summary>
        /// <param name="dpiX"></param>
        /// <param name="dpiY"></param>
        /// <returns></returns>
        private System.Drawing.Image MakeImage(double dpiX, double dpiY)
        {
            // ActualWidth/ActualHeight are in 1/96 in:
            const int ActualDPI = 96;
            RenderTargetBitmap targetBitmap = new RenderTargetBitmap(
                (int)(Math.Round(this.ActualWidth / ActualDPI * dpiX)),
                (int)(Math.Round(this.ActualHeight / ActualDPI * dpiY)),
                dpiX, dpiY,
                PixelFormats.Default);
            targetBitmap.Render(this);

            // add the RenderTargetBitmap to a Bitmapencoder
            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(targetBitmap));

            // produce a WinForms Image:
            MemoryStream ms = new MemoryStream();
            encoder.Save(ms);
            return System.Drawing.Image.FromStream(ms);
        }

        /// <summary>
        /// Centers and zooms the map based on owner settings (including auto zoom/center).
        /// </summary>
        public void DoCenterAndZoom()
        {
            if (_owner == null)
            {
                _c1maps.Center = new Point(0, 0);
                _c1maps.Zoom = 0;
                return;
            }

            if (_owner.AutoCenter)
            {
                Rect bounds = Rect.Empty;

                Action<Point> processGeoPoint = (p) =>
                {
                    if (!double.IsNaN(p.X) && !double.IsNaN(p.Y))
                        bounds.Union(p);
                };

                foreach (MapsLayerBase lb in _layers.FindAll((l) => l.MapLayer.Track))
                    foreach (Point p in lb.GeoPoints)
                        processGeoPoint(p);
                if (!_boundingRect.IsEmpty)
                {
                    processGeoPoint(_boundingRect.TopLeft);
                    processGeoPoint(_boundingRect.BottomRight);
                }

                // apply padding:
                if (!bounds.IsEmpty)
                {
                    var padLon = Math.Abs(bounds.Width) * _owner.AutoZoomPadLon / 100;
                    var padLat = Math.Abs(bounds.Height) * _owner.AutoZoomPadLat / 100;
                    bounds.X -= padLon;
                    bounds.Width += padLon * 2;
                    bounds.Y -= padLon;
                    bounds.Height += padLon * 2;
                }
                //
                SetExtent(bounds.TopLeft, bounds.BottomRight, _owner.AutoZoom, _owner.MaxAutoZoom > 0 ? _owner.MaxAutoZoom : Limits.MaxZoom, _owner.RoundAutoZoom);
                if (!_owner.AutoZoom)
                    _c1maps.Zoom = _owner.ZoomLevel;
            }
            else // if not AutoCenter, AutoZoom is ignored:
            {
                _c1maps.Center = new Point(_owner.CenterLongitude, _owner.CenterLatitude);
                _c1maps.Zoom = _owner.ZoomLevel;
            }
        }

        /// <summary>
        /// Sets the map extent and optionally auto-zooms the map.
        /// </summary>
        /// <param name="extMin">Minimum point of the new extent.</param>
        /// <param name="extMax">Maximum point of the new extent.</param>
        /// <param name="autoZoom">True to auto zoom.</param>
        /// <param name="maxZoom">Maximum auto zoom value.</param>
        /// <param name="roundAutoZoom">True to round down the calculated auto zoom value.</param>
        private void SetExtent(Point extMin, Point extMax, bool autoZoom, double maxZoom, bool roundAutoZoom)
        {
            // sanity:
            extMin.X = ValidateLongitude(extMin.X);
            extMin.Y = ValidateLatitude(extMin.Y);
            extMax.X = ValidateLongitude(extMax.X);
            extMax.Y = ValidateLatitude(extMax.Y);

#if DEBUG && only_if_you_really_need_it
            DrawPoint(extMin.X, extMin.Y, "", 5, System.Drawing.Color.DarkMagenta, System.Drawing.Color.Magenta, MarkerShape.Star);
            DrawPoint(extMin.X, extMax.Y, "", 5, System.Drawing.Color.DarkMagenta, System.Drawing.Color.Magenta, MarkerShape.Star);
            DrawPoint(extMax.X, extMin.Y, "", 5, System.Drawing.Color.DarkMagenta, System.Drawing.Color.Magenta, MarkerShape.Star);
            DrawPoint(extMax.X, extMax.Y, "", 5, System.Drawing.Color.DarkMagenta, System.Drawing.Color.Magenta, MarkerShape.Star);
            DrawPoint((extMax.X + extMin.X) / 2, (extMax.Y + extMin.Y) / 2, "", 5, System.Drawing.Color.DarkMagenta, System.Drawing.Color.Magenta, MarkerShape.Star);
#endif
            Point min = _c1maps.Projection.Project(extMin);
            Point max = _c1maps.Projection.Project(extMax);
            if (autoZoom)
            {
                Point absMin = new Point(0, 0);
                // this is based on C1Maps.ViewportWidth code:
                Point absMax = new Point(this.Width / Limits.MercatorMapWidth, this.Height / Limits.MercatorMapWidth);

                double xZoom = Math.Abs(absMax.X - absMin.X) / Math.Abs(max.X - min.X);
                double yZoom = Math.Abs(absMax.Y - absMin.Y) / Math.Abs(max.Y - min.Y);
                double zoom = Math.Min(xZoom, yZoom);

                zoom = Math.Max(Limits.MinZoom, Math.Log(zoom, 2));
                if (roundAutoZoom)
                    zoom = Math.Truncate(zoom);

                _c1maps.Zoom = Math.Min(zoom, maxZoom);
            }
            // center:
            Point cc = new Point((min.X + max.X) / 2, (min.Y + max.Y) / 2);
            _c1maps.Center = _c1maps.Projection.Unproject(cc);
        }

        /// <summary>
        /// Loads a KML or KMZ file from the specified stream into the layer.
        /// </summary>
        /// <param name="vl">The layer to load the stream into.</param>
        /// <param name="stream">The source stream.</param>
        /// <param name="addingItemProc">The callback to call for each KML item.</param>
        /// <param name="maxBounds">OUT: The union of all loaded items' bounds.</param>
        private static void LoadKML(dynamic vl, Stream stream, AddingKmlItemDelegate addingItemProc, out Rect maxBounds)
        {
            maxBounds = Rect.Empty;
#if !DYN
            var vects = KmlReader.Read(stream);
#else
            dynamic vects = DynLoader.CallC1MapsStaticMethod("C1.WPF.Maps.KmlReader", "Read", stream);
#endif
            vl.BeginUpdate();
#if !DYN
            foreach (C1VectorItemBase vect in vects)
            {
#else
            for (int i = 0; i < vects.Count; ++i)
            {
                dynamic vect = vects[i];
#endif
                if (addingItemProc != null)
                {
                    var oldName = ToolTipService.GetToolTip(vect) as string;
                    var newName = oldName;
                    Nullable<System.Drawing.Color> stroke, fill;
                    bool trackCoords;
                    if (!addingItemProc(ref newName, out stroke, out fill, out trackCoords))
                        continue;
                    if (stroke.HasValue)
                        vect.Stroke = Util.BrushFromGdiColor(stroke.Value);
                    if (fill.HasValue)
                        vect.Fill = Util.BrushFromGdiColor(fill.Value);
                    if (newName != oldName)
                    {
                        ToolTipService.SetToolTip(vect, newName);
#if !DYN
                        if (vect is C1VectorPlacemark)
                            ((C1VectorPlacemark)vect).Label = newName;
#else
                        if (vect.GetType() == DynLoader.GetC1MapsType("C1VectorPlacemark"))
                            vect.Label = newName;
#endif
                    }
                    if (trackCoords)
                        maxBounds.Union(vect.Bounds);
                }
                else
                    maxBounds.Union(vect.Bounds);

                vl.Children.Add(vect);
            }
            vl.EndUpdate();
        }
        #endregion

        #region publics
        /// <summary>
        /// Gets a System.Drawing.Image representing the current map.
        /// </summary>
        /// <param name="dpiX">The horizontal resolution of the image.</param>
        /// <param name="dpiY">The vertical resolution of the image.</param>
        /// <returns>The image (bitmap).</returns>
        public System.Drawing.Image GetImage(double dpiX, double dpiY)
        {
            if (_doingEvents)
                return null;

            RefreshTileSource();

            // apply layer-wide properties:
            foreach (MapsLayerBase lb in _layers)
                lb.UpdateLayerProperties();

            // clear old legends:
            for (int i = _grid.Children.Count - 1; i >= 0; --i)
                if (_grid.Children[i] is MapperLegend)
                    _grid.Children.RemoveAt(i);

            // add new ones:
            if (_owner != null)
            {
                foreach (Legend ml in _owner.Legends)
                {
                    if (ml.Visible)
                    {
                        var l = new MapperLegend();
                        _grid.Children.Add(l);
                        l.Visibility = System.Windows.Visibility.Visible;
                        l.UpdateFromOwner(_owner, ml);
                    }
                }
            }

            this.Measure(new System.Windows.Size(this.Width, this.Height));
            this.Arrange(new System.Windows.Rect(new System.Windows.Size(this.Width, this.Height)));
            this.UpdateLayout();

            // there's no TilesMode in WPF Maps anymore, as its probably the only mode now(?).
            // NOTE: we must DoEvents() at least once even if _tilesRemaining==0, otherwise
            // we don't get the image.
#if skip_dima 
#if !DYN
            if (_c1maps.TilesMode == MapTilesMode.Native)
#else
            if (_c1maps.TilesMode == DynLoader.GetC1MapsEnumValue("C1.WPF.Maps.MapTilesMode.Native"))
#endif
#endif
            {
                int oldTilesRemaining = _tilesRemaining;
                DoEvents();
                const int MAX_WAIT_LOOPS = 200;
                const int MAX_NOCHANGE_LOOPS = 30;
                int nochange_loops = 0;
                for (int i = 0; i < MAX_WAIT_LOOPS && nochange_loops < MAX_NOCHANGE_LOOPS && _tilesRemaining > 0; ++i)
                {
                    System.Threading.Thread.Sleep(300);
                    DoEvents();
                    if (oldTilesRemaining == _tilesRemaining)
                        ++nochange_loops;
                }
            }
            return MakeImage(dpiX, dpiY);
        }

        public void ResetBoundingPoints()
        {
            _boundingRect = Rect.Empty;
        }

        public void AddBoundingPoint(double longitude, double latitude)
        {
            if (!double.IsNaN(longitude) && !double.IsNaN(latitude))
                _boundingRect.Union(new Point(longitude, latitude));
        }

        /// <summary>
        /// Adds a layer created from the specified KML stream.
        /// </summary>
        /// <param name="kml">The source KML stream.</param>
        /// <param name="name">The new layer name (must be a valid alphanumeric name).</param>
        /// <param name="addingItemProc">The callback to invoke for each KML item as it is being loaded.</param>
        public void UpdateKmlLayer(string layerKey, Stream kml, AddingKmlItemDelegate addingItemProc)
        {
            KmlMapsLayer kl = _layers.Find((l) => l.MapLayer.Key == layerKey) as KmlMapsLayer;
            System.Diagnostics.Debug.Assert(kl != null);
            kl.Update(kml, addingItemProc);
        }

        /// <summary>
        /// Clears all previously added marks and lines. (Does not affect KML layers.)
        /// </summary>
        public void ClearMarks()
        {
            _layers.ForEach((l) => l.ClearMarks());
        }

        /// <summary>
        /// Calculates screen distance (in 96dpi pixels) between two points.
        /// </summary>
        /// <param name="longitude1"></param>
        /// <param name="latitude1"></param>
        /// <param name="longitude2"></param>
        /// <param name="latitude2"></param>
        /// <returns></returns>
        public double DistancePix(double longitude1, double latitude1, double longitude2, double latitude2)
        {
            var p1 = _c1maps.Projection.Project(new Point(longitude1, latitude1));
            var p2 = _c1maps.Projection.Project(new Point(longitude2, latitude2));
            double scale = Math.Pow(2, _c1maps.Zoom) * Limits.MercatorMapWidth;
            return Math.Sqrt(Math.Pow((p1.X - p2.X) * scale, 2) + Math.Pow((p1.Y - p2.Y) * scale, 2));
        }

        /// <summary>
        /// Adds a point.
        /// </summary>
        /// <param name="layerKey"></param>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <param name="caption"></param>
        /// <param name="font"></param>
        /// <param name="markShape"></param>
        /// <param name="size"></param>
        /// <param name="stroke"></param>
        /// <param name="fill"></param>
        public void DrawPoint(string layerKey,
            double longitude, double latitude,
            string caption, System.Drawing.Font font, System.Drawing.Color textColor,
            MarkerShape markShape, double size, System.Drawing.Color stroke, System.Drawing.Color fill)
        {
#if !DYN
            var mark = new C1.WPF.Maps.C1VectorPlacemark();
            mark.Lod = new C1.WPF.Maps.LOD(1, 300, 0, 10); // tbd: allow to control this
#else
            dynamic mark = DynLoader.CreateC1MapsInstance("C1VectorPlacemark");
            mark.Lod = DynLoader.CreateC1MapsInstance("C1.WPF.Maps.LOD", 1, 300, 0, 10);
#endif
            mark.GeoPoint = new Point(longitude, latitude);

            if (!string.IsNullOrEmpty(caption))
            {
                mark.Label = caption;
                Util.ApplyFontToControl(font, mark);
                if (!Util.IsColorEmpty(textColor))
                    mark.Foreground = Util.BrushFromGdiColor(textColor);
                // mark.LabelPosition = WPF.Maps.LabelPosition.Right | WPF.Maps.LabelPosition.Bottom;
                // mark.Background = new SolidColorBrush(Colors.Red);
                // TBD: label:
                // - setting mark.LabelPosition makes the label tiny. clarify.
            }

            mark.Geometry = Util.MarkerShapeToGeometry(markShape, size);
            mark.Stroke = Util.BrushFromGdiColor(stroke);
            mark.Fill = Util.BrushFromGdiColor(fill);

            PointsMapsLayer ml = _layers.Find((l) => l.MapLayer.Key == layerKey) as PointsMapsLayer;
            System.Diagnostics.Debug.Assert(ml != null);
            ml.AddMark(mark);
        }

        /// <summary>
        /// Adds a line to the lines layer.
        /// </summary>
        /// <param name="longitude1"></param>
        /// <param name="latitude1"></param>
        /// <param name="longitude2"></param>
        /// <param name="latitude2"></param>
        /// <param name="stroke"></param>
        /// <param name="dashStyle"></param>
        public void DrawLine(
            string layerKey,
            double longitude1, double latitude1, double longitude2, double latitude2,
            System.Drawing.Color stroke, DashStyle dashStyle, double thickness)
        {
            var bStroke = Util.BrushFromGdiColor(stroke);
            var dashes = Util.DashStyleToCollection(dashStyle);
            DrawLine(layerKey, longitude1, latitude1, longitude2, latitude2, bStroke, Brushes.Transparent, dashes, thickness);
        }

        /// <summary>
        /// Adds a line to the lines layer.
        /// </summary>
        /// <param name="longitude1"></param>
        /// <param name="latitude1"></param>
        /// <param name="longitude2"></param>
        /// <param name="latitude2"></param>
        /// <param name="stroke"></param>
        /// <param name="fill"></param>
        /// <param name="dashes"></param>
        public void DrawLine(
            string layerKey,
            double longitude1, double latitude1, double longitude2, double latitude2,
            Brush stroke, Brush fill, DoubleCollection dashes, double thickness)
        {
#if !DYN
            C1.WPF.Maps.C1VectorPolyline line = new C1VectorPolyline();
#else
            dynamic line = DynLoader.CreateC1MapsInstance("C1VectorPolyline");
#endif
            line.Points = new PointCollection()
            {
                new Point(longitude1, latitude1),
                new Point(longitude2, latitude2),
            };
            line.StrokeDashArray = dashes;
            line.Stroke = stroke;
            line.Fill = fill;
            line.StrokeThickness = thickness;

            LinesMapsLayer ll = _layers.Find((l) => l.MapLayer.Key == layerKey) as LinesMapsLayer;
            System.Diagnostics.Debug.Assert(ll != null);
            ll.AddLine(line);
        }
        #endregion

#if not_needed_yet
        // http://stackoverflow.com/questions/3286175/how-do-i-convert-a-wpf-size-to-physical-pixels
        public Size GetElementPixelSize(UIElement element)
        {
            Matrix transformToDevice;
            var source = PresentationSource.FromVisual(element);
            if (source != null)
                transformToDevice = source.CompositionTarget.TransformToDevice;
            else
                using (var src = new HwndSource(new HwndSourceParameters()))
                    transformToDevice = src.CompositionTarget.TransformToDevice;

            if (element.DesiredSize == new Size())
                element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            return (Size)transformToDevice.Transform((Vector)element.DesiredSize);
        }
#endif
#if todo_not_yet
        public class OpenStreetMapsSource : C1.WPF.Maps.C1MultiScaleTileSource
        {
            private readonly string[] tilePathPrefixes = new[] { "a", "b", "c" };
            private readonly Random rand = new Random();
            private const string uriFormat = @"http://{S}.tile.openstreetmap.org/{Z}/{X}/{Y}.png";

            public OpenStreetMapsSource()
                : base(0x8000000, 0x8000000, 0x100, 0x100, 0)
            { }

            protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, IList<object> sources)
            {
                if (tileLevel > 8)
                {
                    var zoom = tileLevel - 8;
                    var prefix = tilePathPrefixes[rand.Next(3)];
                    var url = uriFormat;

                    url = url.Replace("{S}", prefix);
                    url = url.Replace("{Z}", zoom.ToString());
                    url = url.Replace("{X}", tilePositionX.ToString());
                    url = url.Replace("{Y}", tilePositionY.ToString());
                    sources.Add(new Uri(url));
                }
            }
        }

        public class CloudMadeMapsSource : C1.WPF.Maps.C1MultiScaleTileSource
        {
            readonly Random rand = new Random();
            const string uriFormat = @"http://b.tile.cloudmade.com/{0}/{1}/256/{2}/{3}/{4}.png";
            string _apiKey;

            public string Style = "1";

            public CloudMadeMapsSource(string apiKey)
                : base(0x8000000, 0x8000000, 256, 256, 0)
            {
                _apiKey = apiKey;
            }

            protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, IList<object> sources)
            {
                if (tileLevel > 8)
                {
                    sources.Add(new Uri(string.Format(CultureInfo.InvariantCulture,
                        uriFormat, _apiKey, Style, tileLevel - 8, tilePositionX, tilePositionY)));
                }
            }
        }
#endif
    }
}
