## BankTeller (with CAB Extension Kit)
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Ribbon\CS\BankTeller)
____
#### This is a sample from Composite UI Application Block QuickStart adapted for using C1Ribbon instead of ToolStrip controls.
____
The sample introduces C1Ribbon CAB Extension library. There are two options when adding C1Ribbon functionality to an application based on CAB framework. 

1. The parts of C1Ribbon and C1StatusBar controls can be registered as UIExtension sites. The control will be hosted in Shell and shared between multiple modules. Individual WorkItems can add/remove their own elements to/from UIExtension sites. You can see an example in the CustomerWorkItem class in BankTellerModule project. We add some elements to UIExtensionSites created in BankShellApplication for C1StatusBar's LeftPaneItems and RightPaneItems collections. 

2. You can add the special RibbonWorkspace at the top of the Shell Form derived from C1RibbonForm (see ribbonWorkspace in the sample). Then, you can create a SmartPart with the C1Ribbon control placed on it. This smart part will be shown in RibbonWorkspace when the corresponding WorkItem is loaded. It is easy to associate CAB Commands with various events of C1Ribbon elements. So you can create and customize C1Ribbon with powerful design-time editors, then add a set of loosely coupled commands allowing to integrate C1Ribbon seamlessly into the infrastructure of your CAB-based application. For example, see the RibbonView SmartPart in BankTellerModule project. 

If your application uses C1Ribbon or C1StatusBar controls please derive the application class from C1RibbonFormApplication instead of FormShellApplication. The source code for C1.Win.C1Ribbon.CAB library is provided as part of this sample. So you can create your own solutions based on this library. 

For more info on the original BankTeller sample see the following link: http://msdn.microsoft.com/en-us/library/ff649604.aspx 