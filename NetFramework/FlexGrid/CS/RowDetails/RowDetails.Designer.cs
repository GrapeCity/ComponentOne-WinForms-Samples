using System;
using System.Drawing;

namespace RowDetails
{
    partial class RowDetails
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
            this.dockingTab = new C1.Win.C1Command.C1DockingTab();
            this.pageInputPanel = new C1.Win.C1Command.C1DockingTabPage();
            this.inputPanelSample = new InputPanelSample();
            this.pageFlexGrid = new C1.Win.C1Command.C1DockingTabPage();
            this.flexGridSample = new FlexGridSample();
            this.pageInheritance = new C1.Win.C1Command.C1DockingTabPage();
            this.inheritanceSample = new InheritanceSample();
            this.pageCustom = new C1.Win.C1Command.C1DockingTabPage();
            this.customSample = new CustomSample();
            this.themePicker = new C1.Win.C1Themes.C1ThemePicker();
            this.themeController = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).BeginInit();
            this.dockingTab.SuspendLayout();
            this.pageInputPanel.SuspendLayout();
            this.pageFlexGrid.SuspendLayout();
            this.pageInheritance.SuspendLayout();
            this.pageCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingTab
            // 
            this.dockingTab.BackColor = System.Drawing.Color.White;
            this.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTab.Controls.Add(this.pageInputPanel);
            this.dockingTab.Controls.Add(this.pageFlexGrid);
            this.dockingTab.Controls.Add(this.pageInheritance);
            this.dockingTab.Controls.Add(this.pageCustom);
            this.dockingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dockingTab.HotTrack = true;
            this.dockingTab.Location = new System.Drawing.Point(0, 0);
            this.dockingTab.Name = "dockingTab";
            this.dockingTab.Padding = new System.Drawing.Point(6, 6);
            this.dockingTab.Size = new System.Drawing.Size(779, 605);
            this.dockingTab.TabIndex = 0;
            this.dockingTab.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.dockingTab.TabsShowFocusCues = false;
            this.dockingTab.TabsSpacing = 2;
            this.dockingTab.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.dockingTab.TabTextAlignment = System.Drawing.StringAlignment.Near;
            this.themeController.SetTheme(this.dockingTab, "(default)");
            // 
            // pageInputPanel
            // 
            this.pageInputPanel.Controls.Add(this.inputPanelSample);
            this.pageInputPanel.Location = new System.Drawing.Point(1, 35);
            this.pageInputPanel.Name = "pageInputPanel";
            this.pageInputPanel.Size = new System.Drawing.Size(777, 569);
            this.pageInputPanel.TabIndex = 0;
            this.pageInputPanel.Text = "InputPanel";
            // 
            // inputPanelSample
            // 
            this.inputPanelSample.BackColor = System.Drawing.Color.White;
            this.inputPanelSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanelSample.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.inputPanelSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.inputPanelSample.Location = new System.Drawing.Point(0, 0);
            this.inputPanelSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPanelSample.Name = "inputPanelSample";
            this.inputPanelSample.Size = new System.Drawing.Size(777, 569);
            this.inputPanelSample.TabIndex = 0;
            this.themeController.SetTheme(this.inputPanelSample, "(default)");
            // 
            // pageFlexGrid
            // 
            this.pageFlexGrid.Controls.Add(this.flexGridSample);
            this.pageFlexGrid.Location = new System.Drawing.Point(1, 35);
            this.pageFlexGrid.Name = "pageFlexGrid";
            this.pageFlexGrid.Size = new System.Drawing.Size(777, 569);
            this.pageFlexGrid.TabIndex = 1;
            this.pageFlexGrid.Text = "FlexGrid";
            // 
            // flexGridSample
            // 
            this.flexGridSample.BackColor = System.Drawing.Color.White;
            this.flexGridSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGridSample.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.flexGridSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGridSample.Location = new System.Drawing.Point(0, 0);
            this.flexGridSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexGridSample.Name = "flexGridSample";
            this.flexGridSample.Size = new System.Drawing.Size(777, 569);
            this.flexGridSample.TabIndex = 0;
            this.themeController.SetTheme(this.flexGridSample, "(default)");
            // 
            // pageInheritance
            // 
            this.pageInheritance.Controls.Add(this.inheritanceSample);
            this.pageInheritance.Location = new System.Drawing.Point(1, 35);
            this.pageInheritance.Name = "pageInheritance";
            this.pageInheritance.Size = new System.Drawing.Size(777, 569);
            this.pageInheritance.TabIndex = 3;
            this.pageInheritance.Text = "Inheritance";
            // 
            // inheritanceSample
            // 
            this.inheritanceSample.BackColor = System.Drawing.Color.White;
            this.inheritanceSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inheritanceSample.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.inheritanceSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.inheritanceSample.Location = new System.Drawing.Point(0, 0);
            this.inheritanceSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inheritanceSample.Name = "inheritanceSample";
            this.inheritanceSample.Size = new System.Drawing.Size(777, 569);
            this.inheritanceSample.TabIndex = 0;
            this.themeController.SetTheme(this.inheritanceSample, "(default)");
            // 
            // pageCustom
            // 
            this.pageCustom.Controls.Add(this.customSample);
            this.pageCustom.Location = new System.Drawing.Point(1, 35);
            this.pageCustom.Name = "pageCustom";
            this.pageCustom.Size = new System.Drawing.Size(777, 569);
            this.pageCustom.TabIndex = 2;
            this.pageCustom.Text = "Custom";
            // 
            // customSample
            // 
            this.customSample.BackColor = System.Drawing.Color.White;
            this.customSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customSample.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.customSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.customSample.Location = new System.Drawing.Point(0, 0);
            this.customSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customSample.Name = "customSample";
            this.customSample.Size = new System.Drawing.Size(777, 569);
            this.customSample.TabIndex = 0;
            this.themeController.SetTheme(this.customSample, "(default)");
            // 
            // themePicker
            // 
            this.themePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.themePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themePicker.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.themePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.themePicker.Location = new System.Drawing.Point(625, 5);
            this.themePicker.Name = "themePicker";
            this.themePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.themePicker.SelectedThemeName = "Office365Green";
            this.themePicker.Size = new System.Drawing.Size(150, 23);
            this.themePicker.Style.DropDownBackColor = System.Drawing.Color.White;
            this.themePicker.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro;
            this.themePicker.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.themePicker.TabIndex = 0;
            this.themeController.SetTheme(this.themePicker, "(default)");
            this.themePicker.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // RowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(779, 605);
            this.Controls.Add(this.themePicker);
            this.Controls.Add(this.dockingTab);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "RowDetails";
            this.Text = "RowDetails";
            this.themeController.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).EndInit();
            this.dockingTab.ResumeLayout(false);
            this.pageInputPanel.ResumeLayout(false);
            this.pageFlexGrid.ResumeLayout(false);
            this.pageInheritance.ResumeLayout(false);
            this.pageCustom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.themePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private C1.Win.C1Command.C1DockingTab dockingTab;
        private C1.Win.C1Command.C1DockingTabPage pageInputPanel;
        private C1.Win.C1Command.C1DockingTabPage pageFlexGrid;
        private C1.Win.C1Command.C1DockingTabPage pageInheritance;
        private C1.Win.C1Command.C1DockingTabPage pageCustom;
        private C1.Win.C1Themes.C1ThemePicker themePicker;
        private C1.Win.C1Themes.C1ThemeController themeController;
        private InputPanelSample inputPanelSample;
        private FlexGridSample flexGridSample;
        private CustomSample customSample;
        private InheritanceSample inheritanceSample;
    }
}

