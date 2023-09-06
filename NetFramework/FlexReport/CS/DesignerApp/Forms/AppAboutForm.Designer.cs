//----------------------------------------------------------------------------
// AppAboutForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
            _prodName = new System.Windows.Forms.Label();
            _txtVersionInfo = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            _copyright = new System.Windows.Forms.Label();
            _btnOk = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            _panelResources = new System.Windows.Forms.Panel();
            _lblResources = new System.Windows.Forms.Label();
            _panelLinks = new System.Windows.Forms.Panel();
            _linkHome = new System.Windows.Forms.LinkLabel();
            _panelMescius = new System.Windows.Forms.Panel();
            _linkMescius = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pictureBox2.SuspendLayout();
            panel1.SuspendLayout();
            _panelResources.SuspendLayout();
            _panelLinks.SuspendLayout();
            _panelMescius.SuspendLayout();
            SuspendLayout();
            // 
            // _prodName
            // 
            _prodName.AutoSize = true;
            _prodName.BackColor = System.Drawing.Color.White;
            _prodName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            _prodName.ForeColor = System.Drawing.Color.Black;
            _prodName.Location = new System.Drawing.Point(3, 96);
            _prodName.Name = "_prodName";
            _prodName.Padding = new System.Windows.Forms.Padding(4);
            _prodName.Size = new System.Drawing.Size(156, 33);
            _prodName.TabIndex = 0;
            _prodName.Text = "ComponentOne";
            _prodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtVersionInfo
            // 
            _txtVersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _txtVersionInfo.BackColor = System.Drawing.Color.White;
            _txtVersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _txtVersionInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _txtVersionInfo.Location = new System.Drawing.Point(13, 142);
            _txtVersionInfo.Multiline = true;
            _txtVersionInfo.Name = "_txtVersionInfo";
            _txtVersionInfo.ReadOnly = true;
            _txtVersionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            _txtVersionInfo.Size = new System.Drawing.Size(617, 83);
            _txtVersionInfo.TabIndex = 26;
            _txtVersionInfo.TabStop = false;
            _txtVersionInfo.Text = "Version Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(246, 250, 253);
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(646, 93);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += Mover_MouseDown;
            pictureBox1.MouseMove += Mover_MouseMove;
            pictureBox1.MouseUp += Mover_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox2.BackColor = System.Drawing.Color.White;
            pictureBox2.Controls.Add(_copyright);
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(0, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new System.Windows.Forms.Padding(15, 18, 0, 0);
            pictureBox2.Size = new System.Drawing.Size(646, 92);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // _copyright
            // 
            _copyright.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _copyright.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _copyright.ForeColor = System.Drawing.Color.Black;
            _copyright.Location = new System.Drawing.Point(234, 22);
            _copyright.Name = "_copyright";
            _copyright.Size = new System.Drawing.Size(286, 62);
            _copyright.TabIndex = 7;
            _copyright.Text = "Copyright (c) 2001-{0} Mescius, Inc.\r\nAll rights reserved.";
            // 
            // _btnOk
            // 
            _btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _btnOk.BackColor = System.Drawing.Color.FromArgb(247, 248, 248);
            _btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            _btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            _btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            _btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            _btnOk.ForeColor = System.Drawing.Color.Black;
            _btnOk.Location = new System.Drawing.Point(549, 289);
            _btnOk.Name = "_btnOk";
            _btnOk.Size = new System.Drawing.Size(80, 47);
            _btnOk.TabIndex = 0;
            _btnOk.Text = "OK";
            _btnOk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(_btnOk);
            panel1.Controls.Add(_panelResources);
            panel1.Controls.Add(_prodName);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(_txtVersionInfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(646, 360);
            panel1.TabIndex = 29;
            // 
            // _panelResources
            // 
            _panelResources.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _panelResources.BackColor = System.Drawing.Color.FromArgb(246, 250, 253);
            _panelResources.Controls.Add(_lblResources);
            _panelResources.Controls.Add(_panelLinks);
            _panelResources.Controls.Add(_panelMescius);
            _panelResources.Location = new System.Drawing.Point(0, 231);
            _panelResources.Name = "_panelResources";
            _panelResources.Size = new System.Drawing.Size(641, 32);
            _panelResources.TabIndex = 29;
            // 
            // _lblResources
            // 
            _lblResources.Location = new System.Drawing.Point(18, 7);
            _lblResources.Name = "_lblResources";
            _lblResources.Size = new System.Drawing.Size(108, 16);
            _lblResources.TabIndex = 7;
            _lblResources.Text = "CONTACT US:";
            // 
            // _panelLinks
            // 
            _panelLinks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _panelLinks.Controls.Add(_linkHome);
            _panelLinks.Location = new System.Drawing.Point(141, 0);
            _panelLinks.Name = "_panelLinks";
            _panelLinks.Padding = new System.Windows.Forms.Padding(6);
            _panelLinks.Size = new System.Drawing.Size(500, 30);
            _panelLinks.TabIndex = 3;
            // 
            // _linkHome
            // 
            _linkHome.AutoSize = true;
            _linkHome.Dock = System.Windows.Forms.DockStyle.Top;
            _linkHome.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _linkHome.Location = new System.Drawing.Point(6, 6);
            _linkHome.Name = "_linkHome";
            _linkHome.Size = new System.Drawing.Size(229, 13);
            _linkHome.TabIndex = 8;
            _linkHome.TabStop = true;
            _linkHome.Tag = "default.aspx";
            _linkHome.Text = "developer.mescius.com/componentone";
            _linkHome.LinkClicked += resource_LinkClicked;
            // 
            // _panelMescius
            // 
            _panelMescius.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _panelMescius.Controls.Add(_linkMescius);
            _panelMescius.Location = new System.Drawing.Point(141, 0);
            _panelMescius.Name = "_panelMescius";
            _panelMescius.Padding = new System.Windows.Forms.Padding(6);
            _panelMescius.Size = new System.Drawing.Size(500, 30);
            _panelMescius.TabIndex = 3;
            _panelMescius.Visible = false;
            // 
            // _linkMescius
            // 
            _linkMescius.AutoSize = true;
            _linkMescius.Dock = System.Windows.Forms.DockStyle.Top;
            _linkMescius.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _linkMescius.Location = new System.Drawing.Point(6, 6);
            _linkMescius.Name = "_linkMescius";
            _linkMescius.Size = new System.Drawing.Size(313, 12);
            _linkMescius.TabIndex = 0;
            _linkMescius.TabStop = true;
            _linkMescius.Text = "https://developer.mescius.jp/developer/componentone";
            _linkMescius.LinkClicked += _linkMescius_LinkClicked;
            // 
            // AppAboutForm
            // 
            AcceptButton = _btnOk;
            AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            CancelButton = _btnOk;
            ClientSize = new System.Drawing.Size(646, 360);
            Controls.Add(panel1);
            ForeColor = System.Drawing.Color.Black;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppAboutForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About...";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pictureBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            _panelResources.ResumeLayout(false);
            _panelLinks.ResumeLayout(false);
            _panelLinks.PerformLayout();
            _panelMescius.ResumeLayout(false);
            _panelMescius.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Panel _panelLinks;
        private System.Windows.Forms.LinkLabel _linkHome;
        private System.Windows.Forms.TextBox _txtVersionInfo;
        private System.Windows.Forms.Panel _panelMescius;
        private System.Windows.Forms.LinkLabel _linkMescius;
    }
}

