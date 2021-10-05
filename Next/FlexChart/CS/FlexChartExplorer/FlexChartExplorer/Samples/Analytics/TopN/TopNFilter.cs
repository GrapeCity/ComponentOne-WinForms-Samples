using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChartExplorer.Samples
{
    public class TopNFilter : FilterBase
    {
        private bool _topNEnabled;
        private int _topNCount;
        private bool _showOther;


        public bool TopNEnabled
        {
            get { return this._topNEnabled; }
            set { this._topNEnabled = value; Analyse(); }
        }
        public int TopNCount
        {
            get { return this._topNCount; }
            set { this._topNCount = value; Analyse(); }
        }
        public bool ShowOther
        {
            get { return this._showOther; }
            set { this._showOther = value; Analyse(); }
        }
        public override void Analyse()
        {
            var src = Source as IEnumerable<object>;
            if (Bindings == null || Bindings.Length == 0)
                return;
            if (src == null || !src.Any())
                return;
            if (TopNEnabled)
            {
                var data = from srcItem in src select new KeyValuePair<double, object>(GetValues(srcItem, Bindings).Aggregate(AggregateFunction.Sum), srcItem);
                var sortedTopNData = data.Sort(this.SortType).Take(this.TopNCount).GetValue();

                Queue < Object > source = new Queue<object>();
                Queue<Object> sourceOthers = new Queue<object>();

                foreach(var obj in src)
                {
                    if (sortedTopNData.Contains(obj))
                        source.Enqueue(obj);
                    else
                    {
                        if (ShowOther)
                            sourceOthers.Enqueue(obj);
                    }
                }

                if (SortOrder)
                    source = new Queue<object>(sortedTopNData);
                if (ShowOther)
                {
                    var srcItem = src.First();
                    var dataItem = srcItem.GetType().Assembly.CreateInstance(srcItem.GetType().ToString());
                    SetValue(dataItem, this.BindingX, "Others");
                    foreach(var binding in Bindings)
                    {
                        var ptValues = new Queue<double>();
                        foreach(var otherItem in sourceOthers)
                        {
                            ptValues.Enqueue(GetValue(otherItem, binding));
                        }
                        SetValue(dataItem, binding, ptValues.Aggregate(AggregateFunction.Sum));
                    }
                    source.Enqueue(dataItem);
                }
                this.DataSource = source.ToArray();
            }
            else
            {
                this.DataSource = this.Source;
            }
            this.OnPropertyChanged("DataSource");
        }
    }
}
