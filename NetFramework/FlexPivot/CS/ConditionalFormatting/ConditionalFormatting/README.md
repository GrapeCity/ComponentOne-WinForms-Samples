## ConditionalFormatting
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\ConditionalFormatting\ConditionalFormatting)
____
#### Shows how you can use the C1FlexPivotField's StyleHigh and StyleLow properties to implement conditional formatting.
____
When displaying results on a grid, you may want to highlight cells that show values that are especially high or low. 

Since the C1FlexPivotGrid derives from the C1FlexGrid, you can achieve this type of conditional formatting using the C1FlexGrid's OwnerDraw feature, but that requires writing some code. 

An easier alternative is to use the C1FlexPivotField's StyleHigh and StyleLow properties. These properties define a style and a condition when the style should be applied, making conditional formatting extremely easy. 

For example, the code below configures all Value fields in an FlexPivot view to show the top 10% of the values in cells with a green background, and the bottom 10% in cells with a red background: 

```
    // set up conditional formats in code
    foreach (var f in FlexPivot.ValueFields)
    {
        // show top 10% of the values in bold, with a green background
        var sh = f.StyleHigh;
        sh.ConditionType = C1.FlexPivot.ConditionType.Percentage;
        sh.Value = 0.9;
        sh.BackColor = Color.FromArgb(230, 255, 230);
        sh.FontBold = true;

        // show bottom 10% of the values in bold, with a red background
        var sl = f.StyleLow;
        sl.ConditionType = C1.FlexPivot.ConditionType.Percentage;
        sl.Value = 0.1;
        sl.BackColor = Color.FromArgb(255, 230, 230);
        sl.FontBold = true;
    }
```

