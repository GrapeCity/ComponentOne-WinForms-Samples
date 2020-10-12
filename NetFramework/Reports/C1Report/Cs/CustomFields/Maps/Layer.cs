using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Globalization;


namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Abstract base class for map layer classes.
    /// </summary>
    [XmlInclude(typeof(PointsLayer))]
    [XmlInclude(typeof(LinesLayer))]
    [XmlInclude(typeof(KmlLayer))]
    public abstract class LayerBase : MapOwnedKeyedItem, ILegendItem
    {
        #region Private data
        private string _caption;
        private string _recordSource;
        private bool _visible = true;
        private bool _track = true;
        private double _opacity = 1;
        #endregion

        #region Ctors
        public LayerBase(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region Internals
        internal virtual bool Validate(out string error)
        {
            error = null;
            return true;
        }
        #endregion

        public override string ToString()
        {
            return GetDefaultName(this);
        }

        #region Statics
        public static string GetDefaultName(LayerBase value)
        {
            if (!string.IsNullOrEmpty(value.Caption))
                return value.Caption;
            else if (!string.IsNullOrEmpty(value.Name))
                return value.Name;
            else
                return value.BaseName;
        }
        #endregion

        #region Public runtime properties
        /// <summary>
        /// Gets the list of lists of location expressions.
        /// The outer list corresponds to the point or points associated
        /// with each record of the layer - i.e. for a points layer, that list
        /// will contain one element, for lines - two etc.
        /// The inner list for each point is the collection of location
        /// expressions. E.g. it can be Country, City, Address.
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public abstract List<List<string>> PointsLocationExpressions
        {
            get;
        }

        [XmlIgnore]
        [Browsable(false)]
        public abstract List<LonLat<string>> PointsLocations
        {
            get;
        }
        #endregion

        #region Public serializable properties
        /// <summary>
        /// Gets or sets the current layer's visibility.
        /// </summary>
        [Description("Layer's visibility. If false, layer is ignored at runtime.")]
        [Category(c_catGeneral)]
        [DefaultValue(true)]
        public bool Visible
        {
            get { return _visible; }
            set
            {
                _visible = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether spatial data from the current layer should be used to auto center/zoom the map.
        /// </summary>
        [Description("Indicates whether spatial data from the current layer should be used to auto center/zoom the map.")]
        [Category(c_catGeneral)]
        [DefaultValue(true)]
        public bool Track
        {
            get { return _track; }
            set
            {
                _track = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the opacity factor applied to the layer.
        /// </summary>
        [Description("Specifies the opacity factor applied to the layer, from 1 (opaque; default) to 0 (transparent).")]
        [Category(c_catGeneral)]
        [DefaultValue(1d)]
        public double Opacity
        {
            get { return _opacity; }
            set
            {
                _opacity = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the current layer's caption.
        /// Used to represent the layer in legends.
        /// </summary>
        [Description("The layer's caption. Used to represent the layer in legends.")]
        [Category(c_catGeneral)]
        [DefaultValue("")]
#if !WPF
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
        public virtual string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an SQL statement used to retrieve data for the layer.
        /// </summary>
        /// <remarks>
        /// If provided, data is retrieved using the parent report's ConnectionString. 
        /// If omitted, data is retrieved directly from the parent report. 
        /// In this latter case, the data is automatically filtered according 
        /// to the current grouping scope (e.g. a layer in a 'Category' 
        /// group header would contain data only for the current category).
        /// </remarks>
        [Description("SQL statement used to retrieve data for the layer. If empty, report's data source is used (report grouping, if any, is applied in that case).")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.ExpressionEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string RecordSource
        {
            get { return _recordSource; }
            set
            {
                _recordSource = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region IMapperLegendItem
        [XmlIgnore]
        [Browsable(false)]
        public abstract LegendItemKind LegendItemKind { get; }

        [XmlIgnore]
        [Browsable(false)]
        public virtual bool LegendItemVisible { get { return true; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual string LegendItemCaption { get { return Caption; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual Color LegendItemTextColor { get { return Color.Empty; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual Font LegendItemFont { get { return null; } }

        [XmlIgnore]
        [Browsable(false)]
        public abstract Color LegendItemStrokeColor { get; }

        [XmlIgnore]
        [Browsable(false)]
        public abstract Color LegendItemFillColor { get; }

        [XmlIgnore]
        [Browsable(false)]
        public virtual MarkerShape LegendItemMarkerShape { get { return MarkerShape.Circle; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual DashStyle LegendItemDashStyle { get { return DashStyle.Solid; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual double LegendItemLineThickness { get { return -1; } }

        [XmlIgnore]
        [Browsable(false)]
        public virtual double LegendItemMarkerSize { get { return -1; } }
        #endregion
    }

    /// <summary>
    /// Represents a collection of map layers.
    /// </summary>
#if !WPF
    [Editor(typeof(LayerCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class LayerCollection : MapOwnedCollectionBase<LayerBase>
    {
        public const string XmlName = "Layers";

        #region Ctors
        static LayerCollection()
        {
            Serializer = new XmlSerializer(typeof(LayerCollection), new XmlRootAttribute(XmlName));
        }

        public LayerCollection()
            : base()
        {
        }

        public LayerCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region Nested types
#if !WPF
        /// <summary>
        /// The layer collection editor.
        /// </summary>
        class LayerCollectionEditor : MapOwnedCollectionEditor<LayerCollection>
        {
            protected override bool Validate()
            {
                if (_editItems != null)
                {
                    // Ensure some sanity:
                    foreach (LayerBase layer in _editItems)
                    {
                        string error;
                        if (!layer.Validate(out error))
                        {
                            MessageBox.Show(string.Format(
                                "Invalid settings for {0}:\n{1}",
                                GetDisplayText(layer), error),
                                "Map Layers Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return base.Validate();
            }

            protected override bool ExpandGrid { get { return true; } }

            protected override Type[] CreateNewItemTypes()
            {
                return new Type[]
                {
                    typeof(PointsLayer),
                    typeof(LinesLayer),
                    typeof(KmlLayer),
                };
            }

            protected override string GetDisplayText(object value)
            {
                if (value is LayerBase)
                    return LayerBase.GetDefaultName((LayerBase)value);
                else
                {
                    System.Diagnostics.Debug.Assert(false, "Unknown layer type");
                    return base.GetDisplayText(value);
                }
            }

            protected override object CreateInstance(Type itemType)
            {
                var l = (LayerBase)base.CreateInstance(itemType);
                if (string.IsNullOrEmpty(l.Caption) && _editItems != null)
                    l.Caption = string.Format(CultureInfo.InvariantCulture, "{0} {1}", GetDisplayText(l), _editItems.Count);

                return l;
            }
        }
#endif
        #endregion
    }
}
