using System.Drawing;
using System.Windows.Forms;

namespace C1DataCollection101.View
{
    public class YouTubeListView : BaseListView
    {      
        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            var bounds = e.Bounds;
            var item = e.Item;
            var video = (YouTubeVideo)e.Item.Tag;
            var pt = new Point(8, bounds.Y);
            using (var g = e.Graphics)
            {
                // back color
                var backColor = item.Selected ? Color.LightGray : BackColor;
                using (var backBrush = new SolidBrush(backColor))
                    g.FillRectangle(backBrush, bounds);
                // image
                if (item.ImageIndex >= 0 && item.ImageIndex < LargeImageList.Images.Count)
                {
                    var img = LargeImageList.Images[item.ImageIndex];
                    // check click
                    g.DrawImage(img, pt);
                    pt.X += img.Width + 4;
                }
                // text
                pt.Y += 4;
                using (var fontBrush = new SolidBrush(Color.FromArgb(157, 34, 53)))
                using (var font = new Font(Font.FontFamily, 14))
                    g.DrawString(video.Title, font, fontBrush, pt);
                pt.Y += 25;
                // description
                using (var fontBrush = new SolidBrush(Color.Gray))
                using (var font = new Font(Font.FontFamily, 11))
                    g.DrawString(video.Description, font, fontBrush, pt);
            }
        }

    }
}
