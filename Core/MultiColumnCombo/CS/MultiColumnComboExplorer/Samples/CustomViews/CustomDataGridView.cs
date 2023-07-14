using C1.Win.FlexGrid;
using C1.Win.Input.MultiColumnCombo;
using C1.Win.Themes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public class CustomDataGridView : DataGridView, IDropDownView
    {
        private DisplayColumnCollection _columns;
        private readonly C1MultiColumnCombo _owner;

        public CustomDataGridView(C1MultiColumnCombo owner)
        {
            _owner = owner;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
        }

        #region IDropDownView

        public bool RowTracking { get; set; }

        public int SelectedIndex
        {
            get => SelectedRows.Count > 0 ? SelectedRows[0].Index : -1;
            set
            {
                if (value < 0)
                    ClearSelection();
                else
                    SetSelectedRowCore(value, true);
            }
        }

        public bool HasSelection => SelectedRows.Count > 0;

        public int ItemsCount => Rows.Count;

        public bool ShowColumnHeaders
        {
            get => ColumnHeadersVisible;
            set => ColumnHeadersVisible = value;
        }
        public int HeaderHeight
        {
            get => ColumnHeadersHeight;
            set => ColumnHeadersHeight = value;
        }

        public bool AllowSorting
        {
            get => AllowUserToOrderColumns;
            set => AllowUserToOrderColumns = value;
        }

        DisplayColumnCollection IDropDownView.Columns
        {
            get => _columns;
            set
            {
                if (_columns != value)
                {
                    _columns = value;
                    InitilizeGridColumns();
                }
            }
        }
        private void InitilizeGridColumns()
        {
            Columns.Clear();
            for (int i = 0; i < _columns.Count; i++)
            {
                if (Columns.Count <= i)
                    Columns.Add(new DataGridViewTextBoxColumn());
                var column = Columns[i];
                column.HeaderText = _columns[i].Caption;
                column.Name = _columns[i].Name;
                column.DataPropertyName = _columns[i].Name;
                column.Visible = _columns[i].Visible;
                column.Width = _columns[i].Width;
            }            
        }

        public new event EventHandler DataBindingComplete;
        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            DataBindingComplete?.Invoke(this, e);
        }

        public void ApplyStyle(BaseStyle currentTheme) 
        {
            MultiColumnComboStyles styles = (MultiColumnComboStyles)currentTheme;
            Font = styles.Font;
            BackColor = styles.DropDownView.Normal.BackColor;
            DefaultCellStyle.BackColor = styles.DropDownView.Normal.BackColor;
            DefaultCellStyle.ForeColor = styles.DropDownView.Normal.ForeColor;
            
        }
        public int FindString(string value, int startIndex = 0, int columnIndex = -1, bool caseSensitive = false, bool fullMatch = false, bool wrap = false)
        {
            Func<object, object, bool, bool, bool> checkCell = (cellValue, value, caseSensitive, fullMatch) =>
            {
                string text = value?.ToString();
                string cellText = cellValue?.ToString() ?? "";
                if (fullMatch && cellText.Length != text.Length)
                    return false;
                if (string.Compare(text, 0, cellText, 0, text.Length, !caseSensitive, CultureInfo.CurrentCulture) == 0)
                    return true;
                return false;
            };
            return FindRow(value, startIndex, columnIndex, caseSensitive, fullMatch, wrap, checkCell);
        }

        private int FindRow(object value, int startIndex, int columnIndex, bool caseSensitive, bool fullMatch, bool wrap, Func<object, object, bool, bool, bool> checkCell)
        {            
            for (int i = startIndex; i < Rows.Count; i++)
            {
                if (columnIndex != -1)
                {
                    if (checkCell(Rows[i].Cells[columnIndex].Value, value, caseSensitive, fullMatch))
                        return i;
                }
                else
                {
                    for (int cIndex = 0; cIndex < ColumnCount; cIndex++)
                        if (checkCell(Rows[i].Cells[columnIndex].Value, value, caseSensitive, fullMatch))
                            return i;
                }
            }
            if (wrap)
            {
                for (int i = 0; i < startIndex; i++)
                {
                    if (columnIndex != -1)
                    {
                        if (checkCell(Rows[i].Cells[columnIndex].Value, value, caseSensitive, fullMatch))
                            return i;
                    }
                    else
                    {
                        for (int cIndex = 0; cIndex < ColumnCount; cIndex++)
                            if (checkCell(Rows[i].Cells[columnIndex].Value, value, caseSensitive, fullMatch))
                                return i;
                    }
                }
            }
            return -1;
        }

        public int GetColumnIndex(string columnName)
        {
            for (int i = 0; i < Columns.Count; i++)
            {
                if (Columns[i].DataPropertyName == columnName)
                    return i;
            }
            return -1;
        }
        public Control GetControl() => this;
        public int GetHeight(int itemsCount) => HeaderHeight + Rows.Cast<DataGridViewRow>().Take(Math.Min(itemsCount, Rows.Count)).Sum(r => r.Height);
        public object GetValue(int rowIndex, int columnIndex) => Rows[rowIndex].Cells[columnIndex].Value;
        public int GetWidth() => 400;
        public void Select(object value, string columnName)
        {
            int index = GetColumnIndex(columnName);
            Func<object, object, bool, bool, bool> checkCell = (cellValue, value, caseSensitive, fullMatch) =>
            {                
                if (cellValue == DBNull.Value && value == DBNull.Value ||
                    cellValue is not null && cellValue.Equals(value) ||
                    cellValue is null && value is null)
                    return true;
                return false;
            };
            int rowIndex = FindRow(value, 0, index, false, false, true, checkCell);
            if (rowIndex < 0)
                ClearSelection();
            else
                SetSelectedRowCore(rowIndex, true);
        }
        public void Sort(int columnIndex, SortDirection direction)
        {
            switch (direction)
            {
                case SortDirection.Ascending:
                    base.Sort(Columns[columnIndex], System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case SortDirection.Descending:
                    base.Sort(Columns[columnIndex], System.ComponentModel.ListSortDirection.Descending);
                    break;
            }
        }
        public void Sort(string columnName, SortDirection direction) => Sort(Columns.IndexOf(Columns[columnName]), direction);

        #region not implemented

        public string AddItemSeparator { get; set; }
        public int DefaultColumnWidth { get; set; }
        public bool ExtendLastColumn { get; set; }
        public int ItemHeight { get; set; }
        public IList<GroupDescription> GroupDescriptions { get; set; }

        public void AddColumnHeaders(string headers) { }
        public void AddItem(string newItem) { }
        public void ApplySearch(string text, bool highlight, bool filter) { }
        public void ClearItems() { }
        public void InsertItem(string newItem, int rowIndex) { }
        public void RemoveItem(int rowIndex) { }        
        public void SetItemData(int rowIndex, int columnIndex, string data) { }
        public void ScrollToCell(int columnIndex, int rowIndex) { }

        #endregion

        #endregion

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            var info = HitTest(e.X, e.Y);
            if (info.Type == DataGridViewHitTestType.Cell || info.Type == DataGridViewHitTestType.RowHeader)
            {
                _owner.DroppedDown = false;
            }
        }
    }
}
