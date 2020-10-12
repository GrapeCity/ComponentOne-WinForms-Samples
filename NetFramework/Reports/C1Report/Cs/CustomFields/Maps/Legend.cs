using System;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a map legend - an area on a <see cref="Map"/> containing
    /// a list of items derived from <see cref="LegendItemBase"/>.
    /// The following item types are supported:
    /// <list type="bullet">
    /// <item><term><see cref="LegendLayerStyleItem"/></term>
    /// <description>Represents a map layer or layer style. Shows the layer's marker or line, and a descriptive text (the layer's caption by default).</description></item>
    /// <item><term><see cref="LegendColorSwatchItem"/></term>
    /// <description>Shows a color swatch, and a descriptive text.</description></item>
    /// <item><term><see cref="LegendTextItem"/></term>
    /// <description>Shows an arbitrary text.</description></item>
    /// </list>
    /// </summary>
    public class Legend : MapOwnedItemBase
    {
        #region Private data
        private bool _automatic = false;
        private LegendItemCollection _items = new LegendItemCollection();
        private string _caption = null;
        private ContentAlignment _alignment = ContentAlignment.TopRight;
        private Color _backColor = Color.Transparent;
        private Color _textColor = Color.Black;
        private Font _font = null;
        private Padding _margin = new Padding(12);
        private Padding _padding = new Padding(1);
        private Padding _borderThickness = new Padding(1);
        private bool _visible = true;
        private Orientation _orientation = Orientation.Vertical;
        #endregion

        #region ctors
        public Legend()
            : base(null)
        {
        }

        public Legend(Map owner) :
            base(owner)
        {
        }
        #endregion

        #region Infrastructure
        protected override void OnOwnerChanging()
        {
            _items.Owner = null;
            base.OnOwnerChanging();
        }

        protected override void OnOwnerChanged()
        {
            base.OnOwnerChanged();
            _items.Owner = Owner;
        }

        public override string BaseName
        {
            get { return "Legend"; }
        }
        #endregion

        #region Public object model
        /// <summary>
        /// Gets or sets a value indicating whether the current legend's items are
        /// automatically generated at runtime from the map's layers.
        /// If true, the <see cref="Items"/> collection is ignored.
        /// </summary>
        [Category(c_catData)]
        [Description("If true, automatically shows the legend representing the map layers, ignoring the Items collection.")]
        [RefreshProperties(RefreshProperties.All)]
        [DefaultValue(false)]
        public bool Automatic
        {
            get { return _automatic; }
            set
            {
                _automatic = value;
                Util.SetReadOnlyAttribute(this, "Items", _automatic);
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the legend's caption.
        /// </summary>
        [Category(c_catAppearance)]
#if !WPF
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
		[Description("The legend caption.")]
        [DefaultValue(null)]
        public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the alignment of the legend within the map bounds.
        /// </summary>
        [Category(c_catGeneral)]
        [Description("Alignment of the legend within the map bounds.")]
        [DefaultValue(ContentAlignment.TopRight)]
        public ContentAlignment LegendAlignment
        {
            get { return _alignment; }
            set
            {
                _alignment = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the legend's background color.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("The legend's background color.")]
        [DefaultValue(typeof(Color), "Transparent")]
        [XmlIgnore]
        public Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                OnPropertyChanged();
            }
        }

        [Browsable(false)]
        [XmlElement("BackColor")]
        public string BackColorXml
        {
            get { return Util.ColorToString(BackColor); }
            set { BackColor = Util.StringToColor(value); }
        }

        /// <summary>
        /// Gets or sets the legend's text color.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("The legend's text color.")]
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

        /// <summary>
        /// Gets or sets the legend text font.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("The legend text font.")]
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
        /// Gets the collection of legend items. If <see cref="Automatic"/> is true, this collection is ignored.
        /// <para>Note: the set accessor is for serialization only.</para>
        /// </summary>
        [Category(c_catData)]
        [Description("The collection of legend items. If Automatic is true, this collection is created automatically at runtime and cannot be edited.")]
        [ReadOnly(false)]
        public LegendItemCollection Items
        {
            get { return _items; }
            set
            {
                _items = value;
                if (_items != null)
                    _items.Owner = this.Owner;
            }
        }

        /// <summary>
        /// Gets or sets the margin (spacing) between the legend and map edges.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Margin (spacing) between the legend and map edges.")]
        [DefaultValue(typeof(Padding), "12, 12, 12, 12")]
        public Padding Margin
        {
            get { return _margin; }
            set
            {
                _margin = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the padding between the legend and items within.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Padding between the legend and items within.")]
        [DefaultValue(typeof(Padding), "1, 1, 1, 1")]
        public Padding Padding
        {
            get { return _padding; }
            set
            {
                _padding = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the thickness of borders around the legend.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Thickness of borders around the legend.")]
        [DefaultValue(typeof(Padding), "1, 1, 1, 1")]
        public Padding BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                _borderThickness = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the orientation of items within the legend.
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Orientation of items within the legend.")]
        [DefaultValue(Orientation.Vertical)]
        public Orientation Orientation
        {
            get { return _orientation; }
            set
            {
                _orientation = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the legend's visibility.
        /// </summary>
        [Category(c_catGeneral)]
        [Description("The legend's visibility.")]
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
        #endregion
    }

    /// <summary>
    /// Represents a collection of map legends (<see cref="Legend"/>).
    /// </summary>
#if !WPF
    [Editor(typeof(LegendCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
    public class LegendCollection : MapOwnedCollectionBase<Legend>
    {
        #region Serialization
        public const string XmlName = "Legends";
        #endregion

        #region ctors
        static LegendCollection()
        {
            Serializer = new XmlSerializer(typeof(LegendCollection), new XmlRootAttribute(XmlName));
        }

        public LegendCollection()
            : base()
        {
        }

        public LegendCollection(Map owner)
            : base(owner)
        {
        }
        #endregion

        #region Nested types
#if !WPF
        public class LegendCollectionEditor : MapOwnedCollectionEditor<LegendCollection>
        {
            protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
            {
                base.OnGridSelectedObjectsChanged(propGrid);
                var l = propGrid.SelectedObject as Legend;
                if (l != null)
                    Util.SetReadOnlyAttribute(l, "Items", l.Automatic);
                propGrid.Refresh();
            }

            protected override string GetDisplayText(object value)
            {
                var ml = value as Legend;
                if (ml == null)
                    return base.GetDisplayText(value);
                else if (!string.IsNullOrEmpty(ml.Caption))
                    return string.Format(CultureInfo.InvariantCulture, "{1} ({0})", ml.LegendAlignment, ml.Caption);
                else if (!string.IsNullOrEmpty(ml.Name))
                    return string.Format(CultureInfo.InvariantCulture, "{1} ({0})", ml.LegendAlignment, ml.Name);
                else
                    return string.Format(CultureInfo.InvariantCulture, "Legend ({0})", ml.LegendAlignment);
            }
        }
#endif
        #endregion
    }
}
