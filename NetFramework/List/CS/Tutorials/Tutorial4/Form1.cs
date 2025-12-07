using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List dblOpus;
		private C1.Win.List.C1Combo dbcCombo;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private DataSet2 dataSet21;
		private DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand;
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
			this.dblOpus = new C1.Win.List.C1List();
			this.dataSet21 = new Tutorial4.DataSet2();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
			this.dbcCombo = new C1.Win.List.C1Combo();
			this.dataSet11 = new Tutorial4.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.dblOpus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbcCombo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// dblOpus
			// 
			this.dblOpus.AddItemSeparator = ';';
			this.dblOpus.CaptionHeight = 17;
			this.dblOpus.CaptionStyle = style1;
			this.dblOpus.ColumnCaptionHeight = 17;
			this.dblOpus.ColumnFooterHeight = 17;
			this.dblOpus.ColumnWidth = 100;
			this.dblOpus.DataMember = "Opus";
			this.dblOpus.DataSource = this.dataSet21;
			this.dblOpus.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.dblOpus.EvenRowStyle = style2;
			this.dblOpus.FooterStyle = style3;
			this.dblOpus.HeadingStyle = style4;
			this.dblOpus.HighLightRowStyle = style5;
			this.dblOpus.Images.Add(((System.Drawing.Image)(resources.GetObject("dblOpus.Images"))));
			this.dblOpus.ItemHeight = 15;
			this.dblOpus.Location = new System.Drawing.Point(224, 24);
			this.dblOpus.MatchEntryTimeout = ((long)(2000));
			this.dblOpus.Name = "dblOpus";
			this.dblOpus.OddRowStyle = style6;
			this.dblOpus.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.dblOpus.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.dblOpus.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.dblOpus.SelectedStyle = style7;
			this.dblOpus.Size = new System.Drawing.Size(224, 232);
			this.dblOpus.Style = style8;
			this.dblOpus.TabIndex = 0;
			this.dblOpus.Text = "c1List1";
			this.dblOpus.PropBag = resources.GetString("dblOpus.PropBag");
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			// 
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\Data\\C1ListDemo.mdb\"";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT     [Last]\r\nFROM         Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Last", "Last")})});
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT     [Last], Opus\r\nFROM         Opus";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Opus", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Last", "Last"),
                        new System.Data.Common.DataColumnMapping("Opus", "Opus")})});
			// 
			// oleDbInsertCommand
			// 
			this.oleDbInsertCommand.CommandText = "INSERT INTO `Composer` (`Last`) VALUES (?)";
			this.oleDbInsertCommand.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "Last")});
			// 
			// dbcCombo
			// 
			this.dbcCombo.AddItemSeparator = ';';
			this.dbcCombo.Caption = "";
			this.dbcCombo.CaptionHeight = 17;
			this.dbcCombo.CaptionStyle = style9;
			this.dbcCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.dbcCombo.ColumnCaptionHeight = 17;
			this.dbcCombo.ColumnFooterHeight = 17;
			this.dbcCombo.ColumnHeaders = false;
			this.dbcCombo.ColumnWidth = 100;
			this.dbcCombo.ContentHeight = 15;
			this.dbcCombo.DataMember = "Composer";
			this.dbcCombo.DataSource = this.dataSet11;
			this.dbcCombo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.dbcCombo.DisplayMember = "Last";
			this.dbcCombo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.dbcCombo.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dbcCombo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.dbcCombo.EditorHeight = 15;
			this.dbcCombo.EvenRowStyle = style10;
			this.dbcCombo.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.dbcCombo.FooterStyle = style11;
			this.dbcCombo.GapHeight = 2;
			this.dbcCombo.HeadingStyle = style12;
			this.dbcCombo.HighLightRowStyle = style13;
			this.dbcCombo.Images.Add(((System.Drawing.Image)(resources.GetObject("dbcCombo.Images"))));
			this.dbcCombo.ItemHeight = 15;
			this.dbcCombo.Location = new System.Drawing.Point(32, 48);
			this.dbcCombo.MatchEntryTimeout = ((long)(100));
			this.dbcCombo.MaxDropDownItems = ((short)(5));
			this.dbcCombo.MaxLength = 32767;
			this.dbcCombo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.dbcCombo.Name = "dbcCombo";
			this.dbcCombo.OddRowStyle = style14;
			this.dbcCombo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.dbcCombo.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.dbcCombo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.dbcCombo.SelectedStyle = style15;
			this.dbcCombo.Size = new System.Drawing.Size(160, 21);
			this.dbcCombo.Style = style16;
			this.dbcCombo.TabIndex = 1;
			this.dbcCombo.Text = "c1Combo1";
			this.dbcCombo.Change += new C1.Win.List.ChangeEventHandler(this.dbcCombo_Change);
			this.dbcCombo.PropBag = resources.GetString("dbcCombo.PropBag");
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 293);
			this.Controls.Add(this.dbcCombo);
			this.Controls.Add(this.dblOpus);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial4";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dblOpus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbcCombo)).EndInit();
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

		private void dbcCombo_Change(object sender, EventArgs e)
		{
			DataRow[] dr;
			dr = this.dataSet21.Opus.Select("Last='" + this.dbcCombo.Text + "'");
			DataSet2.OpusDataTable tb;
			tb = new DataSet2.OpusDataTable();

			foreach( DataRow item in dr)
			{
				tb.ImportRow(item);
			}

			this.dblOpus.DataMember = "";
			this.dblOpus.DataSource = tb;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet21);

			dbcCombo_Change(null, EventArgs.Empty);
		}

		private string AdjustConnectionString(string connectionString)
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
