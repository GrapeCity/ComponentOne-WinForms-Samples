namespace ControlExplorer.Reports
{
    partial class Acroform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acroform));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.doc = new C1.C1Preview.C1PrintDocument();
            this.btnCheckAnswers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboDocs = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1PrintPreviewControl1);
            this.splitContainer1.Size = new System.Drawing.Size(759, 421);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 4;
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.AvailablePreviewActions = ((C1.Win.C1Preview.C1PreviewActionFlags)((((((((((((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.FileOpen | C1.Win.C1Preview.C1PreviewActionFlags.FileSave)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageSetup)
                        | C1.Win.C1Preview.C1PreviewActionFlags.Print)
                        | C1.Win.C1Preview.C1PreviewActionFlags.Reflow)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageSingle)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageContinuous)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageFacing)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageFacingContinuous)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoFirst)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoPrev)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoNext)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoLast)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoPage)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.HandTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.SelectTextTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.Find)));
            this.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.ImageSet = C1.Win.C1Preview.ImageSetEnum.Adobe;
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
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
            this.c1PrintPreviewControl1.PreviewPane.Document = this.doc;
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.PageWidth;
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
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 348);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(759, 421);
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
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.PageSetup.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup";
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup";
            this.c1PrintPreviewControl1.ToolBars.File.PageSetup.ToolTipText = "Page Setup";
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
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Reflow.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow";
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow";
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.File.Save.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Save.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave";
            this.c1PrintPreviewControl1.ToolBars.File.Save.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave";
            this.c1PrintPreviewControl1.ToolBars.File.Save.ToolTipText = "Save File";
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
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Visible = false;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image")));
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Visible = false;
            this.c1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.Checked = true;
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Continuous.Image")));
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.Name = "btnPageContinuous";
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous";
            this.c1PrintPreviewControl1.ToolBars.Page.Continuous.ToolTipText = "Continuous View";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Facing.Image")));
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing";
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing";
            this.c1PrintPreviewControl1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image")));
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous";
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous";
            this.c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Page.Single.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Single.Image")));
            this.c1PrintPreviewControl1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Page.Single.Name = "btnPageSingle";
            this.c1PrintPreviewControl1.ToolBars.Page.Single.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle";
            this.c1PrintPreviewControl1.ToolBars.Page.Single.ToolTipText = "Single Page View";
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
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewControl1.ToolBars.Text.Hand,
            this.c1PrintPreviewControl1.ToolBars.Text.SelectText,
            this.c1PrintPreviewControl1.ToolBars.Text.Find,
            this.btnCheckAnswers});
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.Location = new System.Drawing.Point(582, 0);
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.Name = "textStrip";
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.Size = new System.Drawing.Size(104, 25);
            this.c1PrintPreviewControl1.ToolBars.Text.ToolStrip.TabIndex = 4;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = null;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image")));
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image")));
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool,
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool});
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image")));
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool";
            this.c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool";
            // 
            // doc
            // 
            this.doc.DocumentInfo.Creator = "C1Reports Engine version 2.6.20101.54005";
            this.doc.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(false, System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in");
            // 
            // btnCheckAnswers
            // 
            this.btnCheckAnswers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheckAnswers.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAnswers.Image")));
            this.btnCheckAnswers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAnswers.Name = "btnCheckAnswers";
            this.btnCheckAnswers.Size = new System.Drawing.Size(23, 22);
            this.btnCheckAnswers.Text = "Check Answers";
            this.btnCheckAnswers.Click += new System.EventHandler(this.btnCheckAnswers_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comboDocs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Select Document:";
            // 
            // comboDocs
            // 
            this.comboDocs.Items.AddRange(new object[] {
            "Acroform",
            "Brain Quiz"});
            this.comboDocs.Name = "comboDocs";
            this.comboDocs.Size = new System.Drawing.Size(121, 25);
            this.comboDocs.SelectedIndexChanged += new System.EventHandler(this.comboDocs_SelectedIndexChanged);
            // 
            // Acroform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 446);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Acroform";
            this.Text = "Acroform";
            this.Load += new System.EventHandler(this.Acroform_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private System.Windows.Forms.ToolStripButton btnCheckAnswers;
        private C1.C1Preview.C1PrintDocument doc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboDocs;
    }
}