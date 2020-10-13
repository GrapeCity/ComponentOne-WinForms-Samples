using C1.Win.C1FlexGrid;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.ZoomPolicies
{
    public class C1FlexGridZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1FlexGrid); }
        }

        private Dictionary<Control, FlexGridInitInfo> _flexGridInfoCache = new Dictionary<Control, FlexGridInitInfo>();
        private Dictionary<RowColCollection, object> _zoomedCols = new Dictionary<RowColCollection, object>();

        public override void Initialize(System.Windows.Forms.Control control)
        {
            C1FlexGrid flexGrid = control as C1FlexGrid;
            _flexGridInfoCache.Add(flexGrid, new FlexGridInitInfo(flexGrid.Rows.DefaultSize, flexGrid.Cols.DefaultSize, flexGrid.TopRow, flexGrid.LeftCol));

            flexGrid.Styles[CellStyleEnum.FilterEditor].Font = flexGrid.Styles[CellStyleEnum.FilterEditor].Font.Clone() as Font;

            base.Initialize(control);
        }

        public override void Terminate(Control control)
        {
            C1FlexGrid flexGrid = control as C1FlexGrid;
            flexGrid.TopRow = _flexGridInfoCache[control].TopRow;
            flexGrid.LeftCol = _flexGridInfoCache[control].LeftCol;

            _flexGridInfoCache.Remove(control);
            _zoomedCols.Clear();
            base.Terminate(control);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1FlexGrid flexGrid = control as C1FlexGrid;
            flexGrid.Cols.DefaultSize = infos.Zoom(_flexGridInfoCache[control].DefaultColSize);
            flexGrid.Rows.DefaultSize = infos.Zoom(_flexGridInfoCache[control].DefaultRowSize);
            if (flexGrid.Rows.MinSize > 0)
            {
                flexGrid.Rows.MinSize = infos.Zoom(flexGrid.Rows.MinSize);
            }
            if (flexGrid.Cols.MinSize > 0)
            {
                flexGrid.Cols.MinSize = infos.Zoom(flexGrid.Cols.MinSize);
            }

            if (!_zoomedCols.ContainsKey(flexGrid.Cols))
            {
                // The columns may be shared by multi flex grid.
                _zoomedCols.Add(flexGrid.Cols, null);
                foreach (Column column in flexGrid.Cols)
                {
                    if (column.Width > 0)
                    {
                        column.Width = infos.Zoom(column.Width);
                    }
                }
            }

            if (!_zoomedCols.ContainsKey(flexGrid.Rows))
            {
                // The rows may be shared by multi flex grid.
                _zoomedCols.Add(flexGrid.Rows, null);
                foreach (Row row in flexGrid.Rows)
                {
                    if (row.Height > 0)
                    {
                        row.Height = infos.Zoom(row.Height);
                    }
                }
            }

            base.ZoomBounds(control, infos);
        }

        private void ZoomStyle(ZoomFontInfo infos, CellStyle style)
        {
            if (style == null || style.Font == null)
            {
                return;
            }
            Font newFont = infos.Zoom(style.Font);
            if (!object.ReferenceEquals(newFont, style.Font))
            {
                style.Font = newFont;
            }
        }

        private struct FlexGridInitInfo
        {
            public FlexGridInitInfo(int defaultRowSize, int defaultColSize, int topRow, int leftCol)
            {
                DefaultRowSize = defaultRowSize;
                DefaultColSize = defaultColSize;
                TopRow = topRow;
                LeftCol = leftCol;
            }
            public int DefaultRowSize;
            public int DefaultColSize;
            public int TopRow;
            public int LeftCol;
        }
    }
}

