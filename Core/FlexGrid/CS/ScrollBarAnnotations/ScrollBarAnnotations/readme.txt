Scrollbar Annotations
---------------------------------------
Scrollbar Annotations in FlexGrid allow users to visualize target rows directly on the grid’s scrollbar using small, colored markers. Each annotation represents specific data such as validation errors, focused rows, search results, or custom highlights, helping users quickly locate them without manual scrolling.

The ScrollBarAnnotationsInfo class provides configuration options for enabling, displaying, and customizing scrollbar annotations through both properties and code.

Working with Scrollbar Annotations
FlexGrid provides flexible options to manage scrollbar annotations, either through properties or programmatically in code. These annotations help improve user experience by offering quick navigation and visual feedback.

Enable or Disable Scrollbar Annotations
You can easily enable or disable scrollbar annotations using the FlexGrid’s scrollbar settings or by modifying the ScrollBarAnnotationsInfo object. This allows you to control whether annotations are visible based on user interaction or application state.

Add Tooltips
Tooltips can be added to scrollbar annotations to display additional details when hovering over an annotation marker. This feature is useful for showing row-specific information, such as error messages or data summaries.

Enable Focused, Selected, or Highlighted Rows
Scrollbar annotations can automatically reflect the state of the grid by showing markers for focused, selected, or highlighted rows. This makes it easier to identify where important or active items are located within large datasets.

Highlight Errors
Annotations can also be used to mark rows containing validation errors or warnings. By assigning a distinct color to error markers, users can instantly recognize problem areas and navigate to them with a single click.

Scroll the FlexGrid to a Specific Scrollbar Annotation
Users can programmatically scroll the grid to a specific annotation. This is useful when focusing on a particular event, record, or flagged row without manually searching or scrolling.

Customize Scrollbar Annotations
Scrollbar annotations are fully customizable. Developers can modify their color, shape, size, or behavior to match the application’s visual theme or to convey specific meaning.
