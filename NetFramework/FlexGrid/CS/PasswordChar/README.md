## PasswordChar
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\PasswordChar)
____
#### Use the C1FlexGrid to enter and edit passwords.
____
The sample handles the uses the SetupEditor event to set the PasswordChar property on the editor so that the password information typed by the user is replaced with a string of asterisks. 

The sample also hides the password information while it's not being edited by sing the OwnerDrawCell event to replace the cell contents (passwords) with strings that contains only asterisks. 

Note that the sample does show the real length of the passwords. In a real application, that would probably be a bad idea. It would be safer to show a fixed number of asterisks and initialize the editor to an empty string in order to provide a little extra security. 