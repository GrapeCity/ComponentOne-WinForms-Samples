using System;
using System.Windows;
using System.Windows.Forms;
using System.Collections.Generic;
using C1.Win.FlexGrid;

namespace ResizeNormalCell
{
    public class C1FlexGridResizer : C1FlexGrid
    {
        int _resizeColumn;
        int _startX;

        // show resize cursor when user moves the mouse near cell boundaries,
        // resize column as the user drags the mouse.
        protected override void OnMouseMove(MouseEventArgs e)
        {
            var pressed = (Control.MouseButtons & MouseButtons.Left) != 0;
            var ht = HitTest();

            // offer to resize column
            if (!pressed && ht.Type == HitTestTypeEnum.Cell)
            {
                var rc = GetCellRect(ht.Row, ht.Column);
                if (ht.Column > 0 && ht.X - rc.X < 4)
                {
                    Cursor = Cursors.SizeWE;
                    _resizeColumn = ht.Column - 1;
                }
                else if (rc.Right - ht.X < 4)
                {
                    Cursor = Cursors.SizeWE;
                    _resizeColumn = ht.Column;
                }
                else
                {
                    Cursor = null;
                    _resizeColumn = -1;
                }
            }

            // resize column as the user drags the mouse
            if (pressed && _resizeColumn > -1)
            {
                var c = Cols[_resizeColumn];
                c.Width = e.X - _startX;
            }

            // fire event as usual
            base.OnMouseMove(e);
        }

        // start resizing column when user presses the mouse button
        protected override void OnMouseDown(MouseEventArgs e)
        {
            var pressed = (Control.MouseButtons & MouseButtons.Left) != 0;
            if (_resizeColumn > -1 && pressed)
            {
                Capture = true;
                var c = Cols[_resizeColumn];
                _startX = e.X - c.WidthDisplay;
            }
            else
            {
                base.OnMouseDown(e);
            }
        }

        // finish resizing
        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            _resizeColumn = -1;
            base.OnMouseCaptureChanged(e);
        }
    }
}
