namespace RichTextEditor
{
    partial class InsertSymbol
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
            this._btnInsert = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._panel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._focusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnInsert
            // 
            this._btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnInsert.Location = new System.Drawing.Point(282, 321);
            this._btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this._btnInsert.Name = "_btnInsert";
            this._btnInsert.Size = new System.Drawing.Size(100, 28);
            this._btnInsert.TabIndex = 4;
            this._btnInsert.Text = "&Insert";
            this._btnInsert.Enabled = false;
            this._btnInsert.UseVisualStyleBackColor = true;
            this._btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Location = new System.Drawing.Point(390, 321);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(100, 28);
            this._btnClose.TabIndex = 5;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // _panel
            // 
            this._panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._panel.AutoScroll = true;
            this._panel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._panel.Location = new System.Drawing.Point(16, 31);
            this._panel.Margin = new System.Windows.Forms.Padding(4);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(473, 277);
            this._panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select symbol, then click Insert:";
            // 
            // _lblDescription
            // 
            this._lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblDescription.AutoSize = true;
            this._lblDescription.Location = new System.Drawing.Point(13, 321);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(0, 17);
            this._lblDescription.TabIndex = 3;
            // 
            // _focusBox
            // 
            this._focusBox.Location = new System.Drawing.Point(634, 6);
            this._focusBox.Name = "_focusBox";
            this._focusBox.Size = new System.Drawing.Size(100, 22);
            this._focusBox.TabIndex = 2;
            this._focusBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._focusBox_KeyDown);
            // 
            // InsertSymbolDialog
            // 
            this.AcceptButton = this._btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this._focusBox);
            this.Controls.Add(this._lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnInsert);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertSymbolDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert Symbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnInsert;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.FlowLayoutPanel _panel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.TextBox _focusBox;
    }
}