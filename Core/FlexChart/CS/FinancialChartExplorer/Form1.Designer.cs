using C1.Win.Themes;
using FinancialChartExplorer.CustomControls;
using System.Windows.Forms;

namespace FinancialChartExplorer
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
            components = new System.ComponentModel.Container();
            C1Office365ThemeSettings c1Office365ThemeSettings2 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings3 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings8 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings4 = new C1Office365ThemeSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1Office365ThemeSettings c1Office365ThemeSettings5 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings6 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings7 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings1 = new C1Office365ThemeSettings();
            C1Office365ThemeSettings c1Office365ThemeSettings9 = new C1Office365ThemeSettings();
            splitContainer1 = new SplitContainer();
            _btnHamb = new Button();
            accordionAreaCT1 = new AccordionAreaCT();
            panel1 = new Panel();
            labelSampleDescription = new Label();
            _toggleBtn = new C1.Win.Input.C1Button();
            panelSample = new Panel();
            labelSampleHeader = new Label();
            imageList1 = new ImageList(components);
            c1ThemeController1 = new C1ThemeController();
            richTextBoxSampleDescription = new C1.Win.Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_toggleBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)richTextBoxSampleDescription).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Font = new Font("Segoe UI", 9.75F);
            splitContainer1.ForeColor = Color.FromArgb(68, 68, 68);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel1.Controls.Add(_btnHamb);
            splitContainer1.Panel1.Controls.Add(accordionAreaCT1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Padding = new Padding(0, 23, 0, 0);
            splitContainer1.Panel2MinSize = 20;
            splitContainer1.Size = new Size(1112, 681);
            splitContainer1.SplitterDistance = 235;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            c1ThemeController1.SetTheme(splitContainer1, "Office2016White");
            // 
            // _btnHamb
            // 
            _btnHamb.BackColor = Color.WhiteSmoke;
            _btnHamb.DialogResult = DialogResult.Cancel;
            _btnHamb.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            _btnHamb.FlatAppearance.CheckedBackColor = Color.FromArgb(240, 240, 240);
            _btnHamb.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            _btnHamb.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            _btnHamb.FlatStyle = FlatStyle.Flat;
            _btnHamb.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _btnHamb.ForeColor = Color.FromArgb(32, 32, 32);
            _btnHamb.Location = new Point(22, 23);
            _btnHamb.Margin = new Padding(4);
            _btnHamb.Name = "_btnHamb";
            _btnHamb.Size = new Size(40, 36);
            _btnHamb.TabIndex = 12;
            _btnHamb.Text = "S";
            c1ThemeController1.SetTheme(_btnHamb, "Office365White");
            c1Office365ThemeSettings2.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings2.Background = Color.WhiteSmoke;
            c1Office365ThemeSettings2.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(_btnHamb, c1Office365ThemeSettings2);
            _btnHamb.UseVisualStyleBackColor = false;
            _btnHamb.Click += BtnHamb_Click;
            // 
            // accordionAreaCT1
            // 
            accordionAreaCT1.AccordionFont = new Font("Segoe UI", 14F);
            accordionAreaCT1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            accordionAreaCT1.BackColor = Color.FromArgb(239, 239, 239);
            accordionAreaCT1.Font = new Font("Segoe UI", 14F);
            accordionAreaCT1.ForeColor = Color.FromArgb(32, 32, 32);
            accordionAreaCT1.Location = new Point(4, 93);
            accordionAreaCT1.Margin = new Padding(4, 1, 4, 1);
            accordionAreaCT1.Name = "accordionAreaCT1";
            accordionAreaCT1.Size = new Size(224, 575);
            accordionAreaCT1.TabIndex = 13;
            c1ThemeController1.SetTheme(accordionAreaCT1, "Office365White");
            c1Office365ThemeSettings3.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings3.Background = Color.White;
            c1Office365ThemeSettings3.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(accordionAreaCT1, c1Office365ThemeSettings3);
            accordionAreaCT1.Child_Clicked_Callback += AccordionChild_Clicked_Callback;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(labelSampleDescription);
            panel1.Controls.Add(_toggleBtn);
            panel1.Controls.Add(panelSample);
            panel1.Controls.Add(labelSampleHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14F);
            panel1.ForeColor = Color.FromArgb(32, 32, 32);
            panel1.Location = new Point(0, 23);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 658);
            panel1.TabIndex = 0;
            c1ThemeController1.SetTheme(panel1, "Office365White");
            c1Office365ThemeSettings8.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings8.Background = Color.White;
            c1Office365ThemeSettings8.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(panel1, c1Office365ThemeSettings8);
            panel1.Paint += Panel1_Paint;
            // 
            // labelSampleDescription
            // 
            labelSampleDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSampleDescription.BackColor = Color.Transparent;
            labelSampleDescription.Font = new Font("Segoe UI", 13F);
            labelSampleDescription.ForeColor = Color.FromArgb(32, 32, 32);
            labelSampleDescription.Location = new Point(42, 123);
            labelSampleDescription.Margin = new Padding(2, 0, 2, 0);
            labelSampleDescription.Name = "labelSampleDescription";
            labelSampleDescription.Size = new Size(782, 88);
            labelSampleDescription.TabIndex = 6;
            labelSampleDescription.Text = "Sample Description";
            c1ThemeController1.SetTheme(labelSampleDescription, "Office365White");
            c1Office365ThemeSettings4.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings4.Background = Color.White;
            c1Office365ThemeSettings4.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(labelSampleDescription, c1Office365ThemeSettings4);
            // 
            // _toggleBtn
            // 
            _toggleBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _toggleBtn.Font = new Font("Segoe UI", 12F);
            _toggleBtn.Icon = new C1.Framework.C1BitmapIcon("light.png", new Size(16, 16), Color.Transparent, (Image)resources.GetObject("_toggleBtn.Icon"));
            _toggleBtn.Location = new Point(657, 45);
            _toggleBtn.Name = "_toggleBtn";
            _toggleBtn.Size = new Size(190, 47);
            _toggleBtn.TabIndex = 4;
            _toggleBtn.Text = "Toggle Theme";
            _toggleBtn.TextAlign = ContentAlignment.MiddleLeft;
            _toggleBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            c1ThemeController1.SetTheme(_toggleBtn, "Office365White");
            c1Office365ThemeSettings5.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings5.Background = Color.White;
            c1Office365ThemeSettings5.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(_toggleBtn, c1Office365ThemeSettings5);
            _toggleBtn.Click += ToggleBtn_Click;
            // 
            // panelSample
            // 
            panelSample.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSample.BackColor = Color.FromArgb(239, 239, 239);
            panelSample.Font = new Font("Segoe UI", 14F);
            panelSample.ForeColor = Color.FromArgb(32, 32, 32);
            panelSample.Location = new Point(45, 215);
            panelSample.Margin = new Padding(0);
            panelSample.Name = "panelSample";
            panelSample.Size = new Size(802, 401);
            panelSample.TabIndex = 2;
            c1ThemeController1.SetTheme(panelSample, "Office365White");
            c1Office365ThemeSettings6.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings6.Background = Color.White;
            c1Office365ThemeSettings6.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(panelSample, c1Office365ThemeSettings6);
            // 
            // labelSampleHeader
            // 
            labelSampleHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSampleHeader.AutoSize = true;
            labelSampleHeader.BackColor = Color.Transparent;
            labelSampleHeader.Font = new Font("Segoe UI Variable Display", 26F, FontStyle.Bold);
            labelSampleHeader.ForeColor = Color.FromArgb(32, 32, 32);
            labelSampleHeader.Location = new Point(37, 60);
            labelSampleHeader.Margin = new Padding(4, 0, 4, 0);
            labelSampleHeader.Name = "labelSampleHeader";
            labelSampleHeader.Size = new Size(397, 69);
            labelSampleHeader.TabIndex = 0;
            labelSampleHeader.Text = "Sample Header";
            c1ThemeController1.SetTheme(labelSampleHeader, "Office365White");
            c1Office365ThemeSettings7.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings7.Background = Color.White;
            c1Office365ThemeSettings7.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(labelSampleHeader, c1Office365ThemeSettings7);
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dark.png");
            imageList1.Images.SetKeyName(1, "light.png");
            // 
            // c1ThemeController1
            // 
            c1ThemeController1.Theme = "Office365White";
            c1Office365ThemeSettings1.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings1.Background = Color.White;
            c1Office365ThemeSettings1.ForeColor = Color.White;
            c1ThemeController1.ThemeSettings = c1Office365ThemeSettings1;
            // 
            // richTextBoxSampleDescription
            // 
            richTextBoxSampleDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxSampleDescription.AutoSize = false;
            richTextBoxSampleDescription.Font = new Font("Segoe UI", 12F);
            richTextBoxSampleDescription.Location = new Point(50, 131);
            richTextBoxSampleDescription.Multiline = true;
            richTextBoxSampleDescription.Name = "richTextBoxSampleDescription";
            richTextBoxSampleDescription.Placeholder = "Sample Description";
            richTextBoxSampleDescription.Size = new Size(901, 104);
            richTextBoxSampleDescription.TabIndex = 5;
            c1ThemeController1.SetTheme(richTextBoxSampleDescription, "Office365White");
            c1Office365ThemeSettings9.AccentColor = Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings9.Background = Color.White;
            c1Office365ThemeSettings9.ForeColor = Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(richTextBoxSampleDescription, c1Office365ThemeSettings9);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 681);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F);
            ForeColor = Color.FromArgb(68, 68, 68);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "FinancialChart Explorer";
            c1ThemeController1.SetTheme(this, "Office2016White");
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_toggleBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).EndInit();
            ((System.ComponentModel.ISupportInitialize)richTextBoxSampleDescription).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSample;
        private System.Windows.Forms.Label labelSampleHeader;
        private System.Windows.Forms.Button _btnHamb;
        //private ImageList imageList1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.Input.C1Button _toggleBtn;
        private AccordionAreaCT accordionAreaCT1;
        private Label labelSampleDescription;
        private C1.Win.Input.C1TextBox richTextBoxSampleDescription;
    }
}

