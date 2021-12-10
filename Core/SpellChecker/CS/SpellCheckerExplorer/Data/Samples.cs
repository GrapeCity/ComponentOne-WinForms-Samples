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
The C1SpellChecker component supports spell-checking of editors that derive from the standard WebBrower class.
The support includes underlining errors with red-wavy underlines as you type, with suggestions in context-sensitive menus, and also the dialog-based modal spell-check.",
                typeof(SpellCheckerExplorer.Samples.WebBrowserSpell.Form1)));
            _allItems.Add(new SampleItem("WebBrowserSpell",
                "CustomParser",
                @"Shows how to implement a custom spell-checking parser class.
The C1SpellChecker control uses a built-in parser to break up text into words that are then spell-checked.
The built-in parser handles plain text and also common formats such as Html and Xml.
It can be configured using the Options.Ignore property.
If you need to check text that is formatted according to special rules (a c# or VB file for example), then you can replace the built-in parser with a custom one.
The sample shows how to implement a parser that skips over C# code and checks only strings and comments in the text.
Custom parsers are classes that implement the ISpellParser interface.",
                typeof(SpellCheckerExplorer.Samples.CustomParser.Form1)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
