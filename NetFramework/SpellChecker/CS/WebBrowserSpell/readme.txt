WebBrowserSpell
------------------------------------------------------------------------------------
C1SpellChecker supports controls based on the WebBrowser class.

Starting with version 2.0.20092.50, the C1SpellChecker component supports spell-checking of editors that derive from the standard WebBrower class.

The support includes underlining errors with red-wavy underlines as you type, with suggestions in context-sensitive menus, and also the dialog-based modal spell-check.

The methods used are the same as the ones used with TextBoxBase controls:
 - SetActiveSpellChecking turns as-you-type spell checking on or off;
 - CheckControl performs a dialog-based modal check of the text in the control.