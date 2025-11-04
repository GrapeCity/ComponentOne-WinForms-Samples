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
            sampleDescription = new C1.Win.Input.C1Label();
            sampleTitle = new C1.Win.Input.C1Label();
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
            ((System.ComponentModel.ISupportInitialize)sampleDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampleTitle).BeginInit();
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
            _flexGrid.Name = "_flexGrid";
            _flexGrid.Size = new Size(1396, 844);
            _flexGrid.TabIndex = 0;
            _flexGrid.Tree.Indent = 18;
            // 
            // c1ThemeController
            // 
            c1ThemeController.Theme = "(none)";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(sampleDescription);
            topPanel.Controls.Add(sampleTitle);
            topPanel.Controls.Add(themeComboBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(5);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(2000, 210);
            topPanel.TabIndex = 3;
            c1ThemeController.SetTheme(topPanel, "(default)");
            // 
            // sampleDescription
            // 
            sampleDescription.Font = new Font("Segoe UI", 12F);
            sampleDescription.Location = new Point(29, 122);
            sampleDescription.MaximumSize = new Size(4001, 99);
            sampleDescription.Name = "sampleDescription";
            sampleDescription.Size = new Size(4001, 67);
            sampleDescription.TabIndex = 13;
            sampleDescription.Text = Properties.Resource.ScrollbarAnnotationsDescription;
            c1ThemeController.SetTheme(sampleDescription, "(default)");
            // 
            // sampleTitle
            // 
            sampleTitle.AutoSize = true;
            sampleTitle.DefaultIconSize = new Size(20, 16);
            sampleTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            sampleTitle.Location = new Point(29, 51);
            sampleTitle.Name = "sampleTitle";
            sampleTitle.Size = new Size(696, 74);
            sampleTitle.TabIndex = 12;
            sampleTitle.Text = Properties.Resource.ScrollbarAnnotationsTitle;
            c1ThemeController.SetTheme(sampleTitle, "(default)");
            // 
            // themeComboBox
            // 
            themeComboBox.Anchor = AnchorStyles.Right;
            themeComboBox.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            themeComboBox.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            themeComboBox.Location = new Point(1581, 74);
            themeComboBox.Name = "themeComboBox";
            themeComboBox.ReadOnly = true;
            themeComboBox.Size = new Size(396, 40);
            themeComboBox.TabIndex = 14;
            c1ThemeController.SetTheme(themeComboBox, "(default)");
            themeComboBox.SelectedIndexChanged += CmbThemes_SelectedIndexChanged;
            // 
            // hotKeysCheckbox
            // 
            hotKeysCheckbox.AutoSize = true;
            hotKeysCheckbox.Location = new Point(13, 357);
            hotKeysCheckbox.Name = "hotKeysCheckbox";
            hotKeysCheckbox.Size = new Size(298, 38);
            hotKeysCheckbox.TabIndex = 10;
            hotKeysCheckbox.Text = Properties.Resource.Hotkeys;
            c1ThemeController.SetTheme(hotKeysCheckbox, "(default)");
            hotKeysCheckbox.CheckedChanged += HotKeys_CheckedChanged;
            // 
            // showScrollTipCheckbox
            // 
            showScrollTipCheckbox.AutoSize = true;
            showScrollTipCheckbox.Location = new Point(13, 401);
            showScrollTipCheckbox.Name = "showScrollTipCheckbox";
            showScrollTipCheckbox.Size = new Size(264, 38);
            showScrollTipCheckbox.TabIndex = 9;
            showScrollTipCheckbox.Text = "Show Scroll ToolTip";
            c1ThemeController.SetTheme(showScrollTipCheckbox, "(default)");
            showScrollTipCheckbox.CheckedChanged += ShowScrollTip_CheckedChanged;
            // 
            // customAnnotation1Checkbox
            // 
            customAnnotation1Checkbox.AutoSize = true;
            customAnnotation1Checkbox.Location = new Point(13, 313);
            customAnnotation1Checkbox.Name = "customAnnotation1Checkbox";
            customAnnotation1Checkbox.Size = new Size(546, 38);
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
            showErrorsCheckbox.Location = new Point(13, 137);
            showErrorsCheckbox.Name = "showErrorsCheckbox";
            showErrorsCheckbox.Size = new Size(181, 38);
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
            showAnnotationsCheckbox.Location = new Point(13, 93);
            showAnnotationsCheckbox.Name = "showAnnotationsCheckbox";
            showAnnotationsCheckbox.Size = new Size(250, 38);
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
            bottomPanel.Location = new Point(0, 210);
            bottomPanel.Margin = new Padding(5);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(2000, 844);
            bottomPanel.TabIndex = 4;
            c1ThemeController.SetTheme(bottomPanel, "(default)");
            // 
            // displayOptionPanel
            // 
            displayOptionPanel.Controls.Add(rightPanel);
            displayOptionPanel.Dock = DockStyle.Right;
            displayOptionPanel.Location = new Point(1396, 0);
            displayOptionPanel.Name = "displayOptionPanel";
            displayOptionPanel.Size = new Size(604, 844);
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
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.Size = new Size(604, 844);
            rightPanel.TabIndex = 1;
            c1ThemeController.SetTheme(rightPanel, "(default)");
            rightPanel.WrapContents = false;
            // 
            // displayOptionTitle
            // 
            displayOptionTitle.AutoSize = true;
            displayOptionTitle.DefaultIconSize = new Size(20, 16);
            displayOptionTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            displayOptionTitle.Location = new Point(13, 13);
            displayOptionTitle.Name = "displayOptionTitle";
            displayOptionTitle.Size = new Size(382, 74);
            displayOptionTitle.TabIndex = 11;
            displayOptionTitle.Text = Properties.Resource.DisplayOptions;
            c1ThemeController.SetTheme(displayOptionTitle, "(default)");
            // 
            // showSelectedRowCheckbox
            // 
            showSelectedRowCheckbox.AutoSize = true;
            showSelectedRowCheckbox.Checked = true;
            showSelectedRowCheckbox.CheckState = CheckState.Checked;
            showSelectedRowCheckbox.Location = new Point(13, 181);
            showSelectedRowCheckbox.Name = "showSelectedRowCheckbox";
            showSelectedRowCheckbox.Size = new Size(273, 38);
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
            showFocusedRowCheckbox.Location = new Point(13, 225);
            showFocusedRowCheckbox.Name = "showFocusedRowCheckbox";
            showFocusedRowCheckbox.Size = new Size(260, 38);
            showFocusedRowCheckbox.TabIndex = 12;
            showFocusedRowCheckbox.Text = Properties.Resource.ShowFocusedRow;
            c1ThemeController.SetTheme(showFocusedRowCheckbox, "(default)");
            showFocusedRowCheckbox.Value = true;
            showFocusedRowCheckbox.CheckedChanged += ShowFocusedRow_CheckedChanged;
            // 
            // showHighlightedRowCheckbox
            // 
            showHighlightedRowCheckbox.AutoSize = true;
            showHighlightedRowCheckbox.Location = new Point(13, 269);
            showHighlightedRowCheckbox.Name = "showHighlightedRowCheckbox";
            showHighlightedRowCheckbox.Size = new Size(520, 38);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1054);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = Properties.Resource.ScrollbarAnnotations;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_flexGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sampleDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampleTitle).EndInit();
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
        private C1.Win.Input.C1Label sampleDescription;
        private C1.Win.Input.C1Label sampleTitle;
        private C1.Win.Input.C1CheckBox showHighlightedRowCheckbox;
        private C1.Win.Input.C1CheckBox showSelectedRowCheckbox;
        private C1.Win.Input.C1CheckBox showFocusedRowCheckbox;
        private ToolTip toolTip;
        private Panel displayOptionPanel;
        private C1.Win.Input.C1ComboBox themeComboBox;
    }
}