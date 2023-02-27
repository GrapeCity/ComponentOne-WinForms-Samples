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
using C1.Win.Data.Entities;
using C1.WPF.LiveLinq;

namespace OrdersEFWinForms
{
    public partial class OrdersViewCountry : UserControl
    {
        // These two classes are used as the result item types of the two live views defined below.
        public class OrderInfo
        {
            public virtual int OrderID { get; set; }
            public virtual DateTime? OrderDate { get; set; }
            public virtual string CustomerName { get; set; }
            public virtual View<Order_Detail> OrderDetails { get; set; }
        }

        public class OrderDetailInfo
        {
            public virtual int ProductID { get; set; }
            public virtual string ProductName { get; set; }
            public virtual int Quantity { get; set; }
            public virtual decimal UnitPrice { get; set; }
            public virtual float Discount { get; set; }
        }

        // A paged EntityViewSource of Orders filtered by customer country.
        EntityViewSource _viewSource;

        // The tab page containing this user control
        public TabPage TabPage;

        public OrdersViewCountry()
        {
            InitializeComponent();

            // Update the displayed page index and count 
            // when they change in EntityViewSource.

            _viewSource = c1DataSource1.ViewSources["Orders"];

            _viewSource.DataView.PropertyChanged += delegate
            {
                labelPage.Text = string.Format("Page: {0}/{1}", _viewSource.DataView.PageIndex + 1, _viewSource.DataView.PageCount);
            };

            //Fill the combo box with customer countries.
            comboBox1.DataSource = ((NORTHWNDEntities)c1DataSource1.ClientCache.DbContext).Countries.ToList();

            // Define and bind a live view on top of the Orders EntityViewSource.
            bindingSource1.DataSource =
                from o in _viewSource.DataView.AsLive<Order>()
                select new OrderInfo()
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    CustomerName = o.Customer.CompanyName,
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
            // Update the Order filter, display the orders of customes in the selected country.
            if (comboBox1.SelectedIndex != -1)
            {
                // Update the filter value.
                _viewSource.FilterDescriptors[0].Value = comboBox1.SelectedValue;
                // Manually reload the EntityViewSource because auto-loading is turned off (AutoLoad=False).
                _viewSource.Load();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
                return;
            // Rebind the data grid, display the order details of the selected order.
            OrderInfo oi = (bindingSource1.Current as ViewRow).Value as OrderInfo;
            dataGridView2.DataSource =
                from od in oi.OrderDetails
                select new OrderDetailInfo()
                {
                    ProductID = od.ProductID,
                    ProductName = od.Product.ProductName,
                    Quantity = od.Quantity,
                    UnitPrice = od.UnitPrice,
                    Discount = od.Discount
                };
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _viewSource.DataView.MoveToPreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _viewSource.DataView.MoveToNextPage();
        }
    }
}
