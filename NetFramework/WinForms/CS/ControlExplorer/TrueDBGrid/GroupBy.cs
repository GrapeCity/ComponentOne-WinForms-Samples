using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TrueDBGrid
{
    public partial class GroupBy : C1DemoForm
    {
        public GroupBy()
        {
            InitializeComponent();    
        }

        private void GroupBy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.c1DemoDataSet.Invoices);

            // add demo properties
            AddProperty("GroupByAreaVisible", c1TrueDBGrid1);
        }
    }
}
