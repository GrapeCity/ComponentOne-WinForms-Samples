using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TestCases
{
    /// <summary>
    /// Utility class for reading Xml.
    /// </summary>
    internal class XmlUtil
    {
        public static bool Read(XmlNode nd, string attName, bool defVal)
        {
            XmlAttribute att = nd.Attributes[attName];
            if (att != null)
            {
                return bool.Parse(att.Value);
            }
            return defVal;
        }
        public static int Read(XmlNode nd, string attName, int defVal)
        {
            XmlAttribute att = nd.Attributes[attName];
            if (att != null)
            {
                return int.Parse(att.Value);
            }
            return defVal;
        }
        public static string Read(XmlNode nd, string attName, string defVal)
        {
            XmlAttribute att = nd.Attributes[attName];
            if (att != null)
            {
                return att.Value;
            }
            return defVal;
        }
        public static Image ReadImage(XmlNode nd, string prefix)
        {
            // read image from file
            XmlAttribute att = nd.Attributes[prefix + "File"];
            if (att != null)
            {
                string fileName = att.Value;
                if (!Path.IsPathRooted(fileName) && nd.BaseURI.Length > 0)
                {
                    string path = Path.GetDirectoryName(nd.BaseURI);
                    if (path.StartsWith(@"file:\"))
                    {
                        path = path.Substring(6);
                    }
                    fileName = Path.Combine(path, fileName);
                }
                if (File.Exists(fileName))
                {
                    return Image.FromFile(fileName);
                }
            }

            // read image from base64 string
            att = nd.Attributes[prefix + "Base64"];
            if (att != null)
            {
                byte[] buf = Convert.FromBase64String(att.Value);
                MemoryStream ms = new MemoryStream(buf);
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(ms) as Image;
            }

            // no image data in node
            return null;
        }
    }
}
