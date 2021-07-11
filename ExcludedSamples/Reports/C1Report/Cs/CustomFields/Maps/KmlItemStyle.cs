using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a style used to render KML items on a map.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class KmlItemStyle : MapStyleBase
    {
        #region private data
        private const string c_StrokeColorName = "Empty";
        private const string c_FillColorName = "Empty";
        private static readonly Color c_StrokeColor = Color.FromName(c_StrokeColorName);
        private static readonly Color c_FillColor = Color.FromName(c_FillColorName);
        //
        private string _itemNameExpr;
        private Color _strokeColor = c_StrokeColor;
        private Color _fillColor = c_FillColor;
        #endregion

        #region ctors
        public KmlItemStyle()
            : base(null)
        {
        }

        public KmlItemStyle(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region Legend support
        protected override LegendItemKind LegendItemKind { get { return LegendItemKind.ColorSwatch; } }
        protected override Color LegendItemStrokeColor { get { return this.StrokeColor; } }
        protected override Color LegendItemFillColor { get { return this.FillColor; } }
        protected override MarkerShape LegendItemMarkerShape { get { return MarkerShape.Square; } }
        protected override DashStyle LegendItemDashStyle { get { return DashStyle.Solid; } }
        protected override double LegendItemLineThickness { get { return -1; } }
        protected override double LegendItemMarkerSize { get { return -1; } }
        #endregion

        #region infrastructure
        public override string BaseName
        {
            get { return "KmlItemStyle"; }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets an expression specifying the name (caption) associated with the KML item. Set to an empty string ("") to suppress printing of item captions.
        /// </summary>
        [Description("Expression specifying the name (caption) associated with the KML item. " +
            "The special kmlItemName variable may be used here. " +
            "Set to an empty string (\"\") to suppress printing of item captions.")]
        [Category(c_catAppearance)]
        [DefaultValue(null)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ItemNameExpr
        {
            get { return _itemNameExpr; }
            set
            {
                _itemNameExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the stroke color of markers placed on the map.
        /// </summary>
        [Description("Stroke color of markers placed on the map.")]
        [Category(c_catAppearance)]
        [XmlIgnore] // see StrokeColorXml
        public Color StrokeColor
        {
            get { return _strokeColor; }
            set
            {
                _strokeColor = value;
                OnPropertyChanged();
            }
        }

        public bool ShouldSerializeStrokeColor()
        {
            return !Util.IsSameColors(StrokeColor, c_StrokeColor);
        }

        /// <summary>
        /// Serialize <see cref="StrokeColor"/> via XmlSerializer which does not work with System.Drawing.Color.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("StrokeColor")]
        public string StrokeColorXml
        {
            get { return Util.ColorToString(StrokeColor); }
            set { StrokeColor = Util.StringToColor(value); }
        }

        public bool ShouldSerializeStrokeColorXml()
        {
            return ShouldSerializeStrokeColor();
        }

        /// <summary>
        /// Gets or sets the fill color of markers placed on the map.
        /// </summary>
        [Description("Fill color of markers placed on the map.")]
        [Category(c_catAppearance)]
        [XmlIgnore] // see FillColorXml
        public Color FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = value;
                OnPropertyChanged();
            }
        }

        public bool ShouldSerializeFillColor()
        {
            return !Util.IsSameColors(FillColor, c_FillColor);
        }

        /// <summary>
        /// Serialize <see cref="FillColor"/> via XmlSerializer which does not work with System.Drawing.Color.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("FillColor")]
        public string FillColorXml
        {
            get { return Util.ColorToString(FillColor); }
            set { FillColor = Util.StringToColor(value); }
        }

        public bool ShouldSerializeFillColorXml()
        {
            return ShouldSerializeFillColor();
        }
        #endregion
    }

    /// <summary>
    /// Represents a <see cref="KmlItemStyle"/> built into a KML layer.
    /// </summary>
    public class InlineKmlItemStyle : KmlItemStyle
    {
        public InlineKmlItemStyle()
            : base(null)
        {
        }

        public InlineKmlItemStyle(Map owner)
            : base(owner)
        {
        }

        /// <summary>
        /// Suppress showing the name in the property editor, as referencing inline styles
        /// in expressions is not possible.
        /// </summary>
        [Browsable(false)]
        public override string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }
    }

    /// <summary>
    /// Represents a collection of <see cref="KmlItemStyle"/> elements.
    /// </summary>
#if !WPF
    [Editor(typeof(KmlItemStyleCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class KmlItemStyleCollection : MapOwnedCollectionBase<KmlItemStyle>
    {
        #region Serialization
        public const string XmlName = "KmlItemStyles";
        #endregion

        #region ctors
        static KmlItemStyleCollection()
        {
            Serializer = new XmlSerializer(typeof(KmlItemStyleCollection), new XmlRootAttribute(XmlName));
        }

        public KmlItemStyleCollection()
            : base()
        {
        }

        public KmlItemStyleCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        #endregion

        #region Nested types
#if !WPF
        public class KmlItemStyleCollectionEditor : MapOwnedCollectionEditor<KmlItemStyleCollection>
        {
        }
#endif
        #endregion
    }
}
