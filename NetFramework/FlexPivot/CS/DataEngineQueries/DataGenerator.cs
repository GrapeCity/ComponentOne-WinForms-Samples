using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.DataEngine;
using System.IO;
using System.Globalization;

namespace Utils
{
    public class DataGenerator
    {
        // genarates a random integer value
        internal static int GenerateInt(int index, int minValue, int maxValue, Random r)
        {
            if (r == null)
                return index;
            return r.Next(minValue, maxValue);
        }

        // generates a random short value
        internal static short GenerateShort(int minValue, int maxValue, Random r)
        {
            return (short)r.Next(minValue, maxValue);
        }

        // generates a random double value
        internal static double GenerateDouble(int minValue, int maxValue, Random r)
        {
            return (double)r.Next(minValue, maxValue) / 100;
        }

        // generates a random float value
        internal static float GenerateFloat(int minValue, int maxValue, Random r)
        {
            return (float)r.Next(minValue, maxValue) / 100;
        }

        // generates a random date
        internal static DateTime GenerateDate(DateTime minValue, DateTime maxValue, Random r)
        {
            return new DateTime(LongRandom(minValue.Ticks, maxValue.Ticks, r));
        }

        // generates a random shifted date from the specific date
        internal static DateTime GenerateShiftedDate(DateTime baseDate, int minShiftDays, int maxShiftDays, Random r)
        {
            long tiksPerDay = 10000L * 1000 * 60 * 60 * 24;
            long minTicks = minShiftDays * tiksPerDay;
            long maxTicks = maxShiftDays * tiksPerDay;
            return new DateTime(baseDate.Ticks + LongRandom(minTicks, maxTicks, r));
        }

        // ganarates a random long value
        private static long LongRandom(long min, long max, Random r)
        {
            byte[] buf = new byte[8];
            r.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }

        // generates a random string value from the specific string list
        internal static string GenerateString(List<string> data, Random r)
        {
            int minIndex = 0;
            int maxIndex = data.Count - 1;
            int idx = r.Next(minIndex, maxIndex);
            return data[idx];
        }

        // gets a list of all countries
        public static List<string> GetCountries()
        {
            List<string> countries = new List<string>();
            CultureInfo[] cis = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo ci in cis)
            {
                RegionInfo ri = new RegionInfo(ci.LCID);
                if (!countries.Contains(ri.EnglishName))
                    countries.Add(ri.EnglishName);
            }
            return countries;
        }

        // gets a list of random names
        public static List<string> GetUserNames()
        {
            string line;
            List<string> names = new List<string>();
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\FakeNameGenerator.com_dc989f6c.csv");
            StreamReader reader = new StreamReader(dataPath);
            while ((line = reader.ReadLine()) != null)
                names.Add(line.Replace(',', ' '));
            return names;
        }
    }

    // OrderDetails table
    public class OrderDetails
    {
        public static string Name { get { return "order_details"; } }

        // generates C1.DataEngine table
        public static void Generate(Workspace workspace, int totalRows, int maxOrders, int maxProducts, int maxQuantity, int maxUnitPrices, int maxDiscounts)
        {
            var list = Item.GenerateList(totalRows, maxOrders, maxProducts, maxQuantity, maxUnitPrices, maxDiscounts);
            var connector = new C1.DataEngine.ObjectConnector<Item>(workspace, list);
            connector.GetData(Name);
        }

        // table row
        private class Item
        {
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public short Quantity { get; set; }
            public double UnitPrice { get; set; }
            public float Discount { get; set; }

            // generates a list of rows with random data
            public static IEnumerable<Item> GenerateList(int totalRows, int maxOrders, int maxProducts, int maxQuantity, int maxUnitPrices, int maxDiscounts)
            {
                Random r = new Random();
                if (totalRows == 0)
                    totalRows = r.Next();
                if (maxOrders == 0 && maxProducts == 0)
                    maxProducts = r.Next(20, 1000);
                if (maxOrders == 0)
                    maxOrders = totalRows / maxProducts;
                else
                    maxProducts = totalRows / maxOrders;
                if (maxQuantity == 0)
                    maxQuantity = r.Next(totalRows);
                if (maxUnitPrices == 0)
                    maxUnitPrices = r.Next(totalRows);
                if (maxDiscounts == 0)
                    maxDiscounts = r.Next(totalRows);
                for (int i = 0; i < totalRows; i++)
                {
                    var item = new Item();
                    item.OrderID = DataGenerator.GenerateInt(i, 0, maxOrders, r);
                    item.ProductID = DataGenerator.GenerateInt(i, 0, maxProducts, r);
                    item.Quantity = DataGenerator.GenerateShort(1, maxQuantity, r);
                    item.UnitPrice = DataGenerator.GenerateDouble(100, 100 + maxUnitPrices, r);
                    item.Discount = DataGenerator.GenerateFloat(0, maxDiscounts, r);
                    yield return item;
                }
            }
        }
    }

    // Products table
    public class Products
    {
        public static string Name { get { return "products"; } }

        // generates C1.DataEngine table
        public static void Generate(Workspace workspace, int totalRows, int maxUnitsInStock, int maxUnitsOnOrder)
        {
            var list = Item.GenerateList(totalRows, maxUnitsInStock, maxUnitsOnOrder);
            var connector = new C1.DataEngine.ObjectConnector<Item>(workspace, list);
            connector.GetData(Name);
        }

        // table row
        private class Item
        {
            public int ProductID { get; set; }
            public short UnitsInStock { get; set; }
            public short UnitsOnOrder { get; set; }

            // generates a list of rows with random data
            public static IEnumerable<Item> GenerateList(int totalRows, int maxUnitsInStock, int maxUnitsOnOrder)
            {
                Random r = new Random();
                if (totalRows == 0)
                    totalRows = r.Next();
                if (maxUnitsInStock == 0)
                    maxUnitsInStock = r.Next(totalRows);
                if (maxUnitsOnOrder == 0)
                    maxUnitsOnOrder = r.Next(totalRows);
                for (int i = 0; i < totalRows; i++)
                {
                    var item = new Item();
                    item.ProductID = DataGenerator.GenerateInt(i, 0, totalRows, null);
                    item.UnitsInStock = DataGenerator.GenerateShort(1, maxUnitsInStock, r);
                    item.UnitsOnOrder = DataGenerator.GenerateShort(1, maxUnitsOnOrder, r);
                    yield return item;
                }
            }
        }
    }

    // Orders table
    public class Orders
    {
        public static string Name { get { return "orders"; } }

        // generates C1.DataEngine table
        public static void Generate(Workspace workspace, int totalRows, DateTime minOrderDate, DateTime maxOrderDate, int minShippedDays, int maxShippedDays)
        {
            var list = Item.GenerateList(totalRows, minOrderDate, maxOrderDate, minShippedDays, maxShippedDays);
            var connector = new C1.DataEngine.ObjectConnector<Item>(workspace, list);
            connector.GetData(Name);
        }

        // table row
        private class Item
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime ShippedDate { get; set; }
            public string ShipName { get; set; }
            public string ShipCountry { get; set; }

            // generates a list of rows with random data
            public static IEnumerable<Item> GenerateList(int totalRows, DateTime minOrderDate, DateTime maxOrderDate, int minShippedDays, int maxShippedDays)
            {
                Random r = new Random();
                if (totalRows == 0)
                    totalRows = r.Next();
                if (minShippedDays == 0)
                    minShippedDays = 1;
                if (maxShippedDays == 0)
                    maxShippedDays = r.Next(minShippedDays, totalRows);
                var names = DataGenerator.GetUserNames();
                var countries = DataGenerator.GetCountries();
                for (int i = 0; i < totalRows; i++)
                {
                    var item = new Item();
                    item.OrderID = DataGenerator.GenerateInt(i, 0, totalRows, r);
                    item.OrderDate = DataGenerator.GenerateDate(minOrderDate, maxOrderDate, r);
                    item.ShippedDate = DataGenerator.GenerateShiftedDate(item.OrderDate, minShippedDays, maxShippedDays, r);
                    item.ShipName = DataGenerator.GenerateString(names, r);
                    item.ShipCountry = DataGenerator.GenerateString(countries, r);
                    yield return item;
                }
            }
        }
    }
}
