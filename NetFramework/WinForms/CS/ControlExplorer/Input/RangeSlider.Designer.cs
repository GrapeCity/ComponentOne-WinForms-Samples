namespace ControlExplorer.Input
{
    partial class RangeSlider
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
            this.c1RangeSlider1 = new C1.Win.C1Input.C1RangeSlider();
            this.c1RangeSlider2 = new C1.Win.C1Input.C1RangeSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.c1RangeSlider1.LargeChange = 5D;
            this.c1RangeSlider1.Location = new System.Drawing.Point(23, 19);
            this.c1RangeSlider1.LowerValue = 0D;
            this.c1RangeSlider1.Maximum = 100D;
            this.c1RangeSlider1.Minimum = 0D;
            this.c1RangeSlider1.Name = "c1RangeSlider1";
            this.c1RangeSlider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.c1RangeSlider1.Size = new System.Drawing.Size(36, 610);
            this.c1RangeSlider1.TabIndex = 1;
            this.c1RangeSlider1.Text = "c1RangeSlider1";
            this.c1RangeSlider1.UpperValue = 100D;
            this.c1RangeSlider1.LowerValueChanged += new System.EventHandler(this.c1RangeSlider1_LowerValueChanged);
            this.c1RangeSlider1.UpperValueChanged += new System.EventHandler(this.c1RangeSlider1_UpperValueChanged);
            // 
            // c1RangeSlider2
            // 
            this.c1RangeSlider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1RangeSlider2.LargeChange = 5D;
            this.c1RangeSlider2.Location = new System.Drawing.Point(15, 671);
            this.c1RangeSlider2.LowerValue = 10D;
            this.c1RangeSlider2.Margin = new System.Windows.Forms.Padding(15);
            this.c1RangeSlider2.Maximum = 100D;
            this.c1RangeSlider2.Minimum = 0D;
            this.c1RangeSlider2.Name = "c1RangeSlider2";
            this.c1RangeSlider2.Size = new System.Drawing.Size(1003, 37);
            this.c1RangeSlider2.TabIndex = 2;
            this.c1RangeSlider2.Text = "c1RangeSlider2";
            this.c1RangeSlider2.UpperValue = 90D;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upper value";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1RangeSlider2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 723);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1RangeSlider1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 650);
            this.panel1.TabIndex = 0;
            // 
            // RangeSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RangeSlider";
            this.Text = "RangeSlider";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1RangeSlider c1RangeSlider1;
        private C1.Win.C1Input.C1RangeSlider c1RangeSlider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}