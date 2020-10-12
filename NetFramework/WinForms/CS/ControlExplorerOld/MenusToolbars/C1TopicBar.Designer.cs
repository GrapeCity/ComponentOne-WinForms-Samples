namespace ControlExplorer.MenusToolbars
{
    partial class C1TopicBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1TopicBar));
            C1.Win.C1Command.C1TopicPage c1TopicPage1 = new C1.Win.C1Command.C1TopicPage();
            C1.Win.C1Command.C1TopicLink c1TopicLink1 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink2 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink3 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicPage c1TopicPage2 = new C1.Win.C1Command.C1TopicPage();
            C1.Win.C1Command.C1TopicLink c1TopicLink4 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink5 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink6 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicPage c1TopicPage3 = new C1.Win.C1Command.C1TopicPage();
            C1.Win.C1Command.C1TopicLink c1TopicLink7 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink8 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink9 = new C1.Win.C1Command.C1TopicLink();
            C1.Win.C1Command.C1TopicLink c1TopicLink10 = new C1.Win.C1Command.C1TopicLink();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1TopicBar1 = new C1.Win.C1Command.C1TopicBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1TopicBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Computer.png");
            this.imageList1.Images.SetKeyName(1, "Options.png");
            this.imageList1.Images.SetKeyName(2, "Install.png");
            this.imageList1.Images.SetKeyName(3, "Finish.png");
            this.imageList1.Images.SetKeyName(4, "WebGlobe.png");
            this.imageList1.Images.SetKeyName(5, "Network.png");
            this.imageList1.Images.SetKeyName(6, "FolderClosed.png");
            this.imageList1.Images.SetKeyName(7, "Settings.png");
            this.imageList1.Images.SetKeyName(8, "Rename.png");
            this.imageList1.Images.SetKeyName(9, "Copy.png");
            this.imageList1.Images.SetKeyName(10, "SendMail.png");
            this.imageList1.Images.SetKeyName(11, "Delete.png");
            // 
            // c1TopicBar1
            // 
            this.c1TopicBar1.AutoScrollMinSize = new System.Drawing.Size(0, 375);
            this.c1TopicBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1TopicBar1.ImageList = this.imageList1;
            this.c1TopicBar1.Location = new System.Drawing.Point(0, 0);
            this.c1TopicBar1.Name = "c1TopicBar1";
            this.c1TopicBar1.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            c1TopicPage1.ImageIndex = 0;
            c1TopicPage1.ImageList = this.imageList1;
            c1TopicLink1.ImageIndex = 1;
            c1TopicLink1.Text = "View System Information";
            c1TopicLink2.ImageIndex = 2;
            c1TopicLink2.Text = "Add or remove programs";
            c1TopicLink3.ImageIndex = 3;
            c1TopicLink3.Text = "Change a setting";
            c1TopicPage1.Links.Add(c1TopicLink1);
            c1TopicPage1.Links.Add(c1TopicLink2);
            c1TopicPage1.Links.Add(c1TopicLink3);
            c1TopicPage1.Text = "System Tasks";
            c1TopicPage2.ImageIndex = 4;
            c1TopicPage2.ImageList = this.imageList1;
            c1TopicLink4.ImageIndex = 5;
            c1TopicLink4.Text = "My Network Places";
            c1TopicLink5.ImageIndex = 6;
            c1TopicLink5.Text = "My Documents";
            c1TopicLink6.ImageIndex = 7;
            c1TopicLink6.Text = "Control Panel";
            c1TopicPage2.Links.Add(c1TopicLink4);
            c1TopicPage2.Links.Add(c1TopicLink5);
            c1TopicPage2.Links.Add(c1TopicLink6);
            c1TopicPage2.Text = "Other Places";
            c1TopicPage3.ImageList = this.imageList1;
            c1TopicLink7.ImageIndex = 8;
            c1TopicLink7.Text = "Rename this file";
            c1TopicLink8.ImageIndex = 9;
            c1TopicLink8.Text = "Copy this file";
            c1TopicLink9.ImageIndex = 10;
            c1TopicLink9.Text = "E-mail this file";
            c1TopicLink10.ImageIndex = 11;
            c1TopicLink10.Text = "Delete this file";
            c1TopicPage3.Links.Add(c1TopicLink7);
            c1TopicPage3.Links.Add(c1TopicLink8);
            c1TopicPage3.Links.Add(c1TopicLink9);
            c1TopicPage3.Links.Add(c1TopicLink10);
            c1TopicPage3.SpecialStyle = true;
            c1TopicPage3.Text = "File and Folder Tasks";
            this.c1TopicBar1.Pages.Add(c1TopicPage1);
            this.c1TopicBar1.Pages.Add(c1TopicPage2);
            this.c1TopicBar1.Pages.Add(c1TopicPage3);
            this.c1TopicBar1.Size = new System.Drawing.Size(281, 549);
            this.c1TopicBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.c1TopicBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(281, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 549);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // C1TopicBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1TopicBar1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "C1TopicBar";
            this.Text = "C1TopicBar";
            this.Load += new System.EventHandler(this.C1TopicBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TopicBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1TopicBar c1TopicBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Splitter splitter1;
    }
}