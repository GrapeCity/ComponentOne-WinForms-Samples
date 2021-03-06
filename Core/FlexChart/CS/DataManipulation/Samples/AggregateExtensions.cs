﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public static class AggregateExtensions
    {
        public static double Aggregate(this IEnumerable<double> values, AggregateFunction type, Func<IEnumerable<double>, double> customFun = null)
        {
            if (customFun != null)
            {
                return customFun(values);
            }
            switch (type)
            {
                case AggregateFunction.Avg:
                    return values.Average();
                case AggregateFunction.Sum:
                    return values.Sum();
                case AggregateFunction.Max:
                    return values.Max();
                case AggregateFunction.Min:
                    return values.Min();
                default:
                    return values.Sum();
            }
        }
        public static IEnumerable<KeyValuePair<double, object>> Sort(this IEnumerable<KeyValuePair<double, object>> kvs, SortType type)
        {
            switch (type)
            {
                case SortType.Descending:
                    return from kv in kvs.OrderByDescending(k => k.Key) select kv;
                case SortType.Ascending:
                    return from kv in kvs.OrderBy(k => k.Key) select kv;
                case SortType.None:
                default:
                    return kvs;
            }
        }

        public static IEnumerable<object> GetValue(this IEnumerable<KeyValuePair<double, object>> kvs)
        {
            return from kv in kvs select kv.Value;
        }
    }
}
