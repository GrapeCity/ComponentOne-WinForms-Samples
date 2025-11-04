using FlexGridExplorer.Utility;

namespace FlexGridExplorer.Core
{
    /// <summary>
    /// Manages the loading and organization of all sample metadata used in the FlexGrid Explorer application.
    /// </summary>
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
            ItemCollection =  FileUtils.DeserializeXml<ItemsCollection>("Resources\\C1Samples.xml");
            AllItems = ItemCollection.Items.SelectManyRecursive(x => x.Items).ToList();
        }

    }
}
