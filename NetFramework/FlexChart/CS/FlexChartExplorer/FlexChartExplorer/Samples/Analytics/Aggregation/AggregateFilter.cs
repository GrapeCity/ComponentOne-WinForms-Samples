using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChartExplorer.Samples
{
    public class AggregateFilter : FilterBase
    {
        public override void Analyse()
        {
            var src = this.Source as IEnumerable<object>;
            if (src == null || !src.Any())
                return;
            IEnumerable<KeyValuePair<string, double>> data;
            if(this.Bindings==null || this.Bindings.Length == 0)
            {
                data = from srcItem in src select new KeyValuePair<string, double>(GetValueKey(srcItem, new string[] { "Year", "Month"}), GetValue(srcItem, "Value"));
            }
            else
            {
                var groupedData = src.GroupBy(k => GetValueKey(k, this.Bindings));
                data = from groupedItem in groupedData select new KeyValuePair<string, double>(GetValueKey(groupedItem.First(), this.Bindings), (from dataItem in groupedItem select GetValue(dataItem, "Value")).Aggregate(this.AggregateType));
            }
            this.DataSource = data.ToArray();
            this.OnPropertyChanged("DataSource");
        }
        static string GetValueKey(object obj, string[] keys)
        {
            var result = string.Empty;
            foreach(var key in keys)
            {
                switch (key)
                {
                    case "Quarter":
                        result += " Q" + GetValue(obj, key);
                        break;
                    case "Month":
                        DateTime dt = new DateTime(1900, Convert.ToInt32(GetValue(obj, key)), 1);
                        result += " " + dt.ToString("MMM");
                        break;
                    default:
                        result += GetValue(obj, key);
                        break;
                }
            }
            return result;
        }
    }
}
