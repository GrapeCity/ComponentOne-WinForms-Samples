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
    /// Represents a style used to render lines on a map.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LineStyle : MapStyleBase
    {
        #region data fields
        internal const string c_LineStroke = "Blue";
        internal const int c_LineThickness = 1;
        internal const string c_ThicknessExpr = "1";
        internal const string c_StrokeColorName = "Blue";
        internal static readonly Color c_StrokeColor = Color.FromName(c_StrokeColorName);
        internal const DashStyle c_DashStyle = DashStyle.Solid;
        //
        private string _thicknessExpr = c_ThicknessExpr;
        private Color _strokeColor = c_StrokeColor;
        private DashStyle _dashStyle = c_DashStyle;
        #endregion

        #region ctors
        public LineStyle()
            : base(null)
        {
        }

        public LineStyle(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        public override string BaseName
        {
            get { return "LineStyle"; }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets the thickness of lines on the map, in 96 DPI pixels.
        /// </summary>
        [Description("Expression specifying the thickness of a line on the map, in 96dpi pixels.")]
        [Category(c_catAppearance)]
        [DefaultValue(c_ThicknessExpr)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ThicknessExpr
        {
            get { return _thicknessExpr; }
            set
            {
                _thicknessExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the stroke brush of marks placed on the map.
        /// </summary>
        [Description("Color used to stroke a line on the map.")]
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
        [DefaultValue(c_DashStyle)]
        public DashStyle DashStyle
        {
            get { return _dashStyle; }
            set
            {
                _dashStyle = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Legend support
        protected override LegendItemKind LegendItemKind { get { return LegendItemKind.Line; } }
        protected override Color LegendItemStrokeColor { get { return this.StrokeColor; } }
        protected override Color LegendItemFillColor { get { return Color.Empty; } }
        protected override MarkerShape LegendItemMarkerShape { get { return MarkerShape.None; } }
        protected override DashStyle LegendItemDashStyle { get { return this.DashStyle; } }
        protected override double LegendItemMarkerSize { get { return -1; } }
        protected override double LegendItemLineThickness
        {
            get
            {
                // We cannot evaluate expressions here, so do the best we can:
                double thickness;
                if (double.TryParse(this.ThicknessExpr, NumberStyles.Float, CultureInfo.InvariantCulture, out thickness))
                    return thickness;
                else
                    return -1;
            }
        }
        #endregion
    }

    /// <summary>
    /// Represents a <see cref="LineStyle"/> built into a <see cref="LinesLayer"/>.
    /// Hides the style's Name as it cannot be used to reference an inline style.
    /// </summary>
    public class InlineLineStyle : LineStyle
    {
        public InlineLineStyle()
            : base(null)
        {
        }

        public InlineLineStyle(Map owner)
            : base(owner)
        {
        }

        /// <summary>
        /// Hide the name from properties window.
        /// </summary>
        [Browsable(false)]
        public override string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }
    }

    /// <summary>
    /// Represents a collection of line styles (elements of type <see cref="LineStyle"/>).
    /// </summary>
#if !WPF
    [Editor(typeof(LineStyleCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class LineStyleCollection : MapOwnedCollectionBase<LineStyle>
    {
        #region Serialization
        public const string XmlName = "LineStyles";
        #endregion

        #region ctors
        static LineStyleCollection()
        {
            Serializer = new XmlSerializer(typeof(LineStyleCollection), new XmlRootAttribute(XmlName));
        }

        public LineStyleCollection()
            : base()
        {
        }

        public LineStyleCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region infrastructure
        #endregion

        #region Nested types
#if !WPF
        public class LineStyleCollectionEditor : MapOwnedCollectionEditor<LineStyleCollection>
        {
        }
#endif
        #endregion
    }
}
