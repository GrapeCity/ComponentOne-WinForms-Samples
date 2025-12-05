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
            rpc = new C1.Win.RibbonPreview.C1RibbonPreview();
            ((System.ComponentModel.ISupportInitialize)rpc).BeginInit();
            SuspendLayout();
            // 
            // rpc
            // 
            rpc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            rpc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            rpc.Dock = System.Windows.Forms.DockStyle.Fill;
            rpc.Location = new System.Drawing.Point(0, 0);
            rpc.Name = "rpc";
            rpc.Size = new System.Drawing.Size(735, 442);
            rpc.TabIndex = 0;
            rpc.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            rpc.UserAction += rpc_UserAction;
            // 
            // PreviewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(735, 442);
            Controls.Add(rpc);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "PreviewForm";
            Text = "C1PrintDocument Viewer";
            Shown += PreviewForm_Shown;
            ((System.ComponentModel.ISupportInitialize)rpc).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.RibbonPreview.C1RibbonPreview rpc;
    }
}

