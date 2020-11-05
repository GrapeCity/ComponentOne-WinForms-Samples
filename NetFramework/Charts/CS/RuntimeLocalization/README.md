## Runtime Localization
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Charts\CS\RuntimeLocalization)
____
#### This samples demonstrates the steps to provide runtime localizations for the charts.
____
The sample saves the default string localizations and loads them into an XML document and performs a quick change of all the localized strings by prefixing the strings with a selected value. 

Although it is unlikely that anyone would actually want make changes to the strings by prefixing them, the process demonstrates how to obtain the set of localizable strings from a chart and replace them with your own. 

In practice, the most likely scenario would involving saving the localizations to a file using SaveLocalizations(string filename) in a sample project, modify the file as appropriate, and finally load the file into one or more charts in one or more applications using using LoadLocalizations(string filename). 

The localizations string are made available to allow runtime localizations of the chart ShowProperties and ShowWizard dialogs, as well as localizing property help descriptions as they appear when the chart is selected by a PropertyGrid. 