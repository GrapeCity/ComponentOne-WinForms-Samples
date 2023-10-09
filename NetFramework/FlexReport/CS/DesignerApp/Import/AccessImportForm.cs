//----------------------------------------------------------------------------
// AccessImportForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
    /// Implements Access import form for C1ReportDesigner application.
	/// </summary>
	public class AccessImportForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.CheckedListBox _chkList;
        private System.Windows.Forms.Button _btnSelectAll;
        private System.Windows.Forms.Button _btnClearAll;
        private System.Windows.Forms.CheckBox _chkClear;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOK;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AccessImportForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessImportForm));
            this._chkList = new System.Windows.Forms.CheckedListBox();
            this._btnSelectAll = new System.Windows.Forms.Button();
            this._btnClearAll = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            this._chkClear = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _chkList
            // 
            this._chkList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._chkList.IntegralHeight = false;
            this._chkList.Location = new System.Drawing.Point(8, 24);
            this._chkList.Name = "_chkList";
            this._chkList.Size = new System.Drawing.Size(442, 192);
            this._chkList.Sorted = true;
            this._chkList.TabIndex = 1;
            // 
            // _btnSelectAll
            // 
            this._btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnSelectAll.Location = new System.Drawing.Point(8, 224);
            this._btnSelectAll.Name = "_btnSelectAll";
            this._btnSelectAll.Size = new System.Drawing.Size(110, 23);
            this._btnSelectAll.TabIndex = 2;
            this._btnSelectAll.Text = "&All";
            this._btnSelectAll.Click += new System.EventHandler(this._btnSelectAll_Click);
            // 
            // _btnClearAll
            // 
            this._btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnClearAll.Location = new System.Drawing.Point(121, 224);
            this._btnClearAll.Name = "_btnClearAll";
            this._btnClearAll.Size = new System.Drawing.Size(110, 23);
            this._btnClearAll.TabIndex = 3;
            this._btnClearAll.Text = "&None";
            this._btnClearAll.Click += new System.EventHandler(this._btnClearAll_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(347, 263);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(102, 24);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.Location = new System.Drawing.Point(237, 263);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(103, 24);
            this._btnOK.TabIndex = 5;
            this._btnOK.Text = "&OK";
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _chkClear
            // 
            this._chkClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._chkClear.Location = new System.Drawing.Point(237, 224);
            this._chkClear.Name = "_chkClear";
            this._chkClear.Size = new System.Drawing.Size(221, 23);
            this._chkClear.TabIndex = 4;
            this._chkClear.Text = "Clea&r current reports before importing";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(8, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 2);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Available Reports:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccessImportForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(456, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._chkClear);
            this.Controls.Add(this._btnSelectAll);
            this.Controls.Add(this._chkList);
            this.Controls.Add(this._btnClearAll);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 232);
            this.Name = "AccessImportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Reports to Import";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        // expose checked list box to caller
        public CheckedListBox CheckedList
        {
            get { return _chkList; }
        }

        // expose ClearOnImport selection
        public bool ClearOnImport
        {
            get { return _chkClear.Checked; }
        }

        // select all reports
        private void _btnSelectAll_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < _chkList.Items.Count; i++)
                _chkList.SetItemChecked(i, true);
        }

        // de-select all reports
        private void _btnClearAll_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < _chkList.Items.Count; i++)
                _chkList.SetItemChecked(i, false);
        }

        // close dialog
        private void _btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
