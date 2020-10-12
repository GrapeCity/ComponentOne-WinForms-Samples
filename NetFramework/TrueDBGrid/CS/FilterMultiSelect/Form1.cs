using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FilterMultiEdit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private FilterMultiEdit.DataSet1 dataSet11;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
        private Panel panel1;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
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
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            this.dataSet11 = new FilterMultiEdit.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"),
            new System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"),
            new System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"),
            new System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"),
            new System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"),
            new System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"),
            new System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"),
            new System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"),
            new System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"),
            new System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Current, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio" +
                ".NET 2.0\\Common\\C1Nwind.mdb;";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" +
                "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " +
                "ShipVia FROM Orders";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Customers(CustomerID) VALUES (?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT CustomerID FROM Customers";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 424);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multiple Selections in";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "CustomerID",
            "EmployeeID",
            "OrderDate",
            "ShipCity",
            "ShipCountry",
            "Freight"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(115, 379);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style9;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.DataMember = "Customers";
            this.c1TrueDBDropdown1.DataSource = this.dataSet11;
            this.c1TrueDBDropdown1.EvenRowStyle = style10;
            this.c1TrueDBDropdown1.ExtendRightColumn = true;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style11;
            this.c1TrueDBDropdown1.HeadingStyle = style12;
            this.c1TrueDBDropdown1.HighLightRowStyle = style13;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(232, 168);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style14;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style15;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(100, 104);
            this.c1TrueDBDropdown1.Style = style16;
            this.c1TrueDBDropdown1.TabIndex = 1;
            this.c1TrueDBDropdown1.TabStop = false;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataMember = "Orders";
            this.c1TrueDBGrid1.DataSource = this.dataSet11;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(131, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(708, 424);
            this.c1TrueDBGrid1.TabIndex = 3;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(839, 424);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1TrueDBDropdown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet11);
			// the dropdown control is bound to the Customers table
			this.c1TrueDBGrid1.Columns["CustomerID"].DropDown = this.c1TrueDBDropdown1;
			// turn on the dropdown button in the filterbar
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].FilterButton = true;
			// turn it off for regulars cells in the grid
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].Button = false;
			this.c1TrueDBDropdown1.ColumnHeaders = false;

            checkedListBox1.Items.Clear();
            foreach(C1.Win.C1TrueDBGrid.C1DataColumn c in c1TrueDBGrid1.Columns)
            {
                c.FilterDropdown = true;
                c.FilterMultiSelect = false;
                checkedListBox1.Items.Add(c.DataField);
            }

            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);
            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.SetItemChecked(4, true);
            this.c1TrueDBGrid1.Columns["CustomerID"].FilterText = "A,S,VI";
            this.c1TrueDBGrid1.Columns["CustomerID"].FilterOperator = "like%";
            this.c1TrueDBGrid1.Columns["EmployeeID"].FilterText = "3,4,5";
		}

        private string GetModifiedConnectionString(string connstring)
        {
            int dataSource = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase);
            int dataSourceEnd = connstring.LastIndexOf('\\', connstring.IndexOf(';', dataSource));
            connstring = connstring.Substring(0, dataSource) + "Data Source=" +
             Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
             "\\ComponentOne Samples\\Common" + connstring.Substring(dataSourceEnd);
            return connstring;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.c1TrueDBGrid1.Columns[(string)checkedListBox1.Items[e.Index]].FilterMultiSelect = (e.NewValue == CheckState.Checked);
        }

	}
}
