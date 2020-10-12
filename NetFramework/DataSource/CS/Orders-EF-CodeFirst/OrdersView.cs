using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.LiveLinq.LiveViews;
using C1.Data;
using C1.Data.DataSource;
using C1.Data.Entities;
using C1.WPF.LiveLinq;

namespace Orders
{
    public partial class OrdersView : UserControl
    {
        // The tab page containing this user control
        public TabPage TabPage;

        // These two classes are used as the result item types of the two live views defined below.
        public class OrderInfo
        {
            public virtual Order Order { get; set; }
            public virtual int OrderID { get; set; }
            public virtual DateTime? OrderDate { get; set; }
            public virtual string CustomerName { get; set; }
            public virtual decimal TotalCost { get; set; }
            public virtual View<Order_Detail> OrderDetails { get; set; }
        }

        public class OrderDetailInfo
        {
            public virtual int ProductID { get; set; }
            public virtual string ProductName { get; set; }
            public virtual int Quantity { get; set; }
            public virtual decimal UnitPrice { get; set; }
            public virtual float Discount { get; set; }
            public virtual decimal TotalCost { get; set; }
        }

        C1.LiveLinq.LiveViews.View _ordersView;
        C1.LiveLinq.LiveViews.View _orderDetailsView;


        public OrdersView()
        {
            InitializeComponent();

            comboBox1.DataSource = ((NORTHWNDEntities)c1DataSource1.ClientCache.DbContext).Cities.ToList();

            // Define and bind a live view on top of the Orders EntityViewSource 
            // sorted by the total cost in descending order.
            bindingSource1.DataSource = _ordersView =
                from o in c1DataSource1["Orders"].AsLive<Order>()
                // Order cost is the sum of order detail costs.
                let totalCost = o.Order_Details.Sum(od => od.Quantity * od.UnitPrice * (1m - (decimal)od.Discount))
                orderby totalCost descending
                select new OrderInfo()
                {
                    Order = o,
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    CustomerName = o.Customer.CompanyName,
                    TotalCost = totalCost,
                    OrderDetails = o.Order_Details.AsLive()
                };            

            dataGridView1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Remove the tab page on Close button click
            if (TabPage != null)
                ((TabControl)TabPage.Parent).TabPages.Remove(TabPage);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the Order filter, display the orders of customers in the selected city.
            if (comboBox1.SelectedIndex != -1)
            {
                // Update the filter value.
                c1DataSource1.ViewSources["Orders"].FilterDescriptors[0].Value = comboBox1.SelectedValue;
                // Manually reload the EntityViewSource because auto-loading is turned off (AutoLoad=False).
                c1DataSource1.ViewSources["Orders"].Load();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
                return;

            // Rebind the data grid, display the order details of the selected order.
            // If the "checkBox1" check box is checked, show only the order details for discontinued products.
            OrderInfo oi = (bindingSource1.Current as ViewRow).Value as OrderInfo;
            dataGridView2.DataSource = _orderDetailsView =
                from od in oi.OrderDetails
                where !checkBox1.Checked || od.Product.Discontinued
                select new OrderDetailInfo()
                {
                    ProductID = od.ProductID,
                    ProductName = od.Product.ProductName,
                    Quantity = od.Quantity,
                    UnitPrice = od.UnitPrice,
                    Discount = od.Discount,
                    TotalCost = od.Quantity * od.UnitPrice * (1m - (decimal)od.Discount)
                };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Rebuild the order detail view to reapply filtering.
            _orderDetailsView.Rebuild();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Add a new Order.
            int pos = bindingSource1.Position;
            if (pos < 0 || pos >= c1DataSource1["Orders"].Count)
            {
                // The user must select an Order to create a new one.
                MessageBox.Show("Must be positioned on an order to be able to create a new one");
                return;
            }
            Order order = c1DataSource1["Orders"][pos] as Order;
            var newOrder = new Order();
            // Assign the new Order to the Customer of the currently selected Order.
            newOrder.Customer = order.Customer;
            newOrder.OrderID = 99999;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Remove the selected Order.
            bindingSource1.RemoveCurrent();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // Do not show the original Order object column in the order data grid.
            if (e.Column.Name == "Order")
                e.Column.Visible = false;
        }
    }
}
