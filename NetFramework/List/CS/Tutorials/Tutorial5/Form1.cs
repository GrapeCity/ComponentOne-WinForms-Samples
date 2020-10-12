using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;  //Add this line first

namespace Tutorial5
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private C1.Win.C1List.C1List c1List1;
		private OleDbCommand oleDbSelectCommand1;
		private OleDbConnection oleDbConnection1;
		private OleDbCommand oleDbInsertCommand1;
		private OleDbCommand oleDbUpdateCommand1;
		private OleDbCommand oleDbDeleteCommand1;
		private OleDbDataAdapter oleDbDataAdapter1;
		private DsComposer dsComposer1;
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
			C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
			C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.c1List1 = new C1.Win.C1List.C1List();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsComposer1 = new Tutorial5.DsComposer();
			((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 272);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(416, 88);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Enter SQL Statement Here";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Execute SQL";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// c1List1
			// 
			this.c1List1.AddItemSeparator = ';';
			this.c1List1.CaptionHeight = 17;
			this.c1List1.CaptionStyle = style1;
			this.c1List1.ColumnCaptionHeight = 17;
			this.c1List1.ColumnFooterHeight = 17;
			this.c1List1.ColumnWidth = 100;
			this.c1List1.DataMember = "Composer";
			this.c1List1.DataSource = this.dsComposer1;
			this.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.c1List1.EvenRowStyle = style2;
			this.c1List1.FooterStyle = style3;
			this.c1List1.HeadingStyle = style4;
			this.c1List1.HighLightRowStyle = style5;
			this.c1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1List1.Images"))));
			this.c1List1.ItemHeight = 15;
			this.c1List1.Location = new System.Drawing.Point(40, 12);
			this.c1List1.MatchEntryTimeout = ((long)(2000));
			this.c1List1.Name = "c1List1";
			this.c1List1.OddRowStyle = style6;
			this.c1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1List1.SelectedStyle = style7;
			this.c1List1.Size = new System.Drawing.Size(416, 193);
			this.c1List1.Style = style8;
			this.c1List1.TabIndex = 3;
			this.c1List1.Text = "c1List1";
			this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT     Composer.*\r\nFROM         Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO `Composer` (`First`, `Last`, `Country`, `Birth`, `Death`) VALUES (?, " +
				"?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "First"),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.VarWChar, 0, "Last"),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.VarWChar, 0, "Country"),
            new System.Data.OleDb.OleDbParameter("p4", System.Data.OleDb.OleDbType.Date, 0, "Birth"),
            new System.Data.OleDb.OleDbParameter("p5", System.Data.OleDb.OleDbType.Date, 0, "Death")});
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
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
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\Data\\C1ListDemo.mdb\"";
			// 
			// dsComposer1
			// 
			this.dsComposer1.DataSetName = "DsComposer";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 381);
			this.Controls.Add(this.c1List1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial5";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
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
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsComposer1);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DataSet ds = new DataSet();
			String  sqlStr;
			OleDbDataAdapter da;

			sqlStr = this.textBox1.Text;
			da = new OleDbDataAdapter(sqlStr, this.oleDbConnection1);

			try
			{
				da.Fill(ds, "TestSQL");
				this.c1List1.DataSource = null;
				this.c1List1.ClearFields();
				this.c1List1.DataSource = ds.Tables["TestSQL"]; 
			}
			catch(Exception ex)
			{
				MessageBox.Show("Invalid SQL Statement", "C1List");
			}
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
