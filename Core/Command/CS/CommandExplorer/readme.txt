CommandExplorer
----------------------------
Shows main samples of controls in the C1.Win.Command assembly.

Included samples:
  - DockingOverview - shows all common properties for C1DockingTab and allows to change them at runtime via PropertyGrid control.
    The C1DockingTab control implements the familiar tab control interface but it also includes a variety of features to visually enhance and customize the control. 
    In addition to the appearance properties, C1DockingTab has several useful behavioral properties for closing tab pages, rearranging tabs, and auto-hiding capabilities.
  - Docking - shows how to create workspaces from floating and docking tabs. C1DockingTabs can float and dock to any edge of the application. 
    C1DockingTabs can float and dock to any edge of the application. Choose among four different docking styles, including Visual Studio 2012 style. 
    To undock and float a C1DockingTab, position your mouse over the tab or the caption bar. Then, click and drag to undock. 
    When dragging tabs near the edges of the form you will notice docking rectangles appear signaling where to dock. 
    In addition, C1DockingTab supports auto-hiding functionality where tabs can be minimized to slide in and out.
  - ToolbarsOverview - shows C1Menu, C1ContextMenu and C1Toolbar which share the same set of commands.
    Menus and Toolbars is a suite of controls including C1MainMenu, C1ContextMenu, and C1ToolBar. 
    The menus and toolbar components can share commands, meaning you will have a cleaner UI and less code to manage. 
    Other features include embedding arbitrary controls, run-time toolbar customization, toolbar mnemonics and more.
  - RadialMenuOverview - shows how to create and control a C1RadialMenu
    The form in this sample includes a C1RadialMenu with several items and submenus, all created in the Visual Studio forms designer.
    The form also includes controls that demonstrate how to control the radial menu from code: hide or show it, turn animation on or off etc.
  - C1Command - This sample demonstrates how one C1Command can be shared across multiple UI controls (C1MainMenu, C1ToolBar, C1DockingTab, and C1ContextMenu) to trigger the same action.
    When you click on any linked control that has the command attached to it, the same command executes and increments a counter. 
    The sample also demonstrates centralized state management - disabling the command automatically disables all linked controls simultaneously.