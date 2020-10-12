using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace ControlExplorer.Ribbon
{
    public partial class GoogleMaps : C1DemoForm
    {
        private bool loaded = false;
        private const string homeUrl = "http://our.componentone.com/maps";

        public GoogleMaps()
        {
            InitializeComponent();
        }

        private void GoogleMaps_Load(object sender, EventArgs e)
        {
            // Associate JavaScript API's with ribbon buttons
            mapHybridButton.Tag = "setMapTypeHybrid";
            mapSatelliteButton.Tag = "setMapTypeSatellite";
            mapStreetButton.Tag = "setMapTypeStreet";
            panDownButton.Tag = "panDown";
            panLeftButton.Tag = "panLeft";
            panRightButton.Tag = "panRight";
            panUpButton.Tag = "panUp";
            positionSaveButton.Tag = "savePosition";
            positionRestoreButton.Tag = "restorePosition";
            zoomInButton.Tag = "zoomIn";
            zoomOutButton.Tag = "zoomOut";
            appPrintButton.Tag = "print";

            // Associate JavaScript API's with ribbon check boxes
            mouseDraggingCheckBox.Tag = "setDraggingEnabled";
            mouseScrollWheelCheckBox.Tag = "setScrollWheelZoomEnabled";

            // Associate KML markup URL's with application menu buttons
            //appOpenBaseballButton.Tag = ControlExplorer.Properties.Resources.mlb;
            //appOpenRoute66Button.Tag = ControlExplorer.Properties.Resources.route66;
            appOpenBaseballButton.Tag = homeUrl + "/mlb.kml";
            appOpenRoute66Button.Tag = homeUrl + "/route66.kml";

            // Create a proxy object for scripting this form
            webBrowser.ObjectForScripting = new ScriptingObject(this);

            // Navigate to the start page
            webBrowser.Navigate(homeUrl);
        }

       private void RibbonEarthForm_Shown(object sender, EventArgs e)
        {
            // Give the browser control focus when the form is shown
            webBrowser.Focus();
        }

        #region Invoke helpers
        private object InvokeMember(string methodName)
        {
            // Invoke a named method on the "map" element in the browser (no arguments)
            object result = null;

            if (loaded)
            {
                HtmlElement map = webBrowser.Document.GetElementById("map");
                
                if (map != null)
                    result = map.InvokeMember(methodName);
            }

            return result;
        }

        private object InvokeMemberWithArgument(string methodName, object arg)
        {
            // Invoke a named method on the "map" element in the browser (one argument)
            object[] args = { arg };
            return InvokeMemberWithArguments(methodName, args);
        }

        private object InvokeMemberWithArguments(string methodName, object[] args)
        {
            // Invoke a named method on the "map" element in the browser (multiple arguments)
            object result = null;

            if (loaded)
            {
                HtmlElement map = webBrowser.Document.GetElementById("map");

                if (map != null)
                    result = map.InvokeMember(methodName, args);
            }

            return result;
        }

        private object InvokeTag(RibbonItem item)
        {
            // Invoke the named method associated with the Tag property of a RibbonItem
            object result = null;

            if (item != null && item.Tag != null)
                result = InvokeMember(item.Tag.ToString());

            return result;
        }

        private object InvokeCheckBoxTag(RibbonCheckBox check)
        {
            // Invoke the named method associated with the Tag property of a RibbonCheckBox
            object result = null;
            
            if (check != null && check.Tag != null)
                result = InvokeMemberWithArgument(check.Tag.ToString(), check.Checked);

            return result;
        }
        #endregion

        #region Find helpers
        private void FindLocation(string address)
        {
            // Get the edit box text if no argument was given
            if (address == null)
                address = findEditBox.TextBox.Text;

            // Try to locate the specified address, place name, or zip code
            if (address.Length > 0)
                InvokeMemberWithArgument("find", address);
        }

        private void UpdateRecentLocations(string address)
        {
            // Get the collection of recent locations (right pane)
            RibbonItemCollection mru = c1Ribbon.ApplicationMenu.RightPaneItems;

            // Add the specified address if not already present
            if (address.Length > 0 && !mru.Contains(address))
            {
                // Create a list item containing a label
                RibbonLabel label = new RibbonLabel(address);
                RibbonListItem item = new RibbonListItem(label);
                
                // Add a handler for the Click event
                item.Click += new EventHandler(recentLocation_Click);
                
                // Must set the ID for subsequent calls to mru.Contains(address)
                item.ID = address;
                
                // Add the new item to the collection
                mru.Add(item);
            }
        }
        #endregion

        #region Write-only properties
        public string StatusText
        {
            set { statusLabel.Text = value; }
        }

        public string RecentLocation
        {
            set { UpdateRecentLocations(value); }
        }

        public int ZoomLevel
        {
            set
            {
                //Added code to handle exception on zooming through mouse wheel - TFS ID 27430
                if (value < statusTrackBar.Minimum)
                    value = statusTrackBar.Minimum;
                if (value > statusTrackBar.Maximum)
                    value = statusTrackBar.Maximum;

                statusTrackBar.Value = value;
                zoomInButton.Enabled = (value < statusTrackBar.Maximum);
                zoomOutButton.Enabled = (value > statusTrackBar.Minimum);
            }
        }
        #endregion

        #region Event handlers for controls
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Now safe to invoke methods on browser objects
            loaded = true;
        }

        private void mapToggleGroup_PressedButtonChanged(object sender, EventArgs e)
        {
            // One of the buttons in the MapType group was pressed
            InvokeTag(mapToggleGroup.PressedButton);
        }

        private void ribbonItem_Click(object sender, EventArgs e)
        {
            // A ribbon item with a JavaScript API tag was clicked
            InvokeTag(sender as RibbonItem);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Find the location in the adjacent edit box
            FindLocation(null);
        }

        private void findEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pressing the Enter key performs the Find command
            if (e.KeyChar == '\r')
                FindLocation(null);
        }

        private void recentLocation_Click(object sender, EventArgs e)
        {
            // One of the recent locations was clicked
            // (item belongs to c1Ribbon.ApplicationMenu.RightPaneItems)
            RibbonListItem item = sender as RibbonListItem;

            if (item != null)
            {
                // label is the first child of item
                RibbonLabel label = item.Items[0] as RibbonLabel;

                // Find the corresponding location
                if (label != null)
                    FindLocation(label.Text);
            }
        }

        private void statusTrackBar_Scroll(object sender, EventArgs e)
        {
            // Set the zoom factor when the track bar value changes
            InvokeMemberWithArgument("setZoom", statusTrackBar.Value);
        }

        private void appHomeButton_Click(object sender, EventArgs e)
        {
            // Navigate to the start page
            webBrowser.Navigate(homeUrl);
        }

        private void appOpenButton_Click(object sender, EventArgs e)
        {
            // One of the Open menu buttons was clicked
            RibbonButton button = (RibbonButton)sender;

            if (button != null)
            {
                // Add an overlay for KML markup (URL hard-coded in Tag)
                InvokeMember("clearOverlays");
                InvokeMemberWithArgument("addOverlay", button.Tag);
            }
        }

        private void appRandomButton_Click(object sender, EventArgs e)
        {
            // Center the map on a randomly generated latitude/longitude
            Random r = new Random();
            double lat = (r.NextDouble() * 180.0) - 90.0;
            double lng = (r.NextDouble() * 360.0) - 180.0;
            object[] args = { lat, lng };
            InvokeMemberWithArguments("setCenter", args);
        }

        private void appExitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void styleToggleGroup_PressedButtonChanged(object sender, EventArgs e)
        {
            // One of the buttons in the Style dropdown menu was pressed
            if (styleBlue2010Button.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2010Blue;

            else if (styleSilver2010Button.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2010Silver;

            else if (styleBlack2010Button.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2010Black;
            else if (styleBlueButton.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2007Blue;

            else if (styleSilverButton.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2007Silver;

            else if (styleBlackButton.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Office2007Black;

            else if (styleWindows7Button.Pressed)
                c1Ribbon.VisualStyle = VisualStyle.Windows7;
        }

        private void ribbonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // A ribbon check box with a JavaScript API tag was clicked
            InvokeCheckBoxTag(sender as RibbonCheckBox);
        }

        private void c1Ribbon_RibbonEvent(object sender, RibbonEventArgs e)
        {
            // Restore focus to the browser control after interacting with the ribbon
            switch (e.EventType)
            {
                case RibbonEventType.ChangeCommitted:
                case RibbonEventType.ChangeCanceled:
                case RibbonEventType.Click:
                case RibbonEventType.DialogLauncherClick:
                case RibbonEventType.DropDownClosed:
                {
                    if (c1Ribbon.Focused)
                        webBrowser.Focus();

                    break;
                }
            }
        }
        #endregion
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class ScriptingObject
    {
        // An instance of the ScriptingObject class is accessed via windows.external in JavaScript.
        // This is necessary because the main form's parent class (C1RibbonForm) does not have the
        // ComVisible attribute.

        private GoogleMaps me;

        public ScriptingObject(GoogleMaps form)
        {
            me = form;
        }
        
        public string StatusText
        {
            set { me.StatusText = value; }
        }

        public string RecentLocation
        {
            set { me.RecentLocation = value; }
        }

        public int ZoomLevel
        {
            set { me.ZoomLevel = value; }
        }
    }
}
