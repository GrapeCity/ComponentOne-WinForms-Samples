namespace ControlExplorer.RulesManager.Dialogs
{
    partial class BaseConditionalFormattingForm
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
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblOperationText = new System.Windows.Forms.Label();
            this.tlpButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpMainLayout.SuspendLayout();
            this.tlpButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMainLayout.Controls.Add(this.lblOperationText, 0, 0);
            this.tlpMainLayout.Controls.Add(this.tlpButtonsLayout, 0, 2);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tlpMainLayout.Location = new System.Drawing.Point(3, 4);
            this.tlpMainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 3;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.Size = new System.Drawing.Size(478, 93);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // lblOperationText
            // 
            this.lblOperationText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOperationText.AutoSize = true;
            this.lblOperationText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationText.Location = new System.Drawing.Point(0, 7);
            this.lblOperationText.Margin = new System.Windows.Forms.Padding(0);
            this.lblOperationText.Name = "lblOperationText";
            this.lblOperationText.Size = new System.Drawing.Size(74, 17);
            this.lblOperationText.TabIndex = 0;
            this.lblOperationText.Text = "Operation:";
            // 
            // tlpButtonsLayout
            // 
            this.tlpButtonsLayout.ColumnCount = 4;
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpButtonsLayout.Controls.Add(this.btnOk, 1, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnCancel, 3, 0);
            this.tlpButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsLayout.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tlpButtonsLayout.Location = new System.Drawing.Point(0, 62);
            this.tlpButtonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonsLayout.Name = "tlpButtonsLayout";
            this.tlpButtonsLayout.RowCount = 1;
            this.tlpButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtonsLayout.Size = new System.Drawing.Size(478, 31);
            this.tlpButtonsLayout.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(286, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(385, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BaseConditionalFormattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 101);
            this.Controls.Add(this.tlpMainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseConditionalFormattingForm";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseConditionalFormattingForm";
            this.Load += new System.EventHandler(this.BaseConditionalFormattingForm_Load);
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpMainLayout.PerformLayout();
            this.tlpButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOperationText;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsLayout;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.TableLayoutPanel tlpMainLayout;
    }
}