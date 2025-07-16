using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using C1.Win.FlexGrid;

namespace Excel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnLoadSheet;
		private System.Windows.Forms.Button _btnSaveSheet;
		private System.Windows.Forms.Button _btnLoadData;
		private System.Windows.Forms.CheckBox _chkFixed;
		private System.Windows.Forms.Button _btnMultiSheet;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._btnLoadSheet = new System.Windows.Forms.Button();
			this._btnSaveSheet = new System.Windows.Forms.Button();
			this._btnLoadData = new System.Windows.Forms.Button();
			this._chkFixed = new System.Windows.Forms.CheckBox();
			this._btnMultiSheet = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Spill;
			this._flex.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Location = new System.Drawing.Point(0, 40);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(616, 317);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _btnLoadSheet
			// 
			this._btnLoadSheet.Location = new System.Drawing.Point(8, 8);
			this._btnLoadSheet.Name = "_btnLoadSheet";
			this._btnLoadSheet.Size = new System.Drawing.Size(96, 24);
			this._btnLoadSheet.TabIndex = 1;
			this._btnLoadSheet.Text = "&Load Sheet...";
			this._btnLoadSheet.Click += new System.EventHandler(this._btnLoadSheet_Click);
			// 
			// _btnSaveSheet
			// 
			this._btnSaveSheet.Location = new System.Drawing.Point(112, 8);
			this._btnSaveSheet.Name = "_btnSaveSheet";
			this._btnSaveSheet.Size = new System.Drawing.Size(96, 24);
			this._btnSaveSheet.TabIndex = 1;
			this._btnSaveSheet.Text = "&Save Sheet...";
			this._btnSaveSheet.Click += new System.EventHandler(this._btnSaveSheet_Click);
			// 
			// _btnLoadData
			// 
			this._btnLoadData.Location = new System.Drawing.Point(368, 8);
			this._btnLoadData.Name = "_btnLoadData";
			this._btnLoadData.Size = new System.Drawing.Size(72, 24);
			this._btnLoadData.TabIndex = 1;
			this._btnLoadData.Text = "Load &Data";
			this._btnLoadData.Click += new System.EventHandler(this._btnLoadData_Click);
			// 
			// _chkFixed
			// 
			this._chkFixed.Location = new System.Drawing.Point(224, 12);
			this._chkFixed.Name = "_chkFixed";
			this._chkFixed.Size = new System.Drawing.Size(120, 16);
			this._chkFixed.TabIndex = 2;
			this._chkFixed.Text = "Include fixed cells";
			// 
			// _btnMultiSheet
			// 
			this._btnMultiSheet.Location = new System.Drawing.Point(448, 8);
			this._btnMultiSheet.Name = "_btnMultiSheet";
			this._btnMultiSheet.Size = new System.Drawing.Size(120, 24);
			this._btnMultiSheet.TabIndex = 1;
			this._btnMultiSheet.Text = "Save &Multi-Sheet";
			this._btnMultiSheet.Click += new System.EventHandler(this._btnMultiSheet_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._chkFixed,
																		  this._btnLoadSheet,
																		  this._flex,
																		  this._btnSaveSheet,
																		  this._btnLoadData,
																		  this._btnMultiSheet});
			this.DockPadding.Top = 40;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Import and Export Excel files";
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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

		// load grid with data from the NWind database
		void _btnLoadData_Click(object sender, System.EventArgs e)
		{
			string conn = GetConnectionString();
			string sql = "select * from customers";
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flex.DataSource = dt;
		}

		// save a bool with several sheets in it
		void _btnMultiSheet_Click(object sender, System.EventArgs e)
		{
			// choose file
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.DefaultExt = "xls";
			dlg.FileName = "*.xls";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// delete file if it's already there
			if (File.Exists(dlg.FileName))
				File.Delete(dlg.FileName);

			// prepare to load data from database
			string mdbfile = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\c1nwind.mdb";
			string conn = @"provider=microsoft.jet.oledb.4.0;data source=" + mdbfile + ";";
			System.Data.OleDb.OleDbDataAdapter da;

			// save several sheets
			string[] tables = "Categories|Products|Employees|Customers|Orders".Split('|');
			foreach (string table in tables)
			{
				// load data into grid
				string sql = "select * from " + table;
				da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				_flex.DataSource = dt;
				_flex.Update();

				// save into a sheet
				_flex.SaveExcel(dlg.FileName, table, FileFlags.VisibleOnly | FileFlags.IncludeFixedCells);
			}
		}

		// load a single sheet from a book
		void _btnLoadSheet_Click(object sender, System.EventArgs e)
		{
			// choose file
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.DefaultExt = "xls";
			dlg.FileName = "*.xls";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// clear data source, if any
			_flex.DataSource = null;
			string[] sheets = _flex.LoadExcelSheetNames(dlg.FileName);
			Console.WriteLine("Found {0} sheets in this book.", sheets.Length);
			foreach (string sheet in sheets)
			{
				Console.WriteLine(" - {0}", sheet);
			}

			// load the first sheet in the book
			FileFlags flags = (_chkFixed.Checked)? FileFlags.IncludeFixedCells: FileFlags.None;
			_flex.LoadGrid(dlg.FileName, FileFormatEnum.Excel, flags);
		}

		// save to a single-sheet book
		void _btnSaveSheet_Click(object sender, System.EventArgs e)
		{
			// choose file
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.DefaultExt = "xls";
			dlg.FileName = "*.xls";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// save grid as sheet in the book
			FileFlags flags = (_chkFixed.Checked)? FileFlags.IncludeFixedCells: FileFlags.None;
			_flex.SaveGrid(dlg.FileName, FileFormatEnum.Excel, flags);
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
