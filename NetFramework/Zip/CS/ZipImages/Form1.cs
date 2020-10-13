using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using C1.C1Zip;

namespace ZipImages
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Splitter splitter1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 285);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(184, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 285);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(176, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(8, 285);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 285);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1,
																		  this.splitter1,
																		  this.listBox1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Zip: Load zipped images";
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

		C1ZipFile _zip = new C1ZipFile();

		// build list of images in resource directory, add them all to a zip file
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// get app dir
			string s = Application.ExecutablePath;
			s = s.Substring(0, s.IndexOf(@"\bin")) + @"\resources";

			// create zip file
			_zip.Create(s + @"\images.zip");

			// populate zip file and list
			foreach (string f in Directory.GetFiles(s))
			{
				string fname = f.ToLower();
				if (fname.EndsWith("zip")) continue; // skip self
				listBox1.Items.Add(Path.GetFileName(fname)); // add to list
				_zip.Entries.Add(fname); // add to zip file
			}
		}

		// show selected image
		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// get selected item
			string item = (string)listBox1.SelectedItem;

			// load image directly from compressed stream
			Stream s = _zip.Entries[item].OpenReader();
			try
			{
				pictureBox1.Image = (Image)Image.FromStream(s);
			} 
			catch {}

			// done with stream
			s.Close();
		}
	}
}
