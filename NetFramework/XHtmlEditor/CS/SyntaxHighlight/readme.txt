SyntaxHighlight
----------------------------------------------------------------------------------
Shows how to implement a syntax-highlighting editor using a C1Editor.

The sample keeps track of any changes made to the document, and applies a list of regular expressions/style definitions to highlight the document. 

It assumes that the document is a C# file, and colors the content the same way Visual Studio does (blue reserved words, green comments, red strings, and so on).

The mechanism used is based on regular expressions and can be easily customized to apply other syntax rules.