using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.LiveLinq;

namespace OrdersEFWinForms
{
    public partial class MainForm : Form
    {
        // All changes in this application are made in the scope of this client transaction.
        ITransaction _transaction;
        // The global transaction scope.
        IDisposable _transactionScope;

        public MainForm()
        {
            InitializeComponent();

            // Open the global transaction scope, so all changes in the application are made in a transaction.
            _transaction = c1DataSource1.ClientScope.ClientCache.CreateTransaction();
            _transactionScope = _transaction.Scope();
        }

        private TabPage OpenWorkspace(UserControl workspace, string title)
        {
            // Create a tab page for the selected workspace control.
            tabControl1.TabPages.Add(title);
            int tabIdx = tabControl1.TabPages.Count - 1;
            TabPage tabPage = tabControl1.TabPages[tabIdx];
            workspace.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            workspace.Size = tabPage.Size;
            workspace.Parent = tabPage;
            tabControl1.SelectedIndex = tabIdx;
            return tabPage;
        }

        private void linkLabelEditOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var workspace = new OrdersView();
            workspace.TabPage = OpenWorkspace(workspace, "Edit Orders");
        }

        private void linkLabelOrdersCountry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var workspace = new OrdersViewCountry();
            workspace.TabPage = OpenWorkspace(workspace, "Orders by Country");
        }

        private void linkLabelProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var workspace = new ProductsView();
            workspace.TabPage = OpenWorkspace(workspace, "Products");
        }

        private void linkLabelAllOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var workspace = new AllOrdersView();
            workspace.TabPage = OpenWorkspace(workspace, "All Orders");
        }

        private void linkLabelSaveChanges_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c1DataSource1.ClientCache.SaveChanges();
        }

        private void linkLabelCancelChanges_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Cancel all changes made in this application by rolling back the global transaction.
            if (_transaction.State == TransactionState.Open)
            {
                _transaction.Rollback();
                _transactionScope.Dispose();
            }
            // Open a new transaction.
            _transaction = c1DataSource1.ClientScope.ClientCache.CreateTransaction();
            _transactionScope = _transaction.Scope();
        }
    }
}
