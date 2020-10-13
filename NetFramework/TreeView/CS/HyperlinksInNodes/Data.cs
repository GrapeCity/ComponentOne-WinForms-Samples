using System.Collections.Generic;

namespace HyperlinksInNodes
{
    public class Data
    {
        public static List<Hyperlink> GetData()
        {
            var data = new List<Hyperlink>();
            data.Add(new Hyperlink() { Title = "Overview", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewforWinFormsOverview.html" });
            data[0].Hyperlinks.Add(new Hyperlink() { Title = "Getting Started with WinForms Edition", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/GettingStartedwithWinFormsEdition.html" });
            data.Add(new Hyperlink() { Title = "Quick Start", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewQuickStart.html" });
            data[1].Hyperlinks.Add(new Hyperlink() { Title = "Step 1: Adding TreeView to the Application", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/AddingTreeViewtotheApplication.html" });
            data[1].Hyperlinks.Add(new Hyperlink() { Title = "Step 2: Creating Nodes in TreeView", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/CreatingNodesinTreeView.html" });
            data[1].Hyperlinks.Add(new Hyperlink() { Title = "Step 3: Running the Application", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/RunningtheApplication.html" });
            data.Add(new Hyperlink() { Title = "Design-Time Support", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/DesignTimeSupport.html" });
            data[2].Hyperlinks.Add(new Hyperlink() { Title = "Collection Editors", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/CollectionEditors.html" });
            data.Add(new Hyperlink() { Title = "Structure and Elements", Url = @"http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewStructureandElements.html" });
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
