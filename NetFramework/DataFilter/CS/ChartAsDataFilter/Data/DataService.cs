using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ChartAsDataFilter.Data
{
    public class DataService
    {
        private static List<Quote> dt;
        static DataService()
        {
            var buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var quotesPath = Path.Combine(buildDir, "Resources", "HistoricalQuotes.json");
            var text = File.ReadAllText(quotesPath);
            var jsonSerializer = new JavaScriptSerializer();
            dt = jsonSerializer.Deserialize<List<Quote>>(text);
        }        
        public static List<Quote> GetFinancialData(int count = 365)
        {
            count = Math.Min(count, dt.Count);
            return dt.Take(count).OrderBy(x => x.Date).ToList();
        }

        public static List<Quote> GetFinancialData(DateTime startDate, int count = 365)
        {
            var quotes = GetFinancialData(count);
            foreach (var quote in quotes)
            {
                quote.Date = startDate.AddDays(quotes.IndexOf(quote));
            }
            return quotes;
        }
    }
}
