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
    public partial class FilterBar : C1DemoForm
    {
        C1DataColumn titleColumn;
        public FilterBar()
        {
            InitializeComponent();
            titleColumn = c1TrueDBGrid1.Columns["ContactTitle"];
            
        }

        private void FilterBar_Load(object sender, EventArgs e)
        {
            c1TrueDBGrid1.SetDataBinding(DemoDataSource("Customers"), "", true);

            // add demo properties
            AddPropertyHeader("Contact Title Column");
            AddProperty("FilterMultiSelect", titleColumn);
        }
    }
}
