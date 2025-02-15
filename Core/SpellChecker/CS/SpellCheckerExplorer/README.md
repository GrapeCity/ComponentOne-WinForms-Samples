## SpellCheckerExplorer
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Core\SpellChecker\CS\SpellCheckerExplorer)
____
#### Shows all the features of SpellChecker control.
____
SpellCheckerExplorer is the single source for you to learn about SpellChecker. 
It shows all the features of SpellChecker in an easy to explore hierarchy.

Included samples:


* QuickStart.
  Shows how to use the C1SpellChecker component to check different types of control. 
  The sample has tabs that select the type of control to spell-check: regular TextBox, RichTextBox, or C1FlexGrid. 
  The textboxes have built-in support for as-you-type as well as modal spell-checking.
  The C1FlexGrid shows how to implement modal spell-checking on arbitrary controls by implementing the ISpellCheckableEditor interface.

* WebBrowserSpell.
  C1SpellChecker supports controls based on the WebBrowser class.
  The support includes underlining errors with red-wavy underlines as you type, with suggestions in context-sensitive menus, and also the dialog-based modal spell-check.

* CustomParser.
  Shows how to implement a custom spell-checking parser class.
  The C1SpellChecker control uses a built-in parser to break up text into words that are then spell-checked.
  The built-in parser handles plain text and also common formats such as Html and Xml.
  It can be configured using the Options.Ignore property.
  If you need to check text that is formatted according to special rules (a c# or VB file for example), then you can replace the built-in parser with a custom one.
  The sample shows how to implement a parser that skips over C# code and checks only strings and comments in the text.
  Custom parsers are classes that implement the ISpellParser interface.

![screenshot](screenshot.png)
