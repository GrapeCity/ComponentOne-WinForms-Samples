## CustomMerge
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\VB\CustomMerge)
____
#### Implement your own merging logic to create a TV-guide display.
____
The C1FlexGrid control offers several built-in merging modes (free, spill, nodes, row/col control, etc). But there are some limitations. For example, none of the built-in modes allows you to create merged ranges that span both rows and columns. 

This sample shows how you can overcome this limitation by inheriting from the C1FlexGrid and implementing a custom version of the virtual GetMergeRange method. 

The sample creates a TV schedule and merges programs across weekdays (columns) and show times (rows). 