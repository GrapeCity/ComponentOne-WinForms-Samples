using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Data.Transactions;
using C1.Data.Entities;
using C1.LiveLinq.LiveViews;
using C1.LiveLinq.Collections;
using C1.LiveLinq;
using C1.WPF.LiveLinq;

namespace TransactionsWinForms
{
    public partial class OrderForm : Form
    {
        // All changes in this form are made in the scope of this client transaction.
        ClientTransaction _transaction;

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order order, ClientTransaction transaction)
        {
            InitializeComponent();
            _transaction = transaction;

            // Create a proxy for the order that automatically opens the transaction scope
            // each time a value is assigned to a property.
            var tranOrder = _transaction.ScopeDataContext(order);

            // Bind text boxes to the properties of the proxy object.
            BindTextBox(textBoxID, tranOrder, "OrderID");
            BindTextBox(textBoxFreight, tranOrder, "Freight");
            BindTextBox(textBoxOrderDate, tranOrder, "OrderDate");
            BindTextBox(textBoxShipName, tranOrder, "ShipName");
            BindTextBox(textBoxShipCity, tranOrder, "ShipCity");

            // Define a live view of order details.
            var orderDetailsView = from od in order.Order_Details.AsLive()
                                   select new OrderDetailsInfo
                                   {
                                       OrderID = od.OrderID,
                                       ProductID = od.ProductID,
                                       UnitPrice = od.UnitPrice,
                                       Discount = od.Discount,
                                       Quantity = od.Quantity
                                   };
            // All changes in this view are made in the transaction scope.
            orderDetailsView.SetTransaction(_transaction);
            orderDetailsGrid.DataSource = orderDetailsView;
        }

        private void BindTextBox(TextBox textBox, object dataSource, string dataMember)
        {
            // Bind the text of the text box to the property of the dataSource object.
            textBox.DataBindings.Add(new Binding("Text", dataSource, dataMember) { FormattingEnabled = true });
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }


    // This class is used as the result item type of an order detail view defined above.
    public class OrderDetailsInfo
    {
        public virtual int OrderID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual float Discount { get; set; }
        public virtual decimal Quantity { get; set; }
    }
}
