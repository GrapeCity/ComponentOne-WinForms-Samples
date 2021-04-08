namespace CommandExplorer.Samples
{
    partial class DockingOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockingOverview));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTab = new System.Windows.Forms.ToolStripButton();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "Bitmap.png");
            this.imageList1.Images.SetKeyName(1, "ClipArt.png");
            this.imageList1.Images.SetKeyName(2, "Picture.png");
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.CanAutoHide = true;
            this.c1DockingTab1.CanCloseTabs = true;
            this.c1DockingTab1.CanMoveTabs = true;
            this.c1DockingTab1.CloseBox = C1.Win.Command.CloseBoxPositionEnum.AllPages;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.ImageList = this.imageList1;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 25);
            this.c1DockingTab1.Margin = new System.Windows.Forms.Padding(4);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.ShowCaption = true;
            this.c1DockingTab1.ShowTabList = true;
            this.c1DockingTab1.Size = new System.Drawing.Size(425, 575);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabLook = C1.Win.Command.ButtonLookFlags.Text;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionVisible = true;
            this.c1DockingTabPage1.ImageIndex = 0;
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(423, 545);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Page1";
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.CaptionVisible = true;
            this.c1DockingTabPage2.ImageIndex = 1;
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(423, 545);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Page2";
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.CaptionVisible = true;
            this.c1DockingTabPage3.ImageIndex = 2;
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(423, 545);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Page3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTab});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTab
            // 
            this.btnAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddTab.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTab.Image")));
            this.btnAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(61, 22);
            this.btnAddTab.Text = "Add Tab";
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(425, 25);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1DockingTab1;
            this.propertyGrid1.Size = new System.Drawing.Size(323, 575);
            this.propertyGrid1.TabIndex = 2;
            // 
            // DockingOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1DockingTab1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DockingOverview";
            this.Size = new System.Drawing.Size(748, 600);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTab;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}