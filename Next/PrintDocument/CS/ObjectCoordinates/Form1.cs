using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace ObjectCoordinates
{
    public partial class Form1 : Form
    {
        private RenderObject _roUnderMouse = null;
        private Pen _hilitePen = null;

        public Form1()
        {
            InitializeComponent();

            // set up a pen for hiliting
            Brush b = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Red,
                Color.FromArgb(128, Color.Yellow));
            _hilitePen = new Pen(b, 4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // make a demo C1PrintDocument; a "real" document can be loaded
            // via the File Open button.
            C1PrintDocument doc = new C1PrintDocument();
            doc.PageLayout.PageHeader = new RenderText("Page [PageNo] of [PageCount]");
            doc.PageLayout.PageHeader.Style.TextAlignHorz = AlignHorzEnum.Right;
            doc.PageLayout.PageHeader.Style.TextAlignVert = AlignVertEnum.Top;
            doc.PageLayout.PageHeader.Height = "1cm";
            RenderText title = new RenderText("This is just a sample; load any C1PrintDocument from a C1D file");
            title.Style.Font = new Font("Arial", 16);
            title.Style.TextAlignHorz = AlignHorzEnum.Center;
            title.Style.Padding.All = "5mm";
            doc.Body.Children.Add(title);
            RenderTable rt = new RenderTable();
            rt.Style.GridLines.All = LineDef.Default;
            for (int row = 0; row < 100; ++row)
                for (int col = 0; col < 4; ++col)
                    rt.Cells[row, col].Text = string.Format("cell ({0},{1})", row, col);
            doc.Body.Children.Add(rt);
            c1PrintPreviewControl1.Document = doc;
        }

        // On mouse move, we try to find the render object under the mouse.
        // In case of success we cache the reference to that render object
        // in the _roUnderMouse var, which is used in Paint handler to high-light
        // that object. Also, we list info about that object in the list box.
        private void c1PrintPreviewControl1_PreviewPane_MouseMove(object sender, MouseEventArgs e)
        {
            C1PreviewPane pane = (C1PreviewPane)sender;
            // this is the point in C1PreviewPane's client coords:
            Point previewPanelP = new Point(e.X, e.Y);
            int pageIdx;
            PointF docP;
            // convert to document coords, which are pixels which have also been:
            // - scaled by the preview zoom factor, and
            // - related to the document page (top left corner of the page is (0,0)).
            pane.ClientToDocument(previewPanelP, out pageIdx, out docP);
            // further processing if the mouse is over a point on a document page:
            if (pageIdx >= 0)
            {
                // clear the list box of old stuff
                if ((listBox1.Items.Count + 1) * listBox1.ItemHeight > listBox1.ClientSize.Height)
                    listBox1.Items.RemoveAt(0);

                // find the RenderObject under the mouse
                RenderObject ro = FindRenderObject(pane.Document, pageIdx, docP, pane.DpiX, pane.DpiY);
                if (ro != _roUnderMouse)
                {
                    // print info in the list box
                    listBox1.Items.Add(string.Format("pageIdx: {0}, pos: {1}. Client: {2}. RO: {3}", pageIdx, docP, previewPanelP,
                        (ro == null ? (object)"<none>" : ro)));
                    // cache the render object (so that it is highlighted in the Paint handler)
                    _roUnderMouse = ro;
                    // force repaint for the highlight to show
                    // (TODO: optimize by invalidating only the areas under the ro's fragments)
                    pane.Invalidate();
                }
            }
        }

        // highlight the render object under the mouse, if any
        private void c1PrintPreviewControl1_PreviewPane_Paint(object sender, PaintEventArgs e)
        {
            if (_roUnderMouse == null)
                return;
            C1PreviewPane pane = c1PrintPreviewControl1.PreviewPane;
            // paint red rectangles over all fragments of the render object
            foreach (RenderFragment rf in _roUnderMouse.Fragments)
            {
                RectangleD rd = rf.BoundsOnPage;
                // FromRU converts from "resolved units" (units in which fragment's bounds are
                // expressed) to any desired unit - in our case, we convert to pixels
                RectangleD rpreview = _roUnderMouse.Document.FromRU(rd, UnitTypeEnum.Pixel, pane.DpiX, pane.DpiY);
                // but because the document does not know anything about the preview's zoom
                // or offset of pages in the preview, we convert "document pixels" to preview ones:
                RectangleF rectf = pane.DocumentToClient(rf.PageIndex, rpreview.ToRectangleF());
                // finally, highlight the rectangle in the preview pane:
                e.Graphics.DrawRectangle(_hilitePen, rectf.X, rectf.Y, rectf.Width, rectf.Height);
            }
        }

        // finds the render object given the document, page index, point in the page
        // (in pixels), and resolution for those pixels.
        private RenderObject FindRenderObject(object document, int pageIdx,
            PointF pt, float dpix, float dpiy)
        {
            C1PrintDocument doc = document as C1PrintDocument;
            if (doc != null)
                return FindRenderObject(doc.Pages[pageIdx].Fragments, pt, dpix, dpiy);
            else
                return null;
        }

        // finds the render object in the fragments' collection
        // (the innermost render object containing the point is found)
        private RenderObject FindRenderObject(RenderFragmentCollection frags,
            PointF pt, float dpix, float dpiy)
        {
            foreach (RenderFragment rf in frags)
            {
                RectangleD rd = rf.Document.FromRU(rf.Bounds, UnitTypeEnum.Pixel, dpix, dpiy);
                RectangleF rrf = new RectangleF((float)rd.X, (float)rd.Y, (float)rd.Width, (float)rd.Height);
                if (rrf.Contains(pt))
                {
                    if (rf.RenderObject.Children.Count > 0)
                    {
                        // try to go deeper
                        pt.X -= (float)rd.Left;
                        pt.Y -= (float)rd.Top;
                        RenderObject child = FindRenderObject(rf.Children, pt, dpix, dpiy);
                        if (child != null)
                            return child;
                    }
                    return rf.RenderObject;
                }
            }
            return null;
        }

        // "high-level" method, finds the render object under the screen point
        private RenderObject FindRoUnderScreenPoint(Point screenPt)
        {
            C1PreviewPane pane = c1PrintPreviewControl1.PreviewPane;
            if (!(pane.Document is C1PrintDocument))
                return null;
            Point clientP = pane.PointToClient(screenPt);
            int pageIdx;
            PointF docP;
            pane.ClientToDocument(clientP, out pageIdx, out docP);
            if (pageIdx >= 0)
                return FindRenderObject((C1PrintDocument)pane.Document, pageIdx, docP, pane.DpiX, pane.DpiY);
            else
                return null;
        }

        // re-generates the document keeping the current preview position
        private void RegenerateDocument(C1PrintDocument doc)
        {
            // NOTE the use of C1PreviewPane.LayoutSection - it will prevent flickering
            // and make redisplay smoother.
            using (new C1PreviewPane.LayoutSection(c1PrintPreviewControl1.PreviewPane, HistorySavedActionsEnum.None))
            {
                PointF pos = c1PrintPreviewControl1.PreviewPane.PreviewScrollPosition;
                doc.Generate();
                c1PrintPreviewControl1.PreviewPane.PreviewScrollPosition = pos;
            }
        }

        // context menu to show for the render object under the mouse
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            RenderObject ro = FindRoUnderScreenPoint(MousePosition);
            if (ro == null)
            {
                e.Cancel = true;
                return;
            }
            showRoProperties.Tag = ro;
            colorizeRo.Tag = ro;
            setRoText.Enabled = ro is RenderText;
            if (setRoText.Enabled)
            {
                setRoText.Text = ((RenderText)ro).Text;
                setRoText.Tag = ro;
            }
            else
            {
                setRoText.Text = "<not a RenderText>";
                setRoText.Tag = null;
            }
        }

        // show the properties of the selected object,
        // attach a handler to reflow the document on a property change
        private void showRoProperties_Click(object sender, EventArgs e)
        {
            RenderObject ro = ((ToolStripItem)sender).Tag as RenderObject;
            if (ro == null)
                return;
            RoProps props = new RoProps();
            props.PropertyGrid.SelectedObject = ro;
            props.PropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(PropertyGrid_PropertyValueChanged);
            props.Show();
        }

        // on a property change of a render object, we re-generate the document.
        // NOTE: this really is not a completely supported/valid action, as the 
        // property grid may allow changes to render object properties that are
        // invalid. DO NOT USE THIS CODE IN A PRODUCTION SOFTWARE!
        void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            RenderObject ro = ((PropertyGrid)s).SelectedObject as RenderObject;
            if (ro != null)
                RegenerateDocument(ro.Document);
        }

        // change the background color of a render object,
        // and regenerate the document.
        private void colorizeRo_Click(object sender, EventArgs e)
        {
            RenderObject ro = ((ToolStripItem)sender).Tag as RenderObject;
            if (ro == null)
                return;
            ColorDialog cd = new ColorDialog();
            cd.Color = ro.Style.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                ro.Style.BackColor = cd.Color;
                RegenerateDocument(ro.Document);
            }
        }

        private void setRoText_Validated(object sender, EventArgs e)
        {
            RenderText rt = ((ToolStripItem)sender).Tag as RenderText;
            if (rt == null)
                return;
            contextMenuStrip1.Hide();
            rt.Text = setRoText.Text;
            RegenerateDocument(rt.Document);
        }

        private void setRoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                setRoText_Validated(sender, EventArgs.Empty);
            }
        }

        private void setRoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                e.Handled = true;
        }
    }
}