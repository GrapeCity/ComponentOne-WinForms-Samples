namespace StockChart
{
    partial class ucSymbolSearchBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSymbolSearchBox));
            this.pnlText = new System.Windows.Forms.Panel();
            this.txtSymbol = new StockChart.AutoCompleteTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlText.Controls.Add(this.txtSymbol);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlText.Location = new System.Drawing.Point(0, 0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(5, 7, 0, 0);
            this.pnlText.Size = new System.Drawing.Size(180, 43);
            this.pnlText.TabIndex = 0;
            // 
            // txtSymbol
            // 
            this.txtSymbol.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("txtSymbol.AutoCompleteList")));
            this.txtSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.CaseSensitive = false;
            this.txtSymbol.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSymbol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol.ForeColor = System.Drawing.Color.White;
            this.txtSymbol.Location = new System.Drawing.Point(5, 7);
            this.txtSymbol.MinTypedCharacters = 2;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.SelectedIndex = -1;
            this.txtSymbol.Size = new System.Drawing.Size(170, 16);
            this.txtSymbol.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(180, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 43);
            this.panel5.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(91)))), ((int)(((byte)(130)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(91)))), ((int)(((byte)(130)))));
            this.btnAdd.Image = global::StockChart.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(190, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 43);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // ucSymbolSearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlText);
            this.Name = "ucSymbolSearchBox";
            this.Size = new System.Drawing.Size(230, 43);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlText;
        private AutoCompleteTextbox txtSymbol;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
    }
}
