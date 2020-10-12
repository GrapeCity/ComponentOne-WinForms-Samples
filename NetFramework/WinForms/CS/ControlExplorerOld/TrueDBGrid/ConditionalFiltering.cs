using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TrueDBGrid
{
    public partial class ConditionalFiltering : C1DemoForm
    {
        public ConditionalFiltering()
        {
            InitializeComponent();
        }

        private void ConditionalFiltering_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'c1DemoDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1DemoDataSet.Products);
        }
    }
}
