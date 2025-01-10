using System.Windows.Forms;

namespace ControlExplorer.Contrlols
{
    partial class TileCard
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
            panel1 = new Panel();
            picBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCardName = new Label();
            lblDesc = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picBox);
            panel1.Location = new System.Drawing.Point(20, 15);
            panel1.Margin = new Padding(20, 15, 0, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(96, 230);
            panel1.TabIndex = 0;
            // 
            // picBox
            // 
            picBox.Location = new System.Drawing.Point(4, 54);
            picBox.Margin = new Padding(4, 5, 4, 5);
            picBox.Name = "picBox";
            picBox.Size = new System.Drawing.Size(99, 104);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblCardName);
            flowLayoutPanel1.Controls.Add(lblDesc);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(130, 15);
            flowLayoutPanel1.Margin = new Padding(14, 15, 14, 15);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(510, 230);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // lblCardName
            // 
            lblCardName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblCardName.Location = new System.Drawing.Point(4, 0);
            lblCardName.Margin = new Padding(4, 0, 4, 0);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new System.Drawing.Size(496, 68);
            lblCardName.TabIndex = 2;
            lblCardName.Text = "label1";
            lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDesc.Location = new System.Drawing.Point(4, 68);
            lblDesc.Margin = new Padding(4, 0, 4, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(78, 32);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(654, 260);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            // 
            // TileCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(6, 28, 18, 10);
            Name = "TileCard";
            Size = new System.Drawing.Size(654, 260);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDesc;
        private Label lblCardName;
        private PictureBox picBox;
    }
}
