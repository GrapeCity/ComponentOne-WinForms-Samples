namespace FlexCalc
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
            this._formulaBar = new System.Windows.Forms.Panel();
            this._txtFormula = new System.Windows.Forms.TextBox();
            this._lblFx = new System.Windows.Forms.Label();
            this._lblAddress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._flex = new FlexCalc();
            this._formulaBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _formulaBar
            // 
            this._formulaBar.BackColor = System.Drawing.SystemColors.Window;
            this._formulaBar.Controls.Add(this._txtFormula);
            this._formulaBar.Controls.Add(this._lblFx);
            this._formulaBar.Controls.Add(this._lblAddress);
            this._formulaBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._formulaBar.Location = new System.Drawing.Point(0, 0);
            this._formulaBar.Name = "_formulaBar";
            this._formulaBar.Size = new System.Drawing.Size(573, 26);
            this._formulaBar.TabIndex = 2;
            // 
            // _txtFormula
            // 
            this._txtFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtFormula.Location = new System.Drawing.Point(134, 0);
            this._txtFormula.Multiline = true;
            this._txtFormula.Name = "_txtFormula";
            this._txtFormula.Size = new System.Drawing.Size(439, 26);
            this._txtFormula.TabIndex = 0;
            // 
            // _lblFx
            // 
            this._lblFx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._lblFx.Dock = System.Windows.Forms.DockStyle.Left;
            this._lblFx.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFx.Location = new System.Drawing.Point(83, 0);
            this._lblFx.Name = "_lblFx";
            this._lblFx.Size = new System.Drawing.Size(51, 26);
            this._lblFx.TabIndex = 1;
            this._lblFx.Text = "fx";
            this._lblFx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblAddress
            // 
            this._lblAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this._lblAddress.Location = new System.Drawing.Point(0, 0);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(83, 26);
            this._lblAddress.TabIndex = 2;
            this._lblAddress.Text = "A1";
            this._lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this._lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(517, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(39, 17);
            this._lblStatus.Text = "Ready";
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,125,Columns:";
            this._flex.DataContext = null;
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 26);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 25;
            this._flex.Size = new System.Drawing.Size(573, 322);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            this._flex.SelChange += new System.EventHandler(this._flex_SelChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 370);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._formulaBar);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Calculation Engine";
            this._formulaBar.ResumeLayout(false);
            this._formulaBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _formulaBar;
        private System.Windows.Forms.TextBox _txtFormula;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.Label _lblFx;
        private FlexCalc _flex;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
    }
}

