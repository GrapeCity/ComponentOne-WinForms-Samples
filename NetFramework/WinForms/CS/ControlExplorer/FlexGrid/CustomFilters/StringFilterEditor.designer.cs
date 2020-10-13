namespace ControlExplorer.FlexGrid.CustomFilters
{
    partial class StringFilterEditor
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
            this._chkAE = new System.Windows.Forms.CheckBox();
            this._chkFJ = new System.Windows.Forms.CheckBox();
            this._chkKO = new System.Windows.Forms.CheckBox();
            this._chkPT = new System.Windows.Forms.CheckBox();
            this._chkUZ = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _chkAE
            // 
            this._chkAE.AutoSize = true;
            this._chkAE.Location = new System.Drawing.Point(2, 4);
            this._chkAE.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._chkAE.Name = "_chkAE";
            this._chkAE.Size = new System.Drawing.Size(61, 21);
            this._chkAE.TabIndex = 0;
            this._chkAE.Text = "A - E";
            this._chkAE.UseVisualStyleBackColor = true;
            this._chkAE.CheckedChanged += new System.EventHandler(this._chkAE_CheckedChanged);
            // 
            // _chkFJ
            // 
            this._chkFJ.AutoSize = true;
            this._chkFJ.Location = new System.Drawing.Point(2, 25);
            this._chkFJ.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._chkFJ.Name = "_chkFJ";
            this._chkFJ.Size = new System.Drawing.Size(58, 21);
            this._chkFJ.TabIndex = 0;
            this._chkFJ.Text = "F - J";
            this._chkFJ.UseVisualStyleBackColor = true;
            this._chkFJ.CheckedChanged += new System.EventHandler(this._chkAE_CheckedChanged);
            // 
            // _chkKO
            // 
            this._chkKO.AutoSize = true;
            this._chkKO.Location = new System.Drawing.Point(2, 46);
            this._chkKO.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._chkKO.Name = "_chkKO";
            this._chkKO.Size = new System.Drawing.Size(63, 21);
            this._chkKO.TabIndex = 0;
            this._chkKO.Text = "K - O";
            this._chkKO.UseVisualStyleBackColor = true;
            this._chkKO.CheckedChanged += new System.EventHandler(this._chkAE_CheckedChanged);
            // 
            // _chkPT
            // 
            this._chkPT.AutoSize = true;
            this._chkPT.Location = new System.Drawing.Point(2, 67);
            this._chkPT.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._chkPT.Name = "_chkPT";
            this._chkPT.Size = new System.Drawing.Size(61, 21);
            this._chkPT.TabIndex = 0;
            this._chkPT.Text = "P - T";
            this._chkPT.UseVisualStyleBackColor = true;
            this._chkPT.CheckedChanged += new System.EventHandler(this._chkAE_CheckedChanged);
            // 
            // _chkUZ
            // 
            this._chkUZ.AutoSize = true;
            this._chkUZ.Location = new System.Drawing.Point(2, 88);
            this._chkUZ.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._chkUZ.Name = "_chkUZ";
            this._chkUZ.Size = new System.Drawing.Size(62, 21);
            this._chkUZ.TabIndex = 0;
            this._chkUZ.Text = "U - Z";
            this._chkUZ.UseVisualStyleBackColor = true;
            this._chkUZ.CheckedChanged += new System.EventHandler(this._chkAE_CheckedChanged);
            // 
            // StringFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._chkUZ);
            this.Controls.Add(this._chkPT);
            this.Controls.Add(this._chkKO);
            this.Controls.Add(this._chkFJ);
            this.Controls.Add(this._chkAE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StringFilterEditor";
            this.Size = new System.Drawing.Size(234, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chkAE;
        private System.Windows.Forms.CheckBox _chkFJ;
        private System.Windows.Forms.CheckBox _chkKO;
        private System.Windows.Forms.CheckBox _chkPT;
        private System.Windows.Forms.CheckBox _chkUZ;
    }
}
