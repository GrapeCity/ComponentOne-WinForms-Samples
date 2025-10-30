# FlexGridCheckboxSelection
This sample demonstrates how to implement **checkbox-based row selection** in a **C1FlexGrid** within a WinForms application.
It highlights how to preserve selections during data refreshes, dynamically update selection counts, toggle header columns,
and optionally group rows by category.

## Key Features
- Checkbox-based row selection with live selection count updates  
- Dynamic data binding from a SQLite data source  
- Grouping and header column toggling with preserved selection states  
- Asynchronous data loading with exception safety  
- Fully localized strings via `.resx` resources for easy translation  
 
## Framework and Technologies
- C# (.NET 10.0)  
- WinForms
- SQLite

### UI Controls Used
- **C1FlexGrid** – Displays data in a flexible, groupable, and selectable grid  
- **C1Label** – Provides styled text labels for descriptions and headings  
- **C1CheckBox** – Used for grouping toggle and header column visibility  
- **RichTextBox** – Displays selection count with formatted text output  

## Global Usings
This project uses a centralized **GlobalUsings.cs** file to simplify namespace management across all classes.
Common framework, control, and internal project namespaces are declared globally to keep individual files clean and focused on logic.

## Project Structure
- **Data/** – Handles SQLite data access and schema validation  
- **Interface/** – Defines core abstraction interfaces for dependency injection  
- **Service/** – Implements grid logic, grouping, and binding services  
- **Utility/** – Contains context-specific helpers for UI
- **Helper/** – Contains helper services 
- **Resources/** – Includes localized UI strings and embedded resources  
 
## UML Call Hierarchy Overview
The following UML-style call hierarchy illustrates how major components in the **FlexGridCheckboxSelection** project interact at runtime.  
It starts from the **Form1** entry point and traces method calls across the *Service* and *Data* layers.
```
Form1
├─ DefaultDataProvider.GetRowsSafe()
│ └─ DataSource.GetRows()
├─ GridBinder.Rebind()
│ ├─ SelectionStateService.CaptureSelectedKeys()
│ ├─ IGridGrouper.ApplyGrouping()
│ └─ SelectionStateService.RestoreSelectedKeys()
├─ ColumnInfoManager.ApplyHeader(showHeader, reGroupAfter)
│ └─ IGridGrouper.ApplyGrouping()
├─ UiUpdater.UpdateSelectedCount()
└─ MessageBoxService.ShowWarning()
```