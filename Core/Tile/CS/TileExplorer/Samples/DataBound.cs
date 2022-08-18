using C1.Win.Tile;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TileExplorer.Data;

namespace TileExplorer.Samples
{
    public partial class DataBound : UserControl
    {
        private DataSet _dataSet;

        public DataBound()
        {
            InitializeComponent();
        }

        private void c1TileControl1_FormatValue(object sender, FormatValueEventArgs e)
        {
            if (e.TileProperty == TileProperty.BackColor)
            {
                if (e.Value is bool && (bool)e.Value)
                    e.Value = Color.Firebrick;
                else
                    e.Value = Color.DimGray;
            }
            else if (e.TileProperty == TileProperty.IntValue)
            {
                int result = 0;
                switch (e.Value as string)
                {
                    case "UK":
                        result = 1; break;
                    case "France":
                        result = 2; break;
                    case "Brazil":
                        result = 3; break;
                    case "Singapore":
                        result = 4; break;
                    case "USA":
                        result = 5; break;
                    case "Germany":
                        result = 6; break;
                    case "Australia":
                        result = 7; break;
                    case "Japan":
                        result = 8; break;
                    case "Canada":
                        result = 9; break;
                    case "Netherlands":
                        result = 10; break;
                    case "Finland":
                        result = 11; break;
                    case "Norway":
                        result = 12; break;
                    case "Italy":
                        result = 13; break;
                    case "Spain":
                        result = 14; break;
                    case "Sweden":
                        result = 15; break;
                    case "Denmark":
                        result = 16; break;
                }
                e.Value = result;
            }
        }

        private void c1TileControl1_TileClicked(object sender, TileEventArgs e)
        {
            CurrencyManager cm = this.BindingContext[_dataSet, "Products"] as CurrencyManager;
            IBindingList list = cm.List as IBindingList;
            PropertyDescriptor pd = cm.GetItemProperties()["ProductID"];
            cm.Position = list.Find(pd, e.Tile.Tag);
        }

        private void DataBound_Load(object sender, EventArgs e)
        {
            #region data

            string sqlCategories = @"
                SELECT CategoryID, CategoryName, Description, Picture
	                FROM Categories ";
            DataTable categoriesTable = DataSource.GetRows(sqlCategories, "Categories");

            string sqlSuppliers = @"
                SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage
	                FROM Suppliers ";
            DataTable suppliersTable = DataSource.GetRows(sqlSuppliers, "Suppliers");

            string sqlProducts = @"
                SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued
	                FROM Products ";
            DataTable productsTable = DataSource.GetRows(sqlProducts, "Products");

            DataSet ds = new DataSet();
            ds.Tables.Add(categoriesTable);
            ds.Tables.Add(suppliersTable);
            ds.Tables.Add(productsTable);
            ds.Relations.Add(categoriesTable.Columns["CategoryID"], productsTable.Columns["CategoryID"]);
            ds.Relations.Add(suppliersTable.Columns["SupplierID"], productsTable.Columns["SupplierID"]);

            #endregion

            c1TileControl1.DataMember = "Products";
            c1TileControl1.DataSource = ds;

            c1TileControl1.PropertyMappings[1].Lookup.DataSource = ds;
            c1TileControl1.PropertyMappings[3].Lookup.DataSource = ds;
            c1TileControl1.PropertyMappings[4].Lookup.DataSource = ds;

            dataGridView1.DataMember = "Products";
            dataGridView1.DataSource = ds;

            supplierIDDataGridViewTextBoxColumn.DataSource = ds;
            categoryIDDataGridViewTextBoxColumn.DataSource = ds;

            _dataSet = ds;
        }
    }
}
