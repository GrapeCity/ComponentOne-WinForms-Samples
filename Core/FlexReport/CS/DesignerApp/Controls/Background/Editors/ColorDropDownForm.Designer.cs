//----------------------------------------------------------------------------
// ColorDropDownForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Background.Editors
{
    partial class ColorDropDownForm
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
            this.dtMain = new C1.Win.Command.C1DockingTab();
            this.dtpWebColors = new C1.Win.Command.C1DockingTabPage();
            this.clbWebColors = new FlexReportDesignerApp.Controls.Background.ColorListBox();
            this.dtpSystemColors = new C1.Win.Command.C1DockingTabPage();
            this.clbSystemColors = new FlexReportDesignerApp.Controls.Background.ColorListBox();
            this.dtpCustom = new C1.Win.Command.C1DockingTabPage();
            this.customColorEditor1 = new FlexReportDesignerApp.Controls.Background.CustomColorEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
            this.dtMain.SuspendLayout();
            this.dtpWebColors.SuspendLayout();
            this.dtpSystemColors.SuspendLayout();
            this.dtpCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMain
            // 
            this.dtMain.Controls.Add(this.dtpWebColors);
            this.dtMain.Controls.Add(this.dtpSystemColors);
            this.dtMain.Controls.Add(this.dtpCustom);
            this.dtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMain.Location = new System.Drawing.Point(0, 0);
            this.dtMain.Name = "dtMain";
            this.dtMain.SelectedIndex = 3;
            this.dtMain.Size = new System.Drawing.Size(300, 380);
            this.dtMain.TabIndex = 1;
            this.dtMain.TabsCanFocus = false;
            // 
            // dtpWebColors
            // 
            this.dtpWebColors.Controls.Add(this.clbWebColors);
            this.dtpWebColors.Location = new System.Drawing.Point(1, 23);
            this.dtpWebColors.Name = "dtpWebColors";
            this.dtpWebColors.Size = new System.Drawing.Size(298, 356);
            this.dtpWebColors.TabIndex = 0;
            this.dtpWebColors.Text = "Web";
            // 
            // clbWebColors
            // 
            this.clbWebColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbWebColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbWebColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clbWebColors.FormattingEnabled = true;
            this.clbWebColors.IntegralHeight = false;
            this.clbWebColors.ItemHeight = 18;
            this.clbWebColors.Location = new System.Drawing.Point(0, 0);
            this.clbWebColors.Name = "clbWebColors";
            this.clbWebColors.Size = new System.Drawing.Size(298, 356);
            this.clbWebColors.TabIndex = 0;
            this.clbWebColors.SelectedIndexChanged += new System.EventHandler(this.clbWebColors_SelectedIndexChanged);
            this.clbWebColors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbWebColors_MouseUp);
            // 
            // dtpSystemColors
            // 
            this.dtpSystemColors.Controls.Add(this.clbSystemColors);
            this.dtpSystemColors.Location = new System.Drawing.Point(1, 23);
            this.dtpSystemColors.Name = "dtpSystemColors";
            this.dtpSystemColors.Size = new System.Drawing.Size(298, 356);
            this.dtpSystemColors.TabIndex = 1;
            this.dtpSystemColors.Text = "System";
            // 
            // clbSystemColors
            // 
            this.clbSystemColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSystemColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSystemColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clbSystemColors.FormattingEnabled = true;
            this.clbSystemColors.IntegralHeight = false;
            this.clbSystemColors.ItemHeight = 18;
            this.clbSystemColors.Location = new System.Drawing.Point(0, 0);
            this.clbSystemColors.Name = "clbSystemColors";
            this.clbSystemColors.Size = new System.Drawing.Size(298, 356);
            this.clbSystemColors.TabIndex = 0;
            this.clbSystemColors.SelectedIndexChanged += new System.EventHandler(this.clbSystemColors_SelectedIndexChanged);
            this.clbSystemColors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbSystemColors_MouseUp);
            // 
            // dtpCustom
            // 
            this.dtpCustom.BackColor = System.Drawing.SystemColors.Control;
            this.dtpCustom.Controls.Add(this.customColorEditor1);
            this.dtpCustom.Location = new System.Drawing.Point(1, 23);
            this.dtpCustom.Name = "dtpCustom";
            this.dtpCustom.Size = new System.Drawing.Size(298, 356);
            this.dtpCustom.TabIndex = 2;
            this.dtpCustom.Text = "Custom";
            // 
            // customColorEditor1
            // 
            this.customColorEditor1.BackColor = System.Drawing.Color.AliceBlue;
            this.customColorEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customColorEditor1.Location = new System.Drawing.Point(0, 0);
            this.customColorEditor1.Name = "customColorEditor1";
            this.customColorEditor1.Size = new System.Drawing.Size(298, 356);
            this.customColorEditor1.TabIndex = 0;
            this.customColorEditor1.ColorSelected += new System.EventHandler(this.customColorEditor1_ColorSelected);
            this.customColorEditor1.ColorChanged += new System.EventHandler(this.customColorEditor1_ColorChanged);
            // 
            // ColorDropDownForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Controls.Add(this.dtMain);
            this.Name = "ColorDropDownForm";
            this.Text = "ColorPickerDropDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).EndInit();
            this.dtMain.ResumeLayout(false);
            this.dtpWebColors.ResumeLayout(false);
            this.dtpSystemColors.ResumeLayout(false);
            this.dtpCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Command.C1DockingTab dtMain;
        private C1.Win.Command.C1DockingTabPage dtpWebColors;
        private ColorListBox clbWebColors;
        private C1.Win.Command.C1DockingTabPage dtpSystemColors;
        private C1.Win.Command.C1DockingTabPage dtpCustom;
        // private System.Windows.Forms.Panel pnlCustomColors;
        private ColorListBox clbSystemColors;
        private CustomColorEditor customColorEditor1;
    }
}
