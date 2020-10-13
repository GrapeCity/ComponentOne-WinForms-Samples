using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace ControlHostLib
{
    /// <summary>
    /// The Ribbon element that contains an ActiveX element (WebBrowser).
    /// </summary>
    public class AxWebBrowserHost : RibbonControlHost
    {
        public const string XmlNodeName = "axWebBrowserHost";

        string _nextUrl;

        /// <summary>
        /// Creates the ActiveX control and its host element.
        /// </summary>
        public AxWebBrowserHost()
            : base(new AxSHDocVw.AxWebBrowser())
        {
        }

        /// <inheritdoc />
        public override string ControlHostNodeName
        {
            get { return XmlNodeName; }
        }

        /// <summary>
        /// Gets the hosted AxWebBrowser control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AxSHDocVw.AxWebBrowser AxWebBrowser
        {
            get { return (AxSHDocVw.AxWebBrowser)Control; }
        }

        /// <summary>
        /// Navigates the browser to the specified URL.
        /// </summary>
        public void Navigate(string url)
        {
            if (!AxWebBrowser.IsHandleCreated)
            {
                _nextUrl = url;
                AxWebBrowser.HandleCreated += new EventHandler(AxWebBrowser_HandleCreated);
            }
            else
                AxWebBrowser.Navigate(url);
        }

        private void AxWebBrowser_HandleCreated(object sender, EventArgs e)
        {
            AxWebBrowser.HandleCreated -= new EventHandler(AxWebBrowser_HandleCreated);
            if (_nextUrl != null)
            {
                AxWebBrowser.Navigate(_nextUrl);
                _nextUrl = null;
            }
        }
    }
}
