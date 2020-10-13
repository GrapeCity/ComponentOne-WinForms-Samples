using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TrueDBGrid
{
    public partial class MultipleLines : C1DemoForm
    {
        public MultipleLines()
        {
            InitializeComponent();
        }

        private void MultipleLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.c1DemoDataSet.Orders);

        }
    }
}
