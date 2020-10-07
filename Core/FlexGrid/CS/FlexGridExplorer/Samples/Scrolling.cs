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
    public class Scrolling : UserControl
    {
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private bool _delayedScroll = true;
        private bool _showScrollTips = true;

        public Scrolling()
        {
            /*   AddProperty("DelayedScroll", this);
               AddProperty("ShowScrollTips", this);*/
            InitializeComponent();
            c1FlexGrid1.ShowScrollTip += c1FlexGrid1_ShowScrollTip;
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

            //set scroll options
            SetScrollOptions();
        }

        private void c1FlexGrid1_ShowScrollTip(object sender, C1.Win.FlexGrid.ToolTipEventArgs e)
        {
            if (c1FlexGrid1.SortColumn != null)
            {
                //Display values from sorted column in tooltip
                e.ToolTipText = c1FlexGrid1.SortColumn.Name + ": " + c1FlexGrid1[e.Row, c1FlexGrid1.SortColumn.Index].ToString() + "\nRow: " + e.Row.ToString();
            }
            else
            {
                //Display OrderDate column values in tooltip
                e.ToolTipText = "OrderDate: " + ((DateTime)(c1FlexGrid1[e.Row, "OrderDate"])).ToShortDateString() + "\nRow: " + e.Row.ToString();
            }
        }

        public bool DelayedScroll
        {
            get
            {
                return _delayedScroll;
            }
            set
            {
                _delayedScroll = value;
                SetScrollOptions();
            }
        }

        public bool ShowScrollTips
        {
            get
            {
                return _showScrollTips;
            }
            set
            {
                _showScrollTips = value;
                SetScrollOptions();
            }
        }

        private void SetScrollOptions()
        {
            if (_delayedScroll && _showScrollTips)
            {
                this.c1FlexGrid1.ScrollOptions = ((C1.Win.FlexGrid.ScrollFlags)((C1.Win.FlexGrid.ScrollFlags.DelayedScroll | C1.Win.FlexGrid.ScrollFlags.ShowScrollTips)));
            }
            else if (_delayedScroll)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.FlexGrid.ScrollFlags.DelayedScroll;
            }
            else if (_showScrollTips)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.FlexGrid.ScrollFlags.ShowScrollTips;
            }
            else
            {
                this.c1FlexGrid1.ScrollOptions = ScrollFlags.None;
            }
        }
    }
}
