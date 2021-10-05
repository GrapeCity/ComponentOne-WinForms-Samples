using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace FloatingBarChart
{
    public static class Localizer
    {
        static string currentCultureConfiguration = string.Empty;
        static Localizer()
        {
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en-US": currentCultureConfiguration = FloatingBarChart.Properties.Resources.ExplorerConfiguration_EN; break;
                case "ch-CH": currentCultureConfiguration = FloatingBarChart.Properties.Resources.ExplorerConfiguration_JP; break;
                case "jp-JP": currentCultureConfiguration = FloatingBarChart.Properties.Resources.ExplorerConfiguration_CH; break;
                default: currentCultureConfiguration = FloatingBarChart.Properties.Resources.ExplorerConfiguration_EN; break;
            }
        }

        public static string GetItem(string id, string attribute)
        {
            try
            {
                string result = String.Empty;

                XmlDocument xml = new XmlDocument();
                xml.Load(new StringReader(currentCultureConfiguration));
                foreach (XmlNode n in xml.SelectNodes("/samples/sample"))
                {
                    if (n.Attributes["id"].Value == id && n.SelectSingleNode(attribute) != null)
                    {
                        result = n.SelectSingleNode(attribute).InnerText;
                        break;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                return string.Format("Error getting localized text: {0}", ex.Message);
            }
        }
        public static string MakeRtf(this string source)
        {

            var result = (@"{\rtf1\ansi\deff0{\colortbl \red100\green100\blue100;\red255\green0\blue0;}" + source + " }")
                .Replace("[b]", "\\b ")
                .Replace("[/b]", "\\b0 ")
                .Replace("[color]", "\\cf1 ")
                .Replace("[/color]", "\\cf0 ")
                .Replace("\r\n", "\\line ");
            return result;
        }
    }
}
