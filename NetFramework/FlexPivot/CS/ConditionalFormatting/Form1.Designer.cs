﻿namespace ConditionalFormatting
{
    partial class Form1
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
            this.c1FlexPivotPage1 = new C1.Win.FlexPivot.FlexPivotPage();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexPivotPage1
            // 
            this.c1FlexPivotPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotPage1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1FlexPivotPage1.Name = "c1FlexPivotPage1";
            this.c1FlexPivotPage1.Size = new System.Drawing.Size(733, 470);
            this.c1FlexPivotPage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 470);
            this.Controls.Add(this.c1FlexPivotPage1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexPivot: Conditional Formatting";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage c1FlexPivotPage1;
    }
}

