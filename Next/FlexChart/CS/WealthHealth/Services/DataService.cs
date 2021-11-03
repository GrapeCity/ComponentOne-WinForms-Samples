using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using WealthHealth.Model;

namespace WealthHealth.Services
{
    public class DataService
    {
        CountryData[] _data;

        public DataService()
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WealthHealth.Resources.nations.json");
            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(CountryData[]));
            _data = (CountryData[])ser.ReadObject(stream);
        }

        public List<DataItem> GetDataByYear(int year)
        {
            var list = new List<DataItem>();
            foreach (var cntr in _data)
            {
                if(cntr.HasData())
                    list.Add(cntr.GetDataByYear(year));
            }

            // sort by population
            list.Sort((cntr1, cntr2) => cntr2.Population.CompareTo(cntr1.Population));
            return list;
        }
    }
}
