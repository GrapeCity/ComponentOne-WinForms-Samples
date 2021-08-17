ComboBoxImages
-----------------------------------------------------------------------------
Images in C1ComboBox control.

Shows how easy is to use images from ImageList in the drop down items of a C1ComboBox control.

Design time:
 1. Add items to C1ComboBox.Items collection.
 2. Add images to the imageList1.
 3. Set keys (Name) of the images equal to the items in C1ComboBox.Items.

Run time:

<code>
c1ComboBox.ItemsImageList = imageList;
imageList.Images.Add("First item", Image.FromFile("First.png"));
c1ComboBox.Items.Add("First item");
</code>