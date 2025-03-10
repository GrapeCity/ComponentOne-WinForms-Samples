using BaseExplorer;
using C1.Win.Input;

namespace FlexChartExplorer.Samples
{
    partial class Introduction
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBoxEx cbChartType;
        private ComboBoxEx cbPalette;
        private ComboBoxEx cbStacked;
        private CheckBoxEx chbRotate;
        private CheckBoxEx chbGroup;
        private LabelEx lblChartType;
        private LabelEx lblPalatte;
        private LabelEx lblStacking;

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
            SuspendLayout();
            // 
            // Introduction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Name = "Introduction";
            ResumeLayout(false);
        }

        #endregion
    }
}
