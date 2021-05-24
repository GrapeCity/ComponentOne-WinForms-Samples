using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C1.Framework;
using C1.Win.TreeView;

namespace C1.C1FlexReportExplorer
{
    /// <summary>
    /// This is used as tree view item object.
    /// </summary>
    internal class TagInfo
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public Image Image { get; set; }
    }

    public class ImageCustomNode : CustomContentPresenter
    {
        private ImageElement _img;
        private RowPanel _rw;

        public ImageCustomNode()
        {
            // initialization image element
            _img = new ImageElement();
            _img.Style = new Style();
            _img.Size = new Size(72, 52);
            HitTestable = true;

            // panel for image
            _rw = new RowPanel();
            _rw.Children.Add(_img);
            _rw.Style = new Style();
            _rw.Style.VerticalAlignment = Alignment.Center;
        }

                public override string ToolTipText
        {
            get
            {
                var row = (TagInfo)Node.Tag;
                return row.Title;
            }
        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            base.SetStyle(styles);

            // image
            _img.Style.ImageScaling = ImageScaling.Scale;
            _img.Style.ImageAlignment = ImageAlignment.CenterCenter;
        }

        public override void SetValue(object value)
        {
            // image
            var row = (TagInfo)Node.Tag;
            if (_img.Image != null)
            {
                _img.Image.Dispose();
                _img.Image = null;
            }
            _img.Image = row.Image;

            // set root panel
            Child = _rw;
        }

        public override void SetFormat(string format)
        {

        }
    }

    public class TitleCustomNode : CustomContentPresenter
    {
        private TextElement _title;
        private TextElement _description;
        private ColumnPanel _cp;

        public TitleCustomNode()
        {
            // title
            _title = new TextElement();
            _title.Style = new Style();

            // description
            _description = new TextElement();
            _description.Style = new Style();
            _description.Width = 120;

            // grid for text elements
            _cp = new ColumnPanel();
            _cp.Children.Add(_title);
            _cp.Children.Add(_description);
            _cp.Style = new Style();
            _cp.Style.VerticalAlignment = Alignment.Center;

            HitTestable = true;

        }

        public override string ToolTipText
        {
            get
            {
                var row = (TagInfo)Node.Tag;
                return row.Title;
            }
        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            base.SetStyle(styles);

            // name 
            _title.Style.Margins = new Thickness(2);
            _title.Style.Font = new Font("Calibri", 11, FontStyle.Regular);

            // description
            _description.Style.Margins = new Thickness(1);
            _description.Style.ForeColor = Color.DarkGray;
            _description.Style.Font = new Font("Calibri", 10, FontStyle.Italic);
            _description.Style.WordWrap = true;
        }

        public override void SetValue(object value)
        {
            // initialization
            var row = (TagInfo)Node.Tag;
            _title.Text = row.Title;

            if (Node.Level == 0)
            {
                var count = Node.HasChildren ? Node.Nodes.Count : 0;
                _description.Text = $"({count})";
            }
            else
            {
                _description.Text = row.Path;
            }

            // set root panel
            Child = _cp;
        }

        public override void SetFormat(string format)
        {

        }
    }
}
