namespace FlexGridGeminiAI.Views.Forms
{
    partial class APIKeyInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIKeyInputForm));
            panel1 = new Panel();
            cancelButton = new C1.Win.Input.C1Button();
            groqAPIKeyLink = new LinkLabel();
            label2 = new Label();
            c1PictureBox2 = new C1.Win.Input.C1PictureBox();
            groqApiInputTextBox = new C1.Win.Input.C1TextBox();
            c1PictureBox1 = new C1.Win.Input.C1PictureBox();
            apiInputTextBox = new C1.Win.Input.C1TextBox();
            geminiAPIlinkLabel = new LinkLabel();
            c1Button1 = new C1.Win.Input.C1Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groqApiInputTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apiInputTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Button1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(groqAPIKeyLink);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(c1PictureBox2);
            panel1.Controls.Add(groqApiInputTextBox);
            panel1.Controls.Add(c1PictureBox1);
            panel1.Controls.Add(apiInputTextBox);
            panel1.Controls.Add(geminiAPIlinkLabel);
            panel1.Controls.Add(c1Button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 438);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.ButtonType = C1.Win.Input.ButtonType.Subtle;
            cancelButton.Location = new Point(342, 389);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 37);
            cancelButton.Styles.Corners = new C1.Framework.Corners(5, 5, 5, 5);
            cancelButton.Styles.FocusBorderColor = Color.Transparent;
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // groqAPIKeyLink
            // 
            groqAPIKeyLink.AutoSize = true;
            groqAPIKeyLink.LinkColor = Color.FromArgb(64, 64, 64);
            groqAPIKeyLink.Location = new Point(285, 290);
            groqAPIKeyLink.Name = "groqAPIKeyLink";
            groqAPIKeyLink.Size = new Size(188, 20);
            groqAPIKeyLink.TabIndex = 9;
            groqAPIKeyLink.TabStop = true;
            groqAPIKeyLink.Text = "Get Your Own Groq API key";
            groqAPIKeyLink.LinkClicked += groqAPIlink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 199);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 8;
            label2.Text = "Groq API Key";
            // 
            // c1PictureBox2
            // 
            c1PictureBox2.BackColor = Color.White;
            c1PictureBox2.ErrorImage = Properties.Resources.hide;
            c1PictureBox2.Image = Properties.Resources.hide;
            c1PictureBox2.InitialImage = Properties.Resources.hide;
            c1PictureBox2.Location = new Point(436, 231);
            c1PictureBox2.Name = "c1PictureBox2";
            c1PictureBox2.Size = new Size(31, 32);
            c1PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            c1PictureBox2.TabIndex = 7;
            c1PictureBox2.TabStop = false;
            c1PictureBox2.Click += c1PictureBox2_Click;
            // 
            // groqApiInputTextBox
            // 
            groqApiInputTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groqApiInputTextBox.Location = new Point(38, 225);
            groqApiInputTextBox.Name = "groqApiInputTextBox";
            groqApiInputTextBox.PasswordChar = '●';
            groqApiInputTextBox.Size = new Size(435, 45);
            groqApiInputTextBox.Styles.Corners = new C1.Framework.Corners(5, 5, 5, 5);
            groqApiInputTextBox.Styles.Default.BorderColor = Color.LightGray;
            groqApiInputTextBox.Styles.Padding = new C1.Framework.Thickness(5, 10, 30, 10);
            groqApiInputTextBox.Styles.Underline.Default.Color = Color.Transparent;
            groqApiInputTextBox.TabIndex = 6;
            groqApiInputTextBox.UseSystemPasswordChar = true;
            groqApiInputTextBox.Value = "";
            groqApiInputTextBox.VerticalAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // c1PictureBox1
            // 
            c1PictureBox1.BackColor = Color.White;
            c1PictureBox1.ErrorImage = Properties.Resources.hide;
            c1PictureBox1.Image = Properties.Resources.hide;
            c1PictureBox1.InitialImage = Properties.Resources.hide;
            c1PictureBox1.Location = new Point(434, 71);
            c1PictureBox1.Name = "c1PictureBox1";
            c1PictureBox1.Size = new Size(31, 32);
            c1PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            c1PictureBox1.TabIndex = 5;
            c1PictureBox1.TabStop = false;
            c1PictureBox1.Click += c1PictureBox1_Click;
            // 
            // apiInputTextBox
            // 
            apiInputTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apiInputTextBox.Location = new Point(38, 64);
            apiInputTextBox.Name = "apiInputTextBox";
            apiInputTextBox.PasswordChar = '●';
            apiInputTextBox.Size = new Size(435, 45);
            apiInputTextBox.Styles.Corners = new C1.Framework.Corners(5, 5, 5, 5);
            apiInputTextBox.Styles.Default.BorderColor = Color.LightGray;
            apiInputTextBox.Styles.Padding = new C1.Framework.Thickness(5, 10, 30, 10);
            apiInputTextBox.Styles.Underline.Default.Color = Color.Transparent;
            apiInputTextBox.TabIndex = 3;
            apiInputTextBox.UseSystemPasswordChar = true;
            apiInputTextBox.Value = "";
            apiInputTextBox.VerticalAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // geminiAPIlinkLabel
            // 
            geminiAPIlinkLabel.AutoSize = true;
            geminiAPIlinkLabel.LinkColor = Color.DimGray;
            geminiAPIlinkLabel.Location = new Point(285, 138);
            geminiAPIlinkLabel.Name = "geminiAPIlinkLabel";
            geminiAPIlinkLabel.Size = new Size(202, 20);
            geminiAPIlinkLabel.TabIndex = 4;
            geminiAPIlinkLabel.TabStop = true;
            geminiAPIlinkLabel.Text = "Get Your Own Gemini API key";
            geminiAPIlinkLabel.LinkClicked += geminiAPIlink_LinkClicked;
            // 
            // c1Button1
            // 
            c1Button1.ButtonType = C1.Win.Input.ButtonType.Accent;
            c1Button1.Font = new Font("Segoe UI", 9F);
            c1Button1.Location = new Point(423, 389);
            c1Button1.Name = "c1Button1";
            c1Button1.Size = new Size(75, 37);
            c1Button1.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            c1Button1.Styles.Corners = new C1.Framework.Corners(5, 5, 5, 5);
            c1Button1.Styles.Default.BackColor = Color.FromArgb(105, 118, 131);
            c1Button1.Styles.Default.BorderColor = Color.Transparent;
            c1Button1.Styles.Default.ForeColor = Color.White;
            c1Button1.Styles.FocusBorderColor = Color.Transparent;
            c1Button1.Styles.Hot.BackColor = Color.FromArgb(96, 107, 119);
            c1Button1.Styles.Hot.BorderColor = Color.FromArgb(105, 118, 131);
            c1Button1.Styles.HotPressed.BackColor = Color.DimGray;
            c1Button1.Styles.HotPressed.BorderColor = Color.DimGray;
            c1Button1.Styles.Pressed.BackColor = Color.FromArgb(64, 64, 64);
            c1Button1.Styles.Pressed.BorderColor = Color.Transparent;
            c1Button1.TabIndex = 2;
            c1Button1.Text = "Confirm";
            c1Button1.Click += c1Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 1;
            label1.Text = "Gemini API Key";
            // 
            // APIKeyInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 438);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "APIKeyInputForm";
            Text = "APIKeyInputForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groqApiInputTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)apiInputTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Button1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private C1.Win.Input.C1TextBox apiInputTextBox;
        private LinkLabel geminiAPIlinkLabel;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private Label label2;
        private C1.Win.Input.C1PictureBox c1PictureBox2;
        private C1.Win.Input.C1TextBox groqApiInputTextBox;
        private LinkLabel groqAPIKeyLink;
        private C1.Win.Input.C1Button c1Button1;
        private C1.Win.Input.C1Button cancelButton;
    }
}