using System;

namespace ControlExplorer.TreeView
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }        

        public Product(string name, int quantity, double price)
        {
            ID = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
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
