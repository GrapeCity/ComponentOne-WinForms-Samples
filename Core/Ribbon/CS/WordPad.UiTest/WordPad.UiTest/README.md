# WordPad UI Test Suite

Comprehensive UI automation test suite for the **C1 Ribbon control in WinForms** using **FlaUI**, **UI Automation (UIA3)**, and **NUnit**.

## Overview

The **WordPad.UiTest** project is a .NET 10 UI automation framework designed to validate Ribbon-based functionality in WinForms applications.

The test suite uses **FlaUI with the UIA3 provider** to interact with the application through the Windows UI Automation framework. This allows tests to verify both application behavior and accessibility-related UI properties.

The project focuses on creating reliable, maintainable, and readable UI automation tests that simulate user interactions.

## Technology Stack

| Technology             | Version                | Purpose                        |
| ---------------------- | ---------------------- | ------------------------------ |
| .NET                   | 10 (`net10.0-windows`) | Application framework          |
| NUnit                  | 4.3.2                  | Test framework                 |
| FlaUI.Core             | 5.0.0                  | UI automation framework        |
| FlaUI.UIA3             | 5.0.0                  | Windows UI Automation provider |
| Microsoft.NET.Test.Sdk | 17.14.0                | Test execution engine          |
| coverlet.collector     | 6.0.4                  | Code coverage                  |

## Project Structure

```text
WordPad.UiTest/
│
├── MainApplication/
│   ├── MainApp.cs
│   └── README.md
│
├── Tests/
│   ├── BaseTest.cs
│   ├── DocumentOperationTest.cs
│   ├── QuickAccessToolbarTest.cs
│   ├── RibbonButtonTest.cs
│   ├── RibbonClipboardGroupTest.cs
│   ├── RibbonFontGroupTest.cs
│   ├── RibbonParagraphGroupTest.cs
│   ├── RibbonStylesGroupTest.cs
│   ├── RibbonTabsTest.cs
│   └── README.md
│
├── UiLocator.cs
├── UiWaiter.cs
└── README.md
```

## Architecture

The test framework follows a layered approach:

```
                 WordPad Application
                         |
                         |
                    MainApp
                         |
                         |
                 FlaUI UI Automation
                         |
          +--------------+--------------+
          |                             |
     UiLocator                     UiWaiter
          |                             |
          +--------------+--------------+
                         |
                       Tests
```

### MainApp

Responsible for application lifecycle management.

Responsibilities:

* Launch the application
* Initialize UI Automation
* Provide access to the main window
* Manage cleanup and resource disposal

See:
`MainApplication/README.md`

---

### UiLocator

Provides reusable methods for locating UI Automation elements.

Benefits:

* Centralized element lookup
* Reduced duplicated locator code
* Easier maintenance when UI changes

---

### UiWaiter

Provides reliable waiting mechanisms for asynchronous UI operations.

Benefits:

* Avoids fixed delays
* Reduces flaky tests
* Waits for actual UI conditions

---

## Tests

Tests are organized by application feature.

| Test Class               | Purpose                        |
| ------------------------ | ------------------------------ |
| RibbonTabsTest           | Validates Ribbon tabs          |
| RibbonButtonTest         | Validates Ribbon buttons       |
| RibbonClipboardGroupTest | Tests Clipboard group controls |
| RibbonFontGroupTest      | Tests Font group controls      |
| RibbonParagraphGroupTest | Tests Paragraph group controls |
| RibbonStylesGroupTest    | Tests Styles gallery           |
| QuickAccessToolbarTest   | Tests Quick Access Toolbar     |
| DocumentOperationTest    | Tests document operations      |

See:

`Tests/README.md`

---

# Getting Started

## Prerequisites

Before running the tests, ensure the following are installed:

* Visual Studio 2022 or later
* .NET 10 SDK
* Windows operating system
* WordPad sample application built successfully

## Running Tests

### Visual Studio

1. Open the solution.
2. Open **Test Explorer**.
3. Select **Run All Tests**.

### Command Line

Run all tests:

```bash
dotnet test
```

Run a specific test:

```bash
dotnet test --filter RibbonTabsTest
```

---

# Project Reference

The test project references:

* **WordPad** - WinForms application under test

---

# Test Design Guidelines

Tests follow the Arrange-Act-Assert (AAA) pattern.

Example:

```csharp
public void Ribbon_IsAvailable()
{
    // Arrange & Act
    AutomationElement ribbon = UiLocator.FindRibbonElementById(Window);

    // Assert
    Assert.Multiple(() =>
    {
        Assert.That(ribbon.IsEnabled, Is.True);
        Assert.That(ribbon.Name, Is.EqualTo("Ribbon"));
        Assert.That(ribbon.ControlType, Is.EqualTo(ControlType.Pane));
    });
}
```

## Best Practices

1. Keep tests independent.
2. Avoid fixed delays such as `Thread.Sleep`.
3. Use `UiWaiter` for asynchronous operations.
4. Keep UI selectors inside `UiLocator`.
5. Use descriptive test names.
6. Validate user-visible behavior.
7. Follow Arrange-Act-Assert structure.

---

# Troubleshooting

| Issue                          | Cause                           | Solution                        |
| ------------------------------ | ------------------------------- | ------------------------------- |
| Application not found          | Executable missing              | Rebuild the WordPad project     |
| UI element not found           | Timing issue                    | Add appropriate wait conditions |
| Tests are flaky                | UI state changes asynchronously | Use `UiWaiter`                  |
| Multiple application instances | Cleanup failure                 | Verify application teardown     |

---

# Code Coverage

Coverage can be collected using:

Visual Studio:

```
Test → Analyze Code Coverage for All Tests
```

---

# Related Resources

* WordPad WinForms Sample
* FlaUI:
  https://github.com/FlaUI/FlaUI
* NUnit:
  https://nunit.org/

---

# Contributing

When adding new automation coverage:

1. Add a new test class under `Tests`.
2. Add reusable locators to `UiLocator` if needed.
3. Add waiting logic through `UiWaiter`.
4. Follow existing naming conventions.
5. Keep tests readable and maintainable.
6. Update documentation when adding new functionality.
