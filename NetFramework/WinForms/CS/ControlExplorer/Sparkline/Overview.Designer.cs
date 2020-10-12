namespace ControlExplorer.Sparkline
{
    partial class Overview
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
            this.lineSparkline = new C1.Win.Sparkline.C1Sparkline();
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.columnSparkline = new C1.Win.Sparkline.C1Sparkline();
            this.winLossSparkline = new C1.Win.Sparkline.C1Sparkline();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.tlpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineSparkline
            // 
            this.lineSparkline.Location = new System.Drawing.Point(33, 52);
            this.lineSparkline.Name = "lineSparkline";
            this.lineSparkline.Size = new System.Drawing.Size(420, 132);
            this.lineSparkline.TabIndex = 0;
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 2;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayout.Controls.Add(this.lineSparkline, 1, 2);
            this.tlpLayout.Controls.Add(this.columnSparkline, 1, 5);
            this.tlpLayout.Controls.Add(this.winLossSparkline, 1, 8);
            this.tlpLayout.Controls.Add(this.lblLine, 1, 1);
            this.tlpLayout.Controls.Add(this.lblColumn, 1, 4);
            this.tlpLayout.Controls.Add(this.lblWinLoss, 1, 7);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 10;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpLayout.Size = new System.Drawing.Size(1174, 708);
            this.tlpLayout.TabIndex = 1;
            // 
            // columnSparkline
            // 
            this.columnSparkline.Location = new System.Drawing.Point(33, 270);
            this.columnSparkline.Name = "columnSparkline";
            this.columnSparkline.Size = new System.Drawing.Size(420, 132);
            this.columnSparkline.SparklineType = C1.Win.Sparkline.SparklineType.Column;
            this.columnSparkline.TabIndex = 1;
            // 
            // winLossSparkline
            // 
            this.winLossSparkline.Location = new System.Drawing.Point(33, 488);
            this.winLossSparkline.Name = "winLossSparkline";
            this.winLossSparkline.Size = new System.Drawing.Size(420, 132);
            this.winLossSparkline.SparklineType = C1.Win.Sparkline.SparklineType.WinLoss;
            this.winLossSparkline.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(33, 29);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(43, 20);
            this.lblLine.TabIndex = 3;
            this.lblLine.Text = "Line";
            // 
            // lblColumn
            // 
            this.lblColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(33, 247);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(69, 20);
            this.lblColumn.TabIndex = 4;
            this.lblColumn.Text = "Column";
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWinLoss.AutoSize = true;
            this.lblWinLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoss.Location = new System.Drawing.Point(33, 465);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(77, 20);
            this.lblWinLoss.TabIndex = 5;
            this.lblWinLoss.Text = "WinLoss";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1174, 708);
            this.Controls.Add(this.tlpLayout);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Sparkline.C1Sparkline lineSparkline;
        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private C1.Win.Sparkline.C1Sparkline columnSparkline;
        private C1.Win.Sparkline.C1Sparkline winLossSparkline;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblWinLoss;
    }
}