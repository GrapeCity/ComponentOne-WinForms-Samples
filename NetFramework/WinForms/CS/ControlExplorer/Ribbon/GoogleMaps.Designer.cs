﻿namespace ControlExplorer.Ribbon
{
    partial class GoogleMaps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleMaps));
            this.c1Ribbon = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonAppMenu = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.appExitButton = new C1.Win.Ribbon.RibbonButton();
            this.appHomeButton = new C1.Win.Ribbon.RibbonButton();
            this.appOpenSplitButton = new C1.Win.Ribbon.RibbonSplitButton();
            this.appOpenLabel = new C1.Win.Ribbon.RibbonLabel();
            this.appOpenBaseballButton = new C1.Win.Ribbon.RibbonButton();
            this.appOpenRoute66Button = new C1.Win.Ribbon.RibbonButton();
            this.appRandomButton = new C1.Win.Ribbon.RibbonButton();
            this.appSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.appPrintButton = new C1.Win.Ribbon.RibbonButton();
            this.appSendButton = new C1.Win.Ribbon.RibbonButton();
            this.appSeparator2 = new C1.Win.Ribbon.RibbonSeparator();
            this.appCloseButton = new C1.Win.Ribbon.RibbonButton();
            this.recentLabelListItem = new C1.Win.Ribbon.RibbonListItem();
            this.recentLabel = new C1.Win.Ribbon.RibbonLabel();
            this.recentSeparatorListItem = new C1.Win.Ribbon.RibbonListItem();
            this.recentSeparator = new C1.Win.Ribbon.RibbonSeparator();
            this.ribbonToolBar = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.styleMenu = new C1.Win.Ribbon.RibbonMenu();
            this.ribbonQat = new C1.Win.Ribbon.RibbonQat();
            this.zoomInButton = new C1.Win.Ribbon.RibbonButton();
            this.zoomOutButton = new C1.Win.Ribbon.RibbonButton();
            this.tabHome = new C1.Win.Ribbon.RibbonTab();
            this.mapGroup = new C1.Win.Ribbon.RibbonGroup();
            this.mapToggleGroup = new C1.Win.Ribbon.RibbonToggleGroup();
            this.mapStreetButton = new C1.Win.Ribbon.RibbonToggleButton();
            this.mapSatelliteButton = new C1.Win.Ribbon.RibbonToggleButton();
            this.mapHybridButton = new C1.Win.Ribbon.RibbonToggleButton();
            this.zoomGroup = new C1.Win.Ribbon.RibbonGroup();
            this.panGroup = new C1.Win.Ribbon.RibbonGroup();
            this.panLeftButton = new C1.Win.Ribbon.RibbonButton();
            this.panSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.panUpButton = new C1.Win.Ribbon.RibbonButton();
            this.panDownButton = new C1.Win.Ribbon.RibbonButton();
            this.panSeparator2 = new C1.Win.Ribbon.RibbonSeparator();
            this.panRightButton = new C1.Win.Ribbon.RibbonButton();
            this.findGroup = new C1.Win.Ribbon.RibbonGroup();
            this.findToolbar = new C1.Win.Ribbon.RibbonToolBar();
            this.findEditBox = new C1.Win.Ribbon.RibbonEditBox();
            this.findButton = new C1.Win.Ribbon.RibbonButton();
            this.tabActions = new C1.Win.Ribbon.RibbonTab();
            this.mouseGroup = new C1.Win.Ribbon.RibbonGroup();
            this.mouseDraggingCheckBox = new C1.Win.Ribbon.RibbonCheckBox();
            this.mouseScrollWheelCheckBox = new C1.Win.Ribbon.RibbonCheckBox();
            this.positionGroup = new C1.Win.Ribbon.RibbonGroup();
            this.positionSaveButton = new C1.Win.Ribbon.RibbonButton();
            this.positionRestoreButton = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.c1StatusBar1 = new C1.Win.Ribbon.C1StatusBar();
            this.statusLabel = new C1.Win.Ribbon.RibbonLabel();
            this.statusTrackBar = new C1.Win.Ribbon.RibbonTrackBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon
            // 
            this.c1Ribbon.ApplicationMenuHolder = this.ribbonAppMenu;
            this.c1Ribbon.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon.ConfigToolBarHolder = this.ribbonToolBar;
            this.c1Ribbon.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon.Name = "c1Ribbon";
            this.c1Ribbon.QatHolder = this.ribbonQat;
            this.c1Ribbon.Size = new System.Drawing.Size(1013, 153);
            this.c1Ribbon.Tabs.Add(this.tabHome);
            this.c1Ribbon.Tabs.Add(this.tabActions);
            this.c1Ribbon.TopToolBarHolder = this.ribbonTopToolBar1;            
            this.c1Ribbon.RibbonEvent += this.c1Ribbon_RibbonEvent;
            // 
            // ribbonAppMenu
            // 
            this.ribbonAppMenu.BottomPaneItems.Add(this.appExitButton);
            this.ribbonAppMenu.DropDownWidth = 375;
            this.ribbonAppMenu.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonAppMenu.LargeImage")));
            this.ribbonAppMenu.LeftPaneItems.Add(this.appHomeButton);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appOpenSplitButton);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appRandomButton);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appSeparator1);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appPrintButton);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appSendButton);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appSeparator2);
            this.ribbonAppMenu.LeftPaneItems.Add(this.appCloseButton);
            this.ribbonAppMenu.Name = "ribbonAppMenu";
            this.ribbonAppMenu.RightPaneItems.Add(this.recentLabelListItem);
            this.ribbonAppMenu.RightPaneItems.Add(this.recentSeparatorListItem);
            this.ribbonAppMenu.SmallImage = global::ControlExplorer.Properties.Resources.SearchWeb;
            this.ribbonAppMenu.Text = " ";
            // 
            // appExitButton
            // 
            this.appExitButton.Name = "appExitButton";
            this.appExitButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("appExitButton.SmallImage")));
            this.appExitButton.Text = "Exit";
            // 
            // appHomeButton
            // 
            this.appHomeButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appHomeButton.LargeImage")));
            this.appHomeButton.Name = "appHomeButton";
            this.appHomeButton.Text = "Home";
            this.appHomeButton.Click += new System.EventHandler(this.appHomeButton_Click);
            // 
            // appOpenSplitButton
            // 
            this.appOpenSplitButton.Items.Add(this.appOpenLabel);
            this.appOpenSplitButton.Items.Add(this.appOpenBaseballButton);
            this.appOpenSplitButton.Items.Add(this.appOpenRoute66Button);
            this.appOpenSplitButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appOpenSplitButton.LargeImage")));
            this.appOpenSplitButton.Name = "appOpenSplitButton";
            this.appOpenSplitButton.Text = "Open";
            // 
            // appOpenLabel
            // 
            this.appOpenLabel.Name = "appOpenLabel";
            this.appOpenLabel.Text = "Open location-specific markup (KML)";
            // 
            // appOpenBaseballButton
            // 
            this.appOpenBaseballButton.Description = "Every baseball park in MLB plus the Hall of Fame.";
            this.appOpenBaseballButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appOpenBaseballButton.LargeImage")));
            this.appOpenBaseballButton.Name = "appOpenBaseballButton";
            this.appOpenBaseballButton.Text = "Major League Baseball";
            this.appOpenBaseballButton.Click += new System.EventHandler(this.appOpenButton_Click);
            // 
            // appOpenRoute66Button
            // 
            this.appOpenRoute66Button.Description = "A collection of interviews with the people who live, work, and travel on the old " +
    "road.";
            this.appOpenRoute66Button.LargeImage = ((System.Drawing.Image)(resources.GetObject("appOpenRoute66Button.LargeImage")));
            this.appOpenRoute66Button.Name = "appOpenRoute66Button";
            this.appOpenRoute66Button.Text = "America\'s Highway: Route 66";
            this.appOpenRoute66Button.Click += new System.EventHandler(this.appOpenButton_Click);
            // 
            // appRandomButton
            // 
            this.appRandomButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appRandomButton.LargeImage")));
            this.appRandomButton.Name = "appRandomButton";
            this.appRandomButton.Text = "Random";
            this.appRandomButton.Click += new System.EventHandler(this.appRandomButton_Click);
            // 
            // appSeparator1
            // 
            this.appSeparator1.Name = "appSeparator1";
            // 
            // appPrintButton
            // 
            this.appPrintButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appPrintButton.LargeImage")));
            this.appPrintButton.Name = "appPrintButton";
            this.appPrintButton.Text = "Print";
            this.appPrintButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // appSendButton
            // 
            this.appSendButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appSendButton.LargeImage")));
            this.appSendButton.Name = "appSendButton";
            this.appSendButton.Text = "Send";
            // 
            // appSeparator2
            // 
            this.appSeparator2.Name = "appSeparator2";
            // 
            // appCloseButton
            // 
            this.appCloseButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("appCloseButton.LargeImage")));
            this.appCloseButton.Name = "appCloseButton";
            this.appCloseButton.Text = "Close";
            // 
            // recentLabelListItem
            // 
            this.recentLabelListItem.AllowSelection = false;
            this.recentLabelListItem.Items.Add(this.recentLabel);
            this.recentLabelListItem.Name = "recentLabelListItem";
            // 
            // recentLabel
            // 
            this.recentLabel.Name = "recentLabel";
            this.recentLabel.Text = "Recent Locations";
            // 
            // recentSeparatorListItem
            // 
            this.recentSeparatorListItem.Items.Add(this.recentSeparator);
            this.recentSeparatorListItem.Name = "recentSeparatorListItem";
            // 
            // recentSeparator
            // 
            this.recentSeparator.Name = "recentSeparator";
            // 
            // ribbonToolBar
            // 
            this.ribbonToolBar.Items.Add(this.styleMenu);
            this.ribbonToolBar.Name = "ribbonToolBar";
            // 
            // styleMenu
            // 
            this.styleMenu.Name = "styleMenu";
            this.styleMenu.Text = "Style";
            this.styleMenu.ToolTip = "Change the color scheme";
            // 
            // ribbonQat
            // 
            this.ribbonQat.HotItemLinks.Add(this.appHomeButton);
            this.ribbonQat.HotItemLinks.Add(this.appRandomButton);
            this.ribbonQat.HotItemLinks.Add(this.appPrintButton);
            this.ribbonQat.HotItemLinks.Add(this.zoomInButton);
            this.ribbonQat.HotItemLinks.Add(this.zoomOutButton);
            this.ribbonQat.ItemLinks.Add(this.zoomInButton);
            this.ribbonQat.ItemLinks.Add(this.zoomOutButton);
            this.ribbonQat.Name = "ribbonQat";
            // 
            // zoomInButton
            // 
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("zoomInButton.SmallImage")));
            this.zoomInButton.Text = "Zoom In";
            this.zoomInButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.SmallImage")));
            this.zoomOutButton.Text = "Zoom Out";
            this.zoomOutButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // tabHome
            // 
            this.tabHome.Groups.Add(this.mapGroup);
            this.tabHome.Groups.Add(this.zoomGroup);
            this.tabHome.Groups.Add(this.panGroup);
            this.tabHome.Groups.Add(this.findGroup);
            this.tabHome.Name = "tabHome";
            this.tabHome.Text = "Home";
            // 
            // mapGroup
            // 
            this.mapGroup.Items.Add(this.mapToggleGroup);
            this.mapGroup.Name = "mapGroup";
            this.mapGroup.Text = "Map Type";
            // 
            // mapToggleGroup
            // 
            this.mapToggleGroup.Items.Add(this.mapStreetButton);
            this.mapToggleGroup.Items.Add(this.mapSatelliteButton);
            this.mapToggleGroup.Items.Add(this.mapHybridButton);
            this.mapToggleGroup.Name = "mapToggleGroup";
            this.mapToggleGroup.PressedButtonChanged += new System.EventHandler(this.mapToggleGroup_PressedButtonChanged);
            // 
            // mapStreetButton
            // 
            this.mapStreetButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("mapStreetButton.LargeImage")));
            this.mapStreetButton.Name = "mapStreetButton";
            this.mapStreetButton.Pressed = true;
            this.mapStreetButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("mapStreetButton.SmallImage")));
            this.mapStreetButton.Text = "Street";
            this.mapStreetButton.ToolTip = "Show street map";
            // 
            // mapSatelliteButton
            // 
            this.mapSatelliteButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("mapSatelliteButton.LargeImage")));
            this.mapSatelliteButton.Name = "mapSatelliteButton";
            this.mapSatelliteButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("mapSatelliteButton.SmallImage")));
            this.mapSatelliteButton.Text = "Satellite";
            this.mapSatelliteButton.ToolTip = "Show satellite imagery";
            // 
            // mapHybridButton
            // 
            this.mapHybridButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("mapHybridButton.LargeImage")));
            this.mapHybridButton.Name = "mapHybridButton";
            this.mapHybridButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("mapHybridButton.SmallImage")));
            this.mapHybridButton.Text = "Hybrid";
            this.mapHybridButton.ToolTip = "Show imagery with street names";
            // 
            // zoomGroup
            // 
            this.zoomGroup.Items.Add(this.zoomInButton);
            this.zoomGroup.Items.Add(this.zoomOutButton);
            this.zoomGroup.Name = "zoomGroup";
            this.zoomGroup.Text = "Zoom";
            // 
            // panGroup
            // 
            this.panGroup.Items.Add(this.panLeftButton);
            this.panGroup.Items.Add(this.panSeparator1);
            this.panGroup.Items.Add(this.panUpButton);
            this.panGroup.Items.Add(this.panDownButton);
            this.panGroup.Items.Add(this.panSeparator2);
            this.panGroup.Items.Add(this.panRightButton);
            this.panGroup.Name = "panGroup";
            this.panGroup.Text = "Pan";
            // 
            // panLeftButton
            // 
            this.panLeftButton.Name = "panLeftButton";
            this.panLeftButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("panLeftButton.SmallImage")));
            this.panLeftButton.ToolTip = "Left";
            this.panLeftButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // panSeparator1
            // 
            this.panSeparator1.Name = "panSeparator1";
            // 
            // panUpButton
            // 
            this.panUpButton.Name = "panUpButton";
            this.panUpButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("panUpButton.SmallImage")));
            this.panUpButton.ToolTip = "Up";
            this.panUpButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // panDownButton
            // 
            this.panDownButton.Name = "panDownButton";
            this.panDownButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("panDownButton.SmallImage")));
            this.panDownButton.ToolTip = "Down";
            this.panDownButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // panSeparator2
            // 
            this.panSeparator2.Name = "panSeparator2";
            // 
            // panRightButton
            // 
            this.panRightButton.Name = "panRightButton";
            this.panRightButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("panRightButton.SmallImage")));
            this.panRightButton.ToolTip = "Right";
            this.panRightButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // findGroup
            // 
            this.findGroup.Items.Add(this.findToolbar);
            this.findGroup.Name = "findGroup";
            this.findGroup.Text = "Places and Addresses";
            // 
            // findToolbar
            // 
            this.findToolbar.Items.Add(this.findEditBox);
            this.findToolbar.Items.Add(this.findButton);
            this.findToolbar.Name = "findToolbar";
            // 
            // findEditBox
            // 
            this.findEditBox.Name = "findEditBox";
            this.findEditBox.TextAreaWidth = 248;
            this.findEditBox.ToolTip = "Enter an address, place name, or zip code";
            this.findEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findEditBox_KeyPress);
            // 
            // findButton
            // 
            this.findButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("findButton.LargeImage")));
            this.findButton.Name = "findButton";
            this.findButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("findButton.SmallImage")));
            this.findButton.Text = "Find";
            this.findButton.ToolTip = "Find this location";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // tabActions
            // 
            this.tabActions.Groups.Add(this.mouseGroup);
            this.tabActions.Groups.Add(this.positionGroup);
            this.tabActions.Name = "tabActions";
            this.tabActions.Text = "Actions";
            // 
            // mouseGroup
            // 
            this.mouseGroup.Items.Add(this.mouseDraggingCheckBox);
            this.mouseGroup.Items.Add(this.mouseScrollWheelCheckBox);
            this.mouseGroup.Name = "mouseGroup";
            this.mouseGroup.Text = "Mouse";
            // 
            // mouseDraggingCheckBox
            // 
            this.mouseDraggingCheckBox.Checked = true;
            this.mouseDraggingCheckBox.Name = "mouseDraggingCheckBox";
            this.mouseDraggingCheckBox.Text = "Dragging";
            this.mouseDraggingCheckBox.ToolTip = "Enable panning by dragging the map";
            this.mouseDraggingCheckBox.CheckedChanged += new System.EventHandler(this.ribbonCheckBox_CheckedChanged);
            // 
            // mouseScrollWheelCheckBox
            // 
            this.mouseScrollWheelCheckBox.Name = "mouseScrollWheelCheckBox";
            this.mouseScrollWheelCheckBox.Text = "Scroll Wheel";
            this.mouseScrollWheelCheckBox.ToolTip = "Enable zooming with the mouse wheel";
            this.mouseScrollWheelCheckBox.CheckedChanged += new System.EventHandler(this.ribbonCheckBox_CheckedChanged);
            // 
            // positionGroup
            // 
            this.positionGroup.Items.Add(this.positionSaveButton);
            this.positionGroup.Items.Add(this.positionRestoreButton);
            this.positionGroup.Name = "positionGroup";
            this.positionGroup.Text = "Position";
            // 
            // positionSaveButton
            // 
            this.positionSaveButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("positionSaveButton.LargeImage")));
            this.positionSaveButton.Name = "positionSaveButton";
            this.positionSaveButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("positionSaveButton.SmallImage")));
            this.positionSaveButton.Text = "Save";
            this.positionSaveButton.ToolTip = "Store current map position and zoom level";
            this.positionSaveButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // positionRestoreButton
            // 
            this.positionRestoreButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("positionRestoreButton.LargeImage")));
            this.positionRestoreButton.Name = "positionRestoreButton";
            this.positionRestoreButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("positionRestoreButton.SmallImage")));
            this.positionRestoreButton.Text = "Restore";
            this.positionRestoreButton.ToolTip = "Restore saved map position and zoom level";
            this.positionRestoreButton.Click += new System.EventHandler(this.ribbonItem_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1StatusBar1.LeftPaneItems.Add(this.statusLabel);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 611);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.statusTrackBar);
            this.c1StatusBar1.RightPaneWidth = 100;
            this.c1StatusBar1.Size = new System.Drawing.Size(1013, 22);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Loading...";
            // 
            // statusTrackBar
            // 
            this.statusTrackBar.Maximum = 17;
            this.statusTrackBar.Minimum = 1;
            this.statusTrackBar.Name = "statusTrackBar";
            this.statusTrackBar.StepFrequency = 1;
            this.statusTrackBar.Value = 1;
            this.statusTrackBar.Scroll += new System.EventHandler(this.statusTrackBar_Scroll);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 153);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(1013, 458);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // GoogleMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 633);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.c1Ribbon);
            this.Controls.Add(this.c1StatusBar1);
            this.Name = "GoogleMaps";
            this.Text = "GoogleMaps";
            this.Load += new System.EventHandler(this.GoogleMaps_Load);
            this.Shown += new System.EventHandler(this.RibbonEarthForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonAppMenu;
        private C1.Win.Ribbon.RibbonButton appExitButton;
        private C1.Win.Ribbon.RibbonButton appHomeButton;
        private C1.Win.Ribbon.RibbonSplitButton appOpenSplitButton;
        private C1.Win.Ribbon.RibbonLabel appOpenLabel;
        private C1.Win.Ribbon.RibbonButton appOpenBaseballButton;
        private C1.Win.Ribbon.RibbonButton appOpenRoute66Button;
        private C1.Win.Ribbon.RibbonButton appRandomButton;
        private C1.Win.Ribbon.RibbonSeparator appSeparator1;
        private C1.Win.Ribbon.RibbonButton appPrintButton;
        private C1.Win.Ribbon.RibbonButton appSendButton;
        private C1.Win.Ribbon.RibbonSeparator appSeparator2;
        private C1.Win.Ribbon.RibbonButton appCloseButton;
        private C1.Win.Ribbon.RibbonListItem recentLabelListItem;
        private C1.Win.Ribbon.RibbonLabel recentLabel;
        private C1.Win.Ribbon.RibbonListItem recentSeparatorListItem;
        private C1.Win.Ribbon.RibbonSeparator recentSeparator;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonToolBar;
        private C1.Win.Ribbon.RibbonMenu styleMenu;
        private C1.Win.Ribbon.RibbonQat ribbonQat;
        private C1.Win.Ribbon.RibbonButton zoomInButton;
        private C1.Win.Ribbon.RibbonButton zoomOutButton;
        private C1.Win.Ribbon.RibbonTab tabHome;
        private C1.Win.Ribbon.RibbonGroup mapGroup;
        private C1.Win.Ribbon.RibbonToggleGroup mapToggleGroup;
        private C1.Win.Ribbon.RibbonToggleButton mapStreetButton;
        private C1.Win.Ribbon.RibbonToggleButton mapSatelliteButton;
        private C1.Win.Ribbon.RibbonToggleButton mapHybridButton;
        private C1.Win.Ribbon.RibbonGroup zoomGroup;
        private C1.Win.Ribbon.RibbonGroup panGroup;
        private C1.Win.Ribbon.RibbonButton panLeftButton;
        private C1.Win.Ribbon.RibbonSeparator panSeparator1;
        private C1.Win.Ribbon.RibbonButton panUpButton;
        private C1.Win.Ribbon.RibbonButton panDownButton;
        private C1.Win.Ribbon.RibbonSeparator panSeparator2;
        private C1.Win.Ribbon.RibbonButton panRightButton;
        private C1.Win.Ribbon.RibbonGroup findGroup;
        private C1.Win.Ribbon.RibbonToolBar findToolbar;
        private C1.Win.Ribbon.RibbonEditBox findEditBox;
        private C1.Win.Ribbon.RibbonButton findButton;
        private C1.Win.Ribbon.RibbonTab tabActions;
        private C1.Win.Ribbon.RibbonGroup mouseGroup;
        private C1.Win.Ribbon.RibbonCheckBox mouseDraggingCheckBox;
        private C1.Win.Ribbon.RibbonCheckBox mouseScrollWheelCheckBox;
        private C1.Win.Ribbon.RibbonGroup positionGroup;
        private C1.Win.Ribbon.RibbonButton positionSaveButton;
        private C1.Win.Ribbon.RibbonButton positionRestoreButton;
        private C1.Win.Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.Ribbon.RibbonLabel statusLabel;
        private C1.Win.Ribbon.RibbonTrackBar statusTrackBar;
        private System.Windows.Forms.WebBrowser webBrowser;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
    }
}