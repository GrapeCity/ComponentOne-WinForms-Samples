using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.PDF
{
    internal static class CustomNavigationHelper
    {
        public static string GetFallbackHtml(string fallbackFileName)
        {
            // Define the path to the fallback HTML file
            string fallbackPath = "Resources\\" + fallbackFileName;

            // Read the content of the HTML file and return it as a string
            return System.IO.File.ReadAllText(fallbackPath);
        }

        public static void AddExternalLinkHandler(WebBrowser webBrowser)
        {
            if (webBrowser?.Document != null)
            {
                foreach (HtmlElement link in webBrowser.Document.GetElementsByTagName("a"))
                {
                    link.Click += (s, args) =>
                    {
                        var href = link.GetAttribute("href");
                        if (!string.IsNullOrEmpty(href))
                        {
                            // Open link in the default browser
                            System.Diagnostics.Process.Start(href);
                            args.ReturnValue = false; // Prevent navigation in WebBrowser
                        }
                    };
                }
            }
        }

    }
}

