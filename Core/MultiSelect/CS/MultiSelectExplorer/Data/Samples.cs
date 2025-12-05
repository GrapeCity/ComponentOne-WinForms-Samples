using MultiSelectExplorer.Samples.Filter;
using MultiSelectExplorer.Samples.Event;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MultiSelectExplorer.Samples.Designer;
using MultiSelectExplorer.Properties;

namespace MultiSelectExplorer.Samples
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
                throw new ArgumentException(Resources.SampleTypeNull, nameof(sampleType));
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
                    Name = Resources.OverviewTxt, Description = Resources.OverviewDesc, Title = Resources.OverviewTxt, SampleType = typeof(Overview)
               },
               new SampleItem()
               {
                    Name = Resources.MailMessageFormTxt, Description = Resources.MailMessageFormDesc, Title = Resources.MailMessageFormTxt, SampleType = typeof(MailMessageForm)
               },
               new SampleItem()
               {
                    Name = Resources.FilterTxt, Description = Resources.FilterDesc, Title = Resources.FilterTxt, SampleType = typeof(FilterControl)
               },
               new SampleItem()
               {
                    Name = Resources.EventTxt, Description = Resources.EventDesc, Title = Resources.EventTxt, SampleType = typeof(EventControl)
               },
               new SampleItem()
               {
                    Name = Resources.ThemeTxt, Description = Resources.ThemeDesc, Title = Resources.ThemeTxt, SampleType = typeof(ThemeControl)
               },
               new SampleItem()
               {
                    Name = Resources.DesignerTxt, Description = Resources.DesignerDesc, Title = Resources.DesignerTxt, SampleType = typeof(DesignerControl)
               },
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
