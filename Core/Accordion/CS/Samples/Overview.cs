using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Schedule;

namespace AccordionExplorer.Samples
{
    public partial class Overview : UserControl
    {
        ToolTip tooltip;

        C1Calendar c1calenar1;

        RadioButton inbox;
        RadioButton sentItems;
        RadioButton drafts;
        RadioButton deletedItems;

        RadioButton customizeAccordionBtn;
        RadioButton customizePageBtn;

        PropertyGrid propertyGrid1;
        Label notification;

        public Overview()
        {
            InitializeComponent();
            InitAccordion();
        }

        private void InitAccordion()
        {
            // Initialize content.
            tooltip = new ToolTip();
            
            // Create calendar for Calendar page.
            c1calenar1 = new C1Calendar();
            c1calenar1.Schedule = c1Schedule1;
            c1calenar1.Dock = DockStyle.Fill;

            // Create buttons for Mail page.
            inbox = CreateButton("Inbox", "Incoming emails.");
            inbox.Click += Inbox_Click;

            sentItems = CreateButton("Sent Items", "Outgoing emails.");
            sentItems.Click += SentItems_Click;

            drafts = CreateButton("Drafts", "Drafts.");
            drafts.Click += Drafts_Click;

            deletedItems = CreateButton("Deleted Items", "Deleted Items.");
            deletedItems.Click += DeletedItems_Click;

            // Create buttons for Settings page.
            customizeAccordionBtn = CreateButton("Customize Accordion", "Allows to customize C1Accordion using PropertyGrid.");
            customizeAccordionBtn.Click += CustomizeAccordionBtn_Click;            

            customizePageBtn = CreateButton("Customize Page", "Allows to customize C1Accordion page using PropertyGrid.");
            customizePageBtn.Click += CustomizePageBtn_Click;

            // Create PropertyGrid for customization content.
            propertyGrid1 = new PropertyGrid()
            {
                Dock = DockStyle.Fill
            };
            propertyGrid1.SelectedObject = c1Accordion1;

            notification = new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(FontFamily.GenericSansSerif, 18)
            };

            // Added controls to pages.
            var page = c1Accordion1.Pages[0];
            page.Content.Controls.Add(c1calenar1);

            page = c1Accordion1.Pages[1];
            page.Content.Controls.Add(deletedItems);
            page.Content.Controls.Add(drafts);
            page.Content.Controls.Add(sentItems);
            page.Content.Controls.Add(inbox);
            page.ContentHeight = deletedItems.Bounds.Bottom + 1;
            
            page = c1Accordion1.Pages[2];
            page.Content.Controls.Add(customizePageBtn);
            page.Content.Controls.Add(customizeAccordionBtn);
            page.ContentHeight = customizePageBtn.Bounds.Bottom + 1;
        }

        // Create button template for pages.
        private RadioButton CreateButton(string text, string tooltipText)
        {
            var btn = new RadioButton()
            {
                Text = text,
                AutoSize = true,
                Dock = DockStyle.Top,
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Padding = new Padding(20, 0, 0, 0)
            };
            btn.FlatAppearance.BorderColor = SystemColors.Window;
            btn.FlatAppearance.CheckedBackColor = SystemColors.ControlDark;
            tooltip.SetToolTip(btn, tooltipText);
            return btn;
        }

        // Clear content panel.
        private void ClearContent()
        {
            contentPanel.Controls.Clear();
            c1Schedule1.Parent = null;
            propertyGrid1.Parent = null;
            notification.Parent = null;
        }

        private void DeletedItems_Click(object sender, EventArgs e)
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "Folder is empty.";
            contentPanel.Controls.Add(notification);
        }
        private void Drafts_Click(object sender, EventArgs e)
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You don't have drafts.";
            contentPanel.Controls.Add(notification);
        }

        private void SentItems_Click(object sender, EventArgs e)
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You have no outgoing emails.";
            contentPanel.Controls.Add(notification);
        }

        private void Inbox_Click(object sender, EventArgs e)
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You have no incoming emails.";
            contentPanel.Controls.Add(notification);
        }

        private void CustomizePageBtn_Click(object sender, EventArgs e)
        {
            if (propertyGrid1.Parent is null)
                ClearContent();

            propertyGrid1.SelectedObject = c1Accordion1.Pages[2];
            contentPanel.Controls.Add(propertyGrid1);
        }

        private void CustomizeAccordionBtn_Click(object sender, EventArgs e)
        {
            if (propertyGrid1.Parent is null)
                ClearContent();

            propertyGrid1.SelectedObject = c1Accordion1;
            contentPanel.Controls.Add(propertyGrid1);
        }

        private void c1Accordion1_PageExpandStateChanged(object sender, C1.Win.Accordion.PageExpandStateChangedEventArgs e)
        {
            if (!e.NewExpandedState)
                return;
            switch (e.Page.Name)
            {
                case "CalendarPage":
                    if (c1Schedule1.Parent != null)
                        break;
                    ClearContent();
                    contentPanel.Controls.Add(c1Schedule1);
                    break;
                case "SettingsPage":
                    if (propertyGrid1.Parent != null)
                        break;
                    ClearContent();
                    contentPanel.Controls.Add(propertyGrid1);
                    break;
            }
        }
    }
}
