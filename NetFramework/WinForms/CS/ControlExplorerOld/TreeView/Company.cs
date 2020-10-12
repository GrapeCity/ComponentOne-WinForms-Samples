using System;
using System.ComponentModel;

namespace ControlExplorer.TreeView
{
    public class Company
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public BindingList<Product> Products { get; set; }        
        public int CountOfProducts
        {
            get { return Products.Count; }
        }

        public Company(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
            Products = new BindingList<Product>();
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
