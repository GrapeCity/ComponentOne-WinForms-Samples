using System;
using System.Collections.ObjectModel;

namespace Custom_Localization.Models
{
    public class TreeItemModel
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public bool IsDirectory { get; set; }
        public bool HasResxFile { get; set; } = false;
        public ObservableCollection<TreeItemModel> Children { get; set; }


        public TreeItemModel()
        {
            Children = new ObservableCollection<TreeItemModel>();
        }
        public TreeItemModel(string name, string fullPath, bool isDirectory)
        {
            Name = name;
            FullPath = fullPath;
            IsDirectory = isDirectory;
            Children = new ObservableCollection<TreeItemModel>();
        }

    }
}