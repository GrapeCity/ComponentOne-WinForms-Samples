﻿DataGridViewConditionalFormatting
----------------------------
This sample shows how to setup MS DataGridView control to work with C1RulesManager.

The C1RulesManager provides a conditional formatting for a control which supports IFormattableView interface.
Any WinForms control (e.g. MS DataGridView) can be extended for using with C1RulesManager by implementing such interface.
This sample shows such basic implementation.
Due to the fact that gradient rules support was not added in the provided implementation and to not confuse end-user about not-working functionality, the gradient rules tab was hidden in the rules manager UI.