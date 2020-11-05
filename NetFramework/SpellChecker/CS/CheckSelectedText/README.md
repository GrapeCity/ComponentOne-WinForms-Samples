## CheckSelectedText
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SpellChecker\CS\CheckSelectedText)
____
#### Shows how to spell check the current selection.
____
The C1SpellChecker has built-in support for checking the content of TextBox controls starting from the start or from the current cursor position. 

This sample shows how to implement spell-checking of the current selection. 

The sample performs these tasks: 

- Check whether the current selection has zero length. If it does, then a full selection is performed. 

- Expand the selection to cover full words in case it contains pieces of words. 

- Attach event handlers for the BadWordFound and TextChenged events. 

- Invoke the CheckControl method. 

- When a bad word is detected, check whether it is beyond the end of the original selection. If so, stop checking. 

- When a replacement is made, adjust the selection end in case the replacement is shorter or longer than the original text. 

- Remove the event handlers. 

- Restore the selection. 

