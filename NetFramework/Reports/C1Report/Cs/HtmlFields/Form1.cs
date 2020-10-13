using System;
using System.Text;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HtmlFields
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "05: Watermark";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Standard Report";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Raw Html Report";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(258, 103);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Reports with Raw Html";
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			// open regular output stream
			string fileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\out.htm";
			Stream s = new FileStream(fileName, FileMode.Create);

			// render report to stream
			Cursor = Cursors.WaitCursor;
			_c1r.RenderToStream(s, C1.C1Report.FileFormatEnum.HTML);
			Cursor = Cursors.Default;

			// close stream
			s.Close();

			// show what we got
			System.Diagnostics.Process.Start(fileName);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// open custom output stream to unescape HTML codes
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\out.htm";
			Stream s = new RawHtmlStream(fileName, FileMode.Create);

			// render report to stream
			Cursor = Cursors.WaitCursor;
			_c1r.RenderToStream(s, C1.C1Report.FileFormatEnum.HTML);
			Cursor = Cursors.Default;

			// close stream
			s.Close();

			// show what we got
			System.Diagnostics.Process.Start(fileName);
		}
	}

	/// <summary>
	/// RawHtmlStream
	/// Inherits from a regular file stream and 'unescapes' html characters
	/// so "&lt;i&gt;" becomes "<i>" again.
	/// </summary>
	public class RawHtmlStream : FileStream
	{
		// ** ctor
		public RawHtmlStream(string path, FileMode mode) : base(path, mode) {}

		// ** overrides
		override public void Write(byte[] buffer, int offset, int count)
		{
			// convert bytes to string
			string s = Encoding.Default.GetString(buffer, offset, count);

			// 'unescape' html sequences
			if (s.IndexOf('&') > -1)
			{
				s = s.Replace("&gt;", ">");
				s = s.Replace("&lt;", "<");
				buffer = Encoding.Default.GetBytes(s);
				offset = 0;
				count = buffer.Length;
			}

			// write converted bytes to stream
			base.Write(buffer, offset, count);
		}
	}
}
