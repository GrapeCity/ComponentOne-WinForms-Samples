namespace Xml2FlxrConverter
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._btnSelectFiles = new System.Windows.Forms.Button();
            this._txtLog = new System.Windows.Forms.TextBox();
            this._txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnOutputFolder = new System.Windows.Forms.Button();
            this._btnConvert = new System.Windows.Forms.Button();
            this._lvwXmls = new System.Windows.Forms.ListView();
            this._images = new System.Windows.Forms.ImageList(this.components);
            this._flxr = new C1.Win.FlexReport.C1FlexReport();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnSelectFiles
            // 
            this._btnSelectFiles.Location = new System.Drawing.Point(14, 15);
            this._btnSelectFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnSelectFiles.Name = "_btnSelectFiles";
            this._btnSelectFiles.Size = new System.Drawing.Size(250, 36);
            this._btnSelectFiles.TabIndex = 0;
            this._btnSelectFiles.Text = "Add C1Report definition files to convert";
            this._btnSelectFiles.UseVisualStyleBackColor = true;
            this._btnSelectFiles.Click += new System.EventHandler(this._btnSelectFiles_Click);
            // 
            // _txtLog
            // 
            this._txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtLog.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLog.Location = new System.Drawing.Point(0, 267);
            this._txtLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.ReadOnly = true;
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtLog.Size = new System.Drawing.Size(798, 300);
            this._txtLog.TabIndex = 1;
            // 
            // _txtOutputFolder
            // 
            this._txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOutputFolder.Location = new System.Drawing.Point(385, 21);
            this._txtOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtOutputFolder.Name = "_txtOutputFolder";
            this._txtOutputFolder.Size = new System.Drawing.Size(370, 23);
            this._txtOutputFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output folder:";
            // 
            // _btnOutputFolder
            // 
            this._btnOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOutputFolder.Location = new System.Drawing.Point(758, 21);
            this._btnOutputFolder.Margin = new System.Windows.Forms.Padding(0);
            this._btnOutputFolder.Name = "_btnOutputFolder";
            this._btnOutputFolder.Size = new System.Drawing.Size(29, 23);
            this._btnOutputFolder.TabIndex = 3;
            this._btnOutputFolder.Text = "...";
            this._btnOutputFolder.UseVisualStyleBackColor = true;
            this._btnOutputFolder.Click += new System.EventHandler(this._btnOutputFolder_Click);
            // 
            // _btnConvert
            // 
            this._btnConvert.Location = new System.Drawing.Point(14, 69);
            this._btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnConvert.Name = "_btnConvert";
            this._btnConvert.Size = new System.Drawing.Size(250, 36);
            this._btnConvert.TabIndex = 5;
            this._btnConvert.Text = "Convert!";
            this._btnConvert.UseVisualStyleBackColor = true;
            this._btnConvert.Click += new System.EventHandler(this._btnConvert_Click);
            // 
            // _lvwXmls
            // 
            this._lvwXmls.CheckBoxes = true;
            this._lvwXmls.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvwXmls.Location = new System.Drawing.Point(10, 0);
            this._lvwXmls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._lvwXmls.Name = "_lvwXmls";
            this._lvwXmls.ShowItemToolTips = true;
            this._lvwXmls.Size = new System.Drawing.Size(778, 143);
            this._lvwXmls.SmallImageList = this._images;
            this._lvwXmls.TabIndex = 0;
            this._lvwXmls.UseCompatibleStateImageBehavior = false;
            this._lvwXmls.View = System.Windows.Forms.View.List;
            // 
            // _images
            // 
            this._images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_images.ImageStream")));
            this._images.TransparentColor = System.Drawing.Color.Transparent;
            this._images.Images.SetKeyName(0, "Error");
            // 
            // _flxr
            // 
            this._flxr.ReportDefinition = resources.GetString("_flxr.ReportDefinition");
            this._flxr.ReportName = "c1FlexReport1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 267);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(798, 12);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._lvwXmls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(798, 143);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnConvert);
            this.panel2.Controls.Add(this._txtOutputFolder);
            this.panel2.Controls.Add(this._btnSelectFiles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._btnOutputFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 124);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 567);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._txtLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(814, 606);
            this.Name = "MainForm";
            this.Text = "C1Report .XML to FlexReport Batch Converter";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSelectFiles;
        private System.Windows.Forms.TextBox _txtLog;
        private System.Windows.Forms.TextBox _txtOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnOutputFolder;
        private System.Windows.Forms.Button _btnConvert;
        private System.Windows.Forms.ListView _lvwXmls;
        private System.Windows.Forms.ImageList _images;
        private C1.Win.FlexReport.C1FlexReport _flxr;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

