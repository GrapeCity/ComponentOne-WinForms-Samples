using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public class Freezing : UserControl
    {
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        public Freezing()
        {
            /* AddProperty("AllowFreezing", c1FlexGrid1);
             AddProperty("AllowDragging", c1FlexGrid1);*/
            InitializeComponent();
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

            c1FlexGrid1.AllowFreezing = AllowFreezingEnum.Both;
            c1FlexGrid1.AllowDragging = AllowDraggingEnum.Both;
            c1FlexGrid1.Cols.Frozen = 2;
            c1FlexGrid1.Rows.Frozen = 3;
        }
    }
}
