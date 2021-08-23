using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using C1.Win.C1FlexGrid;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace C1.Win.C1FlexGrid
{
    // this file contains small utility methods
    public partial class C1FlexGridPrinter
    {
        private Unit PixelsToUnit(int pix)
        {
            return new Unit((double)pix / 96d, UnitTypeEnum.Inch);
        }

        // todo: handle dotted lines
        private LineDef BorderToLineDef(CellStyle cellStyle, bool horizontal)
        {
            CellBorder cb = cellStyle.Border;
            bool none;
            if (horizontal)
                none = cb.Style == BorderStyleEnum.None || cb.Direction == BorderDirEnum.Vertical;
            else // vertical
                none = cb.Style == BorderStyleEnum.None || cb.Direction == BorderDirEnum.Horizontal;
            if (none)
                return LineDef.Empty;
            else
                return new LineDef(PixelsToUnit(cb.Width), cb.Color);
        }
    }
}
