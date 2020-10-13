#if !(CLR40 || CLR45)
#error This code requires .NET 4.0 or newer.
#endif
/*
 * TODO:
 * - add/improve script error handling.
 * 
 * A Map comprises an optional tile layer, and a collection of layers representing spatial data.
 * 
 * Supported layer types are:
 * -- Points: shows spatial data as point markers;
 * -- Lines: shows spatial data as lines, each line connecting two points;
 * -- KML: shows spatial data imported from KML/KMZ files.
 * 
 * TBD: write a short summary here.
 */

using System;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing.Design;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;
using C1.C1Report.CustomFields.Maps;

namespace C1.C1Report.CustomFields
{
    /// <summary>
    /// Represents a map showing spatial and analytical data in the report.
    /// </summary>
#if GRAPECITY
    [Description("マップ")]
#else
    [Description("Map")]
#endif
    public partial class Map : C1.C1Report.Field, IMapperOwner
    {
        #region Categories for property grid grouping
        private const string c_catMap = "Map";
        private const string c_catMapColls = "Map Collections";
        private const string c_catMapStyles = "Map Styles";
        #endregion

        #region Private data
        // The mapper object used to actually generate the map image (using C1.WPF.Maps.C1Maps):
        private C1Mapper _c1mapper = null;
        // Layers:
        private LayerCollection _layers;
        // Legends:
        private LegendCollection _legends;
        // Style collections:
        private MarkerStyleCollection _markerStyles;
        private LineStyleCollection _lineStyles;
        private KmlItemStyleCollection _kmlItemStyles;
        // Misc object model properties:
        private TileSource _tileSource = TileSource.VirtualEarthHybrid;
        private Color _toolsColor = Color.Transparent;
        private bool _showZoomTool = false;
        private bool _showPanTool = false;
        private bool _showScale = true;
        private bool _autoZoom = true;
        private double _zoomLevel = 0;
        private double _maxAutoZoom = 0;
        private bool _roundAutoZoom = true;
        private double _autoZoomPadLon = 10;
        private double _autoZoomPadLat = 10;
        private bool _autoCenter = true;
        private double _centerLatitude = 0;
        private double _centerLongitude = 0;
        private int _targetDpi = 200;
        // The cached map image:
        private Image _image = null;
        // Indicates whether we're at runtime:
        private bool _runtime = false;
        // Indicates whether we're deserializing:
        private bool _loading = false;
        // Used to suppress repeated error reporting:
        private List<int> _reportedErrors = new List<int>();
        // Geocoder (used to get locations' coordinates via google or such):
        private GeocoderBase _geocoder = null;
        // Geocoder cache file path:
        private string _geoCachePath = "geocache.xml";
        // Regex used to replace 'kmlItemName' with actual kml item name (used only in filter):
        static Regex s_kmlItemNameRegex = new Regex(string.Format(CultureInfo.InvariantCulture, @"\b{0}\b", KmlLayer.varItemName), RegexOptions.Compiled | RegexOptions.IgnoreCase);
        // Screen res:
        static readonly double ScreenDpiX;
        static readonly double ScreenDpiY;
        //
        const int TwipsIn = 1440;
        // Design time sample data limits:
        const int SampleLatMin = 30;
        const int SampleLatMax = 50;
        const int SampleLonMin = -110;
        const int SampleLonMax = -75;
        #endregion

        #region events
        /// <summary>
        /// Fired when the Layers collection is set.
        /// </summary>
        public event EventHandler LayersChanged;
        #endregion

        #region ctors
        static Map()
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                ScreenDpiX = bmp.HorizontalResolution;
                ScreenDpiY = bmp.VerticalResolution;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Map class.
        /// </summary>
        public Map()
        {
            InitGeocoder(false);

            // Adjust base props:
#if WPF
	        BackColor = System.Windows.Media.Colors.Transparent;
#else
            BackColor = Color.White;
#endif
            PictureAlign = PictureAlignEnum.Stretch;
            // Various styles:
            MarkerStyles = new MarkerStyleCollection(this);
            LineStyles = new LineStyleCollection(this);
            KmlItemStyles = new KmlItemStyleCollection(this);
            // Main collections:
            Layers = new LayerCollection(this);
            Legends = new LegendCollection(this);
        }
        #endregion

        #region Public object model
        /// <summary>
        /// Gets or sets the path to the file used to cache spatial coordinates (longitude/latitude) specified as
        /// MapLocation rather than actual Longitude/Latitude values. The coordinates in such cases are retrieved
        /// using an online service such as Google, and caching them significantly imporoves performance when the
        /// same location is encountered multiple times.
        /// <para>The path is relative to the application startup path.</para>
        /// <para>The default is "geocache.xml".</para>
        /// <para>Clear this value to disable caching (not recommended).</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("File used to cache spatial coordinates specified as MapLocation rather than Longitude/Latitude pair. If relative, application startup path is used as the base. Clear to disable caching (not recommended).")]
        [DefaultValue("geocache.xml")]
        [Editor(typeof(GeoCacheFileEditor), typeof(UITypeEditor))]
        public string GeoCachePath
        {
            get { return _geoCachePath; }
            set
            {
                if (value != _geoCachePath || _geocoder == null)
                {
                    _geoCachePath = value;
                    InitGeocoder(true);
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the collection of layers containing markers, lines and KML data rendered on the map.
        /// <para>
        /// Note that the set accessor is only for deserialization, and should not be used directly.
        /// </para>
        /// </summary>
        [Category(c_catMapColls)]
        [Description("Collection of layers containing markers, lines and KML data rendered on the map.")]
        public LayerCollection Layers
        {
            get { return _layers; }
            set
            {
                _layers = value;
                if (_layers != null)
                {
                    _layers.Owner = this;
                    if (LayersChanged != null)
                        LayersChanged(this, EventArgs.Empty);
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the collection of legends rendered on the map.
        /// Legends may represent layers or arbitrary information (such as captions).
        /// <para>
        /// Note that the set accessor is only for deserialization, and should not be used directly.
        /// </para>
        /// </summary>
        [Category(c_catMapColls)]
        [Description("Collection of legends rendered on the map.")]
        public LegendCollection Legends
        {
            get { return _legends; }
            set
            {
                _legends = value;
                if (_legends != null)
                {
                    _legends.Owner = this;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the collection of styles used to render markers on the map.
        /// Styles allow markers in different layers or even in different maps to use common visual properties.
        /// <para>
        /// Note that the set accessor is only for deserialization, and should not be used directly.
        /// </para>
        /// </summary>
        [Category(c_catMapStyles)]
        [Description("Collection of visual styles used to render markers on the map.")]
        public MarkerStyleCollection MarkerStyles
        {
            get { return _markerStyles; }
            set
            {
                _markerStyles = value;
                if (_markerStyles != null)
                {
                    _markerStyles.Owner = this;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the collection of styles used to render lines on the map.
        /// Styles allow lines in different layers or even in different maps to use common visual properties.
        /// <para>
        /// Note that the set accessor is only for deserialization, and should not be used directly.
        /// </para>
        /// </summary>
        [Category(c_catMapStyles)]
        [Description("Collection of visual styles used to render lines on the map.")]
        public LineStyleCollection LineStyles
        {
            get { return _lineStyles; }
            set
            {
                _lineStyles = value;
                if (_lineStyles != null)
                {
                    _lineStyles.Owner = this;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the collection of styles used to render KML/KMZ items on the map.
        /// Styles allow KML items in different layers or even in different maps to use common visual properties.
        /// <para>
        /// Note that the set accessor is only for deserialization, and should not be used directly.
        /// </para>
        /// </summary>
        [Category(c_catMapStyles)]
        [Description("Collection of visual styles used to render KML/KMZ items on the map.")]
        public KmlItemStyleCollection KmlItemStyles
        {
            get { return _kmlItemStyles; }
            set
            {
                _kmlItemStyles = value;
                if (_kmlItemStyles != null)
                {
                    _kmlItemStyles.Owner = this;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the background color of the map scale and other tools.
        /// </summary>
        [Category(c_catMap)]
        [Description("Background color of the map scale and other tools.")]
        [DefaultValue(typeof(Color), "Transparent")]
        public Color ToolsColor
        {
            get { return _toolsColor; }
            set
            {
                _toolsColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the zoom scale.
        /// <para>The default is false.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether to show the zoom tool (may be used as an alternative to showing the scale).")]
        [DefaultValue(false)]
        public bool ShowZoomTool
        {
            get { return _showZoomTool; }
            set
            {
                _showZoomTool = value;
                InitMapper();
                _c1mapper.HideShowTools();
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the pan tool.
        /// <para>The default is false.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether to show the pan tool.")]
        [DefaultValue(false)]
        public bool ShowPanTool
        {
            get { return _showPanTool; }
            set
            {
                _showPanTool = value;
                InitMapper();
                _c1mapper.HideShowTools();
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the map scale.
        /// <para>The default is true.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether to show the map scale.")]
        [DefaultValue(true)]
        public bool ShowScale
        {
            get { return _showScale; }
            set
            {
                _showScale = value;
                InitMapper();
                _c1mapper.HideShowTools();
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the map tile source.
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies the map tile source.")]
        [DefaultValue(TileSource.VirtualEarthHybrid)]
        public TileSource TileSource
        {
            get { return _tileSource; }
            set
            {
                _tileSource = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the map should automatically zoom in to just include all spatial data.
        /// Ignored (considered to be false) if AutoCenter is false.
        /// <para>The default is true.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether the map should automatically zoom in to just include all spatial data. Ignored if AutoCenter is off.")]
        [DefaultValue(true)]
        public bool AutoZoom
        {
            get { return _autoZoom; }
            set
            {
                _autoZoom = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to automatically center the map around the spatial data.
        /// Note that setting this property to false effectively turns off AutoZoom.
        /// <para>The default is true.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether to automatically center the map around the spatial data. Note that setting this property to false effectively turns off AutoZoom.")]
        [DefaultValue(true)]
        public bool AutoCenter
        {
            get { return _autoCenter; }
            set
            {
                _autoCenter = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets auto zoom longitude padding, in percent relative to the viewport width.
        /// <para>The default is 10%.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Longitude padding (in percent relative to viewport width) to leave around spatial data when auto zooming.")]
        [DefaultValue(10)]
        public double AutoZoomPadLon
        {
            get { return _autoZoomPadLon; }
            set
            {
                _autoZoomPadLon = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets auto zoom latitude padding, in percent relative to the viewport height.
        /// <para>The default is 10%.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Latitude padding (in percent relative to viewport height) to leave around spatial data when auto zooming.")]
        [DefaultValue(10)]
        public double AutoZoomPadLat
        {
            get { return _autoZoomPadLat; }
            set
            {
                _autoZoomPadLat = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the zoom level value. 0 is no zoom, 1 - x2 zoom and so on.
        /// Valid values are from 0 to 20.
        /// <para>The default is 0.</para>
        /// Ignored if <see cref="AutoZoom"/> is true.
        /// </summary>
        [Category(c_catMap)]
        [Description("Zoom level: 0 is no zoom, 1 is x2 zoom and so on. Valid values are 0 to 20. Ignored if AutoZoom is true.")]
        [DefaultValue(0)]
        public double ZoomLevel
        {
            get { return _zoomLevel; }
            set
            {
                _zoomLevel = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the maximum zoom level value for auto zooming.
        /// Valid values are from 0 to 20.
        /// 0 (the default) disables auto zoom limiting.
        /// </summary>
        [Category(c_catMap)]
        [Description("Maximum auto zoom level. Valid values are 0 to 20. 0 disables auto zoom limiting.")]
        [DefaultValue(0)]
        public double MaxAutoZoom
        {
            get { return _maxAutoZoom; }
            set
            {
                _maxAutoZoom = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to round automatically calculated
        /// zoom levels down to next integer.
        /// <para>The default is true.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("Specifies whether to round automatically calculated zoom levels down to next integer.")]
        [DefaultValue(true)]
        public bool RoundAutoZoom
        {
            get { return _roundAutoZoom; }
            set
            {
                _roundAutoZoom = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the map center longitude. Ignored if AutoCenter is true.
        /// </summary>
        [Category(c_catMap)]
        [Description("The map center longitude. Ignored if AutoCenter is true.")]
        [DefaultValue(0)]
        public double CenterLongitude
        {
            get { return _centerLongitude; }
            set
            {
                _centerLongitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the map center latitude. Ignored if AutoCenter is true.
        /// </summary>
        [Category(c_catMap)]
        [Description("The map center latitude. Ignored if AutoCenter is true.")]
        [DefaultValue(0)]
        public double CenterLatitude
        {
            get { return _centerLatitude; }
            set
            {
                _centerLatitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the target image resolution (dpi).
        /// <para>The default is 200 dpi.</para>
        /// </summary>
        [Category(c_catMap)]
        [Description("The target image resolution (default is 200 dpi).")]
        [DefaultValue(200)]
        public int TargetDpi
        {
            get { return _targetDpi; }
            set
            {
                _targetDpi = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Assigns the map image that will be rendered by the field.
        /// </summary>
        /// <param name="value">The field text (ignored unless map creation failed).</param>
        /// <param name="img">The map image.</param>
        /// <param name="designTime">Specifies whether we are in design time or runtime.</param>
        override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
        {
            _runtime = !designTime;
            try
            {
                img = GetImage(designTime);
            }
            catch (Exception ex)
            {
                img = null;
                value = string.Format(CultureInfo.InvariantCulture, "Cannot create map, error was: {0}", ex.Message);
            }
            finally
            {
                _runtime = false;
            }
        }

        /// <summary>
        /// Overridden. Disposes the cached map image if any, and calls the base implementation.
        /// </summary>
        override public void OnPropertyChanged()
        {
            // maps may be interdependent via styles/legends, hence this:
            foreach (Map m in FindAllMaps(true))
                m.DisposeImage();
            base.OnPropertyChanged();
        }

        /// <summary>
        /// Overridden. Loads map specific collections.
        /// </summary>
        /// <param name="properties">The source XML data.</param>
        protected override void Load(System.Xml.XmlNodeList properties)
        {
            base.Load(properties);
            _loading = true;
            try
            {
                Func<string, XmlSerializer, object> loadColl = (xmlName, serializer) =>
                {
                    foreach (XmlNode n in properties)
                        if (n.Name == xmlName)
                        {
                            XmlNodeReader reader = new XmlNodeReader(n);
                            return serializer.Deserialize(reader);
                        }
                    return null;
                };

                var markerStyles = loadColl(MarkerStyleCollection.XmlName, MarkerStyleCollection.Serializer) as MarkerStyleCollection;
                if (markerStyles != null)
                    MarkerStyles = markerStyles;
                var lineStyles = loadColl(LineStyleCollection.XmlName, LineStyleCollection.Serializer) as LineStyleCollection;
                if (lineStyles != null)
                    LineStyles = lineStyles;
                var kmlItemStyles = loadColl(KmlItemStyleCollection.XmlName, KmlItemStyleCollection.Serializer) as KmlItemStyleCollection;
                if (kmlItemStyles != null)
                    KmlItemStyles = kmlItemStyles;
                var layers = loadColl(LayerCollection.XmlName, LayerCollection.Serializer) as LayerCollection;
                if (layers != null)
                    Layers = layers;
                var legends = loadColl(LegendCollection.XmlName, LegendCollection.Serializer) as LegendCollection;
                if (legends != null)
                    Legends = legends;
            }
            finally
            {
                _loading = false;
            }
        }

        /// <summary>
        /// Overridden. Saves map specific collections.
        /// </summary>
        /// <param name="properties">Writer used to save data.</param>
        protected override void Save(System.Xml.XmlWriter properties)
        {
            base.Save(properties);
            if (MarkerStyles.Count > 0)
                MarkerStyleCollection.Serializer.Serialize(properties, MarkerStyles);
            if (LineStyles.Count > 0)
                LineStyleCollection.Serializer.Serialize(properties, LineStyles);
            if (KmlItemStyles.Count > 0)
                KmlItemStyleCollection.Serializer.Serialize(properties, KmlItemStyles);
            if (Layers.Count > 0)
                LayerCollection.Serializer.Serialize(properties, Layers);
            if (Legends.Count > 0)
                LegendCollection.Serializer.Serialize(properties, Legends);
        }

        /// <summary>
        /// Overridden to clone the inner objects.
        /// </summary>
        /// <returns>A deep clone of the <see cref="Map"/> field.</returns>
        public override object Clone()
        {
            // base.Clone() sets Font, which causes OnPropertyChanged,
            // which in turn disposes the clone's - i.e. OUR - image.
            // So we want to stop this bespredel:
            var tmpImage = _image;
            _image = null;
            Map clone = (Map)base.Clone();
            clone._c1mapper = new C1Mapper(clone);
            clone.MarkerStyles = (MarkerStyleCollection)MarkerStyles.Clone(clone);
            clone.LineStyles = (LineStyleCollection)LineStyles.Clone(clone);
            clone.KmlItemStyles = (KmlItemStyleCollection)KmlItemStyles.Clone(clone);
            clone.Layers = (LayerCollection)Layers.Clone(clone);
            clone.Legends = (LegendCollection)Legends.Clone(clone);
            _image = tmpImage;
            return clone;
        }
        #endregion
   }
}
