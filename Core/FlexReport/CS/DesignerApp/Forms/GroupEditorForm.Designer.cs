//----------------------------------------------------------------------------
// GroupEditorForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Util
{
    partial class GroupEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupEditorForm));
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            this._lstGroups = new System.Windows.Forms.ListBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._btnUp = new System.Windows.Forms.Button();
            this._btnDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._propGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnCancel.Location = new System.Drawing.Point(616, 374);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 17;
            this._btnCancel.Text = "&Cancel";
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnOK.Location = new System.Drawing.Point(535, 374);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 16;
            this._btnOK.Text = "&OK";
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _lstGroups
            // 
            this._lstGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lstGroups.IntegralHeight = false;
            this._lstGroups.Location = new System.Drawing.Point(8, 24);
            this._lstGroups.Name = "_lstGroups";
            this._lstGroups.Size = new System.Drawing.Size(168, 307);
            this._lstGroups.TabIndex = 1;
            this._lstGroups.SelectedIndexChanged += new System.EventHandler(this._lstGroups_SelectedIndexChanged);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnAdd.Location = new System.Drawing.Point(11, 337);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "&Add";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnDelete.Location = new System.Drawing.Point(92, 337);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(75, 23);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "&Delete";
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Groups";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnUp
            // 
            this._btnUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnUp.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._btnUp.Location = new System.Drawing.Point(184, 24);
            this._btnUp.Name = "_btnUp";
            this._btnUp.Size = new System.Drawing.Size(24, 24);
            this._btnUp.TabIndex = 4;
            this._btnUp.Text = "y";
            this._btnUp.Click += new System.EventHandler(this._btnUp_Click);
            // 
            // _btnDown
            // 
            this._btnDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnDown.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._btnDown.Location = new System.Drawing.Point(184, 56);
            this._btnDown.Name = "_btnDown";
            this._btnDown.Size = new System.Drawing.Size(24, 24);
            this._btnDown.TabIndex = 5;
            this._btnDown.Text = "y";
            this._btnDown.Click += new System.EventHandler(this._btnDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 2);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // _propGrid
            // 
            this._propGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._propGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._propGrid.Location = new System.Drawing.Point(214, 8);
            this._propGrid.Name = "_propGrid";
            this._propGrid.Size = new System.Drawing.Size(462, 352);
            this._propGrid.TabIndex = 19;
            // 
            // GroupEditorForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this._propGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnUp);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._lstGroups);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GroupEditorForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.GroupEditorForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox _lstGroups;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnUp;
        private System.Windows.Forms.Button _btnDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid _propGrid;
    }
}
