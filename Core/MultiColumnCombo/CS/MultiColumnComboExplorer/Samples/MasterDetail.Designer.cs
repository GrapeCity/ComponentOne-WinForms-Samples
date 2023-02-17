namespace MultiColumnComboExplorer.Samples
{
    partial class MasterDetail
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
            this.ipDetailed = new C1.Win.InputPanel.C1InputPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ipDetailed)).BeginInit();
            this.SuspendLayout();
            // 
            // ipDetailed
            // 
            this.ipDetailed.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.ipDetailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipDetailed.Location = new System.Drawing.Point(0, 0);
            this.ipDetailed.Name = "ipDetailed";
            this.ipDetailed.Size = new System.Drawing.Size(714, 415);
            this.ipDetailed.TabIndex = 0;
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ipDetailed);
            this.Name = "MasterDetail";
            this.Size = new System.Drawing.Size(714, 415);
            this.Load += new System.EventHandler(this.MasterDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipDetailed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel ipDetailed;
    }
}
