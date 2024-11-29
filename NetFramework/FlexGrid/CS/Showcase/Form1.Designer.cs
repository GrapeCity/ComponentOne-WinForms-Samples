namespace Showcase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Win.C1Themes.C1Office365ThemeSettings c1Office365ThemeSettings1 = new C1.Win.C1Themes.C1Office365ThemeSettings();
            this._ribbon = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonButton2 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.DataTab = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonLabel3 = new C1.Win.Ribbon.RibbonLabel();
            this._listDataSize = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonLabel1 = new C1.Win.Ribbon.RibbonLabel();
            this.ribbonSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this._searchToolBar = new C1.Win.Ribbon.RibbonToolBar();
            this._txtSearch = new C1.Win.Ribbon.RibbonTextBox();
            this.ribbonSeparator2 = new C1.Win.Ribbon.RibbonSeparator();
            this._lstFormating = new C1.Win.Ribbon.RibbonMenu();
            this._lstColumns = new C1.Win.Ribbon.RibbonMenu();
            this.ribbonSeparator3 = new C1.Win.Ribbon.RibbonSeparator();
            this._optGroupByCountry = new C1.Win.Ribbon.RibbonCheckBox();
            this._optGroupByProduct = new C1.Win.Ribbon.RibbonCheckBox();
            this.ExportTab = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this._exportToExcell = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator4 = new C1.Win.Ribbon.RibbonSeparator();
            this._exportToCsv = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator5 = new C1.Win.Ribbon.RibbonSeparator();
            this._exportPdf = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this._themeController = new C1.Win.C1Themes.C1ThemeController();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._tooltipController = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this._errorProvider = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._themeController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _ribbon
            // 
            this._ribbon.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this._ribbon.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this._ribbon.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this._ribbon.Location = new System.Drawing.Point(0, 0);
            this._ribbon.Margin = new System.Windows.Forms.Padding(5);
            this._ribbon.Name = "_ribbon";
            this._ribbon.QatHolder = this.ribbonQat1;
            this._ribbon.Size = new System.Drawing.Size(1121, 137);
            this._ribbon.Tabs.Add(this.DataTab);
            this._ribbon.Tabs.Add(this.ExportTab);
            this._themeController.SetTheme(this._ribbon, "(default)");
            this._ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            this._ribbon.ToolTipSettings.Border = true;
            this._ribbon.ToolTipSettings.Shadow = false;
            this._ribbon.TopToolBarHolder = this.ribbonTopToolBar1;
            this._ribbon.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.BottomPaneItems.Add(this.ribbonButton1);
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "Data";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            this.ribbonBottomToolBar1.Visible = false;
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Items.Add(this.ribbonButton2);
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            this.ribbonConfigToolBar1.Visible = false;
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Button";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // DataTab
            // 
            this.DataTab.Groups.Add(this.ribbonGroup1);
            this.DataTab.Name = "DataTab";
            this.DataTab.Text = "Data";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("Black", new System.Drawing.Size(13, 13), System.Drawing.Color.Transparent, null, -1));
            this.ribbonGroup1.Items.Add(this.ribbonLabel3);
            this.ribbonGroup1.Items.Add(this._listDataSize);
            this.ribbonGroup1.Items.Add(this.ribbonLabel1);
            this.ribbonGroup1.Items.Add(this.ribbonSeparator1);
            this.ribbonGroup1.Items.Add(this._searchToolBar);
            this.ribbonGroup1.Items.Add(this.ribbonSeparator2);
            this.ribbonGroup1.Items.Add(this._lstFormating);
            this.ribbonGroup1.Items.Add(this._lstColumns);
            this.ribbonGroup1.Items.Add(this.ribbonSeparator3);
            this.ribbonGroup1.Items.Add(this._optGroupByCountry);
            this.ribbonGroup1.Items.Add(this._optGroupByProduct);
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // ribbonLabel3
            // 
            this.ribbonLabel3.Name = "ribbonLabel3";
            this.ribbonLabel3.Text = "    ";
            // 
            // _listDataSize
            // 
            this._listDataSize.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this._listDataSize.Label = "Data Size:";
            this._listDataSize.MaxLength = 300;
            this._listDataSize.Name = "_listDataSize";
            this._listDataSize.TextAreaWidth = 151;
            this._listDataSize.SelectedIndexChanged += new System.EventHandler(this._listDataSize_SelectedIndexChanged);
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "   ";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // _searchToolBar
            // 
            this._searchToolBar.Items.Add(this._txtSearch);
            this._searchToolBar.Name = "_searchToolBar";
            // 
            // _txtSearch
            // 
            this._txtSearch.CueBanner = "Search";
            this._txtSearch.GapBeforeTextArea = 60;
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.TextAreaWidth = 171;
            this._txtSearch.TextChanged += new System.EventHandler(this._txtSearch_TextChanged);
            this._txtSearch.ChangeCommitted += new System.EventHandler(this._txtSearch_ChangeCommitted);
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // _lstFormating
            // 
            this._lstFormating.IconSet.Add(new C1.Framework.C1BitmapIcon("Datatable", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 106));
            this._lstFormating.Name = "_lstFormating";
            this._lstFormating.Text = "Conditional Formating";
            // 
            // _lstColumns
            // 
            this._lstColumns.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("_lstColumns.IconSet")))));
            this._lstColumns.Name = "_lstColumns";
            this._lstColumns.Text = "Columns";
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // _optGroupByCountry
            // 
            this._optGroupByCountry.Name = "_optGroupByCountry";
            this._optGroupByCountry.Text = "Group by Country";
            this._optGroupByCountry.CheckedChanged += new System.EventHandler(this._optGroupByCountry_CheckedChanged);
            // 
            // _optGroupByProduct
            // 
            this._optGroupByProduct.Name = "_optGroupByProduct";
            this._optGroupByProduct.Text = "Group by Product";
            this._optGroupByProduct.CheckedChanged += new System.EventHandler(this._optGroupByProduct_CheckedChanged);
            // 
            // ExportTab
            // 
            this.ExportTab.Groups.Add(this.ribbonGroup2);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Text = "Export";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.AllowCollapsed = false;
            this.ribbonGroup2.Items.Add(this._exportToExcell);
            this.ribbonGroup2.Items.Add(this.ribbonSeparator4);
            this.ribbonGroup2.Items.Add(this._exportToCsv);
            this.ribbonGroup2.Items.Add(this.ribbonSeparator5);
            this.ribbonGroup2.Items.Add(this._exportPdf);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Group";
            // 
            // _exportToExcell
            // 
            this._exportToExcell.AllowImageScaling = false;
            this._exportToExcell.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(24, 21), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("_exportToExcell.IconSet")))));
            this._exportToExcell.Name = "_exportToExcell";
            this._exportToExcell.Text = "Excel";
            this._exportToExcell.Click += new System.EventHandler(this._exportToExcell_Click);
            // 
            // ribbonSeparator4
            // 
            this.ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // _exportToCsv
            // 
            this._exportToCsv.AllowImageScaling = false;
            this._exportToCsv.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("_exportToCsv.IconSet")))));
            this._exportToCsv.Name = "_exportToCsv";
            this._exportToCsv.Text = "Csv";
            this._exportToCsv.Click += new System.EventHandler(this._exportToCsv_Click);
            // 
            // ribbonSeparator5
            // 
            this.ribbonSeparator5.Name = "ribbonSeparator5";
            // 
            // _exportPdf
            // 
            this._exportPdf.AllowImageScaling = false;
            this._exportPdf.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("_exportPdf.IconSet")))));
            this._exportPdf.Name = "_exportPdf";
            this._exportPdf.Text = "Pdf";
            this._exportPdf.Click += new System.EventHandler(this._exportPdf_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // _themeController
            // 
            this._themeController.Theme = "Office365White";
            c1Office365ThemeSettings1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings1.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._themeController.ThemeSettings = c1Office365ThemeSettings1;
            this._themeController.ObjectThemeApplied += new C1.Win.C1Themes.ObjectThemeEventHandler(this._themeController_ObjectThemeApplied);
            // 
            // _flex
            // 
            this._flex.AllowFiltering = true;
            this._flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom;
            this._flex.BackColor = System.Drawing.Color.White;
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flex.ColumnInfo = "10,1,0,0,0,-1,Columns:0{Style:\"Margins:15, 15, 15, 15;\";StyleFixed:\"ImageAlign:Le" +
    "ftCenter;\";}\t3{Style:\"Margins:1, 1, 1, 1;\";}\t5{Aggregate:Sum;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Background;
            this._flex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this._flex.IconsStyle = C1.Win.C1FlexGrid.IconsStyle.Office365;
            this._flex.Location = new System.Drawing.Point(0, 153);
            this._flex.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this._flex.MarqueeStyle.BackgroundPadding = new System.Windows.Forms.Padding(1);
            this._flex.MarqueeStyle.BackgroundPaddingColor = System.Drawing.Color.White;
            this._flex.MarqueeStyle.BorderAlign = C1.Win.C1FlexGrid.BorderAlign.Outside;
            this._flex.MarqueeStyle.BorderMode = C1.Win.C1FlexGrid.MarqueeBorderMode.CellRange;
            this._flex.MarqueeStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this._flex.MarqueeStyle.Width = 2;
            this._flex.Name = "_flex";
            this._flex.ShowErrors = true;
            this._flex.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this._flex.Size = new System.Drawing.Size(1121, 660);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 1;
            this._themeController.SetTheme(this._flex, "(default)");
            this._flex.Tree.Indent = 25;
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._flex.GridChanged += new C1.Win.C1FlexGrid.GridChangedEventHandler(this._flex_GridChanged);
            this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // _tooltipController
            // 
            this._tooltipController.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None;
            this._tooltipController.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this._tooltipController.Font = new System.Drawing.Font("Tahoma", 8F);
            this._tooltipController.IsBalloon = true;
            this._tooltipController.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this._tooltipController.RoundedCorners = true;
            this._themeController.SetTheme(this._tooltipController, "(default)");
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            this._themeController.SetTheme(this._errorProvider, "(default)");
            this._errorProvider.ToolTip = this._tooltipController;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 16);
            this.panel1.TabIndex = 3;
            this._themeController.SetTheme(this.panel1, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 813);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Showcase";
            this._themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._themeController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon _ribbon;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab DataTab;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox _listDataSize;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.Ribbon.RibbonMenu _lstFormating;
        private C1.Win.Ribbon.RibbonMenu _lstColumns;
        private C1.Win.Ribbon.RibbonCheckBox _optGroupByCountry;
        private C1.Win.Ribbon.RibbonCheckBox _optGroupByProduct;
        private C1.Win.Ribbon.RibbonTab ExportTab;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Themes.C1ThemeController _themeController;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private C1.Win.Ribbon.RibbonButton ribbonButton2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton _exportToExcell;
        private C1.Win.Ribbon.RibbonButton _exportToCsv;
        private C1.Win.Ribbon.RibbonTextBox _txtSearch;
        private C1.Win.Ribbon.RibbonToolBar _searchToolBar;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.C1SuperTooltip.C1SuperTooltip _tooltipController;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider _errorProvider;
        private C1.Win.Ribbon.RibbonButton _exportPdf;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel3;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator4;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator5;
    }
}

