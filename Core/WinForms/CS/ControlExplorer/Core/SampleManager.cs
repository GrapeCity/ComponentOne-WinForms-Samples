using ControlExplorer.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace ControlExplorer.Core
{
    public class SampleManager
    {
        /// <summary>
        /// Complete sample collection. 
        /// </summary>
        public ItemsCollection ItemCollection
        { get; private set; }

        /// <summary>
        /// Collection of samples that can be displayed in the SampleHost
        /// </summary>
        public List<ItemInfo> AllItems
        { get; private set; }

        public SampleManager()
        {
            ItemCollection = Utilities.FileUtilities.DeserializeXml<ItemsCollection>("Resources\\C1Controls.xml");
            AllItems = ItemCollection.Items.SelectManyRecursive(x => x.Items).ToList();
        }

    }
}
