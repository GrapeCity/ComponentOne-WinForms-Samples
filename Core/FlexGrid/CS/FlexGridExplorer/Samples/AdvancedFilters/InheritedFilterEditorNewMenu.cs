using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.AdvancedFilters
{
    public partial class InheritedFilterEditorNewMenu : ColumnFilterEditor
    {
        private InheritedFilterNewMenu _inheritedFilter;

        public InheritedFilterEditorNewMenu()
        {
            InitializeComponent();

            UseComposedMenu = true;
            MenuFilters.DropDownItems.Add(_mnuWeekdayFilter);
        }

        public override void Initialize(C1FlexGridBase grid, int columnIndex, IC1ColumnFilter filter)
        {
            base.Initialize(grid, columnIndex, filter);
            _weekdayFilterEditor.Initialize(grid, columnIndex, filter);
            _inheritedFilter = (InheritedFilterNewMenu)filter;

            if (_inheritedFilter.WeekdayFilter.IsActive || !_inheritedFilter.IsActive)
            {
                ActiveEditor = _weekdayFilterEditor;
            }

            _mnuWeekdayFilter.Checked = _inheritedFilter.WeekdayFilter.IsActive;
        }

        private void _mnuWeekdayFilter_Click(object sender, EventArgs e)
        {
            ActiveEditor = _weekdayFilterEditor;
        }

        public override void ApplyChanges()
        {
            base.ApplyChanges();

            if (ActiveEditor != _weekdayFilterEditor)
            {
                _inheritedFilter.WeekdayFilter.Reset();
            }
        }

        public override IC1ColumnFilterEditor ActiveEditor
        {
            get
            {
                return _weekdayFilterEditor.Visible ? _weekdayFilterEditor : base.ActiveEditor;
            }
            set
            {
                base.ActiveEditor = value;
                _weekdayFilterEditor.Visible = value == _weekdayFilterEditor;
                _mnuWeekdayFilter.Highlighted = _weekdayFilterEditor.Visible;
            }
        }
    }
}
