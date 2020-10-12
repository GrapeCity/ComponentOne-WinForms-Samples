namespace ExcelLikeConditionalFormatting.Dialogs
{
    partial class SingleValueConditionalFormattingForm
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblWithText = new System.Windows.Forms.Label();
            this.cmbStylePreset = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.tlpEditorLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEditorLayout
            // 
            this.tlpEditorLayout.BackColor = System.Drawing.Color.White;
            this.tlpEditorLayout.ColumnCount = 3;
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEditorLayout.Controls.Add(this.tbValue, 0, 0);
            this.tlpEditorLayout.Controls.Add(this.lblWithText, 1, 0);
            this.tlpEditorLayout.Controls.Add(this.cmbStylePreset, 2, 0);
            this.tlpEditorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditorLayout.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tlpEditorLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tlpEditorLayout.Location = new System.Drawing.Point(0, 31);
            this.tlpEditorLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEditorLayout.Name = "tlpEditorLayout";
            this.tlpEditorLayout.RowCount = 1;
            this.tlpEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEditorLayout.Size = new System.Drawing.Size(478, 31);
            this.tlpEditorLayout.TabIndex = 1;
            this.themeController.SetTheme(this.tlpEditorLayout, "(default)");
            // 
            // tbValue
            // 
            this.tbValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbValue.Location = new System.Drawing.Point(3, 3);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(185, 25);
            this.tbValue.TabIndex = 0;
            this.themeController.SetTheme(this.tbValue, "(default)");
            // 
            // lblWithText
            // 
            this.lblWithText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWithText.AutoSize = true;
            this.lblWithText.BackColor = System.Drawing.Color.White;
            this.lblWithText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblWithText.Location = new System.Drawing.Point(194, 7);
            this.lblWithText.Name = "lblWithText";
            this.lblWithText.Size = new System.Drawing.Size(37, 17);
            this.lblWithText.TabIndex = 1;
            this.lblWithText.Text = "with";
            this.lblWithText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.themeController.SetTheme(this.lblWithText, "(default)");
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
            this.cmbStylePreset.Location = new System.Drawing.Point(237, 3);
            this.cmbStylePreset.Name = "cmbStylePreset";
            this.cmbStylePreset.Size = new System.Drawing.Size(238, 25);
            this.cmbStylePreset.TabIndex = 2;
            this.themeController.SetTheme(this.cmbStylePreset, "(default)");
            // 
            // SingleValueConditionalFormattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 101);
            this.EditorRowControl = this.tlpEditorLayout;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "SingleValueConditionalFormattingForm";
            this.Text = "SingleValueConditionalFormattingForm";
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.SingleValueConditionalFormattingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.tlpEditorLayout.ResumeLayout(false);
            this.tlpEditorLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEditorLayout;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblWithText;
        private System.Windows.Forms.ComboBox cmbStylePreset;
    }
}