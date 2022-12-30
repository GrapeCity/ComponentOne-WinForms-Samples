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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyFilterCheckBox = new C1.Win.Input.C1CheckBox();
            this.EditButton = new C1.Win.Input.C1Button();
            this.CloseButton = new C1.Win.Input.C1Button();
            this.FilterSummaryCombo = new C1.Win.Input.C1ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyFilterCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterSummaryCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ApplyFilterCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilterSummaryCombo, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ApplyFilterCheckBox
            // 
            this.ApplyFilterCheckBox.AutoSize = true;
            this.ApplyFilterCheckBox.Checked = true;
            this.ApplyFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ApplyFilterCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyFilterCheckBox.Location = new System.Drawing.Point(33, 3);
            this.ApplyFilterCheckBox.Name = "ApplyFilterCheckBox";
            this.ApplyFilterCheckBox.Size = new System.Drawing.Size(24, 24);
            this.ApplyFilterCheckBox.TabIndex = 1;
            this.ApplyFilterCheckBox.Value = true;
            this.ApplyFilterCheckBox.CheckedChanged += new System.EventHandler(this.ApplyFilterCheckBox_CheckedChanged);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.Location = new System.Drawing.Point(723, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(74, 24);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit filter";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Icon = new C1.Framework.C1PathIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Red, null);
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.Styles.Default.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FilterSummaryCombo
            // 
            this.FilterSummaryCombo.AutoSuggestMode = C1.Win.Input.AutoSuggestMode.Contains;
            this.FilterSummaryCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterSummaryCombo.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.FilterSummaryCombo.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            this.FilterSummaryCombo.Location = new System.Drawing.Point(63, 3);
            this.FilterSummaryCombo.Name = "FilterSummaryCombo";
            this.FilterSummaryCombo.Placeholder = "Previously applied filters";
            this.FilterSummaryCombo.Size = new System.Drawing.Size(654, 24);
            this.FilterSummaryCombo.TabIndex = 5;
            this.FilterSummaryCombo.SelectedIndexChanged += new System.EventHandler(this.FilterSummaryCombo_SelectedIndexChanged);
            // 
            // FilterEditorSummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);            
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterEditorSummaryPanel";
            this.Size = new System.Drawing.Size(800, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyFilterCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterSummaryCombo)).EndInit();
            this.ResumeLayout(false);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1CheckBox ApplyFilterCheckBox;
        private C1.Win.Input.C1Button EditButton;
        private C1.Win.Input.C1Button CloseButton;
        private C1.Win.Input.C1ComboBox FilterSummaryCombo;
    }
}
