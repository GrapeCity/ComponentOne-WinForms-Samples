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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new System.Windows.Forms.ListBox();
            c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            miShowRoProperties = new System.Windows.Forms.ToolStripMenuItem();
            miColorizeRo = new System.Windows.Forms.ToolStripMenuItem();
            miSetRoText = new System.Windows.Forms.ToolStripTextBox();
            miStickyNoteRo = new System.Windows.Forms.ToolStripMenuItem();
            miHideShowStickyNotes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(2, 711);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(993, 124);
            listBox1.TabIndex = 2;
            // 
            // c1PrintPreviewControl1
            // 
            c1PrintPreviewControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            c1PrintPreviewControl1.Location = new System.Drawing.Point(2, 2);
            c1PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // 
            // 
            c1PrintPreviewControl1.PreviewPane.ContextMenuStrip = contextMenuStrip1;
            c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            c1PrintPreviewControl1.PreviewPane.Location = new System.Drawing.Point(0, 0);
            c1PrintPreviewControl1.PreviewPane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.PreviewPane.Name = "previewPane";
            c1PrintPreviewControl1.PreviewPane.Size = new System.Drawing.Size(233, 300);
            c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            c1PrintPreviewControl1.PreviewPane.Paint += c1PrintPreviewControl1_PreviewPane_Paint;
            c1PrintPreviewControl1.PreviewPane.MouseMove += c1PrintPreviewControl1_PreviewPane_MouseMove;
            c1PrintPreviewControl1.Size = new System.Drawing.Size(1008, 711);
            c1PrintPreviewControl1.TabIndex = 0;
            c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.File.Print.Enabled = false;
            c1PrintPreviewControl1.ToolBars.File.Print.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Print.Image");
            c1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint";
            c1PrintPreviewControl1.ToolBars.File.Print.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print";
            c1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst";
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst";
            c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast";
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast";
            c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext";
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext";
            c1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev";
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev";
            c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext";
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = new System.Drawing.Size(32, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext";
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Enabled = false;
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image");
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 22);
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            c1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Text.Find.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Find.Image");
            c1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind";
            c1PrintPreviewControl1.ToolBars.Text.Find.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find";
            c1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Text.Hand.Checked = true;
            c1PrintPreviewControl1.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked;
            c1PrintPreviewControl1.ToolBars.Text.Hand.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Hand.Image");
            c1PrintPreviewControl1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool";
            c1PrintPreviewControl1.ToolBars.Text.Hand.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool";
            c1PrintPreviewControl1.ToolBars.Text.Hand.ToolTipText = "Hand Tool";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miShowRoProperties, miColorizeRo, miSetRoText, miStickyNoteRo, miHideShowStickyNotes });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(203, 117);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // miShowRoProperties
            // 
            miShowRoProperties.Name = "miShowRoProperties";
            miShowRoProperties.Size = new System.Drawing.Size(202, 22);
            miShowRoProperties.Text = "RenderObject Properties";
            miShowRoProperties.ToolTipText = "View/update the properties of the RenderObject";
            miShowRoProperties.Click += miShowRoProperties_Click;
            // 
            // miColorizeRo
            // 
            miColorizeRo.Name = "miColorizeRo";
            miColorizeRo.Size = new System.Drawing.Size(202, 22);
            miColorizeRo.Text = "Colorize RenderObject";
            miColorizeRo.ToolTipText = "Change the background color of the RenderObject";
            miColorizeRo.Click += miColorizeRo_Click;
            // 
            // miSetRoText
            // 
            miSetRoText.AcceptsReturn = true;
            miSetRoText.Name = "miSetRoText";
            miSetRoText.Size = new System.Drawing.Size(120, 23);
            miSetRoText.Text = "set text";
            miSetRoText.ToolTipText = "Change the text of the RenderText object";
            miSetRoText.KeyDown += miSetRoText_KeyDown;
            miSetRoText.KeyPress += miSetRoText_KeyPress;
            miSetRoText.Validated += miSetRoText_Validated;
            // 
            // miStickyNoteRo
            // 
            miStickyNoteRo.Name = "miStickyNoteRo";
            miStickyNoteRo.Size = new System.Drawing.Size(202, 22);
            miStickyNoteRo.Text = "Add Sticky Note";
            miStickyNoteRo.Click += miStickyNoteRo_Click;
            // 
            // miHideShowStickyNotes
            // 
            miHideShowStickyNotes.Checked = true;
            miHideShowStickyNotes.CheckOnClick = true;
            miHideShowStickyNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            miHideShowStickyNotes.Name = "miHideShowStickyNotes";
            miHideShowStickyNotes.Size = new System.Drawing.Size(202, 22);
            miHideShowStickyNotes.Text = "Show Sticky Notes";
            miHideShowStickyNotes.Click += miHideShowStickyNotes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1010, 852);
            Controls.Add(listBox1);
            Controls.Add(c1PrintPreviewControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "StickyNotes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);

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

