using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorialsWinFormsC1FlexGrid
{
    using C1.Data.Entities;
    using C1.Data;
    using C1.LiveLinq;
    using C1.LiveLinq.LiveViews;

    public partial class ClientSideQuerying : Form
    {
        // This client scope will be used to load the data.
        private EntityClientScope _scope = Program.ClientCache.CreateScope();
        private ClientView<Product> _seafoodProductsView;
        private View<dynamic> _viewProducts;

        public ClientSideQuerying()
        {
            InitializeComponent();

            // Define and bind a live view of expensive non-discontinued products ordered by price.
            _viewProducts =
                (from p in _scope.GetItems<Product>()
                 where !p.Discontinued && p.UnitPrice >= 30
                 orderby p.UnitPrice
                 select new
                 {
                     p.ProductID,
                     p.ProductName,
                     p.CategoryID,
                     p.Category.CategoryName,
                     p.SupplierID,
                     Supplier = p.Supplier.CompanyName,
                     p.UnitPrice,
                     p.QuantityPerUnit,
                     p.UnitsInStock,
                     p.UnitsOnOrder
                 }).AsDynamic(); // AsDynamic() is required for data binding because an anonymous class is used (select new ...)

            c1FlexGrid1.DataSource = _viewProducts;
        
            // Define a view of seafood products. Filtering is performed on the server.
            _seafoodProductsView = _scope.GetItems<Product>().AsFiltered(p => p.CategoryID == 8);

            // Bind the label text to the number of products in the view
            labelCount.DataBindings.Add(new Binding("Text", _viewProducts.LiveCount(), "Value"));
        }

        private void raiseButton_Click(object sender, EventArgs e)
        {
            // Increase the price of the seafood products.
            // The data grid contents will be updated automatically.
            foreach (var p in _seafoodProductsView)
                p.UnitPrice *= 1.2m;
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            // Decrease the price of the seafood products.
            // The data grid contents will be updated automatically.
            foreach (var p in _seafoodProductsView)
                p.UnitPrice /= 1.2m;
        }
    }
}
