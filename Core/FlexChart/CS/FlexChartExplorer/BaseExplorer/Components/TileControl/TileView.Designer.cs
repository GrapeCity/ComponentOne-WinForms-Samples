namespace BaseExplorer.Components
{
    partial class TileView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblCardName = new System.Windows.Forms.Label();
            pnlPB = new System.Windows.Forms.Panel();
            picBox = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1.SuspendLayout();
            pnlPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblCardName, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlPB, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(230, 220);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCardName
            // 
            lblCardName.AutoSize = true;
            lblCardName.BackColor = System.Drawing.Color.Transparent;
            lblCardName.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCardName.Location = new System.Drawing.Point(3, 188);
            lblCardName.Margin = new System.Windows.Forms.Padding(3);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new System.Drawing.Size(224, 29);
            lblCardName.TabIndex = 1;
            lblCardName.Text = "Card Name";
            lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPB
            // 
            pnlPB.Controls.Add(picBox);
            pnlPB.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlPB.Location = new System.Drawing.Point(3, 3);
            pnlPB.Name = "pnlPB";
            pnlPB.Padding = new System.Windows.Forms.Padding(5);
            pnlPB.Size = new System.Drawing.Size(224, 179);
            pnlPB.TabIndex = 2;
            pnlPB.Paint += panel1_Paint;
            // 
            // picBox
            // 
            picBox.BackColor = System.Drawing.Color.Transparent;
            picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            picBox.Location = new System.Drawing.Point(5, 5);
            picBox.Margin = new System.Windows.Forms.Padding(0);
            picBox.Name = "picBox";
            picBox.Size = new System.Drawing.Size(214, 169);
            picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picBox.TabIndex = 2;
            picBox.TabStop = false;
            // 
            // TileView
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "TileView";
            Size = new System.Drawing.Size(230, 220);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Panel pnlPB;
        private System.Windows.Forms.PictureBox picBox;
    }
}
