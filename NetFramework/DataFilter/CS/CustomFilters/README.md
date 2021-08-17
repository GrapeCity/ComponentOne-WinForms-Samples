## CustomFilters
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\DataFilter\CS\CustomFilters)
____
#### Demonstrates using C1DataFilter control to show custom filters.
____
There is C1TreeView and C1DataFilter on the Form. The C1TreeView uses CustomContentPresenter to shows data.
The C1DataFilter uses three custom filters:

* ColorFilter based on CustomFilter, allows to choose the color of the car;
* MapFilter based on CustomFilter, allows to choose the store on map;
* ModelFilter based on CustomFilter, allows to choose the model of the car;
* PriceFilter based on ChecklistFilter, allows to choose the price range of cars.

How to implements custom filter:
1. Add a class with filter model, this class should be based on the CustomFilter class.
   You should implement the GetExpression and SetExpression abstract methods. The GetExpression method returns an expression which is used to perform filtering.
   The SetExpression method is used to load the filter state from an XML file.
   Optionaly you can override the IsApplied property. This property is used to detect whether the DataFilter needs to apply this filter to a data source or not.
2. Implement a UserControl or choose a control as view of custom filter. This control must be set as the Control property of the user filter.
