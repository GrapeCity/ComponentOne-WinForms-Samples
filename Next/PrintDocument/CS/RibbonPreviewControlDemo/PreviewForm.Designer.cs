namespace RibbonPreviewControlDemo
{
    partial class PreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.rpc = new C1.Win.RibbonPreview.C1RibbonPreview();
            ((System.ComponentModel.ISupportInitialize)(this.rpc)).BeginInit();
            this.SuspendLayout();
            // 
            // rpc
            // 
            this.rpc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.rpc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.rpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpc.Location = new System.Drawing.Point(0, 0);
            this.rpc.Name = "rpc";
            this.rpc.Size = new System.Drawing.Size(735, 442);
            this.rpc.TabIndex = 0;
            this.rpc.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            this.rpc.UserAction += new System.EventHandler<C1.Win.RibbonPreview.UserRibbonPreviewActionEventArgs>(this.rpc_UserAction);
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(735, 442);
            this.Controls.Add(this.rpc);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PreviewForm";
            this.Text = "C1PrintDocument Viewer";
            this.Shown += new System.EventHandler(this.PreviewForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.RibbonPreview.C1RibbonPreview rpc;
    }
}

