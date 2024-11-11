namespace UsingUIElementResolver
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
            C1.Win.C1DynamicHelp.MapItem mapItem1 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem2 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem3 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem4 = new C1.Win.C1DynamicHelp.MapItem();
            this.ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton9 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonCheckBox1 = new C1.Win.Ribbon.RibbonCheckBox();
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonButton6 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton7 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton8 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonButton1
            // 
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem1.ShowDefaultTopicFirst = true;
            mapItem1.UIElement = this.ribbonButton1;
            mapItem1.Url = "WordDocuments/howtousec1dynamichelp.htm";
            mapItem1.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.ribbonButton1, mapItem1);
            this.ribbonButton1.ID = "ribbonButton1";
            this.ribbonButton1.Text = "How to use C1DynamicHelp";
            // 
            // ribbonButton9
            // 
            mapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem2.ShowDefaultTopicFirst = true;
            mapItem2.UIElement = this.ribbonButton9;
            mapItem2.Url = "WordDocuments/overview.htm";
            mapItem2.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.ribbonButton9, mapItem2);
            this.ribbonButton9.ID = "ribbonButton9";
            this.ribbonButton9.Text = "Overview";
            // 
            // ribbonCheckBox1
            // 
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem3.ShowDefaultTopicFirst = true;
            mapItem3.UIElement = this.ribbonCheckBox1;
            mapItem3.Url = "WordDocuments/glossaryofterms.htm";
            mapItem3.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.ribbonCheckBox1, mapItem3);
            this.ribbonCheckBox1.ID = "ribbonCheckBox1";
            this.ribbonCheckBox1.Text = "Show the Glossary topic";
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DynamicHelp1.HelpSource = "C1Sample.chm";
            this.c1DynamicHelp1.Location = new System.Drawing.Point(0, 141);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(495, 245);
            this.c1DynamicHelp1.TabIndex = 0;
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.MinimumHeight = 10;
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(495, 141);
            this.c1Ribbon1.TabIndex = 1;
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.HideTabHeaderRow = true;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.ID = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton6);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton7);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton8);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.ID = "ribbonButton6";
            this.ribbonButton6.LargeImage = global::UsingUIElementResolver.Properties.Resources.save;
            this.ribbonButton6.Text = "Button";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.ID = "ribbonButton7";
            this.ribbonButton7.LargeImage = global::UsingUIElementResolver.Properties.Resources.redo;
            this.ribbonButton7.Text = "Button";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.ID = "ribbonButton8";
            this.ribbonButton8.LargeImage = global::UsingUIElementResolver.Properties.Resources.undo;
            this.ribbonButton8.Text = "Button";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.ID = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.ID = "ribbonQat1";
            this.ribbonQat1.ItemLinks.Add(this.ribbonButton6);
            this.ribbonQat1.ItemLinks.Add(this.ribbonButton7);
            this.ribbonQat1.ItemLinks.Add(this.ribbonButton8);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.ID = "ribbonTab1";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.ID = "ribbonGroup1";
            this.ribbonGroup1.Items.Add(this.ribbonButton9);
            this.ribbonGroup1.Items.Add(this.ribbonButton1);
            this.ribbonGroup1.Items.Add(this.ribbonCheckBox1);
            this.ribbonGroup1.Text = "Point the mouse to the ribbon items above to see help topics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 386);
            this.Controls.Add(this.c1DynamicHelp1);
            this.Controls.Add(this.c1Ribbon1);
            mapItem4.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem4.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem4.ShowDefaultTopicFirst = true;
            mapItem4.UIElement = this;
            mapItem4.Url = "WordDocuments/overview.htm";
            mapItem4.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this, mapItem4);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Using a custom UIElmentResolver";
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonButton ribbonButton6;
        private C1.Win.Ribbon.RibbonButton ribbonButton7;
        private C1.Win.Ribbon.RibbonButton ribbonButton8;
        private C1.Win.Ribbon.RibbonButton ribbonButton9;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBox1;
    }
}

