using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.InputPanel
{
    public partial class MasterDetail : C1DemoForm
    {
        public MasterDetail()
        {
            InitializeComponent();
        }

        private void MasterDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Products' table.
            this.productsTableAdapter.Fill(this.c1DemoDataSet.Products);
            // TODO: This line of code loads data into the 'c1DemoDataSet.Categories' table.
            this.categoriesTableAdapter.Fill(this.c1DemoDataSet.Categories);
        }
    }
}
