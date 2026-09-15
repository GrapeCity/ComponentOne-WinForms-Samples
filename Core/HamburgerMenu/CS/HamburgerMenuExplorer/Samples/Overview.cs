using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Schedule;
using C1.Win.Command.HamburgerMenu;
using C1.Framework;
using C1.Win.Themes;

namespace HamburgerMenuExplorer.Samples
{
    public partial class Overview : UserControl
    {
        PropertyGrid propertyGrid1;
        Label notification;

        C1HamburgerMenuItem schedule;
        C1HamburgerMenuItem mail;
        C1HamburgerMenuItem inbox;
        C1HamburgerMenuItem sentItems;
        C1HamburgerMenuItem drafts;
        C1HamburgerMenuItem deletedItems;
        C1HamburgerMenuItem settings;
        C1HamburgerMenuItem customizeHamburgerMenu;
        C1HamburgerMenuItem customizeHamburgerMenuItem;

        public Overview()
        {
            InitializeComponent();
            InitHamburgerMenu();
        }

        private void InitHamburgerMenu()
        {
            c1HamburgerMenu1.ItemSelected += BurgerMenu_Selected;
            schedule = c1HamburgerMenu1.Items[0];
            mail = c1HamburgerMenu1.Items[1];
            settings = c1HamburgerMenu1.Items[2];

            mail.Items.Add(inbox = new C1HamburgerMenuItem
            {
                Text = "Inbox",
                ToolTipText = "Incoming emails."
            });
            mail.Items.Add(sentItems = new C1HamburgerMenuItem
            {
                Text = "Sent Items",
                ToolTipText = "Outgoing emails.",
            });
            mail.Items.Add(drafts = new C1HamburgerMenuItem
            {
                Text = "Drafts",
                ToolTipText = "Drafts."
            });
            mail.Items.Add(deletedItems = new C1HamburgerMenuItem
            {
                Text = "Deleted Items",
                ToolTipText = "Deleted Items."
            });

            settings.Items.Add(customizeHamburgerMenu = new C1HamburgerMenuItem
            {
                Text = "Customize HamburgerMenu",
                ToolTipText = "Allows to customize C1HamburgerMenu using PropertyGrid."
            });
            settings.Items.Add(customizeHamburgerMenuItem = new C1HamburgerMenuItem
            {
                Text = "Customize Item",
                ToolTipText = "Allows to customize C1HamburgerMenu item using PropertyGrid.",
            });

            // Create PropertyGrid for customization content.
            propertyGrid1 = new PropertyGrid()
            {
                Dock = DockStyle.Fill,
                SelectedObject = c1HamburgerMenu1
            };

            notification = new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(FontFamily.GenericSansSerif, 18)
            };
        }

        // Clear content panel.
        private void ClearContent()
        {
            contentPanel.Controls.Clear();
            c1Schedule1.Parent = null;
            propertyGrid1.Parent = null;
            notification.Parent = null;
        }

        private void BurgerMenu_Selected(object sender, ItemSelectedEventArgs e)
        {
            if (e.Item == schedule)
            {
                ShowSchedule();
            }
            if (e.Item == mail || e.Item == inbox)
            {
                ShowInbox();
            }
            else if (e.Item == sentItems)
            {
                ShowSentItems();
            }
            else if (e.Item == drafts)
            {
                ShowDrafts();
            }
            else if (e.Item == deletedItems)
            {
                ShowDeletedItems();
            }
            else if (e.Item == settings || e.Item == customizeHamburgerMenu)
            {
                ShowMenuCustomization();
            }
            else if (e.Item == customizeHamburgerMenuItem)
            {
                ShowItemCustomization();
            }
        }

        private void ShowSchedule()
        {
            if (c1Schedule1.Parent is null)
                ClearContent();

            contentPanel.Controls.Add(c1Schedule1);
        }

        private void ShowDeletedItems()
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "Folder is empty.";
            contentPanel.Controls.Add(notification);
        }
        private void ShowDrafts()
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You don't have drafts.";
            contentPanel.Controls.Add(notification);
        }

        private void ShowSentItems()
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You have no outgoing emails.";
            contentPanel.Controls.Add(notification);
        }

        private void ShowInbox()
        {
            if (notification.Parent is null)
                ClearContent();

            notification.Text = "You have no incoming emails.";
            contentPanel.Controls.Add(notification);
        }

        private void ShowItemCustomization()
        {
            if (propertyGrid1.Parent is null)
                ClearContent();

            propertyGrid1.SelectedObject = c1HamburgerMenu1.Items[2];
            contentPanel.Controls.Add(propertyGrid1);
        }

        private void ShowMenuCustomization()
        {
            if (propertyGrid1.Parent is null)
                ClearContent();

            propertyGrid1.SelectedObject = c1HamburgerMenu1;
            contentPanel.Controls.Add(propertyGrid1);
        }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme)
        {
            C1ThemeController.ApplyThemeToControlTree(this, theme);
        }
    }
}
