using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;

using C1.Zip;

namespace StockChart.Data
{
    class DataService : IDataService
    {
        static string SYMBOLS_OFFLINE = "symbols_offline.txt";
        static string SYMBOLS = "symbols.txt";

        static string CACHE_DIR = "Cache";
        static string SERVICE_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={0}&apikey=EQ8R2LTG732VP7HE&datatype=csv&outputsize=full";
        static string NEWS_URL = "http://articlefeeds.nasdaq.com/nasdaq/symbols?symbol={0}";

        static int YEAR0 = 2008;

        static Dictionary<string, string> _symbols;
        static Dictionary<string, SymbolData> _quotes = new Dictionary<string, SymbolData>();

        static bool _online = true;

        static DataService _instance;

        #region public api

        public DataService()
        {
            _symbols = LoadSymbols();
            OnSymbolsLoaded();
        }

        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataService();
                return _instance;
            }
        }

        public Dictionary<string, string> SymbolNames
        {
            get { return _symbols; }
        }

        public void GetSymbolDataAsync(string symbol, Action<string, SymbolData> action, bool loadEvents = true)
        {
            SymbolData data = null;

            // try app cache
            if (_quotes.TryGetValue(symbol, out data))
                action(symbol, data);
            else
            {
                // try file cache
                data = GetSymbolDataCache(symbol);

                if (data != null)
                    action(symbol, data);
                else
                {
                    if (Online)
                    {
                        GetSymbolDataOnlineAsync(symbol, (s, d) => 
                        {
                            action(s, d);
                            if(loadEvents)
                                LoadEvents(s, d);
                        });
                    }
                    else
                    {
                        data = GetSymbolDataOffline(symbol);
                        action(symbol, data);
                    }
                }
            }
            if(loadEvents)
                LoadEvents(symbol, data);
        }

        public string GetSymbolName(string symbol)
        {
            string value = null;
            if (_symbols.TryGetValue(symbol, out value))
                return value + "(" + symbol.ToUpper() + ")";

            return value;
        }

        public event EventHandler NewsLoaded;

        public event EventHandler SymbolsLoaded;

        public bool Online
        {
            get
            {
                return _online;
            }
            private set
            {
                if (value != _online)
                {
                    _online = value;
                    _symbols = LoadSymbols();
                    OnSymbolsLoaded();
                }
            }
        }

        #endregion

        Stream GetResourceStream(string name)
        {
            var sname = string.Format("StockChart.Resources.{0}", name);
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(sname);
        }

        string GetCacheFileName(string symbol)
        {
            return string.Format("{0}\\{1}.csv", CACHE_DIR, symbol);
        }

        Dictionary<string, string> LoadSymbols()
        {
            var name = Online ? SYMBOLS : SYMBOLS_OFFLINE;
            var dict = new Dictionary<string, string>();

            using (var stream = GetResourceStream(name))
            {
                using (var sr = new StreamReader(stream))
                {
                    for (var line = sr.ReadLine(); line != null; line = sr.ReadLine())
                    {
                        var parts = line.Split('\t');
                        if (parts.Length >= 2)
                        {
                            var key = parts[0].Trim();
                            var value = parts[1].Trim();
                            if (key.Length > 0 && value.Length > 0)
                                dict[key] = value;
                        }
                    }
                }
            }

            return dict;
        }

        SymbolData LoadQuote(string s, bool skipHeader = true)
        {
            var data = new SymbolData();

            var ss = s.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (var i = skipHeader ? 1 : 0; i < ss.Length; i++)
            {
                var q = new Quote(data);
                q.Read(ss[i]);

                if (q.Date.Year >= YEAR0)
                    data.Add(q);
            }

            if (data != null && data.Count > 1 && data[0].Date > data[data.Count - 1].Date)
                data.Reverse();

            return data;
        }

        void OnNewsLoaded()
        {
            if (NewsLoaded != null)
                NewsLoaded(this, EventArgs.Empty);
        }

        void OnSymbolsLoaded()
        {
            if (SymbolsLoaded != null)
                SymbolsLoaded(this, EventArgs.Empty);
        }

        void LoadEvents(string symbol, SymbolData data)
        {
            if (data == null || data.Count == 0)
                return;

            var url = string.Format(NEWS_URL, symbol);

            using (var wc = new WebClient())
            {
                wc.DownloadStringCompleted += (s, e) =>
                {
                    if(e.Error == null)
                    {
                        try
                        {
                            var doc = new XmlDocument();
                            doc.LoadXml(e.Result);

                            var items = doc.GetElementsByTagName("item");
                            // read each line
                            foreach (XmlNode item in items)
                            {
                                var dt = DateTime.Parse(item["pubDate"].InnerText);
                                var text = item["title"].InnerText;

                                var quote = data.FirstOrDefault(q => (q.Date - dt).Days == 0);

                                if (quote != null)
                                {
                                    if (quote.Events != null)
                                    {
                                        if (quote.Events.Length > 0)
                                            quote.Events += Environment.NewLine;
                                        quote.Events += text;
                                    }
                                    else
                                        quote.Events = text;
                                }
                            }

                            OnNewsLoaded();
                        }
                        catch
                        {
                        }
                    }
                };
                try
                {
                    wc.DownloadStringAsync(new Uri(url));
                }
                catch
                {
                }
            }
        }

        void GetSymbolDataOnlineAsync(string symbol, Action<string, SymbolData> action)
        {
            SymbolData data = null;

            using (var wc = new WebClient())
            {
                wc.DownloadStringCompleted += (s, e) =>
                {
                    if (e.Error == null)
                    {
                        try
                        {
                            data = LoadQuote(e.Result);
                        }
                        catch
                        {
                            data = null;
                        }
                    }
                    else
                        Online = false;

                    if (data == null)
                        data = GetSymbolDataOffline(symbol);
                    else
                        CacheQuote(symbol, data);

                    action(symbol, data);
                };

                try
                {
                    wc.DownloadStringAsync(new Uri(string.Format(SERVICE_URL, symbol)));
                }
                catch
                {
                    Online = false;
                    data = GetSymbolDataOffline(symbol);
                    action(symbol, data);
                }
            }
        }

        SymbolData GetSymbolDataOffline(string symbol)
        {
            SymbolData data = null;

            try
            {
                using (var zstream = GetResourceStream(symbol + ".csv.zip"))
                {
                    if (zstream != null)
                    {
                        using (var zip = new C1ZipFile(zstream))
                        {
                            using (var stream = zip.Entries[0].OpenReader())
                            {
                                using (var sr = new StreamReader(stream))
                                {
                                    data = LoadQuote(sr.ReadToEnd());
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return data;
        }

        SymbolData GetSymbolDataCache(string symbol)
        {
            SymbolData data = null;

            try
            {
                var fi = new FileInfo(GetCacheFileName(symbol));
                if (fi.Exists && (DateTime.Today - fi.LastWriteTime).Days <= 1)
                {
                    using (var sr = fi.OpenText())
                    {
                       data = LoadQuote(sr.ReadToEnd());
                    }
                }
            }
            catch
            {
            }

            return data;
        }

        void CacheQuote(string symbol, SymbolData quote)
        {
            try
            {
                if (!Directory.Exists(CACHE_DIR))
                    Directory.CreateDirectory(CACHE_DIR);

                var fi = new FileInfo(GetCacheFileName(symbol));
                using (var sw = fi.CreateText())
                {
                    for (var i = quote.Count - 1; i >= 0; i--)
                    {
                        var q = quote[i];
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}",
                            q.Date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                            q.Open, q.High, q.Low, q.Close, q.Volume));
                    }
                }
            }
            catch
            {

            }
        }
    }
}
