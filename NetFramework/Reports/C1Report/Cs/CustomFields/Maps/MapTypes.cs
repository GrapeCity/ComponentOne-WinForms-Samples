using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Delegate called for each KML item as it is loaded from the KML file into the map.
    /// </summary>
    /// <param name="itemName">IN/OUT: the item name.</param>
    /// <param name="stroke">OUT: item stroke color (null uses color specified in the KML data).</param>
    /// <param name="fill">OUT: item fill color (null uses color specified in the KML data).</param>
    /// <param name="trackCoords">OUT: indicates whether the item's coordinates should be used to auto size/zoom the map.</param>
    /// <returns>True to include an item in the map, false to exclude it.</returns>
    public delegate bool AddingKmlItemDelegate(ref string itemName, out Nullable<Color> stroke, out Nullable<Color> fill, out bool trackCoords);

    /// <summary>
    /// Allows the mapper to pull relevant map properties.
    /// </summary>
    public interface IMapperOwner
    {
        /// <summary>
        /// The background color.
        /// </summary>
#if WPF
		System.Windows.Media.Color BackColor { get; }
#else
		Color BackColor { get; }
#endif
        /// <summary>
        /// Tools' (scale etc) background color.
        /// </summary>
        Color ToolsColor { get; }
        /// <summary>
        /// Tile source.
        /// </summary>
        TileSource TileSource { get; }
        /// <summary>
        /// Whether to show the zoom scale.
        /// </summary>
        bool ShowZoomTool { get; }
        /// <summary>
        /// Whether to show the pan tool.
        /// </summary>
        bool ShowPanTool { get; }
        /// <summary>
        /// Whether to show the scale.
        /// </summary>
        bool ShowScale { get; }
        /// <summary>
        /// Whether to auto-zoom to enclose all marks.
        /// </summary>
        bool AutoZoom { get; }
        /// <summary>
        /// Gets the maximum auto zoom level. 0 means there's no limitation.
        /// </summary>
        double MaxAutoZoom { get; }
        /// <summary>
        /// If true, automatic zoom will be rounded down to next integer.
        /// This may improve performance with some net based tile sources.
        /// </summary>
        bool RoundAutoZoom { get; }
        /// <summary>
        /// Auto zoom longitude padding, in percent.
        /// </summary>
        double AutoZoomPadLon { get; }
        /// <summary>
        /// Auto zoom latitude padding, in percent.
        /// </summary>
        double AutoZoomPadLat { get; }
        /// <summary>
        /// The zoom level, 0 being no zoom, 1 - x2 zoom and so on.
        /// </summary>
        double ZoomLevel { get; }
        /// <summary>
        /// Whether to auto-center to enclose all marks.
        /// </summary>
        bool AutoCenter { get; }
        /// <summary>
        /// The center latitude. Ignored if <see cref="AutoCenter"/> is true.
        /// </summary>
        double CenterLatitude { get; }
        /// <summary>
        /// The center longitude. Ignored if <see cref="AutoCenter"/> is true.
        /// </summary>
        double CenterLongitude { get; }
        /// <summary>
        /// The collection of legends.
        /// </summary>
        LegendCollection Legends { get; }
        /// <summary>
        /// The collection of layers.
        /// </summary>
        LayerCollection Layers { get; }
        /// <summary>
        /// Event fired when the collection of layers changes.
        /// </summary>
        event EventHandler LayersChanged;
    }

    /// <summary>
    /// Abstract base class for layer style types used in maps.
    /// </summary>
    public abstract class MapStyleBase : MapOwnedKeyedItem, ILegendItem
    {
        #region ctors
        public MapStyleBase()
            : base(null)
        {
        }

        public MapStyleBase(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        public override string BaseName
        {
            get { return "MapStyleBase"; }
        }
        #endregion

        #region legend support
        protected abstract LegendItemKind LegendItemKind { get; }
        protected abstract Color LegendItemStrokeColor { get; }
        protected abstract Color LegendItemFillColor { get; }
        protected abstract MarkerShape LegendItemMarkerShape { get; }
        protected abstract DashStyle LegendItemDashStyle { get; }
        protected abstract double LegendItemLineThickness { get; }
        protected abstract double LegendItemMarkerSize { get; }

        LegendItemKind ILegendItem.LegendItemKind { get { return LegendItemKind; } }
        string ILegendItem.LegendItemCaption { get { return this.Name; } }
        bool ILegendItem.LegendItemVisible { get { return true; } }
        Color ILegendItem.LegendItemTextColor { get { return Color.Black; } }
        Font ILegendItem.LegendItemFont { get { return null; } }
        Color ILegendItem.LegendItemStrokeColor { get { return LegendItemStrokeColor; } }
        Color ILegendItem.LegendItemFillColor { get { return LegendItemFillColor; } }
        MarkerShape ILegendItem.LegendItemMarkerShape { get { return LegendItemMarkerShape; } }
        DashStyle ILegendItem.LegendItemDashStyle { get { return LegendItemDashStyle; } }
        double ILegendItem.LegendItemLineThickness { get { return LegendItemLineThickness; } }
        double ILegendItem.LegendItemMarkerSize { get { return LegendItemMarkerSize; } }
        #endregion
    }

    /// <summary>
    /// Specifies the kind of a legend item.
    /// </summary>
    public enum LegendItemKind
    {
        None,
        Point,
        Line,
        KML,
        ColorSwatch,
        Text,
    }

    /// <summary>
    /// Interface that should be implemented by objects which may be represented in a legend.
    /// It exposes properties that enable the legend to draw a representation of the object
    /// (such as a layer or a style).
    /// </summary>
    public interface ILegendItem
    {
        /// <summary>
        /// Gets the kind of legend item.
        /// </summary>
        LegendItemKind LegendItemKind { get; }
        /// <summary>
        /// Gets the legend item's caption.
        /// </summary>
        string LegendItemCaption { get; }
        /// <summary>
        /// Gets the legend item's visibility.
        /// </summary>
        bool LegendItemVisible { get; }
        /// <summary>
        /// Gets the legend item's text color.
        /// </summary>
        Color LegendItemTextColor { get; }
        /// <summary>
        /// Gets the legend item's font.
        /// </summary>
        Font LegendItemFont { get; }
        /// <summary>
        /// Gets the legend item graphic's stroke color.
        /// </summary>
        Color LegendItemStrokeColor { get; }
        /// <summary>
        /// Gets the legend item graphic's fill color.
        /// </summary>
        Color LegendItemFillColor { get; }
        /// <summary>
        /// Gets the legend item graphic's shape (for point marker item kind).
        /// </summary>
        MarkerShape LegendItemMarkerShape { get; }
        /// <summary>
        /// Gets the legend item graphic's dash style (for line item kind).
        /// </summary>
        DashStyle LegendItemDashStyle { get; }
        /// <summary>
        /// Gets the legend item graphic's line thickness in 96dpi pixels (for line item kind). Specify -1 to use the default.
        /// </summary>
        double LegendItemLineThickness { get; }
        /// <summary>
        /// Gets the legend item graphic's marker size in 96dpi pixels (for point marker item kind). Specify -1 to use the default.
        /// </summary>
        double LegendItemMarkerSize { get; }
    }

    /// <summary>
    /// Enumerates the possible map tile sources.
    /// </summary>
    public enum TileSource
    {
        None,
        //
        VirtualEarthRoad,
        VirtualEarthAerial,
        VirtualEarthHybrid,
        //
        OpenStreet,
        CloudMade,
    }

    /// <summary>
    /// Enumerates the line dash styles.
    /// </summary>
    public enum DashStyle
    {
        Solid,
        Dash,
        Dot,
        DashDot,
        DashDotDot,
    }

    /// <summary>
    /// Enumerates the marker shapes.
    /// </summary>
    public enum MarkerShape
    {
        None,
        Circle,
        Triangle,
        Square,
        Diamond,
        Star,
    }

    /// <summary>
    /// Specifies a scale type.
    /// </summary>
    public enum ScaleType
    {
        /// <summary>
        /// Linear scale.
        /// </summary>
        Linear,
        /// <summary>
        /// Logarithmic scale.
        /// </summary>
        Logarithmic,
    }

    /// <summary>
    /// Represents a longitude/latitude pair.
    /// </summary>
    /// <typeparam name="T">The type used to represent longitude and latitude.</typeparam>
    public struct LonLat<T>
    {
        public LonLat(T longitude, T latitude)
            : this()
        {
            Longitude = longitude;
            Latitude = latitude;
        }
        public T Longitude { get; set; }
        public T Latitude { get; set; }
    }

    /// <summary>
    /// Interface for cloneable objects owned by a Map field.
    /// </summary>
    public interface IMapOwnedCloneable
    {
        object Clone(Map newOwner);
        Map Owner { get; }
    }

    /// <summary>
    /// Abstract base class for types owned by a Map field.
    /// </summary>
    public abstract class MapOwnedItemBase
    {
        #region Categories (for property grid grouping)
        protected const string c_catGeneral = "General";
        protected const string c_catLocation = "Location";
        protected const string c_catAppearance = "Appearance";
        protected const string c_catData = "Data";
        #endregion

        #region private data
        private Map _owner = null;
        #endregion

        #region ctor
        public MapOwnedItemBase(Map owner)
        {
            _owner = owner;
        }
        #endregion

        #region infrastructure
        [XmlIgnore]
        [Browsable(false)]
        public Map Owner
        {
            get { return _owner; }
            set
            {
                OnOwnerChanging();
                _owner = value;
                OnOwnerChanged();
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        public C1Report ParentReport
        {
            get
            {
                if (Owner != null)
                    return Owner.ParentReport;
                return null;
            }
        }

        protected virtual void OnPropertyChanged()
        {
            if (Owner != null)
                Owner.OnPropertyChanged();
        }

        protected virtual void OnOwnerChanging()
        {
        }

        protected virtual void OnOwnerChanged()
        {
        }

        /// <summary>
        /// Gets a one word description of the item type (e.g. "Layer").
        /// Also used to automatically generate new items' names.
        /// </summary>
        [Browsable(false)]
        [XmlIgnore]
        public abstract string BaseName { get; }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets the name of the item. If specified, and the item is contained in a collection,
        /// this name can be used in script expressions to reference the item by name rather than by index.
        /// </summary>
        [Category(c_catData)]
        [Description("The name of the item. This name can be used in script expressions to reference the item in the containing collection by name rather than by index.")]
        public virtual string Name
        {
            get;
            set;
        }
        #endregion
    }

    /// <summary>
    /// Represents a map item with a unique immutable key.
    /// </summary>
    public abstract class MapOwnedKeyedItem : MapOwnedItemBase
    {
        #region private data
        private string _key = null;
        #endregion

        #region ctor
        public MapOwnedKeyedItem(Map owner)
            : base(owner)
        {
            _key = string.Format(CultureInfo.InvariantCulture, "k{0:x}", Util.GenerateId());
        }
        #endregion

        #region infrastructure
        /// <summary>
        /// Unique string identifying the layer.
        /// May be used as the layer's name in C1Maps so should be a valid id
        /// (alpha-numeric starting with a letter).
        /// <para>
        /// NOTE: the set accessor is for serialization ONLY. This property must NOT be changed.
        /// </para>
        /// </summary>
        [Browsable(false)]
        public string Key
        {
            get { return _key; }
            set
            {
                _key = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

    /// <summary>
    /// Represents a collection of elements derived from <see cref="MapOwnedItemBase"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MapOwnedCollectionBase<T> :
        ObservableCollection<T>, IMapOwnedCloneable
        where T : MapOwnedItemBase
    {
        #region Serialization
        /// <summary>
        /// Must be initialized in the static ctor.
        /// </summary>
        public static XmlSerializer Serializer;
        #endregion

        #region Private data
        private Map _owner = null;
        #endregion

        #region Constructions
        public MapOwnedCollectionBase()
        {
        }

        public MapOwnedCollectionBase(Map owner)
        {
            _owner = owner;
        }

        public object Clone(Map newOwner)
        {
            using (var ms = new MemoryStream())
            {
                Serializer.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                var clone = (MapOwnedCollectionBase<T>)Serializer.Deserialize(ms);
                clone.Owner = newOwner;
                return clone;
            }
        }
        #endregion

        #region Infrastructure
        public IEnumerable<T> FindAll(Predicate<T> p)
        {
            foreach (T item in this)
                if (p(item))
                    yield return item;
        }

        public IEnumerable<T> FindAllReverse(Predicate<T> p)
        {
            for (int i = this.Count - 1; i >= 0; --i)
                if (p(this[i]))
                    yield return this[i];
        }

        public int CountAll(Predicate<T> p)
        {
            int i = 0;
            foreach (T item in FindAll(p))
                ++i;
            return i;
        }
        #endregion

        #region Overrides
        protected override void InsertItem(int index, T item)
        {
            if (string.IsNullOrEmpty(item.Name))
                item.Name = string.Format(CultureInfo.InvariantCulture, "{0}{1}", item.BaseName, index);
            base.InsertItem(index, item);
        }

        protected override void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
                foreach (MapOwnedItemBase l in e.OldItems)
                    l.Owner = null;

            if (e.NewItems != null)
                foreach (MapOwnedItemBase l in e.NewItems)
                    l.Owner = Owner;

            base.OnCollectionChanged(e);

            if (Owner != null)
                Owner.OnPropertyChanged();
        }

        public virtual T this[string name]
        {
            get
            {
                foreach (T it in FindAll((i) => i.Name == name))
                    return it;
                return null;
            }
            set
            {
                for (int i = 0; i < Count; ++i)
                    if (this[i].Name == name)
                    {
                        this[i] = value;
                        return;
                    }
                this.Add(value);
            }
        }
        #endregion

        #region Public properties
        [XmlIgnore]
        public Map Owner
        {
            get { return _owner; }
            set
            {
                if (_owner != value)
                {
                    _owner = value;
                    foreach (MapOwnedItemBase l in Items)
                        l.Owner = _owner;
                }
            }
        }
        #endregion
    }

#if !WPF
    /// <summary>
    /// Represents an editor for a collection derived from MapOwnedCollectionBase.
    /// </summary>
    /// <typeparam name="TColl"></typeparam>
    public class MapOwnedCollectionEditor<TColl>
        : System.ComponentModel.Design.CollectionEditor
         where TColl : class, IMapOwnedCloneable, INotifyCollectionChanged, INotifyPropertyChanged
    {
        #region private data
        protected TColl _editItems = null;
        protected bool _cancel = false;
        // key name used to save last used collection editor window's size and position
        // (e.g. in C1ReportDesigner.EXE.settings):
        private const string s_windowPosSetting = "MapCollectionEditorWindow";
        #endregion

        #region ctor
        public MapOwnedCollectionEditor()
            : base(typeof(TColl))
        {
        }
        #endregion

        #region overrides
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (Util.GetReadOnlyAttribute(context.PropertyDescriptor))
            {
                MessageBox.Show("Cannot edit a read-only collection.", "Map Custom Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return value;
            }

            var original = (TColl)value;
            _editItems = (TColl)original.Clone(original.Owner);
            bool changed = false;
            _editItems.CollectionChanged += (ss, ee) => changed = true;
            _editItems.PropertyChanged += (ss, ee) => changed = true;

            var v = base.EditValue(context, provider, _editItems);
            if (!_cancel && changed)
                return _editItems;
            else
                return original;
        }

        protected override string GetDisplayText(object value)
        {
            var item = value as MapOwnedItemBase;
            if (item != null && !string.IsNullOrEmpty(item.Name))
                return item.Name;
            return base.GetDisplayText(value);
        }

        protected virtual bool ExpandGrid { get { return false; } }

        protected virtual bool Validate() { return true; }

        protected virtual void OnGridSelectedObjectsChanged(PropertyGrid propGrid) { }

        protected override CollectionForm CreateCollectionForm()
        {
            var cf = base.CreateCollectionForm();
            var settingPersister = C1Report.Services.GetService(typeof(C1.C1Preview.IDesignerSettingPersistService)) as C1.C1Preview.IDesignerSettingPersistService;
			// Add cancel and validation logic, also save window size/position:
            cf.FormClosing += (ss, ee) =>
            {
                _cancel = cf.DialogResult == DialogResult.Cancel;
                if (!_cancel)
                {
                    if (!Validate())
                    {
                        // The editor at this point has already lost the value, reassign:
                        cf.EditValue = _editItems;
                        ee.Cancel = true;
                    }
                }
                if (settingPersister != null)
                {
                    settingPersister.Save(s_windowPosSetting,
                        new System.Windows.Rect(cf.DesktopBounds.X, cf.DesktopBounds.Y, cf.DesktopBounds.Width, cf.DesktopBounds.Height).ToString(CultureInfo.InvariantCulture));
                }
            };
            // restore last window size/position:
            if (settingPersister != null)
            {
                try
                {
                    var wRect = System.Windows.Rect.Parse(settingPersister.Load(s_windowPosSetting));
                    cf.StartPosition = FormStartPosition.Manual;
                    cf.DesktopBounds = new Rectangle((int)wRect.X, (int)wRect.Y, (int)wRect.Width, (int)wRect.Height);
                }
                catch
                {
                    // ne smogla...
                }
            }
            // This allows to alt-tab back to the collection editor window:
            cf.ShowInTaskbar = true;
            // Turn help display on, and provide a selected object change hook, in the property grid:
            var propGrid = FindControl<PropertyGrid>(cf.Controls);
            if (propGrid != null)
            {
                propGrid.HelpVisible = true;
                propGrid.SelectedObjectsChanged += (ss, ee) => OnGridSelectedObjectsChanged(propGrid);
                if (ExpandGrid)
                {
                    cf.Shown += (ss, ee) => propGrid.ExpandAllGridItems();
                    var list = FindControl<ListBox>(cf.Controls);
                    if (list != null)
                        list.SelectedIndexChanged += (ss, ee) => propGrid.ExpandAllGridItems();
                }
            }
            // done:
            return cf;
        }
        #endregion

        #region privates
        private T FindControl<T>(Control.ControlCollection coll) where T : Control
        {
            if (coll != null)
            {
                foreach (Control c in coll)
                {
                    if (c is T)
                        return (T)c;
                    else
                    {
                        var pg = FindControl<T>(c.Controls);
                        if (pg != null)
                            return pg;
                    }
                }
            }
            return null;
        }
        #endregion
    }
#endif

}
