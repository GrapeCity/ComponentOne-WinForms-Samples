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
            this.c1OlapPage1 = new C1.Win.Olap.C1OlapPage();
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(304, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 15);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // c1OlapPage1
            // 
            this.c1OlapPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1OlapPage1.Location = new System.Drawing.Point(0, 0);
            this.c1OlapPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1OlapPage1.Name = "c1OlapPage1";
            this.c1OlapPage1.Size = new System.Drawing.Size(825, 449);
            this.c1OlapPage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 449);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.c1OlapPage1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Olap.C1OlapPage c1OlapPage1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

