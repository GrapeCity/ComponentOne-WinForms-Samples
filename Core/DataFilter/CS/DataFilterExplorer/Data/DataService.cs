using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DataFilterExplorer.Data
{
    /// <summary>
    /// Uses from ChartAsDataFilter sample
    /// </summary>
    public partial class DataService
    {
        private static readonly List<Quote> _dt;

        static DataService()
        {
            var buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var quotesPath = Path.Combine(buildDir, "Resources", "HistoricalQuotes.json");
            var text = File.ReadAllText(quotesPath);
            _dt = JsonSerializer.Deserialize<List<Quote>>(text);
        }        

        public static List<Quote> GetFinancialData(int count = 365)
        {
            count = Math.Min(count, _dt.Count);
            return _dt.Take(count).OrderBy(x => x.Date).ToList();
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
