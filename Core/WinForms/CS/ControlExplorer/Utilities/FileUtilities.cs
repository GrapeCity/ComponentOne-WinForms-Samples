using System.IO;
using System.Xml.Serialization;

namespace ControlExplorer.Utilities
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
