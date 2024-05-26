using C1.Win.C1Themes;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinningColumns
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillFlexGrid(c1FlexGrid1);
            c1FlexGrid1.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.SingleColumn;
            c1FlexGrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            c1FlexGrid1.Cols.Frozen = 3;
            FillFlexGrid(c1FlexGrid2);
            c1FlexGrid2.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.ColumnRange;
            c1FlexGrid2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            c1FlexGrid2.Cols.Frozen = 4;
            InitThemes();
        }


        private void FillFlexGrid(C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid)
        {
                c1FlexGrid.DataSource = DemoDataSource();
            if (c1FlexGrid.Cols.Contains("Product"))
            {
                c1FlexGrid.Cols["Product"].MinWidth = 120;
                c1FlexGrid.Cols["Product"].StarWidth = "*";
            }
            if (c1FlexGrid.Cols.Contains("UnitPrice"))
                c1FlexGrid.Cols["UnitPrice"].Format = "n2";
            if (c1FlexGrid.Cols.Contains("ExtendedPrice"))
                c1FlexGrid.Cols["ExtendedPrice"].Format = "n2";
        }
        public DataTable DemoDataSource()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT DISTINCTROW Orders.OrderID, Orders.OrderDate, Shippers.CompanyName, Customers.Country, [FirstName] & \" \" & [LastName] AS Salesperson, Products.ProductName AS Product, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;";
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\ComponentOne Samples\\Common\\C1NWind.mdb";
            if (File.Exists(dbPath))
            {                 
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + dbPath + ";Persist Security Info=False";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, connString);
                da.Fill(dt);
            }
            else
                MessageBox.Show("An example database C1NWind.mdb is not found at" + dbPath);

            return dt;
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion
    }
}
