namespace DashboardWinForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._toolBar = new C1.Win.Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.cmdDashboard = new C1.Win.Command.C1Command();
            this.cmdAnalysis = new C1.Win.Command.C1Command();
            this.cmdReporting = new C1.Win.Command.C1Command();
            this.cmdTasks = new C1.Win.Command.C1Command();
            this.cmdProducts = new C1.Win.Command.C1Command();
            this.c1CommandMenu1 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnHamb = new System.Windows.Forms.Button();
            this._panMain = new System.Windows.Forms.Panel();
            this._labCaption = new System.Windows.Forms.Label();
            this._picSpinner = new System.Windows.Forms.PictureBox();
            this._panControl = new System.Windows.Forms.Panel();
            this._panToolBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picSpinner)).BeginInit();
            this._panToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolBar
            // 
            this._toolBar.AccessibleName = "Tool Bar";
            this._toolBar.AutoSize = false;
            this._toolBar.ButtonAlign = System.Drawing.StringAlignment.Near;
            this._toolBar.ButtonLayoutVert = C1.Win.Command.ButtonLayoutEnum.TextOnRight;
            this._toolBar.ButtonLookVert = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this._toolBar.CommandHolder = this.c1CommandHolder1;
            this._toolBar.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5});
            this._toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._toolBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._toolBar.Horizontal = false;
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._toolBar.MinButtonSize = 50;
            this._toolBar.Movable = false;
            this._toolBar.Name = "_toolBar";
            this._toolBar.ShowToolTips = false;
            this._toolBar.Size = new System.Drawing.Size(300, 405);
            this._toolBar.Text = "c1ToolBar1";
            this.c1ThemeController1.SetTheme(this._toolBar, "Office2016DarkGray");
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.cmdDashboard);
            this.c1CommandHolder1.Commands.Add(this.cmdAnalysis);
            this.c1CommandHolder1.Commands.Add(this.cmdReporting);
            this.c1CommandHolder1.Commands.Add(this.cmdTasks);
            this.c1CommandHolder1.Commands.Add(this.cmdProducts);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu1);
            this.c1CommandHolder1.ImageList = this.imageList1;
            this.c1CommandHolder1.Owner = this;
            // 
            // cmdDashboard
            // 
            this.cmdDashboard.Image = global::DashboardWinForms.Properties.Resources._24X24_Dashboard;
            this.cmdDashboard.Name = "cmdDashboard";
            this.cmdDashboard.ShortcutText = "";
            this.cmdDashboard.Text = "Dashboard";
            this.cmdDashboard.Click += new C1.Win.Command.ClickEventHandler(this.cmd_Click);
            // 
            // cmdAnalysis
            // 
            this.cmdAnalysis.Image = global::DashboardWinForms.Properties.Resources._24X24_Analysis;
            this.cmdAnalysis.Name = "cmdAnalysis";
            this.cmdAnalysis.ShortcutText = "";
            this.cmdAnalysis.Text = "Analysis";
            this.cmdAnalysis.Click += new C1.Win.Command.ClickEventHandler(this.cmd_Click);
            // 
            // cmdReporting
            // 
            this.cmdReporting.Image = global::DashboardWinForms.Properties.Resources._24X24_Reporting;
            this.cmdReporting.Name = "cmdReporting";
            this.cmdReporting.ShortcutText = "";
            this.cmdReporting.Text = "Reporting";
            this.cmdReporting.Click += new C1.Win.Command.ClickEventHandler(this.cmd_Click);
            // 
            // cmdTasks
            // 
            this.cmdTasks.Image = global::DashboardWinForms.Properties.Resources._24X24_Tasks;
            this.cmdTasks.Name = "cmdTasks";
            this.cmdTasks.ShortcutText = "";
            this.cmdTasks.Text = "Tasks";
            this.cmdTasks.Click += new C1.Win.Command.ClickEventHandler(this.cmd_Click);
            // 
            // cmdProducts
            // 
            this.cmdProducts.Image = global::DashboardWinForms.Properties.Resources._24X24_Products;
            this.cmdProducts.Name = "cmdProducts";
            this.cmdProducts.ShortcutText = "";
            this.cmdProducts.Text = "Products";
            this.cmdProducts.Click += new C1.Win.Command.ClickEventHandler(this.cmd_Click);
            // 
            // c1CommandMenu1
            // 
            this.c1CommandMenu1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink6});
            this.c1CommandMenu1.Name = "c1CommandMenu1";
            this.c1CommandMenu1.ShortcutText = "";
            this.c1ThemeController1.SetTheme(this.c1CommandMenu1, "(default)");
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Text = "New Command";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "24X24_Dashboard.png");
            this.imageList1.Images.SetKeyName(1, "24X24_Analysis.png");
            this.imageList1.Images.SetKeyName(2, "24X24_Reporting.png");
            this.imageList1.Images.SetKeyName(3, "24X24_Products.png");
            this.imageList1.Images.SetKeyName(4, "24X24_Tasks.png");
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.cmdDashboard;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.cmdAnalysis;
            this.c1CommandLink2.SortOrder = 1;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.cmdReporting;
            this.c1CommandLink3.SortOrder = 2;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.cmdTasks;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.cmdProducts;
            this.c1CommandLink5.SortOrder = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this._btnHamb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1695, 85);
            this.panel1.TabIndex = 13;
            this.c1ThemeController1.SetTheme(this.panel1, "VS2013Light");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashboardWinForms.Properties.Resources.AcmeLogo_vertical_100px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(90, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // _btnHamb
            // 
            this._btnHamb.BackColor = System.Drawing.Color.Transparent;
            this._btnHamb.FlatAppearance.BorderSize = 0;
            this._btnHamb.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._btnHamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnHamb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._btnHamb.Location = new System.Drawing.Point(3, 3);
            this._btnHamb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnHamb.Name = "_btnHamb";
            this._btnHamb.Size = new System.Drawing.Size(72, 77);
            this._btnHamb.TabIndex = 12;
            this._btnHamb.Text = "S";
            this._btnHamb.UseVisualStyleBackColor = true;
            this._btnHamb.Click += new System.EventHandler(this._btnHamb_Click);
            // 
            // _panMain
            // 
            this._panMain.BackColor = System.Drawing.Color.White;
            this._panMain.Controls.Add(this._labCaption);
            this._panMain.Controls.Add(this._picSpinner);
            this._panMain.Controls.Add(this._panControl);
            this._panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panMain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this._panMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._panMain.Location = new System.Drawing.Point(300, 85);
            this._panMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._panMain.Name = "_panMain";
            this._panMain.Size = new System.Drawing.Size(1395, 1177);
            this._panMain.TabIndex = 14;
            this.c1ThemeController1.SetTheme(this._panMain, "Office2016Colorful");
            this._panMain.Resize += new System.EventHandler(this._panMain_Resize);
            // 
            // _labCaption
            // 
            this._labCaption.AutoSize = true;
            this._labCaption.BackColor = System.Drawing.Color.White;
            this._labCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._labCaption.Location = new System.Drawing.Point(9, 5);
            this._labCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labCaption.Name = "_labCaption";
            this._labCaption.Size = new System.Drawing.Size(0, 47);
            this._labCaption.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this._labCaption, "Office2016Colorful");
            // 
            // _picSpinner
            // 
            this._picSpinner.Image = global::DashboardWinForms.Properties.Resources.loading_transparent;
            this._picSpinner.Location = new System.Drawing.Point(280, 177);
            this._picSpinner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picSpinner.Name = "_picSpinner";
            this._picSpinner.Size = new System.Drawing.Size(60, 62);
            this._picSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picSpinner.TabIndex = 0;
            this._picSpinner.TabStop = false;
            // 
            // _panControl
            // 
            this._panControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panControl.BackColor = System.Drawing.Color.White;
            this._panControl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this._panControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._panControl.Location = new System.Drawing.Point(0, 57);
            this._panControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._panControl.Name = "_panControl";
            this._panControl.Size = new System.Drawing.Size(1395, 1120);
            this._panControl.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this._panControl, "Office2016Colorful");
            // 
            // _panToolBar
            // 
            this._panToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this._panToolBar.Controls.Add(this._toolBar);
            this._panToolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this._panToolBar.ForeColor = System.Drawing.Color.White;
            this._panToolBar.Location = new System.Drawing.Point(0, 85);
            this._panToolBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._panToolBar.Name = "_panToolBar";
            this._panToolBar.Size = new System.Drawing.Size(300, 1177);
            this._panToolBar.TabIndex = 15;
            this.c1ThemeController1.SetTheme(this._panToolBar, "Office2016DarkGray");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1995, 1262);
            this.Controls.Add(this._panMain);
            this.Controls.Add(this._panToolBar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1522, 1148);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.c1ThemeController1.SetTheme(this, "Office2016DarkGray");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._panMain.ResumeLayout(false);
            this._panMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picSpinner)).EndInit();
            this._panToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Command.C1ToolBar _toolBar;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1Command cmdDashboard;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1Command cmdAnalysis;
        private C1.Win.Command.C1Command cmdReporting;
        private C1.Win.Command.C1Command cmdTasks;
        private C1.Win.Command.C1Command cmdProducts;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Command.C1CommandMenu c1CommandMenu1;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private System.Windows.Forms.Button _btnHamb;
        private System.Windows.Forms.Panel _panMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox _picSpinner;
        private System.Windows.Forms.Panel _panToolBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _labCaption;
        private System.Windows.Forms.Panel _panControl;
    }
}

