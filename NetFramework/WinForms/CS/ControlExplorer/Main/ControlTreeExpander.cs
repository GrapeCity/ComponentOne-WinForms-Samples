using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Main
{
    public class ControlTreeExpander : Control
    {

        private string _name;
        private bool _expanded;
        int _childHeight = 0;
        private Control _child;
        private SizeF _textSize;
        private SolidBrush _brush;
        private float _textHeight;
        private int _childExpandedHeight;
        private int _childCollapsedHeight;

        public int ChildExpandedHeight
        {
            get
            {
                return _childExpandedHeight;
            }
            set
            {
                if (_childExpandedHeight != value)
                {
                    _childExpandedHeight = value;
                    CollapseExpandChild();
                }
            }
        }

        public int ChildCollapsedHeight
        {
            get
            {
                return _childCollapsedHeight;
            }
            set
            {
                if (_childCollapsedHeight != value)
                {
                    _childCollapsedHeight = value;
                    CollapseExpandChild();
                }
            }
        }

        public int ExpanderIconHeight { get; set; }
        public int ExpanderIconWidth { get; set; }
        public Control Child
        {
            get
            {
                return _child;
            }
            set
            {
                if(_child != value)
                {
                    _child = value;
                    _childHeight = _child.Height;
                }
            }
        }

        public new string Text
        {
            get
            {
                return this._name;
            }
            set
            {
                if(this._name != value)
                {
                    _name = value;
                    _textSize = this.CreateGraphics().MeasureString(_name, Font);
                    RenderControlTreeExpander();
                }
            }
        }

        public bool Expanded
        {
            get
            {
                return this._expanded;
            }
            set
            {
                if (this._expanded != value)
                {
                    _expanded = value;
                    RenderControlTreeExpander();
                }
            }
        }

        public ControlTreeExpander()
        {
            this.ExpanderIconHeight = this.Height / 3;
            this.ExpanderIconWidth = 2;
            this.Height = 150;
            this.Width = 400;
            this.Text = this.Name;
            this.Expanded = false;
            _brush = new SolidBrush(this.ForeColor);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            float texttop = ((this.Height - _textSize.Height) / 2) > 0 ?
                    ((this.Height - _textSize.Height) / 2) :
                    0;
            float textleft = this.Height + texttop;
            g.DrawString(this.Text, this.Font, _brush, new PointF(textleft, texttop));
            
            if (!this.Expanded)
            {
                float x, y, width, height;
                x = (this.Height - ExpanderIconHeight) / 2;
                y = ((this.Height - ExpanderIconHeight) / 2) + (this.ExpanderIconHeight - ExpanderIconWidth)/2;
                width = ExpanderIconHeight;
                height = ExpanderIconWidth;
                g.FillRectangle(_brush, x, y, width, height);

                y = (this.Height - ExpanderIconHeight) / 2;
                x = ((this.Height - ExpanderIconHeight) / 2) + (this.ExpanderIconHeight - ExpanderIconWidth) / 2;
                height = ExpanderIconHeight;
                width = ExpanderIconWidth;
                g.FillRectangle(_brush, x, y, width, height);
            }
            else
            {
                float x, y, width, height;
                x = (this.Height - ExpanderIconHeight) / 2;
                y = ((this.Height - ExpanderIconHeight) / 2) + (this.ExpanderIconHeight - ExpanderIconWidth) / 2;
                width = ExpanderIconHeight;
                height = ExpanderIconWidth;
                g.FillRectangle(_brush, x, y, width, height);
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            _brush = new SolidBrush(this.ForeColor);
            RenderControlTreeExpander();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            _textHeight = this.CreateGraphics().MeasureString("A", Font).Height;
            _textSize = this.CreateGraphics().MeasureString(_name, Font);
            RenderControlTreeExpander();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.X < this.Height)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor = Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X < this.Height)
            {
                Expanded = !Expanded;
                CollapseExpandChild();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.ExpanderIconHeight = this.Height / 3;
        }

        private void RenderControlTreeExpander()
        {
            Invalidate();
        }

        private void CollapseExpandChild()
        {
            if (Expanded)
            {
                this.Child.Height = _childExpandedHeight; ;
            }
            else
            {
                this.Child.Height = _childCollapsedHeight;
            }
        }
    }
}
