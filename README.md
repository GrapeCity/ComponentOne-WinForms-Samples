# **1. ComponentOne WinForms Edition Samples [grapecity/c1-winforms-samples](https://bitbucket.org/grapecity/c1-winforms-samples)**

Project Overview and Structure

This repository contains the official sample applications for **ComponentOne WinForms Edition**. The samples demonstrate how to use various ComponentOne controls to build modern, responsive, and data focused Windows Forms applications.

The purpose of this repository is to help developers explore features, understand common usage patterns, and implement ComponentOne controls effectively within their own applications.

---

## **Key Features Demonstrated**

The sample projects highlight a broad range of ComponentOne features, including:

- Displaying and editing data through fast datagrids and input controls
- Data visualization using charts, reporting tools, and analytical components
- Application layout enhancements using docking, ribbon, and dashboard style UI components
- Extensive API usage and customization scenarios
- Support for both **.NET Framework** and **.NET Core** based WinForms applications

Each sample includes a dedicated **readme.md** that explains the purpose of the sample and provides usage guidance.

---

## **Repository Structure**

The repository is organized into multiple sub folders that group samples by platform and product area. The structure aligns with the ComponentOne documentation layout.

```
c1 winforms samples
│
├── Core                  [Contains all .NET Core and .NET Core WinForms samples]
│
├── NetFramework          [Contains all .NET Framework WinForms samples]
│
└── Brand                 [Contains region specific samples or branding variations]
```

### **Platforms**

- **Core folder**
    Includes WinForms samples built using .NET Core and .NET Core.
- **NetFramework folder**
    Includes samples targeting the .NET Framework platform.
- **Brand folder**
    Contains region based sample variations where applicable.

You can find the full list of sample categories and modules in the internal documentation:

[C1 WinForms Samples](https://grapecity.atlassian.net/wiki/spaces/C1/pages/4629725331)

---

## **External Dependencies**

The samples reference ComponentOne control packages, but these packages are not included inside the repository.

To run any sample, install the required NuGet packages from:

- [NuGet Gallery | Home](http://nuget.org/)
- [MESCIUS inc.](http://developer.mescius.com/componentone)
- [c1-dev](https://pkgs.dev.azure.com/dt4dev/C1/_packaging/c1-dev/nuget/v3/index.json)

Dependencies are automatically restored during build or restore operations.

> For initial setup for c1-dev packages, [refer this](https://grapecity.atlassian.net/wiki/spaces/~7120208c038e0589664757aeac2d4aa84e274b/pages/4380721298/Setup+Devs)
---

## **Building the Samples**

### **.NET Framework Samples**

- Require Visual Studio 2012 or later.

### **.NET Core Samples**

- Require Visual Studio 2019 or later.

### **Building with .NET CLI**

For .NET 6 or .NET Core samples, you can build and run from the terminal:

```shell
dotnet build
dotnet run
```

These commands restore dependencies, build the project, and run it.

---

## **Contribution and Pull Requests**

When creating a pull request for this repository, follow the official internal checklist and guidelines:

**PR Runbook:** [link here](https://grapecity.atlassian.net/wiki/spaces/C1/pages/4528668799)

Important requirements:

- Ensure changes align with repository structure and sample standards.
- Follow naming, formatting, and code quality rules described in the internal guidelines.
- Minimum of **two reviewer approvals** is required before merging any PR.
- Include a clear description of what the sample change adds or improves.