

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._btnHamb = new System.Windows.Forms.Button();
            this.accordionAreaCT1 = new FinancialChartExplorer.CustomControls.AccordionAreaCT();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSampleDescription = new System.Windows.Forms.Label();
            this._toggleBtn = new C1.Win.Input.C1Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSample = new System.Windows.Forms.Panel();
            this.labelSampleHeader = new System.Windows.Forms.Label();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.richTextBoxSampleDescription = new C1.Win.Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._toggleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBoxSampleDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this._btnHamb);
            this.splitContainer1.Panel1.Controls.Add(this.accordionAreaCT1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.splitContainer1.Panel2MinSize = 20;
            this.splitContainer1.Size = new System.Drawing.Size(1314, 754);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // _btnHamb
            // 
            this._btnHamb.BackColor = System.Drawing.Color.Transparent;
            this._btnHamb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnHamb.FlatAppearance.BorderSize = 0;
            this._btnHamb.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._btnHamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnHamb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._btnHamb.Location = new System.Drawing.Point(17, 16);
            this._btnHamb.Margin = new System.Windows.Forms.Padding(4);
            this._btnHamb.Name = "_btnHamb";
            this._btnHamb.Size = new System.Drawing.Size(48, 40);
            this._btnHamb.TabIndex = 12;
            this._btnHamb.Text = "S";
            this._btnHamb.UseVisualStyleBackColor = true;
            this._btnHamb.Click += new System.EventHandler(this.BtnHamb_Click);
            // 
            // accordionAreaCT1
            // 
            this.accordionAreaCT1.AccordionFont = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionAreaCT1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accordionAreaCT1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accordionAreaCT1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionAreaCT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accordionAreaCT1.Location = new System.Drawing.Point(6, 79);
            this.accordionAreaCT1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accordionAreaCT1.Name = "accordionAreaCT1";
            this.accordionAreaCT1.Size = new System.Drawing.Size(265, 661);
            this.accordionAreaCT1.TabIndex = 13;
            this.accordionAreaCT1.Child_Clicked_Callback += new AccordionAreaCT.FinalClickEventHandler(this.AccordionChild_Clicked_Callback);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelSampleDescription);
            this.panel1.Controls.Add(this._toggleBtn);
            this.panel1.Controls.Add(this.panelSample);
            this.panel1.Controls.Add(this.labelSampleHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 729);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // labelSampleDescription
            // 
            this.labelSampleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSampleDescription.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelSampleDescription.Location = new System.Drawing.Point(49, 136);
            this.labelSampleDescription.Name = "labelSampleDescription";
            this.labelSampleDescription.Size = new System.Drawing.Size(925, 98);
            this.labelSampleDescription.TabIndex = 6;
            this.labelSampleDescription.Text = "Sample Description";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dark.png");
            this.imageList1.Images.SetKeyName(1, "light (2).png");
            // 
            // _toggleBtn
            // 
            this._toggleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._toggleBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._toggleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._toggleBtn.ImageList = this.imageList1;
            this._toggleBtn.ImageIndex = 1;
            this._toggleBtn.Location = new System.Drawing.Point(829, 50);
            this._toggleBtn.Margin = new System.Windows.Forms.Padding(4);
            this._toggleBtn.Name = "_toggleBtn";
            this._toggleBtn.Size = new System.Drawing.Size(163, 33);
            this._toggleBtn.TabIndex = 4;
            this._toggleBtn.Text = "Toggle Theme";
            this.c1ThemeController1.SetTheme(this._toggleBtn, "(default)");
            this._toggleBtn.Click += new System.EventHandler(this.ToggleBtn_Click);
            // 
            // panelSample
            // 
            this.panelSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSample.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSample.Location = new System.Drawing.Point(54, 238);
            this.panelSample.Margin = new System.Windows.Forms.Padding(4);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(948, 444);
            this.panelSample.TabIndex = 2;
            // 
            // labelSampleHeader
            // 
            this.labelSampleHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSampleHeader.AutoSize = true;
            this.labelSampleHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold);
            this.labelSampleHeader.Location = new System.Drawing.Point(44, 66);
            this.labelSampleHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSampleHeader.Name = "labelSampleHeader";
            this.labelSampleHeader.Size = new System.Drawing.Size(336, 58);
            this.labelSampleHeader.TabIndex = 0;
            this.labelSampleHeader.Text = "Sample Header";
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365White";
            // 
            // richTextBoxSampleDescription
            // 
            this.richTextBoxSampleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSampleDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSampleDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.richTextBoxSampleDescription.Location = new System.Drawing.Point(50, 131);
            this.richTextBoxSampleDescription.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.richTextBoxSampleDescription.Multiline = true;
            this.richTextBoxSampleDescription.Name = "richTextBoxSampleDescription";
            this.richTextBoxSampleDescription.Placeholder = "Sample Description";
            this.richTextBoxSampleDescription.Size = new System.Drawing.Size(901, 104);
            this.richTextBoxSampleDescription.TabIndex = 5;
            this.richTextBoxSampleDescription.Tag = null;
            this.c1ThemeController1.SetTheme(this.richTextBoxSampleDescription, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 754);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "FinancialChart Explorer";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._toggleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBoxSampleDescription)).EndInit();
            this.ResumeLayout(false);

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

