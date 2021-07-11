using System;
using System.IO;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.Globalization;

using C1.C1Preview;
using C1.C1Report;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a map layer containing KML spatial data.
    /// </summary>
    public class KmlLayer : LayerBase
    {
        #region Constants
        /// <summary>
        /// The string "kmlItemName" used in KmlLayer's expressions will be replaced with
        /// the actual quoted KML item name at runtime prior to expression's evaluation.
        /// E.g. the following expression could be used to check for the country:
        /// <code>Country=kmlItemName</code> (note the absense of quotes around kmlName).
        /// </summary>
        public const string varItemName = "kmlItemName";
        #endregion

        #region Private data
        private string _kmlFileName = null;
        // if true, kml file data will be saved with the layer.
        private bool _embedKmlFile = false;
        // Cached kml file data:
        private byte[] _kmlFile = null;
        // runtime only flag raised when the layer has been added to owner;
        // when anything changes, layer is removed from owner and this flag is reset.
        private bool _setOnOwner = false;
        // Expressions:
        private string _itemFilterExpr = null;
        private string _itemTrackExpr = null;
        private string _itemVisibleExpr = null;
        private string _itemStyleExpr;
        private InlineKmlItemStyle _itemStyle;
        #endregion

        #region Nested types
        /// <summary>
        /// Specialized editor for specifying KML/KMZ files.
        /// </summary>
        public class KmlFileEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.Modal;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "KML/KMZ Files (*.kml; *.kmz)|*.kml;*.kmz|All Files (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                        return ofd.FileName;
                }
                return value;
            }
        }
        #endregion

        #region ctors
        public KmlLayer()
            : this(null)
        {
        }

        public KmlLayer(Map owner)
            : base(owner)
        {
            _itemStyle = new InlineKmlItemStyle(owner);
        }
        #endregion

        #region infrastructure
        [XmlIgnore]
        [Browsable(false)]
        internal bool Calculated
        {
            get
            {
                return
                    !string.IsNullOrEmpty(ItemVisibleExpr) ||
                    !string.IsNullOrEmpty(ItemStyleExpr) ||
                    !string.IsNullOrEmpty(ItemTrackExpr);
            }
        }

        public override string BaseName
        {
            get { return "KMLLayer"; }
        }

        internal override bool Validate(out string error)
        {
            if (string.IsNullOrEmpty(KmlFileName))
            {
                error = "KmlFileName must be specified for a KML layer.";
                return false;
            }
            return base.Validate(out error);
        }

        protected override void OnPropertyChanged()
        {
            base.OnPropertyChanged();
            RemoveFromOwner();
        }

        protected override void OnOwnerChanging()
        {
            RemoveFromOwner();
            base.OnOwnerChanging();
        }

        internal void SetKmlOnOwner()
        {
            if (Owner == null || Owner.IsLoading)
                return;

            // setting layer on owner is needed if:
            // - file name is not empty but _setOnOwner is false (file needs to be loaded), or
            // - file name is empty, but _setOnOwner is true (layer needs to be removed).

            if (!string.IsNullOrEmpty(_kmlFileName))
            {
                if (_setOnOwner)
                    return;

                if (!Visible)
                    return;

                try
                {
                    if (_kmlFile == null)
                        CacheKmlFile();
                    System.Diagnostics.Debug.Assert(_kmlFile != null, "KML layer integrity broken");

                    using (var ms = new MemoryStream(_kmlFile, 0, _kmlFile.Length, false))
                        Owner.SetKml(this, ms, Key);
                    _setOnOwner = true;
                }
                catch (Exception ex)
                {
                    var err = ex.InnerException != null ?
                        string.Format(CultureInfo.InvariantCulture, "{0}:\n{1}", ex.Message, ex.InnerException.Message) :
                        ex.Message;
                    var msg = string.Format("Error setting KML/KMZ file: \n{0}", err);
                    Owner.ReportError(_kmlFileName.GetHashCode(), msg);
                }
            }
            else
            {
                RemoveFromOwner();
            }
        }

        internal void RemoveFromOwner()
        {
            if (Owner != null && _setOnOwner)
            {
                Owner.RemoveKmlLayer(Key);
                _setOnOwner = false;
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        public override List<List<string>> PointsLocationExpressions
        {
            get
            {
                return null;
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        public override List<LonLat<string>> PointsLocations
        {
            get { return null; }
        }

        /// <summary>
        /// Hides Caption as KML layers cannot be represented in legends.
        /// </summary>
        [Browsable(false)]
        [XmlIgnore]
        public override string Caption
        {
            get { return Name; }
            set { }
        }
        #endregion

        #region IMapperLegendItem
        public override LegendItemKind LegendItemKind
        {
            get { return LegendItemKind.KML; }
        }

        public override Color LegendItemStrokeColor
        {
            get { return Color.Black; }
        }

        public override Color LegendItemFillColor
        {
            get { return Color.White; }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets the KML/KMZ file name or network URL.
        /// </summary>
        [Description("Local path or network URL of the KML/KMZ file used to draw this layer. If file is embedded, this is for information purposes only.")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor(typeof(KmlFileEditor), typeof(UITypeEditor))]
        [XmlIgnore]
        public string KmlFileName
        {
            get
            {
                if (EmbedKmlFile)
                    return string.Format(CultureInfo.InvariantCulture, "Embedded ({0})", Path.GetFileName(_kmlFileName));
                else
                    return _kmlFileName;
            }
            set
            {
                if (_kmlFileName == value)
                    return;
                _kmlFile = null;
                if (_setOnOwner)
                {
                    System.Diagnostics.Debug.Assert(Owner != null, "KML layer integrity broken");
                    RemoveFromOwner();
                }
                if (Owner != null && !string.IsNullOrEmpty(_kmlFileName))
                    Owner.ResetReportedError(_kmlFileName.GetHashCode());
                _kmlFileName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Used to persist <see cref="KmlFileName"/>.
        /// </summary>
        [Browsable(false)]
        [XmlElement("KmlFileName")]
        public string KmlFileNameXml
        {
            get { return _kmlFileName; }
            set { KmlFileName = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to embed KML data loaded from <see cref="KmlFileName"/> in the report definition file itself.
        /// </summary>
        [Description("If true, KML data will be embedded in the report. Use with caution, and preferably with compressed (KMZ) files, as uncompressed KML files can be very large.")]
        [Category(c_catData)]
        [DefaultValue(false)]
        public bool EmbedKmlFile
        {
            get { return _embedKmlFile; }
            set
            {
                _embedKmlFile = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the KML file data.
        /// </summary>
        [Browsable(false)]
        [DefaultValue(null)]
        public byte[] KmlFileData
        {
            get
            {
                if (EmbedKmlFile)
                {
                    if (_kmlFile == null)
                        CacheKmlFile();
                    return _kmlFile;
                }
                else
                    return null;
            }
            set
            {
                _kmlFile = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a filter string applied to the layer's <see cref="RecordSource"/>.
        /// When KML data is loaded into the layer, for each item being loaded this filter
        /// is applied to the layer data, and item expressions
        /// (<see cref="ItemTrackExpr"/>, <see cref="ItemVisibleExpr"/>, <see cref="ItemStyleExpr"/>)
        /// are evaluated in the context of the first data row matching the filter.
        /// <para>
        /// NOTE: this only works if a custom <see cref="RecordSource"/> is
        /// specified for the KML layer.
        /// </para>
        /// </summary>
        [Description("Filter applied to the layer's RecordSource. " +
            "When KML data is loaded into the layer, for each item this filter is applied to the layer data, " +
            "and item expressions (visibility, tracking, style) are evaluated in the context of the first matching row. " +
            "The special kmlItemName variable may be used here, e.g.: 'kmlItemName=Country'."
            )]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.ExpressionEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ItemFilterExpr
        {
            get { return _itemFilterExpr; }
            set
            {
                _itemFilterExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression that determines whether a KML item's
        /// coordinates are used when calculating auto center/zoom.
        /// If this property is not specified, true is assumed.
        /// </summary>
        [Description("Expression determining whether a KML item's bounds are used to auto zoom/center the map. " +
            "The special kmlItemName variable may be used here. If empty, true is assumed.")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.ExpressionEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ItemTrackExpr
        {
            get { return _itemTrackExpr; }
            set
            {
                _itemTrackExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression that determines whether a KML item is visible.
        /// </summary>
        [Description("Expression determining whether a KML item is visible. The special kmlItemName variable may be used here, " +
            "e.g. \"kmlItemName=Country\" within a \"Country\" group will show only items associated with the current country.")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.ExpressionEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ItemVisibleExpr
        {
            get { return _itemVisibleExpr; }
            set
            {
                _itemVisibleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression that should evaluate to an index or a name of a style in the KmlItemStyles collection
        /// that will be applied to the item. The name may refer to a style in another Map object within the report.
        /// </summary>
        [Description("Expression that should evaluate to an index or a name of a style in the KmlItemStyles collection that will be applied to the item. " +
            "The name may refer to a style in another Map object within the report.")]
        [Category(c_catAppearance)]
        [DefaultValue(null)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string ItemStyleExpr
        {
            get { return _itemStyleExpr; }
            set
            {
                _itemStyleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets the default item style.
        /// <para>Note: the set accessor is for serialization only, and should not be used directly.</para>
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Default KML item style for this layer. Used if ItemStyleExpr is not specified or evaluates to an invalid style.")]
        public InlineKmlItemStyle ItemStyle
        {
            get { return _itemStyle; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _itemStyle = value;
                _itemStyle.Owner = this.Owner;
            }
        }
        #endregion

        #region privates
        private void CacheKmlFile()
        {
            if (_kmlFileName.IndexOf("//") > -1 || _kmlFileName.IndexOf(@"\\") > -1)
            {
                WebRequest fwr = WebRequest.Create(_kmlFileName);
                using (WebResponse wr = fwr.GetResponse())
                using (Stream s = wr.GetResponseStream())
                    CacheKmlFile(s);
            }
            else // local file
            {
                using (var s = new FileStream(Map.GetFullPath(_kmlFileName), FileMode.Open, FileAccess.Read))
                    CacheKmlFile(s);
            }
        }

        private void CacheKmlFile(Stream s)
        {
            using (var ms = new MemoryStream())
            {
                byte[] buf = new byte[16 * 1024];
                while (true)
                {
                    int read = s.Read(buf, 0, buf.Length);
                    if (read == 0)
                        break;
                    ms.Write(buf, 0, read);
                }
                ms.Flush();
                _kmlFile = ms.ToArray();
            }
        }
        #endregion
    }
}
