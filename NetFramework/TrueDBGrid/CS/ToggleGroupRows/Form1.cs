using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ToggleGroupRows
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private ToggleGroupRows.DataSet1 dataSet11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
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
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.dataSet11 = new ToggleGroupRows.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataSource = this.dataSet11.Orders;
            this.c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.GroupBy;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 16);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(536, 217);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.RowColChange += new C1.Win.TrueDBGrid.RowColChangeEventHandler(this.c1TrueDBGrid1_RowColChange);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(576, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(16, 120);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(136, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Collapse All";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(16, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(136, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Expand All";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Collapse Group row";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(16, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Expand Group row";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(760, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
			// intialize the grid to be grouped by CustomerID on load
			this.c1TrueDBGrid1.GroupedColumns.Add(this.c1TrueDBGrid1.Columns["CustomerID"]);
		}

		// expand a grouped row
		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if( this.radioButton1.Checked )
			{
				int row = this.c1TrueDBGrid1.Row;
				if( this.c1TrueDBGrid1.Splits[0].Rows[row].RowType == C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow )
					this.c1TrueDBGrid1.ExpandGroupRow(row);
			}
		}

		// collapse a grouped row
		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if( this.radioButton2.Checked )
			{
				int row = this.c1TrueDBGrid1.Row;
				if( this.c1TrueDBGrid1.Splits[0].Rows[row].RowType == C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow )
					this.c1TrueDBGrid1.CollapseGroupRow(row);
			}
		}

		// expand all grouped rows
		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if( this.radioButton3.Checked )
			{
				for(int i=0; i < this.c1TrueDBGrid1.Splits[0].Rows.Count; i++)
				{
					if( this.c1TrueDBGrid1.Splits[0].Rows[i].RowType != C1.Win.TrueDBGrid.RowTypeEnum.DataRow )
						this.c1TrueDBGrid1.ExpandGroupRow(i);
				}
			}
		}

		// collapse all grouped rows
		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if( this.radioButton4.Checked )
			{
				for(int i=0; i < this.c1TrueDBGrid1.Splits[0].Rows.Count; i++)
				{
					if( this.c1TrueDBGrid1.Splits[0].Rows[i].RowType != C1.Win.TrueDBGrid.RowTypeEnum.DataRow )
						this.c1TrueDBGrid1.CollapseGroupRow(i);
				}
			}
		}

		// set the state of the expand/collapse radio button on row change
		private void c1TrueDBGrid1_RowColChange(object sender, C1.Win.TrueDBGrid.RowColChangeEventArgs e)
		{
            if ((this.c1TrueDBGrid1.Splits[0].Rows.Count <= 0) || (this.c1TrueDBGrid1.Splits[0].Rows[this.c1TrueDBGrid1.Row] == null)) return; //#10989
            // get the type/state of the row
			C1.Win.TrueDBGrid.RowTypeEnum rtype = this.c1TrueDBGrid1.Splits[0].Rows[this.c1TrueDBGrid1.Row].RowType;
			switch (rtype)
			{
				case C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow:
					this.radioButton2.Checked = true;
					break;
				case C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow:
					this.radioButton1.Checked = true;
					break;
			}
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
	}
}
