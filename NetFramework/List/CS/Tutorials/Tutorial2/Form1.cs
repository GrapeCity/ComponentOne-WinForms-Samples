using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1List.C1Combo c1Combo1;
		private DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
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
			this.c1Combo1 = new C1.Win.C1List.C1Combo();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dataSet11 = new Tutorial2.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CaptionStyle = style1;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 17;
			this.c1Combo1.ColumnFooterHeight = 17;
			this.c1Combo1.ColumnWidth = 100;
			this.c1Combo1.ContentHeight = 15;
			this.c1Combo1.DataMember = "Composer";
			this.c1Combo1.DataSource = this.dataSet11;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 15;
			this.c1Combo1.EvenRowStyle = style2;
			this.c1Combo1.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard;
			this.c1Combo1.FooterStyle = style3;
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.HeadingStyle = style4;
			this.c1Combo1.HighLightRowStyle = style5;
			this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(61, 112);
			this.c1Combo1.MatchEntryTimeout = ((long)(2000));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.OddRowStyle = style6;
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.SelectedStyle = style7;
			this.c1Combo1.Size = new System.Drawing.Size(310, 21);
			this.c1Combo1.Style = style8;
			this.c1Combo1.TabIndex = 0;
			this.c1Combo1.Text = "c1Combo1";
			this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
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
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 273);
			this.Controls.Add(this.c1Combo1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial2";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
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
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
