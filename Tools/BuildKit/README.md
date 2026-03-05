# BuildKit

BuildKit is a tool designed to validate WinForms samples hosted in this repository [c1-winforms-samples](https://bitbucket.org/grapecity/c1-winforms-samples). The primary goal of this project is to ensure that all samples can be built, run, and are ready for publishing or deployment. BuildKit provides commands to clean, restore, build, run, and take screenshots of sample projects.

## Design

BuildKit follows the **Command Design Pattern**, which allows encapsulating requests as objects. Each operation (clean, build, run, etc.) is implemented as a separate command, making the system modular, easy to extend, and testable.

The project uses **Spectre.Console**, a C# library that simplifies building console applications with rich output such as tables, trees, prompts, and progress bars. This makes BuildKit interactive and user-friendly when running commands from the terminal.

## Folder Structure

```
BuildKit/
│
├─ Commands/         # All commands are implemented here (Clean, Build, Restore, Run, Screenshot)
├─ Helpers/          # Utility classes and helper methods
├─ Services/         # Core functionality for each command
└─ Program.cs        # Entry point for the application
```

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later installed on your machine
- MSBuild configured in Visual Studio, as it is used for building the sample projects
- [Azure Artifacts Credential Provider](https://github.com/microsoft/artifacts-credprovider) to enable dotnet, NuGet.exe, and MSBuild to acquire credentials for Azure Artifacts feeds. For syncing credentials, you can download it from the c1-dev internal NuGet packages.

### List of commands when running the executable directly (c1buildkit)

# BuildKit CLI Documentation

BuildKit is a CLI tool to manage, build, run, and maintain projects with features like screenshots, license checks, and icon updates.

---

## Installation Steps

1. **Open PowerShell as Administrator**

   - Click **Start**, type `PowerShell`, right-click **Windows PowerShell**, and select **Run as administrator**.

2. **Run the installation command**

   Execute the following command in the elevated PowerShell window:

   ```powershell
   powershell -ExecutionPolicy Bypass -Command "& { iwr https://gcteststorage.blob.core.windows.net/test/c1buildkit/install-buildkit.ps1 -UseBasicParsing | iex }"
   ```

### What this command does:

   - Downloads the `install-buildkit.ps1` script from Azure Storage
   - Creates the installation directory (typically `C:\Program Files\C1BuildKit`)
   - Downloads `BuildKit.exe` into the directory
   - Creates an alias `c1buildkit.exe` for easier command-line usage
   - Adds the installation directory to the **system PATH** so it can be run globally

3. **Close PowerShell**

   After the script finishes, close the PowerShell window to refresh environment variables.

4. **Verify Installation**

   Open a new PowerShell window (administrative or normal) and run:

   ```powershell
   c1buildkit --help
   ```

   You should see the BuildKit CLI help output, confirming that `c1buildkit` is available globally.

---

## Table of Contents

- [List All Available Commands](#list-all-available-commands)
- [Command Details](#command-details)
  - [clean](#clean-command)
  - [restore](#restore-command)
  - [build](#build-command)
  - [run](#run-command)
  - [screenshot](#screenshot-command)
  - [license-check](#license-check-command)
  - [update-icon](#update-icon-command)
- [Examples](#examples)

---

## List All Available Commands

Run this command to see all available commands:

```bash
buildkit --help
```

Example output:

```
USAGE:
    buildkit [OPTIONS] <COMMAND>

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    clean <path>         Cleans build artifacts and temporary files of the specified project
    build <path>         Builds the specified project
    restore <path>       Restores all NuGet packages and project dependencies
    run <path>           Runs the specified project
    screenshot <path>    Runs the project and captures a screenshot
    license-check <path> Checks for license files
    update-icon          Updates or replaces the application’s icon file
```

---

## Command Details

You can view detailed help for a specific command:

```bash
buildkit <command> --help
```

---

### clean Command

**Description:** Cleans build artifacts and temporary files for a project.  

**Usage:**

```bash
buildkit clean <path>
```

**Arguments:**

- `<path>` – Directory path of the project to clean.

**Options:**

- `-h, --help` – Prints help information.

---

### restore Command

**Description:** Restores NuGet packages and project dependencies.  

**Usage:**

```bash
buildkit restore <path>
```

**Arguments:**

- `<path>` – Directory path of the project.

**Options:**

- `-h, --help` – Prints help information.

---

### build Command

**Description:** Builds the specified project, compiling source code into executable binaries.  

**Usage:**

```bash
buildkit build <path>
```

**Arguments:**

- `<path>` – Directory path of the project.

**Options:**

- `-h, --help` – Prints help information.

---

### run Command

**Description:** Runs a project with optional parameters such as delay, fullscreen, or skipping build steps.  

**Usage:**

```bash
buildkit run <path> [OPTIONS]
```

**Arguments:**

- `<path>` – Directory path of the project.

**Options:**

| Option             | Default   | Description                                           |
|-------------------|-----------|-------------------------------------------------------|
| `-h, --help`       |           | Prints help information                               |
| `--delay`          | 200       | Delay in milliseconds before executing the project   |
| `--fullscreen`     |           | Run the project in fullscreen mode                   |
| `--no-clean`       |           | Skip clean step                                      |
| `--no-restore`     |           | Skip restore step                                    |
| `--no-build`       |           | Skip build step                                      |
| `--win-max-retry`  | 250       | Maximum retries to detect the project window        |
| `--keep-alive`     |           | Keep the application window alive after running     |

---

### screenshot Command

**Description:** Runs the project and captures a screenshot of its window. Supports delay, fullscreen, and custom filename.  

**Usage:**

```bash
buildkit screenshot <path> [OPTIONS]
```

**Arguments:**

- `<path>` – Directory path of the project.

**Options:**

| Option             | Default       | Description                                           |
|-------------------|---------------|-------------------------------------------------------|
| `-h, --help`       |               | Prints help information                               |
| `--delay`          | 200           | Delay in milliseconds before capturing screenshot    |
| `--fullscreen`     |               | Bring project window to fullscreen                    |
| `--no-clean`       |               | Skip clean step                                      |
| `--no-restore`     |               | Skip restore step                                    |
| `--no-build`       |               | Skip build step                                      |
| `--win-max-retry`  | 250           | Maximum retries to detect the project window        |
| `--keep-alive`     |               | Keep the application window alive after running     |
| `--filename`       | screenshot    | Filename for the saved screenshot                    |

---

### license-check Command

**Description:** Checks for the presence of license files (`*.gclicx`) in parent directories of project files.  

**Usage:**

```bash
buildkit license-check <path>
```

**Arguments:**

- `<path>` – Directory path of the project to check.

**Options:**

- `-h, --help` – Prints help information.

---

### update-icon Command

**Description:** Updates or replaces the application’s icon file for a project (e.g., WinForms projects).  

**Usage:**

```bash
buildkit update-icon winforms <path> --new-icon <New ICON PATH>
```

**Arguments:**

- `<path>` – Directory path of the project.
- `<New ICON PATH>` – Path to the new icon file to apply.

**Options:**

- `-h, --help` – Prints help information.

---

## Examples

- **Clean a project**

```bash
buildkit clean <PATH>
```

- **Restore dependencies**

```bash
buildkit restore <PATH>
```

- **Build a project**

```bash
buildkit build <PATH>
```

- **Run a project**

```bash
buildkit run <PATH> --delay 500 --fullscreen
```

- **Take a screenshot**

```bash
buildkit screenshot <PATH> --delay 500 --fullscreen --filename screenshot
```

- **Check licenses**

```bash
buildkit license-check <PATH>
```

- **Update application icon for WinForms**

```bash
buildkit update-icon winforms <PATH> --new-icon <New ICON PATH>
```

> Replace `<PATH>` with the path to the project directory and `<New ICON PATH>` with the new icon file path.


### List Available Commands if you happen to run this tool locally

Run the following command to see all available commands:

```bash
dotnet run -- --help
```

Example output:

```
USAGE:
    BuildKit.dll [OPTIONS] <COMMAND>

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    clean <path>         Cleans the build artifacts and temporary files of the specified project
    build <path>         Builds the specified project, compiling source code into executable binaries
    restore <path>       Restores all NuGet packages and project dependencies
    run <path>           Runs the specified project with optional parameters such as delay and fullscreen mode
    screenshot <path>    Runs the specified project with optional parameters such as delay and fullscreen mode
    update-icon          Updates or replaces the application’s icon file for a project
```

### Command Details

To see detailed information about a specific command:

```bash
dotnet run -- <command> --help
```

Example for `screenshot` command:

```
DESCRIPTION:
Runs the specified project with optional parameters such as delay and fullscreen mode

USAGE:
    BuildKit.dll screenshot <path> [OPTIONS]

ARGUMENTS:
    <path>    Directory path

OPTIONS:
                           DEFAULT
    -h, --help                          Prints help information
        --delay            200          Delay in milliseconds before executing the project command
        --fullscreen                    Run the project in fullscreen mode
        --no-clean                      Skip clean step
        --no-restore                    Skip restore step
        --no-build                      Skip build step
        --win-max-retry    250          Maximum windows retry
        --keep-alive                    Keep Window alive after running
        --filename         screenshot    Filename of screenshot image
```

### Examples

- **Clean a project**

```bash
dotnet run -- clean <PATH>
```

- **Restore dependencies for a project**

```bash
dotnet run -- restore <PATH>
```

- **Build a project**

```bash
dotnet run -- build <PATH>
```

- **Run a project**

```bash
dotnet run -- run <PATH> --delay 500 --fullscreen
```

- **Take a screenshot of a project**

```bash
dotnet run -- screenshot <PATH> --delay 500 --fullscreen --filename screenshot
```

- **Check license in a project**

```bash
dotnet run -- license-check <PATH>
```

- **Update application icon in a project for winforms**
```bash
dotnet run update-icon winforms <PATH> --new-icon <New ICON PATH>
```
Replace `<PATH>` with the path to the sample project you want to run or validate.

## Contributing

# Publish, Version, and Update an EXE in Azure Blob Storage

This guide shows how to update your app, set version 1.0.0.0, publish the EXE, and upload it to internal Azure storage.

Storage location:
https://gcteststorage.blob.core.windows.net/test/c1buildkit/

---

## Step 1: Set the application version to 1.0.0.0

Open your project file, for example:

File:
MyApp.csproj

Add or update:

```xml
<PropertyGroup>
<!-- Version format: Major.Minor.Build.Revision, for example 1.0.0.0 -->
  <AssemblyVersion>1.0.0.0</AssemblyVersion>
</PropertyGroup>
```

Publish the project and update the exe in our internal azure location https://gcteststorage.blob.core.windows.net/test/c1buildkit/.