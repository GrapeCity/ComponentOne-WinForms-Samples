SizerExplorer
----------------------------
Shows the main features of the Sizer control.

Includes next samples: 
- Overview. This demo shows C1Sizer in action.
  C1Sizer is a container control with a powerful grid layout manager that extends the basic layout capabilities provided by the 
  .NET Framework (Dock and Anchor properties). C1Sizer gives you the ability to easily manage every contained controls behavior 
  when the panel is resized, thus eliminating the need to set docking and anchoring properties for each control. You can also add 
  splitters anywhere between controls. In this demo we use buttons to represent arbitrary controls on a form.
- PresentationFeatures. This demo is the same as the Overview but with style features.
  C1Sizer has three WPF-like styling features: gradient backgrounds, border styles and rounded corners. For the gradient background 
  you can create a custom, 4 point blend between two colors or choose a preset blend. Add some style to your apps without adding 
  image resources.
- SizerLightControl. This demo shows usage of the C1SizerLight component.
  In addition to C1Sizer there is C1SizerLight. With C1SizerLight you can create resolution-independent applications without having 
  to write any code or play with design-time configuration. Just drop C1SizerLight on your form it keeps track of the forms' size 
  and position. When the form is resized, C1SizerLight resizes all contained controls proportionally, so the form retains its 
  appearance at any resolution.
- AddControls. Shows how to add child controls to a C1Sizer using code.
  The sample adds controls by creating them, adding them to the C1Sizer's Controls collection, then positioning them using the 
  Bounds property available in the sizing grid's Row and Column objects.
  The sample positions the controls at specific cells by intersecting specific row and column rectangles. You can also make controls 
  span any number of adjacent grid cells.
- CustomSplitters. Use the OnPaint event to customize the appearance of the splitter bars.
  The sample uses the OnPaint event to add images and text to the C1Sizer splitter bars. It also handles the mouse to collapse and \
  expand splitter panes when the user clicks an icon on the left of the splitter bar.