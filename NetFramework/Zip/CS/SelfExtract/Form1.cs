using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Reflection;
using C1.Zip;

namespace SelfExtract
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button _btnExtract;
        private System.Windows.Forms.TextBox _txtDestinationPath;
        private System.Windows.Forms.Button _btnSelectDestinationPath;
        private System.Windows.Forms.Label _lbl;
        private System.Windows.Forms.StatusBar _status;
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._btnExtract = new System.Windows.Forms.Button();
            this._txtDestinationPath = new System.Windows.Forms.TextBox();
            this._btnSelectDestinationPath = new System.Windows.Forms.Button();
            this._lbl = new System.Windows.Forms.Label();
            this._status = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // _btnExtract
            // 
            this._btnExtract.Location = new System.Drawing.Point(16, 88);
            this._btnExtract.Name = "_btnExtract";
            this._btnExtract.Size = new System.Drawing.Size(224, 32);
            this._btnExtract.TabIndex = 0;
            this._btnExtract.Text = "&Extract Files";
            this._btnExtract.Click += new System.EventHandler(this._btnExtract_Click);
            // 
            // _txtDestinationPath
            // 
            this._txtDestinationPath.Location = new System.Drawing.Point(16, 40);
            this._txtDestinationPath.Name = "_txtDestinationPath";
            this._txtDestinationPath.Size = new System.Drawing.Size(408, 22);
            this._txtDestinationPath.TabIndex = 1;
            this._txtDestinationPath.Text = "_txtDestinationPath";
            // 
            // _btnSelectDestinationPath
            // 
            this._btnSelectDestinationPath.Location = new System.Drawing.Point(424, 40);
            this._btnSelectDestinationPath.Name = "_btnSelectDestinationPath";
            this._btnSelectDestinationPath.Size = new System.Drawing.Size(32, 24);
            this._btnSelectDestinationPath.TabIndex = 2;
            this._btnSelectDestinationPath.Text = "...";
            this._btnSelectDestinationPath.Click += new System.EventHandler(this._btnSelectDestinationPath_Click);
            // 
            // _lbl
            // 
            this._lbl.Location = new System.Drawing.Point(16, 24);
            this._lbl.Name = "_lbl";
            this._lbl.Size = new System.Drawing.Size(440, 16);
            this._lbl.TabIndex = 3;
            this._lbl.Text = "Select &Destination Directory";
            // 
            // _status
            // 
            this._status.Location = new System.Drawing.Point(0, 132);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(474, 22);
            this._status.TabIndex = 4;
            this._status.Text = " Ready";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(474, 154);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._status,
                                                                          this._lbl,
                                                                          this._btnSelectDestinationPath,
                                                                          this._txtDestinationPath,
                                                                          this._btnExtract});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Zip: Self-Extracting Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        // initialize destination path to current directory
        private void Form1_Load(object sender, System.EventArgs e)
        {
            _btnSelectDestinationPath.Height = _txtDestinationPath.Height;
            _txtDestinationPath.Text = Directory.GetCurrentDirectory();
        }

        // select a new destination directory
        private void _btnSelectDestinationPath_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Destination Directory";
            dlg.CheckPathExists  = true;
            dlg.CheckFileExists  = false;
            dlg.DereferenceLinks = true;
            if (dlg.ShowDialog() == DialogResult.OK)
                _txtDestinationPath.Text = Path.GetDirectoryName(dlg.FileName);
        }

        // extract zip resources to destination directory
        private void _btnExtract_Click(object sender, System.EventArgs e)
        {
            SelfExtract(_txtDestinationPath.Text);
        }
        
        // extract zip resources to destination directory
        //
        // The files to be extracted must be zipped and the resulting zip file must
        // be added to this project as an embedded resource (the name of the resource
        // is not important, as long as it ends with a .zip extension).
        //
        // To do this, right-click the project name in Visual Studio, select the Add Item
        // menu option and select the zip file that will be extracted. Then select the
        // new item, go to the properties window and make sure the BuildAction property
        // is set to Embedded Resource.
        //
        private void SelfExtract(string dstPath)
        {
            // make sure destination path ends with \
            if (!dstPath.EndsWith(@"\"))
                dstPath += @"\";

            // make sure destination directory exists
            if (!Directory.Exists(dstPath))
            {
                string msg = string.Format(
                    "Destination directory doesn't exist. \r\n" +
                    "Would you like to create directory '{0}'?", 
                    dstPath);
                    DialogResult dr = MessageBox.Show(msg, "Confirm Directory Creation", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;
                try
                {
                    Directory.CreateDirectory(dstPath);
                }
                catch
                {
                    MessageBox.Show("Failed to create destination directory.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // make list of zip resources in this application
            ArrayList zipRes = new ArrayList();
            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (string f in asm.GetManifestResourceNames())
            {
                if (f.ToLower().EndsWith(".zip"))
                    zipRes.Add(f);
            }

            // process each zip resource
            byte[] buf = new byte[64 * 1024];
            foreach (string f in zipRes)
            {
                // copy resource to temp zip file
                string tempName = Path.GetTempFileName();
                FileStream sOut = new FileStream(tempName, FileMode.Create);
                Stream sIn = asm.GetManifestResourceStream(f);
                for (;;)
                {
                    int read = sIn.Read(buf, 0, buf.Length);
                    sOut.Write(buf, 0, read);
                    if (read < buf.Length) break;
                }
                sOut.Close();

                // expand temp zip file into destination directory
                C1ZipFile zip = new C1ZipFile();
                zip.Open(tempName);
                int cur = 0;
                int cnt = zip.Entries.Count;
                foreach (C1ZipEntry ze in zip.Entries)
                {
                    // get source and destination file names
                    string src = ze.FileName;
                    string dst = dstPath + ze.FileName;

                    // create destination subdirectory if necessary
                    string dstFolder = Path.GetDirectoryName(dst);
                    if (!Directory.Exists(dstFolder))
                    {
                        try
                        {
                            Directory.CreateDirectory(dstFolder);
                        }
                        catch (Exception x)
                        {
                            string msg = string.Format("Failed to create directory {0}\r\n{1}", dstFolder, x.Message);
                            MessageBox.Show(msg, "Error Creating Directory", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                    }

                    // extract the entry
                    try
                    {
                        _status.Text = string.Format(" Extracting {0} of {1}: {2}", cur++, cnt, Path.GetFileName(ze.FileName));
                        zip.Entries.Extract(src, dst);
                    }
                    catch (Exception x)
                    {
                        string msg = string.Format("Failed to expand {0}\r\n{1}", ze.FileName, x.Message);
                        MessageBox.Show(msg, "Error Extracting File", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // delete temp zip file
                File.Delete(tempName);

                // restore status
                _status.Text = " Ready";
            }
        }
	}
}
