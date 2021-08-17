## PdfTables
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Pdf\CS\PdfTables)
____
#### Shows how to render HTML into PDF documents.
____
The sample uses the DrawStringHtml method to render an HTML string into a document.

The HTML content spans multiple pages, so we use a loop that calls the DrawStringHtml multiple times with increasing offsets, 
until the method returns int.MaxValue which indicates the whole string has been rendered. The code looks like this:

```
    // start with an empty document
    _pdf.Clear();

	// calculate page rectangle (with 1-inch margins)
    var rcPage = _pdf.PageRectangle;
    rcPage.Inflate(-72, -72);

    // render the html content
    for (int offset = 0; offset < int.MaxValue;  )
    {
        if (offset > 0)
        {
			// this is not the first page, so insert break
            _pdf.NewPage();
        }

		// render as much HMTL as will fit the rectangle
        offset = _pdf.DrawStringHtml(_html, this.Font, Brushes.Black, rcPage, offset);
    }
                        
    // save the pdf file
    var fn = Path.Combine(Application.StartupPath, "html.pdf");
    this._pdf.Save(fn);

    // and show it
    System.Diagnostics.Process.Start(fn);
```