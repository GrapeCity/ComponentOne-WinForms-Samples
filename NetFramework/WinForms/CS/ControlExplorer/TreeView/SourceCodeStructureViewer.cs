using C1.C1Zip;
using C1.Win.TreeView;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TreeView
{
    public partial class SourceCodeStructureViewer : C1DemoForm
    {
        public SourceCodeStructureViewer()
        {
            InitializeComponent();
            Load += SourceCodeStructureViewer_Load;
        }

        private void SourceCodeStructureViewer_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(ControlExplorer.Properties.Resources.ClosedFolder);
            imageList1.Images.Add(ControlExplorer.Properties.Resources.OpenedFolder);
            imageList1.Images.Add(ControlExplorer.Properties.Resources.file);
            
            c1TreeView1.BeginUpdate();
            LoadProjectStructure();
            c1TreeView1.EndUpdate();

            c1TreeView1.Expanded += C1TreeView1_Expanded;
            c1TreeView1.Collapsed += C1TreeView1_Collapsed;
        }

        private void C1TreeView1_Expanded(object sender, C1TreeViewEventArgs e)
        {
            e.Node.Images.RemoveAt(0);
            e.Node.Images.Add(1);
        }

        private void C1TreeView1_Collapsed(object sender, C1TreeViewEventArgs e)
        {
            e.Node.Images.RemoveAt(0);
            e.Node.Images.Add(0);
        }

        void LoadProjectStructure()
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            Stream s = asm.GetManifestResourceStream("ControlExplorer.SourceCode.zip");

            C1ZipFile z = new C1ZipFile();
            z.Open(s);

            C1TreeNodeCollection targetNodeCollection = null;
            int previousLevel = -1;

            for (int i = 0; i < z.Entries.Count; i++)
            {
                string[] partsOfPath = z.Entries[i].FileName.Split('/');

                int level = partsOfPath.Length - 2;
                int imageIndex = 0;

                if (!string.IsNullOrEmpty(partsOfPath[partsOfPath.Length - 1]))
                {
                    level = partsOfPath.Length - 1;
                    imageIndex = 2;
                }

                string nodeName = partsOfPath[level];

                if (targetNodeCollection == null)
                    targetNodeCollection = c1TreeView1.Nodes;
                else
                {
                    if (previousLevel > level)
                    {
                        targetNodeCollection = targetNodeCollection.Parent.ParentCollection;
                    }
                    else if (previousLevel < level)
                    {
                        targetNodeCollection = targetNodeCollection.Last().Nodes;
                    }
                }

                C1TreeNode node = targetNodeCollection.Add(nodeName);
                node.Images.Add(imageIndex);
                previousLevel = level;
            }

            z.Close();
        }
    }
}
