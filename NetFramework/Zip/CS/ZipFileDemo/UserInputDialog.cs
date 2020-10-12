using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace C1ZipDemo
{
	/// <summary>
	/// Summary description for Selection.
	/// </summary>
	public class UserInputDialog : System.Windows.Forms.Form
	{
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        // show dialog and return value to the user
        public string GetString(string caption)
        {
            return GetString(caption, "");
        }
        public string GetString(string caption, string defValue)
        {
            // initialize dialog
            Text = caption;
            txtUser.Text = defValue;
            txtUser.SelectAll();

            // show dialog
            DialogResult dr = ShowDialog();

            // return null if the user canceled
            if (dr != DialogResult.OK) return null;

            // otherwise, return value to user (could be "")
            return txtUser.Text;
        }

        // handle OK and Cancel buttons
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserInputDialog()
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(8, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(136, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserInputDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(296, 69);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.btnCancel,
                                                                          this.btnOK,
                                                                          this.txtUser});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caption";
            this.ResumeLayout(false);

        }
		#endregion

	}
}
