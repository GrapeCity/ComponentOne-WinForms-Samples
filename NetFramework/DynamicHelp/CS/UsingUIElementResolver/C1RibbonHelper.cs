using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1DynamicHelp;
using C1.Win.Ribbon;
using System.Drawing;
using System.Windows.Forms;

namespace UsingUIElementResolver
{
    internal static class C1RibbonHelper
    {
        internal static UIElementInfo ResolveControl(object uiElement)
        {
            // initialize UIElementInfo object with the uiElement
            C1.Win.C1DynamicHelp.UIElementInfo info = new C1.Win.C1DynamicHelp.UIElementInfo(uiElement);
            // check the parent object type whether we need to handle it
            if (uiElement is C1.Win.Ribbon.RibbonTab)
            {
                C1.Win.Ribbon.RibbonTab tab = (C1.Win.Ribbon.RibbonTab)uiElement;
                // set the Name and Parent properties for the UIElementInfo object
                info.Name = tab.ID;
                info.Parent = tab.Ribbon;
            }
            else if (uiElement is C1.Win.Ribbon.RibbonGroup)
            {
                C1.Win.Ribbon.RibbonGroup grp = (C1.Win.Ribbon.RibbonGroup)uiElement;
                // set the Name and Parent properties for the UIElementInfo object
                info.Name = grp.ID;
                info.Parent = (grp.Tab != null) ? grp.Tab : (object)grp.Ribbon;
            }
            else if (uiElement is C1.Win.Ribbon.RibbonItem)
            {
                C1.Win.Ribbon.RibbonItem item = (C1.Win.Ribbon.RibbonItem)uiElement;
                // set the Name property for the UIElementInfo object
                info.Name = item.ID;
                // set the Parent property for the UIElementInfo object
                // (since a RibbonItem can be inside different parents, we need to consider all cases)
                if (item.Parent != null)
                    info.Parent = item.Parent;
                else if (item.Tab != null)
                    info.Parent = item.Tab;
                else
                    info.Parent = item.Ribbon;
            }
            else if (uiElement is TextBox)
            {
                TextBox txt = (TextBox)uiElement;
                // check if this TextBox is inside a C1Ribbon, 
                // then we can handle it here, otherwise we should return null to allow the C1DynamicHelp control to process it
                RibbonItem parent = C1Ribbon.GetHostRibbonItem(txt);
                if (parent == null)
                    return null;
                info.Parent = parent;
                info.Name = txt.Name;
            }
            else
                // the uiElement can be handled by the C1DynamicHelp control automatically, so return null
                return null;
            
            // check if the uiElement has a name
            if (info.Name == "")
            {
                // if the name is empty, we can use the uiElement's index instead of the name to identify it later inside a parent
                int pos = IndexOf(info);
                if (pos != -1)
                    info.Name = pos.ToString();
            }

            return info;
        }

        internal static int IndexOf(UIElementInfo info)
        {
            int pos = -1;
            object parent = info.Parent;

            // try to get the index of info.UIElement
            if (parent is RibbonGroup)
                pos = ((RibbonGroup)parent).Items.IndexOf(info.UIElement as RibbonItem);
            else if (parent is RibbonTab)
                pos = ((RibbonTab)parent).Groups.IndexOf(info.UIElement as RibbonGroup);
            else if (parent is RibbonDropDownBase)
            {
                if (parent is RibbonApplicationMenu)
                {
                    RibbonApplicationMenu appMenu = ((RibbonApplicationMenu)parent);
                    // RibbonApplicationMenu has three child collections,
                    // so we use index range from 0 to 999 for BottomPaneItems,
                    // index range from 1000 to 1999 for LeftPaneItems, and
                    // index range starting with 2000 for RightPaneItems
                    pos = appMenu.BottomPaneItems.IndexOf(info.UIElement as RibbonItem);
                    if (pos < 0)
                    {
                        pos = appMenu.LeftPaneItems.IndexOf(info.UIElement as RibbonItem);
                        if (pos >= 0)
                            pos += 1000;
                        else
                        {
                            pos = appMenu.RightPaneItems.IndexOf(info.UIElement as RibbonItem);
                            if (pos >= 0)
                                pos += 2000;
                        }
                    }
                }
                else if (parent is RibbonComboBox)
                {
                    pos = ((RibbonComboBox)parent).MenuItems.IndexOf(info.UIElement as RibbonItem);
                    if (pos < 0)
                    {
                        pos = ((RibbonComboBox)parent).Items.IndexOf(info.UIElement as RibbonItem);
                        if (pos >= 0)
                            pos += 1000;
                    }
                }
                else if (parent is RibbonGallery)
                {
                    pos = ((RibbonGallery)parent).MenuItems.IndexOf(info.UIElement as RibbonItem);
                    if (pos < 0)
                    {
                        pos = ((RibbonGallery)parent).Items.IndexOf(info.UIElement as RibbonItem);
                        if (pos >= 0)
                            pos += 1000;
                    }
                }
                else
                    pos = ((RibbonDropDownBase)parent).Items.IndexOf(info.UIElement as RibbonItem);
            }
            else if (parent is RibbonItemContainer)
            {
                pos = ((RibbonItemContainer)parent).Items.IndexOf(info.UIElement as RibbonItem);
                if (parent is RibbonQat && pos == -1)
                {
                    pos = ((RibbonQat)parent).MenuItems.IndexOf(info.UIElement as RibbonItem);
                    if (pos >= 0)
                        pos += 1000;
                }
            }
            else if (parent is RibbonListItem)
                pos = ((RibbonListItem)parent).Items.IndexOf(info.UIElement as RibbonItem);
            else if (parent is C1Ribbon)
            {
                C1Ribbon ribbon = (C1Ribbon)parent;
                if (ribbon.ApplicationMenu.Equals(info.UIElement))
                    pos = 0;
                else if (ribbon.ConfigToolBar.Equals(info.UIElement))
                    pos = 1;
                else if (ribbon.Qat.Equals(info.UIElement))
                    pos = 2;
                else
                {
                    pos = ribbon.Tabs.IndexOf(info.UIElement as RibbonTab);
                    if (pos >= 0)
                        pos += 1000;
                }
            }
            else if (parent is C1StatusBar)
            {
                C1StatusBar bar = (C1StatusBar)parent;
                pos = bar.LeftPaneItems.IndexOf(info.UIElement as RibbonItem);
                if (pos < 0)
                {
                    pos = bar.RightPaneItems.IndexOf(info.UIElement as RibbonItem);
                    if (pos >= 0)
                        pos += 1000;
                }
            }

            // if uiElement does not have an index, return -1
            if (pos < 0)
                pos = -1;
            return pos;
        }

        internal static object FindUIElement(object parent, string name)
        {
            int pos;
            // Check if the name contains the UI element's index in the parent children collection instead of its real Name.
            // This way we handle UI elements whose Name property is not set.
            if (!int.TryParse(name, out pos))
                pos = -1;
            object child = null;

            try
            {
                // check the parent object type, whether we need to handle it
                if (parent is RibbonGroup)
                {
                    // if the name contains an index, try to get the child UI element by that index
                    if (pos != -1)
                        child = ((RibbonGroup)parent).Items[pos];
                    // otherwise, try to get the child UI element by its name
                    else
                        child = ((RibbonGroup)parent).Items[name];
                }
                else if (parent is RibbonTab)
                {
                    if (pos != -1)
                        child = ((RibbonTab)parent).Groups[pos];
                    else
                        child = ((RibbonTab)parent).Groups[name];
                }
                else if (parent is RibbonDropDownBase)
                {
                    if (parent is RibbonApplicationMenu)
                    {
                        RibbonApplicationMenu appMenu = ((RibbonApplicationMenu)parent);
                        if (pos != -1)
                        {
                            // RibbonApplicationMenu has three child collections, 
                            // so we use index range from 0 to 999 for BottomPaneItems
                            if (pos < 1000)
                                child = appMenu.BottomPaneItems[pos];
                            // use index range from 1000 to 1999 for LeftPaneItems
                            else if (pos < 2000)
                                child = appMenu.LeftPaneItems[pos - 1000];
                            // use index range starting from 2000 for RightPaneItems
                            else
                                child = appMenu.RightPaneItems[pos - 2000];
                        }
                        else
                        {
                            // RibbonApplicationMenu has three child collections,
                            // so we look the child UI element up in all of them
                            if (appMenu.BottomPaneItems.Contains(name))
                                child = appMenu.BottomPaneItems[name];
                            else if (appMenu.LeftPaneItems.Contains(name))
                                child = appMenu.LeftPaneItems[name];
                            else
                                child = appMenu.RightPaneItems[name];
                        }
                    }
                    else if (parent is RibbonComboBox)
                    {
                        if (pos != -1)
                        {
                            // RibbonComboBox has two child collections,
                            // so we use index range from 0 to 999 for MenuItems
                            if (pos < 1000)
                                child = ((RibbonComboBox)parent).MenuItems[pos];
                            // use index range starting from 1000 for Items
                            else
                                child = ((RibbonComboBox)parent).Items[pos - 1000];
                        }
                    }
                    else if (parent is RibbonGallery)
                    {
                        if (pos != -1)
                        {
                            if (pos < 1000)
                                child = ((RibbonGallery)parent).MenuItems[pos];
                            else
                                child = ((RibbonGallery)parent).Items[pos - 1000];
                        }
                    }
                    else
                    {
                        if (pos != -1)
                            child = ((RibbonDropDownBase)parent).Items[pos];
                        else
                            child = ((RibbonDropDownBase)parent).Items[name];
                    }
                }
                else if (parent is RibbonItemContainer)
                {
                    if (pos != -1)
                    {
                        if (pos < 1000)
                            child = ((RibbonItemContainer)parent).Items[pos];
                        else
                            child = ((RibbonQat)parent).MenuItems[pos - 1000];
                    }
                    else
                    {
                        if (((RibbonItemContainer)parent).Items.Contains(name))
                            child = ((RibbonItemContainer)parent).Items[name];
                        else
                            child = ((RibbonQat)parent).MenuItems[name];
                    }
                }
                else if (parent is RibbonListItem)
                {
                    if (pos != -1)
                        child = ((RibbonListItem)parent).Items[pos];
                    else
                        child = ((RibbonListItem)parent).Items[name];
                }
                else if (parent is C1Ribbon)
                {
                    C1Ribbon ribbon = (C1Ribbon)parent;
                    if (pos != -1)
                    {
                        if (pos == 0)
                            child = ribbon.ApplicationMenu;
                        else if (pos == 1)
                            child = ribbon.ConfigToolBar;
                        else if (pos == 2)
                            child = ribbon.Qat;
                        else
                            child = ribbon.Tabs[pos - 1000];
                    }
                    else
                    {
                        child = ribbon.Tabs[name];
                    }
                }
                else if (parent is C1StatusBar)
                {
                    C1StatusBar bar = (C1StatusBar)parent;
                    if (pos != -1)
                    {
                        if (pos < 1000)
                            child = bar.LeftPaneItems[pos];
                        else
                            child = bar.RightPaneItems[pos - 1000];
                    }
                    else
                    {
                        child = bar.LeftPaneItems[name];
                        if (child == null)
                            child = bar.RightPaneItems[name];
                    }
                }
            }
            // an exception can occur if parent doesn't contain a child UI element with the specified name,
            // in that case we return null
            catch { }
            return child;
        }

        internal static object GetChildAtPoint(object parent, Point pt)
        {
            object child = null;
            // check the parent object type whether we need to handle it
            if (parent is C1Ribbon)
            {
                C1Ribbon ribbon = (C1Ribbon)parent;
                // use a method of the C1Ribbon control to get the child at the specified point
                child = ribbon.GetItemAt(ribbon.PointToClient(pt));
            }
            return child;
        }
    }
}
