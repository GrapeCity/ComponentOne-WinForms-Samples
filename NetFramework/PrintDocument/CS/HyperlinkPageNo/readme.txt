HyperlinkPageNo
------------------------------------------------
Demonstrates the use of HyperlinkPageNo script tag.

In the generated document, the HyperlinkPageNo script tag is replaced with the number of the hyperlink's target page.
For example, the following code will generate a hyperlink with the text "Goto page 8." provided the target object (rtTarget) appears on page 8 in the generated document:

<code>
C1PrintDocument doc = new C1PrintDocument();
...
RenderText rtTarget = new RenderText("Hyperlink target.");
doc.Body.Children.Add(rtTarget);
...
rtLink = new RenderText("Goto page [HyperlinkPageNo].");
rtLink.Hyperlink = new C1Hyperlink(new C1LinkTargetDocumentLocation(rtTarget));
doc.Body.Children.Add(rtLink);
</code>

HyperlinkPageNo script tag is especially useful in tables of contents (see RenderToc class in the documentation) but it may be used in other contexts as well.