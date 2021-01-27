## MultiLanguageFilter
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\MultiLanguageFilter)
____
#### Shows how to localize the C1FlexGrid filter at runtime
____
The C1FlexGrid has built-in filtering features activated by the AllowFiltering property. The filter UI contains strings such as "Greater than", "Contains", etc. which are automatically localized to the current culture (CurrentThread.CurrentUICulture). 

Note that the .NET Thread class has two properties related to culture: 

CurrentCulture: This property determines the formats used to display numbers and dates. By default, it reflects the current settings selected by the user in the control panel Format tab. 

CurrentUICulture: This property determines the language used to show localizable strings. By default, is reflects the language of the operating system. Windows Vista and Windows 7 allow you to change this setting by installing language packs. 

For more details in the differences between the CurrentCulture and CurrentUICulture properties, please see: 

http://archives.miloush.net/michkap/archive/2007/01/11/1449754.html

The FlexGrid filter localization is determined by the CurrentUICulture, which cannot be easily changed by users. However, you can change the CurrentUICulture in code, either when the application starts or at runtime. 

This sample uses the following code to set make the CurrentUICulture match the CurrentCulture. This causes the application to show strings localized to the culture selected in the control panel Format tab: 

```
    static void Main()
    {
        var ct = System.Threading.Thread.CurrentThread;
        ct.CurrentUICulture = ct.CurrentCulture;

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
```

At runtime, the sample allows users to select a language from a combo box. It then creates a CultureInfo to match the selected language and applies it to the current thread. The C1FlexGrid detects the change and automatically localizes the filter. 

To see how this works, follow these steps: 

- Run the sample.
- Move the mouse near the right end of a column header to see the filter dropdown.
- Click the filter dropdown and notice the language used.
- Use the ComboBox to select a different language.
- Show the filter again, notice how the new language is applied.


Here is the code that switches the current language: 

```
	// get language selected by the user
    var txt = comboBox1.Text;
    if (!string.IsNullOrEmpty(txt))
    {
		// extract two-letter culture name
        var pos = txt.IndexOf("(");
        var cultureName = txt.Substring(pos + 1, 2);

        // apply culture to current thread
        System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
	}
```

This code is not specific to the C1FlexGrid. It applies the new culture to the current thread, which affects all controls in the current application. 





