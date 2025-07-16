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
	public class Form1 : System.Windows.Forms.Form
	{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// fg
			// 
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "fg";
			this._flex.Size = new System.Drawing.Size(488, 309);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("fg.Tree.NodeImageCollapsed")));
			this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("fg.Tree.NodeImageExpanded")));
			this._flex.AfterDragColumn += new C1.Win.FlexGrid.DragRowColEventHandler(this.fg_AfterDragColumn);
			this._flex.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this.fg_AfterDataRefresh);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Analyze";
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
			// set up fg layout/behavior
			_flex.AllowSorting = AllowSortingEnum.None;
			_flex.AllowMerging = AllowMergingEnum.Nodes;
			_flex.SelectionMode = SelectionModeEnum.Cell;
			_flex.ExtendLastCol = true;
			_flex.Cols[0].Width = _flex.Cols.DefaultSize / 4;
			_flex.Tree.Style = TreeStyleFlags.Simple;
			_flex.Tree.Column = 1;

			// set up fg styles
			_flex.Styles.Normal.Border.Style = BorderStyleEnum.None;
			_flex.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;

			CellStyle s = _flex.Styles[CellStyleEnum.GrandTotal];
			s.BackColor = Color.Black;
			s.ForeColor = Color.White;

			s = _flex.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = Color.Gold;
			s.ForeColor = Color.Black;

			s = _flex.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = Color.Khaki;
			s.ForeColor = Color.Black;

			s = _flex.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = Color.LightGoldenrodYellow;
			s.ForeColor = Color.Black;

			// bind flex to data source
			_flex.DataSource = GetDataSource();

			// prevent user from dragging last three columns
			_flex.Cols[4].AllowDragging = false;
			_flex.Cols[5].AllowDragging = false;
			_flex.Cols[6].AllowDragging = false;
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

		C1.Win.FlexGrid.C1FlexGrid _flex;

		void fg_AfterDataRefresh(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			// total on Sale Amount
			int totalOn = _flex.Cols["Sale Amount"].SafeIndex;
			string caption = "Total for {0}";

            // don't update the screen while calculating the totals
            _flex.BeginUpdate();
            
            // calculate three levels of totals
            _flex.Subtotal(AggregateEnum.Sum, 0, 1, totalOn, caption);
			_flex.Subtotal(AggregateEnum.Sum, 1, 2, totalOn, caption);
			_flex.Subtotal(AggregateEnum.Sum, 2, 3, totalOn, caption);
			_flex.Tree.Show(2);

			// auto-size the grid to accommodate the tree
			_flex.AutoSizeCols(1, 1, 1000, 3, 30, AutoSizeFlags.IgnoreHidden);

            // restore screen updates
            _flex.EndUpdate();
		}

		void fg_AfterDragColumn(object sender, C1.Win.FlexGrid.DragRowColEventArgs e)
		{
			// sort the recordset when the user drags columns
			// this will cause a data refresh, removing all subtotals and
			// firing the AfterDataRefresh event, which rebuilds the subtotals.
			string sort = _flex.Cols[1].Name + ", " + _flex.Cols[2].Name + ", " + _flex.Cols[3].Name;
			DataTable dt = (DataTable)_flex.DataSource;
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
