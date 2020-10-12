//----------------------------------------------------------------------------
// AddSortDefForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Forms
{
    partial class AddSortDefForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSortDefForm));
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            this._cmbSort = new C1.Win.C1Input.C1ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this._chkAscending = new C1.Win.C1Input.C1CheckBox();
            this._chkDescending = new C1.Win.C1Input.C1CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._cmbSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkAscending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkDescending)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(290, 89);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(209, 89);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 4;
            this._btnOK.Text = "&OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _cmbSort
            // 
            this._cmbSort.AllowSpinLoop = false;
            this._cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbSort.GapHeight = 0;
            this._cmbSort.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cmbSort.ItemsDisplayMember = "";
            this._cmbSort.ItemsValueMember = "";
            this._cmbSort.Location = new System.Drawing.Point(94, 12);
            this._cmbSort.Name = "_cmbSort";
            this._cmbSort.Size = new System.Drawing.Size(271, 18);
            this._cmbSort.TabIndex = 1;
            this._cmbSort.Tag = null;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Location = new System.Drawing.Point(12, 15);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(43, 13);
            this.c1Label1.TabIndex = 0;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "&Sort by:";
            this.c1Label1.TextDetached = true;
            this.c1Label1.Value = "";
            // 
            // _chkAscending
            // 
            this._chkAscending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._chkAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkAscending.Image = ((System.Drawing.Image)(resources.GetObject("_chkAscending.Image")));
            this._chkAscending.Location = new System.Drawing.Point(94, 36);
            this._chkAscending.Name = "_chkAscending";
            this._chkAscending.Size = new System.Drawing.Size(111, 32);
            this._chkAscending.TabIndex = 2;
            this._chkAscending.Text = "&Ascending";
            this._chkAscending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._chkAscending.UseVisualStyleBackColor = true;
            this._chkAscending.Value = null;
            // 
            // _chkDescending
            // 
            this._chkDescending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._chkDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkDescending.Image = ((System.Drawing.Image)(resources.GetObject("_chkDescending.Image")));
            this._chkDescending.Location = new System.Drawing.Point(218, 36);
            this._chkDescending.Name = "_chkDescending";
            this._chkDescending.Size = new System.Drawing.Size(111, 32);
            this._chkDescending.TabIndex = 3;
            this._chkDescending.Text = "&Descending";
            this._chkDescending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._chkDescending.UseVisualStyleBackColor = true;
            this._chkDescending.Value = null;
            // 
            // AddSortDefForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(377, 124);
            this.Controls.Add(this._chkDescending);
            this.Controls.Add(this._chkAscending);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this._cmbSort);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSortDefForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort Definition";
            ((System.ComponentModel.ISupportInitialize)(this._cmbSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkAscending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkDescending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOK;
        private C1.Win.C1Input.C1ComboBox _cmbSort;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1CheckBox _chkAscending;
        private C1.Win.C1Input.C1CheckBox _chkDescending;
    }
}
