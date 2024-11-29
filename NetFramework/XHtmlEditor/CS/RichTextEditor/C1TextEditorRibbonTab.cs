using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Ribbon;
using C1.Win.C1SpellChecker;
using Resources = global::RichTextEditor.Properties.Resources;
using C1.Framework;

namespace RichTextEditor
{
    class C1TextEditorRibbonTab : C1.Win.Ribbon.RibbonTab
    {
        //------------------------------------------------------------
        #region ** command dispatcher

        // handle commands issued to this tab.
        internal virtual void HandleItemEvent(RibbonEventArgs e)
        {
        }

        // update UI (button state, etc)
        internal virtual void UpdateUI()
        {
        }

        #endregion

        //------------------------------------------------------------
        #region ** object model

        internal virtual void InitTab()
        {
        }

        // gets an item by ID
        internal RibbonItem GetItemByID(string id)
        {
            return (RibbonItem)Ribbon.GetItemByID(id);
        }

        // gets the parent ribbon
        public new C1TextEditorRibbon Ribbon
        {
            get { return (C1TextEditorRibbon)base.Ribbon; }
        }

        // gets the current editor
        internal C1RibbonEditorXhtml Editor
        {
            get { return Ribbon.Editor; }
        }

        // gets the current spell-checker
        internal C1SpellChecker SpellChecker
        {
            get { return Ribbon.SpellChecker; }
        }

        // Creates a RibbonListItem and initializes it using a unique ID string.
        internal static RibbonListItem CreateHeader(string id)
        {
            string text = (string)Resources.ResourceManager.GetObject(id + "_hdr", Resources.Culture);
            RibbonLabel label = new RibbonLabel(text);
            RibbonListItem header = new RibbonListItem(label);
            header.AllowSelection = false;
            return header;
        }

        // Creates a RibbonLabel and initializes it using a unique ID string.
        internal static RibbonLabel CreateHeaderLabel(string id)
        {
            string text = (string)Resources.ResourceManager.GetObject(id + "_hdr", Resources.Culture);
            return new RibbonLabel(text);
        }

        // creates a RibbonButton and initializes it using a unique ID string.
        // the ID string is used to set the button's ID and also to look up
        // text and image resources that specify the button properties.
        internal static RibbonButton CreateButton(string id)
        {
            return CreateButton(id, id);
        }

        // creates a RibbonButton and initializes it using a unique ID string
        // and an imageID string.
        // the imageID string allows sharing image resources among multiple
        // ribbon elements.
        internal static RibbonButton CreateButton(string id, string imageID)
        {
            RibbonButton btn = new RibbonButton();
            SetItemProperties(btn, id, imageID);
            return btn;
        }

        // creates a RibbonAppMenuTab and initializes it using a unique ID string.        
        internal static BackstageViewTab CreateTab(string id)
        {
            BackstageViewTab tab = new BackstageViewTab();
            SetItemProperties(tab, id);
            tab.Control = (Control)Activator.CreateInstance(Type.GetType("RichTextEditor.BackstageTabs." + id));
            return tab;
        }

        // creates a RibbonToggleButton and initializes it using a unique ID string.
        internal static RibbonToggleButton CreateToggleButton(string id)
        {
            return CreateToggleButton(id, id);
        }

        // creates a RibbonToggleButton and initializes it using a unique ID string
        // and an imageID string.
        internal static RibbonToggleButton CreateToggleButton(string id, string imageID)
        {
            RibbonToggleButton btn = new RibbonToggleButton();
            SetItemProperties(btn, id, imageID);
            return btn;
        }

        // creates a RibbonMenu and initializes it using a unique ID string and
        // a list of items that may contain strings or RibbonElement objects.
        internal static RibbonMenu CreateMenu(string id, params object[] items)
        {
            RibbonMenu menu = new RibbonMenu();
            SetItemProperties(menu, id);
            AddSubItems(menu.Items, items);
            return menu;
        }

        // creates a RibbonSplitButton and initializes it using a unique ID string and
        // a list of items that may contain strings or RibbonElement objects.
        internal static RibbonSplitButton CreateSplitButton(string id, params object[] items)
        {
            RibbonSplitButton split = new RibbonSplitButton();
            SetItemProperties(split, id);
            AddSubItems(split.Items, items);
            return split;
        }

        // sets several properties on a RibbonItem object based on an ID string that
        // identifies text and image resources.
        internal static void SetItemProperties(RibbonItem item, string id)
        {
            SetItemProperties(item, id, id);
        }

        // sets several properties on a RibbonItem object based on an ID string that
        // identifies text resources and on an imageID string that identifies image
        // resources.
        internal static void SetItemProperties(RibbonItem item, string id, string imageID)
        {
            // set ID
            item.ID = id;

            // text resources
            string res = (string)Resources.ResourceManager.GetObject(id + "_txt", Resources.Culture);
            string[] textParts = res != null
                ? res.Split('\n')
                : new string[] { id };
            // 0 : text
            // 1 : tooltip title + shortcut
            // 2 : tooltip body

            // Text
            string text = textParts[0].Trim();
            if (!string.IsNullOrEmpty(text))
            {
                System.Reflection.PropertyInfo pi = item.GetType().GetProperty("Text");
                if (pi != null)
                {
                    pi.SetValue(item, textParts[0], null);
                }
            }

            // ToolTip: text and body
            if (textParts.Length > 1)
            {
                // Description: starts with '*'
                if (textParts[1].StartsWith("*"))
                {
                    item.Description = textParts[1].Substring(1).Trim();
                }
                else
                {
                    string tipTitle = textParts[1].Trim();
                    string tipBody = string.Join("<br/>", textParts, 2, textParts.Length - 2).Trim();
                    item.ToolTip = string.IsNullOrEmpty(tipBody)
                        ? tipTitle
                        : string.Format(
                            "<b>{0}</b><br/>" +
                            "<div style='margin-left:12'>{1}</div>",
                            tipTitle, tipBody);

                    // Shortcut
                    int start = tipTitle.IndexOf('(');
                    int end = tipTitle.LastIndexOf(')');
                    if (start > -1 && end > -1)
                    {
                        System.Reflection.PropertyInfo pi = item.GetType().GetProperty("ShortcutKeys");
                        if (pi != null)
                        {
                            string shortCutString = tipTitle.Substring(start, end - start + 1);
                            pi.SetValue(item, ParseShortcut(shortCutString), null);
                        }
                    }
                }
            }

            // image resources
            if (item is RibbonIconItem iconItem)
            {
                if (Resources.ResourceManager.GetObject(imageID + "_small", Resources.Culture) is Image smallImage)
                    iconItem.IconSet.Add(new C1BitmapIcon()
                    {
                        Size = new Size(16, 16),
                        Source = smallImage,
                        ShowAsMonochrome = ShowAsMonochrome.Never                        
                    });

                if (Resources.ResourceManager.GetObject(imageID + "_large", Resources.Culture) is Image largeImage)
                    iconItem.IconSet.Add(new C1BitmapIcon()
                    {
                        Size = new Size(32, 32),
                        Source = largeImage,
                        ShowAsMonochrome = ShowAsMonochrome.Never
                    });
            }
        }

        #endregion

        //------------------------------------------------------------
        #region ** implementation

        // parses a string such as "(Shift + Ctrl + A)" and returns a 
        // Keys value that represents the shortcut.
        static Keys ParseShortcut(string text)
        {
            Keys shortCut = Keys.None;

            // remove brackets
            if (text.StartsWith("(") && text.EndsWith(")"))
            {
                text = text.Substring(1, text.Length - 2);
            }

            // parse modifiers
            if (text.IndexOf("alt", StringComparison.OrdinalIgnoreCase) > -1)
            {
                shortCut |= Keys.Alt;
            }
            if (text.IndexOf("ctrl", StringComparison.OrdinalIgnoreCase) > -1)
            {
                shortCut |= Keys.Control;
            }
            if (text.IndexOf("shift", StringComparison.OrdinalIgnoreCase) > -1)
            {
                shortCut |= Keys.Shift;
            }

            // parse key
            int pos = text.LastIndexOf(' ');
            string actual = pos < 0 ? text : text.Substring(pos + 1);
            shortCut |= actual.Length == 1
                ? (Keys)actual[0]
                : (Keys)Enum.Parse(typeof(Keys), actual);

            // done
            return shortCut;
        }

        // adds a list of items to a RibbonItemCollection. 
        // items must be strings or RibbonItem objects.
        static void AddSubItems(RibbonItemCollection ric, object[] items)
        {
            foreach (object item in items)
            {
                // convert text into buttons
                string text = item as string;
                if (text != null)
                {
                    ric.Add(CreateButton(text));
                    continue;
                }

                // paste items
                RibbonItem ribbonItem = item as RibbonItem;
                if (ribbonItem != null)
                {
                    ric.Add(ribbonItem);
                    continue;
                }

                // oops
                Debug.Assert(false, "AddSubItems expected string or RibbonItem");
            }
        }

        #endregion
    }
}
