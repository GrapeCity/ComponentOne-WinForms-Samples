## HierarchicalEnumerable
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\HierarchicalEnumerable\HierarchicalEnumerable)
____
#### Shows how you can populate a C1FlexGrid from a data source that implements the IHierarchicalEnumerable interface.
____
The IHierarchicalEnumerable interface is declared in the System.Web.UI interface.
It represents a hierarchical collection that can be enumerated with an IEnumerator interface.

Collections that implement the IHierarchicalEnumerable interface are typically used by ASP.NET site navigation and data source controls,
but they can also be used in WinForms project as long as you add the necessary reference to the System.Web.dll assembly.

The sample uses a hierarchical data source class provided in a CodeProject sample 
http://www.codeproject.com/Articles/19639/Implementing-IHierarchy-Support-Into-Your-Custom-C

The sample populates the FlexGrid by enumerating the items in the collection and adding node rows to represent each item.
The method that populates the grid calls itself recursively to add each item's child items.
