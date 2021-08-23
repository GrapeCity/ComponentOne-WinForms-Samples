namespace DemoTables
{
    partial class QueryCount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.nRows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nCols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCols)).BeginInit();
            this.SuspendLayout();
// 
// nRows
// 
            this.nRows.Location = new System.Drawing.Point(267, 32);
            this.nRows.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nRows.Name = "nRows";
            this.nRows.TabIndex = 0;
            this.nRows.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
// 
// label1
// 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the number of rows in the table:";
// 
// button1
// 
            this.button1.Location = new System.Drawing.Point(312, 116);
            this.button1.Name = "button1";
            this.button1.TabIndex = 2;
            this.button1.Text = "Go!";
            this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// label2
// 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the number of columns in the table:";
// 
// nCols
// 
            this.nCols.Location = new System.Drawing.Point(267, 65);
            this.nCols.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nCols.Name = "nCols";
            this.nCols.TabIndex = 3;
            this.nCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
// 
// QueryCount
// 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(399, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nCols);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QueryCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QueryCount";
            ((System.ComponentModel.ISupportInitialize)(this.nRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown nRows;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nCols;
    }
}