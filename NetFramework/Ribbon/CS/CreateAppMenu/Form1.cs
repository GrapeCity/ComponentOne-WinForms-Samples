using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreateAppMenu
{
    using C1.Win.C1Ribbon;

    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateAppMenu();
            CreateHomeTab();
        }

        private void CreateAppMenu()
        {
            // **** create the Application menu buttons
            this.c1Ribbon1.ApplicationMenu.BottomPaneItems.Add(new RibbonButton("Options"));
            this.c1Ribbon1.ApplicationMenu.BottomPaneItems.Add(new RibbonButton("Exit"));

            // *** create the controls for the left pane
            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(new RibbonButton("&New"));
            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(new RibbonButton("&Open"));
            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(new RibbonButton("&Save"));

            RibbonSplitButton split = new RibbonSplitButton("Save &As");
            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(split);
            split.Items.Add(new RibbonButton("Word Document"));
            split.Items.Add(new RibbonButton("D2H project file"));

            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(new RibbonSeparator());
            this.c1Ribbon1.ApplicationMenu.LeftPaneItems.Add(new RibbonButton("&Print"));

            CreateRecentDocumentList();
        }

        private void CreateRecentDocumentList()
        {
            // **** create the recently used document list (controls in the right pane)

            // first create a header and make sure it's not selectable
            RibbonListItem listItem = new RibbonListItem(new RibbonLabel("Recent Documents"));
            listItem.AllowSelection = false;
            this.c1Ribbon1.ApplicationMenu.RightPaneItems.Add(listItem);
            this.c1Ribbon1.ApplicationMenu.RightPaneItems.Add(new RibbonListItem(new RibbonSeparator()));

            // create the recently used document list
            string[] recentDocuments = new string[] { "Document 1", "Document 2", "Document 3" };

            foreach (string documentName in recentDocuments)
            {
                // each item consists of the name of the document and a push pin
                listItem = new RibbonListItem();
                listItem.Items.Add(new RibbonLabel(documentName));

                // allow the button to be selectable so we can toggle it
                RibbonToggleButton pin = new RibbonToggleButton();
                pin.SmallImage = Properties.Resources.unpinned;
                pin.AllowSelection = true;
                listItem.Items.Add(pin);
                pin.Click += new EventHandler(pinButton_Click);

                this.c1Ribbon1.ApplicationMenu.RightPaneItems.Add(listItem);
            }
        }

        private void pinButton_Click(object sender, EventArgs e)
        {
            RibbonToggleButton pin = sender as RibbonToggleButton;
            if (pin.Pressed)
                pin.SmallImage = Properties.Resources.pinned;
            else
                pin.SmallImage = Properties.Resources.unpinned;
        }

        private void CreateHomeTab()
        {
            this.c1Ribbon1.Tabs.Clear();

            RibbonTab homeTab = new RibbonTab("Home");
            RibbonGroup clipboardGroup = new RibbonGroup("Clipboard");
            RibbonButton pasteButton = new RibbonButton("Paste", null, Properties.Resources.Paste);
            pasteButton.TextImageRelation = TextImageRelation.ImageAboveText;

            clipboardGroup.Items.Add(pasteButton);
            homeTab.Groups.Add(clipboardGroup);
            this.c1Ribbon1.Tabs.Add(homeTab);
        }
    }
}