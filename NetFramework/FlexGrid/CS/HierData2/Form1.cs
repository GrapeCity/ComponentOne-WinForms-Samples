using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace HierData
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Label lblDetail;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1FlexGrid.C1FlexGrid _flexCustomers;
		private C1.Win.C1FlexGrid.C1FlexGrid _flexOrders;
		private C1.Win.C1FlexGrid.C1FlexGrid _flexDetails;
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
			this._flexCustomers = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._flexOrders = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.lblMaster = new System.Windows.Forms.Label();
			this.lblDetail = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._flexDetails = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flexCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// _flexCustomers
			// 
			this._flexCustomers.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:29;}\t";
			this._flexCustomers.Location = new System.Drawing.Point(8, 32);
			this._flexCustomers.Name = "_flexCustomers";
			this._flexCustomers.Rows.DefaultSize = 17;
			this._flexCustomers.Size = new System.Drawing.Size(648, 176);
			this._flexCustomers.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexCustomers.TabIndex = 2;
			this._flexCustomers.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// _flexOrders
			// 
			this._flexOrders.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:29;}\t";
			this._flexOrders.Location = new System.Drawing.Point(8, 248);
			this._flexOrders.Name = "_flexOrders";
			this._flexOrders.Rows.DefaultSize = 17;
			this._flexOrders.Size = new System.Drawing.Size(320, 184);
			this._flexOrders.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexOrders.TabIndex = 2;
			this._flexOrders.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// lblMaster
			// 
			this.lblMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMaster.Location = new System.Drawing.Point(8, 16);
			this.lblMaster.Name = "lblMaster";
			this.lblMaster.Size = new System.Drawing.Size(72, 16);
			this.lblMaster.TabIndex = 3;
			this.lblMaster.Text = "Customers";
			this.lblMaster.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblDetail
			// 
			this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDetail.Location = new System.Drawing.Point(8, 232);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(80, 16);
			this.lblDetail.TabIndex = 3;
			this.lblDetail.Text = "Orders";
			this.lblDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(336, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Details";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _flexDetails
			// 
			this._flexDetails.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:29;}\t";
			this._flexDetails.Location = new System.Drawing.Point(336, 248);
			this._flexDetails.Name = "_flexDetails";
			this._flexDetails.Rows.DefaultSize = 17;
			this._flexDetails.Size = new System.Drawing.Size(320, 184);
			this._flexDetails.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexDetails.TabIndex = 2;
			this._flexDetails.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(666, 439);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblMaster,
																		  this._flexCustomers,
																		  this._flexOrders,
																		  this.lblDetail,
																		  this.label1,
																		  this._flexDetails});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Master-Detail data binding";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flexCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexDetails)).EndInit();
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

        // build data set
        void Form1_Load(object sender, System.EventArgs e)
        {
            // create hierarchical DataSet
			DataSet ds = new DataSet("Hierarchical DataSet");
			string conn = GetConnectionString();

			// load tables
			string sql = "select * from customers";
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			da.Fill(ds, "Customers");
			
			sql = "select * from orders";
			da = new OleDbDataAdapter(sql, conn);
			da.Fill(ds, "Orders");
            
			sql = "select * from [order details]";
			da = new OleDbDataAdapter(sql, conn);
			da.Fill(ds, "Details");
			
			// create relations
            ds.Relations.Add("CustomerOrders", ds.Tables["Customers"].Columns["CustomerID"], ds.Tables["Orders"].Columns["CustomerID"]);
            ds.Relations.Add("OrderDetails", ds.Tables["Orders"].Columns["OrderID"], ds.Tables["Details"].Columns["OrderID"]);

            // bind data set to grids
			_flexCustomers.SetDataBinding(ds, "Customers");
			_flexOrders.SetDataBinding(ds, "Customers.CustomerOrders");
			_flexDetails.SetDataBinding(ds, "Customers.CustomerOrders.OrderDetails");
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
