namespace TreeGeneration
{
    partial class MainForm
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn3 = new C1.Win.TreeView.C1TreeColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(800, 34);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
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
            this.ribbonQat1.Visible = false;
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Items.Add(this.cmbTheme);
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.DisplayFieldName = "ID";
            c1TreeColumn1.HeaderText = "ID";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn2.DisplayFieldName = "Name\\CustomerID\\OrderID";
            c1TreeColumn2.HeaderText = "Customer info";
            c1TreeColumn2.Name = "New Column";
            c1TreeColumn3.DisplayFieldName = "Address\\Date\\Qty";
            c1TreeColumn3.HeaderText = "Order Info";
            c1TreeColumn3.Name = "New Column";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.Columns.Add(c1TreeColumn3);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 34);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(800, 416);
            this.c1TreeView1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1TreeView1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TreeGeneration";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
    }
}

