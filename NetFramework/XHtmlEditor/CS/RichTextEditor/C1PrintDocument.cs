using System;
using System.Drawing;
using System.Drawing.Printing;
using C1.Win.C1Editor;

/// <summary>
/// Custom PrintDocument that knows how to render the contents of the C1Editor control.
/// </summary>
/// <remarks>
/// This class uses the C1SuperLabel to render the content of a C1Editor control into a
/// regular <see cref="PrintDocument"/> object which can in turn be used to preview, print,
/// or export the document to Pdf (using a C1Pdf component).
/// </remarks>
public class XhtmlPrintDocument : PrintDocument
{
    C1Editor _editor;
    C1.Win.C1SuperTooltip.C1SuperLabel _label;
    int _offset;

    public XhtmlPrintDocument(C1Editor editor)
    {
        _editor = editor;
    }
    protected override void OnBeginPrint(PrintEventArgs e)
    {
        _offset = 0;
        _label = new C1.Win.C1SuperTooltip.C1SuperLabel();
        _label.Text = _editor.Document.InnerXml;
        _label.Font = _editor.Font;
        _label.ForeColor = _editor.ForeColor;
    }
    protected override void OnEndPrint(PrintEventArgs e)
    {
        if (_label != null)
        {
            _label.Dispose();
            _label = null;
        }
    }
    protected override void OnPrintPage(PrintPageEventArgs e)
    {
        if (_label == null)
        {
            return;
        }
        // calculate bounds
        Rectangle rc = e.MarginBounds;
        float scale = 96f / 100f;
        RectangleF bounds = new RectangleF(
            rc.Left * scale, rc.Top * scale,
            rc.Width * scale, rc.Height * scale);

        // render from current offset
        int newOffset = _label.DrawToGraphics(e.Graphics, bounds, _offset);

        // update offset
        e.HasMorePages = newOffset != _offset && newOffset < int.MaxValue;
        _offset = newOffset;
    }
}
