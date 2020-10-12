namespace ExcelLikeConditionalFormatting.Dialogs
{
    partial class BetweenForm
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
            this.tlpEditorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tbMinimumValue = new System.Windows.Forms.TextBox();
            this.tbMaximumValue = new System.Windows.Forms.TextBox();
            this.cmbStylePreset = new System.Windows.Forms.ComboBox();
            this.lblAndText = new System.Windows.Forms.Label();
            this.lblWithText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.tlpEditorLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEditorLayout
            // 
            this.tlpEditorLayout.BackColor = System.Drawing.Color.White;
            this.tlpEditorLayout.ColumnCount = 5;
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpEditorLayout.Controls.Add(this.tbMinimumValue, 0, 0);
            this.tlpEditorLayout.Controls.Add(this.tbMaximumValue, 2, 0);
            this.tlpEditorLayout.Controls.Add(this.cmbStylePreset, 4, 0);
            this.tlpEditorLayout.Controls.Add(this.lblAndText, 1, 0);
            this.tlpEditorLayout.Controls.Add(this.lblWithText, 3, 0);
            this.tlpEditorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditorLayout.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tlpEditorLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tlpEditorLayout.Location = new System.Drawing.Point(0, 31);
            this.tlpEditorLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEditorLayout.Name = "tlpEditorLayout";
            this.tlpEditorLayout.RowCount = 1;
            this.tlpEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpEditorLayout.Size = new System.Drawing.Size(632, 31);
            this.tlpEditorLayout.TabIndex = 1;
            this.themeController.SetTheme(this.tlpEditorLayout, "(default)");
            // 
            // tbMinimumValue
            // 
            this.tbMinimumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinimumValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbMinimumValue.Location = new System.Drawing.Point(3, 3);
            this.tbMinimumValue.Name = "tbMinimumValue";
            this.tbMinimumValue.Size = new System.Drawing.Size(164, 25);
            this.tbMinimumValue.TabIndex = 0;
            this.themeController.SetTheme(this.tbMinimumValue, "(default)");
            // 
            // tbMaximumValue
            // 
            this.tbMaximumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaximumValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbMaximumValue.Location = new System.Drawing.Point(210, 3);
            this.tbMaximumValue.Name = "tbMaximumValue";
            this.tbMaximumValue.Size = new System.Drawing.Size(164, 25);
            this.tbMaximumValue.TabIndex = 1;
            this.themeController.SetTheme(this.tbMaximumValue, "(default)");
            // 
            // cmbStylePreset
            // 
            this.cmbStylePreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStylePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStylePreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbStylePreset.FormattingEnabled = true;
            this.cmbStylePreset.Items.AddRange(new object[] {
            "Light Red Fill with Dark Red Text",
            "Yellow Fill with Dark Yellow Text",
            "Green Fill with Dark Green Text",
            "Light Red Fill",
            "Red Text",
            "Red Border"});
            this.cmbStylePreset.Location = new System.Drawing.Point(417, 3);
            this.cmbStylePreset.Name = "cmbStylePreset";
            this.cmbStylePreset.Size = new System.Drawing.Size(212, 25);
            this.cmbStylePreset.TabIndex = 2;
            this.themeController.SetTheme(this.cmbStylePreset, "(default)");
            // 
            // lblAndText
            // 
            this.lblAndText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAndText.AutoSize = true;
            this.lblAndText.BackColor = System.Drawing.Color.White;
            this.lblAndText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblAndText.Location = new System.Drawing.Point(173, 7);
            this.lblAndText.Name = "lblAndText";
            this.lblAndText.Size = new System.Drawing.Size(31, 17);
            this.lblAndText.TabIndex = 3;
            this.lblAndText.Text = "and";
            this.lblAndText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.themeController.SetTheme(this.lblAndText, "(default)");
            // 
            // lblWithText
            // 
            this.lblWithText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWithText.AutoSize = true;
            this.lblWithText.BackColor = System.Drawing.Color.White;
            this.lblWithText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblWithText.Location = new System.Drawing.Point(380, 7);
            this.lblWithText.Name = "lblWithText";
            this.lblWithText.Size = new System.Drawing.Size(31, 17);
            this.lblWithText.TabIndex = 4;
            this.lblWithText.Text = "with";
            this.lblWithText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.themeController.SetTheme(this.lblWithText, "(default)");
            // 
            // BetweenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 101);
            this.ConditionalOperationText = "Format cells that are BETWEEN:";
            this.EditorRowControl = this.tlpEditorLayout;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "BetweenForm";
            this.Text = "Between";
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.BetweenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.tlpEditorLayout.ResumeLayout(false);
            this.tlpEditorLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEditorLayout;
        private System.Windows.Forms.TextBox tbMinimumValue;
        private System.Windows.Forms.TextBox tbMaximumValue;
        private System.Windows.Forms.ComboBox cmbStylePreset;
        private System.Windows.Forms.Label lblAndText;
        private System.Windows.Forms.Label lblWithText;
    }
}