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
    public partial class InheritedFilterEditor : ColumnFilterEditor
    {
        private InheritedFilter _inheritedFilter;

        public InheritedFilterEditor()
        {
            InitializeComponent();

            ParentChanged += InheritedFilterEditor_ParentChanged;
        }

        private void InheritedFilterEditor_ParentChanged(object sender, EventArgs e)
        {
            //ParentForm.MaximumSize = Size.Empty;
        }

        public override void Initialize(C1FlexGridBase grid, int columnIndex, IC1ColumnFilter filter)
        {
            base.Initialize(grid, columnIndex, filter);
            _weekdayFilterEditor.Initialize(grid, columnIndex, filter);
            _inheritedFilter = (InheritedFilter)filter;

            if (_inheritedFilter.WeekdayFilter.IsActive || !_inheritedFilter.IsActive)
            {
                ActiveEditor = _weekdayFilterEditor;
            }
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
            }
        }
    }
}
