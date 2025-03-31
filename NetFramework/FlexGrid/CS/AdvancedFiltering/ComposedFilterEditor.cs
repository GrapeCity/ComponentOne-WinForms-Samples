using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace AdvancedFiltering
{
    public partial class ComposedFilterEditor : UserControl, IC1ColumnFilterEditor
    {
        private ComposedFilter _composedFilter;

        public ComposedFilterEditor()
        {
            InitializeComponent();

            _columnFilterEditor.ActiveEditorChanged += _columnFilterEditor_ActiveEditorChanged;
        }

        private void _columnFilterEditor_ActiveEditorChanged(object sender, EventArgs e)
        {
            _weekdayFilterEditor.Visible = _columnFilterEditor.ActiveEditor == null;
        }

        public void Initialize(C1FlexGridBase grid, int columnIndex, IC1ColumnFilter filter)
        {
            _composedFilter = (ComposedFilter)filter;

            _columnFilterEditor.Initialize(grid, columnIndex, _composedFilter.ColumnFilter);
            _weekdayFilterEditor.Initialize(grid, columnIndex, _composedFilter.WeekdayFilter);

            if (_composedFilter.WeekdayFilter.IsActive || !_composedFilter.IsActive)
            {
                _weekdayFilterEditor.Visible = true;
                _columnFilterEditor.ActiveEditor = null;
            }
            else
            {
                _weekdayFilterEditor.Visible = false;
            }
        }

        public void ApplyChanges()
        {
            if (_weekdayFilterEditor.Visible)
            {
                _weekdayFilterEditor.ApplyChanges();
                _composedFilter.ColumnFilter.Reset();
            }
            else
            {
                _columnFilterEditor.ApplyChanges();
                _composedFilter.WeekdayFilter.Reset();
            }
        }

        public bool KeepFormOpen
        {
            get
            {
                return false;
            }
        }
    }
}
