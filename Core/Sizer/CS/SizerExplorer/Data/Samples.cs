using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SizerExplorer.Samples
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

        public override string ToString()
        {
            return Name.Trim();
        }
    }

    /// <summary>
    /// The data source of controls
    /// </summary>
    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems;

        static SampleDataSource()
        {
            // The samples description creating
            _allItems = new List<SampleItem>()
            {
                  new SampleItem()
                {
                    Description = "C1Sizer is a container control with a powerful grid layout manager that extends the basic layout capabilities provided by the .NET Framework (Dock and Anchor properties). C1Sizer gives you the ability to easily manage every contained controls behavior when the panel is resized, thus eliminating the need to set docking and anchoring properties for each control. You can also add splitters anywhere between controls.In this demo we use buttons to represent arbitrary controls on a form.",
                    Name = "Overview",
                    Title = "C1Sizer demo",
                    SampleType = typeof(Overview)
                },
                new SampleItem()
                {
                    Description = "C1Sizer has three WPF-like styling features: gradient backgrounds, border styles and rounded corners. For the gradient background you can create a custom, 4 point blend between two colors or choose a preset blend. Add some style to your apps without adding image resources.",
                    Name = "Presentation Features",
                    Title = "C1Sizer with style features",
                    SampleType = typeof(PresentationFeatures)
                },
                new SampleItem()
                {
                    Description = "In addition to C1Sizer there is C1SizerLight. With C1SizerLight you can create resolution-independent applications without having to write any code or play with design-time configuration. Just drop C1SizerLight on your form it keeps track of the forms' size and position. When the form is resized, C1SizerLight resizes all contained controls proportionally, so the form retains its appearance at any resolution.",
                    Name = "SizerLight Control",
                    Title = "C1SizerLight demo",
                    SampleType = typeof(SizerLightControl)
                },
                new SampleItem()
                {
                    Description = "The sample adds controls by creating them, adding them to the C1Sizer's Controls collection, then positioning them using the Bounds property available in the sizing grid's Row and Column objects. The sample positions the controls at specific cells by intersecting specific row and column rectangles. You can also make controls span any number of adjacent grid cells.",
                    Name = "Add Controls",
                    Title = "Add child controls to a C1Sizer using code",
                    SampleType = typeof(AddControls)
                },
                new SampleItem()
                {
                    Description = "The sample uses the OnPaint event to add images and text to the C1Sizer splitter bars. It also handles the mouse to collapse and expand splitter panes when the user clicks an icon on the left of the splitter bar.",
                    Name = "Custom Splitters",
                    Title = "Customize the appearance of the splitter bars.",
                    SampleType = typeof(CustomSplitters)
                }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
