XmlToJson
----------------------------------------------------------------------------------------
Shows how you can use C1Excel to convert Excel files into JSON strings.

The sample prompts the user for an Excel file, then loads the file and parses the 
content of the first sheet and generates a JSON string representing the data.

The sample assumes that the data to be converted is on the first sheet of the 
Excel book, that the first row of data contains the property names, and that
each row after the first contains a single object.

The sample only handles simple flat objects with string and number properties.
Sub-objects and arrays are not supported.

