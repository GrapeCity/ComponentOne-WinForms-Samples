namespace FlexPivotExplorer.Samples
{
    partial class CubeAnalysis
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
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.lbWaiting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(391, 233);
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
            this.c1FlexPivotPage1.Size = new System.Drawing.Size(786, 449);
            this.c1FlexPivotPage1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexPivotPage1, "(default)");
            // 
            // lbWaiting
            // 
            this.lbWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWaiting.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWaiting.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbWaiting.Location = new System.Drawing.Point(0, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(786, 449);
            this.lbWaiting.TabIndex = 2;
            this.lbWaiting.Text = "Please wait ...";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CubeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbWaiting);
            this.Controls.Add(this.c1FlexPivotPage1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CubeAnalysis";
            this.Size = new System.Drawing.Size(786, 449);
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.CubeAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage c1FlexPivotPage1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Label lbWaiting;
    }
}

