using System.Windows.Forms;

namespace FinancialChartExplorer.CustomControls
{
    partial class C1NumericEditEx
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
            this.c1NumericEdit1 = new C1.Win.Input.C1NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.Location = new System.Drawing.Point(0, 3);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(60, 22);
            this.c1NumericEdit1.TabIndex = 0;
            this.c1NumericEdit1.Tag = null;
            // 
            // C1NumericEditExx
            // 
            this.Size = new System.Drawing.Size(147, 22);
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1NumericEdit c1NumericEdit1;
    }
}
