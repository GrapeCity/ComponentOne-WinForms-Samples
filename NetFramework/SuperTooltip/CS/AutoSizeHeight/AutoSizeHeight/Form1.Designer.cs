namespace WindowsFormsApplication1
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
            this._superLabel = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.SuspendLayout();
            // 
            // _superLabel
            // 
            this._superLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._superLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._superLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._superLabel.Location = new System.Drawing.Point(0, 0);
            this._superLabel.Name = "_superLabel";
            this._superLabel.Padding = new System.Windows.Forms.Padding(4);
            this._superLabel.Size = new System.Drawing.Size(420, 69);
            this._superLabel.TabIndex = 0;
            this._superLabel.Text = "This is a <b>C1SuperLabel</b> that automatically adjusts its height depending on " +
    "the form width.<hr>To see it in action, resize the form.";
            this._superLabel.UseMnemonic = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 336);
            this.Controls.Add(this._superLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SuperLabel: AutoSize Height";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SuperTooltip.C1SuperLabel _superLabel;
    }
}

