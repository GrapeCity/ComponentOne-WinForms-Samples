using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RtfTitle
{
	/// <summary>
	/// Summary description for RtfForm.
	/// </summary>
	public class RtfForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;

		public string Rtf
		{
			get
			{
				return richTextBox1.Rtf;
			}
			set
			{
				richTextBox1.Rtf = value;
			}
		}

		public RtfForm()
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
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( disposing )
			{
				if(components != null)
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
			this.btnFont = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnFont
			// 
			this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFont.Location = new System.Drawing.Point(64, 8);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(160, 21);
			this.btnFont.TabIndex = 0;
			this.btnFont.Text = "button1";
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.AcceptsTab = true;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.Location = new System.Drawing.Point(0, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(392, 201);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "richTextBox1";
			this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
			// 
			// fontDialog1
			// 
			this.fontDialog1.ShowColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Location = new System.Drawing.Point(200, 248);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(296, 248);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Font:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Left",
																									 "Center",
																									 "Right"});
			this.comboBox1.Location = new System.Drawing.Point(328, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(64, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(256, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "Alignment:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RtfForm
			// 
			this.AcceptButton = this.btnOk;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(392, 273);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label2,
																																	this.comboBox1,
																																	this.label1,
																																	this.btnCancel,
																																	this.btnOk,
																																	this.richTextBox1,
																																	this.btnFont});
			this.DockPadding.Bottom = 32;
			this.DockPadding.Top = 40;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RtfForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit rtf";
			this.Load += new System.EventHandler(this.RtfForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void RtfForm_Load(object sender, System.EventArgs e)
		{
			updateFont();
			updateAlignment();
		}

		private void btnFont_Click(object sender, System.EventArgs e)
		{
			if(fontDialog1.ShowDialog() != DialogResult.Cancel )
			{
				richTextBox1.SelectionColor = fontDialog1.Color;
				richTextBox1.SelectionFont = fontDialog1.Font;

				updateFont();
			}
		}

		private void updateFont()
		{
			btnFont.ForeColor = richTextBox1.SelectionColor;
			btnFont.Text = string.Format( "{0}, {1}pt", richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.SizeInPoints);
		}

		private void updateAlignment()
		{
			comboBox1.SelectedItem = richTextBox1.SelectionAlignment.ToString();
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			richTextBox1.SelectionAlignment = (HorizontalAlignment)Enum.Parse( typeof(HorizontalAlignment),
				comboBox1.SelectedItem.ToString());
		}

		private void richTextBox1_SelectionChanged(object sender, System.EventArgs e)
		{
			updateAlignment();
		}
	}
}
