using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using C1.Win.C1Ribbon;

using Resources = global::C1Words.Properties.Resources;
using Settings = global::C1Words.Properties.Settings;

namespace C1WordsX
{
    /// <summary>
    /// Class that handles the recently used document list.
    /// Manages the list that appears in the application's main menu,
    /// including persistence to the settings file.
    /// </summary>
    class RecentDocumentList
    {
        C1TextEditorRibbon _ribbon;
        const int TOP_INDEX = 2;
        const int MAX_ITEMS = 10;

        // Initializes a new instance of a RecentDocumentList.
        public RecentDocumentList(C1TextEditorRibbon ribbon)
        {
            // save reference to parent ribbon
            _ribbon = ribbon;

            // create header
            RibbonListItem header = C1TextEditorRibbonTab.CreateHeader("RecentDocuments");

            // add header and separator
            Items.Clear();
            Items.Add(header);
            Items.Add(new RibbonListItem(new RibbonSeparator()));

            // add documents saved in settings file
            RecentDocuments = Settings.Default.RecentDocuments;
        }

        // gets the items that show the recent documents.
        public RibbonItemCollection Items
        {
            get { return _ribbon.ApplicationMenu.RightPaneItems; }
        }

        // add a document to the MRU list
        public void AddDocument(string fileName)
        {
            // look for the file in the current list
            RecentDocumentItem doc = FindDocumentByName(fileName);
            if (doc != null)
            {
                // already a member of the list: move to top
                if (Items.IndexOf(doc) > TOP_INDEX)
                {
                    Items.Remove(doc);
                    Items.Insert(TOP_INDEX, doc);
                }
            }
            else if (!string.IsNullOrEmpty(fileName))
            {
                // not a member, add at the top
                Items.Insert(TOP_INDEX, new RecentDocumentItem(fileName, false));
            }

            // trim list
            while (Items.Count > MAX_ITEMS)
            {
                if (!RemoveBottomItem())
                    break;
            }
        }

        // remove a document from the MRU
        public void RemoveDocument(string fileName)
        {
            // look for the file in the current list
            RecentDocumentItem doc = FindDocumentByName(fileName);
            if (doc != null)
            {
                Items.Remove(doc);
            }
        }

        // find a document on the list by its name.
        RecentDocumentItem FindDocumentByName(string fileName)
        {
            foreach (RibbonItem item in Items)
            {
                RecentDocumentItem doc = item as RecentDocumentItem;
                if (doc != null && string.Equals(doc.FileName, fileName, StringComparison.OrdinalIgnoreCase))
                {
                    return doc;
                }
            }
            return null;
        }

        // remove unpinned items from the bottom of the list
        bool RemoveBottomItem()
        {
            for (int i = Items.Count - 1; i >= TOP_INDEX; i--)
            {
                RecentDocumentItem doc = Items[i] as RecentDocumentItem;
                if (doc != null && !doc.Pinned)
                {
                    Items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // get or set the list of recent documents.
        public StringCollection RecentDocuments
        {
            get
            {
                StringCollection list = new StringCollection();
                foreach (object item in Items)
                {
                    RecentDocumentItem doc = item as RecentDocumentItem;
                    if (doc != null && !string.IsNullOrEmpty(doc.FileName))
                    {
                        string fileName = doc.FileName;
                        if (doc.Pinned)
                        {
                            // append a '*' to indicate the document is pinned
                            fileName += "*";
                        }
                        list.Add(fileName);
                    }
                }
                return list;
            }
            set
            {
                // remove old items (keep title and separator)
                while (Items.Count > TOP_INDEX)
                {
                    Items.RemoveAt(TOP_INDEX);
                }

                // add new items
                if (value != null)
                {
                    foreach (string entry in value)
                    {
                        string fileName = entry;
                        bool pinned = false;
                        if (entry.EndsWith("*"))
                        {
                            fileName = fileName.TrimEnd('*');
                            pinned = true;
                        }
                        if (File.Exists(fileName))
                        {
                            Items.Add(new RecentDocumentItem(fileName, pinned));
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// Represents each item in the most recently used documents list.
    /// </summary>
    class RecentDocumentItem : RibbonListItem
    {
        string _fileName;
        RibbonLabel _label;
        RibbonToggleButton _pin;

        public RecentDocumentItem(string fileName, bool pinned)
        {
            // save file name
            _fileName = fileName;

            // initialize label and pin
            _label = new RibbonLabel(Path.GetFileName(fileName));
            _pin = new RibbonToggleButton();
            _pin.AllowSelection = true;
            _pin.SmallImage = Resources.Unpinned;
            _pin.PressedChanged += pin_PressedChanged;
            _pin.Pressed = pinned;

            // populate this element
            Items.Add(_label);
            Items.Add(_pin);
            ToolTip = fileName;
        }
        void pin_PressedChanged(object sender, EventArgs e)
        {
            _pin.SmallImage = _pin.Pressed
                ? Resources.Pinned
                : Resources.Unpinned;
        }
        public string FileName
        {
            get { return _fileName; }
        }
        public bool Pinned
        {
            get { return _pin.Pressed; }
        }
    }
}
