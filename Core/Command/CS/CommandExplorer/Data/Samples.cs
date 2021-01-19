using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommandExplorer
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
            {
                throw new ArgumentException("sampleType can't be null");
            }

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
                    Name = "DockingOverview",
                    Title = "Docking Overview",
                    Description = "The C1DockingTab control implements the familiar tab control interface with enhanced appearance and behavioral settings.",
                    SampleType = typeof(Samples.DockingOverview)
                },

                new SampleItem()
                {
                    Name = "Docking",
                    Title = "Docking",
                    Description = "C1DockingTabs can float and dock to any edge of the application. Choose among four different docking styles, including Visual Studio one.",
                    SampleType = typeof(Samples.Docking)
                },

                new SampleItem()
                {
                    Name ="ToolbarsOverview",
                    Title = "Toolbars and Menus",
                    Description = "This demo shows C1Menu, C1ContextMenu and C1Toolbar which share the same set of commands.",
                    SampleType = typeof(Samples.ToolbarsOverview)
                }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}