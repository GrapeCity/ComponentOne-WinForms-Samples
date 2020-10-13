using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RulesManagerExplorer.Samples
{
    public static class DataSources
    {
        private class Products
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int SupplierID { get; set; }
            public int CategoryID { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal UnitsInStock { get; set; }
            public decimal UnitsOnOrder { get; set; }
            public int ReorderLevel { get; set; }
            public int Discontinued { get; set; }
        }

        public static DataTable GetDataSource()
        {
            var items = new List<Products>()
            {
                new Products()
                {
                    ProductID = 2,
                    ProductName = "Chang",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 19.00m,
                    UnitsInStock = 17m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 3,
                    ProductName = "Aniseed Syrup",
                    SupplierID = 1,
                    CategoryID = 2,
                    QuantityPerUnit = "12 - 550 ml bottles",
                    UnitPrice = 10.00m,
                    UnitsInStock = 13m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 11,
                    ProductName = "Queso Cabrales",
                    SupplierID = 5,
                    CategoryID = 4,
                    QuantityPerUnit = "1 kg pkg.",
                    UnitPrice = 21.00m,
                    UnitsInStock = 22m,
                    UnitsOnOrder = 30m,
                    ReorderLevel = 30,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 21,
                    ProductName = "Sir Rodney's Scones",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "24 pkgs. x 4 pieces",
                    UnitPrice = 10.00m,
                    UnitsInStock = 3m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 5,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 32,
                    ProductName = "Mascarpone Fabioli",
                    SupplierID = 14,
                    CategoryID = 4,
                    QuantityPerUnit = "24 - 200 g pkgs.",
                    UnitPrice = 32.00m,
                    UnitsInStock = 9m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 37,
                    ProductName = "Gravad lax",
                    SupplierID = 17,
                    CategoryID = 8,
                    QuantityPerUnit = "12 - 500 g pkgs.",
                    UnitPrice = 26.00m,
                    UnitsInStock = 11m,
                    UnitsOnOrder = 50m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 43,
                    ProductName = "Ipoh Coffee",
                    SupplierID = 20,
                    CategoryID = 1,
                    QuantityPerUnit = "16 - 500 g tins",
                    UnitPrice = 46.00m,
                    UnitsInStock = 17m,
                    UnitsOnOrder = 10m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 45,
                    ProductName = "Rogede sild",
                    SupplierID = 21,
                    CategoryID = 8,
                    QuantityPerUnit = "1k pkg.",
                    UnitPrice = 9.50m,
                    UnitsInStock = 5m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 15,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 48,
                    ProductName = "Chocolade",
                    SupplierID = 22,
                    CategoryID = 3,
                    QuantityPerUnit = "10 pkgs.",
                    UnitPrice = 12.75m,
                    UnitsInStock = 15m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 49,
                    ProductName = "Maxilaku",
                    SupplierID = 23,
                    CategoryID = 3,
                    QuantityPerUnit = "24 - 50 g pkgs.",
                    UnitPrice = 20.00m,
                    UnitsInStock = 10m,
                    UnitsOnOrder = 60m,
                    ReorderLevel = 15,
                    Discontinued = 0
                }
            };
            var table = new DataTable("Products");

            var properties = typeof(Products).GetProperties()
                .Where(x => x.MemberType == System.Reflection.MemberTypes.Property)
                .Select(x => new { Name = x.Name, DeclaringType = x.PropertyType });
            var columns = properties.Select(x => new DataColumn(x.Name, x.DeclaringType));
            table.Columns.AddRange(columns.ToArray());

            // Add data to DataTable
            items.ForEach(item =>
            {
                var row = table.NewRow();
                properties.ToList().ForEach(property =>
                {
                    var values = item.GetType().GetProperties()
                     .Select(x => new { Name = x.Name, Value = x.GetValue(item, new object[] { }) })
                     .ToDictionary(x => x.Name, z => z.Value);

                    row[property.Name] = values[property.Name];
                });

                table.Rows.Add(row);
            }
            );

            return table;
        }
    }
}
