using FlexReportExplorer.Properties;
using System.Windows.Forms;
namespace FlexReportExplorer
{
    partial class MainForm
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
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings8 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings2 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings3 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings7 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings5 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings6 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings1 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings4 = new C1.Win.Themes.C1Office365ThemeSettings();
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings9 = new C1.Win.Themes.C1Office365ThemeSettings();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.flxViewer = new C1.Win.FlexViewer.C1FlexViewer();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.accordionArea1 = new FlexReportExplorer.AccordionArea();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flxViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.c1ThemeController1.SetTheme(this.splitContainer1, "Office365White");
            c1Office365ThemeSettings8.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings8.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.splitContainer1, c1Office365ThemeSettings8);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Name = "label2";
            this.c1ThemeController1.SetTheme(this.label2, "Office365White");
            c1Office365ThemeSettings2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings2.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.label2, c1Office365ThemeSettings2);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Name = "label1";
            this.c1ThemeController1.SetTheme(this.label1, "Office365White");
            c1Office365ThemeSettings3.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings3.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.label1, c1Office365ThemeSettings3);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.accordionArea1);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flxViewer);
            this.c1ThemeController1.SetTheme(this.splitContainer2, "Office365White");
            c1Office365ThemeSettings7.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings7.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.splitContainer2, c1Office365ThemeSettings7);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.Name = "label3";
            this.c1ThemeController1.SetTheme(this.label3, "Office365Green");
            c1Office365ThemeSettings5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(72)))));
            c1Office365ThemeSettings5.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.label3, c1Office365ThemeSettings5);
            // 
            // flxViewer
            // 
            resources.ApplyResources(this.flxViewer, "flxViewer");
            this.flxViewer.Name = "flxViewer";
            this.flxViewer.OutlineBackColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flxViewer.OutlineBackColorHotSelected = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.flxViewer.OutlineBackColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.flxViewer.OutlineButtonBackColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flxViewer.OutlineButtonBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.flxViewer.OutlineButtonForeColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.flxViewer.OutlineButtonForeColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.flxViewer.OutlineButtonForeColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.flxViewer.OutlineForeColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.flxViewer.OutlineForeColorHotSelected = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.flxViewer.OutlineForeColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.flxViewer.OutlineForeColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.flxViewer.OutlineLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.flxViewer.ParamHeaderBackColor = System.Drawing.Color.White;
            this.flxViewer.ParamHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.flxViewer.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.c1ThemeController1.SetTheme(this.flxViewer, "Office365White");
            c1Office365ThemeSettings6.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings6.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.flxViewer, c1Office365ThemeSettings6);
            this.flxViewer.ThumbAreaBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flxViewer.ThumbBackColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flxViewer.ThumbBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.flxViewer.ThumbBackColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365White";
            c1Office365ThemeSettings1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings1.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.ThemeSettings = c1Office365ThemeSettings1;
            // 
            // accordionArea1
            // 
            resources.ApplyResources(this.accordionArea1, "accordionArea1");
            this.accordionArea1.BackColor = System.Drawing.Color.White;
            this.accordionArea1.ContentHeight = 0;
            this.accordionArea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accordionArea1.Name = "accordionArea1";
            this.accordionArea1.NodeCollapseHeight = 50;
            this.c1ThemeController1.SetTheme(this.accordionArea1, "Office365White");
            c1Office365ThemeSettings4.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings4.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this.accordionArea1, c1Office365ThemeSettings4);
            this.accordionArea1.ChildClickedEvent += new System.EventHandler(this.Accordion_Child_Clicked);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.c1ThemeController1.SetTheme(this, "Office365White");
            c1Office365ThemeSettings9.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings9.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.SetThemeSettings(this, c1Office365ThemeSettings9);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flxViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.FlexReport.C1FlexReport flxRpt;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Label label2;
        private Label label3;
        private C1.Win.FlexViewer.C1FlexViewer flxViewer;
        private AccordionArea accordionArea1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}