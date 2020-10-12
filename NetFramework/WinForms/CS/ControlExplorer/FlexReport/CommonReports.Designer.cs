namespace ControlExplorer.FlexReport
{
    partial class CommonReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonReports));
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this.tbReports = new C1.Win.C1Command.C1TopicBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexViewer1.Location = new System.Drawing.Point(199, 0);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(457, 389);
            this.c1FlexViewer1.TabIndex = 0;
            this.c1FlexViewer1.UseIncrementalSearch = true;
            this.c1FlexViewer1.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.WholePage;
            // 
            // tbReports
            // 
            this.tbReports.AutoScrollMinSize = new System.Drawing.Size(0, 30);
            this.tbReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbReports.ImageList = this.imageList1;
            this.tbReports.Location = new System.Drawing.Point(0, 0);
            this.tbReports.Name = "tbReports";
            this.tbReports.Size = new System.Drawing.Size(196, 389);
            this.tbReports.TabIndex = 1;
            this.tbReports.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.tbReports.LinkClick += new C1.Win.C1Command.C1TopicBarClickEventHandler(this.tbReports_LinkClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(196, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 389);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // CommonReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 389);
            this.Controls.Add(this.c1FlexViewer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbReports);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CommonReports";
            this.Text = "CommonReports";
            this.Load += new System.EventHandler(this.CommonReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private C1.Win.C1Command.C1TopicBar tbReports;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
    }
}