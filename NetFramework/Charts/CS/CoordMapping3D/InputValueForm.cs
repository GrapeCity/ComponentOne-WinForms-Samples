using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoordMapping
{
	/// <summary>
	/// Summary description for InputValueForm.
	/// </summary>
	public class InputValueForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbValue;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnHole;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InputValueForm()
		{
			InitializeComponent();
		}

		public double ZValue
		{
			get
			{
				// return exactly the same hole value
				if( tbValue.Text.Equals("(Hole)"))
					return m_hole;
				try
				{
					return double.Parse( tbValue.Text);
				}
				catch
				{
					return m_hole;
				}
			}
			set
			{
				tbValue.Text = value.ToString();
			}
		}

		double m_hole = double.NaN;				
		public double Hole
		{
			get
			{
				return m_hole;
			}
			set
			{
				m_hole = value;
			}
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
			this.tbValue = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnHole = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbValue
			// 
			this.tbValue.Location = new System.Drawing.Point(16, 16);
			this.tbValue.Name = "tbValue";
			this.tbValue.Size = new System.Drawing.Size(104, 20);
			this.tbValue.TabIndex = 0;
			this.tbValue.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(16, 56);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 20);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(136, 56);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 20);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			// 
			// btnHole
			// 
			this.btnHole.Location = new System.Drawing.Point(136, 16);
			this.btnHole.Name = "btnHole";
			this.btnHole.Size = new System.Drawing.Size(75, 20);
			this.btnHole.TabIndex = 3;
			this.btnHole.Text = "Set Hole";
			this.btnHole.Click += new System.EventHandler(this.btnHole_Click);
			// 
			// InputValueForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(226, 87);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnHole,
																																	this.btnCancel,
																																	this.btnOk,
																																	this.tbValue});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "InputValueForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter Z-Value";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnHole_Click(object sender, System.EventArgs e)
		{
			if( Hole!=double.NaN)
				tbValue.Text = "(Hole)";
		}
	}
}
