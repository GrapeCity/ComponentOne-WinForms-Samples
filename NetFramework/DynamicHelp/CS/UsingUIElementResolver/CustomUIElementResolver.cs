using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1DynamicHelp;
using System.Windows.Forms;
using C1.Win.Ribbon;

namespace UsingUIElementResolver
{
    // This class provides methods to find UI elements inside a control by name, coordinates, etc, 
    // and other methods necessary for associating dynamic help to UI elements inside a control.
    class CustomUIElementResolver : C1.Win.C1DynamicHelp.UIElementResolver
    {
        protected override bool ActivateUIElement(object uiElement)
        {
            bool handled = false;
            // check whether the uiElement should be handled here; 
            // otherwise it can be passed to the C1DynamicHelp control to be activated automatically
            if (uiElement is RibbonItem)
            {
                RibbonItem ribItem = (RibbonItem)uiElement;
                ribItem.Ribbon.RibbonEvent += rib_RibbonEvent;
                handled = true;
            }
            else if (uiElement is RibbonGroup)
            {
                RibbonGroup ribGroup = (RibbonGroup)uiElement;
                ribGroup.Ribbon.RibbonEvent += rib_RibbonEvent;
                handled = true;
            }
            else if (uiElement is RibbonTab)
            {
                RibbonTab ribTab = (RibbonTab)uiElement;
                ribTab.Ribbon.RibbonEvent += rib_RibbonEvent;
                handled = true;
            }
            if (handled)
                // the uiElement has been activated, so we have no need to pass it to the C1DynamicHelp control
                return true;
            // pass the uiElement to the C1DynamicHelp control to be activated
            return base.ActivateUIElement(uiElement);
        }

        protected override object FindUIElement(object parent, string name)
        {
            // try to find a child UI element by its name inside the parent
            object child = C1RibbonHelper.FindUIElement(parent, name);

            // if a child UI element with the specified name was found, return it
            if (child != null)
                return child;

            // child UI element was not found inside the parent
            return base.FindUIElement(parent, name);
        }

        protected override object GetUIElementAtPoint(object parent, System.Drawing.Point pt)
        {
            // try to find a child UI element by its coordinates inside the parent
            object child = C1RibbonHelper.GetChildAtPoint(parent, pt);

            // if a child UI element at the specified point was found, return it
            if (child != null)
                return child;

            // child UI element was not found inside the parent
            return base.GetUIElementAtPoint(parent, pt);
        }

        protected override C1.Win.C1DynamicHelp.UIElementInfo GetUIElementInfo(object uiElement)
        {
            // Try to get Parent and Name for the specified uiElement.
            // These properties should be stored in UIElementInfo object
            UIElementInfo info = C1RibbonHelper.ResolveControl(uiElement);

            // if we were able to get the uiElement's parent and name, return them in a UIElementInfo object.
            if (info != null)
                return info;

            // uiElement wasn't handled here, so it should be processed by the C1DynamicHelp control automatically
            return base.GetUIElementInfo(uiElement);
        }

        // handles Ribbon item events to show topic in C1DynamicHelp
        private void rib_RibbonEvent(object sender, RibbonEventArgs e)
        {
            switch (e.EventType)
            {
                case RibbonEventType.LostFocus:
                case RibbonEventType.DeselectTab:
                    // notify the C1DynamicHelp control that the Leave event occurred for e.Item,
                    // so a new help topic may need to be displayed
                    this.HandleUIElementEvent(e.Item, UIElementEvents.Leave);
                    break;
                case RibbonEventType.GotFocus:
                case RibbonEventType.SelectTab:
                    // notify the C1DynamicHelp control that the Enter event occurred for e.Item, 
                    // so a new help topic may need to be displayed
                    this.HandleUIElementEvent(e.Item, UIElementEvents.Enter);
                    break;
            }
        }
    }
}
