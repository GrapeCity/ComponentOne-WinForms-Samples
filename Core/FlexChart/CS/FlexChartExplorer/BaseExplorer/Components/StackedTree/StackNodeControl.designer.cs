using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    partial class StackNodeControl
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
            lblText = new System.Windows.Forms.Label();
            childPanel = new System.Windows.Forms.FlowLayoutPanel();
            mainPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pbChevron = new C1.Win.Input.C1PictureBox();
            pnlPB = new System.Windows.Forms.Panel();
            pbMain = new C1.Win.Input.C1PictureBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbChevron).BeginInit();
            pnlPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblText);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(50, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(250, 60);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += OnFlowLayoutPanelPaint;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = System.Drawing.Color.Transparent;
            lblText.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblText.ForeColor = System.Drawing.Color.FromArgb(32, 32, 48);
            lblText.Location = new System.Drawing.Point(0, 13);
            lblText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            lblText.Name = "lblText";
            lblText.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            lblText.Size = new System.Drawing.Size(57, 28);
            lblText.TabIndex = 2;
            lblText.Text = "label1";
            lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childPanel
            // 
            childPanel.AutoSize = true;
            childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            childPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            childPanel.Location = new System.Drawing.Point(0, 60);
            childPanel.Margin = new System.Windows.Forms.Padding(0);
            childPanel.Name = "childPanel";
            childPanel.Size = new System.Drawing.Size(315, 100);
            childPanel.TabIndex = 3;
            childPanel.WrapContents = false;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(flowLayoutPanel1);
            mainPanel.Controls.Add(pnlPB);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(10, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(300, 60);
            mainPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(pbChevron);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(270, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            panel1.Size = new System.Drawing.Size(30, 60);
            panel1.TabIndex = 3;
            // 
            // pbChevron
            // 
            pbChevron.Location = new System.Drawing.Point(9, 24);
            pbChevron.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            pbChevron.Name = "pbChevron";
            pbChevron.Size = new System.Drawing.Size(12, 12);
            pbChevron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbChevron.TabIndex = 0;
            pbChevron.TabStop = false;
            // 
            // pnlPB
            // 
            pnlPB.BackColor = System.Drawing.Color.Transparent;
            pnlPB.Controls.Add(pbMain);
            pnlPB.Dock = System.Windows.Forms.DockStyle.Left;
            pnlPB.Location = new System.Drawing.Point(0, 0);
            pnlPB.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            pnlPB.Name = "pnlPB";
            pnlPB.Padding = new System.Windows.Forms.Padding(4, 12, 4, 12);
            pnlPB.Size = new System.Drawing.Size(50, 60);
            pnlPB.TabIndex = 1;
            // 
            // pbMain
            // 
            pbMain.Location = new System.Drawing.Point(17, 21);
            pbMain.Margin = new System.Windows.Forms.Padding(9);
            pbMain.Name = "pbMain";
            pbMain.Size = new System.Drawing.Size(18, 18);
            pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbMain.TabIndex = 0;
            pbMain.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(mainPanel, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(315, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // StackNodeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(childPanel);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(0);
            MinimumSize = new System.Drawing.Size(0, 40);
            Name = "StackNodeControl";
            Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            Size = new System.Drawing.Size(320, 160);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbChevron).EndInit();
            pnlPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel childPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1PictureBox pbMain;
        private C1.Win.Input.C1PictureBox pbChevron;
    }
}
