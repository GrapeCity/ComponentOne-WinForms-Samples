// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using C1.Win.TreeView;
using MultiSelectExplorer.Properties;

namespace MultiSelectExplorer.Samples.Filter
{
    public partial class FilterControl : UserControl
    {
        private DataTable _dataTable;
        private GridColumnFilterService _filterService;
        private const string TargetColumn = "ContactTitle";

        public FilterControl()
        {
            InitializeComponent();
            InitializeLocalizedText();
            LoadData();
            InitializeGrid();
            InitializeMultiSelect();
        }
        private void InitializeLocalizedText()
        {
            lblColumnFilterName.Text = Resources.ColumnFilterName;
            _multiSelect.Placeholder = Resources.SelectContactTitle;
            btnClear.Text = Resources.ClearSelection;
        }

        private void LoadData()
        {
            _dataTable = Data.DataSource.GetRows("SELECT * FROM Customers");
        }

        private void InitializeGrid()
        {
            _flexGrid.DataSource = _dataTable;
            _flexGrid.Cols["ContactTitle"].Caption = "Contact Title";
            _flexGrid.AutoSizeCols();
            _flexGrid.AllowFiltering = true;
        }

        private void InitializeMultiSelect()
        {
            _filterService = new GridColumnFilterService(_dataTable, TargetColumn);

            var filterValues = _filterService.GetDistinctValues();
            _multiSelect.Items.AddRange(filterValues);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _multiSelect.UnselectAll();
            _filterService.ClearFilter();
        }

        private void multiSelectColumnFilter_SelectionChanged(object sender, EventArgs e)
        {
            var selectedValues = _multiSelect.SelectedItems
                .Cast<C1CheckListItem>()
                .Select(i => i.DisplayText)
                .ToList();

            _filterService.ApplyFilter(selectedValues);
        }
    }
}