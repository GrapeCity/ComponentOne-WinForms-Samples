namespace ColumnBandsMultiRow
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
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.rgThemes = new C1.Win.Ribbon.RibbonGroup();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.rgBands = new C1.Win.Ribbon.RibbonGroup();
            this.rbCreateBands = new C1.Win.Ribbon.RibbonButton();
            this.rbClearBands = new C1.Win.Ribbon.RibbonButton();
            this.rgAdditional = new C1.Win.Ribbon.RibbonGroup();
            this.rbBandsColumnsRelation = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.columnBandsUserControl1 = new ColumnBandsMultiRow.ColumnBandsUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1016, 77);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
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
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.rgThemes);
            this.ribbonTab1.Groups.Add(this.rgBands);
            this.ribbonTab1.Groups.Add(this.rgAdditional);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // rgThemes
            // 
            this.rgThemes.Items.Add(this.cmbTheme);
            this.rgThemes.Name = "rgThemes";
            this.rgThemes.Text = "Styles";
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // rgBands
            // 
            this.rgBands.Items.Add(this.rbCreateBands);
            this.rgBands.Items.Add(this.rbClearBands);
            this.rgBands.Name = "rgBands";
            this.rgBands.Text = "Group";
            // 
            // rbCreateBands
            // 
            this.rbCreateBands.IconSet.Add(new C1.Framework.C1BitmapIcon("OutlineGroup", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294));
            this.rbCreateBands.Name = "rbCreateBands";
            this.rbCreateBands.Text = "Create bands";
            this.rbCreateBands.Click += new System.EventHandler(this.rbCreateBands_Click);
            // 
            // rbClearBands
            // 
            this.rbClearBands.IconSet.Add(new C1.Framework.C1BitmapIcon("DeleteColumn", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 117));
            this.rbClearBands.Name = "rbClearBands";
            this.rbClearBands.Text = "Clear bands";
            this.rbClearBands.Click += new System.EventHandler(this.rbClearBands_Click);
            // 
            // rgAdditional
            // 
            this.rgAdditional.IconSet.Add(new C1.Framework.C1BitmapIcon("DecreaseVerticalSpacing", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 114));
            this.rgAdditional.Items.Add(this.rbBandsColumnsRelation);
            this.rgAdditional.Name = "rgAdditional";
            this.rgAdditional.Text = "Group";
            // 
            // rbBandsColumnsRelation
            // 
            this.rbBandsColumnsRelation.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rbBandsColumnsRelation.Label = "Bands Columns Relation";
            this.rbBandsColumnsRelation.Name = "rbBandsColumnsRelation";
            this.rbBandsColumnsRelation.SelectedIndexChanged += new System.EventHandler(this.rbBandsColumnsRelation_SelectedIndexChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016Green";
            // 
            // columnBandsUserControl1
            // 
            this.columnBandsUserControl1.BackColor = System.Drawing.Color.White;
            this.columnBandsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnBandsUserControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.columnBandsUserControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.columnBandsUserControl1.Location = new System.Drawing.Point(0, 77);
            this.columnBandsUserControl1.Name = "columnBandsUserControl1";
            this.columnBandsUserControl1.Size = new System.Drawing.Size(1016, 683);
            this.columnBandsUserControl1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.columnBandsUserControl1, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.columnBandsUserControl1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColumnBands (MultiRow) Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
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
        private C1.Win.Ribbon.RibbonGroup rgThemes;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private ColumnBandsUserControl columnBandsUserControl1;
        private C1.Win.Ribbon.RibbonGroup rgBands;
        private C1.Win.Ribbon.RibbonButton rbCreateBands;
        private C1.Win.Ribbon.RibbonButton rbClearBands;
        private C1.Win.Ribbon.RibbonGroup rgAdditional;
        private C1.Win.Ribbon.RibbonComboBox rbBandsColumnsRelation;
    }
}

