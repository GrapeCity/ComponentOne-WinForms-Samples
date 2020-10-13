using System;

namespace StockPortfolio
{
    /// <summary>
    /// Real Time Stock Quotes Business Object
    /// </summary>
    public class StockQuotes
    {
        public string StockName { get; set; }

        public string StockSymbol { get; set; }

        public string StockExchange { get; set; }

        public double LastTrade { get; set; }

        public string Change { get; set; }

        public string PercentChange { get; set; }

        public double Daylow { get; set; }

        public double Dayhigh { get; set; }

        public double Week52high { get; set; }

        public double Week52low { get; set; }

        public string MarketCap { get; set; }

        public double Open { get; set; }

        public double PreviousClose { get; set; }

        public DateTime LastTradeDate { get; set; }
    }
}