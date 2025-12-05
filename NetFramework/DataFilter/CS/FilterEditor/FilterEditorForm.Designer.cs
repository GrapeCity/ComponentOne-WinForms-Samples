namespace FilterEditor
{
    partial class FilterEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterEditorForm));
            this.ribbon = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCmbThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonTopToolBar = new C1.Win.Ribbon.RibbonTopToolBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnReset = new C1.Win.C1Input.C1Button();
            this.btnApply = new C1.Win.C1Input.C1Button();
            this.filterEditor = new C1.Win.DataFilter.C1FilterEditor();
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            this.themeController = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationMenuHolder = this.ribbonApplicationMenu;
            this.ribbon.BottomToolBarHolder = this.ribbonBottomToolBar;
            this.ribbon.ConfigToolBarHolder = this.ribbonConfigToolBar;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.Name = "ribbon";
            this.ribbon.QatHolder = this.ribbonQat;
            this.ribbon.Size = new System.Drawing.Size(984, 71);
            this.ribbon.Tabs.Add(this.ribbonTab);
            this.themeController.SetTheme(this.ribbon, "(default)");
            this.ribbon.TopToolBarHolder = this.ribbonTopToolBar;
            this.ribbon.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu
            // 
            this.ribbonApplicationMenu.Name = "ribbonApplicationMenu";
            this.ribbonApplicationMenu.Visible = false;
            // 
            // ribbonBottomToolBar
            // 
            this.ribbonBottomToolBar.Name = "ribbonBottomToolBar";
            // 
            // ribbonConfigToolBar
            // 
            this.ribbonConfigToolBar.Name = "ribbonConfigToolBar";
            // 
            // ribbonQat
            // 
            this.ribbonQat.Name = "ribbonQat";
            this.ribbonQat.Visible = false;
            // 
            // ribbonTab
            // 
            this.ribbonTab.Groups.Add(this.ribbonGroup);
            this.ribbonTab.Name = "ribbonTab";
            this.ribbonTab.Text = "Styles";
            // 
            // ribbonGroup
            // 
            this.ribbonGroup.Items.Add(this.ribbonCmbThemes);
            this.ribbonGroup.Name = "ribbonGroup";
            this.ribbonGroup.Text = "Theme";
            // 
            // ribbonCmbThemes
            // 
            this.ribbonCmbThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.ribbonCmbThemes.Name = "ribbonCmbThemes";
            this.ribbonCmbThemes.TextAreaWidth = 100;
            this.ribbonCmbThemes.SelectedIndexChanged += new System.EventHandler(this.ribbonCmbThemes_SelectedIndexChanged);
            // 
            // ribbonTopToolBar
            // 
            this.ribbonTopToolBar.Name = "ribbonTopToolBar";
            this.ribbonTopToolBar.Visible = false;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer.Location = new System.Drawing.Point(0, 71);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnReset);
            this.splitContainer.Panel1.Controls.Add(this.btnApply);
            this.splitContainer.Panel1.Controls.Add(this.filterEditor);
            this.splitContainer.Panel1MinSize = 300;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flexGrid);
            this.splitContainer.Size = new System.Drawing.Size(984, 690);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            this.themeController.SetTheme(this.splitContainer, "(default)");
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(309, 644);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Filter";
            this.themeController.SetTheme(this.btnReset, "(default)");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(204, 644);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 30);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply Filter";
            this.themeController.SetTheme(this.btnApply, "(default)");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // filterEditor
            // 
            this.filterEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterEditor.Location = new System.Drawing.Point(0, 0);
            this.filterEditor.Name = "filterEditor";
            this.filterEditor.Size = new System.Drawing.Size(397, 636);
            this.filterEditor.Styles.Editor.Disabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.filterEditor.Styles.Editor.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.filterEditor.TabIndex = 0;
            this.filterEditor.Text = "c1FilterEditor1";
            this.themeController.SetTheme(this.filterEditor, "(default)");
            this.filterEditor.FilterChanged += new System.EventHandler(this.filterEditor_FilterChanged);
            // 
            // flexGrid
            // 
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 0);
            this.flexGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(579, 690);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 0;
            this.themeController.SetTheme(this.flexGrid, "(default)");
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // themeController
            // 
            this.themeController.Theme = "Office2016Colorful";
            // 
            // FilterEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FilterEditorForm";
            this.Text = "Filter Editor";
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.FilterEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon ribbon;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar;
        private C1.Win.Ribbon.RibbonQat ribbonQat;
        private C1.Win.Ribbon.RibbonTab ribbonTab;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar;
        private C1.Win.Ribbon.RibbonComboBox ribbonCmbThemes;
        private System.Windows.Forms.SplitContainer splitContainer;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private C1.Win.DataFilter.C1FilterEditor filterEditor;
        private C1.Win.C1Input.C1Button btnApply;
        private C1.Win.C1Input.C1Button btnReset;
        private C1.Win.Themes.C1ThemeController themeController;
    }
}

