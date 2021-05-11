using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Represents a map layer containing lines,
    /// where each line connects two points on the map.
    /// </summary>
    public class LinesLayer : LayerBase
    {
        #region Private data
        private string _mapLocation1;
        private string _mapLocation2;
        private LonLat<string> _lonlat1;
        private LonLat<string> _lonlat2;
        private string _lineVisibleExpr;
        private InlineLineStyle _lineStyle;
        private string _lineStyleExpr;
        // runtime only data:
        private List<List<string>> _locExpressions = null;
        #endregion

        #region ctors
        public LinesLayer()
            : this(null)
        {
        }

        public LinesLayer(Map owner)
            : base(owner)
        {
            _lineStyle = new InlineLineStyle(owner);
        }
        #endregion

        #region IMapperLegendItem
        public override LegendItemKind LegendItemKind
        {
            get { return LegendItemKind.Line; }
        }

        public override Color LegendItemStrokeColor
        {
            get { return _lineStyle.StrokeColor; }
        }

        public override Color LegendItemFillColor
        {
            get { return Color.Empty; }
        }

        public override DashStyle LegendItemDashStyle
        {
            get { return _lineStyle.DashStyle; }
        }
        #endregion

        #region infrastructure
        public override string BaseName
        {
            get { return "LinesLayer"; }
        }

        internal override bool Validate(out string error)
        {
            Func<string, string, int, string> checkLonLat = (lon, lat, idx) =>
                {
                    if (string.IsNullOrEmpty(lon) != string.IsNullOrEmpty(lat))
                        return string.Format(
                            "If either Longitude{0} or Latitude{0} is specified, the other must be specified as well.\nAlternatively, you may specify MapLocation{0}.",
                            idx);
                    return null;
                };
            Func<string, string, int, string> checkMapLoc = (lon, mapLoc, idx) =>
                {
                    if (string.IsNullOrEmpty(lon) && string.IsNullOrEmpty(mapLoc))
                        return string.Format(
                            "Either Longitude{0}/Latitude{0}, or MapLocation{0} must be specified.",
                            idx);
                    return null;
                };

            error = checkLonLat(Longitude1, Latitude1, 1);
            if (error == null)
                error = checkLonLat(Longitude2, Latitude2, 2);
            if (error == null)
                checkMapLoc(Longitude1, MapLocation1, 1);
            if (error == null)
                checkMapLoc(Longitude2, MapLocation2, 2);
            if (error != null)
                return false;
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
                    _locExpressions = new List<List<string>>(2)
                    {
                        string.IsNullOrEmpty(MapLocation1) ? null : new List<string>(MapLocation1.Split(';')),
                        string.IsNullOrEmpty(MapLocation2) ? null : new List<string>(MapLocation2.Split(';')),
                    };
                    if (_locExpressions[0] != null)
                        _locExpressions[0].ForEach((e) => e.Trim());
                    if (_locExpressions[1] != null)
                        _locExpressions[1].ForEach((e) => e.Trim());
                }
                return _locExpressions;
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        public override List<LonLat<string>> PointsLocations
        {
            get
            {
                return new List<LonLat<string>>()
                {
                    _lonlat1,
                    _lonlat2,
                };
            }
        }
        #endregion

        #region public object model
        /// <summary>
        /// Gets or sets a string containing one or more semicolon-delimited fields which may be used
        /// to determine the location of an entity using an external service such as Google.
        /// Typically these would be the fields specifying the address, e.g. "Address;City;PostalCode;Country".
        /// </summary>
        [Description("A semicolon delimited list of expressions determining the spatial location of a line's starting point via an external service (Google). Either this, or Longitude1/Latitude1 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string MapLocation1
        {
            get { return _mapLocation1; }
            set
            {
                _mapLocation1 = value;
                _locExpressions = null;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a string containing one or more semicolon-delimited fields which may be used
        /// to determine the location of an entity using an external service such as Google.
        /// Typically these would be the fields specifying the address, e.g. "Address;City;PostalCode;Country".
        /// </summary>
        [Description("A semicolon delimited list of expressions determining the spatial location of a line's ending point via an external service (Google). Either this, or Longitude2/Latitude2 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string MapLocation2
        {
            get { return _mapLocation2; }
            set
            {
                _mapLocation2 = value;
                _locExpressions = null;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of a field specifying the longitude.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the longitude of a line's starting point. Either this and Latitude1, or MapLocation1 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Longitude1
        {
            get { return _lonlat1.Longitude; }
            set
            {
                _lonlat1.Longitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of a field specifying the latitude.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the latitude of a line's starting point. Either this and Longitude1, or MapLocation1 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Latitude1
        {
            get { return _lonlat1.Latitude; }
            set
            {
                _lonlat1.Latitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of a field specifying the longitude.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the longitude of a line's ending point. Either this and Latitude2, or MapLocation2 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Longitude2
        {
            get { return _lonlat2.Longitude; }
            set
            {
                _lonlat2.Longitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of a field specifying the latitude.
        /// Ignored if <see cref="MapLocation"/> is not empty.
        /// </summary>
        [Description("Expression specifying the latitude of a line's ending point. Either this and Longitude2, or MapLocation2 must be specified.")]
        [Category(c_catLocation)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string Latitude2
        {
            get { return _lonlat2.Latitude; }
            set
            {
                _lonlat2.Latitude = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets expression determining whether a line is visible.
        /// </summary>
        [Description("Expression specifying whether a line is visible on the map. Empty expression means that the line is visible.")]
        [Category(c_catData)]
        [DefaultValue("")]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string LineVisibleExpr
        {
            get { return _lineVisibleExpr; }
            set
            {
                _lineVisibleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets an expression that should evaluate to an index or a name of a style in the LineStyles collection
        /// that will be used to draw the line.
        /// </summary>
        [Description("Expression that should evaluate to an index or a name of a style in the LineStyles collection that will be used to draw the line.")]
        [Category(c_catAppearance)]
        [DefaultValue(null)]
        [Editor("C1.C1Report.Design.TextFieldEditor, C1.C1Report.4.Design", typeof(UITypeEditor))]
        public string LineStyleExpr
        {
            get { return _lineStyleExpr; }
            set
            {
                _lineStyleExpr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets the default line style.
        /// <para>Note: the set accessor is for serialization only, and should not be used directly.</para>
        /// </summary>
        [Category(c_catAppearance)]
        [Description("Default line style for this layer. Used if LineStyleExpr is not specified or evaluates to an invalid style.")]
        public InlineLineStyle LineStyle
        {
            get { return _lineStyle; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _lineStyle = value;
                _lineStyle.Owner = this.Owner;
            }
        }
        #endregion
    }
}
