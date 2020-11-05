## FilterDefinitionTdbg
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\TrueDBGrid\CS\FilterDefinitonTdbg)
____
#### Using FilterDefinition property to save/load custom filters in code.
____
C1TrueDbGrid's split has "FilterDefinition" property which allow user to get/set all conditional filters. 

This sample application allows user to apply one of a few pre-defined filters. 

This is done reading the FilterDefinition property from a xml file: ```
void ReadFilter(string name)
{
    c1TrueDBGrid1.Splits[0].FilterDefinition = System.IO.File.ReadAllText(name + ".xml");
}
```

User has opportunity to apply own filter to the grid and save it as custom: ```
void SaveCustomFilter()
{
	System.IO.File.WriteAllText("custom.xml", this.c1TrueDBGrid1.Splits[0].FilterDefinition);
}
```