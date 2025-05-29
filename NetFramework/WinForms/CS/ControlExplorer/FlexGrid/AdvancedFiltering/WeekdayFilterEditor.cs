using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.AdvancedFiltering
{
    public partial class WeekdayFilterEditor : UserControl, IC1ColumnFilterEditor
    {
        private WeekdayFilter _weekdayFilter;

        public WeekdayFilterEditor()
        {
            this.Text = "Week Day Filter";
            InitializeComponent();
        }

        public void Initialize(C1FlexGridBase grid, int columnIndex, IC1ColumnFilter filter)
        {
            if (filter is InheritedFilter inheritedFilter)
            {
                _weekdayFilter = inheritedFilter.WeekdayFilter;
            }
            else if (filter is ComposedFilter composedFilter)
            {
                _weekdayFilter = composedFilter.WeekdayFilter;
            }
            else
            {
                _weekdayFilter = (WeekdayFilter)filter;
            }

            chkMon.Checked = _weekdayFilter.Monday;
            chkTue.Checked = _weekdayFilter.Tuesday;
            chkWed.Checked = _weekdayFilter.Wednesday;
            chkThu.Checked = _weekdayFilter.Thursday;
            chkFri.Checked = _weekdayFilter.Friday;
            chkSat.Checked = _weekdayFilter.Saturday;
            chkSun.Checked = _weekdayFilter.Sunday;
        }

        public void ApplyChanges()
        {
            _weekdayFilter.Monday = chkMon.Checked;
            _weekdayFilter.Tuesday = chkTue.Checked;
            _weekdayFilter.Wednesday = chkWed.Checked;
            _weekdayFilter.Thursday = chkThu.Checked;
            _weekdayFilter.Friday = chkFri.Checked;
            _weekdayFilter.Saturday = chkSat.Checked;
            _weekdayFilter.Sunday = chkSun.Checked;
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
