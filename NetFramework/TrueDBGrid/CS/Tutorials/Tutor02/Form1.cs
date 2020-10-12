using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Tutorial_2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial_2.DsComposer dsComposer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			Application.EnableVisualStyles();
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
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();

            this.dsComposer1 = new Tutorial_2.DsComposer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.DataMember = "Composer";
            this.c1TrueDBGrid1.DataSource = this.dsComposer1;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RecordSelectorWidth = 17;
            this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid1.RowHeight = 15;
            this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(360, 178);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // dsComposer1
            // 
            this.dsComposer1.DataSetName = "DsComposer";
            this.dsComposer1.Locale = new System.Globalization.CultureInfo("en-US");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Execute SQL";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 80);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter SQL statement here";
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
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(360, 286);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Tutorial 02";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			oleDbDataAdapter1.Fill(dsComposer1);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string sqlStr = textBox1.Text;
			OleDbDataAdapter da = new OleDbDataAdapter(sqlStr, oleDbConnection1);
			DataSet ds = new DataSet();
			ds.Clear();
			try
			{
				da.Fill(ds,"mySQL");
				c1TrueDBGrid1.DataSource = null;
				c1TrueDBGrid1.ClearFields();
				c1TrueDBGrid1.DataSource = ds.Tables["mySQL"];
			}
			catch
			{
				Console.WriteLine("Error in SQL clause");
			}
		}
        private string GetModifiedConnectionString(string connstring)
        {
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
        }
    }
}
