namespace RowsSelected
{
    partial class MainForm
    {
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
            this.ribbonComboBoxSelMode = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonComboBoxThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1FlexGridData = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGridRowsSelected = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridRowsSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.AllowContextMenu = false;
            this.c1Ribbon1.AllowMinimize = false;
            this.c1Ribbon1.AllowSimplifiedView = false;
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(6);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1016, 73);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.TabIndex = 0;
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left;
            this.ribbonBottomToolBar1.Items.Add(this.ribbonComboBoxSelMode);
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonComboBoxSelMode
            // 
            this.ribbonComboBoxSelMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.ribbonComboBoxSelMode.Label = "Selection Mode:";
            this.ribbonComboBoxSelMode.Name = "ribbonComboBoxSelMode";
            this.ribbonComboBoxSelMode.TabIndex = 7;
            this.ribbonComboBoxSelMode.SelectedIndexChanged += new System.EventHandler(this.ribbonComboBoxSelMode_SelectedIndexChanged);
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            this.ribbonConfigToolBar1.Visible = false;
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            this.ribbonQat1.Visible = false;
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Items.Add(this.ribbonComboBoxThemes);
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonComboBoxThemes
            // 
            this.ribbonComboBoxThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.ribbonComboBoxThemes.IconSet.Add(new C1.Framework.C1BitmapIcon("Themes", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 462));
            this.ribbonComboBoxThemes.Label = "Theme:";
            this.ribbonComboBoxThemes.Name = "ribbonComboBoxThemes";
            this.ribbonComboBoxThemes.TabIndex = 6;
            this.ribbonComboBoxThemes.SelectedIndexChanged += new System.EventHandler(this.ribbonComboBoxThemes_SelectedIndexChanged);
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365Green";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel1.Controls.Add(this.c1FlexGridData);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel1, "(default)");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexGridRowsSelected);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel2, "(default)");
            this.splitContainer1.Size = new System.Drawing.Size(1016, 687);
            this.splitContainer1.SplitterDistance = 867;
            this.splitContainer1.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // c1FlexGridData
            // 
            this.c1FlexGridData.AllowEditing = false;
            this.c1FlexGridData.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Spill;
            this.c1FlexGridData.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.None;
            this.c1FlexGridData.BackColor = System.Drawing.Color.White;
            this.c1FlexGridData.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            this.c1FlexGridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGridData.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background;
            this.c1FlexGridData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1FlexGridData.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365;
            this.c1FlexGridData.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGridData.Margin = new System.Windows.Forms.Padding(6);
            this.c1FlexGridData.MarqueeStyle.BackgroundPadding = new System.Windows.Forms.Padding(1);
            this.c1FlexGridData.MarqueeStyle.BackgroundPaddingColor = System.Drawing.Color.White;
            this.c1FlexGridData.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            this.c1FlexGridData.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            this.c1FlexGridData.MarqueeStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(72)))));
            this.c1FlexGridData.MarqueeStyle.Width = 2;
            this.c1FlexGridData.Name = "c1FlexGridData";
            this.c1FlexGridData.Size = new System.Drawing.Size(867, 687);
            this.c1FlexGridData.StyleInfo = resources.GetString("c1FlexGridData.StyleInfo");
            this.c1FlexGridData.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1FlexGridData, "(default)");
            this.c1FlexGridData.Tree.Indent = 25;
            this.c1FlexGridData.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.c1FlexGridData.UseCompatibleTextRendering = true;
            this.c1FlexGridData.AfterSelChange += new C1.Win.FlexGrid.RangeEventHandler(this.c1FlexGridData_AfterSelChange);
            // 
            // c1FlexGridRowsSelected
            // 
            this.c1FlexGridRowsSelected.BackColor = System.Drawing.Color.White;
            this.c1FlexGridRowsSelected.ColumnInfo = "1,0,0,0,0,-1,Columns:0{Name:\"colRowsSelected\";Caption:\"Rows.Selected:\";AllowDragg" +
    "ing:False;AllowResizing:False;AllowEditing:False;}\t";
            this.c1FlexGridRowsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGridRowsSelected.ExtendLastCol = true;
            this.c1FlexGridRowsSelected.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background;
            this.c1FlexGridRowsSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1FlexGridRowsSelected.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365;
            this.c1FlexGridRowsSelected.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGridRowsSelected.MarqueeStyle.BackgroundPadding = new System.Windows.Forms.Padding(1);
            this.c1FlexGridRowsSelected.MarqueeStyle.BackgroundPaddingColor = System.Drawing.Color.White;
            this.c1FlexGridRowsSelected.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            this.c1FlexGridRowsSelected.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            this.c1FlexGridRowsSelected.MarqueeStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(72)))));
            this.c1FlexGridRowsSelected.MarqueeStyle.Width = 2;
            this.c1FlexGridRowsSelected.Name = "c1FlexGridRowsSelected";
            this.c1FlexGridRowsSelected.Rows.Count = 1;
            this.c1FlexGridRowsSelected.Size = new System.Drawing.Size(145, 687);
            this.c1FlexGridRowsSelected.StyleInfo = resources.GetString("c1FlexGridRowsSelected.StyleInfo");
            this.c1FlexGridRowsSelected.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexGridRowsSelected, "(default)");
            this.c1FlexGridRowsSelected.Tree.Indent = 25;
            this.c1FlexGridRowsSelected.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlexGrid Rows Selected Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridRowsSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBoxThemes;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGridData;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBoxSelMode;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGridRowsSelected;
    }
}