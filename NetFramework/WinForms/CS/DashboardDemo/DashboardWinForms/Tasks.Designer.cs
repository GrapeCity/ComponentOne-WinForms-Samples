﻿namespace DashboardWinForms
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            C1.Win.C1Themes.C1MaterialThemeSettings c1MaterialThemeSettings1 = new C1.Win.C1Themes.C1MaterialThemeSettings();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._flexGroupPanel = new C1.Win.C1FlexGrid.C1FlexGridGroupPanel();
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1DockingTabPage4 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1DockingTabPage5 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.BackColor = System.Drawing.Color.White;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage4);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage5);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(1155, 761);
            this.c1DockingTab1.TabIndex = 0;
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
            this.c1DockingTabPage1.Controls.Add(this._flex);
            this.c1DockingTabPage1.Controls.Add(this._flexGroupPanel);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage1.Size = new System.Drawing.Size(1153, 725);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Page1";
            // 
            // _flex
            // 
            this._flex.BackColor = System.Drawing.Color.White;
            this._flex.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:19;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this._flex.HideGroupedColumns = true;
            this._flex.Location = new System.Drawing.Point(10, 44);
            this._flex.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 35;
            this._flex.Size = new System.Drawing.Size(1133, 671);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.TabStop = false;
            this.c1ThemeController1.SetTheme(this._flex, "Material");
            c1MaterialThemeSettings1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings1.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this._flex, c1MaterialThemeSettings1);
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            // 
            // _flexGroupPanel
            // 
            this._flexGroupPanel.AutoSize = true;
            this._flexGroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._flexGroupPanel.FlexGrid = this._flex;
            this._flexGroupPanel.Location = new System.Drawing.Point(10, 10);
            this._flexGroupPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._flexGroupPanel.MaxGroups = 3;
            this._flexGroupPanel.Name = "_flexGroupPanel";
            this._flexGroupPanel.Size = new System.Drawing.Size(1133, 34);
            this._flexGroupPanel.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this._flexGroupPanel, "(default)");
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage2.Size = new System.Drawing.Size(1153, 725);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Page2";
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage3.Size = new System.Drawing.Size(1153, 725);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Page3";
            // 
            // c1DockingTabPage4
            // 
            this.c1DockingTabPage4.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage4.Name = "c1DockingTabPage4";
            this.c1DockingTabPage4.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage4.Size = new System.Drawing.Size(1153, 725);
            this.c1DockingTabPage4.TabIndex = 3;
            this.c1DockingTabPage4.Text = "Page4";
            // 
            // c1DockingTabPage5
            // 
            this.c1DockingTabPage5.Location = new System.Drawing.Point(1, 35);
            this.c1DockingTabPage5.Name = "c1DockingTabPage5";
            this.c1DockingTabPage5.Padding = new System.Windows.Forms.Padding(10);
            this.c1DockingTabPage5.Size = new System.Drawing.Size(1153, 725);
            this.c1DockingTabPage5.TabIndex = 4;
            this.c1DockingTabPage5.Text = "Page5";
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016Colorful";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1DockingTab1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tasks";
            this.Size = new System.Drawing.Size(1155, 761);
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            this.c1DockingTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage4;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage5;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1FlexGrid.C1FlexGridGroupPanel _flexGroupPanel;
    }
}
