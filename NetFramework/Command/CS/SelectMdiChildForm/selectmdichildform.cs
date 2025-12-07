using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace SelectMdiChildForm
{
	public class SelectMdiChildForm : C1.Win.Command.C1SelectMdiChildForm
	{
        private System.Windows.Forms.Button btnClose;
		private System.ComponentModel.IContainer components = null;

		public SelectMdiChildForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_windowsList
            // 
            this.m_windowsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.m_windowsList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_windowsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.m_windowsList.ItemHeight = 32;
            this.m_windowsList.Size = new System.Drawing.Size(318, 130);
            // 
            // m_btnOK
            // 
            this.m_btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_btnOK.Location = new System.Drawing.Point(-172, 215);
            this.m_btnOK.Size = new System.Drawing.Size(135, 39);
            this.m_btnOK.UseVisualStyleBackColor = false;
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.m_btnCancel.Location = new System.Drawing.Point(-13, 215);
            this.m_btnCancel.Size = new System.Drawing.Size(135, 39);
            this.m_btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(145, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SelectMdiChildForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(318, 274);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(342, 338);
            this.Name = "SelectMdiChildForm";
            this.Text = "Please select a child window";
            this.Load += new System.EventHandler(this.SelectMdiChildForm_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.m_windowsList, 0);
            this.Controls.SetChildIndex(this.m_btnOK, 0);
            this.Controls.SetChildIndex(this.m_btnCancel, 0);
            this.ResumeLayout(false);

        }
		#endregion

        private void SelectMdiChildForm_Load(object sender, System.EventArgs e)
        {
            // adjust the form's height to show all windows
            int oldH = this.m_windowsList.Height;
            int newH = this.m_windowsList.ItemHeight * this.m_windowsList.Items.Count;
            this.Height += newH - oldH + 2;
            this.btnClose.Enabled = this.m_windowsList.Items.Count > 0;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            // provide the ability to close windows from the list.
            // C1.Win.Command.C1SelectMdiChildForm.WindowItem is the type
            // of items in the m_windowsList. It inherits from object,
            // adds a new member Form referencing the MDI child form,
            // and overrides the ToString() method to show the form caption.
            C1.Win.Command.C1SelectMdiChildForm.WindowItem selectedItem =
                this.m_windowsList.SelectedItem as C1.Win.Command.C1SelectMdiChildForm.WindowItem;
            if (selectedItem != null)
            {
                selectedItem.Form.Close();
                int i = this.m_windowsList.SelectedIndex;
                this.m_windowsList.Items.Remove(selectedItem);
                this.m_windowsList.SelectedIndex = i < this.m_windowsList.Items.Count ? i : i - 1;
                this.btnClose.Enabled = this.m_windowsList.Items.Count > 0;
            }
        }
	}
}
