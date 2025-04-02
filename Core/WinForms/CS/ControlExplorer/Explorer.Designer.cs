namespace ControlExplorer
{
    partial class Explorer
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
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings1 = new C1.Win.Themes.C1Office365ThemeSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings2 = new C1.Win.Themes.C1Office365ThemeSettings();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            sidebar = new ControlExplorer.Controls.SideBar();
            panel1 = new System.Windows.Forms.Panel();
            homePageControl1 = new ControlExplorer.Controls.HomePageControl();
            demoViewer1 = new ControlExplorer.Controls.DemoViewer();
            c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(sidebar, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1691, 948);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sidebar
            // 
            sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sidebar.Collapsed = false;
            sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            sidebar.Location = new System.Drawing.Point(2, 3);
            sidebar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            sidebar.Name = "sidebar";
            sidebar.Samples = null;
            sidebar.Size = new System.Drawing.Size(474, 942);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(homePageControl1);
            panel1.Controls.Add(demoViewer1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(481, 4);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1207, 940);
            panel1.TabIndex = 1;
            // 
            // homePageControl1
            // 
            homePageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            homePageControl1.Location = new System.Drawing.Point(0, 0);
            homePageControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            homePageControl1.Name = "homePageControl1";
            homePageControl1.Padding = new System.Windows.Forms.Padding(30, 29, 30, 29);
            homePageControl1.Samples = null;
            homePageControl1.Size = new System.Drawing.Size(1207, 940);
            homePageControl1.TabIndex = 1;
            // 
            // demoViewer1
            // 
            demoViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            demoViewer1.Location = new System.Drawing.Point(0, 0);
            demoViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            demoViewer1.Name = "demoViewer1";
            demoViewer1.Size = new System.Drawing.Size(1207, 940);
            demoViewer1.TabIndex = 0;
            // 
            // c1ThemeController1
            // 
            c1ThemeController1.Theme = "Office365White";
            c1Office365ThemeSettings1.AccentColor = System.Drawing.Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings1.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            c1ThemeController1.ThemeSettings = c1Office365ThemeSettings1;
            // 
            // Explorer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1691, 948);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MinimumSize = new System.Drawing.Size(1699, 987);
            Name = "Explorer";
            Text = "ComponentOne | Winforms Control Explorer";
            c1ThemeController1.SetTheme(this, "Office365White");
            c1Office365ThemeSettings2.AccentColor = System.Drawing.Color.FromArgb(0, 95, 184);
            c1Office365ThemeSettings2.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings2.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            c1ThemeController1.SetThemeSettings(this, c1Office365ThemeSettings2);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.SideBar sidebar;
        private System.Windows.Forms.Panel panel1;
        private Controls.HomePageControl homePageControl1;
        private Controls.DemoViewer demoViewer1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}