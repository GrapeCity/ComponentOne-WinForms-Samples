namespace DashboardWinForms
{
    partial class Reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporting));
            this.c1FlexReport1 = new C1.Win.FlexReport.C1FlexReport();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexReport1
            // 
            this.c1FlexReport1.ReportDefinition = resources.GetString("c1FlexReport1.ReportDefinition");
            this.c1FlexReport1.ReportName = "c1FlexReport1";
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.BackColor = System.Drawing.Color.White;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.Location = new System.Drawing.Point(15, 16);
            this.c1DockingTab1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(1702, 1063);
            this.c1DockingTab1.TabIndex = 1;
            this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.User;
            this.c1DockingTab1.TabsShowFocusCues = false;
            this.c1DockingTab1.TabsSpacing = 2;
            this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.c1DockingTab1.TabTextAlignment = System.Drawing.StringAlignment.Center;
            this.c1ThemeController1.SetTheme(this.c1DockingTab1, "(default)");
            this.c1DockingTab1.TabClick += new System.EventHandler(this.c1DockingTab1_TabClick);
            this.c1DockingTab1.MeasureTab += new C1.Win.C1Command.MeasureTabEventHandler(this.c1DockingTab1_MeasureTab);
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage1.Size = new System.Drawing.Size(1700, 1027);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Page1";
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(1700, 1027);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Page2";
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(1700, 1027);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Page3";
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016Colorful";
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1DockingTab1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reporting";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Size = new System.Drawing.Size(1732, 1095);
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.FlexReport.C1FlexReport c1FlexReport1;
        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}
