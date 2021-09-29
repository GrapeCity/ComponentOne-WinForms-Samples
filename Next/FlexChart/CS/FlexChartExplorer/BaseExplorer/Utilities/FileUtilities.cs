using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using BaseExplorer.Model;

namespace BaseExplorer.Utilities
{
    class FileUtilities
     {
        public static T DeserializeXml<T>(string path)
        {
            using (var reader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(reader);
            }
        }
    }
}
