using System;
using System.Drawing;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Abstract base class for types representing items in a map legend.
    /// </summary>
    [XmlInclude(typeof(LegendLayerStyleItem))]
    [XmlInclude(typeof(LegendColorSwatchItem))]
    [XmlInclude(typeof(LegendTextItem))]
    public abstract class LegendItemBase : MapOwnedItemBase, ILegendItem
    {
        #region Private data
        private bool _visible = true;
        private string _caption = null;
        private Font _font = null;
        private Color _textColor = Color.Black;
        #endregion

        #region ctors
        public LegendItemBase()
            : base(null)
        {
        }

        public LegendItemBase(Map owner) :
            base(owner)
        {
        }
        #endregion

        #region Infrastructure
        /// <summary>
        /// Called by design time editor when item is selected.
        /// Allows to update readonly-ness of properties depending on values etc.
        /// </summary>
        public virtual void OnItemSelectedInEditor()
        {
        }
        #endregion

        #region IMapperLegendItem implementation
        LegendItemKind ILegendItem.LegendItemKind
        {
            get { return Kind; }
        }

        string ILegendItem.LegendItemCaption
        {
            get { return Caption; }
        }

        bool ILegendItem.LegendItemVisible
        {
            get { return Visible; }
        }

        Color ILegendItem.LegendItemTextColor
        {
            get { return TextColor; }
        }

        Font ILegendItem.LegendItemFont
        {
            get { return Font; }
        }

        Color ILegendItem.LegendItemStrokeColor
        {
            get { return Stroke; }
        }

        Color ILegendItem.LegendItemFillColor
        {
            get { return Fill; }
        }

        MarkerShape ILegendItem.LegendItemMarkerShape
        {
            get { return MarkerShape; }
        }

        DashStyle ILegendItem.LegendItemDashStyle
        {
            get { return DashStyle; }
        }

        double ILegendItem.LegendItemLineThickness
        {
            get { return LineThickness; }
        }

        double ILegendItem.LegendItemMarkerSize
        {
            get { return MarkerSize; }
        }
        #endregion

        #region Virtuals allowing derived types to provide ILegendItem implementation
        [Browsable(false)]
        [XmlIgnore]
        public virtual LegendItemKind Kind
        {
            get { return LegendItemKind.None; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual Color Stroke
        {
            get { return Color.Empty; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual Color Fill
        {
            get { return Color.Empty; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual MarkerShape MarkerShape
        {
            get { return MarkerShape.Circle; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual DashStyle DashStyle
        {
            get { return DashStyle.Solid; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual double LineThickness
        {
            get { return -1; }
            set { }
        }

        [Browsable(false)]
        [XmlIgnore]
        public virtual double MarkerSize
        {
            get { return -1; }
            set { }
        }
        #endregion

        #region Public object model
        /// <summary>
        /// Gets or sets the item's visibility.
        /// </summary>
        [Category(c_catGeneral)]
        [Description("The item's visibility.")]
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
        /// Gets or sets the text representing the current item in the legend.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Text representing the current item in the legend.")]
        [XmlIgnore]
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

        public bool ShouldSerializeCaption()
        {
            return !string.IsNullOrEmpty(_caption);
        }

        [XmlElement("Caption")]
        [Browsable(false)]
        public string CaptionXml
        {
            get { return _caption; }
            set { Caption = value; }
        }

        /// <summary>
        /// Gets or sets the font used to draw the current item's <see cref="Caption"/>.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Font used to draw the current item's text in the legend.")]
        [DefaultValue(null)]
        [XmlIgnore]
        public Font Font
        {
            get { return _font; }
            set
            {
                _font = value;
                OnPropertyChanged();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Font")]
        public string FontXml
        {
            get { return Util.FontToString(Font); }
            set { Font = Util.StringToFont(value); }
        }

        /// <summary>
        /// Gets or sets the color used to draw the current item's <see cref="Caption"/>.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("The current item's text color.")]
        [DefaultValue(typeof(Color), "Black")]
        [XmlIgnore]
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                OnPropertyChanged();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("TextColor")]
        public string TextColorXml
        {
            get { return Util.ColorToString(TextColor); }
            set { TextColor = Util.StringToColor(value); }
        }
        #endregion
    }

    /// <summary>
    /// Represents a legend item describing a map layer or a layer style.
    /// <para>
    /// The layer may belong to a different map in the report. This may be used
    /// to place a legend outside the map's bounds for instance.
    /// </para>
    /// <para>
    /// If no layer or style is associated with the legend item, arbitrary markers, colors
    /// etc may be selected.
    /// </para>
    /// </summary>
    public class LegendLayerStyleItem : LegendItemBase
    {
        #region Private data
        private string _targetKey = null;
        private GraphicKindEnum _graphicKind = GraphicKindEnum.Point;
        private Color _stroke = MarkerStyle.c_StrokeColor;
        private Color _fill = MarkerStyle.c_FillColor;
        private DashStyle _dashStyle = DashStyle.Solid;
        private MarkerShape _markerShape = MarkerShape.Circle;
        private double _markerSize = -1d;
        private double _lineThickness = -1d;
        #endregion

        #region ctors
        public LegendLayerStyleItem()
            : base(null)
        {
        }

        public LegendLayerStyleItem(Map owner) :
            base(owner)
        {
        }
        #endregion

        #region Infrastructure
        public override string BaseName { get { return "LayerStyle"; } }

        public override void OnItemSelectedInEditor()
        {
            var isReadOnly = LayerStyle != null;
            var props = TypeDescriptor.GetProperties(this);
            Util.SetReadOnlyAttribute(props["Stroke"], isReadOnly);
            Util.SetReadOnlyAttribute(props["Fill"], isReadOnly || this.GraphicKind == GraphicKindEnum.Line);
            Util.SetReadOnlyAttribute(props["MarkerShape"], isReadOnly || this.GraphicKind == GraphicKindEnum.Line);
            Util.SetReadOnlyAttribute(props["DashStyle"], isReadOnly || this.GraphicKind == GraphicKindEnum.Point);
            Util.SetReadOnlyAttribute(props["GraphicKind"], isReadOnly);
            Util.SetReadOnlyAttribute(props["LineThickness"], this.GraphicKind != GraphicKindEnum.Line);
            Util.SetReadOnlyAttribute(props["MarkerSize"], this.GraphicKind != GraphicKindEnum.Point);
            base.OnItemSelectedInEditor();
        }

        public override LegendItemKind Kind
        {
            get
            {
                var t = LayerStyle;
                if (t != null)
                    return t.LegendItemKind;
                else if (GraphicKind == LegendLayerStyleItem.GraphicKindEnum.Point)
                    return LegendItemKind.Point;
                else if (GraphicKind == LegendLayerStyleItem.GraphicKindEnum.Line)
                    return LegendItemKind.Line;
                else
                {
                    System.Diagnostics.Debug.Assert(false, "unknown layer style");
                    return LegendItemKind.None;
                }
            }
        }

        private IEnumerable<ILegendItem> FindAllTargets()
        {
            if (Owner != null)
            {
                foreach (Map map in Owner.FindAllMaps(true))
                {
                    // scan layers
                    foreach (LayerBase layer in map.Layers.FindAll((l) => l is PointsLayer || l is LinesLayer))
                        yield return layer;
                    // scan styles
                    foreach (MapStyleBase style in map.MarkerStyles)
                        yield return style;
                    foreach (MapStyleBase style in map.LineStyles)
                        yield return style;
                    foreach (MapStyleBase style in map.KmlItemStyles)
                        yield return style;
                }
            }
        }

        #endregion

        #region Nested types
        /// <summary>
        /// Specifies the kind of graphic shown by a legend item.
        /// </summary>
        public enum GraphicKindEnum
        {
            /// <summary>
            /// The graphic is a point marker.
            /// </summary>
            Point,
            /// <summary>
            /// The graphic is a line.
            /// </summary>
            Line,
        }

        public class LayerStyleConverter : TypeConverter
        {
            private const string EmptyName = "(none)";

            private static string TargetToString(ILegendItem target, ITypeDescriptorContext context)
            {
                if (target == null)
                    return EmptyName;
                else if (context != null)
                {
                    var legend = context.Instance as LegendItemBase;
                    if (legend != null && ((MapOwnedKeyedItem)target).Owner == legend.Owner)
                        return ((MapOwnedKeyedItem)target).Name;
                    else
                        return string.Format(CultureInfo.InvariantCulture, "{0}: {1}", ((MapOwnedKeyedItem)target).Owner.Name, ((MapOwnedKeyedItem)target).Name);
                }
                else
                    return ((MapOwnedKeyedItem)target).Name;
            }

            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                var item = context.Instance as LegendLayerStyleItem;
                if (item == null || item.Owner == null)
                    return null;

                List<object> values = new List<object>();
                values.Add(null);
                foreach (ILegendItem li in item.FindAllTargets())
                    values.Add(li);
                return new StandardValuesCollection(values);
            }

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string))
                    return true;
                return base.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                if (value == null)
                    return null;
                else if (value is string)
                {
                    if (context == null)
                        return null;

                    var key = (string)value;
                    if (key == EmptyName)
                        return null;

                    var m = context.Instance as LegendLayerStyleItem;
                    ILegendItem lMatchedName = null;
                    if (!string.IsNullOrEmpty(key) && m != null && m.Owner != null)
                    {
                        foreach (ILegendItem li in m.FindAllTargets())
                        {
                            if (((MapOwnedKeyedItem)li).Key == key)
                                return li;
                            // PropertyGrid uses the standard values' ToString to show the list, BUT ALSO
                            // to convert back from those strings, hence this:
                            if (TargetToString(li, context) == key)
                                lMatchedName = li;
                        }
                    }
                    return lMatchedName;
                }
                else
                    return base.ConvertFrom(context, culture, value);
            }

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(string))
                    return true;
                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType == typeof(string))
                    return TargetToString(value as ILegendItem, context);
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
        #endregion

        #region Public object model
        /// <summary>
        /// Gets or sets the layer or style associated with the current legend item.
        /// The layer or style may belong to a different <see cref="Map"/> in the report.
        /// </summary>
        [Category(c_catData)]
        [Description("Layer or layer style associated with this legend item (may belong to any map in the report). " +
            "If specified, the graphic shown by the item is determined by the layer or style and cannot be changed.")]
        [XmlIgnore]
        [TypeConverter(typeof(LayerStyleConverter))]
        [DefaultValue(null)]
        public ILegendItem LayerStyle
        {
            get
            {
                if (Owner == null || string.IsNullOrEmpty(TargetKey))
                    return null;
                Predicate<MapOwnedKeyedItem> matchKey = (t) => t.Key == TargetKey;
                foreach (ILegendItem li in FindAllTargets())
                    if (matchKey((MapOwnedKeyedItem)li))
                        return li;
                return null;
            }
            set
            {
                if (!(value is MapOwnedKeyedItem))
                    TargetKey = null;
                else
                    TargetKey = ((MapOwnedKeyedItem)value).Key;
                OnItemSelectedInEditor();
            }
        }

        /// <summary>
        /// Gets or sets the key identifying the layer or style associated with this legend item.
        /// May be null or empty, in which case the item is not associated with any layer or style.
        /// </summary>
        [Browsable(false)]
        public string TargetKey
        {
            get { return _targetKey; }
            set
            {
                _targetKey = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the caption of this legend item.
        /// May be empty, in which case the caption is retrieved from the associated layer if possible.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("The item text. If a layer is associated with this item, the layer's caption is the default (but may be redefined). Clear value to revert to the layer's caption.")]
        [XmlIgnore]
#if !WPF
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
        public override string Caption
        {
            get
            {
                if (string.IsNullOrEmpty(base.Caption))
                {
                    var t = LayerStyle;
                    if (t != null)
                        return t.LegendItemCaption;
                }
                return base.Caption;
            }
        }

        /// <summary>
        /// Gets or sets the kind of graphic shown by the current legend item.
        /// If a layer or style is associated with this item, the value of this property is determined by
        /// it and cannot be changed.
        /// </summary>
        [DefaultValue(GraphicKindEnum.Point)]
        [ReadOnly(false)]
        [Category(c_catData)]
        [Description("The kind of graphic shown by this legend item. If LayerStyle is specified, this property is determined by it and cannot be changed.")]
        public GraphicKindEnum GraphicKind
        {
            get
            {
                var t = LayerStyle;
                if (t != null)
                {
                    switch (t.LegendItemKind)
                    {
                        case LegendItemKind.Line:
                            return GraphicKindEnum.Line;
                        default:
                            return GraphicKindEnum.Point;
                    }
                }
                else
                    return _graphicKind;
            }
            set
            {
                _graphicKind = value;
                OnPropertyChanged();
                OnItemSelectedInEditor();
            }
        }

        public bool ShouldSerializeGraphicKind()
        {
            return LayerStyle == null && GraphicKind != GraphicKindEnum.Point;
        }

        /// <summary>
        /// Gets or sets the stroke color used to draw the graphic shown by this legend item.
        /// If a layer or style is associated with this item, the value of this property
        /// is determined by it and cannot be changed.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Stroke color used to draw the graphic shown by this legend item. If a layer or style is specified, this property is determined by it and cannot be changed.")]
        [ReadOnly(false)]
        [Browsable(true)]
        [XmlIgnore]
        public override Color Stroke
        {
            get
            {
                var t = LayerStyle;
                return t != null ? t.LegendItemStrokeColor : _stroke;
            }
            set
            {
                if (LayerStyle == null)
                {
                    _stroke = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShouldSerializeStroke()
        {
            return LayerStyle == null;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Stroke")]
        public string StrokeXml
        {
            get { return Util.ColorToString(Stroke); }
            set { Stroke = Util.StringToColor(value); }
        }

        public bool ShouldSerializeStrokeXml()
        {
            return ShouldSerializeStroke();
        }

        /// <summary>
        /// Gets or sets the fill color used to draw the graphic shown by this legend item.
        /// If a layer or style is associated with this item, the value of this property
        /// is determined by it and cannot be changed.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Fill color used to draw the graphic shown by this legend item. If a layer or style is specified, this property is determined by it and cannot be changed.")]
        [ReadOnly(false)]
        [Browsable(true)]
        [XmlIgnore]
        public override Color Fill
        {
            get
            {
                var t = LayerStyle;
                return t != null ? t.LegendItemFillColor : _fill;
            }
            set
            {
                if (LayerStyle == null)
                {
                    _fill = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShouldSerializeFill()
        {
            return LayerStyle == null;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Fill")]
        public string FillXml
        {
            get { return Util.ColorToString(Fill); }
            set { Fill = Util.StringToColor(value); }
        }

        public bool ShouldSerializeFillXml()
        {
            return ShouldSerializeFill();
        }

        /// <summary>
        /// Gets or sets the marker shape used to draw point kind graphic shown by this legend item.
        /// If a layer or style is associated with this item, the value of this property
        /// is determined by it and cannot be changed.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("For point graphic kind, specifies the marker shape shown by this legend item. If a layer or style is specified, this property is determined by it and cannot be changed.")]
        [ReadOnly(false)]
        [Browsable(true)]
        public override MarkerShape MarkerShape
        {
            get
            {
                var t = LayerStyle;
                return t != null ? t.LegendItemMarkerShape : _markerShape;
            }
            set
            {
                if (LayerStyle == null)
                {
                    _markerShape = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShouldSerializeMarkerShape()
        {
            return LayerStyle == null;
        }

        /// <summary>
        /// Gets or sets the line dash style used to draw line kind graphic shown by this legend item.
        /// If a layer or style is associated with this item, the value of this property
        /// is determined by it and cannot be changed.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("For line graphic kind, specifies the line dash style shown by this legend item. If a layer or style is specified, this property is determined by it and cannot be changed.")]
        [ReadOnly(false)]
        [Browsable(true)]
        public override DashStyle DashStyle
        {
            get
            {
                var t = LayerStyle;
                return t != null ? t.LegendItemDashStyle : _dashStyle;
            }
            set
            {
                if (LayerStyle == null)
                {
                    _dashStyle = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShouldSerializeDashStyle()
        {
            return LayerStyle == null;
        }

        /// <summary>
        /// Gets or sets the line thickness used to draw line kind graphic shown by this legend item.
        /// Specify -1 to use the default.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("For line graphic kind, specifies the line thickness shown by this legend item. A value of -1 uses the default.")]
        [ReadOnly(false)]
        [Browsable(true)]
        [DefaultValue(-1d)]
        public override double LineThickness
        {
            get { return _lineThickness; }
            set
            {
                _lineThickness = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the marker size used to draw point kind graphic shown by this legend item.
        /// Specify -1 to use the default.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("For point graphic kind, specifies the marker size shown by this legend item. A value of -1 uses the default.")]
        [ReadOnly(false)]
        [Browsable(true)]
        [DefaultValue(-1d)]
        public override double MarkerSize
        {
            get { return _markerSize; }
            set
            {
                _markerSize = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

    /// <summary>
    /// Represents a color swatch legend item.
    /// Shows a colored swatch along with some descriptive text.
    /// </summary>
    public class LegendColorSwatchItem : LegendItemBase
    {
        #region Private data
        private Color _swatchColor = Color.Transparent;
        #endregion

        #region ctors
        public LegendColorSwatchItem()
            : base(null)
        {
        }

        public LegendColorSwatchItem(Map owner) :
            base(owner)
        {
        }
        #endregion

        #region Infrastructure
        public override string BaseName { get { return "ColorSwatch"; } }

        public override LegendItemKind Kind
        {
            get { return LegendItemKind.ColorSwatch; }
        }

        public override Color Fill
        {
            get { return SwatchColor; }
        }

        public override MarkerShape MarkerShape
        {
            get { return MarkerShape.Square; }
        }
        #endregion

        #region Public object model
        [Category(c_catAppearance)]
        [Description("Specifies the swatch color.")]
        [DefaultValue(typeof(Color), "Transparent")]
        [XmlIgnore]
        public Color SwatchColor
        {
            get { return _swatchColor; }
            set
            {
                _swatchColor = value;
                OnPropertyChanged();
            }
        }

        [Browsable(false)]
        [XmlElement("SwatchColor")]
        public string SwatchColorXml
        {
            get { return Util.ColorToString(SwatchColor); }
            set { SwatchColor = Util.StringToColor(value); }
        }
        #endregion
    }

    /// <summary>
    /// Represents a text only legend item.
    /// Shows arbitrary text.
    /// </summary>
    public class LegendTextItem : LegendItemBase
    {
        #region ctors
        public LegendTextItem()
            : base(null)
        {
        }

        public LegendTextItem(Map owner) :
            base(owner)
        {
        }
        #endregion

        #region Infrastructure
        public override string BaseName { get { return "Text"; } }

        public override LegendItemKind Kind
        {
            get { return LegendItemKind.Text; }
        }
        #endregion
    }

    /// <summary>
    /// Represents a collection of map legend items
    /// (types derived from <see cref="LegendItemBase"/>).
    /// </summary>
#if !WPF
    [Editor(typeof(LegendItemCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class LegendItemCollection : MapOwnedCollectionBase<LegendItemBase>
    {
        #region Serialization
        public const string XmlName = "LegendItems";
        #endregion

        #region ctors
        static LegendItemCollection()
        {
            Serializer = new XmlSerializer(typeof(LegendItemCollection), new XmlRootAttribute(XmlName));
        }

        public LegendItemCollection()
            : base()
        {
        }

        public LegendItemCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region Nested types
#if !WPF
        public class LegendItemCollectionEditor : MapOwnedCollectionEditor<LegendItemCollection>
        {
            protected override Type[] CreateNewItemTypes()
            {
                return new Type[]
                {
                    typeof(LegendLayerStyleItem),
                    typeof(LegendColorSwatchItem),
                    typeof(LegendTextItem),
                };
            }

            protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
            {
                base.OnGridSelectedObjectsChanged(propGrid);
                var i = propGrid.SelectedObject as LegendItemBase;
                if (i != null)
                    i.OnItemSelectedInEditor();
                propGrid.Refresh();
            }

            protected override string GetDisplayText(object value)
            {
                var li = value as LegendItemBase;
                if (li == null || _editItems == null)
                    return base.GetDisplayText(value);
                else if (!string.IsNullOrEmpty(li.Caption))
                    return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", li.Caption, li.BaseName);
                else if (!string.IsNullOrEmpty(li.Name))
                    return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", li.Name, li.BaseName);
                else
                    return string.Format(CultureInfo.InvariantCulture, "Item {0} ({1})", _editItems.IndexOf(li), li.BaseName);
            }
        }
#endif
        #endregion
    }
}
