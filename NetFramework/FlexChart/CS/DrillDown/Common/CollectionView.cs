using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillDown
{
    public class CollectionView
    {
        #region fields
        private AggregateType _aggregateType = AggregateType.Sum;
        private string _aggregateOn;
        #endregion

        #region object model

        public CollectionView[] Views { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public CollectionView Parent { get; set; }
        public IEnumerable<object> SourceCollection { get; set; }

        public AggregateType AggregateType
        {
            get
            {
                return _aggregateType;
            }
            set
            {
                _aggregateType = value;
            }
        }

        #endregion

        #region C'tors

        private CollectionView(AggregateType type)
        {
            AggregateType = type;
        }


        public CollectionView(IEnumerable<object> dataSource, string groupBy, string aggregateOn, AggregateType type = AggregateType.Sum, string name = null)
        {
            this.SourceCollection = dataSource;
            this.Name = name;
            this._aggregateOn = aggregateOn;
            var views = dataSource.GroupBy(p => GetProperty(p, groupBy)).Select(p =>
                                new CollectionView(type)
                                {
                                    Parent = this,
                                    Name = p.Key.ToString(),
                                    Value = p.Aggregate(k => (double)GetProperty(k,aggregateOn), type),
                                    SourceCollection = p,
                                });
            this.Views = views.ToArray();
        }
        

        public CollectionView(IEnumerable<object> dataSource, string[] paths, string aggregateOn, AggregateType type = AggregateType.Sum, string name = null)
        {
            this.SourceCollection = dataSource;
            this.Name = name;
            var views = GetViews(dataSource, new Queue<string>(paths),aggregateOn, name);
            this.Views = views.ToArray();
        }

        #endregion

        #region Public Methods

        public CollectionView DrillDown(int index, string subPath, AggregateType type)
        {
            CollectionView view = null;
            if (this.Views != null && index < this.Views.Length && this.Views[index] != null)
            {
                view = new CollectionView(this.Views[index].SourceCollection, subPath, _aggregateOn, type, this.Views[index].Name);
                view.Parent = this;
            }
            return view;
        }

        #endregion

        #region Implementation

        CollectionView[] GetViews(IEnumerable<object> dataSource, Queue<string> paths,string aggregateOn, string name = null)
        {
            if (paths.Count == 0)
            {
                return null;
            }
            var currentPath = paths.Dequeue();
            if (string.IsNullOrEmpty(currentPath))
            {
                return null;
            }
            this.SourceCollection = dataSource;
            this.Name = name;

            var views = dataSource.GroupBy(p => GetProperty(p, currentPath)).Select(p =>
                                new CollectionView(this.AggregateType)
                                {
                                    Parent = this,
                                    Name = p.Key.ToString(),
                                    Value = p.Sum(k => (double)GetProperty(k,aggregateOn)),
                                    SourceCollection = p,
                                    Views = GetViews(p, new Queue<string>(paths), name),
                                });

            return views.ToArray();
        }

        private static object GetProperty(object obj, string path)
        {
            return obj.GetType().GetProperty(path).GetValue(obj);
        }

        #endregion
    }

    internal static class AggregateExtends
    {
        public static double Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, AggregateType type)
        {
            switch (type)
            {
                case AggregateType.Avg:
                    return source.Average(selector);
                case AggregateType.Max:
                    return source.Max(selector);
                case AggregateType.Min:
                    return source.Min(selector);
                case AggregateType.Cnt:
                    return source.Count();
                case AggregateType.Sum:
                default:
                    return source.Sum(selector);
            }
        }
    }
}
