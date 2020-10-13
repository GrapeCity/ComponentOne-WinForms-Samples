using System;
using System.ComponentModel;

namespace SamplesData
{
    public class Store
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public BindingList<ProductsGroup> ProductsGroups { get; set; }
        public int CountOfProducts
        {
            get
            {
                int count = 0;
                foreach (var pg in ProductsGroups)
                    count += pg.CountOfProducts;
                return count;
            }
        }

        public Store(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
            ProductsGroups = new BindingList<ProductsGroup>();
        }

        /// <summary>
        /// Returns string representation.
        /// </summary>
        public override string ToString()
        {
            return Name;
        }        
    }
}
