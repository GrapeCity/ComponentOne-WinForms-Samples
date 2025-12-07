namespace Showcase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _ribbon = new C1.Win.Ribbon.C1Ribbon();
            _ribbonApplicationMenu = new C1.Win.Ribbon.RibbonApplicationMenu();
            _ribbonBottomToolBar = new C1.Win.Ribbon.RibbonBottomToolBar();
            _ribbonConfigToolBar = new C1.Win.Ribbon.RibbonConfigToolBar();
            _ribbonQat = new C1.Win.Ribbon.RibbonQat();
            _ribbonTabData = new C1.Win.Ribbon.RibbonTab();
            _ribbonGroupData = new C1.Win.Ribbon.RibbonGroup();
            _ribbonComboBoxDataSize = new C1.Win.Ribbon.RibbonComboBox();
            _ribbonSeparatorData = new C1.Win.Ribbon.RibbonSeparator();
            _ribbonToolBarSearch = new C1.Win.Ribbon.RibbonToolBar();
            _ribbonTextBoxSearch = new C1.Win.Ribbon.RibbonTextBox();
            _ribbonButtonFilter = new C1.Win.Ribbon.RibbonButton();
            _ribbonSeparatorGroup = new C1.Win.Ribbon.RibbonSeparator();
            _ribbonMenuFormatting = new C1.Win.Ribbon.RibbonMenu();
            _ribbonMenuColumns = new C1.Win.Ribbon.RibbonMenu();
            _ribbonGroupGroup = new C1.Win.Ribbon.RibbonGroup();
            _ribbonCheckBoxGroupByCountry = new C1.Win.Ribbon.RibbonCheckBox();
            _ribbonCheckBoxGroupByProduct = new C1.Win.Ribbon.RibbonCheckBox();
            _exportTab = new C1.Win.Ribbon.RibbonTab();
            _ribbonExportGroup = new C1.Win.Ribbon.RibbonGroup();
            _exportToExcell = new C1.Win.Ribbon.RibbonButton();
            _exportToCsv = new C1.Win.Ribbon.RibbonButton();
            _exportToPdf = new C1.Win.Ribbon.RibbonButton();
            _ribbonTopToolBar = new C1.Win.Ribbon.RibbonTopToolBar();
            _ribbonComboBoxThemes = new C1.Win.Ribbon.RibbonComboBox();
            _themeController = new C1.Win.Themes.C1ThemeController();
            _flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            _tooltip = new C1.Win.SuperTooltip.C1SuperTooltip(components);
            _errorProvider = new C1.Win.SuperTooltip.C1SuperErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)_ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_themeController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_flexGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).BeginInit();
            SuspendLayout();
            // 
            // _ribbon
            // 
            _ribbon.ApplicationMenuHolder = _ribbonApplicationMenu;
            _ribbon.BottomToolBarHolder = _ribbonBottomToolBar;
            _ribbon.ConfigToolBarHolder = _ribbonConfigToolBar;
            _ribbon.Location = new System.Drawing.Point(0, 0);
            _ribbon.Margin = new System.Windows.Forms.Padding(4);
            _ribbon.Name = "_ribbon";
            _ribbon.QatHolder = _ribbonQat;
            _ribbon.Size = new System.Drawing.Size(1121, 105);
            _ribbon.Tabs.Add(_ribbonTabData);
            _ribbon.Tabs.Add(_exportTab);
            _themeController.SetTheme(_ribbon, "(default)");
            _ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            _ribbon.ToolTipSettings.Border = true;
            _ribbon.ToolTipSettings.Shadow = false;
            _ribbon.TopToolBarHolder = _ribbonTopToolBar;
            _ribbon.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // _ribbonApplicationMenu
            // 
            _ribbonApplicationMenu.Name = "_ribbonApplicationMenu";
            _ribbonApplicationMenu.TabIndex = 0;
            _ribbonApplicationMenu.Visible = false;
            // 
            // _ribbonBottomToolBar
            // 
            _ribbonBottomToolBar.Name = "_ribbonBottomToolBar";
            _ribbonBottomToolBar.Visible = false;
            // 
            // _ribbonConfigToolBar
            // 
            _ribbonConfigToolBar.Name = "_ribbonConfigToolBar";
            _ribbonConfigToolBar.Visible = false;
            // 
            // _ribbonQat
            // 
            _ribbonQat.Name = "_ribbonQat";
            // 
            // _ribbonTabData
            // 
            _ribbonTabData.Groups.Add(_ribbonGroupData);
            _ribbonTabData.Groups.Add(_ribbonGroupGroup);
            _ribbonTabData.Name = "_ribbonTabData";
            _ribbonTabData.TabIndex = 0;
            _ribbonTabData.Text = "Data";
            // 
            // _ribbonGroupData
            // 
            _ribbonGroupData.Items.Add(_ribbonComboBoxDataSize);
            _ribbonGroupData.Items.Add(_ribbonSeparatorData);
            _ribbonGroupData.Items.Add(_ribbonToolBarSearch);
            _ribbonGroupData.Items.Add(_ribbonSeparatorGroup);
            _ribbonGroupData.Items.Add(_ribbonMenuFormatting);
            _ribbonGroupData.Items.Add(_ribbonMenuColumns);
            _ribbonGroupData.LauncherTabIndex = 0;
            _ribbonGroupData.Name = "_ribbonGroupData";
            _ribbonGroupData.Text = "Data";
            // 
            // _ribbonComboBoxDataSize
            // 
            _ribbonComboBoxDataSize.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            _ribbonComboBoxDataSize.Label = "Data Size:";
            _ribbonComboBoxDataSize.MaxLength = 300;
            _ribbonComboBoxDataSize.Name = "_ribbonComboBoxDataSize";
            _ribbonComboBoxDataSize.TabIndex = 0;
            _ribbonComboBoxDataSize.TextAreaWidth = 120;
            _ribbonComboBoxDataSize.SelectedIndexChanged += _ribbonComboBoxDataSize_SelectedIndexChanged;
            // 
            // _ribbonSeparatorData
            // 
            _ribbonSeparatorData.Name = "_ribbonSeparatorData";
            // 
            // _ribbonToolBarSearch
            // 
            _ribbonToolBarSearch.Items.Add(_ribbonTextBoxSearch);
            _ribbonToolBarSearch.Items.Add(_ribbonButtonFilter);
            _ribbonToolBarSearch.Name = "_ribbonToolBarSearch";
            // 
            // _ribbonTextBoxSearch
            // 
            _ribbonTextBoxSearch.Label = "Search:";
            _ribbonTextBoxSearch.Name = "_ribbonTextBoxSearch";
            _ribbonTextBoxSearch.TabIndex = 0;
            _ribbonTextBoxSearch.TextChanged += _ribbonTextBoxSearch_TextChanged;
            _ribbonTextBoxSearch.ChangeCommitted += _ribbonTextBoxSearch_ChangeCommitted;
            // 
            // _ribbonButtonFilter
            // 
            _ribbonButtonFilter.Name = "_ribbonButtonFilter";
            _ribbonButtonFilter.TabIndex = 0;
            _ribbonButtonFilter.Click += _ribbonButtonFilter_Click;
            // 
            // _ribbonSeparatorGroup
            // 
            _ribbonSeparatorGroup.Name = "_ribbonSeparatorGroup";
            // 
            // _ribbonMenuFormatting
            // 
            _ribbonMenuFormatting.Name = "_ribbonMenuFormatting";
            _ribbonMenuFormatting.TabIndex = 0;
            _ribbonMenuFormatting.Text = "Conditional Formatting";
            // 
            // _ribbonMenuColumns
            // 
            _ribbonMenuColumns.Name = "_ribbonMenuColumns";
            _ribbonMenuColumns.TabIndex = 0;
            _ribbonMenuColumns.Text = "Columns";
            // 
            // _ribbonGroupGroup
            // 
            _ribbonGroupGroup.Items.Add(_ribbonCheckBoxGroupByCountry);
            _ribbonGroupGroup.Items.Add(_ribbonCheckBoxGroupByProduct);
            _ribbonGroupGroup.LauncherTabIndex = 0;
            _ribbonGroupGroup.Name = "_ribbonGroupGroup";
            _ribbonGroupGroup.Text = "Group";
            // 
            // _ribbonCheckBoxGroupByCountry
            // 
            _ribbonCheckBoxGroupByCountry.Name = "_ribbonCheckBoxGroupByCountry";
            _ribbonCheckBoxGroupByCountry.TabIndex = 0;
            _ribbonCheckBoxGroupByCountry.Text = "Group by Country";
            _ribbonCheckBoxGroupByCountry.CheckedChanged += _ribbonCheckBoxGroupByCountry_CheckedChanged;
            // 
            // _ribbonCheckBoxGroupByProduct
            // 
            _ribbonCheckBoxGroupByProduct.Name = "_ribbonCheckBoxGroupByProduct";
            _ribbonCheckBoxGroupByProduct.TabIndex = 0;
            _ribbonCheckBoxGroupByProduct.Text = "Group by Product";
            _ribbonCheckBoxGroupByProduct.CheckedChanged += _ribbonCheckBoxGroupByProduct_CheckedChanged;
            // 
            // _exportTab
            // 
            _exportTab.Groups.Add(_ribbonExportGroup);
            _exportTab.Name = "_exportTab";
            _exportTab.TabIndex = 0;
            _exportTab.Text = "Export";
            // 
            // _ribbonExportGroup
            // 
            _ribbonExportGroup.Items.Add(_exportToExcell);
            _ribbonExportGroup.Items.Add(_exportToCsv);
            _ribbonExportGroup.Items.Add(_exportToPdf);
            _ribbonExportGroup.LauncherTabIndex = 0;
            _ribbonExportGroup.Name = "_ribbonExportGroup";
            _ribbonExportGroup.Text = "Group";
            // 
            // _exportToExcell
            // 
            _exportToExcell.AllowImageScaling = false;
            _exportToExcell.Name = "_exportToExcell";
            _exportToExcell.TabIndex = 0;
            _exportToExcell.Text = "Excel";
            _exportToExcell.Click += _exportToExcell_Click;
            // 
            // _exportToCsv
            // 
            _exportToCsv.AllowImageScaling = false;
            _exportToCsv.Name = "_exportToCsv";
            _exportToCsv.TabIndex = 0;
            _exportToCsv.Text = "Csv";
            _exportToCsv.Click += _exportToCsv_Click;
            // 
            // _exportToPdf
            // 
            _exportToPdf.AllowImageScaling = false;
            _exportToPdf.Name = "_exportToPdf";
            _exportToPdf.TabIndex = 0;
            _exportToPdf.Text = "Pdf";
            _exportToPdf.Click += _exportToPdf_Click;
            // 
            // _ribbonTopToolBar
            // 
            _ribbonTopToolBar.Items.Add(_ribbonComboBoxThemes);
            _ribbonTopToolBar.Name = "_ribbonTopToolBar";
            // 
            // _ribbonComboBoxThemes
            // 
            _ribbonComboBoxThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            _ribbonComboBoxThemes.Label = "Theme:";
            _ribbonComboBoxThemes.Name = "_ribbonComboBoxThemes";
            _ribbonComboBoxThemes.TabIndex = 0;
            _ribbonComboBoxThemes.TextAreaWidth = 120;
            _ribbonComboBoxThemes.SelectedIndexChanged += _ribbonComboBoxThemes_SelectedIndexChanged;
            // 
            // _themeController
            // 
            _themeController.ObjectThemeApplied += _themeController_ObjectThemeApplied;
            // 
            // _flexGrid
            // 
            _flexGrid.AllowFiltering = true;
            _flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            _flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            _flexGrid.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            _flexGrid.Location = new System.Drawing.Point(0, 105);
            _flexGrid.Margin = new System.Windows.Forms.Padding(4);
            _flexGrid.Name = "_flexGrid";
            _flexGrid.ShowErrors = true;
            _flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            _flexGrid.Size = new System.Drawing.Size(1121, 700);
            _flexGrid.TabIndex = 1;
            _themeController.SetTheme(_flexGrid, "(default)");
            _flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(153, 153, 153);
            _flexGrid.GridChanged += _flexGrid_GridChanged;
            _flexGrid.OwnerDrawCell += _flexGrid_OwnerDrawCell;
            // 
            // _tooltip
            // 
            _tooltip.BackgroundGradient = C1.Win.SuperTooltip.BackgroundGradient.None;
            _tooltip.BorderColor = System.Drawing.Color.FromArgb(153, 153, 153);
            _tooltip.Font = new System.Drawing.Font("Tahoma", 8F);
            _tooltip.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            _themeController.SetTheme(_tooltip, "(default)");
            // 
            // _errorProvider
            // 
            _errorProvider.ContainerControl = this;
            _themeController.SetTheme(_errorProvider, "(default)");
            _errorProvider.ToolTip = _tooltip;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1121, 805);
            Controls.Add(_flexGrid);
            Controls.Add(_ribbon);
            Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "C1FlexGrid: Showcase";
            _themeController.SetTheme(this, "Office2016Green");
            ((System.ComponentModel.ISupportInitialize)_ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)_themeController).EndInit();
            ((System.ComponentModel.ISupportInitialize)_flexGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon _ribbon;
        private C1.Win.Ribbon.RibbonApplicationMenu _ribbonApplicationMenu;
        private C1.Win.Ribbon.RibbonBottomToolBar _ribbonBottomToolBar;
        private C1.Win.Ribbon.RibbonConfigToolBar _ribbonConfigToolBar;
        private C1.Win.Ribbon.RibbonQat _ribbonQat;
        private C1.Win.Ribbon.RibbonTab _ribbonTabData;
        private C1.Win.Ribbon.RibbonGroup _ribbonGroupData;
        private C1.Win.Ribbon.RibbonTopToolBar _ribbonTopToolBar;
        private C1.Win.Ribbon.RibbonComboBox _ribbonComboBoxDataSize;
        private C1.Win.Ribbon.RibbonSeparator _ribbonSeparatorData;
        private C1.Win.Ribbon.RibbonMenu _ribbonMenuFormatting;
        private C1.Win.Ribbon.RibbonMenu _ribbonMenuColumns;
        private C1.Win.Ribbon.RibbonCheckBox _ribbonCheckBoxGroupByCountry;
        private C1.Win.Ribbon.RibbonCheckBox _ribbonCheckBoxGroupByProduct;
        private C1.Win.Themes.C1ThemeController _themeController;
        private C1.Win.Ribbon.RibbonComboBox _ribbonComboBoxThemes;
        private C1.Win.FlexGrid.C1FlexGrid _flexGrid;
        private C1.Win.Ribbon.RibbonButton _ribbonButtonFilter;
        private C1.Win.Ribbon.RibbonGroup _ribbonGroupGroup;
        private C1.Win.Ribbon.RibbonTextBox _ribbonTextBoxSearch;
        private C1.Win.Ribbon.RibbonToolBar _ribbonToolBarSearch;
        private C1.Win.Ribbon.RibbonSeparator _ribbonSeparatorGroup;
        private C1.Win.SuperTooltip.C1SuperTooltip _tooltip;
        private C1.Win.SuperTooltip.C1SuperErrorProvider _errorProvider;
        private C1.Win.Ribbon.RibbonTab _exportTab;
        private C1.Win.Ribbon.RibbonGroup _ribbonExportGroup;
        private C1.Win.Ribbon.RibbonButton _exportToExcell;
        private C1.Win.Ribbon.RibbonButton _exportToCsv;
        private C1.Win.Ribbon.RibbonButton _exportToPdf;
    }
}

