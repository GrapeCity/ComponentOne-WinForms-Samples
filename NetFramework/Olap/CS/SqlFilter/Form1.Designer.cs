namespace SqlFilter
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
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
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
            this._c1OlapPage = new C1.Win.Olap.C1OlapPage();
            ((System.ComponentModel.ISupportInitialize)(this._c1OlapPage)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1OlapPage
            // 
            this._c1OlapPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1OlapPage.Location = new System.Drawing.Point(0, 0);
            this._c1OlapPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._c1OlapPage.Name = "_c1OlapPage";
            this._c1OlapPage.Size = new System.Drawing.Size(877, 429);
            this._c1OlapPage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 429);
            this.Controls.Add(this._c1OlapPage);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NorthWind Sales Data Analysis (Sql filtered)";
            ((System.ComponentModel.ISupportInitialize)(this._c1OlapPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Olap.C1OlapPage _c1OlapPage;
    }
}

