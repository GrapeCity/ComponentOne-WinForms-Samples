SplitButtons
------------------------------------------------------
This sample shows how to use the C1SplitButton, C1ColorPicker and C1FontPicker controls.

There are two C1SplitButton's on the form.
The top "Spell" C1SplitButton uses Image property to display the main button image and the DropDownImageList property for drop down item images.
The separator is an item with "-" text and no child items.
For the "spell" C1SplitButton the "English" item set as DefaultItem, and if user clicks on the main button area, DropDownItemClicked event occurs with the "English" item as argument.
In the "VisualStyle" C1SplitButton Tag property is used to keep the VisualStyle values.
CheckOnClick property if used to display the checkmarks of selected style.
C1ColorPicker and C1FontPicker control allows to change appearance of the selected text fragment.