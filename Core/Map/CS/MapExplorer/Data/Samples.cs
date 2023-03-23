using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MapExplorer.Samples
{
    /// <summary>
    /// The sample description
    /// </summary>
    public class SampleItem
    {
        #region ** fields

        private Type _sampleType;

        #endregion

        #region ** ctor
        public SampleItem() { }

        /// <summary>
        /// Sample item contructor
        /// </summary>
        /// <param name="name">The name of control</param>
        /// <param name="title">The title of control</param>
        /// <param name="desc">The description of control</param>
        /// <param name="sampleType">Type</param>
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            if (sampleType == null)
                throw new ArgumentException("sampleType can't be null");
            Name = name;
            Title = title;
            Description = desc;

            _sampleType = sampleType;
        }

        #endregion

        #region ** public fields
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Type SampleType { get => _sampleType; set => _sampleType = value; }
        public Control Sample
        {
            get
            {
                var control = Activator.CreateInstance(_sampleType) as Control;
                return control;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source of controls
    /// </summary>
    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems;

        static SampleDataSource()
        {
            _allItems = new List<SampleItem>()
            {
               new SampleItem()
               {
                    Name = "Overview", Description = "This view shows how to use standard VirtualEarthAerialSource, VirtualEarthRoadSource, VirtualEarthHybridSource maps and the custom title source from OpenStreetMap service.", Title = "Overview", SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                    Name = "Marks", Description = "This view shows how to add or delete custom marks and determine the scale from the list of marks. The source map is VirtualEarthAerialSource.", Title = "Create marks", SampleType = typeof(MarkControl)
               },
                new SampleItem()
               {
                    Name = "Routes", Description = "This view shows how to create route and labels. The source map is VirtualEarthHybridSource.", Title = "Create route", SampleType = typeof(RouteControl)
               },
                new SampleItem()
               {
                    Name = "Airports", Description = "This view shows how to import GeoJSON data and display it on the map. The sample loads two GeoJSON files, one to show the land and second for the airport locations.", Title = "Airports", SampleType = typeof(AirportsControl)
               }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
