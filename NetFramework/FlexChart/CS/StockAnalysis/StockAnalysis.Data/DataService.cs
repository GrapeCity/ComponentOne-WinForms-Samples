using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace StockAnalysis.Data
{
    public class QuoteEventArg : EventArgs
    {
        public QuoteEventArg(Object.Quote quote)
        {
            Quote = quote;
        }

        public Object.Quote Quote
        {
            get;
            set;
        }
    }
    public class QuotesEventArg: EventArgs
    {
        public QuotesEventArg(IEnumerable<Object.Quote> quotes)
        {
            Quotes = quotes;
        }

        public IEnumerable<Object.Quote> Quotes
        {
            get;
            set;
        }
    }

    public class DataService
    {
        public static IEnumerable<Object.Quote> GetQuotes(Dictionary<string, string> symbols)
        {
            Stack<Object.Quote> quotes = new Stack<Object.Quote>();
            foreach (var symbol in symbols)
            {
                quotes.Push(GetQuote(symbol));
            }
            return quotes;
        }

        public static void GetQuotesAsync(Dictionary<string, string> symbols, EventHandler<QuotesEventArg> callback)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) => {
                Stack<Object.Quote> quotes = new Stack<Object.Quote>();
                foreach (var symbol in symbols)
                {
                    GetQuoteAsync(symbol,
                        (sender, e) =>
                        {
                            quotes.Push(e.Quote);

                            if (quotes.Count == symbols.Count)
                            {
                                var ordered = quotes.OrderBy(p => p.Name);
                                callback(sender, new QuotesEventArg(ordered));
                            }
                        }
                        );
                }
            });
        }

        public static Object.Quote GetQuote(KeyValuePair<string, string> symbol)
        {
            string url = string.Format("http://www.nasdaq.com/symbol/{0}/historical", symbol.Key);
            string reqStr = "1y|true|" + symbol.Key.ToUpper();

            return new Object.Quote()
            {
                Symbol = symbol.Key,
                Name = symbol.Value,
                Data = Request(url, reqStr, Encoding.ASCII),
            };
        }


        public static void GetQuoteAsync(KeyValuePair<string, string> symbol, EventHandler<QuoteEventArg> callback)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) => {
                var quote = GetQuote(symbol);
                callback(o, new QuoteEventArg(quote));
            });
        }

        private static Stack<Object.QuoteData> getCachedData(string cacheFilename, bool alwaysUseCachedData=false)
        {
            Stack<Object.QuoteData> datas = null;
            FileInfo fi = new FileInfo(cacheFilename);

            if (fi.Exists && (fi.LastWriteTime.Date == DateTime.Today || alwaysUseCachedData))
            {
                datas = new Stack<Object.QuoteData>();

                using (StreamReader dataReader = fi.OpenText())
                {
                    try
                    {
                        // skip headers
                        dataReader.ReadLine();
                        dataReader.ReadLine();

                        for (var line = dataReader.ReadLine(); line != null; line = dataReader.ReadLine())
                        {
                            datas.Push(ParseLine(line));
                        }
                    }
                    catch
                    {
                        datas.Clear();
                        datas = null;
                    }
                }
            }
            return datas;
        }

        internal static IEnumerable<Object.QuoteData> Request(string url, string data, Encoding encoding)
        {
            string cachePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\CachedData\";
            string cacheFileName = cachePath + data.Substring(data.LastIndexOf('|') + 1) + ".dataCache";
            Stack<Object.QuoteData> datas = getCachedData(cacheFileName,true);  // true indicates always use current cache.

            if (datas != null)
                return datas;
            else
                datas = new Stack<Object.QuoteData>();

#if DEBUG
            int retryCounter = 10;
#else
            int retryCounter = 3;
#endif
            System.Net.HttpWebRequest request = null;
            System.Net.HttpWebResponse response = null;
            var bs = encoding.GetBytes(data);
            url = url.ToLower();

            RETRY:
            try
            {
                request = (System.Net.HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = bs.Length;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bs, 0, bs.Length);
                    stream.Flush();
                }

                response = (System.Net.HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

                if (retryCounter > 0)
                {
                    request.Abort();
                    retryCounter--;
                    goto RETRY;
                }
            }

            if ((response == null || response.StatusCode != HttpStatusCode.OK) && retryCounter > 0)
            {
                request.Abort();
                retryCounter--;
                goto RETRY;
            }

            StreamWriter dataWriter = null;

            try
            {
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    // if it's not possible to open the file for writing, then flag it or just retrieve without caching.
                    try { dataWriter = File.CreateText(cacheFileName); }
                    catch(Exception ex)
                    { 
                        dataWriter = null;

                        // If a data cache is not desired, comment the following "if" and "throw statements
                        if (ex is System.UnauthorizedAccessException)
                            throw new Exception("To cache data, Write Access required for path: " + cacheFileName, ex);
                    }

                    using (StreamReader sr = new StreamReader(stream, encoding))
                    {
                        // skip headers
                        string line = sr.ReadLine();

                        if (dataWriter != null)
                        {
                            dataWriter.WriteLine(line);
                            line = sr.ReadLine();
                            dataWriter.WriteLine(line);
                        }
                        else
                        {
                            sr.ReadLine();
                        }

                        for (line = sr.ReadLine(); line != null; line = sr.ReadLine())
                        {
                            if (dataWriter != null) dataWriter.WriteLine(line);
                            datas.Push(ParseLine(line));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (retryCounter <= 0 || response == null)
                {
                    datas = getCachedData(cacheFileName, true);
                    if (datas == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Financial data is not available at this time.");
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }

            finally
            {
                if (dataWriter != null)
                {
                    dataWriter.Close();
                    dataWriter.Dispose();
                    dataWriter = null;
                }
            }

            return datas;
        }

        private static Object.QuoteData ParseLine(string line)
        {
            line = line.Replace("\"", string.Empty);

            var items = line.Split(',');
            Object.QuoteData data = new Object.QuoteData()
            {
                //"\"date\",\"close\",\"volume\",\"open\",\"high\",\"low\""
                Date = items[0].ToString(),
                Open = Convert.ToDouble(items[3]),
                High = Convert.ToDouble(items[4]),
                Low = Convert.ToDouble(items[5]),
                Close = Convert.ToDouble(items[1]),
                Volume = Convert.ToDouble(items[2]),
                LocalDate = Convert.ToDateTime(items[0]).ToShortDateString(),
            };

            return data;
        }

    }
}
