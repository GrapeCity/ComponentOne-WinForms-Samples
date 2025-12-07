namespace FlexCommonTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this.c1FlexReport1 = new C1.Win.FlexReport.C1FlexReport();
            this.tbReports = new C1.Win.Command.C1TopicBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexViewer1.Location = new System.Drawing.Point(245, 0);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(974, 716);
            this.c1FlexViewer1.TabIndex = 0;
            // 
            // c1FlexReport1
            // 
            this.c1FlexReport1.ReportDefinition = resources.GetString("c1FlexReport1.ReportDefinition");
            this.c1FlexReport1.ReportName = "c1FlexReport1";
            // 
            // tbReports
            // 
            this.tbReports.AutoScrollMinSize = new System.Drawing.Size(0, 30);
            this.tbReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbReports.ImageList = null;
            this.tbReports.Location = new System.Drawing.Point(0, 0);
            this.tbReports.Name = "tbReports";
            this.tbReports.PagePadding = new System.Windows.Forms.Padding(10);
            this.tbReports.Size = new System.Drawing.Size(242, 716);
            this.tbReports.TabIndex = 1;
            this.tbReports.VisualStyle = C1.Win.Command.VisualStyle.Custom;
            this.tbReports.LinkClick += new C1.Win.Command.C1TopicBarClickEventHandler(this.tbReports_LinkClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(242, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 716);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 716);
            this.Controls.Add(this.c1FlexViewer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flex Common Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private C1.Win.Command.C1TopicBar tbReports;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.FlexReport.C1FlexReport c1FlexReport1;


    }
}

