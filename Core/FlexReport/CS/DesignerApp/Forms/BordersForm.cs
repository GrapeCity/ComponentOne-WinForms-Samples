//----------------------------------------------------------------------------
// BordersForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.IO;

using C1.Win.Localization;
using C1.Win.Themes;

using Doc = C1.Document;
using WinDoc = C1.Win.Document;
using Flex = C1.Win.FlexReport;
using FlexDesigner = C1.Win.FlexReport;
using NSD = C1.Interop;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// Summary description for OptionsForm.
    /// </summary>
    public partial class BordersForm : System.Windows.Forms.Form
    {
        private Doc.Border _border;
        private bool _initializingWidths = false;
        // These are used to draw preview image:
        private Doc.C1Document _previewDocument;
        private Doc.RenderTextFragment _previewFragment;
        private Doc.RenderValue _previewObject;
        private Image _previewImage;

        public BordersForm()
        {
            // initialize component
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of the border form.
        /// </summary>
        /// <param name="border">The border to initialize the dialog from, or null for defaults.</param>
        public BordersForm(Doc.Border border)
            : this()
        {
            _border = border != null ? (Doc.Border)border.Clone() : new Doc.Border();

            _previewDocument = new Doc.C1Document();
            _previewDocument.CompatibilityOptions.BordersMode = Doc.BordersModeEnum.C1Report;
            _previewDocument.MeasurementUnits = Doc.UnitTypeEnum.Twip;
            Doc.RenderSection rs = new Doc.RenderSection();
            Doc.RenderSectionFragment rsf = new Doc.RenderSectionFragment(rs);
            _previewDocument.Body.Sections.Add(rs);
            _previewObject = new Doc.RenderValue();
            rs.ChildObjects.Add(_previewObject);
            _previewObject.Value = "Sample text";
            _previewObject.Style.TextAlignHorz = Doc.AlignHorzEnum.Center;
            _previewObject.Style.TextAlignVert = Doc.AlignVertEnum.Center;
            _previewFragment = new Doc.RenderValueFragment(_previewObject);
            RefreshPreviewImage();
        }

        #region object model
        public Doc.Border Border
        {
            get { return _border; }
        }
        #endregion

        #region Public static
        public class BorderWidthItem
        {
            public double Width;
            public string Text;
            public override string ToString()
            {
                return Text;
            }
        };
        public static List<BorderWidthItem> s_borderWidths = new List<BorderWidthItem>()
        {
            new BorderWidthItem() { Width = 0, Text = "Zero"},
            new BorderWidthItem() { Width = 1, Text = "Hairline"},
            // the rest is taken from MS Word's border width dropdown:
            new BorderWidthItem() { Width = 5, Text = "\u00BC pt"}, // 1/4
            new BorderWidthItem() { Width = 10, Text = "\u00BD pt"}, // 1/2
            new BorderWidthItem() { Width = 15, Text = "\u00BE pt"}, // 3/4
            new BorderWidthItem() { Width = 20, Text = "1 pt"},
            new BorderWidthItem() { Width = 30, Text = "1\u00BD pt"}, // 1 1/2
            new BorderWidthItem() { Width = 45, Text = "2\u00BC pt"}, // 2 1/4
            new BorderWidthItem() { Width = 60, Text = "3 pt"},
            new BorderWidthItem() { Width = 90, Text = "4\u00BD pt"}, // 4 1/2
            new BorderWidthItem() { Width = 120, Text = "6 pt"},
        };
        #endregion

        #region Protected
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (_previewImage != null)
            {
                _previewImage.Dispose();
                _previewImage = null;
            }
        }
        #endregion

        #region private
        private const int c_PreviewOffset = 15;
        private void RefreshPreviewImage()
        {
            if (_previewImage != null)
                _previewImage.Dispose();
            NSD.Point dpi;
            using (Graphics g = this.CreateGraphics())
                dpi = new NSD.Point(g.DpiX, g.DpiY);
            using (WinDoc.Util.C1DXGraphics graphics = new WinDoc.Util.C1DXGraphics())
            {
                // 
                NSD.Size sz = previewPanel.ClientSize;
                graphics.BeginGetImage(sz, dpi);
                graphics.FillRectangle(Color.White, new NSD.Rect(0, 0, sz.Width, sz.Height));
                NSD.Rect previewBounds = new NSD.Rect(c_PreviewOffset, c_PreviewOffset, sz.Width - c_PreviewOffset * 2, sz.Height - c_PreviewOffset * 2);
                _previewObject.Style.Borders = _border;
                _previewFragment.Draw(graphics, previewBounds, null, null);

                using (GrapeCity.Documents.Drawing.IImage image = graphics.EndGetImage(false))
                {
                    _previewImage = Image.FromStream(((Doc.IMemoryStreamProvided)image).GetData());
                }
            }
        }

        private void RefreshPreview()
        {
            RefreshPreviewImage();
            previewPanel.Invalidate();
        }

        private void InitWidths()
        {
            _initializingWidths = true;
            //
            lbWidth.Items.Clear();
            lbWidth.Items.AddRange(s_borderWidths.Skip(1).ToArray());
            lbWidth.SelectedIndex = -1;
            for (int i = 1; i < s_borderWidths.Count - 1; ++i)
            {
                var borderWidth = Border.Width.HasValue ? Border.Width.Value : 0;
                var d = Math.Abs(borderWidth - s_borderWidths[i].Width);
                if (d < (borderWidth - s_borderWidths[i - 1].Width) && d < (s_borderWidths[i + 1].Width - borderWidth))
                {
                    lbWidth.SelectedIndex = i - 1;
                    break;
                }
            }
            if (lbWidth.SelectedIndex == -1)
            {
                if (!Border.Width.HasValue || Border.Width.Value < s_borderWidths[1].Width)
                    lbWidth.SelectedIndex = 0;
                else
                    lbWidth.SelectedIndex = lbWidth.Items.Count - 1;
            }
            //
            _initializingWidths = false;
        }

        /// <summary>
        /// If we think that the user tries to have a border, make sure the style is not "none".
        /// </summary>
        private void EnsureNonEmptyLine()
        {
            if (lbStyle.SelectedIndex == 0)
                lbStyle.SelectedIndex = 1;
        }

        private void InitStyles()
        {
            lbStyle.Items.Add(Doc.DashStyle.None);
            lbStyle.Items.Add(Doc.DashStyle.Solid);
            lbStyle.Items.Add(Doc.DashStyle.Dash);
            lbStyle.Items.Add(Doc.DashStyle.Dot);
            lbStyle.Items.Add(Doc.DashStyle.DashDot);
            lbStyle.Items.Add(Doc.DashStyle.DashDotDot);
            var style = Border.Style;
            if (style != null)
                lbStyle.SelectedItem = style;
            else
                lbStyle.SelectedIndex = 1; // use solid by default
        }

        private void InitColors()
        {
            // c1ColorPicker1.Value = Border.Color;
            var color = Border.Color;
            if (color.IsEmpty || color == System.Drawing.Color.Transparent)
            {
                var lines = new List<Doc.Line>(4) { Border.Left, Border.Top, Border.Right, Border.Bottom };
                int i = lines.FindIndex(l_ => l_.Style != Doc.DashStyle.None && !l_.Color.IsEmpty && l_.Color != System.Drawing.Color.Transparent);
                if (i >= 0)
                    color = lines[i].Color;
            }
            c1ColorPicker1.Color = color;
        }

        private void InitRadiuses()
        {
            if (Border.CornerRadius.AllX.HasValue)
                numRadiusX.Value = (int)Math.Round(Border.CornerRadius.AllX.Value);
            else
                numRadiusX.Value = 0;
            if (Border.CornerRadius.AllY.HasValue)
                numRadiusY.Value = (int)Math.Round(Border.CornerRadius.AllY.Value);
            else
                numRadiusY.Value = 0;
        }

        private void InitBorderLayout()
        {
            // set border layout
            cbBorderLeft.Checked = Border.Left.Style != Doc.DashStyle.None;
            cbBorderTop.Checked = Border.Top.Style != Doc.DashStyle.None;
            cbBorderRight.Checked = Border.Right.Style != Doc.DashStyle.None;
            cbBorderBottom.Checked = Border.Bottom.Style != Doc.DashStyle.None;
            cbBorderAll.Checked = cbBorderLeft.Checked && cbBorderTop.Checked && cbBorderRight.Checked && cbBorderBottom.Checked;
            cbBorderNone.Checked = !cbBorderLeft.Checked && !cbBorderTop.Checked && !cbBorderRight.Checked && !cbBorderBottom.Checked;
        }

        private DashStyle ToDashStyle(Doc.DashStyle style)
        {
            switch (style)
            {
                case Doc.DashStyle.Solid:
                    return DashStyle.Solid;
                case Doc.DashStyle.Dash:
                    return DashStyle.Dash;
                case Doc.DashStyle.Dot:
                    return DashStyle.Dot;
                case Doc.DashStyle.DashDot:
                    return DashStyle.DashDot;
                case Doc.DashStyle.DashDotDot:
                    return DashStyle.DashDotDot;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    return DashStyle.Custom;
            }
        }

        private Doc.DashStyle GetSelectedDashStyhle()
        {
            // Border.Style = (Doc.DashStyle)lbStyle.SelectedItem;
            if (lbStyle.SelectedIndex >= 0)
                return (Doc.DashStyle)lbStyle.SelectedItem;
            else
                return Doc.DashStyle.None;
        }

        private double GetSelectedWidth()
        {
            // Border.Width = ((BorderWidthItem)lbWidth.SelectedItem).Width;
            if (lbWidth.SelectedIndex >= 0)
                return ((BorderWidthItem)lbWidth.SelectedItem).Width;
            else
                return 0;

        }
        #endregion

        #region event handlers
        private void BordersForm_Load(object sender, EventArgs e)
        {
            InitWidths();
            InitStyles();
            InitColors();
            InitRadiuses();
            InitBorderLayout();
        }

        private void lbWidth_DrawItem(object sender, DrawItemEventArgs e)
        {
            const string Sample = "Hairline"; // should be not smaller than the biggest text
            const int PadX = 4;
            const int Gap = 8; // gap between text and line
            BorderWidthItem item = (BorderWidthItem)lbWidth.Items[e.Index];
            double itemWidth = item.Width;
            string itemText = item.Text;
            using (Pen pen = new Pen(e.ForeColor, (float)((itemWidth / 1440f) * e.Graphics.DpiY)))
            using (SolidBrush bruchB = new SolidBrush(e.BackColor))
            using (SolidBrush bruchF = new SolidBrush(e.ForeColor))
            using (var sf = new StringFormat(StringFormat.GenericDefault))
            {
                var offset = e.Graphics.MeasureString(Sample, this.Font, PointF.Empty, StringFormat.GenericDefault).Width + PadX + Gap / 2;
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.FillRectangle(bruchB, e.Bounds);
                e.Graphics.DrawString(itemText, this.Font, bruchF, e.Bounds.Left + offset - Gap / 2, e.Bounds.Top + e.Bounds.Height / 2, sf);
                e.Graphics.DrawLine(pen, e.Bounds.Left + offset + Gap / 2, e.Bounds.Top + e.Bounds.Height / 2, e.Bounds.Right - PadX, e.Bounds.Top + e.Bounds.Height / 2);
            }
            e.DrawFocusRectangle();
        }

        private void lbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializingWidths)
            {
                // If user clicked on a non-0 width, and style is "none" - change it to solid.
                if (lbWidth.SelectedIndex > 0)
                    EnsureNonEmptyLine();
            }
        }

        private void lbStyle_DrawItem(object sender, DrawItemEventArgs e)
        {
            const int PadX = 4;
            const int Gap = 8; // gap between text and line
            Doc.DashStyle item = (Doc.DashStyle)lbStyle.Items[e.Index];
            if (item == Doc.DashStyle.None)
            {
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.DrawBackground();
                    e.Graphics.DrawString("(None)", this.Font, brush, e.Bounds);
                }
            }
            else
            {
                using (Pen pen = new Pen(e.ForeColor, (50 / 1440f) * e.Graphics.DpiY))
                using (SolidBrush brush = new SolidBrush(e.BackColor))
                {
                    pen.DashStyle = ToDashStyle(item);
                    e.Graphics.FillRectangle(brush, e.Bounds);
                    e.Graphics.DrawLine(pen, e.Bounds.Left + Gap / 2, e.Bounds.Top + e.Bounds.Height / 2, e.Bounds.Right - PadX, e.Bounds.Top + e.Bounds.Height / 2);
                }
            }
            e.DrawFocusRectangle();
        }

        // All and None work like regular buttons rather than checkboxes.
        private void cbBorderAll_Click(object sender, EventArgs e)
        {
            cbBorderAll.Checked = true;
            cbBorderLeft.Checked = cbBorderTop.Checked = cbBorderRight.Checked = cbBorderBottom.Checked = true;
            cbBorderNone.Checked = false;
            Border.Style = GetSelectedDashStyhle();
            Border.Width = GetSelectedWidth();
            Border.Color = c1ColorPicker1.Color;
            RefreshPreview();
        }

        private void cbBorderNone_Click(object sender, EventArgs e)
        {
            cbBorderNone.Checked = true;
            cbBorderLeft.Checked = cbBorderTop.Checked = cbBorderRight.Checked = cbBorderBottom.Checked = false;
            cbBorderAll.Checked = false;
            Border.Style = Doc.DashStyle.None;
            // setting style to none should be enough, no need to reset esp color to transparent
            // Border.Width = 0;
            // Border.Color = Color.Transparent;
            RefreshPreview();
        }

        private void cbBorder_Click(object sender, EventArgs e)
        {
            cbBorderAll.Checked = cbBorderLeft.Checked && cbBorderTop.Checked && cbBorderRight.Checked && cbBorderBottom.Checked;
            cbBorderNone.Checked = !cbBorderLeft.Checked && !cbBorderTop.Checked && !cbBorderRight.Checked && !cbBorderBottom.Checked;
            Doc.Line line = null;
            // find required line
            if (sender == cbBorderLeft)
                line = Border.Left;
            else if (sender == cbBorderTop)
                line = Border.Top;
            else if (sender == cbBorderRight)
                line = Border.Right;
            else if (sender == cbBorderBottom)
                line = Border.Bottom;
            
            if (((C1.Win.Input.C1CheckBox)sender).Checked)
            {
                line.Style = GetSelectedDashStyhle();
                line.Width = GetSelectedWidth();
                line.Color = c1ColorPicker1.Color;
            }
            else
            {
                line.Style = Doc.DashStyle.None;
                line.Width = 0;
                line.Color = Color.Transparent;
            }
            RefreshPreview();
        }

        private void previewPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Func<Rectangle, C1.Win.Input.C1CheckBox, bool> testClickBorder = (rect_, cb_) =>
            {
                if (rect_.Contains(e.X, e.Y))
                {
                    cb_.Checked = !cb_.Checked;
                    if (cb_.Checked)
                        EnsureNonEmptyLine();
                    cbBorder_Click(cb_, EventArgs.Empty);
                    return true;
                }
                return false;
            };

            System.Diagnostics.Debug.WriteLine(e.X.ToString() + " / " + e.Y.ToString());
            const int B = 16;
            if (testClickBorder(new Rectangle(0, B, B, previewPanel.Height - B * 2), cbBorderLeft))
                return;
            if (testClickBorder(new Rectangle(B, 0, previewPanel.Width - B * 2, B), cbBorderTop))
                return;
            if (testClickBorder(new Rectangle(previewPanel.Width - B, B, B, previewPanel.Height - B * 2), cbBorderRight))
                return;
            if (testClickBorder(new Rectangle(B, previewPanel.Height - B, previewPanel.Width - B * 2, B), cbBorderBottom))
                return;
            // just return :)
        }

        private void numRadiusX_ValueChanged(object sender, EventArgs e)
        {
            double y = Border.CornerRadius.AllY.HasValue ? Border.CornerRadius.AllY.Value : 0;
            Border.CornerRadius = new Doc.CornerRadius((double)(decimal)numRadiusX.Value, y);
            RefreshPreview();
        }

        private void numRadiusY_ValueChanged(object sender, EventArgs e)
        {
            double x = Border.CornerRadius.AllX.HasValue ? Border.CornerRadius.AllX.Value : 0;
            Border.CornerRadius = new Doc.CornerRadius(x, (double)(decimal)numRadiusY.Value);
            RefreshPreview();
        }

        private void previewPanel_Paint(object sender, PaintEventArgs e)
        {
            // Let's draw each of borders
            if (_previewImage == null)
                e.Graphics.FillRectangle(Brushes.White, previewPanel.ClientRectangle);
            else
                e.Graphics.DrawImage(_previewImage, 0, 0);
        }
        #endregion
    }
}
