namespace BaseExplorer.Components
{
    partial class DescriptionPanel
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
            this.rtbHeader = new System.Windows.Forms.RichTextBox();
            this.rtbContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbHeader
            // 
            this.rtbHeader.BackColor = System.Drawing.Color.White;
            this.rtbHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHeader.Location = new System.Drawing.Point(10, 10);
            this.rtbHeader.Name = "rtbHeader";
            this.rtbHeader.ReadOnly = true;
            this.rtbHeader.Size = new System.Drawing.Size(605, 30);
            this.rtbHeader.TabIndex = 3;
            this.rtbHeader.Text = "Description";
            // 
            // rtbContents
            // 
            this.rtbContents.BackColor = System.Drawing.Color.White;
            this.rtbContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContents.Location = new System.Drawing.Point(10, 40);
            this.rtbContents.MaximumSize = new System.Drawing.Size(0, 250);
            this.rtbContents.MinimumSize = new System.Drawing.Size(0, 100);
            this.rtbContents.Name = "rtbContents";
            this.rtbContents.ReadOnly = true;
            this.rtbContents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbContents.Size = new System.Drawing.Size(605, 240);
            this.rtbContents.TabIndex = 4;
            this.rtbContents.Text = "";
            // 
            // DescriptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rtbContents);
            this.Controls.Add(this.rtbHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DescriptionPanel";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Size = new System.Drawing.Size(625, 280);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbHeader;
        private System.Windows.Forms.RichTextBox rtbContents;
    }
}
