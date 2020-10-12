using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    class ColorFilter : C1.Win.C1FlexGrid.IC1ColumnFilter
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        Color _targetColor = Color.Empty;
        int _tolerance = 100;

        #endregion

        //-------------------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Gets or sets the color the filter is looking for.
        /// </summary>
        public Color TargetColor
        {
            get { return _targetColor; }
            set { _targetColor = value; }
        }
        /// <summary>
        /// Gets or sets the tolerance to use when matching the colors.
        /// </summary>
        public int Tolerance
        {
            get { return _tolerance; }
            set { _tolerance = value; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilter Members

        // filter is active if TargetColor is not empty.
        public bool IsActive
        {
            get { return TargetColor != Color.Empty; }
        }

        // reset filter by setting TargetColor to empty.
        public void Reset()
        {
            TargetColor = Color.Empty;
        }

        // apply filter to a given color
        public bool Apply(object value)
        {
            var clr = (Color)value;
            int dr = Math.Abs(clr.R - _targetColor.R);
            int dg = Math.Abs(clr.G - _targetColor.G);
            int db = Math.Abs(clr.B - _targetColor.B);
            return dr + dg + db <= Tolerance;
        }

        // return editor control for this filter
        public C1.Win.C1FlexGrid.IC1ColumnFilterEditor GetEditor()
        {
            return new ColorFilterEditor();
        }

        #endregion
    }
}
