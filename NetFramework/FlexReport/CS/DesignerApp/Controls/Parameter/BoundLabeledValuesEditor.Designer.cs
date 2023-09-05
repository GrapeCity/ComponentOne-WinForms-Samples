//----------------------------------------------------------------------------
// BoundLabeledValuesEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using C1.Util.Win;
using C1.Win.C1Input;

namespace FlexReportDesignerApp.Controls.Parameter
{
    partial class BoundLabeledValuesEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbDataSourceName = new C1.Win.C1Input.C1ComboBox();
            this.svecLabel = new FlexReportDesignerApp.Controls.ScriptValueEditorControl();
            this.svecValue = new FlexReportDesignerApp.Controls.ScriptValueEditorControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDataSourceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svecLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svecValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataSource
            // 
            this.lblDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(0, 4);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(77, 12);
            this.lblDataSource.TabIndex = 0;
            this.lblDataSource.Text = "Data Source:";
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(0, 48);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(41, 12);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label:";
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(0, 93);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 12);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value:";
            // 
            // cmbDataSourceName
            // 
            this.cmbDataSourceName.AllowSpinLoop = false;
            this.cmbDataSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDataSourceName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbDataSourceName.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cmbDataSourceName.GapHeight = 0;
            this.cmbDataSourceName.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbDataSourceName.ItemsDisplayMember = "";
            this.cmbDataSourceName.ItemsValueMember = "";
            this.cmbDataSourceName.Location = new System.Drawing.Point(0, 19);
            this.cmbDataSourceName.Name = "cmbDataSourceName";
            this.cmbDataSourceName.ShowFocusRectangle = true;
            this.cmbDataSourceName.Size = new System.Drawing.Size(223, 19);
            this.cmbDataSourceName.TabIndex = 1;
            this.cmbDataSourceName.Tag = null;
            // 
            // svecLabel
            // 
            this.svecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svecLabel.Enabled = false;
            this.svecLabel.Expression = "";
            this.svecLabel.GapHeight = 0;
            this.svecLabel.ImagePadding = new System.Windows.Forms.Padding(0);
            this.svecLabel.Location = new System.Drawing.Point(0, 64);
            this.svecLabel.Name = "svecLabel";
            this.svecLabel.Size = new System.Drawing.Size(223, 19);
            this.svecLabel.TabIndex = 3;
            this.svecLabel.Tag = null;
            // 
            // svecValue
            // 
            this.svecValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svecValue.Enabled = false;
            this.svecValue.Expression = "";
            this.svecValue.GapHeight = 0;
            this.svecValue.ImagePadding = new System.Windows.Forms.Padding(0);
            this.svecValue.Location = new System.Drawing.Point(0, 109);
            this.svecValue.Name = "svecValue";
            this.svecValue.Size = new System.Drawing.Size(223, 19);
            this.svecValue.TabIndex = 5;
            this.svecValue.Tag = null;
            // 
            // BoundLabeledValuesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.svecValue);
            this.Controls.Add(this.svecLabel);
            this.Controls.Add(this.cmbDataSourceName);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblDataSource);
            this.Name = "BoundLabeledValuesEditor";
            this.Size = new System.Drawing.Size(223, 138);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDataSourceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svecLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svecValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblValue;
        private C1.Win.C1Input.C1ComboBox cmbDataSourceName;
        private ScriptValueEditorControl svecLabel;
        private ScriptValueEditorControl svecValue;
    }
}
