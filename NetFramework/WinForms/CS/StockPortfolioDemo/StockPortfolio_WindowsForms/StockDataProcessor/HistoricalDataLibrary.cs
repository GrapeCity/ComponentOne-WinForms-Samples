using System;

namespace StockPortfolio
{
    /// <summary>
    /// Historical Stock Data Business Object
    /// </summary>
    public class HistoricalStock
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public double Volume { get; set; }

        public double AdjClose { get; set; }
    }
}