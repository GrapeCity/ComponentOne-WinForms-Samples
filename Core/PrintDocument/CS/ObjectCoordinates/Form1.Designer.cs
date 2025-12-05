namespace ObjectCoordinates
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
            showRoProperties = new System.Windows.Forms.ToolStripMenuItem();
            colorizeRo = new System.Windows.Forms.ToolStripMenuItem();
            setRoText = new System.Windows.Forms.ToolStripTextBox();
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
            c1PrintPreviewControl1.ToolBars.File.Open.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Open.Image");
            c1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen";
            c1PrintPreviewControl1.ToolBars.File.Open.Size = new System.Drawing.Size(32, 22);
            c1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen";
            c1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File";
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
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Text.SelectText.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.SelectText.Image");
            c1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool";
            c1PrintPreviewControl1.ToolBars.Text.SelectText.Size = new System.Drawing.Size(23, 22);
            c1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool";
            c1PrintPreviewControl1.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool";
            c1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = null;
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image");
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Size = new System.Drawing.Size(155, 22);
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Text = "Zoom In Tool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.ToolTipText = "Zoom In Tool";
            // 
            // 
            // 
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image = (System.Drawing.Image)resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image");
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Size = new System.Drawing.Size(155, 22);
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Text = "Zoom Out Tool";
            c1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.ToolTipText = "Zoom Out Tool";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showRoProperties, colorizeRo, setRoText });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(203, 73);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showRoProperties
            // 
            showRoProperties.Name = "showRoProperties";
            showRoProperties.Size = new System.Drawing.Size(202, 22);
            showRoProperties.Text = "RenderObject Properties";
            showRoProperties.ToolTipText = "View/update the properties of the RenderObject";
            showRoProperties.Click += showRoProperties_Click;
            // 
            // colorizeRo
            // 
            colorizeRo.Name = "colorizeRo";
            colorizeRo.Size = new System.Drawing.Size(202, 22);
            colorizeRo.Text = "Colorize RenderObject";
            colorizeRo.ToolTipText = "Change the background color of the RenderObject";
            colorizeRo.Click += colorizeRo_Click;
            // 
            // setRoText
            // 
            setRoText.AcceptsReturn = true;
            setRoText.Name = "setRoText";
            setRoText.Size = new System.Drawing.Size(120, 23);
            setRoText.ToolTipText = "Change the text of the RenderText object";
            setRoText.KeyDown += setRoText_KeyDown;
            setRoText.KeyPress += setRoText_KeyPress;
            setRoText.Validated += setRoText_Validated;
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
            Text = "ObjectCoordinates";
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
        private System.Windows.Forms.ToolStripMenuItem showRoProperties;
        private System.Windows.Forms.ToolStripMenuItem colorizeRo;
        private System.Windows.Forms.ToolStripTextBox setRoText;
    }
}

