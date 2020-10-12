using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private C1.Win.C1List.C1List C1List1;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.C1List1 = new C1.Win.C1List.C1List();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(376, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Phone:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(48, 240);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "textBox1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(216, 240);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "textBox2";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(376, 240);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(88, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "textBox3";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "Add Record";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(216, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 32);
			this.button2.TabIndex = 8;
			this.button2.Text = "Delete Record";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(376, 280);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 32);
			this.button3.TabIndex = 9;
			this.button3.Text = "Clear All";
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			this.C1List1.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("C1List1.Images.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(48, 16);
			this.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember;
			this.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None;
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.ScrollTips = false;
			this.C1List1.Size = new System.Drawing.Size(416, 192);
			this.C1List1.TabIndex = 11;
			this.C1List1.Text = "c1List2";
			this.C1List1.PropBag = ((string)(resources.GetObject("C1List1.PropBag")));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.C1List1,
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.textBox3,
																		  this.textBox2,
																		  this.textBox1,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial3";
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Add initial records
			this.C1List1.AddItemTitles("First Name; LastName; Phone Number");
			this.C1List1.AddItem("Greg;Daryll;412-657-3412");
			this.C1List1.AddItem("Jane;Lambert;567-123-6785");
			this.C1List1.AddItem("Allen;Clark;675-345-9087");
			this.C1List1.AddItem("David;Elkins;564-345-2635");
			this.C1List1.AddItem("Carl;Ziegler;412-678-2351");
			this.C1List1.AddItem("William;Yahner;412-980-6754");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.C1List1.AddItem(this.textBox1.Text + ";" + this.textBox2.Text + ";" + this.textBox3.Text);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.C1List1.RemoveItem(this.C1List1.SelectedIndex);
			}
			catch
			{
				MessageBox.Show("Select a item first","C1List");
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.C1List1.ClearItems();
		}
	}
}
