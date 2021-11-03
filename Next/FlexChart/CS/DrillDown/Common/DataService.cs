using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrillDown
{
    public class DataService
    {
        Random rnd = new Random();
        static DataService _default;

        private DataService()
        {

        }

        public static DataService Instance
        {
            get
            {
                if (_default == null)
                {
                    _default = new DataService();
                }

                return _default;
            }
        }

        public List<DataItem> GetSunburstData()
        {
            var list = new List<DataItem>();
            List<string> years = new List<string>();
            List<List<string>> times = new List<List<string>>()
            {
                new List<string>() { "Jan", "Feb", "Mar"},
                new List<string>() { "Apr", "May", "June"},
                new List<string>() { "Jul", "Aug", "Sep"},
                new List<string>() { "Oct", "Nov", "Dec" }
            };

            var yearLen = Math.Max((int)Math.Round(Math.Abs(5 - Instance.rnd.NextDouble() * 10)), 3);
            int currentYear = DateTime.Now.Year;
            for (int i = yearLen; i > 0; i--)
            {
                years.Add((currentYear - i).ToString());
            }
            var quarterAdded = false;

            years.ForEach(y =>
            {
                var i = years.IndexOf(y);
                var addQuarter = Instance.rnd.NextDouble() > 0.5;
                if (!quarterAdded && i == years.Count - 1)
                {
                    addQuarter = true;
                }
                var year = new DataItem() { Year = y };
                if (addQuarter)
                {
                    quarterAdded = true;
                    times.ForEach(q =>
                    {
                        var addMonth = Instance.rnd.NextDouble() > 0.5;
                        int idx = times.IndexOf(q);
                        var quar = "Q" + (idx + 1);
                        var quarters = new DataItem() { Year = y, Quarter = quar };
                        if (addMonth)
                        {
                            q.ForEach(m =>
                            {
                                quarters.Items.Add(new DataItem()
                                {
                                    Year = y,
                                    Quarter = quar,
                                    Month = m,
                                    Value = rnd.Next(20, 30)
                                });
                            });
                        }
                        else
                        {
                            quarters.Value = rnd.Next(80, 100);
                        }
                        year.Items.Add(quarters);
                    });
                }
                else
                {
                    year.Value = rnd.Next(80, 100);
                }
                list.Add(year);
            });

            return list;
        }

        public List<Item> GetData(int count)
        {
            List<Item> data = new List<Item>();
            var countries = "US,Germany,UK,Japan,Italy,Greece".Split(',');
            var years = new int[] { 2013, 2014, 2015, 2016, 2017 };
            var countriesLen = countries.Length;
            var citiesByCountry = new Dictionary<string, string[]>();
            citiesByCountry.Add("US", new string[] { "New York", "Los Angeles", "Chicago", "Phoenix", "Dallas" });
            citiesByCountry.Add("Germany", new string[] { "Berlin", "Hamburg", "Munich", "Cologne", "Frankfurt" });
            citiesByCountry.Add("UK", new string[] { "London", "Birmingham", "Leeds", "Glasgow", "Sheffield" });
            citiesByCountry.Add("Japan", new string[] { "Tokyo", "Kanagawa", "Osaka", "Aichi", "Hokkaido" });
            citiesByCountry.Add("Italy", new string[] { "Rome", "Milan", "Naples", "Turin", "Palermo" });
            citiesByCountry.Add("Greece", new string[] { "Athens", "Thessaloniki", "Patras", "Heraklion", "Larissa" });
            for (int i = 0; i < count; i++)
            {
                var yearIndex = rnd.Next(0, 5);
                var cityIndex = rnd.Next(0, 5);
                int countryIndex = i % countriesLen;
                var country = countries[countryIndex];
                data.Add(new Item()
                {
                    ID = i,
                    Country = country,
                    City = citiesByCountry[country][cityIndex],
                    Year = years[yearIndex].ToString(),
                    Month = DateTimeFormatInfo.CurrentInfo.GetMonthName(i % 12 + 1),
                    Day = (i % 27 + 1),
                    Amount = Math.Floor(rnd.NextDouble() * 10000)
                });
            }

            return data;
        }

        static IEnumerable<Item> _rawData;

        public IEnumerable<FlexPoint> GetGroupedData(string currentPath, object currentPathValue = null, string newPath = null)
        {
            if (_rawData == null)
            {
                _rawData = Instance.GetData(5000);
            }

            var initialDataSource = _rawData;
            var summarizedData = new List<FlexPoint>();
            if (currentPathValue != null && newPath != null)
            {
                Thread.Sleep(5000);

                summarizedData = initialDataSource
                     .Where(p => Instance.GetProperty(p, currentPath).Equals(currentPathValue))
                     .GroupBy(p1 => Instance.GetProperty(p1, newPath))
                     .Select(p2 =>
                        new FlexPoint
                        {
                            XValue = p2.Key.ToString(),
                            YValue = p2.Sum(k => k.Amount)
                        }).OrderBy(x=>x.XValue).ToList();
                if (currentPath == "Year")
                {
                    var mNames = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
                   summarizedData =  summarizedData.OrderBy(x => mNames.IndexOf(x.XValue)).ToList();
                }
                if(currentPath == "Month")
                {
                    summarizedData = summarizedData.OrderBy(x => Int32.Parse(x.XValue)).ToList();
                }
            }
            else
            {
                summarizedData = initialDataSource
                    .GroupBy(p => Instance.GetProperty(p, currentPath))
                    .Select(p =>
                        new FlexPoint
                        {
                            XValue = p.Key.ToString(),
                            YValue = p.Sum(k => k.Amount)
                        }).OrderBy(x => x.XValue).ToList();
            }
            return summarizedData;
        }

        private object GetProperty(object obj, string path)
        {
            return obj.GetType().GetProperty(path).GetValue(obj);
        }

    }
}
