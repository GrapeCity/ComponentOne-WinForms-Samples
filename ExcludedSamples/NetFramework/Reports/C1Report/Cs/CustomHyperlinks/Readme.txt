CustomHyperlinks
-----------------------------------------------------------------------------
Perform custom actions when report hyperlinks are clicked.

C1Report allows you to add hyperlinks to reports using the Field.LinkTarget
property. The links normally navigate to other documents, and work in 
web browsers and pdf viewers.

If you are previewing the report with the C1Preview control, you can use
the HyperlinkJump event to handle clicks on the hyperlinks and perform
custom actions instead of the standard navigation. For example, clicking
on a product name could bring up a form with product details.