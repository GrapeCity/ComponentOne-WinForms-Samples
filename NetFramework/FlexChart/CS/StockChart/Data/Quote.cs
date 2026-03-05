using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StockChart.Data
{
    public class Quote
    {
        SymbolData _parent;

        public Quote(SymbolData parent)
        {
            _parent = parent;
        }

        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public string Events { get; set; }

        //internal Reference referenceValue { get; set; }

        public double Percentage
        {
            get
            {
                double reValue = _parent.ReferenceValue;
                return reValue == 0 ? 1 : (Close - reValue) / reValue;
            }
        }

        internal void Read(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                var items = s.Split(',');
                var len = items != null ? items.Length : 0;
                var culture = CultureInfo.InvariantCulture;

                // Parses a single record (e.g., CSV row) into market data fields.
                // Each field is optional and parsed only if present and valid.
                if (TryGet(items, 0, out DateTime parsedDate))
                {
                    Date = parsedDate;
                }

                if (TryGet(items, 1, out double open))
                {
                    Open = open;
                }

                if (TryGet(items, 2, out double high))
                {
                    High = high;
                }

                if (TryGet(items, 3, out double low))
                {
                    Low = low;
                }

                if (TryGet(items, 4, out double close))
                {
                    Close = close;
                }

                if (TryGet(items, 5, out double volume))
                {
                    Volume = volume;
                }

            }
        }
        /// Attempts to parse a DateTime value from the specified index if present.
        /// Returns false if the index is out of range or parsing fails.
        private static bool TryGet(string[] items, int index, out DateTime value)
        {
            value = default;
            return items.Length > index &&
                   DateTime.TryParse(
                       items[index],
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out value);
        }

        /// Attempts to parse a double value from the specified index if present.
        /// Returns false if the index is out of range or parsing fails.
        private static bool TryGet(string[] items, int index, out double value)
        {
            value = default;
            return items.Length > index &&
                   double.TryParse(
                       items[index],
                       NumberStyles.Any,
                       CultureInfo.InvariantCulture,
                       out value);
        }
    }

    public class QuoteRange
    {
        public double PriceMin { get; set; }
        public double PriceMax { get; set; }
        public double VolumeMin { get; set; }
        public double VolumeMax { get; set; }
    }
}
