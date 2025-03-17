using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

using System.Web.Script.Serialization;

#if WINFORMS
using C1.Win.Chart;
#endif
#if WPF
using C1.WPF.Chart;
#endif

namespace C1.Chart.Legacy.Serialization
{
#if WPF
    using FlexChart = C1FlexChart;
    using FlexPie = C1FlexPie;
#endif

    public class Serializer
    {
        #region FlexChartBase Serializers
        /// <summary>
        /// Serializes a FlexChart based control to an XML string.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control to serialize to an XML string.</param>
        /// <returns>A string containing a formatted XML string.</returns>
        public static string SerializeChartToXml(FlexChartBase flexChart)
        {
            if (flexChart is FlexChart)
                return SerializeFlexChartToXml(flexChart as FlexChart);
            else if (flexChart is FlexPie)
                return SerializeFlexPieToXml(flexChart as FlexPie);
            return null;
        }

        /// <summary>
        /// Serializes a FlexChart based control to a JSON string.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control to serialize to a JSON string.</param>
        /// <returns>A string containing a formatted JSON string.</returns>
        public static string SerializeChartToJson(FlexChartBase flexChart)
        {
            if (flexChart is FlexChart)
                return SerializeFlexChartToJson(flexChart as FlexChart);
            else if (flexChart is FlexPie)
                return SerializeFlexPieToJson(flexChart as FlexPie);
            return null;
        }

        /// <summary>
        /// Serializes a FlexChart based control to a byte array.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control to serialize to a byte array.</param>
        /// <returns>A byte array containing the serialized chart.</returns>
        public static byte[] SerializeChartToBytes(FlexChartBase flexChart)
        {
            if (flexChart is FlexChart)
                return SerializeFlexChartToBytes(flexChart as FlexChart);
            else if (flexChart is FlexPie)
                return SerializeFlexPieToBytes(flexChart as FlexPie);
            return null;
        }

        /// <summary>
        /// Serializes a FlexChart based control to a file.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="filename">The full path to the file to store the serialized FlexChart based control.</param>
        /// <param name="flexChart">The instance of the FlexChart based control to serialize.</param>
        /// <param name="format">A string specifying the format to use for serialization.  Presently this includes
        /// "xml", "json", "binary" and "base64" format specifications.
        /// </param>
        /// <returns>A boolean value indicating true if the serialization to the file was successfull.</returns>
        public static bool SerializeChartToFile(string filename, FlexChartBase flexChart, string format = "xml")
        {
            bool result = false;

            switch (format.ToLower())
            {
                case "xml":
                    File.WriteAllText(filename, SerializeChartToXml(flexChart));
                    result = true;
                    break;

                case "json":
                    File.WriteAllText(filename, SerializeChartToJson(flexChart));
                    result = true;
                    break;

                case "binary":
                    File.WriteAllBytes(filename, SerializeChartToBytes(flexChart));
                    result = true;
                    break;

                case "base64":
                    File.WriteAllText(filename, Convert.ToBase64String(
                        SerializeChartToBytes(flexChart), Base64FormattingOptions.InsertLineBreaks));
                    result = true;
                    break;
            }
            return result;
        }
        #endregion

        #region FlexChartBase Deserializers
        /// <summary>
        /// Deserializes a FlexChart based control from an XML string.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartString">A string containing the XML string with serialized chart information.</param>
        public static void DeserializeChartFromXml(FlexChartBase flexChart, string flexChartString)
        {
            if (flexChart is FlexChart)
                DeserializeFlexChartFromXml(flexChart as FlexChart, flexChartString);
            else if (flexChart is FlexPie)
                DeserializeFlexPieFromXml(flexChart as FlexPie, flexChartString);
        }

        /// <summary>
        /// Deserializes a FlexChart based control from a JSON string.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartString">A string containing the JSON string with serialized chart information.</param>
        public static void DeserializeChartFromJson(FlexChartBase flexChart, string flexChartString)
        {
            if (flexChart is FlexChart)
                DeserializeFlexChartFromJson(flexChart as FlexChart, flexChartString);
            else if (flexChart is FlexPie)
                DeserializeFlexPieFromJson(flexChart as FlexPie, flexChartString);
        }

        /// <summary>
        /// Deserializes a FlexChart based control from a byte array.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart based control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartBytes">A byte array containing the serialized chart information.</param>
        public static void DeserializeChartFromBytes(FlexChartBase flexChart, byte[] flexChartBytes)
        {
            if (flexChart is FlexChart)
                DeserializeFlexChartFromBytes(flexChart as FlexChart, flexChartBytes);
            if (flexChart is FlexPie)
                DeserializeFlexPieFromBytes(flexChart as FlexPie, flexChartBytes);
        }

        /// <summary>
        /// Deserializes a FlexChart based control from a file.  At present, this includes FlexChart and FlexPie controls.
        /// </summary>
        /// <param name="filename">The full path of the file containing a serialized FlexChart based control.</param>
        /// <param name="flexChart">The instance of the FlexChart based control into which the serialized chart data is to be loaded.</param>
        /// <param name="format">A string specifying the format to use for deserialization.  Presently this includes
        /// "xml", "json", "binary" and "base64" format specifications.
        /// </param>
        /// <returns>A boolean value indicating true if the deserialization from the file was successfull.</returns>
        public static bool DeserializeChartFromFile(string filename, FlexChartBase flexChart, string format = "xml")
        {
            if (flexChart is FlexChart)
                DeserializeFlexChartFromFile(filename, flexChart as FlexChart, format);
            else if (flexChart is FlexPie)
                DeserializeFlexPieFromFile(filename, flexChart as FlexPie, format);
            return false;
        }
        #endregion


        #region private Serialization Methods
        private static string SerializeObjectModelToXml(object model)
        {
            string result = null;
            using (var sw = new StringWriter())
            {
                XmlSerializer ser = new XmlSerializer(model.GetType());
                ser.Serialize(sw, model);
                result = sw.ToString();
            }
            return result;
        }
        private static string SerializeObjectModelToJson(object model)
        {
            string result = null;
            using (var sw = new StringWriter())
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string jsonText = ser.Serialize(model);
                jsonText = Serializer.JsonFormatter(jsonText);
                result = jsonText;
            }
            return result;
        }
        private static byte[] SerializeObjectModelToBytes(object model)
        {
            byte[] result = null;
            using (MemoryStream sw = new MemoryStream())
            {
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(sw, model);
                sw.Position = 0;
                result = sw.ToArray();
            }
            return result;
        }
        #endregion

        #region public FlexChart Serialization
        /// <summary>
        /// Serializes a FlexChart control to an XML string.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control to serialize to an XML string.</param>
        /// <returns>A string containing a formatted XML string.</returns>
        public static string SerializeFlexChartToXml(FlexChart flexChart)
        {
            return SerializeObjectModelToXml(new ChartModel(flexChart));
        }

        /// <summary>
        /// Serializes a FlexChart control to an JSON string.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control to serialize to an JSON string.</param>
        /// <returns>A string containing a formatted JSON string.</returns>
        public static string SerializeFlexChartToJson(FlexChart flexChart)
        {
            return SerializeObjectModelToJson(new ChartModel(flexChart));
        }

        /// <summary>
        /// Serializes a FlexChart control to a byte array.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control to serialize to a byte array.</param>
        /// <returns>A byte array containing the serialized chart.</returns>
        public static byte[] SerializeFlexChartToBytes(FlexChart flexChart)
        {
            return SerializeObjectModelToBytes(new ChartModel(flexChart));
        }
        #endregion

        #region public FlexPie Serialization
        /// <summary>
        /// Serializes a FlexPie control to an XML string.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control to serialize to an XML string.</param>
        /// <returns>A string containing a formatted XML string.</returns>
        public static string SerializeFlexPieToXml(FlexPie flexPie)
        {
            return SerializeObjectModelToXml(new PieModel(flexPie));
        }

        /// <summary>
        /// Serializes a FlexPie control to an JSON string.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control to serialize to an JSON string.</param>
        /// <returns>A string containing a formatted JSON string.</returns>
        public static string SerializeFlexPieToJson(FlexPie flexPie)
        {
            return SerializeObjectModelToJson(new PieModel(flexPie));
        }

        /// <summary>
        /// Serializes a FlexPie control to a byte array.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control to serialize to a byte array.</param>
        /// <returns>A byte array containing the serialized chart.</returns>
        public static byte[] SerializeFlexPieToBytes(FlexPie flexPie)
        {
            return SerializeObjectModelToBytes(new PieModel(flexPie));
        }
        #endregion


        #region private Deserialization Methods
//#if WINFORMS
        private static object DeserializeObjectModelFromXml(Type modelType, string chartString)
        {
            XmlSerializer ser = new XmlSerializer(modelType);
            var sr = new StringReader(chartString);
            return ser.Deserialize(sr);
        }
        private static object DeserializeObjectModelFromJson(Type modelType, string chartString)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize(chartString, modelType);
        }
        private static object DeserializeObjectModelFromBytes(Type modelType, byte[] chartBytes)
        {
            using (MemoryStream stream = new MemoryStream(chartBytes))
            {
                BinaryFormatter ser = new BinaryFormatter();
                return ser.Deserialize(stream);
            }
        }

        private static object DeserializeModelFromData(Type modelType, object data, string format = "xml")
        {
            object model = null;
            switch (format)
            {
                case "xml":
                    model = DeserializeObjectModelFromXml(modelType, data as string);
                    break;

                case "json":
                    model = DeserializeObjectModelFromJson(modelType, data as string);
                    break;

                case "binary":
                    model = DeserializeObjectModelFromBytes(modelType, data as byte[]);
                    break;

                case "base64":
                    model = DeserializeObjectModelFromBytes(modelType, Convert.FromBase64String(data as string));
                    break;
            }
            return model;
        }
        private static void DeserializeFlexChartFromData(FlexChart flexChart, object flexChartData, string format = "xml")
        {
            flexChart.BeginUpdate();
#if WINFORMS
            flexChart.DataSource = null;
#else
            flexChart.ItemsSource = null;
#endif
            ChartModel model = DeserializeModelFromData(typeof(ChartModel), flexChartData, format) as ChartModel;
            ChartModel.Load(flexChart, model);

            flexChart.EndUpdate();
        }
        private static void DeserializeFlexPieFromData(FlexPie flexPie, object flexPieData, string format = "xml")
        {
            flexPie.BeginUpdate();

            PieModel model = DeserializeModelFromData(typeof(PieModel), flexPieData, format) as PieModel;
            PieModel.Load(flexPie, model);

            flexPie.EndUpdate();
        }

        #endregion

        #region public FlexChart Deserialization

        /// <summary>
        /// Deserializes a FlexChart control from an XML string.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartString">A string containing the XML string with serialized chart information.</param>
        public static void DeserializeFlexChartFromXml(FlexChart flexChart, string flexChartString)
        {
            DeserializeFlexChartFromData(flexChart, flexChartString, "xml");
        }

        /// <summary>
        /// Deserializes a FlexChart control from a JSON string.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartString">A string containing the JSON string with serialized chart information.</param>
        public static void DeserializeFlexChartFromJson(FlexChart flexChart, string flexChartString)
        {
            DeserializeFlexChartFromData(flexChart, flexChartString, "json");
        }

        /// <summary>
        /// Deserializes a FlexChart control from a byte array.
        /// </summary>
        /// <param name="flexChart">The instance of the FlexChart control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexChartBytes">A byte array containing the serialized chart information.</param>
        public static void DeserializeFlexChartFromBytes(FlexChart flexChart, byte[] flexChartBytes)
        {
            DeserializeFlexChartFromData(flexChart, flexChartBytes, "binary");
        }

        /// <summary>
        /// Deserializes a FlexChart control from a file.
        /// </summary>
        /// <param name="filename">The full path of the file containing a serialized FlexChart control.</param>
        /// <param name="flexChart">The instance of the FlexChart control into which the serialized chart data is to be loaded.</param>
        /// <param name="format">A string specifying the format to use for deserialization.  Presently this includes
        /// "xml", "json", "binary" and "base64" format specifications.
        /// </param>
        /// <returns>A boolean value indicating true if the deserialization from the file was successfull.</returns>
        public static bool DeserializeFlexChartFromFile(string filename, FlexChart flexChart, string format = "xml")
        {
            bool result = false;
            object data = null;

            if (format == "xml" || format == "json")
                data = File.ReadAllText(filename);
            else if (format == "binary" || format == "base64")
                data = File.ReadAllBytes(filename);

            if (data != null)
            {
                try
                {
                    DeserializeFlexChartFromData(flexChart, data, format);
                    result = true;
                }
                catch { }
            }
            return result;
        }

        #endregion

        #region public FlexPie Deserialization

        /// <summary>
        /// Deserializes a FlexPie control from a XML string.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexPieString">A string containing the XML string with serialized chart information.</param>
        public static void DeserializeFlexPieFromXml(FlexPie flexPie, string flexPieString)
        {
            DeserializeFlexPieFromData(flexPie, flexPieString, "xml");
        }

        /// <summary>
        /// Deserializes a FlexPie control from a JSON string.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexPieString">A string containing the JSON string with serialized chart information.</param>
        public static void DeserializeFlexPieFromJson(FlexPie flexPie, string flexPieString)
        {
            DeserializeFlexPieFromData(flexPie, flexPieString, "json");
        }

        /// <summary>
        /// Deserializes a FlexPie control from a byte array.
        /// </summary>
        /// <param name="flexPie">The instance of the FlexPie control into which the serialized chart data is to be loaded.</param>
        /// <param name="flexPieBytes">A byte array containing the serialized chart information.</param>
        public static void DeserializeFlexPieFromBytes(FlexPie flexPie, byte[] flexPieBytes)
        {
            DeserializeFlexPieFromData(flexPie, flexPieBytes, "binary");
        }

        /// <summary>
        /// Deserializes a FlexPie control from a file.
        /// </summary>
        /// <param name="filename">The full path of the file containing a serialized FlexPie control.</param>
        /// <param name="flexPie">The instance of the FlexPie control into which the serialized chart data is to be loaded.</param>
        /// <param name="format">A string specifying the format to use for deserialization.  Presently this includes
        /// "xml", "json", "binary" and "base64" format specifications.</param>
        /// <returns>A boolean value indicating true if the deserialization from the file was successfull.</returns>
        public static bool DeserializeFlexPieFromFile(string filename, FlexPie flexPie, string format = "xml")
        {
            bool result = false;
            object data = null;

            if (format == "xml" || format == "json")
                data = File.ReadAllText(filename);
            else if (format == "binary" || format == "base64")
                data = File.ReadAllBytes(filename);

            if (data != null)
            {
                try
                {
                    DeserializeFlexPieFromData(flexPie, data, format);
                    result = true;
                }
                catch { }
            }
            return result;
        }

        #endregion


        #region Utilities
        public static void DebugSerializer()
        {
            if (Debugger.IsAttached)
                Debugger.Break();
            else
                Debugger.Launch();
        }

        static string JsonFormatter(string jsonText)
        {
            StringBuilder sb = new StringBuilder();
            const int spaceInc = 2;
            int indent = spaceInc;
            string spaces = " ".PadLeft(10 * spaceInc);     // up to 10 levels deep

            sb.AppendLine("{");
            sb.Append(spaces.Substring(0, indent));

            for (int i = 1; i < jsonText.Length; i++)
            {
                char c = jsonText[i];

                // skip existing new lines.
                if (c == '\r' || c == '\n')
                    continue;

                // copy quoted data exactly
                if (c == '"')
                {
                    do
                    {
                        sb.Append(jsonText[i++]);
                    } while (jsonText[i] != '"');
                    sb.Append(jsonText[i]);
                    continue;
                }

                // handle indenting
                if (c == '{' || c == '[')
                {
                    if ("{}[],".IndexOf(jsonText[i - 1]) < 0)
                    {
                        sb.AppendLine();
                        if (indent > 0) sb.Append(spaces.Substring(0, indent));
                    }
                    sb.AppendLine(c.ToString());
                    indent += spaceInc;

                    if (indent > 0) sb.Append(spaces.Substring(0, indent));
                }
                else if (c == '}' || c == ']')
                {
                    sb.AppendLine();
                    if (indent > 0 && i <= jsonText.Length - 1)
                    {
                        indent -= spaceInc;
                        if (indent > 0) sb.Append(spaces.Substring(0, indent));
                    }
                    if (i + 1 < jsonText.Length)
                    {
                        if (jsonText[i + 1] == ',')
                        {
                            sb.AppendLine(c.ToString() + ",");
                            i++;
                        }
                        else if (jsonText[i + 1] == ']' || jsonText[i + 1] == '}')
                        {
                            sb.Append(c);
                            continue;
                        }
                        else
                            sb.AppendLine(c.ToString());
                    }
                    else
                        sb.AppendLine(c.ToString());
                    if (indent > 0) sb.Append(spaces.Substring(0, indent));
                }
                else if (c == ',')
                {
                    sb.AppendLine(c.ToString());
                    if (indent > 0) sb.Append(spaces.Substring(0, indent));
                }
                else if (c == ':' && (jsonText[i + 1] == '[' || jsonText[i + 1] == '{'))
                {
                    sb.AppendLine(c.ToString() + " " + jsonText[i + 1]);
                    indent += spaceInc;
                    sb.Append(spaces.Substring(0, indent));
                    i++; continue;
                }
                else
                {
                    sb.Append(c);
                    if (c == '\n' && indent > 0)
                        sb.Append(spaces.Substring(0, indent));
                }
            }
            jsonText = sb.ToString();
            return jsonText;
        }
        #endregion
    }
}
