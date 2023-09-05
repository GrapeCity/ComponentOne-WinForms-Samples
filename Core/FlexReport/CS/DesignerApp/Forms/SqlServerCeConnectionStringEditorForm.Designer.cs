//----------------------------------------------------------------------------
// SqlServerCeConnectionStringEditorForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    partial class SqlServerCeConnectionStringEditorForm
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
            this.tbDataSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTempFilePath = new System.Windows.Forms.TextBox();
            this.gbExtended = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaxDatabaseSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxBufferSize = new System.Windows.Forms.TextBox();
            this.cbFileMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTempFilePathBrows = new System.Windows.Forms.Button();
            this.btnDataSourceBrowse = new System.Windows.Forms.Button();
            this.gbExtended.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDataSource
            // 
            this.tbDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataSource.Location = new System.Drawing.Point(12, 25);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(371, 20);
            this.tbDataSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database file name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temp file directory:";
            // 
            // tbTempFilePath
            // 
            this.tbTempFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTempFilePath.Location = new System.Drawing.Point(159, 23);
            this.tbTempFilePath.Name = "tbTempFilePath";
            this.tbTempFilePath.Size = new System.Drawing.Size(206, 20);
            this.tbTempFilePath.TabIndex = 1;
            // 
            // gbExtended
            // 
            this.gbExtended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExtended.Controls.Add(this.btnTempFilePathBrows);
            this.gbExtended.Controls.Add(this.label6);
            this.gbExtended.Controls.Add(this.cbFileMode);
            this.gbExtended.Controls.Add(this.tbMaxBufferSize);
            this.gbExtended.Controls.Add(this.label5);
            this.gbExtended.Controls.Add(this.tbMaxDatabaseSize);
            this.gbExtended.Controls.Add(this.label4);
            this.gbExtended.Controls.Add(this.label2);
            this.gbExtended.Controls.Add(this.tbTempFilePath);
            this.gbExtended.Location = new System.Drawing.Point(12, 77);
            this.gbExtended.Name = "gbExtended";
            this.gbExtended.Size = new System.Drawing.Size(403, 139);
            this.gbExtended.TabIndex = 5;
            this.gbExtended.TabStop = false;
            this.gbExtended.Text = " Extended properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 51);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(109, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum database size (MB):";
            // 
            // tbMaxDatabaseSize
            // 
            this.tbMaxDatabaseSize.Location = new System.Drawing.Point(159, 49);
            this.tbMaxDatabaseSize.Name = "tbMaxDatabaseSize";
            this.tbMaxDatabaseSize.Size = new System.Drawing.Size(100, 20);
            this.tbMaxDatabaseSize.TabIndex = 4;
            this.tbMaxDatabaseSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxDatabaseSize_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum buffer size (KB):";
            // 
            // tbMaxBufferSize
            // 
            this.tbMaxBufferSize.Location = new System.Drawing.Point(159, 75);
            this.tbMaxBufferSize.Name = "tbMaxBufferSize";
            this.tbMaxBufferSize.Size = new System.Drawing.Size(100, 20);
            this.tbMaxBufferSize.TabIndex = 6;
            this.tbMaxBufferSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxDatabaseSize_KeyPress);
            // 
            // cbFileMode
            // 
            this.cbFileMode.FormattingEnabled = true;
            this.cbFileMode.Location = new System.Drawing.Point(159, 101);
            this.cbFileMode.Name = "cbFileMode";
            this.cbFileMode.Size = new System.Drawing.Size(141, 21);
            this.cbFileMode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "File mode:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(259, 222);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(340, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTempFilePathBrows
            // 
            this.btnTempFilePathBrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTempFilePathBrows.Location = new System.Drawing.Point(371, 22);
            this.btnTempFilePathBrows.Name = "btnTempFilePathBrows";
            this.btnTempFilePathBrows.Size = new System.Drawing.Size(26, 21);
            this.btnTempFilePathBrows.TabIndex = 2;
            this.btnTempFilePathBrows.TabStop = false;
            this.btnTempFilePathBrows.Text = "...";
            this.btnTempFilePathBrows.UseVisualStyleBackColor = true;
            this.btnTempFilePathBrows.Click += new System.EventHandler(this.btnTempFilePathBrows_Click);
            // 
            // btnDataSourceBrowse
            // 
            this.btnDataSourceBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataSourceBrowse.Location = new System.Drawing.Point(389, 24);
            this.btnDataSourceBrowse.Name = "btnDataSourceBrowse";
            this.btnDataSourceBrowse.Size = new System.Drawing.Size(26, 21);
            this.btnDataSourceBrowse.TabIndex = 2;
            this.btnDataSourceBrowse.TabStop = false;
            this.btnDataSourceBrowse.Text = "...";
            this.btnDataSourceBrowse.UseVisualStyleBackColor = true;
            this.btnDataSourceBrowse.Click += new System.EventHandler(this.btnDataSourceBrowse_Click);
            // 
            // SqlServerCeConnectionStringEditorForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(427, 254);
            this.Controls.Add(this.btnDataSourceBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbExtended);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDataSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlServerCeConnectionStringEditorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft SQL Server Compact Properties";
            this.gbExtended.ResumeLayout(false);
            this.gbExtended.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDataSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTempFilePath;
        private System.Windows.Forms.GroupBox gbExtended;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFileMode;
        private System.Windows.Forms.TextBox tbMaxBufferSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxDatabaseSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTempFilePathBrows;
        private System.Windows.Forms.Button btnDataSourceBrowse;
    }
}
