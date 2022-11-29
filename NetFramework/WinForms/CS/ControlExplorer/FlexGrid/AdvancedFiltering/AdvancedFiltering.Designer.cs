namespace ControlExplorer.FlexGrid.AdvancedFiltering
{
    partial class AdvancedFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedFiltering));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.rbCreateFilters = new C1.Win.Ribbon.RibbonButton();
            this.rbSaveFiltersToXml = new C1.Win.Ribbon.RibbonButton();
            this.rbClearFilters = new C1.Win.Ribbon.RibbonButton();
            this.rbLoadFiltersFromXml = new C1.Win.Ribbon.RibbonButton();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1016, 40);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            this.c1Ribbon1.TopToolBar.Visible = false;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left;
            this.ribbonBottomToolBar1.Items.Add(this.rbCreateFilters);
            this.ribbonBottomToolBar1.Items.Add(this.rbSaveFiltersToXml);
            this.ribbonBottomToolBar1.Items.Add(this.rbClearFilters);
            this.ribbonBottomToolBar1.Items.Add(this.rbLoadFiltersFromXml);
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // rbCreateFilters
            // 
            this.rbCreateFilters.Description = "Create Some Filters";
            this.rbCreateFilters.IconSet.Add(new C1.Framework.C1BitmapIcon("AdvancedFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294));
            this.rbCreateFilters.Name = "rbCreateFilters";
            this.rbCreateFilters.Text = "Create Filters";
            this.rbCreateFilters.ToolTip = "Create Some Filters";
            this.rbCreateFilters.Click += new System.EventHandler(this.rbCreateFilters_Click);
            // 
            // rbSaveFiltersToXml
            // 
            this.rbSaveFiltersToXml.Description = "Save Filters To XML";
            this.rbSaveFiltersToXml.IconSet.Add(new C1.Framework.C1BitmapIcon("Save", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294));
            this.rbSaveFiltersToXml.Name = "rbSaveFiltersToXml";
            this.rbSaveFiltersToXml.Text = "Save Filters";
            this.rbSaveFiltersToXml.ToolTip = "Save Filters To XML";
            this.rbSaveFiltersToXml.Click += new System.EventHandler(this.rbSaveFiltersToXml_Click);
            // 
            // rbClearFilters
            // 
            this.rbClearFilters.Description = "Clear All Filters";
            this.rbClearFilters.IconSet.Add(new C1.Framework.C1BitmapIcon("ClearFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294));
            this.rbClearFilters.Name = "rbClearFilters";
            this.rbClearFilters.Text = "Clear Filters";
            this.rbClearFilters.ToolTip = "Clear All Filters";
            this.rbClearFilters.Click += new System.EventHandler(this.rbClearFilters_Click);
            // 
            // rbLoadFiltersFromXml
            // 
            this.rbLoadFiltersFromXml.Description = "Load Filters From XML";
            this.rbLoadFiltersFromXml.IconSet.Add(new C1.Framework.C1BitmapIcon("ReapplyFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294));
            this.rbLoadFiltersFromXml.Name = "rbLoadFiltersFromXml";
            this.rbLoadFiltersFromXml.Text = "Load Filters";
            this.rbLoadFiltersFromXml.ToolTip = "Load Filters From XML";
            this.rbLoadFiltersFromXml.Click += new System.EventHandler(this.rbLoadFiltersFromXml_Click);
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
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.BackColor = System.Drawing.Color.White;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = false;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(750, 694);
            this.c1FlexGrid1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.c1FlexGrid1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel1, "(default)");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.c1TextBox1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel2, "(default)");
            this.splitContainer1.Size = new System.Drawing.Size(1016, 694);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AutoSize = false;
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.c1TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1TextBox1.Location = new System.Drawing.Point(0, 0);
            this.c1TextBox1.Multiline = true;
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(262, 694);
            this.c1TextBox1.TabIndex = 0;
            this.c1TextBox1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Filtering Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
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
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonButton rbSaveFiltersToXml;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.Ribbon.RibbonButton rbCreateFilters;
        private C1.Win.Ribbon.RibbonButton rbLoadFiltersFromXml;
        private C1.Win.Ribbon.RibbonButton rbClearFilters;
    }
}