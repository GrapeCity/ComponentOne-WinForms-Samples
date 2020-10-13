using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using C1.Win.C1FlexGrid;

namespace UnboundColumns
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(496, 358);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.SetUnboundValue += new C1.Win.C1FlexGrid.UnboundValueEventHandler(this._flex_SetUnboundValue);
			this._flex.GetUnboundValue += new C1.Win.C1FlexGrid.UnboundValueEventHandler(this._flex_GetUnboundValue);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 358);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Unbound columns";
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
			// load table from db
			string sql = "select * from products";
			string conn = GetConnectionString();
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			
			// bind to grid
			_flex.Cols[0].Width = 20;
			_flex.ShowCursor = true;
			_flex.DataSource = dt;

			// add calculated field
			dt.Columns.Add("ValueInStock", typeof(decimal), "UnitPrice * UnitsInStock");
			_flex.Cols["ValueInStock"].Format = "c";

			// add unbound column
			Column col = _flex.Cols.Add();
			col.Name = col.Caption = "Unbound";
		}

		// keep unbound values in a hashtable
		Hashtable _hash = new Hashtable();

		// get value from hashtable using ProductID as key
		void _flex_GetUnboundValue(object sender, C1.Win.C1FlexGrid.UnboundValueEventArgs e)
		{
			DataRowView drv = (DataRowView)_flex.Rows[e.Row].DataSource;
			e.Value = _hash[drv["ProductID"]];
		}

		// store value in hashtable using ProductID as key
		void _flex_SetUnboundValue(object sender, C1.Win.C1FlexGrid.UnboundValueEventArgs e)
		{
			DataRowView drv = (DataRowView)_flex.Rows[e.Row].DataSource;
			_hash[drv["ProductID"]] = e.Value;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
