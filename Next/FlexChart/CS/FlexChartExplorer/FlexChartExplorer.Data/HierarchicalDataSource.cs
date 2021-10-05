using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlexChartExplorer.Data
{
    public class HierarchicalDataSource
    {
        static Random rnd = new Random();
        static DataHelper _dataHelper = DataHelper.Instance;
        private static int rand()
        {
            return rnd.Next(10, 100);
        }
        public static object GetTreeMapData()
        {
            var data = new TreeMapNodeItem[] { new TreeMapNodeItem {
            Type = "Music",
            Items = new TreeMapNodeItem [] { new TreeMapNodeItem {
                Type = "Country",
                Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Classic Country",
                    CurrentSales = rand(),
                    PreviousSales = rand()
                }, new TreeMapNodeItem {
                    Type= "Cowboy Country",
                    CurrentSales = rand(),
                    PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Outlaw Country",
                    CurrentSales = rand(),
                     PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Western Swing",
                    CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Roadhouse Country",
                    CurrentSales = rand(),PreviousSales = rand()
                 } }
            }, new TreeMapNodeItem {
                Type= "Rock",
                Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Hard Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                }, new TreeMapNodeItem {
                    Type= "Blues Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Funk Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Rap Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Guitar Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Progressive Rock",
                    CurrentSales = rand(),PreviousSales = rand()
                 } }
            }, new TreeMapNodeItem {
                Type= "Classical",
                Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Symphonies",
                    CurrentSales = rand(),PreviousSales = rand()
                    }, new TreeMapNodeItem {
                    Type= "Chamber Music",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Soundtracks",
        Items = new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Movie Soundtracks",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Musical Soundtracks",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Jazz",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Smooth Jazz",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Vocal Jazz",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Jazz Fusion",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Swing Jazz",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Cool Jazz",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Traditional Jazz",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Electronic",
        Items = new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Electronica",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Disco",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "House",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      } }
    }, new TreeMapNodeItem {
            Type= "Video",
      Items = new TreeMapNodeItem [] { new TreeMapNodeItem {
                Type= "Movie",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Kid & Family",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Action & Adventure",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Animation",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Comedy",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Drama",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Romance",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "TV",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Science Fiction",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Documentary",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Fantasy",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Military & War",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Horror",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      } }
    }, new TreeMapNodeItem {
            Type= "Books",
      Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                Type= "Arts & Photography",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Architecture",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Graphic Design",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Drawing",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Photography",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Performing Arts",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Children's Books",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Beginning Readers",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Board Books",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Chapter Books",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Coloring Books",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Picture Books",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Sound Books",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "History",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Ancient",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Medieval",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Renaissance",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Mystery",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Mystery",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Thriller & Suspense",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Romance",
        Items= new TreeMapNodeItem [] {  new TreeMapNodeItem {
                    Type= "Action & Adventure",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Holidays",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Romantic Comedy",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Romantic Suspense",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Western",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Historical",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Sci-Fi & Fantasy",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Fantasy",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Gaming",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Science Fiction",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      } }
    }, new TreeMapNodeItem {
            Type= "Electronics",
      Items= new TreeMapNodeItem  [] { new TreeMapNodeItem {
                Type= "Camera",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Digital Cameras",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Film Photography",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Lenses",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Video",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Accessories",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Headphones",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Earbud headphones",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Over-ear headphones",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "On-ear headphones",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Bluetooth headphones",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Noise-cancelling headphones",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Audiophile headphones",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Cell Phones",
        Items= new TreeMapNodeItem  [] { new TreeMapNodeItem {
                    Type= "Cell Phones",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Accessories",
          Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                        Type= "Batteries",
            CurrentSales = rand(),PreviousSales = rand()
          }, new TreeMapNodeItem {
                        Type= "Bluetooth Headsets",
            CurrentSales = rand(),PreviousSales = rand()
                     }, new TreeMapNodeItem {
                        Type= "Bluetooth Speakers",
            CurrentSales = rand(),PreviousSales = rand()
                     }, new TreeMapNodeItem {
                        Type= "Chargers",
            CurrentSales = rand(),PreviousSales = rand()
                     }, new TreeMapNodeItem {
                        Type= "Screen Protectors",
            CurrentSales = rand(),PreviousSales = rand()
                     } }
        } }
      }, new TreeMapNodeItem {
                Type= "Wearable Technology",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "Activity Trackers",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Smart Watches",
          CurrentSales = rand(),PreviousSales = rand()
                 },  new TreeMapNodeItem {
                    Type= "Sports & GPS Watches",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Virtual Reality Headsets",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Wearable Cameras",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Smart Glasses",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      } }
    }, new TreeMapNodeItem {
            Type= "Computers & Tablets",
      Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                Type= "Desktops",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "All-in-ones",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Minis",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Towers",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Laptops",
        Items = new TreeMapNodeItem [] { new TreeMapNodeItem  {
                    Type= "2 in 1 laptops",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Traditional laptops",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      }, new TreeMapNodeItem {
                Type= "Tablets",
        Items= new TreeMapNodeItem [] { new TreeMapNodeItem {
                    Type= "iOS",
          CurrentSales = rand(),PreviousSales = rand()
        }, new TreeMapNodeItem {
                    Type= "Andriod",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Fire os",
          CurrentSales = rand(),PreviousSales = rand()
                 }, new TreeMapNodeItem {
                    Type= "Windows",
          CurrentSales = rand(),PreviousSales = rand()
                 } }
      } }
    } };
            return data;
        }

        public static List<Product> GetProducts()
        {
            var data = _dataHelper.Products;
            foreach (Product cat in data)
            {
                foreach (Product subCat in cat.Items)
                {
                    foreach (Product item in subCat.Items)
                    {
                        item.Orders = rnd.Next(1000, 10000);
                    }
                }
            }
            return data;
        }

        public static List<HierarchicalDataItem> GetSunburstData()
        {
            List<string> years = new List<string>();
            List<List<string>> times = new List<List<string>>()
            {
                new List<string>() { "Jan", "Feb", "Mar"},
                new List<string>() { "Apr", "May", "June"},
                new List<string>() { "Jul", "Aug", "Sep"},
                new List<string>() { "Oct", "Nov", "Dec" }
            };

            List<HierarchicalDataItem> items = new List<HierarchicalDataItem>();
            var yearLen = Math.Max((int)Math.Round(Math.Abs(5 - rnd.NextDouble() * 10)), 3);
            int currentYear = DateTime.Now.Year;
            for (int i = yearLen; i > 0; i--)
            {
                years.Add((currentYear - i).ToString());
            }
            var quarterAdded = false;

            years.ForEach(y =>
            {
                var i = years.IndexOf(y);
                var addQuarter = rnd.NextDouble() > 0.5;
                if (!quarterAdded && i == years.Count - 1)
                {
                    addQuarter = true;
                }
                var year = new HierarchicalDataItem() { Year = y };
                if (addQuarter)
                {
                    quarterAdded = true;
                    times.ForEach(q =>
                    {
                        var addMonth = rnd.NextDouble() > 0.5;
                        int idx = times.IndexOf(q);
                        var quar = "Q" + (idx + 1);
                        var quarters = new HierarchicalDataItem() { Year = y, Quarter = quar };
                        if (addMonth)
                        {
                            q.ForEach(m =>
                            {
                                quarters.Items.Add(new HierarchicalDataItem()
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
                items.Add(year);
            });

            return items;
        }

        public static CountryGDP[] GetFlatOrHierarchicalGDPData(bool isFlat)
        {
            if (isFlat)
            {
                return new CountryGDP[]
                {
                    new CountryGDP("US", "America", 19362, 19362),
                    new CountryGDP("China", "Asia", 11938, 23122),
                    new CountryGDP("Japan", "Asia", 4884, 5405),
                    new CountryGDP("Germany", "Europe", 3652, 4150),
                    new CountryGDP("France", "Europe", 2575, 2826),
                    new CountryGDP("UK", "Europe", 2565, 2880),
                    new CountryGDP("India", "Asia", 2439, 9447),
                    new CountryGDP("Brazil", "America", 2081, 3219),
                    new CountryGDP("Italy", "Europe", 1921, 2307),
                    new CountryGDP("Canada", "America", 1640, 1764),
                };
            }
            else
            {
                return new CountryGDP[]
                {
                    new CountryGDP { Continent = "Asia",
                    Items = new CountryGDP[] {
                        new CountryGDP{Country= "China", CurrentPrices=11938, PPPValuation=23122},
                        new CountryGDP{Country= "Japan", CurrentPrices=4884, PPPValuation=5405},
                        new CountryGDP{Country= "India", CurrentPrices=2439, PPPValuation=9447}
                    }
                },
                new CountryGDP { Continent = "America",
                    Items = new CountryGDP[] {
                        new CountryGDP {Country= "US", CurrentPrices=19362, PPPValuation=19362},
                        new CountryGDP{Country= "Brazil", CurrentPrices=2081, PPPValuation=3219},
                        new CountryGDP{Country= "Canada", CurrentPrices=1640, PPPValuation=1764}
                    }
                },
                new CountryGDP { Continent = "Europe",
                    Items = new CountryGDP[] {
                        new CountryGDP{Country= "Germany", CurrentPrices=3652, PPPValuation=4150},
                        new CountryGDP{Country= "France", CurrentPrices=2575, PPPValuation=2826},
                        new CountryGDP{Country= "UK", CurrentPrices=2565, PPPValuation=2880},
                        new CountryGDP{Country= "Italy", CurrentPrices=1921, PPPValuation=2307}
                    }
                }
                };
            }
        }

        public static HierarchicalDataItem[] GetHierarchicalDataItems()
        {
            Queue<HierarchicalDataItem> data = new Queue<HierarchicalDataItem>();

            for (int i = 0; i < 240; i++)
            {
                int month = ((i % 12) + 1);
                int q = (month / 3) + ((month % 3) == 0 ? 0 : 1);
                int year = (1997 + (i / 12));

                data.Enqueue(new HierarchicalDataItem()
                {
                    Year = year.ToString(),
                    Month = month.ToString(),
                    Quarter = q.ToString(),
                    Value = rnd.Next(500),
                });
            }

            return data.ToArray();
        }
        public static List<FlatDataItem> GetFlatDataItems(int count)
        {
            List<FlatDataItem> data = new List<FlatDataItem>();
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
                data.Add(new FlatDataItem()
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
        static IEnumerable<FlatDataItem> _rawData;
        public static IEnumerable<CategoricalPoint> GetGroupedData(string currentPath, object currentPathValue = null, string newPath = null)
        {
            if (_rawData == null)
            {
                _rawData = GetFlatDataItems(5000);
            }

            var initialDataSource = _rawData;
            var summarizedData = new List<CategoricalPoint>();
            if (currentPathValue != null && newPath != null)
            {
                Thread.Sleep(5000);

                summarizedData = initialDataSource
                     .Where(p => GetProperty(p, currentPath).Equals(currentPathValue))
                     .GroupBy(p1 => GetProperty(p1, newPath))
                     .Select(p2 =>
                        new CategoricalPoint
                        {
                            Name = p2.Key.ToString(),
                            Value = p2.Sum(k => k.Amount)
                        }).OrderBy(x => x.Name).ToList();
                if (currentPath == "Year")
                {
                    var mNames = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
                    summarizedData = summarizedData.OrderBy(x => mNames.IndexOf(x.Name)).ToList();
                }
                if (currentPath == "Month")
                {
                    summarizedData = summarizedData.OrderBy(x => Int32.Parse(x.Name)).ToList();
                }
            }
            else
            {
                summarizedData = initialDataSource
                    .GroupBy(p => GetProperty(p, currentPath))
                    .Select(p =>
                        new CategoricalPoint
                        {
                            Name = p.Key.ToString(),
                            Value = p.Sum(k => k.Amount)
                        }).OrderBy(x => x.Name).ToList();
            }
            return summarizedData;
        }

        private static object GetProperty(object obj, string path)
        {
            return obj.GetType().GetProperty(path).GetValue(obj, null);
        }
    }
}
