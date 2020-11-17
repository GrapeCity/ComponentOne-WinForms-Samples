using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;

using C1.Win.C1Ribbon;

namespace C1.Win.C1Ribbon.CAB
{
    #region RibbonUIAdapterFactory

    /// <summary>
    /// A <see cref="IUIElementAdapterFactory"/> that produces adapters for C1Ribbon/C1StatusBar UI Elements.
    /// </summary>
    public class RibbonUIAdapterFactory : IUIElementAdapterFactory
    {
        /// <summary>
        /// See <see cref="IUIElementAdapterFactory.GetAdapter"/> for more information.
        /// </summary>
        public IUIElementAdapter GetAdapter(object uiElement)
        {
            if (uiElement is RibbonItemCollectionBase)
                return new RibbonItemCollectionUIAdapter((RibbonItemCollectionBase)uiElement);
            if (uiElement is RibbonItem)
                return new RibbonItemCollectionUIAdapter((RibbonItem)uiElement);

            if (uiElement is RibbonGroupCollection)
                return new RibbonGroupCollectionUIAdapter((RibbonGroupCollection)uiElement);
            if (uiElement is RibbonGroup)
                return new RibbonGroupCollectionUIAdapter((RibbonGroup)uiElement);

            if (uiElement is RibbonTabCollection)
                return new RibbonTabCollectionUIAdapter((RibbonTabCollection)uiElement);
            if (uiElement is RibbonTab)
                return new RibbonTabCollectionUIAdapter((RibbonTab)uiElement);

            if (uiElement is RibbonTabGroupCollection)
                return new RibbonTabGroupCollectionUIAdapter((RibbonTabGroupCollection)uiElement);
            if (uiElement is RibbonContextualTabGroup)
                return new RibbonTabGroupCollectionUIAdapter((RibbonContextualTabGroup)uiElement);

            throw new ArgumentException("uiElement");
        }

        /// <summary>
        /// See <see cref="IUIElementAdapterFactory.Supports"/> for more information.
        /// </summary>
        public bool Supports(object uiElement)
        {
            return (uiElement is RibbonItemCollectionBase) || (uiElement is RibbonItem) ||
                (uiElement is RibbonGroupCollection) || (uiElement is RibbonGroup) ||
                (uiElement is RibbonTabCollection) || (uiElement is RibbonTab) ||
                (uiElement is RibbonTabGroupCollection) || (uiElement is RibbonContextualTabGroup);
        }
    }

    #endregion

    #region RibbonItemCollectionUIAdapter

    /// <summary>
    /// An adapter that wraps a <see cref="RibbonItemCollectionBase"/> for use as an <see cref="IUIElementAdapter"/>.
    /// </summary>
    public class RibbonItemCollectionUIAdapter : UIElementAdapter<RibbonItem>
    {
        RibbonItem _item;
        RibbonItemCollectionBase _collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonItemCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonItemCollectionUIAdapter(RibbonItem item)
        {
            Guard.ArgumentNotNull(item, "item");
            _item = item;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonItemCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonItemCollectionUIAdapter(RibbonItemCollectionBase collection)
        {
            Guard.ArgumentNotNull(collection, "collection");
            _collection = collection;
        }

        /// <summary>
        /// Adds a UI Element.
        /// </summary>
        protected override RibbonItem Add(RibbonItem uiElement)
        {
            if (_item == null)
                _collection.Insert(_collection.Count, uiElement);
            else
            {
                int index = -1;
                RibbonItemCollectionBase collection = _item.OwnerCollection;
                if (collection != null)
                {
                    index = collection.IndexOf(_item);
                }
                if (index < 0)
                {
                    throw new InvalidOperationException();
                }
                collection.Insert(index + 1, uiElement);
            }
            return uiElement;
        }

        /// <summary>
        /// Removes a UI Element.
        /// </summary>
        protected override void Remove(RibbonItem uiElement)
        {
            if (uiElement.OwnerCollection != null)
            {
                uiElement.OwnerCollection.Remove(uiElement);
            }
        }
    }

    #endregion

    #region RibbonGroupCollectionUIAdapter

    /// <summary>
    /// An adapter that wraps a <see cref="RibbonGroupCollection"/> for use as an <see cref="IUIElementAdapter"/>.
    /// </summary>
    public class RibbonGroupCollectionUIAdapter : UIElementAdapter<RibbonGroup>
    {
        RibbonGroup _group;
        RibbonGroupCollection _collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonGroupCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonGroupCollectionUIAdapter(RibbonGroup group)
        {
            Guard.ArgumentNotNull(group, "group");
            _group = group;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonGroupCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonGroupCollectionUIAdapter(RibbonGroupCollection collection)
        {
            Guard.ArgumentNotNull(collection, "collection");
            _collection = collection;
        }

        /// <summary>
        /// Adds a UI Element.
        /// </summary>
        protected override RibbonGroup Add(RibbonGroup uiElement)
        {
            if (_group == null)
                _collection.Insert(_collection.Count, uiElement);
            else
            {
                int index = -1;
                RibbonGroupCollection collection = _group.OwnerCollection;
                if (collection != null)
                {
                    index = collection.IndexOf(_group);
                }
                if (index < 0)
                {
                    throw new InvalidOperationException();
                }
                collection.Insert(index + 1, uiElement);
            }
            return uiElement;
        }

        /// <summary>
        /// Removes a UI Element.
        /// </summary>
        protected override void Remove(RibbonGroup uiElement)
        {
            if (uiElement.OwnerCollection != null)
            {
                uiElement.OwnerCollection.Remove(uiElement);
            }
        }
    }

    #endregion

    #region RibbonTabCollectionUIAdapter

    /// <summary>
    /// An adapter that wraps a <see cref="RibbonTabCollection"/> for use as an <see cref="IUIElementAdapter"/>.
    /// </summary>
    public class RibbonTabCollectionUIAdapter : UIElementAdapter<RibbonTab>
    {
        RibbonTab _tab;
        RibbonTabCollection _collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonTabCollectionUIAdapter(RibbonTab tab)
        {
            Guard.ArgumentNotNull(tab, "tab");
            _tab = tab;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonTabCollectionUIAdapter(RibbonTabCollection collection)
        {
            Guard.ArgumentNotNull(collection, "collection");
            _collection = collection;
        }

        /// <summary>
        /// Adds a UI Element.
        /// </summary>
        protected override RibbonTab Add(RibbonTab uiElement)
        {
            if (_tab == null)
                _collection.Insert(_collection.Count, uiElement);
            else
            {
                int index = -1;
                RibbonTabCollection collection = _tab.OwnerCollection;
                if (collection != null)
                {
                    index = collection.IndexOf(_tab);
                }
                if (index < 0)
                {
                    throw new InvalidOperationException();
                }
                collection.Insert(index + 1, uiElement);
            }
            return uiElement;
        }

        /// <summary>
        /// Removes a UI Element.
        /// </summary>
        protected override void Remove(RibbonTab uiElement)
        {
            if (uiElement.OwnerCollection != null)
            {
                uiElement.OwnerCollection.Remove(uiElement);
            }
        }
    }

    #endregion

    #region RibbonTabGroupCollectionUIAdapter

    /// <summary>
    /// An adapter that wraps a <see cref="RibbonTabGroupCollection"/> for use as an <see cref="IUIElementAdapter"/>.
    /// </summary>
    public class RibbonTabGroupCollectionUIAdapter : UIElementAdapter<RibbonContextualTabGroup>
    {
        RibbonContextualTabGroup _tabGroup;
        RibbonTabGroupCollection _collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabGroupCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonTabGroupCollectionUIAdapter(RibbonContextualTabGroup tabGroup)
        {
            Guard.ArgumentNotNull(tabGroup, "tabGroup");
            _tabGroup = tabGroup;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabGroupCollectionUIAdapter"/> class.
        /// </summary>
        public RibbonTabGroupCollectionUIAdapter(RibbonTabGroupCollection collection)
        {
            Guard.ArgumentNotNull(collection, "collection");
            _collection = collection;
        }

        /// <summary>
        /// Adds a UI Element.
        /// </summary>
        protected override RibbonContextualTabGroup Add(RibbonContextualTabGroup uiElement)
        {
            if (_tabGroup == null)
                _collection.Insert(_collection.Count, uiElement);
            else
            {
                int index = -1;
                RibbonTabGroupCollection collection = _tabGroup.OwnerCollection;
                if (collection != null)
                {
                    index = collection.IndexOf(_tabGroup);
                }
                if (index < 0)
                {
                    throw new InvalidOperationException();
                }
                collection.Insert(index + 1, uiElement);
            }
            return uiElement;
        }

        /// <summary>
        /// Removes a UI Element.
        /// </summary>
        protected override void Remove(RibbonContextualTabGroup uiElement)
        {
            if (uiElement.OwnerCollection != null)
            {
                uiElement.OwnerCollection.Remove(uiElement);
            }
        }
    }

    #endregion
}
