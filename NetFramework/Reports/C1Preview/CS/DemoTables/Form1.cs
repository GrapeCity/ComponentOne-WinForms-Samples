using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace DemoTables
{
    public partial class Form1 : Form
    {
        private Progress _progress = new Progress();
        private TextEdit _textEditor = new TextEdit();

        public Form1()
        {
            InitializeComponent();
            c1PrintPreviewControl1.PreviewPane.ZoomFactor = 1;
            c1PrintPreviewControl1.PreviewPane.MouseDown += new MouseEventHandler(PreviewPane_MouseDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.None;
            C1.C1Preview.C1PrintDocument d = makeDoc1();
            //d.Generate();
            //d.ViewDoc();
            c1PrintPreviewControl1.Document = d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.None;
            c1PrintPreviewControl1.Document = makeDoc_TableStyles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.All;
            c1PrintPreviewControl1.Document = makeDoc_WideTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.None;
            c1PrintPreviewControl1.Document = makeDoc_TextStyles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QueryCount qc = new QueryCount();
            if (qc.ShowDialog() == DialogResult.OK)
            {
                c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.None;

                C1.C1Preview.C1PrintDocument doc = makeDoc_LargeTable((int)qc.nRows.Value, (int)qc.nCols.Value);
                doc.LongOperation += new LongOperationEventHandler(doc_LongOperation);
                // _progress
                _progress.Show();
                doc_LongOperation(this, new LongOperationEventArgs(0));
                doc.Generate();
                _progress.Hide();
                doc.LongOperation -= new LongOperationEventHandler(doc_LongOperation);
                c1PrintPreviewControl1.Document = doc;
            }
        }

        void doc_LongOperation(object sender, LongOperationEventArgs e)
        {
            _progress.label1.Text = string.Format("Complete: {0:P}", e.Complete);
            Application.DoEvents();
        }

        void PreviewPane_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            C1PrintDocument doc = ((C1PreviewPane)sender).Document as C1PrintDocument;
            if (doc == null)
                return;
            Point pt = new Point(e.X, e.Y);
            int pageIdx;
            PointF pDoc;
            if (!((C1PreviewPane)sender).ClientToDocument(pt, out pageIdx, out pDoc))
                return;
            if (!doc.Pages[pageIdx].HasFragments)
                return;

            RenderText rt = FindRenderText(doc.Pages[pageIdx].Fragments, pDoc,
                ((C1PreviewPane)sender).DpiX, ((C1PreviewPane)sender).DpiY);
            if (rt != null)
            {
                _textEditor.textBox1.Text = rt.Text;
                _textEditor.Location = ((C1PreviewPane)sender).PointToScreen(pt);
                if (_textEditor.ShowDialog(this) == DialogResult.OK)
                {
                    rt.Text = _textEditor.textBox1.Text;
                    doc.Reflow();
                }
            }
        }

        private RenderText FindRenderText(RenderFragmentCollection frags, PointF pt, float dpix, float dpiy)
        {
            foreach (RenderFragment rf in frags)
            {
                RectangleD rd = rf.Document.FromRU(rf.Bounds, UnitTypeEnum.Pixel, dpix, dpiy);
                RectangleF rrf = new RectangleF((float)rd.X, (float)rd.Y, (float)rd.Width, (float)rd.Height);
                if (rrf.Contains(pt))
                {
                    if (rf.RenderObject is RenderText)
                        return rf.RenderObject as RenderText;
                    else
                    {
                        pt.X -= (float)rd.Left;
                        pt.Y -= (float)rd.Top;
                        return FindRenderText(rf.Children, pt, dpix, dpiy);
                    }
                }
            }
            return null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PropGrid props = new PropGrid(this);
            props.propertyGrid1.SelectedObject = c1PrintPreviewControl1;
            props.Show();
        }
 
        private void button6_Click(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.None;
            c1PrintPreviewControl1.Document = makeDoc_TableBorders();
        }
    }
}