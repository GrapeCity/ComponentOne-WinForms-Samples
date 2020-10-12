//----------------------------------------------------------------------------
// PictureHolderEditorControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using Access;

namespace FlexReportDesignerApp.Controls
{
    partial class PictureHolderEditorControl
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

            lock (_lock)
            {
                if (_async != null && _async.AsyncWaitHandle != null)
                {
                    _async.AsyncWaitHandle.Close();
                    _async = null;
                }
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
            this.grpImageSource = new System.Windows.Forms.GroupBox();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioExpression = new System.Windows.Forms.RadioButton();
            this.radioURL = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.txtFile = new C1.Win.C1Input.C1DropDownControl();
            this.grpURL = new System.Windows.Forms.GroupBox();
            this.txtURL = new C1.Win.C1Input.C1TextBox();
            this.grpExpression = new System.Windows.Forms.GroupBox();
            this.cmbExpression = new FlexReportDesignerApp.Controls.ScriptValueEditorControl();
            this.grpImageSource.SuspendLayout();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.grpFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile)).BeginInit();
            this.grpURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL)).BeginInit();
            this.grpExpression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpression)).BeginInit();
            this.SuspendLayout();
            // 
            // grpImageSource
            // 
            this.grpImageSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImageSource.Controls.Add(this.radioNone);
            this.grpImageSource.Controls.Add(this.radioExpression);
            this.grpImageSource.Controls.Add(this.radioURL);
            this.grpImageSource.Controls.Add(this.radioFile);
            this.grpImageSource.Location = new System.Drawing.Point(4, 4);
            this.grpImageSource.Name = "grpImageSource";
            this.grpImageSource.Size = new System.Drawing.Size(190, 141);
            this.grpImageSource.TabIndex = 0;
            this.grpImageSource.TabStop = false;
            this.grpImageSource.Text = "Image Source";
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(6, 19);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(51, 17);
            this.radioNone.TabIndex = 0;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radioExpression
            // 
            this.radioExpression.AutoSize = true;
            this.radioExpression.Location = new System.Drawing.Point(6, 88);
            this.radioExpression.Name = "radioExpression";
            this.radioExpression.Size = new System.Drawing.Size(76, 17);
            this.radioExpression.TabIndex = 3;
            this.radioExpression.Text = "Expression";
            this.radioExpression.UseVisualStyleBackColor = true;
            // 
            // radioURL
            // 
            this.radioURL.AutoSize = true;
            this.radioURL.Location = new System.Drawing.Point(6, 65);
            this.radioURL.Name = "radioURL";
            this.radioURL.Size = new System.Drawing.Size(47, 17);
            this.radioURL.TabIndex = 2;
            this.radioURL.Text = "URL";
            this.radioURL.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Location = new System.Drawing.Point(6, 42);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(41, 17);
            this.radioFile.TabIndex = 1;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // grpPreview
            // 
            this.grpPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPreview.Controls.Add(this.picPreview);
            this.grpPreview.Location = new System.Drawing.Point(202, 4);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(180, 141);
            this.grpPreview.TabIndex = 1;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(3, 16);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(174, 122);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // grpFile
            // 
            this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFile.Controls.Add(this.txtFile);
            this.grpFile.Location = new System.Drawing.Point(3, 159);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(378, 56);
            this.grpFile.TabIndex = 2;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Select image from file:";
            this.grpFile.Visible = false;
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.ImagePadding = new System.Windows.Forms.Padding(0);
            this.txtFile.Location = new System.Drawing.Point(6, 22);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(366, 18);
            this.txtFile.TabIndex = 0;
            this.txtFile.Tag = null;
            this.txtFile.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.Modal;
            this.txtFile.ModalButtonClick += new System.EventHandler(this.c1DropDownControl1_ModalButtonClick);
            // 
            // grpURL
            // 
            this.grpURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpURL.Controls.Add(this.txtURL);
            this.grpURL.Location = new System.Drawing.Point(3, 220);
            this.grpURL.Name = "grpURL";
            this.grpURL.Size = new System.Drawing.Size(378, 56);
            this.grpURL.TabIndex = 3;
            this.grpURL.TabStop = false;
            this.grpURL.Text = "Select image from URL:";
            this.grpURL.Visible = false;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(6, 22);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(366, 18);
            this.txtURL.TabIndex = 0;
            this.txtURL.Tag = null;
            // 
            // grpExpression
            // 
            this.grpExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExpression.Controls.Add(this.cmbExpression);
            this.grpExpression.Location = new System.Drawing.Point(3, 281);
            this.grpExpression.Name = "grpExpression";
            this.grpExpression.Size = new System.Drawing.Size(378, 56);
            this.grpExpression.TabIndex = 4;
            this.grpExpression.TabStop = false;
            this.grpExpression.Text = "Select image by expression:";
            this.grpExpression.Visible = false;
            // 
            // cmbExpression
            // 
            this.cmbExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExpression.GapHeight = 0;
            this.cmbExpression.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbExpression.Location = new System.Drawing.Point(6, 22);
            this.cmbExpression.Name = "cmbExpression";
            this.cmbExpression.ShowImageFields = true;
            this.cmbExpression.Size = new System.Drawing.Size(366, 18);
            this.cmbExpression.TabIndex = 0;
            this.cmbExpression.Tag = null;
            this.cmbExpression.Value = "";
            // 
            // PictureHolderEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpExpression);
            this.Controls.Add(this.grpURL);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.grpImageSource);
            this.Name = "PictureHolderEditorControl";
            this.Size = new System.Drawing.Size(389, 351);
            this.grpImageSource.ResumeLayout(false);
            this.grpImageSource.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.grpFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFile)).EndInit();
            this.grpURL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtURL)).EndInit();
            this.grpExpression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpression)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpImageSource;
        private System.Windows.Forms.RadioButton radioExpression;
        private System.Windows.Forms.RadioButton radioURL;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.GroupBox grpURL;
        private System.Windows.Forms.GroupBox grpExpression;
        private ScriptValueEditorControl cmbExpression;
        private C1.Win.C1Input.C1DropDownControl txtFile;
        private C1.Win.C1Input.C1TextBox txtURL;
        private System.Windows.Forms.RadioButton radioNone;
    }
}
