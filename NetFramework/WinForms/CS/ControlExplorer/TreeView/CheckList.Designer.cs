namespace ControlExplorer.TreeView
{
    partial class CheckList
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
            this.c1CheckList1 = new C1.Win.TreeView.C1CheckList();
            this.SuspendLayout();
            // 
            // c1CheckList1
            // 
            this.c1CheckList1.BorderColor = System.Drawing.Color.Empty;
            this.c1CheckList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1CheckList1.Location = new System.Drawing.Point(0, 0);
            this.c1CheckList1.Name = "c1CheckList1";
            this.c1CheckList1.Size = new System.Drawing.Size(1042, 652);
            this.c1CheckList1.TabIndex = 0;
            this.c1CheckList1.Text = "c1CheckList1";
            // 
            // CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 652);
            this.Controls.Add(this.c1CheckList1);
            this.Name = "CheckList";
            this.Text = "CheckList";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1CheckList c1CheckList1;
    }
}