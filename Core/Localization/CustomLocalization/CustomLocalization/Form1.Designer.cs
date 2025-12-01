namespace Custom_Localization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topNavigationPanel = new Panel();
            c1Button1 = new C1.Win.Input.C1Button();
            SampleHeaderTitle = new C1.Win.Input.C1Label();
            TitleBarHeaderBreak = new C1.Win.Input.C1Label();
            ComponentOneHeaderTitle = new C1.Win.Input.C1Label();
            hostPanel = new Panel();
            topNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1Button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SampleHeaderTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleBarHeaderBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComponentOneHeaderTitle).BeginInit();
            SuspendLayout();
            // 
            // topNavigationPanel
            // 
            topNavigationPanel.BackColor = Color.FromArgb(214, 86, 76);
            topNavigationPanel.Controls.Add(c1Button1);
            topNavigationPanel.Controls.Add(SampleHeaderTitle);
            topNavigationPanel.Controls.Add(TitleBarHeaderBreak);
            topNavigationPanel.Controls.Add(ComponentOneHeaderTitle);
            topNavigationPanel.Dock = DockStyle.Top;
            topNavigationPanel.Location = new Point(0, 0);
            topNavigationPanel.Margin = new Padding(2);
            topNavigationPanel.Name = "topNavigationPanel";
            topNavigationPanel.Size = new Size(1378, 75);
            topNavigationPanel.TabIndex = 0;
            // 
            // c1Button1
            // 
            c1Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            c1Button1.Location = new Point(1181, 19);
            c1Button1.Name = "c1Button1";
            c1Button1.Size = new Size(182, 42);
            c1Button1.Styles.Default.BackColor = Color.Transparent;
            c1Button1.Styles.Default.BorderColor = Color.White;
            c1Button1.Styles.Default.ForeColor = Color.White;
            c1Button1.Styles.Hot.BorderColor = Color.White;
            c1Button1.Styles.Hot.ForeColor = Color.Black;
            c1Button1.Styles.HotPressed.BackColor = Color.WhiteSmoke;
            c1Button1.Styles.HotPressed.BorderColor = Color.White;
            c1Button1.Styles.HotPressed.ForeColor = Color.Black;
            c1Button1.TabIndex = 5;
            c1Button1.Text = "View Code Behind";
            c1Button1.Click += c1Button1_Click;
            // 
            // SampleHeaderTitle
            // 
            SampleHeaderTitle.AutoSize = true;
            SampleHeaderTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SampleHeaderTitle.Location = new Point(260, 15);
            SampleHeaderTitle.Name = "SampleHeaderTitle";
            SampleHeaderTitle.Size = new Size(281, 46);
            SampleHeaderTitle.Styles.Default.ForeColor = Color.White;
            SampleHeaderTitle.TabIndex = 4;
            SampleHeaderTitle.Text = "Custom Localization";
            // 
            // TitleBarHeaderBreak
            // 
            TitleBarHeaderBreak.AutoSize = true;
            TitleBarHeaderBreak.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBarHeaderBreak.Location = new Point(240, 10);
            TitleBarHeaderBreak.Name = "TitleBarHeaderBreak";
            TitleBarHeaderBreak.Size = new Size(34, 46);
            TitleBarHeaderBreak.Styles.Default.ForeColor = Color.White;
            TitleBarHeaderBreak.TabIndex = 3;
            TitleBarHeaderBreak.Text = "|";
            // 
            // ComponentOneHeaderTitle
            // 
            ComponentOneHeaderTitle.AutoSize = true;
            ComponentOneHeaderTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComponentOneHeaderTitle.Location = new Point(15, 15);
            ComponentOneHeaderTitle.Name = "ComponentOneHeaderTitle";
            ComponentOneHeaderTitle.Size = new Size(235, 46);
            ComponentOneHeaderTitle.Styles.Default.ForeColor = Color.White;
            ComponentOneHeaderTitle.TabIndex = 0;
            ComponentOneHeaderTitle.Text = "Component One";
            // 
            // hostPanel
            // 
            hostPanel.BackColor = Color.White;
            hostPanel.Dock = DockStyle.Fill;
            hostPanel.Location = new Point(0, 75);
            hostPanel.Margin = new Padding(2);
            hostPanel.Name = "hostPanel";
            hostPanel.Size = new Size(1378, 769);
            hostPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(hostPanel);
            Controls.Add(topNavigationPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1400, 900);
            Name = "Form1";
            Text = "Custom Localization Sample";
            topNavigationPanel.ResumeLayout(false);
            topNavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1Button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SampleHeaderTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleBarHeaderBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComponentOneHeaderTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topNavigationPanel;
        private C1.Win.Input.C1Label ComponentOneHeaderTitle;
        private Panel hostPanel;
        private C1.Win.Input.C1Label SampleHeaderTitle;
        private C1.Win.Input.C1Label TitleBarHeaderBreak;
        private C1.Win.Input.C1Button c1Button1;
    }
}
