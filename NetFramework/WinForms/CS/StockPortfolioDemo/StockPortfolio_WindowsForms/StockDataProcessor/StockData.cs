using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace StockPortfolio
{
    public class StockData : IDisposable
    {
        private DataSet _stockDataset = new DataSet();

        #region SymbolData Code

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _stockDataset.Dispose();
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns a datatable which contains information of Stocks listed on Yahoo Finance
        /// </summary>
        /// <returns></returns>
        private DataTable LoadSymbolData()
        {
            string path = System.Windows.Forms.Application.StartupPath;
            DataTable stockTable = new System.Data.DataTable("StockTable");

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from StockTable", new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StockSymbol.mdb"));

            da.Fill(stockTable);
            stockTable.WriteXmlSchema(path + @"\file.schema");

            return stockTable;
        }

        /// <summary>
        /// Returns Symbol and Company information of all stocks in Yahoo Finance as List of StockSymbolData businees objects
        /// </summary>
        /// <returns></returns>
        public List<StockSymbolData> GetStockSymbolData()
        {
            List<StockSymbolData> symbolDataList = new List<StockSymbolData>();

            DataTable symboltable = LoadSymbolData();

            for (int i = 0; i < symboltable.Rows.Count; i++)
            {
                StockSymbolData stkSymbolData = new StockSymbolData();
                stkSymbolData.Id = Convert.ToInt32(symboltable.Rows[i][0].ToString());
                stkSymbolData.Symbol = symboltable.Rows[i][1].ToString();
                stkSymbolData.CompanyName = symboltable.Rows[i][2].ToString();
                symbolDataList.Add(stkSymbolData);
            }

            return symbolDataList;
        }

        public List<StockSymbolData> GetStockSymbolData(string filter)
        {
            List<StockSymbolData> symbolDataList = new List<StockSymbolData>();

            DataTable symboltable = LoadSymbolData();

            for (int i = 0; i < symboltable.Rows.Count; i++)
            {
                StockSymbolData stkSymbolData = new StockSymbolData();
                stkSymbolData.Id = Convert.ToInt32(symboltable.Rows[i][0].ToString());
                stkSymbolData.Symbol = symboltable.Rows[i][1].ToString();
                stkSymbolData.CompanyName = symboltable.Rows[i][2].ToString();
                if (stkSymbolData.Symbol.Contains(filter) || stkSymbolData.CompanyName.Contains(filter))
                {
                    symbolDataList.Add(stkSymbolData);
                }
            }

            return symbolDataList;
        }

        /// <summary>
        /// Get Stock Symbol Info of first 10 Records
        /// </summary>
        /// <param name="StockSymbol"></param>
        public void GetStockSymbolInfo(String StockSymbol)
        {
            List<StockSymbolData> stk = GetStockSymbolData();
            var s = (from xs in stk
                     where (xs.Symbol.StartsWith(StockSymbol))

                     select xs).OrderBy(x => x.Symbol).Take(10);
        }

        #endregion SymbolData Code

        #region HistoricalStockData

        /// <summary>
        ///  This functions returns the Historical information of a stock  as HistoricalStock object
        /// </summary>
        /// <param name="symbol">Stock Symbol</param>
        /// <param name="FromDate">From Date</param>
        /// <param name="ToDate">To Date</param>
        /// <returns></returns>
        public List<HistoricalStock> GetStockHistoricalData(string symbol, DateTime FromDate, DateTime ToDate)
        {
            List<HistoricalStock> retval = new List<HistoricalStock>();

            try
            {
                //a=frommonth-1 b=fromday   c=fromyear  d=tomonth-1   e=to-day f=toyear g-trading period
                String historicalStockUrl = string.Format(" http://ichart.finance.yahoo.com/table.csv?s={0}&d={1}&e={2}&f={3}&g={4}&a={5}&b={6}&c={7}&ignore.csv", symbol, ToDate.Month - 1, ToDate.Day, ToDate.Year, "d", FromDate.Month - 1, FromDate.Day, FromDate.Year);

                using (WebClient web = new WebClient())
                {
                    string data = web.DownloadString(historicalStockUrl);

                    data = data.Replace("r", "");

                    string[] rows = Regex.Split(data, @"\n");

                    //First row is headers so Ignore it
                    for (int i = 1; i < rows.Length; i++)
                    {
                        if (rows[i].Replace("n", "").Trim() == "") continue;

                        string[] cols = rows[i].Split(',');

                        HistoricalStock hs = new HistoricalStock();
                        hs.Id = Guid.NewGuid();
                        hs.Date = Convert.ToDateTime(cols[0], System.Globalization.CultureInfo.InvariantCulture);
                        hs.Open = Convert.ToDouble(cols[1], System.Globalization.CultureInfo.InvariantCulture);
                        hs.High = Convert.ToDouble(cols[2], System.Globalization.CultureInfo.InvariantCulture);
                        hs.Low = Convert.ToDouble(cols[3], System.Globalization.CultureInfo.InvariantCulture);
                        hs.Close = Convert.ToDouble(cols[4], System.Globalization.CultureInfo.InvariantCulture);
                        hs.Volume = Convert.ToDouble(cols[5], System.Globalization.CultureInfo.InvariantCulture);
                        hs.AdjClose = Convert.ToDouble(cols[6], System.Globalization.CultureInfo.InvariantCulture);

                        retval.Add(hs);
                    }

                    return retval;
                }
            }
            catch
            {
                return null;
            }
        }

        #endregion HistoricalStockData

        #region CurentStockData

        /// <summary>
        /// Returns Stock Quote of a given Symbol
        /// </summary>
        /// <param name="Symbol">Stock Symbol of the Stock</param>
        /// <returns></returns>
        public StockQuotes GetStockQuoteData(String Symbol)
        {
            try
            {
                StockQuotes _stockquote = new StockQuotes();

                using (WebClient web = new WebClient())
                {
                    //S=Symbol ;n=SymbolName;s=Symbol;x=StockExchange;a=Ask;b=Bid;c1=Change;d=DividendShare;e7=EpsEst Current Year;g=Day's Low;h=Day's High;j1=Market Cap;o=Open;p=Previous Close;d1=Last Trade Date

                    // string data = web.DownloadString(string.Format(" http://finance.yahoo.com/d/quotes.csv?s={0}&f=nsxabc1de7ghjkj1opd1", Symbol));
                    string data = web.DownloadString(string.Format("  http://finance.yahoo.com/d/quotes.csv?s={0}&f=nsxl1c1p2ghjkj1opd1", Symbol));

                    Regex regex = new Regex("[\"].+?[\"]|[^,^\\s]+");
                    MatchCollection cols = regex.Matches(data);

                    _stockquote.StockName = cols[0].Value.Replace('"', ' ').Trim(); ;
                    _stockquote.StockSymbol = cols[1].Value.Replace('"', ' ').Trim(); ;
                    _stockquote.StockExchange = cols[2].Value.Replace('"', ' ').Trim(); ;
                    _stockquote.LastTrade = (cols[3].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[3].Value, System.Globalization.CultureInfo.InvariantCulture);
                    _stockquote.Change = Math.Round((cols[4].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[4].Value, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                    _stockquote.PercentChange = cols[5].Value;
                    _stockquote.Daylow = (cols[6].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[6].Value, System.Globalization.CultureInfo.InvariantCulture);
                    _stockquote.Dayhigh = (cols[7].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[7].Value, System.Globalization.CultureInfo.InvariantCulture);
                    _stockquote.Week52low = (cols[8].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[8].Value, System.Globalization.CultureInfo.InvariantCulture);
                    _stockquote.Week52high = (cols[9].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[9].Value, System.Globalization.CultureInfo.InvariantCulture); ;
                    _stockquote.MarketCap = cols[10].Value;
                    _stockquote.Open = (cols[11].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[11].Value, System.Globalization.CultureInfo.InvariantCulture);
                    _stockquote.PreviousClose = (cols[12].Value == "N/A") ? 0.00 : Convert.ToDouble(cols[12].Value, System.Globalization.CultureInfo.InvariantCulture);
                    //  _stockquote.LastTradeDate = Convert.ToDateTime(cols[13].Replace("\"", ""));

                    return _stockquote;
                }
            }
            catch
            {
                return null;
            }
        }

        #endregion CurentStockData
    }
}