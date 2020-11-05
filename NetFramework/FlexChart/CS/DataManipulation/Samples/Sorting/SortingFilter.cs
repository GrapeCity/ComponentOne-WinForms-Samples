using C1.Win.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class SortingFilter : FilterBase
    {

        private Func<IEnumerable<double>, double> _customSortFun;
        public Func<IEnumerable<double>, double> CustomSortFun
        {
            get { return this._customSortFun; }
            set { this._customSortFun = value; Analyse(); }
        }


        public override void Analyse()
        {
            IEnumerable<object> src = this.Source as IEnumerable<object>;

            if (src == null || Bindings == null || Bindings.Length == 0)
            {
                return;
            }
            if (!src.Any())
            {
                return;
            }
            IEnumerable<KeyValuePair<double, object>> data;
            if (CustomSortFun != null)
            {
                data = from p in src select new KeyValuePair<double, object>(GetValues(p, Bindings).Aggregate(AggregateType, CustomSortFun), p);
            }
            else
            {
                data = from p in src select new KeyValuePair<double, object>(GetValues(p, Bindings).Aggregate(AggregateType), p);
            }

            var sortedTopNData = data.Sort(this.SortType).GetValue();

            Queue<object> source = new Queue<object>(sortedTopNData);

            this.DataSource = source.ToArray();

            this.OnPropertyChanged("DataSource");

        }
        
    }

}
