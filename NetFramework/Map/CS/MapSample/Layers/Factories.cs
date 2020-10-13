using System;
using System.Collections.Generic;

namespace MapSample.Layers
{
    public class Entity
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Office : Entity
    {
        public string Manager { get; set; }
        public int Stores { get; set; }
    }

    public class Factory : Entity
    {
        public double Capacity { get; set; }
    }

    public class Store : Entity
    {
        public List<ProductSale> Sales { get; set; }
    }

    public class ProductSale
    {
        public Product Product { get; set; }
        public int Sales { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
    }

    public class DataBase
    {
        public List<Factory> Factories { get; set; }
        public List<Office> Offices { get; set; }
        public List<Store> Stores { get; set; }
        public double OfficeStoreDistance { get; set; }

        public DataBase()
        {
            Factories = new List<Factory>();
            Offices = new List<Office>();
            Stores = new List<Store>();
            OfficeStoreDistance = 100000;
        }
    }
}
