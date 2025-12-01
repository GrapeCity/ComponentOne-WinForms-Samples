using System.IO;
using System.Xml.Serialization;

namespace FlexGridExplorer.Utility
{
    /// <summary>
    /// Provides helper methods for file operations such as XML deserialization.
    /// </summary>
    class FileUtils
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
