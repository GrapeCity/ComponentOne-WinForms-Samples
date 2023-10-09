//----------------------------------------------------------------------------
// AllowedValuesEditorControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Parameter
{
    partial class AllowedValuesEditorControl
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
            this.rbBinding = new System.Windows.Forms.RadioButton();
            this.rbValues = new System.Windows.Forms.RadioButton();
            this.blveMain = new FlexReportDesignerApp.Controls.Parameter.BoundLabeledValuesEditor();
            this.rlveMain = new FlexReportDesignerApp.Controls.Parameter.ReportLabeledValuesEditor();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbBinding
            // 
            this.rbBinding.AutoSize = true;
            this.rbBinding.Location = new System.Drawing.Point(0, 25);
            this.rbBinding.Name = "rbBinding";
            this.rbBinding.Size = new System.Drawing.Size(119, 16);
            this.rbBinding.TabIndex = 1;
            this.rbBinding.Text = "From Data Source";
            this.rbBinding.UseVisualStyleBackColor = true;
            // 
            // rbValues
            // 
            this.rbValues.AutoSize = true;
            this.rbValues.Location = new System.Drawing.Point(0, 47);
            this.rbValues.Name = "rbValues";
            this.rbValues.Size = new System.Drawing.Size(59, 16);
            this.rbValues.TabIndex = 2;
            this.rbValues.Text = "Values";
            this.rbValues.UseVisualStyleBackColor = true;
            // 
            // blveMain
            // 
            this.blveMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blveMain.Location = new System.Drawing.Point(0, 80);
            this.blveMain.Name = "blveMain";
            this.blveMain.Size = new System.Drawing.Size(400, 160);
            this.blveMain.TabIndex = 3;
            // 
            // rlveMain
            // 
            this.rlveMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rlveMain.Location = new System.Drawing.Point(0, 80);
            this.rlveMain.Name = "rlveMain";
            this.rlveMain.Size = new System.Drawing.Size(400, 160);
            this.rlveMain.TabIndex = 3;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(0, 3);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(47, 16);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // AllowedValuesEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.blveMain);
            this.Controls.Add(this.rbValues);
            this.Controls.Add(this.rbBinding);
            this.Controls.Add(this.rlveMain);
            this.Name = "AllowedValuesEditorControl";
            this.Size = new System.Drawing.Size(400, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBinding;
        private System.Windows.Forms.RadioButton rbValues;
        private BoundLabeledValuesEditor blveMain;
        private ReportLabeledValuesEditor rlveMain;
        private System.Windows.Forms.RadioButton rbNone;
    }
}
