namespace FlexPivotRanges
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
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.cbShowSlicers = new C1.Win.Ribbon.RibbonCheckBox();
            this.cbShowPanel = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonGroupViews = new C1.Win.Ribbon.RibbonGroup();
            this.rGallery = new C1.Win.Ribbon.RibbonGallery();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1BackstageView1 = new C1.Win.Ribbon.C1BackstageView();
            this.backstageViewTab1 = new C1.Win.Ribbon.BackstageViewTab();
            this.ribbonLabel1 = new C1.Win.Ribbon.RibbonLabel();
            this.btnClose = new C1.Win.Ribbon.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pivotView1 = new FlexPivotRanges.PivotView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1BackstageView1.SetBackstageView(this.c1Ribbon1, this.c1BackstageView1);
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1152, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroupViews);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "View";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.cbShowSlicers);
            this.ribbonGroup1.Items.Add(this.cbShowPanel);
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // cbShowSlicers
            // 
            this.cbShowSlicers.Checked = true;
            this.cbShowSlicers.Name = "cbShowSlicers";
            this.cbShowSlicers.Text = "Show Slicers";
            this.cbShowSlicers.CheckedChanged += new System.EventHandler(this.cbShowSlicers_Click);
            // 
            // cbShowPanel
            // 
            this.cbShowPanel.Name = "cbShowPanel";
            this.cbShowPanel.Text = "Show Panel";
            this.cbShowPanel.CheckedChanged += new System.EventHandler(this.cbShowPanel_CheckedChanged);
            // 
            // ribbonGroupViews
            // 
            this.ribbonGroupViews.Items.Add(this.rGallery);
            this.ribbonGroupViews.Name = "ribbonGroupViews";
            this.ribbonGroupViews.Text = "Ribbon Group";
            // 
            // rGallery
            // 
            this.rGallery.AllowZooming = true;
            this.rGallery.ItemSize = new System.Drawing.Size(150, 60);
            this.rGallery.ItemSpacing = new System.Drawing.Size(10, 0);
            this.rGallery.Name = "rGallery";
            this.rGallery.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.TextAlwaysVisible;
            this.rGallery.Text = "Gallery";
            this.rGallery.SelectedIndexChanged += new System.EventHandler(this.rGallery_SelectedIndexChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1BackstageView1
            // 
            this.c1BackstageView1.LeftBottomPaneItems.Add(this.backstageViewTab1);
            this.c1BackstageView1.LeftPaneItems.Add(this.ribbonLabel1);
            this.c1BackstageView1.LeftPaneItems.Add(this.btnClose);
            this.c1BackstageView1.Name = "c1BackstageView1";
            this.c1BackstageView1.Text = "File";
            // 
            // backstageViewTab1
            // 
            this.backstageViewTab1.Name = "backstageViewTab1";
            this.backstageViewTab1.Text = "Options";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Ranges App";
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel1.Location = new System.Drawing.Point(21, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 422);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(60, 51);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 293);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pivotView1
            // 
            this.pivotView1.ActiveViewIndex = 0;
            this.pivotView1.BigNumericStep = 200;
            this.pivotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotView1.FirstMonthOfFiscalYear = 4;
            this.pivotView1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pivotView1.Location = new System.Drawing.Point(0, 161);
            this.pivotView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pivotView1.Name = "pivotView1";
            this.pivotView1.ShowFlexPivotPanel = false;
            this.pivotView1.ShowSlicers = true;
            this.pivotView1.Size = new System.Drawing.Size(1152, 538);
            this.pivotView1.SmallNumericStep = 50;
            this.pivotView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 699);
            this.Controls.Add(this.pivotView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1Ribbon1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.C1BackstageView c1BackstageView1;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.Ribbon.RibbonButton btnClose;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.BackstageViewTab backstageViewTab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private PivotView pivotView1;
        private C1.Win.Ribbon.RibbonCheckBox cbShowSlicers;
        private C1.Win.Ribbon.RibbonCheckBox cbShowPanel;
        private C1.Win.Ribbon.RibbonGroup ribbonGroupViews;
        private C1.Win.Ribbon.RibbonGallery rGallery;
    }
}