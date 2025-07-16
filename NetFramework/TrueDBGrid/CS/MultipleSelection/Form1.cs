using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MultipleSelection
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
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private MultipleSelection.DataSet1 dataSet11;
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
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new MultipleSelection.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(536, 349);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1TrueDBGrid1_MouseDown);
            this.c1TrueDBGrid1.SelChange += new C1.Win.TrueDBGrid.CancelEventHandler(this.c1TrueDBGrid1_SelChange);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("First", "First"),
                        new System.Data.Common.DataColumnMapping("Last", "Last"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Birth", "Birth"),
                        new System.Data.Common.DataColumnMapping("Death", "Death")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Birth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Death", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Death", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Death1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Death", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_First", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_First1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Composer(Birth, Country, Death, First, Last) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"),
            new System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"),
            new System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"),
            new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"),
            new System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"),
            new System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"),
            new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"),
            new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Birth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Death", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Death", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Death1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Death", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_First", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_First1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(536, 349);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString();
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.c1TrueDBGrid1.DataSource = this.dataSet11.Composer;
		}
        // Starting from build 61251 SelChange raised also on
        // this.c1TrueDBGrid1.SelectedRows.Add(row);
        // so we should add the flag to know if we are changing selection by code
        bool _changingSelection = false;
		private void c1TrueDBGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            _changingSelection = true;
			// get the row the cursor is on
			int row = this.c1TrueDBGrid1.RowContaining(e.Y);
			if( row != -1 )
			{
				// if the row is in the SelectedRows collection then remove it (deselect)
				// if it isn't then add it (select)
				int index = this.c1TrueDBGrid1.SelectedRows.IndexOf(row);
				if( index != -1 )
					this.c1TrueDBGrid1.SelectedRows.RemoveAt(index);
				else
					this.c1TrueDBGrid1.SelectedRows.Add(row);
			}
            _changingSelection = false;
		}
		private void c1TrueDBGrid1_SelChange(object sender, C1.Win.TrueDBGrid.CancelEventArgs e)
		{
			// this event is fired when the selection is about to change (usually in response to a row or column change)
			// setting e.Cancel prevents the collection from being cleared
			if (!_changingSelection) e.Cancel = true;
		}

		private string GetModifiedConnectionString()
		{
            return string.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}

	}
}
