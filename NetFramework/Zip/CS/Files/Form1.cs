using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using C1.C1Zip;

namespace Files
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCompress;
		private System.Windows.Forms.Button btnExpand;
		private System.Windows.Forms.Label label1;
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
			this.btnCompress = new System.Windows.Forms.Button();
			this.btnExpand = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCompress
			// 
			this.btnCompress.Location = new System.Drawing.Point(8, 16);
			this.btnCompress.Name = "btnCompress";
			this.btnCompress.Size = new System.Drawing.Size(176, 40);
			this.btnCompress.TabIndex = 0;
			this.btnCompress.Text = "Compress Files";
			this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
			// 
			// btnExpand
			// 
			this.btnExpand.Enabled = false;
			this.btnExpand.Location = new System.Drawing.Point(8, 64);
			this.btnExpand.Name = "btnExpand";
			this.btnExpand.Size = new System.Drawing.Size(176, 40);
			this.btnExpand.TabIndex = 0;
			this.btnExpand.Text = "Expand Files";
			this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(200, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 144);
			this.label1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(482, 173);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.btnCompress,
																		  this.btnExpand});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Zip: Compress/Expand individual files";
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

		//
		// utilities to compress/expand files
		//
		private static bool CompressFile(string dstFile, string srcFile)
		{
			// prepare to compress file
			bool retval = true;
			FileStream srcStream = null;
			FileStream dstStream = null;
			try
			{
				// open the files
				srcStream = new FileStream(srcFile, FileMode.Open, FileAccess.Read);
				dstStream = new FileStream(dstFile, FileMode.Create, FileAccess.Write);

				// open compressor stream on destination file
				C1ZStreamWriter sw = new C1ZStreamWriter(dstStream);

				// copy source into compressor stream
				StreamCopy(sw, srcStream);
			}
			catch // exception? tell caller we failed
			{
				retval = false;
			}
			finally // always close our streams
			{
				if (srcStream != null) srcStream.Close();
				if (dstStream != null) dstStream.Close();
			}

			// done
			return retval;
		}
		private static bool ExpandFile(string dstFile, string srcFile)
		{
			// prepare to expand file
			bool retval = true;
			FileStream srcStream = null;
			FileStream dstStream = null;
			try
			{
				// open the files
				srcStream = new FileStream(srcFile, FileMode.Open, FileAccess.Read);
				dstStream = new FileStream(dstFile, FileMode.Create, FileAccess.Write);

				// open expander stream on compressed source
				C1ZStreamReader sr = new C1ZStreamReader(srcStream);

				// copy expander stream into destination file
				StreamCopy(dstStream, sr);
			} 
			catch // exception? tell caller we failed
			{
				retval = false;
			}
			finally // always close our streams
			{
				if (srcStream != null) srcStream.Close();
				if (dstStream != null) dstStream.Close();
			}

			// done
			return retval;
		}
		private static void StreamCopy(Stream dstStream, Stream srcStream)
		{
			byte[] buffer = new byte[32768];
			int read;
			while ((read = srcStream.Read(buffer, 0, buffer.Length)) != 0)
				dstStream.Write(buffer, 0, read);
			dstStream.Flush();
		}
		
		// compress all files in the demo directory to a new "compressed" directory
		private const string DIR_COMP = @"\compressed";
		private const string DIR_EXP  = @"\expanded";

		private void btnCompress_Click(object sender, System.EventArgs e)
		{
			// get application directory
			string path = Application.ExecutablePath;
			int i = path.IndexOf(@"\bin\");
			if (i > 0) path = path.Substring(0, i);

			// create directory for compressed files
			if (Directory.Exists(path + DIR_COMP))
				Directory.Delete(path + DIR_COMP, true);
			Directory.CreateDirectory(path + DIR_COMP);

			// prepare to collect compression statistics
			long count = 0;
			long size = 0;
			long sizeCompressed = 0;
			long ticks = DateTime.Now.Ticks;

			// compress all files in application dir into compressed dir
			string[] files = Directory.GetFiles(path);
			foreach (string srcFile in files)
			{
				// compress file
				string dstFile = path + DIR_COMP + "\\" + Path.GetFileName(srcFile) + ".cmp";
				CompressFile(dstFile, srcFile);

				// update stats
				count++;
				size += new FileInfo(srcFile).Length;
				sizeCompressed += new FileInfo(dstFile).Length;
			}

			// show stats
			string msg = string.Format(
			    "Compressed {0} files in {1} ms.\r\n" +
				"Original size:   {2:#,###}\r\n" +
				"Compressed size: {3:#,###} ({4:0.00}% of original)",
				count,
				(DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond,
				size, sizeCompressed,
				(sizeCompressed / (double)size) * 100.0);
			label1.Text = msg;

			// now we can expand
			btnExpand.Enabled = true;
		}

		// expand files in "compressed" directory to a new "expanded" directory
		private void btnExpand_Click(object sender, System.EventArgs e)
		{
			// get application directory
			string path = Application.ExecutablePath;
			int i = path.IndexOf(@"\bin\");
			if (i > 0) path = path.Substring(0, i);

			// create directory for expanded files
			if (Directory.Exists(path + DIR_EXP))
				Directory.Delete(path + DIR_EXP, true);
			Directory.CreateDirectory(path + DIR_EXP);

			// prepare to collect compression statistics
			long count = 0;
			long size = 0;
			long sizeExpanded = 0;
			long ticks = DateTime.Now.Ticks;

			// expand all files in "compressed" dir to "expanded" dir
			string[] files = Directory.GetFiles(path + DIR_COMP);
			foreach (string srcFile in files)
			{
				// expand file
				string dstFile = path + DIR_EXP + "\\" + Path.GetFileName(srcFile);
				dstFile = dstFile.Replace(".cmp", "");
				ExpandFile(dstFile, srcFile);

				// update stats
				count++;
				size += new FileInfo(srcFile).Length;
				sizeExpanded += new FileInfo(dstFile).Length;
			}

			// show stats
			string msg = string.Format(
				"Expanded {0} files in {1} ms.\r\n" +
				"Original size:   {2:#,###}\r\n" +
				"Expanded size: {3:#,###} ({4:0.00} x size of compressed)",
				count,
				(DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond,
				size, sizeExpanded,
				sizeExpanded / (double)size);
			label1.Text = msg;
		}
	}
}
