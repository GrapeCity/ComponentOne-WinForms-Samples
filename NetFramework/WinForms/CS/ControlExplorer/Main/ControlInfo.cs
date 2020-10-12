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
#if (CLR45)
        private const string SAMPLE_TREE = "C1Controls.4.5.2.xml";
#else
        private const string SAMPLE_TREE = "C1Controls.xml";
#endif

        static ControlInfo()
        {
            // parse control descriptions from xml
            XElement elem = XDocument.Load(SAMPLE_TREE).Root;
            int pageIndex = 0;
            Controls = new List<ControlInfo>();
            foreach (XElement controlNode in elem.Descendants("control").ToList())
            {
                ControlInfo control = new ControlInfo();
                if (controlNode.Attribute("name") != null)
                {
                    control.Name = controlNode.Attribute("name").Value;
                }
                if (controlNode.Attribute("link") != null)
                {
                    control.Link = controlNode.Attribute("link").Value;
                }
                if (controlNode.Attribute("tooltip") != null)
                {
                    control.Tooltip = controlNode.Attribute("tooltip").Value;
                }
                if (controlNode.Attribute("group") != null)
                {
                    control.Group = controlNode.Attribute("group").Value;
                }
                if (controlNode.Attribute("status") != null)
                {
                    foreach (string val in controlNode.Attribute("status").Value.Split(','))
                    {
                        switch (val)
                        {
                            case "new":
                                control.IsNew = true;
                                break;
                            case "popular":
                                control.IsPopular = true;
                                break;
                        }
                    }
                }
                else
                {
                    control.IsNew = false;
                    control.IsPopular = false;
                }
                if (controlNode.Attribute("newFeatureName") != null)
                {
                    control.NewFeatureName = controlNode.Attribute("newFeatureName").Value;
                }
                /*      // todo: we have it in xml, but currently it is not used
                        if (controlNode.Attribute("icon") != null)
                        {
                            string icon = controlNode.Attribute("icon").Value;
                            if (_icons.ContainsKey(icon))
                            {
                                control.Icon = _icons[icon].Image;
                            }
                        }
                        if (control.Icon == null)
                        {
                            if (!_icons.ContainsKey(control.Name))
                            {
                                _icons.Add(control.Name, Properties.Resources.ci_Empty); // Default empty icon for new stuff
                            }
                            control.Icon = _icons[control.Name].Image;
                        }*/
                control.Features = new List<FeatureInfo>();
                foreach (XElement node in controlNode.Elements())
                {
                    if (node.Name == "sample")
                    {
                        SampleInfo sample = ReadSampleData(node);
                        control.Features.Add(sample);
                    }
                    else if (node.Name == "category")
                    {
                        CategoryInfo category = ReadCategoryData(node);
                        if (category.Samples.Count > 0)
                        {
                            control.Features.Add(category);
                        }
                    }
                }
                ControlInfo.Controls.Add(control);
                pageIndex++;
            }
        }

        private static SampleInfo ReadSampleData(XElement sampleNode)
        {
            SampleInfo sample = new SampleInfo();
            if (sampleNode.Attribute("name") != null)
            {
                sample.Name = sampleNode.Attribute("name").Value;
            }
            if (sampleNode.Attribute("form") != null)
            {
                sample.FormName = sampleNode.Attribute("form").Value;
            }
            if (sampleNode.Attribute("short") != null)
            {
                sample.ShortDescription = sampleNode.Attribute("short").Value;
            }
            if (sampleNode.Attribute("description") != null)
            {
                sample.LongDescription = sampleNode.Attribute("description").Value.Replace("\\r\\n", "\r\n");
            }
            if (sampleNode.Attribute("status") != null)
            {
                sample.IsNew = (sampleNode.Attribute("status").Value == "new") ? true : false;
            }
            else
            {
                sample.IsNew = false;
            }
            return sample;
        }

        private static CategoryInfo ReadCategoryData(XElement catNode)
        {
            CategoryInfo category = new CategoryInfo();
            if (catNode.Attribute("name") != null)
            {
                category.Name = catNode.Attribute("name").Value;
            }
            if (catNode.Attribute("status") != null)
            {
                category.IsNew = (catNode.Attribute("status").Value == "new") ? true : false;
            }
            else
            {
                category.IsNew = false;
            }
            category.Samples = new List<SampleInfo>();
            foreach (XElement sampleNode in catNode.Descendants("sample"))
            {
                SampleInfo sample = ReadSampleData(sampleNode);
                category.Samples.Add(sample);
            }
            return category;
        }
#endregion

#region control properties
        public string Name { get; set; }
        public bool IsNew { get; set; }
        public bool IsPopular { get; set; }
        public string NewFeatureName { get; set; }
        public string Group { get; set; }
        public string Link { get; set; }
        public string Tooltip { get; set; }
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
        /// <summary>
        /// The name of form which should be shown when this sample is selected.
        /// </summary>
        public string FormName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }

    /// <summary>
    /// Describes category which can be used to group samples.
    /// </summary>
    public class CategoryInfo : FeatureInfo
    {
        public List<SampleInfo> Samples;
    }

    /// <summary>
    /// The base class for all control features
    /// </summary>
    public class FeatureInfo
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public bool IsNew { get; set; }
    }
}
