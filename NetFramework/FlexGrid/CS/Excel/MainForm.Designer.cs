namespace Excel
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
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonButtonImportSheet = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButtonExportSheet = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButtonLoadData = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButtonExportMultiSheet = new C1.Win.Ribbon.RibbonButton();
            this.ribbonComboBoxThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Spill;
            this.c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.BackColor = System.Drawing.Color.White;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background;
            this.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1FlexGrid1.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 39);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c1FlexGrid1.MarqueeStyle.BackgroundPadding = new System.Windows.Forms.Padding(1);
            this.c1FlexGrid1.MarqueeStyle.BackgroundPaddingColor = System.Drawing.Color.White;
            this.c1FlexGrid1.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            this.c1FlexGrid1.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            this.c1FlexGrid1.MarqueeStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(72)))));
            this.c1FlexGrid1.MarqueeStyle.Width = 2;
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1008, 690);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.Indent = 25;
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.c1FlexGrid1.UseCompatibleTextRendering = true;
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
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1008, 39);
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
            this.ribbonBottomToolBar1.Items.Add(this.ribbonButtonImportSheet);
            this.ribbonBottomToolBar1.Items.Add(this.ribbonButtonExportSheet);
            this.ribbonBottomToolBar1.Items.Add(this.ribbonButtonLoadData);
            this.ribbonBottomToolBar1.Items.Add(this.ribbonButtonExportMultiSheet);
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonButtonImportSheet
            // 
            this.ribbonButtonImportSheet.IconSet.Add(new C1.Framework.C1BitmapIcon("Import", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 218));
            this.ribbonButtonImportSheet.Name = "ribbonButtonImportSheet";
            this.ribbonButtonImportSheet.TabIndex = 1;
            this.ribbonButtonImportSheet.Text = "&Import Sheet...";
            this.ribbonButtonImportSheet.Click += new System.EventHandler(this.btnImportSheet_Click);
            // 
            // ribbonButtonExportSheet
            // 
            this.ribbonButtonExportSheet.IconSet.Add(new C1.Framework.C1BitmapIcon("Export", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 0));
            this.ribbonButtonExportSheet.Name = "ribbonButtonExportSheet";
            this.ribbonButtonExportSheet.TabIndex = 2;
            this.ribbonButtonExportSheet.Text = "&Export Sheet...";
            this.ribbonButtonExportSheet.Click += new System.EventHandler(this.btnExportSheet_Click);
            // 
            // ribbonButtonLoadData
            // 
            this.ribbonButtonLoadData.IconSet.Add(new C1.Framework.C1BitmapIcon("FromDatabase", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 173));
            this.ribbonButtonLoadData.Name = "ribbonButtonLoadData";
            this.ribbonButtonLoadData.TabIndex = 3;
            this.ribbonButtonLoadData.Text = "Load &Data";
            this.ribbonButtonLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // ribbonButtonExportMultiSheet
            // 
            this.ribbonButtonExportMultiSheet.IconSet.Add(new C1.Framework.C1BitmapIcon("SidebySide", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 423));
            this.ribbonButtonExportMultiSheet.Name = "ribbonButtonExportMultiSheet";
            this.ribbonButtonExportMultiSheet.TabIndex = 4;
            this.ribbonButtonExportMultiSheet.Text = "Export &Multi-Sheet...";
            this.ribbonButtonExportMultiSheet.Click += new System.EventHandler(this.btnMultiSheet_Click);
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
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            this.ribbonTopToolBar1.Items.Add(this.ribbonComboBoxThemes);
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365Green";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import and Export Excel files Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton ribbonButtonExportSheet;
        private C1.Win.Ribbon.RibbonButton ribbonButtonImportSheet;
        private C1.Win.Ribbon.RibbonButton ribbonButtonLoadData;
        private C1.Win.Ribbon.RibbonButton ribbonButtonExportMultiSheet;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBoxThemes;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}