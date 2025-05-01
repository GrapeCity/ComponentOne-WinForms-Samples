
namespace ControlExplorer.BitmapSample
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c1PictureBox1 = new C1.Win.C1Input.C1PictureBox();
            this.richTextBox1 = new C1.Win.C1Input.C1TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 336);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.c1PictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 336);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // c1PictureBox1
            // 
            this.c1PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.c1PictureBox1.Name = "c1PictureBox1";
            this.c1PictureBox1.Size = new System.Drawing.Size(244, 150);
            this.c1PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c1PictureBox1.TabIndex = 0;
            this.c1PictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 159);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(244, 174);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Tag = null;
            this.richTextBox1.TextDetached = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 336);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Sample";
            this.Size = new System.Drawing.Size(478, 336);
            this.Load += new System.EventHandler(this.Sample_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.C1Input.C1PictureBox c1PictureBox1;
        private C1.Win.C1Input.C1TextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
