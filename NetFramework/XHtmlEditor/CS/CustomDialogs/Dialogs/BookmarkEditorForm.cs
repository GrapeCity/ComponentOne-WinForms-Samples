using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor.UICustomization;
using Resources = global::CustomDialogs.Properties.Resources;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing bookmark properties.
    /// </summary>
    internal partial class BookmarkEditorForm : BaseEditorForm, IBookmarkItemDialog
    {
        #region ctors

        public BookmarkEditorForm()
        {
            InitializeComponent();

            _tbName.TextChanged += new EventHandler(ButtonOKEnabledChanged);
            
            ToolStripProfessionalRenderer render = new ToolStripProfessionalRenderer();
            render.RoundedEdges = false;
            _toolStrip.Renderer = render;
            _toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(_toolStrip_ItemClicked);

            _tree.ImageList = new ImageList();
            _tree.ImageList.ColorDepth = ColorDepth.Depth32Bit;
            _tree.ImageList.Images.Add(Resources.bookmark);
            _tree.AfterSelect += new TreeViewEventHandler(_tree_AfterSelect);
            _tree.KeyDown += new KeyEventHandler(_tree_KeyDown);
            _tree.DoubleClick += new EventHandler(_tree_DoubleClick);

            _panel.Paint += new PaintEventHandler(PaintBorder);
        }

        #endregion

        #region implementation

        private XHTMLBookmarkItem Item 
        {
            get { return _item as XHTMLBookmarkItem; }
        }

        private void LoadBookmarks()
        {
            _tree.Nodes.Clear();
            foreach (Bookmark bookmark in Item.Bookmarks)
            {
                TreeNode node = _tree.Nodes.Add(bookmark.Name);
                node.Tag = bookmark;
            }
            UpdateToolbarState();
        }

        private void UpdateToolbarState()
        {
            bool enabled = _tree.SelectedNode != null;
            _btnRemove.Enabled = enabled;
            _btnGoTo.Enabled = enabled;
        }

        private void RemoveBookmark(TreeNode node)
        {
            if (node == null)
                return;

            Bookmark bookmark = node.Tag as Bookmark;
            bool isSelected = bookmark.IsSelected;
            bookmark.Remove();

            _tree.Nodes.Remove(node);
            if (isSelected)
            {
                if (_tree.Nodes.Count == 0)
                    _tbName.Text = "";
                else if (_tree.SelectedNode != null)
                    GotoBookmark(_tree.SelectedNode);
            }

            UpdateToolbarState();
            ButtonOKEnabledChanged(this, EventArgs.Empty);
        }

        private void GotoBookmark(TreeNode node)
        {
            if (node == null)
                return;

            Bookmark bookmark = node.Tag as Bookmark;
            bookmark.Select();
            _tbName.Text = bookmark.Name;
        }

        #endregion

        #region #event handlers

        private void _toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == _btnRemove)
                RemoveBookmark(_tree.SelectedNode);
            else if (e.ClickedItem == _btnGoTo)
                GotoBookmark(_tree.SelectedNode);
        }

        private void _tree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.None)
                return;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    _btnRemove.PerformClick();
                    break;
                case Keys.Enter:
                    _btnGoTo.PerformClick();
                    break;
            }
        }

        private void _tree_DoubleClick(object sender, EventArgs e)
        {
            _btnGoTo.PerformClick();
        }

        private void ButtonOKEnabledChanged(object sender, EventArgs e)
        {
            _btnOK.Enabled = _btnAplly.Visible || 
                !string.IsNullOrEmpty(_tbName.Text.Trim()) ||
                HaveDeletedBookmarks();
        }

        private void _tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateToolbarState();
        }

        protected override void ApllyClick(object sender, EventArgs e)
        {
            ApplyChanges(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && !ApplyChanges(true))
                e.Cancel = true;
            base.OnFormClosing(e);
        }

        private bool HaveDeletedBookmarks()
        {
            for (int i = Item.Bookmarks.Count - 1; i >= 0; i--)
                if (Item.Bookmarks[i].IsRemoved)
                    return true;
            return false;
        }

        private bool ApplyChanges(bool checkCurrentBookmarkOnly)
        {
            try
            {
                if (checkCurrentBookmarkOnly)
                {
                    Item.CheckCurrentBookmark();
                    return true;
                }
                Item.ApplyChanges();
                if (!String.IsNullOrEmpty(_tbName.Text))
                {
                    foreach (TreeNode node in _tree.Nodes)
                    {
                        Bookmark bookmark = node.Tag as Bookmark;
                        if (bookmark.IsSelected && String.Compare(node.Text, _tbName.Text) != 0)
                            node.Text = _tbName.Text;
                    }
                }
                Focus();
                return true;
            }
            catch (InvalidBookmarkNameException)
            {
                MessageBox.Show(this, Resources.sInvalidBookmarkName,
                    Resources.sApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch (ExistingBookmarkException)
            {
                MessageBox.Show(this, Resources.sBookmarkExists,
                    Resources.sApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region IBookmarkItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IBookmarkItemDialog.BindData(XHTMLBookmarkItem item)
        {
            _item = item;
            _tbName.DataBindings.Add("Text", Item, "Name");
            LoadBookmarks();
            ButtonOKEnabledChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IBookmarkItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }

}

