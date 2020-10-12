namespace ControlExplorer.Editor
{
    partial class RTFEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTFEditor));
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.oad = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton6 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton3 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton4 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton5 = new C1.Win.C1Ribbon.RibbonButton();
            this.c1EditorToolStripMain1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Editor1
            // 
            this.c1Editor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Editor1.BackColor = System.Drawing.Color.White;
            this.c1Editor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Editor1.Location = new System.Drawing.Point(0, 150);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.Size = new System.Drawing.Size(624, 292);
            this.c1Editor1.TabIndex = 0;
            this.c1Editor1.Xml = resources.GetString("c1Editor1.Xml");
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(624, 156);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Enabled = false;
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.HotItemLinks.Add(this.oad);
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // oad
            // 
            this.oad.Items.Add(this.ribbonButton1);
            this.oad.Items.Add(this.ribbonButton6);
            this.oad.Items.Add(this.ribbonButton2);
            this.oad.Name = "oad";
            this.oad.Text = "RTF";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Load";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Load RTF - 2";
            this.ribbonButton6.Click += new System.EventHandler(this.ribbonButton6_Click_1);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Save";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.oad);
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "File";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonButton3);
            this.ribbonGroup1.Items.Add(this.ribbonButton4);
            this.ribbonGroup1.Items.Add(this.ribbonButton5);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Views";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Design";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "HTML";
            this.ribbonButton4.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Preview";
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // c1EditorToolStripMain1
            // 
            this.c1EditorToolStripMain1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1EditorToolStripMain1.Dock = System.Windows.Forms.DockStyle.None;
            this.c1EditorToolStripMain1.Editor = this.c1Editor1;
            this.c1EditorToolStripMain1.Location = new System.Drawing.Point(0, 150);
            this.c1EditorToolStripMain1.Name = "c1EditorToolStripMain1";
            this.c1EditorToolStripMain1.Size = new System.Drawing.Size(381, 25);
            this.c1EditorToolStripMain1.TabIndex = 2;
            this.c1EditorToolStripMain1.Text = "c1EditorToolStripMain1";
            this.c1EditorToolStripMain1.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF Files (*.rtf) |*.rtf";
            this.saveFileDialog1.DefaultExt = "RTF Files | *.rtf";
            this.saveFileDialog1.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 10.0\\Common7\\IDE";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // RTFEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.c1Ribbon1);
            this.Controls.Add(this.c1Editor1);
            this.Controls.Add(this.c1EditorToolStripMain1);
            this.Name = "RTFEditor";
            this.Text = "RTF Load/Save - C1Editor";
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Editor.C1Editor c1Editor1;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup oad;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton3;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton4;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton5;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain c1EditorToolStripMain1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

