namespace TransposeSample
{
    partial class c1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c1));
            label5 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Location = new Point(12, 23);
            label5.MaximumSize = new Size(650, 200);
            label5.Name = "label5";
            label5.Size = new Size(650, 200);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // c1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 510);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "c1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "c1";
            Load += c1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
    }
}