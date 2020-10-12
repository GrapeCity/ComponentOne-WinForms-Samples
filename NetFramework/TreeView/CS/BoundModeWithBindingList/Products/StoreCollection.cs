using System.ComponentModel;

namespace SamplesData
{
    public class StoreCollection: BindingList<Store>
    {
        public static StoreCollection GetData()
        {
            var stores = new StoreCollection();

            stores.Add(new Store("Pear Inc."));
            stores[0].ProductsGroups.Add(new ProductsGroup("Mobile phones"));
            stores[0].ProductsGroups[0].Products.Add(new Product("fPhone 34", 999.99));
            stores[0].ProductsGroups[0].Products.Add(new Product("fPhone 34Z", 9999.99));
            stores[0].ProductsGroups[0].Products.Add(new Product("fPhone 34XX", 100000));
            stores[0].ProductsGroups.Add(new ProductsGroup("Notebooks"));
            stores[0].ProductsGroups[1].Products.Add(new Product("DuckBook S", 9999.99));
            stores[0].ProductsGroups[1].Products.Add(new Product("DuckBook Ultra", 14000));
            stores[0].ProductsGroups[1].Products.Add(new Product("DuckBook Pro", 20000));
            stores[0].ProductsGroups.Add(new ProductsGroup("Computers"));
            stores[0].ProductsGroups[2].Products.Add(new Product("DuckPC 3", 10000.99));
            stores[0].ProductsGroups[2].Products.Add(new Product("DuckPro X", 15000));
            stores[0].ProductsGroups[2].Products.Add(new Product("DuckPro Ultra", 19000));

            stores.Add(new Store("Space Inc."));
            stores[1].ProductsGroups.Add(new ProductsGroup("Mobile phones"));
            stores[1].ProductsGroups[0].Products.Add(new Product("Rocket 1A", 900));
            stores[1].ProductsGroups[0].Products.Add(new Product("Rocket 2X", 3999));
            stores[1].ProductsGroups[0].Products.Add(new Product("Rocket 3E", 20000));
            stores[1].ProductsGroups.Add(new ProductsGroup("Notebooks"));
            stores[1].ProductsGroups[1].Products.Add(new Product("Shuttle 1A", 9999.99));
            stores[1].ProductsGroups[1].Products.Add(new Product("Shuttle 1X", 14000));
            stores[1].ProductsGroups[1].Products.Add(new Product("Shuttle Pro", 20000));
            stores[1].ProductsGroups.Add(new ProductsGroup("Computers"));
            stores[1].ProductsGroups[2].Products.Add(new Product("IssPC 2D", 10000.99));
            stores[1].ProductsGroups[2].Products.Add(new Product("IssPro 2X", 15000));
            stores[1].ProductsGroups[2].Products.Add(new Product("IssPro Pro", 19000));

            stores.Add(new Store("Fruit Inc."));
            stores[2].ProductsGroups.Add(new ProductsGroup("Mobile phones"));
            stores[2].ProductsGroups[0].Products.Add(new Product("Pineapple 1", 2900));
            stores[2].ProductsGroups[0].Products.Add(new Product("Mango 1", 3099));
            stores[2].ProductsGroups[0].Products.Add(new Product("Orange 1", 5000));
            stores[2].ProductsGroups.Add(new ProductsGroup("Notebooks"));
            stores[2].ProductsGroups[1].Products.Add(new Product("Mandarin X", 9999.99));
            stores[2].ProductsGroups[1].Products.Add(new Product("Lemon X", 14000));
            stores[2].ProductsGroups[1].Products.Add(new Product("Lemon Pro", 20000));
            stores[2].ProductsGroups.Add(new ProductsGroup("Computers"));
            stores[2].ProductsGroups[2].Products.Add(new Product("Plum X", 10000.99));
            stores[2].ProductsGroups[2].Products.Add(new Product("Plum Z", 15000));
            stores[2].ProductsGroups[2].Products.Add(new Product("Plum Pro", 19000));
        
            return stores;
        }
    }
}
