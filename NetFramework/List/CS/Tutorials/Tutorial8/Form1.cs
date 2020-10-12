using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial8
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1List.C1List C1List1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial8.DsContacts dsContacts1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.C1List1 = new C1.Win.C1List.C1List();
			this.dsContacts1 = new Tutorial8.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
			this.SuspendLayout();
			// 
			// C1List1
			// 
			this.C1List1.AddItemCols = 0;
			this.C1List1.AddItemSeparator = ';';
			this.C1List1.AllowSort = true;
			this.C1List1.AlternatingRows = false;
			this.C1List1.CaptionHeight = 17;
			this.C1List1.ColumnCaptionHeight = 17;
			this.C1List1.ColumnFooterHeight = 17;
			this.C1List1.ColumnWidth = 100;
			this.C1List1.DataSource = this.dsContacts1.Contacts;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("C1List1.Images.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(32, 24);
			this.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember;
			this.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None;
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.ScrollTips = false;
			this.C1List1.Size = new System.Drawing.Size(416, 224);
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.PropBag = ((string)(resources.GetObject("C1List1.PropBag")));
			// 
			// dsContacts1
			// 
			this.dsContacts1.DataSetName = "DsContacts";
			this.dsContacts1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsContacts1.Namespace = "http://www.tempuri.org/DsContacts.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Contacts", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CONTACTS.UserCode", "CONTACTS.UserCode"),
																																																					new System.Data.Common.DataColumnMapping("ContactDate", "ContactDate"),
																																																					new System.Data.Common.DataColumnMapping("Callback", "Callback"),
																																																					new System.Data.Common.DataColumnMapping("Comments", "Comments"),
																																																					new System.Data.Common.DataColumnMapping("ContactType", "ContactType"),
																																																					new System.Data.Common.DataColumnMapping("CUSTOMER.UserCode", "CUSTOMER.UserCode"),
																																																					new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					new System.Data.Common.DataColumnMapping("Company", "Company"),
																																																					new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
																																																					new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					new System.Data.Common.DataColumnMapping("CustType", "CustType")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Contacts.Callback, Contacts.Comments, Contacts.ContactDate, Contacts.ContactType, Contacts.UserCode, Customer.Company, Customer.Contacted, Customer.CustType, Customer.FirstName, Customer.LastName, Customer.Phone, Customer.UserCode AS Expr1 FROM Contacts INNER JOIN Customer ON Contacts.UserCode = Customer.UserCode";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=..\\..\\..\\Data\\C1ListDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.C1List1});
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial8";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).EndInit();
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
			this.oleDbDataAdapter1.Fill(this.dsContacts1);
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
