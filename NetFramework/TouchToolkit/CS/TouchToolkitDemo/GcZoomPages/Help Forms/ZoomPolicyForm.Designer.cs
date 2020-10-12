namespace ClickOnceDemo.C1ZoomPages.Help_Forms
{
    partial class ZoomPolicyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C1ZoomPanel1 = new C1.Win.TouchToolKit.C1ZoomPanel();
            this.C1ZoomPanel2 = new C1.Win.TouchToolKit.C1ZoomPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 22, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please try zoom in the two touch rectangle by touch.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZoomPolicy is Enabled:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // C1ZoomPanel1
            // 
            this.C1ZoomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1ZoomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1ZoomPanel1.Location = new System.Drawing.Point(10, 94);
            this.C1ZoomPanel1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 11);
            this.C1ZoomPanel1.Name = "C1ZoomPanel1";
            this.C1ZoomPanel1.Size = new System.Drawing.Size(335, 359);
            this.C1ZoomPanel1.TabIndex = 3;
            // 
            // C1ZoomPanel2
            // 
            this.C1ZoomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1ZoomPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1ZoomPanel2.Location = new System.Drawing.Point(365, 94);
            this.C1ZoomPanel2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 11);
            this.C1ZoomPanel2.Name = "C1ZoomPanel2";
            this.C1ZoomPanel2.Size = new System.Drawing.Size(336, 359);
            this.C1ZoomPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.C1ZoomPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.C1ZoomPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 464);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(385, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "ZoomPolicy is Disabled:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ZoomPolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(727, 503);
            this.Name = "ZoomPolicyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZoomPolicyForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.TouchToolKit.C1ZoomPanel C1ZoomPanel1;
        private C1.Win.TouchToolKit.C1ZoomPanel C1ZoomPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}