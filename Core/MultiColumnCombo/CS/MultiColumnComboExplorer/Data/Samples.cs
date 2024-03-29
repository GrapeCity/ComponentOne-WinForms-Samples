﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
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
                    Name = "Overview", Description = "This view shows the basic C1MultiColumnCombo features.", Title = "Overview", SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                    Name = "Master Detail", Description = "This view shows how to use the C1MultiColumnCombo as a hosted control in the C1InputPanel control.", Title = "Master Detail", SampleType = typeof(MasterDetail)
               },
               new SampleItem()
               {
                    Name = "Custom view", Description = "This view shows how to implement custom view.", Title = "Custom view", SampleType = typeof(CustomView)
               },
               new SampleItem()
               {
                    Name = "Editor in C1FlexGrid", Description = "This view shows how to use the C1MultiColumnCombo as embedded editor in the C1FlexGrid control.", Title = "Editor in C1FlexGrid", SampleType = typeof(EmbeddedEditorInFlexGrid)
               },
               new SampleItem()
               {
                    Name = "Editor in C1TreeView", Description = "This view shows how to use the C1MultiColumnCombo as embedded editor in the C1TreeView control.", Title = "Editor in C1TreeView", SampleType = typeof(EmbeddedEditorInTreeView)
               },
               new SampleItem()
               {
                    Name = "Editor in DataGridView", Description = "This view shows how to use the C1MultiColumnCombo as embedded editor in the DataGridView control.", Title = "Editor in DataGridView", SampleType = typeof(EmbeddedEditorInDataGridView)
               }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
