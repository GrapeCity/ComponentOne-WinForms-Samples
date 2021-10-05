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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCardName = new System.Windows.Forms.Label();
            this.pnlPB = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblCardName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPB, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 220);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.BackColor = System.Drawing.Color.White;
            this.lblCardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(3, 193);
            this.lblCardName.Margin = new System.Windows.Forms.Padding(3);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(224, 24);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "Card Name";
            this.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPB
            // 
            this.pnlPB.Controls.Add(this.picBox);
            this.pnlPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPB.Location = new System.Drawing.Point(3, 3);
            this.pnlPB.Name = "pnlPB";
            this.pnlPB.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPB.Size = new System.Drawing.Size(224, 184);
            this.pnlPB.TabIndex = 2;
            this.pnlPB.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(5, 5);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(214, 174);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // TileView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TileView";
            this.Size = new System.Drawing.Size(230, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Panel pnlPB;
        private System.Windows.Forms.PictureBox picBox;
    }
}
