//----------------------------------------------------------------------------
// ReportStyleForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    partial class ReportStyleForm : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportStyleForm));
            this._list = new System.Windows.Forms.ListBox();
            this._preview = new System.Windows.Forms.PictureBox();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnApply = new System.Windows.Forms.Button();
            this._propGrid = new System.Windows.Forms.PropertyGrid();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._lblPropGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._preview)).BeginInit();
            this.SuspendLayout();
            // 
            // _list
            // 
            this._list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._list.IntegralHeight = false;
            this._list.Location = new System.Drawing.Point(10, 24);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(184, 360);
            this._list.TabIndex = 1;
            this._list.SelectedIndexChanged += new System.EventHandler(this._list_SelectedIndexChanged);
            this._list.DoubleClick += new System.EventHandler(this._list_DoubleClick);
            // 
            // _preview
            // 
            this._preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._preview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._preview.Location = new System.Drawing.Point(200, 214);
            this._preview.Name = "_preview";
            this._preview.Size = new System.Drawing.Size(374, 204);
            this._preview.TabIndex = 1;
            this._preview.TabStop = false;
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.Location = new System.Drawing.Point(376, 430);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(95, 28);
            this._btnOK.TabIndex = 8;
            this._btnOK.Text = "&OK";
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.Location = new System.Drawing.Point(477, 430);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(95, 28);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnApply
            // 
            this._btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnApply.Location = new System.Drawing.Point(10, 430);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(90, 28);
            this._btnApply.TabIndex = 10;
            this._btnApply.Text = "Appl&y";
            this._btnApply.Click += new System.EventHandler(this._btnApply_Click);
            // 
            // _propGrid
            // 
            this._propGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._propGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._propGrid.HelpVisible = false;
            this._propGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
            this._propGrid.Location = new System.Drawing.Point(200, 24);
            this._propGrid.Name = "_propGrid";
            this._propGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this._propGrid.Size = new System.Drawing.Size(374, 184);
            this._propGrid.TabIndex = 5;
            this._propGrid.ToolbarVisible = false;
            this._propGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this._propGrid_PropertyValueChanged);
            // 
            // _btnRemove
            // 
            this._btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnRemove.Location = new System.Drawing.Point(104, 390);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(90, 28);
            this._btnRemove.TabIndex = 3;
            this._btnRemove.Text = "&Remove";
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnAdd.Location = new System.Drawing.Point(10, 390);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(90, 28);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "&Add";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(8, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 2);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Style Gallery:";
            // 
            // _lblPropGrid
            // 
            this._lblPropGrid.AutoSize = true;
            this._lblPropGrid.Location = new System.Drawing.Point(197, 9);
            this._lblPropGrid.Name = "_lblPropGrid";
            this._lblPropGrid.Size = new System.Drawing.Size(54, 13);
            this._lblPropGrid.TabIndex = 4;
            this._lblPropGrid.Text = "Edit Style:";
            // 
            // ReportStyleForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this._lblPropGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._preview);
            this.Controls.Add(this._list);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnApply);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._propGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 445);
            this.Name = "ReportStyleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Style Editor";
            ((System.ComponentModel.ISupportInitialize)(this._preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ListBox _list;
        private System.Windows.Forms.PictureBox _preview;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnApply;
        private System.Windows.Forms.PropertyGrid _propGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label _lblPropGrid;
    }
}
