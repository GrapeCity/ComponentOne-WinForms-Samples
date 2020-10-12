using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartLoader
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class frmLoadURL : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labEnterURL;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLoadURL()
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
			this.labEnterURL = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labEnterURL
			// 
			this.labEnterURL.Location = new System.Drawing.Point(8, 24);
			this.labEnterURL.Name = "labEnterURL";
			this.labEnterURL.Size = new System.Drawing.Size(72, 16);
			this.labEnterURL.TabIndex = 0;
			this.labEnterURL.Text = "Enter URL:";
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(24, 48);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(496, 20);
			this.txtURL.TabIndex = 1;
			this.txtURL.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(360, 96);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(448, 96);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			// 
			// frmLoadURL
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(542, 133);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnCancel,
																		  this.btnOK,
																		  this.txtURL,
																		  this.labEnterURL});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLoadURL";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Load Chart from URL...";
			this.ResumeLayout(false);

		}
		#endregion

		public string URL
		{
			get { return txtURL.Text; }
			set { txtURL.Text = value; }
		}
	}
}
