using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C1.Framework;
using System.Xml.Linq;
using C1.Win.Themes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinancialChartExplorer.CustomControls
{
    internal class AccordionChildCT : Control
    {
        public AccordionChildCT()
        {
            DoubleBuffered = true;
            Font = new Font("Segoe UI Variable", 10, FontStyle.Regular);
            ForeColor = Color.Black;
        }

        private bool _isHovered = false;
        private Color _indicatorColor = ColorTranslator.FromHtml("#005FB8");
        private int _collapsedHeight = 40;
        private int _indicatorSize = 40;
        private int _generalControlHeight;

        public delegate void ChildClickedEventHandler(object sender, EventArgs e);

        public event ChildClickedEventHandler ChildClicked;

        public int IndicatorSize { get => _indicatorSize; set => _indicatorSize = value; }
        public int GeneralControlHeight { get => _generalControlHeight; set => _generalControlHeight = value; }

        private GraphicsPath GetRoundedCornerPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            return path;
        }

        public string SetTheme
        {
            set
            {
                if (!_isHovered)
                {
                    BackColor = value == "Office365White" ? Color.WhiteSmoke : Color.Black;
                    ForeColor = value == "Office365White" ? Color.Black : Color.White;
                }
                else if (_isHovered)
                {
                    BackColor = value == "Office365White" ? Color.White : Color.Gray;
                    ForeColor = value == "Office365White" ? Color.Black : Color.White;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SizeF stringSize = e.Graphics.MeasureString(Text, Font);


            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush brush = new SolidBrush(ForeColor))
            {
                // Define the brush (color) to draw the text
                float x = 48;
                float y = _collapsedHeight / 3; // center
                // Define the location to draw the text
                if (stringSize.Width > 300)
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    stringFormat.FormatFlags = StringFormatFlags.NoWrap;

                    e.Graphics.DrawString(Text, Font, brush, new RectangleF(x, y, 300F, stringSize.Height), stringFormat);

                }
                else
                {
                    e.Graphics.DrawString(Text, Font, brush, new PointF(x, y));
                }
            }

            // Draw vertical line when hovered
            if (_isHovered)
            {
                using (Pen pen = new Pen(_indicatorColor, 3))
                {
                    e.Graphics.DrawLine(pen, 10, 12, 10, 28); // Vertical line
                }
            }
            SetTheme = C1ThemeController.ApplicationTheme;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            string curTheme = C1ThemeController.ApplicationTheme;
            Invalidate();
            SetTheme = curTheme;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovered = false;
            string curTheme = C1ThemeController.ApplicationTheme;
            Invalidate();
            SetTheme = curTheme;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ChildClicked?.Invoke(this, e);
        }

    }
    //***********************************************************************************************
    internal class AccordionCT : Control, ISupportInitialize
    {
        public AccordionCT()
        {
            DoubleBuffered = true;
            Font = new Font("Segoe UI Variable", 12, FontStyle.Regular);
        }

        private bool _isHovered = false;
        private bool _isExpanded = false;
        private Color _indicatorColor = ColorTranslator.FromHtml("#005FB8");
        private int _collapsedHeight = 40;
        private int _textHeight = 14;
        private List<AccordionChildCT> _children = new List<AccordionChildCT>();

        public delegate void AccordionClickedEventHandler(object sender, EventArgs e);
        public event AccordionClickedEventHandler AccordionClicked;

        private int _generalControlHeight;

        public int GeneralControlHeight { get => _generalControlHeight; set => _generalControlHeight = value; }
        public bool IsExpanded { get => _isExpanded; set => _isExpanded = value; }

        public void AddChild(AccordionChildCT child)
        {
            if (child != null)
            {
                _children.Add(child);
            }
        }

        public string SetTheme
        {
            set
            {
                if (_isHovered)
                {
                    BackColor = value == "Office365White" ? Color.White : Color.Gray;
                    ForeColor = Color.Black;
                }
                else if (!_isHovered)
                {
                    BackColor = value == "Office365White" ? Color.WhiteSmoke : Color.Black;
                    ForeColor = value == "Office365White" ? Color.Black : Color.White;
                }
                foreach (AccordionChildCT child in Controls)
                {
                    child.BackColor = value == "Office365White" ? Color.White : Color.Black;
                    child.ForeColor = value == "Office365White" ? Color.Black : Color.White;
                }
            }
        }

        private GraphicsPath GetRoundedCornerPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SizeF stringSize = e.Graphics.MeasureString(Text, Font);
            _textHeight = (int)stringSize.Height;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush brush = new SolidBrush(ForeColor))
            {
                // Define the brush (color) to draw the text
                float x = 16;
                float y = (_collapsedHeight - stringSize.Height) / 2; // center
                if (stringSize.Width > 300)
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    stringFormat.FormatFlags = StringFormatFlags.NoWrap;

                    e.Graphics.DrawString(Text, Font, brush, new RectangleF(x, y, 315F, stringSize.Height), stringFormat);

                }
                // Define the location to draw the text
                else { e.Graphics.DrawString(Text, Font, brush, new PointF(x, y)); }
            }

            // Draw vertical line when hovered
            if (_isHovered)
            {
                using (Pen pen = new Pen(_indicatorColor, 3))
                {
                    e.Graphics.DrawLine(pen, 10, 12, 10, 28); // Vertical line
                }
            }
            // Calculate center of the control on the right side for chevron placement
            int chevronCenterY = _collapsedHeight / 2;
            int chevronRightX = Width - 20;
            // Draw Up and Down chevron
            if (_isExpanded)
            {
                using (Pen pen = new Pen(ForeColor, 1))
                {
                    // Draw Chevron Up (center-right)
                    Point[] chevronUpPoints =
                    {
                        new Point(chevronRightX - 5, chevronCenterY + 3), // Bottom-left
                        new Point(chevronRightX, chevronCenterY - 3),      // Top-center
                        new Point(chevronRightX + 5, chevronCenterY + 3)  // Bottom-right
                    };
                    e.Graphics.DrawLines(pen, chevronUpPoints);
                }
            }
            else
            {
                using (Pen pen = new Pen(ForeColor, 1))
                {
                    Point[] chevronDownPoints =
                    {
                        new Point(chevronRightX - 5, chevronCenterY - 3), // Top-left
                        new Point(chevronRightX, chevronCenterY + 3),      // Bottom-center
                        new Point(chevronRightX + 5, chevronCenterY - 3)  // Top-right
                    };
                    e.Graphics.DrawLines(pen, chevronDownPoints);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!_isExpanded)
            {
                _isHovered = true;
                Invalidate();
            }
            SetTheme = C1ThemeController.ApplicationTheme;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovered = false;
            Invalidate();
            SetTheme = C1ThemeController.ApplicationTheme;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (_isExpanded)
            {
                _collapsedHeight = Height;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (_isExpanded)
            {
                Size = new Size(Width, _collapsedHeight);
            }
            else
            {
                if (Controls.Count == 0 && _children.Count != 0)
                {
                    for (int i = 0; i < _children.Count; i++)
                    {
                        var cnt = _children[i];
                        cnt.Location = new Point(0, _collapsedHeight + i * _collapsedHeight);
                        cnt.ForeColor = Color.Black;
                        cnt.IndicatorSize = _textHeight;
                        cnt.Height = _generalControlHeight;
                        cnt.Visible = !_isExpanded;
                        Controls.Add(cnt);
                    }
                }
                Height = _generalControlHeight + _children.Count * _generalControlHeight;
            }
            _isExpanded = !_isExpanded;
            Invalidate();
            AccordionClicked.Invoke(this, e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            OnClick(e);
        }

        void ISupportInitialize.BeginInit()
        {
        }

        void ISupportInitialize.EndInit()
        {
        }
    }
    //***********************************************************************************************
    internal class AccordionAreaCT : Panel
    {
        private int _generalControlHeights = 40;

        public delegate void FinalClickEventHandler(object sender, EventArgs e);
        public event FinalClickEventHandler Child_Clicked_Callback;

        public Font AccordionFont
        {
            get => Font;
            set
            {
                Font = value;
                if (Controls.Count > 0)
                {
                    // Apply font to parent and child controls
                    foreach (Control parentControl in Controls)
                    {
                        parentControl.Font = value;
                        if (parentControl.Controls.Count > 0)
                        {
                            foreach (Control childControl in parentControl.Controls) { childControl.Font = value; }
                        }
                    }
                }
            }
        }

        public AccordionAreaCT()
        {
            base.DoubleBuffered = true;
        }

        public string SetTheme
        {
            set
            {
                BackColor = value == "Office365Black" ? Color.Black : Color.WhiteSmoke;
                ForeColor = value == "Office365Black" ? Color.White : Color.Black;

                foreach (AccordionCT parent in Controls)
                {
                    parent.SetTheme = value;
                }
            }
        }

        public void AccordionExpanded(object sender, EventArgs e)
        {
            var mouseLocation = (e as MouseEventArgs).Location;
            int selectedAccordionIndex = (int)(sender as AccordionCT).Tag;
            CalculateNewLocation(new Point(mouseLocation.X, mouseLocation.Y + 200), selectedAccordionIndex);
        }

        private void ResetAccordionSize(int index)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (i != index)
                {
                    (Controls[i] as AccordionCT).IsExpanded = false;
                    Controls[i].Size = new Size(Controls[i].Width, 40);
                }
            }
        }

        private void CalculateNewLocation(Point mousePointerLocation, int index)
        {
            AutoScroll = false;
            ResetAccordionSize(index);

            // Relocate all Accordion parent
            for (int i = 0; i < Controls.Count; i++)
            {
                if (i > 0) Controls[i].Top = 0;
                List<int> tmpHeights = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    tmpHeights.Add(Controls[j].Height);
                }
                Controls[i].Location = new Point(10, tmpHeights.Sum());
            }
            AutoScroll = true;
        }

        public void AccordionChildClick(object sender, EventArgs e)
        {
            base.OnClick(e);
            Child_Clicked_Callback?.Invoke(sender, e);
        }

        public void AddChild(Dictionary<string, List<string>> keyValuePairs)
        {
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var element = keyValuePairs.ElementAt(i);
                var parent = new AccordionCT
                {
                    Text = element.Key,
                    Location = new Point(10, 10 + i * _generalControlHeights),
                    Tag = i,
                };
                parent.AccordionClicked += AccordionExpanded;
                parent.GeneralControlHeight = _generalControlHeights;
                parent.Size = new Size(Width - 30, 40);
                // Add child to parent
                foreach (string name in element.Value)
                {
                    var child = new AccordionChildCT
                    {
                        Text = name,
                        Tag = $"{element.Key},{name}",
                        GeneralControlHeight = _generalControlHeights,
                        Height = _generalControlHeights,
                    };
                    child.ChildClicked += AccordionChildClick;
                    child.Size = new Size(Width - 30, 40);
                    parent.AddChild(child);
                }
                Controls.Add(parent);
            }
        }

        public void AddChildren(AllSamples samples)
        {
            for (int i = 0; i < samples.Groups.Count; i++)
            {
                var parent = new AccordionCT
                {
                    Text = samples.Groups[i].Name,
                    Location = new Point(10, 10 + i * _generalControlHeights),
                    Tag = i,
                };
                parent.AccordionClicked += AccordionExpanded;
                parent.GeneralControlHeight = _generalControlHeights;
                parent.Size = new Size(Width - 30, 40);
                Console.WriteLine(samples);
                foreach (var sample in samples.Groups[i].Samples)
                {
                    var child = new AccordionChildCT()
                    {
                        Text = sample.Name,
                        Tag = sample,
                        GeneralControlHeight = _generalControlHeights,
                        Height = _generalControlHeights,
                    };
                    child.ChildClicked += AccordionChildClick;
                    child.Size = new Size(Width - 30, 40);
                    parent.AddChild(child);
                }
                Controls.Add(parent);
            }
        }
    }
}
