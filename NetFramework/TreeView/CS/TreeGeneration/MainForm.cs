using C1.Win.Themes;
using C1.Win.Ribbon;
using System;
using System.Data;
using System.Linq;

namespace TreeGeneration
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();

            // set the data source
            c1TreeView1.BindingInfo.DataMemberPath.Add(0, "Customers");
            c1TreeView1.BindingInfo.DataMemberPath.Add(1, "Orders");
            c1TreeView1.BindingInfo.DataMemberPath.Add(2, "OrderDetail");
            c1TreeView1.BindingInfo.DataSource = GetData();
        }

        public DataSet GetData()
        {
            // create hierarchical DataSet
            DataRowCollection drc;
            DataColumnCollection dcc;
            DataSet ds = new DataSet("Hierarchical DataSet");

            ds.Tables.Add("Products");
            dcc = ds.Tables["Products"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("Name", typeof(string));
            dcc.Add("Value", typeof(decimal));

            drc = ds.Tables["Products"].Rows;
            drc.Add(new object[] { "P1", "Widget", 19.95 });
            drc.Add(new object[] { "P2", "Gadget", 22.75 });
            drc.Add(new object[] { "P3", "Sprocket", 33.10 });

            ds.Tables.Add("Customers");
            dcc = ds.Tables["Customers"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("Name", typeof(string));
            dcc.Add("Address", typeof(string));

            drc = ds.Tables["Customers"].Rows;
            drc.Add(new object[] { "C1", "John", "122 Penny Lane" });
            drc.Add(new object[] { "C2", "Paul", "666 Abbey Road" });
            drc.Add(new object[] { "C3", "George", "222 Chatham Road" });
            drc.Add(new object[] { "C4", "Ringo", "345 Oxford St." });

            ds.Tables.Add("Orders");
            dcc = ds.Tables["Orders"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("CustomerID", typeof(string));
            dcc.Add("Prty", typeof(int));
            dcc.Add("Date", typeof(DateTime));

            drc = ds.Tables["Orders"].Rows;
            drc.Add(new object[] { "O1", "C1", 1, new DateTime(2001, 12, 1) });
            drc.Add(new object[] { "O2", "C2", 2, new DateTime(2002, 1, 22) });
            drc.Add(new object[] { "O3", "C3", 3, new DateTime(2002, 1, 20) });
            drc.Add(new object[] { "O4", "C4", 1, new DateTime(2002, 1, 14) });
            drc.Add(new object[] { "O5", "C1", 3, new DateTime(2002, 1, 16) });

            ds.Tables.Add("OrderDetail");
            dcc = ds.Tables["OrderDetail"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("OrderID", typeof(string));
            dcc.Add("ProductID", typeof(string));
            dcc.Add("Qty", typeof(int));

            drc = ds.Tables["OrderDetail"].Rows;
            drc.Add(new object[] { "D1", "O1", "P1", 1 });
            drc.Add(new object[] { "D2", "O1", "P2", 12 });
            drc.Add(new object[] { "D3", "O1", "P3", 1 });
            drc.Add(new object[] { "D4", "O2", "P1", 1 });
            drc.Add(new object[] { "D5", "O2", "P2", 8 });
            drc.Add(new object[] { "D6", "O2", "P3", 1 });
            drc.Add(new object[] { "D7", "O3", "P1", 1 });
            drc.Add(new object[] { "D8", "O4", "P1", 1 });
            drc.Add(new object[] { "D9", "O4", "P2", 10 });
            drc.Add(new object[] { "D10", "O5", "P1", 1 });
            drc.Add(new object[] { "D11", "O5", "P2", 16 });
            drc.Add(new object[] { "D12", "O5", "P3", 1 });

            ds.Relations.Add("CustomerOrders", ds.Tables["Customers"].Columns["ID"], ds.Tables["Orders"].Columns["CustomerID"]);
            ds.Relations.Add("Order Details", ds.Tables["Orders"].Columns["ID"], ds.Tables["OrderDetail"].Columns["OrderID"]);
            ds.Relations.Add("Product Details", ds.Tables["Products"].Columns["ID"], ds.Tables["OrderDetail"].Columns["ProductID"]);

            return ds;
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion
    }
}
