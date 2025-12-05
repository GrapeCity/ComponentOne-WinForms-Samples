using C1.Win.FlexGrid;
using Custom_Localization.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace Custom_Localization.Services
{
    public class ProjectTreeBuilder
    {
        public ObservableCollection<TreeItemModel> GetProjectStructure()
        {
            var projectDir = DirectoryManager.GetProjectRoot();
            return BuildTree(projectDir);
        }

        private static readonly HashSet<string> IgnoredFolders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "bin", "obj", ".vs", "node_modules", "packages"
        };

        private ObservableCollection<TreeItemModel> BuildTree(string path)
        {
            var items = new ObservableCollection<TreeItemModel>();

            foreach (var dir in Directory.GetDirectories(path))
            {
                var dirName = Path.GetFileName(dir);
                if (IgnoredFolders.Contains(dirName))
                    continue;

                var dirItem = new TreeItemModel
                {
                    Name = dirName,
                    FullPath = dir,
                    IsDirectory = true,
                    Children = BuildTree(dir),
                    HasResxFile = Directory.GetFiles(dir, "*.resx").Any()
                };
                items.Add(dirItem);
            }

            foreach (var file in Directory.GetFiles(path))
            {
                var fileItem = new TreeItemModel
                {
                    Name = Path.GetFileName(file),
                    FullPath = file,
                    IsDirectory = false
                };
                items.Add(fileItem);
            }

            return items;
        }
    }
}
