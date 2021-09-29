using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace TreeViewExplorer
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
        public Type SampleType { get { return _sampleType; } }
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
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem("Overview",
               "Overview",
               "This demo uses bound C1TreeView and C1CheckList with BindingList object. You can create C1TreeView control and setup it at design time or in code. Use the RaiseApplyNodeStyles method and ApplyNodeStyles event to customize node styles of C1TreeView. Also you can customize the appearance of columns and node cells. You can use C1CheckList in interaction with C1TreeView.", 
               typeof(Samples.Overview)));
            _allItems.Add(new SampleItem("Todo List",
               "Todo List",
               "C1TreeView supports checkbox appearance in nodes.This sample shows how C1TreeView can be turned into todo list with sub-cases in any node.",
               typeof(Samples.TodoList)));
            _allItems.Add(new SampleItem("UnboundMode",
              "Unbound Mode",
              "This sample shows how to use TreeView in unbound mode. The TreeView in this sample allows to generate, view and modify data.",
              typeof(Samples.UnboundMode)));
            _allItems.Add(new SampleItem("DefaultEditors",
              "Default Editors",
              "This sample shows all default node editors available in TreeView.",
              typeof(Samples.DefaultEditors)));
            _allItems.Add(new SampleItem("CVForm",
              "CV Form",
              "The C1CheckList control can be used as a list with multiple answers in input forms.",
              typeof(Samples.CVForm)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
