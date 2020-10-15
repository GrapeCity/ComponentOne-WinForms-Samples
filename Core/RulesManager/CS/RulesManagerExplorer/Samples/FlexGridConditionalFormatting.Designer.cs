namespace RulesManagerExplorer.Samples
{
    partial class FlexGridConditionalFormatting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexGridConditionalFormatting));
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
            this.commandDock = new C1.Win.Command.C1CommandDock();
            this.dockingTab = new C1.Win.Command.C1DockingTab();
            this.dockingTabPageConditionalFormatting = new C1.Win.Command.C1DockingTabPage();
            this.rulesManager = new C1.Win.RulesManager.C1RulesManager();
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).BeginInit();
            this.commandDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).BeginInit();
            this.dockingTab.SuspendLayout();
            this.dockingTabPageConditionalFormatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1092, 43);
            this.ribbon.Tabs.Add(this.ribbonTab);
            this.ribbon.ToolTipSettings.BackColor = System.Drawing.Color.White;
            this.ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            this.ribbon.ToolTipSettings.Border = true;
            this.ribbon.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ribbon.ToolTipSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.ribbonTopToolBar.Name = "ribbonTopToolBar";
            this.ribbonTopToolBar.Visible = false;
            // 
            // commandDock
            // 
            this.commandDock.BackColor = System.Drawing.Color.White;
            this.commandDock.Controls.Add(this.dockingTab);
            this.commandDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandDock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandDock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.commandDock.Id = 1;
            this.commandDock.Location = new System.Drawing.Point(792, 43);
            this.commandDock.Name = "commandDock";
            this.commandDock.Size = new System.Drawing.Size(300, 709);
            // 
            // dockingTab
            // 
            this.dockingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTab.Controls.Add(this.dockingTabPageConditionalFormatting);
            this.dockingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dockingTab.HotTrack = true;
            this.dockingTab.Location = new System.Drawing.Point(0, 0);
            this.dockingTab.Name = "dockingTab";
            this.dockingTab.ShowSingleTab = false;
            this.dockingTab.Size = new System.Drawing.Size(300, 709);
            this.dockingTab.TabIndex = 0;
            this.dockingTab.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTab.TabsShowFocusCues = false;
            this.dockingTab.TabsSpacing = 2;
            this.dockingTab.TabStyle = C1.Win.Command.TabStyleEnum.Office2007;
            this.dockingTab.VisualStyle = C1.Win.Command.VisualStyle.Custom;
            this.dockingTab.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Silver;
            // 
            // dockingTabPageConditionalFormatting
            // 
            this.dockingTabPageConditionalFormatting.Controls.Add(this.rulesManager);
            this.dockingTabPageConditionalFormatting.Location = new System.Drawing.Point(4, 1);
            this.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting";
            this.dockingTabPageConditionalFormatting.Size = new System.Drawing.Size(295, 707);
            this.dockingTabPageConditionalFormatting.TabIndex = 0;
            this.dockingTabPageConditionalFormatting.Text = "Conditional Formatting";
            // 
            // rulesManager
            // 
            this.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesManager.Location = new System.Drawing.Point(0, 0);
            this.rulesManager.Name = "rulesManager";
            this.rulesManager.Size = new System.Drawing.Size(295, 707);
            this.rulesManager.TabIndex = 0;
            this.rulesManager.Text = "rulesManager";
            // 
            // flexGrid
            // 
            this.flexGrid.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None;
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.rulesManager.SetC1RulesManager(this.flexGrid, this.rulesManager);
            this.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 43);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(792, 709);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 1;
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // FlexGridConditionalFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flexGrid);
            this.Controls.Add(this.commandDock);
            this.Controls.Add(this.ribbon);
            this.Name = "FlexGridConditionalFormatting";
            this.Size = new System.Drawing.Size(1092, 752);
            this.Load += new System.EventHandler(this.FlexGridConditionalFormatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).EndInit();
            this.commandDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).EndInit();
            this.dockingTab.ResumeLayout(false);
            this.dockingTabPageConditionalFormatting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
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
        private C1.Win.Command.C1CommandDock commandDock;
        private C1.Win.Command.C1DockingTab dockingTab;
        private C1.Win.Command.C1DockingTabPage dockingTabPageConditionalFormatting;
        private C1.Win.RulesManager.C1RulesManager rulesManager;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private C1.Win.Ribbon.RibbonToggleButton ribbonToggleButtonManageRules;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxHeader;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxAddButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRemoveButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRuleName;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRangeSelector;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxCondition;
    }
}

