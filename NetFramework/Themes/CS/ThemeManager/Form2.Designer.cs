namespace ThemeManager
{
    partial class Form2
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
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.btnCloneForm = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.Location = new System.Drawing.Point(12, 9);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(168, 87);
            this.c1Label1.TabIndex = 3;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "This form demonstrates\r\nthat changing ApplicationTheme\r\non a single C1ThemeContro" +
    "ller\r\nin an application automatically\r\npropagates to all forms with\r\ntheme contr" +
    "ollers on them.";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.UseCompatibleTextRendering = true;
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.ObjectThemeApplied += new C1.Win.Themes.ObjectThemeEventHandler(this.c1ThemeController1_ObjectThemeApplied);
            // 
            // btnCloneForm
            // 
            this.btnCloneForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloneForm.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnCloneForm.Location = new System.Drawing.Point(12, 227);
            this.btnCloneForm.Name = "btnCloneForm";
            this.btnCloneForm.Size = new System.Drawing.Size(128, 23);
            this.btnCloneForm.TabIndex = 6;
            this.btnCloneForm.Text = "Clone this form";
            this.c1ThemeController1.SetTheme(this.btnCloneForm, "(default)");
            this.btnCloneForm.UseVisualStyleBackColor = true;
            this.btnCloneForm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCloneForm.Click += new System.EventHandler(this.btnCloneForm_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCloneForm);
            this.Controls.Add(this.c1Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Test Form";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Input.C1Button btnCloneForm;
    }
}