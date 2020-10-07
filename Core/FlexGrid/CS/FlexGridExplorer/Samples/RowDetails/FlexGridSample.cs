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
    public partial class FlexGridSample : UserControl
    {
        public FlexGridSample()
        {
            InitializeComponent();
        }

        private void FlexGridSample_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();

            string sql = "SELECT * FROM Customers";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Properties.Settings.Default.C1DemoConnectionString);
            da.Fill(dt);
            dt.TableName = "Customers";
            ds.Tables.Add(dt);

            sql = "SELECT * FROM Orders";
            dt = new DataTable();
            da = new SqlDataAdapter(sql, Properties.Settings.Default.C1DemoConnectionString);
            da.Fill(dt);
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
