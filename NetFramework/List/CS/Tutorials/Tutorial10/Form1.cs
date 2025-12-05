using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial10
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private bool bFlag1;
		private bool bFlag2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private DsCustomers dsCustomers1;
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
			C1.Win.List.Style style1 = new C1.Win.List.Style();
			C1.Win.List.Style style2 = new C1.Win.List.Style();
			C1.Win.List.Style style3 = new C1.Win.List.Style();
			C1.Win.List.Style style4 = new C1.Win.List.Style();
			C1.Win.List.Style style5 = new C1.Win.List.Style();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			C1.Win.List.Style style6 = new C1.Win.List.Style();
			C1.Win.List.Style style7 = new C1.Win.List.Style();
			C1.Win.List.Style style8 = new C1.Win.List.Style();
			this.C1List1 = new C1.Win.List.C1List();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsCustomers1 = new Tutorial10.DsCustomers();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers1)).BeginInit();
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
			this.C1List1.DataMember = "Customer";
			this.C1List1.DataSource = this.dsCustomers1;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.EvenRowStyle = style2;
			this.C1List1.FooterStyle = style3;
			this.C1List1.HeadingStyle = style4;
			this.C1List1.HighLightRowStyle = style5;
			this.C1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("C1List1.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(40, 16);
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.OddRowStyle = style6;
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.SelectedStyle = style7;
			this.C1List1.Size = new System.Drawing.Size(560, 240);
			this.C1List1.Style = style8;
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.FetchRowStyle += new C1.Win.List.FetchRowStyleEventHandler(this.C1List1_FetchRowStyle);
			this.C1List1.PropBag = resources.GetString("C1List1.PropBag");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Prospective Customers";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(256, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "Distributors";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(472, 280);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 32);
			this.button3.TabIndex = 3;
			this.button3.Text = "Reset the List";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT     Customer.*\r\nFROM         Customer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Company", "Company"),
                        new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("CustType", "CustType")})});
			// 
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\Data\\C1ListDemo.mdb\"";			// 
			// dsCustomers1
			// 
			this.dsCustomers1.DataSetName = "DsCustomers";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 325);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.C1List1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial10";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers1)).EndInit();
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
			this.oleDbDataAdapter1.Fill(this.dsCustomers1);
			bFlag1 = bFlag2 = false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.C1List1.FetchRowStyles  = true;
			bFlag1 = true;
			this.C1List1.Refresh();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.C1List1.FetchRowStyles = true;
			bFlag2 = true;
			this.C1List1.Refresh();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			bFlag1 = bFlag2 = false;
			this.C1List1.Refresh();
		}

		private void C1List1_FetchRowStyle(object sender, C1.Win.List.FetchRowStyleEventArgs e)
		{
			if (bFlag1 && Int32.Parse(this.C1List1.Columns["CustType"].CellText(e.Row)) == 1)
			{
				Font fntFont = new Font(e.CellStyle.Font.Name, e.CellStyle.Font.Size, FontStyle.Bold);
				e.CellStyle.Font = fntFont;
				e.CellStyle.ForeColor = Color.Blue;
			}

			if (bFlag2 && Int32.Parse(this.C1List1.Columns["CustType"].CellText(e.Row)) == 4)
			{
				e.CellStyle.ForeColor = Color.White;
				e.CellStyle.BackColor = Color.Red;
			}
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
