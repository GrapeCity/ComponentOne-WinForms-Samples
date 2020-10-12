using System;

namespace SamplesData
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }        

        public Product(string name, double price)
        {
            ID = Guid.NewGuid();
            Name = name;
            Price = price;
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
