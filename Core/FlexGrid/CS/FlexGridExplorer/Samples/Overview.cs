using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class Overview : UserControl
    {
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;

        public Overview()
        {
            InitializeComponent();
         /*   AddProperty("AllowAddNew", c1FlexGrid1);
            AddProperty("AllowDelete", c1FlexGrid1);
            AddProperty("AllowEditing", c1FlexGrid1);
            AddProperty("AllowSorting", c1FlexGrid1);
            AddProperty("SelectionMode", c1FlexGrid1);
            AddProperty("AllowFiltering", c1FlexGrid1);
            AddProperty("AllowMerging", c1FlexGrid1);
            AddProperty("AllowResizing", c1FlexGrid1);
            AddProperty("MinSize", c1FlexGrid1.Cols, "Column Min Width");
            AddProperty("ShowCellLabels", c1FlexGrid1);*/
        }

        private void InitializeComponent()
        {
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(334, 238);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.Text = "c1FlexGrid1";
            // 
            // Overview
            // 
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(334, 238);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void OnLoad(EventArgs e)
        {
            string sql = "SELECT Distinct Orders.[OrderID], Orders.OrderDate, Shippers.CompanyName, Customers.Country, [FirstName] + ' ' + [LastName] AS Salesperson, Products.ProductName AS Product, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, ([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 as ExtendedPrice FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Properties.Settings.Default.C1DemoConnectionString);
            da.Fill(dt);
            c1FlexGrid1.DataSource = dt;
            foreach (C1.Win.FlexGrid.Column c in c1FlexGrid1.Cols)
            {
                c.AllowMerging = true;
            }
            c1FlexGrid1.Cols["Product"].MinWidth = 120;
            c1FlexGrid1.Cols["Product"].StarWidth = "*";
            c1FlexGrid1.Cols["UnitPrice"].Format = "n2";
            c1FlexGrid1.Cols["ExtendedPrice"].Format = "n2";
        }
    }
}
