using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ErrorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(472, 285);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.UseCompatibleTextRendering = true;
            this._flex.GetCellErrorInfo += new C1.Win.FlexGrid.GetErrorInfoEventHandler(this._flex_GetCellErrorInfo);
            this._flex.GetRowErrorInfo += new C1.Win.FlexGrid.GetErrorInfoEventHandler(this._flex_GetRowErrorInfo);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(472, 285);
            this.Controls.Add(this._flex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Display Error Information";
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
			// load some data from db
			string sql  = "select * from products";
			string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// add some errors to the table
			foreach (DataRow dr in dt.Rows)
			{
				// specific cells
				if ((int)dr["SupplierID"] == 4)
					dr.SetColumnError("SupplierID", "Supplier 4 is no longer active.\r\nHe retired and moved to Tahiti.");
				if ((int)dr["CategoryID"] == 7)
					dr.SetColumnError("CategoryID", "Category 7 has been deprecated.\r\nWe're moving out of the tobacco business.");

				// entire rows
				if ((int)dr["ProductID"] == 7)
					dr.RowError = "This is product 7. That's bad luck.";
				if ((int)dr["ProductID"] == 13)
					dr.RowError = "This is row 13. Even worse luck!!!\r\nPehaps you should leave it empty.";
			}

			// bind to grid
			_flex.DataSource = dt;

			// make sure grid shows the errors
			_flex.ShowErrors = true;

			// make the grid look nice
			_flex.ShowCursor = true;
			_flex.Cols[0].Width = 15;
		}

		// provide custom error information in addition to the IDataErrorInfo stuff
		void _flex_GetCellErrorInfo(object sender, C1.Win.FlexGrid.GetErrorInfoEventArgs e)
		{
			if (_flex.Cols[e.Col].Name == "UnitPrice")
			{
				if ((decimal)_flex[e.Row, e.Col] > 100)
				{
					string fmt = "This product has a high unit price ({0:c}),\r\n" +
						"call supplier {1} and negotiate a discount.";
					e.ErrorText = string.Format(fmt, _flex[e.Row, e.Col], _flex[e.Row, "SupplierID"]);
				}
			}
		}
		void _flex_GetRowErrorInfo(object sender, C1.Win.FlexGrid.GetErrorInfoEventArgs e)
		{
			if (object.Equals(_flex[e.Row, "Discontinued"], true))
			{
				e.ErrorText = "Please check that this product\r\nhas really been discontinued.";
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
