namespace SeparateControls
{
    partial class DropDownPanel
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
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            this.SuspendLayout();
            // 
            // c1ExpressionEditorPanel1
            // 
            this.c1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditorPanel1.ExpressionEditor = null;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(456, 252);
            this.c1ExpressionEditorPanel1.TabIndex = 0;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // DropDownPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 252);
            this.Controls.Add(this.c1ExpressionEditorPanel1);
            this.Name = "DropDownPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
    }
}