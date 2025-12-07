namespace DataGridViewConditionalFormatting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroupConditionalFormatting = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToggleButtonManageRules = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonCheckBoxHeader = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxAddButton = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRemoveButton = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRuleName = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRangeSelector = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxCondition = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonTopToolBar = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonComboBoxTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.commandDock = new C1.Win.Command.C1CommandDock();
            this.dockingTab = new C1.Win.Command.C1DockingTab();
            this.dockingTabPageConditionalFormatting = new C1.Win.Command.C1DockingTabPage();
            this.rulesManager = new C1.Win.RulesManager.C1RulesManager();
            this.formattableDataGridView = new DataGridViewConditionalFormatting.FormattableDataGridView();
            this.superTooltip = new C1.Win.SuperTooltip.C1SuperTooltip(this.components);
            this.themeController = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).BeginInit();
            this.commandDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).BeginInit();
            this.dockingTab.SuspendLayout();
            this.dockingTabPageConditionalFormatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationMenuHolder = this.ribbonApplicationMenu;
            this.ribbon.BottomToolBarHolder = this.ribbonBottomToolBar;
            this.ribbon.ConfigToolBarHolder = this.ribbonConfigToolBar;
            this.ribbon.HideTabHeaderRow = true;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Name = "ribbon";
            this.ribbon.QatHolder = this.ribbonQat;
            this.ribbon.Size = new System.Drawing.Size(1092, 77);
            this.ribbon.Tabs.Add(this.ribbonTab);
            this.themeController.SetTheme(this.ribbon, "(default)");
            this.ribbon.ToolTipSettings.BackColor = System.Drawing.Color.White;
            this.ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            this.ribbon.ToolTipSettings.Border = true;
            this.ribbon.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ribbon.ToolTipSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ribbon.ToolTipSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.ribbon.ToolTipSettings.InitialDelay = 900;
            this.ribbon.ToolTipSettings.ReshowDelay = 180;
            this.ribbon.ToolTipSettings.Shadow = false;
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
            this.ribbonTab.Groups.Add(this.ribbonGroupConditionalFormatting);
            this.ribbonTab.Name = "ribbonTab";
            this.ribbonTab.Text = "Tab";
            // 
            // ribbonGroupConditionalFormatting
            // 
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonToggleButtonManageRules);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxHeader);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxAddButton);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRemoveButton);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRuleName);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRangeSelector);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxCondition);
            this.ribbonGroupConditionalFormatting.Name = "ribbonGroupConditionalFormatting";
            this.ribbonGroupConditionalFormatting.Text = "Conditional Formatting";
            // 
            // ribbonToggleButtonManageRules
            // 
            this.ribbonToggleButtonManageRules.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonToggleButtonManageRules.IconSet")))));
            this.ribbonToggleButtonManageRules.Name = "ribbonToggleButtonManageRules";
            this.ribbonToggleButtonManageRules.Pressed = true;
            this.ribbonToggleButtonManageRules.Text = "Manage Rules";
            this.ribbonToggleButtonManageRules.PressedChanged += new System.EventHandler(this.ribbonToggleButtonManageRules_PressedChanged);
            // 
            // ribbonCheckBoxHeader
            // 
            this.ribbonCheckBoxHeader.Checked = true;
            this.ribbonCheckBoxHeader.Name = "ribbonCheckBoxHeader";
            this.ribbonCheckBoxHeader.Text = "Header";
            this.ribbonCheckBoxHeader.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxHeader_CheckedChanged);
            // 
            // ribbonCheckBoxAddButton
            // 
            this.ribbonCheckBoxAddButton.Checked = true;
            this.ribbonCheckBoxAddButton.Name = "ribbonCheckBoxAddButton";
            this.ribbonCheckBoxAddButton.Text = "Add button";
            this.ribbonCheckBoxAddButton.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxAddButton_CheckedChanged);
            // 
            // ribbonCheckBoxRemoveButton
            // 
            this.ribbonCheckBoxRemoveButton.Checked = true;
            this.ribbonCheckBoxRemoveButton.Name = "ribbonCheckBoxRemoveButton";
            this.ribbonCheckBoxRemoveButton.Text = "Remove button";
            this.ribbonCheckBoxRemoveButton.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRemoveButton_CheckedChanged);
            // 
            // ribbonCheckBoxRuleName
            // 
            this.ribbonCheckBoxRuleName.Checked = true;
            this.ribbonCheckBoxRuleName.Name = "ribbonCheckBoxRuleName";
            this.ribbonCheckBoxRuleName.Text = "Rule name";
            this.ribbonCheckBoxRuleName.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRuleName_CheckedChanged);
            // 
            // ribbonCheckBoxRangeSelector
            // 
            this.ribbonCheckBoxRangeSelector.Checked = true;
            this.ribbonCheckBoxRangeSelector.Name = "ribbonCheckBoxRangeSelector";
            this.ribbonCheckBoxRangeSelector.Text = "Range selector";
            this.ribbonCheckBoxRangeSelector.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRangeSelector_CheckedChanged);
            // 
            // ribbonCheckBoxCondition
            // 
            this.ribbonCheckBoxCondition.Checked = true;
            this.ribbonCheckBoxCondition.Name = "ribbonCheckBoxCondition";
            this.ribbonCheckBoxCondition.Text = "Condition";
            this.ribbonCheckBoxCondition.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxCondition_CheckedChanged);
            // 
            // ribbonTopToolBar
            // 
            this.ribbonTopToolBar.Items.Add(this.ribbonComboBoxTheme);
            this.ribbonTopToolBar.Name = "ribbonTopToolBar";
            // 
            // ribbonComboBoxTheme
            // 
            this.ribbonComboBoxTheme.Label = "Theme";
            this.ribbonComboBoxTheme.Name = "ribbonComboBoxTheme";
            this.ribbonComboBoxTheme.TextAreaWidth = 105;
            this.ribbonComboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.ribbonComboBoxTheme_SelectedIndexChanged);
            // 
            // commandDock
            // 
            this.commandDock.BackColor = System.Drawing.Color.White;
            this.commandDock.Controls.Add(this.dockingTab);
            this.commandDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandDock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.commandDock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.commandDock.Id = 1;
            this.commandDock.Location = new System.Drawing.Point(792, 77);
            this.commandDock.Name = "commandDock";
            this.commandDock.Size = new System.Drawing.Size(300, 675);
            this.themeController.SetTheme(this.commandDock, "(default)");
            // 
            // dockingTab
            // 
            this.dockingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTab.Controls.Add(this.dockingTabPageConditionalFormatting);
            this.dockingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dockingTab.HotTrack = true;
            this.dockingTab.Location = new System.Drawing.Point(0, 0);
            this.dockingTab.Name = "dockingTab";
            this.dockingTab.ShowSingleTab = false;
            this.dockingTab.Size = new System.Drawing.Size(300, 675);
            this.dockingTab.TabIndex = 0;
            this.dockingTab.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTab.TabsShowFocusCues = false;
            this.dockingTab.TabsSpacing = 2;
            this.dockingTab.TabStyle = C1.Win.Command.TabStyleEnum.Office2007;
            this.themeController.SetTheme(this.dockingTab, "(default)");
            // 
            // dockingTabPageConditionalFormatting
            // 
            this.dockingTabPageConditionalFormatting.Controls.Add(this.rulesManager);
            this.dockingTabPageConditionalFormatting.Location = new System.Drawing.Point(4, 1);
            this.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting";
            this.dockingTabPageConditionalFormatting.Size = new System.Drawing.Size(295, 673);
            this.dockingTabPageConditionalFormatting.TabIndex = 0;
            this.dockingTabPageConditionalFormatting.Text = "Conditional Formatting";
            // 
            // rulesManager
            // 
            this.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesManager.Location = new System.Drawing.Point(0, 0);
            this.rulesManager.Name = "rulesManager";
            this.rulesManager.Options.AllowedRules = C1.Win.RulesManager.RuleTypes.Solid;
            this.rulesManager.Options.IsBorderColorVisible = false;
            this.rulesManager.Options.IsTextAlignVisible = false;
            this.rulesManager.Size = new System.Drawing.Size(295, 673);
            this.rulesManager.TabIndex = 0;
            this.rulesManager.Text = "rulesManager";
            this.themeController.SetTheme(this.rulesManager, "(default)");
            this.rulesManager.MouseLeave += new System.EventHandler(this.rulesManager_MouseLeave);
            this.rulesManager.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rulesManager_MouseMove);
            // 
            // formattableDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.formattableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.formattableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rulesManager.SetC1RulesManager(this.formattableDataGridView, this.rulesManager);
            this.formattableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.formattableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formattableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.formattableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattableDataGridView.EnableHeadersVisualStyles = false;
            this.formattableDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.formattableDataGridView.Location = new System.Drawing.Point(0, 77);
            this.formattableDataGridView.Name = "formattableDataGridView";
            this.formattableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.formattableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.formattableDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.formattableDataGridView.Size = new System.Drawing.Size(792, 675);
            this.formattableDataGridView.TabIndex = 1;
            this.themeController.SetTheme(this.formattableDataGridView, "(default)");
            // 
            // superTooltip
            // 
            this.superTooltip.BackgroundGradient = C1.Win.SuperTooltip.BackgroundGradient.None;
            this.superTooltip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.superTooltip.Font = new System.Drawing.Font("Tahoma", 8F);
            this.superTooltip.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.themeController.SetTheme(this.superTooltip, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 752);
            this.Controls.Add(this.formattableDataGridView);
            this.Controls.Add(this.commandDock);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DataGridViewConditionalFormatting";
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).EndInit();
            this.commandDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).EndInit();
            this.dockingTab.ResumeLayout(false);
            this.dockingTabPageConditionalFormatting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableDataGridView)).EndInit();
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
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar;
        private C1.Win.Ribbon.RibbonGroup ribbonGroupConditionalFormatting;
        private C1.Win.Themes.C1ThemeController themeController;
        private C1.Win.Command.C1CommandDock commandDock;
        private C1.Win.Command.C1DockingTab dockingTab;
        private C1.Win.Command.C1DockingTabPage dockingTabPageConditionalFormatting;
        private C1.Win.RulesManager.C1RulesManager rulesManager;
        private DataGridViewConditionalFormatting.FormattableDataGridView formattableDataGridView;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBoxTheme;
        private C1.Win.Ribbon.RibbonToggleButton ribbonToggleButtonManageRules;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxHeader;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxAddButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRemoveButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRuleName;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRangeSelector;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxCondition;
        private C1.Win.SuperTooltip.C1SuperTooltip superTooltip;
    }
}

