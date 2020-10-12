namespace C1dView
{
    partial class ZoomDialog
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
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt100 = new System.Windows.Forms.RadioButton();
            this.rbtFitWindow = new System.Windows.Forms.RadioButton();
            this.rbtFitWidth = new System.Windows.Forms.RadioButton();
            this.rbtFitTextWidth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.chkContinuous = new System.Windows.Forms.CheckBox();
            this.chkFacing = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            this.SuspendLayout();
            // 
            // numZoom
            // 
            this.numZoom.Location = new System.Drawing.Point(84, 12);
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(92, 20);
            this.numZoom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom %:";
            // 
            // rbt100
            // 
            this.rbt100.AutoSize = true;
            this.rbt100.Location = new System.Drawing.Point(6, 19);
            this.rbt100.Name = "rbt100";
            this.rbt100.Size = new System.Drawing.Size(51, 17);
            this.rbt100.TabIndex = 0;
            this.rbt100.TabStop = true;
            this.rbt100.Text = "100%";
            this.rbt100.UseVisualStyleBackColor = true;
            // 
            // rbtFitWindow
            // 
            this.rbtFitWindow.AutoSize = true;
            this.rbtFitWindow.Location = new System.Drawing.Point(6, 42);
            this.rbtFitWindow.Name = "rbtFitWindow";
            this.rbtFitWindow.Size = new System.Drawing.Size(78, 17);
            this.rbtFitWindow.TabIndex = 1;
            this.rbtFitWindow.TabStop = true;
            this.rbtFitWindow.Text = "Fit Window";
            this.rbtFitWindow.UseVisualStyleBackColor = true;
            // 
            // rbtFitWidth
            // 
            this.rbtFitWidth.AutoSize = true;
            this.rbtFitWidth.Location = new System.Drawing.Point(6, 65);
            this.rbtFitWidth.Name = "rbtFitWidth";
            this.rbtFitWidth.Size = new System.Drawing.Size(67, 17);
            this.rbtFitWidth.TabIndex = 2;
            this.rbtFitWidth.TabStop = true;
            this.rbtFitWidth.Text = "Fit Width";
            this.rbtFitWidth.UseVisualStyleBackColor = true;
            // 
            // rbtFitTextWidth
            // 
            this.rbtFitTextWidth.AutoSize = true;
            this.rbtFitTextWidth.Location = new System.Drawing.Point(6, 88);
            this.rbtFitTextWidth.Name = "rbtFitTextWidth";
            this.rbtFitTextWidth.Size = new System.Drawing.Size(91, 17);
            this.rbtFitTextWidth.TabIndex = 3;
            this.rbtFitTextWidth.TabStop = true;
            this.rbtFitTextWidth.Text = "Fit Text Width";
            this.rbtFitTextWidth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFitWidth);
            this.groupBox1.Controls.Add(this.rbtFitTextWidth);
            this.groupBox1.Controls.Add(this.rbt100);
            this.groupBox1.Controls.Add(this.rbtFitWindow);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Zoom";
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(117, 38);
            this.numRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(59, 20);
            this.numRows.TabIndex = 3;
            this.numRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Page Rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page Columns:";
            // 
            // numCols
            // 
            this.numCols.Location = new System.Drawing.Point(117, 64);
            this.numCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(59, 20);
            this.numCols.TabIndex = 5;
            this.numCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkContinuous
            // 
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(15, 113);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(79, 17);
            this.chkContinuous.TabIndex = 7;
            this.chkContinuous.Text = "Continuous";
            this.chkContinuous.UseVisualStyleBackColor = true;
            // 
            // chkFacing
            // 
            this.chkFacing.AutoSize = true;
            this.chkFacing.Location = new System.Drawing.Point(15, 90);
            this.chkFacing.Name = "chkFacing";
            this.chkFacing.Size = new System.Drawing.Size(168, 17);
            this.chkFacing.TabIndex = 6;
            this.chkFacing.Text = "Facing Pages, Cover on Right";
            this.chkFacing.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(259, 138);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "&Close";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // ZoomDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(346, 173);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkFacing);
            this.Controls.Add(this.chkContinuous);
            this.Controls.Add(this.numCols);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZoomDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoom";
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt100;
        private System.Windows.Forms.RadioButton rbtFitWindow;
        private System.Windows.Forms.RadioButton rbtFitWidth;
        private System.Windows.Forms.RadioButton rbtFitTextWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCols;
        private System.Windows.Forms.CheckBox chkContinuous;
        private System.Windows.Forms.CheckBox chkFacing;
        private System.Windows.Forms.Button btnOk;
    }
}