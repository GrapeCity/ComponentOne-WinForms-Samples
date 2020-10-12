using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqOlap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // designer
            InitializeComponent();

            // load all interesting tables into a DataSet
            var ds = new DataSet();
            foreach (string table in "Products,Categories,Employees,Customers,Orders,Order Details".Split(','))
            {
                string sql = string.Format("select * from [{0}]", table);
                var da = new OleDbDataAdapter(sql, GetConnectionString());
                da.Fill(ds, table);
            }

            // build LINQ query
            var q =
                from detail in ds.Tables["Order Details"].AsEnumerable()
                join product in ds.Tables["Products"].AsEnumerable()
                    on detail.Field<int>("ProductID") equals product.Field<int>("ProductID")
                join category in ds.Tables["Categories"].AsEnumerable()
                    on product.Field<int>("CategoryID") equals category.Field<int>("CategoryID")
                join order in ds.Tables["Orders"].AsEnumerable()
                    on detail.Field<int>("OrderID") equals order.Field<int>("OrderID")
                join customer in ds.Tables["Customers"].AsEnumerable()
                    on order.Field<string>("CustomerID") equals customer.Field<string>("CustomerID")
                join employee in ds.Tables["Employees"].AsEnumerable()
                    on order.Field<int>("EmployeeID") equals employee.Field<int>("EmployeeID")
                select new
                {
                    Sales = (detail.Field<short>("Quantity") * (double)detail.Field<decimal>("UnitPrice")) * (1 - (double)detail.Field<float>("Discount")),
                    OrderDate = order.Field<DateTime>("OrderDate"),
                    Product = product.Field<string>("ProductName"),
                    Customer = customer.Field<string>("CompanyName"),
                    Country = customer.Field<string>("Country"),
                    Employee = employee.Field<string>("FirstName") + " " + employee.Field<string>("LastName"),
                    Category = category.Field<string>("CategoryName")
                };

            // use LINQ query as DataSource
            _c1OlapPage.DataSource = q.ToList();

            // show default view
            var olap = _c1OlapPage.OlapPanel.OlapEngine;
            olap.BeginUpdate();
            olap.RowFields.Add("Country");
            olap.ColumnFields.Add("Category");
            olap.ValueFields.Add("Sales");
            olap.EndUpdate();

            // load predefined olap views
            var doc = new XmlDocument();
            doc.LoadXml(Properties.Resources.OlapViews);

            // build menu with default olap views
            var menuView = new ToolStripDropDownButton("&View", Properties.Resources.Views_small);
            foreach (XmlNode nd in doc.SelectNodes("OlapViews/C1Olap"))
            {
                var tsi = menuView.DropDownItems.Add(nd.Attributes["id"].Value);
                tsi.Tag = nd;
            }
            menuView.DropDownItemClicked += MenuView_DropDownItemClicked;

            // add the new view menu to the toolstrip
            _c1OlapPage.ToolStrip.Items.Insert(3, menuView);
        }

        // select a predefined Olap view
        void MenuView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var nd = e.ClickedItem.Tag as XmlNode;
            if (nd != null)
            {
                _c1OlapPage.OlapPanel.ViewDefinition = nd.OuterXml;
            }
        }

        // get standard nwind mdb connection string
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
