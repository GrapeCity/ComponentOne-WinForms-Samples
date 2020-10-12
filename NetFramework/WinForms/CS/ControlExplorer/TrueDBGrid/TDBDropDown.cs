using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1TrueDBGrid;

namespace ControlExplorer.TrueDBGrid
{
    public partial class TDBDropDown : C1DemoForm
    {
        public TDBDropDown()
        {
            InitializeComponent();
        }

        private void TDBDropDown_Load(object sender, EventArgs e)
        {
            c1TrueDBGrid1.SetDataBinding(DemoDataSource("Orders"), "", true);
            c1TrueDBDropdown1.SetDataBinding(DemoDataSource("Customers"), "", true);
            c1TrueDBDropdown2.SetDataBinding(DemoDataSource("Employees"), "", true);

            // add demo properties
            AddPropertyHeader("Customer column:");
            AddProperty("AllowSizing", c1TrueDBDropdown1);

            AddPropertySeparator();
            AddPropertyHeader("Employee column:");
            AddProperty("AllowSizing", c1TrueDBDropdown2);
        }
    }
}
