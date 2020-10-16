using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace ExpressionEditorExplorer.Samples
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
                    Description = "Expression Editor, when integrated with grid, enables using expressions on grid and perform operations such as filtering, grouping, sorting, and column calculation over its data. To integrate Expression Editor with DataGridView, you need to use DataSource property of DataGridView that takes a collection of objects to generate grid data.",
                    Name = "DataGridView",
                    Title = "Integration with DataGridView",
                    SampleType = typeof(DataGridViewIntegration)
                },
                new SampleItem()
                {
                    Description = "The Expression Editor supports integration with FlexGrid control. Expression Editor, when integrated with grid, enables using expressions on grid and perform operations such as filtering, grouping, sorting, and column calculation over its data.",
                    Name = "FlexGrid",
                    Title = "Integration with FlexGrid",
                    SampleType = typeof(FlexGridIntegration)
                }
                /* TODO: Package TreeView not support ExpressionEditor!,
                new SampleItem()
                {
                    Description = "TreeView supports integration with the Expression Editor control. When integrated with Expression Editor, expressions can be used to perform operations such as column calculation over the data in TreeView. These expressions can be used on all the node levels available in the TreeView control.",
                    Name = "TreeView",
                    Title = "Integration with TreeView",
                    SampleType = typeof(TreeViewIntegration)
                }*/
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
