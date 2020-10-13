using C1.Win.C1TrueDBGrid;
using C1.Win.C1TrueDBGrid.BaseGrid;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.ZoomPolicies
{
    public class C1TrueDBGridZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1TrueDBGrid); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            C1TrueDBGrid trueDBGrid = control as C1TrueDBGrid;
            if (trueDBGrid.CellTipsWidth > 0)
            {
                trueDBGrid.CellTipsWidth = infos.Zoom(trueDBGrid.CellTipsWidth);
            }
            if (trueDBGrid.DefColWidth > 0)
            {
                trueDBGrid.DefColWidth = infos.Zoom(trueDBGrid.DefColWidth);
            }
            if (trueDBGrid.RecordSelectorWidth > 0)
            {
                trueDBGrid.RecordSelectorWidth = infos.Zoom(trueDBGrid.RecordSelectorWidth);
            }
            if (trueDBGrid.ViewCaptionWidth > 0)
            {
                trueDBGrid.ViewCaptionWidth = infos.Zoom(trueDBGrid.ViewCaptionWidth);
            }
            if (trueDBGrid.ViewColumnWidth > 0)
            {
                trueDBGrid.ViewColumnWidth = infos.Zoom(trueDBGrid.ViewColumnWidth);
            }
            if (trueDBGrid.CaptionHeight > 0)
            {
                trueDBGrid.CaptionHeight = infos.Zoom(trueDBGrid.CaptionHeight);
            }
            if (trueDBGrid.RowHeight > 0)
            {
                trueDBGrid.RowHeight = infos.Zoom(trueDBGrid.RowHeight);
            }
            if (!trueDBGrid.SplitDividerSize.IsEmpty)
            {
                trueDBGrid.SplitDividerSize = infos.Zoom(trueDBGrid.SplitDividerSize);
            }
            foreach (Split split in trueDBGrid.Splits)
            {
                if (split.CaptionHeight > 0)
                {
                    split.CaptionHeight = infos.Zoom(split.CaptionHeight);
                }
                if (split.ColumnCaptionHeight > 0)
                {
                    split.ColumnCaptionHeight = infos.Zoom(split.ColumnCaptionHeight);
                }
                if (split.ColumnFooterHeight > 0)
                {
                    split.ColumnFooterHeight = infos.Zoom(split.ColumnFooterHeight);
                }
                if (split.Height > 0)
                {
                    split.Height = infos.Zoom(split.Height);
                }
                if (split.MinHeight > 0)
                {
                    split.MinHeight = infos.Zoom(split.MinHeight);
                }
                if (split.MinWidth > 0)
                {
                    split.MinWidth = infos.Zoom(split.MinWidth);
                }
                if (split.SplitSize > 0)
                {
                    split.SplitSize = infos.Zoom(split.SplitSize);
                }
                foreach (C1DisplayColumn column in split.DisplayColumns)
                {
                    if (column.Width > 0)
                    {
                        column.Width = infos.Zoom(column.Width);
                    }
                    if (column.Height > 0)
                    {
                        column.Height = infos.Zoom(column.Height);
                    }
                }
                foreach (ViewRow row in split.Rows)
                {
                    if (row.Width > 0)
                    {
                        row.Width = infos.Zoom(row.Width);
                    }
                    if (row.Height > 0)
                    {
                        row.Height = infos.Zoom(row.Height);
                    }
                }
            }
            foreach (C1DataColumn column in trueDBGrid.Columns)
            {
                if (column.DataWidth > 0)
                {
                    column.DataWidth = infos.Zoom(column.DataWidth);
                }
            }
            base.ZoomBounds(control, infos);
        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            C1TrueDBGrid trueDBGrid = control as C1TrueDBGrid;

            Font baseFont = trueDBGrid.Font;
            foreach (Style style in trueDBGrid.Styles)
            {
                ZoomStyle(infos, baseFont, style);
            }

            foreach (Split split in trueDBGrid.Splits)
            {
                baseFont = trueDBGrid.Font;
                if (split.Style != null && split.Style.Font != null && !object.ReferenceEquals(split.Style.Font, baseFont))
                {
                    ZoomStyle(infos, baseFont, split.Style);
                    baseFont = split.Style.Font;
                }

                foreach (C1DisplayColumn column in split.DisplayColumns)
                {
                    ZoomStyle(infos, baseFont, column.Style);
                }
            }

            baseFont = trueDBGrid.Font;
            base.ZoomFont(control, infos);
        }

        private void ZoomStyle(ZoomFontInfo infos, Font baseFont, Style style)
        {
            if (style == null || style.Font == null)
            {
                return;
            }
            style.Font = infos.Zoom(style.Font);
        }

        Dictionary<Control, int> _firstRowCache = new Dictionary<Control, int>();

        public override void Initialize(Control control)
        {
            C1TrueDBGrid trueDBGrid = control as C1TrueDBGrid;
            if (trueDBGrid.EditActive)
            {
                trueDBGrid.EditActive = false;
            }
            // Cache the first row of TrueDBGrid, then restore it after zoom.
            // By this code, we can keep the first row no change when zoom.
            _firstRowCache.Add(trueDBGrid, trueDBGrid.FirstRow);

            base.Initialize(control);
        }

        public override void Terminate(Control control)
        {
            C1TrueDBGrid trueDBGrid = control as C1TrueDBGrid;

            trueDBGrid.FirstRow = _firstRowCache[trueDBGrid];
            _firstRowCache.Remove(trueDBGrid);

            base.Terminate(control);
        }

        public override IEnumerable<Control> GetChildren(Control control)
        {
            List<Control> children = new List<Control>();
            foreach (Control child in control.Controls)
            {
                if (child is ScrollBar)
                {
                    continue;
                }
                children.Add(child);
            }
            return children;
        }
    }

    public class C1TDBDropDownZoomPolicy : NoZoomFontZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1TrueDBDropdown); }
        }

        public override bool CanZoom(Control control)
        {
            return false;
        }

        public override bool CanZoomChildren(Control control)
        {
            return false;
        }
    }

}

