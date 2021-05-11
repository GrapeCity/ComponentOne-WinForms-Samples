using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1ReportParms;

namespace ParseParameters
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox _txtSource;
		private System.Windows.Forms.TextBox _txtQuery;
		private System.Windows.Forms.DataGrid _dataGrid;
		private System.Windows.Forms.Button _btnUpdate;
		private System.Windows.Forms.Button _btnPreview;
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
            this._c1r = new C1.C1Report.C1Report();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtQuery = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._dataGrid = new System.Windows.Forms.DataGrid();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Employee Sales by Country";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtSource
            // 
            this._txtSource.Location = new System.Drawing.Point(104, 8);
            this._txtSource.Multiline = true;
            this._txtSource.Name = "_txtSource";
            this._txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtSource.Size = new System.Drawing.Size(480, 142);
            this._txtSource.TabIndex = 1;
            this._txtSource.TextChanged += new System.EventHandler(this._txtSource_TextChanged);
            this._txtSource.Leave += new System.EventHandler(this._txtSource_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parameters:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Query:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtQuery
            // 
            this._txtQuery.Location = new System.Drawing.Point(104, 248);
            this._txtQuery.Multiline = true;
            this._txtQuery.Name = "_txtQuery";
            this._txtQuery.ReadOnly = true;
            this._txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtQuery.Size = new System.Drawing.Size(480, 142);
            this._txtQuery.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 2);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // _dataGrid
            // 
            this._dataGrid.CaptionVisible = false;
            this._dataGrid.DataMember = "";
            this._dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this._dataGrid.Location = new System.Drawing.Point(104, 152);
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.Size = new System.Drawing.Size(480, 80);
            this._dataGrid.TabIndex = 12;
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Location = new System.Drawing.Point(16, 280);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(80, 24);
            this._btnUpdate.TabIndex = 13;
            this._btnUpdate.Text = "Update";
            this._btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnPreview
            // 
            this._btnPreview.Location = new System.Drawing.Point(16, 312);
            this._btnPreview.Name = "_btnPreview";
            this._btnPreview.Size = new System.Drawing.Size(80, 24);
            this._btnPreview.TabIndex = 13;
            this._btnPreview.Text = "Preview...";
            this._btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPreview.Click += new System.EventHandler(this._btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtQuery);
            this.Controls.Add(this._btnPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report Demo: Parsing Parameterized Queries";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
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

		// private fields
		private C1ReportParameters _rp;
		private bool _dirty = false;

		// parse parameters when recordsource changes
		private void ParseParameters()
		{
			// parse new parameters
			string rs = _txtSource.Text;
			_rp = new C1ReportParameters(rs);

			// we're clean
			_dirty = false;

			// show parameters
			_dataGrid.DataSource = _rp.List;

			// and show query
			_txtQuery.Text = _rp.QueryString;
		}

		
		// initialize form
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// make sure ConnectionString points to the local NorthWind mdb
            string MDBFILE =
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb";

			string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MDBFILE + ";";
			_c1r.DataSource.ConnectionString = conn;

			// initialize form
			string rs = _c1r.DataSource.RecordSource;
			_txtSource.Text = rs;
			ParseParameters();
		}

		// parse parameters after any changes to the recordsoure
		private void _txtSource_TextChanged(object sender, System.EventArgs e)
		{
			_dirty = true;		
		}
		private void _txtSource_Leave(object sender, System.EventArgs e)
		{
			if (_dirty)
				ParseParameters();
		}

		// rebuild query string with current parameters
		private void _btnUpdate_Click(object sender, System.EventArgs e)
		{
			_txtQuery.Text = _rp.QueryString;
		}

		// show report with current parameters
		private void _btnPreview_Click(object sender, System.EventArgs e)
		{
			// render report
			Cursor = Cursors.WaitCursor;
			_c1r.DataSource.RecordSource = _txtQuery.Text;
			_c1r.Render();
			Cursor = Cursors.Default;

			// and show it in preview dialog
            C1.Win.C1Preview.C1PrintPreviewDialog ppv = new C1.Win.C1Preview.C1PrintPreviewDialog();
			ppv.Document = _c1r;
			ppv.ShowDialog();
		}
	}
}
