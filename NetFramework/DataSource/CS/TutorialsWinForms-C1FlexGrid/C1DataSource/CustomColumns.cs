using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.LiveLinq.LiveViews;

namespace TutorialsWinForms
{
    public partial class CustomColumns : Form
    {
        public CustomColumns()
        {
            InitializeComponent();

            // Define a live view with custom fields.
            // The data grid will automatically generate columns based on these fields.
            c1FlexGrid1.DataSource =
                (from p in c1DataSource1["Products"].AsLive<Product>()
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
        }
    }
}
