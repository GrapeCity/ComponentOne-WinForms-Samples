namespace ExcelFormulas
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._gboxSave = new System.Windows.Forms.GroupBox();
            this.cbOpenXml = new System.Windows.Forms.CheckBox();
            this._radioDialog = new System.Windows.Forms.RadioButton();
            this._radioTemp = new System.Windows.Forms.RadioButton();
            this._cbPreview = new System.Windows.Forms.CheckBox();
            this._btCreate = new System.Windows.Forms.Button();
            this._gboxSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gboxSave
            // 
            this._gboxSave.Controls.Add(this.cbOpenXml);
            this._gboxSave.Controls.Add(this._radioDialog);
            this._gboxSave.Controls.Add(this._radioTemp);
            this._gboxSave.Controls.Add(this._cbPreview);
            this._gboxSave.Location = new System.Drawing.Point(12, 41);
            this._gboxSave.Name = "_gboxSave";
            this._gboxSave.Size = new System.Drawing.Size(323, 86);
            this._gboxSave.TabIndex = 8;
            this._gboxSave.TabStop = false;
            this._gboxSave.Text = "Result option";
            // 
            // cbOpenXml
            // 
            this.cbOpenXml.AutoSize = true;
            this.cbOpenXml.Location = new System.Drawing.Point(6, 42);
            this.cbOpenXml.Name = "cbOpenXml";
            this.cbOpenXml.Size = new System.Drawing.Size(183, 17);
            this.cbOpenXml.TabIndex = 12;
            this.cbOpenXml.Text = "Enable save to Open XML format";
            this.cbOpenXml.UseVisualStyleBackColor = true;
            // 
            // _radioDialog
            // 
            this._radioDialog.AutoSize = true;
            this._radioDialog.Location = new System.Drawing.Point(185, 19);
            this._radioDialog.Name = "_radioDialog";
            this._radioDialog.Size = new System.Drawing.Size(105, 17);
            this._radioDialog.TabIndex = 5;
            this._radioDialog.Text = "Use Save Dialog";
            this._radioDialog.UseVisualStyleBackColor = true;
            // 
            // _radioTemp
            // 
            this._radioTemp.AutoSize = true;
            this._radioTemp.Checked = true;
            this._radioTemp.Location = new System.Drawing.Point(6, 19);
            this._radioTemp.Name = "_radioTemp";
            this._radioTemp.Size = new System.Drawing.Size(109, 17);
            this._radioTemp.TabIndex = 3;
            this._radioTemp.TabStop = true;
            this._radioTemp.Text = "Use temporary file";
            this._radioTemp.UseVisualStyleBackColor = true;
            // 
            // _cbPreview
            // 
            this._cbPreview.AutoSize = true;
            this._cbPreview.Checked = true;
            this._cbPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbPreview.Location = new System.Drawing.Point(6, 63);
            this._cbPreview.Name = "_cbPreview";
            this._cbPreview.Size = new System.Drawing.Size(141, 17);
            this._cbPreview.TabIndex = 1;
            this._cbPreview.Text = "Automatic result preview";
            this._cbPreview.UseVisualStyleBackColor = true;
            // 
            // _btCreate
            // 
            this._btCreate.Location = new System.Drawing.Point(12, 6);
            this._btCreate.Name = "_btCreate";
            this._btCreate.Size = new System.Drawing.Size(323, 29);
            this._btCreate.TabIndex = 9;
            this._btCreate.Text = "Create Excel file with formulas";
            this._btCreate.UseVisualStyleBackColor = true;
            this._btCreate.Click += new System.EventHandler(this._btCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 139);
            this.Controls.Add(this._btCreate);
            this.Controls.Add(this._gboxSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel formulas sample";
            this._gboxSave.ResumeLayout(false);
            this._gboxSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gboxSave;
        private System.Windows.Forms.CheckBox cbOpenXml;
        private System.Windows.Forms.RadioButton _radioDialog;
        private System.Windows.Forms.RadioButton _radioTemp;
        private System.Windows.Forms.CheckBox _cbPreview;
        private System.Windows.Forms.Button _btCreate;
    }
}

