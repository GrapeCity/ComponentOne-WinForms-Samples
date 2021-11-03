using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public static class FinancialDataSource
    {
        private static List<Quote> dt;
        private static DataHelper _dataHelper = DataHelper.Instance;

        static FinancialDataSource()
        {
            var buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var quotesPath = Path.Combine(buildDir, "Resources", "HistoricalQuotes.json");
            var text = File.ReadAllText(quotesPath);
            dt = JsonConvert.DeserializeObject<List<Quote>>(text);
        }

        private static Random rnd = new Random();

        /// <summary>
        /// Gets specified number of Historical Quotes 
        /// </summary>
        /// <param name="count">Number of quotes to return. Default being 365</param>
        /// <returns></returns>
        public static List<Quote> GetQuotes(int count = 365)
        {
            count = Math.Min(count, dt.Count);
            return dt.Take(count).ToList();
        }

        public static List<Quote> GetQuotes(DateTime startDate, int count = 365)
        {
            var quotes = GetQuotes(count);
            quotes.Reverse();
            foreach (var quote in quotes)
            {
                quote.Date = startDate.AddDays(quotes.IndexOf(quote));
            }
            return quotes;
        }

        public static List<Quote> GetFinancialData()
        {
            var data = new List<Quote>();
            var startDate = new DateTime(2017, 1, 1);
            var temp = 50;
            for (int i = 0; i < 100; i++)
            {
                if (i % 7 == 0)
                    temp += i < 70 ? rnd.Next(5, 15) : -rnd.Next(1, 15);
                var open = rnd.Next(temp - 15, temp + 15);
                var close = rnd.Next(temp - 15, temp + 15);
                var high = open > close ? rnd.Next(open + 1, open + 10) : rnd.Next(close + 1, close + 10);
                var low = open > close ? rnd.Next(close - 10, close - 1) : rnd.Next(open - 10, open - 1);
                data.Add(new Quote
                {
                    Date = startDate.AddDays(i),
                    High = high,
                    Low = low,
                    Open = open,
                    Close = close,
                    Volume = rnd.Next(50, 200),
                });
            }
            return data;
        }

        public static List<Object> GetProfitStatement()
        {
            var data = new List<Object>();
            var change = 0.10f;
            for (int i = 0; i < 12; i++)
            {
                change += change >= 0.20f ? -rnd.Next(1, 10) / 100f : rnd.Next(1, 4) / 100f;
                data.Add(new
                {
                    Month = _dataHelper.Months[i],
                    Change = rnd.Next(1000, 10000) > 5000 ? rnd.Next(1000, 10000) : -rnd.Next(1000, 5000),
                    PChange = change,
                });
            }
            return data;
        }


        public static List<InvestmentEquity> GetInvestmentData()
        {
            var data = new List<InvestmentEquity>();
            int count = 30;
            double rate = 1;
            for (int i = 0; i < count; i++)
            {
                data.Add(new InvestmentEquity
                {
                    Age = i + 1,
                    Amount = rnd.Next(100000, 1000000),
                    Rate = (i / 5) % 2 == 0 ? rate + rnd.NextDouble() / 10 : rate - rnd.NextDouble() / 10
                });
            }
            return data;
        }
    }
}
