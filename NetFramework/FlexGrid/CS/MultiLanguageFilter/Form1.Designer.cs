namespace MultiLanguageFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flex = new C1.Win.FlexGrid.C1FlexGrid();
            this._cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
            this.SuspendLayout();
            // 
            // flex
            // 
            this.flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flex.ColumnInfo = "10,1,0,0,0,130,Columns:";
            this.flex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flex.Location = new System.Drawing.Point(12, 41);
            this.flex.Name = "flex";
            this.flex.Rows.DefaultSize = 26;
            this.flex.Size = new System.Drawing.Size(591, 231);
            this.flex.StyleInfo = resources.GetString("flex.StyleInfo");
            this.flex.TabIndex = 0;
            // 
            // _cmbLanguage
            // 
            this._cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbLanguage.FormattingEnabled = true;
            this._cmbLanguage.Items.AddRange(new object[] {
            "English (en)",
            "German (de)",
            "Spanish (es)",
            "Portuguese (pt)",
            "Italian (it)",
            "French (fr)",
            "Dutch (nl)",
            "Russian (ru)",
            "Japanese (ja)",
            "Slovak (sk)",
            "Czech (cs)",
            "Greek (el)",
            "Danish (da)",
            "Finnish (fi)",
            "Norwegian (no)",
            "Swedish (sv)"});
            this._cmbLanguage.Location = new System.Drawing.Point(186, 12);
            this._cmbLanguage.Name = "_cmbLanguage";
            this._cmbLanguage.Size = new System.Drawing.Size(224, 40);
            this._cmbLanguage.TabIndex = 1;
            this._cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Filter Language:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbLanguage);
            this.Controls.Add(this.flex);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Switch Filter Language at Runtime";
            ((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid flex;
        private System.Windows.Forms.ComboBox _cmbLanguage;
        private System.Windows.Forms.Label label1;
    }
}

