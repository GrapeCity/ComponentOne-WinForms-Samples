using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace RowDetails
{
    public partial class FlexGridSample : UserControl
    {
        public FlexGridSample()
        {
            InitializeComponent();
        }

        private void FlexGrid_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            string conn = Util.GetConnectionString();
            var ds = new DataSet();
            string[] tables = "Customers, Orders".Split(',');
            foreach (string tableName in tables)
            {
                Util.FillTable(ds, tableName, conn);
            }

            ds.Relations.Add("Customers_Orders",
                ds.Tables["Customers"].Columns["CustomerID"],
                ds.Tables["Orders"].Columns["CustomerID"]);

            flexGrid.DataSource = ds;
            flexGrid.DataMember = "Customers";
            flexGrid.RowDetailProvider = (g, r) => new C1FlexGridRowDetail();
            flexGrid.AreRowDetailsFrozen = false;
        }
    }
}
