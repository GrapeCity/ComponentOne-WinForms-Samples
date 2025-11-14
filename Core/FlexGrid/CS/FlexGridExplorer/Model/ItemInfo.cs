using FlexGridExplorer.Utility;
using System.Xml.Serialization;

namespace FlexGridExplorer
{
    [XmlRoot("items")]
    public class ItemsCollection
    {
        [XmlElement("item")]
        public ItemInfo[] Items { get; set; }

    }
    public class ItemInfo
    {
        [XmlIgnore]
        #region Private Variables

        List<ItemInfo> _items;
        ItemInfo[] _itemsArray;

        #endregion

        #region Public Methods
        public List<ItemInfo> Items
        {
            get
            {
                if (_items == null && ItemsArray != null)
                {
                    _items = new List<ItemInfo>();
                    _items.AddRange(ItemsArray);
                }
                return _items;
            }
        }

        public ItemInfo Parent { get; set; }
        public ItemInfo()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid
        { get; set; }

        public ItemInfo Find(string name)
        {
            if (Name == name)
                return this;

            if (ItemsArray != null)
            {
                foreach (var subItem in ItemsArray)
                {
                    var found = subItem.Find(name);
                    if (found != null)
                        return found;
                }
            } 

            return null;
        }

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
        #endregion

        #region control properties

        [XmlArray("items"), XmlArrayItem("item")]
        public ItemInfo[] ItemsArray
        {
            get { return _itemsArray; }
            set
            {
                _itemsArray = value;
                if (_itemsArray != null)
                {
                    foreach (var item in _itemsArray)
                        item.Parent = this;
                }
            }
        }
        [XmlAttribute("name")]
        public string Name { get; set; } 

        [XmlAttribute("status")]
        public string Status { get; set; }
        [XmlAttribute("defaultSampleName")]
        public string DefaultSampleName { get; set; }

        [XmlAttribute("isReferenced")]
        public Boolean IsReferenced { get; set; }

        [XmlAttribute("icon")]
        public string Icon { get; set; }

        [XmlAttribute("type")]
        public string TypeName { get; set; }

        [XmlAttribute("short")]
        public string ShortDescription { get; set; }
        [XmlAttribute("description")]
        public string LongDescription { get; set; }
        [XmlAttribute("assembly")]
        public string AssemblyName { get; set; }
         
        #endregion

        #region Protected Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
