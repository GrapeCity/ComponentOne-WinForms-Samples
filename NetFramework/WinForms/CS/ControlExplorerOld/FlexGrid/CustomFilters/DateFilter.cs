using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    class DateFilter : C1.Win.C1FlexGrid.IC1ColumnFilter
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        DateTime _min = DateTime.MinValue;
        DateTime _max = DateTime.MaxValue;

        #endregion

        //-------------------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Gets or sets the minimum date required by the filter.
        /// </summary>
        public DateTime Minimum
        {
            get { return _min; }
            set { _min = value; }
        }
        /// <summary>
        /// Gets or sets the maximum date required by the filter.
        /// </summary>
        public DateTime Maximum
        {
            get { return _max; }
            set { _max = value; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilter Members

        // filter is active if range doesn't cover all represetabla dates.
        public bool IsActive
        {
            get { return _min != DateTime.MinValue || _max != DateTime.MaxValue; }
        }

        // reset filter.
        public void Reset()
        {
            _min = DateTime.MinValue;
            _max = DateTime.MaxValue;
        }

        // apply filter to a given date
        public bool Apply(object value)
        {
            var dt = (DateTime)value;
            return dt >= _min && dt <= _max;
        }

        // return editor control for this filter
        public C1.Win.C1FlexGrid.IC1ColumnFilterEditor GetEditor()
        {
            return new DateFilterEditor();
        }

        #endregion
    }
}
