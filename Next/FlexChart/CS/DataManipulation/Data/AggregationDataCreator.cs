using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class AggregationDataCreator
    {
        static Random r = new Random();
        public static YearData[] CreateScore()
        {
            Queue<YearData> ys = new Queue<YearData>();

            for (int i = 0; i < 240; i++)
            {
                int month = ((i % 12) + 1);
                int q = (month / 3) + ((month % 3) == 0 ? 0 : 1);
                int year = (1997 + (i - 1) / 12);

                ys.Enqueue(new YearData()
                {
                    Year = year,
                    M = month.ToString(),
                    Q = q,
                    Value = r.Next(500),
                });
            }

            return ys.ToArray();
        }
    }

    public class YearData
    {
        public int Year { get; set; }

        public int Q { get; set; }
        public string M { get; set; }
        public double Value { get; set; }
    }
}
