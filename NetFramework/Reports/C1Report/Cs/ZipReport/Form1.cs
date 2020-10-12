using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;
using System.Xml;
using C1.C1Zip;

namespace ZipReport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
        private C1.Win.C1Preview.C1PreviewPane _ppv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "c1Report1";
            // 
            // _ppv
            // 
            this._ppv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._ppv.Location = new System.Drawing.Point(96, 8);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(489, 479);
            this._ppv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Render Employees";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Render Chart";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(593, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._ppv);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Load reports from zipped/encrypted files";
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
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

        private void LoadAndRender(string reportName)
        {
			// locate zip file
			string strFile = Application.ExecutablePath;
			int i = strFile.IndexOf("\\bin");
			if (i > -1) strFile = strFile.Substring(0, i);
			strFile += "\\nwind.zip";
			
			// open password-protected zip file
            C1ZipFile zip = new C1ZipFile();
            zip.Open(strFile);
            zip.Password = "nwind";

            // load report definition XML document from compressed stream
            Stream stream = zip.Entries[0].OpenReader();
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
			stream.Close();

			// close zip file
			zip.Close();

            // load report into control
            _c1r.Load(doc, reportName);
            CorrectConnectionString(_c1r);
            _ppv.Document = _c1r;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            LoadAndRender("Customer Labels");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            LoadAndRender("Sales Chart");
        }
    }
}
