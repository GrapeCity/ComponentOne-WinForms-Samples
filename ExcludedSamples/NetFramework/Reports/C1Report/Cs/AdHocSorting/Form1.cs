using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Report;
using C1.Win.C1Preview;

namespace AdHocSorting
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.ListBox _list;
		private System.Windows.Forms.Button _btnShow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton _rdAscending;
		private System.Windows.Forms.RadioButton _rdDescending;
        private Button button1;
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
            this._list = new System.Windows.Forms.ListBox();
            this._btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._rdAscending = new System.Windows.Forms.RadioButton();
            this._rdDescending = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Alphabetical List of Products Report";
            // 
            // _list
            // 
            this._list.Location = new System.Drawing.Point(8, 32);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(216, 225);
            this._list.TabIndex = 0;
            // 
            // _btnShow
            // 
            this._btnShow.Location = new System.Drawing.Point(240, 78);
            this._btnShow.Name = "_btnShow";
            this._btnShow.Size = new System.Drawing.Size(128, 32);
            this._btnShow.TabIndex = 1;
            this._btnShow.Text = "Show report";
            this._btnShow.Click += new System.EventHandler(this._btnShow_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rdAscending
            // 
            this._rdAscending.Checked = true;
            this._rdAscending.Location = new System.Drawing.Point(240, 32);
            this._rdAscending.Name = "_rdAscending";
            this._rdAscending.Size = new System.Drawing.Size(120, 16);
            this._rdAscending.TabIndex = 3;
            this._rdAscending.TabStop = true;
            this._rdAscending.Text = "Ascending";
            // 
            // _rdDescending
            // 
            this._rdDescending.Location = new System.Drawing.Point(240, 56);
            this._rdDescending.Name = "_rdDescending";
            this._rdDescending.Size = new System.Drawing.Size(120, 16);
            this._rdDescending.TabIndex = 3;
            this._rdDescending.Text = "Descending";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show report\r\nin C1PrintPreviewControl";
            this.button1.Click += new System.EventHandler(this._btnC1Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.Controls.Add(this._rdAscending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._btnShow);
            this.Controls.Add(this._list);
            this.Controls.Add(this._rdDescending);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Ad-Hoc Sorting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
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
			// populate list with fields available for sorting
			char[] badChars = new char[] {'&', '(', ')', ' '};
			foreach (Field f in _c1r.Fields)
			{
				if (f.Calculated && f.Text.IndexOfAny(badChars) < 0)
					_list.Items.Add(f.Text);
			}
		}

        private void Sort()
        {
            // apply sorting expression to report's first (and only) group
            _c1r.Groups[0].GroupBy = _list.Text;
            if (_rdAscending.Checked)
                _c1r.Groups[0].Sort = SortEnum.Ascending;
            else
                _c1r.Groups[0].Sort = SortEnum.Descending;
        }

        private void _btnShow_Click(object sender, System.EventArgs e)
		{
            Sort();

			// show report
			PrintPreviewDialog p = new PrintPreviewDialog();
			((Form)p).Text = "Report sorted by " + _list.Text;
			p.Document = _c1r.Document;
			p.ShowDialog();
		}

        private void _btnC1Show_Click(object sender, System.EventArgs e)
        {
            Sort();

            // show report
            C1PrintPreviewDialog p = new C1PrintPreviewDialog();
            ((Form)p).Text = "Report sorted by " + _list.Text;
            p.Document = _c1r;
            p.ShowDialog();
        }
    }
}
