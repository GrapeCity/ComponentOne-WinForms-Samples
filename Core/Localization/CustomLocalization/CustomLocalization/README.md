# Custom Localization

## Overview
This sample demonstrates how to create and apply a **custom localization service** for ComponentOne WinForms controls.  
It provides a utility to scan a project, view and edit resource (`.resx`) files, and apply custom translations at runtime. This allows developers to easily override default control text or add support for new languages.

---

## Key Features

1.  **Dynamic Project Loading**  
    Scans a specified directory to build and display a project's file structure, focusing on `.resx` resource files.

2.  **Resource File Editor**  
    Provides a simple interface to view and edit the key-value pairs within selected `.resx` files.

3.  **Custom Localization Service**  
    Implements a custom `C1Localizer` service that loads translations from external resource files, overriding the default component resources.

4.  **Live Culture Switching**  
    Allows the application's culture to be changed on the fly, demonstrating the immediate effect of the custom localization service.

5.  **C1Schedule Localization Example**  
    Features a practical demonstration of the localization service applied to the `C1Schedule` control.

---

## C1 Controls Used
Version used: `10.0.20252.*`

- `C1 Schedule`
- `C1 FlexGrid`
- `C1 TreeView`
- `C1 Input`
- `C1 List`

---

## Folder Structure
```
CustomLocalization/
│
├── CustomResources/    # Contains custom .resx files for different languages
├── Events/             # Custom event arguments used in the application
├── Models/             # Data models for the application (e.g., TreeItemModel)
├── Pages/              # UI pages for different views (Home, Resource Editor)
├── Services/           # Core logic for localization and file management
│   ├── CustomLocalizationService.cs # Implements the custom C1Localizer
│   ├── DirectoryManager.cs      # Manages directory operations
│   ├── ProjectTreeBuilder.cs    # Builds the project tree structure
│   └── ResourceFileReader.cs    # Reads and parses .resx files
│
├── UserControls/       # Reusable UI components
│   ├── CultureDisplayControl.cs # Control for switching the current culture
│   └── CustomTreeView.cs        # Displays the project file structure
│
├── Form1.cs            # Main form containing the primary UI
├── Program.cs          # Entry point of the application
└── Custom Localization.csproj # The C# project file
```
