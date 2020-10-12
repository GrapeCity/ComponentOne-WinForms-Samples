namespace StockPortfolio
{
    partial class StockPortfolioContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPortfolioContainer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadingBackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.LoadingPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 611);
            this.panel1.TabIndex = 0;
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.Location = new System.Drawing.Point(459, 191);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Size = new System.Drawing.Size(200, 158);
            this.LoadingPictureBox.TabIndex = 0;
            this.LoadingPictureBox.TabStop = false;
            this.LoadingPictureBox.Visible = false;
            // 
            // LoadingBackGroundWorker
            // 
            this.LoadingBackGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadingBackGroundWorker_DoWork);
            this.LoadingBackGroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadingBackGroundWorker_RunWorkerCompleted);
            // 
            // StockPortfolioContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StockPortfolioContainer";
            this.Text = "Stock Portfolio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockPortfolioContainer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LoadingPictureBox;
        private System.ComponentModel.BackgroundWorker LoadingBackGroundWorker;


    }
}

