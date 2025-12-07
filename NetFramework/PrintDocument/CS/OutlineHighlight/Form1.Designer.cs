namespace OutlineHighlight
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
            this.showRoProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.colorizeRo = new System.Windows.Forms.ToolStripMenuItem();
            this.setRoText = new System.Windows.Forms.ToolStripTextBox();
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
            // c1PrintPreviewControl1.PreviewPane
            // 
            this.c1PrintPreviewControl1.PreviewPane.ContextMenuStrip = this.contextMenuStrip1;
            this.c1PrintPreviewControl1.PreviewPane.ExportOptions.Content = new C1.Win.C1Preview.ExporterOptions[0];
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewPane.Paint += new System.Windows.Forms.PaintEventHandler(this.c1PrintPreviewControl1_PreviewPane_Paint);
            this.c1PrintPreviewControl1.PreviewPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1PrintPreviewControl1_PreviewPane_MouseMove);
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(864, 616);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.File.Open.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Open.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen";
            this.c1PrintPreviewControl1.ToolBars.File.Open.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen";
            this.c1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File";
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
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.SelectText.Image")));
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool";
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool";
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image")));
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Size = new System.Drawing.Size(144, 22);
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Text = "Zoom In Tool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.ToolTipText = "Zoom In Tool";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image")));
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Size = new System.Drawing.Size(144, 22);
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Text = "Zoom Out Tool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.ToolTipText = "Zoom Out Tool";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRoProperties,
            this.colorizeRo,
            this.setRoText});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 71);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showRoProperties
            // 
            this.showRoProperties.Name = "showRoProperties";
            this.showRoProperties.Size = new System.Drawing.Size(193, 22);
            this.showRoProperties.Text = "RenderObject Properties";
            this.showRoProperties.ToolTipText = "View/update the properties of the RenderObject";
            this.showRoProperties.Click += new System.EventHandler(this.showRoProperties_Click);
            // 
            // colorizeRo
            // 
            this.colorizeRo.Name = "colorizeRo";
            this.colorizeRo.Size = new System.Drawing.Size(193, 22);
            this.colorizeRo.Text = "Colorize RenderObject";
            this.colorizeRo.ToolTipText = "Change the background color of the RenderObject";
            this.colorizeRo.Click += new System.EventHandler(this.colorizeRo_Click);
            // 
            // setRoText
            // 
            this.setRoText.AcceptsReturn = true;
            this.setRoText.Name = "setRoText";
            this.setRoText.Size = new System.Drawing.Size(120, 21);
            this.setRoText.ToolTipText = "Change the text of the RenderText object";
            this.setRoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.setRoText_KeyDown);
            this.setRoText.Validated += new System.EventHandler(this.setRoText_Validated);
            this.setRoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setRoText_KeyPress);
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
        private System.Windows.Forms.ToolStripMenuItem showRoProperties;
        private System.Windows.Forms.ToolStripMenuItem colorizeRo;
        private System.Windows.Forms.ToolStripTextBox setRoText;
    }
}

