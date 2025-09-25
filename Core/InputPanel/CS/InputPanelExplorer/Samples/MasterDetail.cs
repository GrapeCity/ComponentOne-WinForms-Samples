using System;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    public partial class MasterDetail : UserControl
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
