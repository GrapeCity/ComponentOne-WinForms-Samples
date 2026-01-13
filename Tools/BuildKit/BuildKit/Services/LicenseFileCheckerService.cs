// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Models;
using Spectre.Console;

namespace BuildKit.Services
{
    public class LicenseFileCheckerService
    {
        /// <summary>
        /// Checks each provided project path for a license file (*.gclicx) 
        /// in its parent directory and prints a table showing the status.
        /// </summary>
        public void CheckLicenseFiles(List<FileMeta> csProjPaths)
        {
            // Create a Spectre.Console table
            var table = new Table();
            table.Border = TableBorder.Rounded;
            table.AddColumn("Parent Directory");
            table.AddColumn("License Status");

            foreach (var csproj in csProjPaths)
            {
                string parentPath = csproj.ParentPath ?? "Not Found";
                string licenseStatus;

                if (string.IsNullOrWhiteSpace(csproj.ParentPath))
                {
                    licenseStatus = "[red]Parent directory not found[/]";
                }
                else
                {
                    var parentDir = new DirectoryInfo(csproj.ParentPath);
                    if (!parentDir.Exists)
                    {
                        licenseStatus = "[red]Directory does not exist[/]";
                    }
                    else
                    {
                        var licenseFile = parentDir.GetFiles("*.gclicx").FirstOrDefault();
                        licenseStatus = licenseFile != null
                            ? $"[green]Found: {licenseFile.Name}[/]"
                            : "[yellow]Not Found[/]";
                    }
                }

                table.AddRow(parentPath, licenseStatus);
            }

            // Render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
