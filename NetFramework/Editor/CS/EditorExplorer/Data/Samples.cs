using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace EditorExplorer.Samples
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
                   Name = "Overview", 
                   Description = "This view shows how to implement a basic text editor application using the Editor control. You can load/save HTML, HTM, RTF and DOCX files.", 
                   Title = "Overview", 
                   SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                   Name = "RibbonCustomization", 
                   Description = "This view shows customization feature of C1EditorRibbon. Use all the features available for C1Ribbon to customize C1EditorRibbon, such as showing/hiding/adding/removing items or saving/loading layout, etc.", 
                   Title = "Ribbon Customization", 
                   SampleType = typeof(RibbonCustomization)
               },
               new SampleItem()
               {
                   Name = "SyntaxHighlight",
                   Description = "This view shows how to implement a text editor with syntax highlighting using the Editor control.",
                   Title = "Syntax Highlighting",
                   SampleType = typeof(SyntaxHighlight)
               },
               new SampleItem()
               {
                   Name = "Chat",
                   Description = "This view shows how to create a simple Chat using the C1Editor control.",
                   Title = "Chat",
                   SampleType = typeof(Chat)
               },
               new SampleItem()
               {
                   Name = "Events",
                   Description = "This view shows how the C1Editor control raises drag-and-drop, mouse, and DocumentChanged events.",
                   Title = "Events",
                   SampleType = typeof(Events)
               },
               new SampleItem()
               {
                   Name = "Inserts",
                   Description = "This view demonstrates different ways to insert content into the C1Editor using the API.",
                   Title = "Inserts",
                   SampleType = typeof(Inserts)
               }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
