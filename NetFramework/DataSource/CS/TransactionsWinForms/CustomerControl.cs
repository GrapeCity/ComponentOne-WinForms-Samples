using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Data.Transactions;
using C1.Data;
using C1.Data.Entities;
using C1.WPF.LiveLinq;

namespace TransactionsWinForms
{
    public partial class CustomerControl : UserControl
    {
        // The customer being edited.
        public Customer Customer { get; private set; }
        // This view contains the orders of the customer.
        C1.LiveLinq.LiveViews.View _ordersView;
        // All changes in this control are made in the scope of this transaction.
        ClientTransaction _transaction;
        EntityClientCache _cache;

        public CustomerControl()
        {
            InitializeComponent();
        }
        
        public CustomerControl(Customer customer, EntityClientCache clientCache)
        {
            InitializeComponent();
            _cache = clientCache;
            Customer = customer;

            // Define and bind a live view of orders of the current customer.
            _ordersView = from o in customer.Orders.AsLive()
                          select new OrderInfo(o)
                          {
                              OrderID = o.OrderID,
                              OrderDate = o.OrderDate,
                              Freight = o.Freight,
                              ShipName = o.ShipName,
                              ShipCity = o.ShipCity
                          };
            CreateTransaction();
            ordersGrid.DataSource = _ordersView;
        }

        // MainForm closes the tab page with this control when this event is raised.
        public event EventHandler CloseRequested = delegate { };

        void transaction_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // The Undo button is enabled if and only if there are changes made in the transaction scope.
            buttonUndo.Enabled = _transaction.HasChanges;
        }

        void CreateTransaction()
        {
            // Initialize the client transaction.
            // Specify that all changes to _ordersView are automatically considered changes made in the scope of this transaction.
            _transaction = _cache.CreateTransaction();
            _ordersView.SetTransaction(_transaction);

            // Enable/disable the Undo button when the _transaction.HasChanges property value changes.
            _transaction.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(transaction_PropertyChanged);
            buttonUndo.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (_transaction.HasChanges)
            {
                // Ask the user whether they will save or cancel the changes made by this control.
                switch (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        _transaction.Commit();
                        break;
                    case DialogResult.No:
                        _transaction.Rollback();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            // Raise the CloseRequested event, so MainForm removes the tab page containing this control.
            CloseRequested(this, EventArgs.Empty);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            // Cancel the changes made by this control
            // by rolling back the _transaction.
            _transaction.PropertyChanged -= new System.ComponentModel.PropertyChangedEventHandler(transaction_PropertyChanged);
            _transaction.Rollback();
            // Create a new transaction.
            CreateTransaction();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var row = BindingContext[_ordersView].Current as C1.LiveLinq.LiveViews.ViewRow;
            if (row == null)
                return;
            var order = ((OrderInfo)row.Value).GetOrder();

            // Edit the order in a child transaction scope.
            // Rolling back the child transaction will not roll back the parent transaction.
            using (var tran2 = new ClientTransaction(_transaction))
            {
                var window = new OrderForm(order, tran2);
                if (window.ShowDialog() == DialogResult.OK)
                    tran2.Commit();
            } // The child transaction will be rolled back automatically if it is not committed.
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add a new Order in a child transaction scope.
            // Rolling back the child transaction will not roll back the parent transaction.
            using (var tran2 = new ClientTransaction(_transaction))
            {
                var order = new Order();
                using (tran2.Scope())
                {
                    _cache.ObjectContext.AddObject("Orders", order);
                }


                var window = new OrderForm(order, tran2);
                if (window.ShowDialog() == DialogResult.OK)
                {
                    // Add the order to the Customer.Orders in the child transaction scope and commit the transaction.
                    using(tran2.Scope())
                    {
                        Customer.Orders.Add(order);
                        tran2.Commit();
                    }
                }
            } // The child transaction will be rolled back automatically if it is not committed.
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Remove the selected order.

            var row = BindingContext[_ordersView].Current as C1.LiveLinq.LiveViews.ViewRow;
            if (row == null)
                return;
            var order = ((OrderInfo)row.Value).GetOrder();

            using (_transaction.Scope())
            {
                // Make the change in the transaction scope.
                Customer.Orders.Remove(order);
            }
        }
    }

    // This class is used as the result item type of an order view defined above.
    public class OrderInfo
    {
        public OrderInfo(Order o)
        {
            _order = o;
        }
        private Order _order;
        public Order GetOrder() { return _order; }

        public virtual int OrderID { get; set; }
        public virtual DateTime? OrderDate { get; set; }
        public virtual decimal? Freight { get; set; }
        public virtual string ShipName { get; set; }
        public virtual string ShipCity { get; set; }
    }
}
