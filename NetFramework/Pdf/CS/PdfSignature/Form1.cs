using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.Security.Permissions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace PdfSignature
{
    using C1.C1Pdf;

    public partial class Form1 : Form
    {
        private X509Certificate _certificate;

        public Form1()
        {
            InitializeComponent();
            UpdateState();

            _lbInfo.Text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "C1PdfTest.pfx");
            _tbPassword.Text = "pdftest";
        }

        private void UpdateState()
        {
            _lbCreate.Enabled = _btCreate.Enabled = (_certificate != null);
        }

        private void _tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(_lbInfo.Text) && _rtbCertificate.Text == string.Empty)
            {
                try
                {
                    _certificate = new X509Certificate2(_lbInfo.Text, _tbPassword.Text, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet);
                    _rtbCertificate.Text = _certificate.ToString();
                    UpdateState();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    _rtbCertificate.Text = string.Empty;
                    _certificate = null;
                }
            }
        }
        private void _btOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = @".pfx";
                dlg.FileName = @"*.pfx";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _lbInfo.Text = dlg.FileName;
                    try
                    {
                        _certificate = new X509Certificate2(_lbInfo.Text);
                        _rtbCertificate.Text = _certificate.ToString();
                    }
                    catch (CryptographicException cex)
                    {
                        Debug.WriteLine(cex.ToString());
                        _rtbCertificate.Text = string.Empty;
                        _certificate = null;
                        if (_tbPassword.Text != string.Empty)
                        {
                            try
                            {
                                _certificate = new X509Certificate2(_lbInfo.Text, _tbPassword.Text);
                                _rtbCertificate.Text = _certificate.ToString();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.ToString());
                                _rtbCertificate.Text = string.Empty;
                                _certificate = null;
                            }
                        }
                    }
                }
            }

            UpdateState();
        }
        private void _btCreate_Click(object sender, EventArgs e)
        {
            // create pdf document
            _c1pdf.Clear();
            _c1pdf.FontType = FontTypeEnum.Embedded;
            _c1pdf.DocumentInfo.Title = "PDF digital signature";
            _statusBar.Text = "Creating pdf document...";

            // calculate page rectangle (discounting margins)
            RectangleF rcPage = GetPageRect();
            RectangleF rc = rcPage;

            // add title
            Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
            titleFont = new Font("Times New Roman", 22, FontStyle.Italic | FontStyle.Bold);

            rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);
            rc = rcPage;

            // load image
            Image img = Image.FromStream(GetManifestResource("c1logo.png"));

            // signature
            PdfSignature signature = new PdfSignature();
            signature.Reason = "Test";
            signature.Certificate = _certificate as X509Certificate2;
            signature.Visibility = FieldVisibility.Visible;
            signature.Handler = SignatureHandler.PPKLite;
            if (_rbImage.Checked)
            {
                signature.BorderWidth = FieldBorderWidth.Thin;
                signature.BorderColor = Color.Gray;
                signature.BackColor = Color.DarkGray;
                signature.Image = img;
            }
            else
            {
                signature.BorderWidth = FieldBorderWidth.Medium;
                signature.BorderColor = Color.Blue;
                signature.BackColor = Color.White;
                signature.Text = "ComponentOne" + Environment.NewLine + "Signature field of C1Pdf";
                signature.Font = new Font("Tahoma", 14, FontStyle.Italic | FontStyle.Bold);
            }
            _c1pdf.AddField(signature, new RectangleF(100, rc.Height - 100, 200, 50));

            // next page
            _c1pdf.NewPage();

            // text for next page
            rc = rcPage;
            RenderParagraph("Second page", titleFont, rcPage, rc, false);

            // second pass to number pages
            AddFooters();

            // save to file and show it
            _statusBar.Text = "Saving pdf document...";
            string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\nwind.pdf";
            _c1pdf.Compression = CompressionEnum.None;
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