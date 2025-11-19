using System.Resources;

namespace ScrollBarAnnotations
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            _flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            c1ThemeController = new C1.Win.Themes.C1ThemeController();
            topPanel = new Panel();
            themeComboBox = new C1.Win.Input.C1ComboBox();
            hotKeysCheckbox = new C1.Win.Input.C1CheckBox();
            showScrollTipCheckbox = new C1.Win.Input.C1CheckBox();
            customAnnotation1Checkbox = new C1.Win.Input.C1CheckBox();
            showErrorsCheckbox = new C1.Win.Input.C1CheckBox();
            showAnnotationsCheckbox = new C1.Win.Input.C1CheckBox();
            bottomPanel = new Panel();
            displayOptionPanel = new Panel();
            rightPanel = new FlowLayoutPanel();
            displayOptionTitle = new C1.Win.Input.C1Label();
            showSelectedRowCheckbox = new C1.Win.Input.C1CheckBox();
            showFocusedRowCheckbox = new C1.Win.Input.C1CheckBox();
            showHighlightedRowCheckbox = new C1.Win.Input.C1CheckBox();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)_flexGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)themeComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotKeysCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showScrollTipCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customAnnotation1Checkbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showErrorsCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showAnnotationsCheckbox).BeginInit();
            bottomPanel.SuspendLayout();
            displayOptionPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayOptionTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showSelectedRowCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showFocusedRowCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showHighlightedRowCheckbox).BeginInit();
            SuspendLayout();
            // 
            // _flexGrid
            // 
            _flexGrid.AutoResize = true;
            _flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            _flexGrid.Dock = DockStyle.Fill;
            _flexGrid.ExtendLastCol = true;
            _flexGrid.Location = new Point(0, 0);
            _flexGrid.Margin = new Padding(2);
            _flexGrid.Name = "_flexGrid";
            _flexGrid.Size = new Size(1073, 754);
            _flexGrid.TabIndex = 0;
            _flexGrid.Tree.Indent = 18;
            // 
            // c1ThemeController
            // 
            c1ThemeController.Theme = "(none)";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(themeComboBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1538, 69);
            topPanel.TabIndex = 3;
            c1ThemeController.SetTheme(topPanel, "(default)");
            // 
            // themeComboBox
            // 
            themeComboBox.Anchor = AnchorStyles.Right;
            themeComboBox.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            themeComboBox.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            themeComboBox.Location = new Point(1220, 19);
            themeComboBox.Name = "themeComboBox";
            themeComboBox.ReadOnly = true;
            themeComboBox.Size = new Size(305, 33);
            themeComboBox.TabIndex = 14;
            c1ThemeController.SetTheme(themeComboBox, "(default)");
            themeComboBox.SelectedIndexChanged += CmbThemes_SelectedIndexChanged;
            // 
            // hotKeysCheckbox
            // 
            hotKeysCheckbox.AutoSize = true;
            hotKeysCheckbox.Location = new Point(11, 269);
            hotKeysCheckbox.Name = "hotKeysCheckbox";
            hotKeysCheckbox.Size = new Size(223, 27);
            hotKeysCheckbox.TabIndex = 10;
            hotKeysCheckbox.Text = Properties.Resource.Hotkeys;
            c1ThemeController.SetTheme(hotKeysCheckbox, "(default)");
            hotKeysCheckbox.CheckedChanged += HotKeys_CheckedChanged;
            // 
            // showScrollTipCheckbox
            // 
            showScrollTipCheckbox.AutoSize = true;
            showScrollTipCheckbox.Location = new Point(11, 302);
            showScrollTipCheckbox.Name = "showScrollTipCheckbox";
            showScrollTipCheckbox.Size = new Size(196, 27);
            showScrollTipCheckbox.TabIndex = 9;
            showScrollTipCheckbox.Text = "Show Scroll ToolTip";
            c1ThemeController.SetTheme(showScrollTipCheckbox, "(default)");
            showScrollTipCheckbox.CheckedChanged += ShowScrollTip_CheckedChanged;
            // 
            // customAnnotation1Checkbox
            // 
            customAnnotation1Checkbox.AutoSize = true;
            customAnnotation1Checkbox.Location = new Point(11, 236);
            customAnnotation1Checkbox.Name = "customAnnotation1Checkbox";
            customAnnotation1Checkbox.Size = new Size(409, 27);
            customAnnotation1Checkbox.TabIndex = 8;
            customAnnotation1Checkbox.Text = Properties.Resource.CustomAnnotations;
            c1ThemeController.SetTheme(customAnnotation1Checkbox, "(default)");
            customAnnotation1Checkbox.CheckedChanged += CustomAnnotation1_CheckedChanged;
            // 
            // showErrorsCheckbox
            // 
            showErrorsCheckbox.AutoSize = true;
            showErrorsCheckbox.Checked = true;
            showErrorsCheckbox.CheckState = CheckState.Checked;
            showErrorsCheckbox.Location = new Point(11, 104);
            showErrorsCheckbox.Name = "showErrorsCheckbox";
            showErrorsCheckbox.Size = new Size(137, 27);
            showErrorsCheckbox.TabIndex = 7;
            showErrorsCheckbox.Text = "Show Errors";
            c1ThemeController.SetTheme(showErrorsCheckbox, "(default)");
            showErrorsCheckbox.Value = true;
            showErrorsCheckbox.CheckedChanged += ShowErrors_CheckedChanged;
            // 
            // showAnnotationsCheckbox
            // 
            showAnnotationsCheckbox.AutoSize = true;
            showAnnotationsCheckbox.Checked = true;
            showAnnotationsCheckbox.CheckState = CheckState.Checked;
            showAnnotationsCheckbox.Location = new Point(11, 71);
            showAnnotationsCheckbox.Name = "showAnnotationsCheckbox";
            showAnnotationsCheckbox.Size = new Size(188, 27);
            showAnnotationsCheckbox.TabIndex = 3;
            showAnnotationsCheckbox.Text = Properties.Resource.ShowAnnotations;
            c1ThemeController.SetTheme(showAnnotationsCheckbox, "(default)");
            showAnnotationsCheckbox.Value = true;
            showAnnotationsCheckbox.CheckedChanged += ShowAnnotaions_CheckedChanged;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(_flexGrid);
            bottomPanel.Controls.Add(displayOptionPanel);
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new Point(0, 69);
            bottomPanel.Margin = new Padding(4);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1538, 754);
            bottomPanel.TabIndex = 4;
            c1ThemeController.SetTheme(bottomPanel, "(default)");
            // 
            // displayOptionPanel
            // 
            displayOptionPanel.Controls.Add(rightPanel);
            displayOptionPanel.Dock = DockStyle.Right;
            displayOptionPanel.Location = new Point(1073, 0);
            displayOptionPanel.Margin = new Padding(2);
            displayOptionPanel.Name = "displayOptionPanel";
            displayOptionPanel.Size = new Size(465, 754);
            displayOptionPanel.TabIndex = 15;
            c1ThemeController.SetTheme(displayOptionPanel, "(default)");
            // 
            // rightPanel
            // 
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Controls.Add(displayOptionTitle);
            rightPanel.Controls.Add(showAnnotationsCheckbox);
            rightPanel.Controls.Add(showErrorsCheckbox);
            rightPanel.Controls.Add(showSelectedRowCheckbox);
            rightPanel.Controls.Add(showFocusedRowCheckbox);
            rightPanel.Controls.Add(showHighlightedRowCheckbox);
            rightPanel.Controls.Add(customAnnotation1Checkbox);
            rightPanel.Controls.Add(hotKeysCheckbox);
            rightPanel.Controls.Add(showScrollTipCheckbox);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.FlowDirection = FlowDirection.TopDown;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Margin = new Padding(2);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(8);
            rightPanel.Size = new Size(465, 754);
            rightPanel.TabIndex = 1;
            c1ThemeController.SetTheme(rightPanel, "(default)");
            rightPanel.WrapContents = false;
            // 
            // displayOptionTitle
            // 
            displayOptionTitle.AutoSize = true;
            displayOptionTitle.DefaultIconSize = new Size(20, 16);
            displayOptionTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            displayOptionTitle.Location = new Point(11, 11);
            displayOptionTitle.Name = "displayOptionTitle";
            displayOptionTitle.Size = new Size(281, 54);
            displayOptionTitle.TabIndex = 11;
            displayOptionTitle.Text = Properties.Resource.DisplayOptions;
            c1ThemeController.SetTheme(displayOptionTitle, "(default)");
            // 
            // showSelectedRowCheckbox
            // 
            showSelectedRowCheckbox.AutoSize = true;
            showSelectedRowCheckbox.Checked = true;
            showSelectedRowCheckbox.CheckState = CheckState.Checked;
            showSelectedRowCheckbox.Location = new Point(11, 137);
            showSelectedRowCheckbox.Name = "showSelectedRowCheckbox";
            showSelectedRowCheckbox.Size = new Size(204, 27);
            showSelectedRowCheckbox.TabIndex = 13;
            showSelectedRowCheckbox.Text = Properties.Resource.ShowSelectedRows;
            c1ThemeController.SetTheme(showSelectedRowCheckbox, "(default)");
            showSelectedRowCheckbox.Value = true;
            showSelectedRowCheckbox.CheckedChanged += ShowSelectedRow_CheckedChanged;
            // 
            // showFocusedRowCheckbox
            // 
            showFocusedRowCheckbox.AutoSize = true;
            showFocusedRowCheckbox.Checked = true;
            showFocusedRowCheckbox.CheckState = CheckState.Checked;
            showFocusedRowCheckbox.Location = new Point(11, 170);
            showFocusedRowCheckbox.Name = "showFocusedRowCheckbox";
            showFocusedRowCheckbox.Size = new Size(196, 27);
            showFocusedRowCheckbox.TabIndex = 12;
            showFocusedRowCheckbox.Text = Properties.Resource.ShowFocusedRow;
            c1ThemeController.SetTheme(showFocusedRowCheckbox, "(default)");
            showFocusedRowCheckbox.Value = true;
            showFocusedRowCheckbox.CheckedChanged += ShowFocusedRow_CheckedChanged;
            // 
            // showHighlightedRowCheckbox
            // 
            showHighlightedRowCheckbox.AutoSize = true;
            showHighlightedRowCheckbox.Location = new Point(11, 203);
            showHighlightedRowCheckbox.Name = "showHighlightedRowCheckbox";
            showHighlightedRowCheckbox.Size = new Size(384, 27);
            showHighlightedRowCheckbox.TabIndex = 14;
            showHighlightedRowCheckbox.Text = Properties.Resource.ShowHighlightedRows;
            c1ThemeController.SetTheme(showHighlightedRowCheckbox, "(default)");
            showHighlightedRowCheckbox.CheckedChanged += ShowHighlightedRow_CheckedChanged;
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = Properties.Resource.FeatureInfo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 823);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = Properties.Resource.ScrollbarAnnotationsTitle;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_flexGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)themeComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotKeysCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showScrollTipCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customAnnotation1Checkbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showErrorsCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showAnnotationsCheckbox).EndInit();
            bottomPanel.ResumeLayout(false);
            displayOptionPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)displayOptionTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)showSelectedRowCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showFocusedRowCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showHighlightedRowCheckbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid _flexGrid;
        private C1.Win.Themes.C1ThemeController c1ThemeController;
        private Panel topPanel;
        private Panel bottomPanel;
        private C1.Win.Input.C1CheckBox showErrorsCheckbox;
        private C1.Win.Input.C1CheckBox showAnnotationsCheckbox;
        private C1.Win.Input.C1CheckBox customAnnotation1Checkbox;
        private C1.Win.Input.C1CheckBox showScrollTipCheckbox;
        private C1.Win.Input.C1CheckBox hotKeysCheckbox;
        private FlowLayoutPanel rightPanel;
        private C1.Win.Input.C1Label displayOptionTitle;
        private C1.Win.Input.C1CheckBox showHighlightedRowCheckbox;
        private C1.Win.Input.C1CheckBox showSelectedRowCheckbox;
        private C1.Win.Input.C1CheckBox showFocusedRowCheckbox;
        private ToolTip toolTip;
        private Panel displayOptionPanel;
        private C1.Win.Input.C1ComboBox themeComboBox;
    }
}