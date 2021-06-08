
namespace SimpleReports
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._ribbonPreview = new C1.Win.RibbonPreview.C1RibbonPreview();
            this._printDocument = new C1.C1Preview.C1PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this._ribbonPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._printDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // _ribbonPreview
            // 
            this._ribbonPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this._ribbonPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._ribbonPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ribbonPreview.Document = this._printDocument;
            this._ribbonPreview.Location = new System.Drawing.Point(0, 0);
            this._ribbonPreview.Name = "_ribbonPreview";
            this._ribbonPreview.Size = new System.Drawing.Size(800, 450);
            this._ribbonPreview.TabIndex = 0;
            this._ribbonPreview.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._ribbonPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple reports viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._ribbonPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._printDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.RibbonPreview.C1RibbonPreview _ribbonPreview;
        private C1.C1Preview.C1PrintDocument _printDocument;
    }
}