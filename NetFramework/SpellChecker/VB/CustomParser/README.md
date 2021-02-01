## CustomParser
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SpellChecker\VB\CustomParser)
____
#### Shows how to implement a custom spell-checking parser class.
____
The C1SpellChecker control uses a built-in parser to break up text into words that are then spell-checked. The built-in parser handles plain text and also common formats such as Html and Xml. It can be configured using the Options.Ignore property. 

If you need to check text that is formatted according to special rules (a c# or VB file for example), then you can replace the built-in parser with a custom one. 

The sample shows how to implement a parser that skips over C# code and checks only strings and comments in the text. 

Custom parsers are classes that implement the ISpellParser interface. 