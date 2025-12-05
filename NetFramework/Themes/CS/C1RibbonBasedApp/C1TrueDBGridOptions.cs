using System;
using System.Windows.Forms;

using C1.Win.TrueDBGrid;

namespace C1RibbonBasedApp
{
    public class C1TrueDBGridOptions
    {
        private C1TrueDBGrid _trueGrid;

        public C1TrueDBGridOptions(
            C1TrueDBGrid trueGrid)
        {
            _trueGrid = trueGrid;
        }

        public C1TrueDBGrid TrueGrid
        {
            get { return _trueGrid; }
        }

        public DataViewEnum DataView
        {
            get { return _trueGrid.DataView; }
            set
            {
                if (DataView == value)
                    return;

                _trueGrid.DataView = value;
                if (value == DataViewEnum.GroupBy)
                {
                    if (_trueGrid.GroupedColumns.IndexOf(_trueGrid.Columns["Region"]) == -1)
                        _trueGrid.GroupedColumns.Add(_trueGrid.Columns["Region"]);
                    for (int i = 0; i < _trueGrid.RowCount; i++)
                        _trueGrid.ExpandGroupRow(i);
                }
                else
                {
                    _trueGrid.GroupedColumns.Clear();
                }
            }
        }

        public bool ShowCaption
        {
            get { return !string.IsNullOrEmpty(_trueGrid.Caption); }
            set
            {
                if (ShowCaption == value)
                    return;

                if (value)
                    _trueGrid.Caption = "C1TrueDBGrid caption";
                else
                    _trueGrid.Caption = string.Empty;
            }
        }

        public bool ShowFilterBar
        {
            get { return _trueGrid.FilterBar; }
            set { _trueGrid.FilterBar = value; }
        }

        public bool ShowGroupByArea
        {
            get { return _trueGrid.GroupByAreaVisible; }
            set { _trueGrid.GroupByAreaVisible = value; }
        }
    }
}
