using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using PointD = C1.Win.Interop.Point;

namespace MapSample.Layers
{
    public class City
    {
        public string Name { get; set; }
        public PointD Location { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", Name, Location, Population, Country);
        }

        public static City FromString(string s)
        {
            City city = null;
            if (!string.IsNullOrEmpty(s))
            {
                var ss = s.Split('\t');
                if (ss.Length == 4)
                {
                    city = new City
                    {
                        Name = ss[0],
                        Location = PointFromString(ss[1]),
                        Population = int.Parse(ss[2]),
                        Country = ss[3]
                    };
                }
            }

            return city;
        }

        static PointD PointFromString(string s)
        {
            var ss = s.Split(',');
            return new PointD(double.Parse(ss[1], CultureInfo.InvariantCulture),
              double.Parse(ss[0], CultureInfo.InvariantCulture));
        }

        public static List<City> Read(Stream stream)
        {
            var cities = new List<City>();

            using (var sr = new StreamReader(stream))
            {
                for (; !sr.EndOfStream; )
                {
                    var city = FromString(sr.ReadLine());
                    if (city != null)
                        cities.Add(city);
                }
            }

            return cities;
        }
    }
}
