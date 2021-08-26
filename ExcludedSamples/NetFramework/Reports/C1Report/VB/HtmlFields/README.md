## HtmlFields
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\VB\HtmlFields)
____
#### Render reports to HTML preserving HTML formatting.
____
By default, C1Report escapes the HTML output so reports look the same in the preview window as they do in HTML. For example, if a field contains text such as "<a><b><c>", that would be exported to HTML as "&lt;a&gt;&lt;b&gt;&lt;c&gt;", which the browser would show as "<a><b><c>". 

In some cases, however, you may want to export fields as raw HTML, with rich formatting. This sample accomplishes this using a custom stream class that 'unescapes' the HTML codes back into their raw format. 