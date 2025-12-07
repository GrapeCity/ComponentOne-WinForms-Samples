namespace ExtendedFeatures
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSamples = new System.Windows.Forms.TableLayoutPanel();
            this.panelSample = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sampleHeader = new System.Windows.Forms.Label();
            this.sampleDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelSamples, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSample, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sampleHeader, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sampleDescription, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSamples
            // 
            this.panelSamples.ColumnCount = 1;
            this.panelSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSamples.Location = new System.Drawing.Point(1, 32);
            this.panelSamples.Margin = new System.Windows.Forms.Padding(0);
            this.panelSamples.Name = "panelSamples";
            this.panelSamples.RowCount = 1;
            this.tableLayoutPanel1.SetRowSpan(this.panelSamples, 3);
            this.panelSamples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSamples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.panelSamples.Size = new System.Drawing.Size(180, 408);
            this.panelSamples.TabIndex = 0;
            // 
            // panelSample
            // 
            this.panelSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSample.Location = new System.Drawing.Point(185, 167);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(595, 270);
            this.panelSample.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extended FlexChart Features";
            // 
            // sampleHeader
            // 
            this.sampleHeader.AutoSize = true;
            this.sampleHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleHeader.Location = new System.Drawing.Point(185, 32);
            this.sampleHeader.Name = "sampleHeader";
            this.sampleHeader.Size = new System.Drawing.Size(595, 50);
            this.sampleHeader.TabIndex = 3;
            this.sampleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sampleDescription
            // 
            this.sampleDescription.BackColor = System.Drawing.SystemColors.Control;
            this.sampleDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleDescription.Location = new System.Drawing.Point(194, 86);
            this.sampleDescription.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.sampleDescription.Name = "sampleDescription";
            this.sampleDescription.Size = new System.Drawing.Size(586, 74);
            this.sampleDescription.TabIndex = 4;
            this.sampleDescription.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "ExtendedFeatures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel panelSamples;
        private System.Windows.Forms.Panel panelSample;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sampleHeader;
        private System.Windows.Forms.RichTextBox sampleDescription;
    }
}

