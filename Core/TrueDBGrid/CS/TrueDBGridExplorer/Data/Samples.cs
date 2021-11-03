using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    /// <summary>
    /// The sample description
    /// </summary>
    public class SampleItem
    {
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
            Name = name;
            Title = title;
            Description = desc;

            SampleType = sampleType ?? throw new ArgumentException("sampleType can't be null");
        }

        #endregion

        #region ** properties

        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Type SampleType { get; set; }
        public Control Sample => Activator.CreateInstance(SampleType) as Control;        

        #endregion
    }

    /// <summary>
    /// The data source of controls
    /// </summary>
    public static class SampleDataSource
    {
        private static readonly List<SampleItem> _allItems;

        static SampleDataSource()
        {
            _allItems = new List<SampleItem>()
            {
               new SampleItem()
               {
                    Name = "Overview", Description = "This view shows the basic TrueDBGrid features.", Title = "Overview", SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                    Name = "AggregateFooter", Description = "This view shows how to use an expression for the grid footer.", Title = "Aggregate Footer", SampleType = typeof(AggregateFooter)
               },
               new SampleItem()
               {
                    Name = "FilterMultiSelect", Description = "This view shows how to set up multiple selections in column filters.", Title = "Filter MultiSelect", SampleType = typeof(FilterMultiSelect)
               },
               new SampleItem()
               {
                    Name = "ToggleGroupRows", Description = "This view shows how to expand and collapse rows in a GroupBy grid in code.", Title = "Toggle group rows", SampleType = typeof(ToggleGroupRows)
               },
               new SampleItem()
               {
                    Name = "ThreeStatesCheckBox", Description = "This view shows how to create a column that supports three-state checkboxes.", Title = "Three states CheckBox", SampleType = typeof(ThreeStatesCheckBox)
               }
            };
        }

        public static IList<SampleItem> AllItems => _allItems;
    }
}
