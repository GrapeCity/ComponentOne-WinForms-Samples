namespace CustomIcons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Minimized = true;
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(800, 34);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Items.Add(this.cmbTheme);
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.TextAreaWidth = 120;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 34);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.RowHeight = 17;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(800, 416);
            this.c1TrueDBGrid1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1TrueDBGrid1, "(default)");
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Custom icons";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}

