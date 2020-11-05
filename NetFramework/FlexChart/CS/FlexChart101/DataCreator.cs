using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChart101
{
    class DataCreator
    {
        public delegate double MathActionDouble(double num);
        public delegate double MathActionInt(int num);
        public static DataTable Create(MathActionDouble function, double from, double to, double step)
        {
            var result = new DataTable();

            result.Columns.Add(new DataColumn("XVals", typeof(double)));
            result.Columns.Add(new DataColumn("YVals", typeof(double)));

            var count = (to - from) / step;

            for (double r = from; r < to; r += step)
            {
                DataRow dr = result.NewRow();
                dr[0] = r;
                dr[1] = function(r);
                result.Rows.Add(dr);
            }
            return result;
        }
        public static DataTable Create(MathActionInt function, int from, int to, int step)
        {
            var result = new DataTable();

            result.Columns.Add(new DataColumn("XVals", typeof(int)));
            result.Columns.Add(new DataColumn("YVals", typeof(int)));

            var count = (to - from) / step;

            for (int r = from; r < to; r += step)
            {
                DataRow dr = result.NewRow();
                dr[0] = r;
                dr[1] = function(r);
                result.Rows.Add(dr);
            }
            return result;
        }
        public static DataTable Create(MathActionDouble functionX, MathActionDouble functionY, int ptsCount)
        {
            var result = new DataTable();

            result.Columns.Add(new DataColumn("XVals", typeof(double)));
            result.Columns.Add(new DataColumn("YVals", typeof(double)));

            for (double i = 0; i < ptsCount; i++)
            {
                DataRow dr = result.NewRow();
                dr[0] = functionX(i);
                dr[1] = functionY(i);
                result.Rows.Add(dr);
            }
            return result;
        }

        public static FruitDataItem[] CreateFruit()
        {
            var fruits = new string[] {"Oranges", "Apples", "Pears", "Bananas"};
            var count = fruits.Length;
            var result = new FruitDataItem[count];
            var rnd = new Random();
            for (var i = 0; i < count; i++)
                result[i] = new FruitDataItem()
                {
                    Fruit = fruits[i],
                    March = rnd.Next(20),
                    April = rnd.Next(20),
                    May = rnd.Next(20),
                };
            return result;
        }
        public static double Sinus(double x)
        {
            return Math.Sin(x);
        }
        public static double Test1(double x)
        {
            return (Math.Pow(-x, 2 / 3) + Math.Sqrt(Math.Pow(x, 4 / 3) - 4 * Math.Pow(x, 2) + 4)) / 2;
        }
    }
    public class FruitDataItem
    {
        public string Fruit { get; set; }
        public double March { get; set; }
        public double April { get; set; }
        public double May { get; set; }
    }
}
