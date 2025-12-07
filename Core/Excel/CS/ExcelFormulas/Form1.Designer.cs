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
            _gboxSave = new System.Windows.Forms.GroupBox();
            cbOpenXml = new System.Windows.Forms.CheckBox();
            _radioDialog = new System.Windows.Forms.RadioButton();
            _radioTemp = new System.Windows.Forms.RadioButton();
            _cbPreview = new System.Windows.Forms.CheckBox();
            _btCreate = new System.Windows.Forms.Button();
            _gboxSave.SuspendLayout();
            SuspendLayout();
            // 
            // _gboxSave
            // 
            _gboxSave.Controls.Add(cbOpenXml);
            _gboxSave.Controls.Add(_radioDialog);
            _gboxSave.Controls.Add(_radioTemp);
            _gboxSave.Controls.Add(_cbPreview);
            _gboxSave.Location = new System.Drawing.Point(26, 101);
            _gboxSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _gboxSave.Name = "_gboxSave";
            _gboxSave.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _gboxSave.Size = new System.Drawing.Size(699, 211);
            _gboxSave.TabIndex = 8;
            _gboxSave.TabStop = false;
            _gboxSave.Text = "Result option";
            // 
            // cbOpenXml
            // 
            cbOpenXml.AutoSize = true;
            cbOpenXml.Checked = true;
            cbOpenXml.CheckState = System.Windows.Forms.CheckState.Checked;
            cbOpenXml.Location = new System.Drawing.Point(13, 104);
            cbOpenXml.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbOpenXml.Name = "cbOpenXml";
            cbOpenXml.Size = new System.Drawing.Size(398, 36);
            cbOpenXml.TabIndex = 12;
            cbOpenXml.Text = "Enable save to Open XML format";
            cbOpenXml.UseVisualStyleBackColor = true;
            // 
            // _radioDialog
            // 
            _radioDialog.AutoSize = true;
            _radioDialog.Location = new System.Drawing.Point(400, 47);
            _radioDialog.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _radioDialog.Name = "_radioDialog";
            _radioDialog.Size = new System.Drawing.Size(217, 36);
            _radioDialog.TabIndex = 5;
            _radioDialog.Text = "Use Save Dialog";
            _radioDialog.UseVisualStyleBackColor = true;
            // 
            // _radioTemp
            // 
            _radioTemp.AutoSize = true;
            _radioTemp.Checked = true;
            _radioTemp.Location = new System.Drawing.Point(13, 47);
            _radioTemp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _radioTemp.Name = "_radioTemp";
            _radioTemp.Size = new System.Drawing.Size(241, 36);
            _radioTemp.TabIndex = 3;
            _radioTemp.TabStop = true;
            _radioTemp.Text = "Use temporary file";
            _radioTemp.UseVisualStyleBackColor = true;
            // 
            // _cbPreview
            // 
            _cbPreview.AutoSize = true;
            _cbPreview.Checked = true;
            _cbPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            _cbPreview.Location = new System.Drawing.Point(13, 155);
            _cbPreview.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _cbPreview.Name = "_cbPreview";
            _cbPreview.Size = new System.Drawing.Size(311, 36);
            _cbPreview.TabIndex = 1;
            _cbPreview.Text = "Automatic result preview";
            _cbPreview.UseVisualStyleBackColor = true;
            // 
            // _btCreate
            // 
            _btCreate.Location = new System.Drawing.Point(26, 15);
            _btCreate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            _btCreate.Name = "_btCreate";
            _btCreate.Size = new System.Drawing.Size(699, 72);
            _btCreate.TabIndex = 9;
            _btCreate.Text = "Create Excel file with formulas";
            _btCreate.UseVisualStyleBackColor = true;
            _btCreate.Click += _btCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 342);
            Controls.Add(_btCreate);
            Controls.Add(_gboxSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Excel formulas sample";
            _gboxSave.ResumeLayout(false);
            _gboxSave.PerformLayout();
            ResumeLayout(false);

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

