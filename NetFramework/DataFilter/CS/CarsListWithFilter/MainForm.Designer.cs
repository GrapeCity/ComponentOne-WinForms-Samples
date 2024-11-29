namespace CarsListWithFilter
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
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCmbThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.cbAutoApply = new C1.Win.Ribbon.RibbonCheckBox();
            this.rbtnApplyFilter = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnSaveFilter = new C1.Win.Ribbon.RibbonButton();
            this.rbtnResetFilter = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1DataFilter1 = new C1.Win.DataFilter.C1DataFilter();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1617, 201);
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
            this.ribbonGroup2.Items.Add(this.cbAutoApply);
            this.ribbonGroup2.Items.Add(this.rbtnApplyFilter);
            this.ribbonGroup2.Items.Add(this.ribbonSeparator1);
            this.ribbonGroup2.Items.Add(this.rbtnSaveFilter);
            this.ribbonGroup2.Items.Add(this.rbtnResetFilter);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Filter";
            // 
            // cbAutoApply
            // 
            this.cbAutoApply.Checked = true;
            this.cbAutoApply.Name = "cbAutoApply";
            this.cbAutoApply.Text = "Auto apply filter";
            this.cbAutoApply.CheckedChanged += new System.EventHandler(this.cbAutoApply_CheckedChanged);
            // 
            // rbtnApplyFilter
            // 
            this.rbtnApplyFilter.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("rbtnApplyFilter.IconSet")))));
            this.rbtnApplyFilter.Name = "rbtnApplyFilter";
            this.rbtnApplyFilter.Text = "Apply filter";
            this.rbtnApplyFilter.Click += new System.EventHandler(this.rbtnApplyFilter_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // rbtnSaveFilter
            // 
            this.rbtnSaveFilter.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("rbtnSaveFilter.IconSet")))));
            this.rbtnSaveFilter.Name = "rbtnSaveFilter";
            this.rbtnSaveFilter.Text = "Save filter";
            this.rbtnSaveFilter.Click += new System.EventHandler(this.rbtnSaveFilter_Click);
            // 
            // rbtnResetFilter
            // 
            this.rbtnResetFilter.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("rbtnResetFilter.IconSet")))));
            this.rbtnResetFilter.Name = "rbtnResetFilter";
            this.rbtnResetFilter.Text = "Reset filter";
            this.rbtnResetFilter.Click += new System.EventHandler(this.rbtnResetFilter_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 201);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1DataFilter1);
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel1, "(default)");
            this.splitContainer1.Panel1MinSize = 270;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexGrid1);
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel2, "(default)");
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(1617, 277);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // c1DataFilter1
            // 
            this.c1DataFilter1.AutoGenerateFilters = true;
            this.c1DataFilter1.DataMember = null;
            this.c1DataFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DataFilter1.HeaderText = "Filter";
            this.c1DataFilter1.Location = new System.Drawing.Point(0, 0);
            this.c1DataFilter1.Name = "c1DataFilter1";
            this.c1DataFilter1.Size = new System.Drawing.Size(370, 277);
            this.c1DataFilter1.TabIndex = 0;
            this.c1DataFilter1.Text = "c1DataFilter1";
            this.c1DataFilter1.FilterAutoGenerating += new System.EventHandler<C1.DataFilter.FilterAutoGeneratingEventArgs>(this.c1DataFilter1_FilterAutoGenerating);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowDelete = true;
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.AutoResize = true;
            this.c1FlexGrid1.ColumnInfo = "1,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 25;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1242, 277);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 478);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1Ribbon1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "CarsListWithFilter";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.DataFilter.C1DataFilter c1DataFilter1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonCheckBox cbAutoApply;
        private C1.Win.Ribbon.RibbonButton rbtnApplyFilter;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.Ribbon.RibbonButton rbtnSaveFilter;
        private C1.Win.Ribbon.RibbonButton rbtnResetFilter;
    }
}

