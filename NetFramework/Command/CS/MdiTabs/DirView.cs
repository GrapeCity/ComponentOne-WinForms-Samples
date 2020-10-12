using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace MdiTabs
{
	/// <summary>
	/// Tree view with deferred directory listing
	/// </summary>
	public class DirView : TreeView
	{
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        // filter: a list of file matching patterns
        private string[] m_filter;
        // used to identify 'placeholder' nodes 
        static object s_placeholderTag = new object();
        // used to identify directories
        static object s_directory = new object();
        // used to identify files
        static object s_file = new object();
        // used to identify text files
        static object s_document = new object();

        // event to edit file
        public class EditFileEventArgs : EventArgs
        {
            public string Path = string.Empty;
            public EditFileEventArgs(string path)
            {
                Path = path;
            }
        }
        public delegate void EditFileEventHandler(object sender, EditFileEventArgs e);
        public event EditFileEventHandler EditFile;

		public DirView()
		{
            InitializeComponent();
		}

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DirView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // DirView
            // 
            this.ImageIndex = 0;
            this.ImageList = this.imageList1;
            this.SelectedImageIndex = 0;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirView_KeyDown);
            this.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.DirView_AfterCollapse);
            this.DoubleClick += new System.EventHandler(this.DirView_DoubleClick);
            this.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirView_AfterSelect);
            this.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DirView_BeforeExpand);

        }

        /// <summary>
        /// A list of extensions (no dots) to list
        /// </summary>
        public string[] Filter
        {
            get { return m_filter; }
            set { m_filter = value; }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            Nodes.Clear();
            if (Visible)
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string drive in drives)
                    AddDirNode(Nodes, drive.Substring(0, 2));
            }
        }

        private void AddDirNode(TreeNodeCollection nodes, string dir)
        {
            // string tstr = Path.GetDirectoryName(dir);
            string tstr = Path.GetFileName(dir);
            if (tstr != null && tstr.Length > 0)
                dir = tstr;
            TreeNode tn = new TreeNode(dir);
            tn.Tag = s_directory;
            tn.ImageIndex = 0;
            tn.SelectedImageIndex = 4;
            AddPlaceholder(tn);
            nodes.Add(tn);
        }

        private void AddPlaceholder(TreeNode dirNode)
        {
            TreeNode placeholder = new TreeNode("...");
            placeholder.Tag = s_placeholderTag;
            dirNode.Nodes.Add(placeholder);
        }

        private void AddFileNode(TreeNodeCollection nodes, string file)
        {
            file = Path.GetFileName(file);
            TreeNode tn = new TreeNode(file);
            string tstr = file.ToLower();
            // files matching filter are "documents"
            bool doc = false;
            foreach (string pattern in m_filter)
            {
                string pat = pattern;
                if (pattern.StartsWith("*"))
                    pat = pat.Substring(1);
                else if (!pattern.StartsWith("."))
                    pat = "." + pat;
                if (tstr.EndsWith(pat))
                {
                    doc = true;
                    break;
                }
            }
            if (doc)
            {
                tn.Tag = s_document;
                tn.ImageIndex = 3;
                tn.SelectedImageIndex = 7;
            }
            else
            {
                tn.Tag = s_file;
                tn.ImageIndex = 2;
                tn.SelectedImageIndex = 6;
            }
            nodes.Add(tn);
        }

        private void ListDir(TreeNode parent)
        {
            try
            {
                string parentPath = parent.FullPath;
                if (!parentPath.EndsWith(PathSeparator))
                    parentPath = parentPath + PathSeparator;
                string[] dirs = Directory.GetDirectories(parentPath);
                string path = parent.FullPath;
                foreach (string dir in dirs)
                {
                    AddDirNode(parent.Nodes, Path.Combine(path, dir));
                }
                foreach (string pattern in m_filter)
                {
                    string tstr = pattern;
                    if (!pattern.StartsWith("*"))
                        tstr = "*." + pattern;
                    else if (!pattern.StartsWith("."))
                        tstr = "." + pattern;
                    string[] files = Directory.GetFiles(parentPath, pattern);
                    foreach (string file in files)
                        AddFileNode(parent.Nodes, file);
                }
            }
            catch
            {
                // ignore file system access errors.
            }
        }

        private void DirView_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            ListDir(e.Node);
            if (e.Node.Nodes.Count > 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 5;
            }
        }

        private void DirView_AfterCollapse(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 4;
        }

        private void DirView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
        }

        private void EditSelectedFile()
        {
            if (EditFile != null)
            {
                TreeNode tn = SelectedNode;
                if (tn == null || tn.Tag != s_document)
                    return;
                string path = tn.FullPath;
                EditFile(this, new EditFileEventArgs(path));
            }
        }

        private void DirView_DoubleClick(object sender, System.EventArgs e)
        {
            EditSelectedFile();
        }

        private void DirView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode tn = SelectedNode;
                if (tn != null)
                    if (tn.Tag == s_document)
                        EditSelectedFile();
                    else
                        tn.Expand();
                e.Handled = true;
            }
        }
	}
}
