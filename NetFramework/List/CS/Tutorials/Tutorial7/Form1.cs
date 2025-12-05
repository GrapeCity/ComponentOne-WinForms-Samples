using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial7
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private DataTable dtCopy;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Tutorial7.DsComposer dsComposer1; 
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
			dtCopy = new DataTable();
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
			C1.Win.List.Style style1 = new C1.Win.List.Style();
			C1.Win.List.Style style2 = new C1.Win.List.Style();
			C1.Win.List.Style style3 = new C1.Win.List.Style();
			C1.Win.List.Style style4 = new C1.Win.List.Style();
			C1.Win.List.Style style5 = new C1.Win.List.Style();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			C1.Win.List.Style style6 = new C1.Win.List.Style();
			C1.Win.List.Style style7 = new C1.Win.List.Style();
			C1.Win.List.Style style8 = new C1.Win.List.Style();
			this.C1List1 = new C1.Win.List.C1List();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsComposer1 = new Tutorial7.DsComposer();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).BeginInit();
			this.SuspendLayout();
			// 
			// C1List1
			// 
			this.C1List1.AddItemSeparator = ';';
			this.C1List1.CaptionHeight = 17;
			this.C1List1.CaptionStyle = style1;
			this.C1List1.ColumnCaptionHeight = 17;
			this.C1List1.ColumnFooterHeight = 17;
			this.C1List1.ColumnWidth = 100;
			this.C1List1.DataMember = "Composer";
			this.C1List1.DataSource = this.dsComposer1;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.EvenRowStyle = style2;
			this.C1List1.FooterStyle = style3;
			this.C1List1.HeadingStyle = style4;
			this.C1List1.HighLightRowStyle = style5;
			this.C1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("C1List1.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(56, 24);
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.OddRowStyle = style6;
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.SelectedStyle = style7;
			this.C1List1.Size = new System.Drawing.Size(408, 272);
			this.C1List1.Style = style8;
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.UnboundColumnFetch += new C1.Win.List.UnboundColumnFetchEventHandler(this.C1List1_UnboundColumnFetch);
			this.C1List1.PropBag = resources.GetString("C1List1.PropBag");
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT     Composer.*\r\nFROM         Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("First", "First"),
                        new System.Data.Common.DataColumnMapping("Last", "Last"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Birth", "Birth"),
                        new System.Data.Common.DataColumnMapping("Death", "Death")})});
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
			this.ClientSize = new System.Drawing.Size(496, 325);
			this.Controls.Add(this.C1List1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial7";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsComposer1);
			dtCopy = this.dsComposer1.Tables[0].Copy();

			this.C1List1.Splits[0].DisplayColumns["Last"].Visible = false;
			this.C1List1.Splits[0].DisplayColumns["First"].Visible = false;
		}

		private void C1List1_UnboundColumnFetch(object sender, C1.Win.List.UnboundColumnFetchEventArgs e)
		{
			if (e.Col == 0 && e.Row < dtCopy.Rows.Count)
				e.Value = dtCopy.Rows[e.Row]["First"] + " " + dtCopy.Rows[e.Row]["Last"];
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
