using DataFilterExplorer.Samples;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataFilterExplorer
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
    }
}
