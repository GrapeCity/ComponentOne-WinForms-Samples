namespace FlexGridExplorer.Samples
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private RichTextBox rtb;

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
            rtb = new RichTextBox();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.BackColor = Color.FromArgb(249, 248, 248);
            rtb.BorderStyle = BorderStyle.None;
            rtb.Dock = DockStyle.Fill;
            rtb.Font = new Font("Segoe UI", 13.8F);
            rtb.Location = new Point(0, 0);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            rtb.Size = new Size(765, 585);
            rtb.TabIndex = 0;
            rtb.Text = "";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 248, 248);
            Controls.Add(rtb);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Size = new Size(765, 585);
            ResumeLayout(false);
        }

        #endregion
    }
}
