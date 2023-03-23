using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorialsWinForms
{
    using C1.Data.Entities;
    using C1.Data;

    public partial class DataSourcesInCode : Form
    {
        // This client scope will be used to load the data.
        private EntityClientScope _scope = Program.ClientCache.CreateScope();

        public DataSourcesInCode()
        {
            InitializeComponent();

            // Bind the category combo box to the category view
            // and show the products of the first category in the data grid.

            ClientView<Category> viewCategories = _scope.GetItems<Category>();

            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = viewCategories;

            BindGrid(viewCategories.First().CategoryID);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Rebind the data grid, display the products of the selected category.
            if (comboBox1.SelectedValue != null)
                BindGrid((int)comboBox1.SelectedValue);
        }

        private void BindGrid(int categoryID)
        {
            // Filter products by CategoryID on the server
            // and bind them to the data grid.
            dataGridView1.DataSource =
                (from p in _scope.GetItems<Product>().AsFiltered(p => p.CategoryID == categoryID)
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
                 }).AsDynamic(); // AsDynamic() is required for data binding because an anonymous class is used (select new...)
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Program.ClientCache.SaveChanges();
        }
    }
}
