using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace PdfAnnotations
{
    using C1.Pdf;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btCreate_Click(object sender, EventArgs e)
        {
            // create pdf document
            _c1pdf.Clear();
            _c1pdf.FontType = PdfFontType.Embedded;
            _c1pdf.DocumentInfo.Title = "PDF Annotations";
            _statusBar.Text = "Creating pdf document...";

            // calculate page rect (discounting margins)
            RectangleF rcPage = GetPageRect();
            RectangleF rc = rcPage;

            // add title
            Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
            titleFont = new Font("Times New Roman", 22, FontStyle.Italic | FontStyle.Bold);

            rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);
            rc = rcPage;

            //-----------------------------------------------
            // annotations
            RectangleF squareRc = new RectangleF(rc.X, rc.Y + rc.Height / 10, rc.Width / 3, rc.Height / 30);

             // rectangle note
            PdfSquareNote squareNote = new PdfSquareNote();
            squareNote.Contents = "Japanese text";
            squareNote.FillColor = Color.Yellow;
            squareNote.Thickness = 2;
            squareNote.Opacity = 55f;
            squareNote.PopupOpen = true;

            // add
            _c1pdf.AddNote(squareNote, squareRc);

            squareRc = new RectangleF(rc.X, rc.Y + rc.Height / 5, rc.Width / 3, rc.Height / 10);

            // circle note
            PdfCircleNote circleNote = new PdfCircleNote();
            circleNote.Contents = "Next text";
            circleNote.FillColor = Color.Teal;
            circleNote.Opacity = 25.78f;

            // add
            _c1pdf.AddNote(circleNote, squareRc);

            // line note
            PdfLineNote lineNote = new PdfLineNote(new PointF(rc.X, rc.Y + rc.Height / 3), new PointF(rc.X + rc.Width / 3, rc.Y + rc.Height / 3));
            lineNote.Contents = "Line text";
            lineNote.Thickness = 3;

            // add
            _c1pdf.AddNote(lineNote, lineNote.Rectangle);

            // text note
            RectangleF textRc = new RectangleF(rc.X, rc.Y + rc.Height / 2, rc.Width / 3, rc.Height / 30);

            // circle note
            PdfTextNote textNote = new PdfTextNote();
            textNote.Contents = "Simple text";
            textNote.Opacity = 44;

            // add
            _c1pdf.AddNote(textNote, textRc);

            // next page
            _c1pdf.NewPage();

            // line note
            lineNote = new PdfLineNote(new PointF(rc.X, rc.Y + rc.Height / 10), new PointF(rc.X + rc.Width / 2, rc.Y + rc.Height / 7));
            lineNote.Contents = "Line annotation";
            lineNote.Opacity = 33;
            lineNote.Thickness = 7;
            lineNote.PopupOpen = true;

            // add
            _c1pdf.AddNote(lineNote, lineNote.Rectangle);

            // text for next page
            rc = rcPage;
            RenderParagraph("Second page with annotation", titleFont, rcPage, rc, false);

            // second pass to number pages
            AddFooters();

            // save to file and show it
            _statusBar.Text = "Saving pdf document...";
            string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\nwind.pdf";
            _c1pdf.Compression = CompressionLevel.NoCompression;
            _c1pdf.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        // get the current page rectangle (depends on paper size)
        // and apply a 1" margin all around it.
        internal RectangleF GetPageRect()
        {
            RectangleF rcPage = _c1pdf.PageRectangle;
            rcPage.Inflate(-72, -72);
            return rcPage;
        }


        // measure a paragraph, skip a page if it won't fit, render it into a rectangle,
        // and update the rectangle for the next paragraph.
        // 
        // optionally mark the paragraph as an outline entry and as a link target.
        //
        // this routine will not break a paragraph across pages. for that, see the Text Flow sample.
        //
        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline, bool linkTarget)
        {
            // if it won't fit this page, do a page break
            rc.Height = _c1pdf.MeasureString(text, font, rc.Width).Height;
            if (rc.Bottom > rcPage.Bottom)
            {
                _c1pdf.NewPage();
                rc.Y = rcPage.Top;
            }

            // draw the string
            _c1pdf.DrawString(text, font, Brushes.Black, rc);

            // show bounds (mainly to check word wrapping)
            //_c1pdf.DrawRectangle(Pens.Sienna, rc);

            // add headings to outline
            if (outline)
            {
                _c1pdf.DrawLine(Pens.Black, rc.X, rc.Y, rc.Right, rc.Y);
                _c1pdf.AddBookmark(text, 0, rc.Y);
            }

            // add link target
            if (linkTarget)
            {
                _c1pdf.AddTarget(text, rc);
            }

            // update rectangle for next time
            rc.Offset(0, rc.Height);
            return rc;
        }
        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline)
        {
            return RenderParagraph(text, font, rcPage, rc, outline, false);
        }
        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc)
        {
            return RenderParagraph(text, font, rcPage, rc, false, false);
        }

        //================================================================================
        // add page footers to a document
        //
        // this method is called by all samples in this project. it scans the document
        // and adds a 'page n of m' footer to each page. the footers are rendered as 
        // vertical text along the right edge of the document.
        //
        // adding content to an existing page is easy: just set the CurrentPage property
        // to point to an existing page and write into it as usual.
        //
        private void AddFooters()
        {
            Font fontHorz = new Font("Tahoma", 7, FontStyle.Bold);
            Font fontVert = new Font("Viner Hand ITC", 14, FontStyle.Bold);

            StringFormat sfRight = new StringFormat();
            sfRight.Alignment = StringAlignment.Far;

            StringFormat sfVert = new StringFormat();
            sfVert.FormatFlags |= StringFormatFlags.DirectionVertical;
            sfVert.Alignment = StringAlignment.Center;

            for (int page = 0; page < _c1pdf.Pages.Count; page++)
            {
                // select page we want (could change PageSize)
                _c1pdf.CurrentPage = page;

                // build rectangles for rendering text
                RectangleF rcPage = GetPageRect();
                RectangleF rcFooter = rcPage;
                rcFooter.Y = rcFooter.Bottom + 6;
                rcFooter.Height = 12;
                RectangleF rcVert = rcPage;
                rcVert.X = rcPage.Right + 6;

                // add left-aligned footer
                string text = _c1pdf.DocumentInfo.Title;
                _c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter);

                // add right-aligned footer
                text = string.Format("Page {0} of {1}", page + 1, _c1pdf.Pages.Count);
                _c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter, sfRight);

                // add vertical text
                text = _c1pdf.DocumentInfo.Title + " (document created using the C1Pdf .NET component)";
                _c1pdf.DrawString(text, fontVert, Brushes.LightGray, rcVert, sfVert);

                // draw lines on bottom and right of the page
                _c1pdf.DrawLine(Pens.Gray, rcPage.Left, rcPage.Bottom, rcPage.Right, rcPage.Bottom);
                _c1pdf.DrawLine(Pens.Gray, rcPage.Right, rcPage.Top, rcPage.Right, rcPage.Bottom);
            }
        }

        /// <summary>
        /// Gets embedded resource by the file name.
        /// </summary>
        /// <param name="resourceName">The file on embedded resources.</param>
        /// <returns>The stream with embedded resource or null.</returns>
        public static Stream GetManifestResource(string resourceName)
        {
            return GetManifestResource(Assembly.GetExecutingAssembly(), resourceName);
        }
        /// <summary>
        /// Gets embedded resource by the file name.
        /// </summary>
        /// <param name="a">The calling <see cref="Assembly"/>.</param>
        /// <param name="resourceName">The file on embedded resources.</param>
        /// <returns>The stream with embedded resource or null.</returns>
        public static Stream GetManifestResource(Assembly a, string resourceName)
        {
            // search resource in embedded resources
            try
            {
                foreach (string res in a.GetManifestResourceNames())
                {
                    if (res.EndsWith(resourceName))
                    {
                        return a.GetManifestResourceStream(res);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            // done
            return null;
        }
    }
}