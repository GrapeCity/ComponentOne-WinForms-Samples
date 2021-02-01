## CustomDictionary
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SpellChecker\VB\CustomDictionary)
____
#### Shows how to implement a custom spell dictionary class.
____
The C1SpellChecker control uses up to three spell dictionaries while checking text: 

1) MainDictionary: 

Read-only dictionary that contains the main word list. The US-English version of this dictionary is built into the control, so there's no need for any additional files. Other languages are available as DCT files that ship with the control, and can be selected using the MainDictionary.FileName property. 

2) UserDictionary: 

Read-write dictionary used to store words that are correct but are not part of the main dictionaries. These files are stored as plain text, and can be selected using the UserDictionary.FileName property. 

3) CustomDictionary: 

Any .NET object that implements the ISpellDictionary interface. This allows users to create their own dictionary classes, using whatever scheme makes sense in their application. A custom dictionary could, for example, look up words on the web using a web service (and then cache them for speed). 

The sample implements a CustomDictionary that accepts all words starting with the letter 'z' as correct. 