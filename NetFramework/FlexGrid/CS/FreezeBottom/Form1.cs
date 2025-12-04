using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace FlexFreezeBottomSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnCustomers;
		private System.Windows.Forms.Button _btnEmployees;
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._btnCustomers = new System.Windows.Forms.Button();
			this._btnEmployees = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = @"10,1,0,0,0,75,Columns:0{Width:35;}";
			this._flex.Location = new System.Drawing.Point(8, 40);
			this._flex.Name = "_flex";
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(432, 310);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;ForeColor:ControlText;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _btnCustomers
			// 
			this._btnCustomers.Location = new System.Drawing.Point(8, 8);
			this._btnCustomers.Name = "_btnCustomers";
			this._btnCustomers.Size = new System.Drawing.Size(120, 24);
			this._btnCustomers.TabIndex = 1;
			this._btnCustomers.Text = "Customers";
			this._btnCustomers.Click += new System.EventHandler(this._btnCustomers_Click);
			// 
			// _btnEmployees
			// 
			this._btnEmployees.Location = new System.Drawing.Point(144, 8);
			this._btnEmployees.Name = "_btnEmployees";
			this._btnEmployees.Size = new System.Drawing.Size(120, 24);
			this._btnEmployees.TabIndex = 1;
			this._btnEmployees.Text = "Employees";
			this._btnEmployees.Click += new System.EventHandler(this._btnEmployees_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 358);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnCustomers,
																		  this._flex,
																		  this._btnEmployees});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Frozen rows at the bottom of the grid";
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
			// initialize control
			_flex.AllowResizing = AllowResizingEnum.Both;
			_flex.AllowFreezing = AllowFreezingEnum.Both;

			// bind main grid to Customers table
			Bind("select * from customers");

			// create frozen area at the bottom, with 3 rows
			FlexFreezeBottom ffb = new FlexFreezeBottom(_flex, 3);
		}
		void _btnCustomers_Click(object sender, System.EventArgs e)
		{
			Bind("select * from customers");
		}
		void _btnEmployees_Click(object sender, System.EventArgs e)
		{
			Bind("select * from employees");
		}
		void Bind(string sql)
		{
			// bind grid to data source
			string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flex.DataSource = dt;

			// add row indices
			for (int r = 0; r < _flex.Rows.Count; r++)
				_flex[r,0] = r;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
