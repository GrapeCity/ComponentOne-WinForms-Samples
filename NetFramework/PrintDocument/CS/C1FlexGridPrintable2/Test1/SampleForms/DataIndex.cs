using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataIndex
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
		private System.Windows.Forms.StatusBar _stBar;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
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
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._stBar = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:20;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 19;
            this._flex.ShowCursor = true;
            this._flex.Size = new System.Drawing.Size(457, 229);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.AfterDragColumn += new C1.Win.C1FlexGrid.DragRowColEventHandler(this._flex_AfterDragColumn);
            this._flex.RowColChange += new System.EventHandler(this._flex_RowColChange);
            this._flex.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this._flex_AfterDataRefresh);
            // 
            // _stBar
            // 
            this._stBar.Location = new System.Drawing.Point(0, 229);
            this._stBar.Name = "_stBar";
            this._stBar.Size = new System.Drawing.Size(457, 16);
            this._stBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(457, 245);
            this.Controls.Add(this._flex);
            this.Controls.Add(this._stBar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: DataIndex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data table
			DataTable dt = new DataTable();
			dt.Columns.Add("Customer", typeof(string));
			dt.Columns.Add("Product", typeof(string));
			dt.Columns.Add("Date", typeof(DateTime));
			dt.Columns.Add("Amount", typeof(decimal));

			// populate data table
			Random rnd = new Random();
			string[] customers = "GM|Ford|Chrysler|Toyota|Honda|Mazda|Mitsubishi|Mercedes".Split('|');
			string[] products  = "Palm PC|Monitor|Keyboard|Printer|Fax|Copier|Mouse|Headphone".Split('|');
			object[] data = new object[4];
			for (int i = 0; i < 200; i++)
			{
				data[0] = customers[rnd.Next(customers.Length-1)];
				data[1] = products[rnd.Next(products.Length-1)];
				data[2] = DateTime.Now.AddDays(-356 * rnd.Next(-365, 0));
				data[3] = rnd.NextDouble() * 10000;
				dt.Rows.Add(data);
			}
			dt.AcceptChanges();

			// sort data table
			dt.DefaultView.Sort = "Customer, Product";

			// bind to grid
			_flex.DataSource = dt;

			// configure grid
			_flex.Cols["Amount"].Format = "c";
			_flex.Cols["Amount"].AllowDragging = false;
			_flex.Cols["Date"].AllowDragging = false;
			_flex.AutoSizeCols();
			_flex.Cols[1].Width += 40;
			_flex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.MultiColumn;
		}

		private void _flex_AfterDataRefresh(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			UpdateTotals();
		}
		private void _flex_AfterDragColumn(object sender, C1.Win.C1FlexGrid.DragRowColEventArgs e)
		{
			UpdateTotals();
		}
		private void _flex_RowColChange(object sender, System.EventArgs e)
		{
			UpdateStatus();
		}

		private void UpdateTotals()
		{
			// set up tree
			_flex.Tree.Column = 1;

			// clear existing totals
			_flex.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear);

			// total amounts per product and customer
			int totalOn = _flex.Cols["Amount"].Index;
			_flex.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 1, totalOn);
			_flex.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 2, totalOn);

			// update status
			UpdateStatus();
		}
		private void UpdateStatus()
		{
			// get current row's DataIndex (skip nodes and fixed rows)
			int current = (_flex.Row > 0)? _flex.Rows[_flex.Row].DataIndex: -1;

			// not a data row?
			if (current < 0)
			{
				_stBar.Text = "Not a data row";
				return;
			}

			// count data rows
			int last = -1;
			for (int index = _flex.Rows.Count-1; index > 0 && last < 0; index--)
				last = _flex.Rows[index].DataIndex;

			// get underlying DataRow
			CurrencyManager cm = BindingContext[_flex.DataSource, _flex.DataMember] as CurrencyManager;
			DataRowView drv = cm.List[current] as DataRowView;

			// show current, total
			_stBar.Text = string.Format("Row {0} of {1}: {2}", current+1, last+1, drv.Row.RowState);
		}
	}
}
