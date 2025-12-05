
# RibbonUITest: C1Ribbon Control UI Automation Project

## Project Overview

This UI Automation Test Suite is designed to comprehensively validate the functionality of the **C1Ribbon** control within a **WinForms WordPad** application. The project leverages advanced UI testing techniques to ensure robust control interaction and validation.

## Key Technologies Used

- **Automation Framework**: Appium WebDriver
- **Test Framework**: xUnit
- **Target Application**: WinForms WordPad with C1Ribbon Control

## System Requirements

- **.NET 8.0 SDK**
- **Visual Studio 2022 or later**
- **Node.js v22.14.0** (for Appium)
- **Appium CLI v2.15.0**
- **WinAppDriver v1.3**

### Supported Platforms

- **Windows 10 or later (64-bit)**

## Installation Guide

Follow the steps below to set up the environment for running **RibbonUITest**:

### 1. Install Visual Studio

Ensure that **Visual Studio 2022 or later** is installed with the **.NET Desktop Development** workload.

### 2. Install .NET 8.0 SDK

Download and install the [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) if it is not already available on your machine.

To verify installation:

```bash
dotnet --version
```

### 3. Install Node.js

Appium CLI depends on Node.js. Download and install it from the [Node.js official website](https://nodejs.org/).

Verify installation:

```bash
node -v
npm -v
```

### 4. Install Appium CLI

Install Appium CLI globally using npm:

```bash
npm install -g appium
```

Verify Appium installation:

```bash
appium -v
```

### 5. Install WinAppDriver

1. Download the latest release from [WinAppDriver GitHub Releases](https://github.com/microsoft/WinAppDriver/releases).
2. Run the installer and complete the installation.
3. The default installation path is:

    ```bash
    C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe
    ```
4. Enable Developer Mode for the WinAppDriver

## Running the Tests

Follow these steps to run your automation tests:

1. **Clone the project repository** or download the “RibbonUITest” source.

2. **Open the solution** in Visual Studio.

3. **Build the solution** to restore all NuGet and project dependencies.

4. **Start the Appium server** in a **Command Prompt / PowerShell** window:

   - Open a **new Command Prompt** or **PowerShell** window.
   - Run the following command to start Appium on port `4723`:

     ```bash
     appium -p 4723
     ```

   This will start the Appium server, which is responsible for driving the UI tests. Leave this window open as the Appium server needs to run during test execution.

5. **Start WinAppDriver on a different port** (e.g., `4725`) in another **Command Prompt / PowerShell** window:

   - Open another Command Prompt or PowerShell window (different from the one used for Appium).
   - Run the following command to start WinAppDriver on port `4725`:

     ```bash
     "C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe" 4725
     ```

   This will start the WinAppDriver process, which communicates with the Windows UI for automation. Leave this window open as well.

   If WinAppDriver starts successfully, you will see output in the console.

6. **Run the Tests** in Visual Studio:

   1. Once Appium and WinAppDriver are both running, go back to **Visual Studio**.
   2. In Visual Studio, right-click on the test project in **Solution Explorer** and select **Run Tests**.
      - Alternatively, you can open the **Test Explorer** and click **Run All** to execute the tests.

   This will start running your UI automation tests on the **C1Ribbon** control in the **WinForms WordPad** application.
