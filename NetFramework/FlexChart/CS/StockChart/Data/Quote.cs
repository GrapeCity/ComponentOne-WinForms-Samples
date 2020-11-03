using System;
using System.Collections.Generic;
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
                if (len >= 1)
                    Date = DateTime.Parse(items[0]);
                if (len >= 2)
                    Open = Convert.ToDouble(items[1]);
                if (len >= 3)
                    High = Convert.ToDouble(items[2]);
                if (len >= 4)
                    Low = Convert.ToDouble(items[3]);
                if (len >= 5)
                    Close = Convert.ToDouble(items[4]);
                if (len >= 6)
                    Volume = Convert.ToDouble(items[5]);
            }
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
