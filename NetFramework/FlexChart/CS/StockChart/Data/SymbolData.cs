using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockChart.Data
{
    public class SymbolData : List<Quote>
    {
        private double _referenceValue;

        internal double ReferenceValue
        {
            get { return _referenceValue; }
            set { _referenceValue = value; }
        }

        public QuoteRange GetSymbolYRange(double s, double e, string property = null)
        {
            QuoteRange qr = null;
            DateTime ds = DateTime.FromOADate(s);
            DateTime de = DateTime.FromOADate(e);
            IEnumerable<Quote> quoteCache = from p in this where p.Date >= ds && p.Date <= de select p;

            if (quoteCache.Any())
            {
                qr = new QuoteRange();
                qr.PriceMin = quoteCache.Min((k) => GetValue(k, string.IsNullOrEmpty(property) ? "Low" : property));
                qr.PriceMax = quoteCache.Max((k) => GetValue(k, string.IsNullOrEmpty(property) ? "High" : property));
                qr.VolumeMin = quoteCache.Min(k => k.Volume);
                qr.VolumeMax = quoteCache.Max(k => k.Volume);
            }
            return qr;
        }

        static double GetValue(Quote q, string name)
        {
            switch (name)
            {
                case "Percentage":
                    return q.Percentage;
                case "Close":
                    return q.Close;
                case "High":
                    return q.High;
                case "Low":
                    return q.Low;
                default:
                    return 0;
            }
        }
    }
}
