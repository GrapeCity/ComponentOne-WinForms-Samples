# ScrollBarAnnotations

## Overview
This sample demonstrates how to enhance the **FlexGrid** usability by displaying **annotations directly on the scrollbar**.  
It provides visual indicators for various row states such as selection, focus, errors, and highlights, improving data navigation and user experience.

---

## Key Features

1. **Show Annotations**  
   Master switch to enable or disable all scrollbar annotations.

2. **Annotations with Theme**  
   Supports annotations that adapt to the current visual theme.

3. **Show Errors**  
   Displays error indicators in the scrollbar for rows containing errors.

4. **Show Selected Row**  
   Highlights the currently selected row on the scrollbar.

5. **Show Focused Row**  
   Displays a marker for the row currently in focus.

6. **Show Highlighted Row**  
   Marks highlighted rows directly on the scrollbar.

7. **Custom Annotations**  
   Supports user-defined annotations.  
   (The current sample includes custom annotations for discontinued products.)

8. **Scroll to Scrollbar Annotation**  
   Allows navigation directly to a specific annotation using hotkeys:  
   - `Ctrl + Up` to move up  
   - `Ctrl + Down` to move down

9. **Show Scroll Tooltip**  
   Displays contextual tooltips while scrolling over annotations.

---

## C1 Controls Used
Version used: `10.0.20252.*`

- `C1 Input`  
- `C1 FlexGrid` (with Scrollbar Annotations)  
- `C1 Label`  
- `C1 CheckBox`  
- `C1 ComboBox`  
- `C1 Theme Controller`

---

## Folder Structure
```
ScrollBarAnnotations/
│
├── CustomAnnotations/          # Contains custom annotation logic
├── Enums/                      # Enumeration types used across the sample
├── Manager/                    # Centralized classes that manage specific app features
│   ├── ThemeManager.cs         # Handles theme loading and applying logic
│   ├── DatabaseManager.cs      # Handles connection string and database access logic
│   └── TooltipManager.cs       # Handles tooltip configuration and descriptions
│
├── App.config                  # Application configuration file
├── Form1.cs                    # Main form containing UI and logic
├── Program.cs                  # Entry point of the application
│
├── README.md                   # Project documentation (this file)
└── x.gclicx                    # ComponentOne license configuration
```