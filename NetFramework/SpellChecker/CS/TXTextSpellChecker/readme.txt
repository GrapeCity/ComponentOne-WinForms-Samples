TXTextSpellChecker
-------------------------------------------------------------------------
Shows how to implement as-you-type spell-checking with the TXTextControl.

The TXTextControl is a very popular and powerful text editor control: http://www.textcontrol.com/ .
It supports advanced features like tables, doc and html file format import and export, pdf output, and more.

The TXTextControl does not include a built-in spell checker.
This sample shows how you can implement a control that derives from the TXTextControl and implements the interfaces required by the C1SpellChecker in order to support as-you-type spell-checking.