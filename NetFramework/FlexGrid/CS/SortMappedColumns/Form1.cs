using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace SortMappedColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WithRelations();
            WithoutRelations();
        }

        /// <summary>
        /// Bind the grid to a table with two mapped columns: 
        /// Show CustomerName instead of CustomerID, and LastName instead of EmployeedID.
        /// 
        /// Add hidden calculated columns to perform the sorting based on name instead of ID.
        /// The calculated columns are created using relations defined in the DataSet 
        /// (e.g. Parent.CompanyName)
        /// </summary>
        void WithRelations()
        {
            // create DataSet
            var ds = new DataSet();

            // load tables
            var da = new OleDbDataAdapter("select * from orders", GetConnectionString());
            da.Fill(ds, "Orders");

            da = new OleDbDataAdapter("select * from customers", GetConnectionString());
            da.Fill(ds, "Customers");

            da = new OleDbDataAdapter("select * from employees", GetConnectionString());
            da.Fill(ds, "Employees");

            // create relations
            ds.Relations.Add("Order_Customer",
                ds.Tables["Customers"].Columns["CustomerID"],
                ds.Tables["Orders"].Columns["CustomerID"]);
            
            ds.Relations.Add("Order_Employee",
                ds.Tables["Employees"].Columns["EmployeeID"],
                ds.Tables["Orders"].Columns["EmployeeID"]);

            // add calculated columns (look up names based on IDs, for sorting)
            ds.Tables["Orders"].Columns.Add("CustomerMapped", typeof(string), "Parent(Order_Customer).CompanyName");
            ds.Tables["Orders"].Columns.Add("EmployeeMapped", typeof(string), "Parent(Order_Employee).LastName + ' ' + Parent(Order_Employee).FirstName");

            // show the data
            _flex.DataSource = ds.Tables["Orders"];

            // add data maps
            var dctCustomers = new MultiColumnDictionary(ds.Tables["Customers"], "CustomerID", new string[] { "CompanyName" }, 0);
            var dctEmployees = new MultiColumnDictionary(ds.Tables["Employees"], "EmployeeID", new string[] { "LastName" }, 0);
            _flex.Cols["CustomerID"].DataMap = dctCustomers;
            _flex.Cols["EmployeeID"].DataMap = dctEmployees;

            // hide the calculated columns
            _flex.Cols["CustomerMapped"].Visible = false;
            _flex.Cols["EmployeeMapped"].Visible = false;
        }

        /// <summary>
        /// Bind the grid to a table with two mapped columns: 
        /// Show CustomerName instead of CustomerID, and LastName instead of EmployeedID.
        /// 
        /// Add hidden calculated columns to perform the sorting based on name instead of ID.
        /// The calculated columns are created using lookup tables built dynamically using
        /// nested IIF statements.
        /// </summary>
        void WithoutRelations()
        {
            // bind to orders table
            var da = new OleDbDataAdapter("select * from orders", GetConnectionString());
            var dtOrders = new DataTable();
            da.Fill(dtOrders);
            this._flex.DataSource = dtOrders;

            // map CustomerID column
            da = new OleDbDataAdapter("select * from customers", GetConnectionString());
            var dtCustomers = new DataTable();
            da.Fill(dtCustomers);
            var dctCustomers = new C1.Win.C1FlexGrid.MultiColumnDictionary(dtCustomers, "CustomerID", new string[] { "CompanyName" }, 0);
            _flex.Cols["CustomerID"].DataMap = dctCustomers;

            // map EmployeeID column
            da = new OleDbDataAdapter("select * from employees", GetConnectionString());
            var dtEmployees = new DataTable();
            da.Fill(dtEmployees);
            var dctEmployees = new C1.Win.C1FlexGrid.MultiColumnDictionary(dtEmployees, "EmployeeID", new string[] { "LastName", "FirstName" }, 0);
            _flex.Cols["EmployeeID"].DataMap = dctEmployees;

            // create additional mapped columns (for sorting)
            var exprCustomer = BuildExpression(0, dtCustomers, "CustomerID", "CompanyName");
            var dcCustomerMapped = dtOrders.Columns.Add("CustomerMapped", typeof(string), exprCustomer);
            var exprEmployee = BuildExpression(0, dtEmployees, "EmployeeID", "LastName");
            var dcEmployeeMapped = dtOrders.Columns.Add("EmployeeMapped", typeof(string), exprEmployee);

            // hide the calculated columns
            _flex.Cols["CustomerMapped"].Visible = false;
            _flex.Cols["EmployeeMapped"].Visible = false;
        }
        string BuildExpression(int i, DataTable dt, string key, string value)
        {
            if (i < dt.Rows.Count)
            {
                return string.Format("IIF({0} = '{1}', '{2}', {3})",
                    key,
                    dt.Rows[i][key],
                    dt.Rows[i][value].ToString().Replace("'", "''"),
                    BuildExpression(i + 1, dt, key, value));
            }
            else
            {
                return "'NOT FOUND'";
            }
        }

        // intercept sort command and sort by mapped column instead
        void _flex_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
        {
            if (_flex.Cols[e.Col].Name == "CustomerID")
            {
                int col = _flex.Cols["CustomerMapped"].Index;
                _flex.Sort(e.Order, col);
                _flex.ShowSortAt(e.Order, col);
                e.Handled = true;
            }
            else if (_flex.Cols[e.Col].Name == "EmployeeID")
            {
                int col = _flex.Cols["EmployeeMapped"].Index;
                _flex.Sort(e.Order, col);
                _flex.ShowSortAt(e.Order, col);
                e.Handled = true;
            }
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
