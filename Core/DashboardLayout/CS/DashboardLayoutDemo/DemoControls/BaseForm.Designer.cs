namespace DashboardDemo.Controls
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonMenu1 = new C1.Win.Ribbon.RibbonMenu();
            this.menuSave = new C1.Win.Ribbon.RibbonButton();
            this.menuApply = new C1.Win.Ribbon.RibbonSplitButton();
            this.menuManage = new C1.Win.Ribbon.RibbonButton();
            this.menuReset = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.btnFlow = new C1.Win.Ribbon.RibbonToggleButton();
            this.btnGrid = new C1.Win.Ribbon.RibbonToggleButton();
            this.btnSplit = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.cmbToolicon = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.cmbThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1517, 232);
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
            this.ribbonTab1.Groups.Add(this.ribbonGroup4);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Settings";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonMenu1);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Layout";
            // 
            // ribbonMenu1
            // 
            this.ribbonMenu1.Items.Add(this.menuSave);
            this.ribbonMenu1.Items.Add(this.menuApply);
            this.ribbonMenu1.Items.Add(this.menuManage);
            this.ribbonMenu1.Items.Add(this.menuReset);
            this.ribbonMenu1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonMenu1.LargeImage")));
            this.ribbonMenu1.Name = "ribbonMenu1";
            this.ribbonMenu1.TextImageRelation = C1.Win.Ribbon.TextImageRelation.ImageAboveText;
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuSave.SmallImage")));
            this.menuSave.Text = "Save Layout";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuApply
            // 
            this.menuApply.Name = "menuApply";
            this.menuApply.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuApply.SmallImage")));
            this.menuApply.Text = "Apply Layout";
            // 
            // menuManage
            // 
            this.menuManage.Name = "menuManage";
            this.menuManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuManage.SmallImage")));
            this.menuManage.Text = "Manage Layout";
            this.menuManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuReset
            // 
            this.menuReset.Name = "menuReset";
            this.menuReset.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuReset.SmallImage")));
            this.menuReset.Text = "Reset Layout";
            this.menuReset.Click += new System.EventHandler(this.menuReset_Click);
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnFlow);
            this.ribbonGroup4.Items.Add(this.btnGrid);
            this.ribbonGroup4.Items.Add(this.btnSplit);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "LayoutType";
            // 
            // btnFlow
            // 
            this.btnFlow.CanDepress = false;
            this.btnFlow.Name = "btnFlow";
            this.btnFlow.Text = "Flow";
            this.btnFlow.ToggleGroupName = "LayoutType";
            this.btnFlow.PressedChanged += new System.EventHandler(this.btnFlow_PressedChanged);
            // 
            // btnGrid
            // 
            this.btnGrid.CanDepress = false;
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Text = "Grid";
            this.btnGrid.ToggleGroupName = "LayoutType";
            this.btnGrid.PressedChanged += new System.EventHandler(this.btnGrid_PressedChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.CanDepress = false;
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Text = "Split";
            this.btnSplit.ToggleGroupName = "LayoutType";
            this.btnSplit.PressedChanged += new System.EventHandler(this.btnSplit_PressedChanged);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.cmbToolicon);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Options";
            // 
            // cmbToolicon
            // 
            this.cmbToolicon.Label = "Toolicon";
            this.cmbToolicon.Name = "cmbToolicon";
            this.cmbToolicon.SelectedIndexChanged += new System.EventHandler(this.cmbToolicon_SelectedIndexChanged);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.cmbThemes);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Theme";
            // 
            // cmbThemes
            // 
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1517, 1008);
            this.Controls.Add(this.c1Ribbon1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonMenu ribbonMenu1;
        private C1.Win.Ribbon.RibbonButton menuSave;
        private C1.Win.Ribbon.RibbonSplitButton menuApply;
        private C1.Win.Ribbon.RibbonButton menuManage;
        private C1.Win.Ribbon.RibbonButton menuReset;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonToggleButton btnFlow;
        private C1.Win.Ribbon.RibbonToggleButton btnGrid;
        private C1.Win.Ribbon.RibbonToggleButton btnSplit;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonComboBox cmbToolicon;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonComboBox cmbThemes;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
    }
}