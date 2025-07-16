using C1.Win.Ribbon;
using C1.Win.Themes;
using System;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OrdersWithFilter
{
    public partial class MainForm : C1RibbonForm
    {
        #region ctor

        public MainForm()
        {
            InitializeComponent();            
            Initialize();
        }

        private void Initialize()
        {
            foreach (var theme in C1ThemeController.GetThemes())
                ribbonCmbThemes.Items.Add(theme);
            ThemeName = "Office365White";
            ribbonCmbThemes.SelectedIndex = ribbonCmbThemes.Items.IndexOf(ThemeName);
            ApplyTheme(this);
        }

        #endregion

        #region themes

        private void ribbonCmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }
        private string ThemeName
        {
            get;
            set;
        }
        private void ApplyTheme(Control control)
        {
            if (!string.IsNullOrEmpty(ThemeName))
            {
                var theme = C1ThemeController.GetThemeByName(ThemeName, false);
                if (theme != null)
                    C1ThemeController.ApplyThemeToControlTree(control, theme);
                c1TrueDBGrid1.SuspendLayout();
                for (int i = 0; i < c1TrueDBGrid1.Splits[0].Rows.Count; i++)
                    c1TrueDBGrid1.Splits[0].Rows[i].AutoSize();
                c1TrueDBGrid1.ResumeLayout();

            }
        }

        #endregion

        #region data source

        private DataTable _ordersTable;

        private static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        private static DataTable GetDataSource()
        {
            string rs = "select * from Orders;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ordersTable = GetDataSource();
            c1TrueDBGrid1.DataSource = _ordersTable;
            c1DataFilter1.DataSource = _ordersTable;
            c1DataFilter1.ShowClearFilterButtons = true;
        }

        private void c1DataFilter1_FilterAutoGenerating(object sender, C1.DataFilter.FilterAutoGeneratingEventArgs e)
        {
            switch (e.Property.Name)
            {
                case "OrderDate":
                    var orderDateFilter = (C1.Win.DataFilter.DateRangeFilter)e.Filter;
                    orderDateFilter.Maximum = _ordersTable.AsEnumerable().Max(x => x.Field<DateTime>("OrderDate"));
                    orderDateFilter.Minimum = _ordersTable.AsEnumerable().Min(x => x.Field<DateTime>("OrderDate"));
                    orderDateFilter.HeaderText = "Order date";
                    break;
                case "RequiredDate":
                    var reqDateFilter = (C1.Win.DataFilter.DateRangeFilter)e.Filter;
                    reqDateFilter.Maximum = _ordersTable.AsEnumerable().Max(x => x.Field<DateTime>("RequiredDate"));
                    reqDateFilter.Minimum = _ordersTable.AsEnumerable().Min(x => x.Field<DateTime>("RequiredDate"));
                    reqDateFilter.HeaderText = "Required date";
                    break;
                case "Freight":
                    var freightFilter = (C1.Win.DataFilter.RangeFilter)e.Filter;
                    freightFilter.Maximum = (double)_ordersTable.AsEnumerable().Max(x => x.Field<decimal>("Freight"));
                    freightFilter.Minimum = (double)_ordersTable.AsEnumerable().Min(x => x.Field<decimal>("Freight"));
                    freightFilter.Increment = 10;
                    freightFilter.HeaderText = "Freight";
                    break;
                case "ShipCountry":
                    var countryFilter = (C1.Win.DataFilter.ChecklistFilter)e.Filter;
                    countryFilter.HeaderText = "Ship country";
                    countryFilter.ShowSelectAll = true;
                    countryFilter.ShowSearchBox = true;
                    countryFilter.SelectAll();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

    }
}
