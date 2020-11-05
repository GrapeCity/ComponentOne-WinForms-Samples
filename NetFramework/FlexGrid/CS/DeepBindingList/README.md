## DeepBindingList
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\DeepBindingList)
____
#### Shows how you can implement a data source that exposes sub-properties of the bound items.
____
When you bind a list of objects to a grid, it displays the properties of the items on the list. But if the properties are complex objects themselves, then the grid shows only the main object (usually based on a ToString() conversion), and not the properties of those objects. 

For example, consider the following Customer class: 

```
public class Customer
{
	public int ID { get; set; }
	public string Name { get; set; }
	public Address Address { get; set; }
}
public class Address
{
	public string Street { get; set; }
	public string City { get; set; }
	public string Country { get; set; }
}
```

If you create a list of customers and bind that to a grid, you will get three columns: "ID", "Name", and "Address". The first two columns will display the data as usual, but the third will show a string containing the class name "Address". 

You could override the 'ToString' method in the Address class to display more useful information, and you could create type converters and custom editors to allow users to edit the address, but in many cases it would be better to show the properties of the Address object instead. 

Unlike a regular BindingList<T>, the DeepBindingList<T> in this example traverses the sub-properties of each property, so when you bind it to the grid you will get six columns instead of three: 

```
	ID (int)
	Name (string)
	Address (Address)
	Address.Street (string)
	Address.City (string)
	Address.Country (string)
```

In most cases you will want to hide the "Address" column on the grid and show only the columns that contain basic types. You can do that in two ways: 

1) Set AutoGenerateColumns to true (the default) and hide the "Address" column after binding the grid to the data: 

```
	_flex.DataSource = deepBindingList;
	_flex.Cols["Address"].Visible = false;
```

2) Set AutoGenerateColumns to false and specify the columns you want to display: 

```
	_flex.AutoGenerateColumns = false;
	_flex.DataSource = deepBindingList;
	_flex.Cols.Count = _flex.Cols.Fixed;
	foreach (string name in "ID,Name,Address.Street,Address.City,Address.Country".Split(','))
	{
		var c = _flex.Cols.Add();
		c.Name = name;
		c.Caption = name;
	}
```

In addition to deep binding, the DeepBindingList<T> class also implements sorting (which is not supported by the standard BindingList<T> class). 

NOTE: The DeepBindingList<T> class can be used as a data source for any control, there's nothing in it that is specific to the FlexGrid. 

Some related links: 

http://stackoverflow.com/questions/2549989/combine-master-detail-databinding/4729603#4729603 

http://blogs.msdn.com/b/msdnts/archive/2007/01/19/how-to-bind-a-datagridview-column-to-a-second-level-property-of-a-data-source.aspx 

