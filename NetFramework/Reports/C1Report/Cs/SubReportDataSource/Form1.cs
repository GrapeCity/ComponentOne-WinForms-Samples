using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.C1Report;

namespace SubReportDataSource
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
        private C1.Win.C1Preview.C1PreviewPane _ppv;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ToolBar _tb;
		private System.Windows.Forms.ToolBarButton _tbFirst;
		private System.Windows.Forms.ToolBarButton _tbPrevious;
		private System.Windows.Forms.ToolBarButton _tbNext;
		private System.Windows.Forms.ToolBarButton _tbLast;
		private System.Windows.Forms.ToolBarButton _tbSep0;
		private System.Windows.Forms.ToolBarButton _tbZoomIn;
		private System.Windows.Forms.ToolBarButton _tbZoomOut;
		private System.Windows.Forms.ToolBarButton _tbPage;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;
            if (cs == null || cs.Length <= 0)
                return;

            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            rep.DataSource.ConnectionString = cs;

            //
            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null)
                    CorrectConnectionString(field.Subreport);
        }

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            CorrectConnectionString(_c1r);
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
            this._ppv = new C1.Win.C1Preview.C1PreviewPane();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._tb = new System.Windows.Forms.ToolBar();
            this._tbFirst = new System.Windows.Forms.ToolBarButton();
            this._tbPrevious = new System.Windows.Forms.ToolBarButton();
            this._tbNext = new System.Windows.Forms.ToolBarButton();
            this._tbLast = new System.Windows.Forms.ToolBarButton();
            this._tbSep0 = new System.Windows.Forms.ToolBarButton();
            this._tbZoomIn = new System.Windows.Forms.ToolBarButton();
            this._tbZoomOut = new System.Windows.Forms.ToolBarButton();
            this._tbPage = new System.Windows.Forms.ToolBarButton();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Categories";
            // 
            // _ppv
            // 
            this._ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppv.Location = new System.Drawing.Point(0, 60);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(520, 456);
            this._ppv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 35);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Default Data/Filter";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "Custom Data";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 22);
            this.button3.TabIndex = 0;
            this.button3.Text = "Custom Data/Filter";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _tb
            // 
            this._tb.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._tb.AutoSize = false;
            this._tb.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this._tbFirst,
            this._tbPrevious,
            this._tbNext,
            this._tbLast,
            this._tbSep0,
            this._tbZoomIn,
            this._tbZoomOut,
            this._tbPage});
            this._tb.ButtonSize = new System.Drawing.Size(50, 22);
            this._tb.DropDownArrows = true;
            this._tb.Location = new System.Drawing.Point(0, 0);
            this._tb.Name = "_tb";
            this._tb.ShowToolTips = true;
            this._tb.Size = new System.Drawing.Size(520, 25);
            this._tb.TabIndex = 2;
            this._tb.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this._tb.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._tb_ButtonClick);
            // 
            // _tbFirst
            // 
            this._tbFirst.Name = "_tbFirst";
            this._tbFirst.Text = "<<";
            // 
            // _tbPrevious
            // 
            this._tbPrevious.Name = "_tbPrevious";
            this._tbPrevious.Text = "<";
            // 
            // _tbNext
            // 
            this._tbNext.Name = "_tbNext";
            this._tbNext.Text = ">";
            // 
            // _tbLast
            // 
            this._tbLast.Name = "_tbLast";
            this._tbLast.Text = ">>";
            // 
            // _tbSep0
            // 
            this._tbSep0.Name = "_tbSep0";
            this._tbSep0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _tbZoomIn
            // 
            this._tbZoomIn.Name = "_tbZoomIn";
            this._tbZoomIn.Text = "+";
            // 
            // _tbZoomOut
            // 
            this._tbZoomOut.Name = "_tbZoomOut";
            this._tbZoomOut.Text = "-";
            // 
            // _tbPage
            // 
            this._tbPage.Name = "_tbPage";
            this._tbPage.Text = "Page";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 516);
            this.Controls.Add(this._ppv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._tb);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Subreport Data Sources";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            this.panel1.ResumeLayout(false);
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

		DataTable _dataTable;
		string _strFilter;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data table
			_dataTable = new DataTable();
			_dataTable.Columns.Add("ProductName", typeof(string));
			_dataTable.Columns.Add("UnitsInStock", typeof(int));
			_dataTable.Columns.Add("CategoryID", typeof(int));
			for (int i = 0; i < 100; i++)
			{
				string name = "Product " + i;
				int units = 5 * i;
				int id = i % 20 + 1;
				_dataTable.Rows.Add(new object[] { name, units, id });
			}

			// save original subreport filter expression
			Field srField = _c1r.Fields["SubreportField"];
			_strFilter = srField.Text;

			// hook up startReport event to apply custom filter when needed
			C1Report rptSubreport = srField.Subreport;
			rptSubreport.StartReport += new System.EventHandler(_StartReport);
		}

		// render report using data from the database
		private void button1_Click(object sender, System.EventArgs e)
		{
			// reset subreport custom data
			// (will use ConnectionString and RecordSource properties)
			Field srField = _c1r.Fields["SubreportField"];
			C1Report rptSubreport = srField.Subreport;
			rptSubreport.DataSource.Recordset = null;

			// use original subreport filter (based on category ID)
			srField.Text = _strFilter;

			// render report
			_ppv.Document = _c1r;
            _ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
		}

		// render report using data from _dataTable object
		// and the default filter mechanism
		private void button2_Click(object sender, System.EventArgs e)
		{
			// use custom data source
			Field srField = _c1r.Fields["SubreportField"];
			C1Report rptSubreport = srField.Subreport;
			rptSubreport.DataSource.Recordset = _dataTable;

			// use original subreport filter (based on category ID)
			srField.Text = _strFilter;

			// render report
			_ppv.Document = _c1r;
            _ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
        }

		// render report using data from _dataTable object
		// and a custom filter
		private void button3_Click(object sender, System.EventArgs e)
		{
			// use custom data source
			Field srField = _c1r.Fields["SubreportField"];
			C1Report rptSubreport = srField.Subreport;
			rptSubreport.DataSource.Recordset = _dataTable;

			// use custom filter:
			srField.Text = "";

			// render report
			_ppv.Document = _c1r;
            _ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
        }

		// apply custom filter if one wasn't provided
		private void _StartReport(object sender, System.EventArgs e)
		{
			// get subreport field
			Field srField = _c1r.Fields["SubreportField"];

			// if the filter is set, nothing to do
			if (srField.Text.Length > 0)
				return;

			// build custom filter
			// (add 5 to current ID just to show that it works)
			int currentID = (int)_c1r.Evaluate("CategoryID");
			string filter = string.Format("CategoryID = '{0}'", currentID + 5);
 
			// apply custom filter
			DataView dv = _dataTable.DefaultView;
			dv.RowFilter = filter;

			// and apply data source to the report
			C1Report rptSubreport = srField.Subreport;
			rptSubreport.DataSource.Recordset = dv;
		}

		// control preview
		private void _tb_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
            if (e.Button == this._tbFirst)
                _ppv.StartPageIdx = 0;
            else if (e.Button == this._tbLast)
                _ppv.StartPageIdx = 1000;
            else if (e.Button == this._tbPrevious)
                _ppv.StartPageIdx--;
            else if (e.Button == this._tbNext)
                _ppv.StartPageIdx++;
            else if (e.Button == this._tbZoomIn)
                _ppv.ZoomFactor += .1;
            else if (e.Button == this._tbZoomOut)
                _ppv.ZoomFactor -= .1;
            else if (e.Button == this._tbPage)
                _ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
		}
	}
}
