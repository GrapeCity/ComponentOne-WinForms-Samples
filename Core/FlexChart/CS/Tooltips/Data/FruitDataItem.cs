using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooltips.Data
{
    class FruitDataItem
    {
        public string Fruit { get; set; }
        public double Value { get; set; }

        public static FruitDataItem[] CreateFruit()
        {
            var fruits = Tooltips.Resources.AppResources.FruitsList.Split(',');
            var count = fruits.Length;
            var result = new FruitDataItem[count];
            var rnd = new Random();
            for (var i = 0; i < count; i++)
                result[i] = new FruitDataItem()
                {
                    Fruit = fruits[i],
                    Value = rnd.Next(20)
                };
            return result;
        }
    }

}
