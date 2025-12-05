namespace FlexGridGeminiAI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bodyNavPanel = new Panel();
            leftBorderPanel = new Panel();
            girdViewPanel = new Panel();
            flexGridC1 = new C1.Win.FlexGrid.C1FlexGrid();
            sideMenuPanel = new Panel();
            responseSidePanel = new Panel();
            loadingIconPictureBox = new C1.Win.Input.C1PictureBox();
            responseTextBoxC1 = new C1.Win.Input.C1TextBox();
            panel1 = new Panel();
            c1PictureBox2 = new C1.Win.Input.C1PictureBox();
            c1Label4 = new C1.Win.Input.C1Label();
            promptSidePanel = new Panel();
            sendPictureIcon = new C1.Win.Input.C1PictureBox();
            aiModelComboBox = new ComboBox();
            promptTextBoxC1 = new C1.Win.Input.C1TextBox();
            clearPictureIcon = new C1.Win.Input.C1PictureBox();
            settingsPictureIcon = new C1.Win.Input.C1PictureBox();
            c1TextBox1 = new C1.Win.Input.C1TextBox();
            bannerLabel = new C1.Win.Input.C1Label();
            topNavPanel = new Panel();
            i_Icon = new C1.Win.Input.C1PictureBox();
            dataSourceDd = new ComboBox();
            c1PictureBox1 = new C1.Win.Input.C1PictureBox();
            dataTableDd = new ComboBox();
            c1Label2 = new C1.Win.Input.C1Label();
            c1Label1 = new C1.Win.Input.C1Label();
            bottomBorderPanel = new Panel();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            bodyNavPanel.SuspendLayout();
            girdViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexGridC1).BeginInit();
            sideMenuPanel.SuspendLayout();
            responseSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)responseTextBoxC1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label4).BeginInit();
            promptSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sendPictureIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promptTextBoxC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clearPictureIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsPictureIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1TextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bannerLabel).BeginInit();
            topNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)i_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).BeginInit();
            SuspendLayout();
            // 
            // bodyNavPanel
            // 
            bodyNavPanel.AutoScrollMargin = new Size(150, 200);
            bodyNavPanel.BackColor = Color.White;
            bodyNavPanel.Controls.Add(leftBorderPanel);
            bodyNavPanel.Controls.Add(girdViewPanel);
            bodyNavPanel.Controls.Add(sideMenuPanel);
            bodyNavPanel.Dock = DockStyle.Fill;
            bodyNavPanel.Location = new Point(0, 100);
            bodyNavPanel.Name = "bodyNavPanel";
            bodyNavPanel.Size = new Size(1644, 869);
            bodyNavPanel.TabIndex = 0;
            // 
            // leftBorderPanel
            // 
            leftBorderPanel.BackColor = Color.DarkGray;
            leftBorderPanel.Dock = DockStyle.Right;
            leftBorderPanel.Location = new Point(1222, 0);
            leftBorderPanel.Margin = new Padding(20, 3, 3, 3);
            leftBorderPanel.Name = "leftBorderPanel";
            leftBorderPanel.Padding = new Padding(0, 80, 0, 0);
            leftBorderPanel.Size = new Size(1, 869);
            leftBorderPanel.TabIndex = 2;
            // 
            // girdViewPanel
            // 
            girdViewPanel.BackColor = Color.White;
            girdViewPanel.Controls.Add(flexGridC1);
            girdViewPanel.Dock = DockStyle.Fill;
            girdViewPanel.Location = new Point(0, 0);
            girdViewPanel.Name = "girdViewPanel";
            girdViewPanel.Padding = new Padding(20, 20, 5, 5);
            girdViewPanel.Size = new Size(1223, 869);
            girdViewPanel.TabIndex = 1;
            // 
            // flexGridC1
            // 
            flexGridC1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.None;
            flexGridC1.AutoResize = true;
            flexGridC1.BackColor = Color.White;
            flexGridC1.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            flexGridC1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGridC1.Dock = DockStyle.Fill;
            flexGridC1.Font = new Font("Segoe UI", 9F);
            flexGridC1.Location = new Point(20, 20);
            flexGridC1.MarqueeStyle.Color = Color.LightGray;
            flexGridC1.Name = "flexGridC1";
            flexGridC1.Size = new Size(1198, 844);
            flexGridC1.StyleInfo = resources.GetString("flexGridC1.StyleInfo");
            flexGridC1.TabIndex = 0;
            flexGridC1.Tree.LineColor = Color.LightGray;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.WhiteSmoke;
            sideMenuPanel.Controls.Add(responseSidePanel);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Controls.Add(promptSidePanel);
            sideMenuPanel.Dock = DockStyle.Right;
            sideMenuPanel.Location = new Point(1223, 0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Padding = new Padding(20, 20, 20, 10);
            sideMenuPanel.Size = new Size(421, 869);
            sideMenuPanel.TabIndex = 0;
            // 
            // responseSidePanel
            // 
            responseSidePanel.BackColor = Color.WhiteSmoke;
            responseSidePanel.Controls.Add(loadingIconPictureBox);
            responseSidePanel.Controls.Add(responseTextBoxC1);
            responseSidePanel.Dock = DockStyle.Fill;
            responseSidePanel.Location = new Point(20, 71);
            responseSidePanel.Name = "responseSidePanel";
            responseSidePanel.Size = new Size(381, 536);
            responseSidePanel.TabIndex = 0;
            responseSidePanel.Resize += ResponseSidePanel_ResizeEvent;
            // 
            // loadingIconPictureBox
            // 
            loadingIconPictureBox.BackColor = Color.White;
            loadingIconPictureBox.ErrorImage = (Image)resources.GetObject("loadingIconPictureBox.ErrorImage");
            loadingIconPictureBox.Image = Properties.Resources.loding;
            loadingIconPictureBox.InitialImage = (Image)resources.GetObject("loadingIconPictureBox.InitialImage");
            loadingIconPictureBox.Location = new Point(157, 248);
            loadingIconPictureBox.Name = "loadingIconPictureBox";
            loadingIconPictureBox.Size = new Size(50, 50);
            loadingIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loadingIconPictureBox.TabIndex = 6;
            loadingIconPictureBox.TabStop = false;
            loadingIconPictureBox.Visible = false;
            // 
            // responseTextBoxC1
            // 
            responseTextBoxC1.AutoSize = false;
            responseTextBoxC1.Dock = DockStyle.Fill;
            responseTextBoxC1.Location = new Point(0, 0);
            responseTextBoxC1.Multiline = true;
            responseTextBoxC1.Name = "responseTextBoxC1";
            responseTextBoxC1.Placeholder = "AI Response will appear here...";
            responseTextBoxC1.ReadOnly = true;
            responseTextBoxC1.ScrollBars = ScrollBars.Both;
            responseTextBoxC1.Size = new Size(381, 536);
            responseTextBoxC1.Styles.Corners = new C1.Framework.Corners(10, 10, 10, 10);
            responseTextBoxC1.Styles.Disabled.BackColor = Color.White;
            responseTextBoxC1.Styles.Padding = new C1.Framework.Thickness(10, 10, 10, 10);
            responseTextBoxC1.Styles.Readonly.BackColor = Color.White;
            responseTextBoxC1.Styles.Underline.Default.Color = Color.Transparent;
            responseTextBoxC1.Styles.Underline.Focused.Color = Color.Transparent;
            responseTextBoxC1.TabIndex = 5;
            responseTextBoxC1.Value = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(c1PictureBox2);
            panel1.Controls.Add(c1Label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 51);
            panel1.TabIndex = 2;
            // 
            // c1PictureBox2
            // 
            c1PictureBox2.ErrorImage = Properties.Resources.ai_icon;
            c1PictureBox2.Image = Properties.Resources.ai_icon;
            c1PictureBox2.InitialImage = Properties.Resources.ai_icon;
            c1PictureBox2.Location = new Point(84, -4);
            c1PictureBox2.Name = "c1PictureBox2";
            c1PictureBox2.Size = new Size(57, 44);
            c1PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            c1PictureBox2.TabIndex = 15;
            c1PictureBox2.TabStop = false;
            // 
            // c1Label4
            // 
            c1Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            c1Label4.AutoSize = true;
            c1Label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c1Label4.Location = new Point(147, 0);
            c1Label4.Name = "c1Label4";
            c1Label4.Size = new Size(124, 28);
            c1Label4.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            c1Label4.TabIndex = 15;
            c1Label4.Text = "AI Assistant";
            // 
            // promptSidePanel
            // 
            promptSidePanel.BackColor = Color.WhiteSmoke;
            promptSidePanel.Controls.Add(sendPictureIcon);
            promptSidePanel.Controls.Add(aiModelComboBox);
            promptSidePanel.Controls.Add(promptTextBoxC1);
            promptSidePanel.Controls.Add(clearPictureIcon);
            promptSidePanel.Controls.Add(settingsPictureIcon);
            promptSidePanel.Controls.Add(c1TextBox1);
            promptSidePanel.Dock = DockStyle.Bottom;
            promptSidePanel.Location = new Point(20, 607);
            promptSidePanel.Name = "promptSidePanel";
            promptSidePanel.Padding = new Padding(0, 10, 0, 0);
            promptSidePanel.Size = new Size(381, 252);
            promptSidePanel.TabIndex = 1;
            // 
            // sendPictureIcon
            // 
            sendPictureIcon.BackColor = Color.White;
            sendPictureIcon.Image = Properties.Resources.send;
            sendPictureIcon.InitialImage = Properties.Resources.paper_plane__1_;
            sendPictureIcon.Location = new Point(316, 206);
            sendPictureIcon.Name = "sendPictureIcon";
            sendPictureIcon.Size = new Size(44, 37);
            sendPictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
            sendPictureIcon.TabIndex = 17;
            sendPictureIcon.TabStop = false;
            toolTip2.SetToolTip(sendPictureIcon, "Send");
            sendPictureIcon.Click += sendPictureIcon_Click;
            sendPictureIcon.MouseMove += sendPictureIcon_MouseMove;
            // 
            // aiModelComboBox
            // 
            aiModelComboBox.BackColor = Color.WhiteSmoke;
            aiModelComboBox.FlatStyle = FlatStyle.Flat;
            aiModelComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aiModelComboBox.FormattingEnabled = true;
            aiModelComboBox.Location = new Point(205, 210);
            aiModelComboBox.Name = "aiModelComboBox";
            aiModelComboBox.Size = new Size(105, 31);
            aiModelComboBox.TabIndex = 13;
            toolTip2.SetToolTip(aiModelComboBox, "Choose Ai model");
            aiModelComboBox.MouseMove += aiModelComboBox_MouseMove;
            // 
            // promptTextBoxC1
            // 
            promptTextBoxC1.AutoSize = false;
            promptTextBoxC1.Dock = DockStyle.Top;
            promptTextBoxC1.Location = new Point(0, 10);
            promptTextBoxC1.Multiline = true;
            promptTextBoxC1.Name = "promptTextBoxC1";
            promptTextBoxC1.Placeholder = "Eg. Show all product containing animal names...";
            promptTextBoxC1.Size = new Size(381, 193);
            promptTextBoxC1.Styles.Border = new C1.Framework.Thickness(1, 1, 1, 0);
            promptTextBoxC1.Styles.Corners = new C1.Framework.Corners(10, 10, 0, 0);
            promptTextBoxC1.Styles.Margins = new C1.Framework.Thickness(0, 0, 0, 0);
            promptTextBoxC1.Styles.Padding = new C1.Framework.Thickness(10, 10, 10, 10);
            promptTextBoxC1.Styles.Underline.Default.Color = Color.Transparent;
            promptTextBoxC1.Styles.Underline.Disabled.Color = Color.Transparent;
            promptTextBoxC1.Styles.Underline.Focused.Color = Color.Transparent;
            promptTextBoxC1.Styles.Underline.Hot.Color = Color.Transparent;
            promptTextBoxC1.Styles.Underline.Readonly.Color = Color.Transparent;
            promptTextBoxC1.TabIndex = 6;
            promptTextBoxC1.Value = "";
            promptTextBoxC1.KeyDown += promptTextBoxC1_KeyDown;
            // 
            // clearPictureIcon
            // 
            clearPictureIcon.BackColor = Color.White;
            clearPictureIcon.Image = Properties.Resources.cleaning;
            clearPictureIcon.Location = new Point(64, 210);
            clearPictureIcon.Name = "clearPictureIcon";
            clearPictureIcon.Size = new Size(37, 31);
            clearPictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
            clearPictureIcon.TabIndex = 15;
            clearPictureIcon.TabStop = false;
            toolTip2.SetToolTip(clearPictureIcon, "Clear/ reset");
            clearPictureIcon.Click += clearPictureIcon_Click;
            clearPictureIcon.MouseMove += clearPictureIcon_MouseMove;
            // 
            // settingsPictureIcon
            // 
            settingsPictureIcon.BackColor = Color.White;
            settingsPictureIcon.Image = Properties.Resources.settings1;
            settingsPictureIcon.Location = new Point(16, 210);
            settingsPictureIcon.Name = "settingsPictureIcon";
            settingsPictureIcon.Size = new Size(33, 31);
            settingsPictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
            settingsPictureIcon.TabIndex = 16;
            settingsPictureIcon.TabStop = false;
            toolTip2.SetToolTip(settingsPictureIcon, "Set your API key from here\r\n");
            settingsPictureIcon.Click += settingsPictureIcon_Click;
            settingsPictureIcon.MouseMove += settingsPictureIcon_MouseMove;
            // 
            // c1TextBox1
            // 
            c1TextBox1.AutoSize = false;
            c1TextBox1.Dock = DockStyle.Fill;
            c1TextBox1.Enabled = false;
            c1TextBox1.Location = new Point(0, 10);
            c1TextBox1.Multiline = true;
            c1TextBox1.Name = "c1TextBox1";
            c1TextBox1.Placeholder = "Eg. Show all product containing animal names...";
            c1TextBox1.ReadOnly = true;
            c1TextBox1.Size = new Size(381, 242);
            c1TextBox1.Styles.Corners = new C1.Framework.Corners(10, 10, 10, 10);
            c1TextBox1.Styles.Default.BackColor = Color.White;
            c1TextBox1.Styles.Disabled.BackColor = Color.White;
            c1TextBox1.Styles.Margins = new C1.Framework.Thickness(0, 0, 0, 0);
            c1TextBox1.Styles.Padding = new C1.Framework.Thickness(10, 10, 10, 10);
            c1TextBox1.Styles.Readonly.BackColor = Color.White;
            c1TextBox1.Styles.Underline.Default.Color = Color.Transparent;
            c1TextBox1.Styles.Underline.Disabled.Color = Color.Transparent;
            c1TextBox1.Styles.Underline.Focused.Color = Color.Transparent;
            c1TextBox1.Styles.Underline.Hot.Color = Color.Transparent;
            c1TextBox1.Styles.Underline.Readonly.Color = Color.Transparent;
            c1TextBox1.TabIndex = 7;
            c1TextBox1.Value = "";
            // 
            // bannerLabel
            // 
            bannerLabel.AutoSize = true;
            bannerLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bannerLabel.Location = new Point(86, 37);
            bannerLabel.Name = "bannerLabel";
            bannerLabel.Size = new Size(385, 29);
            bannerLabel.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            bannerLabel.TabIndex = 7;
            bannerLabel.Text = "Component One | AI Integration ";
            // 
            // topNavPanel
            // 
            topNavPanel.BackColor = Color.White;
            topNavPanel.Controls.Add(i_Icon);
            topNavPanel.Controls.Add(dataSourceDd);
            topNavPanel.Controls.Add(c1PictureBox1);
            topNavPanel.Controls.Add(dataTableDd);
            topNavPanel.Controls.Add(c1Label2);
            topNavPanel.Controls.Add(c1Label1);
            topNavPanel.Controls.Add(bannerLabel);
            topNavPanel.Controls.Add(bottomBorderPanel);
            topNavPanel.Dock = DockStyle.Top;
            topNavPanel.Location = new Point(0, 0);
            topNavPanel.Name = "topNavPanel";
            topNavPanel.Size = new Size(1644, 100);
            topNavPanel.TabIndex = 2;
            // 
            // i_Icon
            // 
            i_Icon.Image = Properties.Resources.letter_i;
            i_Icon.Location = new Point(490, 41);
            i_Icon.Name = "i_Icon";
            i_Icon.Size = new Size(25, 25);
            i_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            i_Icon.TabIndex = 15;
            i_Icon.TabStop = false;
            toolTip1.SetToolTip(i_Icon, resources.GetString("i_Icon.ToolTip"));
            i_Icon.MouseMove += i_Icon_MouseMove;
            // 
            // dataSourceDd
            // 
            dataSourceDd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataSourceDd.BackColor = Color.WhiteSmoke;
            dataSourceDd.FlatStyle = FlatStyle.Flat;
            dataSourceDd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataSourceDd.FormattingEnabled = true;
            dataSourceDd.Location = new Point(1182, 50);
            dataSourceDd.Name = "dataSourceDd";
            dataSourceDd.Size = new Size(172, 31);
            dataSourceDd.TabIndex = 9;
            dataSourceDd.SelectedIndexChanged += dataSourceDd_SelectedIndexChanged;
            dataSourceDd.MouseMove += dataSourceDd_MouseMove;
            // 
            // c1PictureBox1
            // 
            c1PictureBox1.ErrorImage = Properties.Resources.ai;
            c1PictureBox1.Image = Properties.Resources.ai;
            c1PictureBox1.InitialImage = Properties.Resources.ai;
            c1PictureBox1.Location = new Point(20, 19);
            c1PictureBox1.Name = "c1PictureBox1";
            c1PictureBox1.Size = new Size(60, 60);
            c1PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            c1PictureBox1.TabIndex = 14;
            c1PictureBox1.TabStop = false;
            // 
            // dataTableDd
            // 
            dataTableDd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataTableDd.BackColor = Color.WhiteSmoke;
            dataTableDd.FlatStyle = FlatStyle.Flat;
            dataTableDd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataTableDd.FormattingEnabled = true;
            dataTableDd.Location = new Point(1400, 49);
            dataTableDd.Name = "dataTableDd";
            dataTableDd.Size = new Size(212, 31);
            dataTableDd.TabIndex = 8;
            dataTableDd.SelectedIndexChanged += dataTableDd_SelectedIndexChanged;
            dataTableDd.MouseMove += dataTableDd_MouseMove;
            // 
            // c1Label2
            // 
            c1Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            c1Label2.AutoSize = true;
            c1Label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c1Label2.Location = new Point(1182, 24);
            c1Label2.Name = "c1Label2";
            c1Label2.Size = new Size(125, 20);
            c1Label2.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            c1Label2.TabIndex = 10;
            c1Label2.Text = "Pick DataSource:";
            // 
            // c1Label1
            // 
            c1Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            c1Label1.AutoSize = true;
            c1Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c1Label1.Location = new Point(1400, 24);
            c1Label1.Name = "c1Label1";
            c1Label1.Size = new Size(119, 20);
            c1Label1.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            c1Label1.TabIndex = 0;
            c1Label1.Text = "Pick Data Table:";
            // 
            // bottomBorderPanel
            // 
            bottomBorderPanel.BackColor = Color.DarkGray;
            bottomBorderPanel.Dock = DockStyle.Bottom;
            bottomBorderPanel.Location = new Point(0, 99);
            bottomBorderPanel.Name = "bottomBorderPanel";
            bottomBorderPanel.Size = new Size(1644, 1);
            bottomBorderPanel.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "FlexGridGeminiAI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1644, 969);
            Controls.Add(bodyNavPanel);
            Controls.Add(topNavPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integration of AI in FilterDefination";
            bodyNavPanel.ResumeLayout(false);
            girdViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexGridC1).EndInit();
            sideMenuPanel.ResumeLayout(false);
            responseSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadingIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)responseTextBoxC1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label4).EndInit();
            promptSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sendPictureIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)promptTextBoxC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clearPictureIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsPictureIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1TextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bannerLabel).EndInit();
            topNavPanel.ResumeLayout(false);
            topNavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)i_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bodyNavPanel;
        private Panel girdViewPanel;
        private Panel sideMenuPanel;
        private C1.Win.FlexGrid.C1FlexGrid flexGridC1;
        private Panel promptSidePanel;
        private Panel responseSidePanel;
        private Panel topNavPanel;
        private C1.Win.Input.C1TextBox promptTextBoxC1;
        private C1.Win.Input.C1TextBox responseTextBoxC1;
        private Panel bottomBorderPanel;
        private Panel leftBorderPanel;
        private C1.Win.Input.C1Label bannerLabel;
        private ComboBox dataTableDd;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1PictureBox loadingIconPictureBox;
        private ComboBox aiModelComboBox;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private ComboBox dataSourceDd;
        private Panel panel1;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1PictureBox c1PictureBox2;
        private C1.Win.Input.C1TextBox c1TextBox1;
        private C1.Win.Input.C1PictureBox settingsPictureIcon;
        private C1.Win.Input.C1PictureBox sendPictureIcon;
        private C1.Win.Input.C1PictureBox clearPictureIcon;
        private C1.Win.Input.C1PictureBox i_Icon;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
