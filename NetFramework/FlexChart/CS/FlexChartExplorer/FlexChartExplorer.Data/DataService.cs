using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace FlexChartExplorer.Data
{
    internal class DataHelper
    {
        #region fields
        private static readonly string buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private static readonly string filePath = Path.Combine(buildDir, "Resources", "Data.json");
        private static JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        private Dictionary<string, object> _dict;
        private Random rnd = new Random();

        private string[] _countries, _months, _salesStages, _departments, _purchaseFactors, _salesItems, _countryGDP;
        private List<Product> _products;
        private static DataHelper _default;
        #endregion

        #region Object Model

        public static DataHelper Instance
        {
            get
            {
                if (_default == null)
                    _default = new DataHelper();
                return _default;
            }
        }
        public string[] Countries
        {
            get
            {
                if (_countries == null)
                {
                    _countries = GetObject("Countries").ToString().Split('|');
                }
                return _countries;
            }
        }
        public string[] Months
        {
            get
            {
                if (_months == null)
                {
                    _months = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;
                }
                return _months;
            }
        }
        public string[] SalesStages
        {
            get
            {
                if (_salesStages == null)
                {
                    _salesStages = GetObject("SalesStages").ToString().Split('|');
                }
                return _salesStages;
            }
        }
        public string[] Departments
        {
            get
            {
                if (_departments == null)
                {
                    _departments = GetObject("Departments").ToString().Split('|');
                }
                return _departments;
            }
        }
        public string[] PurchaseFactors
        {
            get
            {
                if (_purchaseFactors == null)
                    _purchaseFactors = GetObject("PurchaseFactors").ToString().Split('|');
                return _purchaseFactors;
            }
        }
        public List<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    var values = javaScriptSerializer.Serialize(GetObject("Products"));
                    _products = javaScriptSerializer.Deserialize<List<Product>>(values);
                }
                return _products;
            }
        }
        public string[] SalesItems
        {
            get
            {
                if (_salesItems == null)
                    _salesItems = GetObject("SalesItems").ToString().Split('|');
                return _salesItems;
            }
        }
        public string[] CountryGDP
        {
            get
            {
                if (_countryGDP == null)
                    _countryGDP = GetObject("Country_GDP").ToString().Split('|');
                return _countryGDP;
            }
        }
        #endregion

        #region Methods
        private object GetObject(string key)
        {
            if (_dict == null)
            {
                var json = File.ReadAllText(filePath);
                _dict = javaScriptSerializer.Deserialize<Dictionary<string, object>>(json);
            }
            return _dict[key];
        }

        private string GetRandomString(string[] arr)
        {
            return arr[rnd.Next(arr.Length)];
        }

        private DataHelper() { }
        #endregion
    }

    public class DataService
    {
        static Random rnd = new Random();
        static DataHelper _dataHelper = DataHelper.Instance;

        public static IList<CategoricalPoint> GetRecruitmentData()
        {
            var data = new List<CategoricalPoint>();

            data.Add(new CategoricalPoint { Name = "Candidates Applied", Value = 250 });
            data.Add(new CategoricalPoint { Name = "Initial Validation", Value = 145 });
            data.Add(new CategoricalPoint { Name = "Screening", Value = 105 });
            data.Add(new CategoricalPoint { Name = "Telephonic Interview", Value = 85 });
            data.Add(new CategoricalPoint { Name = "Personal Interview", Value = 48 });
            data.Add(new CategoricalPoint { Name = "Hired", Value = 18 });
            return data;
        }

        public static List<Task> GetTasksData()
        {
            var taskList = new List<Task>();
            var year = DateTime.Now.Year;
            taskList.Add(new Task { Name = "Documentation", Start = new DateTime(year, 5, 5), End = new DateTime(year, 6, 15) });
            taskList.Add(new Task { Name = "Testing and QA", Start = new DateTime(year, 5, 11), End = new DateTime(year, 6, 15) });
            taskList.Add(new Task { Name = "Test Plan", Start = new DateTime(year, 4, 26), End = new DateTime(year, 5, 11) });
            taskList.Add(new Task { Name = "Development", Start = new DateTime(year, 4, 25), End = new DateTime(year, 6, 15) });
            taskList.Add(new Task { Name = "Detail Design", Start = new DateTime(year, 4, 18), End = new DateTime(year, 5, 2) });
            taskList.Add(new Task { Name = "Planning", Start = new DateTime(year, 4, 12), End = new DateTime(year, 4, 26) });
            taskList.Add(new Task { Name = "Architecture", Start = new DateTime(year, 3, 27), End = new DateTime(year, 4, 12) });
            taskList.Add(new Task { Name = "Specifications", Start = new DateTime(year, 3, 14), End = new DateTime(year, 3, 27) });
            taskList.Add(new Task { Name = "Preparation", Start = new DateTime(year, 3, 1), End = new DateTime(year, 3, 14) });

            return taskList;
        }

        public static List<EnergyConsumption> GetEnergyConsumptionData()
        {
            var data = new List<EnergyConsumption>();
            for (int year = 1990; year <= 2017; year++)
            {
                var total = 100;
                var petroleum = rnd.Next(30, 40);
                total -= petroleum;
                var natural = rnd.Next(20, 30);
                total -= natural;
                var coal = rnd.Next(10, 20);
                total -= coal;
                var renewable = rnd.Next(5, 10);
                total -= renewable;
                var nuclear = total;
                data.Add(new EnergyConsumption
                {
                    Year = year,
                    Petroleum = petroleum / 100.0,
                    NaturalGas = natural / 100.0,
                    Coal = coal / 100.0,
                    Renewable = renewable / 100.0,
                    Nuclear = nuclear / 100.0,
                });
            }
            return data;
        }

        public static List<CategoricalPoint> GetPurchaseFactorsData()
        {
            var data = new List<CategoricalPoint>();
            for (int i = 1; i <= 7; i++)
            {
                int fact = 1;
                foreach (string factor in _dataHelper.PurchaseFactors)
                {
                    data.Add(new CategoricalPoint
                    {
                        Name = factor,
                        Value = (22 - (fact * 3)) * rnd.Next(9, 15),
                    });
                    fact++;
                }
            }
            return data;
        }

        public static List<Object> GetSineCosineData(double k, double a)
        {
            var data = new List<Object>();
            var count = 360;
            for (int point = 0; point < count; point++)
            {
                data.Add(new
                {
                    X = point,
                    SinX = Math.Sin(k * Math.PI * point / 180) + a,
                    CosX = Math.Cos(k * Math.PI * point / 180) + a,
                });
            }
            return data;
        }

        public static List<CityDataItem> GetTemperatureData(string[] cities, bool monthly = false, int count = 30, bool isFahrenheit = false)
        {
            var data = new List<CityDataItem>();
            var startDate = new DateTime(2017, 1, 1);
            foreach (string city in cities)
            {
                var dataItem = new CityDataItem() { Name = city };
                for (int i = 0; i < count; i++)
                {
                    var temp = new Temperature();
                    DateTime date;
                    if (monthly)
                        date = startDate.AddMonths(i);
                    else
                        date = startDate.AddDays(i);
                    temp.Date = date;
                    if (date.Month <= 8)
                        temp.HighTemp = rnd.Next(3 * date.Month, 8 * date.Month);
                    else
                        temp.HighTemp = rnd.Next((13 - date.Month - 2) * date.Month, (13 - date.Month) * date.Month);
                    temp.LowTemp = temp.HighTemp - rnd.Next(6, 8);
                    temp.Precipitation = (date.Month < 4 || date.Month > 8) ? rnd.Next(100, 150) : rnd.Next(150, 200);
                    if (isFahrenheit) temp.HighTemp = temp.HighTemp * 1.8 + 32;
                    dataItem.Data.Add(temp);
                }
                data.Add(dataItem);
            }
            return data;
        }

        public static List<CategoricalPoint> GetMonthAxisDataSource()
        {
            List<CategoricalPoint> data = new List<CategoricalPoint>();
            int i = 0;
            foreach (string month in _dataHelper.Months.Take(12))
            {
                data.Add(new CategoricalPoint { Name = month, Value = i });
                i++;
            }
            return data;
        }

        public static List<UnitsCost> GetUnitCostData()
        {
            var data = new List<UnitsCost>();
            var date = new DateTime(2017, 1, 1);
            int cost = 900;
            for (int i = 10; i <= 180; i += 10)
            {
                cost += i <= 100 ? -rnd.Next(20, 70) : rnd.Next(20, 50);
                data.Add(new UnitsCost
                {
                    Units = i,
                    Cost = cost,
                });
            }
            return data;
        }

        public static List<Object> GetGamesInfo()
        {
            var data = new List<Object>()
            {
                new {Year = "1958", Won = 5, Drawn = 1, Lost = 0},
                new {Year = "1962", Won = 5, Drawn = 1, Lost = 0},
                new {Year = "1966", Won = 1, Drawn = 0, Lost = 2},
                new {Year = "1970", Won = 6, Drawn = 0, Lost = 0},
                new {Year = "1974", Won = 3, Drawn = 2, Lost = 2},
                new {Year = "1978", Won = 4, Drawn = 3, Lost = 0},
                new {Year = "1982", Won = 4, Drawn = 0, Lost = 1},
                new {Year = "1986", Won = 4, Drawn = 1, Lost = 0},
                new {Year = "1990", Won = 3, Drawn = 0, Lost = 1},
                new {Year = "1994", Won = 5, Drawn = 2, Lost = 0},
                new {Year = "1998", Won = 4, Drawn = 1, Lost = 2},
                new {Year = "2002", Won = 7, Drawn = 0, Lost = 0},
                new {Year = "2006", Won = 4, Drawn = 0, Lost = 1},
                new {Year = "2010", Won = 3, Drawn = 1, Lost = 1},
                new {Year = "2014", Won = 3, Drawn = 2, Lost = 2},
                new {Year = "2018", Won = 3, Drawn = 1, Lost = 1},
            };
            return data;
        }

        public static List<Object> GetWebTrafficStats()
        {
            var data = new List<Object>();
            var time = new DateTime(2017, 5, 1, 0, 0, 0);
            for (int i = 1; i <= 8; i++)
            {
                var traffic = i < 4 ? rnd.Next(1000 * (4 - i), 1000 * (4 - i) + rnd.Next(50, 200)) : rnd.Next(1000 * i, 1000 * i + rnd.Next(50, 200));
                traffic = i == 1 ? 10000 : traffic;
                data.Add(new
                {
                    Time = time,
                    Traffic = traffic,
                });
                time = time.AddHours(3);
            }
            return data;
        }
        public static List<Object> GetNewsSourcesInfo()
        {
            var data = new List<Object>();
            for (int year = 2000; year <= 2017; year++)
            {
                var count = year - 1999;
                data.Add(new
                {
                    Year = year,
                    TV = rnd.Next(71 - count / 2, 71 + count / 2) / 100f,
                    Newspaper = rnd.Next(40 - count / 3, 40 - count / 3 + 10) / 100f,
                    Radio = rnd.Next(30 - count, 30 - count + 3) / 100f,
                    Internet = rnd.Next(count * 3, count * 3 + 10) / 100f,
                });
            }
            return data;
        }
        public static List<Student> GetStudentScores()
        {
            var data = new List<Student>();
            var maxScore = 1600;
            for (int i = 1; i <= 200; i++)
            {
                data.Add(new Student
                {
                    Number = i,
                    Score = (int)(maxScore * 0.5 * (1 + rnd.NextDouble())),
                });
            }
            return data;
        }
        public static List<PointD> GetPointData()
        {
            var original = new List<PointD>() { new PointD{X=161.2,Y= 51.6}, new PointD{X=167.5,Y= 59.0}, new PointD{X=159.5,Y= 49.2}, new PointD{X=157.0,Y= 63.0}, new PointD{X=155.8,Y= 53.6},
            new PointD{X=170.0,Y= 59.0}, new PointD{X=159.1,Y= 47.6}, new PointD{X=166.0,Y= 69.8}, new PointD{X=176.2,Y= 66.8}, new PointD{X=160.2,Y= 75.2},
            new PointD{X=172.5,Y= 55.2}, new PointD{X=170.9,Y= 54.2}, new PointD{X=172.9,Y= 62.5}, new PointD{X=153.4,Y= 42.0}, new PointD{X=160.0,Y= 50.0},
            new PointD{X=147.2,Y= 49.8}, new PointD{X=168.2,Y= 49.2}, new PointD{X=175.0,Y= 73.2}, new PointD{X=157.0,Y= 47.8}, new PointD{X=167.6,Y= 68.8},
            new PointD{X=159.5,Y= 50.6}, new PointD{X=175.0,Y= 82.5}, new PointD{X=166.8,Y= 57.2}, new PointD{X=176.5,Y= 87.8}, new PointD{X=170.2,Y= 72.8},
            new PointD{X=174.0,Y= 54.5}, new PointD{X=173.0,Y= 59.8}, new PointD{X=179.9,Y= 67.3}, new PointD{X=170.5,Y= 67.8}, new PointD{X=160.0,Y= 47.0},
            new PointD{X=154.4,Y= 46.2}, new PointD{X=162.0,Y= 55.0}, new PointD{X=176.5,Y= 83.0}, new PointD{X=160.0,Y= 54.4}, new PointD{X=152.0,Y= 45.8},
            new PointD{X=162.1,Y= 53.6}, new PointD{X=170.0,Y= 73.2}, new PointD{X=160.2,Y= 52.1}, new PointD{X=161.3,Y= 67.9}, new PointD{X=166.4,Y= 56.6},
            new PointD{X=168.9,Y= 62.3}, new PointD{X=163.8,Y= 58.5}, new PointD{X=167.6,Y= 54.5}, new PointD{X=160.0,Y= 50.2}, new PointD{X=161.3,Y= 60.3},
            new PointD{X=167.6,Y= 58.3}, new PointD{X=165.1,Y= 56.2}, new PointD{X=160.0,Y= 50.2}, new PointD{X=170.0,Y= 72.9}, new PointD{X=157.5,Y= 59.8},
            new PointD{X=167.6,Y= 61.0}, new PointD{X=160.7,Y= 69.1}, new PointD{X=163.2,Y= 55.9}, new PointD{X=152.4,Y= 46.5}, new PointD{X=157.5,Y= 54.3},
            new PointD{X=168.3,Y= 54.8}, new PointD{X=180.3,Y= 60.7}, new PointD{X=165.5,Y= 60.0}, new PointD{X=165.0,Y= 62.0}, new PointD{X=164.5,Y= 60.3},
            new PointD{X=156.0,Y= 52.7}, new PointD{X=160.0,Y= 74.3}, new PointD{X=163.0,Y= 62.0}, new PointD{X=165.7,Y= 73.1}, new PointD{X=161.0,Y= 80.0},
            new PointD{X=162.0,Y= 54.7}, new PointD{X=166.0,Y= 53.2}, new PointD{X=174.0,Y= 75.7}, new PointD{X=172.7,Y= 61.1}, new PointD{X=167.6,Y= 55.7},
            new PointD{X=151.1,Y= 48.7}, new PointD{X=164.5,Y= 52.3}, new PointD{X=163.5,Y= 50.0}, new PointD{X=152.0,Y= 59.3}, new PointD{X=169.0,Y= 62.5},
            new PointD{X=164.0,Y= 55.7}, new PointD{X=161.2,Y= 54.8}, new PointD{X=155.0,Y= 45.9}, new PointD{X=170.0,Y= 70.6}, new PointD{X=176.2,Y= 67.2},
            new PointD{X=170.0,Y= 69.4}, new PointD{X=162.5,Y= 58.2}, new PointD{X=170.3,Y= 64.8}, new PointD{X=164.1,Y= 71.6}, new PointD{X=169.5,Y= 52.8},
            new PointD{X=163.2,Y= 59.8}, new PointD{X=154.5,Y= 49.0}, new PointD{X=159.8,Y= 50.0}, new PointD{X=173.2,Y= 69.2}, new PointD{X=170.0,Y= 55.9},
            new PointD{X=161.4,Y= 63.4}, new PointD{X=169.0,Y= 58.2}, new PointD{X=166.2,Y= 58.6}, new PointD{X=159.4,Y= 45.7}, new PointD{X=162.5,Y= 52.2},
            new PointD{X=159.0,Y= 48.6}, new PointD{X=162.8,Y= 57.8}, new PointD{X=159.0,Y= 55.6}, new PointD{X=179.8,Y= 66.8}, new PointD{X=162.9,Y= 59.4},
            new PointD{X=161.0,Y= 53.6}, new PointD{X=151.1,Y= 73.2}, new PointD{X=168.2,Y= 53.4}, new PointD{X=168.9,Y= 69.0}, new PointD{X=173.2,Y= 58.4},
            new PointD{X=171.8,Y= 56.2}, new PointD{X=178.0,Y= 70.6}, new PointD{X=164.3,Y= 59.8}, new PointD{X=163.0,Y= 72.0}, new PointD{X=168.5,Y= 65.2},
            new PointD{X=166.8,Y= 56.6}, new PointD{X=172.7,Y= 105.2}, new PointD{X=163.5,Y= 51.8}, new PointD{X=169.4,Y= 63.4}, new PointD{X=167.8,Y= 59.0},
            new PointD{X=159.5,Y= 47.6}, new PointD{X=167.6,Y= 63.0}, new PointD{X=161.2,Y= 55.2}, new PointD{X=160.0,Y= 45.0}, new PointD{X=163.2,Y= 54.0},
            new PointD{X=162.2,Y= 50.2}, new PointD{X=161.3,Y= 60.2}, new PointD{X=149.5,Y= 44.8}, new PointD{X=157.5,Y= 58.8}, new PointD{X=163.2,Y= 56.4},
            new PointD{X=172.7,Y= 62.0}, new PointD{X=155.0,Y= 49.2}, new PointD{X=156.5,Y= 67.2}, new PointD{X=164.0,Y= 53.8}, new PointD{X=160.9,Y= 54.4},
            new PointD{X=162.8,Y= 58.0}, new PointD{X=167.0,Y= 59.8}, new PointD{X=160.0,Y= 54.8}, new PointD{X=160.0,Y= 43.2}, new PointD{X=168.9,Y= 60.5},
            new PointD{X=158.2,Y= 46.4}, new PointD{X=156.0,Y= 64.4}, new PointD{X=160.0,Y= 48.8}, new PointD{X=167.1,Y= 62.2}, new PointD{X=158.0,Y= 55.5},
            new PointD{X=167.6,Y= 57.8}, new PointD{X=156.0,Y= 54.6}, new PointD{X=162.1,Y= 59.2}, new PointD{X=173.4,Y= 52.7}, new PointD{X=159.8,Y= 53.2},
            new PointD{X=170.5,Y= 64.5}, new PointD{X=159.2,Y= 51.8}, new PointD{X=157.5,Y= 56.0}, new PointD{X=161.3,Y= 63.6}, new PointD{X=162.6,Y= 63.2},
            new PointD{X=160.0,Y= 59.5}, new PointD{X=168.9,Y= 56.8}, new PointD{X=165.1,Y= 64.1}, new PointD{X=162.6,Y= 50.0}, new PointD{X=165.1,Y= 72.3},
            new PointD{X=166.4,Y= 55.0}, new PointD{X=160.0,Y= 55.9}, new PointD{X=152.4,Y= 60.4}, new PointD{X=170.2,Y= 69.1}, new PointD{X=162.6,Y= 84.5},
            new PointD{X=170.2,Y= 55.9}, new PointD{X=158.8,Y= 55.5}, new PointD{X=172.7,Y= 69.5}, new PointD{X=167.6,Y= 76.4}, new PointD{X=162.6,Y= 61.4},
            new PointD{X=167.6,Y= 65.9}, new PointD{X=156.2,Y= 58.6}, new PointD{X=175.2,Y= 66.8}, new PointD{X=172.1,Y= 56.6}, new PointD{X=162.6,Y= 58.6},
            new PointD{X=160.0,Y= 55.9}, new PointD{X=165.1,Y= 59.1}, new PointD{X=182.9,Y= 81.8}, new PointD{X=166.4,Y= 70.7}, new PointD{X=165.1,Y= 56.8},
            new PointD{X=177.8,Y= 60.0}, new PointD{X=165.1,Y= 58.2}, new PointD{X=175.3,Y= 72.7}, new PointD{X=154.9,Y= 54.1}, new PointD{X=158.8,Y= 49.1},
            new PointD{X=172.7,Y= 75.9}, new PointD{X=168.9,Y= 55.0}, new PointD{X=161.3,Y= 57.3}, new PointD{X=167.6,Y= 55.0}, new PointD{X=165.1,Y= 65.5},
            new PointD{X=175.3,Y= 65.5}, new PointD{X=157.5,Y= 48.6}, new PointD{X=163.8,Y= 58.6}, new PointD{X=167.6,Y= 63.6}, new PointD{X=165.1,Y= 55.2},
            new PointD{X=165.1,Y= 62.7}, new PointD{X=168.9,Y= 56.6}, new PointD{X=162.6,Y= 53.9}, new PointD{X=164.5,Y= 63.2}, new PointD{X=176.5,Y= 73.6},
            new PointD{X=168.9,Y= 62.0}, new PointD{X=175.3,Y= 63.6}, new PointD{X=159.4,Y= 53.2}, new PointD{X=160.0,Y= 53.4}, new PointD{X=170.2,Y= 55.0},
            new PointD{X=162.6,Y= 70.5}, new PointD{X=167.6,Y= 54.5}, new PointD{X=162.6,Y= 54.5}, new PointD{X=160.7,Y= 55.9}, new PointD{X=160.0,Y= 59.0},
            new PointD{X=157.5,Y= 63.6}, new PointD{X=162.6,Y= 54.5}, new PointD{X=152.4,Y= 47.3}, new PointD{X=170.2,Y= 67.7}, new PointD{X=165.1,Y= 80.9},
            new PointD{X=172.7,Y= 70.5}, new PointD{X=165.1,Y= 60.9}, new PointD{X=170.2,Y= 63.6}, new PointD{X=170.2,Y= 54.5}, new PointD{X=170.2,Y= 59.1},
            new PointD{X=161.3,Y= 70.5}, new PointD{X=167.6,Y= 52.7}, new PointD{X=167.6,Y= 62.7}, new PointD{X=165.1,Y= 86.3}, new PointD{X=162.6,Y= 66.4},
            new PointD{X=152.4,Y= 67.3}, new PointD{X=168.9,Y= 63.0}, new PointD{X=170.2,Y= 73.6}, new PointD{X=175.2,Y= 62.3}, new PointD{X=175.2,Y= 57.7},
            new PointD{X=160.0,Y= 55.4}, new PointD{X=165.1,Y= 104.1}, new PointD{X=174.0,Y= 55.5}, new PointD{X=170.2,Y= 77.3}, new PointD{X=160.0,Y= 80.5},
            new PointD{X=167.6,Y= 64.5}, new PointD{X=167.6,Y= 72.3}, new PointD{X=167.6,Y= 61.4}, new PointD{X=154.9,Y= 58.2}, new PointD{X=162.6,Y= 81.8},
            new PointD{X=175.3,Y= 63.6}, new PointD{X=171.4,Y= 53.4}, new PointD{X=157.5,Y= 54.5}, new PointD{X=165.1,Y= 53.6}, new PointD{X=160.0,Y= 60.0},
            new PointD{X=174.0,Y= 73.6}, new PointD{X=162.6,Y= 61.4}, new PointD{X=174.0,Y= 55.5}, new PointD{X=162.6,Y= 63.6}, new PointD{X=161.3,Y= 60.9},
            new PointD{X=156.2,Y= 60.0}, new PointD{X=149.9,Y= 46.8}, new PointD{X=169.5,Y= 57.3}, new PointD{X=160.0,Y= 64.1}, new PointD{X=175.3,Y= 63.6},
            new PointD{X=169.5,Y= 67.3}, new PointD{X=160.0,Y= 75.5}, new PointD{X=172.7,Y= 68.2}, new PointD{X=162.6,Y= 61.4}, new PointD{X=157.5,Y= 76.8},
            new PointD{X=176.5,Y= 71.8}, new PointD{X=164.4,Y= 55.5}, new PointD{X=160.7,Y= 48.6}, new PointD{X=174.0,Y= 66.4}, new PointD{X=163.8,Y= 67.3}};
            return original;
        }
        public static List<Object> GetLineMarkerCustomData()
        {
            var data = new List<Object>();
            DateTime startDate = new DateTime(DateTime.Now.Year - 1, 1, 1);
            for (DateTime date = startDate; date.Month < startDate.AddMonths(2).Month; date += TimeSpan.FromDays(1.0))
            {
                data.Add(new
                {
                    Date = date,
                    Japan = rnd.Next(1, 99),
                    China = rnd.Next(1, 99),
                    India = rnd.Next(1, 99),
                });
            }
            return data;
        }
        public static List<object> GetTotalEarnings()
        {
            var data = new List<object>();
            for (int i = 1990; i <= 2010; i++)
            {
                data.Add(new { Year = i, Earning = i <= 1998 ? rnd.Next(30, 50 * ((i - 1989) % 10)) * 10 : rnd.Next(100, 500) * 10 });
            }
            return data;
        }
        public static List<object> GetAxisBindinglabels()
        {
            var data = new List<object>();
            for (double i = 100; i < 5000; i += 200)
            {
                data.Add(new { Value = i, Text = i / 100 >= 10 ? string.Format("{0:c1} K", i / 1000) : string.Format("{0:c0}", i) });
            }
            return data;
        }

        public static List<object> GetPlantProduction()
        {
            var data = new List<object>()
            {
                new {Year="2010", Units=90},
                new {Year="2011", Units=145},
                new {Year="2012", Units=145},
                new {Year="2013", Units=120},
                new {Year="2014", Units=120},
                new {Year="2015", Units=120},
                new {Year="2016", Units=165},
                new {Year="2017", Units=180},
            };
            return data;
        }

        public static List<SmartPhoneVendor> SmartPhoneVendors()
        {
            List<SmartPhoneVendor> vendors = new List<SmartPhoneVendor>();

            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Apple",
                Color = Color.FromArgb(136, 189, 230),
                Shipments = 215.2,
                Country = "USA",
                Image = Properties.Resources.apple_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Huawei",
                Color = Color.FromArgb(251, 178, 88),
                Shipments = 139,
                Country = "China",
                Image = Properties.Resources.huawei_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Lenovo",
                Color = Color.FromArgb(144, 205, 151),
                Shipments = 50.7,
                Country = "China",
                Image = Properties.Resources.lenovo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "LG",
                Color = Color.FromArgb(246, 170, 201),
                Shipments = 55.1,
                Country = "Korea",
                Image = Properties.Resources.lg_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Oppo",
                Color = Color.FromArgb(191, 165, 84),
                Shipments = 92.5,
                Country = "China",
                Image = Properties.Resources.oppo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Samsung",
                Color = Color.FromArgb(188, 153, 199),
                Shipments = 310.3,
                Country = "Korea",
                Image = Properties.Resources.samsung_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Vivo",
                Color = Color.FromArgb(237, 221, 70),
                Shipments = 71.7,
                Country = "China",
                Image = Properties.Resources.vivo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Xiaomi",
                Color = Color.FromArgb(240, 126, 110),
                Shipments = 61,
                Country = "China",
                Image = Properties.Resources.xiaomi_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "ZTE",
                Color = Color.FromArgb(140, 140, 140),
                Shipments = 61.9,
                Country = "China",
                Image = Properties.Resources.zte_50,
            });

            return vendors;
        }
        public static List<CategoricalPoint> GetUSStatesTemperature()
        {
            List<CategoricalPoint> records = new List<CategoricalPoint>();
            records.Add(new CategoricalPoint() { Name = "Alabama", Value = 112 });
            records.Add(new CategoricalPoint() { Name = "Alaska", Value = 100 });
            records.Add(new CategoricalPoint() { Name = "Arizona", Value = 128 });
            records.Add(new CategoricalPoint() { Name = "Arkansas", Value = 120 });
            records.Add(new CategoricalPoint() { Name = "California", Value = 134 });
            records.Add(new CategoricalPoint() { Name = "Colorado", Value = 114 });
            records.Add(new CategoricalPoint() { Name = "Connecticut", Value = 106 });
            records.Add(new CategoricalPoint() { Name = "Delaware", Value = 110 });
            records.Add(new CategoricalPoint() { Name = "District of Columbia", Value = 106 });
            records.Add(new CategoricalPoint() { Name = "Florida", Value = 109 });
            records.Add(new CategoricalPoint() { Name = "Georgia", Value = 112 });
            records.Add(new CategoricalPoint() { Name = "Hawaii", Value = 98 });
            records.Add(new CategoricalPoint() { Name = "Idaho", Value = 118 });
            records.Add(new CategoricalPoint() { Name = "Illinois", Value = 117 });
            records.Add(new CategoricalPoint() { Name = "Indiana", Value = 116 });
            records.Add(new CategoricalPoint() { Name = "Iowa", Value = 118 });
            records.Add(new CategoricalPoint() { Name = "Kansas", Value = 121 });
            records.Add(new CategoricalPoint() { Name = "Kentucky", Value = 114 });
            records.Add(new CategoricalPoint() { Name = "Louisiana", Value = 114 });
            records.Add(new CategoricalPoint() { Name = "Maine", Value = 105 });
            records.Add(new CategoricalPoint() { Name = "Maryland", Value = 109 });
            records.Add(new CategoricalPoint() { Name = "Massachusetts", Value = 107 });
            records.Add(new CategoricalPoint() { Name = "Michigan", Value = 112 });
            records.Add(new CategoricalPoint() { Name = "Minnesota", Value = 115 });
            records.Add(new CategoricalPoint() { Name = "Mississippi", Value = 115 });
            records.Add(new CategoricalPoint() { Name = "Missouri", Value = 118 });
            records.Add(new CategoricalPoint() { Name = "Montana", Value = 117 });
            records.Add(new CategoricalPoint() { Name = "Nebraska", Value = 118 });
            records.Add(new CategoricalPoint() { Name = "Nevada", Value = 125 });
            records.Add(new CategoricalPoint() { Name = "New Hampshire", Value = 106 });
            records.Add(new CategoricalPoint() { Name = "New Jersey", Value = 110 });
            records.Add(new CategoricalPoint() { Name = "New Mexico", Value = 122 });
            records.Add(new CategoricalPoint() { Name = "New York", Value = 109 });
            records.Add(new CategoricalPoint() { Name = "North Carolina", Value = 110 });
            records.Add(new CategoricalPoint() { Name = "North Dakota", Value = 121 });
            records.Add(new CategoricalPoint() { Name = "Ohio", Value = 113 });
            records.Add(new CategoricalPoint() { Name = "Oklahoma", Value = 120 });
            records.Add(new CategoricalPoint() { Name = "Oregon", Value = 117 });
            records.Add(new CategoricalPoint() { Name = "Pennsylvania", Value = 111 });
            records.Add(new CategoricalPoint() { Name = "Rhode Island", Value = 104 });
            records.Add(new CategoricalPoint() { Name = "South Carolina", Value = 113 });
            records.Add(new CategoricalPoint() { Name = "South Dakota", Value = 120 });
            records.Add(new CategoricalPoint() { Name = "Tennessee", Value = 113 });
            records.Add(new CategoricalPoint() { Name = "Texas", Value = 120 });
            records.Add(new CategoricalPoint() { Name = "Utah", Value = 117 });
            records.Add(new CategoricalPoint() { Name = "Vermont", Value = 105 });
            records.Add(new CategoricalPoint() { Name = "Virginia", Value = 110 });
            records.Add(new CategoricalPoint() { Name = "Washington", Value = 118 });
            records.Add(new CategoricalPoint() { Name = "West Virginia", Value = 112 });
            records.Add(new CategoricalPoint() { Name = "Wisconsin", Value = 114 });
            records.Add(new CategoricalPoint() { Name = "Wyoming", Value = 115 });
            return records;
        }
        public static List<CategoricalPoint> GetCountriesGDP()
        {
            var data = new List<CategoricalPoint>();
            foreach (var keyVal in _dataHelper.CountryGDP)
            {
                var val = keyVal.Split(',');
                data.Add(new CategoricalPoint { Name = val[0], Value = double.Parse(val[1]) });
            }
            return data;
        }
        public static List<Point> GetLineStylePoints()
        {
            List<Point> data = new List<Point>();
            data.Add(new Point() { X = 1, Y = 50 });
            data.Add(new Point() { X = 2, Y = 30 });
            data.Add(new Point() { X = 3, Y = 40 });
            data.Add(new Point() { X = 4, Y = 60 });
            data.Add(new Point() { X = 5, Y = 90 });
            data.Add(new Point() { X = 6, Y = 80 });
            data.Add(new Point() { X = 7, Y = 56 });
            data.Add(new Point() { X = 8, Y = 56 });
            data.Add(new Point() { X = 9, Y = 50 });
            data.Add(new Point() { X = 10, Y = 70 });
            return data;
        }
        public static List<PointD> CreateDataPoints(Func<double, double> funX, Func<double, double> funY, int count)
        {
            var data = new List<PointD>();
            for (int i = 0; i < count; i++)
            {
                data.Add(new PointD
                {
                    X = funX(i),
                    Y = funY(i),
                });
            }
            return data;
        }
        public static TwoDDataItem Get2DTempData()
        {
            var data = new double[,]
            {
                {  3.0, 3.1, 5.7, 8.2, 12.5, 15.0, 17.1, 17.1, 14.3, 10.6, 6.6, 4.3 },
                { -9.3, -7.7, -2.2, 5.8, 13.1, 16.6, 18.2, 16.4, 11.0, 5.1, -1.2, -6.1},
                { -15.1, -12.5, -5.2, 3.1, 10.1, 15.5, 18.3, 15.0, 9.4, 1.4, -5.6, -11.4},
            };
            var months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var areas = new string[] { "Amsterdam", "Moscow", "Perm" };
            return new TwoDDataItem(data, months, areas);
        }
        public static TwoDDataItem Get2DTrafficData()
        {
            var data = new double[24, 7];
            for (var j = 0; j < 7; j++)
                for (var i = 0; i < 24; i++)
                    data[i, j] = 10 * Math.Exp(-(i - 12) * (i - 12) / (2 * 4.0 * 4.0)) / Math.Sqrt(2 * Math.PI * 4.0 * 4.0) * ((j == 5 || j == 6) ? 50 : 100) * rnd.NextDouble();


            var times = new string[24];
            for (var i = 0; i < 24; i++)
                times[i] = new DateTime(2000, 1, 1, i, 0, 0).ToShortTimeString();
            var days = Enum.GetNames(typeof(DayOfWeek));
            return new TwoDDataItem(data, times, days);
        }
        public static TwoDDataItem Get2DDeformationData()
        {
            var data = new double[50, 50];
            for (var i = 0; i < 50; i++)
                for (var j = 0; j < 50; j++)
                    data[i, j] = 2 + (Math.Sin(0.1 * i) + Math.Cos(0.1 * j));
            var item = new TwoDDataItem();
            item.Values = data;
            return item;
        }

    }
}
