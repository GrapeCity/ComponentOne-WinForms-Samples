using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace FlexChartExplorer.Data
{
    public class Demographics
    {
        static Random rnd = new Random();
        private static List<CountryPopulation> _dtPopulation;
        public static List<Object> GetAgeData()
        {
            var data = new List<Object>();
            for (int i = 0; i < 500; i++)
            {
                var age = rnd.NextDouble() < 0.6 ? rnd.Next(1, 45) : (rnd.NextDouble() < 0.7 ? rnd.Next(46, 65) : rnd.Next(66, 100));
                data.Add(new
                {
                    AgeGroup = GetAgeGroups(age),
                    Age = age,
                    Count = 1,
                });
            }
            return data.OrderBy((dynamic x) => x.Age).ToList();
        }
        public static List<CountryPopulation> GetPopulationEducation()
        {
            if (_dtPopulation == null)
            {
                var buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var path = Path.Combine(buildDir, "Resources", "Population.json");
                var text = File.ReadAllText(path);
                var jsonSerializer = new JavaScriptSerializer();
                _dtPopulation = jsonSerializer.Deserialize<List<CountryPopulation>>(text);
            }
            return _dtPopulation;
        }
        private static string GetAgeGroups(int age)
        {
            if (age < 13)
                return "Children";
            else if (age >= 13 && age < 20)
                return "Youth";
            else if (age >= 20 && age < 25)
                return "Young Adults";
            else if (age >= 25 && age < 40)
                return "Adults";
            else if (age >= 40 && age < 65)
                return "Middle Aged";
            else
                return "Older";
        }
    }
}
