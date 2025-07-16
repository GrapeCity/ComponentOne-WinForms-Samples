using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace MultiParent
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flexMaster;
		private C1.Win.FlexGrid.C1FlexGrid _flexDetail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Splitter splitter1;
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
			this._flexMaster = new C1.Win.FlexGrid.C1FlexGrid();
			this._flexDetail = new C1.Win.FlexGrid.C1FlexGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this._flexMaster)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// _flexMaster
			// 
			this._flexMaster.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this._flexMaster.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexMaster.Dock = System.Windows.Forms.DockStyle.Top;
			this._flexMaster.Location = new System.Drawing.Point(0, 32);
			this._flexMaster.Name = "_flexMaster";
			this._flexMaster.Rows.DefaultSize = 17;
			this._flexMaster.Size = new System.Drawing.Size(454, 184);
			this._flexMaster.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexMaster.TabIndex = 0;
			this._flexMaster.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flexMaster_AfterEdit);
			// 
			// _flexDetail
			// 
			this._flexDetail.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this._flexDetail.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flexDetail.Location = new System.Drawing.Point(0, 221);
			this._flexDetail.Name = "_flexDetail";
			this._flexDetail.Rows.DefaultSize = 17;
			this._flexDetail.Size = new System.Drawing.Size(454, 190);
			this._flexDetail.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexDetail.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(454, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select one or more rows on the top grid by checking the \"Selected\" column. The bo" +
				"ttom grid will show the detail for all selected rows.";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 216);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(454, 5);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(454, 411);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flexDetail,
																		  this.splitter1,
																		  this._flexMaster,
																		  this.label1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: MultiParent Binding";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flexMaster)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexDetail)).EndInit();
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

		// create new dataset
		DataSet ds = new DataSet();
		DataTable dtDetails;

		void Form1_Load(object sender, System.EventArgs e)
		{
			// fill data set with orders, details
            string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter("select * from orders", conn);
			da.Fill(ds, "Orders");
			da = new OleDbDataAdapter("select * from [order details]", conn);
			da.Fill(ds, "[Order Details]");

			// set up a relation between orders and details
			DataColumn parentColumn = ds.Tables["Orders"].Columns["OrderID"];
			DataColumn childColumn = ds.Tables["[Order Details]"].Columns["OrderID"];
			ds.Relations.Add("Orders_Details", parentColumn, childColumn);

			// add a "Selected" column to the orders
			DataColumn selectionCol = new DataColumn("Selected", typeof(bool));
			selectionCol.DefaultValue = false;
			ds.Tables["Orders"].Columns.Add(selectionCol);

			// bind top grid to orders
			_flexMaster.SetDataBinding(ds, "Orders");
			_flexMaster.Cols[0].Width = 20;
			_flexDetail.Cols[0].Width = 20;

			// make "Selected" column the first one
			_flexMaster.Cols["Selected"].Move(1);

			// don't bind bottom grid, wait for selection to change
			// (this would the simple way to do master-detail)
			//_flexDetail.SetDataBinding(ds, "Orders.Orders_Details");
			//_flexDetail.SelectionMode = SelectionModeEnum.ListBox;

			// instead, bind the detail to an empty clone of the details
			// table and update the table when the user changes the selection
			dtDetails = ds.Tables["[Order Details]"].Clone();
			_flexDetail.DataSource = dtDetails;
		}

		void _flexMaster_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			if (_flexMaster.Cols[e.Col].Name == "Selected")
			{
				// the grid still has the focus and the cursor hasn't moved to a new row,
				// so the data source still doesn't see the row as changed.
				// so we use the currency manager to end the edits.
				CurrencyManager cm = (CurrencyManager)BindingContext[_flexMaster.DataSource, _flexMaster.DataMember];
				cm.EndCurrentEdit();

				// clear detail table
				dtDetails.BeginLoadData();
				dtDetails.Clear();

				// get selected orders
				DataTable dtOrders = ds.Tables["Orders"];
				DataRow[] drOrders = dtOrders.Select("Selected = true");

				// scan selected orders and add detail to new table
				foreach (DataRow drOrder in drOrders)
				{
					DataRow[] drDetails = drOrder.GetChildRows(ds.Relations[0]);
					foreach (DataRow drDetail in drDetails)
						dtDetails.Rows.Add(drDetail.ItemArray);
				}
				dtDetails.EndLoadData();
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
