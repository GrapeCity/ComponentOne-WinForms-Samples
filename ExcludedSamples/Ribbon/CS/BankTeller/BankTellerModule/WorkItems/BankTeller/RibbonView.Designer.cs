namespace BankTellerModule
{
    partial class RibbonView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonView));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.aboutButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.exitButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.minimizeRibbonButton = new C1.Win.C1Ribbon.RibbonButton();
            this.expandRibbonButton = new C1.Win.C1Ribbon.RibbonButton();
            this.helpConfigButton = new C1.Win.C1Ribbon.RibbonButton();
            this.selectionCTG = new C1.Win.C1Ribbon.RibbonContextualTabGroup();
            this.customerTab = new C1.Win.C1Ribbon.RibbonTab();
            this.actionsGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.saveButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator2 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.editButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator3 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.commentsButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.rbAcceptCustomer = new C1.Win.C1Ribbon.RibbonButton();
            this.bankTab = new C1.Win.C1Ribbon.RibbonTab();
            this.queueGroup = new C1.Win.C1Ribbon.RibbonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.ContextualTabGroups.Add(this.selectionCTG);
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(637, 156);
            this.c1Ribbon1.Tabs.Add(this.bankTab);
            this.c1Ribbon1.MinimizedChanged += new System.EventHandler(this.c1Ribbon1_MinimizedChanged);
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.DropDownWidth = 179;
            this.ribbonApplicationMenu1.KeyTip = "F";
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.aboutButton);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonSeparator1);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.exitButton);
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Text = "File";
            this.ribbonApplicationMenu1.Win7Look = true;
            // 
            // aboutButton
            // 
            this.aboutButton.KeyTip = "A";
            this.aboutButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.LargeImage")));
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.SmallImage")));
            this.aboutButton.Text = "&About Bank Teller...";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // exitButton
            // 
            this.exitButton.KeyTip = "X";
            this.exitButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("exitButton.LargeImage")));
            this.exitButton.Name = "exitButton";
            this.exitButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("exitButton.SmallImage")));
            this.exitButton.Text = "E&xit";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Items.Add(this.minimizeRibbonButton);
            this.ribbonConfigToolBar1.Items.Add(this.expandRibbonButton);
            this.ribbonConfigToolBar1.Items.Add(this.helpConfigButton);
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // minimizeRibbonButton
            // 
            this.minimizeRibbonButton.KeyTip = "M";
            this.minimizeRibbonButton.Name = "minimizeRibbonButton";
            this.minimizeRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("minimizeRibbonButton.SmallImage")));
            this.minimizeRibbonButton.ToolTip = "Minimize the Ribbon";
            this.minimizeRibbonButton.Click += new System.EventHandler(this.minimizeRibbonButton_Click);
            // 
            // expandRibbonButton
            // 
            this.expandRibbonButton.KeyTip = "M";
            this.expandRibbonButton.Name = "expandRibbonButton";
            this.expandRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("expandRibbonButton.SmallImage")));
            this.expandRibbonButton.ToolTip = "Expand the Ribbon";
            this.expandRibbonButton.Visible = false;
            this.expandRibbonButton.Click += new System.EventHandler(this.expandRibbonButton_Click);
            // 
            // helpConfigButton
            // 
            this.helpConfigButton.KeyTip = "H";
            this.helpConfigButton.Name = "helpConfigButton";
            this.helpConfigButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("helpConfigButton.SmallImage")));
            this.helpConfigButton.ToolTip = "Help";
            // 
            // selectionCTG
            // 
            this.selectionCTG.Name = "selectionCTG";
            this.selectionCTG.Tabs.Add(this.customerTab);
            this.selectionCTG.Text = "Selection";
            // 
            // customerTab
            // 
            this.customerTab.Groups.Add(this.actionsGroup);
            this.customerTab.KeyTip = "C";
            this.customerTab.Name = "customerTab";
            this.customerTab.Text = "Customer";
            // 
            // actionsGroup
            // 
            this.actionsGroup.Items.Add(this.saveButton);
            this.actionsGroup.Items.Add(this.ribbonSeparator2);
            this.actionsGroup.Items.Add(this.editButton);
            this.actionsGroup.Items.Add(this.ribbonSeparator3);
            this.actionsGroup.Items.Add(this.commentsButton);
            this.actionsGroup.Name = "actionsGroup";
            this.actionsGroup.Text = "Actions";
            // 
            // saveButton
            // 
            this.saveButton.KeyTip = "S";
            this.saveButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveButton.LargeImage")));
            this.saveButton.Name = "saveButton";
            this.saveButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("saveButton.SmallImage")));
            this.saveButton.Text = "Save Changes";
            this.saveButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
            this.saveButton.ToolTip = "Save Customer Data";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // editButton
            // 
            this.editButton.KeyTip = "E";
            this.editButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("editButton.LargeImage")));
            this.editButton.Name = "editButton";
            this.editButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("editButton.SmallImage")));
            this.editButton.Text = "Edit Summary";
            this.editButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
            this.editButton.ToolTip = "Edit Customer Summary";
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // commentsButton
            // 
            this.commentsButton.KeyTip = "C";
            this.commentsButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("commentsButton.LargeImage")));
            this.commentsButton.Name = "commentsButton";
            this.commentsButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("commentsButton.SmallImage")));
            this.commentsButton.Text = "Add Comments";
            this.commentsButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
            this.commentsButton.ToolTip = "Add or Edit Comments";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.ItemLinks.Add(this.rbAcceptCustomer);
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // rbAcceptCustomer
            // 
            this.rbAcceptCustomer.KeyTip = "A";
            this.rbAcceptCustomer.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbAcceptCustomer.LargeImage")));
            this.rbAcceptCustomer.Name = "rbAcceptCustomer";
            this.rbAcceptCustomer.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAcceptCustomer.SmallImage")));
            this.rbAcceptCustomer.Text = "Accept Customer";
            this.rbAcceptCustomer.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
            this.rbAcceptCustomer.ToolTip = "Accept New Customer";
            // 
            // bankTab
            // 
            this.bankTab.Groups.Add(this.queueGroup);
            this.bankTab.KeyTip = "B";
            this.bankTab.Name = "bankTab";
            this.bankTab.Text = "Bank";
            // 
            // queueGroup
            // 
            this.queueGroup.Items.Add(this.rbAcceptCustomer);
            this.queueGroup.Name = "queueGroup";
            this.queueGroup.Text = "Queue";
            // 
            // RibbonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "RibbonView";
            this.Size = new System.Drawing.Size(637, 199);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab bankTab;
        private C1.Win.C1Ribbon.RibbonGroup queueGroup;
        private C1.Win.C1Ribbon.RibbonButton exitButton;
        private C1.Win.C1Ribbon.RibbonButton aboutButton;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonButton rbAcceptCustomer;
        private C1.Win.C1Ribbon.RibbonButton minimizeRibbonButton;
        private C1.Win.C1Ribbon.RibbonButton expandRibbonButton;
        private C1.Win.C1Ribbon.RibbonButton helpConfigButton;
        private C1.Win.C1Ribbon.RibbonContextualTabGroup selectionCTG;
        private C1.Win.C1Ribbon.RibbonTab customerTab;
        private C1.Win.C1Ribbon.RibbonGroup actionsGroup;
        private C1.Win.C1Ribbon.RibbonButton saveButton;
        private C1.Win.C1Ribbon.RibbonButton editButton;
        private C1.Win.C1Ribbon.RibbonButton commentsButton;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator3;
    }
}
