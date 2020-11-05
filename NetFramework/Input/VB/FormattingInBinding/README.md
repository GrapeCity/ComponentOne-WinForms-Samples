## FormattingInBinding
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Input\VB\FormattingInBinding)
____
#### Using BindingFormatting and BindingParsing events.
____
The sample demonstrates the use of two important events of C1TextBox, C1Label, and C1PictureBox controls. 

At the top of the form you can see the first data source - a ListView control. There are also C1DbNavigator, C1DateEdit, and C1Label controls bound to this data source. The DataType property for both C1DateEdit and C1Label is set to DateTime while the ListView contains string data. BindingFormatting/Parsing events are used to convert the data type of a value passed between the data source and the UI controls. 

There is also another data source (listView2) and a C1PictureBox in the bottom part of the form. The ListView contains images stored as strings in Base64 encoding. The C1PictureBox control converts the string into the binary form within the BindingFormatting event. Also, an image can be converted back to the string form within the BindingParsing event. 