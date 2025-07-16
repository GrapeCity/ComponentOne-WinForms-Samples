using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace DBTree
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(432, 325);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.AfterDragColumn += new C1.Win.FlexGrid.DragRowColEventHandler(this._flex_AfterDragColumn);
			this._flex.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this._flex_AfterDataRefresh);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Databound Tree Display";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		void Form1_Load(object sender, System.EventArgs e)
		{
            string conn = GetConnectionString();
			string rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
				"FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
				"INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID " +
				"ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

			Cursor = Cursors.WaitCursor;
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataSet ds = new DataSet();
			da.Fill(ds);
			Cursor = Cursors.Default;

			_flex.Cols[0].Width = 2 * _flex.Rows[0].HeightDisplay;
			_flex.DataSource = ds.Tables[0];

			_flex.AllowSorting = AllowSortingEnum.None;
			_flex.Cols[4].AllowDragging = false;
			_flex.Cols[5].AllowDragging = false;
			_flex.Cols[6].AllowDragging = false;

			updateDataTree();
		}
		void _flex_AfterDragColumn(object sender, C1.Win.FlexGrid.DragRowColEventArgs e)
		{
			updateDataTree();
		}
		void updateDataTree()
		{
			// sort the recordset when the user drags columns
			// this will cause a date refresh, removing all subtotals and
			// firing the AfterDataRefresh event, which rebuilds the subtotals.
			string strSort = _flex.Cols[1].Name + ", " + _flex.Cols[2].Name + ", " + _flex.Cols[3].Name;
			DataTable dt = _flex.DataSource as DataTable;
			if (dt != null) 
				dt.DefaultView.Sort = strSort;
		}

		void _flex_AfterDataRefresh(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			_flex.Tree.Style = TreeStyleFlags.Simple;
			_flex.Tree.Column = 1;
			_flex.AllowMerging = AllowMergingEnum.Nodes;

			int totalOn = _flex.Cols["Sale Amount"].SafeIndex;
			_flex.Subtotal(AggregateEnum.Sum, 0, 1, totalOn);
			_flex.Subtotal(AggregateEnum.Sum, 1, 2, totalOn);
			_flex.Subtotal(AggregateEnum.Sum, 2, 3, totalOn);
			_flex.AutoSizeCols(1, 1, 1000, 3, 30, AutoSizeFlags.IgnoreHidden);
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
