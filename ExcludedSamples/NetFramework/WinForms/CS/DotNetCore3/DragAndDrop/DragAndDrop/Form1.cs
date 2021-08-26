using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1TreeView1.AllowDrop = true;
            c1TreeView2.AllowDrop = true;
            c1TreeView1.ItemDrag += C1TreeView_ItemDrag;
            c1TreeView2.ItemDrag += C1TreeView_ItemDrag;
            c1TreeView1.DragEnter += C1TreeView_DragEnter;
            c1TreeView2.DragEnter += C1TreeView_DragEnter;
            c1TreeView1.DragDrop += C1TreeView_DragDrop;
            c1TreeView2.DragDrop += C1TreeView_DragDrop;
        }

        private void C1TreeView_DragDrop(object sender, DragEventArgs e)
        {
            // get dropped data
            var distanceNodes = (C1TreeNode[])e.Data.GetData(typeof(C1TreeNode[]));
            var distanceNode = distanceNodes[0];
            var pos = (DragDropPosition)e.Data.GetData(typeof(DragDropPosition));

            var treeView = (C1TreeView)sender;

            var p = treeView.PointToClient(new Point(e.X, e.Y));
            var currentNode = treeView.GetNodeAtPoint(p);
            if (currentNode != null)
            {
                var index = currentNode.ParentCollection.IndexOf(currentNode);
                distanceNode.ParentCollection.Remove(distanceNode);
                switch (pos)
                {
                    case DragDropPosition.After:
                        currentNode.ParentCollection.Insert(index + 1, distanceNode);
                        break;
                    case DragDropPosition.Before:
                        currentNode.ParentCollection.Insert(index, distanceNode);
                        break;
                    case DragDropPosition.Inner:
                        currentNode.Nodes.Add(distanceNode);
                        break;
                }
            }
            else // if tree is empty
            {
                distanceNode.ParentCollection.Remove(distanceNode);
                treeView.Nodes.Add(distanceNode);
            }

        }

        private void C1TreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void C1TreeView_ItemDrag(object sender, C1.Win.TreeView.C1TreeViewItemDragEventArgs e)
        {            
            DoDragDrop(e.DraggedData, DragDropEffects.Move);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                c1TreeView1.Nodes.Add("Node" + i);
                c1TreeView2.Nodes.Add("Node" + i * 100);
                for (int j = 0; j < 5; j++)
                {
                    c1TreeView1.Nodes[i].Nodes.Add("Node" + (i * 10 + j));
                    c1TreeView2.Nodes[i].Nodes.Add("Node" + (i * 100 + j));
                }
            }
        }
    }
}
