namespace CustomStateImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeNode c1TreeNode6 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode7 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode8 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode9 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode10 = new C1.Win.TreeView.C1TreeNode();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCmbThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCBCheckBoxStates = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCBExpandStates = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.ribbonBtnEditExpand = new C1.Win.Ribbon.RibbonButton();
            this.ribbonBtnEditCheckBox = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCBEnabledTreeView = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(733, 143);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
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
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Styles";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonCmbThemes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Theme";
            // 
            // ribbonCmbThemes
            // 
            this.ribbonCmbThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.ribbonCmbThemes.Name = "ribbonCmbThemes";
            this.ribbonCmbThemes.SelectedIndexChanged += new System.EventHandler(this.ribbonCmbThemes_SelectedIndexChanged);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonCBCheckBoxStates);
            this.ribbonGroup2.Items.Add(this.ribbonCBExpandStates);
            this.ribbonGroup2.Items.Add(this.ribbonSeparator1);
            this.ribbonGroup2.Items.Add(this.ribbonBtnEditExpand);
            this.ribbonGroup2.Items.Add(this.ribbonBtnEditCheckBox);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Images";
            // 
            // ribbonCBCheckBoxStates
            // 
            this.ribbonCBCheckBoxStates.Name = "ribbonCBCheckBoxStates";
            this.ribbonCBCheckBoxStates.Text = "Use two checkbox states";
            this.ribbonCBCheckBoxStates.CheckedChanged += new System.EventHandler(this.ribbonCBCheckBoxStates_CheckedChanged);
            // 
            // ribbonCBExpandStates
            // 
            this.ribbonCBExpandStates.Name = "ribbonCBExpandStates";
            this.ribbonCBExpandStates.Text = "Use two expand button states";
            this.ribbonCBExpandStates.CheckedChanged += new System.EventHandler(this.ribbonCBExpandStates_CheckedChanged);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // ribbonBtnEditExpand
            // 
            this.ribbonBtnEditExpand.Name = "ribbonBtnEditExpand";
            this.ribbonBtnEditExpand.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonBtnEditExpand.SmallImage")));
            this.ribbonBtnEditExpand.Text = "Edit expand button images";
            this.ribbonBtnEditExpand.Click += new System.EventHandler(this.ribbonBtnEditExpand_Click);
            // 
            // ribbonBtnEditCheckBox
            // 
            this.ribbonBtnEditCheckBox.Name = "ribbonBtnEditCheckBox";
            this.ribbonBtnEditCheckBox.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonBtnEditCheckBox.SmallImage")));
            this.ribbonBtnEditCheckBox.Text = "Edit checkbox images";
            this.ribbonBtnEditCheckBox.Click += new System.EventHandler(this.ribbonBtnEditCheckBox_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.ribbonCBEnabledTreeView);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "TreeView";
            // 
            // ribbonCBEnabledTreeView
            // 
            this.ribbonCBEnabledTreeView.Name = "ribbonCBEnabledTreeView";
            this.ribbonCBEnabledTreeView.Text = "Enabled";
            this.ribbonCBEnabledTreeView.CheckedChanged += new System.EventHandler(this.ribbonCBEnabledTreeView_CheckedChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1TreeView1
            // 
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.c1TreeView1.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.c1TreeView1.CheckBoxes = true;
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.c1TreeView1.CheckImageList.TransparentColor = System.Drawing.Color.Transparent;
            c1TreeColumn2.DisplayFieldName = null;
            c1TreeColumn2.HeaderText = "Column1";
            c1TreeColumn2.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 143);
            this.c1TreeView1.Name = "c1TreeView1";
            c1TreeNode7.SetValue("New node");
            c1TreeNode6.Nodes.Add(c1TreeNode7);
            c1TreeNode6.SetValue("New node");
            c1TreeNode9.SetValue("New node");
            c1TreeNode8.Nodes.Add(c1TreeNode9);
            c1TreeNode8.SetValue("New node");
            c1TreeNode10.SetValue("New node");
            this.c1TreeView1.Nodes.Add(c1TreeNode6);
            this.c1TreeView1.Nodes.Add(c1TreeNode8);
            this.c1TreeView1.Nodes.Add(c1TreeNode10);
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(733, 461);
            this.c1TreeView1.Styles.ShowLines = false;
            this.c1TreeView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 604);
            this.Controls.Add(this.c1TreeView1);
            this.Controls.Add(this.c1Ribbon1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomStateImages";
            this.c1ThemeController1.SetTheme(this, "(default)");
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
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonComboBox ribbonCmbThemes;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCBCheckBoxStates;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCBExpandStates;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.Ribbon.RibbonButton ribbonBtnEditExpand;
        private C1.Win.Ribbon.RibbonButton ribbonBtnEditCheckBox;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCBEnabledTreeView;
    }
}

