using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    class StringFilter : C1.Win.C1FlexGrid.IC1ColumnFilter
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        List<Point> _ranges = new List<Point>();

        #endregion

        //-------------------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Gets the list of points that define the strings accepted by this fiter.
        /// </summary>
        public List<Point> Ranges
        {
            get { return _ranges; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilter Members

        // filter is active if range list is not empty.
        public bool IsActive
        {
            get { return _ranges.Count > 0; }
        }

        // reset filter.
        public void Reset()
        {
            _ranges.Clear();
        }

        // apply filter to a given date
        public bool Apply(object value)
        {
            if (value != null)
            {
                var s = value.ToString();
                if (s.Length > 0)
                {
                    int c = char.ToUpperInvariant(s[0]);
                    foreach (var cr in _ranges)
                    {
                        if (c >= char.ToUpperInvariant((char)cr.X) &&
                            c <= char.ToUpperInvariant((char)cr.Y))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // return editor control for this filter
        public C1.Win.C1FlexGrid.IC1ColumnFilterEditor GetEditor()
        {
            return new StringFilterEditor();
        }

        #endregion
    }
}
