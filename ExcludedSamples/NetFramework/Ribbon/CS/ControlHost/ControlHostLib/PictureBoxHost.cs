using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

using C1.Win.C1Ribbon;

namespace ControlHostLib
{
    /// <summary>
    /// The Ribbon element that contains a PictureBox.
    /// </summary>
    public class PictureBoxHost : RibbonControlHost
    {
        public const string XmlNodeName = "pictureBoxHost";

        /// <summary>
        /// Creates the PictureBox control and its host element.
        /// </summary>
        public PictureBoxHost()
            : base(new PictureBox())
        {
        }

        /// <inheritdoc />
        public override string ControlHostNodeName
        {
            get { return XmlNodeName; }
        }

        /// <summary>
        /// Gets the hosted PictureBox control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBox PictureBox
        {
            get { return (PictureBox)Control; }
        }

        /// <summary>
        /// Gets or sets the image that the PictureBox displays.
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets the image that the PictureBox displays.")]
        public Image Image
        {
            get { return PictureBox.Image; }
            set { PictureBox.Image = value; }
        }

        /// <inheritdoc />
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get { return string.Empty; }
            set { }
        }

        protected override void LoadControlHostProperties(XmlNode node)
        {
            base.LoadControlHostProperties(node);
            Image = ReadImage(node, "image");
        }

        protected override void SaveControlHostProperties(XmlWriter writer)
        {
            base.SaveControlHostProperties(writer);
            if (Image != null)
            {
                WriteImage(writer, "image", Image);
            }
        }

        static Image ReadImage(XmlNode node, string prefix)
        {
            XmlAttribute att = node.Attributes[prefix + "Base64"];
            if (att != null)
            {
                byte[] buf = Convert.FromBase64String(att.Value);
                MemoryStream ms = new MemoryStream(buf);
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(ms) as Image;
            }
            return null;
        }

        static void WriteImage(XmlWriter writer, string prefix, Image image)
        {
            if (image != null)
            {
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, image);
                string base64 = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                writer.WriteAttributeString(prefix + "Base64", base64);
            }
        }
    }
}
