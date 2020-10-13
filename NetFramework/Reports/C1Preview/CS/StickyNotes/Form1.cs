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

namespace StickyNotes
{
    public partial class Form1 : Form
    {
        private RenderObject _roUnderMouse = null;
        private Pen _hilitePen = null;
        private const string c_stickyNoteUserData = "__sticky_note__"; // any unique string will do

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
            if (!pane.Focused)
                return;

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
                miShowRoProperties.Enabled = false;
                miColorizeRo.Enabled = false;
                miSetRoText.Enabled = false;
                miStickyNoteRo.Enabled = false;
            }
            else
            {
                miShowRoProperties.Tag = ro;
                miColorizeRo.Tag = ro;
                miSetRoText.Enabled = ro is RenderText;
                if (miSetRoText.Enabled)
                {
                    miSetRoText.Text = ((RenderText)ro).Text;
                    miSetRoText.Tag = ro;
                }
                else
                {
                    miSetRoText.Text = "<not a RenderText>";
                    miSetRoText.Tag = null;
                }
                // Sticky notes: we do not add notes to notes.
                // Additionally, we do not add notes to multi-fragment objects as currently
                // there's no way to anchor the note's position to a particular fragment.
                // (This feature will be added in a future version.)
                string testUserData = ro.UserData as string;
                if (testUserData == c_stickyNoteUserData || ro.Fragments.Count > 1)
                    miStickyNoteRo.Enabled = false;
                else
                {
                    miStickyNoteRo.Enabled = true;
                    miStickyNoteRo.Tag = ro;
                }
            }
        }

        // show the properties of the selected object,
        // attach a handler to reflow the document on a property change
        private void miShowRoProperties_Click(object sender, EventArgs e)
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
        private void miColorizeRo_Click(object sender, EventArgs e)
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

        private void miSetRoText_Validated(object sender, EventArgs e)
        {
            RenderText rt = ((ToolStripItem)sender).Tag as RenderText;
            if (rt == null)
                return;
            contextMenuStrip1.Hide();
            rt.Text = miSetRoText.Text;
            RegenerateDocument(rt.Document);
        }

        private void miSetRoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                miSetRoText_Validated(sender, EventArgs.Empty);
            }
        }

        private void miSetRoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                e.Handled = true;
        }

        /// <summary>
        /// If the passed object has a name, just returns it.
        /// If it does not have a name, assigns a unique name to it and returns the new name.
        /// </summary>
        /// <param name="target">The object to check/assign a name to.</param>
        /// <returns>The object's name.</returns>
        private string NameObject(RenderObject target)
        {
            if (!string.IsNullOrEmpty(target.Name))
                return target.Name;

            Random rnd = new Random();
            while (true)
            {
                string name = string.Format("_snote_{0}", rnd.Next());
                if (target.Document.Body.Children.FindByName(name) == null)
                {
                    target.Name = name;
                    return name;
                }
            }
        }

        private void miStickyNoteRo_Click(object sender, EventArgs e)
        {
            RenderObject ro = ((ToolStripItem)sender).Tag as RenderObject;
            if (ro == null || ro is RenderTable)
                return;
            // Do NOT add notes to notes:
            string testUserData = ro.UserData as string;
            if (testUserData == c_stickyNoteUserData)
                return;

            TextBox tb = new TextBox();
            tb.Multiline = true;
            C1PreviewPane pane = c1PrintPreviewControl1.PreviewPane;
            RectangleD rd = ro.FirstFragment.BoundsOnPage;
            RectangleD rpreview = _roUnderMouse.Document.FromRU(rd, UnitTypeEnum.Pixel, pane.DpiX, pane.DpiY);
            RectangleF rectf = pane.DocumentToClient(ro.FirstFragment.PageIndex, rpreview.ToRectangleF());
            // show note input box to the right/below the render object:
            Point p = new Point((int)rectf.Right, (int)rectf.Bottom);
            // switch to form coordinates:
            p = pane.PointToScreen(p);
            p = this.PointToClient(p);
            tb.Location = p;
            tb.Width = 200;
            tb.Height = 40;
            tb.BackColor = Color.Yellow;
            this.Controls.Add(tb);
            tb.BringToFront();
            tb.Focus();
            tb.KeyDown += (ss, ee) =>
            {
                if (ee.KeyCode == Keys.Escape)
                {
                    this.Controls.Remove(tb);
                }
                if (ee.KeyCode == Keys.Enter && ee.Modifiers == Keys.None)
                {
                    ee.Handled = true;
                    this.ValidateChildren();
                    pane.Focus();
                }
            };

            tb.Validated += (ss, ee) =>
            {
                AddStickyNote(ro, tb.Text);

                // remove textbox:
                this.Controls.Remove(tb);

                // Done - update document:
                RegenerateDocument(ro.Document);
            };
        }

        private void miHideShowStickyNotes_Click(object sender, EventArgs e)
        {
            C1PrintDocument doc = c1PrintPreviewControl1.Document as C1PrintDocument;
            if (doc == null)
                return;

            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            foreach (RenderObject ro in doc.Body.Children)
                if ((ro.UserData as string) == c_stickyNoteUserData)
                    ro.Visibility = mi.Checked ? VisibilityEnum.Visible : VisibilityEnum.Hidden;

            RegenerateDocument(doc);
        }

        /// <summary>
        /// Attaches a sticky note to a render object.
        /// The note is floating text box like a callout, placed below and to the right
        /// of the render object being annotated.
        /// </summary>
        /// <param name="ro">The render object to annotate.</param>
        /// <param name="annotation">The note text.</param>
        private void AddStickyNote(RenderObject ro, string noteText)
        {
            // We do not annotate notes, and currently we cannot annotate objects
            // with multiple fragments as there is no mechanism yet to anchor the note
            // near a specific fragment:
            if (ro == null || (ro.UserData as string) == c_stickyNoteUserData || ro.Fragments.Count > 1)
                return;

            RenderText noteRo = new RenderText(noteText);
            // Set up annotation styles:
            noteRo.Style.Padding.All = "0.8mm";
            noteRo.Style.Font = new Font("Arial", 8);
            noteRo.Style.BackColor = Color.Yellow;
            noteRo.Style.Borders.All = new LineDef("1pt", Color.SteelBlue);
            noteRo.Style.Borders.RadiusX = noteRo.Style.Borders.RadiusY = "1.6mm";
            //noteRo.Clip = false;
            // Position relative to the object being annotated:
            string noteName = NameObject(ro);
            noteRo.X = string.Format("{0}.right + 5mm", noteName);
            noteRo.Y = string.Format("{0}.bottom", noteName);
            noteRo.Style.Shadow.Transparency = 50;
            noteRo.Width = "Min(auto, 40mm)";
            noteRo.Height = "auto";
            // add a line from the object being annotated to the note:
            RenderLine line = new RenderLine();
            line.X = string.Format("{0}.right", noteName);
            line.Y = string.Format("{0}.top + {0}.height/2", noteName);
            line.Height = string.Format("prev.height/2 + {0}.height/2", noteName);
            line.Width = string.Format("prev.left - {0}.right", noteName);
            line.Line.X1 = 0;
            line.Line.Y1 = 0;
            line.Line.X2 = "width";
            line.Line.Y2 = "height";
            line.Style.ShapeLine = new LineDef("1pt", Color.SteelBlue);

            // paint annotated object's background:
            ro.Style.BackColor = Color.FromArgb(70, Color.SteelBlue);

            // Draw annotation over everything else:
            noteRo.ZOrder = 100;
            line.ZOrder = 100;

            // mark annotations as such:
            noteRo.UserData = c_stickyNoteUserData;
            line.UserData = c_stickyNoteUserData;

            // add to document body:
            ro.Document.Body.Children.Add(noteRo);
            ro.Document.Body.Children.Add(line);
        }
    }
}
