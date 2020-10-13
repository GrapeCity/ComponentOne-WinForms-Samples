using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Input
{
    public partial class CustomDropDowns : C1DemoForm
    {
        public CustomDropDowns()
        {
            InitializeComponent();
        }

        private void CustomDropDowns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Categories' table.
            this.categoriesTableAdapter.Fill(this.c1DemoDataSet.Categories);
        }

    }
}
