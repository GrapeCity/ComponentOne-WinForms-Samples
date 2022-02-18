namespace GaugeDemo
{
    partial class PageBulletGraph
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c1BulletGraph1 = new C1.Win.Gauge.C1BulletGraph();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1BulletGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.tableLayoutPanel1);
            this.gaugePanel.Size = new System.Drawing.Size(576, 425);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1BulletGraph1;
            this.gaugeGrid.Size = new System.Drawing.Size(216, 430);
            // 
            // captionLabel
            // 
            this.captionLabel.Size = new System.Drawing.Size(576, 25);
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(580, 0);
            this.gridPanel.Size = new System.Drawing.Size(220, 450);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(576, 0);
            this.splitter1.Size = new System.Drawing.Size(4, 450);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.c1BulletGraph1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // c1BulletGraph1
            // 
            this.c1BulletGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1BulletGraph1.Location = new System.Drawing.Point(3, 130);
            this.c1BulletGraph1.Name = "c1BulletGraph1";
            this.c1BulletGraph1.Origin = double.NaN;
            this.c1BulletGraph1.Size = new System.Drawing.Size(570, 164);
            this.c1BulletGraph1.TabIndex = 0;
            this.c1BulletGraph1.Text = "c1BulletGraph1";
            this.c1BulletGraph1.Value = 50D;
            // 
            // PageBulletGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageBulletGraph";
            this.Size = new System.Drawing.Size(800, 450);
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1BulletGraph1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Gauge.C1BulletGraph c1BulletGraph1;
    }
}