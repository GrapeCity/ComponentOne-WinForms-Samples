using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.LiveLinq;
using C1.LiveLinq.AdoNet;

namespace OptimizingLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare northwind DataSet
        NORTHWNDDataSet _ds = new NORTHWNDDataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            // load data into DataSet
            new NORTHWNDDataSetTableAdapters.CustomersTableAdapter().Fill(_ds.Customers);
            new NORTHWNDDataSetTableAdapters.OrdersTableAdapter().Fill(_ds.Orders);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();

            // get reference to source data
            var customers = _ds.Customers;
            var orders = _ds.Orders;

            // find all orders for the first customer
            var q =
              from o in orders
              where o.CustomerID == customers[0].CustomerID
              select o;

            // benchmark the query (execute 1000 times)
            var start = DateTime.Now;
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                foreach (var d in q)
                {
                    count++;
                }
            }

            lbxResult.Items.Add(string.Format("LiveLinq query done in {0} ms", DateTime.Now.Subtract(start).TotalMilliseconds));
        }

        private void btnFindIndexing_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();

            // get reference to source data
            var customers = _ds.Customers;
            var orders = _ds.Orders;

            // find all orders for the first customer
            var q =
              from o in orders.AsIndexed()
              where o.CustomerID.Indexed() == customers[0].CustomerID
              select o;

            // benchmark the query (execute 1000 times)
            var start = DateTime.Now;
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                foreach (var d in q)
                {
                    count++;
                }
            }

            lbxResult.Items.Add(string.Format("LiveLinq query done in {0} ms", DateTime.Now.Subtract(start).TotalMilliseconds));
        }
    }
}
