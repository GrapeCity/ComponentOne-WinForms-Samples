namespace C1WordsX
{
    partial class InsertDateTime
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
            this._btnInsert = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _btnInsert
            // 
            this._btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnInsert.Location = new System.Drawing.Point(115, 321);
            this._btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this._btnInsert.Name = "_btnInsert";
            this._btnInsert.Size = new System.Drawing.Size(100, 28);
            this._btnInsert.TabIndex = 4;
            this._btnInsert.Text = "&OK";
            this._btnInsert.UseVisualStyleBackColor = true;
            this._btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Location = new System.Drawing.Point(223, 321);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(100, 28);
            this._btnClose.TabIndex = 5;
            this._btnClose.Text = "Cancel";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Available formats:";
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
            // _list
            // 
            this._list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._list.FormattingEnabled = true;
            this._list.IntegralHeight = false;
            this._list.ItemHeight = 16;
            this._list.Location = new System.Drawing.Point(12, 29);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(311, 285);
            this._list.TabIndex = 6;
            // 
            // InsertDateTime
            // 
            this.AcceptButton = this._btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(335, 364);
            this.Controls.Add(this._list);
            this.Controls.Add(this._lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertDateTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date and Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnInsert;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.ListBox _list;
    }
}