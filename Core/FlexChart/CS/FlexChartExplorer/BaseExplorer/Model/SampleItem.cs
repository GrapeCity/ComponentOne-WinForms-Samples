using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using BaseExplorer.Utilities;


namespace BaseExplorer.Model
{
    [XmlRoot("items")]
    public class SamplesCollection
    {
        [XmlElement("item")]
        public SampleItem[] Samples { get; set; }

    }

    public class SampleItem
    {
        [XmlIgnore]
        public Guid Guid
        { get; private set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("status")]
        public string Status { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("summary")]
        public string Summary { get; set; }

        private string _title;

        [XmlAttribute("title")]
        public string Title
        {
            get
            {
                return string.IsNullOrEmpty(_title) ? Name : _title;
            }
            set
            {
                _title = value;
            }
        }

        public string _expanded_Image;


        [XmlAttribute("expanded_Image")]
        public string ExpandedImage
        {
            get
            {
                return _expanded_Image;
            }
            set
            {
                _expanded_Image = value;
            }
        }

        public string _collapsed_Image;


        [XmlAttribute("icon")]
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }

        public string _icon;


        [XmlAttribute("collapsed_Image")]
        public string CollapsedImage
        {
            get
            {
                return _collapsed_Image;
            }
            set
            {
                _collapsed_Image = value;
            }
        }

        private SampleItem[] itemsArray;

        [XmlArray("items"), XmlArrayItem("item")]
        public SampleItem[] ItemsArray
        {
            get { return itemsArray; }
            set
            {
                itemsArray = value;
                if (itemsArray != null)
                {
                    foreach (var item in itemsArray)
                        item.Parent = this;
                }
            }
        }

        private List<SampleItem> items;

        public List<SampleItem> Items
        {
            get
            {
                if (items == null && ItemsArray != null)
                {
                    items = new List<SampleItem>();
                    items.AddRange(ItemsArray);
                }
                return items;
            }
        }

        [XmlAttribute("type")]
        public string TypeName { get; set; }

        public SampleItem Parent { get; set; }

        public int Depth
        {
            get
            {
                if (Items.IsNullOrEmpty())
                {
                    return 0;
                }
                return Items.Select(x => x.Depth)
                            .DefaultIfEmpty()
                            .Max() + 1;
            }
        }

        [XmlAttribute("keyWords")]
        public string KeyWords { get; set; }

        public SampleItem()
        {
            Guid = Guid.NewGuid();
        }
        public override string ToString()
        {
            var str = String.Format(" Name: {0} ChildItems:{1}", Title, Items.IsNullOrEmpty() ? 0 : Items.Count);
            return str;
        }

    }
}
