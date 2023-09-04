using System.Collections.Generic;

namespace HyperlinksInNodes
{
    public class Data
    {
        public static List<Hyperlink> GetData()
        {
            var data = new List<Hyperlink>();
            data.Add(new Hyperlink() { Title = "Overview", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/overview.html" });
            data.Add(new Hyperlink() { Title = "Key Features", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/KeyFeatures.html" });
            data.Add(new Hyperlink() { Title = "Quick Start", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/TreeViewQuickStart.html" });
            data.Add(new Hyperlink() { Title = "Data Binding", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/DataBinding.html" });
            data[3].Hyperlinks.Add(new Hyperlink() { Title = "Binding List", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/bind-treeview-with-binding-list.html" });
            data[3].Hyperlinks.Add(new Hyperlink() { Title = "Self-Referencing", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/self-referencing.html" });
            data[3].Hyperlinks.Add(new Hyperlink() { Title = "DataSet Binding", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/binding-dataset.html" });
            data[3].Hyperlinks.Add(new Hyperlink() { Title = "XML Binding", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/xml-binding.html" });
            data.Add(new Hyperlink() { Title = "Node Operations", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/Nodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Add Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/add-nodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Remove Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/remove-nodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Drag and Drop Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/DraggingandDroppingNodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Reorder Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/ReorderingNodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Edit Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/EditingNodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Select Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/SelectingNodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Search Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/searchingnodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Expand and Collapse Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/ExpandingandCollapsingNodes.html" });
            data[4].Hyperlinks.Add(new Hyperlink() { Title = "Navigate Nodes", Url = @"https://developer.mescius.com/componentone/docs/win/online-treeview/NavigatingNodes.html" });

            return data;
        }
    }

    public class Hyperlink
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public List<Hyperlink> Hyperlinks { get; set; }

        public Hyperlink()
        {
            Hyperlinks = new List<Hyperlink>();
        }
    }
}
