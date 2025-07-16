using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HierData
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.FlexGrid.C1FlexGrid flex1;
        private C1.Win.FlexGrid.C1FlexGrid flex2;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Label lblDetail;
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flex1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.flex2 = new C1.Win.FlexGrid.C1FlexGrid();
            this.lblMaster = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flex2)).BeginInit();
            this.SuspendLayout();
            // 
            // flex1
            // 
            this.flex1.BackColor = System.Drawing.SystemColors.Window;
            this.flex1.ColumnInfo = @"10,1,0,0,0,75,Columns:0{Width:29;}";
            this.flex1.Location = new System.Drawing.Point(8, 32);
            this.flex1.Name = "flex1";
            this.flex1.Size = new System.Drawing.Size(320, 256);
            this.flex1.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this.flex1.TabIndex = 2;
            this.flex1.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
            // 
            // flex2
            // 
            this.flex2.BackColor = System.Drawing.SystemColors.Window;
            this.flex2.ColumnInfo = @"10,1,0,0,0,75,Columns:0{Width:29;}";
            this.flex2.Location = new System.Drawing.Point(344, 32);
            this.flex2.Name = "flex2";
            this.flex2.Size = new System.Drawing.Size(312, 256);
            this.flex2.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this.flex2.TabIndex = 2;
            this.flex2.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
            // 
            // lblMaster
            // 
            this.lblMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMaster.Location = new System.Drawing.Point(8, 16);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(64, 16);
            this.lblMaster.TabIndex = 3;
            this.lblMaster.Text = "Master";
            this.lblMaster.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDetail
            // 
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(344, 16);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(208, 16);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Detail";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(666, 303);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.lblMaster,
                                                                          this.flex1,
                                                                          this.flex2,
                                                                          this.lblDetail});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Master-Detail data binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flex2)).EndInit();
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
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // create hierarchical DataSet
            DataRowCollection drc;
            DataColumnCollection dcc;
            DataSet ds = new DataSet("Hierarchical DataSet");

            ds.Tables.Add("Products");
            dcc = ds.Tables["Products"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("Name", typeof(string));
            dcc.Add("Value", typeof(decimal));

            drc = ds.Tables["Products"].Rows;
            drc.Add(new object[] { "P1", "Widget", 19.95 });
            drc.Add(new object[] { "P2", "Gadget", 22.75 });
            drc.Add(new object[] { "P3", "Sprocket", 33.10 });

            ds.Tables.Add("Customers");
            dcc = ds.Tables["Customers"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("Name", typeof(string));
            dcc.Add("Address", typeof(string));

            drc = ds.Tables["Customers"].Rows;
            drc.Add(new object[] { "C1", "John", "122 Penny Lane" });
            drc.Add(new object[] { "C2", "Paul", "666 Abbey Road" });
            drc.Add(new object[] { "C3", "George", "222 Chatham Road" });
            drc.Add(new object[] { "C4", "Ringo", "345 Oxford St." });

            ds.Tables.Add("Orders");
            dcc = ds.Tables["Orders"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("CustomerID", typeof(string));
            dcc.Add("Prty", typeof(int));
            dcc.Add("Date", typeof(DateTime));

            drc = ds.Tables["Orders"].Rows;
            drc.Add(new object[] { "O1", "C1", 1, new DateTime(2001, 12, 1) });
            drc.Add(new object[] { "O2", "C2", 2, new DateTime(2002, 1, 22) });
            drc.Add(new object[] { "O3", "C3", 3, new DateTime(2002, 1, 20) });
            drc.Add(new object[] { "O4", "C4", 1, new DateTime(2002, 1, 14) });
            drc.Add(new object[] { "O5", "C1", 3, new DateTime(2002, 1, 16) });

            ds.Tables.Add("OrderDetail");
            dcc = ds.Tables["OrderDetail"].Columns;
            dcc.Add("ID", typeof(string));
            dcc.Add("OrderID", typeof(string));
            dcc.Add("ProductID", typeof(string));
            dcc.Add("Qty", typeof(int));

            drc = ds.Tables["OrderDetail"].Rows;
            drc.Add(new object[] { "D1", "O1", "P1", 1 });
            drc.Add(new object[] { "D2", "O1", "P2", 12 });
            drc.Add(new object[] { "D3", "O1", "P3", 1 });
            drc.Add(new object[] { "D4", "O2", "P1", 1 });
            drc.Add(new object[] { "D5", "O2", "P2", 8 });
            drc.Add(new object[] { "D6", "O2", "P3", 1 });
            drc.Add(new object[] { "D7", "O3", "P1", 1 });
            drc.Add(new object[] { "D8", "O4", "P1", 1 });
            drc.Add(new object[] { "D9", "O4", "P2", 10 });
            drc.Add(new object[] { "D10", "O5", "P1", 1 });
            drc.Add(new object[] { "D11", "O5", "P2", 16 });
            drc.Add(new object[] { "D12", "O5", "P3", 1 });

            ds.Relations.Add("CustomerOrders", ds.Tables["Customers"].Columns["ID"], ds.Tables["Orders"].Columns["CustomerID"]);
            ds.Relations.Add("Order Details", ds.Tables["Orders"].Columns["ID"], ds.Tables["OrderDetail"].Columns["OrderID"]);
            ds.Relations.Add("Product Details", ds.Tables["Products"].Columns["ID"], ds.Tables["OrderDetail"].Columns["ProductID"]);

            // bind data set to flex1/flex2 controls
            flex1.DataMember = "Customers";
            flex1.DataSource = ds;
            flex2.DataMember = "Customers.CustomerOrders";
            flex2.DataSource = ds;
        }
    }
}