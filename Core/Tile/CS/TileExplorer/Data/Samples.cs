using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace TileExplorer.Samples
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
                    Name = "Overview", Description = "This view shows the basic Tile features.", Title = "Overview", SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                    Name = "AppsPanel", Description = "Simulates Windows 8 \"All Apps\" screen and allows to choose the color scheme.", Title = "Apps Panel", SampleType = typeof(AppsPanel)
               },
               new SampleItem()
               {
                    Name = "DataBound", Description = "Shows an example of binding C1TileControl to a data source.", Title = "Data Bound", SampleType = typeof(DataBound)
               },
               new SampleItem()
               {
                    Name = "FileExplorer", Description = "The sample allows browsing the files and folders on the local drives.", Title = "File Explorer", SampleType = typeof(FileExplorer)
               },
               new SampleItem()
               {
                    Name = "MovingSlides", Description = "The sample demonstrates slides that replace each other using various transitions.", Title = "Moving Slides", SampleType = typeof(MovingSlides)
               },
               new SampleItem()
               {
                    Name = "TileImages", Description = "The sample shows how to display images on tiles using various techniques.", Title = "Tile Images", SampleType = typeof(TileImages)
               },
               new SampleItem()
               {
                    Name = "TileLayout", Description = "The sample shows various methods of laying out the template elements.", Title = "Tile Layout", SampleType = typeof(TileLayout)
               },
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
