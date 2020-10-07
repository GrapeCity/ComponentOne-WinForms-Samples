using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChartExplorer.Samples
{
    public class SortingFilter : FilterBase
    {
        private Func<IEnumerable<double>, double> _customSortFun;
        public Func<IEnumerable<double>, double> CustomSortFun
        {
            get { return _customSortFun; }
            set { _customSortFun = value; Analyse(); }
        }
        public override void Analyse()
        {
            var src = this.Source as IEnumerable<object>;
            if (src == null || Bindings == null || Bindings.Length == 0)
                return;            
            if (!src.Any())            
                return;
            var data = from srcItem in src select new KeyValuePair<double, object>(GetValues(srcItem, this.Bindings).Aggregate(this.AggregateType, CustomSortFun), srcItem);
            var sortedData = data.Sort(this.SortType).GetValue();
            this.DataSource = sortedData.ToArray();
            this.OnPropertyChanged("DataSource");
        }
    }
}
