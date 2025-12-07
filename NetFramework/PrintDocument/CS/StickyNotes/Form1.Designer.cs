namespace StickyNotes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miShowRoProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.miColorizeRo = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetRoText = new System.Windows.Forms.ToolStripTextBox();
            this.miStickyNoteRo = new System.Windows.Forms.ToolStripMenuItem();
            this.miHideShowStickyNotes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 616);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(852, 108);
            this.listBox1.TabIndex = 2;
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(2, 2);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // c1PrintPreviewControl1.OutlineView
            // 
            this.c1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView";
            this.c1PrintPreviewControl1.PreviewOutlineView.Size = new System.Drawing.Size(165, 427);
            this.c1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0;
            // 
            // c1PrintPreviewControl1.PreviewPane
            // 
            this.c1PrintPreviewControl1.PreviewPane.ContextMenuStrip = this.contextMenuStrip1;
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewPane.Paint += new System.Windows.Forms.PaintEventHandler(this.c1PrintPreviewControl1_PreviewPane_Paint);
            this.c1PrintPreviewControl1.PreviewPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1PrintPreviewControl1_PreviewPane_MouseMove);
            // 
            // c1PrintPreviewControl1.PreviewTextSearchPanel
            // 
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Location = new System.Drawing.Point(530, 0);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 453);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Visible = false;
            // 
            // c1PrintPreviewControl1.ThumbnailView
            // 
            this.c1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView";
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 543);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(864, 616);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.File.Print.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Print.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint";
            this.c1PrintPreviewControl1.ToolBars.File.Print.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print";
            this.c1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            this.c1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Find.Image")));
            this.c1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind";
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find";
            this.c1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.Checked = true;
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Hand.Image")));
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool";
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool";
            this.c1PrintPreviewControl1.ToolBars.Text.Hand.ToolTipText = "Hand Tool";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShowRoProperties,
            this.miColorizeRo,
            this.miSetRoText,
            this.miStickyNoteRo,
            this.miHideShowStickyNotes});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 139);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showRoProperties
            // 
            this.miShowRoProperties.Name = "miShowRoProperties";
            this.miShowRoProperties.Size = new System.Drawing.Size(202, 22);
            this.miShowRoProperties.Text = "RenderObject Properties";
            this.miShowRoProperties.ToolTipText = "View/update the properties of the RenderObject";
            this.miShowRoProperties.Click += new System.EventHandler(this.miShowRoProperties_Click);
            // 
            // colorizeRo
            // 
            this.miColorizeRo.Name = "miColorizeRo";
            this.miColorizeRo.Size = new System.Drawing.Size(202, 22);
            this.miColorizeRo.Text = "Colorize RenderObject";
            this.miColorizeRo.ToolTipText = "Change the background color of the RenderObject";
            this.miColorizeRo.Click += new System.EventHandler(this.miColorizeRo_Click);
            // 
            // setRoText
            // 
            this.miSetRoText.AcceptsReturn = true;
            this.miSetRoText.Name = "miSetRoText";
            this.miSetRoText.Size = new System.Drawing.Size(120, 23);
            this.miSetRoText.Text = "set text";
            this.miSetRoText.ToolTipText = "Change the text of the RenderText object";
            this.miSetRoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.miSetRoText_KeyDown);
            this.miSetRoText.Validated += new System.EventHandler(this.miSetRoText_Validated);
            this.miSetRoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miSetRoText_KeyPress);
            // 
            // miStickyNoteRo
            // 
            this.miStickyNoteRo.Name = "miStickyNoteRo";
            this.miStickyNoteRo.Size = new System.Drawing.Size(202, 22);
            this.miStickyNoteRo.Text = "Add Sticky Note";
            this.miStickyNoteRo.Click += new System.EventHandler(this.miStickyNoteRo_Click);
            // 
            // miHideShowStickyNotes
            // 
            this.miHideShowStickyNotes.Checked = true;
            this.miHideShowStickyNotes.CheckOnClick = true;
            this.miHideShowStickyNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miHideShowStickyNotes.Name = "miHideShowStickyNotes";
            this.miHideShowStickyNotes.Size = new System.Drawing.Size(202, 22);
            this.miHideShowStickyNotes.Text = "Show Sticky Notes";
            this.miHideShowStickyNotes.Click += new System.EventHandler(this.miHideShowStickyNotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 738);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miShowRoProperties;
        private System.Windows.Forms.ToolStripMenuItem miColorizeRo;
        private System.Windows.Forms.ToolStripTextBox miSetRoText;
        private System.Windows.Forms.ToolStripMenuItem miStickyNoteRo;
        private System.Windows.Forms.ToolStripMenuItem miHideShowStickyNotes;
    }
}

