namespace SubReportDataSource
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
            this._ppv = new C1.Win.FlexViewer.C1FlexViewerPane();
            this._btnFirstPage = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._btnPrevPage = new System.Windows.Forms.Button();
            this._btnNextPage = new System.Windows.Forms.Button();
            this._btnLastPage = new System.Windows.Forms.Button();
            this._btnZoomOut = new System.Windows.Forms.Button();
            this._btnZoomIn = new System.Windows.Forms.Button();
            this._btnRepDefault = new System.Windows.Forms.Button();
            this._btnRepCustom = new System.Windows.Forms.Button();
            this._btnRepCustomFilter = new System.Windows.Forms.Button();
            this._c1flxr = new C1.Win.FlexReport.C1FlexReport();
            this.button1 = new System.Windows.Forms.Button();
            this._btnZoomFit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            this.SuspendLayout();
            // 
            // _ppv
            // 
            this._ppv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ppv.Location = new System.Drawing.Point(-2, 54);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(685, 558);
            this._ppv.TabIndex = 10;
            // 
            // _btnFirstPage
            // 
            this._btnFirstPage.FlatAppearance.BorderSize = 0;
            this._btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFirstPage.ImageKey = "NavFirstPage";
            this._btnFirstPage.ImageList = this.imageList1;
            this._btnFirstPage.Location = new System.Drawing.Point(12, 12);
            this._btnFirstPage.Name = "_btnFirstPage";
            this._btnFirstPage.Size = new System.Drawing.Size(30, 30);
            this._btnFirstPage.TabIndex = 0;
            this._btnFirstPage.TabStop = false;
            this._btnFirstPage.UseVisualStyleBackColor = true;
            this._btnFirstPage.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NavFirstPage");
            this.imageList1.Images.SetKeyName(1, "NavPrevPage");
            this.imageList1.Images.SetKeyName(2, "NavNextPage");
            this.imageList1.Images.SetKeyName(3, "NavLastPage");
            this.imageList1.Images.SetKeyName(4, "ZoomIn");
            this.imageList1.Images.SetKeyName(5, "ZoomOut");
            this.imageList1.Images.SetKeyName(6, "ZoomFitToWindow");
            // 
            // _btnPrevPage
            // 
            this._btnPrevPage.FlatAppearance.BorderSize = 0;
            this._btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPrevPage.ImageKey = "NavPrevPage";
            this._btnPrevPage.ImageList = this.imageList1;
            this._btnPrevPage.Location = new System.Drawing.Point(48, 12);
            this._btnPrevPage.Name = "_btnPrevPage";
            this._btnPrevPage.Size = new System.Drawing.Size(30, 30);
            this._btnPrevPage.TabIndex = 1;
            this._btnPrevPage.TabStop = false;
            this._btnPrevPage.UseVisualStyleBackColor = true;
            this._btnPrevPage.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnNextPage
            // 
            this._btnNextPage.FlatAppearance.BorderSize = 0;
            this._btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNextPage.ImageKey = "NavNextPage";
            this._btnNextPage.ImageList = this.imageList1;
            this._btnNextPage.Location = new System.Drawing.Point(84, 12);
            this._btnNextPage.Name = "_btnNextPage";
            this._btnNextPage.Size = new System.Drawing.Size(30, 30);
            this._btnNextPage.TabIndex = 2;
            this._btnNextPage.TabStop = false;
            this._btnNextPage.UseVisualStyleBackColor = true;
            this._btnNextPage.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnLastPage
            // 
            this._btnLastPage.FlatAppearance.BorderSize = 0;
            this._btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnLastPage.ImageKey = "NavLastPage";
            this._btnLastPage.ImageList = this.imageList1;
            this._btnLastPage.Location = new System.Drawing.Point(120, 12);
            this._btnLastPage.Name = "_btnLastPage";
            this._btnLastPage.Size = new System.Drawing.Size(30, 30);
            this._btnLastPage.TabIndex = 3;
            this._btnLastPage.TabStop = false;
            this._btnLastPage.UseVisualStyleBackColor = true;
            this._btnLastPage.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnZoomOut
            // 
            this._btnZoomOut.FlatAppearance.BorderSize = 0;
            this._btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnZoomOut.ImageKey = "ZoomOut";
            this._btnZoomOut.ImageList = this.imageList1;
            this._btnZoomOut.Location = new System.Drawing.Point(173, 12);
            this._btnZoomOut.Name = "_btnZoomOut";
            this._btnZoomOut.Size = new System.Drawing.Size(30, 30);
            this._btnZoomOut.TabIndex = 4;
            this._btnZoomOut.TabStop = false;
            this._btnZoomOut.UseVisualStyleBackColor = true;
            this._btnZoomOut.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnZoomIn
            // 
            this._btnZoomIn.FlatAppearance.BorderSize = 0;
            this._btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnZoomIn.ImageKey = "ZoomIn";
            this._btnZoomIn.ImageList = this.imageList1;
            this._btnZoomIn.Location = new System.Drawing.Point(209, 12);
            this._btnZoomIn.Name = "_btnZoomIn";
            this._btnZoomIn.Size = new System.Drawing.Size(30, 30);
            this._btnZoomIn.TabIndex = 5;
            this._btnZoomIn.TabStop = false;
            this._btnZoomIn.UseVisualStyleBackColor = true;
            this._btnZoomIn.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnRepDefault
            // 
            this._btnRepDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRepDefault.FlatAppearance.BorderSize = 0;
            this._btnRepDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRepDefault.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRepDefault.Location = new System.Drawing.Point(296, 12);
            this._btnRepDefault.Name = "_btnRepDefault";
            this._btnRepDefault.Size = new System.Drawing.Size(120, 30);
            this._btnRepDefault.TabIndex = 7;
            this._btnRepDefault.TabStop = false;
            this._btnRepDefault.Text = "Default Data/Filter";
            this._btnRepDefault.Click += new System.EventHandler(this._btnRepDefault_Click);
            // 
            // _btnRepCustom
            // 
            this._btnRepCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRepCustom.FlatAppearance.BorderSize = 0;
            this._btnRepCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRepCustom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRepCustom.Location = new System.Drawing.Point(424, 12);
            this._btnRepCustom.Name = "_btnRepCustom";
            this._btnRepCustom.Size = new System.Drawing.Size(120, 30);
            this._btnRepCustom.TabIndex = 8;
            this._btnRepCustom.TabStop = false;
            this._btnRepCustom.Text = "Custom Data";
            this._btnRepCustom.Click += new System.EventHandler(this._btnRepCustom_Click);
            // 
            // _btnRepCustomFilter
            // 
            this._btnRepCustomFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRepCustomFilter.FlatAppearance.BorderSize = 0;
            this._btnRepCustomFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRepCustomFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRepCustomFilter.Location = new System.Drawing.Point(552, 12);
            this._btnRepCustomFilter.Name = "_btnRepCustomFilter";
            this._btnRepCustomFilter.Size = new System.Drawing.Size(120, 30);
            this._btnRepCustomFilter.TabIndex = 9;
            this._btnRepCustomFilter.TabStop = false;
            this._btnRepCustomFilter.Text = "Custom Data/Filter";
            this._btnRepCustomFilter.Click += new System.EventHandler(this._btnRepCustomFilter_Click);
            // 
            // _c1flxr
            // 
            this._c1flxr.ReportDefinition = resources.GetString("_c1flxr.ReportDefinition");
            this._c1flxr.ReportName = "Categories";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "ZoomIn";
            this.button1.Location = new System.Drawing.Point(245, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // _btnZoomFit
            // 
            this._btnZoomFit.FlatAppearance.BorderSize = 0;
            this._btnZoomFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnZoomFit.ImageKey = "ZoomFitToWindow";
            this._btnZoomFit.ImageList = this.imageList1;
            this._btnZoomFit.Location = new System.Drawing.Point(245, 12);
            this._btnZoomFit.Name = "_btnZoomFit";
            this._btnZoomFit.Size = new System.Drawing.Size(30, 30);
            this._btnZoomFit.TabIndex = 6;
            this._btnZoomFit.TabStop = false;
            this._btnZoomFit.UseVisualStyleBackColor = true;
            this._btnZoomFit.Click += new System.EventHandler(this._btnTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this._btnRepDefault);
            this.Controls.Add(this._btnRepCustom);
            this.Controls.Add(this._btnRepCustomFilter);
            this.Controls.Add(this._btnZoomFit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._btnZoomIn);
            this.Controls.Add(this._btnZoomOut);
            this.Controls.Add(this._btnLastPage);
            this.Controls.Add(this._btnPrevPage);
            this.Controls.Add(this._btnNextPage);
            this.Controls.Add(this._btnFirstPage);
            this.Controls.Add(this._ppv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "Form1";
            this.Text = "SubReportDataSource";
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewerPane _ppv;
        private System.Windows.Forms.Button _btnFirstPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button _btnPrevPage;
        private System.Windows.Forms.Button _btnNextPage;
        private System.Windows.Forms.Button _btnLastPage;
        private System.Windows.Forms.Button _btnZoomOut;
        private System.Windows.Forms.Button _btnZoomIn;
        private System.Windows.Forms.Button _btnRepDefault;
        private System.Windows.Forms.Button _btnRepCustom;
        private System.Windows.Forms.Button _btnRepCustomFilter;
        private C1.Win.FlexReport.C1FlexReport _c1flxr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _btnZoomFit;
    }
}