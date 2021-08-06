using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace Analyze
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Analyze : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Analyze()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analyze));
            this.fg = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fg.Location = new System.Drawing.Point(0, 0);
            this.fg.Name = "fg";
            this.fg.Size = new System.Drawing.Size(507, 305);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            this.fg.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fg.AfterDragColumn += new C1.Win.FlexGrid.DragRowColEventHandler(this.fg_AfterDragColumn);
            this.fg.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this.fg_AfterDataRefresh);
            // 
            // Analyze
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(507, 305);
            this.Controls.Add(this.fg);
            this.Name = "Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Analyze";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		void Form1_Load(object sender, System.EventArgs e)
		{
			// set up fg layout/behavior
			fg.AllowSorting = AllowSortingEnum.None;
			fg.AllowMerging = AllowMergingEnum.Nodes;
			fg.SelectionMode = SelectionModeEnum.Cell;
			fg.ExtendLastCol = true;
			fg.Cols[0].Width = fg.Cols.DefaultSize / 4;
			fg.Tree.Style = TreeStyleFlags.Simple;
			fg.Tree.Column = 1;

			// set up fg styles
			fg.Styles.Normal.Border.Style = BorderStyleEnum.None;
			fg.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;

			CellStyle s = fg.Styles[CellStyleEnum.GrandTotal];
			s.BackColor = Color.Black;
			s.ForeColor = Color.White;

			s = fg.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = Color.Gold;
			s.ForeColor = Color.Black;

			s = fg.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = Color.Khaki;
			s.ForeColor = Color.Black;

			s = fg.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = Color.LightGoldenrodYellow;
			s.ForeColor = Color.Black;

			// bind flex to data source
			fg.DataSource = GetDataSource();

			// prevent user from dragging last three columns
			fg.Cols[4].AllowDragging = false;
			fg.Cols[5].AllowDragging = false;
			fg.Cols[6].AllowDragging = false;
		}

		DataTable GetDataSource()
		{
			// set up connection string
			string conn = GetConnectionString();

			// set up SQL statement
			string rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, " +
				"Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
				"FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) " +
				"INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
				"INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
				"ON Products.ProductID = [Order Details].ProductID " +
				"ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

			// retrieve data into DataSet
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataSet ds = new DataSet();
			da.Fill(ds);

			// return data table
			return ds.Tables[0];
		}

		C1.Win.FlexGrid.C1FlexGrid fg;

		void fg_AfterDataRefresh(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			// total on Sale Amount
			int totalOn = fg.Cols["Sale Amount"].SafeIndex;
			string caption = "Total for {0}";

			// calculate three levels of totals
			fg.Subtotal(AggregateEnum.Sum, 0, 1, totalOn, caption);
			fg.Subtotal(AggregateEnum.Sum, 1, 2, totalOn, caption);
			fg.Subtotal(AggregateEnum.Sum, 2, 3, totalOn, caption);
			fg.Tree.Show(2);

			// autosize the fg to accommodate tree
			fg.AutoSizeCols(1, 1, 1000, 3, 30, AutoSizeFlags.IgnoreHidden);
		}

		void fg_AfterDragColumn(object sender, C1.Win.FlexGrid.DragRowColEventArgs e)
		{
			// sort the recordset when the user drags columns
			// this will cause a data refresh, removing all subtotals and
			// firing the AfterDataRefresh event, which rebuilds the subtotals.
			string sort = fg.Cols[1].Name + ", " + fg.Cols[2].Name + ", " + fg.Cols[3].Name;
			DataTable dt = (DataTable)fg.DataSource;
			dt.DefaultView.Sort = sort;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
