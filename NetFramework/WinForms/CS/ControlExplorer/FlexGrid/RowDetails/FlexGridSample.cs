using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.RowDetails
{
    public partial class FlexGridSample : C1DemoForm
    {
        public FlexGridSample()
        {
            InitializeComponent();
        }

        private void FlexGridSample_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();

            var dt = DemoDataSource("Customers");
            dt.TableName = "Customers";
            ds.Tables.Add(dt);

            dt = DemoDataSource("Orders");
            dt.TableName = "Orders";
            ds.Tables.Add(dt);

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
