using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ControlExplorer
{
    [XmlRoot("items")]
    public class ItemsCollection
    {
        [XmlElement("item")]
        public ItemInfo[] Items { get; set; }
        [XmlElement("menus")]
        public ItemInfo[] Menus { get; set; }
    }
    public class ItemInfo
    {
        [XmlIgnore]
        #region Private Variables

        private List<ItemInfo> _items;
        private List<ItemInfo> _menus;
        private ItemInfo[] _itemsArray;
        private ItemInfo[] _menusArray;

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

        public List<ItemInfo> Menus
        {
            get
            {
                if (_menus == null && MenusArray != null)
                {
                    _menus = new List<ItemInfo>();
                    _menus.AddRange(MenusArray);
                }
                return _menus;
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
            if (MenusArray != null)
            {
                foreach (var subItem in MenusArray)
                {
                    var found = subItem.Find(name);
                    if (found != null)
                        return found;
                }
            }
            return null;
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
        [XmlAttribute("isDefault")]
        public bool IsDefault { get; set; }

        [XmlAttribute("home")]
        public Boolean Home { get; set; }

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

        [XmlArray("menus"), XmlArrayItem("item")]
        public ItemInfo[] MenusArray
        {
            get { return _menusArray; }
            set
            {
                _menusArray = value;
                if (_menusArray != null)
                {
                    foreach (var item in _menusArray)
                        item.Parent = this;
                }
            }
        }
        public ItemInfo FindByGuid(Guid guid)
        {
            if (this.Guid == guid)
                return this;

            if (Items != null)
            {
                foreach (var item in Items)
                {
                    var found = item.FindByGuid(guid);
                    if (found != null)
                        return found;
                }
            }
            return null;
        }
        #endregion

        #region Protected Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
