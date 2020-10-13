using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;
using C1.C1Zip;

namespace Memory
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCompressString;
		private System.Windows.Forms.Button btnExpandString;
		private System.Windows.Forms.Button btnCompressData;
		private System.Windows.Forms.Button btnExpandData;
		private System.Windows.Forms.TextBox textBox1;
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
			this.btnCompressString = new System.Windows.Forms.Button();
			this.btnExpandString = new System.Windows.Forms.Button();
			this.btnCompressData = new System.Windows.Forms.Button();
			this.btnExpandData = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCompressString
			// 
			this.btnCompressString.Location = new System.Drawing.Point(16, 16);
			this.btnCompressString.Name = "btnCompressString";
			this.btnCompressString.Size = new System.Drawing.Size(144, 32);
			this.btnCompressString.TabIndex = 0;
			this.btnCompressString.Text = "Compress String";
			this.btnCompressString.Click += new System.EventHandler(this.btnCompressString_Click);
			// 
			// btnExpandString
			// 
			this.btnExpandString.Enabled = false;
			this.btnExpandString.Location = new System.Drawing.Point(16, 64);
			this.btnExpandString.Name = "btnExpandString";
			this.btnExpandString.Size = new System.Drawing.Size(144, 32);
			this.btnExpandString.TabIndex = 0;
			this.btnExpandString.Text = "Decompress String";
			this.btnExpandString.Click += new System.EventHandler(this.btnExpandString_Click);
			// 
			// btnCompressData
			// 
			this.btnCompressData.Location = new System.Drawing.Point(16, 192);
			this.btnCompressData.Name = "btnCompressData";
			this.btnCompressData.Size = new System.Drawing.Size(144, 32);
			this.btnCompressData.TabIndex = 0;
			this.btnCompressData.Text = "Compress Data";
			this.btnCompressData.Click += new System.EventHandler(this.btnCompressData_Click);
			// 
			// btnExpandData
			// 
			this.btnExpandData.Enabled = false;
			this.btnExpandData.Location = new System.Drawing.Point(16, 240);
			this.btnExpandData.Name = "btnExpandData";
			this.btnExpandData.Size = new System.Drawing.Size(144, 32);
			this.btnExpandData.TabIndex = 0;
			this.btnExpandData.Text = "Decompress Data";
			this.btnExpandData.Click += new System.EventHandler(this.btnExpandData_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(184, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(368, 160);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "zlib is a general purpose data compression library.  All the code is reentrant (t" +
				"hread safe).  The data format used by the zlib library is described by RFCs (Req" +
				"uest for Comments) 1950 to 1952 in the files ftp://ds.internic.net/rfc/rfc1950.t" +
				"xt (zlib format), rfc1951.txt (deflate format) and rfc1952.txt (gzip format). Th" +
				"ese documents are also available in other formats from ftp://ftp.uu.net/graphics" +
				"/png/documents/zlib/zdoc-index.html\r\n\r\nAll functions of the compression library " +
				"are documented in the file zlib.h. A usage example of the library is given in th" +
				"e file example.c which also tests that the library is working correctly. Another" +
				" example is given in the file minigzip.c. The compression library itself is comp" +
				"osed of all source files except example.c and minigzip.c.\r\n\r\nTo compile all file" +
				"s and run the test program, follow the instructions given at the top of Makefile" +
				". In short \"make test; make install\" should work for most machines.  For MSDOS, " +
				"use one of the special makefiles such as Makefile.msc; for VMS, use Make_vms.com" +
				" or descrip.mms.\r\n\r\nQuestions about zlib should be sent to <zlib@quest.jpl.nasa." +
				"gov> or, if this fails, to the addresses given below in the Copyright section. T" +
				"he zlib home page is http://quest.jpl.nasa.gov/zlib/\r\n\r\nThe changes made in vers" +
				"ion 1.0.4 are documented in the file ChangeLog. The main changes since 1.0.3 are" +
				":\r\n\r\n- In very rare conditions, deflate(s, Z_FINISH) could fail to produce an EO" +
				"F   bit, so the decompressor could decompress all the correct data but went on t" +
				"o attempt decompressing extra garbage data. This affected minigzip too.\r\n- zlibV" +
				"ersion and gzerror return const char* (needed for DLL)\r\n- port to RISCOS (no fdo" +
				"pen, no multiple dots, no unlink, no fileno)\r\n\r\nA Perl interface to zlib written" +
				" by Paul Marquess <pmarquess@bfsec.bt.co.uk> is in the CPAN (Comprehensive Perl " +
				"Archive Network) sites, such as: ftp://ftp.cis.ufl.edu/pub/perl/CPAN/modules/by-" +
				"module/Compress/Compress-Zlib*\r\n\r\nNotes for some targets:\r\n\r\n- For Turbo C the s" +
				"mall model is supported only with reduced performance to avoid any far allocatio" +
				"n; it was tested with -DMAX_WBITS=11 -DMAX_MEM_LEVEL=3\r\n- For 64-bit Iris, defla" +
				"te.c must be compiled without any optimization. With -O, one libpng test fails. " +
				"The test works in 32 bit mode (with the -32 compiler flag). The compiler bug has" +
				" been reported to SGI.\r\n- zlib doesn\'t work with gcc 2.6.3 on a DEC 3000/300LX u" +
				"nder OSF/1 2.1 it works when compiled with cc.\r\n- zlib doesn\'t work on HP-UX 9.0" +
				"5 with one cc compiler (the one not accepting the -O option). It works with the " +
				"other cc compiler.\r\n- To build a Windows DLL version, include in a DLL project z" +
				"lib.def, zlib.rc and all .c files except example.c and minigzip.c; compile with " +
				"-DZLIB_DLL For help on building a zlib DLL, contact Alessandro Iacopetti <iaco@e" +
				"mail.alessandria.alpcom.it>  http://lisa.unial.it/iaco, or contact Brad Clarke <" +
				"bclarke@cyberus.ca>.\r\n- gzdopen is not supported on RISCOS\r\n\r\nAcknowledgments:\r\n" +
				"\r\nThe deflate format used by zlib was defined by Phil Katz. The deflate and zlib" +
				" specifications were written by Peter Deutsch. Thanks to all the people who repo" +
				"rted problems and suggested various improvements in zlib; they are too numerous " +
				"to cite here.\r\n\r\nCopyright notice:\r\n\r\n (C) 1995-1996 Jean-loup Gailly and Mark A" +
				"dler\r\n\r\nThis software is provided \'as-is\', without any express or implied  warra" +
				"nty.  In no event will the authors be held liable for any damages arising from t" +
				"he use of this software.\r\nPermission is granted to anyone to use this software f" +
				"or any purpose,  including commercial applications, and to alter it and redistri" +
				"bute it freely, subject to the following restrictions:\r\n\r\n1. The origin of this " +
				"software must not be misrepresented; you must not claim that you wrote the origi" +
				"nal software. If you use this software in a product, an acknowledgment in the pr" +
				"oduct documentation would be appreciated but is not required.\r\n2. Altered source" +
				" versions must be plainly marked as such, and must not be misrepresented as bein" +
				"g the original software.\r\n3. This notice may not be removed or altered from any " +
				"source distribution.\r\n\r\nJean-loup Gailly        Mark Adler\r\ngzip@prep.ai.mit.edu" +
				"    madler@alumni.caltech.edu\r\n\r\nIf you use the zlib library in a product, we wo" +
				"uld appreciate *not* receiving lengthy legal documents to sign. The sources are " +
				"provided for free but without warranty of any kind.  The library has been entire" +
				"ly written by Jean-loup Gailly and Mark Adler; it does not include third-party c" +
				"ode.\r\n\r\nIf you redistribute modified sources, we would appreciate that you inclu" +
				"de in the file ChangeLog history information documenting your changes.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(184, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(368, 144);
			this.label1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.textBox1,
																		  this.btnCompressString,
																		  this.btnExpandString,
																		  this.btnCompressData,
																		  this.btnExpandData});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Zip: Compress/Expand data in memory";
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
		// utilities to compress/expand a string
		//
		public static byte[] CompressString(string str)
		{
			// open memory stream
			MemoryStream ms = new MemoryStream();

			// attach compressor stream to memory stream
			C1ZStreamWriter sw = new C1ZStreamWriter(ms);

			// write data into compressor stream
			StreamWriter writer = new StreamWriter(sw);
			writer.Write(str);

			// flush any pending data
			writer.Flush();

			// return the memory buffer
			// (note: don't use GetBuffer(), it may return an array that is too long)
			return ms.ToArray();
		}
		public static string ExpandString(byte[] buffer)
		{
			// turn buffer into a memory stream
			MemoryStream ms = new MemoryStream(buffer);

			// attach decompressor stream to memory stream
			C1ZStreamReader sr = new C1ZStreamReader(ms);

			// read uncompressed data
			StreamReader reader = new StreamReader(sr);
			return reader.ReadToEnd();
		}

		//
		// compress/expand string
		//
		private byte[] m_CompressedString;
		private void btnCompressString_Click(object sender, System.EventArgs e)
		{
			// compress the string
			long ticks = DateTime.Now.Ticks;
			m_CompressedString = CompressString(textBox1.Text);

			// tell user how long it took
			int ms = (int)((DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond);
			int lenBefore = textBox1.Text.Length * 2; // << 1 unicode char = 2 bytes
			int lenAfter = m_CompressedString.Length;
			string msg = string.Format("Compressed from {0} bytes to {1} bytes in {2} milliseconds.", lenBefore, lenAfter, ms);
			MessageBox.Show(msg, "Compressed", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// we can now expand it
			btnExpandString.Enabled = true;
		}
		private void btnExpandString_Click(object sender, System.EventArgs e)
		{
			// expand the string
			long ticks = DateTime.Now.Ticks;
			textBox1.Text = ExpandString(m_CompressedString);

			// tell user how long it took
			int ms = (int)((DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond);
			int lenBefore = m_CompressedString.Length;
			int lenAfter = textBox1.Text.Length * 2; // << 1 unicode char = 2 bytes
			string msg = string.Format("Expanded from {0} bytes to {1} bytes in {2} milliseconds.", lenBefore, lenAfter, ms);
			MessageBox.Show(msg, "Expanded", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//
		// compress/expand binary data
		//
		private byte[] m_CompressedData;
		private void btnCompressData_Click(object sender, System.EventArgs e)
		{
			// open memory stream
			MemoryStream ms = new MemoryStream();

			// attach compressor stream to memory stream
			C1ZStreamWriter sw = new C1ZStreamWriter(ms);

			// attach BinaryWriter to the compressor stream
			BinaryWriter bw = new BinaryWriter(sw);

			// write a bunch of numbers into the stream
			int count = 1000;
			bw.Write(count);
			for (int i = 0; i < count; i++)
			{
				double a = i * Math.PI/180.0;
				bw.Write(i);
				bw.Write(a);
				bw.Write(Math.Sin(a));
				bw.Write(Math.Cos(a));
			}

			// flush any pending output
			bw.Flush();

			// save the compressed data
            m_CompressedData = ms.ToArray();

			// done
			string msg = string.Format("Generated table with {0} points, saved into {1} bytes", count, m_CompressedData.Length);
			label1.Text = msg;

			// we can now expand it
			btnExpandData.Enabled = true;
		}

		private void btnExpandData_Click(object sender, System.EventArgs e)
		{
			// open memory stream on saved data
			MemoryStream ms = new MemoryStream(m_CompressedData);

			// attach decompressor stream to memory stream
			C1ZStreamReader sr = new C1ZStreamReader(ms);

			// read uncompressed data
			BinaryReader br = new BinaryReader(sr);
			int count = br.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				int    deg = br.ReadInt32();
				double rad = br.ReadDouble();
				double sin = br.ReadDouble();
				double cos = br.ReadDouble();
			}

			// done, tell user about it
			string msg = string.Format("Read table with {0} points from stream with {1} bytes.", count, m_CompressedData.Length);
			label1.Text = msg;
		}
	}
}
