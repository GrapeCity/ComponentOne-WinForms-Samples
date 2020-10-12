using C1.Framework;
using C1.Win.TreeView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HyperlinksInNodes
{
    public class HyperLinkPresenter : CustomContentPresenter
    {
        private HyperLinkElement _hyperLink;        

        public HyperLinkPresenter()
        {                        
            _hyperLink = new HyperLinkElement();            
            _hyperLink.Style = new Style();
            _hyperLink.Style.Margins = new Thickness(0,4);
            _hyperLink.Click += hyperLink_Click;
            // CustomContentPresenter child has a parent size, so we add an intermediate panel.
            var panel = new RowPanel();
            panel.Children.Add(_hyperLink);

            Child = panel;
        }

        private void hyperLink_Click(object sender, EventArgs e)
        {
            var url = ((Hyperlink)Node.GetValue()).Url;
            System.Diagnostics.Process.Start(url);            
        }

        #region ICellContentPresenter
        public override void SetStyle(TreeNodeCellStyles styles)
        {
            _hyperLink.Style.Font = styles.Font;            
        }

        public override void SetValue(object value)
        {
            _hyperLink.Text = value.ToString();
        }

        public override string ToolTipText
        {
            get
            {
                return string.Empty;
            }
        }

        public override void SetFormat(string format)
        {

        }        
        #endregion
    }

    public class HyperLinkElement : TextElement
    {
        private bool _isVisited;
        private Cursor _oldCursor;
        private Color _defaultColor;

        public HyperLinkElement()
        {
            HitTestable = true;
        }

        public override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            // saves cursor and changes to hand
            _oldCursor = HostControl.Cursor;
            HostControl.Cursor = Cursors.Hand;
            // set underline
            Style.Font = new Font(Style.Font, FontStyle.Underline);
        }

        public override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            // reset cursor
            HostControl.Cursor = _oldCursor;
            // reset font
            Style.Font = new Font(Style.Font, FontStyle.Regular);
        }

        public bool IsVisited
        {
            get { return _isVisited; }
            set {
                _isVisited = value;
                if (_isVisited)
                {
                    _defaultColor = Style.ForeColor;
                    // set visited color
                    Style.ForeColor = System.Drawing.Color.FromArgb(128, 0, 128);
                }
                else
                {
                    Style.ForeColor = _defaultColor;
                }
            }
        }

        public override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            IsVisited = true;            
            if (Click != null)
                Click(this, e);
        }

        public event EventHandler Click;
    }
}
