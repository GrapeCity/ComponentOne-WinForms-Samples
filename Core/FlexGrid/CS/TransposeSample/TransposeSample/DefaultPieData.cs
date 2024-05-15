using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeSample
{
    internal class DefaultPieData
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public static List<DefaultPieData> GetDefaultData()
        {
            var data = new List<DefaultPieData>()
            {
                new DefaultPieData{Name=".", Value=1643467},

            };
            return data;
        }

        public static List<DefaultPieData> GetHotelData()
        {
            var data = new List<DefaultPieData>()
            {
                new DefaultPieData{Name="NA", Value=1643467},

            };
            return data;
        }



    }
}