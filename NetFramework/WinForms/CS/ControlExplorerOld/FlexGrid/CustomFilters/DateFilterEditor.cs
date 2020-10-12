using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    public partial class DateFilterEditor : 
        UserControl,
        C1.Win.C1FlexGrid.IC1ColumnFilterEditor
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        DateFilter _filter;

        #endregion

        //-------------------------------------------------------------------------------
        #region ** ctor

        public DateFilterEditor()
        {
            InitializeComponent();
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilterEditor

        public void Initialize(C1.Win.C1FlexGrid.C1FlexGridBase grid, int columnIndex, C1.Win.C1FlexGrid.IC1ColumnFilter filter)
        {
            _filter = (DateFilter)filter;

            // TODO: 
            // a really useful editor would set the calendar/checkboxes to match the current
            // filter values.
        }
        public void ApplyChanges()
        {
            _filter.Reset();
            if (_chkCalendar.Checked)
            {
                _filter.Minimum = _calendar.SelectionRange.Start;
                _filter.Maximum = _calendar.SelectionRange.End;
            }
            else 
            {
                var yesterday = DateTime.Today.AddDays(-1);
                if (_chkYesterday.Checked)
                {
                    _filter.Maximum = yesterday;
                    _filter.Minimum = yesterday;
                }
                if (_chkEarlierThisWeek.Checked)
                {
                    _filter.Maximum = yesterday;
                    _filter.Minimum = yesterday;
                    while (_filter.Minimum.DayOfWeek != DayOfWeek.Monday)
                    {
                        _filter.Minimum = _filter.Minimum.AddDays(-1);
                    }
                }
                if (_chkLastWeek.Checked)
                {
                    _filter.Maximum = yesterday;
                    _filter.Minimum = yesterday.AddDays(-7);
                    while (_filter.Minimum.DayOfWeek != DayOfWeek.Monday)
                    {
                        _filter.Minimum = _filter.Minimum.AddDays(-1);
                    }
                }
                if (_chkLongAgo.Checked)
                {
                    _filter.Maximum = yesterday;
                    _filter.Minimum = yesterday.AddYears(-5);
                }
            }
        }
        public bool KeepFormOpen
        {
            get { return false; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** event handlers

        void _calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            _chkCalendar.Checked = true;
        }
        void _chkCalendar_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            cb.Font = new Font(Font, cb.Checked ? FontStyle.Bold : FontStyle.Regular);
        }

        #endregion
    }
}
