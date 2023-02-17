using C1.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ControlExplorer
{
    /// <summary>
    /// Keeps static collection of control descriptions and features.
    /// </summary>
    public class ControlInfo
    {
        #region static
        public static List<ControlInfo> Controls;
        private const string SAMPLE_TREE = "Resources\\C1Controls.xml";

        static ControlInfo()
        {
            // parse control descriptions from xml
            XElement elem = XDocument.Load(SAMPLE_TREE).Root;
            Controls = new List<ControlInfo>();
            foreach (XElement controlNode in elem.Descendants("control").ToList())
            {
                ControlInfo control = new ControlInfo(controlNode);
                Controls.Add(control);
            }
        }
        #endregion

        #region control properties
        public ControlInfo(XElement node)
        {
            if (node.Attribute("name") != null)
            {
                Name = node.Attribute("name").Value;
            }
            if (node.Attribute("link") != null)
            {
                Link = node.Attribute("link").Value;
            }
            if (node.Attribute("tooltip") != null)
            {
                Tooltip = node.Attribute("tooltip").Value;
            }
            if (node.Attribute("group") != null)
            {
                Group = node.Attribute("group").Value;
            }
            if (node.Attribute("status") != null)
            {
                foreach (string val in node.Attribute("status").Value.Split(','))
                {
                    switch (val)
                    {
                        case "new":
                            IsNew = true;
                            break;
                        case "popular":
                            IsPopular = true;
                            break;
                    }
                }
            }
            else
            {
                IsNew = false;
                IsPopular = false;
            }
            if (node.Attribute("defaultSampleName") != null)
            {
                DefaultSampleName = node.Attribute("defaultSampleName").Value;
            }
            Icon = ControlIcons.GetControlIcon(Name, IsNew, IsPopular);
            Features = new List<FeatureInfo>();
            foreach (XElement fNode in node.Elements())
            {
                if (fNode.Name == "sample")
                {
                    SampleInfo sample = new SampleInfo(fNode);
                    Features.Add(sample);
                }
                else if (fNode.Name == "category")
                {
                    CategoryInfo category = new CategoryInfo(fNode);
                    if (category.Samples.Count > 0)
                    {
                        Features.Add(category);
                    }
                }
            }
        }

        public string Name { get; set; }
        public bool IsNew { get; set; }
        public bool IsPopular { get; set; }
        public string DefaultSampleName { get; set; }
        public string Group { get; set; }
        public string Link { get; set; }
        public string Tooltip { get; set; }
        public C1Icon Icon { get; private set; }
        public List<FeatureInfo> Features;
        public override string ToString()
        {
            return Name;
        }

        public FeatureInfo Find(string name)
        {
            foreach (FeatureInfo feature in Features)
            {
                if (feature.Name == name)
                {
                    return feature;
                }
                if (feature is CategoryInfo)
                {
                    foreach (FeatureInfo sample in ((CategoryInfo)feature).Samples)
                    {
                        if (sample.Name == name)
                        {
                            return sample;
                        }
                    }
                }
            }
            return null;
        }
        #endregion
    }

    /// <summary>
    /// Sample description
    /// </summary>
    public class SampleInfo : FeatureInfo
    {
        public SampleInfo(XElement node)
            : base(node)
        {
            if (node.Attribute("assembly") != null)
            {
                AssemblyName = node.Attribute("assembly").Value;
            }
            if (node.Attribute("type") != null)
            {
                TypeName = node.Attribute("type").Value;
            }
            else
            {
                TypeName = Name; // fallback to Name if they are the same
            }
            if (node.Attribute("short") != null)
            {
                ShortDescription = node.Attribute("short").Value;
            }
            if (node.Attribute("description") != null)
            {
                LongDescription = node.Attribute("description").Value.Replace("\\r\\n", "\r\n");
            }
        }
        /// <summary>
        /// The name of form which should be shown when this sample is selected.
        /// </summary>
        public string TypeName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AssemblyName { get; set; }
        public string Category { get; set; }
    }

    /// <summary>
    /// Describes category which can be used to group samples.
    /// </summary>
    public class CategoryInfo : FeatureInfo
    {
        public CategoryInfo(XElement node)
            : base(node)
        {
            Samples = new List<SampleInfo>();
            foreach (XElement sampleNode in node.Descendants("sample"))
            {
                SampleInfo sample = new SampleInfo(sampleNode);
                sample.Category = this.Name;
                Samples.Add(sample);
            }
        }
        public List<SampleInfo> Samples;
    }

    /// <summary>
    /// The base class for all control features
    /// </summary>
    public class FeatureInfo
    {
        public FeatureInfo(XElement node)
        {
            if (node.Attribute("name") != null)
            {
                Name = node.Attribute("name").Value;
            }
            if (node.Attribute("status") != null)
            {
                IsNew = (node.Attribute("status").Value == "new") ? true : false;
            }
            else
            {
                IsNew = false;
            }
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public bool IsNew { get; set; }
    }
}
