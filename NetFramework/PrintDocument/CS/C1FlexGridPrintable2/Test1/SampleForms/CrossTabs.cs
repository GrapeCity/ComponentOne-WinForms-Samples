using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win;

namespace CrossTabs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form, C1FlexGridPrinterTest.IFlexSample
    {
        #region C1FlexGridPrinter
        public C1.C1Preview.C1PrintDocument MakeDoc(C1.Win.C1FlexGrid.C1FlexGridPrintInfo printInfo, LongOperationEventHandler longOperation)
        {
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();

            C1.C1Preview.RenderText hdrFlex = new C1.C1Preview.RenderText("Header for Flex");
            hdrFlex.Style.FontSize = 12;
            hdrFlex.Style.FontBold = true;
            hdrFlex.Style.Spacing.Bottom = "2mm";
            doc.Body.Children.Add(hdrFlex);

            C1.Win.C1FlexGrid.C1FlexGridPrinter pFlex = new C1.Win.C1FlexGrid.C1FlexGridPrinter(_flex);
            pFlex.LongOperation += longOperation;
            pFlex.PrintInfo = printInfo;
            doc.Body.Children.Add(pFlex.MakeGridTable(doc));

            C1.C1Preview.RenderText hdrFlexTab = new C1.C1Preview.RenderText("Header for FlexTab");
            hdrFlexTab.Style.FontSize = 12;
            hdrFlexTab.Style.FontBold = true;
            hdrFlexTab.Style.Spacing.Bottom = "2mm";
            hdrFlexTab.BreakBefore = C1.C1Preview.BreakEnum.Page;
            doc.Body.Children.Add(hdrFlexTab);

            C1.Win.C1FlexGrid.C1FlexGridPrinter pFlexTab = new C1.Win.C1FlexGrid.C1FlexGridPrinter(_flexXTab);
            pFlexTab.LongOperation += longOperation;
            pFlexTab.PrintInfo = printInfo;
            doc.Body.Children.Add(pFlexTab.MakeGridTable(doc));

            return doc;
        }
        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private C1.Win.C1FlexGrid.C1FlexGrid _flexXTab;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.StatusBar _status;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._flexXTab = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._status = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexXTab)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Country x Year";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(160, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "SalesPerson x Year";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(160, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "SalesPerson x Category";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(8, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "Country x Category";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(312, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 24);
            this.button5.TabIndex = 5;
            this.button5.Text = "Customer x Category";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(312, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 24);
            this.button6.TabIndex = 6;
            this.button6.Text = "Category x Quarter";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Left;
            this._flex.Location = new System.Drawing.Point(0, 65);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.ShowCursor = true;
            this._flex.Size = new System.Drawing.Size(192, 352);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 7;
            this._flex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Black;
            // 
            // _flexXTab
            // 
            this._flexXTab.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flexXTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexXTab.Location = new System.Drawing.Point(200, 65);
            this._flexXTab.Name = "_flexXTab";
            this._flexXTab.Rows.DefaultSize = 17;
            this._flexXTab.ShowCursor = true;
            this._flexXTab.Size = new System.Drawing.Size(463, 352);
            this._flexXTab.StyleInfo = resources.GetString("_flexXTab.StyleInfo");
            this._flexXTab.TabIndex = 7;
            this._flexXTab.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Black;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(192, 65);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 352);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // _status
            // 
            this._status.Location = new System.Drawing.Point(0, 417);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(663, 22);
            this._status.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(663, 439);
            this.Controls.Add(this._flexXTab);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._status);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 65, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crosstabs";
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexXTab)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT 
					YEAR(Orders.OrderDate) AS OrderYear, 
					Orders.ShipCountry, 
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice
				FROM Orders 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Products ON [Order Details].ProductID = Products.ProductID
				GROUP BY 
					YEAR(Orders.OrderDate), 
					Orders.ShipCountry";
			ShowTables(sql, "OrderYear", "ExtendedPrice");
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT 
					YEAR(Orders.OrderDate) AS OrderYear, 
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice, 
					(Employees.FirstName + ' ' + Employees.LastName) AS FullName
				FROM Orders 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
				GROUP BY 
					YEAR(Orders.OrderDate), 
					(Employees.FirstName + ' ' + Employees.LastName)";
			ShowTables(sql, "OrderYear", "ExtendedPrice");
		}
		private void button3_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT 
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice,
					Employees.LastName, 
					Categories.CategoryName
				FROM Orders 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
					INNER JOIN Products ON [Order Details].ProductID = Products.ProductID 
					INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
				GROUP BY 
					Employees.LastName,
					Categories.CategoryName";		
			ShowTables(sql, "CategoryName", "ExtendedPrice");
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT 
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice, 
					Categories.CategoryName, 
					Orders.ShipCountry
				FROM Orders 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Products ON [Order Details].ProductID = Products.ProductID 
					INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
				GROUP BY 
					Categories.CategoryName, 
					Orders.ShipCountry";
			ShowTables(sql, "CategoryName", "ExtendedPrice");
		}
		private void button5_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT 
					Customers.CompanyName,
					Customers.Country,
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice, 
					Categories.CategoryName
				FROM Customers 
					INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Products ON [Order Details].ProductID = Products.ProductID 
					INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
				GROUP BY 
					Customers.CompanyName, 
					Categories.CategoryName,
					Customers.Country";
			ShowTables(sql, "CategoryName", "ExtendedPrice");
		}
		private void button6_Click(object sender, System.EventArgs e)
		{
			string sql = @"
				SELECT
					SUM([Order Details].UnitPrice * [Order Details].Quantity) AS ExtendedPrice,
					Categories.CategoryName, 
					DATEPART(q, Orders.OrderDate) AS OrderQuarter
				FROM Customers 
					INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID 
					INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID 
					INNER JOIN Products ON [Order Details].ProductID = Products.ProductID 
					INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
				GROUP BY 
					Categories.CategoryName, 
					DATEPART(q, Orders.OrderDate)";
			ShowTables(sql, "OrderQuarter", "ExtendedPrice");
		}
		private void ShowTables(string sql, string pivotField, string valueField)
		{
			// create regular table
			string conn = "Integrated Security=SSPI;Initial Catalog=Northwind;Data Source=localhost";
			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// show it
			_flex.DataSource = dt;

			// create crosstab (PivotTable, with benchmark)
			DateTime start = DateTime.Now;
			DataTable dtx = new PivotTable(dt, pivotField, valueField, true);
			TimeSpan span = DateTime.Now - start;
			Console.WriteLine("pivot table created in {0} seconds", span.TotalSeconds);

			// show it
			_flexXTab.DataSource = dtx;

			// show how much we summarized here
			_status.Text = string.Format("Original table: {0} rows by {1} columns; PivotTable: {2} rows by {3} columns.",
				dt.Rows.Count, dt.Columns.Count, 
				dtx.Rows.Count, dtx.Columns.Count);
		}
    }
}
