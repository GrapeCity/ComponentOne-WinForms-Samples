using System.IO;
using System.Net;
using System.Xml;
using System.Text;
using System.Globalization;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Geocoder that uses Google geocoding services.
    /// </summary>
    public class GeocoderGoogle : GeocoderBase
    {
        /// <summary>
        /// Initializes a new instance of a <see cref="GeocoderGoogle"/>.
        /// </summary>
        /// <param name="cacheFile">Name of cache file where locations are persisted.</param>
        public GeocoderGoogle(string cacheFile, bool autoSave)
            : base(cacheFile, autoSave)
        {
        }

        /// <summary>
        /// Call Google to geocode an address.
        /// </summary>
        /// <param name="address">Address to geocode.</param>
        /// <returns>
        /// <para>A <see cref="Point"/> where the X and Y values represent the Longitude and 
        /// Latitude of the given <paramref name="address"/>.</para>
        /// <para>If the address cannot be located, the point returned has X and Y values
        /// set to double.NaN.</para>
        /// </returns>
        protected override LonLat<double> GeoLocateAddress(string address)
        {
            address = UrlEncode(address);
            bool needToWait;
            for (int i = 0; i < 10; ++i)
            {
                var result = GeoLocateEncodedAddress(address, out needToWait);
                if (!needToWait)
                    return result;
                // Free Google API allows 5 requests per second.
                System.Diagnostics.Debug.WriteLine("Map custom field: waiting for Google...");
                System.Threading.Thread.Sleep(1000);
            }
            System.Diagnostics.Debug.WriteLine("Map custom field: failed to get location from Google: " + address);
            return new LonLat<double>(double.NaN, double.NaN);
        }

        /// <summary>
        /// Use Gooogle to locate an address.
        /// </summary>
        /// <param name="urlEncodedAddress">The address encoded for use in URLs.</param>
        /// <param name="needToWait">OUT: if true, the return value is NaN/NaN, but might succeed if try again later (we are asking too much/too fast).</param>
        /// <returns>The geo location.</returns>
        static LonLat<double> GeoLocateEncodedAddress(string urlEncodedAddress, out bool needToWait)
        {
            needToWait = false;

            // URL to Google Geocoder
            const string GEO_URL = "https://maps.googleapis.com/maps/api/geocode/xml?address="; // todo: add Google maps API KEY property

            // build web request
            var request = WebRequest.Create(GEO_URL + urlEncodedAddress);

            // submit request and get response
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(stream);

                XmlNode xstatus = xdoc.SelectSingleNode("/GeocodeResponse/status");
                if (xstatus != null)
                {
                    switch (xstatus.InnerText.ToUpperInvariant())
                    {
                        case "OK":
                            XmlNode xnode = xdoc.SelectSingleNode("/GeocodeResponse/result/geometry/location");
                            if (xnode != null)
                            {
                                XmlElement xlat = xnode["lat"];
                                XmlElement xlon = xnode["lng"];
                                if (xlat != null && xlon != null)
                                {
                                    double lat = double.Parse(xlat.InnerText, CultureInfo.InvariantCulture);
                                    double lon = double.Parse(xlon.InnerText, CultureInfo.InvariantCulture);
                                    return new LonLat<double>(lon, lat);
                                }
                            }
                            break;
                        case "OVER_QUERY_LIMIT":
                            needToWait = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            // no dice...
            return new LonLat<double>(double.NaN, double.NaN);
        }
    }

    /// <summary>
    /// As of Jan 2015, this does not work anymore.
    /// </summary>
    public class GeocoderGoogleOld : GeocoderBase
    {
        /// <summary>
        /// Initializes a new instance of a <see cref="GeocoderGoogle"/>.
        /// </summary>
        /// <param name="cacheFile">Name of cache file where locations are persisted.</param>
        public GeocoderGoogleOld(string cacheFile, bool autoSave)
            : base(cacheFile, autoSave)
        {
        }

        /// <summary>
        /// Call Google to geocode an address.
        /// </summary>
        /// <param name="address">Address to geocode.</param>
        /// <returns>
        /// <para>A <see cref="Point"/> where the X and Y values represent the Longitude and 
        /// Latitude of the given <paramref name="address"/>.</para>
        /// <para>If the address cannot be located, the point returned has X and Y values
        /// set to double.NaN.</para>
        /// </returns>
        protected override LonLat<double> GeoLocateAddress(string address)
        {
            address = UrlEncode(address);
            return GeoLocateEncodedAddress(address, true);
        }

        // call Google to locate an address, optionally accepting alternate suggestions
        static LonLat<double> GeoLocateEncodedAddress(string urlEncodedAddress, bool tryAlternatives)
        {
            // URL to Google Geocoder
            const string GEO_URL = "http://maps.google.com/maps?output=kml&q=";

            // build web request
            var request = WebRequest.Create(GEO_URL + urlEncodedAddress);

            // submit request and get response
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var sr = new StreamReader(stream))
            {
                // parse response
                var doc = sr.ReadToEnd();
                var coords = "<Point><coordinates>";
                var pos = doc.IndexOf(coords);
                if (pos > -1)
                {
                    var ci = CultureInfo.InvariantCulture;
                    var end = doc.IndexOf("<", pos + coords.Length);
                    var arr = doc.Substring(pos + coords.Length, end - pos - coords.Length).Split(',');
                    var lon = double.Parse(arr[0], ci);
                    var lat = double.Parse(arr[1], ci);
                    return new LonLat<double>(lon, lat);
                }

                // accept suggestions
                pos = doc.IndexOf("Did you mean:");
                if (pos > -1 && tryAlternatives)
                {
                    var url = "maps.google.com/maps?q=";
                    pos = doc.IndexOf(url, pos);
                    if (pos > -1)
                    {
                        var end = doc.IndexOf("&amp;", pos);
                        if (end > -1)
                        {
                            var parm = doc.Substring(pos + url.Length, end - pos - url.Length);
                            return GeoLocateEncodedAddress(parm, false);
                        }
                    }
                }
            }

            // no dice...
            return new LonLat<double>(double.NaN, double.NaN);
        }
    }

    /// <summary>
    /// Geocoder that uses Bing geocoding services.
    /// </summary>
    public class GeocoderBing : GeocoderBase
    {
        string _bingKey = "Amt9oyxRmMhjEU0-WcIy4gqiDRLZvxO_tbYRIPRNknDZ_4AuO5yNKl-FndzIC7IM";

        /// <summary>
        /// Initializes a new instance of a <see cref="GeocoderGoogle"/>.
        /// </summary>
        /// <param name="cacheFile">Name of cache file where locations are persisted.</param>
        /// <param name="bingKey">Bing license key used to access Bing services.</param>
        /// <remarks>
        /// You can create Bing license keys here: http://www.bingmapsportal.com/.
        /// </remarks>
        public GeocoderBing(string cacheFile, bool autoSave, string bingKey)
            : base(cacheFile, autoSave)
        {
            if (bingKey != null)
            {
                _bingKey = bingKey;
            }
        }

        /// <summary>
        /// Call Bing to geocode an address.
        /// </summary>
        /// <param name="address">Address to geocode.</param>
        /// <returns>
        /// <para>A <see cref="Point"/> where the X and Y values represent the Longitude and 
        /// Latitude of the given <paramref name="address"/>.</para>
        /// <para>If the address cannot be located, the point returned has X and Y values
        /// set to double.NaN.</para>
        /// </returns>
        protected override LonLat<double> GeoLocateAddress(string address)
        {
            address = UrlEncode(address);
            return GeoLocateEncodedAddress(address);
        }

        // call Bing to locate an address
        LonLat<double> GeoLocateEncodedAddress(string urlEncodedAddress)
        {
            // URL to Bing Geocoder
            const string GEO_URL = "http://dev.virtualearth.net/REST/v1/Locations?addressLine={0}&output=xml&key={1}";

            // build web request
            var request = WebRequest.Create(string.Format(System.Globalization.CultureInfo.InvariantCulture, GEO_URL, urlEncodedAddress, _bingKey));

            // submit request and get response
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var sr = new StreamReader(stream))
            {
                // parse response
                var doc = sr.ReadToEnd();
                var posLon = doc.IndexOf("<Longitude>");
                var posLat = doc.IndexOf("<Latitude>");
                if (posLat > -1 && posLon > -1)
                {
                    var lon = ParseDouble(doc, posLon);
                    var lat = ParseDouble(doc, posLat);
                    return new LonLat<double>(lon, lat);
                }
            }

            // no dice...
            return new LonLat<double>(double.NaN, double.NaN);
        }

        static double ParseDouble(string doc, int start)
        {
            start = doc.IndexOf(">", start);
            if (start > -1)
            {
                int end = doc.IndexOf("<", start);
                if (end > -1)
                {
                    double d;
                    var val = doc.Substring(start + 1, end - start - 2);
                    if (double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
                    {
                        return d;
                    }
                }
            }
            return double.NaN;
        }
    }

    /// <summary>
    /// Abstract base class used for the GeocoderGoogle and GeocoderBing classes.
    /// </summary>
    /// <remarks>
    /// This class manages a file-based location cache. The actual geocoding must be performed
    /// on derived classes that implement the GetLocation method.
    /// </remarks>
    public abstract class GeocoderBase
    {
        //--------------------------------------------------------------------------------
        #region ** fields
        Dictionary<string, LonLat<double>> _cache;
        string _fileName;
        bool _readOnly;
        bool _autoSave;
        #endregion

        //--------------------------------------------------------------------------------
        #region ** ctor
        /// <summary>
        /// Initializes a new instance of a <see cref="CachedGeoCoder"/>.
        /// </summary>
        /// <param name="cacheFile">Name of cache file where locations are persisted.</param>
        public GeocoderBase(string cacheFile, bool autoSave)
        {
            _cache = new Dictionary<string, LonLat<double>>();
            _autoSave = autoSave;
            _fileName = cacheFile;
            LoadCache();
        }
        #endregion

        //--------------------------------------------------------------------------------
        #region ** object model
        /// <summary>
        /// Gets the location of a given object.
        /// </summary>
        /// <param name="address">Address to be located.</param>
        /// <returns>A <see cref="Point"/> that represents the location of the given address.</returns>
        /// <remarks>
        /// The X and Y values of the point returned represent the longitude and latitude of the address.
        /// </remarks>
        public LonLat<double> GetLocation(string address)
        {
            // seems like a good idea:
            if (string.IsNullOrWhiteSpace(address))
                return new LonLat<double>(double.NaN, double.NaN);
            address = address.Trim();

            // look in cache
            LonLat<double> loc;
            if (_cache.TryGetValue(address, out loc))
            {
                Debug.WriteLine("found in cache: " + address);
                return loc;
            }

            // not found, geolocate now
            Debug.Write("locating " + address + "...");
            loc = GeoLocateAddress(address);
            Debug.WriteLine(" got it: " + loc.Longitude.ToString());

            // store result in cache
            _cache[address] = loc;
            if (_autoSave)
            {
                Debug.Write("saving cache...");
                SaveCache();
                Debug.WriteLine(" saved");
            }

            // done
            return loc;
        }

        /// <summary>
        /// Call geocoding service to retrieve the location of an address.
        /// </summary>
        /// <param name="address">Address to geocode.</param>
        /// <returns>
        /// <para>A <see cref="Point"/> where the X and Y values represent the Longitude and 
        /// Latitude of the given <paramref name="address"/>.</para>
        /// <para>If the address cannot be located, the point returned has X and Y values
        /// set to double.NaN.</para>
        /// </returns>
        protected abstract LonLat<double> GeoLocateAddress(string address);

        /// <summary>
        /// Loads the location cache from the default cache file..
        /// </summary>
        public void LoadCache()
        {
            if (!string.IsNullOrEmpty(_fileName) && File.Exists(_fileName))
            {
                LoadCache(_fileName);
            }
        }

        /// <summary>
        /// Saves the current location cache to the default cache file.
        /// </summary>
        public void SaveCache()
        {
            if (!string.IsNullOrEmpty(_fileName))
            {
                SaveCache(_fileName);
            }
        }

        /// <summary>
        /// Same as HttpUtility.UrlEncode, but without taking a dependency on System.Web.
        /// </summary>
        protected static string UrlEncode(string str)
        {
            // sanitize whitespaces
            str = str.Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ').Replace("  ", " ");

            // regular url encoding
            var sb = new StringBuilder();
            foreach (var c in str)
            {
                if (IsUrlSafeChar(c))
                {
                    sb.Append(c);
                }
                else if (c == ' ')
                {
                    sb.Append((char)0x2b);
                }
                else
                {
                    sb.Append((char)0x25);
                    sb.Append(IntToHex(((int)c) >> 4) & 15);
                    sb.Append(IntToHex((int)c & 15));
                }
            }
            return sb.ToString();
        }

        static bool IsUrlSafeChar(char ch)
        {
            if ((((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z'))) || ((ch >= '0') && (ch <= '9')))
            {
                return true;
            }
            switch (ch)
            {
                case '(':
                case ')':
                case '*':
                case '-':
                case '.':
                case '_':
                case '!':
                    return true;
            }
            return false;
        }

        static char IntToHex(int n)
        {
            return n <= 9
                ? (char)(n + 0x30)
                : (char)((n - 10) + 0x61);
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** implementation
        /// <summary>
        /// Saves the current location cache to a file.
        /// </summary>
        /// <param name="fileName">Name of the file to use for saving the location cache.</param>
        void SaveCache(string fileName)
        {
            if (!_readOnly)
            {
                lock (typeof(GeocoderBase)) // todo: think of a better approach!
                {
                    try
                    {
                        // we don't have permissions to write...
                        using (var xw = new XmlTextWriter(fileName, Encoding.UTF8))
                        {
                            var ci = CultureInfo.InvariantCulture;
                            xw.Formatting = Formatting.Indented;
                            xw.WriteStartElement("Locations");
                            foreach (var address in _cache.Keys)
                            {
                                var loc = _cache[address];
                                xw.WriteStartElement("Location");
                                xw.WriteAttributeString("add", address);
                                xw.WriteAttributeString("lat", loc.Latitude.ToString(ci));
                                xw.WriteAttributeString("lon", loc.Longitude.ToString(ci));
                                xw.WriteEndElement();
                            }
                            xw.WriteEndElement();
                        }
                    }
                    catch
                    {
                        _readOnly = true;
                    }
                }
            }
        }

        /// <summary>
        /// Loads the location cache from a file.
        /// </summary>
        /// <param name="fileName">Name of the file to use for loading the location cache.</param>
        void LoadCache(string fileName)
        {
            lock (typeof(GeocoderBase)) // todo: think of a better approach!
            {
                lock (_cache)
                {
                    using (var xr = new XmlTextReader(fileName))
                    {
                        var ci = CultureInfo.InvariantCulture;
                        while (xr.Read())
                        {
                            xr.MoveToElement();
                            if (xr.MoveToAttribute("add"))
                            {
                                var address = xr.Value;
                                if (xr.MoveToAttribute("lat"))
                                {
                                    var lat = double.Parse(xr.Value, ci);
                                    if (xr.MoveToAttribute("lon"))
                                    {
                                        var lon = double.Parse(xr.Value, ci);
                                        _cache[address] = new LonLat<double>(lon, lat);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
