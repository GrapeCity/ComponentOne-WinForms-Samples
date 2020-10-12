using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a map layer containing point markers.
    /// </summary>
    public class PointsLayer : LayerBase
    {
        #region Private data
        private const string c_catClustering = "Clustering";
        private const ScaleType c_ClusterDistribution = ScaleType.Logarithmic;
        //
        private string _mapLocation;
        private string _longitude;
        private string _latitude;
        private string _markerVisibleExpr;
        private string _markerStyleExpr;
        private InlineMarkerStyle _markerStyle;
        // clustering:
        private double _clusterDistance = 0d;
        private MarkerStyleCollection _clusterStyles;
        private ScaleType _clusterDistribution = c_ClusterDistribution;
        // runtime only data:
        private List<List<string>> _locExpressions = null;
        #endregion

        #region ctors
        public PointsLayer()
            : this(null)
        {
        }

        public PointsLayer(Map owner)
            : base(owner)
        {
            _markerStyle = new InlineMarkerStyle(owner);
            _clusterStyles = new MarkerStyleCollection(owner);
        }
        #endregion

        #region Infrastructure
        protected override void OnOwnerChanging()
        {
            _markerStyle.Owner = null;
            _clusterStyles.Owner = null;
            base.OnOwnerChanging();
        }

        protected override void OnOwnerChanged()
        {
            base.OnOwnerChanged();
            _markerStyle.Owner = Owner;
            _clusterStyles.Owner = Owner;
        }

        public override string BaseName
        {
            get { return "PointsLayer"; }
        }

        internal override bool Validate(out string error)
        {
            if (string.IsNullOrEmpty(this.Longitude) != string.IsNullOrEmpty(this.Latitude))
            {
                error = "If either Longitude or Latitude is specified, the other must be specified as well.\nAlternatively, you may specify MapLocation.";
                return false;
            }
            if (string.IsNullOrEmpty(this.Longitude) && string.IsNullOrEmpty(MapLocation))
            {
                error = "Either Longitude/Latitude, or MapLocation must be specified for a Points layer.";
                return false;
            }
            return base.Validate(out error);
        }

        [XmlIgnore]
        [Browsable(false)]
        public override List<List<string>> PointsLocationExpressions
        {
            get
            {
                if (_locExpressions == null)
                {
                    if (!string.IsNullOrEmpty(MapLocation))
                    {
                        _locExpressions = new List<List<string>>() { new List<string>(MapLocation.Split(';')) };
                        _locExpressions[0].ForEach((e) => e.Trim());
                    }
                    else
                        _locExpressions = new List<List<string>>() { null };
                }
                return _locExpressions;
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        public override List<LonLat<string>> PointsLocations
        {
            get { return new List<LonLat<string>>() { new LonLat<string>(this.Longitude, this.Latitude) }; }
        }
        #endregion

        #region IMapperLegendItem
        public override LegendItemKind LegendItemKind
        {
            get { return MarkerStyle.Shape == MarkerShape.None ? LegendItemKind.Text : LegendItemKind.Point; }
        }

        public override Color LegendItemTextColor
        {
            get { return MarkerStyle.TextColor; }
        }

        public override Font LegendItemFont
        {
            get { return MarkerStyle.Font; }
        }

        public override Color LegendItemStrokeColor
        {
            get { return MarkerStyle.StrokeColor; }
        }

        public override Color LegendItemFillColor
        {
            get { return MarkerStyle.FillColor; }
        }

        public override MarkerShape LegendItemMarkerShape
        {
            get { return MarkerStyle.Shape; }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets a string containing one or more semicolon-delimited fields which may be used
        /// to determine the location of an object using an external service such as Google.
        /// Typically these would be the fields specifying the address, e.g. "Address;City;PostalCode;Country".
        /// </summary>
        [Description("A semicolon delimited list of expressions determining the spatial location via an external service (Google). Either this, or Longitude/Latitude must be specified. E.g. \"Address;City;Country\"")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string MapLocation
        {
            get { return _mapLocation; }
            set
            {
                _mapLocation = value;
                _locExpressions = null;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression specifying the longitude of a marker.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the longitude of a marker. Either this and Latitude, or MapLocation must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression specifying the latitude of a marker.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the latitude of a marker. Either this and Longitude, or MapLocation must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression determining whether a marker is visible.
        /// </summary>
        [Description("Expression specifying whether a marker is visible on the map. Empty expression means that the marker is visible.")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string MarkerVisibleExpr
        {
            get { return _markerVisibleExpr; }
            set
            {
                _markerVisibleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression that should evaluate to an index or a name of a style in the MarkerStyles collection
        /// that will be used to draw the marker.
        /// </summary>
        [Description("Expression that should evaluate to an index or a name of a style in the MarkerStyles collection that will be used to draw the marker.")]
        [Category(c_catAppearance)]
        [DefaultValue(null)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string MarkerStyleExpr
        {
            get { return _markerStyleExpr; }
            set
            {
                _markerStyleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets the default marker style.
        /// <para>Note: the set accessor is for serialization only, and should not be used directly.</para>
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Default marker style for this layer. Used if MarkerStyleExpr is not specified or evaluates to an invalid style.")]
        public InlineMarkerStyle MarkerStyle
        {
            get { return _markerStyle; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _markerStyle = value;
                _markerStyle.Owner = this.Owner;
            }
        }

        /// <summary>
        /// Gets or sets the maximum distance (in 96dpi pixels) between markers that should be grouped into clusters.
        /// Default (0) disables clustering.
        /// </summary>
        [Category(c_catClustering)]
        [Description("Maximum distance (in 96dpi pixels) between markers that should be grouped into clusters. Default (0) disables clustering.")]
        [DefaultValue(0d)]
        public double ClusterDistance
        {
            get { return _clusterDistance; }
            set
            {
                _clusterDistance = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the type of cluster styles distribution.
        /// </summary>
        [Category(c_catClustering)]
        [Description("Specifies how styles in the ClusterStyles collection are distributed between clusters depending on their size.")]
        [DefaultValue(c_ClusterDistribution)]
        public ScaleType ClusterDistribution
        {
            get { return _clusterDistribution; }
            set
            {
                _clusterDistribution = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the collection of cluster styles.
        /// </summary>
        [Category(c_catClustering)]
        [Description("Collection of styles used to draw cluster markers. " +
            "Styles in the collection are assigned to markers in order depending on cluster size, from small to large.")]
        [ReadOnly(false)]
        public MarkerStyleCollection ClusterStyles
        {
            get { return _clusterStyles; }
            set
            {
                _clusterStyles = value;
                if (_clusterStyles != null)
                    _clusterStyles.Owner = this.Owner;
            }
        }
        #endregion
    }
}
