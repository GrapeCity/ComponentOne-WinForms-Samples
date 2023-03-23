using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.Win.C1FlexGrid;

namespace FlexCalc
{
    class FlexCalcEngine : CalcEngine.CalcEngine
    {
        // ** fields
        FlexCalc _flex;

        // ** ctor

        /// <summary>
        /// Initializes a new instance of a FlexCalcEngine.
        /// </summary>
        /// <param name="flex">Grid that provides data for the engine.</param>
        public FlexCalcEngine(FlexCalc flex)
        {
            // save reference to parent grid
            _flex = flex;

            // parse multi-cell range references ($A2:B$4)
            IdentifierChars = "$:";
        }

        // ** object model

        /// <summary>
        /// Exposes the grid's DataContext to the CalcEngine.
        /// </summary>
        public override object DataContext
        {
            get { return _flex != null ? _flex.DataContext : base.DataContext; }
            set 
            {
                if (_flex != null)
                {
                    _flex.DataContext = value;
                }
                else
                {
                    base.DataContext = value;
                }
            }
        }
        /// <summary>
        /// Parses references to cell ranges.
        /// </summary>
        /// <param name="identifier">String representing a cell range (e.g. "A1" or "A1:B12".</param>
        /// <returns>A <see cref="CellRange"/> object that represents the given range.</returns>
        public override object GetExternalObject(string identifier)
        {
            // make sure we have a grid
            if (_flex != null)
            {
                var cells = identifier.Split(':');
                if (cells.Length > 0 && cells.Length < 3)
                {
                    CellRange rng = GetRange(cells[0]);
                    if (cells.Length > 1)
                    {
                        rng = MergeRanges(rng, GetRange(cells[1]));
                    }
                    if (rng.IsValid)
                    {
                        return new CellRangeReference(_flex, rng);
                    }
                }
            }

            // this doesn't look like a range
            return null;
        }

        // ** implementation
        CellRange GetRange(string cell)
        {
            int index = 0;

            // parse column
            int col = -1;
            bool absCol = false;
            for (; index < cell.Length; index++)
            {
                var c = cell[index];
                if (c == '$' && !absCol)
                {
                    absCol = true;
                    continue;
                }
                if (!char.IsLetter(c))
                {
                    break;
                }
                if (col < 0) col = 0;
                col = 26 * col + (char.ToUpper(c) - 'A' + 1);
            }

            // parse row
            int row = -1;
            bool absRow = false;
            for (; index < cell.Length; index++)
            {
                var c = cell[index];
                if (c == '$' && !absRow)
                {
                    absRow = true;
                    continue;
                }
                if (!char.IsDigit(c))
                {
                    break;
                }
                if (row < 0) row = 0;
                row = 10 * row + (c - '0');
            }

            // sanity
            if (index < cell.Length)
            {
                throw new Exception("Invalid cell reference.");
            }

            // done
            return index < cell.Length || row < 0 || col < 0
                ? _flex.GetCellRange(-1, -1)
                : _flex.GetCellRange(_flex.Rows.Fixed - 1 + row, _flex.Cols.Fixed - 1 + col);
        }
        CellRange MergeRanges(CellRange rng1, CellRange rng2)
        {
            return _flex.GetCellRange(
            Math.Min(rng1.TopRow, rng2.TopRow),
            Math.Min(rng1.LeftCol, rng2.LeftCol),
            Math.Max(rng1.BottomRow, rng2.BottomRow),
            Math.Max(rng1.RightCol, rng2.RightCol));
        }
        /// <summary>
        /// Represents cell ranges and returns the cell values to the calc engine.
        /// </summary>
        class CellRangeReference : CalcEngine.IValueObject, IEnumerable
        {
            FlexCalc _flex;
            CellRange _rng;
            bool _evaluating;

            public CellRangeReference(FlexCalc flex, CellRange rng)
            {
                _flex = flex;
                _rng = rng;
            }

            // ** IValueObject
            public object GetValue()
            {
                return GetValue(_rng);
            }

            // ** IEnumerable
            public IEnumerator GetEnumerator()
            {
                for (int r = _rng.TopRow; r <= _rng.BottomRow; r++)
                {
                    for (int c = _rng.LeftCol; c <= _rng.RightCol; c++)
                    {
                        var rng = _flex.GetCellRange(r, c);
                        yield return GetValue(rng);
                    }
                }
            }

            // ** implementation
            object GetValue(CellRange rng)
            {
                if (_evaluating)
                {
                    throw new Exception("Circular Reference");
                }

                try
                {
                    _evaluating = true;
                    return _flex.Evaluate(rng.r1, rng.c1);
                }
                finally
                {
                    _evaluating = false;
                }
            }
        }
    }
}
