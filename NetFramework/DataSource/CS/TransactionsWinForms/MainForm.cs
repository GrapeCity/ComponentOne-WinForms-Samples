using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Data;
using C1.Data.Entities;
using C1.LiveLinq.LiveViews;

namespace TransactionsWinForms
{
    public partial class MainForm : Form
    {
        // A client cache and a client scope that are used to load the data.
        EntityClientCache _clientCache;
        EntityClientScope _scope;

        public MainForm()
        {
            InitializeComponent();

            // Initialize the client cache and the client scope.
            _clientCache = new EntityClientCache(new NORTHWNDEntities());
            _scope = new EntityClientScope(_clientCache);

            // Bind a combo box to the list of cities
            // using a live view of customers grouped by city.
            comboBoxCity.DisplayMember = "City";
            comboBoxCity.DataSource =
                (from c in _scope.GetItems<Customer>()
                 group c by c.City into g
                 orderby g.Key
                 select new
                 {
                     City = g.Key,
                     Customers = g
                 }).AsDynamic();
        }

        private void EditOrdersForCustomer()
        {
            // Start editing the selected customer.
            var row = listBoxCustomers.SelectedItem as ViewRow;
            if (row == null)
                return;
            var customer = row.Value as Customer;

            // If the customer is already being edited, then select the tab page associated with that customer.
            foreach (TabPage page in tabControl1.TabPages)
                if (page.Text == customer.ContactName)
                {
                    tabControl1.SelectedTab = page;
                    return;
                }

            // Create a CustomerControl for the current customer
            // and display it in the tab control.
            var customerControl = new CustomerControl(customer, _clientCache);
            tabControl1.TabPages.Add(customer.ContactName);
            int tabIdx = tabControl1.TabPages.Count - 1;
            TabPage tabPage = tabControl1.TabPages[tabIdx];
            customerControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            customerControl.Size = tabPage.Size;
            customerControl.Parent = tabPage;
            tabControl1.SelectedIndex = tabIdx;

            // Remove the created tab page when the Close button is pressed.
            customerControl.CloseRequested += delegate
            {
                tabControl1.TabPages.Remove(tabPage);
            };
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the customers of the selected city.
            ViewRow row = comboBoxCity.SelectedItem as ViewRow;
            if (row != null)
            {
                listBoxCustomers.DisplayMember = "ContactName";
                listBoxCustomers.DataSource = ((dynamic)row.Value).Customers;
            }
        }

        private void listBoxCustomers_DoubleClick(object sender, EventArgs e)
        {
            // Start editing the selected customer on double click.
            EditOrdersForCustomer();
        }
    }
}
