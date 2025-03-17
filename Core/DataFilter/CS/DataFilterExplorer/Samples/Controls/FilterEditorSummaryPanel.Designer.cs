namespace DataFilterExplorer.Samples.Controls
{
    partial class FilterEditorSummaryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ApplyFilterCheckBox = new C1.Win.Input.C1CheckBox();
            EditButton = new C1.Win.Input.C1Button();
            FilterSummaryCombo = new C1.Win.Input.C1ComboBox();
            CloseButton = new C1.Win.Input.C1Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ApplyFilterCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilterSummaryCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(ApplyFilterCheckBox, 1, 0);
            tableLayoutPanel1.Controls.Add(EditButton, 3, 0);
            tableLayoutPanel1.Controls.Add(FilterSummaryCombo, 2, 0);
            tableLayoutPanel1.Controls.Add(CloseButton, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 35);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ApplyFilterCheckBox
            // 
            ApplyFilterCheckBox.AutoSize = true;
            ApplyFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ApplyFilterCheckBox.Checked = true;
            ApplyFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            ApplyFilterCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ApplyFilterCheckBox.Location = new System.Drawing.Point(43, 3);
            ApplyFilterCheckBox.Name = "ApplyFilterCheckBox";
            ApplyFilterCheckBox.Size = new System.Drawing.Size(34, 29);
            ApplyFilterCheckBox.TabIndex = 1;
            ApplyFilterCheckBox.Value = true;
            ApplyFilterCheckBox.CheckedChanged += ApplyFilterCheckBox_CheckedChanged;
            // 
            // EditButton
            // 
            EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            EditButton.Location = new System.Drawing.Point(723, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(74, 29);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit filter";
            EditButton.Click += EditButton_Click;
            // 
            // FilterSummaryCombo
            // 
            FilterSummaryCombo.AutoSuggestMode = C1.Win.Input.AutoSuggestMode.Contains;
            FilterSummaryCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            FilterSummaryCombo.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            FilterSummaryCombo.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            FilterSummaryCombo.Location = new System.Drawing.Point(83, 3);
            FilterSummaryCombo.Name = "FilterSummaryCombo";
            FilterSummaryCombo.Placeholder = "Previously applied filters";
            FilterSummaryCombo.ReadOnly = true;
            FilterSummaryCombo.Size = new System.Drawing.Size(634, 23);
            FilterSummaryCombo.TabIndex = 5;
            FilterSummaryCombo.VerticalAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            FilterSummaryCombo.SelectedIndexChanged += FilterSummaryCombo_SelectedIndexChanged;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            CloseButton.AutoSize = true;
            CloseButton.Icon = new C1.Framework.C1PathIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Red, null, System.Drawing.Color.Transparent);
            CloseButton.Location = new System.Drawing.Point(8, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(24, 24);
            CloseButton.Styles.Default.ForeColor = System.Drawing.Color.Red;
            CloseButton.Styles.Font = new System.Drawing.Font("Segoe UI", 8F);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // FilterEditorSummaryPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Name = "FilterEditorSummaryPanel";
            Size = new System.Drawing.Size(800, 35);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ApplyFilterCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilterSummaryCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1CheckBox ApplyFilterCheckBox;
        private C1.Win.Input.C1Button EditButton;
        private C1.Win.Input.C1Button CloseButton;
        private C1.Win.Input.C1ComboBox FilterSummaryCombo;
    }
}
