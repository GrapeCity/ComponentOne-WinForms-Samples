using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SampleExplorer
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



    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            _allItems.Add(new SampleItem("Overview",
                "Overview",
                "This view shows all controls included into C1.Win.Input assembly",
                typeof(InputExplorer.Samples.Overview)));

            _allItems.Add(new SampleItem("Themes",
                "Themes",
                "This view shows appearance of all C1Input controls with the applied C1Theme",
                typeof(InputExplorer.Samples.Themes)));

            _allItems.Add(new SampleItem("DataBinding",
                "DataBinding",
                "This view shows data binding with C1Input controls.",
                typeof(InputExplorer.Samples.DataBinding)));

            _allItems.Add(new SampleItem("DataCreating",
                "DataCreating",
                "This view shows how to add new data record using C1Input controls.",
                typeof(InputExplorer.Samples.DataCreating)));

            _allItems.Add(new SampleItem("FloatingPlaceholder",
                "FloatingPlaceholder",
                "This view shows how to use a floating placeholder feature.",
                typeof(InputExplorer.Samples.FloatingPlaceholder)));

            _allItems.Add(new SampleItem("C1Button",
                "Button",
                "Explore C1Button properties",
                typeof(InputExplorer.Samples.Button)));

            _allItems.Add(new SampleItem("C1CheckBox",
                "CheckBox",
                "Explore C1CheckBox properties",
                typeof(InputExplorer.Samples.CheckBox)));

            _allItems.Add(new SampleItem("C1ComboBox",
                "ComboBox",
                "Explore C1ComboBox properties",
                typeof(InputExplorer.Samples.ComboBox)));            

            _allItems.Add(new SampleItem("C1NumericEdit",
               "NumericEdit",
               "Explore C1NumericEdit properties",
               typeof(InputExplorer.Samples.NumericEdit)));

            _allItems.Add(new SampleItem("C1RadioButton",
                "RadioButton",
                "Explore C1RadioButton properties",
                typeof(InputExplorer.Samples.RadioButton)));

            _allItems.Add(new SampleItem("C1RangeSlider",
                "RangeSlider",
                "Explore C1RangeSlider properties",
                typeof(InputExplorer.Samples.RangeSlider)));

            _allItems.Add(new SampleItem("C1SplitButton",
                "SplitButton",
                "Explore C1SplitButton properties",
                typeof(InputExplorer.Samples.SplitButton)));

            _allItems.Add(new SampleItem("C1TextBox",
                "TextBox",
                "Explore C1TextBox properties",
                typeof(InputExplorer.Samples.TextBox)));

            _allItems.Add(new SampleItem("C1DropDownControl",
                "DropDownControl",
                "Explore C1DropDownControl properties",
                typeof(InputExplorer.Samples.DropDownControl)));

            _allItems.Add(new SampleItem("C1MaskedTextBox",
                "MaskedTextBox",
                "This view shows variations of mask implemented with C1MaskedTextBox",
                typeof(InputExplorer.Samples.MaskedTextBox)));

            _allItems.Add(new SampleItem("C1ColorPicker",
               "ColorPicker",
               "Explore C1ColorPicker properties",
               typeof(InputExplorer.Samples.ColorPicker)));

            _allItems.Add(new SampleItem("C1FontPicker",
               "FontPicker",
               "Explore C1FontPicker properties",
               typeof(InputExplorer.Samples.FontPicker)));

            _allItems.Add(new SampleItem("C1CalendarView",
                "CalendarView",
                "Explore C1CalendarView properties",
                typeof(InputExplorer.Samples.CalendarView)));

            _allItems.Add(new SampleItem("C1DateEdit",
                "DateEdit",
                "Explore C1DateEdit properties",
                typeof(InputExplorer.Samples.DateEdit)));

            // todo:
            // samples for individual controls with PropertyGrid
            // sample which shows all control with themes (and ability to switch)
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
