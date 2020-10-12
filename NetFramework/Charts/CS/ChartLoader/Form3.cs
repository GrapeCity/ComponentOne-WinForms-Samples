using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartLoader
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class frmClientSize : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Label labWidth;
		private System.Windows.Forms.Label labHeight;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.TextBox txtHeight;
		private bool allowExit = false;
		private Form clientForm = null;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmClientSize()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.labWidth = new System.Windows.Forms.Label();
			this.labHeight = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(8, 72);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(64, 24);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(80, 72);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 24);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnApply
			// 
			this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnApply.Location = new System.Drawing.Point(184, 72);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(64, 24);
			this.btnApply.TabIndex = 2;
			this.btnApply.Text = "&Apply";
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// labWidth
			// 
			this.labWidth.Location = new System.Drawing.Point(8, 24);
			this.labWidth.Name = "labWidth";
			this.labWidth.Size = new System.Drawing.Size(40, 24);
			this.labWidth.TabIndex = 3;
			this.labWidth.Text = "&Width:";
			// 
			// labHeight
			// 
			this.labHeight.Location = new System.Drawing.Point(152, 24);
			this.labHeight.Name = "labHeight";
			this.labHeight.Size = new System.Drawing.Size(40, 23);
			this.labHeight.TabIndex = 4;
			this.labHeight.Text = "&Height:";
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(48, 24);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(50, 20);
			this.txtWidth.TabIndex = 5;
			this.txtWidth.Text = "0";
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(200, 24);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(50, 20);
			this.txtHeight.TabIndex = 6;
			this.txtHeight.Text = "0";
			// 
			// frmClientSize
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(264, 109);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.txtHeight,
																		  this.txtWidth,
																		  this.labHeight,
																		  this.labWidth,
																		  this.btnApply,
																		  this.btnCancel,
																		  this.btnOK});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmClientSize";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set Chart Form ClientSize ...";
			this.ResumeLayout(false);

		}
		#endregion

		public void SetClientForm(Form frm)
		{
			clientForm = frm;
			txtWidth.Text = frm.ClientSize.Width.ToString();
			txtHeight.Text = frm.ClientSize.Height.ToString();
		}

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			int minbound = 10;
			int w = minbound, h = minbound;

			allowExit = false;

			try
			{
				w = Int32.Parse(txtWidth.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				txtWidth.Focus();
				return;
			}

			try
			{
				h = Int32.Parse(txtHeight.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				txtHeight.Focus();
				return;
			}

			if(w < minbound)
			{
				MessageBox.Show("Minimum client width is " + minbound.ToString());
				w = 10;
			}

			if(h < minbound)
			{
				MessageBox.Show("Minimum client width is " + minbound.ToString());
				h = 10;
			}

			clientForm.ClientSize = new Size(w, h);
			allowExit = true;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			btnApply_Click(sender, e);
			if(allowExit)
				Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
