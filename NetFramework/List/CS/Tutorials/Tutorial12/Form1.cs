using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial12
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private C1.Win.List.C1List c1List2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
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
			C1.Win.List.Style style1 = new C1.Win.List.Style();
			C1.Win.List.Style style2 = new C1.Win.List.Style();
			C1.Win.List.Style style3 = new C1.Win.List.Style();
			C1.Win.List.Style style4 = new C1.Win.List.Style();
			C1.Win.List.Style style5 = new C1.Win.List.Style();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			C1.Win.List.Style style6 = new C1.Win.List.Style();
			C1.Win.List.Style style7 = new C1.Win.List.Style();
			C1.Win.List.Style style8 = new C1.Win.List.Style();
			C1.Win.List.Style style9 = new C1.Win.List.Style();
			C1.Win.List.Style style10 = new C1.Win.List.Style();
			C1.Win.List.Style style11 = new C1.Win.List.Style();
			C1.Win.List.Style style12 = new C1.Win.List.Style();
			C1.Win.List.Style style13 = new C1.Win.List.Style();
			C1.Win.List.Style style14 = new C1.Win.List.Style();
			C1.Win.List.Style style15 = new C1.Win.List.Style();
			C1.Win.List.Style style16 = new C1.Win.List.Style();
			this.C1List1 = new C1.Win.List.C1List();
			this.c1List2 = new C1.Win.List.C1List();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsComposer1 = new Tutorial12.DsComposer();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1List2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).BeginInit();
			this.SuspendLayout();
			// 
			// C1List1
			// 
			this.C1List1.AddItemSeparator = ';';
			this.C1List1.AllowHorizontalSplit = true;
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
			this.C1List1.Size = new System.Drawing.Size(408, 136);
			this.C1List1.Style = style8;
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.PropBag = resources.GetString("C1List1.PropBag");
			// 
			// c1List2
			// 
			this.c1List2.AddItemSeparator = ';';
			this.c1List2.CaptionHeight = 17;
			this.c1List2.CaptionStyle = style9;
			this.c1List2.ColumnCaptionHeight = 17;
			this.c1List2.ColumnFooterHeight = 17;
			this.c1List2.ColumnWidth = 100;
			this.c1List2.DataMember = "Composer";
			this.c1List2.DataSource = this.dsComposer1;
			this.c1List2.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.c1List2.EvenRowStyle = style10;
			this.c1List2.FooterStyle = style11;
			this.c1List2.HeadingStyle = style12;
			this.c1List2.HighLightRowStyle = style13;
			this.c1List2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1List2.Images"))));
			this.c1List2.ItemHeight = 15;
			this.c1List2.Location = new System.Drawing.Point(56, 176);
			this.c1List2.MatchEntryTimeout = ((long)(2000));
			this.c1List2.Name = "c1List2";
			this.c1List2.OddRowStyle = style14;
			this.c1List2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1List2.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1List2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1List2.SelectedStyle = style15;
			this.c1List2.Size = new System.Drawing.Size(408, 120);
			this.c1List2.Style = style16;
			this.c1List2.TabIndex = 1;
			this.c1List2.Text = "c1List2";
			this.c1List2.PropBag = resources.GetString("c1List2.PropBag");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 312);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Fix Columns";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(296, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 32);
			this.button2.TabIndex = 3;
			this.button2.Text = "&Unfix Columns";
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.ClientSize = new System.Drawing.Size(496, 349);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.c1List2);
			this.Controls.Add(this.C1List1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial12";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1List2)).EndInit();
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

			//hide all the columns from the left split except col 0 & 1
			for (int i = 2; i < this.C1List1.Columns.Count; i++)
				this.C1List1.Splits[0].DisplayColumns[i].Visible = false;

			//Configure the left split to display 2 columns exactly
			this.C1List1.Splits[0].SplitSizeMode = C1.Win.List.SizeModeEnum.NumberOfColumns;
			this.C1List1.Splits[0].SplitSize = 2;
			this.C1List1.Splits[0].AllowHorizontalSizing = false;

			//Make col0 & col1 invisible in the right split
			this.C1List1.Splits[1].DisplayColumns[0].Visible = false;
			this.C1List1.Splits[1].DisplayColumns[1].Visible = false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//make country & birth columns fixed
			this.c1List2.Splits[0].DisplayColumns["Birth"].FixColumn(true);
			this.c1List2.Splits[0].DisplayColumns["Country"].FixColumn(true, 1);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//make country & birth columns unfixed
			this.c1List2.Splits[0].DisplayColumns["Country"].FixColumn(false, 1);
			this.c1List2.Splits[0].DisplayColumns["Birth"].FixColumn(false, 0);
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
