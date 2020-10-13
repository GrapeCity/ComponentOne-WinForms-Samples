using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TrueDBGrid
{
    public partial class ChildGrids : C1DemoForm
    {
        public ChildGrids()
        {
            InitializeComponent();
        }

        private void ChildGrids_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.c1DemoDataSet.Order_Details);
            // TODO: This line of code loads data into the 'c1DemoDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.c1DemoDataSet.Orders);
            // TODO: This line of code loads data into the 'c1DemoDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.c1DemoDataSet.Customers);


        }

    }
}
