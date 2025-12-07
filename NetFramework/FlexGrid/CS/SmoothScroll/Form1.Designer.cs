namespace SmoothScroll
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
            this._smoothFlex = new SmoothScroll.SmoothFlex();
            ((System.ComponentModel.ISupportInitialize)(this._smoothFlex)).BeginInit();
            this.SuspendLayout();
            // 
            // _smoothFlex
            // 
            this._smoothFlex.ColumnInfo = "10,1,0,0,0,120,Columns:";
            this._smoothFlex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._smoothFlex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._smoothFlex.IsScrolling = false;
            this._smoothFlex.Location = new System.Drawing.Point(0, 0);
            this._smoothFlex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._smoothFlex.Name = "_smoothFlex";
            this._smoothFlex.Rows.DefaultSize = 24;
            this._smoothFlex.Size = new System.Drawing.Size(1006, 588);
            this._smoothFlex.StyleInfo = resources.GetString("_smoothFlex.StyleInfo");
            this._smoothFlex.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 588);
            this.Controls.Add(this._smoothFlex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Flexgrid: Smooth Scrolling";
            ((System.ComponentModel.ISupportInitialize)(this._smoothFlex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmoothFlex _smoothFlex;

    }
}

