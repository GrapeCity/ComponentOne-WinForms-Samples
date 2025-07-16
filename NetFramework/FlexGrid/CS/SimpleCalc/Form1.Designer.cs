namespace SimpleCalc
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
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 40);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(593, 263);
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entries starting with an \"=\" sign will be evaluated by the grid. Press F2 to edit" +
                " the expressions.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Simple Calc Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.Label label1;
    }
}

