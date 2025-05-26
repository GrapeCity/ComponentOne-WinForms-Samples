namespace FlexGridAi.Controls
{
    partial class CustomTextBox
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
            textBox = new TextBox();
            askButton = new C1.Win.Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)askButton).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(20, 20);
            textBox.MaxLength = 200;
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(509, 115);
            textBox.TabIndex = 0;
            // 
            // askButton
            // 
            askButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            askButton.Cursor = Cursors.Hand;
            askButton.Font = new Font("Segoe UI Variable Text", 10F);
            askButton.Location = new Point(412, 150);
            askButton.Name = "askButton";
            askButton.Size = new Size(117, 50);
            askButton.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            askButton.Styles.Default.BackColor = Color.FromArgb(0, 95, 184);
            askButton.Styles.Default.BorderColor = Color.FromArgb(20, 108, 190);
            askButton.Styles.Default.ForeColor = Color.White;
            askButton.Styles.Disabled.BackColor = SystemColors.ScrollBar;
            askButton.Styles.Disabled.BorderColor = SystemColors.ScrollBar;
            askButton.Styles.Disabled.ForeColor = Color.White;
            askButton.Styles.Hot.BackColor = Color.FromArgb(26, 111, 192);
            askButton.Styles.Hot.BorderColor = Color.FromArgb(30, 84, 136);
            askButton.Styles.Hot.ForeColor = Color.White;
            askButton.Styles.HotPressed.BackColor = Color.FromArgb(51, 127, 198);
            askButton.Styles.HotPressed.BorderColor = Color.FromArgb(67, 137, 202);
            askButton.Styles.HotPressed.ForeColor = Color.FromArgb(193, 216, 238);
            askButton.TabIndex = 1;
            askButton.Text = "Ask";
            // 
            // CustomTextBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(askButton);
            Controls.Add(textBox);
            Margin = new Padding(20, 20, 10, 10);
            Name = "CustomTextBox";
            Padding = new Padding(10);
            Size = new Size(549, 218);
            ((System.ComponentModel.ISupportInitialize)askButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private C1.Win.Input.C1Button askButton;
    }
}
