using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AnalyzeNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize grid bound to DataTable
            InitializeFlexGrid(_flexDataTable);
            _flexDataTable.DataSource = GetDataTable();
            _flexDataTable.Cols["LastName"].StarWidth = "*";
            _flexDataTable.Cols["ShipCountry"].StarWidth = "*";
            _flexDataTable.Cols["CategoryName"].StarWidth = "*";
            _flexDataTable.Cols["ProductName"].StarWidth = "2*";
            var col = _flexDataTable.Cols["OrderDate"];
            col.Width = 80;
            col.Aggregate = AggregateEnum.Max;
            col = _flexDataTable.Cols["Sale Amount"];
            col.Width = 80;
            col.Format = "N2";
            col.Aggregate = AggregateEnum.Sum;
            foreach (Column c in _flexDataTable.Cols)
            {
                c.Caption = Regex.Replace(c.Caption, "([a-z])([A-Z])", "$1 $2");
            }

            // initialize groups
            _flexDataTable.HideGroupedColumns = this._chkHideDataTable.Checked = true;
            SetGroups(_flexDataTable, "LastName", "ShipCountry", "CategoryName");

            // initialize grid bound to object list
            InitializeFlexGrid(_flexObjectList);
            _flexObjectList.DataSource = new SortableBindingList<Data>(Data.GetData(1000));
            _flexObjectList.Cols["ID"].Width = 60;
            _flexObjectList.Cols["Country"].StarWidth = "2*";
            _flexObjectList.Cols["Product"].StarWidth = "3*";
            _flexObjectList.Cols["Active"].Width = 100;
            col = _flexObjectList.Cols["Downloads"];
            col.Format = "N0";
            col.StarWidth = "*";
            col.MinWidth = 100;
            col = _flexObjectList.Cols["Sales"];
            col.Aggregate = AggregateEnum.Sum;
            col.Format = "N2";
            col.StarWidth = "*";
            col.MinWidth = 100;
            col = _flexObjectList.Cols["Expenses"];
            col.Aggregate = AggregateEnum.Sum;
            col.Format = "N2";
            col.StarWidth = "*";
            col.MinWidth = 100;

            // initialize groups
            _flexObjectList.HideGroupedColumns = _chkHideObjectList.Checked = true;
            SetGroups(_flexObjectList, "Country", "Product");
        }
        void InitializeFlexGrid(C1FlexGrid flex)
        {
            // set properties
            flex.AllowMerging = AllowMergingEnum.Nodes;
            flex.Tree.Style = TreeStyleFlags.Simple;
            flex.Cols[0].Width = _flexDataTable.Cols.DefaultSize / 4;

            // set up styles
            flex.Styles.Normal.Border.Style = BorderStyleEnum.None;
            flex.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;

            var s = flex.Styles[CellStyleEnum.GrandTotal];
            {
                s.BackColor = Color.Black;
                s.ForeColor = Color.White;
                s.Font = new Font(this.Font, FontStyle.Bold);
            }
            s = flex.Styles[CellStyleEnum.Subtotal0];
            {
                s.BackColor = Color.Gold;
                s.ForeColor = Color.Black;
                s.Font = new Font(this.Font, FontStyle.Bold);
            }
            s = flex.Styles[CellStyleEnum.Subtotal1];
            {
                s.BackColor = Color.Khaki;
                s.ForeColor = Color.Black;
                s.Font = new Font(this.Font, FontStyle.Bold);
            }
            s = flex.Styles[CellStyleEnum.Subtotal2];
            {
                s.BackColor = Color.LightGoldenrodYellow;
                s.ForeColor = Color.Black;
            }
        }

        public void SetGroups(C1FlexGrid flex, params string[] props)
        {
            var groups = new List<GroupDescription>();
            foreach (var prop in props)
            {
                groups.Add(new GroupDescription(prop, ListSortDirection.Ascending));
            }
            flex.GroupDescriptions = groups;
            if (flex == _flexDataTable && this._chkCollapseDataTable.Checked)
            {
                flex.Tree.Show(props.Length - 1);
            }
            if (flex == _flexObjectList && this._chkCollapseObjectList.Checked)
            {
                flex.Tree.Show(props.Length - 1);
            }
        }

        // get a DataTable
        DataTable GetDataTable()
        {
            // set up connection string
            var conn = GetConnectionString();

            // set up SQL statement
            var rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, " +
                "Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
                "FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) " +
                "INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
                "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
                "ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

            // retrieve data into DataSet
            var da = new OleDbDataAdapter(rs, conn);
            var ds = new DataSet();
            da.Fill(ds);

            // return data table
            return ds.Tables[0];
        }
        static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        // get a list of objects
        public class Data
        {
            public int ID { get; set; }
            public string Country { get; set; }
            public string Product { get; set; }
            public bool Active { get; set; }
            public int Downloads { get; set; }
            public double Sales { get; set; }
            public double Expenses { get; set; }

            static string[] _Countries = "US,Germany,UK,Japan,Italy,Greece".Split(',');
            static string[] _Products = "Cake,Pie,Croissant,Danish,Doughnut,Pancake,Bread,Scone".Split(',');
            static Random rnd = new Random();
            public Data(int i)
            {
                this.ID = i;
                this.Country = _Countries[rnd.Next(_Countries.Length)];
                this.Product = _Products[rnd.Next(_Products.Length)];
                this.Active = i % 5 != 0;
                this.Downloads = rnd.Next(200000);
                this.Sales = rnd.NextDouble() * 100000;
                this.Expenses = rnd.NextDouble() * 5000;
            }
            public static IList<Data> GetData(int cnt)
            {
                var list = new List<Data>();
                for (var i = 0; i < cnt; i++)
                {
                    list.Add(new Data(i));
                }
                return list;
            }
        }

        // event handlers
        private void _btnNameCountryCat_Click(object sender, EventArgs e)
        {
            SetGroups(_flexDataTable, "LastName", "ShipCountry", "CategoryName");
        }

        private void _btnCatCountryName_Click(object sender, EventArgs e)
        {
            SetGroups(_flexDataTable, "CategoryName", "ShipCountry", "LastName");
        }

        private void _btnCountryCat_Click(object sender, EventArgs e)
        {
            SetGroups(_flexDataTable, "ShipCountry", "CategoryName");
        }

        private void _btnProdCountryActive_Click(object sender, EventArgs e)
        {
            SetGroups(_flexObjectList, "Product", "Country", "Active");
        }

        private void _btnCountryProdActive_Click(object sender, EventArgs e)
        {
            SetGroups(_flexObjectList, "Country", "Product", "Active");
        }

        private void _btnProdCountry_Click(object sender, EventArgs e)
        {
            SetGroups(_flexObjectList, "Product", "Country");
        }

        private void _chkHideDataTable_CheckedChanged(object sender, EventArgs e)
        {
            this._flexDataTable.HideGroupedColumns = _chkHideDataTable.Checked;
        }

        private void _chkHideObjectList_CheckedChanged(object sender, EventArgs e)
        {
            this._flexObjectList.HideGroupedColumns = _chkHideObjectList.Checked;
        }
    }
}
