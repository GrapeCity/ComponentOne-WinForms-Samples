## SearchText
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Next\C1.Win.Document\CS\SearchText)
____
#### Demonstrates how C1TextSearchManager can be used to search for a text in a PDF file without a viewer.
____
The sample shows a dialog allowing the user to select an arbitrary PDF file from their system,
which is loaded into a C1PdfDocumentSource instance maintained by the dialog form.
The form also creates an instance of the C1TextSearchManager class to perform searches.

When a PDF file is selected, the user can enter a text to search for, and specify search options (whole word search, case sensitivity).
When the user hits the "Find" button, the FindStartAsync method on the C1TextSearchManager is called to start the search in a background worker thread.
Event handlers on the C1TextSearchManager are used to update the UI while the search is running.
