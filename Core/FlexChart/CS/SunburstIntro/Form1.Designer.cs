namespace SunburstIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pnlSamples = new System.Windows.Forms.TableLayoutPanel();
            richTextBoxSampleDescription = new System.Windows.Forms.RichTextBox();
            panelSample = new System.Windows.Forms.Panel();
            labelSampleHeader = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlSamples, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxSampleDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(panelSample, 1, 3);
            tableLayoutPanel1.Controls.Add(labelSampleHeader, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(924, 601);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlSamples
            // 
            pnlSamples.ColumnCount = 1;
            pnlSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pnlSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSamples.Location = new System.Drawing.Point(1, 86);
            pnlSamples.Margin = new System.Windows.Forms.Padding(0);
            pnlSamples.Name = "pnlSamples";
            pnlSamples.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(pnlSamples, 3);
            pnlSamples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pnlSamples.Size = new System.Drawing.Size(180, 514);
            pnlSamples.TabIndex = 2;
            // 
            // richTextBoxSampleDescription
            // 
            richTextBoxSampleDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxSampleDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxSampleDescription.Location = new System.Drawing.Point(185, 141);
            richTextBoxSampleDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBoxSampleDescription.Name = "richTextBoxSampleDescription";
            richTextBoxSampleDescription.ReadOnly = true;
            richTextBoxSampleDescription.Size = new System.Drawing.Size(735, 72);
            richTextBoxSampleDescription.TabIndex = 3;
            richTextBoxSampleDescription.Text = "";
            // 
            // panelSample
            // 
            panelSample.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSample.Location = new System.Drawing.Point(185, 222);
            panelSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelSample.Name = "panelSample";
            panelSample.Size = new System.Drawing.Size(735, 374);
            panelSample.TabIndex = 4;
            // 
            // labelSampleHeader
            // 
            labelSampleHeader.AutoSize = true;
            labelSampleHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSampleHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            labelSampleHeader.Location = new System.Drawing.Point(185, 86);
            labelSampleHeader.Name = "labelSampleHeader";
            labelSampleHeader.Size = new System.Drawing.Size(735, 50);
            labelSampleHeader.TabIndex = 5;
            labelSampleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(922, 84);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 16);
            pictureBox1.Margin = new System.Windows.Forms.Padding(16, 16, 0, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Location = new System.Drawing.Point(69, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new System.Drawing.Size(209, 78);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            label1.Location = new System.Drawing.Point(0, 2);
            label1.Margin = new System.Windows.Forms.Padding(0, 2, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(206, 44);
            label1.TabIndex = 0;
            label1.Text = "Sunburst 101";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(8, 46);
            label2.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Introduction to Sunburst chart.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(924, 601);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 9.75F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sunburst 101";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlSamples;
        private System.Windows.Forms.RichTextBox richTextBoxSampleDescription;
        private System.Windows.Forms.Panel panelSample;
        private System.Windows.Forms.Label labelSampleHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

