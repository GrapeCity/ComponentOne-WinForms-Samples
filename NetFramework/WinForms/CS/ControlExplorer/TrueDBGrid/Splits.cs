using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TrueDBGrid
{
    public partial class Splits : C1DemoForm
    {
        public Splits()
        {
            InitializeComponent();
        }

        private void Splits_Load(object sender, EventArgs e)
        {
            c1TrueDBGrid1.DataSource = DemoDataSource("Customers");

            // add demo properties
            AddProperty("AllowHorizontalSplit", c1TrueDBGrid1);
            AddProperty("AllowVerticalSplit", c1TrueDBGrid1);
            AddProperty("SpringMode", c1TrueDBGrid1);
            AddProperty("TabAcrossSplits", c1TrueDBGrid1);
        }
    }
}
