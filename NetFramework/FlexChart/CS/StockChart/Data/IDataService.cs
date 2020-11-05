using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockChart.Data
{
    interface IDataService
    {
        Dictionary<string, string> SymbolNames { get; }
        // SymbolData GetSymbolData(string symbol, Action<string> onWebError = null);

        string GetSymbolName(string symbol);

        void GetSymbolDataAsync(string symbol, Action<string, SymbolData> action, bool loadEvents = true);

        event EventHandler NewsLoaded;
        event EventHandler SymbolsLoaded;
    }
}
