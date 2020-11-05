using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WealthHealth.Model
{
    [DataContract]
    public class CountryData
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "income")]
        public List<List<double>> IncomeRaw { get; set; }
        [DataMember(Name = "population")]
        public List<List<double>> PopulationRaw { get; set; }
        [DataMember(Name = "lifeExpectancy")]
        public List<List<double>> LifeExpectancyRaw { get; set; }

        public DataItem GetDataByYear(int year)
        {
            return new DataItem()
            {
                Country = Name,
                Region = Region,
                Year = year,
                Income = GetInterpolatedDataByYear(year, IncomeRaw),
                Population = GetInterpolatedDataByYear(year, PopulationRaw),
                LifeExpectancy = GetInterpolatedDataByYear(year, LifeExpectancyRaw),
            };
        }

        public bool HasData()
        {
            return IncomeRaw.Count > 1 && PopulationRaw.Count > 1 && LifeExpectancyRaw.Count > 1;
        }

        double GetInterpolatedDataByYear(int year, List<List<double>> rawData)
        {
            if (year <= rawData[0][0])
                return rawData[0][1];

            var cnt = rawData.Count;
            for (var i = 1; i < cnt; i++)
            {
                var y0 = rawData[i - 1][0];
                var y = rawData[i][0];
                if (y == year)
                    return rawData[i][1];
                else if (i > 0 && year < y && year >= y0)
                    return rawData[i - 1][1] + (year - y0) / (y - y0) * (rawData[i][1] - rawData[i][1]);
            }

            return rawData[cnt - 1][1];
        }
    }

    public class DataItem
    {
        public string Country { get; set; }
        public string Region { get; set; }

        public int Year { get; set; }
        public double Income { get; set; }
        public double Population { get; set; }
        public double LifeExpectancy { get; set; }

        public string PopulationMillions
        {
            get
            {
                return string.Format("{0} million people", Math.Round(Population / 1000000, 1));
            }
        }
                
    }
}
