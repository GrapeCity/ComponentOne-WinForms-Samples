using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Text;
using C1.C1Preview;

namespace C1ReportsScheduler
{
    internal static class Util
    {
        private static long s_nextId;
        public const long NullId = -1;
        public const long NewestId = -2; // used to indicated a newly added item

        static Util()
        {
            s_nextId = 1; // DateTime.Now.Ticks.GetHashCode();
        }

        public static long NewId()
        {
            return s_nextId++;
        }

        public static void SetProperty(object target, string propertyName, string propertyValue)
        {
            if (target == null)
                return;
            try
            {
                PropertyDescriptor pd = TypeDescriptor.GetProperties(target)[propertyName];
                object value = TypeDescriptor.GetConverter(pd.PropertyType).ConvertFrom(propertyValue);
                pd.SetValue(target, value);
            }
            catch
            {
                AltUtil.ShowError(string.Format("SetProperty failed for {0}, value was {1}.", propertyName, propertyValue));
            }
        }

        public static void CopyNonXmlIgnoreProperties(object target, object source, Type type)
        {
            PropertyInfo[] pis = type.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                if (!pi.CanRead || !pi.CanWrite)
                    continue;
                if (pi.GetCustomAttributes(typeof(XmlIgnoreAttribute), true).Length > 0)
                    continue;
                pi.SetValue(target, pi.GetValue(source, null), null);
            }
        }

        public static string ToXml(object source, Type type)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // note: using XmlSerializer(type) ctor should be save as infrastructure
                // itself caches/reuses serializers in this case:
                XmlSerializer xs = new XmlSerializer(type);
                xs.Serialize(ms, source);
                ms.Seek(0, SeekOrigin.Begin);
                return UTF8Encoding.Default.GetString(ms.GetBuffer());
            }
        }

        public static object FromXml(string xml, Type type)
        {
            using (MemoryStream ms = new MemoryStream(UTF8Encoding.Default.GetBytes(xml)))
            {
                XmlSerializer xs = new XmlSerializer(type);
                return xs.Deserialize(ms);
            }
        }

        public class MustOverrideException : Exception
        {
            // NOTE: This should NOT happen (i.e. this is for debug only).
            public MustOverrideException()
                : base("This property or method must be overridden in the derived class!")
            {
            }
        }

        public class ShouldNotHappenException : Exception
        {
            // NOTE: This should NOT happen (i.e. this is for debug only).
            public ShouldNotHappenException()
                : base("This code should never execute!")
            {
            }
        }

        public static string GetAssemblyAboutName(Assembly assembly)
        {
            return GetAssemblyAboutName(assembly.GetName());
        }

        public static string GetAssemblyAboutName(AssemblyName name)
        {
            try
            {
                return string.Format("{0}, Version {1}", name.Name, name.Version);
            }
            catch
            {
                return "<error - could not parse assembly name!>";
            }
        }

        // stolen from http://www.codinghorror.com/blog/archives/000264.html
        public static DateTime RetrieveLinkerTimestamp(Assembly asmb)
        {
            try
            {
                string filePath = asmb.Location;
                const int c_PeHeaderOffset = 60;
                const int c_LinkerTimestampOffset = 8;
                byte[] b = new byte[2048];

                using (Stream s = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    s.Read(b, 0, 2048);

                int i = System.BitConverter.ToInt32(b, c_PeHeaderOffset);
                int secondsSince1970 = System.BitConverter.ToInt32(b, i + c_LinkerTimestampOffset);
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
                dt = dt.AddSeconds(secondsSince1970);
                dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
                return dt;
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
                return DateTime.MaxValue;
            }
        }
    }
}
