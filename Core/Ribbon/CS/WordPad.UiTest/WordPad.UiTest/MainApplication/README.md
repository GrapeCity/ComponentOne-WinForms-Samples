# MainApplication - WordPad UI Test Automation

The `MainApplication` folder contains the application lifecycle management and automation infrastructure used by the WordPad UI test suite.

It provides a centralized way for tests to launch the WordPad application, initialize UI Automation, access the main application window, and release resources after testing.

## Overview

The `MainApp` class acts as the bridge between the UI automation framework and the WordPad application.

Tests should interact with the application through `MainApp` instead of directly managing application processes or automation objects.

## MainApp

`MainApp` manages the lifecycle of the Application Under Test (AUT).

## Responsibilities

`MainApp` is responsible for:

* Starting the WordPad application
* Initializing FlaUI automation
* Locating and storing the main application window
* Providing shared access to automation resources
* Closing the application after test execution
* Releasing UI Automation resources

## Key Members

| Member         | Description                                       |
| -------------- | ------------------------------------------------- |
| `Initialize()` | Starts the application and prepares UI Automation |
| `Window`       | Provides access to the main application window    |
| `Dispose()`    | Closes the application and releases resources     |

## Usage Example

```csharp
MainApp.Initialize();

var window = MainApp.Window;

// Perform UI automation operations

MainApp.TearDown();
```

## Application Lifecycle

The typical lifecycle is:

```text
Test Execution Starts
        |
        v
Initialize()
        |
        v
Launch WordPad
        |
        v
Create FlaUI Automation Instance
        |
        v
Find Main Window
        |
        v
Execute Tests
        |
        v
TearDown()
        |
        v
Release Resources
```

## Design Approach

The application lifecycle is isolated from individual tests to provide:

* Consistent application state
* Reduced duplicated setup code
* Easier maintenance
* Reliable cleanup

Tests should focus on validating functionality rather than managing application startup.

## Dependencies

The automation infrastructure uses:

| Dependency         | Purpose                          |
| ------------------ | -------------------------------- |
| FlaUI.Core         | Core UI automation functionality |
| FlaUI.UIA3         | Windows UI Automation provider   |
| System.Diagnostics | Application process management   |

## Best Practices

When extending the application automation layer:

1. Keep application lifecycle logic inside `MainApp`.
2. Avoid launching application instances directly from tests.
3. Release automation resources during teardown.
4. Keep UI element lookup logic outside this class.
5. Add feature-specific operations through separate helper classes when required.

## Related Documentation

* Root project documentation:
  `../README.md`

* Test documentation:
  `../Tests/README.md`
