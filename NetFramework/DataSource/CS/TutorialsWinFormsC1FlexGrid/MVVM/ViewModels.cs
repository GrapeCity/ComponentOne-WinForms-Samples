using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace TutorialsWinFormsC1FlexGrid
{
    using C1.Data.Entities;

    // This file contains View Models used in the CategoryProductsView.

    // The properties of the following two view models 
    // must be virtual to make live view items modifiable.
    public class CategoryViewModel
    {
        public virtual int CategoryID { get; set; }
        public virtual string CategoryName { get; set; }
    }

    public class ProductViewModel
    {
        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int? CategoryID { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual int? SupplierID { get; set; }
        public virtual string SupplierName { get; set; }
        public virtual decimal? UnitPrice { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual short? UnitsInStock { get; set; }
        public virtual short? UnitsOnOrder { get; set; }
    }

    public class CategoryProductsViewModel
    {
        // This client scope will be used to load the data.
        private EntityClientScope _scope = Program.ClientCache.CreateScope();

        // Data grids in this view are bound to these data sources.
        public BindingSource Categories { get; private set; }
        public BindingSource Products { get; private set; }

        public CategoryProductsViewModel()
        {
            // These binding sources will be used by the CategoryProductsView
            // to display categories and products.
            Categories = new BindingSource(
                from c in _scope.GetItems<Category>()
                select new CategoryViewModel()
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName
                }, null);

            // Products are filtered by CategoryID on the server.
            // Filtering is performed automatically when the current Category changes.
            // Product suppliers are fetched along with the products.
            Products = new BindingSource(
                from p in _scope.GetItems<Product>().AsFilteredBound(p => p.CategoryID)
                    .BindFilterKey(Categories, "Current.CategoryID").Include("Supplier")
                select new ProductViewModel()
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    CategoryID = p.CategoryID,
                    CategoryName = p.Category.CategoryName,
                    SupplierID = p.SupplierID,
                    SupplierName = p.Supplier.CompanyName,
                    UnitPrice = p.UnitPrice,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder
                }, null);
        }
    }
}
