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
    public partial class CategoryProductsView : Form
    {
        CategoryProductsViewModel viewModel = new CategoryProductsViewModel();

        public CategoryProductsView()
        {
            InitializeComponent();

            // Connect this view to the view model.
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = viewModel.Categories;
            dataGridView1.DataSource = viewModel.Products;
        }
    }
}
