## TransactionsWinForms
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\DataSource\CS\TransactionsWinForms)
____
#### Client-side transactions in WinForms.
____
Client-side transactions is a mechanism implemented in C1DataSource for canceling changes on the client without involving the server.
For details, see "Client-Side Transactions" in "Programming Guilde" in the documentation.

This demo application shows how to undo changes with a Cancel button, including in nested (child) dialogs/forms, using all three methods of working with client-side transactions:
  1. Associating a transaction with a live view.
  2. Binding to an object tracking changes using ScopeDataContext method.
  3. Opening a transaction Scope() manually in code.

![screenshot](screenshot.PNG)
