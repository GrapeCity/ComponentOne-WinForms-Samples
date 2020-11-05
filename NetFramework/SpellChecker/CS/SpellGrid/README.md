## SpellGrid
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SpellChecker\CS\SpellGrid)
____
#### Shows how to implement a custom spell-checking modal dialog.
____
The C1SpellChecker control has built-in support for controls that derive from the TextBoxBase class (such as the TextBox and RichTextBox controls). 

This means you can simply connect the C1SpellChecker to any of these controls (using the SetSpellChecking method) and the C1SpellChecker will detect spelling mistakes as the user types, showing a red wavy underline and providing a context-sensitive menu with suggestions. You can also use the CheckControl method to provide modal spell-checking against these controls. 

If you want to spell check controls that do not derive from TextBoxBase, then you need to provide a class that implements one of the following interfaces: 

- ISpellCheckableEditor (for modal spell-checking), or  - ISpellCheckableRichEditor (for modal and as-you-type spell-checking) 

This sample shows how to create a wrapper class that implements the ISpellCheckableEditor interface on behalf of a C1FlexGrid control. 

This FlexGridSpeller class can then be used with the CheckControl method to provide modal spell-checking for the C1FlexGrid control. 

