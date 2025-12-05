namespace CustomEditors
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
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.InputPanel.InputLabel();
            this.formBackColorEditor = new ColorEditorHost();
            this.inputLabel5 = new C1.Win.InputPanel.InputLabel();
            this.formForeColorEditor = new ColorEditorHost();
            this.inputLabel3 = new C1.Win.InputPanel.InputLabel();
            this.labelColorEditor = new ColorEditorHost();
            this.inputGroupHeader2 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel4 = new C1.Win.InputPanel.InputLabel();
            this.formFontEditor = new FontEditorHost();
            this.inputLabel2 = new C1.Win.InputPanel.InputLabel();
            this.labelFontEditor = new FontEditorHost();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.demoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.BorderThickness = 2;
            this.c1InputPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.formBackColorEditor);
            this.c1InputPanel1.Items.Add(this.inputLabel5);
            this.c1InputPanel1.Items.Add(this.formForeColorEditor);
            this.c1InputPanel1.Items.Add(this.inputLabel3);
            this.c1InputPanel1.Items.Add(this.labelColorEditor);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel1.Items.Add(this.inputLabel4);
            this.c1InputPanel1.Items.Add(this.formFontEditor);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.labelFontEditor);
            this.c1InputPanel1.Location = new System.Drawing.Point(12, 33);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(364, 200);
            this.c1InputPanel1.TabIndex = 0;
            this.c1InputPanel1.ControlHostFromXmlNode += new System.EventHandler<C1.Win.InputPanel.ControlHostFromXmlNodeEventArgs>(this.c1InputPanel1_ControlHostFromXmlNode);
            this.c1InputPanel1.ItemDeserialized += new System.EventHandler<C1.Win.InputPanel.ItemDeserializedEventArgs>(this.c1InputPanel1_ItemDeserialized);
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "Color Editor";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "Form BackColor:";
            this.inputLabel1.Width = 91;
            // 
            // formBackColorEditor
            // 
            this.formBackColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.formBackColorEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.formBackColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formBackColorEditor.Name = "formBackColorEditor";
            this.formBackColorEditor.Width = 237;
            this.formBackColorEditor.SelectedColorChanged += new System.EventHandler(this.formBackColorEditor_SelectedColorChanged);
            // 
            // inputLabel5
            // 
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "Form ForeColor:";
            this.inputLabel5.Width = 91;
            // 
            // formForeColorEditor
            // 
            this.formForeColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.formForeColorEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.formForeColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formForeColorEditor.Name = "formForeColorEditor";
            this.formForeColorEditor.Width = 237;
            this.formForeColorEditor.SelectedColorChanged += new System.EventHandler(this.formForeColorEditor_SelectedColorChanged);
            // 
            // inputLabel3
            // 
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Text = "Label Color:";
            this.inputLabel3.Width = 91;
            // 
            // labelColorEditor
            // 
            this.labelColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.labelColorEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelColorEditor.Name = "labelColorEditor";
            this.labelColorEditor.Width = 237;
            this.labelColorEditor.SelectedColorChanged += new System.EventHandler(this.labelColorEditor_SelectedColorChanged);
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "Font Editor";
            // 
            // inputLabel4
            // 
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = "Form Font:";
            this.inputLabel4.Width = 91;
            // 
            // formFontEditor
            // 
            this.formFontEditor.BackColor = System.Drawing.SystemColors.Window;
            this.formFontEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.formFontEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formFontEditor.Name = "formFontEditor";
            this.formFontEditor.Width = 236;
            this.formFontEditor.SelectedFontChanged += new System.EventHandler(this.formFontEditor_SelectedFontChanged);
            // 
            // inputLabel2
            // 
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "Label Font:";
            this.inputLabel2.Width = 91;
            // 
            // labelFontEditor
            // 
            this.labelFontEditor.BackColor = System.Drawing.SystemColors.Window;
            this.labelFontEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelFontEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelFontEditor.Name = "labelFontEditor";
            this.labelFontEditor.Width = 236;
            this.labelFontEditor.SelectedFontChanged += new System.EventHandler(this.labelFontEditor_SelectedFontChanged);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveXml.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveXml.Location = new System.Drawing.Point(122, 246);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(92, 23);
            this.btnSaveXml.TabIndex = 2;
            this.btnSaveXml.Text = "Save as XML";
            this.btnSaveXml.UseVisualStyleBackColor = false;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadXml.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadXml.Location = new System.Drawing.Point(284, 246);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(92, 23);
            this.btnLoadXml.TabIndex = 4;
            this.btnLoadXml.Text = "Load from XML";
            this.btnLoadXml.UseVisualStyleBackColor = false;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // demoLabel
            // 
            this.demoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.demoLabel.AutoSize = true;
            this.demoLabel.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.demoLabel.Location = new System.Drawing.Point(12, 246);
            this.demoLabel.Name = "demoLabel";
            this.demoLabel.Size = new System.Drawing.Size(82, 19);
            this.demoLabel.TabIndex = 1;
            this.demoLabel.Text = "Demo Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Color and Font editors based on UITypeEditors";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(220, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSaveXml;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLoadXml;
            this.ClientSize = new System.Drawing.Size(389, 281);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demoLabel);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.c1InputPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Form1";
            this.Text = "Custom Editors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.InputPanel.InputLabel inputLabel1;
        private ColorEditorHost formBackColorEditor;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadXml;
        private C1.Win.InputPanel.InputLabel inputLabel2;
        private FontEditorHost formFontEditor;
        private System.Windows.Forms.Label demoLabel;
        private C1.Win.InputPanel.InputLabel inputLabel3;
        private ColorEditorHost labelColorEditor;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.InputPanel.InputLabel inputLabel4;
        private FontEditorHost labelFontEditor;
        private C1.Win.InputPanel.InputLabel inputLabel5;
        private ColorEditorHost formForeColorEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}
