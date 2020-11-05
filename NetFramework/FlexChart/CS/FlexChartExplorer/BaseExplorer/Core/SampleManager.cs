using BaseExplorer.Model;
using BaseExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseExplorer.Core
{
    public class SampleManager
    {
        /// <summary>
        /// Complete sample collection. 
        /// </summary>
        public SamplesCollection SampleCollection
        { get; private set; }

        /// <summary>
        /// Collection of samples that can be displayed in the SampleHost
        /// </summary>
        public List<SampleItem> AllSamples
        { get; private set; }

        /// <summary>
        /// Current sample that has been loaded in the SampleHost
        /// </summary>
        public SampleItem Current { get; set; }

        /// <summary>
        /// Sample next to the Current sample that the user can navigate to
        /// </summary>
        public SampleItem Next
        {
            get { return AllSamples.GetNext(Current); }
        }

        /// <summary>
        /// Sample previous to the Current sample that the user can navigate to
        /// </summary>
        public SampleItem Previous
        {
            get { return AllSamples.GetPrevious(Current); }
        }

        public SampleManager(string filePath)
        {
            SampleCollection = Utilities.FileUtilities.DeserializeXml<SamplesCollection>(filePath);
            AllSamples = SampleCollection.Samples.SelectManyRecursive(x => x.Items).ToList();
        }

    }
}
