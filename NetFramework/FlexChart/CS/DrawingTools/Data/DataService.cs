using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTools.Data
{
    public class Quote
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }

    class DataService
    {
        static Random rnd = new Random();

        public static List<Quote> GetFinancialData(int npts = 365)
        {
            var data = new List<Quote>();
            var startDate = new DateTime(2017, 1, 1);
            var temp = 50;
            for (int i = 0; i < npts; i++)
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
    }
}
