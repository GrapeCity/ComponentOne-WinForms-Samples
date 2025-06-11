namespace CubeAnalysis
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.c1FlexPivotPage1 = new C1.Win.FlexPivot.FlexPivotPage();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1ThemePicker1 = new C1.Win.C1Themes.C1ThemePicker();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemePicker1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(417, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 15);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // c1FlexPivotPage1
            // 
            this.c1FlexPivotPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotPage1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1FlexPivotPage1.Name = "c1FlexPivotPage1";
            this.c1FlexPivotPage1.Size = new System.Drawing.Size(1087, 700);
            this.c1FlexPivotPage1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexPivotPage1, "(default)");
            this.c1FlexPivotPage1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
            // 
            // c1ThemePicker1
            // 
            this.c1ThemePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.c1ThemePicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ThemePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1ThemePicker1.Location = new System.Drawing.Point(887, 0);
            this.c1ThemePicker1.Name = "c1ThemePicker1";
            this.c1ThemePicker1.Size = new System.Drawing.Size(200, 26);
            this.c1ThemePicker1.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.c1ThemePicker1, "(default)");
            this.c1ThemePicker1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 700);
            this.Controls.Add(this.c1ThemePicker1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.c1FlexPivotPage1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cube Analysis";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemePicker1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage c1FlexPivotPage1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Themes.C1ThemePicker c1ThemePicker1;
    }
}

