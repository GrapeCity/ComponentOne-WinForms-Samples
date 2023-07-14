using C1.Win.FlexGrid;
using C1.Win.Input.MultiColumnCombo;
using C1.Win.Themes;
using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    /// <summary>
    /// Represents a two-level tree view, this tree view is used as a custom dropdown view for <see cref="C1MultiColumnCombo"/> control.
    /// </summary>
	public class CustomTreeView : C1TreeView, IDropDownView
    {
        private int _defaultWidth;
        private DisplayColumnCollection _columns;
        private readonly C1MultiColumnCombo _owner;

        public CustomTreeView(C1MultiColumnCombo owner)
        {
            _owner = owner;
            SelectionMode = C1TreeViewSelectionMode.Single;
            IsFocusSynchronizedWithSelection = true;
            MoveDownByEnter = false;
        }

        #region IDropDownView

        public bool RowTracking { get; set; }

        public int SelectedIndex
        {
            get => HasSelection ? GetIndexByNode(SelectedNodes.First()) : -1;
            set
            {
                C1TreeNode node = GetNodeByIndex(value);
                if (node is not null)
                    node.Selected = true;
            }
        }

        public bool HasSelection => SelectedNodes.Length > 0;

        public int ItemsCount => Nodes.Sum(n => n.Nodes.Count);

        public int DefaultColumnWidth
        {
            get => _defaultWidth;
            set
            {
                if (_defaultWidth != value)
                {
                    _defaultWidth = value;
                    UpdateColumnWidth(value);
                }
            }
        }

        public string AddItemSeparator { get; set; } = ",";

        DisplayColumnCollection IDropDownView.Columns
        {
            get => _columns;
            set
            {
                if (_columns != value)
                {
                    if (_columns is not null)
                    {
                        _columns.CollectionChanged -= Columns_CollectionChanged;
                        _columns.ColumnChanged -= Columns_ColumnChanged;
                    }
                    _columns = value;
                    InitilizeTreeColumns();
                    if (_columns is not null)
                    {
                        _columns.CollectionChanged += Columns_CollectionChanged;
                        _columns.ColumnChanged += Columns_ColumnChanged;
                    }
                }
            }
        }

        private IList<GroupDescription> _groupDescriptions;
        public IList<GroupDescription> GroupDescriptions
        {
            get => _groupDescriptions;
            set
            {
                _groupDescriptions = value;
                if (_groupDescriptions.Count == 2)
                {
                    BindingInfo.KeyField = _groupDescriptions[0].PropertyName;
                    BindingInfo.ParentKeyField = _groupDescriptions[1].PropertyName;
                }
            }
        }

        public new event EventHandler SelectionChanged;
        protected override void OnMultipleSelectionChanged(EventArgs e)
        {
            base.OnMultipleSelectionChanged(e);
            if (SelectedNodes.Length > 0)
            {
                SelectionChanged?.Invoke(this, e);
            }
        }

        public void ApplyStyle(BaseStyle currentTheme)
        {
            MultiColumnComboStyles styles = (MultiColumnComboStyles)currentTheme;
            Styles.Font = styles.Font;
            BackColor = styles.DropDownView.Normal.BackColor;
            ApplyStyle(Styles.Default, styles.DropDownView.Normal);
            ApplyStyle(Styles.Hot, styles.DropDownView.Normal);
            ApplyStyle(Styles.HotSelected, styles.DropDownView.Highlight);
            ApplyStyle(Styles.Selected, styles.DropDownView.Highlight);
            ApplyStyle(Styles.UnfocusedSelected, styles.DropDownView.Highlight);
            ApplyStyle(Styles.ColumnHeader, styles.DropDownView.Fixed);
            ApplyStyle(Styles.Disabled, styles.DropDownView.Normal);
        }

        public int FindString(string value, int startIndex = 0, int columnIndex = -1, bool caseSensitive = false, bool fullMatch = false, bool wrap = false)
        {
            Func<C1TreeNode, int, object, bool, bool, bool> checkNode = (node, columnIndex, value, caseSensitive, fullMatch) =>
            {
                string text = value?.ToString() ?? "";
                string nodeText = node.GetValue(columnIndex)?.ToString() ?? "";
                if (fullMatch && nodeText.Length != text.Length)
                    return false;
                if (string.Compare(text, 0, nodeText, 0, text.Length, !caseSensitive, CultureInfo.CurrentCulture) == 0)
                    return true;
                return false;
            };
            return FindNode(checkNode, value, startIndex, columnIndex, caseSensitive, fullMatch, wrap);

        }

        public Control GetControl() => this;

        public int GetHeight(int itemsCount) => 200;

        public object GetValue(int rowIndex, int columnIndex)
        {
            if (columnIndex == -1)
                return null;
            return GetNodeByIndex(rowIndex)?.GetValue(columnIndex);
        }

        public int GetWidth() => 400;

        public void ScrollToCell(int columnIndex, int rowIndex) => ScrollToCell(columnIndex, rowIndex);

        public void Select(object value, string columnName)
        {
            Func<C1TreeNode, int, object, bool, bool, bool> checkNode = (node, columnIndex, value, caseSensitive, fullMatch) =>
            {
                object nodeValue = node.GetValue(columnIndex);
                if (nodeValue == value)
                    return true;
                return false;
            };
            var column = Columns.FirstOrDefault(c => c.DisplayFieldName == columnName);
            int columnIndex = Columns.IndexOf(column);
            int nodeIndex = FindNode(checkNode, value, 0, columnIndex, true, true, false);
            if (nodeIndex > 0)
                GetNodeByIndex(nodeIndex).Selected = true;
        }        

        public int GetColumnIndex(string columnName)
        {
            var column = Columns.FirstOrDefault(c => c.Name == columnName);
            if (column != null)
                return Columns.IndexOf(column);
            else
                return -1;
        }

        private void Columns_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Columns.Add(new C1TreeColumn
                    {
                        HeaderText = _columns[e.NewStartingIndex].Caption,
                        Name = _columns[e.NewStartingIndex].Name,
                        DisplayFieldName = _columns[e.NewStartingIndex].Name,
                        Visible = _columns[e.NewStartingIndex].Visible,
                        Width = _columns[e.NewStartingIndex].Width,
                    });                    
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Columns.RemoveAt(e.OldStartingIndex);
                    break;
                case NotifyCollectionChangedAction.Replace:                    
                    break;
                case NotifyCollectionChangedAction.Reset:
                    InitilizeTreeColumns();
                    break;
            }
        }
        private void Columns_ColumnChanged(object sender, ColumnChangedEventArgs e)
        {
            var i = _columns.IndexOf(e.Column);
            switch (e.PropertyName)
            {
                case "Caption":
                    Columns[i].HeaderText = _columns[i].Caption;
                    break;
                case "Name":
                    Columns[i].Name = _columns[i].Name;
                    Columns[i].DisplayFieldName = _columns[i].Name;
                    break;
                case "Visible":
                    Columns[i].Visible = _columns[i].Visible;
                    break;
                case "Width":
                    Columns[i].Width = _columns[i].Width;
                    break;
            }
        }

        #region not implemented

        public int HeaderHeight { get; set; }
        public int ItemHeight { get; set; }
        public bool AllowSorting { get; set; }

        public event EventHandler Sorted;

        public void AddColumnHeaders(string headers) { }
        public void AddItem(string newItem) { }
        public void ApplySearch(string text, bool highlight, bool filter) { }
        public void ClearItems() { }
        public void InsertItem(string newItem, int rowIndex) { }
        public void RemoveItem(int rowIndex) { }
        public void SetItemData(int rowIndex, int columnIndex, string data) { }

        public void Sort(int columnIndex, SortDirection direction) { }
        public void Sort(string columnName, SortDirection direction) { }

        #endregion

        #endregion

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            var node = GetNodeAtPoint(e.Location);            
            if (node is not null)
            {
                _owner.DroppedDown = false;
            }
        }

        protected override void OnDataBindingComplete(EventArgs e)
        {
            base.OnDataBindingComplete(e);
            ExpandAll();
        }

        #region private staff

        private int GetIndexByNode(C1TreeNode node)
        {
            int index = node.ParentCollection.IndexOf(node);
            C1TreeNode parent = node.ParentCollection.Parent ?? node;
            int parentIndex = parent.ParentCollection.IndexOf(parent);
            int actualIndex = 0;
            for (int i = 0; i < parentIndex; i++)
            {
                actualIndex++;
                actualIndex += Nodes[i].Nodes.Count;
            }
            if (parent != node)
            {
                actualIndex++;
                actualIndex += index;
            }
            return actualIndex;
        }

        private C1TreeNode GetNodeByIndex(int index)
        {
            if (index < 0)
                return null;
            int currentIndex = 0;
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (currentIndex == index)
                    return Nodes[i];
                currentIndex++;
                if (Nodes[i].Nodes.Count + currentIndex <= index)
                    currentIndex += Nodes[i].Nodes.Count;
                else
                    return Nodes[i].Nodes[index - currentIndex];
            }
            return null;
        }

        private void UpdateColumnWidth(int value)
        {
            foreach (var column in Columns)
            {
                if (value == -1)
                    column.AutoWidth = true;
                else
                {
                    column.AutoWidth = false;
                    column.Width = value;
                }
            }
        }

        private void InitilizeTreeColumns()
        {
            for (int i = 0; i < _columns.Count; i++)
            {
                if (Columns.Count <= i)
                    Columns.Add(new C1TreeColumn());
                var column = Columns[i];
                column.HeaderText = _columns[i].Caption;
                column.Name = _columns[i].Name;
                column.Visible = _columns[i].Visible;
                column.Width = _columns[i].Width;
                column.DisplayFieldName = _columns[i].Name;                
            }
            while (Columns.Count > _columns.Count)
                Columns.Remove(Columns.Last());
        }

        private int FindNode(Func<C1TreeNode, int, object, bool, bool, bool> checkFunc, object value, int startIndex = 0, int columnIndex = -1,
            bool caseSensitive = false, bool fullMatch = false, bool wrap = false)
        {
            C1TreeNode node = GetNodeByIndex(startIndex);
            if (node is null)
                return -1;

            int childIndex = node.ParentCollection.IndexOf(node);
            C1TreeNode parent = node.ParentCollection.Parent ?? node;
            int parentIndex = parent.ParentCollection.IndexOf(parent);
            int maxParentCount = Nodes.Count;
            int initialParentIndex = parentIndex;
            for (; parentIndex < maxParentCount; parentIndex++)
            {
                parent = Nodes[parentIndex];
                if (columnIndex > -1)
                {
                    if (checkFunc(parent, columnIndex, value, caseSensitive, fullMatch))
                        return parentIndex;
                }
                else
                {
                    for (int cIndex = 0; cIndex < Columns.Count; cIndex++)
                    {
                        if (checkFunc(parent, cIndex, value, caseSensitive, fullMatch))
                            return parentIndex;
                    }
                }

                for (; childIndex < parent.Nodes.Count; childIndex++)
                {
                    node = parent.Nodes[childIndex];
                    if (columnIndex > -1)
                    {
                        if (checkFunc(node, columnIndex, value, caseSensitive, fullMatch))
                            return childIndex;
                    }
                    else
                    {
                        for (int cIndex = 0; cIndex < Columns.Count; cIndex++)
                        {
                            if (checkFunc(node, cIndex, value, caseSensitive, fullMatch))
                                return childIndex;
                        }
                    }
                }
                childIndex = 0;
                if (maxParentCount == parentIndex - 1 && wrap)
                {
                    wrap = false;
                    parentIndex = 0;
                    maxParentCount = initialParentIndex;
                }
            }
            return -1;
        }

        private void ApplyStyle(NodeCellStyle destination, ViewCellStyle source)
        {
            destination.BackColor = source.BackColor;
            destination.ForeColor = source.ForeColor;
        }

        #endregion
    }

}