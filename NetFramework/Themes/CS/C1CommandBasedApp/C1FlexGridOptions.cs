using System;
using System.Collections.Generic;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace C1CommandBasedApp
{
    public enum FlexViewModeEnum
    {
        None,
        Normal,
        Tree,
        Subtotals,
    }

    /// <summary>
    /// Allows change view options of C1FlexGrid.
    /// </summary>
    public class C1FlexGridOptions
    {
        private C1FlexGrid _flexGrid;
        private FlexViewModeEnum _viewMode;
        private List<Subtot> _subtotalsData = null;
        private BindingSource _bindingSource;

        public C1FlexGridOptions(
            C1FlexGrid flexGrid)
        {
            _flexGrid = flexGrid;
            _bindingSource = (BindingSource)flexGrid.DataSource;
        }

        private List<Subtot> MakeSubtots()
        {
            List<Subtot> subtots = new List<Subtot>();

            Random rand = new Random();
            const int numRows = 4;
            const int maxValue = 99;
            for (int i = 0; i < numRows; ++i)
                subtots.Add(new Subtot(
                    string.Format("A{0}", rand.Next(5)),
                    string.Format("B{0}", rand.Next(5)),
                    string.Format("C{0}", rand.Next(5)),
                    string.Format("D{0}", rand.Next(5)),
                    string.Format("E{0}", rand.Next(5)),
                    string.Format("F{0}", rand.Next(5)),
                    string.Format("G{0}", rand.Next(5)),
                    rand.Next(maxValue)));

            subtots.Sort((x, y) =>
            {
                int res = x.Level0.CompareTo(y.Level0);
                if (res != 0)
                    return res;
                res = x.Level1.CompareTo(y.Level1);
                if (res != 0)
                    return res;
                res = x.Level2.CompareTo(y.Level2);
                if (res != 0)
                    return res;
                res = x.Level3.CompareTo(y.Level3);
                if (res != 0)
                    return res;
                res = x.Level4.CompareTo(y.Level4);
                if (res != 0)
                    return res;
                res = x.Level5.CompareTo(y.Level5);
                if (res != 0)
                    return res;
                res = x.Level6.CompareTo(y.Level6);
                return res;
            });

            return subtots;
        }

        private void BuildEmployeesTree()
        {
            _bindingSource.Sort = "Country,City";
            _flexGrid.DataSource = _bindingSource;
            int idxCountry = _flexGrid.Cols["Country"].Index;
            _flexGrid.Cols.Move(idxCountry, 1);
            int idxCity = _flexGrid.Cols["City"].Index;
            _flexGrid.Cols.Move(idxCity, 2);
            _flexGrid.Cols["EmployeeID"].Visible = false;

            string lastCountry = "";
            string lastCity = "";
            for (int row = _flexGrid.Rows.Fixed; row < _flexGrid.Rows.Count; ++row)
            {
                string country = _flexGrid.GetData(row, "Country") as string;
                if (country != lastCountry)
                {
                    lastCountry = country;
                    lastCity = "";
                    var node = _flexGrid.Rows.InsertNode(row++, 0);
                    node.Row[2] = string.Format("Country: {0}", country);
                }
                string city = _flexGrid.GetData(row, "City") as string;
                if (city != lastCity)
                {
                    lastCity = city;
                    var node = _flexGrid.Rows.InsertNode(row++, 1);
                    node.Row[2] = string.Format("Country: {0}, city: {1}", country, city);
                }
            }
            _flexGrid.Tree.Column = 1;
        }

        private void BindSubtots(
            List<Subtot> subtots)
        {
            if (subtots != null)
                this._flexGrid.DataSource = subtots;

            this._flexGrid.Tree.Column = 1;
            this._flexGrid.Subtotal(AggregateEnum.Sum, 0, 1, 1, 8, "Subtotal0");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 1, 1, 2, 8, "Subtotal1");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 2, 1, 3, 8, "Subtotal2");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 3, 1, 4, 8, "Subtotal3");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 4, 1, 5, 8, "Subtotal4");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 5, 1, 6, 8, "Subtotal5");
            this._flexGrid.Subtotal(AggregateEnum.Sum, 6, 1, 7, 8, "Subtotal6");

            this._flexGrid.Subtotal(AggregateEnum.Sum, -1, -1, -1, 8, "GrandTotal");
        }

        private void UpdateGrid()
        {
            switch (_viewMode)
            {
                case FlexViewModeEnum.None:
                    break;
                case FlexViewModeEnum.Normal:
                    break;
                case FlexViewModeEnum.Tree:
                    break;
                case FlexViewModeEnum.Subtotals:
                    if (_subtotalsData == null)
                    {
                        _subtotalsData = MakeSubtots();
                        BindSubtots(_subtotalsData);
                    }
                    else
                        BindSubtots(null);
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
        }

        public C1FlexGrid FlexGrid
        {
            get { return _flexGrid; }
        }

        public FlexViewModeEnum ViewMode
        {
            get { return _viewMode; }
            set
            {
                if (value == _viewMode)
                    return;

                _viewMode = value;
                _flexGrid.BeginUpdate();
                _flexGrid.DataSource = null;
                _flexGrid.Clear(ClearFlags.Content);
                switch (_viewMode)
                {
                    case FlexViewModeEnum.Normal:
                        _flexGrid.DataSource = _bindingSource;
                        break;
                    case FlexViewModeEnum.Tree:
                        BuildEmployeesTree();
                        break;
                    case FlexViewModeEnum.Subtotals:
                        if (_subtotalsData == null)
                            _subtotalsData = MakeSubtots();
                        BindSubtots(_subtotalsData);
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
                _flexGrid.AutoSizeCols();
                _flexGrid.AutoSizeRows();
                _flexGrid.EndUpdate();
            }
        }

        public int FrozenColCount
        {
            get { return _flexGrid.Cols.Frozen; }
            set { _flexGrid.Cols.Frozen = value; }
        }

        public int FrozenRowCount
        {
            get { return _flexGrid.Rows.Frozen; }
            set { _flexGrid.Rows.Frozen = value; }
        }

        public SelectionModeEnum SelectionMode
        {
            get { return _flexGrid.SelectionMode; }
            set { _flexGrid.SelectionMode = value; }
        }

        public FocusRectEnum FocusRect
        {
            get { return _flexGrid.FocusRect; }
            set { _flexGrid.FocusRect = value; }
        }

        public bool ShowCursor
        {
            get { return _flexGrid.ShowCursor; }
            set { _flexGrid.ShowCursor = value; }
        }

        #region Nested types
        private class Subtot
        {
            public Subtot(
                string level0, string level1, string level2, string level3, string level4, string level5, string level6,
                int value)
            {
                Level0 = level0;
                Level1 = level1;
                Level2 = level2;
                Level3 = level3;
                Level4 = level4;
                Level5 = level5;
                Level6 = level6;
                Value = value;
            }

            public string Level0 { get; set; }
            public string Level1 { get; set; }
            public string Level2 { get; set; }
            public string Level3 { get; set; }
            public string Level4 { get; set; }
            public string Level5 { get; set; }
            public string Level6 { get; set; }
            public int Value { get; set; }
        }
        #endregion
    }
}
