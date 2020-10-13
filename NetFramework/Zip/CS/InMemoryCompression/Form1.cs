using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace InMemoryCompression
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(8, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(144, 200);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add Files to Archive";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button2.Location = new System.Drawing.Point(8, 248);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 24);
			this.button2.TabIndex = 1;
			this.button2.Text = "Show Selected File";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.Location = new System.Drawing.Point(160, 8);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(248, 264);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 277);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1,
																		  this.button1,
																		  this.listBox1,
																		  this.button2});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Zip: In-memory compression";
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

		// archive contains (compressed memory streams)
		Hashtable _archive = new Hashtable();

		// add a file to the archive
		private void AddToArchive(string fileName)
		{
			// open compressor on memory stream
			MemoryStream ms = new MemoryStream();
			C1.C1Zip.C1ZStreamWriter sw = new C1.C1Zip.C1ZStreamWriter(ms);

			// write file into compressor
			byte[] buff = new byte[1024 * 32];
			using (FileStream fs = new FileStream(fileName, FileMode.Open))
			{
				for (;;)
				{
					int count = fs.Read(buff, 0, buff.Length);
					if (count == 0) break;
					sw.Write(buff, 0, count);
				}
			}
			sw.Flush();

			// save compressed stream
			_archive[fileName] = ms;
		}

		// expand a stream from the archive
		private void ReadFromArchive(string fileName, Stream s)
		{
			// open compressed stream
			Stream cs = (Stream)_archive[fileName];
			if (cs == null) return;
			cs.Position = 0;

			// decompress into output stream
			byte[] buff = new byte[1024 * 32];
			C1.C1Zip.C1ZStreamReader zr = new C1.C1Zip.C1ZStreamReader(cs);
			for (;;)
			{
				int count = zr.Read(buff, 0, buff.Length);
				if (count == 0) break;
				s.Write(buff, 0, count);
			}
			s.Flush();
		}

		// update list display
		private void UpdateList()
		{
			this.listBox1.Items.Clear();
			foreach (string s in _archive.Keys)
			{
				this.listBox1.Items.Add(s);
			}
		}

		// show file name with no path
		private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			e.DrawBackground();
			string s = (e.Index > -1)
				? Path.GetFileName((string)this.listBox1.Items[e.Index])
				: string.Empty;
			Brush br = ((e.State & DrawItemState.Selected) != 0)
				? SystemBrushes.HighlightText
				: SystemBrushes.WindowText;
			e.Graphics.DrawString(s, Font, br, e.Bounds);
		}

		// add items to archive
		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Multiselect = true;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in dlg.FileNames)
				{
					AddToArchive(fileName);
				}
			}
			UpdateList();
		}

		// show selected item
		private void button2_Click(object sender, System.EventArgs e)
		{
			if (listBox1.Items.Count == 0 || listBox1.SelectedIndex < 0)
				return;

			// clear text box
			textBox1.Clear();

			// expand into new stream
			MemoryStream ms = new MemoryStream();
			ReadFromArchive(listBox1.Text, ms);

			// show in textbox
            byte[] buff = ms.ToArray();
			textBox1.Text = System.Text.Encoding.Default.GetString(buff, 0, (int)ms.Length);
		}
	}
}
