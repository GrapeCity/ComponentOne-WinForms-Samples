using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class SalesDataSource
    {
        private static DataHelper _dataHelper = DataHelper.Instance;
        private static Random rnd = new Random();
        public static List<Country> GetCountrySales(int rangeMin = 100,int rangeMax = 1000)
        {
            var data = new List<Country>();
            for (int i = 0; i < _dataHelper.Countries.Length; i++)
            {
                var country = new Country
                {
                    Name = _dataHelper.Countries[i],
                    Sales = rnd.Next(rangeMin, rangeMax),
                    Downloads = rnd.Next(rangeMin, rangeMax),
                    Expenses = rnd.Next(rangeMin, rangeMax)
                };
                data.Add(country);
            }
            return data;
        }

        public static SalesData[] GetSalesForecastData()
        {
            List<SalesData> sds = new List<SalesData>();

            sds.Add(new SalesData("Mechanical", 230, 226));
            sds.Add(new SalesData("3C", 960, 870));
            sds.Add(new SalesData("Medicinal", 520, 500));
            sds.Add(new SalesData("Appliances", 370, 300));
            sds.Add(new SalesData("Software", 320, 120));
            sds.Add(new SalesData("Cosmetic", 780, 700));
            return sds.ToArray();
        }

        public static List<SeasonSale> GetSeasonSales(int numOfCategories)
        {
            var data = new List<SeasonSale>();
            for (int i = 0; i < numOfCategories; i++)
            {
                var item = _dataHelper.SalesItems[i];
                data.Add(new SeasonSale
                {
                    Name = item,
                    WinterOnline = rnd.Next(10, 100),
                    SummerOnline = rnd.Next(10, 100),
                    WinterOffline = rnd.Next(10, 100),
                    SummerOffline = rnd.Next(10, 100),
                });
            }
            return data;
        }

        public static object[] GetSalesVsDownloadData(int count)
        {
            var data = new object[count];
            var dateStep = 0;
            for (var i = 0; i < count; i++)
            {
                var date = DateTime.Today.AddDays(dateStep += 9);
                data[i] = new
                {
                    Downloads = date.Month == 4 || date.Month == 8 ? (int?)null : rnd.Next(10, 20),
                    Sales = date.Month == 4 || date.Month == 8 ? (int?)null : rnd.Next(0, 10),
                    Date = date
                };
            }
            return data;
        }

        public static List<CountrySalesOrders> GetSalesOrders()
        {
            var data = new List<CountrySalesOrders>();
            var start = new DateTime(2013, 1, 1);
            var end = new DateTime(2015, 12, 12);
            foreach (string country in _dataHelper.Countries)
            {
                var countryData = new CountrySalesOrders { Name = country };
                for (int i = 0; i < 10; i++)
                {
                    countryData.Orders.Add(new Order
                    {
                        Id = 500 + i,
                        Amount = rnd.Next(50, 150),
                        Date = start.AddDays(rnd.Next((end - start).Days)),
                    });
                }
                data.Add(countryData);
            }
            return data;
        }

        public static List<Object> GetUnitSalesInfo()
        {
            var data = new List<Object>();
            var startDate = new DateTime(2017, 4, 1);
            for (int i = 0; i <= 90; i++)
            {
                var date = startDate.AddDays(i);
                data.Add(new
                {
                    Date = date,
                    Drink = rnd.Next(100 * date.Month, 100 * date.Month + 100),
                    Food = rnd.Next(600, 700),
                    NonConsumable = rnd.Next(300, 350),
                });
            }
            return data;
        }

        public static List<CategoricalPoint> GetCarSales()
        {
            var data = new List<CategoricalPoint>()
            {
                new CategoricalPoint{Name="Maruti", Value=1643467},
                new CategoricalPoint{Name="Hyundai", Value=536241},
                new CategoricalPoint{Name="Mahindra", Value=248859},
                new CategoricalPoint{Name="Tata", Value=210200},
                new CategoricalPoint{Name="Honda", Value=170026},
                new CategoricalPoint{Name="Toyota", Value=140645},
                new CategoricalPoint{Name="Renault", Value=102222},
                new CategoricalPoint{Name="Ford", Value=90061},
            };
            return data;
        }

    }
}
