using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordPad
{
    /// <summary>
    /// Class that handles the recently used document list.
    /// Manages the list that appears in the application's main menu,
    /// including persistence to the settings file.
    /// </summary>
    public class RecentDocumentList
    {
        const int MAX_ITEMS = 10;

        // Initializes a new instance of a RecentDocumentList.
        public RecentDocumentList(List<RecentDocumentItem> docs)
        {
            RecentDocuments = docs;
        }

        // add a document to the MRU list
        public void AddDocument(string fileName)
        {
            // look for the file in the current list
            RecentDocumentItem doc = RecentDocuments.FirstOrDefault(x => x.FileName == fileName);
            if (doc != null)
            {
                // update date
                doc.Date = DateTime.Now;                
            }
            else if (!string.IsNullOrEmpty(fileName))
            {
                // not a member, add
                doc = new RecentDocumentItem
                {
                    Text = Path.GetFileName(fileName),
                    SubText = Path.GetDirectoryName(fileName),
                    Date = DateTime.Now
                };
                RecentDocuments.Add(doc);
            }

            // trim list  
            while (RecentDocuments.Count > MAX_ITEMS)
            {
                // first - check not pinned docs
                var notPinned = RecentDocuments.Where(x => !x.Pinned).OrderBy(x => x.Date);
                if (notPinned.Count() > 0)
                {
                    RecentDocuments.Remove(notPinned.Last());
                }
                else
                {
                    // remove last pinned doc
                    RecentDocuments.Remove(RecentDocuments.OrderBy(x => x.Date).Last());
                }                
            }
        }

        // get or set the list of recent documents.
        public List<RecentDocumentItem> RecentDocuments
        {
            get;
            set;
        }

        public void RemoveDocument(string fileName)
        {
            var doc = RecentDocuments.FirstOrDefault(x => x.FileName == fileName);
            if (doc != null)
                RecentDocuments.Remove(doc);
        }
    }

    /// <summary>
    /// Represents each item in the most recently used documents list.
    /// </summary>
    [Serializable]
    public class RecentDocumentItem
    {
        public string Text { get; set; }
        public string SubText { get; set; }
        public DateTime Date { get; set; }
        public bool Pinned { get; set; }     

        public string FileName
        {
            get { return Path.Combine(SubText, Text); }
        }       
    }
}
