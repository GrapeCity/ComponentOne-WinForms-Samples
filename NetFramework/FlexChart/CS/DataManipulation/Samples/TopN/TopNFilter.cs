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
            IEnumerable<object> src = this.Source as IEnumerable<object>;

            if (src == null || Bindings == null || Bindings.Length == 0)
            {
                return;
            }
            if (!src.Any())
            {
                return;
            }
            
            if (this.TopNEnabled)
            {
                var data = from p in src select new KeyValuePair<double, object>(GetValues(p, Bindings).Aggregate(AggregateFunction.Sum), p);
                
                var sortedTopNData = data.Sort(this.SortType).Take(this.TopNCount).GetValue();

                Queue<object> source = new Queue<object>();
                Queue<object> sourceOthers = new Queue<object>();
                foreach (var obj in src)
                {
                    if (sortedTopNData.Contains(obj))
                    {
                        source.Enqueue(obj);
                    }
                    else
                    {
                        if (ShowOther)
                        {
                            sourceOthers.Enqueue(obj);
                        }
                    }
                }

                if (SortOrder)
                {
                    source = new Queue<object>(sortedTopNData);
                }

                if (ShowOther)
                {
                    var srcItem = src.First();
                    var others = srcItem.GetType().Assembly.CreateInstance(srcItem.GetType().ToString());
                    SetValue(others, "Name", "Others");

                    foreach (var binding in Bindings)
                    {
                        Queue<double> ptValues = new Queue<double>();
                        foreach (var item in sourceOthers)
                        {
                            ptValues.Enqueue(GetValue(item, binding));
                        }
                        SetValue(others, binding, ptValues.Aggregate(AggregateFunction.Sum));
                    }
                    source.Enqueue(others);
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
