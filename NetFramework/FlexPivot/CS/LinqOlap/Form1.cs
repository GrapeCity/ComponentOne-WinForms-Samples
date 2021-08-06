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

namespace LinqFlexPivot
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
            _c1FlexPivotPage.DataSource = q.ToList();

            // show default view
            var fp = _c1FlexPivotPage.FlexPivotPanel.PivotEngine;
            fp.BeginUpdate();
            fp.RowFields.Add("Country");
            fp.ColumnFields.Add("Category");
            fp.ValueFields.Add("Sales");
            fp.EndUpdate();

            // load predefined FlexPivot views
            var doc = new XmlDocument();
            doc.LoadXml(Properties.Resources.FlexPivotViews);

            // build menu with default FlexPivot views
            var menuView = new C1.Win.C1Command.C1CommandMenu();
            menuView.Text = "&View";
            menuView.Image = Properties.Resources.Views_small;
            foreach (XmlNode nd in doc.SelectNodes("FlexPivotViews/C1FlexPivot"))
            {
                var cmd = new C1.Win.C1Command.C1Command();
                cmd.Text = nd.Attributes["id"].Value;
                cmd.UserData = nd;
                cmd.Click += MenuView_DropDownItemClicked;
                var link = new C1.Win.C1Command.C1CommandLink(cmd);
                menuView.CommandLinks.Add(link);
            }

            // add the new view menu to the toolstrip
            var menuLink = new C1.Win.C1Command.C1CommandLink(menuView);
            _c1FlexPivotPage.ToolBar.CommandLinks.Insert(3, menuLink);
        }

        // select a predefined FlexPivot view
        void MenuView_DropDownItemClicked(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            var nd = e.CallerLink.Command.UserData as XmlNode;
            if (nd != null)
            {
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml;
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
