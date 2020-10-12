using System;
using System.ComponentModel;

namespace ControlExplorer.TreeView
{
    public class ProductType
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public BindingList<Company> Companies { get; set; }

        public ProductType(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
            Companies = new BindingList<Company>();
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
