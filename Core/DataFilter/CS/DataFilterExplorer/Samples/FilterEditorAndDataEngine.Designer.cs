namespace DataFilterExplorer.Samples
{
    partial class FilterEditorAndDataEngine
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
            if (disposing)
                _view.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SamplePanel = new System.Windows.Forms.Panel();
            LeftPanel = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label10 = new System.Windows.Forms.Label();
            lblTotalCount = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label11 = new System.Windows.Forms.Label();
            lblFilteredCount = new System.Windows.Forms.Label();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label12 = new System.Windows.Forms.Label();
            lblTotalLoadTime = new System.Windows.Forms.Label();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            label13 = new System.Windows.Forms.Label();
            lblFilteredTime = new System.Windows.Forms.Label();
            LeftPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // SamplePanel
            // 
            SamplePanel.BackColor = System.Drawing.Color.White;
            SamplePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SamplePanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            SamplePanel.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            SamplePanel.Location = new System.Drawing.Point(161, 0);
            SamplePanel.Name = "SamplePanel";
            SamplePanel.Size = new System.Drawing.Size(0, 150);
            SamplePanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = System.Drawing.Color.White;
            LeftPanel.Controls.Add(tableLayoutPanel1);
            LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            LeftPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            LeftPanel.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            LeftPanel.Location = new System.Drawing.Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new System.Drawing.Size(161, 150);
            LeftPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 5);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(161, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(lblTotalCount);
            flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(148, 29);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.White;
            label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label10.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label10.Location = new System.Drawing.Point(0, 0);
            label10.Margin = new System.Windows.Forms.Padding(0);
            label10.Name = "label10";
            label10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label10.Size = new System.Drawing.Size(123, 29);
            label10.TabIndex = 3;
            label10.Text = "Total rows:";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.BackColor = System.Drawing.Color.White;
            lblTotalCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            lblTotalCount.Location = new System.Drawing.Point(123, 0);
            lblTotalCount.Margin = new System.Windows.Forms.Padding(0);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new System.Drawing.Size(25, 29);
            lblTotalCount.TabIndex = 4;
            lblTotalCount.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            flowLayoutPanel2.Controls.Add(label11);
            flowLayoutPanel2.Controls.Add(lblFilteredCount);
            flowLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            flowLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(150, 58);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label11.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label11.Location = new System.Drawing.Point(0, 0);
            label11.Margin = new System.Windows.Forms.Padding(0);
            label11.Name = "label11";
            label11.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label11.Size = new System.Drawing.Size(150, 29);
            label11.TabIndex = 3;
            label11.Text = "Filtered rows:";
            // 
            // lblFilteredCount
            // 
            lblFilteredCount.AutoSize = true;
            lblFilteredCount.BackColor = System.Drawing.Color.White;
            lblFilteredCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            lblFilteredCount.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            lblFilteredCount.Location = new System.Drawing.Point(0, 29);
            lblFilteredCount.Margin = new System.Windows.Forms.Padding(0);
            lblFilteredCount.Name = "lblFilteredCount";
            lblFilteredCount.Size = new System.Drawing.Size(25, 29);
            lblFilteredCount.TabIndex = 4;
            lblFilteredCount.Text = "0";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            flowLayoutPanel3.Controls.Add(label12);
            flowLayoutPanel3.Controls.Add(lblTotalLoadTime);
            flowLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            flowLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 112);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(144, 58);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label12.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label12.Location = new System.Drawing.Point(0, 0);
            label12.Margin = new System.Windows.Forms.Padding(0);
            label12.Name = "label12";
            label12.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label12.Size = new System.Drawing.Size(119, 58);
            label12.TabIndex = 4;
            label12.Text = "Load data time:";
            // 
            // lblTotalLoadTime
            // 
            lblTotalLoadTime.AutoSize = true;
            lblTotalLoadTime.BackColor = System.Drawing.Color.White;
            lblTotalLoadTime.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            lblTotalLoadTime.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            lblTotalLoadTime.Location = new System.Drawing.Point(119, 0);
            lblTotalLoadTime.Margin = new System.Windows.Forms.Padding(0);
            lblTotalLoadTime.Name = "lblTotalLoadTime";
            lblTotalLoadTime.Size = new System.Drawing.Size(25, 29);
            lblTotalLoadTime.TabIndex = 5;
            lblTotalLoadTime.Text = "0";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            flowLayoutPanel4.Controls.Add(label13);
            flowLayoutPanel4.Controls.Add(lblFilteredTime);
            flowLayoutPanel4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            flowLayoutPanel4.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 176);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(147, 58);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.White;
            label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label13.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label13.Location = new System.Drawing.Point(0, 0);
            label13.Margin = new System.Windows.Forms.Padding(0);
            label13.Name = "label13";
            label13.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label13.Size = new System.Drawing.Size(147, 29);
            label13.TabIndex = 5;
            label13.Text = "Filtered time:";
            // 
            // lblFilteredTime
            // 
            lblFilteredTime.AutoSize = true;
            lblFilteredTime.BackColor = System.Drawing.Color.White;
            lblFilteredTime.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            lblFilteredTime.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            lblFilteredTime.Location = new System.Drawing.Point(0, 29);
            lblFilteredTime.Margin = new System.Windows.Forms.Padding(0);
            lblFilteredTime.Name = "lblFilteredTime";
            lblFilteredTime.Size = new System.Drawing.Size(25, 29);
            lblFilteredTime.TabIndex = 6;
            lblFilteredTime.Text = "0";
            // 
            // FilterEditorAndDataEngine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(SamplePanel);
            Controls.Add(LeftPanel);
            Name = "FilterEditorAndDataEngine";
            LeftPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel SamplePanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblFilteredCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblTotalLoadTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lblFilteredTime;
    }
}
