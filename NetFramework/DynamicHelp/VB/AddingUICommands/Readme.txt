AddingUICommands
-----------------------------
Adding a toolbar for pinning down current topic, navigating through topics and opening external help.

C1DynamicHelp does not have any built-in GUI except for the control displaying help topics.
But you can use any GUI that you need to interact with C1DynamicHelp. This sample demonstrates how to create a toolbar with common commands.

This sample utilizes the following classes, methods and properties:
- C1DynamicHelp.Browser
- C1DynamicHelp.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab tab)
- C1DynamicHelp.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab tab, object parameter)
- C1DynamicHelp.IsPinnedDown