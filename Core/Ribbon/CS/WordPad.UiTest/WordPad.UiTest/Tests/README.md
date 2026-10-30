# UI Tests

The `Tests` folder contains the automated UI test suite for the WordPad WinForms application.

Tests are implemented using **NUnit** and **FlaUI UIA3** to validate Ribbon functionality, document operations, and UI Automation behavior.

## Overview

Each test class focuses on a specific application feature.

The test suite follows a feature-based organization to keep tests:

* Easy to discover
* Independent
* Maintainable
* Simple to extend

## Test Structure

```text
Tests/
│
├── BaseTest.cs
├── DocumentOperationTest.cs
├── QuickAccessToolbarTest.cs
├── RibbonButtonTest.cs
├── RibbonClipboardGroupTest.cs
├── RibbonFontGroupTest.cs
├── RibbonParagraphGroupTest.cs
├── RibbonStylesGroupTest.cs
└── RibbonTabsTest.cs
```

---

# BaseTest

`BaseTest` provides common functionality shared by all test classes.

## Responsibilities

* Provides access to the application window
* Initializes common test resources
* Provides shared test setup
* Handles common cleanup operations

Test classes inherit from `BaseTest` to avoid duplicated setup code.

Example:

```csharp
public class RibbonTabsTest : BaseTest
{
    [Test]
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
}
```

---

# Running Tests

## Run All Tests

### Visual Studio

1. Open the solution.
2. Open **Test Explorer**.
3. Select **Run All Tests**.

### Command Line

```bash
dotnet test
```

---

## Run Selected Tests

Using Visual Studio:

1. Open **Test Explorer**.
2. Select a test class or test method.
3. Choose **Run**.

Using CLI:

```bash
dotnet test --filter RibbonTabsTest
```

---

# Test Pattern

All tests follow the Arrange-Act-Assert pattern.

Example:

```csharp
[Test]
public void Ribbon_WhenFileButtonInvoked_OpensBackstage()
{
    // Arrange
    Button backstage = UiLocator.FindButtonByName(Window, "c1BackstageView1");

    // Act
    backstage.Patterns.Invoke.Pattern.Invoke();

    // Assert
    MenuItem newCommand = UiLocator.FindMenuItemByName(Window, "New");
    Assert.That(newCommand.IsEnabled, Is.True);
}
```

## Arrange

Prepare required UI elements and test data.

## Act

Perform the user interaction.

## Assert

Verify the expected application state.

---

# NUnit Attributes

| Attribute           | Purpose                    |
| ------------------- | -------------------------- |
| `[Test]`            | Defines a test method      |
| `[TestFixture]`     | Defines a test class       |
| `[SetUp]`           | Runs before each test      |
| `[TearDown]`        | Runs after each test       |
| `[OneTimeSetUp]`    | Runs once before all tests |
| `[OneTimeTearDown]` | Runs once after all tests  |

---

# Test Naming Convention

Tests follow the pattern:

```
<Component>_<Condition>_<ExpectedResult>
```

Example:

```csharp
Ribbon_WhenFileButtonInvoked_OpensBackstage()
```

This describes:

| Part            | Meaning              |
| --------------- | -------------------- |
| Component       | UI area being tested |
| Condition       | Action or scenario   |
| Expected Result | Required outcome     |

---

# Best Practices

When adding new tests:

1. Keep tests independent.
2. Avoid relying on execution order.
3. Use `UiLocator` for locating elements.
4. Use `UiWaiter` instead of fixed delays.
5. Verify observable behavior.
6. Keep assertions clear and meaningful.
7. Use descriptive test names.

---

# Common Assertions

Examples:

```csharp
Assert.That(value, Is.EqualTo(expected));

Assert.That(condition, Is.True);

Assert.That(collection, Does.Contain(item));

Assert.That(element, Is.Not.Null);
```

---

# Troubleshooting

| Issue                      | Solution                                    |
| -------------------------- | ------------------------------------------- |
| Application not found      | Ensure WordPad is built successfully        |
| UI element cannot be found | Verify AutomationId, Name, or ControlType   |
| Tests are flaky            | Add proper wait conditions using `UiWaiter` |
| Tests timeout              | Increase timeout values for slow operations |
| Application remains open   | Verify teardown logic executes              |

---

# Test Development Guidelines

When adding new automation coverage:

1. Create a new test class under `Tests`.
2. Inherit from `BaseTest`.
3. Use `UiLocator` for element discovery.
4. Use `UiWaiter` for asynchronous operations.
5. Follow existing naming conventions.
6. Document complex automation scenarios.

---

# Related Documentation

* Root project:
  `../README.md`

* Application lifecycle:
  `../MainApplication/README.md`
