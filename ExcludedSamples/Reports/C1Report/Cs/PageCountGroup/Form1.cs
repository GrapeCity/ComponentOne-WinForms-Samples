using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PageCountGroup
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.StatusBar statusBar1;
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
            this.button1 = new System.Windows.Forms.Button();
            this._c1r = new C1.C1Report.C1Report();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Report";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Orders Report";
            this._c1r.StartPage += new C1.C1Report.ReportEventHandler(this._c1r_StartPage);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 65);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(258, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(258, 87);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Page Counts per Group";
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

		int _pass;
		Hashtable _groupCounts;
		private void button1_Click(object sender, System.EventArgs e)
		{
			// first pass: count number of pages in each group
			_pass= 1;
			_groupCounts = new Hashtable();
			_c1r.Render();

			// second pass: set footers
			_pass = 2;
			_c1r.Render();
			statusBar1.Text = string.Empty;
            C1.Win.C1Preview.C1PrintPreviewDialog pd = new C1.Win.C1Preview.C1PrintPreviewDialog();

			// show it
			pd.Document = _c1r;
			pd.ShowDialog();
		}
        private void _c1r_StartPage(object sender, C1.C1Report.ReportEventArgs e)
		{
			// first pass, counting pages in each group
			if (_pass == 1)
			{
				// get current country
				string country = (string)_c1r.Evaluate("ShipCountry");

				// update page counters
				if (_groupCounts.Contains(country))
					_groupCounts[country] = (int)_groupCounts[country]+1;
				else
					_groupCounts[country] = 1;

				// user feedback
				statusBar1.Text = string.Format("Counting pages: {0} {1}",
					country, _groupCounts[country]);

			}

			// second pass, rendering
			if (_pass == 2)
			{
				// get current country
				string country = (string)_c1r.Evaluate("ShipCountry");

				// get page count for this group (stored during first pass)
				int count = (int)_groupCounts[country];

				// update group count variable used in the report
				_c1r.Execute("groupPageCount = " + count.ToString());

				// user feedback
				int page = (int)(double)_c1r.Evaluate("groupPageCount");
				statusBar1.Text = string.Format("Rendering: {0} page {1} of {2}",
					country, page, _groupCounts[country]);
			}
		}
	}
}
