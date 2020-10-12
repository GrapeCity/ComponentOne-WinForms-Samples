using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1DataCollection101.View
{
    public class MenuListView: BaseListView
    {
        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            var bounds = e.Bounds;
            var item = e.Item;
            var sample = (Sample)e.Item.Tag;
            var pt = new Point(8, bounds.Y);
            using (var g = e.Graphics)
            {
                // back color
                var backColor = item.Selected ? Color.LightGray : BackColor;
                using (var backBrush = new SolidBrush(backColor))
                    g.FillRectangle(backBrush, bounds);
                // image
                var img = LargeImageList.Images[item.ImageIndex];
                g.DrawImage(img, pt);
                pt.X += img.Width + 4;
                // text
                pt.Y += 4;
                using (var fontBrush = new SolidBrush(Color.FromArgb(157, 34, 53)))
                using (var font = new Font(Font.FontFamily, 14))
                    g.DrawString(sample.Name, font, fontBrush, pt);
                pt.Y += 25;
                // description
                using (var fontBrush = new SolidBrush(Color.Gray))
                using (var font = new Font(Font.FontFamily, 11))
                    g.DrawString(sample.Description, font, fontBrush, pt);
            }
        }
    }
}
