namespace ControlExplorer.SSRS
{
    partial class RibbonSsrsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonSsrsViewer));
            this.c1RibbonPreview1 = new C1.Win.C1RibbonPreview.C1RibbonPreview();
            this.c1SsrsDocumentSource1 = new C1.Win.C1Document.C1SSRSDocumentSource();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.bwListReports = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1RibbonPreview1
            // 
            this.c1RibbonPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1RibbonPreview1.Document = this.c1SsrsDocumentSource1;
            this.c1RibbonPreview1.Location = new System.Drawing.Point(0, 0);
            this.c1RibbonPreview1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1RibbonPreview1.Name = "c1RibbonPreview1";
            this.c1RibbonPreview1.RibbonElements.FileOpen.Visible = false;
            this.c1RibbonPreview1.Size = new System.Drawing.Size(974, 499);
            this.c1RibbonPreview1.TabIndex = 0;
            this.c1RibbonPreview1.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            // 
            // c1SsrsDocumentSource1
            // 
            this.c1SsrsDocumentSource1.Language = new System.Globalization.CultureInfo("en-US");
            this.c1SsrsDocumentSource1.BusyStateChanged += new System.EventHandler(this.SsrsDocumentSource_StateChanged);
            this.c1SsrsDocumentSource1.SecurityError += new C1.Win.C1Document.SecurityErrorEventHandler(this.SsrsDocumentSource_SecurityError);
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "Folder.png");
            this.ilMain.Images.SetKeyName(1, "CreateReportBlankReport.png");
            this.ilMain.Images.SetKeyName(2, "RecurrenceEdit.png");
            // 
            // bwListReports
            // 
            this.bwListReports.WorkerSupportsCancellation = true;
            this.bwListReports.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwListReports_DoWork);
            this.bwListReports.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwListReports_RunWorkerCompleted);
            // 
            // RibbonSsrsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 499);
            this.Controls.Add(this.c1RibbonPreview1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "RibbonSsrsViewer";
            this.Text = "RibbonSsrsViewer";
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private C1.Win.C1RibbonPreview.C1RibbonPreview c1RibbonPreview1;
        private C1.Win.C1Document.C1SSRSDocumentSource c1SsrsDocumentSource1;
        private System.Windows.Forms.ImageList ilMain;
        private System.ComponentModel.BackgroundWorker bwListReports;
    }
}