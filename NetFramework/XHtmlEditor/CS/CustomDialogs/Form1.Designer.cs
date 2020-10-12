namespace CustomDialogs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFormatting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsHyperlink = new System.Windows.Forms.ToolStripButton();
            this.tsBookmark = new System.Windows.Forms.ToolStripButton();
            this.tsPicture = new System.Windows.Forms.ToolStripButton();
            this.tsFlash = new System.Windows.Forms.ToolStripButton();
            this.tsTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFind = new System.Windows.Forms.ToolStripButton();
            this.tsReplace = new System.Windows.Forms.ToolStripButton();
            this.editor = new C1.Win.C1Editor.C1Editor();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFormatting,
            this.toolStripSeparator1,
            this.tsHyperlink,
            this.tsBookmark,
            this.tsPicture,
            this.tsFlash,
            this.tsTable,
            this.toolStripSeparator2,
            this.tsFind,
            this.tsReplace});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsFormatting
            // 
            this.tsFormatting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFormatting.Image = global::CustomDialogs.Properties.Resources.formatting;
            this.tsFormatting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFormatting.Name = "tsFormatting";
            this.tsFormatting.Size = new System.Drawing.Size(23, 22);
            this.tsFormatting.Text = "Text Formatting";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsHyperlink
            // 
            this.tsHyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsHyperlink.Image = global::CustomDialogs.Properties.Resources.hyperlink;
            this.tsHyperlink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHyperlink.Name = "tsHyperlink";
            this.tsHyperlink.Size = new System.Drawing.Size(23, 22);
            this.tsHyperlink.Text = "Insert Hyperlink";
            // 
            // tsBookmark
            // 
            this.tsBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBookmark.Image = global::CustomDialogs.Properties.Resources.bookmark;
            this.tsBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBookmark.Name = "tsBookmark";
            this.tsBookmark.Size = new System.Drawing.Size(23, 22);
            this.tsBookmark.Text = "Insert Bookmark";
            // 
            // tsPicture
            // 
            this.tsPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPicture.Image = global::CustomDialogs.Properties.Resources.picture;
            this.tsPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPicture.Name = "tsPicture";
            this.tsPicture.Size = new System.Drawing.Size(23, 22);
            this.tsPicture.Text = "Insert Picture From File";
            // 
            // tsFlash
            // 
            this.tsFlash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFlash.Image = global::CustomDialogs.Properties.Resources.flash;
            this.tsFlash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFlash.Name = "tsFlash";
            this.tsFlash.Size = new System.Drawing.Size(23, 22);
            this.tsFlash.Text = "Insert Movie in Flash Format";
            // 
            // tsTable
            // 
            this.tsTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTable.Image = global::CustomDialogs.Properties.Resources.table;
            this.tsTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTable.Name = "tsTable";
            this.tsTable.Size = new System.Drawing.Size(23, 22);
            this.tsTable.Text = "Insert Table";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsFind
            // 
            this.tsFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFind.Image = global::CustomDialogs.Properties.Resources.find;
            this.tsFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFind.Name = "tsFind";
            this.tsFind.Size = new System.Drawing.Size(23, 22);
            this.tsFind.Text = "Find";
            // 
            // tsReplace
            // 
            this.tsReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReplace.Image = global::CustomDialogs.Properties.Resources.replace;
            this.tsReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReplace.Name = "tsReplace";
            this.tsReplace.Size = new System.Drawing.Size(23, 22);
            this.tsReplace.Text = "Replace";
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.SystemColors.Window;
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 25);
            this.editor.Name = "editor";
            this.editor.WordWrap = true;
            this.editor.Size = new System.Drawing.Size(751, 436);
            this.editor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 461);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFormatting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsHyperlink;
        private System.Windows.Forms.ToolStripButton tsBookmark;
        private System.Windows.Forms.ToolStripButton tsPicture;
        private System.Windows.Forms.ToolStripButton tsFlash;
        private System.Windows.Forms.ToolStripButton tsTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsFind;
        private System.Windows.Forms.ToolStripButton tsReplace;
        private C1.Win.C1Editor.C1Editor editor;

    }
}