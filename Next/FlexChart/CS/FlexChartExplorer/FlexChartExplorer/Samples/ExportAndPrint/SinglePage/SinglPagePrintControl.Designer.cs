namespace FlexChartExplorer.Samples
{
    partial class SinglePagePrintControl
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
            // 
            // SingleChartPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.labHeight);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.comboPrintScale);
            this.Controls.Add(this.chkGrayScale);
            this.Controls.Add(this.btnPrint);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SingleChartPrint";
            this.Size = new System.Drawing.Size(548, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btnPrint;
        //private System.Windows.Forms.Button btnClear;
        //private System.Windows.Forms.CheckBox chkGrayScale;
        //private System.Windows.Forms.ComboBox comboPrintScale;
        //private System.Windows.Forms.CheckBox chkPreview;
        //private System.Windows.Forms.Label labX;
        //private System.Windows.Forms.Label labY;
        //private System.Windows.Forms.Label labWidth;
        //private System.Windows.Forms.Label labHeight;
        //private System.Windows.Forms.TextBox txtX;
        //private System.Windows.Forms.TextBox txtY;
        //private System.Windows.Forms.TextBox txtWidth;
        //private System.Windows.Forms.TextBox txtHeight;
    }
}
