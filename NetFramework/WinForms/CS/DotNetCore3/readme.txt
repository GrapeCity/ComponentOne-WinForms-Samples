.NET Core 3.0 conversion
-----------------------------------------------------------------------------
Shows how the C1 controls can be used with .NET Core 3.0.

Description:

This sample aggregates several samples and can be launched either as the .NET Core 3.0 application 
or as .NET Framework 4.5.2 application.
By default the DotNetCore3.csproj is defined as a startup project and it launches the app as .NET Core 3.0 app.
You can change the startup project to WindowsFormsApp1.csproj and it will launch the app as .NET Framework 4.5.2 app.
After launching you can observe in Visual Studio's Modules window as an appropriate .NET Core 3.0 assemblies work for DotNetCore3 project and .NET Framework 4.5.2 assembles work for WindowsFormsApp1 project accordingly.

Prerequisits:

Install .NET Core 3.0 SDK from here: https://dotnet.microsoft.com/download/dotnet-core/3.0 before opening this solution.
Choose an appropriate platform to download installer - x64 if you have 64-bit version system and x86 if you have 32-bit system.

The solution structure:

- DotNetCore3.csproj is a project for .NET Core 3.0. 
- WindowsFormsApp1.csproj is a project for .NET Framework 4.5.2. Also WindowsFormsApp1 project contains main form Form1.* that can be edited in Visual Studio designer (note .NET Core 3.0 has no appropriate design-time yet). This main form is linked from the DotNetCore3.csproj and used as main form also.