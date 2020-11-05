using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.RowDetails
{
    using FlexGridExplorer.Data;

    public partial class FlexGridSample : UserControl
    {
        public FlexGridSample()
        {
            InitializeComponent();
        }

        private void FlexGridSample_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();

            // Creating tables
            var customersTable = DataSource.GetRows("Select * from Customers");
            customersTable.TableName = "Customers";
            var ordersTable = DataSource.GetRows("Select * from Orders");
            ordersTable.TableName = "Orders";
            ds.Tables.Add(customersTable);
            ds.Tables.Add(ordersTable);

            // Creating relation between orders table and customers table
            ds.Relations.Add("Customers_Orders",
              ds.Tables["Customers"].Columns["CustomerID"],
              ds.Tables["Orders"].Columns["CustomerID"]);

            // Set data source
            flexGrid.DataSource = ds;
            flexGrid.DataMember = "Customers";

            flexGrid.RowDetailProvider = (g, r) => new C1FlexGridRowDetail();
            flexGrid.AreRowDetailsFrozen = false;
        }
    }
}
