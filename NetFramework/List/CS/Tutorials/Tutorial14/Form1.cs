using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial14
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.C1List1 = new C1.Win.List.C1List();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			this.SuspendLayout();
			// 
			// C1List1
			// 
			this.C1List1.AddItemCols = 0;
			this.C1List1.AddItemSeparator = ';';
			this.C1List1.AllowSort = true;
			this.C1List1.AlternatingRows = false;
			this.C1List1.CaptionHeight = 17;
			this.C1List1.ColumnCaptionHeight = 17;
			this.C1List1.ColumnFooterHeight = 17;
			this.C1List1.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("C1List1.Images.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(40, 16);
			this.C1List1.MatchCol = C1.Win.List.MatchColEnum.DisplayMember;
			this.C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.None;
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.ScrollTips = false;
			this.C1List1.Size = new System.Drawing.Size(496, 296);
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.FetchCellStyle += new C1.Win.List.FetchCellStyleEventHandler(this.C1List1_FetchCellStyle);
			this.C1List1.PropBag = ((string)(resources.GetObject("C1List1.PropBag")));
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 336);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(320, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "textBox1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(432, 328);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Display";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 389);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.textBox1,
																		  this.C1List1});
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial14";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
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
			this.C1List1.AddItemTitles("File Name; Picture");
			this.C1List1.ExtendRightColumn = true;
			this.C1List1.ItemHeight = 50;

			string dir,fileName;
			string[] strCol;
			dir = this.textBox1.Text.Trim();
			strCol = System.IO.Directory.GetFiles(dir, "*.bmp");

			foreach (string str in strCol)
			{
				fileName = str.Substring(str.LastIndexOf("\\") + 1);
				this.C1List1.AddItem(fileName + ";");
			}

			//Fire FetchCellStyle event
			this.C1List1.Splits[0].DisplayColumns[1].FetchStyle = true;	
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			string dir = Application.StartupPath;
			dir = dir.Substring(0, dir.LastIndexOf("\\"));
			dir = dir.Substring(0, dir.LastIndexOf("\\"));
			dir = dir.Substring(0, dir.LastIndexOf("\\"));
			dir = dir + "\\Flags";
			this.textBox1.Text = dir;
		}

		private void C1List1_FetchCellStyle(object sender, C1.Win.List.FetchCellStyleEventArgs e)
		{
			if (e.Col == 1)
			{
				string file = this.C1List1.Splits[0].DisplayColumns[0].DataColumn.CellText(e.Row);
				file = this.textBox1.Text.Trim() + "\\" + file;
				e.CellStyle.ForeGroundPicturePosition = C1.Win.List.ForeGroundPicturePositionEnum.PictureOnly;
				e.CellStyle.ForegroundImage = Image.FromFile(file);
			}
		}
	}
}
