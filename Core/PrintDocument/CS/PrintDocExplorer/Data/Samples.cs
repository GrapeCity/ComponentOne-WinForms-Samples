using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace PrintDocExplorer
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
            _allItems.Add(new SampleItem("Acroform",
               "Acroform",
               "The C1PrintDocument component can be used to create rich documents containing tables, hyperlinks, input controls, images and more. You can easily add content to C1PrintDocument with its block, inline and direct rendering methods, and then print or export to PDF, Word, Excel and more. This demo features interactive objects in the document (Acroforms). Use 'Save File' button to save generated form into PDF.", 
               typeof(Samples.Acroform)));
            _allItems.Add(new SampleItem("File Viewer",
              "File Viewer",
              "C1 PrintPreview controls can display both C1PrintDocument and Microsoft's PrintDocument content. This demo shows how to create simple file viewer for txt files using C1PrintPreviewControl and System.Drawing.Printing.PrintDocument or C1PrintDocument components. Try to open the same file with PrintDocument and C1PrintDocument to see how easy it is to get paging and word wrapping if C1PrintDocument does it for you.",
              typeof(Samples.MSPrintDocument)));
            _allItems.Add(new SampleItem("Ribbon Preview",
               "Ribbon Preview",
               "The sample creates a C1PrintDocument, in which most of the RenderObject types are included: RenderArea, RenderText, RenderGraphics, RenderEmpty, RenderImage, RenderRichText, RenderPolygon, RenderTable, RenderParagraph.\r\nNew RibbonPreview control allows you to get more screen place by using Ribbon Simplified view or by minimizing Ribbon.New icon set is customized both for light and dark themes.",
              typeof(Samples.RibbonPreview)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
