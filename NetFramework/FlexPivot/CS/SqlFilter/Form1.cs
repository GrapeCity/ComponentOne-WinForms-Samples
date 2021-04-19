using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using SqlFilter.Properties;

namespace SqlFilter
{
    public partial class Form1 : Form
    {
        List<string> _customerList;
        List<string> _activeCustomerList;
        const int MAX_CUSTOMERS = 12;

        public Form1()
        {
            InitializeComponent();

            // get complete list of customers
            _customerList = new List<string>();
            var sql = @"SELECT DISTINCT Customers.CompanyName AS [Customer] FROM Customers";
            var da = new OleDbDataAdapter(sql, GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                _customerList.Add((string)dr["Customer"]);
            }

            // get active customer list
            _activeCustomerList = new List<string>();
            foreach (string customer in Settings.Default.Customers)
            {
                _activeCustomerList.Add(customer);
            }

            // get data into the CachedDataTable
            var dtSales = new CachedDataTable(
                Resources.SqlTemplate, 
                Resources.WhereTemplate, 
                GetConnectionString());
            dtSales.Fill(_activeCustomerList);

            // assign data to C1FlexPivotPage control
            _c1FlexPivotPage.DataSource = dtSales;

            // show default view
            var fp = _c1FlexPivotPage.PivotEngine;
            fp.BeginUpdate();
            fp.RowFields.Add("Customer");
            fp.ColumnFields.Add("Category");
            fp.ValueFields.Add("Sales");
            fp.EndUpdate();

            // custom filter: customers in the list, customers currently active
            var field = fp.Fields["Customer"];
            var filter = field.Filter;
            filter.Values = _customerList;
            filter.ShowValues = _activeCustomerList.ToArray();
            filter.PropertyChanged += filter_PropertyChanged;

            // load predefined FlexPivot views
            var doc = new XmlDocument();
            doc.LoadXml(Resources.FlexPivotViews);

            // build menu with default FlexPivot views
            var items = _c1FlexPivotPage.MenuGrid.CommandLinks;
            int i = 0;
            foreach (XmlNode nd in doc.SelectNodes("FlexPivotViews/C1FlexPivot"))
            {
                var cmd = new C1.Win.C1Command.C1Command();
                cmd.Text = nd.Attributes["id"].Value;
                cmd.UserData = nd;
                cmd.Click += MenuView_DropDownItemClicked;
                var link = new C1.Win.C1Command.C1CommandLink(cmd);
                if (i == 0)
                   link.Delimiter = true; 
                items.Add(link);
                i++;
            }

            // change "OrderDate" caption to "Date" (looks nicer on the UI)
            fp.Fields["OrderDate"].Caption = "Date";

            // make sure Customer field is always in the view
            // (since it is always used at least as a filter)
            _c1FlexPivotPage.Updating += _c1FlexPivotPage_Updating;
        }

        // make sure Customer field is always in the view
        // (since it is always used at least as a filter)
        void  _c1FlexPivotPage_Updating(object sender, EventArgs e)
        {
            var fp = _c1FlexPivotPage.PivotEngine;
            var field = fp.Fields["Customer"];
            if (!field.IsActive)
            {
                fp.FilterFields.Add(field);
            }
        }

        // re-query database when list of selected customers changes
        void filter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // get reference to parent filter
            var filter = sender as C1.PivotEngine.PivotFilter;

            // get list of values accepted by the filter
            _activeCustomerList.Clear();
            foreach (string customer in _customerList)
            {
                if (filter.Apply(customer))
                {
                    _activeCustomerList.Add(customer);
                }
            }

            // skip if no values were selected
            if (_activeCustomerList.Count == 0)
            {
                MessageBox.Show(
                    "You have selected no customers, change will not be applied.",
                    "No Customers");
                return;
            }

            // trim list if necessary
            if (_activeCustomerList.Count > MAX_CUSTOMERS)
            {
                MessageBox.Show(
                    "You have selected too many customers, list will be trimmed.",
                    "Too Many Customers");
                _activeCustomerList.RemoveRange(MAX_CUSTOMERS, _activeCustomerList.Count - MAX_CUSTOMERS);
            }

            // get new data
            var dt = _c1FlexPivotPage.DataSource as CachedDataTable;
            dt.Fill(_activeCustomerList);
        }

        protected override void OnClosed(EventArgs e)
        {
            // save current customer list for next time
            var customerList = Settings.Default.Customers;
            customerList.Clear();
            foreach (string customer in _activeCustomerList)
            {
                customerList.Add(customer);
            }
            Settings.Default.Save();

            // fire event as usual
            base.OnClosed(e);
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
