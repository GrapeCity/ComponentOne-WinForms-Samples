namespace StockChart.Controls
{
    partial class ucTitlebar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchBox = new StockChart.ucSymbolSearchBox();
            this.stockLabel = new StockChart.Controls.StockLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Controls.Add(this.stockLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(800, 44);
            this.panel2.TabIndex = 1;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtSearchBox.ButtonImage = global::StockChart.Properties.Resources.search;
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(565, 5);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Placeholder = "Go to symbol";
            this.txtSearchBox.Size = new System.Drawing.Size(230, 34);
            this.txtSearchBox.TabIndex = 15;
            // 
            // stockLabel
            // 
            this.stockLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.stockLabel.CausesValidation = false;
            this.stockLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stockLabel.Difference = 0D;
            this.stockLabel.DiffFont = new System.Drawing.Font("Segoe UI", 12F);
            this.stockLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stockLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stockLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockLabel.Location = new System.Drawing.Point(5, 5);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.NameFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stockLabel.Price = 0D;
            this.stockLabel.PriceFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.stockLabel.Size = new System.Drawing.Size(483, 34);
            this.stockLabel.StockName = null;
            this.stockLabel.TabIndex = 1;
            // 
            // ucTitlebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Name = "ucTitlebar";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Size = new System.Drawing.Size(800, 64);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private StockLabel stockLabel;
        private ucSymbolSearchBox txtSearchBox;
    }
}
