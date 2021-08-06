//----------------------------------------------------------------------------
// AppAboutForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace C1.Util.Licensing
{
    partial class AppAboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppAboutForm));
            this._prodName = new System.Windows.Forms.Label();
            this._txtVersionInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._copyright = new System.Windows.Forms.Label();
            this._btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._panelResources = new System.Windows.Forms.Panel();
            this._lblResources = new System.Windows.Forms.Label();
            this._panelLinks = new System.Windows.Forms.Panel();
            this._linkHome = new System.Windows.Forms.LinkLabel();
            this._lblContactUs = new System.Windows.Forms.Label();
            this._lblSalesInfo = new System.Windows.Forms.Label();
            this._panelGC = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._linkGC = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pictureBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this._panelResources.SuspendLayout();
            this._panelLinks.SuspendLayout();
            this._panelGC.SuspendLayout();
            this.SuspendLayout();
            // 
            // _prodName
            // 
            this._prodName.AutoSize = true;
            this._prodName.BackColor = System.Drawing.Color.White;
            this._prodName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prodName.ForeColor = System.Drawing.Color.Black;
            this._prodName.Location = new System.Drawing.Point(3, 90);
            this._prodName.Name = "_prodName";
            this._prodName.Padding = new System.Windows.Forms.Padding(4);
            this._prodName.Size = new System.Drawing.Size(196, 40);
            this._prodName.TabIndex = 0;
            this._prodName.Text = "ComponentOne";
            this._prodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtVersionInfo
            // 
            this._txtVersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtVersionInfo.BackColor = System.Drawing.Color.White;
            this._txtVersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtVersionInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtVersionInfo.Location = new System.Drawing.Point(13, 133);
            this._txtVersionInfo.Multiline = true;
            this._txtVersionInfo.Name = "_txtVersionInfo";
            this._txtVersionInfo.ReadOnly = true;
            this._txtVersionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtVersionInfo.Size = new System.Drawing.Size(617, 81);
            this._txtVersionInfo.TabIndex = 26;
            this._txtVersionInfo.TabStop = false;
            this._txtVersionInfo.Text = "Version Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Controls.Add(this._copyright);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(15, 18, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(646, 87);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // _copyright
            // 
            this._copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._copyright.Font = new System.Drawing.Font("Verdana", 7F);
            this._copyright.ForeColor = System.Drawing.Color.Black;
            this._copyright.Location = new System.Drawing.Point(234, 21);
            this._copyright.Name = "_copyright";
            this._copyright.Size = new System.Drawing.Size(286, 58);
            this._copyright.TabIndex = 7;
            this._copyright.Text = "Copyright (c) 2001-{0} GrapeCity, Inc.\r\nAll rights reserved.";
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(549, 331);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(80, 44);
            this._btnOk.TabIndex = 0;
            this._btnOk.Text = "OK";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._btnOk);
            this.panel1.Controls.Add(this._panelResources);
            this.panel1.Controls.Add(this._prodName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this._txtVersionInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 399);
            this.panel1.TabIndex = 29;
            // 
            // _panelResources
            // 
            this._panelResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this._panelResources.Controls.Add(this._lblResources);
            this._panelResources.Controls.Add(this._panelLinks);
            this._panelResources.Controls.Add(this._panelGC);
            this._panelResources.Location = new System.Drawing.Point(0, 220);
            this._panelResources.Name = "_panelResources";
            this._panelResources.Size = new System.Drawing.Size(641, 84);
            this._panelResources.TabIndex = 29;
            // 
            // _lblResources
            // 
            this._lblResources.Location = new System.Drawing.Point(18, 7);
            this._lblResources.Name = "_lblResources";
            this._lblResources.Size = new System.Drawing.Size(108, 15);
            this._lblResources.TabIndex = 7;
            this._lblResources.Text = "CONTACT US:";
            // 
            // _panelLinks
            // 
            this._panelLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelLinks.Controls.Add(this._linkHome);
            this._panelLinks.Controls.Add(this._lblContactUs);
            this._panelLinks.Controls.Add(this._lblSalesInfo);
            this._panelLinks.Location = new System.Drawing.Point(141, 0);
            this._panelLinks.Name = "_panelLinks";
            this._panelLinks.Padding = new System.Windows.Forms.Padding(6);
            this._panelLinks.Size = new System.Drawing.Size(500, 81);
            this._panelLinks.TabIndex = 3;
            // 
            // _linkHome
            // 
            this._linkHome.AutoSize = true;
            this._linkHome.Dock = System.Windows.Forms.DockStyle.Top;
            this._linkHome.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkHome.Location = new System.Drawing.Point(6, 6);
            this._linkHome.Name = "_linkHome";
            this._linkHome.Size = new System.Drawing.Size(185, 17);
            this._linkHome.TabIndex = 8;
            this._linkHome.TabStop = true;
            this._linkHome.Tag = "default.aspx";
            this._linkHome.Text = "www.grapecity.com/en/componentone";
            this._linkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resource_LinkClicked);
            // 
            // _lblContactUs
            // 
            this._lblContactUs.AutoSize = true;
            this._lblContactUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._lblContactUs.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblContactUs.Location = new System.Drawing.Point(6, 24);
            this._lblContactUs.Name = "_lblContactUs";
            this._lblContactUs.Size = new System.Drawing.Size(283, 51);
            this._lblContactUs.TabIndex = 9;
            this._lblContactUs.Text = "GrapeCity\r\n201 South Highland Avenue, Suite 301\r\nPittsburgh, PA 15206";
            // 
            // _lblSalesInfo
            // 
            this._lblSalesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblSalesInfo.AutoSize = true;
            this._lblSalesInfo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSalesInfo.Location = new System.Drawing.Point(295, 23);
            this._lblSalesInfo.Name = "_lblSalesInfo";
            this._lblSalesInfo.Size = new System.Drawing.Size(170, 45);
            this._lblSalesInfo.TabIndex = 10;
			this._lblSalesInfo.Text = "\r\nPhone: 1.800.858.2739\r\nus.sales@grapecity.com";
            // 
            this._panelGC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelGC.Controls.Add(this.label2);
            this._panelGC.Controls.Add(this.label1);
            this._panelGC.Controls.Add(this._linkGC);
            this._panelGC.Location = new System.Drawing.Point(141, 0);
            this._panelGC.Name = "_panelGC";
            this._panelGC.Padding = new System.Windows.Forms.Padding(6);
            this._panelGC.Size = new System.Drawing.Size(500, 81);
            this._panelGC.TabIndex = 3;
            this._panelGC.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "981-3205  宮城県仙台市泉区紫山3-1-4\r\ne-mail: sales@grapecity.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "グレープシティ株式会社";
            // 
            // _linkGC
            // 
            this._linkGC.AutoSize = true;
            this._linkGC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._linkGC.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkGC.Location = new System.Drawing.Point(6, 61);
            this._linkGC.Name = "_linkGC";
            this._linkGC.Size = new System.Drawing.Size(158, 14);
            this._linkGC.TabIndex = 0;
            this._linkGC.TabStop = true;
            this._linkGC.Text = "http://c1.grapecity.com/";
            this._linkGC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkGC_LinkClicked);
            // 
            // AppAboutForm
            // 
            this.AcceptButton = this._btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this._btnOk;
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppAboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pictureBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panelResources.ResumeLayout(false);
            this._panelLinks.ResumeLayout(false);
            this._panelLinks.PerformLayout();
            this._panelGC.ResumeLayout(false);
            this._panelGC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label _prodName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.Label _copyright;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _panelResources;
        private System.Windows.Forms.Label _lblResources;
        private System.Windows.Forms.Panel _panelGC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel _linkGC;
        private System.Windows.Forms.Panel _panelLinks;
        private System.Windows.Forms.LinkLabel _linkHome;
        private System.Windows.Forms.Label _lblContactUs;
        private System.Windows.Forms.Label _lblSalesInfo;
        private System.Windows.Forms.TextBox _txtVersionInfo;
    }
}
