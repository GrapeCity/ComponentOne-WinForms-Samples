namespace PrintTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonTemplateSource = new System.Windows.Forms.RadioButton();
            this.radioButtonPreview = new System.Windows.Forms.RadioButton();
            this.radioButtonSource = new System.Windows.Forms.RadioButton();
            this.radioButtonDesign = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printing Template";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Template1.htm: A Minimal Template (Print Preview Only)",
            "Template2.htm: Minimal Template Supporting Printing",
            "Template3.htm: Dynamic Creation of LayoutRects (Preview Only)",
            "Template4.htm: Adding Headers and Footers 1 (Preview Only)",
            "Template5.htm: Adding Headers and Footers 2 (Preview Only)",
            "Template6.htm: Reading from Page Setup/Synchronizing Threads",
            "Template7.htm: Building a User Interface",
            "Template8.htm: Adjustable Margin UI"});
            this.comboBox1.Location = new System.Drawing.Point(200, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 392);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(13, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Print w/o Prompt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(13, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Print with Prompt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(13, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.radioButtonTemplateSource);
            this.panel3.Controls.Add(this.radioButtonPreview);
            this.panel3.Controls.Add(this.radioButtonSource);
            this.panel3.Controls.Add(this.radioButtonDesign);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 41);
            this.panel3.TabIndex = 2;
            // 
            // radioButtonTemplateSource
            // 
            this.radioButtonTemplateSource.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTemplateSource.AutoSize = true;
            this.radioButtonTemplateSource.FlatAppearance.BorderSize = 0;
            this.radioButtonTemplateSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonTemplateSource.Location = new System.Drawing.Point(214, 7);
            this.radioButtonTemplateSource.Name = "radioButtonTemplateSource";
            this.radioButtonTemplateSource.Size = new System.Drawing.Size(98, 23);
            this.radioButtonTemplateSource.TabIndex = 4;
            this.radioButtonTemplateSource.Text = "Template Source";
            this.radioButtonTemplateSource.UseVisualStyleBackColor = true;
            this.radioButtonTemplateSource.CheckedChanged += new System.EventHandler(this.radioButtonPreview_CheckedChanged);
            // 
            // radioButtonPreview
            // 
            this.radioButtonPreview.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPreview.AutoSize = true;
            this.radioButtonPreview.Checked = true;
            this.radioButtonPreview.FlatAppearance.BorderSize = 0;
            this.radioButtonPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPreview.Location = new System.Drawing.Point(123, 7);
            this.radioButtonPreview.Name = "radioButtonPreview";
            this.radioButtonPreview.Size = new System.Drawing.Size(55, 23);
            this.radioButtonPreview.TabIndex = 3;
            this.radioButtonPreview.TabStop = true;
            this.radioButtonPreview.Text = "Preview";
            this.radioButtonPreview.UseVisualStyleBackColor = true;
            this.radioButtonPreview.CheckedChanged += new System.EventHandler(this.radioButtonPreview_CheckedChanged);
            // 
            // radioButtonSource
            // 
            this.radioButtonSource.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSource.AutoSize = true;
            this.radioButtonSource.FlatAppearance.BorderSize = 0;
            this.radioButtonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSource.Location = new System.Drawing.Point(64, 7);
            this.radioButtonSource.Name = "radioButtonSource";
            this.radioButtonSource.Size = new System.Drawing.Size(51, 23);
            this.radioButtonSource.TabIndex = 2;
            this.radioButtonSource.Text = "Source";
            this.radioButtonSource.UseVisualStyleBackColor = true;
            this.radioButtonSource.CheckedChanged += new System.EventHandler(this.radioButtonPreview_CheckedChanged);
            // 
            // radioButtonDesign
            // 
            this.radioButtonDesign.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDesign.AutoSize = true;
            this.radioButtonDesign.FlatAppearance.BorderSize = 0;
            this.radioButtonDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDesign.Location = new System.Drawing.Point(6, 7);
            this.radioButtonDesign.Name = "radioButtonDesign";
            this.radioButtonDesign.Size = new System.Drawing.Size(50, 23);
            this.radioButtonDesign.TabIndex = 1;
            this.radioButtonDesign.Text = "Design";
            this.radioButtonDesign.UseVisualStyleBackColor = true;
            this.radioButtonDesign.CheckedChanged += new System.EventHandler(this.radioButtonPreview_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(200, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(428, 351);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // c1Editor1
            // 
            this.c1Editor1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Editor1.XmlExtensions = null;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(200, 51);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.WordWrap = true;
            this.c1Editor1.Size = new System.Drawing.Size(428, 351);
            this.c1Editor1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 443);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.c1Editor1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.C1Editor.C1Editor c1Editor1;
        private System.Windows.Forms.RadioButton radioButtonDesign;
        private System.Windows.Forms.RadioButton radioButtonPreview;
        private System.Windows.Forms.RadioButton radioButtonSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonTemplateSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

