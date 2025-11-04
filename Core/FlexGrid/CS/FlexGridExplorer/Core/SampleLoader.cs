namespace FlexGridExplorer.Core
{
    /// <summary>
    /// Provides functionality to load and retrieve all available sample items
    /// </summary>
    internal class SampleLoader : ISampleLoader
    {
        public List<ItemInfo> LoadSamples()
        {
            SampleManager sampleManager = new SampleManager();
            return sampleManager.ItemCollection.Items.ToList();
        }
    }
}
