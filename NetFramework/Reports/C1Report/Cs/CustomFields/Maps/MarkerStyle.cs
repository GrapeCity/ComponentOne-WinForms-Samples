using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a style used to render point markers on a map.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MarkerStyle : MapStyleBase
    {
        #region defaults
        internal const int c_SizeValue = 3;
        internal const string c_SizeExpr = "3";
        internal const string c_StrokeColorName = "OrangeRed";
        internal const string c_FillColorName = "Orange";
        internal const string c_TextColorName = "Black";
        internal static readonly Color c_StrokeColor = Color.FromName(c_StrokeColorName);
        internal static readonly Color c_FillColor = Color.FromName(c_FillColorName);
        internal static readonly Color c_cTextColor = Color.FromName(c_TextColorName);
        internal const MarkerShape c_Shape = MarkerShape.Circle;
        #endregion

        #region private data
        private string _captionExpr;
        private MarkerShape _shape = c_Shape;
        private string _sizeExpr = c_SizeExpr;
        private Color _strokeColor = c_StrokeColor;
        private Color _fillColor = c_FillColor;
        private Font _font = null;
        private Color _textColor = c_cTextColor;
        #endregion

        #region ctors
        public MarkerStyle()
            : base(null)
        {
        }

        public MarkerStyle(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        public override string BaseName
        {
            get { return "MarkerStyle"; }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets the name of a field specifying the caption.
        /// </summary>
        [Description("Expression specifying the caption associated with a mark on the map.")]
        [Category(c_catAppearance)]
        [DefaultValue(null)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string CaptionExpr
        {
            get { return _captionExpr; }
            set
            {
                _captionExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the shape of a mark.
        /// </summary>
        [Description("Shape of a mark on the map.")]
        [Category(c_catAppearance)]
        [DefaultValue(c_Shape)]
        public MarkerShape Shape
        {
            get { return _shape; }
            set
            {
                _shape = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the size of marks placed on the map, in 96 DPI pixels.
        /// </summary>
        [Description("Expression specifying the size of a mark on the map, in 96dpi pixels.")]
        [Category(c_catAppearance)]
        [DefaultValue(c_SizeExpr)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string SizeExpr
        {
            get { return _sizeExpr; }
            set
            {
                _sizeExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the stroke brush of marks placed on the map.
        /// </summary>
        [Description("Color used to stroke a mark on the map.")]
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
        /// Gets or sets the fill brush of marks placed on the map.
        /// </summary>
        [Description("Color used to fill a mark on the map.")]
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

        /// <summary>
        /// Gets or sets the font used to draw mark captions.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Font used to draw mark captions.")]
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
        /// Gets or sets the text color of mark captions.
        /// </summary>
        [Description("Text color of a mark's caption.")]
        [Category(c_catAppearance)]
        [XmlIgnore]
        [Browsable(true)]
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                OnPropertyChanged();
            }
        }

        public bool ShouldSerializeTextColor()
        {
            return !Util.IsSameColors(TextColor, c_cTextColor);
        }

        /// <summary>
        /// Serialize to save <see cref="TextColor"/> via XmlSerializer which does not work with System.Drawing.Color.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("TextColor")]
        public string TextColorXml
        {
            get { return Util.ColorToString(TextColor); }
            set { TextColor = Util.StringToColor(value); }
        }

        public bool ShouldSerializeTextColorXml()
        {
            return ShouldSerializeTextColor();
        }
        #endregion

        #region Legend support
        protected override LegendItemKind LegendItemKind { get { return LegendItemKind.Point; } }
        protected override Color LegendItemStrokeColor { get { return this.StrokeColor; } }
        protected override Color LegendItemFillColor { get { return this.FillColor; } }
        protected override MarkerShape LegendItemMarkerShape { get { return this.Shape; } }
        protected override DashStyle LegendItemDashStyle { get { return DashStyle.Solid; } }
        protected override double LegendItemLineThickness { get { return -1; } }
        protected override double LegendItemMarkerSize
        {
            get
            {
                // We cannot evaluate expressions here, so do the best we can:
                double size;
                if (double.TryParse(this.SizeExpr, NumberStyles.Float, CultureInfo.InvariantCulture, out size))
                    return size;
                else
                    return -1;
            }
        }
        #endregion
    }

    /// <summary>
    /// Represents a <see cref="MarkerStyle"/> built into a <see cref="PointsLayer"/>.
    /// Hides the style's Name as it cannot be used to reference an inline style.
    /// </summary>
    public class InlineMarkerStyle : MarkerStyle
    {
        public InlineMarkerStyle()
            : base(null)
        {
        }

        public InlineMarkerStyle(Map owner)
            : base(owner)
        {
        }

        [Browsable(false)]
        public override string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }
    }

    /// <summary>
    /// Represents a collection of marker styles (elements of type <see cref="MarkerStyle"/>).
    /// </summary>
#if !WPF
    [Editor(typeof(MarkerStyleCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class MarkerStyleCollection : MapOwnedCollectionBase<MarkerStyle>
    {
        #region Serialization
        public const string XmlName = "MarkerStyles";
        #endregion

        #region ctors
        static MarkerStyleCollection()
        {
            Serializer = new XmlSerializer(typeof(MarkerStyleCollection), new XmlRootAttribute(XmlName));
        }

        public MarkerStyleCollection()
            : base()
        {
        }

        public MarkerStyleCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        #endregion

        #region Nested types
#if !WPF
        public class MarkerStyleCollectionEditor : MapOwnedCollectionEditor<MarkerStyleCollection>
        {
        }
#endif
        #endregion
    }
}
