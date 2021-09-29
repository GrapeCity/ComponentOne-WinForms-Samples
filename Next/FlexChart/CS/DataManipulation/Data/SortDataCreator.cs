using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class SortDataCreator
    {
        static Random r = new Random();
        public static SalesData[] CreateScore()
        {
            Queue<SalesData> sds = new Queue<SalesData>();
            
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "Mechanical",
                       PredictiveValue = 230,
                       ActualValue = 226,
                   });
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "3C",
                       PredictiveValue = 960,
                       ActualValue = 870,
                   });
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "Medicinal",
                       PredictiveValue = 520,
                       ActualValue = 500,
                   });
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "Appliances",
                       PredictiveValue = 370,
                       ActualValue = 300,
                   });
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "Software",
                       PredictiveValue = 320,
                       ActualValue = 120,
                   });
            sds.Enqueue(
                   new SalesData()
                   {
                       Name = "Cosmetic",
                       PredictiveValue = 780,
                       ActualValue = 700,
                   });

            return sds.ToArray();
        }
    }

    public class SalesData
    {
        public string Name { get; set; }
        public double PredictiveValue { get; set; }
        public double ActualValue { get; set; }
    }
}
