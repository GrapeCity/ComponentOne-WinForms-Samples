using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SampleExplorer
{
    public class SampleItem
    {
        private Type _sampleType;
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            if (sampleType == null)
                throw new ArgumentException("sampleType can't be null");
            Name = name;
            Title = title;
            Description = desc;
            _sampleType = sampleType;
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Control Sample
        {
            get
            {
                var c = Activator.CreateInstance(_sampleType) as Control;
                return c;
            }
        }
    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            _allItems.Add(new SampleItem("QuickStart",
                "QuickStart",
                @"Shows how to use the C1SpellChecker component to check different types of control.
The sample has tabs that select the type of control to spell-check: regular TextBox, RichTextBox, or C1FlexGrid.
The textboxes have built-in support for as-you-type as well as modal spell-checking.
The C1FlexGrid shows how to implement modal spell-checking on arbitrary controls by implementing the ISpellCheckableEditor interface.",
                typeof(SpellCheckerExplorer.Samples.QuickStart.Form1)));
            _allItems.Add(new SampleItem("WebBrowserSpell",
                "WebBrowserSpell",
                @"C1SpellChecker supports controls based on the WebBrowser class.
Starting with version 2.0.20092.50, the C1SpellChecker component supports spell-checking of editors that derive from the standard WebBrower class.
The support includes underlining errors with red-wavy underlines as you type, with suggestions in context-sensitive menus, and also the dialog-based modal spell-check.",
                typeof(SpellCheckerExplorer.Samples.WebBrowserSpell.Form1)));

        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
