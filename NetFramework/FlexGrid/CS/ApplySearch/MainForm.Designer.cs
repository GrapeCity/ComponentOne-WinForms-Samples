namespace ApplySearch
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
            this.rcbHighlightMode = new C1.Win.Ribbon.RibbonComboBox();
            this.rcbSearchFilter = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton2 = new C1.Win.Ribbon.RibbonButton();
            this.rcbSearchTemplates = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonButton3 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton4 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton5 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton6 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton7 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton8 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGridSearchPanel1 = new C1.Win.FlexGrid.C1FlexGridSearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1016, 66);
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
            this.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left;
            this.ribbonBottomToolBar1.Items.Add(this.rcbHighlightMode);
            this.ribbonBottomToolBar1.Items.Add(this.rcbSearchFilter);
            this.ribbonBottomToolBar1.Items.Add(this.rcbSearchTemplates);
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // rcbHighlightMode
            // 
            this.rcbHighlightMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rcbHighlightMode.Label = " Highlight Mode:";
            this.rcbHighlightMode.Name = "rcbHighlightMode";
            this.rcbHighlightMode.SelectedIndexChanged += new System.EventHandler(this.rcbHighlightMode_SelectedIndexChanged);
            // 
            // rcbSearchFilter
            // 
            this.rcbSearchFilter.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rcbSearchFilter.Items.Add(this.ribbonButton1);
            this.rcbSearchFilter.Items.Add(this.ribbonButton2);
            this.rcbSearchFilter.Label = " Filter Results:";
            this.rcbSearchFilter.Name = "rcbSearchFilter";
            this.rcbSearchFilter.SelectedIndexChanged += new System.EventHandler(this.rcbSearchFilter_SelectedIndexChanged);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "Enabled";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Disabled";
            // 
            // rcbSearchTemplates
            // 
            this.rcbSearchTemplates.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rcbSearchTemplates.Items.Add(this.ribbonButton3);
            this.rcbSearchTemplates.Items.Add(this.ribbonButton4);
            this.rcbSearchTemplates.Items.Add(this.ribbonButton5);
            this.rcbSearchTemplates.Items.Add(this.ribbonButton6);
            this.rcbSearchTemplates.Items.Add(this.ribbonButton7);
            this.rcbSearchTemplates.Items.Add(this.ribbonButton8);
            this.rcbSearchTemplates.Label = " Search Templates:";
            this.rcbSearchTemplates.Name = "rcbSearchTemplates";
            this.rcbSearchTemplates.SelectedIndexChanged += new System.EventHandler(this.rcbSearchTemplates_SelectedIndexChanged);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.Text = "\"a\"\"B\"";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.Text = "123";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.Text = "\"VE\"-\"bA\"-\"9\"";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.Text = "+\"Ma\"-\"d\"";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.Text = "+\"rI\"\"od\"";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.Text = "\"g s\"\", p\"";
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
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.BackColor = System.Drawing.Color.White;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.None;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = false;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 115);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1016, 645);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // c1FlexGridSearchPanel1
            // 
            this.c1FlexGridSearchPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1FlexGridSearchPanel1.Location = new System.Drawing.Point(0, 66);
            this.c1FlexGridSearchPanel1.Name = "c1FlexGridSearchPanel1";
            this.c1FlexGridSearchPanel1.SearchMode = C1.Win.FlexGrid.SearchMode.Always;
            this.c1FlexGridSearchPanel1.Size = new System.Drawing.Size(1016, 49);
            this.c1FlexGridSearchPanel1.TabIndex = 5;
            this.c1ThemeController1.SetTheme(this.c1FlexGridSearchPanel1, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1FlexGridSearchPanel1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplySearch Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
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
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Ribbon.RibbonComboBox rcbHighlightMode;
        private C1.Win.Ribbon.RibbonComboBox rcbSearchFilter;
        private C1.Win.Ribbon.RibbonComboBox rcbSearchTemplates;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
        private C1.Win.Ribbon.RibbonButton ribbonButton2;
        private C1.Win.FlexGrid.C1FlexGridSearchPanel c1FlexGridSearchPanel1;
        private C1.Win.Ribbon.RibbonButton ribbonButton3;
        private C1.Win.Ribbon.RibbonButton ribbonButton4;
        private C1.Win.Ribbon.RibbonButton ribbonButton5;
        private C1.Win.Ribbon.RibbonButton ribbonButton6;
        private C1.Win.Ribbon.RibbonButton ribbonButton7;
        private C1.Win.Ribbon.RibbonButton ribbonButton8;
    }
}

