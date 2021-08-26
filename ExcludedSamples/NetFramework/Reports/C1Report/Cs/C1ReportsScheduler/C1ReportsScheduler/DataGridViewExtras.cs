using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace C1ReportsScheduler
{
    public class DataGridViewImageButtonCell : DataGridViewButtonCell
    {
        private Image _image;
        private Size _imageSize;

        public DataGridViewImageButtonCell()
        {
        }

        public DataGridViewImageButtonCell(Image image, Size imageSize, string toolTipText)
        {
            _image = image;
            _imageSize = imageSize;
            base.ToolTipText = toolTipText;
        }

        public override object Clone()
        {
            DataGridViewImageButtonCell clone = (DataGridViewImageButtonCell)base.Clone();
            clone._image = this._image;
            clone._imageSize = this._imageSize;
            return clone;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            System.Diagnostics.Debug.Assert(_image != null && _imageSize != Size.Empty);
            if (_image == null || _imageSize == Size.Empty)
                return;
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            Rectangle rc = new Rectangle(
                cellBounds.X + (cellBounds.Width - _imageSize.Width) / 2,
                cellBounds.Y + (cellBounds.Height - _imageSize.Height) / 2,
                _imageSize.Width,
                _imageSize.Height);
            graphics.DrawImage(_image, rc);
        }
    }
}
