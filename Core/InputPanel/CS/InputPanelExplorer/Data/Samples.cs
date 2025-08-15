using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InputPanelExplorer
{
    public class SampleItem
    {
        private Type _sampleType;

        public SampleItem() { }
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

    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            var xmlPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Sample.xml");
            var doc = XDocument.Load(xmlPath);

            var items = doc.Descendants("SampleItem").Select(x =>
            {
                string typeName = $"InputPanelExplorer.{x.Element("SampleType")?.Value}";
                Type resolvedType = Type.GetType(typeName);

                return new SampleItem
                {
                    Name = x.Element("Name")?.Value,
                    Title = x.Element("Title")?.Value,
                    Description = x.Element("Description")?.Value,
                    SampleType = resolvedType
                };
            });

            _allItems.AddRange(items);
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
